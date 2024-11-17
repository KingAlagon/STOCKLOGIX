Imports MySql.Data.MySqlClient

Public Class addSupplier

    Private Sub btn_addSupp_Click(sender As Object, e As EventArgs) Handles btn_addSupp.Click
        'To make the user input in the textbox
        Dim sName As String = txt_sName.Text.Trim()
        Dim saddress As String = txt_sAddress.Text.Trim()
        Dim sNumber As String = txt_sNumber.Text.Trim()
        Dim type As String = cmb_suppProdType.Text.Trim()
        If String.IsNullOrEmpty(sName) OrElse String.IsNullOrEmpty(saddress) OrElse String.IsNullOrEmpty(sNumber) OrElse String.IsNullOrEmpty(type) Then
            MessageBox.Show("Please Fill Empty Text Field.")
            Return
        End If

        Dim confirm = MsgBox("ARE YOU SURE YOU WANT TO ADD SUPPLIER? ", MessageBoxButtons.YesNo + MsgBoxStyle.Information)
        If confirm = MsgBoxResult.Yes Then
            Try
                connect()
                ' Check if the product already exists
                Dim cmd As New MySqlCommand("SELECT COUNT(*) FROM tbl_supplier WHERE supp_name=@supp_name AND supp_prod_type=@supp_prod_type", sqlconn)
                cmd.Parameters.AddWithValue("@supp_name", txt_sName.Text)
                cmd.Parameters.AddWithValue("@supp_prod_type", cmb_suppProdType.Text)
                Dim count As Integer = CInt(cmd.ExecuteScalar())
                If count > 0 Then
                    MessageBox.Show("Supplier with the same Name and Product Type already exists in the database!")
                    cmb_suppProdType.Text = ""
                Else
                    ' Add the new supplier
                    ' Generate the new supp_id value
                    Dim selectCmd As New MySqlCommand("SELECT MAX(CAST(SUBSTRING(supp_id, 12) AS INT)) FROM tbl_supplier", sqlconn)
                    Dim maxId As Object = selectCmd.ExecuteScalar()

                    Dim newId As String = "HSLLS-SUPP-" & If(maxId Is DBNull.Value, "001", (Convert.ToInt32(maxId) + 1).ToString("000"))

                    Dim insertCmd As New MySqlCommand("INSERT INTO tbl_supplier(supp_id, supp_name, supp_address, supp_number, supp_prod_type, active) VALUES(@supp_id, UPPER(@supp_name), UPPER(@supp_address), @supp_number, UPPER(@supp_prod_type), 1)", sqlconn)

                    insertCmd.Parameters.AddWithValue("@supp_id", newId)
                    insertCmd.Parameters.AddWithValue("@supp_name", txt_sName.Text.ToUpper())
                    insertCmd.Parameters.AddWithValue("@supp_address", txt_sAddress.Text.ToUpper())
                    insertCmd.Parameters.AddWithValue("@supp_number", txt_sNumber.Text)
                    insertCmd.Parameters.AddWithValue("@supp_prod_type", cmb_suppProdType.Text.ToUpper())

                    insertCmd.ExecuteNonQuery()
                    MsgBox("Supplier Data Added Successfully!")


                    txt_sName.Text = ""
                    txt_sAddress.Text = ""
                    txt_sNumber.Text = ""
                    cmb_suppProdType.Text = ""
                End If
                txt_sName.Text = ""
                txt_sAddress.Text = ""
                txt_sNumber.Text = ""
                cmb_suppProdType.Text = ""

                disconnect_db()

            Catch ex As Exception
                MessageBox.Show("An error occurred: " & ex.Message)
            End Try
        Else

        End If

    End Sub

    Private Sub addSupplier_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connect()
        da = New MySqlDataAdapter("Select supp_prod_type from tbl_supplier group by supp_prod_type HAVING COUNT(supp_prod_type) > 0", sqlconn)
        Dim supp_prodType As New DataTable
        da.Fill(supp_prodType)
        cmb_suppProdType.DataSource = supp_prodType
        cmb_suppProdType.ValueMember = "supp_prod_type"
        cmb_suppProdType.DisplayMember = "supp_prod_type"
        cmb_suppProdType.Text = ""
        disconnect_db()
    End Sub
    Public Sub New()
        MyBase.New()
        InitializeComponent()
        Me.DoubleBuffered = True
    End Sub

    Private Sub txt_sNumber_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_sNumber.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                MessageBox.Show("PLEASE ENTER NUMBER ONLY!")
                e.Handled = True
            End If
        End If
    End Sub

End Class