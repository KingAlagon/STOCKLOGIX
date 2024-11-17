Public Class loginoption
    Private Property MoveForm As Boolean
    Private Property Move_Form_MousePosition As Point
    Private Sub btn_admin_Click(sender As Object, e As EventArgs) Handles btn_admin.Click

        adminlogin.Show()
        adminlogin.txt_aUser.Text = ""
        adminlogin.txt_aPass.Text = ""
        Me.Hide()
    End Sub

    Private Sub btn_employee_Click(sender As Object, e As EventArgs) Handles btn_employee.Click
        employeelogin.Show()
        employeelogin.txt_eUser.Text = ""
        employeelogin.txt_ePass.Text = ""
        Me.Hide()
    End Sub

    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        Application.Exit()
    End Sub

    Public Sub New()
        MyBase.New()
        InitializeComponent()
        Me.DoubleBuffered = True
    End Sub

    Private Sub top_panel_MouseDown(sender As Object, e As MouseEventArgs) Handles top_panel.MouseDown
        If e.Button = MouseButtons.Left Then
            MoveForm = True
            Me.Cursor = Cursors.Default
            Move_Form_MousePosition = e.Location
        End If
    End Sub

    Private Sub top_panel_MouseMove(sender As Object, e As MouseEventArgs) Handles top_panel.MouseMove
        If MoveForm Then
            Me.Location = Me.Location + (e.Location - Move_Form_MousePosition)
        End If
    End Sub

    Private Sub top_panel_MouseUp(sender As Object, e As MouseEventArgs) Handles top_panel.MouseUp
        If e.Button = MouseButtons.Left Then
            MoveForm = False
            Me.Cursor = Cursors.Default
        End If
    End Sub
End Class