<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class updateStocks
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(updateStocks))
        Me.lbl_sID = New System.Windows.Forms.Label()
        Me.btn_siN = New FontAwesome.Sharp.IconButton()
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.btn_exit = New FontAwesome.Sharp.IconButton()
        Me.btn_minimize = New FontAwesome.Sharp.IconButton()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lbl_sname = New System.Windows.Forms.Label()
        Me.lbl_pname = New System.Windows.Forms.Label()
        Me.lbl_pID = New System.Windows.Forms.Label()
        Me.btn_qty = New FontAwesome.Sharp.IconButton()
        Me.txt_qty = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.top_panel = New System.Windows.Forms.Panel()
        Me.lbl_pType = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_pPrice = New System.Windows.Forms.TextBox()
        Me.txt_sPrice = New System.Windows.Forms.TextBox()
        Me.btn_pPrice = New FontAwesome.Sharp.IconButton()
        Me.btn_sPrice = New FontAwesome.Sharp.IconButton()
        Me.top_panel.SuspendLayout()
        Me.SuspendLayout()
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
        Me.lbl_sID.TabIndex = 81
        Me.lbl_sID.Text = "0"
        '
        'btn_siN
        '
        Me.btn_siN.BackColor = System.Drawing.Color.Transparent
        Me.btn_siN.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue
        Me.btn_siN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue
        Me.btn_siN.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_siN.Font = New System.Drawing.Font("Argentum Novus", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_siN.ForeColor = System.Drawing.Color.White
        Me.btn_siN.IconChar = FontAwesome.Sharp.IconChar.DollyBox
        Me.btn_siN.IconColor = System.Drawing.Color.White
        Me.btn_siN.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_siN.IconSize = 30
        Me.btn_siN.Location = New System.Drawing.Point(165, 405)
        Me.btn_siN.Name = "btn_siN"
        Me.btn_siN.Size = New System.Drawing.Size(117, 43)
        Me.btn_siN.TabIndex = 6
        Me.btn_siN.Text = "UPDATE STOCKS"
        Me.btn_siN.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_siN.UseVisualStyleBackColor = False
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 20
        Me.BunifuElipse1.TargetControl = Me
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
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Argentum Novus", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(59, 138)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(80, 18)
        Me.Label9.TabIndex = 80
        Me.Label9.Text = "Stocks ID:"
        '
        'lbl_sname
        '
        Me.lbl_sname.AutoSize = True
        Me.lbl_sname.BackColor = System.Drawing.Color.Transparent
        Me.lbl_sname.Font = New System.Drawing.Font("Argentum Novus", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_sname.ForeColor = System.Drawing.Color.White
        Me.lbl_sname.Location = New System.Drawing.Point(184, 232)
        Me.lbl_sname.Name = "lbl_sname"
        Me.lbl_sname.Size = New System.Drawing.Size(19, 18)
        Me.lbl_sname.TabIndex = 78
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
        Me.lbl_pname.TabIndex = 77
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
        Me.lbl_pID.TabIndex = 76
        Me.lbl_pID.Text = "0"
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
        Me.btn_qty.Location = New System.Drawing.Point(357, 350)
        Me.btn_qty.Name = "btn_qty"
        Me.btn_qty.Size = New System.Drawing.Size(27, 34)
        Me.btn_qty.TabIndex = 4
        Me.btn_qty.UseVisualStyleBackColor = False
        '
        'txt_qty
        '
        Me.txt_qty.BackColor = System.Drawing.Color.White
        Me.txt_qty.Enabled = False
        Me.txt_qty.Font = New System.Drawing.Font("Argentum Novus", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_qty.ForeColor = System.Drawing.Color.DodgerBlue
        Me.txt_qty.Location = New System.Drawing.Point(187, 354)
        Me.txt_qty.Multiline = True
        Me.txt_qty.Name = "txt_qty"
        Me.txt_qty.Size = New System.Drawing.Size(164, 24)
        Me.txt_qty.TabIndex = 5
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Argentum Novus", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(59, 287)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(112, 18)
        Me.Label8.TabIndex = 70
        Me.Label8.Text = "Product Price:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Argentum Novus", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(59, 357)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(76, 18)
        Me.Label6.TabIndex = 69
        Me.Label6.Text = "Quantity:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Argentum Novus", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(59, 321)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(116, 18)
        Me.Label5.TabIndex = 68
        Me.Label5.Text = "Supplier Price:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Argentum Novus", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(59, 232)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(125, 18)
        Me.Label3.TabIndex = 67
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
        Me.Label2.TabIndex = 65
        Me.Label2.Text = "Product ID:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Argentum Novus", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(106, 78)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(278, 25)
        Me.Label1.TabIndex = 64
        Me.Label1.Text = "UPDATE STOCKS FORM"
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
        Me.Label7.TabIndex = 66
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
        Me.top_panel.TabIndex = 63
        '
        'lbl_pType
        '
        Me.lbl_pType.AutoSize = True
        Me.lbl_pType.BackColor = System.Drawing.Color.Transparent
        Me.lbl_pType.Font = New System.Drawing.Font("Argentum Novus", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_pType.ForeColor = System.Drawing.Color.White
        Me.lbl_pType.Location = New System.Drawing.Point(184, 261)
        Me.lbl_pType.Name = "lbl_pType"
        Me.lbl_pType.Size = New System.Drawing.Size(19, 18)
        Me.lbl_pType.TabIndex = 83
        Me.lbl_pType.Text = "#"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Argentum Novus", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(59, 261)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(111, 18)
        Me.Label4.TabIndex = 82
        Me.Label4.Text = "Product Type:"
        '
        'txt_pPrice
        '
        Me.txt_pPrice.BackColor = System.Drawing.Color.White
        Me.txt_pPrice.Enabled = False
        Me.txt_pPrice.Font = New System.Drawing.Font("Argentum Novus", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_pPrice.ForeColor = System.Drawing.Color.DodgerBlue
        Me.txt_pPrice.Location = New System.Drawing.Point(187, 284)
        Me.txt_pPrice.Multiline = True
        Me.txt_pPrice.Name = "txt_pPrice"
        Me.txt_pPrice.Size = New System.Drawing.Size(164, 24)
        Me.txt_pPrice.TabIndex = 1
        '
        'txt_sPrice
        '
        Me.txt_sPrice.BackColor = System.Drawing.Color.White
        Me.txt_sPrice.Enabled = False
        Me.txt_sPrice.Font = New System.Drawing.Font("Argentum Novus", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_sPrice.ForeColor = System.Drawing.Color.DodgerBlue
        Me.txt_sPrice.Location = New System.Drawing.Point(187, 318)
        Me.txt_sPrice.Multiline = True
        Me.txt_sPrice.Name = "txt_sPrice"
        Me.txt_sPrice.Size = New System.Drawing.Size(164, 24)
        Me.txt_sPrice.TabIndex = 3
        '
        'btn_pPrice
        '
        Me.btn_pPrice.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_pPrice.BackColor = System.Drawing.Color.Transparent
        Me.btn_pPrice.FlatAppearance.BorderSize = 0
        Me.btn_pPrice.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue
        Me.btn_pPrice.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_pPrice.Font = New System.Drawing.Font("Yu Gothic UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_pPrice.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btn_pPrice.IconChar = FontAwesome.Sharp.IconChar.PenToSquare
        Me.btn_pPrice.IconColor = System.Drawing.Color.White
        Me.btn_pPrice.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_pPrice.IconSize = 30
        Me.btn_pPrice.Location = New System.Drawing.Point(357, 280)
        Me.btn_pPrice.Name = "btn_pPrice"
        Me.btn_pPrice.Size = New System.Drawing.Size(27, 34)
        Me.btn_pPrice.TabIndex = 0
        Me.btn_pPrice.UseVisualStyleBackColor = False
        '
        'btn_sPrice
        '
        Me.btn_sPrice.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_sPrice.BackColor = System.Drawing.Color.Transparent
        Me.btn_sPrice.FlatAppearance.BorderSize = 0
        Me.btn_sPrice.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue
        Me.btn_sPrice.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_sPrice.Font = New System.Drawing.Font("Yu Gothic UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_sPrice.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btn_sPrice.IconChar = FontAwesome.Sharp.IconChar.PenToSquare
        Me.btn_sPrice.IconColor = System.Drawing.Color.White
        Me.btn_sPrice.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_sPrice.IconSize = 30
        Me.btn_sPrice.Location = New System.Drawing.Point(357, 314)
        Me.btn_sPrice.Name = "btn_sPrice"
        Me.btn_sPrice.Size = New System.Drawing.Size(27, 34)
        Me.btn_sPrice.TabIndex = 2
        Me.btn_sPrice.UseVisualStyleBackColor = False
        '
        'updateStocks
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(448, 470)
        Me.Controls.Add(Me.btn_sPrice)
        Me.Controls.Add(Me.btn_pPrice)
        Me.Controls.Add(Me.txt_sPrice)
        Me.Controls.Add(Me.txt_pPrice)
        Me.Controls.Add(Me.lbl_pType)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lbl_sID)
        Me.Controls.Add(Me.btn_siN)
        Me.Controls.Add(Me.Label9)
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
        Me.Name = "updateStocks"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "STOCKSLOGIX"
        Me.top_panel.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_sID As Label
    Friend WithEvents btn_siN As FontAwesome.Sharp.IconButton
    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents Label9 As Label
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
    Friend WithEvents Label7 As Label
    Friend WithEvents top_panel As Panel
    Friend WithEvents btn_exit As FontAwesome.Sharp.IconButton
    Friend WithEvents btn_minimize As FontAwesome.Sharp.IconButton
    Friend WithEvents lbl_pType As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btn_sPrice As FontAwesome.Sharp.IconButton
    Friend WithEvents btn_pPrice As FontAwesome.Sharp.IconButton
    Friend WithEvents txt_sPrice As TextBox
    Friend WithEvents txt_pPrice As TextBox
End Class
