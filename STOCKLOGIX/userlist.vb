Imports MySql.Data.MySqlClient
Public Class userlist
    Public Sub New()
        MyBase.New()
        InitializeComponent()
        Me.DoubleBuffered = True
    End Sub
    Public Sub RefreshDataGridView()
        connect()

        ds = New DataSet
        da = New MySqlDataAdapter("Select eID,fullname,username,password,email,address,number,type from tbl_employee where active = 1", sqlconn)
        da.Fill(ds, "tbl_employee")
        DataGridView1.DataSource = ds.Tables("tbl_employee")

        DataGridView1.RowTemplate.Height = 100
        DataGridView1.Columns(0).HeaderText = "ID"
        DataGridView1.Columns(1).HeaderText = "NAME"
        DataGridView1.Columns(2).HeaderText = "USERNAME"
        DataGridView1.Columns(3).HeaderText = "PASSWORD"
        DataGridView1.Columns(4).HeaderText = "EMAIL"
        DataGridView1.Columns(5).HeaderText = "ADDRESS"
        DataGridView1.Columns(6).HeaderText = "NUMBER"
        DataGridView1.Columns(7).HeaderText = "TYPE"

        DataGridView1.Columns("eID").DefaultCellStyle.WrapMode = DataGridViewTriState.True
        DataGridView1.Columns("fullname").DefaultCellStyle.WrapMode = DataGridViewTriState.True
        DataGridView1.Columns("username").DefaultCellStyle.WrapMode = DataGridViewTriState.True
        DataGridView1.Columns("password").DefaultCellStyle.WrapMode = DataGridViewTriState.True
        DataGridView1.Columns("email").DefaultCellStyle.WrapMode = DataGridViewTriState.True
        DataGridView1.Columns("address").DefaultCellStyle.WrapMode = DataGridViewTriState.True
        DataGridView1.Columns("number").DefaultCellStyle.WrapMode = DataGridViewTriState.True
        DataGridView1.Columns("type").DefaultCellStyle.WrapMode = DataGridViewTriState.True


        disconnect_db()
    End Sub
    Public Sub RefreshDataGridView2()
        connect()

        ds = New DataSet
        da = New MySqlDataAdapter("Select eID,fullname,username,password,email,address,number,type from tbl_employee where active = 0", sqlconn)
        da.Fill(ds, "tbl_employee")
        DataGridView2.DataSource = ds.Tables("tbl_employee")
        DataGridView2.Columns("eID").Visible = False
        DataGridView2.Columns("password").Visible = False

        DataGridView2.RowTemplate.Height = 100

        DataGridView2.Columns(0).HeaderText = "ID"
        DataGridView2.Columns(1).HeaderText = "NAME"
        DataGridView2.Columns(2).HeaderText = "USERNAME"
        DataGridView2.Columns(3).HeaderText = "PASSWORD"
        DataGridView2.Columns(4).HeaderText = "EMAIL"
        DataGridView2.Columns(5).HeaderText = "ADDRESS"
        DataGridView2.Columns(6).HeaderText = "NUMBER"
        DataGridView2.Columns(7).HeaderText = "TYPE"

        ' Set the WrapMode property of a specific column to True

        DataGridView2.RowTemplate.Height = 100
        DataGridView2.Columns("eID").DefaultCellStyle.WrapMode = DataGridViewTriState.True
        DataGridView2.Columns("fullname").DefaultCellStyle.WrapMode = DataGridViewTriState.True
        DataGridView2.Columns("username").DefaultCellStyle.WrapMode = DataGridViewTriState.True
        DataGridView2.Columns("password").DefaultCellStyle.WrapMode = DataGridViewTriState.True
        DataGridView2.Columns("email").DefaultCellStyle.WrapMode = DataGridViewTriState.True
        DataGridView2.Columns("address").DefaultCellStyle.WrapMode = DataGridViewTriState.True
        DataGridView2.Columns("number").DefaultCellStyle.WrapMode = DataGridViewTriState.True
        DataGridView2.Columns("type").DefaultCellStyle.WrapMode = DataGridViewTriState.True

        disconnect_db()
    End Sub
    Private Sub userlist_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connect()

        da = New MySqlDataAdapter("SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'stocklogix' AND (TABLE_NAME LIKE '%tbl_employee%' OR TABLE_NAME LIKE '%tbl_admin%');", sqlconn)
        Dim dt As New DataTable
        Dim count As Integer
        dt.Clear()
        da.Fill(dt)
        cmb_list.Items.Clear()

        While count < dt.Rows.Count
            cmb_list.Items.Add(dt.Rows(count)(0).ToString)
            count = count + 1

        End While
        Dim label As String = lbl_id1.Text

        DataGridView2.Visible = False
        DataGridView3.Visible = False
        txt_search1.Visible = False
        txt_search2.Visible = False
        txt_search3.Visible = False
        btn_deactivate.Visible = False
        btn_refresh.Hide()
        btn_refresh2.Hide()
        btn_update.Hide()
        btn_restore.Hide()
        btn_back.Hide()
        btn_delete.Hide()
        Label1.Visible = False
        Me.DoubleBuffered = True
    End Sub

    Private Sub cmb_list_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmb_list.SelectionChangeCommitted
        connect()
        Dim selectedTable As String = cmb_list.SelectedItem.ToString()
        da = New MySqlDataAdapter("select * from " + selectedTable + " Where active = 1", sqlconn)
        Dim dt2 As New DataTable
        dt2.Clear()
        da.Fill(dt2)
        DataGridView1.DataSource = dt2

        'to hide button and textbox for search
        If selectedTable = ("tbl_admin") Then

            DataGridView1.Columns("active").Visible = False
            DataGridView1.Columns("password").Visible = False
            DataGridView1.Visible = True
            DataGridView2.Visible = False
            DataGridView3.Visible = False
            btn_deactivate.Visible = False
            btn_update.Visible = False
            btn_refresh.Visible = True
            btn_refresh2.Visible = False
            txt_search1.Visible = True
            txt_search2.Visible = False
            txt_search3.Visible = False
            btn_restore.Visible = False
            btn_back.Visible = False
            btn_delete.Visible = False
            Label1.Visible = True
            btn_back.Visible = True
            lbl_id.Text = 0


            DataGridView1.RowTemplate.Height = 100
            DataGridView1.Columns(0).HeaderText = "ID"
            DataGridView1.Columns(1).HeaderText = "NAME"
            DataGridView1.Columns(2).HeaderText = "USERNAME"
            DataGridView1.Columns(3).HeaderText = "PASSWORD"
            DataGridView1.Columns(4).HeaderText = "EMAIL"
            DataGridView1.Columns(5).HeaderText = "ADDRESS"
            DataGridView1.Columns(6).HeaderText = "NUMBER"
            DataGridView1.Columns(7).HeaderText = "TYPE"

            DataGridView1.Columns("aID").DefaultCellStyle.WrapMode = DataGridViewTriState.True
            DataGridView1.Columns("fullname").DefaultCellStyle.WrapMode = DataGridViewTriState.True
            DataGridView1.Columns("username").DefaultCellStyle.WrapMode = DataGridViewTriState.True
            DataGridView1.Columns("password").DefaultCellStyle.WrapMode = DataGridViewTriState.True
            DataGridView1.Columns("email").DefaultCellStyle.WrapMode = DataGridViewTriState.True
            DataGridView1.Columns("address").DefaultCellStyle.WrapMode = DataGridViewTriState.True
            DataGridView1.Columns("number").DefaultCellStyle.WrapMode = DataGridViewTriState.True
            DataGridView1.Columns("type").DefaultCellStyle.WrapMode = DataGridViewTriState.True

        ElseIf selectedTable = ("tbl_employee") Then

            DataGridView1.Columns("active").Visible = False
            DataGridView1.Columns("password").Visible = False
            DataGridView1.Visible = True
            DataGridView2.Visible = False
            DataGridView3.Visible = False
            btn_deactivate.Visible = True
            btn_update.Visible = True
            btn_refresh2.Visible = True
            btn_refresh.Visible = False
            txt_search2.Visible = True
            txt_search1.Visible = False
            txt_search3.Visible = False
            btn_restore.Visible = False
            btn_back.Visible = False
            btn_delete.Visible = False
            Label1.Visible = True
            btn_back.Visible = True
            lbl_id.Text = 0

            DataGridView1.RowTemplate.Height = 100
            DataGridView1.Columns(0).HeaderText = "ID"
            DataGridView1.Columns(1).HeaderText = "NAME"
            DataGridView1.Columns(2).HeaderText = "USERNAME"
            DataGridView1.Columns(3).HeaderText = "PASSWORD"
            DataGridView1.Columns(4).HeaderText = "EMAIL"
            DataGridView1.Columns(5).HeaderText = "ADDRESS"
            DataGridView1.Columns(6).HeaderText = "NUMBER"
            DataGridView1.Columns(7).HeaderText = "TYPE"

            DataGridView1.Columns("eID").DefaultCellStyle.WrapMode = DataGridViewTriState.True
            DataGridView1.Columns("fullname").DefaultCellStyle.WrapMode = DataGridViewTriState.True
            DataGridView1.Columns("username").DefaultCellStyle.WrapMode = DataGridViewTriState.True
            DataGridView1.Columns("password").DefaultCellStyle.WrapMode = DataGridViewTriState.True
            DataGridView1.Columns("email").DefaultCellStyle.WrapMode = DataGridViewTriState.True
            DataGridView1.Columns("address").DefaultCellStyle.WrapMode = DataGridViewTriState.True
            DataGridView1.Columns("number").DefaultCellStyle.WrapMode = DataGridViewTriState.True
            DataGridView1.Columns("type").DefaultCellStyle.WrapMode = DataGridViewTriState.True

        End If



    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        If lbl_id.Text = "HUE-EMP-000" Then
            MessageBox.Show("No data selected!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        If userUpdateForm.lbl_id.Text = "HUE-EMP-000" Then
            MessageBox.Show("No data selected!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        userUpdateForm.Show()
        updateProductForm.Close()
        updateSupplier.Close()
    End Sub


    Private Sub btn_refresh_Click(sender As Object, e As EventArgs) Handles btn_refresh.Click
        connect()
        ds = New DataSet
        da = New MySqlDataAdapter("Select fullname,username,password,email,address,number,type from tbl_admin where active = 1", sqlconn)
        da.Fill(ds, "tbl_admin")
        DataGridView1.DataSource = ds.Tables("tbl_admin")
        disconnect_db()
        txt_search1.ResetText()
    End Sub
    Private Sub btn_refresh2_Click(sender As Object, e As EventArgs) Handles btn_refresh2.Click
        connect()
        lbl_id1.Text = ""
        lbl_id.Text = 0
        ds = New DataSet
        da = New MySqlDataAdapter("Select fullname,username,password,email,address,number,type from tbl_employee where active= 1", sqlconn)
        da.Fill(ds, "tbl_employee")
        DataGridView1.DataSource = ds.Tables("tbl_employee")
        disconnect_db()
        txt_search2.ResetText()
    End Sub
    Private Sub txt_search1_TextChanged(sender As Object, e As EventArgs) Handles txt_search1.TextChanged
        connect()

        ds = New DataSet
        da = New MySqlDataAdapter("Select * from tbl_admin where username like @username order by username ASC", sqlconn)
        da.SelectCommand.Parameters.AddWithValue("@username", "%" & txt_search1.Text & "%")
        da.Fill(ds, "tbl_admin")
        DataGridView1.DataSource = ds.Tables("tbl_admin")

        disconnect_db()
    End Sub

    Private Sub txt_search2_TextChanged(sender As Object, e As EventArgs) Handles txt_search2.TextChanged
        connect()

        ds = New DataSet
        da = New MySqlDataAdapter("Select * from tbl_employee where active = 1 AND username like @username order by username ASC", sqlconn)
        da.SelectCommand.Parameters.AddWithValue("@username", "%" & txt_search2.Text & "%")
        da.Fill(ds, "tbl_employee")
        DataGridView1.DataSource = ds.Tables("tbl_employee")

        disconnect_db()
    End Sub

    Private Sub userlist_Click(sender As Object, e As EventArgs) Handles MyBase.Click
        lbl_id1.Text = ""
    End Sub

    Private Sub txt_search2_Click(sender As Object, e As EventArgs) Handles txt_search2.Click
        lbl_id1.Text = ""
    End Sub

    Private Sub cmb_list_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_list.SelectedIndexChanged
        lbl_id1.Text = ""
    End Sub

    Private Sub cmb_list_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmb_list.KeyPress
        e.Handled = True
    End Sub


    Private Sub btn_deactivate_Click(sender As Object, e As EventArgs) Handles btn_deactivate.Click
        If lbl_id.Text = "HUE_EMP-000" Then
            MessageBox.Show("No data selected!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim confirm = MsgBox("ARE YOU SURE YOU WANT TO DEACTIVATE USER? ", MessageBoxButtons.YesNo + MsgBoxStyle.Information)
        If confirm = MsgBoxResult.Yes Then
            connect()
            ds = New DataSet
            da = New MySqlDataAdapter("update tbl_employee set Active = 0 where eID = @eID", sqlconn)
            da.SelectCommand.Parameters.AddWithValue("eID", lbl_id.Text)
            da.Fill(ds, "tbl_employee")

            MsgBox("DEACTIVATION SUCCESSFUL")
            lbl_id.Text = 0
            RefreshDataGridView()
        Else

        End If
        disconnect_db()
    End Sub

    Private Sub btn_sDeactivate_Click(sender As Object, e As EventArgs) Handles btn_sDeactivate.Click
        DataGridView2.Visible = True
        RefreshDataGridView2()
        DataGridView3.Visible = False
        DataGridView1.Visible = False
        btn_deactivate.Visible = False
        btn_update.Visible = False
        btn_restore.Visible = True
        txt_search1.ResetText()
        txt_search2.ResetText()
        txt_search3.ResetText()
        txt_search3.Visible = True
        txt_search1.Visible = False
        txt_search2.Visible = False
        btn_back.Visible = True
        btn_delete.Visible = True

        cmb_list.Text = "   DEACTIVATED USER"
        lbl_id.Text = 0

        DataGridView2.RowTemplate.Height = 100

        DataGridView2.Columns("fullname").DefaultCellStyle.WrapMode = DataGridViewTriState.True
        DataGridView2.Columns("username").DefaultCellStyle.WrapMode = DataGridViewTriState.True
        DataGridView2.Columns("password").DefaultCellStyle.WrapMode = DataGridViewTriState.True
        DataGridView2.Columns("email").DefaultCellStyle.WrapMode = DataGridViewTriState.True
        DataGridView2.Columns("address").DefaultCellStyle.WrapMode = DataGridViewTriState.True
        DataGridView2.Columns("number").DefaultCellStyle.WrapMode = DataGridViewTriState.True
        DataGridView2.Columns("type").DefaultCellStyle.WrapMode = DataGridViewTriState.True
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Try
            lbl_id.Text = DataGridView1.SelectedRows(0).Cells("eID").Value.ToString
            userUpdateForm.lbl_id.Text = DataGridView1.SelectedRows(0).Cells("eID").Value.ToString
            userUpdateForm.txt_fName.Text = DataGridView1.SelectedRows(0).Cells("fullname").Value.ToString
            userUpdateForm.txt_uName.Text = DataGridView1.SelectedRows(0).Cells("username").Value.ToString
            userUpdateForm.txt_email.Text = DataGridView1.SelectedRows(0).Cells("email").Value.ToString
            userUpdateForm.txt_num.Text = DataGridView1.SelectedRows(0).Cells("number").Value.ToString
            userUpdateForm.txt_address.Text = DataGridView1.SelectedRows(0).Cells("address").Value.ToString
            lbl_id1.Text = DataGridView1.SelectedRows(0).Cells("eID").Value.ToString

        Catch ex As Exception

        End Try
    End Sub

    Private Sub DataGridView2_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellClick
        Try
            lbl_id.Text = DataGridView2.SelectedRows(0).Cells("eID").Value.ToString
        Catch

        End Try
    End Sub

    Private Sub btn_restore_Click(sender As Object, e As EventArgs) Handles btn_restore.Click
        If lbl_id.Text = "HUE-EMP-000" Then
            MessageBox.Show("No data selected!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim confirm = MsgBox("ARE YOU SURE YOU WANT TO ACTIVATE USER? ", MessageBoxButtons.YesNo + MsgBoxStyle.Information)
        If confirm = MsgBoxResult.Yes Then
            Try
                connect()
                Dim query = "UPDATE tbl_employee SET Active = 1 WHERE eID = @eID"
                Using cmd As New MySqlCommand(query, sqlconn)
                    cmd.Parameters.AddWithValue("@eID", lbl_id.Text)
                    Dim rowsAffected = cmd.ExecuteNonQuery()
                    If rowsAffected > 0 Then
                        MsgBox("User restored successfully.")
                        RefreshDataGridView2()

                        lbl_id.Text = 0

                    Else
                        MsgBox("User not found.", MessageBoxIcon.Warning)
                    End If
                End Using
            Catch ex As Exception
                MsgBox("Error restoring product: " & ex.Message, MessageBoxIcon.Error)
            Finally
                disconnect_db()
            End Try

        End If
    End Sub

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        btn_restore.Visible = False
        DataGridView1.Visible = False
        DataGridView3.Visible = True
        DataGridView2.Visible = False
        btn_back.Visible = False
        btn_deactivate.Visible = True
        btn_refresh.Visible = True
        btn_delete.Visible = False
        txt_search1.ResetText()
        txt_search2.ResetText()
        txt_search3.ResetText()
        txt_search1.Visible = False
        txt_search2.Visible = False
        txt_search3.Visible = False
        btn_deactivate.Visible = False
        btn_delete.Visible = False
        Label1.Visible = False
        lbl_id.Text = 0

        cmb_list.Text = "<==    SELECT USER  ==>"


    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        If lbl_id.Text = "HUE-EMP-000" Then
            MessageBox.Show("No data selected!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        Dim confirm = MsgBox("ARE YOU SURE YOU WANT TO PERMANENTLY DELETE USER? ", MessageBoxButtons.YesNo + MsgBoxStyle.Exclamation)
        If confirm = MsgBoxResult.Yes Then
            Try
                connect()
                Dim query = "DELETE FROM tbl_employee WHERE eID = @eID"
                Using cmd As New MySqlCommand(query, sqlconn)
                    cmd.Parameters.AddWithValue("@eID", lbl_id.Text)
                    Dim rowsAffected = cmd.ExecuteNonQuery()
                    If rowsAffected > 0 Then
                        MsgBox("User Deleted Successfully.")
                        RefreshDataGridView2()

                        lbl_id.Text = 0

                    Else
                        MsgBox("User not found.", MessageBoxIcon.Warning)
                    End If
                End Using
            Catch ex As Exception
                MsgBox("Error restoring product: " & ex.Message, MessageBoxIcon.Error)
            Finally
                disconnect_db()
            End Try
        End If
    End Sub

    Private Sub txt_search3_TextChanged(sender As Object, e As EventArgs) Handles txt_search3.TextChanged
        connect()

        ds = New DataSet
        da = New MySqlDataAdapter("Select * from tbl_employee where active = 0 AND username like @username order by username ASC", sqlconn)
        da.SelectCommand.Parameters.AddWithValue("@username", "%" & txt_search3.Text & "%")
        da.Fill(ds, "tbl_employee")
        DataGridView2.DataSource = ds.Tables("tbl_employee")
        disconnect_db()
    End Sub


End Class