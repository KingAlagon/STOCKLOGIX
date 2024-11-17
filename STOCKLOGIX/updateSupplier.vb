Imports MySql.Data.MySqlClient

Public Class updateSupplier
    Private Property MoveForm As Boolean
    Private Property Move_Form_MousePosition As Point

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click

        'To make the user input in the textbox
        Dim sName As String = txt_sName.Text.Trim()
        Dim saddress As String = txt_sAddress.Text.Trim()
        Dim sNumber As String = txt_sNumber.Text.Trim()
        Dim type As String = cmb_prodType.Text.Trim()

        If String.IsNullOrEmpty(sName) OrElse String.IsNullOrEmpty(saddress) OrElse String.IsNullOrEmpty(sNumber) OrElse String.IsNullOrEmpty(type) Then
            MessageBox.Show("Please Fill Empty Text Field.")
            Return
        End If

        Dim confirm = MsgBox("ARE YOU SURE YOU WANT TO UPDATE SUPPLIER? ", MessageBoxButtons.YesNo + MsgBoxStyle.Information)
        If confirm = MsgBoxResult.Yes Then
            Try

                connect()
                ' Check if the product already exists
                Dim cmd As New MySqlCommand("SELECT COUNT(*) FROM tbl_supplier WHERE supp_name = @supp_name AND supp_address = @supp_address AND supp_number = @supp_number AND supp_prod_type=@supp_prod_type", sqlconn)
                cmd.Parameters.AddWithValue("@supp_name", txt_sName.Text)
                cmd.Parameters.AddWithValue("@supp_address", txt_sAddress.Text)
                cmd.Parameters.AddWithValue("@supp_number", txt_sNumber.Text)
                cmd.Parameters.AddWithValue("@supp_prod_type", cmb_prodType.Text)
                Dim count As Integer = CInt(cmd.ExecuteScalar())
                If count > 0 Then
                    MessageBox.Show("Supplier with the same Product Type already exists in the database!")
                    cmb_prodType.Text = ""

                Else

                    ds = New DataSet
                    da = New MySqlDataAdapter("update tbl_supplier set supp_name=@supp_name,supp_address=@supp_address,supp_number=@supp_number,supp_prod_type=@supp_prod_type where supp_id=@id", sqlconn)
                    da.SelectCommand.Parameters.AddWithValue("@id", lbl_id.Text.ToUpper)
                    da.SelectCommand.Parameters.AddWithValue("@supp_name", txt_sName.Text.ToUpper)
                    da.SelectCommand.Parameters.AddWithValue("@supp_address", txt_sAddress.Text.ToUpper)
                    da.SelectCommand.Parameters.AddWithValue("@supp_number", txt_sNumber.Text.ToUpper)
                    da.SelectCommand.Parameters.AddWithValue("@supp_prod_type", cmb_prodType.Text.ToUpper)
                    da.Fill(ds, "tbl_supplier")

                    'to refresh datagrid
                    Dim frm1 As supplierList = CType(Application.OpenForms("supplierList"), supplierList)
                    frm1.RefreshDataGridView()
                    MsgBox("Supplier Data Updated Successfully!")
                    Me.Close()
                End If

                disconnect_db()

            Catch ex As Exception

            End Try
        Else

        End If

    End Sub

    Private Sub updateSuppliervb_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        connect()

        da = New MySqlDataAdapter("Select supp_prod_type from tbl_supplier group by supp_prod_type HAVING COUNT(supp_prod_type) > 0", sqlconn)
        Dim supp_prodType As New DataTable
        da.Fill(supp_prodType)
        'loop for getting the value of the selected row in datagridview in supplierlist form.
        For Each row As DataRow In supp_prodType.Rows
            cmb_prodType.Items.Add(row("supp_prod_type").ToString())
        Next

        disconnect_db()
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

    Private Sub txt_sNumber_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_sNumber.KeyPress
        If Asc(e.KeyChar) <> 8 AndAlso Asc(e.KeyChar) <> 13 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                MessageBox.Show("PLEASE ENTER NUMBER ONLY!")
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub top_panel_Paint(sender As Object, e As PaintEventArgs) Handles top_panel.Paint

    End Sub
End Class