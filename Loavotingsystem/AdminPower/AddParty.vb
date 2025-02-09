Imports System.Collections.Specialized.BitVector32
Imports System.Data.OleDb

Public Class AddParty

    Private Sub AddParty_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDataToComboBox("PRESIDENT", CBPresident)
        LoadDataToComboBox("EXECUTIVE VICE PRESIDENT", CBViceEPresident)
        LoadDataToComboBox("VP FINANCE", CBVPfinance)
        LoadDataToComboBox("VP ACTIVITIES", CBActivities)
        LoadDataToComboBox("VP COMMUNICATION AND MARKETING", CBCOMMARKETING)
        LoadDataToComboBox("VP DOCUMENTATION", CbDocumentation)
    End Sub
    Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\loa_voting.accdb;Jet OLEDB:Database Password=1669-21loa"

    Private Sub LoadDataToComboBox(position As String, comboBox As ComboBox)
        Try
            Using connection As New OleDbConnection(connectionString)
                connection.Open()

                ' Modify the query to filter out candidates with "Active" PartyStatus
                Dim query As String = "SELECT Studid, Firstname, Lastname FROM qryCandidatedetails WHERE Position = @Position AND PartyStatus = 'Inactive'"

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


    Private Sub Guna2PictureBox1_Click(sender As Object, e As EventArgs) Handles pictureboxpartylist.Click
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            pictureboxpartylist.ImageLocation = OpenFileDialog1.FileName
        End If
    End Sub

    Private Sub ButtonClear_Click(sender As Object, e As EventArgs) Handles ButtonClear.Click
        pictureboxpartylist.Image = My.Resources._error
    End Sub

    Public AddedPartyPanel As AddParty

    Private Sub ButtonDiscard_Click(sender As Object, e As EventArgs) Handles ButtonDiscard.Click
        If AddedPartyPanel IsNot Nothing Then
            AddedPartyPanel.Close()
        End If
        Me.Close()
    End Sub






    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        Try
            ' Validate if all required fields are filled
            If String.IsNullOrWhiteSpace(txtpartyname.Text) OrElse
               String.IsNullOrWhiteSpace(txtdescriptionparty.Text) OrElse
               CBPresident.SelectedItem Is Nothing OrElse
               CBViceEPresident.SelectedItem Is Nothing OrElse
               CBVPfinance.SelectedItem Is Nothing OrElse
               CBActivities.SelectedItem Is Nothing OrElse
               CBCOMMARKETING.SelectedItem Is Nothing OrElse
               CbDocumentation.SelectedItem Is Nothing Then
                MessageBox.Show("Please fill in all required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            ' Get the selected candidate names for each position
            Dim president As String = CBPresident.SelectedItem.ToString()
            Dim vicePresident As String = CBViceEPresident.SelectedItem.ToString()
            Dim treasurer As String = CBVPfinance.SelectedItem.ToString()
            Dim marketing As String = CBActivities.SelectedItem.ToString()
            Dim documentation As String = CbDocumentation.SelectedItem.ToString()
            Dim communication As String = CBCOMMARKETING.SelectedItem.ToString()

            ' Get the party image as byte array
            Dim partyImageBytes As Byte() = Nothing
            If pictureboxpartylist.Image IsNot Nothing Then
                Using ms As New System.IO.MemoryStream()
                    pictureboxpartylist.Image.Save(ms, pictureboxpartylist.Image.RawFormat)
                    partyImageBytes = ms.ToArray()
                End Using
            End If

            ' Insert data into tblParty
            Using connection As New OleDbConnection(connectionString)
                connection.Open()

                ' Get the next PartyID
                Dim partyID As Integer = GetNextPartyID(connection)

                ' Insert into tblParty
                Dim insertQuery As String = "INSERT INTO tblParty (PartyID, Title, Description, partyimage, PartyStatus) VALUES (@PartyID, @Title, @Description, @partyimage, 'Active')"

                Using command As New OleDbCommand(insertQuery, connection)
                    command.Parameters.AddWithValue("@PartyID", partyID)
                    command.Parameters.AddWithValue("@Title", txtpartyname.Text)
                    command.Parameters.AddWithValue("@Description", txtdescriptionparty.Text)
                    command.Parameters.AddWithValue("@partyimage", If(partyImageBytes, DBNull.Value))
                    command.ExecuteNonQuery()
                End Using

                ' Update PartyStatus and PartyID in tblCandidate for selected students
                UpdateCandidatePartyStatus(connection, "PRESIDENT", president, partyID)
                UpdateCandidatePartyStatus(connection, "EXECUTIVE VICE PRESIDENT", vicePresident, partyID)
                UpdateCandidatePartyStatus(connection, "VP FINANCE", treasurer, partyID)
                UpdateCandidatePartyStatus(connection, "VP ACTIVITIES", marketing, partyID)
                UpdateCandidatePartyStatus(connection, "VP DOCUMENTATION", documentation, partyID)
                UpdateCandidatePartyStatus(connection, "VP COMMUNICATION AND MARKETING", communication, partyID)

                MessageBox.Show("Party added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Using

            Me.Close()
        Catch ex As Exception
            MessageBox.Show("Error saving party: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub UpdateCandidatePartyStatus(connection As OleDbConnection, position As String, candidateName As String, partyID As Integer)
        ' Update PartyStatus and PartyID for the selected candidate
        Dim updateQuery As String = "UPDATE tblCandidate SET PartyStatus = 'Active', PartyID = @PartyID WHERE Position = @Position AND PartyStatus = 'Inactive' AND (Firstname & ' ' & Lastname) = @CandidateName"

        Using updateCommand As New OleDbCommand(updateQuery, connection)
            updateCommand.Parameters.AddWithValue("@PartyID", partyID)
            updateCommand.Parameters.AddWithValue("@Position", position)
            updateCommand.Parameters.AddWithValue("@CandidateName", candidateName)

            updateCommand.ExecuteNonQuery()
        End Using
    End Sub




    Private Function GetNextPartyID(connection As OleDbConnection) As Integer
        ' Retrieve the maximum PartyID from the table where PartyID is not equal to 0 and add 1
        Dim query As String = "SELECT MAX(PartyID) FROM tblParty WHERE CInt(PartyID) <> 0"
        Using command As New OleDbCommand(query, connection)
            Dim result As Object = command.ExecuteScalar()
            If result IsNot DBNull.Value Then
                Return CInt(result) + 1
            Else
                Return 1 ' If there are no records in the table yet or all PartyIDs are 0
            End If
        End Using
    End Function


End Class


