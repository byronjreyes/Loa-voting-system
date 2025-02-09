Imports System.Data.OleDb

Public Class CandidatesPanel

    Inherits Form

    Public Sub New()
        Me.DoubleBuffered = True
        InitializeComponent()
    End Sub

    Public Sub setclosecandidatesbtton(visible As Boolean)
        btnclose.Visible = visible
    End Sub
    Private Sub CandidatesPanel_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Connection()

        If IsActivePartyList() Then
            Panelhider.SendToBack()
            candihider.BringToFront()


        Else
            Panelhider.BringToFront()
            candihider.SendToBack()
        End If
    End Sub

    Private Sub FlowPanel()
        Try
            Connection()
            sql = "Select * From qryCandidatedetails "

            If ButtonPresident.Checked Then
                sql += "WHERE Position = 'PRESIDENT'"
            ElseIf ButtonEVPresident.Checked Then
                sql += "WHERE Position = 'EXECUTIVE VICE PRESIDENT'"
            ElseIf ButtonVFinance.Checked Then
                sql += "WHERE Position = 'VP FINANCE'"
            ElseIf ButtonVActivities.Checked Then
                sql += "WHERE Position = 'VP ACTIVITIES'"
            ElseIf ButtonVComMarketing.Checked Then
                sql += "WHERE Position = 'VP COMMUNICATION AND MARKETING'"
            ElseIf ButtonVDocumentation.Checked Then
                sql += "WHERE Position = 'VP DOCUMENTATION'"
            End If

            ' Continue with the rest of your code
            cmd = New OleDbCommand(sql, cn)
            dr = cmd.ExecuteReader
            flpMain.Controls.Clear()

            While dr.Read
                Dim Items As New FlowPanelItems
                ' Update the code to access individual columns properly
                Items.lblfullname1.Text = dr("Firstname").ToString() & " " & dr("Lastname").ToString()
                Items.lblposition1.Text = dr("Position").ToString
                Items.lblstudentid1.Text = dr("Studid").ToString
                Items.lblrepresentative1.Text = dr("Representative").ToString
                Items.lblcourse1.Text = dr("Course").ToString
                Items.lblyear1.Text = dr("Yearlvl").ToString
                Items.lbltagline1.Text = dr("Tagline").ToString

                ' Check if the 'img' column is not DBNull
                If Not IsDBNull(dr("img")) Then
                    ' Convert the byte array to Image
                    Dim imageData As Byte() = DirectCast(dr("img"), Byte())
                    Dim ms As New IO.MemoryStream(imageData)
                    Items.PictureBox1.Image = Image.FromStream(ms)
                End If

                flpMain.Controls.Add(Items)

                ' Center the FlowPanelItems control within the FlowLayoutPanel
                Dim centerX As Integer = (flpMain.Width - Items.Width) \ 2
                Dim centerY As Integer = (flpMain.Height - Items.Height) \ 2
                Items.Location = New Point(centerX, centerY)
            End While

        Catch ex As Exception
            ' Handle exceptions
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
                ' Call the FlowPanel method when any of the buttons is checked
                FlowPanel()

            End If
        End If
    End Sub

    Private Sub btnAddCandidates_Click(sender As Object, e As EventArgs) Handles btnAddCandidates.Click
        Dim formodal As New Form
        Try
            Dim modal As New AddVoters
            formodal.StartPosition = FormStartPosition.CenterScreen
            formodal.FormBorderStyle = FormBorderStyle.None
            formodal.Opacity = 0.5D
            formodal.BackColor = Color.Black
            formodal.WindowState = FormWindowState.Maximized
            formodal.TopMost = True
            formodal.Location = Location
            formodal.ShowInTaskbar = False

            modal.LabelInfo.Text = "*Take note: A candidate must be registered in the voters' list.*"

            formodal.Show()
            modal.Owner = formodal
            modal.ShowDialog()

        Catch ex As Exception
        Finally
            formodal.Dispose()
        End Try
    End Sub

    Private Function IsActivePartyList() As Boolean
        Dim isActiveSql As String = "SELECT COUNT(*) FROM qryCandidatedetails WHERE VAL(Voteresiv) >= 0 AND VAL(Voteresiv) <= 100"




        Using cn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\loa_voting.accdb;Jet OLEDB:Database Password=1669-21loa")
            Using cmd As New OleDbCommand(isActiveSql, cn)
                Try
                    cn.Open()
                    Dim count As Integer = CInt(cmd.ExecuteScalar())

                    ' Check if there are active candidates
                    If count > 0 Then
                        ' If there are active candidates, send Panelhider to the back
                        Panelhider.SendToBack()
                        Return True
                    Else
                        ' If no active candidates, bring Panelhider to the front
                        Panelhider.BringToFront()
                        Return False
                    End If
                Catch ex As Exception
                    MsgBox("Error checking active party list: " & ex.Message, vbCritical)
                    Return False
                End Try
            End Using
        End Using
    End Function





    Private Sub Panelhider_Paint(sender As Object, e As PaintEventArgs) Handles Panelhider.Paint

    End Sub

    Private Sub btnclose_Click(sender As Object, e As EventArgs) Handles btnclose.Click
        Me.Close()
    End Sub
End Class
