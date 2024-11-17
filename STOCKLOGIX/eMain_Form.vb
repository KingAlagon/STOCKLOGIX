Imports MySql.Data.MySqlClient
Public Class eMain_Form
    Private Property MoveForm As Boolean
    Private Property Move_Form_MousePosition As Point
    Private loggedInUserId As Integer
    Public userId As Integer
    Private _loggedInUsername As String

    Public Sub New(loggedInUsername As String)
        InitializeComponent()
        _loggedInUsername = loggedInUsername
    End Sub

    Public currentChildForm As Form
    Public Sub New()
        MyBase.New()
        ' This call is required by the designer.
        InitializeComponent()
        Me.DoubleBuffered = True
        ' Add any initialization after the InitializeComponent() call.
        Me.Text = String.Empty
        Me.ControlBox = False
        Me.DoubleBuffered = True
        Me.MaximizedBounds = Screen.PrimaryScreen.WorkingArea

    End Sub
    Public Sub New(ByVal userId As Integer)
        ' This call is required by the designer.
        InitializeComponent()

        ' Store the user ID as a class-level variable
        Me.userId = userId
    End Sub
    Public Sub OpenChildForm(childForm As Form)
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

    Private Sub btn_catProd_Click(sender As Object, e As EventArgs) Handles btn_catProd.Click
        If prod_panel.Visible = False Then
            prod_panel.Visible = True
        Else
            prod_panel.Visible = False
        End If
    End Sub
    Private Sub btn_stock_Click(sender As Object, e As EventArgs) Handles btn_stock.Click
        If stock_panel.Visible = False Then
            stock_panel.Visible = True
        Else
            stock_panel.Visible = False
        End If
    End Sub
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        If currentChildForm IsNot Nothing Then
            currentChildForm.Close()
            prod_panel.Visible = False
            stock_panel.Visible = False

        End If
        Reset()
    End Sub

    Private Sub eMain_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        'to display inputted value of the textbox username
        lbl_username.Text = employeelogin.loggedInUsername

        'to hide sub panel in register button
        prod_panel.Visible = False
        stock_panel.Visible = False
    End Sub

    Private Sub btn_minimize_Click(sender As Object, e As EventArgs) Handles btn_minimize.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        Application.Exit()
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

        If prod_panel.Visible = True Then
            prod_panel.Visible = True
            stock_panel.Visible = False


        End If
    End Sub
    Sub subpanel2()
        If stock_panel.Visible = True Then
            stock_panel.Visible = True
            prod_panel.Visible = False
        End If
    End Sub

    Private Sub btn_addProd_Click(sender As Object, e As EventArgs) Handles btn_addProd.Click
        subPanel()
        OpenChildForm(New addProduct)

        updateProductForm.Close()

    End Sub

    Private Sub btn_prodList_Click(sender As Object, e As EventArgs) Handles btn_prodList.Click
        subPanel()
        OpenChildForm(New prodList)


    End Sub

    Private Sub btn_stockout_Click(sender As Object, e As EventArgs) Handles btn_stockout.Click
        subpanel2()
        OpenChildForm(New stockList)
        stockInProduct.Close()
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
    Public loggedInUsername As String

    Private Function GetUserInformation(ByVal username As String) As String
        Dim userInfo As String = ""
        connect()
        Dim cmd As MySqlCommand

        ' Query the database for the user's information based on their username
        Dim query As String = "SELECT eID, fullname, username, password, email, address, number FROM tbl_employee WHERE username = @username"
        cmd = New MySqlCommand(query, sqlconn)
        cmd.Parameters.AddWithValue("@username", username)
        Dim reader As MySqlDataReader = cmd.ExecuteReader()

        ' Check if there is a result returned from the query
        If reader.Read() Then
            ' Concatenate the user's information into a single string
            userInfo = reader.GetInt32("eID").ToString() & "," & reader.GetString("fullname") & "," & reader.GetString("username") & "," & reader.GetString("password") & "," & reader.GetString("email") & "," & reader.GetString("address") & "," & reader.GetString("number")
        End If

        reader.Close()
        disconnect_db()

        Return userInfo
    End Function
    Private Sub lbl_username_Click(sender As Object, e As EventArgs) Handles lbl_username.Click
        ' Open the update form and pass the user ID and username as parameters
        'Dim updateForm As New employees(Me.userId)
        'updateForm.loggedInUsername = Me.lbl_username.Text.Trim()
        ' If updateForm.ShowDialog() = DialogResult.OK Then
        ' Update the username label with the new value
        '   Me.lbl_username.Text = updateForm.loggedInUsername
        'End If

        'Open the update form And pass the user ID as a parameter
        Dim updateForm As New employees(Me.userId)
        updateForm.Show()
    End Sub

    Private Sub btn_POS_Click(sender As Object, e As EventArgs) Handles btn_POS.Click
        Dim msg As String = "We apologize for the inconvenience, but our POS system is currently unavailable."
        Dim title As String = "POS"
        Dim result = MessageBox.Show(msg, title, MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
        If result = DialogResult.OK Then
        End If
    End Sub
End Class