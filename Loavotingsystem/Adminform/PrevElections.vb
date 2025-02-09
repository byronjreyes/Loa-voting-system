Imports System.Data.OleDb
Imports System.Windows.Forms
Imports System.Windows.Forms.DataVisualization.Charting
Imports Guna.UI.WinForms
Imports Guna.UI2.WinForms

Public Class PrevElections

    Private connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\loa_voting.accdb;Jet OLEDB:Database Password=1669-21loa"

    Private Sub PrevElections_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ClearElectionButtons()
        LoadElectionTitles()
        flpMain.Visible = False
        ButtonShowElection.Visible = False
    End Sub

    Private Sub ClearElectionButtons()
        For Each control As Control In FlowLayoutPanel1.Controls
            If TypeOf control Is Guna2Button Then
                FlowLayoutPanel1.Controls.Remove(control)
            End If
        Next
    End Sub

    Private Sub LoadElectionTitles()
        Try
            Using connection As New OleDbConnection(connectionString)
                connection.Open()

                Dim query As String = "SELECT Title FROM tblPrevElections WHERE Status = 'Ended' GROUP BY Title"

                Using command As New OleDbCommand(query, connection)
                    Using reader As OleDbDataReader = command.ExecuteReader()
                        While reader.Read()
                            Dim title As String = reader("Title").ToString()
                            CreateElectionButton(title)
                        End While
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading election titles: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub




    Private Sub CreateElectionButton(title As String)

        Dim btn As New Guna2Button()


        btn.Text = title
        btn.AutoSize = True
        btn.Height = 68
        btn.Width = 979
        btn.FillColor = Color.White
        btn.ForeColor = Color.Black
        btn.BorderRadius = 21
        btn.Font = New Font("Century gothic", 14, FontStyle.Regular)
        btn.Margin = New Padding(5)


        GunaButtonElection = btn


        AddHandler GunaButtonElection.Click, Sub(sender, e) GunaButtonElection_Click(sender, e, title)

        FlowLayoutPanel1.Controls.Add(btn)
    End Sub


    Private WithEvents GunaButtonElection As Guna.UI2.WinForms.Guna2Button

    Private Sub GunaButtonElection_Click(sender As Object, e As EventArgs, title As String)
        LoadDataAndDisplayCandidateChart(title)
        LoadFinalizedResults(title)
        LoadDataAndDisplayPartylistChart(title) ' Add this line to include the party list chart
        flpMain.Visible = True
        flpMain.Dock = DockStyle.Fill ' Set flpMain to dock fill
        FlowLayoutPanel1.Visible = False ' Hide FlowLayoutPanel1
        GunaButtonElection.Visible = False
        ButtonShowElection.Visible = True
        btnclose.Visible = False
    End Sub

    Private Sub ButtonShowElection_Click(sender As Object, e As EventArgs) Handles ButtonShowElection.Click
        flpMain.Visible = False
        flpMain.Dock = DockStyle.None ' Set flpMain to undock
        FlowLayoutPanel1.Visible = True ' Unhide FlowLayoutPanel1
        GunaButtonElection.Visible = True
        ButtonShowElection.Visible = False
        btnclose.Visible = True
    End Sub




    Private Sub LoadFinalizedResults(selectedTitle As String)
        Try
            Using connection As New OleDbConnection(connectionString)
                connection.Open()

                Dim query As String = "SELECT * FROM tblPrevElections WHERE Title = @Title AND Whowin = 'Won'"

                Using command As New OleDbCommand(query, connection)
                    command.Parameters.AddWithValue("@Title", selectedTitle)

                    Using reader As OleDbDataReader = command.ExecuteReader()
                        flowLayoutPanelResults.Controls.Clear()

                        While reader.Read()
                            Dim resultControl As New ResultPrevElections()

                            resultControl.LabelPresident.Text = reader("Firstname").ToString() & " " & reader("Lastname").ToString()
                            resultControl.LabelVicePresident.Text = reader("PartyName").ToString() ' Assuming you want to display PartyName here
                            resultControl.LabelFinance.Text = " " & reader("Votes").ToString()
                            resultControl.LabelActivities.Text = reader("Position").ToString()
                            resultControl.lblpartytitle.Text = reader("Title").ToString() ' Set the label for Party Title

                            ' Add the UserControl to the FlowLayoutPanel
                            flowLayoutPanelResults.Controls.Add(resultControl)
                        End While
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading finalized results: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub




    Private Sub LoadDataAndDisplayCandidateChart(selectedTitle As String, Optional position As String = Nothing)
        Try
            Using connection As New OleDbConnection(connectionString)
                connection.Open()

                Dim query As String
                If String.IsNullOrEmpty(position) Then
                    query = "SELECT Firstname & ' ' & Lastname AS CandidateName, Votes FROM tblPrevElections WHERE Title = @Title"
                Else
                    query = "SELECT Firstname & ' ' & Lastname AS CandidateName, Votes FROM tblPrevElections WHERE Title = @Title AND Position = @Position"
                End If

                Using command As New OleDbCommand(query, connection)
                    command.Parameters.AddWithValue("@Title", selectedTitle)

                    If Not String.IsNullOrEmpty(position) Then
                        command.Parameters.AddWithValue("@Position", position)
                    End If

                    Using reader As OleDbDataReader = command.ExecuteReader()

                        Chart1.Series.Clear()
                        Chart1.ChartAreas.Clear()
                        Chart1.Legends.Clear()

                        Dim chartArea As New ChartArea()
                        Chart1.ChartAreas.Add(chartArea)

                        Dim legendName As String = "CandidateLegend"
                        If Not Chart1.Legends.Any(Function(l) l.Name = legendName) Then
                            Dim legend As New Legend()
                            Chart1.Legends.Add(legend)
                            legend.Name = legendName
                            legend.Docking = Docking.Right
                            legend.Alignment = StringAlignment.Center
                        End If

                        Dim series As New Series("VoteCountBar")
                        series.ChartType = SeriesChartType.StackedColumn
                        series.IsValueShownAsLabel = True

                        While reader.Read()
                            Dim candidateName As String = reader("CandidateName").ToString()
                            Dim voteCount As Integer = Convert.ToInt32(reader("Votes"))
                            Dim dataPoint As New DataPoint()
                            dataPoint.AxisLabel = candidateName
                            dataPoint.YValues = New Double() {voteCount}

                            series.Points.Add(dataPoint)
                        End While

                        Chart1.Series.Add(series)

                        Chart1.ChartAreas(0).AxisX.Minimum = 0
                        Chart1.ChartAreas(0).AxisX.Interval = 1
                        Chart1.ChartAreas(0).AxisX.IsLabelAutoFit = False
                        Chart1.ChartAreas(0).AxisX.CustomLabels.Clear()

                        Chart1.ChartAreas(0).AxisY.LabelStyle.Angle = -90
                        Chart1.ChartAreas(0).AxisY.IsReversed = True

                        Chart1.ChartAreas(0).AxisX.LabelStyle.Font = New System.Drawing.Font("Poppins", 10, Drawing.FontStyle.Regular)
                        Chart1.ChartAreas(0).AxisX.LabelStyle.ForeColor = Drawing.Color.White
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading candidate data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub LoadDataAndDisplayPartylistChart(selectedTitle As String)
        Try
            Using connection As New OleDbConnection(connectionString)
                connection.Open()
                Dim queryPartylist As String = "SELECT Title, PartyName, SUM(Votes) AS TotalVotes " &
                                           "FROM tblPrevElections " &
                                           "WHERE Whowin = 'Won' AND Title = @Title " &
                                           "GROUP BY Title, PartyName"

                Using commandPartylist As New OleDbCommand(queryPartylist, connection)
                    commandPartylist.Parameters.AddWithValue("@Title", selectedTitle)

                    Using readerPartylist As OleDbDataReader = commandPartylist.ExecuteReader()

                        ' Clear existing series, chart areas, and legends in the party list chart
                        Chart2.Series.Clear()
                        Chart2.ChartAreas.Clear()
                        Chart2.Legends.Clear()

                        ' Create a new chart area for the party list chart
                        Dim chartAreaPartylist As New ChartArea()
                        Chart2.ChartAreas.Add(chartAreaPartylist)

                        While readerPartylist.Read()
                            Dim partyTitle As String = readerPartylist("PartyName").ToString()
                            Dim totalVotes As Integer = Convert.ToInt32(readerPartylist("TotalVotes"))

                            ' Create a new series for each party
                            Dim seriesPartylist As New Series("PartylistVoteCountBar_" & partyTitle)
                            seriesPartylist.ChartType = SeriesChartType.Column
                            seriesPartylist.IsValueShownAsLabel = True
                            seriesPartylist.LegendText = partyTitle

                            ' Clear existing points for the series
                            seriesPartylist.Points.Clear()

                            ' Add a data point for each party's total votes
                            Dim dataPointPartylist As New DataPoint()
                            dataPointPartylist.AxisLabel = partyTitle
                            dataPointPartylist.YValues = New Double() {totalVotes}

                            ' Customize label format
                            dataPointPartylist.Label = totalVotes.ToString("#,##0")
                            dataPointPartylist.LabelForeColor = Drawing.Color.Black
                            dataPointPartylist.LabelBackColor = Drawing.Color.Transparent
                            dataPointPartylist.LabelAngle = -90

                            seriesPartylist.Points.Add(dataPointPartylist)

                            ' Add the series to the chart
                            Chart2.Series.Add(seriesPartylist)

                            ' Customize other chart settings if needed
                        End While

                        ' Customize chart area font, size, and color
                        Chart2.ChartAreas(0).AxisX.LabelStyle.Font = New System.Drawing.Font("Poppins", 10, Drawing.FontStyle.Regular)
                        Chart2.ChartAreas(0).AxisX.LabelStyle.ForeColor = Drawing.Color.White
                        Chart2.ChartAreas(0).AxisY.LabelStyle.ForeColor = Drawing.Color.White
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading Partylist data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub ButtonPresident_Click(sender As Object, e As EventArgs) Handles ButtonPresident.Click
        LoadDataAndDisplayCandidateChart(GunaButtonElection.Text, "PRESIDENT")
        LoadDataAndDisplayPartylistChart(GunaButtonElection.Text) ' Add this line
    End Sub

    Private Sub ButtonEVPresident_Click(sender As Object, e As EventArgs) Handles ButtonEVPresident.Click
        LoadDataAndDisplayCandidateChart(GunaButtonElection.Text, "EXECUTIVE VICE PRESIDENT")
        LoadDataAndDisplayPartylistChart(GunaButtonElection.Text) ' Add this line
    End Sub

    Private Sub ButtonVFinance_Click(sender As Object, e As EventArgs) Handles ButtonVFinance.Click
        LoadDataAndDisplayCandidateChart(GunaButtonElection.Text, "VP FINANCE")
    End Sub

    Private Sub ButtonVActivities_Click(sender As Object, e As EventArgs) Handles ButtonVActivities.Click
        LoadDataAndDisplayCandidateChart(GunaButtonElection.Text, "VP ACTIVITIES")
    End Sub

    Private Sub ButtonVComMarketing_Click(sender As Object, e As EventArgs) Handles ButtonVComMarketing.Click
        LoadDataAndDisplayCandidateChart(GunaButtonElection.Text, "VP COMMUNICATION AND MARKETING")
    End Sub

    Private Sub ButtonVDocumentation_Click(sender As Object, e As EventArgs) Handles ButtonVDocumentation.Click
        LoadDataAndDisplayCandidateChart(GunaButtonElection.Text, "VP DOCUMENTATION")
    End Sub

    Private Sub buttonall_Click(sender As Object, e As EventArgs) Handles buttonall.Click
        LoadDataAndDisplayCandidateChart(GunaButtonElection.Text)
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles btnclose.Click
        Me.Close()
    End Sub
End Class
