<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class userlist
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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(userlist))
        Me.cmb_list = New System.Windows.Forms.ComboBox()
        Me.btn_update = New FontAwesome.Sharp.IconButton()
        Me.lbl_id1 = New System.Windows.Forms.Label()
        Me.btn_refresh = New FontAwesome.Sharp.IconButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_search1 = New System.Windows.Forms.TextBox()
        Me.txt_search2 = New System.Windows.Forms.TextBox()
        Me.btn_refresh2 = New FontAwesome.Sharp.IconButton()
        Me.btn_deactivate = New FontAwesome.Sharp.IconButton()
        Me.btn_sDeactivate = New FontAwesome.Sharp.IconButton()
        Me.lbl_id = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btn_restore = New FontAwesome.Sharp.IconButton()
        Me.btn_back = New FontAwesome.Sharp.IconButton()
        Me.btn_delete = New FontAwesome.Sharp.IconButton()
        Me.DataGridView3 = New System.Windows.Forms.DataGridView()
        Me.txt_search3 = New System.Windows.Forms.TextBox()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmb_list
        '
        Me.cmb_list.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmb_list.Font = New System.Drawing.Font("Argentum Novus", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_list.ForeColor = System.Drawing.Color.SteelBlue
        Me.cmb_list.FormattingEnabled = True
        Me.cmb_list.ItemHeight = 18
        Me.cmb_list.Location = New System.Drawing.Point(331, 33)
        Me.cmb_list.Name = "cmb_list"
        Me.cmb_list.Size = New System.Drawing.Size(209, 26)
        Me.cmb_list.TabIndex = 1
        Me.cmb_list.Text = " <==    SELECT USER  ==>"
        '
        'btn_update
        '
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
        Me.btn_update.Location = New System.Drawing.Point(379, 449)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Size = New System.Drawing.Size(107, 43)
        Me.btn_update.TabIndex = 4
        Me.btn_update.Text = "UPDATE"
        Me.btn_update.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_update.UseVisualStyleBackColor = False
        '
        'lbl_id1
        '
        Me.lbl_id1.AutoSize = True
        Me.lbl_id1.BackColor = System.Drawing.Color.Transparent
        Me.lbl_id1.Location = New System.Drawing.Point(78, 116)
        Me.lbl_id1.Name = "lbl_id1"
        Me.lbl_id1.Size = New System.Drawing.Size(0, 13)
        Me.lbl_id1.TabIndex = 6
        '
        'btn_refresh
        '
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
        Me.btn_refresh.TabIndex = 7
        Me.btn_refresh.UseVisualStyleBackColor = False
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
        Me.Label1.TabIndex = 40
        Me.Label1.Text = "Search:"
        '
        'txt_search1
        '
        Me.txt_search1.Font = New System.Drawing.Font("Argentum Novus", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_search1.ForeColor = System.Drawing.Color.SteelBlue
        Me.txt_search1.Location = New System.Drawing.Point(103, 55)
        Me.txt_search1.Name = "txt_search1"
        Me.txt_search1.Size = New System.Drawing.Size(158, 23)
        Me.txt_search1.TabIndex = 39
        '
        'txt_search2
        '
        Me.txt_search2.Font = New System.Drawing.Font("Argentum Novus", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_search2.ForeColor = System.Drawing.Color.SteelBlue
        Me.txt_search2.Location = New System.Drawing.Point(103, 55)
        Me.txt_search2.Name = "txt_search2"
        Me.txt_search2.Size = New System.Drawing.Size(158, 23)
        Me.txt_search2.TabIndex = 41
        '
        'btn_refresh2
        '
        Me.btn_refresh2.BackColor = System.Drawing.Color.Transparent
        Me.btn_refresh2.FlatAppearance.BorderSize = 0
        Me.btn_refresh2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue
        Me.btn_refresh2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue
        Me.btn_refresh2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_refresh2.IconChar = FontAwesome.Sharp.IconChar.ArrowRotateBack
        Me.btn_refresh2.IconColor = System.Drawing.Color.White
        Me.btn_refresh2.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_refresh2.IconSize = 25
        Me.btn_refresh2.Location = New System.Drawing.Point(766, 62)
        Me.btn_refresh2.Name = "btn_refresh2"
        Me.btn_refresh2.Size = New System.Drawing.Size(28, 20)
        Me.btn_refresh2.TabIndex = 42
        Me.btn_refresh2.UseVisualStyleBackColor = False
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
        Me.btn_deactivate.Location = New System.Drawing.Point(732, 59)
        Me.btn_deactivate.Name = "btn_deactivate"
        Me.btn_deactivate.Size = New System.Drawing.Size(28, 27)
        Me.btn_deactivate.TabIndex = 50
        Me.btn_deactivate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_deactivate.UseVisualStyleBackColor = False
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
        Me.btn_sDeactivate.Location = New System.Drawing.Point(805, 12)
        Me.btn_sDeactivate.Name = "btn_sDeactivate"
        Me.btn_sDeactivate.Size = New System.Drawing.Size(28, 27)
        Me.btn_sDeactivate.TabIndex = 51
        Me.btn_sDeactivate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_sDeactivate.UseVisualStyleBackColor = False
        '
        'lbl_id
        '
        Me.lbl_id.AutoSize = True
        Me.lbl_id.BackColor = System.Drawing.Color.Transparent
        Me.lbl_id.Location = New System.Drawing.Point(41, 88)
        Me.lbl_id.Name = "lbl_id"
        Me.lbl_id.Size = New System.Drawing.Size(13, 13)
        Me.lbl_id.TabIndex = 54
        Me.lbl_id.Text = "0"
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
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.CornflowerBlue
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.EnableHeadersVisualStyles = False
        Me.DataGridView1.Location = New System.Drawing.Point(44, 88)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Argentum Novus", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.CornflowerBlue
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.RowHeadersWidth = 50
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Argentum Novus", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.DodgerBlue
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridView1.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridView1.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowTemplate.Height = 50
        Me.DataGridView1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(750, 344)
        Me.DataGridView1.TabIndex = 55
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
        Me.btn_restore.TabIndex = 57
        Me.btn_restore.Text = "RESTORE"
        Me.btn_restore.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_restore.UseVisualStyleBackColor = False
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
        Me.btn_back.TabIndex = 59
        Me.btn_back.UseVisualStyleBackColor = False
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
        Me.btn_delete.Location = New System.Drawing.Point(732, 59)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(28, 27)
        Me.btn_delete.TabIndex = 60
        Me.btn_delete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_delete.UseVisualStyleBackColor = False
        '
        'DataGridView3
        '
        Me.DataGridView3.AllowUserToAddRows = False
        Me.DataGridView3.AllowUserToDeleteRows = False
        Me.DataGridView3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView3.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView3.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGridView3.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Argentum Novus", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.CornflowerBlue
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView3.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.CornflowerBlue
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView3.DefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridView3.EnableHeadersVisualStyles = False
        Me.DataGridView3.Location = New System.Drawing.Point(44, 88)
        Me.DataGridView3.Name = "DataGridView3"
        Me.DataGridView3.ReadOnly = True
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Argentum Novus", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.CornflowerBlue
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView3.RowHeadersDefaultCellStyle = DataGridViewCellStyle7
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Argentum Novus", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.DodgerBlue
        Me.DataGridView3.RowsDefaultCellStyle = DataGridViewCellStyle8
        Me.DataGridView3.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView3.Size = New System.Drawing.Size(750, 344)
        Me.DataGridView3.TabIndex = 61
        '
        'txt_search3
        '
        Me.txt_search3.Font = New System.Drawing.Font("Argentum Novus", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_search3.ForeColor = System.Drawing.Color.SteelBlue
        Me.txt_search3.Location = New System.Drawing.Point(103, 55)
        Me.txt_search3.Name = "txt_search3"
        Me.txt_search3.Size = New System.Drawing.Size(158, 23)
        Me.txt_search3.TabIndex = 62
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
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Argentum Novus", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.CornflowerBlue
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView2.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.CornflowerBlue
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView2.DefaultCellStyle = DataGridViewCellStyle10
        Me.DataGridView2.EnableHeadersVisualStyles = False
        Me.DataGridView2.Location = New System.Drawing.Point(44, 88)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.ReadOnly = True
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Argentum Novus", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.CornflowerBlue
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView2.RowHeadersDefaultCellStyle = DataGridViewCellStyle11
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Argentum Novus", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle12.ForeColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.DodgerBlue
        Me.DataGridView2.RowsDefaultCellStyle = DataGridViewCellStyle12
        Me.DataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView2.Size = New System.Drawing.Size(750, 344)
        Me.DataGridView2.TabIndex = 63
        '
        'userlist
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(845, 506)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.txt_search3)
        Me.Controls.Add(Me.DataGridView3)
        Me.Controls.Add(Me.btn_delete)
        Me.Controls.Add(Me.btn_back)
        Me.Controls.Add(Me.btn_restore)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btn_sDeactivate)
        Me.Controls.Add(Me.btn_deactivate)
        Me.Controls.Add(Me.btn_refresh2)
        Me.Controls.Add(Me.txt_search2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_search1)
        Me.Controls.Add(Me.btn_refresh)
        Me.Controls.Add(Me.btn_update)
        Me.Controls.Add(Me.cmb_list)
        Me.Controls.Add(Me.lbl_id1)
        Me.Controls.Add(Me.lbl_id)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "userlist"
        Me.Text = "STOCKSLOGIX"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmb_list As ComboBox
    Friend WithEvents btn_update As FontAwesome.Sharp.IconButton
    Friend WithEvents lbl_id1 As Label
    Friend WithEvents btn_refresh As FontAwesome.Sharp.IconButton
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_search1 As TextBox
    Friend WithEvents txt_search2 As TextBox
    Friend WithEvents btn_refresh2 As FontAwesome.Sharp.IconButton
    Friend WithEvents btn_deactivate As FontAwesome.Sharp.IconButton
    Friend WithEvents btn_sDeactivate As FontAwesome.Sharp.IconButton
    Friend WithEvents lbl_id As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btn_restore As FontAwesome.Sharp.IconButton
    Friend WithEvents btn_back As FontAwesome.Sharp.IconButton
    Friend WithEvents btn_delete As FontAwesome.Sharp.IconButton
    Friend WithEvents DataGridView3 As DataGridView
    Friend WithEvents txt_search3 As TextBox
    Friend WithEvents DataGridView2 As DataGridView
End Class
