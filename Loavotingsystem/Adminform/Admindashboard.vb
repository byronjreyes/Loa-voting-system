Imports System.Data.OleDb
Imports System.Management.Instrumentation
Imports Guna.UI2.WinForms

Public Class Admindashboard
    Inherits Form

    Public Sub New()
        Me.DoubleBuffered = True
        InitializeComponent()

        ChipElectionStatus.Text = "Not Started"
    End Sub
    Public ActivePage As Guna2Button
    Private ElectionEnded As Boolean = False



    Private Sub Admindashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UpdateDateTimeLabel()
        CheckElectionStatus()
    End Sub



    Public Sub HideTimerLabels()
        lbltimeremaining.Visible = False
        lblelectionend.Visible = False
    End Sub



    Private Sub UpdateRemainingTimeLabel(remainingTime As TimeSpan)
        Dim formattedRemainingTime As String

        If remainingTime.Days >= 1 Then
            formattedRemainingTime = String.Format("{0} days {1:D2} hrs {2:D2} mins {3:D2} secs",
                                           remainingTime.Days, remainingTime.Hours, remainingTime.Minutes, remainingTime.Seconds)
        ElseIf remainingTime.Hours > 0 Then
            formattedRemainingTime = String.Format("{0} hrs {1:D2} mins {2:D2} secs",
                                           remainingTime.Hours, remainingTime.Minutes, remainingTime.Seconds)
        Else
            formattedRemainingTime = String.Format("{0} mins {1:D2} secs",
                                           remainingTime.Minutes, remainingTime.Seconds)
        End If


        lbltimeremaining.Text = formattedRemainingTime
    End Sub



    Private Sub UpdateDateTimeLabel()
        lbldatetime.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")
    End Sub



    Private currentform As Form = Nothing

    Private Sub openchildform(childForm As Form)
        If currentform IsNot Nothing Then currentform.Close()
        currentform = childForm

        If TypeOf childForm Is SettingsPanel Then
            Dim settingsPanelForm As SettingsPanel = DirectCast(childForm, SettingsPanel)
            settingsPanelForm.LoggedInUsername = lblname.Text

        End If
        childForm.TopLevel = False
        childForm.FormBorderStyle = FormBorderStyle.None
        childForm.Dock = DockStyle.Fill
        mainform.Controls.Add(childForm)
        mainform.Tag = childForm
        childForm.BringToFront()

        childForm.Show()
    End Sub
    Private voterealCountForm As VoterealCount
    Private finalizedResultForm As FinalizedResult
    Private Sub GoBackToClientDashboard()
        If currentform IsNot Nothing Then
            currentform.Close()
            currentform = Nothing
        End If

        If voterealCountForm IsNot Nothing Then
            voterealCountForm.Close()
            voterealCountForm = Nothing
        End If

        If finalizedResultForm IsNot Nothing Then
            finalizedResultForm.Close()
            finalizedResultForm = Nothing
        End If

        If Adminlogin IsNot Nothing AndAlso Not Adminlogin.IsDisposed Then
            Adminlogin.Hide()
        End If

        If Me IsNot Nothing AndAlso Not Me.IsDisposed Then
            Me.Show()
        End If
    End Sub
    Private Sub ButtonHome_Click(sender As Object, e As EventArgs) Handles ButtonHome.Click
        GoBackToClientDashboard()
    End Sub

    ''Admindashboard form
    Private WithEvents currentVotersPanel As VotersPanel

    Private Sub buttonvoters_Click(sender As Object, e As EventArgs) Handles buttonvoters.Click
        GoBackToClientDashboard()
        currentVotersPanel = New VotersPanel()
        openchildform(currentVotersPanel)

        If currentVotersPanel IsNot Nothing Then
            currentVotersPanel.SetCloseButtonVisibility(False) ' Hide the close button
        End If
    End Sub


    ''Admindashboard form
    Private WithEvents currentCandidatepanel As CandidatesPanel
    Private Sub ButtonCandidate_Click(sender As Object, e As EventArgs) Handles ButtonCandidate.Click
        GoBackToClientDashboard()
        currentCandidatepanel = New CandidatesPanel()
        openchildform(currentCandidatepanel)
        If currentVotersPanel IsNot Nothing Then
            currentCandidatepanel.setclosecandidatesbtton(False) ' Hide the close button
        End If
    End Sub


    Private WithEvents currentpartypanel As PartyPanel
    Private Sub ButtonParty_Click(sender As Object, e As EventArgs) Handles ButtonParty.Click
        GoBackToClientDashboard()
        currentpartypanel = New PartyPanel()
        openchildform(currentpartypanel)
        If currentVotersPanel IsNot Nothing Then
            currentpartypanel.setpartybtnclose(False) ' Hide the close button
        End If
    End Sub


    Private Sub Buttonsettings_Click(sender As Object, e As EventArgs) Handles Buttonsettings.Click
        GoBackToClientDashboard()
        openchildform(New SettingsPanel())
    End Sub

    Private Sub btnlogout_Click(sender As Object, e As EventArgs) Handles btnlogout.Click
        If MsgBox("Logout Account?", vbQuestion + vbYesNo) = vbYes Then
            MsgBox("Goodbye" & lblname.Text & " " & " Have a nice day!!", vbInformation, "Logout User")

            Dim notStartedForm As New AdmindashboardNotyetstarted()

            notStartedForm.TopLevel = False
            notStartedForm.FormBorderStyle = FormBorderStyle.None
            notStartedForm.Dock = DockStyle.Fill
            mainform.Controls.Add(notStartedForm)
            notStartedForm.BringToFront()
            notStartedForm.Show()

            Me.Close()
            Adminlogin.Show()
        End If
    End Sub



    Private Sub ButtonStartElection_Click(sender As Object, e As EventArgs)

        If electionactive() = "Started" Then

            MessageBox.Show("Finish the current election first.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
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
        End If
    End Sub

    Private Function HasResultData() As Boolean
        Try
            Using connection As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\loa_voting.accdb;Jet OLEDB:Database Password=1669-21loa")
                connection.Open()

                Dim query As String = "SELECT COUNT(*) FROM tblResult"

                Using command As New OleDbCommand(query, connection)
                    Dim resultCount As Integer = CInt(command.ExecuteScalar())

                    Return resultCount > 0
                End Using
            End Using
        Catch ex As Exception
            MsgBox("Error checking result data: " & ex.Message, vbCritical)
            Return False
        End Try
    End Function


    Public Sub CheckElectionStatus()
        Try
            ChipElectionStatus.Text = "Ended"

            Using connection As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\loa_voting.accdb;Jet OLEDB:Database Password=1669-21loa")
                connection.Open()

                Dim query As String = "SELECT TOP 1 * FROM tblElection ORDER BY CDate(Started) DESC"

                Using command As New OleDbCommand(query, connection)
                    Dim reader As OleDbDataReader = command.ExecuteReader()

                    If reader.Read() Then
                        Dim status As String = Convert.ToString(reader("Status"))
                        If String.Equals(status, "Active", StringComparison.OrdinalIgnoreCase) Then
                            Dim endedDateTime As DateTime = Convert.ToDateTime(reader("Ended"))

                            lblelectionend.Visible = True
                            lbltimeremaining.Visible = True
                            Dim remainingTime As TimeSpan = endedDateTime - DateTime.Now
                            UpdateRemainingTimeLabel(remainingTime)

                            endDate = endedDateTime
                            countdownTimer.Start()

                            ShowVoterealCountForm()

                            ChipElectionStatus.Text = "Started"

                            btnnewelection.Visible = False

                            Return
                        End If



                        If HasResultData() Then
                            ShowAdmindashboardEndedForm()
                            btnnewelection.Visible = True
                            Me.Refresh()
                            lblelectionend.Visible = False
                            lbltimeremaining.Visible = False
                            Return
                        Else
                            Dim isDoneStatus As String = Convert.ToString(reader("Isdone"))

                            If String.Equals(isDoneStatus, "Not finalize", StringComparison.OrdinalIgnoreCase) Then
                                ShowFinalizedResultForm()
                                lblelectionend.Visible = False
                                lbltimeremaining.Visible = False
                                btnnewelection.Visible = False
                                Return
                            End If

                            ChipElectionStatus.Text = If(String.Equals(status, "Active", StringComparison.OrdinalIgnoreCase), "Started", status)

                            If String.Equals(status, "Active", StringComparison.OrdinalIgnoreCase) Then
                                Dim endedDateTime As DateTime = Convert.ToDateTime(reader("Ended"))

                                lblelectionend.Visible = True
                                lbltimeremaining.Visible = True

                                Dim remainingTime As TimeSpan = endedDateTime - DateTime.Now
                                UpdateRemainingTimeLabel(remainingTime)

                                endDate = endedDateTime
                                countdownTimer.Start()

                                ShowVoterealCountForm()
                            ElseIf String.Equals(status, "Ended", StringComparison.OrdinalIgnoreCase) Then
                                ShowFinalizedResultForm()

                                lblelectionend.Visible = False
                                lbltimeremaining.Visible = False
                            Else
                                lblelectionend.Visible = False
                                lbltimeremaining.Visible = False
                                ChipElectionStatus.Text = "Not Started"
                                ShowAdmindashboardNotYetStartedForm()
                            End If
                        End If
                    Else
                        ChipElectionStatus.Text = "Ended"
                        lblelectionend.Visible = False
                        lbltimeremaining.Visible = False
                        lblelectionnew.Visible = False
                        ShowAdmindashboardNotYetStartedForm()

                    End If
                End Using
            End Using
        Catch ex As Exception
            MsgBox("Error checking election status: " & ex.Message, vbCritical)
        End Try
    End Sub





    Private Sub ShowFinalizedResultForm()
        Try
            Dim finalizedResultForm As FinalizedResult = Application.OpenForms.OfType(Of FinalizedResult)().FirstOrDefault()

            If finalizedResultForm Is Nothing OrElse finalizedResultForm.IsDisposed Then
                finalizedResultForm = New FinalizedResult()

                finalizedResultForm.AdminDashboard = Me

                finalizedResultForm.TopLevel = False
                finalizedResultForm.FormBorderStyle = FormBorderStyle.None
                finalizedResultForm.Dock = DockStyle.Fill

                mainform.Controls.Add(finalizedResultForm)
                finalizedResultForm.BringToFront()
                finalizedResultForm.Show()
            Else
                finalizedResultForm.BringToFront()
            End If
        Catch ex As Exception
            MsgBox("Error showing finalized result form: " & ex.Message, vbCritical)
        End Try
    End Sub

    Private Sub ShowAdmindashboardEndedForm()
        Dim endedForm As AdmindashboardEnded = Application.OpenForms.OfType(Of AdmindashboardEnded)().FirstOrDefault()

        If endedForm Is Nothing Then
            endedForm = New AdmindashboardEnded()

            endedForm.TopLevel = False
            endedForm.FormBorderStyle = FormBorderStyle.None
            endedForm.Dock = DockStyle.Fill

            lblelectionend.Visible = False
            lbltimeremaining.Visible = False

            mainform.Controls.Add(endedForm)
            endedForm.BringToFront()
            endedForm.Show()
        Else
            btnnewelection.Visible = True
            endedForm.BringToFront()
        End If
    End Sub

    Private Sub ShowAdmindashboardNotYetStartedForm()
        Dim notStartedForm As AdmindashboardNotyetstarted = Application.OpenForms.OfType(Of AdmindashboardNotyetstarted)().FirstOrDefault()

        If notStartedForm Is Nothing Then
            notStartedForm = New AdmindashboardNotyetstarted()

            notStartedForm.TopLevel = False
            notStartedForm.FormBorderStyle = FormBorderStyle.None
            notStartedForm.Dock = DockStyle.Fill

            btnnewelection.Visible = False

            mainform.Controls.Add(notStartedForm)
            notStartedForm.BringToFront()
            notStartedForm.Show()
        Else
            notStartedForm.BringToFront()
        End If
    End Sub


    Private Sub ShowVoterealCountForm()

        Dim notStartedForm As VoterealCount = Application.OpenForms.OfType(Of VoterealCount)().FirstOrDefault()

        If notStartedForm Is Nothing Then
            notStartedForm = New VoterealCount()

            notStartedForm.TopLevel = False
            notStartedForm.FormBorderStyle = FormBorderStyle.None
            notStartedForm.Dock = DockStyle.Fill

            btnnewelection.Visible = False

            mainform.Controls.Add(notStartedForm)
            notStartedForm.BringToFront()
            notStartedForm.Show()
        Else
            notStartedForm.BringToFront()
        End If
    End Sub



    Private endDate As DateTime
    Private WithEvents countdownTimer As New Timer()
    Private Sub countdownTimer_Tick(sender As Object, e As EventArgs) Handles countdownTimer.Tick
        Dim remainingTime As TimeSpan = endDate - DateTime.Now
        UpdateRemainingTimeLabel(remainingTime)

        If remainingTime.TotalSeconds <= 0 Then
            countdownTimer.Stop()

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

            ChipElectionStatus.Text = "Ended"
            lblelectionend.Visible = False
            lblelectionnew.Visible = False

            lbltimeremaining.Text = "Election Ended"
            lbltimeremaining.Visible = False

            ShowFinalizedResultForm()

            If voterealCountForm IsNot Nothing AndAlso Not voterealCountForm.IsDisposed Then
                voterealCountForm.Close()
            End If

            GoBackToClientDashboard()
        End If
    End Sub





    Private Sub ChipElectionStatus_Click(sender As Object, e As EventArgs) Handles ChipElectionStatus.Click
        Dim electionStatus As String = electionactive()

        If electionStatus = "Started" Then
            ChipElectionStatus.Text = "Started"
        ElseIf electionStatus = "Not Started" Then
            ChipElectionStatus.Text = "Not Started"

        Else
            ChipElectionStatus.Text = "Error"
        End If
    End Sub




    Private Function electionactive() As String
        Try
            Using connection As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\loa_voting.accdb;Jet OLEDB:Database Password=1669-21loa")
                connection.Open()

                Dim query As String = "SELECT TOP 1 Status FROM tblElection ORDER BY CDate(Started) DESC"

                Using command As New OleDbCommand(query, connection)
                    Dim status As Object = command.ExecuteScalar()

                    If status IsNot Nothing AndAlso Not DBNull.Value.Equals(status) Then
                        Dim statusString As String = status.ToString()

                        If String.Equals(statusString, "Active", StringComparison.OrdinalIgnoreCase) Then
                            Return "Started"
                        ElseIf String.Equals(statusString, "Inactive", StringComparison.OrdinalIgnoreCase) Then
                            ChipElectionStatus.Text = "Not Started"

                            Return "Not Started"
                        Else
                            Return "Error"
                        End If
                    Else
                        Return "Not Started"

                    End If
                End Using
            End Using
        Catch ex As Exception
            MsgBox("Error checking election status: " & ex.Message, vbCritical)
            Return "Error"
        End Try
    End Function


    Public ReadOnly Property LoggedInUsername As String
        Get
            Return lblname.Text
        End Get
    End Property

    Private Sub btnnewelection_Click(sender As Object, e As EventArgs) Handles btnnewelection.Click


        Dim formodal As New Form
        Try
            Dim modal As New ElectionStart
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
            ElectionStart.ShowDialog()

        Catch ex As Exception
        Finally
            formodal.Dispose()
        End Try
    End Sub
    Public Sub RefreshForm()
        ShowAdmindashboardNotYetStartedForm()


    End Sub



    Private Sub picrefresh_Click(sender As Object, e As EventArgs)
        btnnewelection.Visible = True
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class
