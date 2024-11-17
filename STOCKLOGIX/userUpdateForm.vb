Imports MySql.Data.MySqlClient
Imports System.Text.RegularExpressions
Public Class userUpdateForm
    Private Property MoveForm As Boolean
    Private Property Move_Form_MousePosition As Point

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        'To make the user input in the textbox
        Dim fname As String = txt_fName.Text.Trim()
        Dim uname As String = txt_uName.Text.Trim()

        Dim email As String = txt_email.Text.Trim()
        Dim num As String = txt_num.Text.Trim()
        Dim address As String = txt_address.Text.Trim()
        If String.IsNullOrEmpty(fname) OrElse String.IsNullOrEmpty(uname) OrElse String.IsNullOrEmpty(email) OrElse String.IsNullOrEmpty(num) OrElse String.IsNullOrEmpty(address) Then
            MessageBox.Show("Please Fill Empty Text Field.")
            Return
        End If
        Dim confirm = MsgBox("ARE YOU SURE YOU WANT TO UPDATE USER? ", MessageBoxButtons.YesNo + MsgBoxStyle.Information)

        If confirm = MsgBoxResult.Yes Then

            connect()
            ds = New DataSet
            da = New MySqlDataAdapter("update tbl_employee set fullname=@fullname,username=@username,email=@email,number=@number,address=@address where eID=@id", sqlconn)
            da.SelectCommand.Parameters.AddWithValue("@id", lbl_id.Text)
            da.SelectCommand.Parameters.AddWithValue("@fullname", txt_fName.Text)
            da.SelectCommand.Parameters.AddWithValue("@username", txt_uName.Text)

            da.SelectCommand.Parameters.AddWithValue("@email", txt_email.Text)
            da.SelectCommand.Parameters.AddWithValue("@number", txt_num.Text)
            da.SelectCommand.Parameters.AddWithValue("@address", txt_address.Text)

            da.Fill(ds, "tbl_employee")

            'to update the datagridview
            Dim frm1 As userlist = CType(Application.OpenForms("userlist"), userlist)
            frm1.RefreshDataGridView()
            'kulang pa need mag update si label after mag update data
            userlist.lbl_id1.Text = ""
            MsgBox("Update Sucessfull!")

        Else
            userlist.lbl_id1.Text = ""
            lbl_id.Text = ""
            txt_fName.Text = ""
            txt_uName.Text = ""
            txt_email.Text = ""
            txt_num.Text = ""
            txt_address.Text = ""
        End If
        userlist.lbl_id1.Text = ""
        Me.Close()
    End Sub
    Private Sub userUpdateFormvb_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Public Sub New()
        MyBase.New()
        InitializeComponent()
        Me.DoubleBuffered = True
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

    Private Sub btn_minimize_Click(sender As Object, e As EventArgs) Handles btn_minimize.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        Me.Close()
    End Sub

    Private Sub txt_num_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_num.KeyPress
        If Asc(e.KeyChar) <> 8 AndAlso Asc(e.KeyChar) <> 13 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                MessageBox.Show("PLEASE ENTER NUMBER ONLY!")
                e.Handled = True
            End If
        End If
    End Sub


End Class