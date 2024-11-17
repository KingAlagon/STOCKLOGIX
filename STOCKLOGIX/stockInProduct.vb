Imports MySql.Data.MySqlClient
Public Class stockInProduct
    Private Property MoveForm As Boolean
    Private Property Move_Form_MousePosition As Point

    Private Sub txt_suppPrice_Click(sender As Object, e As EventArgs) Handles btn_suppPrice.Click
        txt_sPrice.Enabled = True
    End Sub

    Private Sub btn_qty_Click(sender As Object, e As EventArgs) Handles btn_qty.Click
        txt_qty.Enabled = True
    End Sub

    Private Sub btn_price_Click(sender As Object, e As EventArgs) Handles btn_price.Click
        txt_price.Enabled = True
    End Sub

    Private Sub btn_sIN_Click(sender As Object, e As EventArgs) Handles btn_sIN.Click
        'To make the user input in the textbox
        Dim suppprice As String = txt_sPrice.Text.Trim()
        Dim qty As String = txt_qty.Text.Trim()
        Dim price As String = txt_price.Text.Trim()
        If String.IsNullOrEmpty(suppprice) OrElse String.IsNullOrEmpty(qty) OrElse String.IsNullOrEmpty(price) Then
            MessageBox.Show("Please Input Supplier Price, Product Price, and Quantity.")
            Return
        End If

        If suppprice = "0" OrElse qty = "0" OrElse price = "0" Then
            MessageBox.Show("Supplier Price,Product Price, and Quantity cannot be zero.")
            Return
        End If

        Dim confirm = MsgBox("ARE YOU SURE YOU WANT TO STOCK IN DATA? ", MessageBoxButtons.YesNo + MsgBoxStyle.Information)
        If confirm = MsgBoxResult.Yes Then
            Try

                connect()
                ' Check if the product already exists
                Dim cmd As New MySqlCommand("SELECT COUNT(*) FROM tbl_stocks WHERE ProductName=@ProductName AND SupplierName=@SupplierName", sqlconn)
                cmd.Parameters.AddWithValue("@ProductName", lbl_pname.Text)
                cmd.Parameters.AddWithValue("@SupplierName", lbl_sname.Text)
                Dim count As Integer = CInt(cmd.ExecuteScalar())
                If count > 0 Then
                    MessageBox.Show("Stocks with the same Product Name and Supplier Name already exists in the database!")
                    txt_price.Text = ""
                    txt_qty.Text = ""
                    txt_sPrice.Text = ""
                Else

                    Dim insertCmd As New MySqlCommand("Insert into tbl_stocks(ProductName,ProductID,Quantity,ProductPrice,SupplierPrice,SupplierName,ProductType,Active) values (@ProductName,@ProductID,@Quantity,@ProductPrice,@SupplierPrice,@SupplierName,@ProductType,1)", sqlconn)
                    insertCmd.Parameters.AddWithValue("@ProductName", lbl_pname.Text)
                    insertCmd.Parameters.AddWithValue("@ProductID", lbl_pID.Text)
                    insertCmd.Parameters.AddWithValue("@Quantity", txt_qty.Text)
                    insertCmd.Parameters.AddWithValue("@ProductPrice", txt_price.Text)
                    insertCmd.Parameters.AddWithValue("@SupplierPrice", txt_sPrice.Text)
                    insertCmd.Parameters.AddWithValue("@SupplierName", lbl_sname.Text)
                    insertCmd.Parameters.AddWithValue("@ProductType", lbl_ptype.Text)
                    insertCmd.ExecuteNonQuery()
                    MsgBox("STOCK-IN SUCCESSFUL!")

                    Me.Close()
                End If
                disconnect_db()
            Catch ex As Exception
                MessageBox.Show("An error occurred: " & ex.Message)
            End Try
        Else

        End If

    End Sub

    Private Sub txt_sName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_sPrice.KeyPress
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

    Private Sub txt_price_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_price.KeyPress
        If Asc(e.KeyChar) <> 8 AndAlso Asc(e.KeyChar) <> 13 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                MessageBox.Show("PLEASE ENTER NUMBER ONLY!")
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub stockInProduct_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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

    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        Me.Close()
    End Sub

    Private Sub btn_minimize_Click(sender As Object, e As EventArgs) Handles btn_minimize.Click
        WindowState = FormWindowState.Minimized
    End Sub
End Class