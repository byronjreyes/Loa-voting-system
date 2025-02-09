Imports System.Data.SqlClient

Public Class Candidate
    Public Property Studid As String
    Public Property Firstname As String
    Public Property Lastname As String
    Public Property Position As String
    Public Property Representative As String
    Public Property Course As String
    Public Property Yearlvl As String
    Public Property Tagline As String
    Public Property Img As String
    Public Property PartyStatus As String

    Public Sub New(reader As SqlDataReader)
        ' Initialize properties from SqlDataReader
        Studid = reader("Studid").ToString()
        Firstname = reader("Firstname").ToString()
        Lastname = reader("Lastname").ToString()
        Position = reader("Position").ToString()
        Representative = reader("Representative").ToString()
        Course = reader("Course").ToString()
        Yearlvl = reader("Yearlvl").ToString()
        Tagline = reader("Tagline").ToString()
        Img = reader("Img").ToString()
        PartyStatus = reader("PartyStatus").ToString()
    End Sub
End Class
