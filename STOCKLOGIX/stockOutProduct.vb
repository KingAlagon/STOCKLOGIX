Imports MySql.Data.MySqlClient
Public Class stockOutProduct
    Private Property MoveForm As Boolean
    Private Property Move_Form_MousePosition As Point


    Private Sub btn_qty_Click(sender As Object, e As EventArgs) Handles btn_qty.Click
        txt_qty.Enabled = True
    End Sub



    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        Me.Close()
    End Sub

    Private Sub btn_minimize_Click(sender As Object, e As EventArgs) Handles btn_minimize.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btn_sOut_Click(sender As Object, e As EventArgs) Handles btn_sOut.Click

        Dim qty As String = txt_qty.Text.Trim()
        If String.IsNullOrEmpty(qty) Then
            MessageBox.Show("Please Fill Empty Text Field.")
            Return
        End If

        Dim stockID As String = CInt(lbl_sID.Text)
        Dim quantity As Integer = CInt(txt_qty.Text)


        connect()
        'begin a transaction to ensure data consistency
        Using transaction As MySqlTransaction = sqlconn.BeginTransaction()
            Try
                'lock the row for update to avoid race conditions
                Dim selectCommand As New MySqlCommand("SELECT Quantity FROM tbl_stocks WHERE StocksID = @StocksID FOR UPDATE", sqlconn, transaction)
                selectCommand.Parameters.AddWithValue("@StocksID", stockID)
                Dim currentQuantity As Integer = CInt(selectCommand.ExecuteScalar())
                'check if there's enough quantity to sell
                If currentQuantity >= quantity And quantity > 0 Then
                    'update the quantity
                    Dim updateCommand As New MySqlCommand("UPDATE tbl_stocks SET Quantity = Quantity - @quantity WHERE StocksID = @productId", sqlconn, transaction)
                    updateCommand.Parameters.AddWithValue("@quantity", quantity)
                    updateCommand.Parameters.AddWithValue("@productId", stockID)

                    updateCommand.ExecuteNonQuery()

                    'deactivate the item if the quantity is 0
                    Dim deactivateCommand As New MySqlCommand("UPDATE tbl_stocks SET active = @active WHERE StocksID = @productId AND Quantity = 0", sqlconn, transaction)
                    deactivateCommand.Parameters.AddWithValue("@active", 0)
                    deactivateCommand.Parameters.AddWithValue("@productId", stockID)

                    Dim rowsAffected As Integer = deactivateCommand.ExecuteNonQuery()

                    'commit the transaction
                    transaction.Commit()
                    Dim frm1 As stockList = CType(Application.OpenForms("stockList"), stockList)
                    frm1.RefreshDataGridView()
                    stockList.lbl_id.Text = 0
                    MessageBox.Show(quantity & " products have been stocked out.")
                Else
                    If quantity <= 0 Then
                        MessageBox.Show("Please enter a positive quantity!")
                    Else
                        MessageBox.Show("Not enough quantity to stock out!")
                    End If

                End If
            Catch ex As Exception
                'rollback the transaction in case of errors
                transaction.Rollback()
                MessageBox.Show("An error occurred: " & ex.Message)
            End Try
        End Using
        disconnect_db()
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

    Private Sub txt_qty_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_qty.KeyPress
        If Asc(e.KeyChar) <> 8 AndAlso Asc(e.KeyChar) <> 13 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                MessageBox.Show("PLEASE ENTER NUMBER ONLY!")
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txt_qty_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_qty.KeyDown
        'code for enter 

        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True ' Suppress the Enter key press to prevent new line
            btn_sOut_Click(sender, e) ' Call the button click event
        End If
    End Sub
End Class