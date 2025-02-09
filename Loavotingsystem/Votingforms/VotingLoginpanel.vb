Imports System.Data.OleDb

Public Class VotingLoginpanel

    Private Sub VotingLoginpanel_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.KeyPreview = True
    End Sub



    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, keyData As Keys) As Boolean
        If keyData = (Keys.Control Or Keys.Alt Or Keys.D9 Or Keys.D0) Then
            ShowAnotherForm()
            Return True
        End If

        Return MyBase.ProcessCmdKey(msg, keyData)
    End Function





    Private Sub ShowAnotherForm()
        Dim anotherForm As New Adminlogin()
        anotherForm.Show()
        Me.Hide()
    End Sub

    Private Sub Panel4_Paint(sender As Object, e As PaintEventArgs) Handles Panel4.Paint

    End Sub

    Private Sub VotingLoginpanel_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.Control AndAlso e.Alt AndAlso e.KeyCode = Keys.D9 AndAlso e.KeyCode = Keys.D0 Then
            ShowAnotherForm()
        ElseIf e.KeyCode = Keys.Enter Then
            btnlogin_Click(sender, e)
        End If
    End Sub







    Private Sub Adminloginform_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            Connection()


            Me.KeyPreview = True
        End Sub

        Private Sub ButtonVisibility_Click(sender As Object, e As EventArgs) Handles Guna2Button1.CheckedChanged
            txtpassword.UseSystemPasswordChar = Not txtpassword.UseSystemPasswordChar
        End Sub

    'Login

    Private Sub btnlogin_Click(sender As Object, e As EventArgs) Handles btnlogin.Click
        Connection()

        Dim username As String = txtusername.Text
        Dim password As String = txtpassword.Text
        If Not IsElectionActive() Then
            ' Show an alert that the election is not started yet
            MessageBox.Show("The election is not started yet. Please wait for the election to begin.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        If ValidateForm() Then
            Try
                If Not cn.State = ConnectionState.Open Then
                    cn.Open()
                End If

                ' Update the SQL query to retrieve Firstname and Lastname
                Dim selectSql As String = "SELECT ID, Studid, Firstname, Lastname, Password, Votestatus FROM tblVoters WHERE Studid = @username;"
                cmd = New OleDbCommand(selectSql, cn)
                cmd.Parameters.AddWithValue("@username", username)
                dr = cmd.ExecuteReader()

                If dr.Read() Then
                    Dim voterId = dr("ID")
                    Dim dbUsername As String = dr("Studid")
                    Dim dbFirstname As String = dr("Firstname")
                    Dim dbLastname As String = dr("Lastname")
                    Dim dbPassword As String = dr("Password")
                    Dim votingStatus As String = dr("Votestatus")

                    If password = dbPassword Then
                        If votingStatus = "Unvoted" Then
                            vbinformationpanel.setAlert("Login Success", vbinformationpanel.AlertType.Success)

                            ' Combine Firstname and Lastname into a single label
                            Dim fullName As String = $"{dbFirstname} {dbLastname}"
                            VotingDashboard.lblfullname.Text = fullName

                            ' Pass additional information to VotingDashboard
                            VotingDashboard.lblname.Text = dbUsername

                            VotingDashboard.Show()
                            Me.Hide()
                            txtpassword.Clear()
                        Else
                            lblValidationErrors.Text = "- You have already voted."
                        End If
                    Else
                        lblValidationErrors.Text = "- Incorrect password."
                    End If
                Else
                    ' Student ID not found
                    lblValidationErrors.Text = "- Student ID not found. Make sure you have entered the correct " & Environment.NewLine & " Student ID."
                    lblValidationErrors.TextAlign = ContentAlignment.MiddleLeft

                    lblnote.Text = "- Reminder: Don't forget to include '-' in your Student ID."
                    lblnote.TextAlign = ContentAlignment.MiddleLeft
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                dr.Close()
            End Try
        End If
    End Sub

    Private Function IsElectionActive() As Boolean
        Try
            Using connection As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\loa_voting.accdb;Jet OLEDB:Database Password=1669-21loa")
                connection.Open()

                Dim query As String = "SELECT TOP 1 Status FROM tblElection ORDER BY CDate(Started) DESC"

                Using command As New OleDbCommand(query, connection)
                    Dim status As String = Convert.ToString(command.ExecuteScalar())

                    ' If the election status is active, return true
                    Return String.Equals(status, "Active", StringComparison.OrdinalIgnoreCase)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error checking election status: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function
    Private Function ValidateForm() As Boolean
        Dim UsernameLength = txtusername.Text.Length
        Dim PasswordLength = txtpassword.Text.Length

        PanelUsernameStatus.BackColor = SystemColors.Control
        PanelPasswordStatus.BackColor = SystemColors.Control

        Dim ValidationError As String = ""

        If UsernameLength < 6 AndAlso txtusername.Text.Trim() <> "" Then
            ValidationError += "- Student ID must have at least 6 characters" & Environment.NewLine
            PanelUsernameStatus.BackColor = Color.Red
        ElseIf txtusername.Text.Trim() = "" Then
            ValidationError += "- Student ID is required" & Environment.NewLine
            PanelUsernameStatus.BackColor = Color.Red
        End If

        If PasswordLength < 6 AndAlso txtpassword.Text.Trim() <> "" Then
            ValidationError += "- Password must have at least 6 characters" & Environment.NewLine
            PanelPasswordStatus.BackColor = Color.Red
            txtpassword.Select()
        ElseIf txtpassword.Text.Trim() = "" Then
            ValidationError += "- Password is required" & Environment.NewLine
            PanelPasswordStatus.BackColor = Color.Red
        End If

        If ValidationError <> "" Then
            lblValidationErrors.Text = ValidationError
            Return False
        Else
            Return True
        End If
    End Function

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs)
        Dim vbInformationPanel As New vbinformationpanel()

        If ValidateForm() Then
            sql = "Select * from tblUsers where Username='" & txtusername.Text & "' and Password='" & txtpassword.Text & "'"
            cmd = New OleDbCommand(sql, cn)
            dr = cmd.ExecuteReader

            If dr.Read = True Then
                vbInformationPanel.setAlert("Login Success", vbinformationpanel.AlertType.Success)

            Else
                vbInformationPanel.setAlert("Login failed", vbinformationpanel.AlertType.Error)
            End If

            dr.Close()
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dim formodal As New Form
        Try
            Dim modal As New exitpassword
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
            exitpassword.ShowDialog()

        Catch ex As Exception
        Finally
            formodal.Dispose()
        End Try
    End Sub

End Class

