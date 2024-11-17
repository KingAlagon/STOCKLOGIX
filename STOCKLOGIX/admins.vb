Imports MySql.Data.MySqlClient
Imports System.Text.RegularExpressions
Public Class admins
    Private Property MoveForm As Boolean
    Private Property Move_Form_MousePosition As Point
    Public loggedInUserId As Integer
    Public Shared Property loggedInUsername As String
    Private userId As Integer
    Public Sub New()
        MyBase.New()
        InitializeComponent()
        Me.DoubleBuffered = True
    End Sub
    Public Sub New(ByVal userId As Integer)
        ' This call is required by the designer.
        InitializeComponent()

        ' Store the user ID in a class-level variable for future use
        Me.userId = userId
    End Sub
    Private Function GetUserInformation(ByVal userId As Integer) As String
        Dim userInfo As String = ""
        connect()
        Dim cmd As MySqlCommand

        ' Query the database for the user's information based on their user ID
        Dim query As String = "SELECT fullname, username, password, email, address, number FROM tbl_admin WHERE aID = @userId"
        cmd = New MySqlCommand(query, sqlconn)
        cmd.Parameters.AddWithValue("@userId", userId)
        Dim reader As MySqlDataReader = cmd.ExecuteReader()

        ' Check if there is a result returned from the query
        If reader.Read() Then
            ' Concatenate the user's information into a single string
            userInfo = userId & "," & reader.GetString("fullname") & "," & reader.GetString("username") & "," & reader.GetString("password") & "," & reader.GetString("email") & "," & reader.GetString("address") & "," & reader.GetString("number")
        End If

        reader.Close()
        disconnect_db()

        Return userInfo
    End Function
    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        'To make the user input in the textbox
        Dim fname As String = txt_fname.Text.Trim()
        Dim username As String = txt_uname.Text.Trim()
        Dim password As String = txt_pass.Text.Trim()
        Dim email As String = txt_email.Text.Trim()
        Dim address As String = txt_address.Text.Trim()
        Dim number As String = txt_number.Text.Trim()
        If String.IsNullOrEmpty(fname) OrElse String.IsNullOrEmpty(username) OrElse String.IsNullOrEmpty(password) OrElse String.IsNullOrEmpty(email) OrElse String.IsNullOrEmpty(address) OrElse String.IsNullOrEmpty(number) Then
            MessageBox.Show("Please Fill Empty Text Field.")
            Return
        End If
        Dim confirm = MsgBox("ARE YOU SURE YOU WANT TO UPDATE YOUR INFORMATION? ", MessageBoxButtons.YesNo + MsgBoxStyle.Information)
        If confirm = MsgBoxResult.Yes Then

            connect()

            ds = New DataSet
            da = New MySqlDataAdapter("update tbl_admin set fullname=@fullname,username=@username,password=@password,email=@email,address=@address,number=@number where aID=@aID", sqlconn)
            da.SelectCommand.Parameters.AddWithValue("@aID", lbl_id.Text)
            da.SelectCommand.Parameters.AddWithValue("@fullname", txt_fname.Text.ToUpper)
            da.SelectCommand.Parameters.AddWithValue("@username", txt_uname.Text)
            da.SelectCommand.Parameters.AddWithValue("@password", txt_pass.Text)
            da.SelectCommand.Parameters.AddWithValue("@email", txt_email.Text)
            da.SelectCommand.Parameters.AddWithValue("@address", txt_address.Text.ToUpper)
            da.SelectCommand.Parameters.AddWithValue("@number", txt_number.Text)

            Dim newpassword As String = txt_pass.Text
            Dim regexPattern As String = "^(?=.*[A-Za-z])(?=.*\d)[A-Za-z\d]{8,}$"
            Dim regexMatch As Match = Regex.Match(newpassword, regexPattern)

            If Not regexMatch.Success Then
                MessageBox.Show("Password should be at least 8 characters long, with at least one number, one uppercase letter, and one lowercase letter")
                txt_pass.Text = ""
                Return
            End If
            da.Fill(ds, "tbl_admin")
            MsgBox("Admin Data Updated Successfully! ")

            Dim confirm1 = MsgBox("Do you want to logout to apply update? ", MessageBoxButtons.YesNo + MsgBoxStyle.Information)
            If confirm1 = MsgBoxResult.Yes Then
                Me.Close()
                Application.Restart()

            ElseIf confirm1 = MsgBoxResult.No Then
                Me.Close()

            End If
            employeelogin.loggedInUsername = txt_uname.Text



            Me.Close()
        End If
        disconnect_db()
    End Sub

    Private Sub admins_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connect()
        ' Retrieve the user's information from the database using the ID
        Dim userInfo As String = GetUserInformation(Me.userId)

        ' Fill in the textboxes with the user's information
        Dim userInfoArray As String() = userInfo.Split(",")
        If userInfoArray.Length >= 6 Then
            lbl_id.Text = userInfoArray(0)
            txt_fname.Text = userInfoArray(1)
            txt_uname.Text = userInfoArray(2)
            txt_pass.Text = userInfoArray(3)
            txt_email.Text = userInfoArray(4)
            txt_address.Text = userInfoArray(5)
            txt_number.Text = userInfoArray(6)
        End If

        disconnect_db()
    End Sub

    Private Sub btn_minimize_Click(sender As Object, e As EventArgs) Handles btn_minimize.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        Me.Close()
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

    Private Sub btn_show_Click(sender As Object, e As EventArgs) Handles btn_show.Click
        If txt_pass.PasswordChar = "*" Then
            btn_show.IconChar = FontAwesome.Sharp.IconChar.Eye
            ' Show password characters
            txt_pass.PasswordChar = ""

        Else
            ' Hide password characters
            btn_show.IconChar = FontAwesome.Sharp.IconChar.EyeSlash
            txt_pass.PasswordChar = "*"

        End If
    End Sub
End Class