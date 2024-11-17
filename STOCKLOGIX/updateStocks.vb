Imports MySql.Data.MySqlClient
Public Class updateStocks
    Private Property MoveForm As Boolean
    Private Property Move_Form_MousePosition As Point
    Private Sub btn_siN_Click(sender As Object, e As EventArgs) Handles btn_siN.Click
        Dim sPrice As String = txt_sPrice.Text.Trim()
        Dim qty As String = txt_qty.Text.Trim()
        Dim pPrice As String = txt_pPrice.Text.Trim()

        If String.IsNullOrEmpty(qty) OrElse String.IsNullOrEmpty(sPrice) OrElse String.IsNullOrEmpty(pPrice) Then
            MessageBox.Show("Please Fill Empty Text Field.")
            Return
        End If
        Dim confirm = MsgBox("ARE YOU SURE YOU WANT TO UPDATE STOCKS? ", MessageBoxButtons.YesNo + MsgBoxStyle.Information)
        If confirm = MsgBoxResult.Yes Then
            connect()
            ds = New DataSet
            da = New MySqlDataAdapter("update tbl_stocks set SupplierPrice = @SupplierPrice,ProductPrice=@ProductPrice,Quantity=@Quantity where StocksID = @id", sqlconn)
            da.SelectCommand.Parameters.AddWithValue("@id", lbl_sID.Text)
            da.SelectCommand.Parameters.AddWithValue("@SupplierPrice", txt_sPrice.Text)
            da.SelectCommand.Parameters.AddWithValue("@Quantity", txt_qty.Text)
            da.SelectCommand.Parameters.AddWithValue("@ProductPrice", txt_pPrice.Text)

            da.Fill(ds, "tbl_stocks")
            'to refresh datagrid
            Dim frm1 As stockList = CType(Application.OpenForms("stockList"), stockList)
            frm1.RefreshDataGridView()
            MsgBox("Supplier Data Updated Successfully!")
            Me.Close()
            disconnect_db()
        End If
    End Sub

    Private Sub btn_qty_Click(sender As Object, e As EventArgs) Handles btn_qty.Click
        txt_qty.Enabled = True
    End Sub
    Private Sub btn_sPrice_Click(sender As Object, e As EventArgs) Handles btn_sPrice.Click
        txt_sPrice.Enabled = True
    End Sub

    Private Sub btn_pPrice_Click(sender As Object, e As EventArgs) Handles btn_pPrice.Click
        txt_pPrice.Enabled = True
    End Sub


    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        Me.Close()
    End Sub

    Private Sub btn_minimize_Click(sender As Object, e As EventArgs) Handles btn_minimize.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub top_panel_MouseDown(sender As Object, e As MouseEventArgs) Handles top_panel.MouseDown
        If e.Button = MouseButtons.Left Then
            MoveForm = True
            Me.Cursor = Cursors.Default
            Move_Form_MousePosition = e.Location
        End If
    End Sub

    Private Sub top_panel_MouseMove(sender As Object, e As MouseEventArgs) Handles top_panel.MouseMove
        If MoveForm Then
            Me.Location = Me.Location + (e.Location - Move_Form_MousePosition)
        End If
    End Sub

    Private Sub top_panel_MouseUp(sender As Object, e As MouseEventArgs) Handles top_panel.MouseUp
        If e.Button = MouseButtons.Left Then
            MoveForm = False
            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub txt_sPrice_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_sPrice.KeyPress
        If Asc(e.KeyChar) <> 8 AndAlso Asc(e.KeyChar) <> 13 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                MessageBox.Show("PLEASE ENTER NUMBER ONLY!")
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txt_pPrice_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_pPrice.KeyPress
        If Asc(e.KeyChar) <> 8 AndAlso Asc(e.KeyChar) <> 13 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                MessageBox.Show("PLEASE ENTER NUMBER ONLY!")
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txt_qty_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_qty.KeyPress
        If Asc(e.KeyChar) <> 8 AndAlso Asc(e.KeyChar) <> 13 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                MessageBox.Show("PLEASE ENTER NUMBER ONLY!")
                e.Handled = True
            End If
        End If
    End Sub
End Class