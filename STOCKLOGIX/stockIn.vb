Imports MySql.Data.MySqlClient
Public Class stockIn
    Public Sub New()
        MyBase.New()
        InitializeComponent()
        Me.DoubleBuffered = True
    End Sub
    Public Sub RefreshDataGridView()
        connect()

        ds = New DataSet
        da = New MySqlDataAdapter("SELECT StocksID,ProductID,ProductName,SupplierName,ProductType,ProductPrice,Quantity,SupplierPrice from tbl_stocks where Active=1", sqlconn)
        da.Fill(ds, "tbl_stocks")
        DataGridView1.DataSource = ds.Tables("tbl_stocks")

        disconnect_db()
    End Sub
    Private Sub stockIn_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connect()
        RefreshDataGridView()
        disconnect_db()
    End Sub


    Private Sub btn_sIN_Click(sender As Object, e As EventArgs) Handles btn_sIN.Click
        If stockInProduct.lbl_pID.Text = 0 Then
            MessageBox.Show("No data selected!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        stockInProduct.Show()
        updateProductForm.Close()

    End Sub

    Private Sub DataGridView1_CellClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        lbl_id.Text = DataGridView1.SelectedRows(0).Cells("product_id").Value.ToString
        stockInProduct.lbl_pID.Text = DataGridView1.SelectedRows(0).Cells("product_id").Value.ToString
        stockInProduct.lbl_pname.Text = DataGridView1.SelectedRows(0).Cells("product_name").Value.ToString
        stockInProduct.lbl_ptype.Text = DataGridView1.SelectedRows(0).Cells("product_type").Value.ToString
        stockInProduct.lbl_sname.Text = DataGridView1.SelectedRows(0).Cells("product_supplier").Value.ToString

    End Sub
End Class