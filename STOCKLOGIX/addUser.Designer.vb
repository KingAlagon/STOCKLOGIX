<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class addUser
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(addUser))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_fname = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_uname = New System.Windows.Forms.TextBox()
        Me.txt_email = New System.Windows.Forms.TextBox()
        Me.txt_password = New System.Windows.Forms.TextBox()
        Me.txt_number = New System.Windows.Forms.TextBox()
        Me.txt_address = New System.Windows.Forms.TextBox()
        Me.btn_aSignup = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cmb_type = New System.Windows.Forms.ComboBox()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btn_eSignup = New System.Windows.Forms.Button()
        Me.btn_show = New FontAwesome.Sharp.IconButton()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Argentum Novus", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(128, 152)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Full Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Argentum Novus", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(128, 214)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Username:"
        '
        'txt_fname
        '
        Me.txt_fname.Font = New System.Drawing.Font("Argentum Novus", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_fname.ForeColor = System.Drawing.Color.DodgerBlue
        Me.txt_fname.Location = New System.Drawing.Point(131, 171)
        Me.txt_fname.Multiline = True
        Me.txt_fname.Name = "txt_fname"
        Me.txt_fname.Size = New System.Drawing.Size(219, 30)
        Me.txt_fname.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Argentum Novus", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(128, 276)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 16)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Password"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Argentum Novus", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(464, 152)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 16)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Email"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Argentum Novus", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(464, 90)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(109, 16)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Phone Number"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Argentum Novus", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(464, 214)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(60, 16)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "Address"
        '
        'txt_uname
        '
        Me.txt_uname.Font = New System.Drawing.Font("Argentum Novus", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_uname.ForeColor = System.Drawing.Color.DodgerBlue
        Me.txt_uname.Location = New System.Drawing.Point(131, 233)
        Me.txt_uname.Multiline = True
        Me.txt_uname.Name = "txt_uname"
        Me.txt_uname.Size = New System.Drawing.Size(219, 30)
        Me.txt_uname.TabIndex = 2
        '
        'txt_email
        '
        Me.txt_email.Font = New System.Drawing.Font("Argentum Novus", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_email.ForeColor = System.Drawing.Color.DodgerBlue
        Me.txt_email.Location = New System.Drawing.Point(467, 171)
        Me.txt_email.Multiline = True
        Me.txt_email.Name = "txt_email"
        Me.txt_email.Size = New System.Drawing.Size(219, 30)
        Me.txt_email.TabIndex = 5
        '
        'txt_password
        '
        Me.txt_password.Font = New System.Drawing.Font("Argentum Novus", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_password.ForeColor = System.Drawing.Color.DodgerBlue
        Me.txt_password.Location = New System.Drawing.Point(131, 295)
        Me.txt_password.Multiline = True
        Me.txt_password.Name = "txt_password"
        Me.txt_password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_password.Size = New System.Drawing.Size(219, 30)
        Me.txt_password.TabIndex = 3
        '
        'txt_number
        '
        Me.txt_number.Font = New System.Drawing.Font("Argentum Novus", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_number.ForeColor = System.Drawing.Color.DodgerBlue
        Me.txt_number.Location = New System.Drawing.Point(509, 109)
        Me.txt_number.Multiline = True
        Me.txt_number.Name = "txt_number"
        Me.txt_number.Size = New System.Drawing.Size(177, 30)
        Me.txt_number.TabIndex = 4
        '
        'txt_address
        '
        Me.txt_address.Font = New System.Drawing.Font("Argentum Novus", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_address.ForeColor = System.Drawing.Color.DodgerBlue
        Me.txt_address.Location = New System.Drawing.Point(467, 233)
        Me.txt_address.Multiline = True
        Me.txt_address.Name = "txt_address"
        Me.txt_address.Size = New System.Drawing.Size(219, 92)
        Me.txt_address.TabIndex = 6
        '
        'btn_aSignup
        '
        Me.btn_aSignup.BackColor = System.Drawing.Color.DodgerBlue
        Me.btn_aSignup.FlatAppearance.BorderSize = 0
        Me.btn_aSignup.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue
        Me.btn_aSignup.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue
        Me.btn_aSignup.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_aSignup.Font = New System.Drawing.Font("Argentum Novus", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_aSignup.ForeColor = System.Drawing.Color.White
        Me.btn_aSignup.Location = New System.Drawing.Point(238, 371)
        Me.btn_aSignup.Name = "btn_aSignup"
        Me.btn_aSignup.Size = New System.Drawing.Size(361, 52)
        Me.btn_aSignup.TabIndex = 25
        Me.btn_aSignup.Text = "Sign Up"
        Me.btn_aSignup.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Argentum Novus", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(253, 25)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(346, 32)
        Me.Label7.TabIndex = 26
        Me.Label7.Text = "Sign up for new account"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Argentum Novus", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(128, 90)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(72, 16)
        Me.Label8.TabIndex = 27
        Me.Label8.Text = "User Type"
        '
        'cmb_type
        '
        Me.cmb_type.BackColor = System.Drawing.Color.White
        Me.cmb_type.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmb_type.Font = New System.Drawing.Font("Argentum Novus", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_type.ForeColor = System.Drawing.Color.DodgerBlue
        Me.cmb_type.FormattingEnabled = True
        Me.cmb_type.Items.AddRange(New Object() {"ADMIN", "EMPLOYEE"})
        Me.cmb_type.Location = New System.Drawing.Point(131, 109)
        Me.cmb_type.Name = "cmb_type"
        Me.cmb_type.Size = New System.Drawing.Size(219, 24)
        Me.cmb_type.TabIndex = 0
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'Label9
        '
        Me.Label9.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Argentum Novus", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(463, 112)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(41, 22)
        Me.Label9.TabIndex = 39
        Me.Label9.Text = "+63"
        '
        'btn_eSignup
        '
        Me.btn_eSignup.BackColor = System.Drawing.Color.DodgerBlue
        Me.btn_eSignup.FlatAppearance.BorderSize = 0
        Me.btn_eSignup.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue
        Me.btn_eSignup.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue
        Me.btn_eSignup.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_eSignup.Font = New System.Drawing.Font("Argentum Novus", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_eSignup.ForeColor = System.Drawing.Color.White
        Me.btn_eSignup.Location = New System.Drawing.Point(238, 371)
        Me.btn_eSignup.Name = "btn_eSignup"
        Me.btn_eSignup.Size = New System.Drawing.Size(361, 52)
        Me.btn_eSignup.TabIndex = 7
        Me.btn_eSignup.Text = "Sign Up"
        Me.btn_eSignup.UseVisualStyleBackColor = False
        '
        'btn_show
        '
        Me.btn_show.BackColor = System.Drawing.Color.White
        Me.btn_show.FlatAppearance.BorderSize = 0
        Me.btn_show.FlatAppearance.MouseDownBackColor = System.Drawing.Color.AliceBlue
        Me.btn_show.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btn_show.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_show.IconChar = FontAwesome.Sharp.IconChar.EyeSlash
        Me.btn_show.IconColor = System.Drawing.Color.SteelBlue
        Me.btn_show.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_show.IconSize = 30
        Me.btn_show.Location = New System.Drawing.Point(321, 298)
        Me.btn_show.Name = "btn_show"
        Me.btn_show.Size = New System.Drawing.Size(28, 23)
        Me.btn_show.TabIndex = 41
        Me.btn_show.UseVisualStyleBackColor = False
        '
        'addUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(829, 467)
        Me.Controls.Add(Me.btn_show)
        Me.Controls.Add(Me.btn_eSignup)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.cmb_type)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btn_aSignup)
        Me.Controls.Add(Me.txt_address)
        Me.Controls.Add(Me.txt_number)
        Me.Controls.Add(Me.txt_password)
        Me.Controls.Add(Me.txt_email)
        Me.Controls.Add(Me.txt_uname)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_fname)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "addUser"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "STOCKSLOGIX"
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_fname As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_uname As TextBox
    Friend WithEvents txt_email As TextBox
    Friend WithEvents txt_password As TextBox
    Friend WithEvents txt_number As TextBox
    Friend WithEvents txt_address As TextBox
    Friend WithEvents btn_aSignup As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents cmb_type As ComboBox
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents Label9 As Label
    Friend WithEvents btn_eSignup As Button
    Friend WithEvents btn_show As FontAwesome.Sharp.IconButton
End Class
