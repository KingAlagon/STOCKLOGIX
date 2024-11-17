<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class eMain_Form
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(eMain_Form))
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.panel_dashboard = New System.Windows.Forms.Panel()
        Me.panel_user = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.lbl_username = New System.Windows.Forms.Label()
        Me.btn_logout = New FontAwesome.Sharp.IconButton()
        Me.stock_panel = New System.Windows.Forms.Panel()
        Me.btn_stockout = New System.Windows.Forms.Button()
        Me.btn_stock = New FontAwesome.Sharp.IconButton()
        Me.prod_panel = New System.Windows.Forms.Panel()
        Me.btn_prodList = New System.Windows.Forms.Button()
        Me.btn_addProd = New System.Windows.Forms.Button()
        Me.btn_catProd = New FontAwesome.Sharp.IconButton()
        Me.paneldash = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.panel_logo = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.panel_title = New System.Windows.Forms.Panel()
        Me.btn_exit = New FontAwesome.Sharp.IconButton()
        Me.btn_minimize = New FontAwesome.Sharp.IconButton()
        Me.panel_desktop = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btn_POS = New System.Windows.Forms.Button()
        Me.BunifuColorTransition1 = New Bunifu.Framework.UI.BunifuColorTransition(Me.components)
        Me.panel_dashboard.SuspendLayout()
        Me.panel_user.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.stock_panel.SuspendLayout()
        Me.prod_panel.SuspendLayout()
        Me.paneldash.SuspendLayout()
        Me.panel_logo.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel_title.SuspendLayout()
        Me.SuspendLayout()
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 40
        Me.BunifuElipse1.TargetControl = Me
        '
        'panel_dashboard
        '
        Me.panel_dashboard.AutoScroll = True
        Me.panel_dashboard.BackColor = System.Drawing.Color.Transparent
        Me.panel_dashboard.BackgroundImage = CType(resources.GetObject("panel_dashboard.BackgroundImage"), System.Drawing.Image)
        Me.panel_dashboard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.panel_dashboard.Controls.Add(Me.btn_POS)
        Me.panel_dashboard.Controls.Add(Me.panel_user)
        Me.panel_dashboard.Controls.Add(Me.btn_logout)
        Me.panel_dashboard.Controls.Add(Me.stock_panel)
        Me.panel_dashboard.Controls.Add(Me.btn_stock)
        Me.panel_dashboard.Controls.Add(Me.prod_panel)
        Me.panel_dashboard.Controls.Add(Me.btn_catProd)
        Me.panel_dashboard.Controls.Add(Me.paneldash)
        Me.panel_dashboard.Controls.Add(Me.panel_logo)
        Me.panel_dashboard.Dock = System.Windows.Forms.DockStyle.Left
        Me.panel_dashboard.Location = New System.Drawing.Point(0, 0)
        Me.panel_dashboard.Name = "panel_dashboard"
        Me.panel_dashboard.Size = New System.Drawing.Size(200, 636)
        Me.panel_dashboard.TabIndex = 0
        '
        'panel_user
        '
        Me.panel_user.Controls.Add(Me.PictureBox2)
        Me.panel_user.Controls.Add(Me.lbl_username)
        Me.panel_user.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panel_user.Location = New System.Drawing.Point(0, 573)
        Me.panel_user.Name = "panel_user"
        Me.panel_user.Size = New System.Drawing.Size(200, 33)
        Me.panel_user.TabIndex = 13
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
        Me.btn_logout.Location = New System.Drawing.Point(0, 606)
        Me.btn_logout.Name = "btn_logout"
        Me.btn_logout.Size = New System.Drawing.Size(200, 30)
        Me.btn_logout.TabIndex = 12
        Me.btn_logout.Text = "LOGOUT"
        Me.btn_logout.UseVisualStyleBackColor = False
        '
        'stock_panel
        '
        Me.stock_panel.BackColor = System.Drawing.Color.Transparent
        Me.stock_panel.Controls.Add(Me.btn_stockout)
        Me.stock_panel.Dock = System.Windows.Forms.DockStyle.Top
        Me.stock_panel.Location = New System.Drawing.Point(0, 431)
        Me.stock_panel.MaximumSize = New System.Drawing.Size(200, 150)
        Me.stock_panel.MinimumSize = New System.Drawing.Size(200, 20)
        Me.stock_panel.Name = "stock_panel"
        Me.stock_panel.Size = New System.Drawing.Size(200, 55)
        Me.stock_panel.TabIndex = 11
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
        Me.btn_stock.IconSize = 40
        Me.btn_stock.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_stock.Location = New System.Drawing.Point(0, 371)
        Me.btn_stock.Name = "btn_stock"
        Me.btn_stock.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btn_stock.Size = New System.Drawing.Size(200, 60)
        Me.btn_stock.TabIndex = 10
        Me.btn_stock.Text = "STOCKS"
        Me.btn_stock.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_stock.UseVisualStyleBackColor = False
        '
        'prod_panel
        '
        Me.prod_panel.BackColor = System.Drawing.Color.Transparent
        Me.prod_panel.Controls.Add(Me.btn_prodList)
        Me.prod_panel.Controls.Add(Me.btn_addProd)
        Me.prod_panel.Dock = System.Windows.Forms.DockStyle.Top
        Me.prod_panel.Location = New System.Drawing.Point(0, 268)
        Me.prod_panel.MaximumSize = New System.Drawing.Size(200, 150)
        Me.prod_panel.MinimumSize = New System.Drawing.Size(200, 100)
        Me.prod_panel.Name = "prod_panel"
        Me.prod_panel.Size = New System.Drawing.Size(200, 103)
        Me.prod_panel.TabIndex = 9
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
        Me.btn_prodList.Location = New System.Drawing.Point(0, 50)
        Me.btn_prodList.Name = "btn_prodList"
        Me.btn_prodList.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.btn_prodList.Size = New System.Drawing.Size(200, 53)
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
        Me.btn_catProd.Location = New System.Drawing.Point(0, 208)
        Me.btn_catProd.Name = "btn_catProd"
        Me.btn_catProd.Size = New System.Drawing.Size(200, 60)
        Me.btn_catProd.TabIndex = 6
        Me.btn_catProd.Text = "CATEGORY PRODUCTS"
        Me.btn_catProd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_catProd.UseVisualStyleBackColor = False
        '
        'paneldash
        '
        Me.paneldash.BackColor = System.Drawing.Color.Transparent
        Me.paneldash.Controls.Add(Me.Label1)
        Me.paneldash.Controls.Add(Me.Label2)
        Me.paneldash.Dock = System.Windows.Forms.DockStyle.Top
        Me.paneldash.Location = New System.Drawing.Point(0, 130)
        Me.paneldash.Name = "paneldash"
        Me.paneldash.Size = New System.Drawing.Size(200, 78)
        Me.paneldash.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Label1.Location = New System.Drawing.Point(32, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(137, 24)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "DASHBOARD"
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
        Me.panel_logo.Controls.Add(Me.PictureBox1)
        Me.panel_logo.Dock = System.Windows.Forms.DockStyle.Top
        Me.panel_logo.Location = New System.Drawing.Point(0, 0)
        Me.panel_logo.Name = "panel_logo"
        Me.panel_logo.Size = New System.Drawing.Size(200, 130)
        Me.panel_logo.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 27)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(171, 103)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
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
        Me.panel_title.TabIndex = 2
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
        Me.btn_minimize.Location = New System.Drawing.Point(785, 12)
        Me.btn_minimize.Name = "btn_minimize"
        Me.btn_minimize.Size = New System.Drawing.Size(16, 29)
        Me.btn_minimize.TabIndex = 3
        Me.btn_minimize.UseVisualStyleBackColor = True
        '
        'panel_desktop
        '
        Me.panel_desktop.BackColor = System.Drawing.Color.Transparent
        Me.panel_desktop.BackgroundImage = CType(resources.GetObject("panel_desktop.BackgroundImage"), System.Drawing.Image)
        Me.panel_desktop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.panel_desktop.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panel_desktop.Location = New System.Drawing.Point(200, 130)
        Me.panel_desktop.Name = "panel_desktop"
        Me.panel_desktop.Size = New System.Drawing.Size(845, 506)
        Me.panel_desktop.TabIndex = 2
        '
        'Button2
        '
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(0, 0)
        Me.Button2.Name = "Button2"
        Me.Button2.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.Button2.Size = New System.Drawing.Size(200, 50)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "ADD PRODUCT"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(0, 50)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(200, 53)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "PRODUCT LIST"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btn_POS
        '
        Me.btn_POS.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_POS.FlatAppearance.BorderSize = 0
        Me.btn_POS.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue
        Me.btn_POS.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue
        Me.btn_POS.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_POS.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_POS.ForeColor = System.Drawing.Color.White
        Me.btn_POS.Image = CType(resources.GetObject("btn_POS.Image"), System.Drawing.Image)
        Me.btn_POS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_POS.Location = New System.Drawing.Point(0, 486)
        Me.btn_POS.Name = "btn_POS"
        Me.btn_POS.Padding = New System.Windows.Forms.Padding(15, 0, 0, 0)
        Me.btn_POS.Size = New System.Drawing.Size(200, 50)
        Me.btn_POS.TabIndex = 6
        Me.btn_POS.Text = " POS"
        Me.btn_POS.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_POS.UseVisualStyleBackColor = True
        '
        'BunifuColorTransition1
        '
        Me.BunifuColorTransition1.Color1 = System.Drawing.Color.DimGray
        Me.BunifuColorTransition1.Color2 = System.Drawing.Color.GreenYellow
        Me.BunifuColorTransition1.ProgessValue = 8
        '
        'eMain_Form
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
        Me.Name = "eMain_Form"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "STOCKSLOGIX"
        Me.panel_dashboard.ResumeLayout(False)
        Me.panel_user.ResumeLayout(False)
        Me.panel_user.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.stock_panel.ResumeLayout(False)
        Me.prod_panel.ResumeLayout(False)
        Me.paneldash.ResumeLayout(False)
        Me.paneldash.PerformLayout()
        Me.panel_logo.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel_title.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents panel_dashboard As Panel
    Friend WithEvents panel_logo As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents paneldash As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents panel_title As Panel
    Friend WithEvents btn_exit As FontAwesome.Sharp.IconButton
    Friend WithEvents btn_minimize As FontAwesome.Sharp.IconButton
    Friend WithEvents btn_catProd As FontAwesome.Sharp.IconButton
    Friend WithEvents prod_panel As Panel
    Friend WithEvents btn_prodList As Button
    Friend WithEvents btn_addProd As Button
    Friend WithEvents stock_panel As Panel
    Friend WithEvents btn_stockout As Button
    Friend WithEvents btn_stock As FontAwesome.Sharp.IconButton
    Friend WithEvents btn_logout As FontAwesome.Sharp.IconButton
    Friend WithEvents panel_desktop As Panel
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents lbl_username As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents panel_user As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents btn_POS As Button
    Public WithEvents BunifuColorTransition1 As Bunifu.Framework.UI.BunifuColorTransition
End Class
