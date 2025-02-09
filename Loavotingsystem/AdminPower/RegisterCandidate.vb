Imports System.Data.OleDb

Public Class RegisterCandidate
    Private Sub RegisterCandidate_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    Public Sub setvotersinfo(lrnid As String, studId As String, firstName As String, lastName As String, course As String, yearLvl As String, sectionStatus As String)

        LabelLRN.Text = lrnid
        TextStudentID.Text = studId
        TextFirstname.Text = firstName
        TextLastname.Text = lastName
        CBCourse.Text = course
        CBYear.Text = yearLvl.ToString()
        CBSection.Text = sectionStatus.ToString()

    End Sub
    Private Sub ButtonDiscard_Click(sender As Object, e As EventArgs) Handles ButtonDiscard.Click
        Me.Close()
    End Sub

    Private Sub Guna2PictureBox1_Click(sender As Object, e As EventArgs) Handles Guna2PictureBox1.Click
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            Guna2PictureBox1.ImageLocation = OpenFileDialog1.FileName
        End If
    End Sub

    Private Sub ButtonClear_Click(sender As Object, e As EventArgs) Handles ButtonClear.Click

        Guna2PictureBox1.Image = My.Resources._error
    End Sub

    Private Sub SaveCandidate()
        Try
            If String.IsNullOrWhiteSpace(txtrepresentative.Text) OrElse
           String.IsNullOrWhiteSpace(txtposition.Text) OrElse
           String.IsNullOrWhiteSpace(txttagline.Text) OrElse
           (Guna2PictureBox1.Image Is Nothing) Then
                MsgBox("Please input all required fields.", vbExclamation, "Validation Error")
                Return
            End If

            If String.IsNullOrWhiteSpace(Guna2PictureBox1.ImageLocation) OrElse
           Not System.IO.File.Exists(Guna2PictureBox1.ImageLocation) Then
                MsgBox("Please select a valid image.", vbExclamation, "Validation Error")
                Return
            End If

            Using cn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\loa_voting.accdb;Jet OLEDB:Database Password=1669-21loa")
                cn.Open()

                If IsCandidateRegistered(cn, TextStudentID.Text) Then
                    MsgBox("Student is already registered as a candidate.", vbCritical, "Error Occurred")
                    Return
                End If

                If PositionLimitExceeded(cn, txtposition.Text.ToLower()) Then
                    MsgBox($"Position limit for {txtposition.Text} has been reached. Cannot register more candidates for this position.", vbCritical, "Error Occurred")
                    Return
                End If

                ' Check if Party with PartyID 0 exists
                Dim partyIDExists As Boolean = PartyExists(cn, 0)

                If Not partyIDExists Then
                    ' If PartyID 0 doesn't exist, insert into tblParty
                    Dim insertPartySql As String = "INSERT INTO tblParty (PartyID, Title, Description, partyimage, PartyStatus) VALUES (0, 'Empty', 'Empty', NULL, 'Empty')"
                    Using cmdInsertParty As New OleDbCommand(insertPartySql, cn)
                        cmdInsertParty.ExecuteNonQuery()
                    End Using
                End If

                Dim sql As String = "INSERT INTO tblCandidate ([Studid], [Firstname], [Lastname], [Position], [Representative], [Tagline], [Voteresiv], [img], [PartyStatus], [PositionID], [Status], [PartyID]) VALUES (@studid, @firstname, @lastname, @position, @representative, @tagline, @voteresiv, @img, @partystatus, @positionid, @status, @partyid)"

                Using cmd As New OleDbCommand(sql, cn)
                    cmd.Parameters.AddWithValue("@studid", TextStudentID.Text)
                    cmd.Parameters.AddWithValue("@firstname", TextFirstname.Text)
                    cmd.Parameters.AddWithValue("@lastname", TextLastname.Text)
                    cmd.Parameters.AddWithValue("@position", txtposition.Text)
                    cmd.Parameters.AddWithValue("@representative", txtrepresentative.Text)
                    cmd.Parameters.AddWithValue("@tagline", txttagline.Text)
                    cmd.Parameters.AddWithValue("@voteresiv", 0)

                    Dim imgPath As String = Guna2PictureBox1.ImageLocation
                    Dim imgBytes As Byte() = System.IO.File.ReadAllBytes(imgPath)
                    cmd.Parameters.AddWithValue("@img", imgBytes)
                    cmd.Parameters.AddWithValue("@partystatus", "Inactive")

                    Dim positionID As Integer = GetPositionID(cn, txtposition.Text)
                    cmd.Parameters.AddWithValue("@positionid", positionID)

                    ' Assuming Status is a column with default value "Independent"
                    cmd.Parameters.AddWithValue("@status", "Independent")

                    ' Use PartyID 0 for candidates
                    cmd.Parameters.AddWithValue("@partyid", 0)

                    cmd.ExecuteNonQuery()
                End Using
            End Using

            MsgBox("Candidate registered successfully", vbInformation, "Success")
            Me.Close()
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        End Try
    End Sub

    Private Function PartyExists(connection As OleDbConnection, partyID As Integer) As Boolean
        Dim sql As String = "SELECT COUNT(*) FROM tblParty WHERE PartyID = @partyID"
        Using cmd As New OleDbCommand(sql, connection)
            cmd.Parameters.AddWithValue("@partyID", partyID)
            Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
            Return count > 0
        End Using
    End Function



    'Private Sub SaveCandidate()
    '    Try
    '        If String.IsNullOrWhiteSpace(txtrepresentative.Text) OrElse
    '       String.IsNullOrWhiteSpace(txtposition.Text) OrElse
    '       String.IsNullOrWhiteSpace(txttagline.Text) OrElse
    '       (Guna2PictureBox1.Image Is Nothing) Then
    '            MsgBox("Please input all required fields.", vbExclamation, "Validation Error")
    '            Return
    '        End If
    '        If String.IsNullOrWhiteSpace(Guna2PictureBox1.ImageLocation) OrElse
    '       Not System.IO.File.Exists(Guna2PictureBox1.ImageLocation) Then
    '            MsgBox("Please select a valid image.", vbExclamation, "Validation Error")
    '            Return
    '        End If

    '        Using cn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\loa_voting.accdb;Jet OLEDB:Database Password=1669-21loa")
    '            cn.Open()

    '            If IsCandidateRegistered(cn, TextStudentID.Text) Then
    '                MsgBox("Student is already registered as a candidate.", vbCritical, "Error Occurred")
    '                Return
    '            End If

    '            If PositionLimitExceeded(cn, txtposition.Text.ToLower()) Then
    '                MsgBox($"Position limit for {txtposition.Text} has been reached. Cannot register more candidates for this position.", vbCritical, "Error Occurred")
    '                Return
    '            End If

    '            Dim sql As String = "INSERT INTO tblCandidate ([Studid], [Firstname], [Lastname], [Position], [Representative], [Tagline], [Voteresiv], [img], [PartyStatus], [PositionID]) VALUES (@studid, @firstname, @lastname, @position, @representative, @tagline, @voteresiv, @img, @partystatus, @positionid)"

    '            Using cmd As New OleDbCommand(sql, cn)
    '                cmd.Parameters.AddWithValue("@studid", TextStudentID.Text)
    '                cmd.Parameters.AddWithValue("@firstname", TextFirstname.Text)
    '                cmd.Parameters.AddWithValue("@lastname", TextLastname.Text)
    '                cmd.Parameters.AddWithValue("@position", txtposition.Text)
    '                cmd.Parameters.AddWithValue("@representative", txtrepresentative.Text)
    '                cmd.Parameters.AddWithValue("@tagline", txttagline.Text)
    '                cmd.Parameters.AddWithValue("@voteresiv", 0)

    '                Dim imgPath As String = Guna2PictureBox1.ImageLocation
    '                Dim imgBytes As Byte() = System.IO.File.ReadAllBytes(imgPath)
    '                cmd.Parameters.AddWithValue("@img", imgBytes)
    '                cmd.Parameters.AddWithValue("@partystatus", "Inactive")


    '                Dim positionID As Integer = GetPositionID(cn, txtposition.Text)
    '                cmd.Parameters.AddWithValue("@positionid", positionID)

    '                cmd.ExecuteNonQuery()
    '            End Using
    '        End Using

    '        MsgBox("Candidate registered successfully", vbInformation, "Success")
    '        Me.Close
    '    Catch ex As Exception
    '        MsgBox("Error: " & ex.Message)
    '    End Try
    'End Sub

    Private Function GetPositionID(connection As OleDbConnection, position As String) As Integer
        Dim sql As String = "SELECT [PositionID] FROM tblPosition WHERE [Position] = @position"

        Using cmd As New OleDbCommand(sql, connection)
            cmd.Parameters.AddWithValue("@position", position)
            Dim result As Object = cmd.ExecuteScalar()

            If result IsNot Nothing AndAlso Not DBNull.Value.Equals(result) Then
                Return Convert.ToInt32(result)
            Else
                Return -1
            End If
        End Using
    End Function


    Private Function IsCandidateRegistered(connection As OleDbConnection, studentID As String) As Boolean
        Dim sql As String = "SELECT COUNT(*) FROM tblCandidate WHERE [Studid] = @studid"

        Using cmd As New OleDbCommand(sql, connection)
            cmd.Parameters.AddWithValue("@studid", studentID)
            Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
            Return count > 0
        End Using
    End Function


    Private Function PositionLimitExceeded(connection As OleDbConnection, position As String) As Boolean
        Dim sql As String = "SELECT COUNT(*) FROM tblCandidate WHERE [Position] = @position"

        Using cmd As New OleDbCommand(sql, connection)
            cmd.Parameters.AddWithValue("@position", position.Trim())
            Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())

            Select Case position.ToLower().Trim()
                Case "president"
                    Return count >= 15
                Case "executive vice president"
                    Return count >= 15
                Case "vp finance"
                    Return count >= 15
                Case "vp activities"
                    Return count >= 15
                Case "vp communication and marketing"
                    Return count >= 15
                Case "vp documentation"
                    Return count >= 15
                Case Else
                    Return False
            End Select
        End Using
    End Function




    Private Sub ButtonRegister_Click(sender As Object, e As EventArgs) Handles ButtonRegister.Click
        SaveCandidate()
    End Sub


End Class