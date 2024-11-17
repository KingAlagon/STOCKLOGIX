<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class stockInProduct
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(stockInProduct))
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.top_panel = New System.Windows.Forms.Panel()
        Me.btn_exit = New FontAwesome.Sharp.IconButton()
        Me.btn_minimize = New FontAwesome.Sharp.IconButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_sPrice = New System.Windows.Forms.TextBox()
        Me.txt_qty = New System.Windows.Forms.TextBox()
        Me.txt_price = New System.Windows.Forms.TextBox()
        Me.btn_suppPrice = New FontAwesome.Sharp.IconButton()
        Me.btn_qty = New FontAwesome.Sharp.IconButton()
        Me.btn_price = New FontAwesome.Sharp.IconButton()
        Me.lbl_pID = New System.Windows.Forms.Label()
        Me.lbl_pname = New System.Windows.Forms.Label()
        Me.lbl_sname = New System.Windows.Forms.Label()
        Me.lbl_ptype = New System.Windows.Forms.Label()
        Me.btn_sIN = New FontAwesome.Sharp.IconButton()
        Me.top_panel.SuspendLayout()
        Me.SuspendLayout()
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 20
        Me.BunifuElipse1.TargetControl = Me
        '
        'top_panel
        '
        Me.top_panel.BackColor = System.Drawing.Color.Transparent
        Me.top_panel.Controls.Add(Me.btn_exit)
        Me.top_panel.Controls.Add(Me.btn_minimize)
        Me.top_panel.Location = New System.Drawing.Point(0, -4)
        Me.top_panel.Name = "top_panel"
        Me.top_panel.Size = New System.Drawing.Size(449, 37)
        Me.top_panel.TabIndex = 21
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
        Me.btn_exit.Location = New System.Drawing.Point(416, 7)
        Me.btn_exit.Name = "btn_exit"
        Me.btn_exit.Size = New System.Drawing.Size(30, 29)
        Me.btn_exit.TabIndex = 8
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
        Me.btn_minimize.Location = New System.Drawing.Point(394, 3)
        Me.btn_minimize.Name = "btn_minimize"
        Me.btn_minimize.Size = New System.Drawing.Size(16, 29)
        Me.btn_minimize.TabIndex = 7
        Me.btn_minimize.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Argentum Novus", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(127, 75)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(196, 25)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "STOCK IN FORM"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Argentum Novus", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(59, 133)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 18)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "Product ID:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Argentum Novus", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(59, 341)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(76, 18)
        Me.Label6.TabIndex = 28
        Me.Label6.Text = "Quantity:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Argentum Novus", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(59, 307)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(116, 18)
        Me.Label5.TabIndex = 27
        Me.Label5.Text = "Supplier Price:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Argentum Novus", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(59, 238)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(111, 18)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "Product Type:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Argentum Novus", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(59, 202)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(125, 18)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "Supplier Name:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Argentum Novus", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(59, 167)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(121, 18)
        Me.Label7.TabIndex = 24
        Me.Label7.Text = "Product Name:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Argentum Novus", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(59, 272)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(112, 18)
        Me.Label8.TabIndex = 29
        Me.Label8.Text = "Product Price:"
        '
        'txt_sPrice
        '
        Me.txt_sPrice.BackColor = System.Drawing.Color.White
        Me.txt_sPrice.Enabled = False
        Me.txt_sPrice.Font = New System.Drawing.Font("Argentum Novus", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_sPrice.ForeColor = System.Drawing.Color.DodgerBlue
        Me.txt_sPrice.Location = New System.Drawing.Point(187, 304)
        Me.txt_sPrice.Multiline = True
        Me.txt_sPrice.Name = "txt_sPrice"
        Me.txt_sPrice.Size = New System.Drawing.Size(164, 24)
        Me.txt_sPrice.TabIndex = 3
        '
        'txt_qty
        '
        Me.txt_qty.BackColor = System.Drawing.Color.White
        Me.txt_qty.Enabled = False
        Me.txt_qty.Font = New System.Drawing.Font("Argentum Novus", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_qty.ForeColor = System.Drawing.Color.DodgerBlue
        Me.txt_qty.Location = New System.Drawing.Point(187, 338)
        Me.txt_qty.Multiline = True
        Me.txt_qty.Name = "txt_qty"
        Me.txt_qty.Size = New System.Drawing.Size(164, 24)
        Me.txt_qty.TabIndex = 5
        '
        'txt_price
        '
        Me.txt_price.BackColor = System.Drawing.Color.White
        Me.txt_price.Enabled = False
        Me.txt_price.Font = New System.Drawing.Font("Argentum Novus", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_price.ForeColor = System.Drawing.Color.DodgerBlue
        Me.txt_price.Location = New System.Drawing.Point(187, 269)
        Me.txt_price.Multiline = True
        Me.txt_price.Name = "txt_price"
        Me.txt_price.Size = New System.Drawing.Size(164, 24)
        Me.txt_price.TabIndex = 1
        '
        'btn_suppPrice
        '
        Me.btn_suppPrice.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_suppPrice.BackColor = System.Drawing.Color.Transparent
        Me.btn_suppPrice.FlatAppearance.BorderSize = 0
        Me.btn_suppPrice.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue
        Me.btn_suppPrice.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_suppPrice.Font = New System.Drawing.Font("Yu Gothic UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_suppPrice.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btn_suppPrice.IconChar = FontAwesome.Sharp.IconChar.PenToSquare
        Me.btn_suppPrice.IconColor = System.Drawing.Color.White
        Me.btn_suppPrice.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_suppPrice.IconSize = 30
        Me.btn_suppPrice.Location = New System.Drawing.Point(357, 300)
        Me.btn_suppPrice.Name = "btn_suppPrice"
        Me.btn_suppPrice.Size = New System.Drawing.Size(27, 34)
        Me.btn_suppPrice.TabIndex = 2
        Me.btn_suppPrice.UseVisualStyleBackColor = False
        '
        'btn_qty
        '
        Me.btn_qty.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_qty.BackColor = System.Drawing.Color.Transparent
        Me.btn_qty.FlatAppearance.BorderSize = 0
        Me.btn_qty.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue
        Me.btn_qty.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_qty.Font = New System.Drawing.Font("Yu Gothic UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_qty.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btn_qty.IconChar = FontAwesome.Sharp.IconChar.PenToSquare
        Me.btn_qty.IconColor = System.Drawing.Color.White
        Me.btn_qty.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_qty.IconSize = 30
        Me.btn_qty.Location = New System.Drawing.Point(357, 334)
        Me.btn_qty.Name = "btn_qty"
        Me.btn_qty.Size = New System.Drawing.Size(27, 34)
        Me.btn_qty.TabIndex = 4
        Me.btn_qty.UseVisualStyleBackColor = False
        '
        'btn_price
        '
        Me.btn_price.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_price.BackColor = System.Drawing.Color.Transparent
        Me.btn_price.FlatAppearance.BorderSize = 0
        Me.btn_price.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue
        Me.btn_price.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_price.Font = New System.Drawing.Font("Yu Gothic UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_price.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btn_price.IconChar = FontAwesome.Sharp.IconChar.PenToSquare
        Me.btn_price.IconColor = System.Drawing.Color.White
        Me.btn_price.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_price.IconSize = 30
        Me.btn_price.Location = New System.Drawing.Point(357, 265)
        Me.btn_price.Name = "btn_price"
        Me.btn_price.Size = New System.Drawing.Size(27, 34)
        Me.btn_price.TabIndex = 0
        Me.btn_price.UseVisualStyleBackColor = False
        '
        'lbl_pID
        '
        Me.lbl_pID.AutoSize = True
        Me.lbl_pID.BackColor = System.Drawing.Color.Transparent
        Me.lbl_pID.Font = New System.Drawing.Font("Argentum Novus", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_pID.ForeColor = System.Drawing.Color.White
        Me.lbl_pID.Location = New System.Drawing.Point(184, 133)
        Me.lbl_pID.Name = "lbl_pID"
        Me.lbl_pID.Size = New System.Drawing.Size(17, 18)
        Me.lbl_pID.TabIndex = 35
        Me.lbl_pID.Text = "0"
        '
        'lbl_pname
        '
        Me.lbl_pname.AutoSize = True
        Me.lbl_pname.BackColor = System.Drawing.Color.Transparent
        Me.lbl_pname.Font = New System.Drawing.Font("Argentum Novus", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_pname.ForeColor = System.Drawing.Color.White
        Me.lbl_pname.Location = New System.Drawing.Point(184, 167)
        Me.lbl_pname.Name = "lbl_pname"
        Me.lbl_pname.Size = New System.Drawing.Size(19, 18)
        Me.lbl_pname.TabIndex = 36
        Me.lbl_pname.Text = "#"
        '
        'lbl_sname
        '
        Me.lbl_sname.AutoSize = True
        Me.lbl_sname.BackColor = System.Drawing.Color.Transparent
        Me.lbl_sname.Font = New System.Drawing.Font("Argentum Novus", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_sname.ForeColor = System.Drawing.Color.White
        Me.lbl_sname.Location = New System.Drawing.Point(184, 202)
        Me.lbl_sname.Name = "lbl_sname"
        Me.lbl_sname.Size = New System.Drawing.Size(19, 18)
        Me.lbl_sname.TabIndex = 37
        Me.lbl_sname.Text = "#"
        '
        'lbl_ptype
        '
        Me.lbl_ptype.AutoSize = True
        Me.lbl_ptype.BackColor = System.Drawing.Color.Transparent
        Me.lbl_ptype.Font = New System.Drawing.Font("Argentum Novus", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_ptype.ForeColor = System.Drawing.Color.White
        Me.lbl_ptype.Location = New System.Drawing.Point(184, 238)
        Me.lbl_ptype.Name = "lbl_ptype"
        Me.lbl_ptype.Size = New System.Drawing.Size(19, 18)
        Me.lbl_ptype.TabIndex = 38
        Me.lbl_ptype.Text = "#"
        '
        'btn_sIN
        '
        Me.btn_sIN.BackColor = System.Drawing.Color.Transparent
        Me.btn_sIN.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue
        Me.btn_sIN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue
        Me.btn_sIN.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_sIN.Font = New System.Drawing.Font("Argentum Novus", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_sIN.ForeColor = System.Drawing.Color.White
        Me.btn_sIN.IconChar = FontAwesome.Sharp.IconChar.CartArrowDown
        Me.btn_sIN.IconColor = System.Drawing.Color.White
        Me.btn_sIN.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_sIN.IconSize = 30
        Me.btn_sIN.Location = New System.Drawing.Point(165, 389)
        Me.btn_sIN.Name = "btn_sIN"
        Me.btn_sIN.Size = New System.Drawing.Size(117, 43)
        Me.btn_sIN.TabIndex = 6
        Me.btn_sIN.Text = "STOCK IN"
        Me.btn_sIN.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_sIN.UseVisualStyleBackColor = False
        '
        'stockInProduct
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(448, 470)
        Me.Controls.Add(Me.btn_sIN)
        Me.Controls.Add(Me.lbl_ptype)
        Me.Controls.Add(Me.lbl_sname)
        Me.Controls.Add(Me.lbl_pname)
        Me.Controls.Add(Me.lbl_pID)
        Me.Controls.Add(Me.btn_price)
        Me.Controls.Add(Me.btn_qty)
        Me.Controls.Add(Me.btn_suppPrice)
        Me.Controls.Add(Me.txt_price)
        Me.Controls.Add(Me.txt_qty)
        Me.Controls.Add(Me.txt_sPrice)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.top_panel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "stockInProduct"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "STOCKSLOGIX"
        Me.top_panel.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents top_panel As Panel
    Friend WithEvents btn_exit As FontAwesome.Sharp.IconButton
    Friend WithEvents btn_minimize As FontAwesome.Sharp.IconButton
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents btn_suppPrice As FontAwesome.Sharp.IconButton
    Friend WithEvents txt_price As TextBox
    Friend WithEvents txt_qty As TextBox
    Friend WithEvents txt_sPrice As TextBox
    Friend WithEvents btn_price As FontAwesome.Sharp.IconButton
    Friend WithEvents btn_qty As FontAwesome.Sharp.IconButton
    Friend WithEvents lbl_ptype As Label
    Friend WithEvents lbl_sname As Label
    Friend WithEvents lbl_pname As Label
    Friend WithEvents lbl_pID As Label
    Friend WithEvents btn_sIN As FontAwesome.Sharp.IconButton
End Class
