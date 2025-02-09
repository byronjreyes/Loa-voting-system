Imports System.Data.OleDb

Public Class Adminlogin

    Private Shared Instance As Adminlogin

    Public Shared Function GetInstance() As Adminlogin
        If IsNothing(Instance) Then
            Instance = New Adminlogin
        End If
        Return Instance
    End Function

    Private Sub Adminloginform_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Connection()


        Me.KeyPreview = True
    End Sub

    Private Sub ButtonVisibility_Click(sender As Object, e As EventArgs) Handles Guna2Button1.CheckedChanged
        txtpassword.UseSystemPasswordChar = Not txtpassword.UseSystemPasswordChar
    End Sub

    'Login
    Private Sub btnlogin_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click

        Connection()

        Dim username As String = txtusername.Text
        Dim password As String = txtpassword.Text

        If ValidateForm() Then
            Try
                If Not cn.State = ConnectionState.Open Then
                    cn.Open()
                End If

                Dim selectSql As String = "SELECT ID, Username, Password, LoginAttempts, AcctStatus, AccessLevel, Role FROM tblUsers WHERE Username = @username;"
                cmd = New OleDbCommand(selectSql, cn)
                cmd.Parameters.AddWithValue("@username", username)
                dr = cmd.ExecuteReader()

                If dr.Read() Then
                    Dim userid = dr("ID")
                    Dim dbUsername As String = dr("Username")
                    Dim dbPassword As String = dr("Password")
                    Dim loginAttempts As Integer = CInt(dr("LoginAttempts"))
                    Dim acctStatus As String = dr("AcctStatus")
                    Dim accessLevel As String = dr("AccessLevel")
                    Dim role As String = dr("Role")

                    If acctStatus = "Disabled" Then
                        lblValidationErrors.Text = "- Account is disabled. Please contact the admin to enable your account."
                    ElseIf password = dbPassword Then
                        vbinformationpanel.setAlert("Login Success", vbinformationpanel.AlertType.Success)



                        If role = "Admin" Then
                            Dim frmPOS As New Admindashboard()
                            frmPOS.Show()
                        Else
                            Dim mainDashboard As New Admindashboard()
                            mainDashboard.lblname.Text = txtusername.Text
                            mainDashboard.Show()
                        End If

                        Me.Hide()
                        txtpassword.Clear()
                        Dim updateSql As String = "UPDATE tblUsers SET LoginAttempts = 0 WHERE ID = @userid;"
                        cmd = New OleDbCommand(updateSql, cn)
                        cmd.Parameters.AddWithValue("@userid", userid)
                        cmd.ExecuteNonQuery()
                    Else
                        loginAttempts += 1
                        lblValidationErrors.Text = "- Incorrect password. You have " & (3 - loginAttempts) & " attempts left."
                        txtpassword.Select()

                        Dim updateSql As String = "UPDATE tblUsers SET LoginAttempts = @loginAttempts WHERE ID = @userid;"
                        cmd = New OleDbCommand(updateSql, cn)
                        cmd.Parameters.AddWithValue("@loginAttempts", loginAttempts)
                        cmd.Parameters.AddWithValue("@userid", userid)
                        cmd.ExecuteNonQuery()

                        If loginAttempts >= 3 Then
                            lblValidationErrors.Text = "- Account is locked. Please contact the admin to unlock your account."
                            txtusername.Select()
                            txtpassword.Clear()

                            Dim lockSql As String = "UPDATE tblUsers SET AcctStatus = 'Disabled' WHERE ID = @userid;"
                            cmd = New OleDbCommand(lockSql, cn)
                            cmd.Parameters.AddWithValue("@userid", userid)
                            cmd.ExecuteNonQuery()
                        End If
                    End If
                Else
                    lblValidationErrors.Text = "- User not found and Password error."
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                dr.Close()
            End Try
        End If
    End Sub
    Private Function ValidateForm() As Boolean
        Dim UsernameLength = txtusername.Text.Length
        Dim PasswordLength = txtpassword.Text.Length

        PanelUsernameStatus.BackColor = SystemColors.Control
        PanelPasswordStatus.BackColor = SystemColors.Control

        Dim ValidationError As String = ""

        If UsernameLength < 6 AndAlso txtusername.Text.Trim() <> "" Then
            ValidationError += "- Username must have at least 6 characters" & Environment.NewLine
            PanelUsernameStatus.BackColor = Color.Red
        ElseIf txtusername.Text.Trim() = "" Then
            ValidationError += "- Username is required" & Environment.NewLine
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

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
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

    Private Sub Guna2ControlBox1_Click(sender As Object, e As EventArgs) Handles Guna2ControlBox1.Click
        Me.Hide()
        VotingLoginpanel.Show()
    End Sub

    Private Sub Panel4_Paint(sender As Object, e As PaintEventArgs) Handles Panel4.Paint

    End Sub
End Class
