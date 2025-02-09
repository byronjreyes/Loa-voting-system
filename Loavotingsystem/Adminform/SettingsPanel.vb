Imports System.Data.OleDb

Public Class SettingsPanel

    Private _loggedInUsername As String
    Public Property LoggedInUsername() As String
        Get
            Return _loggedInUsername
        End Get
        Set(ByVal value As String)
            _loggedInUsername = value
        End Set
    End Property
    Private Sub SettingsPanel_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


    Private Sub BtnChangePassword_Click(sender As Object, e As EventArgs) Handles BtnChangePassword.Click
        If IsSuperAdmin(LoggedInUsername) Then
            Dim formmodal As New Form
            Dim changePassForm As New ChangePass()
            Try
                formmodal.StartPosition = FormStartPosition.CenterScreen
                formmodal.FormBorderStyle = FormBorderStyle.None
                formmodal.Opacity = 0.5D
                formmodal.BackColor = Color.Black
                formmodal.WindowState = FormWindowState.Maximized
                formmodal.TopMost = True
                formmodal.Location = Location
                formmodal.ShowInTaskbar = False
                formmodal.Show()

                changePassForm.Username = LoggedInUsername
                changePassForm.Owner = formmodal


                changePassForm.ShowDialog()

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                formmodal.Dispose()
            End Try
        Else
            MessageBox.Show("Only Super Admin can open this.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub


    Private Function IsSuperAdmin(username As String) As Boolean

        Try
            Using cn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\loa_voting.accdb;Jet OLEDB:Database Password=1669-21loa")
                cn.Open()
                Dim sql As String = "SELECT AccessLevel FROM tblUsers WHERE Username = @username"
                Using cmd As New OleDbCommand(sql, cn)
                    cmd.Parameters.AddWithValue("@username", username)
                    Dim accessLevel As String = Convert.ToString(cmd.ExecuteScalar())
                    Return accessLevel = "Super Admin"
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error checking access level: " & ex.Message)
            Return False
        End Try
    End Function

    Private Sub btnbackupdata_Click(sender As Object, e As EventArgs) Handles btnbackupdata.Click
        Dim formModal As New Form
        Dim changePassForm As New Backupdb()

        Try
            formModal.StartPosition = FormStartPosition.CenterScreen
            formModal.FormBorderStyle = FormBorderStyle.None
            formModal.Opacity = 0.5D
            formModal.BackColor = Color.Black
            formModal.WindowState = FormWindowState.Maximized
            formModal.TopMost = True
            formModal.Location = Location
            formModal.ShowInTaskbar = False
            formModal.Show()
            changePassForm.Owner = formModal
            changePassForm.ShowDialog()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            formModal.Dispose()
        End Try
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub ButtonAddAdmin_Click(sender As Object, e As EventArgs) Handles ButtonAddAdmin.Click
        If IsSuperAdmin2(LoggedInUsername) Then
            Dim formmodal As New Form
            Dim addsomeusers As New AddUsers()
            Try
                formmodal.StartPosition = FormStartPosition.CenterScreen
                formmodal.FormBorderStyle = FormBorderStyle.None
                formmodal.Opacity = 0.5D
                formmodal.BackColor = Color.Black
                formmodal.WindowState = FormWindowState.Maximized
                formmodal.TopMost = True
                formmodal.Location = Location
                formmodal.ShowInTaskbar = False
                formmodal.Show()

                addsomeusers.Username = LoggedInUsername
                addsomeusers.Owner = formmodal


                addsomeusers.ShowDialog()

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                formmodal.Dispose()
            End Try
        Else
            MessageBox.Show("Only Super Admin can open this.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub
    Private Function IsSuperAdmin2(username As String) As Boolean

        Try
            Using cn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\loa_voting.accdb;Jet OLEDB:Database Password=1669-21loa")
                cn.Open()
                Dim sql As String = "SELECT AccessLevel FROM tblUsers WHERE Username = @username"
                Using cmd As New OleDbCommand(sql, cn)
                    cmd.Parameters.AddWithValue("@username", username)
                    Dim accessLevel As String = Convert.ToString(cmd.ExecuteScalar())
                    Return accessLevel = "Super Admin"
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error checking access level: " & ex.Message)
            Return False
        End Try
    End Function








    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click

        Dim formodal As New Form
        Try
            Dim modal As New ManageAdmins
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
            ManageAdmins.ShowDialog()

        Catch ex As Exception
        Finally
            formodal.Dispose()
        End Try
    End Sub
End Class