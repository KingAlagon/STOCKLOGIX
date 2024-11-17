Imports MySql.Data.MySqlClient

Module Module1
    Public sqlconn As New MySqlConnection
    Public ds As New DataSet
    Public da As New MySqlDataAdapter
    Public dr As MySqlDataReader
    Public Sub connect()
        If sqlconn.State = ConnectionState.Closed Then
            sqlconn = New MySqlConnection("server=localhost;userid=root;password=;database=stocklogix;")
            sqlconn.Open()

        End If
    End Sub
    Public Sub disconnect_db()
        If sqlconn.State = ConnectionState.Open Then
            sqlconn.Close()

        End If
    End Sub
End Module
