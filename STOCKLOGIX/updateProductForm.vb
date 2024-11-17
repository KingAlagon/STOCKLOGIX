Imports MySql.Data.MySqlClient
Public Class updateProductForm
    Private Property MoveForm As Boolean
    Private Property Move_Form_MousePosition As Point
    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click

        'To make the user input in the textbox
        Dim pName As String = txt_pName.Text.Trim()
        'Dim cb_prodtype As String = cmb_type.SelectedValue?.ToString().Trim()
        'Dim cb_prodSupp As String = cmb_prodSupp.SelectedValue?.ToString().Trim()
        If String.IsNullOrEmpty(pName) Then 'OrElse String.IsNullOrEmpty(cb_prodtype) Then
            MessageBox.Show("Invalid Input. Please Select Items in Drop Down List")
            Return
        End If
        Dim confirm = MsgBox("ARE YOU SURE YOU WANT TO UPDATE PRODUCT? ", MessageBoxButtons.YesNo + MsgBoxStyle.Information)
        If confirm = MsgBoxResult.Yes Then
            Try

                connect()
                ' Check if the product already exists
                Dim cmd As New MySqlCommand("SELECT COUNT(*) FROM tbl_products WHERE product_name=@product_name AND product_type = @product_type AND product_supplier=@product_supplier", sqlconn)
                cmd.Parameters.AddWithValue("@product_name", txt_pName.Text)
                cmd.Parameters.AddWithValue("product_type", cmb_type.Text)
                cmd.Parameters.AddWithValue("@product_supplier", cmb_prodSupp.Text)

                Dim count As Integer = CInt(cmd.ExecuteScalar())

                If count > 0 Then
                    MessageBox.Show("Product with the same Name, Product Type, and Product Supplier already exists in the database!")

                    prodList.txt_search.ResetText()

                Else


                    ds = New DataSet
                    da = New MySqlDataAdapter("update tbl_products set product_name=@product_name,product_type=@product_type,product_supplier=@product_supplier where product_id=@product_id", sqlconn)
                    da.SelectCommand.Parameters.AddWithValue("@product_id", lbl_id.Text)
                    da.SelectCommand.Parameters.AddWithValue("@product_name", txt_pName.Text)
                    da.SelectCommand.Parameters.AddWithValue("@product_type", cmb_type.Text)
                    da.SelectCommand.Parameters.AddWithValue("@product_supplier", cmb_prodSupp.Text)
                    da.Fill(ds, "tbl_products")

                    'to refresh datagridview 
                    Dim frm1 As prodList = CType(Application.OpenForms("prodList"), prodList)
                    frm1.RefreshDataGridView()
                    MsgBox("Product Data Updated Successfully!")
                    prodList.txt_search.ResetText()
                    Me.Close()
                    disconnect_db()
                End If

            Catch ex As Exception

            End Try
        Else

        End If

    End Sub



    Private Sub updateProductForm_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load
        connect()

        da = New MySqlDataAdapter("SELECT DISTINCT supp_prod_type FROM tbl_supplier", sqlconn)
        Dim prod_type_tbl As New DataTable
        da.Fill(prod_type_tbl)

        For Each row As DataRow In prod_type_tbl.Rows
            cmb_type.Items.Add(row("supp_prod_type").ToString())
        Next

        da = New MySqlDataAdapter("SELECT DISTINCT supp_name FROM tbl_supplier", sqlconn)
        Dim prod_supp_tbl As New DataTable
        da.Fill(prod_supp_tbl)

        For Each row As DataRow In prod_supp_tbl.Rows
            cmb_prodSupp.Items.Add(row("supp_name").ToString())
        Next

        disconnect_db()

    End Sub
    Public Sub New()
        MyBase.New()
        InitializeComponent()
        Me.DoubleBuffered = True
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

    Private Sub cmb_prodSupp_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmb_prodSupp.KeyPress
        e.Handled = True
    End Sub

    Private Sub cmb_prodSupp_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_prodSupp.SelectedIndexChanged


        connect()
        da = New MySqlDataAdapter("SELECT DISTINCT supp_prod_type FROM tbl_supplier WHERE supp_name = @selectedSupplier", sqlconn)

        da.SelectCommand.Parameters.Clear() 'Clear parameters before adding new ones
        da.SelectCommand.Parameters.AddWithValue("@selectedSupplier", cmb_prodSupp.SelectedItem.ToString())
        Dim prodTypeTable As New DataTable()
        da.Fill(prodTypeTable)

        cmb_type.DataSource = prodTypeTable
        cmb_type.ValueMember = "supp_prod_type"
        cmb_type.DisplayMember = "supp_prod_type"
        disconnect_db()
    End Sub

    Private Sub cmb_type_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmb_type.KeyPress
        e.Handled = True
    End Sub
End Class