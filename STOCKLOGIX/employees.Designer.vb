<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class employees
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(employees))
        Me.top_panel = New System.Windows.Forms.Panel()
        Me.btn_exit = New FontAwesome.Sharp.IconButton()
        Me.btn_minimize = New FontAwesome.Sharp.IconButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btn_update = New FontAwesome.Sharp.IconButton()
        Me.lbl_id = New System.Windows.Forms.Label()
        Me.txt_fname = New System.Windows.Forms.TextBox()
        Me.txt_uname = New System.Windows.Forms.TextBox()
        Me.txt_pass = New System.Windows.Forms.TextBox()
        Me.txt_email = New System.Windows.Forms.TextBox()
        Me.txt_address = New System.Windows.Forms.TextBox()
        Me.txt_number = New System.Windows.Forms.TextBox()
        Me.btn_show = New FontAwesome.Sharp.IconButton()
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.Label8 = New System.Windows.Forms.Label()
        Me.top_panel.SuspendLayout()
        Me.SuspendLayout()
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
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Argentum Novus", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(64, 151)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(27, 18)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "ID:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Argentum Novus", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(64, 180)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 18)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Fullname:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Argentum Novus", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(64, 209)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 18)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "Username:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Argentum Novus", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(64, 238)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 18)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "Password:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Argentum Novus", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(64, 267)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 18)
        Me.Label5.TabIndex = 26
        Me.Label5.Text = "Email:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Argentum Novus", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(64, 295)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(71, 18)
        Me.Label6.TabIndex = 27
        Me.Label6.Text = "Address:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Argentum Novus", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(64, 324)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(74, 18)
        Me.Label7.TabIndex = 28
        Me.Label7.Text = "Number:"
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
        Me.btn_update.Location = New System.Drawing.Point(160, 375)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Size = New System.Drawing.Size(107, 43)
        Me.btn_update.TabIndex = 6
        Me.btn_update.Text = "UPDATE"
        Me.btn_update.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_update.UseVisualStyleBackColor = False
        '
        'lbl_id
        '
        Me.lbl_id.AutoSize = True
        Me.lbl_id.BackColor = System.Drawing.Color.Transparent
        Me.lbl_id.Font = New System.Drawing.Font("Argentum Novus", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_id.ForeColor = System.Drawing.Color.White
        Me.lbl_id.Location = New System.Drawing.Point(157, 151)
        Me.lbl_id.Name = "lbl_id"
        Me.lbl_id.Size = New System.Drawing.Size(17, 18)
        Me.lbl_id.TabIndex = 30
        Me.lbl_id.Text = "0"
        '
        'txt_fname
        '
        Me.txt_fname.BackColor = System.Drawing.Color.White
        Me.txt_fname.Font = New System.Drawing.Font("Argentum Novus", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_fname.ForeColor = System.Drawing.Color.DodgerBlue
        Me.txt_fname.Location = New System.Drawing.Point(160, 177)
        Me.txt_fname.Multiline = True
        Me.txt_fname.Name = "txt_fname"
        Me.txt_fname.Size = New System.Drawing.Size(223, 24)
        Me.txt_fname.TabIndex = 0
        '
        'txt_uname
        '
        Me.txt_uname.BackColor = System.Drawing.Color.White
        Me.txt_uname.Font = New System.Drawing.Font("Argentum Novus", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_uname.ForeColor = System.Drawing.Color.DodgerBlue
        Me.txt_uname.Location = New System.Drawing.Point(160, 206)
        Me.txt_uname.Multiline = True
        Me.txt_uname.Name = "txt_uname"
        Me.txt_uname.Size = New System.Drawing.Size(223, 24)
        Me.txt_uname.TabIndex = 1
        '
        'txt_pass
        '
        Me.txt_pass.BackColor = System.Drawing.Color.White
        Me.txt_pass.Font = New System.Drawing.Font("Argentum Novus", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_pass.ForeColor = System.Drawing.Color.DodgerBlue
        Me.txt_pass.Location = New System.Drawing.Point(160, 235)
        Me.txt_pass.Multiline = True
        Me.txt_pass.Name = "txt_pass"
        Me.txt_pass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_pass.Size = New System.Drawing.Size(223, 24)
        Me.txt_pass.TabIndex = 2
        '
        'txt_email
        '
        Me.txt_email.BackColor = System.Drawing.Color.White
        Me.txt_email.Font = New System.Drawing.Font("Argentum Novus", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_email.ForeColor = System.Drawing.Color.DodgerBlue
        Me.txt_email.Location = New System.Drawing.Point(159, 264)
        Me.txt_email.Multiline = True
        Me.txt_email.Name = "txt_email"
        Me.txt_email.Size = New System.Drawing.Size(223, 24)
        Me.txt_email.TabIndex = 3
        '
        'txt_address
        '
        Me.txt_address.BackColor = System.Drawing.Color.White
        Me.txt_address.Font = New System.Drawing.Font("Argentum Novus", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_address.ForeColor = System.Drawing.Color.DodgerBlue
        Me.txt_address.Location = New System.Drawing.Point(160, 292)
        Me.txt_address.Multiline = True
        Me.txt_address.Name = "txt_address"
        Me.txt_address.Size = New System.Drawing.Size(223, 24)
        Me.txt_address.TabIndex = 4
        '
        'txt_number
        '
        Me.txt_number.BackColor = System.Drawing.Color.White
        Me.txt_number.Font = New System.Drawing.Font("Argentum Novus", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_number.ForeColor = System.Drawing.Color.DodgerBlue
        Me.txt_number.Location = New System.Drawing.Point(160, 321)
        Me.txt_number.Multiline = True
        Me.txt_number.Name = "txt_number"
        Me.txt_number.Size = New System.Drawing.Size(223, 24)
        Me.txt_number.TabIndex = 5
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
        Me.btn_show.Location = New System.Drawing.Point(354, 235)
        Me.btn_show.Name = "btn_show"
        Me.btn_show.Size = New System.Drawing.Size(28, 23)
        Me.btn_show.TabIndex = 42
        Me.btn_show.UseVisualStyleBackColor = False
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 20
        Me.BunifuElipse1.TargetControl = Me
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Argentum Novus", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(71, 69)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(312, 25)
        Me.Label8.TabIndex = 43
        Me.Label8.Text = "EMPLOYEE UPDATE FORM"
        '
        'employees
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(448, 470)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.btn_show)
        Me.Controls.Add(Me.txt_number)
        Me.Controls.Add(Me.txt_address)
        Me.Controls.Add(Me.txt_email)
        Me.Controls.Add(Me.txt_pass)
        Me.Controls.Add(Me.txt_uname)
        Me.Controls.Add(Me.txt_fname)
        Me.Controls.Add(Me.lbl_id)
        Me.Controls.Add(Me.btn_update)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.top_panel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "employees"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "STOCKSLOGIX"
        Me.top_panel.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents top_panel As Panel
    Friend WithEvents btn_exit As FontAwesome.Sharp.IconButton
    Friend WithEvents btn_minimize As FontAwesome.Sharp.IconButton
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents btn_update As FontAwesome.Sharp.IconButton
    Friend WithEvents lbl_id As Label
    Friend WithEvents txt_fname As TextBox
    Friend WithEvents txt_uname As TextBox
    Friend WithEvents txt_pass As TextBox
    Friend WithEvents txt_email As TextBox
    Friend WithEvents txt_address As TextBox
    Friend WithEvents txt_number As TextBox
    Friend WithEvents btn_show As FontAwesome.Sharp.IconButton
    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents Label8 As Label
End Class
