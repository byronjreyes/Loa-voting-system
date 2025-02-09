Imports System.Data.OleDb

Public Class ManageAdmins
    Private Sub ManageAdmins_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadaccount()
    End Sub
    Private Sub loadaccount()
        sql = "SELECT * FROM tblUsers WHERE AccessLevel IN ('Admin')"
        cmd = New OleDbCommand(sql, cn)
        dr = cmd.ExecuteReader

        Dim xox As ListViewItem
        ListView1.Items.Clear()

        Do While dr.Read()
            xox = New ListViewItem(dr("Username").ToString)
            xox.SubItems.Add(dr("Password").ToString)
            xox.SubItems.Add(dr("AcctStatus").ToString)
            xox.SubItems.Add(dr("AccessLevel").ToString)
            xox.SubItems.Add(dr("Lastname").ToString)
            xox.SubItems.Add(dr("Firstname").ToString)
            xox.SubItems.Add(dr("Role").ToString)
            ListView1.Items.Add(xox)
        Loop
    End Sub


    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged
        If ListView1.SelectedItems.Count > 0 Then
            txtusername.Text = ListView1.SelectedItems(0).SubItems(0).Text
            btnsave.Enabled = False
        End If
    End Sub

    Private Sub txtusername_TextChanged(sender As Object, e As EventArgs) Handles txtusername.TextChanged
        Try
            Using cn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\loa_voting.accdb;Jet OLEDB:Database Password=1669-21loa")
                cn.Open()

                sql = "Select Password,AcctStatus,AccessLevel,Lastname,Firstname,Role from tblUsers where Username= '" & txtusername.Text & "'"

                Using cmd As New OleDbCommand(sql, cn)
                    Using dr As OleDbDataReader = cmd.ExecuteReader()
                        If dr.Read() Then
                            txtpassword.Text = dr("Password").ToString
                            cbostatus.Text = dr("AcctStatus").ToString
                            acclevel.Text = dr("AccessLevel").ToString
                            txtlastname.Text = dr("Lastname").ToString
                            txtfirstname.Text = dr("Firstname").ToString
                            txtrole.Text = dr("Role").ToString
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception

            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub
    ''update data
    Private Sub updatedata()
        sql = "Update tblUsers set AcctStatus=@AcctStatus,AccessLevel=@AccessLevel,Lastname=@Lastname,Firstname=@Firstname,Role=@Role WHERE Username=@Username"

        cmd = New OleDbCommand(sql, cn)
        With cmd


            .Parameters.AddWithValue("@AcctStatus", cbostatus.Text)
            .Parameters.AddWithValue("@AccessLevel", acclevel.Text)
            .Parameters.AddWithValue("@Lastname", txtlastname.Text)
            .Parameters.AddWithValue("@Firstname", txtfirstname.Text)
            .Parameters.AddWithValue("@Role", txtrole.Text)
            .Parameters.AddWithValue("@Username", txtusername.Text)
            .ExecuteNonQuery()
            If cbostatus.Text = "Active" Then
                ResetLoginAttempts(txtusername.Text)
            End If
        End With

        updatepass()
        MsgBox("Users Record Successfully Updated", MsgBoxStyle.Information)
        loadaccount()
    End Sub

    Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click, btnsave.Click
        If txtpassword.Text.Length < 6 Then
            MsgBox("Password must be 6 characters long", vbExclamation, "Pin Error")
        Else
            Call updatedata()
            If cbostatus.Text = "Disabled" Then
                UpdateLoginAttempts(txtusername.Text, 3)
            End If
        End If
    End Sub
    Private Sub ResetLoginAttempts(usernames As String)
        sql = "Update tblUsers set LoginAttempts = 0 where Username = @username"
        cmd = New OleDbCommand(sql, cn)
        cmd.Parameters.AddWithValue("@username", usernames)
        cmd.ExecuteNonQuery()
    End Sub

    Private Sub updatepass()
        sql = "UPDATE tblUsers SET [Password]=@password WHERE Username=@username"

        cmd = New OleDbCommand(sql, cn)
        With cmd
            .Parameters.AddWithValue("@password", txtpassword.Text)
            .Parameters.AddWithValue("@username", txtusername.Text)
            .ExecuteNonQuery()
        End With
    End Sub
    Private Sub UpdateLoginAttempts(username As String, attempts As Integer)
        Try
            If cn.State = ConnectionState.Closed Then
                cn.Open()
            End If

            Dim sql As String = "UPDATE tblUsers SET LoginAttempts=@attempts WHERE Username=@username"

            Using cmd As New OleDbCommand(sql, cn)
                cmd.Parameters.AddWithValue("@attempts", attempts)
                cmd.Parameters.AddWithValue("@username", username)
                cmd.ExecuteNonQuery()
            End Using
        Catch ex As Exception
            MessageBox.Show("Error updating login attempts: " & ex.Message)
        End Try
    End Sub

    ''saving data
    Private Sub savedata()

        sql = "INSERT INTO tblUsers (Username, [Password], AcctStatus, AccessLevel, Lastname, Firstname, Role, LoginAttempts) VALUES (?, ?, ?, ?, ?, ?, ?, ?)"
        cmd = New OleDbCommand(sql, cn)

        With cmd
            .Parameters.AddWithValue("@0", txtusername.Text)
            .Parameters.AddWithValue("@1", txtpassword.Text)
            .Parameters.AddWithValue("@2", cbostatus.Text)
            .Parameters.AddWithValue("@3", acclevel.Text)
            .Parameters.AddWithValue("@4", txtlastname.Text)
            .Parameters.AddWithValue("@5", txtfirstname.Text)
            .Parameters.AddWithValue("@6", txtrole.Text)
            .Parameters.AddWithValue("@7", 0)
            .ExecuteNonQuery()
        End With

        MsgBox("Users Record Successfully Saved", MsgBoxStyle.Information)
        loadaccount()

    End Sub




    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        ' Check if any required field is empty
        If String.IsNullOrWhiteSpace(txtfirstname.Text) OrElse
       String.IsNullOrWhiteSpace(txtlastname.Text) OrElse
       String.IsNullOrWhiteSpace(acclevel.Text) OrElse
       String.IsNullOrWhiteSpace(cbostatus.Text) OrElse
       String.IsNullOrWhiteSpace(txtrole.Text) OrElse
       String.IsNullOrWhiteSpace(txtpassword.Text) OrElse
       String.IsNullOrWhiteSpace(txtusername.Text) Then

            MessageBox.Show("Please input all required fields.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If


        checkAccount()
    End Sub

    Private Sub checkAccount()
        Try
            sql = "Select Username from tblUsers where Username='" & txtusername.Text & "'"
            cmd = New OleDbCommand(sql, cn)
            dr = cmd.ExecuteReader()

            If dr.Read() = True Then
                MsgBox("Username is already Exist", MsgBoxStyle.Exclamation, "Duplicated Data")
            Else
                sql = "Select * From tblUsers Where [Password] = @password"
                cmd = New OleDbCommand(sql, cn)
                cmd.Parameters.AddWithValue("@password", txtpassword.Text)
                dr = cmd.ExecuteReader()

                If dr.HasRows = True Then
                    MsgBox("Password must be unique", vbExclamation, "Unique Password")
                Else
                    savedata()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Error checking account: " & ex.Message)
        End Try
    End Sub

    ''new data
    Private Sub GunaButton1_Click(sender As Object, e As EventArgs) Handles btnnew.Click
        txtfirstname.Clear()
        txtlastname.Clear()

        acclevel.Text = Nothing
        txtusername.Clear()
        txtpassword.Clear()

        txtrole.Text = Nothing
        cbostatus.Text = Nothing
        btnsave.Enabled = True

    End Sub


    ''delete data


    Private Sub GunaButton2_Click_1(sender As Object, e As EventArgs) Handles GunaButton2.Click
        Dim confirmation As DialogResult = MessageBox.Show("Are you sure you want to delete this record?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If confirmation = DialogResult.Yes Then
            sql = "DELETE FROM tblUsers WHERE Username = @username"
            cmd = New OleDbCommand(sql, cn)
            With cmd
                .Parameters.AddWithValue("@username", txtusername.Text)
                .ExecuteNonQuery()
            End With
            MsgBox("Delete successful", vbInformation)
            loadaccount()
        End If
    End Sub

    Private Sub ButtonDiscard_Click(sender As Object, e As EventArgs) Handles ButtonDiscard.Click
        Me.Close()
    End Sub
End Class