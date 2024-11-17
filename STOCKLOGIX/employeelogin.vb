Imports MySql.Data.MySqlClient

Public Class employeelogin
    Public ds As New DataSet
    Public da As New MySqlDataAdapter
    Public sqlconn As New MySqlConnection
    Public dt As New DataTable
    Public loggedInUsername As String
    Public loggedInUserId As Integer
    Private Property MoveForm As Boolean
    Private Property Move_Form_MousePosition As Point
    Private Sub btn_minimize_Click(sender As Object, e As EventArgs) Handles btn_minimize.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        Application.Exit()
    End Sub
    Public Sub connect()
        If sqlconn.State = ConnectionState.Closed Then
            sqlconn = New MySqlConnection("server=localhost;userid=root;password=;database=stocklogix;")
            sqlconn.Open()

        End If
    End Sub
    Private loginAttempts As Integer = 0
    Private lastLoginAttemptTime As DateTime = DateTime.MinValue ' Variable to store the time of the last login attempt
    Private enableLoginButton As Action = Sub()
                                              btn_login.Enabled = True
                                          End Sub
    Private Sub disableLoginButton()
        btn_login.Enabled = False
    End Sub
    Public employeeLoginSuccessful As Boolean = False
    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click
        Dim username As String = txt_eUser.Text.Trim()
        Dim password As String = txt_ePass.Text.Trim()

        If String.IsNullOrEmpty(username) OrElse String.IsNullOrEmpty(password) Then
            MessageBox.Show("Please fill empty text field.")
            Return
        End If
        'Check if the user has exceeded the maximum number of login attempts
        If loginAttempts >= 5 AndAlso DateTime.Now.Subtract(lastLoginAttemptTime).TotalSeconds < 30 Then
            MessageBox.Show("Too many failed login attempts. Please wait for 30 seconds before trying again.")
            txt_ePass.Text = ""
            btn_login.Enabled = False
            lbl_countdown.Visible = True
            lbl_countdown.Text = "30"
            Timer2.Start()
            Return
        ElseIf loginAttempts >= 5 AndAlso DateTime.Now.Subtract(lastLoginAttemptTime).TotalSeconds >= 30 Then
            loginAttempts = 0
            btn_login.Enabled = True
            lbl_countdown.Visible = False
            Timer2.Stop()
        End If

        connect()

        Dim query As String = "SELECT eID, fullname, email FROM tbl_employee WHERE active = 1 AND username = @username AND password = @password"
        Dim cmd As New MySqlCommand(query, sqlconn)
        cmd.Parameters.AddWithValue("@username", username)
        cmd.Parameters.AddWithValue("@password", password)
        Using reader As MySqlDataReader = cmd.ExecuteReader()
            If reader.Read() Then
                ' Retrieve the user's information and store it in variables
                Dim userId As Integer = reader.GetInt32("eID")
                Dim fullName As String = reader.GetString("fullname")
                Dim email As String = reader.GetString("email")

                ' Close the reader and database connection
                reader.Close()
                disconnect_db()

                loggedInUsername = txt_eUser.Text.Trim()

                ' Insert the log in the database
                ds = New DataSet
                da = New MySqlDataAdapter("insert into tbl_logs (username,type,date_time) values (@username,'EMPLOYEE',@date_time)", sqlconn)
                da.SelectCommand.Parameters.AddWithValue("@username", txt_eUser.Text)
                da.SelectCommand.Parameters.AddWithValue("@date_time", DateTimePicker1.Text)
                da.Fill(ds, "tbl_logs")
                txt_eUser.Text = ""
                txt_ePass.Text = ""

                employeeLoginSuccessful = True

                Dim mainForm As New eMenuLS(userId)
                mainForm.Show()
            Else
                ' Increment login attempts and store the time of the last attempt
                loginAttempts += 1
                lastLoginAttemptTime = DateTime.Now

                ' If the query returns no rows, the user is not authenticated
                Dim attemptsLeft As Integer = 5 - loginAttempts
                If attemptsLeft > 0 Then
                    MessageBox.Show($"Invalid username or password. Please try again. {attemptsLeft} attempt(s) left.")
                Else
                    MessageBox.Show("Too many failed login attempts. Please wait for 30 seconds before trying again.")
                    btn_login.Enabled = False
                    lbl_countdown.Visible = True
                    lbl_countdown.Text = "30"
                    Timer2.Start()
                    Return
                End If
                txt_ePass.Text = ""
                DialogResult = DialogResult.None
                Exit Sub
            End If
        End Using
        Me.Hide()
    End Sub
    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Dim remainingSeconds As Integer = CInt(30 - DateTime.Now.Subtract(lastLoginAttemptTime).TotalSeconds)
        If remainingSeconds <= 0 Then
            Timer2.Stop()
            lbl_countdown.Visible = False
            If Not adminlogin.adminLoginSuccessful Then
                MessageBox.Show("The employee login is now available. Please try logging in again.")
            End If

            btn_login.Enabled = True
            Else
                lbl_countdown.Text = "Remaining seconds: " & remainingSeconds.ToString()
        End If
    End Sub
    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        loginoption.Show()
        Me.Hide()
    End Sub
    Private Sub employeelogin_load(sender As Object, e As EventArgs) Handles MyBase.Load

        DateTimePicker1.Format = DateTimePickerFormat.Custom
        lbl_countdown.Visible = False
        DateTimePicker1.CustomFormat = "yyyy-MM-dd || hh:mm:ss"
        btn_login.Visible = False
    End Sub
    Public Sub New()
        MyBase.New()
        InitializeComponent()
        Me.DoubleBuffered = True
    End Sub

    Private Sub txt_ePass_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_ePass.KeyDown
        'code for enter 

        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True ' Suppress the Enter key press to prevent new line
            btn_login_Click(sender, e) ' Call the login button click event
        End If
    End Sub

    Private Sub txt_eUser_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_eUser.KeyDown
        'code for enter 

        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True ' Suppress the Enter key press to prevent new line
            btn_login_Click(sender, e) ' Call the login button click event
        End If
    End Sub

    Private Sub txt_ePass_TextChanged(sender As Object, e As EventArgs) Handles txt_ePass.TextChanged
        If Not String.IsNullOrEmpty(txt_ePass.Text) Then
            btn_login.Visible = True
        Else
            btn_login.Visible = False
        End If
    End Sub

    Private Sub txt_ePass_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_ePass.KeyPress
        btn_login.Visible = True
    End Sub

    Private Sub btn_show_Click(sender As Object, e As EventArgs) Handles btn_show.Click
        If txt_ePass.PasswordChar = "*" Then
            btn_show.IconChar = FontAwesome.Sharp.IconChar.Eye
            ' Show password characters
            txt_ePass.PasswordChar = ""

        Else
            ' Hide password characters
            btn_show.IconChar = FontAwesome.Sharp.IconChar.EyeSlash
            txt_ePass.PasswordChar = "*"

        End If
    End Sub
    Private Sub top_panel_MouseDown(sender As Object, e As MouseEventArgs) Handles top_panel.MouseDown
        If e.Button = MouseButtons.Left Then
            MoveForm = True
            Me.Cursor = Cursors.Default
            Move_Form_MousePosition = e.Location
        End If
    End Sub

    Private Sub top_panel_MouseUp(sender As Object, e As MouseEventArgs) Handles top_panel.MouseUp
        If e.Button = MouseButtons.Left Then
            MoveForm = False
            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub top_panel_MouseMove(sender As Object, e As MouseEventArgs) Handles top_panel.MouseMove
        If MoveForm Then
            Me.Location = Me.Location + (e.Location - Move_Form_MousePosition)
        End If
    End Sub
End Class