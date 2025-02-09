Imports System.Data.OleDb

Public Class FinalizedResult

    Inherits Form

    Public Sub New()
        Me.DoubleBuffered = True
        InitializeComponent()
    End Sub

    Private _adminDashboard As Admindashboard
    Public WriteOnly Property AdminDashboard As Admindashboard
        Set(value As Admindashboard)
            _adminDashboard = value
        End Set
    End Property

    Private connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\loa_voting.accdb;Jet OLEDB:Database Password=1669-21loa"

    Private Sub FinalizedResult_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadCandidates("PRESIDENT", CBPresident, LabelPresident, lbltiepresident)
        LoadCandidates("EXECUTIVE VICE PRESIDENT", CBViceEPresident, LabelVicePresident, lbltievicepresident)
        LoadCandidates("VP FINANCE", CBVPfinance, LabelFinance, lbltiefinance)
        LoadCandidates("VP ACTIVITIES", CBActivities, LabelActivities, lbltieactivities)
        LoadCandidates("VP COMMUNICATION AND MARKETING", CBCOMMARKETING, LabelComnMarket, lbltiecomnmarketing)
        LoadCandidates("VP DOCUMENTATION", CbDocumentation, LabelDocu, lbltiedocu)
    End Sub

    Private Sub LoadCandidates(position As String, comboBox As ComboBox, labelToUpdate As Label, tieLabel As Label)
        Try
            Using connection As New OleDbConnection(connectionString)
                connection.Open()


                Dim query As String = "SELECT Studid, Firstname, Lastname, Voteresiv FROM tblCandidate " &
                                  "WHERE Position = @Position AND PartyStatus IN ('Active', 'Inactive') " &
                                  "ORDER BY Voteresiv DESC, Lastname, Firstname"

                Using command As New OleDbCommand(query, connection)
                    command.Parameters.AddWithValue("@Position", position)
                    Using reader As OleDbDataReader = command.ExecuteReader()

                        Dim highestVotes As Integer = 0
                        Dim candidatesWithHighestVotes As New List(Of String)()
                        While reader.Read()
                            Dim currentVotes = Convert.ToInt32(reader("Voteresiv"))
                            Dim currentCandidateName = $"{reader("Firstname")} {reader("Lastname")}"

                            If currentVotes = highestVotes Then
                                candidatesWithHighestVotes.Add(currentCandidateName)
                            ElseIf currentVotes > highestVotes Then

                                highestVotes = currentVotes
                                candidatesWithHighestVotes.Clear()
                                candidatesWithHighestVotes.Add(currentCandidateName)
                            End If
                        End While

                        If candidatesWithHighestVotes.Count = 1 Then

                            labelToUpdate.Text = candidatesWithHighestVotes(0)
                            comboBox.Visible = False
                            tieLabel.Visible = False
                        ElseIf candidatesWithHighestVotes.Count > 1 Then

                            comboBox.Items.Clear()
                            comboBox.Items.AddRange(candidatesWithHighestVotes.ToArray())
                            comboBox.Visible = True
                            tieLabel.Visible = True

                            labelToUpdate.Text = "(None Selected)"
                        Else

                            comboBox.Visible = False
                            tieLabel.Visible = False
                            labelToUpdate.Text = ""
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub





    Private Sub PositionComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBPresident.SelectedIndexChanged,
                                                                                            CBViceEPresident.SelectedIndexChanged,
                                                                                            CBVPfinance.SelectedIndexChanged,
                                                                                            CBActivities.SelectedIndexChanged,
                                                                                            CBCOMMARKETING.SelectedIndexChanged,
                                                                                            CbDocumentation.SelectedIndexChanged
        Dim comboBox As ComboBox = DirectCast(sender, ComboBox)
        Dim labelToUpdate As Label

        If comboBox.SelectedItem IsNot Nothing Then
            Select Case comboBox.Name
                Case "CBPresident"
                    labelToUpdate = LabelPresident
                Case "CBViceEPresident"
                    labelToUpdate = LabelVicePresident
                Case "CBVPfinance"
                    labelToUpdate = LabelFinance
                Case "CBActivities"
                    labelToUpdate = LabelActivities
                Case "CBCOMMARKETING"
                    labelToUpdate = LabelComnMarket
                Case "CbDocumentation"
                    labelToUpdate = LabelDocu
                Case Else
                    labelToUpdate = Nothing
            End Select

            If labelToUpdate IsNot Nothing Then
                UpdateLabel(comboBox.SelectedItem.ToString(), labelToUpdate)
            End If
        End If
    End Sub

    Private Sub UpdateLabel(selectedName As String, labelToUpdate As Label)
        labelToUpdate.Text = selectedName
    End Sub

    Private Sub btnfinalized_Click(sender As Object, e As EventArgs) Handles btnfinalized.Click
        If LabelPresident.Text = "(None Selected)" Or
        LabelVicePresident.Text = "(None Selected)" Or
        LabelFinance.Text = "(None Selected)" Or
        LabelActivities.Text = "(None Selected)" Or
        LabelComnMarket.Text = "(None Selected)" Or
        LabelDocu.Text = "(None Selected)" Then

            MessageBox.Show("Please select candidates for all positions before finalizing.", "Incomplete Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If AreResultsFinalized() Then
            MessageBox.Show("Finalized results already exist in the database. Cannot finalize again.", "Already Finalized", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If


        InsertFinalizedResults("PRESIDENT", LabelPresident.Text)
        InsertFinalizedResults("EXECUTIVE VICE PRESIDENT", LabelVicePresident.Text)
        InsertFinalizedResults("VP FINANCE", LabelFinance.Text)
        InsertFinalizedResults("VP ACTIVITIES", LabelActivities.Text)
        InsertFinalizedResults("VP COMMUNICATION AND MARKETING", LabelComnMarket.Text)
        InsertFinalizedResults("VP DOCUMENTATION", LabelDocu.Text)

        MessageBox.Show("Finalized results have been inserted into tblResult.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Me.Close()

        Dim adminDashboardForm As Admindashboard = Me._adminDashboard


        If adminDashboardForm IsNot Nothing Then
            Dim adminDashboardEndedForm As New AdmindashboardEnded()
            adminDashboardEndedForm.TopLevel = False
            adminDashboardEndedForm.FormBorderStyle = FormBorderStyle.None
            adminDashboardEndedForm.Dock = DockStyle.Fill
            adminDashboardForm.mainform.Controls.Add(adminDashboardEndedForm)
            adminDashboardEndedForm.BringToFront()
            adminDashboardEndedForm.Show()
        End If

    End Sub


    Private Function AreResultsFinalized() As Boolean
        Try
            Using connection As New OleDbConnection(connectionString)
                connection.Open()
                Dim query As String = "SELECT COUNT(*) FROM tblResult"
                Using command As New OleDbCommand(query, connection)
                    Dim resultCount As Integer = Convert.ToInt32(command.ExecuteScalar())

                    Return resultCount > 0
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error checking finalized results: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function




    Private Sub InsertFinalizedResults(position As String, candidateName As String)
        Try
            Using connection As New OleDbConnection(connectionString)
                connection.Open()

                Dim resultQuery As String = "INSERT INTO tblResult (Studid, PartyID, Title, Votes, Firstname, Lastname, [Position]) " &
                             "SELECT tblCandidate.Studid, tblParty.PartyID, tblParty.Title, tblCandidate.Voteresiv, " &
                             "tblCandidate.Firstname, tblCandidate.Lastname, tblCandidate.[Position] " &
                             "FROM tblCandidate " &
                             "INNER JOIN tblParty ON tblCandidate.PartyID = tblParty.PartyID " &
                             "WHERE tblCandidate.[Position] = ? AND (tblParty.PartyStatus = 'Active' OR tblParty.PartyStatus = 'Inactive' OR tblParty.PartyStatus = 'Independent') " &
                             "AND (tblCandidate.Firstname & ' ' & tblCandidate.Lastname) = ?"
                Using resultCommand As New OleDbCommand(resultQuery, connection)
                    resultCommand.Parameters.AddWithValue("@Position", position)
                    resultCommand.Parameters.AddWithValue("@CandidateName", candidateName)
                    resultCommand.ExecuteNonQuery()
                End Using


                Dim updateElectionQuery As String = "UPDATE tblElection SET Isdone = 'Finalized' WHERE ID = (SELECT TOP 1 ID FROM tblElection ORDER BY Ended DESC)"
                Using updateElectionCommand As New OleDbCommand(updateElectionQuery, connection)
                    updateElectionCommand.ExecuteNonQuery()
                End Using

                Dim prevElectionsQuery As String = "INSERT INTO tblPrevElections (Title, Started, Ended, Status, Studid, PartyID, Votes, Firstname, Lastname, [Position], PartyName, Whowin) " &
    "SELECT " &
    "(SELECT TOP 1 Title FROM tblElection ORDER BY Ended DESC), " &
    "(SELECT Started FROM tblElection WHERE ID = (SELECT TOP 1 ID FROM tblElection ORDER BY Ended DESC)), " &
    "(SELECT Ended FROM tblElection WHERE ID = (SELECT TOP 1 ID FROM tblElection ORDER BY Ended DESC)), " &
    "'Ended' AS ElectionStatus, tblCandidate.Studid, tblParty.PartyID, tblCandidate.Voteresiv, " &
    "tblCandidate.Firstname, tblCandidate.Lastname, tblCandidate.[Position], tblParty.Title AS PartyName, " &
    "IIf((tblCandidate.Firstname & ' ' & tblCandidate.Lastname) = @CandidateName, 'Won', 'Lose') AS Whowin " &
    "FROM tblCandidate " &
    "INNER JOIN tblParty ON tblCandidate.PartyID = tblParty.PartyID " &
 "WHERE tblCandidate.[Position] = @Position AND (tblParty.PartyStatus = 'Active' OR tblParty.PartyStatus = 'Inactive' OR tblParty.PartyStatus = 'Independent')"

                Using prevElectionsCommand As New OleDbCommand(prevElectionsQuery, connection)
                    prevElectionsCommand.Parameters.AddWithValue("@CandidateName", candidateName)
                    prevElectionsCommand.Parameters.AddWithValue("@Position", position)
                    prevElectionsCommand.ExecuteNonQuery()
                End Using





            End Using
        Catch ex As Exception
            MessageBox.Show("Error inserting finalized results: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub



End Class
