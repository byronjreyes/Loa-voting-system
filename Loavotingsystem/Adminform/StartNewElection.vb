Imports System.Data.OleDb

Public Class StartNewElection


    Private WithEvents countdownTimer As New Timer()
    Private endDate As DateTime

    Private Sub StartNewElection_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Guna2DateTimePicker1.MinDate = DateTime.Now.Date
        Guna2DateTimePicker1.Value = DateTime.Now

        countdownTimer.Interval = 1000 ' 1 second
        countdownTimer.Enabled = False
    End Sub
    Private Function GetPasswordFromDatabase(username As String) As String
        Dim password As String = ""

        Try
            Using cn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\loa_voting.accdb;Jet OLEDB:Database Password=1669-21loa")
                Using cmd As New OleDbCommand("SELECT Password FROM tblUsers WHERE Username = @Username", cn)
                    cn.Open()
                    cmd.Parameters.AddWithValue("@Username", username)

                    Dim result As Object = cmd.ExecuteScalar()

                    If result IsNot Nothing AndAlso Not DBNull.Value.Equals(result) Then
                        password = result.ToString()
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error retrieving password from the database: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Return password
    End Function

    Private Sub ButtonStart_Click(sender As Object, e As EventArgs) Handles ButtonStart.Click
        Try
            If String.IsNullOrEmpty(TextName.Text) Then
                MessageBox.Show("Please provide a valid election title.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            Dim loggedInUsername As String = CType(Application.OpenForms.OfType(Of Admindashboard)().FirstOrDefault(), Admindashboard)?.LoggedInUsername

            Dim userPassword As String = GetPasswordFromDatabase(loggedInUsername)

            If TextPassword.Text <> userPassword Then
                MessageBox.Show("Incorrect password. Please enter the correct password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            Dim status As String = "Active"
            Dim startedDateTime As DateTime = DateTime.Now

            Dim endDate As DateTime = Guna2DateTimePicker1.Value
            If Guna2RadioButton1for7ammoring.Checked Then
                ' Set the time to 7:00 AM
                endDate = endDate.Date.Add(New TimeSpan(7, 0, 0))
            ElseIf Guna2RadioButton2for12pmafternoon.Checked Then
                ' Set the time to 12:00 PM
                endDate = endDate.Date.Add(New TimeSpan(12, 0, 0))
            ElseIf Guna2RadioButton3for6pmevening.Checked Then
                ' Set the time to 6:00 PM
                endDate = endDate.Date.Add(New TimeSpan(18, 0, 0))
            End If

            If endDate < DateTime.Now Then
                MessageBox.Show("Selected date and time must be later than the current date and time.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            Me.endDate = endDate

            Dim formattedStartedDateTime As String = startedDateTime.ToString("M/d/yyyy h:mm:ss tt")
            Dim formattedEndedDateTime As String = endDate.ToString("M/d/yyyy h:mm:ss tt")


            Dim insertSql As String = "INSERT INTO tblElection (Title, Status, Started, Ended, Isdone) VALUES (@Title, @Status, @Started, @Ended, @Isdone)"

            Using cn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\loa_voting.accdb;Jet OLEDB:Database Password=1669-21loa")
                Using cmd As New OleDbCommand(insertSql, cn)
                    cn.Open()
                    cmd.Parameters.AddWithValue("@Title", TextName.Text)
                    cmd.Parameters.AddWithValue("@Status", status)
                    cmd.Parameters.AddWithValue("@Started", formattedStartedDateTime)
                    cmd.Parameters.AddWithValue("@Ended", formattedEndedDateTime)
                    cmd.Parameters.AddWithValue("@Isdone", "Not finalize") ' Set the default value for Isdone
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Election has started!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            countdownTimer.Start()

            Dim adminDashboard As Admindashboard = Application.OpenForms.OfType(Of Admindashboard)().FirstOrDefault()
            If adminDashboard IsNot Nothing Then
                adminDashboard.lbltimeremaining.Visible = True
                adminDashboard.lblelectionend.Visible = True

                adminDashboard.ChipElectionStatus.Text = "Started"

                Dim voterealCountForm As VoterealCount = New VoterealCount()
                voterealCountForm.TopLevel = False
                voterealCountForm.FormBorderStyle = FormBorderStyle.None
                voterealCountForm.Dock = DockStyle.Fill
                adminDashboard.mainform.Controls.Clear()
                adminDashboard.mainform.Controls.Add(voterealCountForm)
                voterealCountForm.BringToFront()
                voterealCountForm.Show()
            End If

            Me.Close()

        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub countdownTimer_Tick(sender As Object, e As EventArgs) Handles countdownTimer.Tick
        Dim currentTime As DateTime = DateTime.Now

        Dim remainingTime As TimeSpan = endDate - currentTime

        Dim formattedRemainingTime As String = ""

        If remainingTime.TotalSeconds > 0 Then
            If remainingTime.TotalDays >= 1 Then
                formattedRemainingTime = String.Format("{0} days {1:D2} hrs {2:D2} mins {3:D2} secs",
                                       remainingTime.Days, remainingTime.Hours, remainingTime.Minutes, remainingTime.Seconds)
            ElseIf remainingTime.Hours > 0 Then
                formattedRemainingTime = String.Format("{0} hrs {1:D2} mins {2:D2} secs",
                                       remainingTime.Hours, remainingTime.Minutes, remainingTime.Seconds)
            Else
                formattedRemainingTime = String.Format("{0} mins {1:D2} secs",
                                       remainingTime.Minutes, remainingTime.Seconds)
            End If

            Dim adminDashboard As Admindashboard = Application.OpenForms.OfType(Of Admindashboard)().FirstOrDefault()
            If adminDashboard IsNot Nothing Then
                adminDashboard.lbltimeremaining.Text = "" & formattedRemainingTime
            End If
        Else
            countdownTimer.Stop()

            Dim adminDashboard As Admindashboard = Application.OpenForms.OfType(Of Admindashboard)().FirstOrDefault()
            If adminDashboard IsNot Nothing Then
                adminDashboard.ChipElectionStatus.Text = "Ended"
                adminDashboard.lbltimeremaining.Text = "Election Ended"
                adminDashboard.HideTimerLabels()

                ' Update tblElection status to "Inactive"
                Try
                    Dim updateSql As String = "UPDATE tblElection SET Status = 'Inactive' WHERE Status = 'Active'"

                    Using cn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\loa_voting.accdb;Jet OLEDB:Database Password=1669-21loa")
                        Using cmd As New OleDbCommand(updateSql, cn)
                            cn.Open()
                            cmd.ExecuteNonQuery()
                        End Using
                    End Using
                Catch ex As Exception
                    MessageBox.Show("Error updating election status: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
        End If
    End Sub





    Private Sub Guna2GroupBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextPassword_TextChanged(sender As Object, e As EventArgs) Handles TextPassword.TextChanged

    End Sub

    Private Sub ButtonCancel_Click(sender As Object, e As EventArgs) Handles ButtonCancel.Click
        Me.Close()
    End Sub
End Class
