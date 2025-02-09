Imports System.Data.OleDb
Imports System.Windows.Forms.DataVisualization.Charting

Public Class VoterealCount
    Private connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\loa_voting.accdb;Jet OLEDB:Database Password=1669-21loa"



    Private Sub VoterealCount_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDataAndDisplayCandidateChart()
        LoadDataAndDisplayPartylistChart()
        Dim votingCounts = GetVotingCounts()
        TotalVotersCount.Text = $" {votingCounts.TotalVoters}"
        AlreadyVotedCount.Text = $" {votingCounts.AlreadyVotedCount}"
        RemainingVotersCount.Text = $" {votingCounts.RemainingVotersCount}"
        lblTime.Text = $"Result as of {DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss tt")}"


    End Sub


    Private Sub LoadDataAndDisplayCandidateChart(Optional position As String = Nothing)
        Try
            Using connection As New OleDbConnection(connectionString)
                connection.Open()

                ' Select candidate names and their vote counts based on the selected position if provided
                Dim query As String
                If String.IsNullOrEmpty(position) Then
                    query = "SELECT FirstName & ' ' & LastName AS CandidateName, Voteresiv, PartyStatus FROM tblCandidate"
                Else
                    query = "SELECT FirstName & ' ' & LastName AS CandidateName, Voteresiv, PartyStatus FROM tblCandidate WHERE Position = @Position"
                End If

                Using command As New OleDbCommand(query, connection)
                    ' Add a parameter for the position if provided
                    If Not String.IsNullOrEmpty(position) Then
                        command.Parameters.AddWithValue("@Position", position)
                    End If

                    Using reader As OleDbDataReader = command.ExecuteReader()
                        ' Clear existing series and chart areas in the chart
                        Chart1.Series.Clear()
                        Chart1.ChartAreas.Clear()
                        Chart1.Legends.Clear() ' Clear existing legends

                        ' Create a new chart area with dark mode colors
                        Dim chartArea As New ChartArea()
                        chartArea.BackColor = Drawing.Color.FromArgb(30, 30, 30)  ' Set dark background color
                        chartArea.AxisX.LineColor = Drawing.Color.Gray
                        chartArea.AxisX.MajorGrid.LineColor = Drawing.Color.DimGray
                        chartArea.AxisY.LineColor = Drawing.Color.Gray
                        chartArea.AxisY.MajorGrid.LineColor = Drawing.Color.DimGray
                        Chart1.ChartAreas.Add(chartArea)

                        ' Add a legend to show candidate names with dark mode colors
                        Dim legendName As String = "CandidateLegend"
                        If Not Chart1.Legends.Any(Function(l) l.Name = legendName) Then
                            Dim legend As New Legend()
                            legend.BackColor = Drawing.Color.Transparent
                            Chart1.Legends.Add(legend)
                            legend.Name = legendName
                            legend.Docking = Docking.Right
                            legend.Alignment = StringAlignment.Center
                            legend.ForeColor = Drawing.Color.Gray  ' Set legend text color
                        End If

                        ' Loop through the candidates and add individual bars for each
                        While reader.Read()
                            Dim candidateName As String = reader("CandidateName").ToString()
                            Dim voteCount As Integer = Convert.ToInt32(reader("Voteresiv"))
                            Dim partyStatus As String = reader("PartyStatus").ToString()

                            ' Filter candidates based on PartyStatus
                            If partyStatus = "Active" OrElse partyStatus = "Inactive" Then
                                ' Create a new series for each candidate
                                Dim series As New Series(candidateName)
                                series.ChartType = SeriesChartType.Column
                                series.IsValueShownAsLabel = True ' Show data values as labels
                                series.LabelForeColor = Drawing.Color.White  ' Set label color

                                ' Add a data point for each candidate's vote count
                                Dim dataPoint As New DataPoint()
                                dataPoint.YValues = New Double() {voteCount}

                                series.Points.Add(dataPoint)

                                ' Add the series to the chart
                                Chart1.Series.Add(series)
                            End If
                        End While

                        ' Configure the X-axis
                        chartArea.AxisX.MajorGrid.LineDashStyle = ChartDashStyle.Dash  ' Set major grid line style
                        chartArea.AxisX.MinorGrid.Enabled = True
                        chartArea.AxisX.MinorGrid.LineDashStyle = ChartDashStyle.Dot  ' Set minor grid line style

                        ' Configure the Y-axis
                        chartArea.AxisY.MajorGrid.LineDashStyle = ChartDashStyle.Dash  ' Set major grid line style
                        chartArea.AxisY.MinorGrid.Enabled = True
                        chartArea.AxisY.MinorGrid.LineDashStyle = ChartDashStyle.Dot  ' Set minor grid line style

                        ' Customize chart area font, size, and color
                        chartArea.AxisX.LabelStyle.Font = New System.Drawing.Font("Poppins", 10, Drawing.FontStyle.Regular)
                        chartArea.AxisX.LabelStyle.ForeColor = Drawing.Color.Gray
                        chartArea.AxisY.LabelStyle.Font = New System.Drawing.Font("Poppins", 10, Drawing.FontStyle.Regular)
                        chartArea.AxisY.LabelStyle.ForeColor = Drawing.Color.Gray

                        ' Associate the legend with the series
                        Chart1.Legends(legendName).Docking = Docking.Right
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading candidate data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub








    Private Sub LoadDataAndDisplayPartylistChart()
        Try
            Using connection As New OleDbConnection(connectionString)
                connection.Open()

                ' Check if there are active parties
                Dim queryActiveParties As String = "SELECT COUNT(*) FROM tblParty WHERE PartyStatus = 'Active'"
                Using commandActiveParties As New OleDbCommand(queryActiveParties, connection)
                    Dim activePartiesCount As Integer = Convert.ToInt32(commandActiveParties.ExecuteScalar())

                    If activePartiesCount > 0 Then
                        ' There are active parties, show Chart2, hide Chart1, and undock Chart1
                        Panel1.Visible = True
                        Panel2.Visible = True
                        Chart1.Dock = DockStyle.None
                        lblcheckerparty.Visible = True

                        Dim queryPartylist As String = "SELECT p.PartyID, p.Title, SUM(c.Voteresiv) AS TotalVotes " &
                                            "FROM tblParty p " &
                                            "LEFT JOIN tblCandidate c ON p.PartyID = c.PartyID " &
                                            "WHERE c.PartyStatus = 'Active' " &
                                            "GROUP BY p.PartyID, p.Title"
                        Using commandPartylist As New OleDbCommand(queryPartylist, connection)
                            Using readerPartylist As OleDbDataReader = commandPartylist.ExecuteReader()

                                ' Clear existing series, chart areas, and legends in the party list chart
                                Chart2.Series.Clear()
                                Chart2.ChartAreas.Clear()
                                Chart2.Legends.Clear()

                                ' Create a new chart area for the party list chart
                                Dim chartAreaPartylist As New ChartArea()
                                Chart2.ChartAreas.Add(chartAreaPartylist)

                                While readerPartylist.Read()
                                    Dim partyID As Integer = Convert.ToInt32(readerPartylist("PartyID"))
                                    Dim partyTitle As String = readerPartylist("Title").ToString()
                                    Dim totalVotes As Integer = Convert.ToInt32(readerPartylist("TotalVotes"))

                                    ' Create a new series for each party
                                    Dim seriesPartylist As New Series("PartylistVoteCountBar_" & partyID)
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
                    Else
                        ' There are no active parties, hide Panel2, show Panel1, and dock Panel1
                        Panel2.Visible = False
                        Panel1.Visible = True
                        Panel1.Dock = DockStyle.Fill
                        lblcheckerparty.Visible = False
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading Partylist data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub










    Private Sub ButtonPresident_Click(sender As Object, e As EventArgs) Handles ButtonPresident.Click
        LoadDataAndDisplayCandidateChart("PRESIDENT")

    End Sub

    Private Sub ButtonEVPresident_Click(sender As Object, e As EventArgs) Handles ButtonEVPresident.Click
        LoadDataAndDisplayCandidateChart("EXECUTIVE VICE PRESIDENT")

    End Sub

    Private Sub ButtonVFinance_Click(sender As Object, e As EventArgs) Handles ButtonVFinance.Click
        LoadDataAndDisplayCandidateChart("VP FINANCE")

    End Sub

    Private Sub ButtonVActivities_Click(sender As Object, e As EventArgs) Handles ButtonVActivities.Click
        LoadDataAndDisplayCandidateChart("VP ACTIVITIES")

    End Sub

    Private Sub ButtonVComMarketing_Click(sender As Object, e As EventArgs) Handles ButtonVComMarketing.Click
        LoadDataAndDisplayCandidateChart("VP COMMUNICATION AND MARKETING")

    End Sub

    Private Sub ButtonVDocumentation_Click(sender As Object, e As EventArgs) Handles ButtonVDocumentation.Click
        LoadDataAndDisplayCandidateChart("VP DOCUMENTATION")

    End Sub

    Private Sub Chart2_Click(sender As Object, e As EventArgs) Handles Chart2.Click

    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        LoadDataAndDisplayCandidateChart()
    End Sub

    Private Sub TotalVotersCircle_ValueChanged(sender As Object, e As EventArgs) Handles TotalVotersCircle.ValueChanged

    End Sub

    Private Sub TotalVotersCount_Click(sender As Object, e As EventArgs) Handles TotalVotersCount.Click

    End Sub
    Private Function GetVotingCounts() As (TotalVoters As Integer, AlreadyVotedCount As Integer, RemainingVotersCount As Integer)
        Try
            Using connection As New OleDbConnection(connectionString)
                connection.Open()
                Dim totalVotersQuery As String = "SELECT COUNT(*) FROM tblVoters"
                Dim alreadyVotedQuery As String = "SELECT COUNT(*) FROM tblVoters WHERE VoteStatus = 'Voted'"
                Dim remainingVotersQuery As String = "SELECT COUNT(*) FROM tblVoters WHERE VoteStatus = 'Unvoted'"

                Dim totalVoters, alreadyVotedCount, remainingVotersCount As Integer
                Using totalVotersCommand As New OleDbCommand(totalVotersQuery, connection)
                    totalVoters = Convert.ToInt32(totalVotersCommand.ExecuteScalar())
                End Using
                Using alreadyVotedCommand As New OleDbCommand(alreadyVotedQuery, connection)
                    alreadyVotedCount = Convert.ToInt32(alreadyVotedCommand.ExecuteScalar())
                End Using
                Using remainingVotersCommand As New OleDbCommand(remainingVotersQuery, connection)
                    remainingVotersCount = Convert.ToInt32(remainingVotersCommand.ExecuteScalar())
                End Using

                Return (totalVoters, alreadyVotedCount, remainingVotersCount)
            End Using
        Catch ex As Exception
            MessageBox.Show("Error getting voting counts: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return (0, 0, 0)
        End Try
    End Function

    Private Sub GunaCirclePictureBox1_Click(sender As Object, e As EventArgs) Handles btngunarefresh.Click
        LoadDataAndDisplayCandidateChart()
        LoadDataAndDisplayPartylistChart()
    End Sub
End Class
