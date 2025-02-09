Imports System.Data.OleDb

Public Class UpdateVoters
    Private Sub UpdateVoters_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Public Sub setvotersinfo(lrnid As String, studId As String, firstName As String, lastName As String, course As String, yearLvl As String, sectionStatus As String, votingstatus As String, passwords As String)

        LabelLRN.Text = lrnid
        TextStudentID.Text = studId
        TextFirstname.Text = firstName
        TextLastname.Text = lastName
        CBCourse.Text = course
        CBYear.Text = yearLvl.ToString()
        CBSection.Text = sectionStatus.ToString()
        cbvote.Text = votingstatus
    End Sub

    Private Sub ButtonDiscard_Click(sender As Object, e As EventArgs) Handles ButtonDiscard.Click
        Me.Close()
    End Sub

    Private Sub ButtonSubmit_Click(sender As Object, e As EventArgs) Handles ButtonSubmit.Click
        updatedata()
    End Sub
    Private Sub updatedata()
        Try
            ' Check if all required fields are filled in
            If String.IsNullOrWhiteSpace(TextFirstname.Text) OrElse
               String.IsNullOrWhiteSpace(TextLastname.Text) OrElse
               String.IsNullOrWhiteSpace(CBCourse.Text) OrElse
               String.IsNullOrWhiteSpace(CBYear.Text) OrElse
               String.IsNullOrWhiteSpace(cbvote.Text) OrElse
               String.IsNullOrWhiteSpace(CBSection.Text) Then

                MsgBox("Please fill in all required fields.", MsgBoxStyle.Exclamation)
                Return
            End If

            Using cn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\loa_voting.accdb;Jet OLEDB:Database Password=1669-21loa")
                cn.Open()

                ' Update tblVoters
                Dim sqlVoters As String = "UPDATE tblVoters SET [Firstname]=@firstname, [Lastname]=@lastname, [Course]=@course, [Yearlvl]=@yearlvl, [Votestatus]=@votestatus, [SectionStatus]=@sectionstatus WHERE Studid=@studid"
                Using cmdVoters As New OleDbCommand(sqlVoters, cn)
                    With cmdVoters
                        .Parameters.AddWithValue("@firstname", TextFirstname.Text)
                        .Parameters.AddWithValue("@lastname", TextLastname.Text)
                        .Parameters.AddWithValue("@course", CBCourse.Text)
                        .Parameters.AddWithValue("@yearlvl", CBYear.Text)
                        .Parameters.AddWithValue("@votestatus", cbvote.Text)
                        .Parameters.AddWithValue("@sectionstatus", CBSection.Text)
                        .Parameters.AddWithValue("@studid", TextStudentID.Text)
                        .ExecuteNonQuery()
                    End With
                End Using

            End Using

            MsgBox("Voters Record Successfully Updated", MsgBoxStyle.Information)

        Catch ex As Exception
            MsgBox("Error updating candidate record: " & ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub TextStudentID_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextStudentID.KeyPress
        If Not Char.IsLetterOrDigit(e.KeyChar) AndAlso e.KeyChar <> ChrW(Keys.Back) AndAlso e.KeyChar <> "-" Then
            e.Handled = True
        End If
    End Sub



    Private Sub TextStudentID_TextChanged(sender As Object, e As EventArgs) Handles TextStudentID.TextChanged
        If TextStudentID.Text.Length > 7 Then
            TextStudentID.Text = TextStudentID.Text.Substring(0, 7)
        End If
    End Sub

    Private Sub TextFirstname_TextChanged(sender As Object, e As EventArgs) Handles TextFirstname.TextChanged
        TextFirstname.Text = New String(TextFirstname.Text.Where(Function(c) Char.IsLetter(c) OrElse Char.IsWhiteSpace(c)).ToArray())
        TextFirstname.SelectionStart = TextFirstname.Text.Length
    End Sub

    Private Sub TextLastname_TextChanged(sender As Object, e As EventArgs) Handles TextLastname.TextChanged
        TextLastname.Text = New String(TextLastname.Text.Where(Function(c) Char.IsLetter(c) OrElse Char.IsWhiteSpace(c)).ToArray())
        TextLastname.SelectionStart = TextLastname.Text.Length
    End Sub


End Class