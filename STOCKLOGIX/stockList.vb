Imports MySql.Data.MySqlClient
Imports System.Drawing.Printing
Imports System.IO
Public Class stockList

    Public Sub New()
        MyBase.New()
        InitializeComponent()
        Me.DoubleBuffered = True
    End Sub
    Public Sub RefreshDataGridView()
        connect()

        ds = New DataSet
        da = New MySqlDataAdapter("SELECT StocksID,ProductID,ProductName,SupplierName,ProductType,ProductPrice,SupplierPrice,Quantity from tbl_stocks where Active=1 ", sqlconn)
        da.Fill(ds, "tbl_stocks")
        DataGridView1.DataSource = ds.Tables("tbl_stocks")
        DataGridView1.Columns("ProductID").Visible = False
        Me.DoubleBuffered = True
        DataGridView1.Columns(0).HeaderText = "ID"
        DataGridView1.Columns(2).HeaderText = "PRODUCT NAME"
        DataGridView1.Columns(3).HeaderText = "SUPPLIER NAME"
        DataGridView1.Columns(4).HeaderText = "PRODUCT TYPE"
        DataGridView1.Columns(5).HeaderText = "PRODUCT PRICE"
        DataGridView1.Columns(6).HeaderText = "SUPPLIER PRICE"
        DataGridView1.Columns(7).HeaderText = "QUANTITY"

        DataGridView1.Columns(0).Width = 40
        DataGridView1.RowTemplate.Height = 100
        DataGridView1.Columns("ProductName").HeaderCell.Style.WrapMode = DataGridViewTriState.True
        DataGridView1.Columns("SupplierName").HeaderCell.Style.WrapMode = DataGridViewTriState.True
        DataGridView1.Columns("ProductType").HeaderCell.Style.WrapMode = DataGridViewTriState.True
        DataGridView1.Columns("ProductPrice").HeaderCell.Style.WrapMode = DataGridViewTriState.True
        DataGridView1.Columns("Quantity").HeaderCell.Style.WrapMode = DataGridViewTriState.True
        DataGridView1.Columns("SupplierPrice").HeaderCell.Style.WrapMode = DataGridViewTriState.True

        DataGridView1.Columns("ProductName").DefaultCellStyle.WrapMode = DataGridViewTriState.True
        DataGridView1.Columns("SupplierName").DefaultCellStyle.WrapMode = DataGridViewTriState.True
        DataGridView1.Columns("ProductType").DefaultCellStyle.WrapMode = DataGridViewTriState.True
        DataGridView1.Columns("ProductPrice").DefaultCellStyle.WrapMode = DataGridViewTriState.True
        DataGridView1.Columns("Quantity").DefaultCellStyle.WrapMode = DataGridViewTriState.True
        DataGridView1.Columns("SupplierPrice").DefaultCellStyle.WrapMode = DataGridViewTriState.True
        disconnect_db()

    End Sub
    Public Sub RefreshDataGridView2()
        connect()

        ds = New DataSet
        da = New MySqlDataAdapter("SELECT StocksID,ProductID,ProductName,SupplierName,ProductType,ProductPrice,SupplierPrice,Quantity,Active from tbl_stocks where Active=0 and Quantity=0 ", sqlconn)
        da.Fill(ds, "tbl_stocks")
        DataGridView2.DataSource = ds.Tables("tbl_stocks")

        DataGridView2.Columns("ProductID").Visible = False
        DataGridView2.Columns("Active").Visible = False
        Me.DoubleBuffered = True
        DataGridView2.Columns(0).HeaderText = "ID"
        DataGridView2.Columns(2).HeaderText = "PRODUCT NAME"
        DataGridView2.Columns(3).HeaderText = "SUPPLIER NAME"
        DataGridView2.Columns(4).HeaderText = "PRODUCT TYPE"
        DataGridView2.Columns(5).HeaderText = "PRODUCT PRICE"
        DataGridView2.Columns(6).HeaderText = "SUPPLIER PRICE"
        DataGridView2.Columns(7).HeaderText = "QUANTITY"

        DataGridView2.Columns(0).Width = 40
        DataGridView2.RowTemplate.Height = 100
        DataGridView2.Columns("ProductName").HeaderCell.Style.WrapMode = DataGridViewTriState.True
        DataGridView2.Columns("SupplierName").HeaderCell.Style.WrapMode = DataGridViewTriState.True
        DataGridView2.Columns("ProductType").HeaderCell.Style.WrapMode = DataGridViewTriState.True
        DataGridView2.Columns("ProductPrice").HeaderCell.Style.WrapMode = DataGridViewTriState.True
        DataGridView2.Columns("Quantity").HeaderCell.Style.WrapMode = DataGridViewTriState.True
        DataGridView2.Columns("SupplierPrice").HeaderCell.Style.WrapMode = DataGridViewTriState.True

        DataGridView2.Columns("ProductName").DefaultCellStyle.WrapMode = DataGridViewTriState.True
        DataGridView2.Columns("SupplierName").DefaultCellStyle.WrapMode = DataGridViewTriState.True
        DataGridView2.Columns("ProductType").DefaultCellStyle.WrapMode = DataGridViewTriState.True
        DataGridView2.Columns("ProductPrice").DefaultCellStyle.WrapMode = DataGridViewTriState.True
        DataGridView2.Columns("Quantity").DefaultCellStyle.WrapMode = DataGridViewTriState.True
        DataGridView2.Columns("SupplierPrice").DefaultCellStyle.WrapMode = DataGridViewTriState.True
        disconnect_db()
    End Sub
    Public Sub RefreshDataGridView3()
        connect()
        ds = New DataSet
        da = New MySqlDataAdapter("SELECT StocksID,ProductID,ProductName,SupplierName,ProductType,ProductPrice,SupplierPrice,Quantity,Active from tbl_stocks where Active=0 and Quantity !=0", sqlconn)
        da.Fill(ds, "tbl_stocks")
        DataGridView3.DataSource = ds.Tables("tbl_stocks")

        DataGridView3.Columns("ProductID").Visible = False
        DataGridView3.Columns("Active").Visible = False
        Me.DoubleBuffered = True

        DataGridView3.Columns(0).HeaderText = "ID"
        DataGridView3.Columns(2).HeaderText = "PRODUCT NAME"
        DataGridView3.Columns(3).HeaderText = "SUPPLIER NAME"
        DataGridView3.Columns(4).HeaderText = "PRODUCT TYPE"
        DataGridView3.Columns(5).HeaderText = "PRODUCT PRICE"
        DataGridView3.Columns(6).HeaderText = "SUPPLIER PRICE"
        DataGridView3.Columns(7).HeaderText = "QUANTITY"

        DataGridView3.Columns(0).Width = 40
        DataGridView3.RowTemplate.Height = 100
        DataGridView3.Columns("ProductName").HeaderCell.Style.WrapMode = DataGridViewTriState.True
        DataGridView3.Columns("SupplierName").HeaderCell.Style.WrapMode = DataGridViewTriState.True
        DataGridView3.Columns("ProductType").HeaderCell.Style.WrapMode = DataGridViewTriState.True
        DataGridView3.Columns("ProductPrice").HeaderCell.Style.WrapMode = DataGridViewTriState.True
        DataGridView3.Columns("Quantity").HeaderCell.Style.WrapMode = DataGridViewTriState.True
        DataGridView3.Columns("SupplierPrice").HeaderCell.Style.WrapMode = DataGridViewTriState.True

        DataGridView3.Columns("ProductName").DefaultCellStyle.WrapMode = DataGridViewTriState.True
        DataGridView3.Columns("SupplierName").DefaultCellStyle.WrapMode = DataGridViewTriState.True
        DataGridView3.Columns("ProductType").DefaultCellStyle.WrapMode = DataGridViewTriState.True
        DataGridView3.Columns("ProductPrice").DefaultCellStyle.WrapMode = DataGridViewTriState.True
        DataGridView3.Columns("Quantity").DefaultCellStyle.WrapMode = DataGridViewTriState.True
        DataGridView3.Columns("SupplierPrice").DefaultCellStyle.WrapMode = DataGridViewTriState.True
        disconnect_db()
    End Sub
    Private Sub stockList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connect()

        RefreshDataGridView()
        btn_rstock.Visible = False
        btn_back.Visible = False
        btn_back1.Visible = False
        txt_search.Visible = True
        txt_search2.Visible = False
        txt_search3.Visible = False
        btn_restore.Visible = False
        DataGridView2.Visible = False
        DataGridView3.Visible = False
        btn_deactivate.Visible = True
        btn_export2.Visible = False
        btn_export3.Visible = False
        btn_print2.Visible = False
        btn_delete.Visible = False
        btn_delete2.Visible = False
        lbl_id.Text = 0

        disconnect_db()
    End Sub

    Private Sub btn_export_Click(sender As Object, e As EventArgs) Handles btn_export.Click
        connect()

        ' Create a SQL command to retrieve data from the database
        da = New MySqlDataAdapter("Select * FROM tbl_stocks where active = 1", sqlconn)
        Dim table As New DataTable()
        da.Fill(table)

        ' Create a new Excel file and add the DataGridView data to it
        Dim excel As New Microsoft.Office.Interop.Excel.Application()
        Dim workbook As Microsoft.Office.Interop.Excel.Workbook = excel.Workbooks.Add(Type.Missing)
        Dim worksheet As Microsoft.Office.Interop.Excel.Worksheet = Nothing
        worksheet = CType(workbook.Sheets("Sheet1"), Microsoft.Office.Interop.Excel.Worksheet)
        worksheet = workbook.ActiveSheet
        worksheet.Name = "Active Inventory List"
        For i As Integer = 1 To table.Columns.Count
            worksheet.Cells(1, i) = table.Columns(i - 1).ColumnName
        Next
        For i As Integer = 0 To table.Rows.Count - 1
            For j As Integer = 0 To table.Columns.Count - 1
                worksheet.Cells(i + 2, j + 1) = table.Rows(i)(j).ToString()
            Next
        Next

        ' Save the Excel file and close the Excel application
        Dim saveDialog As New SaveFileDialog()
        saveDialog.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*"
        saveDialog.FilterIndex = 2
        saveDialog.RestoreDirectory = True
        If File.Exists(saveDialog.FileName) Then
            If MessageBox.Show("The file already exists. Do you want to overwrite it?", "Confirm Overwrite", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                File.Delete(saveDialog.FileName)
            Else
                Exit Sub ' Exit the sub if the user selects No or Cancel
            End If
        End If
        excel.Quit()


        disconnect_db()
    End Sub
    Private Sub btn_export2_Click(sender As Object, e As EventArgs) Handles btn_export2.Click
        connect()

        ' Create a SQL command to retrieve data from the database
        da = New MySqlDataAdapter("Select * FROM tbl_stocks where active = 0 and Quantity =0", sqlconn)
        Dim table As New DataTable()
        da.Fill(table)

        ' Create a new Excel file and add the DataGridView data to it
        Dim excel As New Microsoft.Office.Interop.Excel.Application()
        Dim workbook As Microsoft.Office.Interop.Excel.Workbook = excel.Workbooks.Add(Type.Missing)
        Dim worksheet As Microsoft.Office.Interop.Excel.Worksheet = Nothing
        worksheet = CType(workbook.Sheets("Sheet1"), Microsoft.Office.Interop.Excel.Worksheet)
        worksheet = workbook.ActiveSheet
        worksheet.Name = "Out of Stock Inventory List"
        For i As Integer = 1 To table.Columns.Count
            worksheet.Cells(1, i) = table.Columns(i - 1).ColumnName
        Next
        For i As Integer = 0 To table.Rows.Count - 1
            For j As Integer = 0 To table.Columns.Count - 1
                worksheet.Cells(i + 2, j + 1) = table.Rows(i)(j).ToString()
            Next
        Next

        ' Save the Excel file and close the Excel application
        Dim saveDialog As New SaveFileDialog()
        saveDialog.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*"
        saveDialog.FilterIndex = 2
        saveDialog.RestoreDirectory = True
        If File.Exists(saveDialog.FileName) Then
            If MessageBox.Show("The file already exists. Do you want to overwrite it?", "Confirm Overwrite", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                File.Delete(saveDialog.FileName)
            Else
                Exit Sub ' Exit the sub if the user selects No or Cancel
            End If
        End If
        excel.Quit()


        disconnect_db()
    End Sub
    Private Sub btn_export3_Click(sender As Object, e As EventArgs) Handles btn_export3.Click
        connect()

        ' Create a SQL command to retrieve data from the database
        da = New MySqlDataAdapter("Select * FROM tbl_stocks where active = 0 and Quantity!= 0", sqlconn)
        Dim table As New DataTable()
        da.Fill(table)

        ' Create a new Excel file and add the DataGridView data to it
        Dim excel As New Microsoft.Office.Interop.Excel.Application()
        Dim workbook As Microsoft.Office.Interop.Excel.Workbook = excel.Workbooks.Add(Type.Missing)
        Dim worksheet As Microsoft.Office.Interop.Excel.Worksheet = Nothing
        worksheet = CType(workbook.Sheets("Sheet1"), Microsoft.Office.Interop.Excel.Worksheet)
        worksheet = workbook.ActiveSheet
        worksheet.Name = "Deactivated Inventory List"
        For i As Integer = 1 To table.Columns.Count
            worksheet.Cells(1, i) = table.Columns(i - 1).ColumnName
        Next
        For i As Integer = 0 To table.Rows.Count - 1
            For j As Integer = 0 To table.Columns.Count - 1
                worksheet.Cells(i + 2, j + 1) = table.Rows(i)(j).ToString()
            Next
        Next

        ' Save the Excel file and close the Excel application
        Dim saveDialog As New SaveFileDialog()
        saveDialog.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*"
        saveDialog.FilterIndex = 2
        saveDialog.RestoreDirectory = True
        If File.Exists(saveDialog.FileName) Then
            If MessageBox.Show("The file already exists. Do you want to overwrite it?", "Confirm Overwrite", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                File.Delete(saveDialog.FileName)
            Else
                Exit Sub ' Exit the sub if the user selects No or Cancel
            End If
        End If
        excel.Quit()


        disconnect_db()
    End Sub
    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick

        lbl_id.Text = DataGridView1.SelectedRows(0).Cells("StocksID").Value.ToString()
        stockOutProduct.lbl_sID.Text = DataGridView1.SelectedRows(0).Cells("StocksID").Value.ToString
        stockOutProduct.lbl_pID.Text = DataGridView1.SelectedRows(0).Cells("ProductID").Value.ToString
        stockOutProduct.lbl_pname.Text = DataGridView1.SelectedRows(0).Cells("ProductName").Value.ToString
        stockOutProduct.lbl_sname.Text = DataGridView1.SelectedRows(0).Cells("SupplierName").Value.ToString
        stockOutProduct.lbl_pType.Text = DataGridView1.SelectedRows(0).Cells("ProductType").Value.ToString
        stockOutProduct.lbl_sPrice.Text = DataGridView1.SelectedRows(0).Cells("SupplierPrice").Value.ToString
        stockOutProduct.txt_qty.Text = DataGridView1.SelectedRows(0).Cells("Quantity").Value.ToString
        stockOutProduct.lbl_pPrice.Text = DataGridView1.SelectedRows(0).Cells("ProductPrice").Value.ToString

        lbl_id.Text = DataGridView1.SelectedRows(0).Cells("StocksID").Value.ToString
        updateStocks.lbl_sID.Text = DataGridView1.SelectedRows(0).Cells("StocksID").Value.ToString
        updateStocks.lbl_pID.Text = DataGridView1.SelectedRows(0).Cells("ProductID").Value.ToString
        updateStocks.lbl_pname.Text = DataGridView1.SelectedRows(0).Cells("ProductName").Value.ToString
        updateStocks.lbl_sname.Text = DataGridView1.SelectedRows(0).Cells("SupplierName").Value.ToString
        updateStocks.lbl_pType.Text = DataGridView1.SelectedRows(0).Cells("ProductType").Value.ToString
        updateStocks.txt_sPrice.Text = DataGridView1.SelectedRows(0).Cells("SupplierPrice").Value.ToString
        updateStocks.txt_qty.Text = DataGridView1.SelectedRows(0).Cells("Quantity").Value.ToString
        updateStocks.txt_pPrice.Text = DataGridView1.SelectedRows(0).Cells("ProductPrice").Value.ToString

    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim bitmap As New Bitmap(Me.DataGridView1.Width, Me.DataGridView1.Height)
        Me.DataGridView1.DrawToBitmap(bitmap, Me.DataGridView1.DisplayRectangle)

        ' Add header with logo and text
        Dim headerFont As New Font("Arial", 30, FontStyle.Bold)
        Dim headerText As String = "STOCKSLOGIX"
        Dim headerHeight As Integer = 100
        Dim headerRect As New Rectangle(0, 0, e.PageBounds.Width, headerHeight)
        Dim logoRect As New Rectangle(10, 10, 80, 80)
        e.Graphics.FillRectangle(Brushes.LightGray, headerRect)

        e.Graphics.DrawString(headerText, headerFont, Brushes.Black, logoRect.Right + 10, 15)
        Dim headerTextSize As SizeF = e.Graphics.MeasureString(headerText, headerFont)
        Dim headerTextRect As New RectangleF((e.PageBounds.Width - headerTextSize.Width) / 2, logoRect.Bottom + 10, headerTextSize.Width, headerTextSize.Height)
        e.Graphics.DrawString(headerText, headerFont, Brushes.SteelBlue, headerTextRect)

        ' Calculate the bounds for the DataGridView
        Dim dgvWidth As Integer = e.PageBounds.Width
        Dim dgvHeight As Integer = e.PageBounds.Height - headerRect.Height
        Dim dgvRect As New Rectangle(0, headerRect.Bottom, dgvWidth, dgvHeight)

        ' Adjust the size of the DataGridView to fit the calculated bounds
        Dim originalSize As Size = Me.DataGridView1.Size
        Me.DataGridView1.Size = dgvRect.Size

        ' Print the DataGridView
        e.Graphics.DrawImage(bitmap, dgvRect)

        ' Restore the size of the DataGridView to its original size
        Me.DataGridView1.Size = originalSize

    End Sub

    Private Sub btn_print_Click_1(sender As Object, e As EventArgs) Handles btn_print.Click

        Dim printDialog As New PrintPreviewDialog()
        Dim printDocument As New PrintDocument()
        AddHandler printDocument.PrintPage, AddressOf PrintDocument1_PrintPage
        printDialog.Document = printDocument
        printDialog.ShowDialog()
    End Sub


    Private Sub btn_refresh_Click(sender As Object, e As EventArgs) Handles btn_refresh.Click

        RefreshDataGridView()
        RefreshDataGridView2()
        txt_search.ResetText()
        txt_search2.ResetText()
        lbl_id.Text = 0

    End Sub

    Private Sub btn_sOut_Click(sender As Object, e As EventArgs) Handles btn_sOut.Click
        If lbl_id.Text = 0 Then
            MessageBox.Show("No data selected!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        If stockOutProduct.lbl_sID.Text = 0 Then
            MessageBox.Show("No data selected!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        stockOutProduct.Show()
        updateStocks.Close()
        reactivateStocks.Close()
    End Sub

    Private Sub btn_sIn_Click(sender As Object, e As EventArgs) Handles btn_sIn.Click
        If lbl_id.Text = 0 Then
            MessageBox.Show("No data selected!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        If updateStocks.lbl_sID.Text = 0 Then
            MessageBox.Show("No data selected!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        updateStocks.Show()
        stockOutProduct.Close()
        reactivateStocks.Close()
    End Sub

    Private Sub btn_deactivate_Click(sender As Object, e As EventArgs) Handles btn_deactivate.Click
        If lbl_id.Text = 0 Then
            MessageBox.Show("No data selected!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim confirm = MsgBox("ARE YOU SURE YOU WANT TO DEACTIVATE " & DataGridView1.CurrentRow.Cells("ProductName").Value.ToString() & " PRODUCT THAT HAS QUANTITY OF " & DataGridView1.CurrentRow.Cells("Quantity").Value.ToString() & "?", MessageBoxButtons.YesNo + MsgBoxStyle.Information)
        If confirm = MsgBoxResult.Yes Then
            connect()
            ds = New DataSet
            da = New MySqlDataAdapter("update tbl_stocks set Active = 0 where StocksID = @StocksID", sqlconn)
            da.SelectCommand.Parameters.AddWithValue("StocksID", lbl_id.Text)
            da.Fill(ds, "tbl_stocks")

            MsgBox("DEACTIVATION SUCCESSFUL")
            RefreshDataGridView()
            lbl_id.Text = 0

        Else

        End If
        lbl_id.Text = 0
        disconnect_db()
    End Sub

    Private Sub btn_restock_Click(sender As Object, e As EventArgs) Handles btn_restock.Click
        DataGridView2.Visible = True
        RefreshDataGridView2()
        DataGridView1.Visible = False
        DataGridView3.Visible = False
        btn_sIn.Visible = False
        btn_sOut.Visible = False
        txt_search.Visible = False
        btn_deactivate.Visible = False
        btn_export.Visible = False
        btn_export3.Visible = False
        btn_export2.Visible = True
        txt_search.Visible = False
        txt_search2.Visible = True
        txt_search3.Visible = False
        btn_back.Visible = True
        btn_back1.Visible = False
        btn_restore.Visible = False
        btn_rstock.Visible = True
        btn_print2.Visible = True
        btn_print.Visible = False
        btn_delete2.Visible = True
        btn_delete.Visible = False
        txt_search.ResetText()
        lbl_id.Text = 0
        lbl_header.Text = "OUT OF STOCK LIST"
    End Sub


    Private Sub DataGridView2_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellClick
        lbl_id.Text = DataGridView2.SelectedRows(0).Cells("StocksID").Value.ToString
        reactivateStocks.lbl_sID.Text = DataGridView2.SelectedRows(0).Cells("StocksID").Value.ToString
        reactivateStocks.lbl_pID.Text = DataGridView2.SelectedRows(0).Cells("ProductID").Value.ToString
        reactivateStocks.lbl_pname.Text = DataGridView2.SelectedRows(0).Cells("ProductName").Value.ToString
        reactivateStocks.lbl_sname.Text = DataGridView2.SelectedRows(0).Cells("SupplierName").Value.ToString
        reactivateStocks.lbl_pType.Text = DataGridView2.SelectedRows(0).Cells("ProductType").Value.ToString
        reactivateStocks.lbl_sPrice.Text = DataGridView2.SelectedRows(0).Cells("SupplierPrice").Value.ToString
        reactivateStocks.txt_qty.Text = DataGridView2.SelectedRows(0).Cells("Quantity").Value.ToString
        reactivateStocks.lbl_pPrice.Text = DataGridView2.SelectedRows(0).Cells("ProductPrice").Value.ToString
    End Sub

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        DataGridView1.Visible = True
        RefreshDataGridView()
        DataGridView2.Visible = False
        btn_sIn.Visible = True
        btn_sOut.Visible = True
        txt_search.Visible = True
        btn_deactivate.Visible = True
        btn_export.Visible = True
        btn_export2.Visible = False
        btn_export3.Visible = False
        txt_search2.Visible = False
        txt_search3.Visible = False
        btn_back.Visible = False
        btn_back1.Visible = False
        btn_rstock.Visible = False
        btn_restore.Visible = False
        btn_print2.Visible = False
        btn_print.Visible = True
        btn_delete.Visible = False
        txt_search2.ResetText()
        lbl_header.Text = "INVENTORY LIST"
        lbl_id.Text = 0
    End Sub
    Private Sub btn_back1_Click(sender As Object, e As EventArgs) Handles btn_back1.Click
        DataGridView1.Visible = True
        RefreshDataGridView()
        DataGridView2.Visible = False
        DataGridView3.Visible = False
        btn_sIn.Visible = True
        btn_sOut.Visible = True
        txt_search.Visible = True
        btn_deactivate.Visible = True
        btn_export.Visible = True
        btn_export2.Visible = False
        btn_export3.Visible = False
        txt_search2.Visible = False
        txt_search3.Visible = False
        btn_back.Visible = False
        btn_back1.Visible = False
        btn_rstock.Visible = False
        btn_restore.Visible = False
        btn_print2.Visible = False
        btn_print.Visible = True
        btn_delete.Visible = False
        txt_search2.ResetText()
        lbl_header.Text = "INVENTORY LIST"
        lbl_id.Text = 0
    End Sub
    Private Sub txt_search_TextChanged(sender As Object, e As EventArgs) Handles txt_search.TextChanged
        connect()

        ds = New DataSet
        da = New MySqlDataAdapter("Select StocksID,ProductID,ProductName,SupplierName,ProductType,ProductPrice,Quantity,SupplierPrice from tbl_stocks where Active = 1 AND ProductName like @ProductName order by ProductName ASC;", sqlconn)
        da.SelectCommand.Parameters.AddWithValue("@ProductName", "%" & txt_search.Text & "%")
        da.Fill(ds, "tbl_stocks")
        DataGridView1.DataSource = ds.Tables("tbl_stocks")
        lbl_id.Text = 0
        disconnect_db()
    End Sub

    Private Sub txt_search2_TextChanged(sender As Object, e As EventArgs) Handles txt_search2.TextChanged
        connect()

        ds = New DataSet
        da = New MySqlDataAdapter("SELECT StocksID,ProductID,ProductName,SupplierName,ProductType,ProductPrice,Quantity,SupplierPrice,Active FROM tbl_stocks WHERE Active = 0 AND Quantity = 0 AND ProductName LIKE @ProductName ORDER BY ProductName ASC;", sqlconn)
        da.SelectCommand.Parameters.AddWithValue("@ProductName", "%" & txt_search2.Text & "%")
        da.Fill(ds, "tbl_stocks")
        DataGridView2.DataSource = ds.Tables("tbl_stocks")
        lbl_id.Text = 0
        disconnect_db()
    End Sub
    Private Sub txt_search3_TextChanged(sender As Object, e As EventArgs) Handles txt_search3.TextChanged
        connect()

        ds = New DataSet
        da = New MySqlDataAdapter("SELECT StocksID,ProductID,ProductName,SupplierName,ProductType,ProductPrice,Quantity,SupplierPrice,Active FROM tbl_stocks WHERE Active = 0 AND Quantity !=0 AND ProductName LIKE @ProductName ORDER BY ProductName ASC;", sqlconn)
        da.SelectCommand.Parameters.AddWithValue("@ProductName", "%" & txt_search3.Text & "%")
        da.Fill(ds, "tbl_stocks")
        DataGridView3.DataSource = ds.Tables("tbl_stocks")
        lbl_id.Text = 0
        disconnect_db()
    End Sub

    Private selectedStockID As Integer ' Class-level variable to store the selected StockID value
    Private Sub btn_restore_Click(sender As Object, e As EventArgs) Handles btn_restore.Click
        If lbl_id.Text = 0 Then
            MessageBox.Show("No data selected!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If DataGridView3.SelectedRows.Count = 0 Then
            MessageBox.Show("No data selected!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        reactivateStocks.StocksID = SelectedStocksID ' Set the StocksID property of the reactivateStocks form to the selected StocksID
        reactivateStocks.ShowDialog()
        RefreshDataGridView3()

    End Sub
    Private Sub btn_rstock_Click(sender As Object, e As EventArgs) Handles btn_rstock.Click
        If lbl_id.Text = 0 Then
            MessageBox.Show("No data selected!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If DataGridView2.SelectedRows.Count = 0 Then
            MessageBox.Show("No data selected!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        reactivateStocks.StocksID = SelectedStocksID ' Set the StocksID property of the reactivateStocks form to the selected StocksID
        reactivateStocks.ShowDialog()
        RefreshDataGridView2()
    End Sub
    ' Public property to get the selected StocksID value from the StockList form
    Public ReadOnly Property SelectedStocksID() As Integer

        Get
            If DataGridView2.SelectedRows.Count > 0 Then
                selectedStockID = CInt(DataGridView2.SelectedRows(0).Cells("StocksID").Value)
                Return selectedStockID
            End If
            If DataGridView3.SelectedRows.Count > 0 Then
                selectedStockID = CInt(DataGridView3.SelectedRows(0).Cells("StocksID").Value)
                Return selectedStockID

            Else
                Return 0
            End If
        End Get
    End Property
    Public Sub ResetSelectedStocksID()
        selectedStockID = 0
    End Sub
    Private Sub DataGridView2_SelectionChanged(sender As Object, e As EventArgs) Handles DataGridView2.SelectionChanged
        lbl_id.Text = SelectedStocksID.ToString()
        reactivateStocks.StocksID = SelectedStocksID

    End Sub
    Private Sub DataGridView3_SelectionChanged(sender As Object, e As EventArgs) Handles DataGridView3.SelectionChanged
        lbl_id.Text = SelectedStocksID.ToString()
        reactivateStocks.StocksID = SelectedStocksID
    End Sub


    Private Sub btn_print2_Click(sender As Object, e As EventArgs) Handles btn_print2.Click
        Dim printDialog As New PrintPreviewDialog()
        Dim printDocument As New PrintDocument()
        AddHandler printDocument.PrintPage, AddressOf PrintDocument2_PrintPage
        printDialog.Document = printDocument
        printDialog.ShowDialog()
    End Sub

    Private Sub PrintDocument2_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PrintDocument2.PrintPage
        Dim bitmap As New Bitmap(Me.DataGridView2.Width, Me.DataGridView2.Height)
        Me.DataGridView2.DrawToBitmap(bitmap, Me.DataGridView2.DisplayRectangle)

        ' Add header with logo and text
        Dim headerFont As New Font("Arial", 30, FontStyle.Bold)
        Dim headerText As String = "STOCKSLOGIX"
        Dim headerHeight As Integer = 100
        Dim headerRect As New Rectangle(0, 0, e.PageBounds.Width, headerHeight)
        Dim logoRect As New Rectangle(10, 10, 80, 80)
        e.Graphics.FillRectangle(Brushes.LightGray, headerRect)

        e.Graphics.DrawString(headerText, headerFont, Brushes.Black, logoRect.Right + 10, 15)
        Dim headerTextSize As SizeF = e.Graphics.MeasureString(headerText, headerFont)
        Dim headerTextRect As New RectangleF((e.PageBounds.Width - headerTextSize.Width) / 2, logoRect.Bottom + 10, headerTextSize.Width, headerTextSize.Height)
        e.Graphics.DrawString(headerText, headerFont, Brushes.SteelBlue, headerTextRect)

        ' Calculate the bounds for the DataGridView
        Dim dgvWidth As Integer = e.PageBounds.Width
        Dim dgvHeight As Integer = e.PageBounds.Height - headerRect.Height
        Dim dgvRect As New Rectangle(0, headerRect.Bottom, dgvWidth, dgvHeight)

        ' Adjust the size of the DataGridView to fit the calculated bounds
        Dim originalSize As Size = Me.DataGridView2.Size
        Me.DataGridView2.Size = dgvRect.Size

        ' Print the DataGridView
        e.Graphics.DrawImage(bitmap, dgvRect)

        ' Restore the size of the DataGridView to its original size
        Me.DataGridView2.Size = originalSize
    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click

        If lbl_id.Text = 0 Then
            MessageBox.Show("No data selected!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        Dim confirm = MsgBox("ARE YOU SURE YOU WANT TO PERMANENTLY DELETE STOCK " & DataGridView3.CurrentRow.Cells("ProductName").Value.ToString() & " PRODUCT THAT HAS QUANTITY OF " & DataGridView3.CurrentRow.Cells("Quantity").Value.ToString() & "?", MessageBoxButtons.YesNo + MsgBoxStyle.Exclamation)
        If confirm = MsgBoxResult.Yes Then
            Try
                connect()
                Dim query = "DELETE FROM tbl_stocks WHERE StocksID = @StocksID"
                Using cmd As New MySqlCommand(query, sqlconn)
                    cmd.Parameters.AddWithValue("@StocksID", lbl_id.Text)
                    Dim rowsAffected = cmd.ExecuteNonQuery()
                    If rowsAffected > 0 Then
                        MsgBox("Stock Deleted Successfully.")
                        RefreshDataGridView3()

                        lbl_id.Text = 0

                    Else
                        MsgBox("User not found.", MessageBoxIcon.Warning)
                    End If
                End Using
            Catch ex As Exception
                MsgBox("Error restoring product: " & ex.Message, MessageBoxIcon.Error)
            Finally
                disconnect_db()
            End Try
        End If

    End Sub
    Private Sub btn_delete2_Click(sender As Object, e As EventArgs) Handles btn_delete2.Click
        Dim confirm1 = MsgBox("ARE YOU SURE YOU WANT TO PERMANENTLY DELETE STOCK " & DataGridView2.CurrentRow.Cells("ProductName").Value.ToString() & " PRODUCT THAT HAS QUANTITY OF " & DataGridView2.CurrentRow.Cells("Quantity").Value.ToString() & "?", MessageBoxButtons.YesNo + MsgBoxStyle.Exclamation)
        If confirm1 = MsgBoxResult.Yes Then
            Try
                connect()
                Dim query = "DELETE FROM tbl_stocks WHERE StocksID = @StocksID"
                Using cmd As New MySqlCommand(query, sqlconn)
                    cmd.Parameters.AddWithValue("@StocksID", lbl_id.Text)
                    Dim rowsAffected = cmd.ExecuteNonQuery()
                    If rowsAffected > 0 Then
                        MsgBox("Stock Deleted Successfully.")
                        RefreshDataGridView2()

                        lbl_id.Text = 0

                    Else
                        MsgBox("User not found.", MessageBoxIcon.Warning)
                    End If
                End Using
            Catch ex As Exception
                MsgBox("Error restoring product: " & ex.Message, MessageBoxIcon.Error)
            Finally
                disconnect_db()
            End Try
        End If
    End Sub
    Private Sub DataGridView2_Click(sender As Object, e As EventArgs) Handles DataGridView2.Click
        lbl_id.Text = 0
    End Sub

    Private Sub stockList_Click(sender As Object, e As EventArgs) Handles MyBase.Click
        lbl_id.Text = 0
    End Sub

    Private Sub DataGridView3_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView3.CellClick
        lbl_id.Text = DataGridView3.SelectedRows(0).Cells("StocksID").Value.ToString
        reactivateStocks.lbl_sID.Text = DataGridView3.SelectedRows(0).Cells("StocksID").Value.ToString
        reactivateStocks.lbl_pID.Text = DataGridView3.SelectedRows(0).Cells("ProductID").Value.ToString
        reactivateStocks.lbl_pname.Text = DataGridView3.SelectedRows(0).Cells("ProductName").Value.ToString
        reactivateStocks.lbl_sname.Text = DataGridView3.SelectedRows(0).Cells("SupplierName").Value.ToString
        reactivateStocks.lbl_pType.Text = DataGridView3.SelectedRows(0).Cells("ProductType").Value.ToString
        reactivateStocks.lbl_sPrice.Text = DataGridView3.SelectedRows(0).Cells("SupplierPrice").Value.ToString
        reactivateStocks.txt_qty.Text = DataGridView3.SelectedRows(0).Cells("Quantity").Value.ToString
        reactivateStocks.lbl_pPrice.Text = DataGridView3.SelectedRows(0).Cells("ProductPrice").Value.ToString

    End Sub

    Private Sub btn_sDeactivate_Click(sender As Object, e As EventArgs) Handles btn_sDeactivate.Click
        RefreshDataGridView3()
        DataGridView3.Visible = True
        DataGridView1.Visible = False
        DataGridView2.Visible = False
        btn_sIn.Visible = False
        btn_sOut.Visible = False
        txt_search.Visible = False
        btn_deactivate.Visible = False
        btn_export.Visible = False
        btn_export2.Visible = False
        txt_search.Visible = False
        btn_export3.Visible = True
        txt_search2.Visible = False
        txt_search3.Visible = True
        btn_back.Visible = False
        btn_back1.Visible = True
        btn_rstock.Visible = False
        btn_restore.Visible = True
        btn_print2.Visible = True
        btn_print.Visible = False
        btn_delete.Visible = True
        btn_delete2.Visible = False
        txt_search.ResetText()
        lbl_header.Text = "DEACTIVATED LIST"
        lbl_id.Text = 0
    End Sub

    Private Sub PrintDocument3_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PrintDocument3.PrintPage
        Dim bitmap As New Bitmap(Me.DataGridView3.Width, Me.DataGridView3.Height)
        Me.DataGridView3.DrawToBitmap(bitmap, Me.DataGridView3.DisplayRectangle)

        ' Add header with logo and text
        Dim headerFont As New Font("Arial", 30, FontStyle.Bold)
        Dim headerText As String = "STOCKSLOGIX"
        Dim headerHeight As Integer = 100
        Dim headerRect As New Rectangle(0, 0, e.PageBounds.Width, headerHeight)
        Dim logoRect As New Rectangle(10, 10, 80, 80)
        e.Graphics.FillRectangle(Brushes.LightGray, headerRect)

        e.Graphics.DrawString(headerText, headerFont, Brushes.Black, logoRect.Right + 10, 15)
        Dim headerTextSize As SizeF = e.Graphics.MeasureString(headerText, headerFont)
        Dim headerTextRect As New RectangleF((e.PageBounds.Width - headerTextSize.Width) / 2, logoRect.Bottom + 10, headerTextSize.Width, headerTextSize.Height)
        e.Graphics.DrawString(headerText, headerFont, Brushes.SteelBlue, headerTextRect)

        ' Calculate the bounds for the DataGridView
        Dim dgvWidth As Integer = e.PageBounds.Width
        Dim dgvHeight As Integer = e.PageBounds.Height - headerRect.Height
        Dim dgvRect As New Rectangle(0, headerRect.Bottom, dgvWidth, dgvHeight)

        ' Adjust the size of the DataGridView to fit the calculated bounds
        Dim originalSize As Size = Me.DataGridView3.Size
        Me.DataGridView3.Size = dgvRect.Size

        ' Print the DataGridView
        e.Graphics.DrawImage(bitmap, dgvRect)

        ' Restore the size of the DataGridView to its original size
        Me.DataGridView3.Size = originalSize
    End Sub


End Class