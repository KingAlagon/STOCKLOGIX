Imports MySql.Data.MySqlClient
Imports System.Drawing.Printing
Imports System.IO
Public Class logs
    Public ds As New DataSet
    Public da As New MySqlDataAdapter
    Public sqlconn As New MySqlConnection
    Public dt As New DataTable
    Public Sub New()

        InitializeComponent()
        Me.DoubleBuffered = True
    End Sub
    Private Sub logs_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connect()
        ds = New DataSet
        da = New MySqlDataAdapter("Select * from tbl_logs", sqlconn)
        da.Fill(ds, "tbl_logs")
        DataGridView1.DataSource = ds.Tables("tbl_logs")
    End Sub
    Public Sub connect()

        sqlconn = New MySqlConnection("server=localhost;userid=root;password=;database=stocklogix;")
        If sqlconn.State = ConnectionState.Closed Then

            sqlconn.Open()

        End If

    End Sub
    Public Sub disconnect_db()
        If sqlconn.State = ConnectionState.Open Then
            sqlconn.Close()

        End If
    End Sub

    Private Sub txt_search_TextChanged(sender As Object, e As EventArgs) Handles txt_search.TextChanged
        connect()

        ds = New DataSet
        da = New MySqlDataAdapter("Select * from tbl_logs where username like @username order by username ASC", sqlconn)
        da.SelectCommand.Parameters.AddWithValue("@username", "%" & txt_search.Text & "%")
        da.Fill(ds, "tbl_logs")
        DataGridView1.DataSource = ds.Tables("tbl_logs")

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
        connect()

        ' Create a SQL command to retrieve data from the database
        da = New MySqlDataAdapter("Select * FROM tbl_logs", sqlconn)
        Dim table As New DataTable()
        da.Fill(table)

        ' Create a new Excel file and add the DataGridView data to it
        Dim excel As New Microsoft.Office.Interop.Excel.Application()
        Dim workbook As Microsoft.Office.Interop.Excel.Workbook = excel.Workbooks.Add(Type.Missing)
        Dim worksheet As Microsoft.Office.Interop.Excel.Worksheet = Nothing
        worksheet = CType(workbook.Sheets("Sheet1"), Microsoft.Office.Interop.Excel.Worksheet)
        worksheet = workbook.ActiveSheet
        worksheet.Name = "Logs"
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
End Class