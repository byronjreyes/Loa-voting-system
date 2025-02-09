Imports System.Data.OleDb

Public Class Votenow

    'LabelPresident
    'LabelVicePresident
    'LabelFinance
    'LabelActivities
    'LabelComnMarket
    'LabelDocu

    Private Sub Votenow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDataToComboBox("PRESIDENT", CBPresident)
        LoadDataToComboBox("EXECUTIVE VICE PRESIDENT", CBViceEPresident)
        LoadDataToComboBox("VP FINANCE", CBVPfinance)
        LoadDataToComboBox("VP ACTIVITIES", CBActivities)
        LoadDataToComboBox("VP COMMUNICATION AND MARKETING", CBCOMMARKETING)
        LoadDataToComboBox("VP DOCUMENTATION", CbDocumentation)
    End Sub



    Private Sub ButtonClear_Click(sender As Object, e As EventArgs) Handles ButtonClear.Click
        ' Clear selected votes
        LabelPresident.Text = "(None Selected)"
        LabelVicePresident.Text = "(None Selected)"
        LabelFinance.Text = "(None Selected)"
        LabelActivities.Text = "(None Selected)"
        LabelComnMarket.Text = "(None Selected)"
        LabelDocu.Text = "(None Selected)"
        ' Add additional labels as needed
    End Sub


    Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\loa_voting.accdb;Jet OLEDB:Database Password=1669-21loa"

    Private Sub LoadDataToComboBox(position As String, comboBox As ComboBox)
        Try
            Using connection As New OleDbConnection(connectionString)
                connection.Open()

                ' Modify the query to include candidates with both "Active" and "Inactive" PartyStatus
                Dim query As String = "SELECT Studid, Firstname, Lastname FROM tblCandidate WHERE Position = @Position AND (PartyStatus = 'Active' OR PartyStatus = 'Inactive')"

                Using command As New OleDbCommand(query, connection)
                    command.Parameters.AddWithValue("@Position", position)
                    Using reader As OleDbDataReader = command.ExecuteReader()
                        comboBox.Items.Clear()
                        While reader.Read()
                            Dim name As String = $"{reader("Firstname")} {reader("Lastname")}"
                            comboBox.Items.Add(name)
                        End While
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub PositionComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBPresident.SelectedIndexChanged, CBViceEPresident.SelectedIndexChanged, CBVPfinance.SelectedIndexChanged, CBActivities.SelectedIndexChanged, CBCOMMARKETING.SelectedIndexChanged, CbDocumentation.SelectedIndexChanged
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
                    ' Add additional cases for other ComboBoxes as needed
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

    Private _loggedInUsername As String
    Public Property LoggedInUsername As String
        Get
            Return _loggedInUsername
        End Get
        Set(value As String)
            _loggedInUsername = value
        End Set
    End Property

    Private Sub ButtonSubmit_Click(sender As Object, e As EventArgs) Handles ButtonSubmit.Click
        Try
            If LoggedInUsername IsNot Nothing Then
                ' Validate the form
                If ValidateForm() Then
                    ' Form is valid, proceed with submission
                    Connection()

                    ' Update the vote count for each selected candidate
                    UpdateVoteCount("PRESIDENT", CBPresident)
                    UpdateVoteCount("EXECUTIVE VICE PRESIDENT", CBViceEPresident)
                    UpdateVoteCount("VP FINANCE", CBVPfinance)
                    UpdateVoteCount("VP ACTIVITIES", CBActivities)
                    UpdateVoteCount("VP COMMUNICATION AND MARKETING", CBCOMMARKETING)
                    UpdateVoteCount("VP DOCUMENTATION", CbDocumentation)

                    ' Set the selected candidates to display in VoteInformation form
                    Dim voteInfoForm As New VoteInformation()
                    voteInfoForm.PresidentLabel = CBPresident.Text
                    voteInfoForm.VicePresidentLabel = CBViceEPresident.Text
                    voteInfoForm.FinanceLabel = CBVPfinance.Text
                    voteInfoForm.ActivitiesLabel = CBActivities.Text
                    voteInfoForm.ComnMarketLabel = CBCOMMARKETING.Text
                    voteInfoForm.DocuLabel = CbDocumentation.Text

                    If TypeOf Me.ParentForm Is VotingDashboard Then
                        Dim votingDashboard As VotingDashboard = DirectCast(Me.ParentForm, VotingDashboard)
                        votingDashboard.ShowVoteInformationForm(CBPresident.Text, CBViceEPresident.Text,
                                                    CBVPfinance.Text, CBActivities.Text,
                                                    CBCOMMARKETING.Text, CbDocumentation.Text)
                    End If
                    MessageBox.Show("Votes submitted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    ' Update VotingStatus to "Voted" for the logged-in voter in tblVoters
                    Dim updateSql As String = "UPDATE tblVoters SET [Votestatus] = 'Voted' WHERE [Studid] = @studid;"
                    Using cmdUpdate As New OleDbCommand(updateSql, cn)
                        cmdUpdate.Parameters.AddWithValue("@studid", LoggedInUsername)
                        cmdUpdate.ExecuteNonQuery()
                    End Using

                    ' Optionally, you can clear the selected votes and labels after submission
                    ClearSelectedVotes()
                Else
                    ' Handle validation failure
                End If
            Else
                MessageBox.Show("Error: Logged-in username is null.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show("Error submitting votes: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub



    Private Function ValidateForm() As Boolean


        Dim presidentvaliderror As String = ""
        Dim vicepresidenterror As String = ""
        Dim vicefinanceerror As String = ""
        Dim viceactivitieserror As String = ""
        Dim vicecomunicationerror As String = ""
        Dim vicedocumentationerror As String = ""


        If CBPresident.Text.Trim() = "" Then
            presidentvaliderror = "- Please select a candidate for President" & Environment.NewLine
        End If

        If CBViceEPresident.Text.Trim() = "" Then
            vicepresidenterror = "- Please select a candidate for Executive Vice President" & Environment.NewLine
        End If

        If CBVPfinance.Text.Trim() = "" Then
            vicefinanceerror = "- Please select a candidate for VP Finance" & Environment.NewLine
        End If

        If CBActivities.Text.Trim() = "" Then
            viceactivitieserror = "- Please select a candidate for VP Activities" & Environment.NewLine
        End If

        If CBCOMMARKETING.Text.Trim() = "" Then
            vicecomunicationerror = "- Please select a candidate for VP Communication and Marketing" & Environment.NewLine
        End If

        If CbDocumentation.Text.Trim() = "" Then
            vicedocumentationerror = "- Please select a candidate for VP Documentation" & Environment.NewLine
        End If


        ' Update labels with validation messages
        lblpresidenterror.Text = presidentvaliderror
        lblvicepresidenterror.Text = vicepresidenterror
        lblfinanceerror.Text = vicefinanceerror
        lblactivitieserror.Text = viceactivitieserror
        lblcomandmarketingerrror.Text = vicecomunicationerror
        lbldocuerror.Text = vicedocumentationerror

        ' Check if any validation error exists
        If presidentvaliderror <> "" OrElse
       vicepresidenterror <> "" OrElse
       vicefinanceerror <> "" OrElse
       viceactivitieserror <> "" OrElse
       vicecomunicationerror <> "" OrElse
       vicedocumentationerror <> "" Then


            Return False
        Else
            ' Clear labels if there are no validation errors
            lblpresidenterror.Text = ""
            lblvicepresidenterror.Text = ""
            lblfinanceerror.Text = ""
            lblactivitieserror.Text = ""
            lblcomandmarketingerrror.Text = ""
            lbldocuerror.Text = ""

            Return True ' Validation passed
        End If
    End Function

    Private Sub ComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBPresident.SelectedIndexChanged, CBViceEPresident.SelectedIndexChanged, CBVPfinance.SelectedIndexChanged, CBActivities.SelectedIndexChanged, CBCOMMARKETING.SelectedIndexChanged, CbDocumentation.SelectedIndexChanged
        ' Cast the sender to ComboBox to access properties and methods
        Dim comboBox As ComboBox = DirectCast(sender, ComboBox)

        ' Get the corresponding error label
        Dim errorLabel As Label = GetErrorLabel(comboBox)

        ' Check if the combo box is not empty
        If comboBox.SelectedIndex <> -1 Then
            ' Combo box is not empty, clear the error label
            errorLabel.Text = ""
        End If
    End Sub

    Private Function GetErrorLabel(comboBox As ComboBox) As Label
        ' Return the corresponding error label based on the combo box
        Select Case comboBox.Name
            Case "CBPresident"
                Return lblpresidenterror
            Case "CBViceEPresident"
                Return lblvicepresidenterror
            Case "CBVPfinance"
                Return lblfinanceerror
            Case "CBActivities"
                Return lblactivitieserror
            Case "CBCOMMARKETING"
                Return lblcomandmarketingerrror
            Case "CbDocumentation"
                Return lbldocuerror
            Case Else
                Return Nothing
        End Select
    End Function



    Private Sub UpdateVoteCount(position As String, comboBox As ComboBox)
        Try
            If comboBox.SelectedItem IsNot Nothing Then
                Using connection As New OleDbConnection(connectionString)
                    connection.Open()

                    ' Increment the vote count in tblCandidate for both "Active" and "Inactive" PartyStatus
                    Dim updateQuery As String = "UPDATE tblCandidate SET Voteresiv = Voteresiv + 1 WHERE Position = @Position AND (PartyStatus = 'Active' OR PartyStatus = 'Inactive') AND (FirstName & ' ' & LastName) = @CandidateName"

                    Using command As New OleDbCommand(updateQuery, connection)
                        command.Parameters.AddWithValue("@Position", position)
                        command.Parameters.AddWithValue("@CandidateName", comboBox.SelectedItem.ToString())
                        command.ExecuteNonQuery()
                    End Using
                End Using
            End If
        Catch ex As Exception
            Throw New Exception("Error updating vote count: " & ex.Message)
        End Try
    End Sub



    Private Sub ClearSelectedVotes()
        ' Clear selected votes and labels
        CBPresident.SelectedIndex = -1
        CBViceEPresident.SelectedIndex = -1
        CBVPfinance.SelectedIndex = -1
        CBActivities.SelectedIndex = -1
        CBCOMMARKETING.SelectedIndex = -1
        CbDocumentation.SelectedIndex = -1
        LabelPresident.Text = "(None Selected)"
        LabelVicePresident.Text = "(None Selected)"
        LabelFinance.Text = "(None Selected)"
        LabelActivities.Text = "(None Selected)"
        LabelComnMarket.Text = "(None Selected)"
        LabelDocu.Text = "(None Selected)"
        ' Add additional labels and ComboBoxes as needed
    End Sub

End Class
