Imports System.Data.OleDb
Imports System.IO

Public Class CandidateUpdate
    Private Sub CandidateUpdate_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Public Sub setcandidateinfo(lblfirstnameandlastname As String, position As String, studentid As String, representative As String, course As String, yearlvl As String, tagline As String, candidateImage As Image)        ' Split the full name into first name and last name
        Dim names() As String = lblfirstnameandlastname.Split(" "c)
        Dim firstname As String = names(0)
        Dim lastname As String = If(names.Length > 1, String.Join(" ", names.Skip(1)), String.Empty)

        txtFirstName.Text = firstname
        txtlastname.Text = lastname
        txtPosition.Text = position
        txtStudentID.Text = studentid
        txtrepresentative.Text = representative
        txtCourse.Text = course
        txtYear.Text = yearlvl
        txttagline.Text = tagline
        PictureBox1.Image = candidateImage


    End Sub






    Private Sub ButtonDiscard_Click(sender As Object, e As EventArgs) Handles ButtonDiscard.Click
        Me.Close()
    End Sub

    Private Sub UpdateCandidateData()
        Try
            Using cn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\loa_voting.accdb;Jet OLEDB:Database Password=1669-21loa")
                cn.Open()

                ' Update tblCandidate
                UpdateCandidate(cn)

                ' Update tblVoters
                UpdateVoters(cn)
            End Using

            MsgBox("Candidate Record Successfully Updated", MsgBoxStyle.Information)

        Catch ex As Exception
            MsgBox("Error updating candidate record: " & ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub UpdateCandidate(cn As OleDbConnection)
        Dim sqlCandidate As String = "UPDATE tblCandidate SET [Firstname]=@Firstname, [Lastname]=@Lastname, [Position]=@Position, [Representative]=@Representative, [Tagline]=@Tagline, [img]=@img WHERE [Studid]=@Studid"

        Using cmdCandidate As New OleDbCommand(sqlCandidate, cn)
            ' Add parameters
            cmdCandidate.Parameters.AddWithValue("@Firstname", txtFirstName.Text)
            cmdCandidate.Parameters.AddWithValue("@Lastname", txtlastname.Text)
            cmdCandidate.Parameters.AddWithValue("@Position", txtPosition.Text)
            cmdCandidate.Parameters.AddWithValue("@Representative", txtrepresentative.Text)
            cmdCandidate.Parameters.AddWithValue("@Tagline", txttagline.Text)
            cmdCandidate.Parameters.AddWithValue("@img", If(PictureBox1.Image IsNot Nothing, ImageToByteArray(PictureBox1.Image), DBNull.Value))
            cmdCandidate.Parameters.AddWithValue("@Studid", txtStudentID.Text)

            ' Print the SQL command for debugging
            Console.WriteLine("SQL Candidate Command: " & cmdCandidate.CommandText)

            Try
                ' Execute the command
                cmdCandidate.ExecuteNonQuery()
                Console.WriteLine("Candidate Record Successfully Updated")
            Catch ex As Exception
                Console.WriteLine("Error updating candidate record: " & ex.Message)
            End Try
        End Using
    End Sub





    Private Sub UpdateVoters(cn As OleDbConnection)
        Dim sqlVoters As String = "UPDATE tblVoters SET [Firstname]=@firstname, [Lastname]=@lastname, [Yearlvl]=@yearlvl, [Course]=@course WHERE [Studid]=@studid"
        Using cmdVoters As New OleDbCommand(sqlVoters, cn)
            With cmdVoters
                .Parameters.AddWithValue("@firstname", txtFirstName.Text)
                .Parameters.AddWithValue("@lastname", txtlastname.Text)
                .Parameters.AddWithValue("@yearlvl", txtYear.Text)
                .Parameters.AddWithValue("@course", txtCourse.Text)
                .Parameters.AddWithValue("@studid", txtStudentID.Text)
                .ExecuteNonQuery()
            End With
        End Using
    End Sub


    Private Sub ButtonSubmit_Click(sender As Object, e As EventArgs) Handles ButtonSubmit.Click
        Try
            UpdateCandidateData()

            ' Update candidate image in tblCandidate
            UpdateCandidateInDatabase(txtStudentID.Text) ' Pass the student ID as the parameter

            MsgBox("Update successfully saved", vbInformation)
        Catch ex As Exception
            MessageBox.Show("Error updating candidate information: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Using openFileDialog As New OpenFileDialog()
            openFileDialog.Filter = "Image Files (*.bmp; *.jpg; *.png)|*.bmp; *.jpg; *.png|All Files (*.*)|*.*"
            openFileDialog.Title = "Select an Image File"

            If openFileDialog.ShowDialog() = DialogResult.OK Then
                ' Set the selected image file to PictureBox1
                PictureBox1.Image = Image.FromFile(openFileDialog.FileName)
            End If
        End Using
    End Sub

    Private Sub UpdateCandidateInDatabase(studid As String)
        ' Connection string (Replace with your actual connection string)
        Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\loa_voting.accdb;Jet OLEDB:Database Password=1669-21loa"

        Using connection As New OleDbConnection(connectionString)
            connection.Open()

            ' SQL update command for tblParty
            Dim updateCandidateSql As String = "UPDATE tblCandidate SET img = @img WHERE Studid = @Studid"

            Using cmd As New OleDbCommand(updateCandidateSql, connection)
                ' Convert and set image parameter
                If PictureBox1.Image IsNot Nothing Then
                    Dim imageBytes As Byte() = ImageToByteArray(PictureBox1.Image)
                    cmd.Parameters.AddWithValue("@img", imageBytes)
                Else
                    cmd.Parameters.AddWithValue("@img", DBNull.Value)
                End If

                ' Set Studid parameter
                cmd.Parameters.AddWithValue("@Studid", studid)

                ' Execute the update command
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    Private Function ImageToByteArray(image As Image) As Byte()
        Using stream As New MemoryStream()
            image.Save(stream, image.RawFormat)
            Return stream.ToArray()
        End Using
    End Function


End Class
