<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class updateProductForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(updateProductForm))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_pName = New System.Windows.Forms.TextBox()
        Me.cmb_type = New System.Windows.Forms.ComboBox()
        Me.cmb_prodSupp = New System.Windows.Forms.ComboBox()
        Me.btn_update = New FontAwesome.Sharp.IconButton()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lbl_id = New System.Windows.Forms.Label()
        Me.top_panel = New System.Windows.Forms.Panel()
        Me.btn_exit = New FontAwesome.Sharp.IconButton()
        Me.btn_minimize = New FontAwesome.Sharp.IconButton()
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.top_panel.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Argentum Novus", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(80, 81)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(299, 25)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "PRODUCT UPDATE FORM"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Argentum Novus", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(50, 195)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(121, 18)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Product Name:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Argentum Novus", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(50, 239)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(111, 18)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Product Type:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Argentum Novus", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(50, 283)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(135, 18)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Product Supplier"
        '
        'txt_pName
        '
        Me.txt_pName.BackColor = System.Drawing.Color.White
        Me.txt_pName.Font = New System.Drawing.Font("Argentum Novus", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_pName.ForeColor = System.Drawing.Color.DodgerBlue
        Me.txt_pName.Location = New System.Drawing.Point(187, 192)
        Me.txt_pName.Multiline = True
        Me.txt_pName.Name = "txt_pName"
        Me.txt_pName.Size = New System.Drawing.Size(223, 24)
        Me.txt_pName.TabIndex = 1
        '
        'cmb_type
        '
        Me.cmb_type.Font = New System.Drawing.Font("Argentum Novus", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_type.ForeColor = System.Drawing.Color.DodgerBlue
        Me.cmb_type.FormattingEnabled = True
        Me.cmb_type.Location = New System.Drawing.Point(187, 236)
        Me.cmb_type.Name = "cmb_type"
        Me.cmb_type.Size = New System.Drawing.Size(223, 26)
        Me.cmb_type.TabIndex = 2
        '
        'cmb_prodSupp
        '
        Me.cmb_prodSupp.Font = New System.Drawing.Font("Argentum Novus", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_prodSupp.ForeColor = System.Drawing.Color.DodgerBlue
        Me.cmb_prodSupp.FormattingEnabled = True
        Me.cmb_prodSupp.Location = New System.Drawing.Point(187, 280)
        Me.cmb_prodSupp.Name = "cmb_prodSupp"
        Me.cmb_prodSupp.Size = New System.Drawing.Size(223, 26)
        Me.cmb_prodSupp.TabIndex = 3
        '
        'btn_update
        '
        Me.btn_update.BackColor = System.Drawing.Color.Transparent
        Me.btn_update.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue
        Me.btn_update.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue
        Me.btn_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_update.Font = New System.Drawing.Font("Argentum Novus", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_update.ForeColor = System.Drawing.Color.White
        Me.btn_update.IconChar = FontAwesome.Sharp.IconChar.Pen
        Me.btn_update.IconColor = System.Drawing.Color.White
        Me.btn_update.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_update.IconSize = 30
        Me.btn_update.Location = New System.Drawing.Point(187, 356)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Size = New System.Drawing.Size(107, 43)
        Me.btn_update.TabIndex = 4
        Me.btn_update.Text = "UPDATE"
        Me.btn_update.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_update.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Argentum Novus", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(50, 156)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(91, 18)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Product ID:"
        '
        'lbl_id
        '
        Me.lbl_id.AutoSize = True
        Me.lbl_id.BackColor = System.Drawing.Color.Transparent
        Me.lbl_id.Font = New System.Drawing.Font("Argentum Novus", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_id.ForeColor = System.Drawing.Color.White
        Me.lbl_id.Location = New System.Drawing.Point(184, 156)
        Me.lbl_id.Name = "lbl_id"
        Me.lbl_id.Size = New System.Drawing.Size(17, 18)
        Me.lbl_id.TabIndex = 17
        Me.lbl_id.Text = "0"
        '
        'top_panel
        '
        Me.top_panel.BackColor = System.Drawing.Color.Transparent
        Me.top_panel.Controls.Add(Me.btn_exit)
        Me.top_panel.Controls.Add(Me.btn_minimize)
        Me.top_panel.Location = New System.Drawing.Point(0, -4)
        Me.top_panel.Name = "top_panel"
        Me.top_panel.Size = New System.Drawing.Size(449, 37)
        Me.top_panel.TabIndex = 20
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
        Me.btn_minimize.Location = New System.Drawing.Point(394, 3)
        Me.btn_minimize.Name = "btn_minimize"
        Me.btn_minimize.Size = New System.Drawing.Size(16, 29)
        Me.btn_minimize.TabIndex = 5
        Me.btn_minimize.UseVisualStyleBackColor = True
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 20
        Me.BunifuElipse1.TargetControl = Me
        '
        'updateProductForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(448, 470)
        Me.Controls.Add(Me.top_panel)
        Me.Controls.Add(Me.lbl_id)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btn_update)
        Me.Controls.Add(Me.cmb_prodSupp)
        Me.Controls.Add(Me.cmb_type)
        Me.Controls.Add(Me.txt_pName)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "updateProductForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "STOCKSLOGIX"
        Me.top_panel.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_pName As TextBox
    Friend WithEvents cmb_type As ComboBox
    Friend WithEvents cmb_prodSupp As ComboBox
    Friend WithEvents btn_update As FontAwesome.Sharp.IconButton
    Friend WithEvents Label5 As Label
    Friend WithEvents lbl_id As Label
    Friend WithEvents top_panel As Panel
    Friend WithEvents btn_exit As FontAwesome.Sharp.IconButton
    Friend WithEvents btn_minimize As FontAwesome.Sharp.IconButton
    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
End Class
