<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class prodList
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(prodList))
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btn_update = New FontAwesome.Sharp.IconButton()
        Me.txt_search = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl_id1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btn_refresh = New FontAwesome.Sharp.IconButton()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.btn_print = New FontAwesome.Sharp.IconButton()
        Me.btn_export = New FontAwesome.Sharp.IconButton()
        Me.btn_sIn = New FontAwesome.Sharp.IconButton()
        Me.btn_back = New FontAwesome.Sharp.IconButton()
        Me.btn_sDeactivate = New FontAwesome.Sharp.IconButton()
        Me.btn_deactivate = New FontAwesome.Sharp.IconButton()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.btn_restore = New FontAwesome.Sharp.IconButton()
        Me.btn_export2 = New FontAwesome.Sharp.IconButton()
        Me.btn_print2 = New FontAwesome.Sharp.IconButton()
        Me.PrintDocument2 = New System.Drawing.Printing.PrintDocument()
        Me.btn_delete = New FontAwesome.Sharp.IconButton()
        Me.lbl_header = New System.Windows.Forms.Label()
        Me.txt_search2 = New System.Windows.Forms.TextBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_update
        '
        Me.btn_update.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btn_update.BackColor = System.Drawing.Color.Transparent
        Me.btn_update.FlatAppearance.BorderSize = 0
        Me.btn_update.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue
        Me.btn_update.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue
        Me.btn_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_update.Font = New System.Drawing.Font("Argentum Novus", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_update.ForeColor = System.Drawing.Color.White
        Me.btn_update.IconChar = FontAwesome.Sharp.IconChar.Pen
        Me.btn_update.IconColor = System.Drawing.Color.White
        Me.btn_update.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_update.IconSize = 30
        Me.btn_update.Location = New System.Drawing.Point(459, 449)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Size = New System.Drawing.Size(107, 43)
        Me.btn_update.TabIndex = 5
        Me.btn_update.Text = "UPDATE"
        Me.btn_update.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_update.UseVisualStyleBackColor = False
        '
        'txt_search
        '
        Me.txt_search.Font = New System.Drawing.Font("Argentum Novus", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_search.ForeColor = System.Drawing.Color.SteelBlue
        Me.txt_search.Location = New System.Drawing.Point(103, 55)
        Me.txt_search.Name = "txt_search"
        Me.txt_search.Size = New System.Drawing.Size(158, 23)
        Me.txt_search.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Argentum Novus", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(41, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 16)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Search:"
        '
        'lbl_id1
        '
        Me.lbl_id1.AutoSize = True
        Me.lbl_id1.BackColor = System.Drawing.Color.Transparent
        Me.lbl_id1.Location = New System.Drawing.Point(57, 99)
        Me.lbl_id1.Name = "lbl_id1"
        Me.lbl_id1.Size = New System.Drawing.Size(13, 13)
        Me.lbl_id1.TabIndex = 33
        Me.lbl_id1.Text = "0"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGridView1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Argentum Novus", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.CornflowerBlue
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.CornflowerBlue
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.EnableHeadersVisualStyles = False
        Me.DataGridView1.Location = New System.Drawing.Point(44, 88)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Argentum Novus", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.CornflowerBlue
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Argentum Novus", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.DodgerBlue
        Me.DataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(750, 344)
        Me.DataGridView1.TabIndex = 34
        '
        'btn_refresh
        '
        Me.btn_refresh.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_refresh.BackColor = System.Drawing.Color.Transparent
        Me.btn_refresh.FlatAppearance.BorderSize = 0
        Me.btn_refresh.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue
        Me.btn_refresh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue
        Me.btn_refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_refresh.IconChar = FontAwesome.Sharp.IconChar.ArrowRotateBack
        Me.btn_refresh.IconColor = System.Drawing.Color.White
        Me.btn_refresh.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_refresh.IconSize = 25
        Me.btn_refresh.Location = New System.Drawing.Point(766, 62)
        Me.btn_refresh.Name = "btn_refresh"
        Me.btn_refresh.Size = New System.Drawing.Size(28, 20)
        Me.btn_refresh.TabIndex = 35
        Me.btn_refresh.UseVisualStyleBackColor = False
        '
        'PrintDocument1
        '
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Document = Me.PrintDocument1
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'btn_print
        '
        Me.btn_print.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btn_print.BackColor = System.Drawing.Color.Transparent
        Me.btn_print.FlatAppearance.BorderSize = 0
        Me.btn_print.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue
        Me.btn_print.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue
        Me.btn_print.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_print.Font = New System.Drawing.Font("Argentum Novus", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_print.ForeColor = System.Drawing.Color.White
        Me.btn_print.IconChar = FontAwesome.Sharp.IconChar.Print
        Me.btn_print.IconColor = System.Drawing.Color.White
        Me.btn_print.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_print.IconSize = 30
        Me.btn_print.Location = New System.Drawing.Point(769, 0)
        Me.btn_print.Name = "btn_print"
        Me.btn_print.Size = New System.Drawing.Size(75, 42)
        Me.btn_print.TabIndex = 36
        Me.btn_print.Text = "Print"
        Me.btn_print.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_print.UseVisualStyleBackColor = False
        '
        'btn_export
        '
        Me.btn_export.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btn_export.BackColor = System.Drawing.Color.Transparent
        Me.btn_export.FlatAppearance.BorderSize = 0
        Me.btn_export.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue
        Me.btn_export.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue
        Me.btn_export.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_export.Font = New System.Drawing.Font("Argentum Novus", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_export.ForeColor = System.Drawing.Color.White
        Me.btn_export.IconChar = FontAwesome.Sharp.IconChar.FileImport
        Me.btn_export.IconColor = System.Drawing.Color.White
        Me.btn_export.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_export.IconSize = 30
        Me.btn_export.Location = New System.Drawing.Point(674, 0)
        Me.btn_export.Name = "btn_export"
        Me.btn_export.Size = New System.Drawing.Size(89, 42)
        Me.btn_export.TabIndex = 41
        Me.btn_export.Text = "EXPORT"
        Me.btn_export.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_export.UseVisualStyleBackColor = False
        '
        'btn_sIn
        '
        Me.btn_sIn.BackColor = System.Drawing.Color.Transparent
        Me.btn_sIn.FlatAppearance.BorderSize = 0
        Me.btn_sIn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue
        Me.btn_sIn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue
        Me.btn_sIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_sIn.Font = New System.Drawing.Font("Argentum Novus", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_sIn.ForeColor = System.Drawing.Color.White
        Me.btn_sIn.IconChar = FontAwesome.Sharp.IconChar.CartArrowDown
        Me.btn_sIn.IconColor = System.Drawing.Color.White
        Me.btn_sIn.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_sIn.IconSize = 30
        Me.btn_sIn.Location = New System.Drawing.Point(275, 451)
        Me.btn_sIn.Name = "btn_sIn"
        Me.btn_sIn.Size = New System.Drawing.Size(117, 43)
        Me.btn_sIn.TabIndex = 49
        Me.btn_sIn.Text = "STOCK IN"
        Me.btn_sIn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_sIn.UseVisualStyleBackColor = False
        '
        'btn_back
        '
        Me.btn_back.BackColor = System.Drawing.Color.Transparent
        Me.btn_back.FlatAppearance.BorderSize = 0
        Me.btn_back.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue
        Me.btn_back.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue
        Me.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_back.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft
        Me.btn_back.IconColor = System.Drawing.Color.White
        Me.btn_back.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_back.IconSize = 20
        Me.btn_back.Location = New System.Drawing.Point(12, 9)
        Me.btn_back.Name = "btn_back"
        Me.btn_back.Size = New System.Drawing.Size(27, 23)
        Me.btn_back.TabIndex = 61
        Me.btn_back.UseVisualStyleBackColor = False
        '
        'btn_sDeactivate
        '
        Me.btn_sDeactivate.BackColor = System.Drawing.Color.Transparent
        Me.btn_sDeactivate.FlatAppearance.BorderSize = 0
        Me.btn_sDeactivate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue
        Me.btn_sDeactivate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue
        Me.btn_sDeactivate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_sDeactivate.Font = New System.Drawing.Font("Argentum Novus", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_sDeactivate.ForeColor = System.Drawing.Color.White
        Me.btn_sDeactivate.IconChar = FontAwesome.Sharp.IconChar.FileCircleMinus
        Me.btn_sDeactivate.IconColor = System.Drawing.Color.White
        Me.btn_sDeactivate.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_sDeactivate.IconSize = 30
        Me.btn_sDeactivate.Location = New System.Drawing.Point(639, 7)
        Me.btn_sDeactivate.Name = "btn_sDeactivate"
        Me.btn_sDeactivate.Size = New System.Drawing.Size(28, 27)
        Me.btn_sDeactivate.TabIndex = 62
        Me.btn_sDeactivate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_sDeactivate.UseVisualStyleBackColor = False
        '
        'btn_deactivate
        '
        Me.btn_deactivate.BackColor = System.Drawing.Color.Transparent
        Me.btn_deactivate.FlatAppearance.BorderSize = 0
        Me.btn_deactivate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue
        Me.btn_deactivate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue
        Me.btn_deactivate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_deactivate.Font = New System.Drawing.Font("Argentum Novus", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_deactivate.ForeColor = System.Drawing.Color.White
        Me.btn_deactivate.IconChar = FontAwesome.Sharp.IconChar.Trash
        Me.btn_deactivate.IconColor = System.Drawing.Color.White
        Me.btn_deactivate.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_deactivate.IconSize = 25
        Me.btn_deactivate.Location = New System.Drawing.Point(739, 59)
        Me.btn_deactivate.Name = "btn_deactivate"
        Me.btn_deactivate.Size = New System.Drawing.Size(28, 27)
        Me.btn_deactivate.TabIndex = 63
        Me.btn_deactivate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_deactivate.UseVisualStyleBackColor = False
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AllowUserToDeleteRows = False
        Me.DataGridView2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView2.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGridView2.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Argentum Novus", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.CornflowerBlue
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView2.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.CornflowerBlue
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView2.DefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridView2.EnableHeadersVisualStyles = False
        Me.DataGridView2.Location = New System.Drawing.Point(44, 88)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.ReadOnly = True
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Argentum Novus", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.CornflowerBlue
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView2.RowHeadersDefaultCellStyle = DataGridViewCellStyle7
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Argentum Novus", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.DodgerBlue
        Me.DataGridView2.RowsDefaultCellStyle = DataGridViewCellStyle8
        Me.DataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView2.Size = New System.Drawing.Size(750, 344)
        Me.DataGridView2.TabIndex = 64
        '
        'btn_restore
        '
        Me.btn_restore.BackColor = System.Drawing.Color.Transparent
        Me.btn_restore.FlatAppearance.BorderSize = 0
        Me.btn_restore.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue
        Me.btn_restore.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue
        Me.btn_restore.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_restore.Font = New System.Drawing.Font("Argentum Novus", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_restore.ForeColor = System.Drawing.Color.White
        Me.btn_restore.IconChar = FontAwesome.Sharp.IconChar.ClockRotateLeft
        Me.btn_restore.IconColor = System.Drawing.Color.White
        Me.btn_restore.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_restore.IconSize = 25
        Me.btn_restore.Location = New System.Drawing.Point(379, 449)
        Me.btn_restore.Name = "btn_restore"
        Me.btn_restore.Size = New System.Drawing.Size(117, 43)
        Me.btn_restore.TabIndex = 65
        Me.btn_restore.Text = "RESTORE"
        Me.btn_restore.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_restore.UseVisualStyleBackColor = False
        '
        'btn_export2
        '
        Me.btn_export2.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btn_export2.BackColor = System.Drawing.Color.Transparent
        Me.btn_export2.FlatAppearance.BorderSize = 0
        Me.btn_export2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue
        Me.btn_export2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue
        Me.btn_export2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_export2.Font = New System.Drawing.Font("Argentum Novus", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_export2.ForeColor = System.Drawing.Color.White
        Me.btn_export2.IconChar = FontAwesome.Sharp.IconChar.FileImport
        Me.btn_export2.IconColor = System.Drawing.Color.White
        Me.btn_export2.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_export2.IconSize = 30
        Me.btn_export2.Location = New System.Drawing.Point(674, 0)
        Me.btn_export2.Name = "btn_export2"
        Me.btn_export2.Size = New System.Drawing.Size(89, 42)
        Me.btn_export2.TabIndex = 66
        Me.btn_export2.Text = "EXPORT"
        Me.btn_export2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_export2.UseVisualStyleBackColor = False
        '
        'btn_print2
        '
        Me.btn_print2.BackColor = System.Drawing.Color.Transparent
        Me.btn_print2.FlatAppearance.BorderSize = 0
        Me.btn_print2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue
        Me.btn_print2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue
        Me.btn_print2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_print2.Font = New System.Drawing.Font("Argentum Novus", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_print2.ForeColor = System.Drawing.Color.White
        Me.btn_print2.IconChar = FontAwesome.Sharp.IconChar.Print
        Me.btn_print2.IconColor = System.Drawing.Color.White
        Me.btn_print2.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_print2.IconSize = 30
        Me.btn_print2.Location = New System.Drawing.Point(769, 0)
        Me.btn_print2.Name = "btn_print2"
        Me.btn_print2.Size = New System.Drawing.Size(75, 42)
        Me.btn_print2.TabIndex = 67
        Me.btn_print2.Text = "Print"
        Me.btn_print2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_print2.UseVisualStyleBackColor = False
        '
        'PrintDocument2
        '
        '
        'btn_delete
        '
        Me.btn_delete.BackColor = System.Drawing.Color.Transparent
        Me.btn_delete.FlatAppearance.BorderSize = 0
        Me.btn_delete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue
        Me.btn_delete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue
        Me.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_delete.Font = New System.Drawing.Font("Argentum Novus", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_delete.ForeColor = System.Drawing.Color.White
        Me.btn_delete.IconChar = FontAwesome.Sharp.IconChar.Trash
        Me.btn_delete.IconColor = System.Drawing.Color.White
        Me.btn_delete.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_delete.IconSize = 25
        Me.btn_delete.Location = New System.Drawing.Point(739, 59)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(28, 27)
        Me.btn_delete.TabIndex = 68
        Me.btn_delete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_delete.UseVisualStyleBackColor = False
        '
        'lbl_header
        '
        Me.lbl_header.AutoSize = True
        Me.lbl_header.BackColor = System.Drawing.Color.Transparent
        Me.lbl_header.Font = New System.Drawing.Font("Argentum Novus", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_header.ForeColor = System.Drawing.Color.White
        Me.lbl_header.Location = New System.Drawing.Point(294, 43)
        Me.lbl_header.Name = "lbl_header"
        Me.lbl_header.Size = New System.Drawing.Size(239, 70)
        Me.lbl_header.TabIndex = 69
        Me.lbl_header.Text = "PRODUCT LIST" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'txt_search2
        '
        Me.txt_search2.Font = New System.Drawing.Font("Argentum Novus", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_search2.ForeColor = System.Drawing.Color.SteelBlue
        Me.txt_search2.Location = New System.Drawing.Point(103, 55)
        Me.txt_search2.Name = "txt_search2"
        Me.txt_search2.Size = New System.Drawing.Size(158, 23)
        Me.txt_search2.TabIndex = 70
        '
        'prodList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(845, 506)
        Me.Controls.Add(Me.txt_search2)
        Me.Controls.Add(Me.btn_delete)
        Me.Controls.Add(Me.btn_print2)
        Me.Controls.Add(Me.btn_export2)
        Me.Controls.Add(Me.btn_restore)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.btn_deactivate)
        Me.Controls.Add(Me.btn_sDeactivate)
        Me.Controls.Add(Me.btn_back)
        Me.Controls.Add(Me.btn_sIn)
        Me.Controls.Add(Me.btn_export)
        Me.Controls.Add(Me.btn_print)
        Me.Controls.Add(Me.btn_refresh)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_search)
        Me.Controls.Add(Me.btn_update)
        Me.Controls.Add(Me.lbl_id1)
        Me.Controls.Add(Me.lbl_header)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "prodList"
        Me.Text = "STOCKSLOGIX"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_update As FontAwesome.Sharp.IconButton
    Friend WithEvents txt_search As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lbl_id1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btn_refresh As FontAwesome.Sharp.IconButton
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents btn_print As FontAwesome.Sharp.IconButton
    Friend WithEvents btn_export As FontAwesome.Sharp.IconButton
    Friend WithEvents btn_sIn As FontAwesome.Sharp.IconButton
    Friend WithEvents btn_back As FontAwesome.Sharp.IconButton
    Friend WithEvents btn_sDeactivate As FontAwesome.Sharp.IconButton
    Friend WithEvents btn_deactivate As FontAwesome.Sharp.IconButton
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents btn_restore As FontAwesome.Sharp.IconButton
    Friend WithEvents btn_export2 As FontAwesome.Sharp.IconButton
    Friend WithEvents btn_print2 As FontAwesome.Sharp.IconButton
    Friend WithEvents PrintDocument2 As Printing.PrintDocument
    Friend WithEvents btn_delete As FontAwesome.Sharp.IconButton
    Friend WithEvents lbl_header As Label
    Friend WithEvents txt_search2 As TextBox
End Class
