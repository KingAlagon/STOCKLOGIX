Imports MySql.Data.MySqlClient
Imports System.Drawing.Printing
Imports System.IO

Public Class supplierList
    Private supplierDataSource As New DataTable()

    Public Sub New()
        MyBase.New()
        InitializeComponent()
        Me.DoubleBuffered = True
    End Sub
    Public Sub RefreshDataGridView()
        connect()

        ds = New DataSet
        da = New MySqlDataAdapter("SELECT supp_id, supp_name, supp_address, supp_number, supp_prod_type FROM tbl_supplier where active = 1", sqlconn)
        da.Fill(ds, "tbl_supplier")
        DataGridView1.DataSource = ds.Tables("tbl_supplier")
        DataGridView1.Columns(0).HeaderText = "ID"
        DataGridView1.Columns(1).HeaderText = "NAME"
        DataGridView1.Columns(2).HeaderText = "ADDRESS"
        DataGridView1.Columns(3).HeaderText = "NUMBER"
        DataGridView1.Columns(4).HeaderText = "PRODUCT TYPE"
        disconnect_db()
    End Sub
    Public Sub RefreshDataGridView2()
        connect()
        ds = New DataSet
        da = New MySqlDataAdapter("SELECT supp_id, supp_name, supp_address, supp_number, supp_prod_type FROM tbl_supplier where active = 0", sqlconn)
        da.Fill(ds, "tbl_supplier")
        DataGridView2.DataSource = ds.Tables("tbl_supplier")
        DataGridView2.Columns(0).Width = 100
        DataGridView2.Columns(3).Width = 100
        DataGridView2.Columns(0).HeaderText = "ID"
        DataGridView2.Columns(1).HeaderText = "NAME"
        DataGridView2.Columns(2).HeaderText = "ADDRESS"
        DataGridView2.Columns(3).HeaderText = "NUMBER"
        DataGridView2.Columns(4).HeaderText = "PRODUCT TYPE"

        DataGridView2.RowTemplate.Height = 100
        DataGridView2.Columns("supp_name").DefaultCellStyle.WrapMode = DataGridViewTriState.True
        DataGridView2.Columns("supp_address").DefaultCellStyle.WrapMode = DataGridViewTriState.True
        DataGridView2.Columns("supp_number").DefaultCellStyle.WrapMode = DataGridViewTriState.True
        DataGridView2.Columns("supp_prod_type").DefaultCellStyle.WrapMode = DataGridViewTriState.True
        disconnect_db()
    End Sub

    Private Sub supplierList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connect()
        RefreshDataGridView()
        btn_delete.Visible = False
        btn_back.Visible = False
        btn_restore.Visible = False
        DataGridView2.Visible = False
        txt_search2.Visible = False
        btn_print2.Visible = False
        btn_export2.Visible = False
        DataGridView1.Columns(0).Width = 100
        DataGridView1.Columns(3).Width = 100
        DataGridView1.RowTemplate.Height = 100
        DataGridView1.Columns("supp_name").DefaultCellStyle.WrapMode = DataGridViewTriState.True
        DataGridView1.Columns("supp_address").DefaultCellStyle.WrapMode = DataGridViewTriState.True
        DataGridView1.Columns("supp_number").DefaultCellStyle.WrapMode = DataGridViewTriState.True
        DataGridView1.Columns("supp_prod_type").DefaultCellStyle.WrapMode = DataGridViewTriState.True
        disconnect_db()
    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        If lbl_id.Text = "HSLLS-000" Then
            MessageBox.Show("No data selected!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        If updateSupplier.lbl_id.Text = "HSLLS-000" Then
            MessageBox.Show("No data selected!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        updateSupplier.Show()
        updateProductForm.Close()
        userUpdateForm.Close()
    End Sub


    Private Sub btn_refresh_Click(sender As Object, e As EventArgs) Handles btn_refresh.Click
        connect()
        lbl_id1.Text = ""
        txt_search.Text = ""
        ds = New DataSet
        da = New MySqlDataAdapter("SELECT supp_id, supp_name,supp_address,supp_number,supp_prod_type FROM tbl_supplier", sqlconn)
        da.Fill(ds, "tbl_supplier")
        DataGridView1.DataSource = ds.Tables("tbl_supplier")
        txt_search.ResetText()
        disconnect_db()
    End Sub

    Private Sub txt_search_TextChanged(sender As Object, e As EventArgs) Handles txt_search.TextChanged
        connect()

        ds = New DataSet
        da = New MySqlDataAdapter("Select supp_id, supp_name, supp_address, supp_number, supp_prod_type from tbl_supplier where active = 1 AND supp_name like @supp_name order by supp_name ASC", sqlconn)
        da.SelectCommand.Parameters.AddWithValue("@supp_name", "%" & txt_search.Text & "%")
        da.Fill(ds, "tbl_supplier")
        DataGridView1.DataSource = ds.Tables("tbl_supplier")


        disconnect_db()
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

    Private Sub btn_print_Click(sender As Object, e As EventArgs) Handles btn_print.Click
        Dim printDialog As New PrintPreviewDialog()
        Dim printDocument As New PrintDocument()
        AddHandler printDocument.PrintPage, AddressOf PrintDocument1_PrintPage
        printDialog.Document = printDocument
        printDialog.ShowDialog()
    End Sub

    Private Sub btn_export_Click(sender As Object, e As EventArgs) Handles btn_export.Click
        ' Connect to the database
        connect()

        ' Create a SQL command to retrieve data from the database
        da = New MySqlDataAdapter("Select * FROM tbl_supplier where active = 1", sqlconn)
        Dim table As New DataTable()
        da.Fill(table)

        ' Create a new Excel file and add the DataGridView data to it
        Dim excel As New Microsoft.Office.Interop.Excel.Application()
        Dim workbook As Microsoft.Office.Interop.Excel.Workbook = excel.Workbooks.Add(Type.Missing)
        Dim worksheet As Microsoft.Office.Interop.Excel.Worksheet = Nothing
        worksheet = CType(workbook.Sheets("Sheet1"), Microsoft.Office.Interop.Excel.Worksheet)
        worksheet = workbook.ActiveSheet
        worksheet.Name = "Supplier Data"
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

        ' Disconnect from the database
        disconnect_db()


    End Sub

    Private Sub supplierList_Click(sender As Object, e As EventArgs) Handles MyBase.Click
        lbl_id1.Text = ""
    End Sub

    Private Sub txt_search_Click(sender As Object, e As EventArgs) Handles txt_search.Click
        lbl_id1.Text = ""
    End Sub



    Private Sub DataGridView1_CellClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick


        lbl_id.Text = DataGridView1.SelectedRows(0).Cells("supp_id").Value.ToString
        updateSupplier.lbl_id.Text = DataGridView1.SelectedRows(0).Cells("supp_id").Value.ToString
        updateSupplier.txt_sName.Text = DataGridView1.SelectedRows(0).Cells("supp_name").Value.ToString
        updateSupplier.txt_sAddress.Text = DataGridView1.SelectedRows(0).Cells("supp_address").Value.ToString
        updateSupplier.txt_sNumber.Text = DataGridView1.SelectedRows(0).Cells("supp_number").Value.ToString
        updateSupplier.cmb_prodType.Text = DataGridView1.SelectedRows(0).Cells("supp_prod_type").Value.ToString
        lbl_id1.Text = DataGridView1.SelectedRows(0).Cells("supp_id").Value.ToString


    End Sub

    Private Sub DataGridView1_Click_1(sender As Object, e As EventArgs) Handles DataGridView1.Click
        lbl_id1.Text = ""
    End Sub

    Private Sub btn_deactivate_Click(sender As Object, e As EventArgs) Handles btn_deactivate.Click
        If lbl_id.Text = "HSLLS-000" Then
            MessageBox.Show("No data selected!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        Dim confirm = MsgBox("ARE YOU SURE YOU WANT TO DEACTIVATE SUPPLIER " & DataGridView1.CurrentRow.Cells("supp_name").Value.ToString() & " WITH PRODUCT TYPE " & DataGridView1.CurrentRow.Cells("supp_prod_type").Value.ToString() & "?", MessageBoxButtons.YesNo + MsgBoxStyle.Information)
        If confirm = MsgBoxResult.Yes Then
            connect()
            ds = New DataSet
            da = New MySqlDataAdapter("update tbl_supplier set active = 0 where supp_id = @supp_id", sqlconn)
            da.SelectCommand.Parameters.AddWithValue("supp_id", lbl_id.Text)
            da.Fill(ds, "tbl_supplier")

            MsgBox("DEACTIVATION SUCCESSFUL")
            RefreshDataGridView()
            lbl_id.Text = "HSLLS-000"

        Else

        End If
        lbl_id.Text = "HSLLS-000"
        disconnect_db()
    End Sub

    Private Sub btn_sDeactivate_Click(sender As Object, e As EventArgs) Handles btn_sDeactivate.Click
        DataGridView2.Visible = True
        RefreshDataGridView2()
        DataGridView1.Visible = False
        btn_back.Visible = True
        btn_restore.Visible = True
        btn_update.Visible = False
        btn_deactivate.Visible = False
        btn_delete.Visible = True
        txt_search2.Visible = True
        btn_export.Visible = False
        btn_export2.Visible = True
        btn_print2.Visible = True
        btn_print.Visible = False

        lbl_header.Text = "DEACTIVATED LIST"
    End Sub

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click

        DataGridView1.Visible = True
        RefreshDataGridView()
        DataGridView2.Visible = False
        btn_back.Visible = False
        btn_restore.Visible = False
        btn_delete.Visible = False
        btn_deactivate.Visible = True
        txt_search.Visible = True
        txt_search2.Visible = False
        btn_update.Visible = True
        btn_print2.Visible = False
        btn_export2.Visible = False
        btn_print.Visible = True
        btn_export.Visible = True
        lbl_header.Text = "SUPPLIER LIST"
        lbl_id.Text = "HSLLS-000"
    End Sub

    Private Sub DataGridView2_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellClick
        lbl_id.Text = DataGridView2.SelectedRows(0).Cells("supp_id").Value.ToString
    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click

        If lbl_id.Text = "HSLLS-000" Then
            MessageBox.Show("No data selected!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        Dim confirm = MsgBox("ARE YOU SURE YOU WANT TO PERMANENTLY DELETE SUPPLIER " & DataGridView2.CurrentRow.Cells("supp_name").Value.ToString() & " WITH PRODUCT TYPE " & DataGridView2.CurrentRow.Cells("supp_prod_type").Value.ToString() & "?", MessageBoxButtons.YesNo + MsgBoxStyle.Exclamation)

        If confirm = MsgBoxResult.Yes Then
            Try
                connect()
                Dim query = "DELETE FROM tbl_supplier WHERE supp_id = @supp_id"
                Using cmd As New MySqlCommand(query, sqlconn)
                    cmd.Parameters.AddWithValue("@supp_id", lbl_id.Text)
                    Dim rowsAffected = cmd.ExecuteNonQuery()
                    If rowsAffected > 0 Then
                        MsgBox("Supplier Deleted Successfully.")
                        RefreshDataGridView2()

                        lbl_id.Text = "HSLLS-000"

                    Else
                        MsgBox("Supplier not found.", MessageBoxIcon.Warning)
                    End If
                End Using
            Catch ex As Exception
                MsgBox("Error restoring product: " & ex.Message, MessageBoxIcon.Error)
            Finally
                disconnect_db()
            End Try
        End If
    End Sub

    Private Sub btn_restore_Click(sender As Object, e As EventArgs) Handles btn_restore.Click
        If lbl_id.Text = "HSLLS-000" Then
            MessageBox.Show("No data selected!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim confirm = MsgBox("ARE YOU SURE YOU WANT TO ACTIVATE SUPPLIER " & DataGridView2.CurrentRow.Cells("supp_name").Value.ToString() & " WITH PRODUCT TYPE " & DataGridView2.CurrentRow.Cells("supp_prod_type").Value.ToString() & "?", MessageBoxButtons.YesNo + MsgBoxStyle.Information)
        If confirm = MsgBoxResult.Yes Then
            Try
                connect()
                Dim query = "UPDATE tbl_supplier SET Active = 1 WHERE supp_id = @supp_id"
                Using cmd As New MySqlCommand(query, sqlconn)
                    cmd.Parameters.AddWithValue("@supp_id", lbl_id.Text)
                    Dim rowsAffected = cmd.ExecuteNonQuery()
                    If rowsAffected > 0 Then
                        MsgBox("Supplier restored successfully.")
                        RefreshDataGridView2()

                        lbl_id.Text = 0

                    Else
                        MsgBox("Supplier not found.", MessageBoxIcon.Warning)
                    End If
                End Using
            Catch ex As Exception
                MsgBox("Error restoring product: " & ex.Message, MessageBoxIcon.Error)
            Finally
                disconnect_db()
            End Try

        End If
    End Sub

    Private Sub txt_search2_TextChanged(sender As Object, e As EventArgs) Handles txt_search2.TextChanged
        connect()

        ds = New DataSet
        da = New MySqlDataAdapter("Select supp_id, supp_name, supp_address, supp_number, supp_prod_type from tbl_supplier where active = 0 AND supp_name like @supp_name order by supp_name ASC", sqlconn)
        da.SelectCommand.Parameters.AddWithValue("@supp_name", "%" & txt_search.Text & "%")
        da.Fill(ds, "tbl_supplier")
        DataGridView2.DataSource = ds.Tables("tbl_supplier")


        disconnect_db()
    End Sub

    Private Sub btn_export2_Click(sender As Object, e As EventArgs) Handles btn_export2.Click
        ' Connect to the database
        connect()

        ' Create a SQL command to retrieve data from the database
        da = New MySqlDataAdapter("Select * FROM tbl_supplier where active = 0", sqlconn)
        Dim table As New DataTable()
        da.Fill(table)

        ' Create a new Excel file and add the DataGridView data to it
        Dim excel As New Microsoft.Office.Interop.Excel.Application()
        Dim workbook As Microsoft.Office.Interop.Excel.Workbook = excel.Workbooks.Add(Type.Missing)
        Dim worksheet As Microsoft.Office.Interop.Excel.Worksheet = Nothing
        worksheet = CType(workbook.Sheets("Sheet1"), Microsoft.Office.Interop.Excel.Worksheet)
        worksheet = workbook.ActiveSheet
        worksheet.Name = "Deactivated Supplier Data"
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

        ' Disconnect from the database
        disconnect_db()

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

    Private Sub btn_print2_Click(sender As Object, e As EventArgs) Handles btn_print2.Click
        Dim printDialog As New PrintPreviewDialog()
        Dim printDocument As New PrintDocument()
        AddHandler printDocument.PrintPage, AddressOf PrintDocument2_PrintPage
        printDialog.Document = printDocument
        printDialog.ShowDialog()
    End Sub
End Class