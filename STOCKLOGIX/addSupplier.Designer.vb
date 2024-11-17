<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class addSupplier
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(addSupplier))
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_sName = New System.Windows.Forms.TextBox()
        Me.txt_sAddress = New System.Windows.Forms.TextBox()
        Me.txt_sNumber = New System.Windows.Forms.TextBox()
        Me.cmb_suppProdType = New System.Windows.Forms.ComboBox()
        Me.btn_addSupp = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label7
        '
        Me.Label7.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Argentum Novus", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(302, 42)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(219, 32)
        Me.Label7.TabIndex = 28
        Me.Label7.Text = "ADD SUPPLIER"
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Argentum Novus", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(292, 98)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(152, 22)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "Supplier Name"
        '
        'Label2
        '
        Me.Label2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Argentum Novus", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(292, 171)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(171, 22)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "Supplier Address"
        '
        'Label3
        '
        Me.Label3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Argentum Novus", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(292, 240)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 22)
        Me.Label3.TabIndex = 31
        Me.Label3.Text = "Number"
        '
        'Label4
        '
        Me.Label4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Argentum Novus", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(292, 314)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(222, 22)
        Me.Label4.TabIndex = 32
        Me.Label4.Text = "Supplier Product Type"
        '
        'txt_sName
        '
        Me.txt_sName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_sName.Font = New System.Drawing.Font("Argentum Novus", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_sName.ForeColor = System.Drawing.Color.DodgerBlue
        Me.txt_sName.Location = New System.Drawing.Point(296, 131)
        Me.txt_sName.Name = "txt_sName"
        Me.txt_sName.Size = New System.Drawing.Size(233, 22)
        Me.txt_sName.TabIndex = 0
        '
        'txt_sAddress
        '
        Me.txt_sAddress.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_sAddress.Font = New System.Drawing.Font("Argentum Novus", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_sAddress.ForeColor = System.Drawing.Color.DodgerBlue
        Me.txt_sAddress.Location = New System.Drawing.Point(296, 204)
        Me.txt_sAddress.Name = "txt_sAddress"
        Me.txt_sAddress.Size = New System.Drawing.Size(233, 22)
        Me.txt_sAddress.TabIndex = 1
        '
        'txt_sNumber
        '
        Me.txt_sNumber.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_sNumber.Font = New System.Drawing.Font("Argentum Novus", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_sNumber.ForeColor = System.Drawing.Color.DodgerBlue
        Me.txt_sNumber.Location = New System.Drawing.Point(339, 265)
        Me.txt_sNumber.Name = "txt_sNumber"
        Me.txt_sNumber.Size = New System.Drawing.Size(190, 22)
        Me.txt_sNumber.TabIndex = 2
        '
        'cmb_suppProdType
        '
        Me.cmb_suppProdType.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmb_suppProdType.Font = New System.Drawing.Font("Argentum Novus", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_suppProdType.ForeColor = System.Drawing.Color.DodgerBlue
        Me.cmb_suppProdType.FormattingEnabled = True
        Me.cmb_suppProdType.Location = New System.Drawing.Point(296, 348)
        Me.cmb_suppProdType.Name = "cmb_suppProdType"
        Me.cmb_suppProdType.Size = New System.Drawing.Size(233, 23)
        Me.cmb_suppProdType.TabIndex = 3
        '
        'btn_addSupp
        '
        Me.btn_addSupp.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_addSupp.BackColor = System.Drawing.Color.DodgerBlue
        Me.btn_addSupp.FlatAppearance.BorderSize = 0
        Me.btn_addSupp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue
        Me.btn_addSupp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue
        Me.btn_addSupp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_addSupp.Font = New System.Drawing.Font("Argentum Novus", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_addSupp.ForeColor = System.Drawing.Color.White
        Me.btn_addSupp.Location = New System.Drawing.Point(224, 397)
        Me.btn_addSupp.Name = "btn_addSupp"
        Me.btn_addSupp.Size = New System.Drawing.Size(361, 52)
        Me.btn_addSupp.TabIndex = 4
        Me.btn_addSupp.Text = "Add Supplier"
        Me.btn_addSupp.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Argentum Novus", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(292, 265)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(41, 22)
        Me.Label5.TabIndex = 38
        Me.Label5.Text = "+63"
        '
        'addSupplier
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(845, 506)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btn_addSupp)
        Me.Controls.Add(Me.cmb_suppProdType)
        Me.Controls.Add(Me.txt_sNumber)
        Me.Controls.Add(Me.txt_sAddress)
        Me.Controls.Add(Me.txt_sName)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label7)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "addSupplier"
        Me.Text = "STOCKSLOGIX"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label7 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_sName As TextBox
    Friend WithEvents txt_sAddress As TextBox
    Friend WithEvents txt_sNumber As TextBox
    Friend WithEvents cmb_suppProdType As ComboBox
    Friend WithEvents btn_addSupp As Button
    Friend WithEvents Label5 As Label
End Class
