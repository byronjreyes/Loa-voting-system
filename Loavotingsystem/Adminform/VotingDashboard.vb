Imports System.Data.OleDb
Imports System.Management.Instrumentation

Public Class VotingDashboard


    Inherits Form

    Public Sub New()
        Me.DoubleBuffered = True
        InitializeComponent()
    End Sub


    Private Sub VotingDashboard_Load(sender As Object, e As EventArgs)
        FlowPanel()
        IsActivePartyList()

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
    Private Sub gobacktovotingpanel()
        If currentform IsNot Nothing Then
            currentform.Hide()
            currentform = Nothing
        End If
        If Adminlogin.Visible Then
            Adminlogin.Hide()
        End If
        Me.Show()
    End Sub



    Private Sub btncandidateinfo_Click(sender As Object, e As EventArgs) Handles btncandidateinfo.Click
        gobacktovotingpanel()
        mainform.BringToFront()

    End Sub


    Private Sub buttonvoters_Click(sender As Object, e As EventArgs) Handles btnpartyinfo.Click

        gobacktovotingpanel()
        openchildform(New Partyvoteinfo())
    End Sub

    Private Sub FlowPanel()
        Try
            Connection()
            sql = "SELECT * FROM qryCandidatedetails WHERE PartyStatus IN ('Active', 'Inactive') AND Status IN ('Independent', 'Haveparty')"
            If ButtonPresident.Checked Then
                sql += " AND Position = 'PRESIDENT'"
            ElseIf ButtonEVPresident.Checked Then
                sql += " AND Position = 'EXECUTIVE VICE PRESIDENT'"
            ElseIf ButtonVFinance.Checked Then
                sql += " AND Position = 'VP FINANCE'"
            ElseIf ButtonVActivities.Checked Then
                sql += " AND Position = 'VP ACTIVITIES'"
            ElseIf ButtonVComMarketing.Checked Then
                sql += " AND Position = 'VP COMMUNICATION AND MARKETING'"
            ElseIf ButtonVDocumentation.Checked Then
                sql += " AND Position = 'VP DOCUMENTATION'"
            End If

            cmd = New OleDbCommand(sql, cn)
            dr = cmd.ExecuteReader
            flpMain.Controls.Clear()

            While dr.Read
                Dim Items As New FlowPanelItems

                Items.lblfullname1.Text = dr("Firstname").ToString() & " " & dr("Lastname").ToString()
                Items.lblposition1.Text = dr("Position").ToString
                Items.lblstudentid1.Text = dr("Studid").ToString
                Items.lblrepresentative1.Text = dr("Representative").ToString
                Items.lblcourse1.Text = dr("Course").ToString
                Items.lblyear1.Text = dr("Yearlvl").ToString
                Items.lbltagline1.Text = dr("Tagline").ToString

                If Not IsDBNull(dr("img")) Then
                    Dim imageData As Byte() = DirectCast(dr("img"), Byte())
                    Dim ms As New IO.MemoryStream(imageData)
                    Items.PictureBox1.Image = Image.FromStream(ms)
                End If
                Items.ButtonsEnabled = False
                flpMain.Controls.Add(Items)
                Dim centerX As Integer = (flpMain.Width - Items.Width) \ 2
                Dim centerY As Integer = (flpMain.Height - Items.Height) \ 2
                Items.Location = New Point(centerX, centerY)
            End While

        Catch ex As Exception
        Finally
            cn.Close()
        End Try
    End Sub




    Private Sub FilterButton_Click(sender As Object, e As EventArgs) Handles ButtonPresident.Click,
                                                                                ButtonEVPresident.Click,
                                                                                ButtonVFinance.Click,
                                                                                ButtonVActivities.Click,
                                                                                ButtonVComMarketing.Click,
                                                                                ButtonVDocumentation.Click
        If TypeOf sender Is Guna.UI2.WinForms.Guna2Button Then
            Dim selectedButton As Guna.UI2.WinForms.Guna2Button = DirectCast(sender, Guna.UI2.WinForms.Guna2Button)

            If selectedButton.Checked Then
                FlowPanel()
            End If
        End If
    End Sub

    Private Function IsActivePartyList() As Boolean
        Dim isActiveSql As String = "SELECT COUNT(*) FROM qryCandidatedetails WHERE PartyStatus = 'Active'"

        Using cn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\loa_voting.accdb;Jet OLEDB:Database Password=1669-21loa")
            Using cmd As New OleDbCommand(isActiveSql, cn)
                Try
                    cn.Open()
                    Dim count As Integer = CInt(cmd.ExecuteScalar())
                    Return count > 0
                Catch ex As Exception
                    MsgBox("Error checking active party list: " & ex.Message, vbCritical)
                    Return False
                End Try
            End Using
        End Using
    End Function

    Private Sub buttonvotenow_Click(sender As Object, e As EventArgs) Handles buttonvotenow.Click

        Dim voteNowForm As New Votenow()
        voteNowForm.LoggedInUsername = lblname.Text
        gobacktovotingpanel()
        openchildform(voteNowForm)
    End Sub


    Private Sub Buttonsettings_Click(sender As Object, e As EventArgs) Handles Buttonsettings.Click
        gobacktovotingpanel()
        openchildform(New VoterealCount())
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        FlowPanel()
    End Sub


    Public Sub ShowVoteInformationForm(ByVal presidentLabel As String, ByVal vicePresidentLabel As String,
                                   ByVal financeLabel As String, ByVal activitiesLabel As String,
                                   ByVal comnMarketLabel As String, ByVal docuLabel As String)
        buttonvotenow.Visible = False
        Dim voteInfoForm As New VoteInformation()

        ' Set the labels in VoteInformation form
        voteInfoForm.PresidentLabel = presidentLabel
        voteInfoForm.VicePresidentLabel = vicePresidentLabel
        voteInfoForm.FinanceLabel = financeLabel
        voteInfoForm.ActivitiesLabel = activitiesLabel
        voteInfoForm.ComnMarketLabel = comnMarketLabel
        voteInfoForm.DocuLabel = docuLabel

        AddHandler voteInfoForm.FormClosed, AddressOf VoteInformationFormClosed
        voteInfoForm.TopLevel = False
        voteInfoForm.FormBorderStyle = FormBorderStyle.None
        voteInfoForm.Dock = DockStyle.Fill
        mainform.Controls.Add(voteInfoForm)
        voteInfoForm.BringToFront()
        voteInfoForm.Show()
    End Sub

    Private Sub VoteInformationFormClosed(sender As Object, e As FormClosedEventArgs)
        buttonvotenow.Visible = True
    End Sub

    Private Sub btnlogout_Click(sender As Object, e As EventArgs) Handles btnlogout.Click
        If MsgBox("Are you sure you want to logout now?", vbQuestion + vbYesNo) = vbYes Then
            MsgBox("Thank you for voting " & lblfullname.Text & " " & " Have a nice day!!", vbInformation, "Logut User")
            Me.Close()
            VotingLoginpanel.Show()
        End If
    End Sub

    Private Sub mainform_Paint(sender As Object, e As PaintEventArgs) Handles mainform.Paint

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class