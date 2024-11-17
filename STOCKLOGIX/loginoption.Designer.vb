<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class loginoption
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(loginoption))
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.btn_admin = New FontAwesome.Sharp.IconButton()
        Me.btn_employee = New FontAwesome.Sharp.IconButton()
        Me.btn_exit = New FontAwesome.Sharp.IconButton()
        Me.BunifuCustomLabel1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.top_panel = New System.Windows.Forms.Panel()
        Me.top_panel.SuspendLayout()
        Me.SuspendLayout()
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 40
        Me.BunifuElipse1.TargetControl = Me
        '
        'btn_admin
        '
        Me.btn_admin.BackColor = System.Drawing.Color.Transparent
        Me.btn_admin.BackgroundImage = CType(resources.GetObject("btn_admin.BackgroundImage"), System.Drawing.Image)
        Me.btn_admin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_admin.FlatAppearance.BorderSize = 0
        Me.btn_admin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btn_admin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btn_admin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_admin.IconChar = FontAwesome.Sharp.IconChar.None
        Me.btn_admin.IconColor = System.Drawing.Color.Black
        Me.btn_admin.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_admin.Location = New System.Drawing.Point(92, 529)
        Me.btn_admin.Name = "btn_admin"
        Me.btn_admin.Size = New System.Drawing.Size(319, 50)
        Me.btn_admin.TabIndex = 0
        Me.btn_admin.UseVisualStyleBackColor = False
        '
        'btn_employee
        '
        Me.btn_employee.BackColor = System.Drawing.Color.Transparent
        Me.btn_employee.BackgroundImage = CType(resources.GetObject("btn_employee.BackgroundImage"), System.Drawing.Image)
        Me.btn_employee.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_employee.FlatAppearance.BorderSize = 0
        Me.btn_employee.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btn_employee.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btn_employee.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_employee.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btn_employee.IconChar = FontAwesome.Sharp.IconChar.None
        Me.btn_employee.IconColor = System.Drawing.Color.Black
        Me.btn_employee.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_employee.Location = New System.Drawing.Point(92, 585)
        Me.btn_employee.Name = "btn_employee"
        Me.btn_employee.Size = New System.Drawing.Size(319, 50)
        Me.btn_employee.TabIndex = 1
        Me.btn_employee.UseVisualStyleBackColor = False
        '
        'btn_exit
        '
        Me.btn_exit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_exit.BackColor = System.Drawing.Color.Transparent
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
        Me.btn_exit.Location = New System.Drawing.Point(464, 7)
        Me.btn_exit.Name = "btn_exit"
        Me.btn_exit.Size = New System.Drawing.Size(21, 25)
        Me.btn_exit.TabIndex = 2
        Me.btn_exit.UseVisualStyleBackColor = False
        '
        'BunifuCustomLabel1
        '
        Me.BunifuCustomLabel1.AutoSize = True
        Me.BunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuCustomLabel1.Font = New System.Drawing.Font("Argentum Novus", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel1.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.BunifuCustomLabel1.Location = New System.Drawing.Point(179, 664)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.Size = New System.Drawing.Size(143, 10)
        Me.BunifuCustomLabel1.TabIndex = 11
        Me.BunifuCustomLabel1.Text = "COPYRIGHT 2023 | VERSION 1.0.0.0"
        '
        'top_panel
        '
        Me.top_panel.BackColor = System.Drawing.Color.Transparent
        Me.top_panel.Controls.Add(Me.btn_exit)
        Me.top_panel.Location = New System.Drawing.Point(0, -1)
        Me.top_panel.Name = "top_panel"
        Me.top_panel.Size = New System.Drawing.Size(494, 37)
        Me.top_panel.TabIndex = 12
        '
        'loginoption
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(497, 686)
        Me.Controls.Add(Me.top_panel)
        Me.Controls.Add(Me.BunifuCustomLabel1)
        Me.Controls.Add(Me.btn_employee)
        Me.Controls.Add(Me.btn_admin)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "loginoption"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "STOCKSLOGIX"
        Me.top_panel.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents btn_employee As FontAwesome.Sharp.IconButton
    Friend WithEvents btn_admin As FontAwesome.Sharp.IconButton
    Friend WithEvents btn_exit As FontAwesome.Sharp.IconButton
    Friend WithEvents BunifuCustomLabel1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents top_panel As Panel
End Class
