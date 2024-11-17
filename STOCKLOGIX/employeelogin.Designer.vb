<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class employeelogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(employeelogin))
        Me.panel_logo = New System.Windows.Forms.Panel()
        Me.top_panel = New System.Windows.Forms.Panel()
        Me.btn_minimize = New FontAwesome.Sharp.IconButton()
        Me.btn_exit = New FontAwesome.Sharp.IconButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lbl_countdown = New System.Windows.Forms.Label()
        Me.btn_show = New FontAwesome.Sharp.IconButton()
        Me.BunifuCustomLabel1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.txt_ePass = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_eUser = New System.Windows.Forms.TextBox()
        Me.btn_back = New FontAwesome.Sharp.IconButton()
        Me.btn_login = New System.Windows.Forms.Button()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.panel_logo.SuspendLayout()
        Me.top_panel.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'panel_logo
        '
        Me.panel_logo.BackgroundImage = CType(resources.GetObject("panel_logo.BackgroundImage"), System.Drawing.Image)
        Me.panel_logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.panel_logo.Controls.Add(Me.top_panel)
        Me.panel_logo.Location = New System.Drawing.Point(345, -2)
        Me.panel_logo.Name = "panel_logo"
        Me.panel_logo.Size = New System.Drawing.Size(627, 465)
        Me.panel_logo.TabIndex = 0
        '
        'top_panel
        '
        Me.top_panel.BackColor = System.Drawing.Color.Transparent
        Me.top_panel.Controls.Add(Me.btn_minimize)
        Me.top_panel.Controls.Add(Me.btn_exit)
        Me.top_panel.ForeColor = System.Drawing.Color.Transparent
        Me.top_panel.Location = New System.Drawing.Point(-347, -4)
        Me.top_panel.Name = "top_panel"
        Me.top_panel.Size = New System.Drawing.Size(978, 37)
        Me.top_panel.TabIndex = 100
        '
        'btn_minimize
        '
        Me.btn_minimize.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_minimize.BackColor = System.Drawing.Color.Transparent
        Me.btn_minimize.FlatAppearance.BorderSize = 0
        Me.btn_minimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btn_minimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue
        Me.btn_minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_minimize.Font = New System.Drawing.Font("Yu Gothic UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_minimize.ForeColor = System.Drawing.Color.White
        Me.btn_minimize.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize
        Me.btn_minimize.IconColor = System.Drawing.Color.White
        Me.btn_minimize.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_minimize.IconSize = 30
        Me.btn_minimize.Location = New System.Drawing.Point(926, 7)
        Me.btn_minimize.Name = "btn_minimize"
        Me.btn_minimize.Size = New System.Drawing.Size(16, 29)
        Me.btn_minimize.TabIndex = 4
        Me.btn_minimize.UseVisualStyleBackColor = False
        '
        'btn_exit
        '
        Me.btn_exit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_exit.BackColor = System.Drawing.Color.Transparent
        Me.btn_exit.FlatAppearance.BorderSize = 0
        Me.btn_exit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btn_exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue
        Me.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_exit.Font = New System.Drawing.Font("Yu Gothic UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_exit.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btn_exit.IconChar = FontAwesome.Sharp.IconChar.XmarkCircle
        Me.btn_exit.IconColor = System.Drawing.Color.White
        Me.btn_exit.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_exit.IconSize = 30
        Me.btn_exit.Location = New System.Drawing.Point(943, 9)
        Me.btn_exit.Name = "btn_exit"
        Me.btn_exit.Size = New System.Drawing.Size(30, 29)
        Me.btn_exit.TabIndex = 5
        Me.btn_exit.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.lbl_countdown)
        Me.Panel1.Controls.Add(Me.btn_show)
        Me.Panel1.Controls.Add(Me.BunifuCustomLabel1)
        Me.Panel1.Controls.Add(Me.txt_ePass)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.txt_eUser)
        Me.Panel1.Controls.Add(Me.btn_back)
        Me.Panel1.Controls.Add(Me.btn_login)
        Me.Panel1.Location = New System.Drawing.Point(-2, -2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(351, 465)
        Me.Panel1.TabIndex = 1
        '
        'lbl_countdown
        '
        Me.lbl_countdown.AutoSize = True
        Me.lbl_countdown.BackColor = System.Drawing.Color.Transparent
        Me.lbl_countdown.Font = New System.Drawing.Font("Argentum Novus", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_countdown.ForeColor = System.Drawing.Color.SteelBlue
        Me.lbl_countdown.Location = New System.Drawing.Point(39, 349)
        Me.lbl_countdown.Name = "lbl_countdown"
        Me.lbl_countdown.Size = New System.Drawing.Size(24, 16)
        Me.lbl_countdown.TabIndex = 23
        Me.lbl_countdown.Text = "10"
        '
        'btn_show
        '
        Me.btn_show.BackColor = System.Drawing.Color.Transparent
        Me.btn_show.FlatAppearance.BorderSize = 0
        Me.btn_show.FlatAppearance.MouseDownBackColor = System.Drawing.Color.AliceBlue
        Me.btn_show.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btn_show.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_show.IconChar = FontAwesome.Sharp.IconChar.EyeSlash
        Me.btn_show.IconColor = System.Drawing.Color.SteelBlue
        Me.btn_show.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_show.IconSize = 30
        Me.btn_show.Location = New System.Drawing.Point(287, 316)
        Me.btn_show.Name = "btn_show"
        Me.btn_show.Size = New System.Drawing.Size(28, 23)
        Me.btn_show.TabIndex = 2
        Me.btn_show.UseVisualStyleBackColor = False
        '
        'BunifuCustomLabel1
        '
        Me.BunifuCustomLabel1.AutoSize = True
        Me.BunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuCustomLabel1.Font = New System.Drawing.Font("Argentum Novus", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel1.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.BunifuCustomLabel1.Location = New System.Drawing.Point(109, 444)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.Size = New System.Drawing.Size(143, 10)
        Me.BunifuCustomLabel1.TabIndex = 12
        Me.BunifuCustomLabel1.Text = "COPYRIGHT 2023 | VERSION 1.0.0.0"
        '
        'txt_ePass
        '
        Me.txt_ePass.Font = New System.Drawing.Font("Argentum Novus", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_ePass.ForeColor = System.Drawing.Color.DodgerBlue
        Me.txt_ePass.Location = New System.Drawing.Point(39, 309)
        Me.txt_ePass.Multiline = True
        Me.txt_ePass.Name = "txt_ePass"
        Me.txt_ePass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_ePass.Size = New System.Drawing.Size(278, 37)
        Me.txt_ePass.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Argentum Novus", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label2.Location = New System.Drawing.Point(40, 293)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 11)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "PASSWORD: "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Argentum Novus", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label1.Location = New System.Drawing.Point(40, 230)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 11)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "USERNAME: "
        '
        'txt_eUser
        '
        Me.txt_eUser.BackColor = System.Drawing.Color.White
        Me.txt_eUser.Font = New System.Drawing.Font("Argentum Novus", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_eUser.ForeColor = System.Drawing.Color.DodgerBlue
        Me.txt_eUser.Location = New System.Drawing.Point(39, 248)
        Me.txt_eUser.Multiline = True
        Me.txt_eUser.Name = "txt_eUser"
        Me.txt_eUser.Size = New System.Drawing.Size(278, 37)
        Me.txt_eUser.TabIndex = 0
        '
        'btn_back
        '
        Me.btn_back.BackColor = System.Drawing.Color.Transparent
        Me.btn_back.FlatAppearance.BorderSize = 0
        Me.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_back.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft
        Me.btn_back.IconColor = System.Drawing.Color.DodgerBlue
        Me.btn_back.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_back.IconSize = 20
        Me.btn_back.Location = New System.Drawing.Point(12, 10)
        Me.btn_back.Name = "btn_back"
        Me.btn_back.Size = New System.Drawing.Size(27, 23)
        Me.btn_back.TabIndex = 9
        Me.btn_back.UseVisualStyleBackColor = False
        '
        'btn_login
        '
        Me.btn_login.BackColor = System.Drawing.Color.DodgerBlue
        Me.btn_login.FlatAppearance.BorderSize = 0
        Me.btn_login.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue
        Me.btn_login.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue
        Me.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_login.Font = New System.Drawing.Font("Argentum Novus", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_login.ForeColor = System.Drawing.Color.White
        Me.btn_login.Location = New System.Drawing.Point(39, 377)
        Me.btn_login.Name = "btn_login"
        Me.btn_login.Size = New System.Drawing.Size(278, 48)
        Me.btn_login.TabIndex = 3
        Me.btn_login.Text = "LOGIN"
        Me.btn_login.UseVisualStyleBackColor = False
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Enabled = False
        Me.DateTimePicker1.Location = New System.Drawing.Point(328, 1)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(11, 20)
        Me.DateTimePicker1.TabIndex = 20
        '
        'Timer2
        '
        '
        'employeelogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(972, 461)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.panel_logo)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "employeelogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "STOCKSLOGIX"
        Me.panel_logo.ResumeLayout(False)
        Me.top_panel.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents panel_logo As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btn_login As Button
    Friend WithEvents btn_back As FontAwesome.Sharp.IconButton
    Friend WithEvents txt_eUser As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_ePass As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents BunifuCustomLabel1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents btn_show As FontAwesome.Sharp.IconButton
    Friend WithEvents lbl_countdown As Label
    Friend WithEvents btn_exit As FontAwesome.Sharp.IconButton
    Friend WithEvents btn_minimize As FontAwesome.Sharp.IconButton
    Friend WithEvents top_panel As Panel
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
End Class
