Imports System.Data.OleDb

Public Class FlowPanelItems

    Private _buttonsEnabled As Boolean = False

    Public Property ButtonsEnabled As Boolean
        Get
            Return _buttonsEnabled
        End Get
        Set(value As Boolean)
            _buttonsEnabled = value
            btnedit.Visible = value
            btnremove.Visible = value
        End Set
    End Property
    Private Sub btnedit_Click(sender As Object, e As EventArgs) Handles btnedit.Click

        Dim formodal As New Form
        Dim lblfirstnameandlastname As String = lblfullname1.Text
        Dim position As String = lblposition1.Text
        Dim studentid As String = lblstudentid1.Text
        Dim representative As String = lblrepresentative1.Text
        Dim course As String = lblcourse1.Text
        Dim yearlvl As String = lblyear1.Text
        Dim tagline As String = lbltagline1.Text
        Try
            Dim modal As New CandidateUpdate
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
            ' Pass the PictureBox image to CandidateUpdate
            modal.setcandidateinfo(lblfirstnameandlastname, position, studentid, representative, course, yearlvl, tagline, PictureBox1.Image)
            modal.ShowDialog()



        Catch ex As Exception
        Finally
            formodal.Dispose()
        End Try
    End Sub

    Private Sub btnremove_Click(sender As Object, e As EventArgs) Handles btnremove.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to remove this candidate?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            Try
                Connection()
                Dim studentID As String = lblstudentid1.Text
                Dim deleteQuery As String = "DELETE FROM tblCandidate WHERE Studid = @StudentID"
                cmd = New OleDbCommand(deleteQuery, cn)
                cmd.Parameters.AddWithValue("@StudentID", studentID)
                cmd.ExecuteNonQuery()
                Dim flowLayoutPanel As FlowLayoutPanel = DirectCast(Me.Parent, FlowLayoutPanel)
                flowLayoutPanel.Controls.Remove(Me)

                MessageBox.Show("Candidate removed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show("Error removing candidate. " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                cn.Close()
            End Try
        End If
    End Sub

    Private Sub Guna2CustomGradientPanel1_Paint(sender As Object, e As PaintEventArgs) Handles Guna2CustomGradientPanel1.Paint

    End Sub
End Class
