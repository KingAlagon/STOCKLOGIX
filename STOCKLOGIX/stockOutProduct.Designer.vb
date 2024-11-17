<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class stockOutProduct
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(stockOutProduct))
        Me.lbl_sname = New System.Windows.Forms.Label()
        Me.lbl_pname = New System.Windows.Forms.Label()
        Me.lbl_pID = New System.Windows.Forms.Label()
        Me.txt_qty = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.top_panel = New System.Windows.Forms.Panel()
        Me.btn_exit = New FontAwesome.Sharp.IconButton()
        Me.btn_minimize = New FontAwesome.Sharp.IconButton()
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.btn_sOut = New FontAwesome.Sharp.IconButton()
        Me.btn_qty = New FontAwesome.Sharp.IconButton()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lbl_sID = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lbl_pType = New System.Windows.Forms.Label()
        Me.lbl_sPrice = New System.Windows.Forms.Label()
        Me.lbl_pPrice = New System.Windows.Forms.Label()
        Me.top_panel.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbl_sname
        '
        Me.lbl_sname.AutoSize = True
        Me.lbl_sname.BackColor = System.Drawing.Color.Transparent
        Me.lbl_sname.Font = New System.Drawing.Font("Argentum Novus", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_sname.ForeColor = System.Drawing.Color.White
        Me.lbl_sname.Location = New System.Drawing.Point(184, 233)
        Me.lbl_sname.Name = "lbl_sname"
        Me.lbl_sname.Size = New System.Drawing.Size(19, 18)
        Me.lbl_sname.TabIndex = 57
        Me.lbl_sname.Text = "#"
        '
        'lbl_pname
        '
        Me.lbl_pname.AutoSize = True
        Me.lbl_pname.BackColor = System.Drawing.Color.Transparent
        Me.lbl_pname.Font = New System.Drawing.Font("Argentum Novus", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_pname.ForeColor = System.Drawing.Color.White
        Me.lbl_pname.Location = New System.Drawing.Point(184, 201)
        Me.lbl_pname.Name = "lbl_pname"
        Me.lbl_pname.Size = New System.Drawing.Size(19, 18)
        Me.lbl_pname.TabIndex = 56
        Me.lbl_pname.Text = "#"
        '
        'lbl_pID
        '
        Me.lbl_pID.AutoSize = True
        Me.lbl_pID.BackColor = System.Drawing.Color.Transparent
        Me.lbl_pID.Font = New System.Drawing.Font("Argentum Novus", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_pID.ForeColor = System.Drawing.Color.White
        Me.lbl_pID.Location = New System.Drawing.Point(184, 167)
        Me.lbl_pID.Name = "lbl_pID"
        Me.lbl_pID.Size = New System.Drawing.Size(17, 18)
        Me.lbl_pID.TabIndex = 55
        Me.lbl_pID.Text = "0"
        '
        'txt_qty
        '
        Me.txt_qty.BackColor = System.Drawing.Color.White
        Me.txt_qty.Enabled = False
        Me.txt_qty.Font = New System.Drawing.Font("Argentum Novus", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_qty.ForeColor = System.Drawing.Color.DodgerBlue
        Me.txt_qty.Location = New System.Drawing.Point(187, 361)
        Me.txt_qty.Multiline = True
        Me.txt_qty.Name = "txt_qty"
        Me.txt_qty.Size = New System.Drawing.Size(164, 24)
        Me.txt_qty.TabIndex = 51
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Argentum Novus", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(59, 328)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(112, 18)
        Me.Label8.TabIndex = 49
        Me.Label8.Text = "Product Price:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Argentum Novus", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(59, 364)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(76, 18)
        Me.Label6.TabIndex = 48
        Me.Label6.Text = "Quantity:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Argentum Novus", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(59, 295)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(116, 18)
        Me.Label5.TabIndex = 47
        Me.Label5.Text = "Supplier Price:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Argentum Novus", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(59, 233)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(125, 18)
        Me.Label3.TabIndex = 45
        Me.Label3.Text = "Supplier Name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Argentum Novus", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(59, 167)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 18)
        Me.Label2.TabIndex = 43
        Me.Label2.Text = "Product ID:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Argentum Novus", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(127, 75)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(219, 25)
        Me.Label1.TabIndex = 42
        Me.Label1.Text = "STOCK OUT FORM"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Argentum Novus", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(59, 201)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(121, 18)
        Me.Label7.TabIndex = 44
        Me.Label7.Text = "Product Name:"
        '
        'top_panel
        '
        Me.top_panel.BackColor = System.Drawing.Color.Transparent
        Me.top_panel.Controls.Add(Me.btn_exit)
        Me.top_panel.Controls.Add(Me.btn_minimize)
        Me.top_panel.Location = New System.Drawing.Point(0, -4)
        Me.top_panel.Name = "top_panel"
        Me.top_panel.Size = New System.Drawing.Size(449, 37)
        Me.top_panel.TabIndex = 41
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
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 20
        Me.BunifuElipse1.TargetControl = Me
        '
        'btn_sOut
        '
        Me.btn_sOut.BackColor = System.Drawing.Color.Transparent
        Me.btn_sOut.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue
        Me.btn_sOut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue
        Me.btn_sOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_sOut.Font = New System.Drawing.Font("Argentum Novus", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_sOut.ForeColor = System.Drawing.Color.White
        Me.btn_sOut.IconChar = FontAwesome.Sharp.IconChar.DollyBox
        Me.btn_sOut.IconColor = System.Drawing.Color.White
        Me.btn_sOut.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_sOut.IconSize = 30
        Me.btn_sOut.Location = New System.Drawing.Point(165, 408)
        Me.btn_sOut.Name = "btn_sOut"
        Me.btn_sOut.Size = New System.Drawing.Size(117, 43)
        Me.btn_sOut.TabIndex = 59
        Me.btn_sOut.Text = "STOCK OUT"
        Me.btn_sOut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_sOut.UseVisualStyleBackColor = False
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
        Me.btn_qty.Location = New System.Drawing.Point(357, 357)
        Me.btn_qty.Name = "btn_qty"
        Me.btn_qty.Size = New System.Drawing.Size(27, 34)
        Me.btn_qty.TabIndex = 53
        Me.btn_qty.UseVisualStyleBackColor = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Argentum Novus", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(59, 138)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(80, 18)
        Me.Label9.TabIndex = 60
        Me.Label9.Text = "Stocks ID:"
        '
        'lbl_sID
        '
        Me.lbl_sID.AutoSize = True
        Me.lbl_sID.BackColor = System.Drawing.Color.Transparent
        Me.lbl_sID.Font = New System.Drawing.Font("Argentum Novus", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_sID.ForeColor = System.Drawing.Color.White
        Me.lbl_sID.Location = New System.Drawing.Point(184, 138)
        Me.lbl_sID.Name = "lbl_sID"
        Me.lbl_sID.Size = New System.Drawing.Size(17, 18)
        Me.lbl_sID.TabIndex = 61
        Me.lbl_sID.Text = "0"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Argentum Novus", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(59, 262)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(108, 18)
        Me.Label4.TabIndex = 62
        Me.Label4.Text = "Product Type"
        '
        'lbl_pType
        '
        Me.lbl_pType.AutoSize = True
        Me.lbl_pType.BackColor = System.Drawing.Color.Transparent
        Me.lbl_pType.Font = New System.Drawing.Font("Argentum Novus", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_pType.ForeColor = System.Drawing.Color.White
        Me.lbl_pType.Location = New System.Drawing.Point(184, 260)
        Me.lbl_pType.Name = "lbl_pType"
        Me.lbl_pType.Size = New System.Drawing.Size(19, 18)
        Me.lbl_pType.TabIndex = 63
        Me.lbl_pType.Text = "#"
        '
        'lbl_sPrice
        '
        Me.lbl_sPrice.AutoSize = True
        Me.lbl_sPrice.BackColor = System.Drawing.Color.Transparent
        Me.lbl_sPrice.Font = New System.Drawing.Font("Argentum Novus", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_sPrice.ForeColor = System.Drawing.Color.White
        Me.lbl_sPrice.Location = New System.Drawing.Point(186, 295)
        Me.lbl_sPrice.Name = "lbl_sPrice"
        Me.lbl_sPrice.Size = New System.Drawing.Size(17, 18)
        Me.lbl_sPrice.TabIndex = 64
        Me.lbl_sPrice.Text = "0"
        '
        'lbl_pPrice
        '
        Me.lbl_pPrice.AutoSize = True
        Me.lbl_pPrice.BackColor = System.Drawing.Color.Transparent
        Me.lbl_pPrice.Font = New System.Drawing.Font("Argentum Novus", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_pPrice.ForeColor = System.Drawing.Color.White
        Me.lbl_pPrice.Location = New System.Drawing.Point(186, 328)
        Me.lbl_pPrice.Name = "lbl_pPrice"
        Me.lbl_pPrice.Size = New System.Drawing.Size(17, 18)
        Me.lbl_pPrice.TabIndex = 65
        Me.lbl_pPrice.Text = "0"
        '
        'stockOutProduct
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(448, 470)
        Me.Controls.Add(Me.lbl_pPrice)
        Me.Controls.Add(Me.lbl_sPrice)
        Me.Controls.Add(Me.lbl_pType)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lbl_sID)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.btn_sOut)
        Me.Controls.Add(Me.lbl_sname)
        Me.Controls.Add(Me.lbl_pname)
        Me.Controls.Add(Me.lbl_pID)
        Me.Controls.Add(Me.btn_qty)
        Me.Controls.Add(Me.txt_qty)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.top_panel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "stockOutProduct"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "STOCKSLOGIX"
        Me.top_panel.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_sOut As FontAwesome.Sharp.IconButton
    Friend WithEvents lbl_sname As Label
    Friend WithEvents lbl_pname As Label
    Friend WithEvents lbl_pID As Label
    Friend WithEvents btn_qty As FontAwesome.Sharp.IconButton
    Friend WithEvents txt_qty As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_exit As FontAwesome.Sharp.IconButton
    Friend WithEvents btn_minimize As FontAwesome.Sharp.IconButton
    Friend WithEvents Label7 As Label
    Friend WithEvents top_panel As Panel
    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents lbl_sID As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents lbl_pType As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lbl_pPrice As Label
    Friend WithEvents lbl_sPrice As Label
End Class
