Imports MySql.Data.MySqlClient

Public Class adminlogin
    Private Property MoveForm As Boolean
    Private Property Move_Form_MousePosition As Point

    Public ds As New DataSet
    Public da As New MySqlDataAdapter
    Public sqlconn As New MySqlConnection
    Public dt As New DataTable
    Public loggedInUsername As String
    Public loggedInUserId As Integer
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
    Public adminLoginSuccessful As Boolean = False
    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click

        'To make the user input in the textbox
        Dim username As String = txt_aUser.Text.Trim()
        Dim password As String = txt_aPass.Text.Trim()
        If String.IsNullOrEmpty(username) OrElse String.IsNullOrEmpty(password) Then
            MessageBox.Show("Please fill empty text field.")
            Return
        End If

        'Check if the user has exceeded the maximum number of login attempts
        If loginAttempts >= 5 AndAlso DateTime.Now.Subtract(lastLoginAttemptTime).TotalSeconds < 30 Then
            MessageBox.Show("Too many failed login attempts. Please wait for 30 seconds before trying again.")
            txt_aPass.Text = ""
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

        Dim query As String = "SELECT aID, fullname, email FROM tbl_admin WHERE active = 1 AND username = @username AND password = @password"
        Dim cmd As New MySqlCommand(query, sqlconn)
        cmd.Parameters.AddWithValue("@username", username)
        cmd.Parameters.AddWithValue("@password", password)
        Using reader As MySqlDataReader = cmd.ExecuteReader()
            If reader.Read() Then
                ' Retrieve the user's information and store it in variables
                Dim userId As Integer = reader.GetInt32("aID")
                Dim fullName As String = reader.GetString("fullname")
                Dim email As String = reader.GetString("email")

                ' Close the reader and database connection
                reader.Close()
                disconnect_db()

                'to catch username input of the textbox
                loggedInUsername = txt_aUser.Text.Trim()

                ds = New DataSet
                da = New MySqlDataAdapter("insert into tbl_logs (username,type,date_time) values (@username,'ADMIN',@date_time)", sqlconn)
                da.SelectCommand.Parameters.AddWithValue("@username", txt_aUser.Text)
                da.SelectCommand.Parameters.AddWithValue("@date_time", d1.Text)
                da.Fill(ds, "tbl_logs")
                txt_aUser.Text = ""
                txt_aPass.Text = ""

                adminLoginSuccessful = True

                Dim mainForm As New menuLS(userId)
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
                txt_aPass.Text = ""
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
            If Not employeelogin.employeeLoginSuccessful Then
                MessageBox.Show("The admin login is now available. Please try logging in again.")
            End If
            btn_login.Enabled = True
            Else
                lbl_countdown.Text = "Remaining seconds: " & remainingSeconds.ToString()
        End If
    End Sub
    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        Application.Exit()
    End Sub

    Private Sub btn_minimize_Click(sender As Object, e As EventArgs) Handles btn_minimize.Click
        WindowState = FormWindowState.Minimized
    End Sub
    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        loginoption.Show()
        Me.Hide()
    End Sub
    Public Class DoubleBufferedTopPanel
        Inherits Panel

        Public Sub New()
            MyBase.New()
            Me.DoubleBuffered = True
        End Sub

    End Class

    Private Sub adminlogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim top_panel As New DoubleBufferedTopPanel()
        lbl_countdown.Visible = False
        d1.Format = DateTimePickerFormat.Custom
        d1.CustomFormat = "yyyy-MM-dd || hh:mm:ss"
        btn_login.Visible = False

    End Sub

    Public Sub New()
        MyBase.New()
        InitializeComponent()
        Me.DoubleBuffered = True
    End Sub

    Private Sub txt_aUser_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_aUser.KeyDown
        'code for enter 

        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True ' Suppress the Enter key press to prevent new line
            btn_login_Click(sender, e) ' Call the login button click event
        End If
    End Sub

    Private Sub txt_aPass_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_aPass.KeyDown
        'code for enter 

        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True ' Suppress the Enter key press to prevent new line
            btn_login_Click(sender, e) ' Call the login button click event
        End If
    End Sub

    Private Sub txt_aPass_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_aPass.KeyPress
        btn_login.Visible = True
    End Sub

    Private Sub txt_aPass_TextChanged(sender As Object, e As EventArgs) Handles txt_aPass.TextChanged
        If Not String.IsNullOrEmpty(txt_aPass.Text) Then
            btn_login.Visible = True
        Else
            btn_login.Visible = False
        End If
    End Sub

    Private Sub btn_show_Click(sender As Object, e As EventArgs) Handles btn_show.Click
        If txt_aPass.PasswordChar = "*" Then
            btn_show.IconChar = FontAwesome.Sharp.IconChar.Eye
            ' Show password characters
            txt_aPass.PasswordChar = ""

        Else
            ' Hide password characters
            btn_show.IconChar = FontAwesome.Sharp.IconChar.EyeSlash
            txt_aPass.PasswordChar = "*"

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