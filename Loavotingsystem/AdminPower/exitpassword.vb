Public Class exitpassword
    Private Const ExitPassword As String = "akosibyron"

    Private Sub ButtonDiscard_Click(sender As Object, e As EventArgs) Handles ButtonDiscard.Click
        Me.Close()
    End Sub

    Private Sub btnsubmit_Click(sender As Object, e As EventArgs) Handles btnsubmit.Click
        If txtpassword.Text = ExitPassword Then
            Application.Exit()
        Else
            MsgBox("Incorrect password. Please try again.", "Error", vbCritical)


            txtpassword.Clear()
        End If
    End Sub


End Class
