<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class main_form
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(main_form))
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.panel_title = New System.Windows.Forms.Panel()
        Me.btn_exit = New FontAwesome.Sharp.IconButton()
        Me.btn_minimize = New FontAwesome.Sharp.IconButton()
        Me.btn_logs = New FontAwesome.Sharp.IconButton()
        Me.panel_dashboard = New System.Windows.Forms.Panel()
        Me.stock_panel = New System.Windows.Forms.Panel()
        Me.btn_stockout = New System.Windows.Forms.Button()
        Me.btn_stock = New FontAwesome.Sharp.IconButton()
        Me.panel_user = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.lbl_username = New System.Windows.Forms.Label()
        Me.btn_logout = New FontAwesome.Sharp.IconButton()
        Me.prod_panel = New System.Windows.Forms.Panel()
        Me.btn_prodList = New System.Windows.Forms.Button()
        Me.btn_addProd = New System.Windows.Forms.Button()
        Me.btn_catProd = New FontAwesome.Sharp.IconButton()
        Me.panel_register = New System.Windows.Forms.Panel()
        Me.btn_suppList = New System.Windows.Forms.Button()
        Me.btn_addSupp = New System.Windows.Forms.Button()
        Me.btn_supplier = New FontAwesome.Sharp.IconButton()
        Me.registerpanel = New System.Windows.Forms.Panel()
        Me.btn_show = New System.Windows.Forms.Button()
        Me.btn_add = New System.Windows.Forms.Button()
        Me.btn_register = New FontAwesome.Sharp.IconButton()
        Me.paneldash = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.panel_logo = New System.Windows.Forms.Panel()
        Me.btn_slide = New FontAwesome.Sharp.IconButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.panel_desktop = New System.Windows.Forms.Panel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.panel_title.SuspendLayout()
        Me.panel_dashboard.SuspendLayout()
        Me.stock_panel.SuspendLayout()
        Me.panel_user.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.prod_panel.SuspendLayout()
        Me.panel_register.SuspendLayout()
        Me.registerpanel.SuspendLayout()
        Me.paneldash.SuspendLayout()
        Me.panel_logo.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 40
        Me.BunifuElipse1.TargetControl = Me
        '
        'panel_title
        '
        Me.panel_title.BackColor = System.Drawing.Color.Transparent
        Me.panel_title.BackgroundImage = CType(resources.GetObject("panel_title.BackgroundImage"), System.Drawing.Image)
        Me.panel_title.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.panel_title.Controls.Add(Me.btn_exit)
        Me.panel_title.Controls.Add(Me.btn_minimize)
        Me.panel_title.Dock = System.Windows.Forms.DockStyle.Top
        Me.panel_title.Location = New System.Drawing.Point(200, 0)
        Me.panel_title.Name = "panel_title"
        Me.panel_title.Size = New System.Drawing.Size(845, 130)
        Me.panel_title.TabIndex = 1
        '
        'btn_exit
        '
        Me.btn_exit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_exit.FlatAppearance.BorderSize = 0
        Me.btn_exit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btn_exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue
        Me.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_exit.Font = New System.Drawing.Font("Yu Gothic UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_exit.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btn_exit.IconChar = FontAwesome.Sharp.IconChar.XmarkCircle
        Me.btn_exit.IconColor = System.Drawing.Color.White
        Me.btn_exit.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_exit.IconSize = 30
        Me.btn_exit.Location = New System.Drawing.Point(803, 12)
        Me.btn_exit.Name = "btn_exit"
        Me.btn_exit.Size = New System.Drawing.Size(30, 29)
        Me.btn_exit.TabIndex = 6
        Me.btn_exit.UseVisualStyleBackColor = True
        '
        'btn_minimize
        '
        Me.btn_minimize.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_minimize.FlatAppearance.BorderSize = 0
        Me.btn_minimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue
        Me.btn_minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_minimize.Font = New System.Drawing.Font("Yu Gothic UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_minimize.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btn_minimize.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize
        Me.btn_minimize.IconColor = System.Drawing.Color.White
        Me.btn_minimize.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_minimize.IconSize = 30
        Me.btn_minimize.Location = New System.Drawing.Point(781, 12)
        Me.btn_minimize.Name = "btn_minimize"
        Me.btn_minimize.Size = New System.Drawing.Size(16, 29)
        Me.btn_minimize.TabIndex = 3
        Me.btn_minimize.UseVisualStyleBackColor = True
        '
        'btn_logs
        '
        Me.btn_logs.BackColor = System.Drawing.Color.Transparent
        Me.btn_logs.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_logs.FlatAppearance.BorderColor = System.Drawing.Color.Teal
        Me.btn_logs.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue
        Me.btn_logs.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue
        Me.btn_logs.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_logs.Font = New System.Drawing.Font("Yu Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_logs.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btn_logs.IconChar = FontAwesome.Sharp.IconChar.Lock
        Me.btn_logs.IconColor = System.Drawing.Color.White
        Me.btn_logs.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_logs.IconSize = 35
        Me.btn_logs.Location = New System.Drawing.Point(0, 808)
        Me.btn_logs.Name = "btn_logs"
        Me.btn_logs.Size = New System.Drawing.Size(183, 60)
        Me.btn_logs.TabIndex = 4
        Me.btn_logs.TabStop = False
        Me.btn_logs.Tag = ""
        Me.btn_logs.Text = "   LOGS"
        Me.btn_logs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_logs.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_logs.UseVisualStyleBackColor = False
        '
        'panel_dashboard
        '
        Me.panel_dashboard.AutoScroll = True
        Me.panel_dashboard.BackColor = System.Drawing.Color.White
        Me.panel_dashboard.BackgroundImage = CType(resources.GetObject("panel_dashboard.BackgroundImage"), System.Drawing.Image)
        Me.panel_dashboard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.panel_dashboard.Controls.Add(Me.btn_logs)
        Me.panel_dashboard.Controls.Add(Me.stock_panel)
        Me.panel_dashboard.Controls.Add(Me.btn_stock)
        Me.panel_dashboard.Controls.Add(Me.panel_user)
        Me.panel_dashboard.Controls.Add(Me.btn_logout)
        Me.panel_dashboard.Controls.Add(Me.prod_panel)
        Me.panel_dashboard.Controls.Add(Me.btn_catProd)
        Me.panel_dashboard.Controls.Add(Me.panel_register)
        Me.panel_dashboard.Controls.Add(Me.btn_supplier)
        Me.panel_dashboard.Controls.Add(Me.registerpanel)
        Me.panel_dashboard.Controls.Add(Me.btn_register)
        Me.panel_dashboard.Controls.Add(Me.paneldash)
        Me.panel_dashboard.Controls.Add(Me.panel_logo)
        Me.panel_dashboard.Dock = System.Windows.Forms.DockStyle.Left
        Me.panel_dashboard.Location = New System.Drawing.Point(0, 0)
        Me.panel_dashboard.Name = "panel_dashboard"
        Me.panel_dashboard.Size = New System.Drawing.Size(200, 636)
        Me.panel_dashboard.TabIndex = 0
        '
        'stock_panel
        '
        Me.stock_panel.BackColor = System.Drawing.Color.Transparent
        Me.stock_panel.Controls.Add(Me.btn_stockout)
        Me.stock_panel.Dock = System.Windows.Forms.DockStyle.Top
        Me.stock_panel.Location = New System.Drawing.Point(0, 754)
        Me.stock_panel.MaximumSize = New System.Drawing.Size(200, 150)
        Me.stock_panel.MinimumSize = New System.Drawing.Size(200, 50)
        Me.stock_panel.Name = "stock_panel"
        Me.stock_panel.Size = New System.Drawing.Size(200, 54)
        Me.stock_panel.TabIndex = 16
        '
        'btn_stockout
        '
        Me.btn_stockout.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_stockout.FlatAppearance.BorderSize = 0
        Me.btn_stockout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue
        Me.btn_stockout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue
        Me.btn_stockout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_stockout.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_stockout.ForeColor = System.Drawing.Color.White
        Me.btn_stockout.Image = CType(resources.GetObject("btn_stockout.Image"), System.Drawing.Image)
        Me.btn_stockout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_stockout.Location = New System.Drawing.Point(0, 0)
        Me.btn_stockout.Name = "btn_stockout"
        Me.btn_stockout.Padding = New System.Windows.Forms.Padding(25, 0, 0, 0)
        Me.btn_stockout.Size = New System.Drawing.Size(200, 50)
        Me.btn_stockout.TabIndex = 5
        Me.btn_stockout.Text = "STOCK LIST"
        Me.btn_stockout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_stockout.UseVisualStyleBackColor = True
        '
        'btn_stock
        '
        Me.btn_stock.BackColor = System.Drawing.Color.Transparent
        Me.btn_stock.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_stock.FlatAppearance.BorderColor = System.Drawing.Color.Teal
        Me.btn_stock.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue
        Me.btn_stock.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue
        Me.btn_stock.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_stock.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_stock.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btn_stock.IconChar = FontAwesome.Sharp.IconChar.CartFlatbed
        Me.btn_stock.IconColor = System.Drawing.Color.White
        Me.btn_stock.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_stock.IconSize = 35
        Me.btn_stock.Location = New System.Drawing.Point(0, 694)
        Me.btn_stock.Name = "btn_stock"
        Me.btn_stock.Size = New System.Drawing.Size(183, 60)
        Me.btn_stock.TabIndex = 15
        Me.btn_stock.Text = "STOCKS"
        Me.btn_stock.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_stock.UseVisualStyleBackColor = False
        '
        'panel_user
        '
        Me.panel_user.BackColor = System.Drawing.Color.Transparent
        Me.panel_user.Controls.Add(Me.PictureBox2)
        Me.panel_user.Controls.Add(Me.lbl_username)
        Me.panel_user.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panel_user.Location = New System.Drawing.Point(0, 868)
        Me.panel_user.Name = "panel_user"
        Me.panel_user.Size = New System.Drawing.Size(183, 33)
        Me.panel_user.TabIndex = 14
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(12, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(33, 33)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 27
        Me.PictureBox2.TabStop = False
        '
        'lbl_username
        '
        Me.lbl_username.AutoSize = True
        Me.lbl_username.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lbl_username.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_username.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lbl_username.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.lbl_username.Location = New System.Drawing.Point(64, 5)
        Me.lbl_username.Name = "lbl_username"
        Me.lbl_username.Size = New System.Drawing.Size(53, 25)
        Me.lbl_username.TabIndex = 5
        Me.lbl_username.Text = "Null"
        Me.lbl_username.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btn_logout
        '
        Me.btn_logout.BackColor = System.Drawing.Color.Transparent
        Me.btn_logout.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btn_logout.FlatAppearance.BorderSize = 0
        Me.btn_logout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue
        Me.btn_logout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue
        Me.btn_logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_logout.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_logout.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btn_logout.IconChar = FontAwesome.Sharp.IconChar.None
        Me.btn_logout.IconColor = System.Drawing.Color.White
        Me.btn_logout.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_logout.Location = New System.Drawing.Point(0, 901)
        Me.btn_logout.Name = "btn_logout"
        Me.btn_logout.Size = New System.Drawing.Size(183, 30)
        Me.btn_logout.TabIndex = 6
        Me.btn_logout.Text = "LOGOUT"
        Me.btn_logout.UseVisualStyleBackColor = False
        '
        'prod_panel
        '
        Me.prod_panel.BackColor = System.Drawing.Color.Transparent
        Me.prod_panel.Controls.Add(Me.btn_prodList)
        Me.prod_panel.Controls.Add(Me.btn_addProd)
        Me.prod_panel.Dock = System.Windows.Forms.DockStyle.Top
        Me.prod_panel.Location = New System.Drawing.Point(0, 591)
        Me.prod_panel.MaximumSize = New System.Drawing.Size(200, 150)
        Me.prod_panel.MinimumSize = New System.Drawing.Size(200, 100)
        Me.prod_panel.Name = "prod_panel"
        Me.prod_panel.Size = New System.Drawing.Size(200, 103)
        Me.prod_panel.TabIndex = 8
        '
        'btn_prodList
        '
        Me.btn_prodList.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_prodList.FlatAppearance.BorderSize = 0
        Me.btn_prodList.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue
        Me.btn_prodList.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue
        Me.btn_prodList.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_prodList.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_prodList.ForeColor = System.Drawing.Color.White
        Me.btn_prodList.Image = CType(resources.GetObject("btn_prodList.Image"), System.Drawing.Image)
        Me.btn_prodList.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_prodList.Location = New System.Drawing.Point(0, 50)
        Me.btn_prodList.Name = "btn_prodList"
        Me.btn_prodList.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.btn_prodList.Size = New System.Drawing.Size(200, 47)
        Me.btn_prodList.TabIndex = 5
        Me.btn_prodList.Text = "PRODUCT LIST"
        Me.btn_prodList.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_prodList.UseVisualStyleBackColor = True
        '
        'btn_addProd
        '
        Me.btn_addProd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_addProd.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_addProd.FlatAppearance.BorderSize = 0
        Me.btn_addProd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue
        Me.btn_addProd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue
        Me.btn_addProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_addProd.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_addProd.ForeColor = System.Drawing.Color.White
        Me.btn_addProd.Image = CType(resources.GetObject("btn_addProd.Image"), System.Drawing.Image)
        Me.btn_addProd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_addProd.Location = New System.Drawing.Point(0, 0)
        Me.btn_addProd.Name = "btn_addProd"
        Me.btn_addProd.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.btn_addProd.Size = New System.Drawing.Size(200, 50)
        Me.btn_addProd.TabIndex = 4
        Me.btn_addProd.Text = "ADD PRODUCT"
        Me.btn_addProd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_addProd.UseVisualStyleBackColor = True
        '
        'btn_catProd
        '
        Me.btn_catProd.BackColor = System.Drawing.Color.Transparent
        Me.btn_catProd.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_catProd.FlatAppearance.BorderColor = System.Drawing.Color.Teal
        Me.btn_catProd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue
        Me.btn_catProd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue
        Me.btn_catProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_catProd.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_catProd.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btn_catProd.IconChar = FontAwesome.Sharp.IconChar.ThList
        Me.btn_catProd.IconColor = System.Drawing.Color.White
        Me.btn_catProd.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_catProd.IconSize = 35
        Me.btn_catProd.Location = New System.Drawing.Point(0, 531)
        Me.btn_catProd.Name = "btn_catProd"
        Me.btn_catProd.Size = New System.Drawing.Size(183, 60)
        Me.btn_catProd.TabIndex = 2
        Me.btn_catProd.Text = "PRODUCTS"
        Me.btn_catProd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_catProd.UseVisualStyleBackColor = False
        '
        'panel_register
        '
        Me.panel_register.BackColor = System.Drawing.Color.Transparent
        Me.panel_register.Controls.Add(Me.btn_suppList)
        Me.panel_register.Controls.Add(Me.btn_addSupp)
        Me.panel_register.Dock = System.Windows.Forms.DockStyle.Top
        Me.panel_register.Location = New System.Drawing.Point(0, 431)
        Me.panel_register.MaximumSize = New System.Drawing.Size(200, 150)
        Me.panel_register.MinimumSize = New System.Drawing.Size(200, 100)
        Me.panel_register.Name = "panel_register"
        Me.panel_register.Size = New System.Drawing.Size(200, 100)
        Me.panel_register.TabIndex = 10
        '
        'btn_suppList
        '
        Me.btn_suppList.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_suppList.FlatAppearance.BorderSize = 0
        Me.btn_suppList.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue
        Me.btn_suppList.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue
        Me.btn_suppList.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_suppList.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_suppList.ForeColor = System.Drawing.Color.White
        Me.btn_suppList.Image = CType(resources.GetObject("btn_suppList.Image"), System.Drawing.Image)
        Me.btn_suppList.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_suppList.Location = New System.Drawing.Point(0, 50)
        Me.btn_suppList.Name = "btn_suppList"
        Me.btn_suppList.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.btn_suppList.Size = New System.Drawing.Size(200, 50)
        Me.btn_suppList.TabIndex = 5
        Me.btn_suppList.Text = "SUPPLIER LIST"
        Me.btn_suppList.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_suppList.UseVisualStyleBackColor = True
        '
        'btn_addSupp
        '
        Me.btn_addSupp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_addSupp.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_addSupp.FlatAppearance.BorderSize = 0
        Me.btn_addSupp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue
        Me.btn_addSupp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue
        Me.btn_addSupp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_addSupp.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_addSupp.ForeColor = System.Drawing.Color.White
        Me.btn_addSupp.Image = CType(resources.GetObject("btn_addSupp.Image"), System.Drawing.Image)
        Me.btn_addSupp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_addSupp.Location = New System.Drawing.Point(0, 0)
        Me.btn_addSupp.Name = "btn_addSupp"
        Me.btn_addSupp.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.btn_addSupp.Size = New System.Drawing.Size(200, 50)
        Me.btn_addSupp.TabIndex = 4
        Me.btn_addSupp.Text = "ADD SUPPLIER"
        Me.btn_addSupp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_addSupp.UseVisualStyleBackColor = True
        '
        'btn_supplier
        '
        Me.btn_supplier.BackColor = System.Drawing.Color.Transparent
        Me.btn_supplier.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_supplier.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_supplier.FlatAppearance.BorderColor = System.Drawing.Color.Teal
        Me.btn_supplier.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue
        Me.btn_supplier.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue
        Me.btn_supplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_supplier.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_supplier.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btn_supplier.IconChar = FontAwesome.Sharp.IconChar.UserTag
        Me.btn_supplier.IconColor = System.Drawing.Color.White
        Me.btn_supplier.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_supplier.IconSize = 40
        Me.btn_supplier.Location = New System.Drawing.Point(0, 371)
        Me.btn_supplier.Name = "btn_supplier"
        Me.btn_supplier.Size = New System.Drawing.Size(183, 60)
        Me.btn_supplier.TabIndex = 9
        Me.btn_supplier.Text = "SUPPLIER"
        Me.btn_supplier.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_supplier.UseVisualStyleBackColor = False
        '
        'registerpanel
        '
        Me.registerpanel.BackColor = System.Drawing.Color.Transparent
        Me.registerpanel.Controls.Add(Me.btn_show)
        Me.registerpanel.Controls.Add(Me.btn_add)
        Me.registerpanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.registerpanel.Location = New System.Drawing.Point(0, 268)
        Me.registerpanel.MaximumSize = New System.Drawing.Size(200, 150)
        Me.registerpanel.MinimumSize = New System.Drawing.Size(200, 100)
        Me.registerpanel.Name = "registerpanel"
        Me.registerpanel.Size = New System.Drawing.Size(200, 103)
        Me.registerpanel.TabIndex = 7
        '
        'btn_show
        '
        Me.btn_show.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_show.FlatAppearance.BorderSize = 0
        Me.btn_show.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue
        Me.btn_show.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue
        Me.btn_show.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_show.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_show.ForeColor = System.Drawing.Color.White
        Me.btn_show.Image = CType(resources.GetObject("btn_show.Image"), System.Drawing.Image)
        Me.btn_show.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_show.Location = New System.Drawing.Point(0, 50)
        Me.btn_show.Name = "btn_show"
        Me.btn_show.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.btn_show.Size = New System.Drawing.Size(200, 50)
        Me.btn_show.TabIndex = 5
        Me.btn_show.Text = "USER LIST"
        Me.btn_show.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_show.UseVisualStyleBackColor = True
        '
        'btn_add
        '
        Me.btn_add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_add.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_add.FlatAppearance.BorderSize = 0
        Me.btn_add.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue
        Me.btn_add.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue
        Me.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_add.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_add.ForeColor = System.Drawing.Color.White
        Me.btn_add.Image = CType(resources.GetObject("btn_add.Image"), System.Drawing.Image)
        Me.btn_add.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_add.Location = New System.Drawing.Point(0, 0)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.btn_add.Size = New System.Drawing.Size(200, 50)
        Me.btn_add.TabIndex = 4
        Me.btn_add.Text = "ADD USER"
        Me.btn_add.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_add.UseVisualStyleBackColor = True
        '
        'btn_register
        '
        Me.btn_register.BackColor = System.Drawing.Color.Transparent
        Me.btn_register.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_register.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_register.FlatAppearance.BorderColor = System.Drawing.Color.Teal
        Me.btn_register.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue
        Me.btn_register.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue
        Me.btn_register.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_register.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_register.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btn_register.IconChar = FontAwesome.Sharp.IconChar.AddressBook
        Me.btn_register.IconColor = System.Drawing.Color.White
        Me.btn_register.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_register.IconSize = 40
        Me.btn_register.Location = New System.Drawing.Point(0, 208)
        Me.btn_register.Name = "btn_register"
        Me.btn_register.Size = New System.Drawing.Size(183, 60)
        Me.btn_register.TabIndex = 1
        Me.btn_register.Text = "USER"
        Me.btn_register.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_register.UseVisualStyleBackColor = False
        '
        'paneldash
        '
        Me.paneldash.BackColor = System.Drawing.Color.Transparent
        Me.paneldash.Controls.Add(Me.Label2)
        Me.paneldash.Dock = System.Windows.Forms.DockStyle.Top
        Me.paneldash.Location = New System.Drawing.Point(0, 130)
        Me.paneldash.Name = "paneldash"
        Me.paneldash.Size = New System.Drawing.Size(183, 78)
        Me.paneldash.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label2.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Label2.Location = New System.Drawing.Point(30, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(137, 24)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "DASHBOARD"
        '
        'panel_logo
        '
        Me.panel_logo.BackColor = System.Drawing.Color.Transparent
        Me.panel_logo.Controls.Add(Me.btn_slide)
        Me.panel_logo.Controls.Add(Me.PictureBox1)
        Me.panel_logo.Dock = System.Windows.Forms.DockStyle.Top
        Me.panel_logo.Location = New System.Drawing.Point(0, 0)
        Me.panel_logo.Name = "panel_logo"
        Me.panel_logo.Size = New System.Drawing.Size(183, 130)
        Me.panel_logo.TabIndex = 0
        '
        'btn_slide
        '
        Me.btn_slide.BackColor = System.Drawing.Color.Transparent
        Me.btn_slide.FlatAppearance.BorderSize = 0
        Me.btn_slide.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_slide.ForeColor = System.Drawing.Color.Transparent
        Me.btn_slide.IconChar = FontAwesome.Sharp.IconChar.Bilibili
        Me.btn_slide.IconColor = System.Drawing.Color.White
        Me.btn_slide.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_slide.IconSize = 35
        Me.btn_slide.Location = New System.Drawing.Point(145, 3)
        Me.btn_slide.Name = "btn_slide"
        Me.btn_slide.Size = New System.Drawing.Size(35, 23)
        Me.btn_slide.TabIndex = 0
        Me.btn_slide.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 27)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(171, 103)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'panel_desktop
        '
        Me.panel_desktop.BackgroundImage = CType(resources.GetObject("panel_desktop.BackgroundImage"), System.Drawing.Image)
        Me.panel_desktop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.panel_desktop.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panel_desktop.Location = New System.Drawing.Point(200, 130)
        Me.panel_desktop.Name = "panel_desktop"
        Me.panel_desktop.Size = New System.Drawing.Size(845, 506)
        Me.panel_desktop.TabIndex = 2
        '
        'Timer1
        '
        '
        'main_form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1045, 636)
        Me.Controls.Add(Me.panel_desktop)
        Me.Controls.Add(Me.panel_title)
        Me.Controls.Add(Me.panel_dashboard)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(950, 636)
        Me.Name = "main_form"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "STOCKSLOGIX"
        Me.panel_title.ResumeLayout(False)
        Me.panel_dashboard.ResumeLayout(False)
        Me.stock_panel.ResumeLayout(False)
        Me.panel_user.ResumeLayout(False)
        Me.panel_user.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.prod_panel.ResumeLayout(False)
        Me.panel_register.ResumeLayout(False)
        Me.registerpanel.ResumeLayout(False)
        Me.paneldash.ResumeLayout(False)
        Me.paneldash.PerformLayout()
        Me.panel_logo.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents panel_dashboard As Panel
    Friend WithEvents panel_title As Panel
    Friend WithEvents btn_register As FontAwesome.Sharp.IconButton
    Friend WithEvents panel_logo As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents paneldash As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents btn_minimize As FontAwesome.Sharp.IconButton
    Friend WithEvents btn_exit As FontAwesome.Sharp.IconButton
    Friend WithEvents btn_logs As FontAwesome.Sharp.IconButton
    Friend WithEvents btn_logout As FontAwesome.Sharp.IconButton
    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents registerpanel As Panel
    Friend WithEvents btn_show As Button
    Friend WithEvents btn_add As Button
    Friend WithEvents prod_panel As Panel
    Friend WithEvents btn_prodList As Button
    Friend WithEvents btn_addProd As Button
    Friend WithEvents btn_catProd As FontAwesome.Sharp.IconButton
    Friend WithEvents panel_register As Panel
    Friend WithEvents btn_suppList As Button
    Friend WithEvents btn_addSupp As Button
    Friend WithEvents btn_supplier As FontAwesome.Sharp.IconButton
    Friend WithEvents panel_desktop As Panel
    Friend WithEvents panel_user As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents lbl_username As Label
    Friend WithEvents btn_stock As FontAwesome.Sharp.IconButton
    Friend WithEvents stock_panel As Panel
    Friend WithEvents btn_stockout As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents btn_slide As FontAwesome.Sharp.IconButton
    Friend WithEvents Timer2 As Timer
End Class
