Imports System.Data.OleDb
Imports System.Drawing.Imaging
Imports System.IO
Public Class UpdateParty
    Public Property PartyID As Integer
    Public Property Title As String
    Public Property Description As String
    Public Property President As String
    Public Property VicePresident As String
    Public Property Finance As String
    Public Property Activities As String
        Public Property CommuMarketing As String
        Public Property Docu As String
    Public Property CurrentPartyID As Integer
    Public Property SelectedPictureBox As PictureBox

    Private Sub UpdateParty_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        texttitle.Text = Title
        txtdescription.Text = Description
        CBPresident.Text = President
        CBViceEPresident.Text = VicePresident
        CBVPfinance.Text = Finance
        CBActivities.Text = Activities
        CBCOMMARKETING.Text = CommuMarketing
        CbDocumentation.Text = Docu

        CBPresident.Enabled = False
        CBViceEPresident.Enabled = False
        CBVPfinance.Enabled = False
        CBActivities.Enabled = False
        CBCOMMARKETING.Enabled = False
        CbDocumentation.Enabled = False


        If SelectedPictureBox IsNot Nothing AndAlso SelectedPictureBox.Image IsNot Nothing Then
            Picturebox1.Image = SelectedPictureBox.Image
            Picturebox1.SizeMode = PictureBoxSizeMode.StretchImage
        End If
    End Sub





    Private Function ImageToByteArray(image As Image) As Byte()
        Using ms As New MemoryStream()
            image.Save(ms, ImageFormat.Jpeg)
            Return ms.ToArray()
        End Using
    End Function

    Private Sub ButtonClear_Click(sender As Object, e As EventArgs) Handles ButtonClear.Click
        Picturebox1.Image = My.Resources._error
    End Sub

    Private Sub Picturebox1_Click(sender As Object, e As EventArgs) Handles Picturebox1.Click
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            Picturebox1.Image = Image.FromFile(OpenFileDialog1.FileName)

            Picturebox1.SizeMode = PictureBoxSizeMode.StretchImage
        End If
    End Sub


    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Try
            UpdatePartyInDatabase()
            MsgBox("Party Update success")
            Me.DialogResult = DialogResult.OK
            Me.Close()
        Catch ex As Exception
            MessageBox.Show("Error updating party information: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub UpdatePartyInDatabase()
        Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\loa_voting.accdb;Jet OLEDB:Database Password=1669-21loa"

        Using connection As New OleDbConnection(connectionString)
            connection.Open()

            Dim updatePartySql As String = "UPDATE tblParty SET Title = @Title, Description = @Description, partyimage = @PartyImage " &
                                           "WHERE PartyID = @PartyID"

            Using cmd As New OleDbCommand(updatePartySql, connection)
                cmd.Parameters.AddWithValue("@Title", texttitle.Text)
                cmd.Parameters.AddWithValue("@Description", txtdescription.Text)

                If Picturebox1.Image IsNot Nothing Then
                    Dim imageBytes As Byte() = ImageToByteArray(Picturebox1.Image)
                    cmd.Parameters.AddWithValue("@PartyImage", imageBytes)
                Else
                    cmd.Parameters.AddWithValue("@PartyImage", DBNull.Value)
                End If

                cmd.Parameters.AddWithValue("@PartyID", PartyID)

                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub
End Class