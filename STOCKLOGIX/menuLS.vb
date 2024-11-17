Imports MySql.Data.MySqlClient
Public Class menuLS
    Public userId As Integer
    Public loggedInUsername As String
    Public Sub New(ByVal userId As Integer)
        ' This call is required by the designer.
        InitializeComponent()

        ' Store the user ID as a class-level variable
        Me.userId = userId
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
    Private Sub menuLS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If (ProgressBar1.Value = ProgressBar1.Maximum) Then
            Dim mainform As New main_form(Me.userId)
            mainform.Show()
            Timer1.Enabled = False
            Me.Close()
        Else
            ProgressBar1.PerformStep()

        End If
    End Sub
    Public Sub New()
        MyBase.New()
        InitializeComponent()
        Me.DoubleBuffered = True
    End Sub
End Class