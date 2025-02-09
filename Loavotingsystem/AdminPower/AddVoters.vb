Imports System.Data.OleDb

Public Class AddVoters
    Private Sub ButtonSubmit_Click(sender As Object, e As EventArgs) Handles ButtonSubmit.Click
        If Not ValidateForm() Then
            Return
        End If

        Try
            Using cn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\loa_voting.accdb;Jet OLEDB:Database Password=1669-21loa")
                cn.Open()

                Dim randomPassword As String = GenerateRandomPassword(cn)

                Dim sql As String = "INSERT INTO tblVoters (LRN, Studid, Firstname, Lastname, Course, Yearlvl, Votestatus, SectionStatus, [Password]) VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?)"

                Using cmd As New OleDbCommand(sql, cn)
                    cmd.Parameters.AddWithValue("@p1", Convert.ToString(textlrnnumber.Text))
                    cmd.Parameters.AddWithValue("@p2", TextStudentID.Text)
                    cmd.Parameters.AddWithValue("@p3", TextFirstname.Text)
                    cmd.Parameters.AddWithValue("@p4", TextLastname.Text)
                    cmd.Parameters.AddWithValue("@p5", CBCourse.Text)
                    cmd.Parameters.AddWithValue("@p6", CBYear.Text)
                    cmd.Parameters.AddWithValue("@p7", "Unvoted")
                    cmd.Parameters.AddWithValue("@p8", CBSection.Text)
                    cmd.Parameters.AddWithValue("@p9", randomPassword)

                    cmd.ExecuteNonQuery()
                End Using
            End Using

            MsgBox("Added to voters", vbInformation, "Success")
            clearall()
            Me.Close()
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub clearall()
        textlrnnumber.Clear()
        TextStudentID.Clear()
        TextLastname.Clear()
        TextFirstname.Clear()
        CBCourse.Text = -1
        CBYear.SelectedIndex = -1 ' Assuming CBYear is a ComboBox
        CBSection.SelectedIndex = -1 ' Assuming CBSection is a ComboBox
    End Sub

    Private Function GenerateRandomPassword(cn As OleDbConnection) As String
        Dim random As New Random()
        Dim generatedPassword As String = ""

        Do

            generatedPassword = random.Next(100000, 999999).ToString()

            If Not PasswordExists(cn, generatedPassword) Then
                Exit Do
            End If
        Loop

        Return generatedPassword
    End Function

    Private Function PasswordExists(cn As OleDbConnection, password As String) As Boolean
        Dim sql As String = "SELECT COUNT(*) FROM tblVoters WHERE Password = @password"

        Using cmd As New OleDbCommand(sql, cn)
            cmd.Parameters.AddWithValue("@password", password)

            Return CInt(cmd.ExecuteScalar()) > 0
        End Using
    End Function




    Private Function ValidateForm() As Boolean
        Dim studentLength = TextStudentID.Text.Length
        Dim firstNameLength = TextFirstname.Text.Length
        Dim lastNameLength = TextLastname.Text.Length
        Dim yearLevelLength = CBYear.Text.Length
        Dim courseLength = CBCourse.Text.Length
        Dim sectionLength = CBSection.Text.Length
        Dim lrnLength = textlrnnumber.Text.Length

        Dim studentIDValidationError As String = ""
        Dim firstNameValidationError As String = ""
        Dim lastNameValidationError As String = ""
        Dim yearLevelValidationError As String = ""
        Dim courseValidationError As String = ""
        Dim sectionValidationError As String = ""
        Dim lrnValidationError As String = ""

        If lrnLength < 12 AndAlso textlrnnumber.Text.Trim() <> "" Then
            lrnValidationError = "- LRN number must have at least 12 Characters" & Environment.NewLine
        ElseIf textlrnnumber.Text.Trim() = "" Then
            lrnValidationError = "- LRN Number is required" & Environment.NewLine
        End If

        If studentLength < 7 AndAlso TextStudentID.Text.Trim() <> "" Then
            studentIDValidationError = "- Student ID must have at least 7 characters" & Environment.NewLine
        ElseIf TextStudentID.Text.Trim() = "" Then
            studentIDValidationError = "- Student ID is required" & Environment.NewLine
        End If

        If firstNameLength < 4 AndAlso TextFirstname.Text.Trim() <> "" Then
            firstNameValidationError = "- First Name must have at least 2 characters" & Environment.NewLine
        ElseIf TextFirstname.Text.Trim() = "" Then
            firstNameValidationError = "- First Name is required" & Environment.NewLine
        End If

        If lastNameLength < 4 AndAlso TextLastname.Text.Trim() <> "" Then
            lastNameValidationError = "- Last Name must have at least 2 characters" & Environment.NewLine
        ElseIf TextLastname.Text.Trim() = "" Then
            lastNameValidationError = "- Last Name is required" & Environment.NewLine
        End If

        If CBYear.SelectedIndex = -1 Then
            yearLevelValidationError = "- Year Level must be selected" & Environment.NewLine
        End If
        If CBCourse.SelectedIndex = -1 Then
            courseValidationError = "- Course must be selected" & Environment.NewLine
        End If

        If CBSection.SelectedIndex = -1 Then
            sectionValidationError = "- Section must be selected" & Environment.NewLine
        End If

        ' Update labels with validation messages
        lblStudentIDValidation.Text = studentIDValidationError
        lblFirstNameValidation.Text = firstNameValidationError
        lblLastNameValidation.Text = lastNameValidationError
        lblYearLevelValidation.Text = yearLevelValidationError
        lblCourseValidation.Text = courseValidationError
        lblSectionValidation.Text = sectionValidationError
        lblLRNValidation.Text = lrnValidationError

        ' Check if any validation error exists
        If studentIDValidationError <> "" OrElse
       firstNameValidationError <> "" OrElse
       lastNameValidationError <> "" OrElse
       yearLevelValidationError <> "" OrElse
       courseValidationError <> "" OrElse
       sectionValidationError <> "" OrElse
       lrnValidationError <> "" Then

            Return False
        Else
            ' Clear labels if there are no validation errors
            lblStudentIDValidation.Text = ""
            lblFirstNameValidation.Text = ""
            lblLastNameValidation.Text = ""
            lblYearLevelValidation.Text = ""
            lblCourseValidation.Text = ""
            lblSectionValidation.Text = ""
            lblLRNValidation.Text = ""
            Return True ' Validation passed
        End If
    End Function



    Private Sub textlrnnumber_KeyPress(sender As Object, e As KeyPressEventArgs) Handles textlrnnumber.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> ChrW(Keys.Back) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextStudentID_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextStudentID.KeyPress
        If Not Char.IsLetterOrDigit(e.KeyChar) AndAlso e.KeyChar <> ChrW(Keys.Back) AndAlso e.KeyChar <> "-" Then
            e.Handled = True
        End If
    End Sub


    Private Sub textlrnnumber_TextChanged(sender As Object, e As EventArgs) Handles textlrnnumber.TextChanged
        If textlrnnumber.Text.Length > 12 Then
            textlrnnumber.Text = textlrnnumber.Text.Substring(0, 12)
        End If
    End Sub

    Private Sub TextStudentID_TextChanged(sender As Object, e As EventArgs) Handles TextStudentID.TextChanged
        If TextStudentID.Text.Length > 7 Then
            TextStudentID.Text = TextStudentID.Text.Substring(0, 7)
        End If
    End Sub


    Private Sub TextFirstname_TextChanged(sender As Object, e As EventArgs) Handles TextFirstname.TextChanged
        TextFirstname.Text = New String(TextFirstname.Text.Where(Function(c) Char.IsLetter(c) OrElse Char.IsWhiteSpace(c)).ToArray())
        TextFirstname.SelectionStart = TextFirstname.Text.Length
    End Sub

    Private Sub TextLastname_TextChanged(sender As Object, e As EventArgs) Handles TextLastname.TextChanged
        TextLastname.Text = New String(TextLastname.Text.Where(Function(c) Char.IsLetter(c) OrElse Char.IsWhiteSpace(c)).ToArray())
        TextLastname.SelectionStart = TextLastname.Text.Length
    End Sub


    Private Sub AddVoters_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ButtonDiscard_Click(sender As Object, e As EventArgs) Handles ButtonDiscard.Click
        Me.Close()
    End Sub

End Class
