Imports MySql.Data.MySqlClient
Imports System.Text.RegularExpressions


Public Class addUser
    Private Sub btn_eSignup_Click(sender As Object, e As EventArgs) Handles btn_eSignup.Click

        Dim fname As String = txt_fname.Text.Trim()
        Dim uname As String = txt_uname.Text.Trim()
        Dim pass As String = txt_password.Text.Trim()
        Dim email As String = txt_email.Text.Trim()
        Dim num As String = txt_number.Text.Trim()
        Dim address As String = txt_address.Text.Trim()

        If String.IsNullOrEmpty(fname) OrElse String.IsNullOrEmpty(uname) OrElse String.IsNullOrEmpty(pass) OrElse String.IsNullOrEmpty(email) OrElse String.IsNullOrEmpty(num) OrElse String.IsNullOrEmpty(address) Then
            MessageBox.Show("Please Fill Empty Text Field.")
            Return
        End If


        Dim confirm = MsgBox("ARE YOU SURE YOU WANT TO ADD USER? ", MessageBoxButtons.YesNo + MsgBoxStyle.Information)
        If confirm = MsgBoxResult.Yes Then
            Try
                connect()

                Dim selectedTable As String = cmb_type.SelectedItem.ToString()
                Dim cmd2 As New MySqlCommand("SELECT COUNT(*) FROM tbl_employee WHERE fullname=@fullname AND username = @username And type=@type", sqlconn)
                cmd2.Parameters.AddWithValue("@fullname", txt_fname.Text)
                cmd2.Parameters.AddWithValue("@username", txt_uname.Text)
                cmd2.Parameters.AddWithValue("@type", cmb_type.Text)
                Dim count2 As Integer = CInt(cmd2.ExecuteScalar())
                If count2 > 0 Then
                    MessageBox.Show("User with the same Name, Username and Type already exists in the database!")
                Else
                    selectedTable = "EMPLOYEE"
                    ' Generate the new employee ID value
                    Dim selectCmd As New MySqlCommand("SELECT MAX(CAST(SUBSTRING(eid, 9) AS INT)) FROM tbl_employee", sqlconn)
                    Dim maxId As Object = selectCmd.ExecuteScalar()

                    Dim newId As String = "HUE-EMP-" & If(maxId Is DBNull.Value, "001", (Convert.ToInt32(maxId) + 1).ToString("000"))

                    Dim insertCmd As New MySqlCommand("insert into tbl_employee(eID,fullname,username,password,email,address,number,type,active) values (@eid, @fullname,@username,@password,@email,@address,@number,@type,1)", sqlconn)
                    insertCmd.Parameters.AddWithValue("@eid", newId)
                    insertCmd.Parameters.AddWithValue("@fullname", txt_fname.Text)
                    insertCmd.Parameters.AddWithValue("@username", txt_uname.Text)
                    insertCmd.Parameters.AddWithValue("@password", txt_password.Text)
                    insertCmd.Parameters.AddWithValue("@email", txt_email.Text)
                    insertCmd.Parameters.AddWithValue("@address", txt_address.Text)
                    insertCmd.Parameters.AddWithValue("@number", txt_number.Text)
                    insertCmd.Parameters.AddWithValue("@type", cmb_type.Text)

                    Dim password As String = txt_password.Text
                    Dim regexPattern As String = "^(?=.*[A-Za-z])(?=.*\d)[A-Za-z\d]{8,}$"
                    Dim regexMatch As Match = Regex.Match(password, regexPattern)

                    If Not regexMatch.Success Then
                        MessageBox.Show("Password should be at least 8 characters long, with at least one number, one uppercase letter, and one lowercase letter")
                        txt_password.Text = ""
                        Return
                    End If

                    insertCmd.ExecuteNonQuery()


                    MsgBox("USER ADDED SUCCESSFULLY")
                End If
                txt_fname.Text = ""
                txt_uname.Text = ""
                txt_password.Text = ""
                txt_email.Text = ""
                txt_address.Text = ""
                txt_number.Text = ""


                disconnect_db()
            Catch ex As Exception
                MessageBox.Show("An error occurred: " & ex.Message)
            End Try
        Else


        End If
    End Sub
    Private Sub btn_aSignup_Click(sender As Object, e As EventArgs) Handles btn_aSignup.Click
        'To make the user input in the textbox
        Dim fname As String = txt_fname.Text.Trim()
        Dim uname As String = txt_uname.Text.Trim()
        Dim pass As String = txt_password.Text.Trim()
        Dim email As String = txt_email.Text.Trim()
        Dim num As String = txt_number.Text.Trim()
        Dim address As String = txt_address.Text.Trim()

        If String.IsNullOrEmpty(fname) OrElse String.IsNullOrEmpty(uname) OrElse String.IsNullOrEmpty(pass) OrElse String.IsNullOrEmpty(email) OrElse String.IsNullOrEmpty(num) OrElse String.IsNullOrEmpty(address) Then
            MessageBox.Show("Please Fill Empty Text Field.")
            Return
        End If

        Dim confirm = MsgBox("ARE YOU SURE YOU WANT TO ADD USER? ", MessageBoxButtons.YesNo + MsgBoxStyle.Information)
        If confirm = MsgBoxResult.Yes Then
            Try

                connect()
                Dim selectedTable As String = cmb_type.SelectedItem.ToString()
                Dim cmd As New MySqlCommand("SELECT COUNT(*) FROM tbl_admin WHERE fullname=@fullname AND username = @username And type=@type", sqlconn)

                cmd.Parameters.AddWithValue("@fullname", txt_fname.Text)
                cmd.Parameters.AddWithValue("@username", txt_uname.Text)
                cmd.Parameters.AddWithValue("@type", cmb_type.Text)
                Dim count As Integer = CInt(cmd.ExecuteScalar())
                If count > 0 Then
                    MessageBox.Show("User with the same Name, Username and Type already exists in the database!")
                Else
                    selectedTable = "ADMIN"
                    ' Generate the new employee ID value
                    Dim selectCmd As New MySqlCommand("SELECT MAX(CAST(SUBSTRING(aID, 9) AS INT)) FROM tbl_admin", sqlconn)
                    Dim maxId As Object = selectCmd.ExecuteScalar()

                    Dim newId As String = "HUE-ADM-" & If(maxId Is DBNull.Value, "001", (Convert.ToInt32(maxId) + 1).ToString("000"))
                    Dim insertCmd As New MySqlCommand("insert into tbl_admin(aID,fullname,username,password,email,address,number,type,active) values (@aID,@fullname,@username,@password,@email,@address,@number,@type,1)", sqlconn)
                    insertCmd.Parameters.AddWithValue("@aID", newId)
                    insertCmd.Parameters.AddWithValue("@fullname", txt_fname.Text)
                    insertCmd.Parameters.AddWithValue("@username", txt_uname.Text)
                    insertCmd.Parameters.AddWithValue("@password", txt_password.Text)
                    insertCmd.Parameters.AddWithValue("@email", txt_email.Text)
                    insertCmd.Parameters.AddWithValue("@address", txt_address.Text)
                    insertCmd.Parameters.AddWithValue("@number", txt_number.Text)
                    insertCmd.Parameters.AddWithValue("@type", cmb_type.Text)
                    Dim password As String = txt_password.Text
                    Dim regexPattern As String = "^(?=.*[A-Za-z])(?=.*\d)[A-Za-z\d]{8,}$"
                    Dim regexMatch As Match = Regex.Match(password, regexPattern)

                    If Not regexMatch.Success Then
                        MessageBox.Show("Password should be at least 8 characters long, with at least one number, one uppercase letter, and one lowercase letter")
                        txt_password.Text = ""
                        Return
                    End If
                    insertCmd.ExecuteNonQuery()
                    MsgBox("USER ADDED SUCCESSFULLY")
                End If
                txt_fname.Text = ""
                txt_uname.Text = ""
                txt_password.Text = ""
                txt_email.Text = ""
                txt_address.Text = ""
                txt_number.Text = ""

                disconnect_db()
            Catch ex As Exception
                MessageBox.Show("An error occurred: " & ex.Message)
            End Try
        Else

        End If
    End Sub

    Private Sub addUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btn_eSignup.Visible = False
        btn_aSignup.Visible = False
        cmb_type.Text = "<==     SELECT USER TYPE   ==>"

    End Sub
    Public Sub New()
        MyBase.New()
        InitializeComponent()
        Me.DoubleBuffered = True
    End Sub

    Private Sub cmb_type_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmb_type.KeyPress
        e.Handled = True
    End Sub

    Private Sub txt_number_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_number.KeyPress
        If Asc(e.KeyChar) <> 8 AndAlso Asc(e.KeyChar) <> 13 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                MessageBox.Show("PLEASE ENTER NUMBER ONLY!")
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub cmb_type_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmb_type.SelectionChangeCommitted
        Dim selectedTable As String = cmb_type.SelectedItem.ToString()
        If selectedTable = "ADMIN" Then
            btn_aSignup.Visible = True
            btn_eSignup.Visible = False
        ElseIf selectedTable = ("EMPLOYEE") Then
            btn_eSignup.Visible = True
            btn_aSignup.Visible = False
        End If
    End Sub

    Private Sub btn_show_Click(sender As Object, e As EventArgs) Handles btn_show.Click
        If txt_password.PasswordChar = "*" Then
            btn_show.IconChar = FontAwesome.Sharp.IconChar.Eye
            ' Show password characters
            txt_password.PasswordChar = ""

        Else
            ' Hide password characters
            btn_show.IconChar = FontAwesome.Sharp.IconChar.EyeSlash
            txt_password.PasswordChar = "*"

        End If
    End Sub
End Class