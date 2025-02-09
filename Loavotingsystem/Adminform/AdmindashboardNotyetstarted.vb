Imports System.Data.OleDb
Imports System.Windows.Forms.DataVisualization.Charting

Public Class AdmindashboardNotyetstarted
    Inherits Form

    Private Sub AdmindashboardNotYetStarted_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UpdateVotersCountLabel()
        UpdatePreviousElectionCountLabel()
        updatepartiesccount()
        updatecandidatesload()
        updateadmndload()
    End Sub

    Private Sub btngunarefresh_Click(sender As Object, e As EventArgs) Handles btngunarefresh.Click
        UpdateVotersCountLabel()
        UpdatePreviousElectionCountLabel()
        updatepartiesccount()
        updatecandidatesload()
        updateadmndload()
    End Sub

    Private Sub Guna2GradientButton5_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton5.Click
        Try
            Dim electionStatus As String = GetElectionStatus()

            Using connection As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\loa_voting.accdb;Jet OLEDB:Database Password=1669-21loa")
                connection.Open()

                Dim checkQuery As String = "SELECT COUNT(*) FROM tblElection WHERE IsDone = 'Not finalize'"
                Using checkCommand As New OleDbCommand(checkQuery, connection)
                    Dim isElectionNotFinalized As Integer = Convert.ToInt32(checkCommand.ExecuteScalar())

                    If isElectionNotFinalized > 0 Then

                        Dim candidateQuery As String = "SELECT COUNT(*) FROM tblCandidate WHERE CInt(Voteresiv) > 0"
                        Using candidateCommand As New OleDbCommand(candidateQuery, connection)
                            Dim candidateCount As Integer = Convert.ToInt32(candidateCommand.ExecuteScalar())

                            If candidateCount > 0 Then
                                Dim finalizedResultForm As New FinalizedResult()
                                finalizedResultForm.ShowDialog()
                            Else
                                ' No candidates with non-zero votes, show a messagebox
                                MsgBox("Please Start a new Election.", vbInformation, "Information")
                            End If
                        End Using
                    Else
                        MsgBox("The Election has been finalized. Please Start a new Election", vbInformation, "Information")
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Function GetElectionStatus() As String
        Dim adminDashboardForm As Admindashboard = Application.OpenForms.OfType(Of Admindashboard)().FirstOrDefault()

        If adminDashboardForm IsNot Nothing Then
            Return adminDashboardForm.ChipElectionStatus.Text
        Else
            Return String.Empty
        End If
    End Function



    Private Sub btnprev_Click(sender As Object, e As EventArgs) Handles btnprev.Click
        Dim formodal As New Form
        Try
            Dim modal As New PrevElections
            formodal.StartPosition = FormStartPosition.CenterScreen
            formodal.FormBorderStyle = FormBorderStyle.None
            formodal.Opacity = 0.5D
            formodal.BackColor = Color.Black
            formodal.WindowState = FormWindowState.Maximized
            formodal.TopMost = True
            formodal.Location = Location
            formodal.ShowInTaskbar = False
            formodal.Show()
            modal.Owner = formodal
            PrevElections.ShowDialog()
        Catch ex As Exception
        Finally
            formodal.Dispose()
        End Try
    End Sub

    Private Sub ButtonStartElection_Click(sender As Object, e As EventArgs) Handles ButtonStartElection.Click
        Try
            Using connection As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\loa_voting.accdb;Jet OLEDB:Database Password=1669-21loa")
                connection.Open()
                If HasUnfinalizedElections(connection) Then
                    MessageBox.Show("Please finalize the results of the winner before starting a new election.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Return
                End If

                ' Get distinct positions from tblPosition
                Dim positions As List(Of String) = GetDistinctPositions(connection)

                ' Check if there are at least 2 candidates for each position
                Dim insufficientCandidatesPositions As List(Of String) = CheckCandidatesForMinimumPositions(connection, positions, 2)

                If insufficientCandidatesPositions.Count = 0 Then
                    ' There are at least 2 candidates for all positions, open the StartNewElection form
                    Dim formodal As New Form
                    Try
                        Dim modal As New StartNewElection
                        formodal.StartPosition = FormStartPosition.CenterScreen
                        formodal.FormBorderStyle = FormBorderStyle.None
                        formodal.Opacity = 0.5D
                        formodal.BackColor = Color.Black
                        formodal.WindowState = FormWindowState.Maximized
                        formodal.TopMost = True
                        formodal.Location = Location
                        formodal.ShowInTaskbar = False
                        formodal.Show()
                        modal.Owner = formodal
                        StartNewElection.ShowDialog()
                    Catch ex As Exception
                    Finally
                        formodal.Dispose()
                    End Try
                Else
                    ' Display a message box indicating positions with insufficient candidates
                    MessageBox.Show($"There are not enough candidates (less than 2) for the following positions: {String.Join(", ", insufficientCandidatesPositions)}", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End Using
        Catch ex As Exception
            ' Handle exceptions here
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Function HasUnfinalizedElections(connection As OleDbConnection) As Boolean
        Dim query As String = "SELECT COUNT(*) FROM tblElection WHERE Isdone = 'Not finalize'"
        Using command As New OleDbCommand(query, connection)
            Dim resultCount As Integer = Convert.ToInt32(command.ExecuteScalar())
            Return resultCount > 0
        End Using
    End Function


    Private Function CheckCandidatesForMinimumPositions(connection As OleDbConnection, positions As List(Of String), minimumCandidates As Integer) As List(Of String)
        Dim insufficientCandidatesPositions As New List(Of String)

        For Each position As String In positions
            Dim query As String = "SELECT COUNT(*) FROM tblCandidate WHERE [Position] = @position"
            Using command As New OleDbCommand(query, connection)
                command.Parameters.AddWithValue("@position", position)
                Dim candidateCount As Integer = Convert.ToInt32(command.ExecuteScalar())
                If candidateCount < minimumCandidates Then
                    insufficientCandidatesPositions.Add(position)
                End If
            End Using
        Next

        Return insufficientCandidatesPositions
    End Function
    Private Function GetDistinctPositions(connection As OleDbConnection) As List(Of String)
        Dim positions As New List(Of String)
        Dim query As String = "SELECT DISTINCT [Position] FROM tblPosition"
        Using command As New OleDbCommand(query, connection)
            Using reader As OleDbDataReader = command.ExecuteReader()
                While reader.Read()
                    positions.Add(reader("Position").ToString())
                End While
            End Using
        End Using
        Return positions
    End Function

    Private Function CheckCandidatesForPositions(connection As OleDbConnection, positions As List(Of String)) As List(Of String)
        Dim noCandidatesPositions As New List(Of String)

        For Each position As String In positions
            Dim query As String = "SELECT COUNT(*) FROM tblCandidate WHERE [Position] = @position"
            Using command As New OleDbCommand(query, connection)
                command.Parameters.AddWithValue("@position", position)
                Dim candidateCount As Integer = Convert.ToInt32(command.ExecuteScalar())
                If candidateCount = 0 Then
                    noCandidatesPositions.Add(position)
                End If
            End Using
        Next

        Return noCandidatesPositions
    End Function
    Private connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\loa_voting.accdb;Jet OLEDB:Database Password=1669-21loa"


    Private Sub UpdateVotersCountLabel()
        Try
            Using connection As New OleDbConnection(connectionString)
                connection.Open()

                Dim query As String = "SELECT COUNT(*) FROM tblVoters"
                Using command As New OleDbCommand(query, connection)
                    Dim votersCount As Integer = Convert.ToInt32(command.ExecuteScalar())

                    LabelVotersCount.Text = $" {votersCount}"
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub updatepartiesccount()
        Try
            Using connection As New OleDbConnection(connectionString)
                connection.Open()

                ' Assuming PartyID is a text field
                Dim query As String = "SELECT COUNT(*) FROM tblParty WHERE PartyID BETWEEN '1' AND '100'"

                Using command As New OleDbCommand(query, connection)
                    Dim partiesCount As Integer = Convert.ToInt32(command.ExecuteScalar())

                    LabelParties.Text = $" {partiesCount}"
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub



    Private Sub UpdatePreviousElectionCountLabel()
        Try
            Using connection As New OleDbConnection(connectionString)
                connection.Open()

                Dim query As String = "SELECT COUNT(*) FROM (SELECT DISTINCT Title FROM tblPrevElections)"
                Using command As New OleDbCommand(query, connection)
                    Dim prevElectionCount As Integer = Convert.ToInt32(command.ExecuteScalar())
                    LabelPreviousElection.Text = $" {prevElectionCount}"
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub updatecandidatesload()
        Try
            Using connection As New OleDbConnection(connectionString)
                connection.Open()

                Dim query As String = "SELECT COUNT(*) FROM tblCandidate"
                Using command As New OleDbCommand(query, connection)
                    Dim votersCount As Integer = Convert.ToInt32(command.ExecuteScalar())

                    labelcandidatecount.Text = $" {votersCount}"
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub updateadmndload()
        Try
            Using connection As New OleDbConnection(connectionString)
                connection.Open()

                Dim query As String = "SELECT COUNT(*) FROM tblUsers WHERE AccessLevel <> 'Super Admin'"

                Using command As New OleDbCommand(query, connection)
                    Dim usersCount As Integer = Convert.ToInt32(command.ExecuteScalar())

                    lbladmincount.Text = $" {usersCount}"
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private currentform As Form = Nothing


    ''Admindashboardnotstarted form
    Private Sub movetomanagevoters_Click(sender As Object, e As EventArgs) Handles movetomanagevoters.Click
        Dim formodal As New Form
        Try
            Dim modal As New VotersPanel
            formodal.StartPosition = FormStartPosition.CenterScreen
            formodal.FormBorderStyle = FormBorderStyle.None
            formodal.Opacity = 0.5D
            formodal.BackColor = Color.Black
            formodal.WindowState = FormWindowState.Maximized
            formodal.TopMost = True
            formodal.Location = Location
            formodal.ShowInTaskbar = False
            modal.SetCloseButtonVisibility(True)
            formodal.Show()
            modal.Owner = formodal

            VotersPanel.ShowDialog()

        Catch ex As Exception
        Finally
            formodal.Dispose()
        End Try
    End Sub

    Private Sub ButtonImport_Click(sender As Object, e As EventArgs) Handles ButtonImport.Click
        Dim formodal As New Form
        Try
            Dim modal As New UploadDatabase
            formodal.StartPosition = FormStartPosition.CenterScreen
            formodal.FormBorderStyle = FormBorderStyle.None
            formodal.Opacity = 0.5D
            formodal.BackColor = Color.Black
            formodal.WindowState = FormWindowState.Maximized
            formodal.TopMost = True
            formodal.Location = Location
            formodal.ShowInTaskbar = False
            formodal.Show()
            modal.Owner = formodal
            UploadDatabase.ShowDialog()

        Catch ex As Exception
        Finally
            formodal.Dispose()
        End Try
    End Sub

    Private Sub navigatetocandidates_Click(sender As Object, e As EventArgs) Handles navigatetocandidates.Click
        Dim formodal As New Form
        Try
            Dim modal As New CandidatesPanel
            formodal.StartPosition = FormStartPosition.CenterScreen
            formodal.FormBorderStyle = FormBorderStyle.None
            formodal.Opacity = 0.5D
            formodal.BackColor = Color.Black
            formodal.WindowState = FormWindowState.Maximized
            formodal.TopMost = True
            formodal.Location = Location
            formodal.ShowInTaskbar = False
            modal.setclosecandidatesbtton(True)
            formodal.Show()
            modal.Owner = formodal

            CandidatesPanel.ShowDialog()

        Catch ex As Exception
        Finally
            formodal.Dispose()
        End Try
    End Sub
    ''Admindashboardnotyetstarted form
    Private Sub managetopartypanel_Click(sender As Object, e As EventArgs) Handles managetopartypanel.Click
        Dim formodal As New Form
        Try
            Dim modal As New PartyPanel
            formodal.StartPosition = FormStartPosition.CenterScreen
            formodal.FormBorderStyle = FormBorderStyle.None
            formodal.Opacity = 0.5D
            formodal.BackColor = Color.Black
            formodal.WindowState = FormWindowState.Maximized
            formodal.TopMost = True
            formodal.Location = Location
            formodal.ShowInTaskbar = False
            modal.setpartybtnclose(True)
            formodal.Show()
            modal.Owner = formodal

            PartyPanel.ShowDialog()

        Catch ex As Exception
        Finally
            formodal.Dispose()
        End Try
    End Sub

    Private Sub Guna2GradientButton1_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton1.Click

        Dim formodal As New Form
        Try
            Dim modal As New ManageAdmins
            formodal.StartPosition = FormStartPosition.CenterScreen
            formodal.FormBorderStyle = FormBorderStyle.None
            formodal.Opacity = 0.5D
            formodal.BackColor = Color.Black
            formodal.WindowState = FormWindowState.Maximized
            formodal.TopMost = True
            formodal.Location = Location
            formodal.ShowInTaskbar = False
            formodal.Show()
            modal.Owner = formodal
            ManageAdmins.ShowDialog()

        Catch ex As Exception
        Finally
            formodal.Dispose()
        End Try

    End Sub

End Class