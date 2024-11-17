<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class addProduct
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(addProduct))
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_pName = New System.Windows.Forms.TextBox()
        Me.cmb_type = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmb_prodtype = New System.Windows.Forms.ComboBox()
        Me.cmb_prodSupp = New System.Windows.Forms.ComboBox()
        Me.btn_prodAdd = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Argentum Novus", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(302, 42)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(229, 32)
        Me.Label7.TabIndex = 27
        Me.Label7.Text = "ADD PRODUCT "
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Argentum Novus", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(304, 284)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(149, 22)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "Product Name"
        '
        'txt_pName
        '
        Me.txt_pName.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.txt_pName.Font = New System.Drawing.Font("Argentum Novus", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_pName.ForeColor = System.Drawing.Color.DodgerBlue
        Me.txt_pName.Location = New System.Drawing.Point(308, 316)
        Me.txt_pName.Name = "txt_pName"
        Me.txt_pName.Size = New System.Drawing.Size(233, 22)
        Me.txt_pName.TabIndex = 31
        '
        'cmb_type
        '
        Me.cmb_type.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.cmb_type.AutoSize = True
        Me.cmb_type.BackColor = System.Drawing.Color.Transparent
        Me.cmb_type.Font = New System.Drawing.Font("Argentum Novus", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_type.ForeColor = System.Drawing.Color.White
        Me.cmb_type.Location = New System.Drawing.Point(304, 200)
        Me.cmb_type.Name = "cmb_type"
        Me.cmb_type.Size = New System.Drawing.Size(137, 22)
        Me.cmb_type.TabIndex = 32
        Me.cmb_type.Text = "Product Type"
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Argentum Novus", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(302, 114)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(171, 22)
        Me.Label3.TabIndex = 33
        Me.Label3.Text = "Product Supplier"
        '
        'cmb_prodtype
        '
        Me.cmb_prodtype.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.cmb_prodtype.Font = New System.Drawing.Font("Argentum Novus", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_prodtype.ForeColor = System.Drawing.Color.DodgerBlue
        Me.cmb_prodtype.FormattingEnabled = True
        Me.cmb_prodtype.Location = New System.Drawing.Point(308, 227)
        Me.cmb_prodtype.Name = "cmb_prodtype"
        Me.cmb_prodtype.Size = New System.Drawing.Size(233, 23)
        Me.cmb_prodtype.TabIndex = 34
        '
        'cmb_prodSupp
        '
        Me.cmb_prodSupp.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.cmb_prodSupp.Font = New System.Drawing.Font("Argentum Novus", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_prodSupp.ForeColor = System.Drawing.Color.DodgerBlue
        Me.cmb_prodSupp.FormattingEnabled = True
        Me.cmb_prodSupp.Location = New System.Drawing.Point(308, 144)
        Me.cmb_prodSupp.Name = "cmb_prodSupp"
        Me.cmb_prodSupp.Size = New System.Drawing.Size(233, 23)
        Me.cmb_prodSupp.TabIndex = 35
        '
        'btn_prodAdd
        '
        Me.btn_prodAdd.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btn_prodAdd.BackColor = System.Drawing.Color.DodgerBlue
        Me.btn_prodAdd.FlatAppearance.BorderSize = 0
        Me.btn_prodAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue
        Me.btn_prodAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue
        Me.btn_prodAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_prodAdd.Font = New System.Drawing.Font("Argentum Novus", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_prodAdd.ForeColor = System.Drawing.Color.White
        Me.btn_prodAdd.Location = New System.Drawing.Point(224, 397)
        Me.btn_prodAdd.Name = "btn_prodAdd"
        Me.btn_prodAdd.Size = New System.Drawing.Size(361, 52)
        Me.btn_prodAdd.TabIndex = 36
        Me.btn_prodAdd.Text = "Add Product"
        Me.btn_prodAdd.UseVisualStyleBackColor = False
        '
        'addProduct
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(845, 506)
        Me.Controls.Add(Me.btn_prodAdd)
        Me.Controls.Add(Me.cmb_prodSupp)
        Me.Controls.Add(Me.cmb_prodtype)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cmb_type)
        Me.Controls.Add(Me.txt_pName)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label7)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "addProduct"
        Me.Text = "STOCKSLOGIX"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label7 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_pName As TextBox
    Friend WithEvents cmb_type As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents cmb_prodtype As ComboBox
    Friend WithEvents cmb_prodSupp As ComboBox
    Friend WithEvents btn_prodAdd As Button
End Class
