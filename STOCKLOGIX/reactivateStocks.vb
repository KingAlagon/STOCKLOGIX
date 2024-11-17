Imports MySql.Data.MySqlClient
Public Class reactivateStocks
    Private Property MoveForm As Boolean
    Private Property Move_Form_MousePosition As Point

    Private _stocksID As Integer

    Public Property StocksID As Integer
        Get
            Return _stocksID
        End Get
        Set(value As Integer)
            _stocksID = value
        End Set
    End Property


    Private Sub btn_restore_Click(sender As Object, e As EventArgs) Handles btn_restore.Click
        Dim qty As String = txt_qty.Text.Trim()
        If String.IsNullOrEmpty(qty) Then
            MessageBox.Show("Please Fill Empty Text Field.")
            Return
        End If
        Dim confirm = MsgBox("ARE YOU SURE YOU WANT TO ACTIVATE PRODUCT? ", MessageBoxButtons.YesNo + MsgBoxStyle.Information)
        If confirm = MsgBoxResult.Yes Then
            Try
                connect()
                Dim query = "UPDATE tbl_stocks SET Active = 1, Quantity = @Quantity WHERE StocksID = @StocksID"
                Using cmd As New MySqlCommand(query, sqlconn)
                    cmd.Parameters.AddWithValue("@StocksID", Me.StocksID)
                    If CInt(txt_qty.Text) <= 0 Then
                        MsgBox("Quantity should be greater than 0.", MessageBoxIcon.Warning)
                        txt_qty.Text = ""
                        txt_qty.Enabled = True

                        Exit Sub
                    End If
                    cmd.Parameters.AddWithValue("@Quantity", txt_qty.Text)
                    Dim rowsAffected = cmd.ExecuteNonQuery()
                    If rowsAffected > 0 Then
                        MsgBox("Product restored successfully.", MessageBoxIcon.Information)
                        'add code para mawala ang stockID to 0 after product successfull
                        stockList.lbl_id.Text = 0
                        Me.StocksID = 0
                        Me.Close()

                    Else
                        StocksID = 0
                        MsgBox("Product not found.", MessageBoxIcon.Warning)
                    End If
                End Using
            Catch ex As Exception
                MsgBox("Error restoring product: " & ex.Message, MessageBoxIcon.Error)
                Exit Sub ' Exit the event handler if an error occurs
            Finally
                disconnect_db()
            End Try

            Dim frm1 As stockList = CType(Application.OpenForms("stockList"), stockList)
            frm1.RefreshDataGridView2()
            Dim frm2 As stockList = CType(Application.OpenForms("stockList"), stockList)
            frm2.RefreshDataGridView3()
            Me.Close()
        End If


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

    Private Sub reactivateStocks_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click

        StocksID = 0

        Me.Close()
    End Sub

    Private Sub btn_minimize_Click(sender As Object, e As EventArgs) Handles btn_minimize.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btn_qty_Click(sender As Object, e As EventArgs) Handles btn_qty.Click
        txt_qty.Text = ""
        txt_qty.Enabled = True
    End Sub

    Private Sub txt_qty_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_qty.KeyDown
        'code for enter 

        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True ' Suppress the Enter key press to prevent new line
            btn_restore_Click(sender, e) ' Call the button click event
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

    Private Sub reactivateStocks_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Dim stockListForm As stockList = DirectCast(Application.OpenForms("stockList"), stockList)
        stockListForm.ResetSelectedStocksID()
    End Sub

End Class