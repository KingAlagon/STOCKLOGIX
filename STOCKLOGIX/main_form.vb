Imports MySql.Data.MySqlClient
Imports System.Reflection


Public Class main_form
    Private Property MoveForm As Boolean
    Private Property Move_Form_MousePosition As Point
    Private loggedInUserId As Integer
    Public userId As Integer
    Private _loggedInUsername As String
    Public loggedInUsername As String
    Private currentChildForm As Form

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        Me.DoubleBuffered = True
        ' Add any initialization after the InitializeComponent() call.
        Me.Text = String.Empty
        Me.ControlBox = False

        Me.MaximizedBounds = Screen.PrimaryScreen.WorkingArea

    End Sub
    Public Sub New(ByVal userId As Integer)
        ' This call is required by the designer.
        InitializeComponent()

        ' Store the user ID as a class-level variable
        Me.userId = userId
    End Sub

    Private Sub OpenChildForm(childForm As Form)
        If currentChildForm IsNot Nothing Then
            currentChildForm.Close()

        End If
        currentChildForm = childForm

        childForm.TopLevel = False
        childForm.FormBorderStyle = FormBorderStyle.None
        childForm.Dock = DockStyle.Fill
        panel_desktop.Controls.Add(childForm)
        panel_desktop.Tag = childForm
        childForm.BringToFront()
        childForm.Show()
    End Sub
    Private Sub hideSubMenu()
        registerpanel.Visible = False
        prod_panel.Visible = False
        panel_register.Visible = False
        stock_panel.Visible = False
    End Sub
    Private Sub showSubMenu(subMenu As Panel)
        If subMenu.Visible = False Then
            hideSubMenu()
            subMenu.Visible = True
        Else
            subMenu.Visible = False
        End If

    End Sub
    Private Sub btn_add_Click_1(sender As Object, e As EventArgs) Handles btn_register.Click
        'code for sub panel to show.
        showSubMenu(registerpanel)
    End Sub

    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles btn_catProd.Click
        showSubMenu(prod_panel)

    End Sub

    Private Sub PictureBox1_Click_1(sender As Object, e As EventArgs) Handles PictureBox1.Click

        If currentChildForm IsNot Nothing Then
            currentChildForm.Close()
            hideSubMenu()
            Me.DoubleBuffered = True
        End If
        Reset()
    End Sub
    Public Sub connect()

        sqlconn = New MySqlConnection("server=localhost;userid=root;password=;database=stocklogix;")
        If sqlconn.State = ConnectionState.Closed Then

            sqlconn.Open()

        End If

    End Sub
    Public Sub disconnect_db()
        If sqlconn.State = ConnectionState.Open Then
            sqlconn.Close()

        End If
    End Sub

    Private Sub main_form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.AutoScroll = True
        Timer1.Start()
        'to display inputted value of the textbox username
        lbl_username.Text = adminlogin.loggedInUsername

        'to hide sub panel in register button
        registerpanel.Visible = False
        prod_panel.Visible = False
        panel_register.Visible = False
        stock_panel.Visible = False
        Me.DoubleBuffered = True

    End Sub

    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        Application.Exit()

    End Sub

    Private Sub btn_minimize_Click(sender As Object, e As EventArgs) Handles btn_minimize.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btn_logs_Click(sender As Object, e As EventArgs) Handles btn_logs.Click
        OpenChildForm(New logs)
        userUpdateForm.Close()
        updateProductForm.Close()
        updateSupplier.Close()
        updateStocks.Close()
        stockOutProduct.Close()
        stockInProduct.Close()

        registerpanel.Visible = False
        prod_panel.Visible = False
        panel_register.Visible = False
        stock_panel.Visible = False
    End Sub

    Private Sub btn_logout_Click(sender As Object, e As EventArgs) Handles btn_logout.Click

        Dim msg As String = "ARE YOU SURE YOU WANT TO LOGOUT?"
        Dim title As String = "LOGOUT"
        Dim result = MessageBox.Show(msg, title, MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
        If result = DialogResult.OK Then

            Application.Restart()

        End If
    End Sub

    Sub subPanel()

        If registerpanel.Visible = True Then
            registerpanel.Visible = True
            prod_panel.Visible = False
            panel_register.Visible = False
            stock_panel.Visible = False
        End If
    End Sub
    Sub subPanel2()
        If prod_panel.Visible = True Then
            prod_panel.Visible = True
            registerpanel.Visible = False
            panel_register.Visible = False
            stock_panel.Visible = False
        End If
    End Sub
    Sub subPanel3()
        If panel_register.Visible = True Then
            panel_register.Visible = True
            prod_panel.Visible = False
            registerpanel.Visible = False
            stock_panel.Visible = False
        Else
        End If
    End Sub
    Sub subPanel4()
        If stock_panel.Visible = True Then
            stock_panel.Visible = True
            prod_panel.Visible = False
            registerpanel.Visible = False
            panel_register.Visible = False
        End If
    End Sub

    Private Sub btn_show_Click(sender As Object, e As EventArgs) Handles btn_show.Click
        subPanel()
        OpenChildForm(New userlist)

        updateProductForm.Close()
        updateSupplier.Close()
        stockInProduct.Close()
        updateProductForm.Close()
        stockOutProduct.Close()
        updateStocks.Close()

    End Sub

    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        subPanel()
        OpenChildForm(New addUser)
        userUpdateForm.Close()
        updateProductForm.Close()
        updateSupplier.Close()
        stockInProduct.Close()
        updateStocks.Close()
        stockOutProduct.Close()
    End Sub

    Private Sub btn_addProd_Click(sender As Object, e As EventArgs) Handles btn_addProd.Click
        subPanel2()
        OpenChildForm(New addProduct)
        userUpdateForm.Close()
        updateProductForm.Close()
        updateSupplier.Close()
        stockInProduct.Close()
        stockOutProduct.Close()
        updateStocks.Close()
    End Sub

    Private Sub btn_prodList_Click(sender As Object, e As EventArgs) Handles btn_prodList.Click
        subPanel2()
        OpenChildForm(New prodList)
        userUpdateForm.Close()
        updateSupplier.Close()

        stockOutProduct.Close()
        updateStocks.Close()
    End Sub

    Private Sub btn_supplier_Click(sender As Object, e As EventArgs) Handles btn_supplier.Click
        showSubMenu(panel_register)
    End Sub

    Private Sub btn_addSupp_Click(sender As Object, e As EventArgs) Handles btn_addSupp.Click
        subPanel3()
        OpenChildForm(New addSupplier)
        userUpdateForm.Close()
        updateProductForm.Close()
        updateSupplier.Close()
        stockInProduct.Close()
        stockOutProduct.Close()
        updateStocks.Close()
    End Sub

    Private Sub btn_suppList_Click(sender As Object, e As EventArgs) Handles btn_suppList.Click
        subPanel3()
        OpenChildForm(New supplierList)
        userUpdateForm.Close()
        updateProductForm.Close()
        stockInProduct.Close()
        stockOutProduct.Close()
        updateStocks.Close()
    End Sub

    Private Sub panel_title_MouseDown(sender As Object, e As MouseEventArgs) Handles panel_title.MouseDown
        If e.Button = MouseButtons.Left Then
            MoveForm = True
            Me.Cursor = Cursors.Default
            Move_Form_MousePosition = e.Location
        End If
    End Sub

    Private Sub panel_title_MouseUp(sender As Object, e As MouseEventArgs) Handles panel_title.MouseUp
        If e.Button = MouseButtons.Left Then
            MoveForm = False
            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub panel_title_MouseMove(sender As Object, e As MouseEventArgs) Handles panel_title.MouseMove
        If MoveForm Then
            Me.Location = Me.Location + (e.Location - Move_Form_MousePosition)
        End If
    End Sub

    Private Sub panel_logo_MouseDown(sender As Object, e As MouseEventArgs) Handles panel_logo.MouseDown
        If e.Button = MouseButtons.Left Then
            MoveForm = True
            Me.Cursor = Cursors.Default
            Move_Form_MousePosition = e.Location
        End If
    End Sub

    Private Sub panel_logo_MouseUp(sender As Object, e As MouseEventArgs) Handles panel_logo.MouseUp
        If e.Button = MouseButtons.Left Then
            MoveForm = False
            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub panel_logo_MouseMove(sender As Object, e As MouseEventArgs) Handles panel_logo.MouseMove
        If MoveForm Then
            Me.Location = Me.Location + (e.Location - Move_Form_MousePosition)
        End If
    End Sub

    Private Sub panel_dashboard_Click(sender As Object, e As EventArgs) Handles panel_dashboard.Click
        Me.DoubleBuffered = True
    End Sub

    Private Sub panel_logo_Click(sender As Object, e As EventArgs) Handles panel_logo.Click
        Me.DoubleBuffered = True
    End Sub

    Private Sub btn_stock_Click(sender As Object, e As EventArgs) Handles btn_stock.Click
        showSubMenu(stock_panel)
    End Sub

    Private Sub btn_stockout_Click(sender As Object, e As EventArgs) Handles btn_stockout.Click
        subPanel4()
        OpenChildForm(New stockList)
        userUpdateForm.Close()
        updateProductForm.Close()
        stockInProduct.Close()
    End Sub

    Private timerTime As New Stopwatch()
    Private timerTransition As Timer
    Private Sub panel_dashboard_Scroll(sender As Object, e As ScrollEventArgs) Handles panel_dashboard.Scroll
        Me.DoubleBuffered = True

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        'Calculate the target position of the side panel based on the current scroll position of the form
        Dim targetPos As Integer = Me.AutoScrollPosition.X * -1

        'Calculate the current position of the side panel
        Dim currentPos As Integer = panel_dashboard.Location.X

        'Calculate the distance between the current position and the target position
        Dim distance As Integer = targetPos - currentPos

        'Calculate the amount by which to move the side panel
        Dim moveAmount As Integer = distance / 10

        'If the side panel is close enough to the target position, snap it into place
        If Math.Abs(distance) < 5 Then
            panel_dashboard.Location = New Point(targetPos, panel_dashboard.Location.Y)
        Else
            'Otherwise, move the side panel by the calculated amount
            panel_dashboard.Location = New Point(currentPos + moveAmount, panel_dashboard.Location.Y)
        End If
    End Sub

    Private Sub panel_desktop_Paint(sender As Object, e As PaintEventArgs) Handles panel_desktop.Paint
        Me.DoubleBuffered = True
    End Sub

    Private Sub panel_logo_Paint(sender As Object, e As PaintEventArgs) Handles panel_logo.Paint
        Me.DoubleBuffered = True
    End Sub

    Private Sub panel_logo_Move(sender As Object, e As EventArgs) Handles panel_logo.Move
        Me.DoubleBuffered = True
    End Sub

    Private Sub PictureBox1_Move(sender As Object, e As EventArgs) Handles PictureBox1.Move
        Me.DoubleBuffered = True
    End Sub

    Private Sub paneldash_Paint(sender As Object, e As PaintEventArgs) Handles paneldash.Paint
        DoubleBuffered = True
    End Sub

    Private Function GetUserInformation(ByVal username As String) As String
        Dim userInfo As String = ""
        connect()
        Dim cmd As MySqlCommand

        ' Query the database for the user's information based on their username
        Dim query As String = "SELECT aID, fullname, username, password, email, address, number FROM tbl_admin WHERE username = @username"
        cmd = New MySqlCommand(query, sqlconn)
        cmd.Parameters.AddWithValue("@username", username)
        Dim reader As MySqlDataReader = cmd.ExecuteReader()

        ' Check if there is a result returned from the query
        If reader.Read() Then
            ' Concatenate the user's information into a single string
            userInfo = reader.GetInt32("aID").ToString() & "," & reader.GetString("fullname") & "," & reader.GetString("username") & "," & reader.GetString("password") & "," & reader.GetString("email") & "," & reader.GetString("address") & "," & reader.GetString("number")
        End If

        reader.Close()
        disconnect_db()

        Return userInfo
    End Function
    Private Sub lbl_username_Click(sender As Object, e As EventArgs) Handles lbl_username.Click
        ' Open the update form and pass the user ID and username as parameters
        'Dim updateForm As New admins(Me.userId)
        'updateForm.loggedInUsername = Me.lbl_username.Text.Trim()
        'If updateForm.ShowDialog() = DialogResult.OK Then
        ' Update the username label with the new value
        '   Me.lbl_username.Text = updateForm.loggedInUsername
        'End If

        ' Open the update form and pass the user ID as a parameter
        Dim updateForm As New admins(Me.userId)
        updateForm.Show()
    End Sub

    Private Sub btn_slide_Click(sender As Object, e As EventArgs) Handles btn_slide.Click

    End Sub
    'test
End Class
