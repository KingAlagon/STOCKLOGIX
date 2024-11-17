Imports MySql.Data.MySqlClient


Public Class addProduct

    Private Sub addProduct_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connect()

        'combo box code
        da = New MySqlDataAdapter("Select supp_name from tbl_supplier WHERE active = 1 group by supp_name HAVING COUNT(supp_name) > 0", sqlconn)
        Dim prod_supp_tbl As New DataTable()
        da.Fill(prod_supp_tbl)
        cmb_prodSupp.DataSource = prod_supp_tbl
        cmb_prodSupp.ValueMember = "supp_name"
        cmb_prodSupp.DisplayMember = "supp_name"
        cmb_prodSupp.Text = ""

        btn_prodAdd.Visible = False
        disconnect_db()
    End Sub

    Private Sub btn_prodAdd_Click(sender As Object, e As EventArgs) Handles btn_prodAdd.Click
        'To make the user input in the textbox
        Dim pName As String = txt_pName.Text.Trim()
        Dim cb_prodSupp As String = cmb_prodSupp.SelectedValue?.ToString().Trim()
        Dim cb_prodType As String = cmb_prodtype.SelectedValue?.ToString().Trim()
        Dim cbpSupp As String = cmb_prodSupp.Text.Trim
        Dim addproductform As New addProduct

        If String.IsNullOrEmpty(pName) OrElse String.IsNullOrEmpty(cb_prodSupp) OrElse String.IsNullOrEmpty(cb_prodType) OrElse String.IsNullOrEmpty(cbpSupp) Then
            MessageBox.Show("Supplier or Product is not Recognised. Please Register Supplier First")

            txt_pName.Text = ""
            cmb_prodSupp.Text = ""
            cmb_prodtype.Text = ""
            btn_prodAdd.Visible = False

            Return
        End If


        Dim confirm = MsgBox("ARE YOU SURE YOU WANT TO ADD PRODUCT? ", MessageBoxButtons.YesNo + MsgBoxStyle.Information)
        If confirm = MsgBoxResult.Yes Then

            Try
                connect()

                ' Check if the product already exists
                Dim cmd As New MySqlCommand("SELECT COUNT(*) FROM tbl_products WHERE product_name=@product_name AND product_type = @product_type AND product_supplier=@product_supplier", sqlconn)
                cmd.Parameters.AddWithValue("@product_name", txt_pName.Text)
                cmd.Parameters.AddWithValue("product_type", cmb_prodtype.Text)
                cmd.Parameters.AddWithValue("@product_supplier", cmb_prodSupp.Text)

                Dim count As Integer = CInt(cmd.ExecuteScalar())

                If count > 0 Then
                    MessageBox.Show("Product with the same Name, Product Type, and Product Supplier already exists in the database!")
                    txt_pName.Text = ""
                    cmb_prodSupp.Text = ""
                    cmb_prodtype.Text = ""
                    btn_prodAdd.Visible = False

                Else
                    ' Add the new product
                    ' Generate the new supp_id value
                    Dim selectCmd As New MySqlCommand("SELECT MAX(CAST(SUBSTRING(product_id, 12) AS INT)) FROM tbl_products", sqlconn)
                    Dim maxId As Object = selectCmd.ExecuteScalar()

                    Dim newId As String = "HSLLS-PROD-" & If(maxId Is DBNull.Value, "001", (Convert.ToInt32(maxId) + 1).ToString("000"))

                    Dim insertCmd As New MySqlCommand("INSERT INTO tbl_products(product_id, product_name, product_type, product_supplier,active) VALUES (@product_id, @product_name, @product_type, @product_supplier,1)", sqlconn)
                    insertCmd.Parameters.AddWithValue("@product_id", newId)
                    insertCmd.Parameters.AddWithValue("@product_name", txt_pName.Text.ToUpper)
                    insertCmd.Parameters.AddWithValue("@product_type", cmb_prodtype.Text)
                    insertCmd.Parameters.AddWithValue("@product_supplier", cmb_prodSupp.Text)

                    insertCmd.ExecuteNonQuery()

                    MessageBox.Show("Product added successfully!")

                    txt_pName.Text = ""
                    cmb_prodSupp.Text = ""
                    cmb_prodtype.Text = ""
                    btn_prodAdd.Visible = False
                End If
                txt_pName.Text = ""
                cmb_prodtype.Text = ""
                cmb_prodSupp.Text = ""
                disconnect_db()

            Catch ex As Exception
                MessageBox.Show("An error occurred: " & ex.Message)
            End Try
        Else

        End If

    End Sub

    Public Sub New()
        MyBase.New()
        InitializeComponent()
        Me.DoubleBuffered = True
    End Sub

    Private Sub cmb_prodSupp_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmb_prodSupp.KeyPress
        e.Handled = True
    End Sub

    Private Sub cmb_prodSupp_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_prodSupp.SelectedIndexChanged

        connect()
        da = New MySqlDataAdapter("SELECT DISTINCT supp_prod_type FROM tbl_supplier WHERE active = 1 and supp_name = @selectedSupplier", sqlconn)
        da.SelectCommand.Parameters.AddWithValue("@selectedSupplier", cmb_prodSupp.SelectedValue.ToString())
        Dim prodTypeTable As New DataTable()
        da.Fill(prodTypeTable)

        cmb_prodtype.DataSource = prodTypeTable
        cmb_prodtype.ValueMember = "supp_prod_type"
        cmb_prodtype.DisplayMember = "supp_prod_type"
        btn_prodAdd.Visible = True
        disconnect_db()

    End Sub

    Private Sub cmb_prodtype_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmb_prodtype.KeyPress
        e.Handled = True
    End Sub


End Class