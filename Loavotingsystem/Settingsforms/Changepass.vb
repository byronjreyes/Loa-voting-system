Imports System.Data.OleDb

Public Class ChangePass


    Private _username As String
    Public Property Username() As String
        Get
            Return _username
        End Get
        Set(ByVal value As String)
            _username = value

            txtusername.Text = value
        End Set
    End Property

    Private Sub ChangePass_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtusername.Enabled = False
        Connection()
    End Sub

    Private Sub ButtonDiscard_Click(sender As Object, e As EventArgs) Handles ButtonDiscard.Click
        Me.Close()
    End Sub


    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        ' Validate the form
        If Not ValidateForm() Then
            Return
        End If

        ' Continue with the password change logic
        If Not CheckCurrentpass() Then
            lblCurrentPassValidation.Text = "- Current Password is incorrect. Please enter the correct Password."
            Return
        Else
            lblCurrentPassValidation.Text = ""
        End If

        If txtnewpass.Text <> txtrepass.Text Then
            lblRePassValidation.Text = "- New Password and re-entered Password do not match."
            Return
        ElseIf txtnewpass.Text.Length < 6 Then
            lblNewPassValidation.Text = "- New Password must be 6 characters long."
            Return
        Else
            lblRePassValidation.Text = ""
            lblNewPassValidation.Text = ""
        End If

        Updatepass()
        clear()
    End Sub


    Private Function ValidateForm() As Boolean
        Dim currentPassLength = txtcurrent.Text.Length
        Dim newPassLength = txtnewpass.Text.Length
        Dim rePassLength = txtrepass.Text.Length

        Dim currentPassValidationError As String = ""
        Dim newPassValidationError As String = ""
        Dim rePassValidationError As String = ""

        If currentPassLength = 0 Then
            currentPassValidationError = "- Current Password is required" & Environment.NewLine
        End If

        If newPassLength < 6 AndAlso txtnewpass.Text.Trim() <> "" Then
            newPassValidationError = "- New Password must have at least 6 characters" & Environment.NewLine
        ElseIf txtnewpass.Text.Trim() = "" Then
            newPassValidationError = "- New Password is required" & Environment.NewLine
        End If

        If rePassLength = 0 Then
            rePassValidationError = "- Re-entered Password is required" & Environment.NewLine
        End If

        ' Update labels with validation messages
        lblCurrentPassValidation.Text = currentPassValidationError
        lblNewPassValidation.Text = newPassValidationError
        lblRePassValidation.Text = rePassValidationError

        ' Check if any validation error exists
        If currentPassValidationError <> "" OrElse
        newPassValidationError <> "" OrElse
        rePassValidationError <> "" Then
            Return False
        Else
            ' Clear labels if there are no validation errors
            lblCurrentPassValidation.Text = ""
            lblNewPassValidation.Text = ""
            lblRePassValidation.Text = ""
            Return True ' Validation passed
        End If
    End Function

    Private Function CheckCurrentpass() As Boolean

        sql = "SELECT COUNT(*) FROM tblUsers WHERE Username=@username AND Password=@password"
        cmd = New OleDbCommand(sql, cn)
        With cmd
            .Parameters.AddWithValue("@username", txtusername.Text)
            .Parameters.AddWithValue("@password", txtcurrent.Text)
        End With

        Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
        Return count > 0
    End Function

    Private Sub Updatepass()

        sql = "UPDATE tblUsers SET [Password]=@password WHERE [Username]=@username"
        cmd = New OleDbCommand(sql, cn)
        With cmd
            .Parameters.AddWithValue("@password", txtnewpass.Text)
            .Parameters.AddWithValue("@username", txtusername.Text)
            .ExecuteNonQuery()
        End With
        MsgBox("Password has been updated successfully.", vbInformation, "Updated Successfully")

    End Sub

    Private Sub clear()
        txtcurrent.Clear()
        txtnewpass.Clear()
        txtrepass.Clear()
    End Sub
End Class