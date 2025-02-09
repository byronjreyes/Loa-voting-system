Imports System.Data.OleDb

Module dbconnection

    Public cn As New OleDbConnection
    Public cmd As New OleDbCommand
    Public sql As String
    Public dr As OleDbDataReader

    Public Sub Connection()

        cn.Close()

        cn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\loa_voting.accdb;Jet OLEDB:Database Password=1669-21loa"
        cn.Open()

    End Sub
End Module
