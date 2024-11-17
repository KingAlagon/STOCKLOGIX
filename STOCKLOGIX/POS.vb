Imports MySql.Data.MySqlClient
Public Class POS

    Public Sub RefreshDataGridView()
        connect()
        ds = New DataSet
        da = New MySqlDataAdapter("SELECT * from pos", sqlconn)
        da.Fill(ds, "pos")
        DataGridView1.DataSource = ds.Tables("pos")
        Me.DoubleBuffered = True
        DataGridView1.Columns(0).HeaderText = "SERIAL"
        DataGridView1.Columns(1).HeaderText = "MODEL NAME"
        DataGridView1.Columns(2).HeaderText = "DESCRIPTION"
        DataGridView1.Columns(3).HeaderText = "PRODUCT TYPE"
        DataGridView1.Columns(4).HeaderText = "QUANTITY"
        DataGridView1.Columns(5).HeaderText = "DATE OF PURCHASE"
        DataGridView1.Columns(6).HeaderText = "WARRANTY"
        DataGridView1.Columns(7).HeaderText = "SRP"


        DataGridView1.RowTemplate.Height = 100
        DataGridView1.Columns("serial").HeaderCell.Style.WrapMode = DataGridViewTriState.True
        DataGridView1.Columns("modelname").HeaderCell.Style.WrapMode = DataGridViewTriState.True
        DataGridView1.Columns("description").HeaderCell.Style.WrapMode = DataGridViewTriState.True
        DataGridView1.Columns("producttype").HeaderCell.Style.WrapMode = DataGridViewTriState.True
        DataGridView1.Columns("quantity").HeaderCell.Style.WrapMode = DataGridViewTriState.True
        DataGridView1.Columns("DOP").HeaderCell.Style.WrapMode = DataGridViewTriState.True
        DataGridView1.Columns("Warranty").HeaderCell.Style.WrapMode = DataGridViewTriState.True
        DataGridView1.Columns("srpprice").HeaderCell.Style.WrapMode = DataGridViewTriState.True

        DataGridView1.Columns("serial").DefaultCellStyle.WrapMode = DataGridViewTriState.True
        DataGridView1.Columns("modelname").DefaultCellStyle.WrapMode = DataGridViewTriState.True
        DataGridView1.Columns("description").DefaultCellStyle.WrapMode = DataGridViewTriState.True
        DataGridView1.Columns("producttype").DefaultCellStyle.WrapMode = DataGridViewTriState.True
        DataGridView1.Columns("quantity").DefaultCellStyle.WrapMode = DataGridViewTriState.True
        DataGridView1.Columns("DOP").DefaultCellStyle.WrapMode = DataGridViewTriState.True
        DataGridView1.Columns("Warranty").DefaultCellStyle.WrapMode = DataGridViewTriState.True
        DataGridView1.Columns("srpprice").DefaultCellStyle.WrapMode = DataGridViewTriState.True
        disconnect_db()
    End Sub
    Private Sub POS_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        RefreshDataGridView()

    End Sub
End Class