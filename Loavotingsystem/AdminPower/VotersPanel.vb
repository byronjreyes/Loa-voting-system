Imports System.Data.OleDb
Imports Guna.UI2.WinForms

Public Class VotersPanel
    Private Sub VotersPanel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ButtonFilterAll.FillColor = Color.FromArgb(255, 164, 91)
        ButtonFilterAll.ForeColor = Color.White
        loadaccount()

    End Sub

    Public Sub SetCloseButtonVisibility(visible As Boolean)
        btnclose.Visible = visible
    End Sub
    Public Sub loadaccount()
        Try

            Dim historySql As String = "SELECT LRN, Studid, Firstname, Lastname, Course, Yearlvl, SectionStatus, Votestatus, Password FROM tblVoters"
            cmd = New OleDbCommand(historySql, cn)

            Dim adapter As New OleDbDataAdapter(cmd)
            Dim dataTable As New DataTable()
            adapter.Fill(dataTable)
            DataGridView1.DataSource = dataTable

        Catch ex As Exception
            MsgBox("Error loading voters students " & ex.Message, vbCritical)
        End Try
    End Sub



    Private currentform As Form = Nothing
    Private Sub GoBackToClientDashboard()
        If currentform IsNot Nothing Then
            currentform.Hide()
        End If
        If Adminlogin.Visible Then
            Adminlogin.Hide()
        End If
        Me.Show()
    End Sub

    Private Sub TextSearch_TextChanged(sender As Object, e As EventArgs) Handles TextSearch.TextChanged
        SearchVoters(TextSearch.Text)
    End Sub



    Private Sub searchvoters(keyword As String)
        Try
            Dim searchsql As String = "select lrn, studid, firstname, lastname, course, yearlvl, sectionstatus, Votestatus, Password from tblvoters where firstname like '%" & keyword & "%' or lastname like '%" & keyword & "%' or studid like '%" & keyword & "%'"
            cmd = New OleDbCommand(searchsql, cn)

            Dim adapter As New OleDbDataAdapter(cmd)
            Dim datatable As New DataTable()
            adapter.Fill(datatable)
            DataGridView1.DataSource = datatable

        Catch ex As Exception
            MsgBox("error searching voters: " & ex.Message, vbCritical)
        End Try
    End Sub


    Private Sub filterByVotingStatus(votingStatus As String)
        Try
            Dim filterSql As String = "SELECT LRN, studid, firstname, lastname, course, yearlvl, sectionstatus, Votestatus, Password FROM tblvoters WHERE Votestatus = '" & votingStatus & "'"
            cmd = New OleDbCommand(filterSql, cn)

            Dim adapter As New OleDbDataAdapter(cmd)
            Dim datatable As New DataTable()
            adapter.Fill(datatable)
            DataGridView1.DataSource = datatable

        Catch ex As Exception
            MsgBox("Error filtering voters by voting status: " & ex.Message, vbCritical)
        End Try
    End Sub

    Private Sub filterbyyear(year As Integer)
        Try

            Dim filtersql As String = "select LRN, studid, firstname, lastname, course, yearlvl, sectionstatus, Votestatus, Password from tblvoters where yearlvl like '%" & year & "st-year' or yearlvl like '%" & year & "nd-year' or yearlvl like '%" & year & "rd-year' or yearlvl like '%" & year & "th-year'"
            cmd = New OleDbCommand(filtersql, cn)

            Dim adapter As New OleDbDataAdapter(cmd)
            Dim datatable As New DataTable()
            adapter.Fill(datatable)
            DataGridView1.DataSource = datatable

        Catch ex As Exception
            MsgBox("error filtering voters by year: " & ex.Message, vbCritical)
        End Try
    End Sub

    Private Sub BindingSource1_CurrentChanged(sender As Object, e As EventArgs)

    End Sub




    Private PreviousFilter As Guna2Button = Nothing

    Private Sub ButtonFilter_Click(sender As Object, e As EventArgs) Handles ButtonFilterAll.Click, ButtonFilter1st.Click, ButtonFilter4th.Click, ButtonFilter3rd.Click, ButtonFilter2nd.Click, btnfilterunvoted.Click
        Dim clickedButton As Guna2Button = DirectCast(sender, Guna2Button)

        If (PreviousFilter IsNot Nothing AndAlso clickedButton.Equals(PreviousFilter)) Then Return
        ButtonFilterAll.FillColor = SystemColors.Control
        ButtonFilterAll.ForeColor = SystemColors.ControlDarkDark

        If PreviousFilter IsNot Nothing Then
            PreviousFilter.FillColor = SystemColors.Control
            PreviousFilter.ForeColor = SystemColors.ControlDarkDark
        End If

        clickedButton.FillColor = Color.FromArgb(173, 152, 82)
        clickedButton.ForeColor = Color.White
        PreviousFilter = clickedButton

        LoadStudent()
    End Sub

    Private Sub LoadStudent()
        If ButtonFilterAll.Equals(PreviousFilter) Then
            loadaccount()
        ElseIf ButtonFilter1st.Equals(PreviousFilter) Then
            filterbyyear(1)
        ElseIf ButtonFilter2nd.Equals(PreviousFilter) Then
            filterbyyear(2)
        ElseIf ButtonFilter3rd.Equals(PreviousFilter) Then
            filterbyyear(3)
        ElseIf ButtonFilter4th.Equals(PreviousFilter) Then
            filterbyyear(4)
        ElseIf btnfilterunvoted.Equals(PreviousFilter) Then
            filterByVotingStatus("Unvoted")
        End If
    End Sub

    Private Sub DataGridView1_DoubleClick(sender As Object, e As EventArgs) Handles DataGridView1.DoubleClick
        If DataGridView1.SelectedRows.Count > 0 Then

            Dim lrnID As String = DataGridView1.SelectedRows(0).Cells("LRN").Value.ToString()
            Dim studId As String = DataGridView1.SelectedRows(0).Cells("Studid").Value.ToString()
            Dim firstName As String = DataGridView1.SelectedRows(0).Cells("Firstname").Value.ToString()
            Dim lastName As String = DataGridView1.SelectedRows(0).Cells("Lastname").Value.ToString()
            Dim course As String = DataGridView1.SelectedRows(0).Cells("Course").Value.ToString()
            Dim yearLvl As String = DataGridView1.SelectedRows(0).Cells("Yearlvl").Value.ToString()
            Dim sectionStatus As String = DataGridView1.SelectedRows(0).Cells("SectionStatus").Value.ToString()
            Dim votingStatus As String = DataGridView1.SelectedRows(0).Cells("Votestatus").Value.ToString()
            Dim passwords As String = DataGridView1.SelectedRows(0).Cells("Password").Value.ToString()

            Dim formodal As New Form
            Try
                Dim votersInfoForm As New Votersinfo(lrnID, studId, firstName, lastName, course, yearLvl, sectionStatus, votingStatus, passwords)
                formodal.StartPosition = FormStartPosition.CenterScreen
                formodal.FormBorderStyle = FormBorderStyle.None
                formodal.Opacity = 0.5D
                formodal.BackColor = Color.Black
                formodal.WindowState = FormWindowState.Maximized
                formodal.TopMost = True
                formodal.Location = Location
                formodal.ShowInTaskbar = False
                formodal.Show()
                votersInfoForm.Owner = formodal
                votersInfoForm.ShowDialog()

            Catch ex As Exception
            Finally
                formodal.Dispose()
            End Try
        End If
    End Sub


    Private Sub TextSearch_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextSearch.KeyPress
        If Not Char.IsLetterOrDigit(e.KeyChar) AndAlso e.KeyChar <> ChrW(Keys.Back) AndAlso e.KeyChar <> "-" Then
            e.Handled = True
        End If
    End Sub


    Private Sub ButtonSubmit_Click(sender As Object, e As EventArgs) Handles ButtonSubmit.Click

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
            formodal.Show()
            modal.Owner = formodal
            AddVoters.ShowDialog()

        Catch ex As Exception
        Finally
            formodal.Dispose()
        End Try
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        loadaccount()
    End Sub

    Private Sub btnclose_Click(sender As Object, e As EventArgs) Handles btnclose.Click
        Me.Close()
    End Sub
End Class