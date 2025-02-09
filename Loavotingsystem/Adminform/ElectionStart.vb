Imports System.Data.OleDb

Public Class ElectionStart

    Private connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\loa_voting.accdb;Jet OLEDB:Database Password=1669-21loa"

    Private btnSubmitClicked As Boolean = False

    Private Sub BtnSubmit_Click(sender As Object, e As EventArgs) Handles BtnSubmit.Click
        Dim confirmationResult As DialogResult = MessageBox.Show("Are you sure you want to perform the action?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If confirmationResult = DialogResult.Yes Then
            btnSubmitClicked = True

            If SwitchKeepVoter.Checked Then
                UpdateVoterStatus("Unvoted")
            Else
                DeleteAllVoters()
            End If

            If SwitchkeepSubadmin.Checked Then
            Else
                DeleteUsersByAccessLevel("Admin")
            End If

            DeleteAllCandidates()
            DeleteResult()
            Deletellparty()


            MsgBox("New Election has been Success", vbInformation, "Success operation")

            Dim notStartedForm As Admindashboard = Application.OpenForms.OfType(Of Admindashboard)().FirstOrDefault()
            If notStartedForm IsNot Nothing Then
                notStartedForm.RefreshForm()
            End If

            btnSubmitClicked = False
        End If
    End Sub



    Private Sub UpdateVoterStatus(status As String)
        If btnSubmitClicked Then
            Using connection As New OleDbConnection(connectionString)
                connection.Open()
                Dim query As String = "UPDATE tblVoters SET Votestatus=@Votestatus"
                Using command As New OleDbCommand(query, connection)
                    command.Parameters.AddWithValue("@Votestatus", status)
                    command.ExecuteNonQuery()
                End Using
            End Using
        End If
    End Sub

    Private Sub DeleteAllVoters()
        If btnSubmitClicked Then
            Using connection As New OleDbConnection(connectionString)
                connection.Open()
                Dim query As String = "DELETE FROM tblVoters"
                Using command As New OleDbCommand(query, connection)
                    command.ExecuteNonQuery()
                End Using
            End Using
        End If
    End Sub

    Private Sub DeleteUsersByAccessLevel(accessLevel As String)
        If btnSubmitClicked Then
            Using connection As New OleDbConnection(connectionString)
                Try
                    connection.Open()
                    Dim query As String = "DELETE FROM tblUsers WHERE AccessLevel=@AccessLevel"
                    Using command As New OleDbCommand(query, connection)
                        command.Parameters.AddWithValue("@AccessLevel", accessLevel)
                        command.ExecuteNonQuery()
                    End Using
                Catch ex As Exception
                    MessageBox.Show("Error deleting users: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End Using
        End If
    End Sub


    Private Sub DeleteAllCandidates()
        If btnSubmitClicked Then
            Using connection As New OleDbConnection(connectionString)
                connection.Open()
                Dim query As String = "DELETE FROM tblCandidate"
                Using command As New OleDbCommand(query, connection)
                    command.ExecuteNonQuery()
                End Using
            End Using
        End If
    End Sub

    Private Sub Deletellparty()
        If btnSubmitClicked Then
            Using connection As New OleDbConnection(connectionString)
                connection.Open()
                Dim query As String = "DELETE FROM tblParty WHERE PartyStatus = 'Active'"
                Using command As New OleDbCommand(query, connection)
                    command.ExecuteNonQuery()
                End Using
            End Using
        End If
    End Sub

    Private Sub DeleteResult()
        If btnSubmitClicked Then
            Using connection As New OleDbConnection(connectionString)
                connection.Open()
                Dim query As String = "DELETE FROM tblResult"
                Using command As New OleDbCommand(query, connection)
                    command.ExecuteNonQuery()
                End Using
            End Using
        End If
    End Sub



    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub
End Class
