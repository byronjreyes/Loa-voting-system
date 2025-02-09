Imports System.Data.OleDb
Imports System.Drawing.Imaging

Public Class Partyvoteinfo
    Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\loa_voting.accdb;Jet OLEDB:Database Password=1669-21loa"


    Private Sub Partyvoteinfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Connection()

        If IsActivePartyList() Then



            For Each partyID In GetActivePartyIDs()
                CreatePartyPictureBox(partyID)
            Next
        Else

        End If
    End Sub

    Private Function IsActivePartyList() As Boolean
        Dim isActiveSql As String = "SELECT COUNT(*) FROM tblParty WHERE PartyStatus = 'Active'"

        Using cn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\loa_voting.accdb;Jet OLEDB:Database Password=1669-21loa")
            Using cmd As New OleDbCommand(isActiveSql, cn)
                Try
                    cn.Open()
                    Dim count As Integer = CInt(cmd.ExecuteScalar())
                    Return count > 0
                Catch ex As Exception
                    MsgBox("Error checking active party list: " & ex.Message, vbCritical)
                    Return False
                End Try
            End Using
        End Using
    End Function

    Private Function ByteArrayToImage(byteArray As Byte()) As Image
        Using ms As New System.IO.MemoryStream(byteArray)
            Return Image.FromStream(ms)
        End Using
    End Function

    Private Function GetCurrentPartyID() As Integer
        Dim query As String = "SELECT MAX(PartyID) FROM tblParty"
        Using connection As New OleDbConnection(connectionString)
            connection.Open()
            Using command As New OleDbCommand(query, connection)
                Dim result As Object = command.ExecuteScalar()
                If result IsNot DBNull.Value Then
                    Return CInt(result)
                Else
                    Return 0
                End If
            End Using
        End Using
    End Function
    Private _PartyPictureBoxCount As Integer = 0
    Public Sub CreatePartyPictureBox(partyID As Integer)
        If partyID = 0 Then
            flpMain.Controls.Clear()
        End If

        Dim partyPictureBox As PictureBox
        partyPictureBox = New PictureBox()

        CurrentPartyID = partyID

        _PartyPictureBoxCount += 1

        With partyPictureBox
            .BackColor = Color.White
            .Size = New Size(200, 100)
            .Name = $"picturepartyimage{_PartyPictureBoxCount}"

            AddHandler .Click, AddressOf picturepartyimage_Click
            Dim partyImage As Image = LoadPartyImage(partyID)
            If partyImage IsNot Nothing Then
                .Image = partyImage
                .SizeMode = PictureBoxSizeMode.StretchImage
            Else
                .Image = Nothing
            End If
            AddHandler .MouseEnter, AddressOf partyPictureBox_MouseEnter
            AddHandler .MouseLeave, AddressOf partyPictureBox_MouseLeave

        End With

        flpMain.Controls.Add(partyPictureBox)
    End Sub

    Private Sub partyPictureBox_MouseEnter(sender As Object, e As EventArgs)
        DirectCast(sender, PictureBox).Cursor = Cursors.Hand
    End Sub

    Private Sub partyPictureBox_MouseLeave(sender As Object, e As EventArgs)
        DirectCast(sender, PictureBox).Cursor = Cursors.Default
    End Sub

    Private Function ChangeImageOpacity(image As Image, opacity As Single) As Image
        Dim bmp As New Bitmap(image.Width, image.Height)
        Using g As Graphics = Graphics.FromImage(bmp)
            Dim matrix As New ColorMatrix()
            matrix.Matrix33 = opacity
            Dim attributes As New ImageAttributes()
            attributes.SetColorMatrix(matrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap)
            g.DrawImage(image, New Rectangle(0, 0, bmp.Width, bmp.Height), 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, attributes)
        End Using
        Return bmp
    End Function



    Private Function GetActivePartyIDs() As List(Of Integer)
        Dim partyIDs As New List(Of Integer)

        Using cn As New OleDbConnection(connectionString)
            cn.Open()

            Dim selectActivePartyIDsSql As String = "SELECT PartyID FROM tblParty WHERE PartyStatus = 'Active'"
            Using cmd As New OleDbCommand(selectActivePartyIDsSql, cn)
                Using reader As OleDbDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        partyIDs.Add(Convert.ToInt32(reader("PartyID")))
                    End While
                End Using
            End Using
        End Using

        Return partyIDs
    End Function

    Private Function LoadPartyImage(partyID As Integer) As Image
        Dim query As String = "SELECT partyimage FROM tblParty WHERE PartyID = @PartyID"
        Using connection As New OleDbConnection(connectionString)
            connection.Open()
            Using command As New OleDbCommand(query, connection)
                command.Parameters.AddWithValue("@PartyID", partyID)

                Dim result As Object = command.ExecuteScalar()
                If result IsNot DBNull.Value Then
                    Dim imageBytes As Byte() = DirectCast(result, Byte())
                    Using ms As New System.IO.MemoryStream(imageBytes)
                        Return Image.FromStream(ms)
                    End Using
                End If
            End Using
        End Using

        Return Nothing
    End Function

    Private Function GetMaxPartyID() As Integer
        Dim query As String = "SELECT MAX(PartyID) FROM tblParty"

        Using connection As New OleDbConnection(connectionString)
            connection.Open()
            Using command As New OleDbCommand(query, connection)
                Dim result As Object = command.ExecuteScalar()
                If result IsNot DBNull.Value Then
                    Return CInt(result)
                Else
                    Return 0
                End If
            End Using
        End Using
    End Function
    Private SelectedPictureBox As PictureBox = Nothing
    Private Sub picturepartyimage_Click(sender As Object, e As EventArgs)

        Dim clickedPictureBox As PictureBox = DirectCast(sender, PictureBox)

        If SelectedPictureBox IsNot clickedPictureBox Then

            If SelectedPictureBox IsNot Nothing Then
                DeselectPictureBox(SelectedPictureBox)
            End If
            Dim partyID As Integer
            If Integer.TryParse(clickedPictureBox.Name.Replace("picturepartyimage", ""), partyID) Then
                LoadPartyDetails(partyID)
                SelectPictureBox(clickedPictureBox)
            End If
        Else
            DeselectPictureBox(SelectedPictureBox)
        End If
    End Sub

    Private Sub SelectPictureBox(pictureBox As PictureBox)

        Dim selectedColor As Color = Color.FromArgb(140, 140, 140)

        pictureBox.BackColor = selectedColor
        pictureBox.Image = ChangeImageOpacity(pictureBox.Image, 0.9F)
        SelectedPictureBox = pictureBox
    End Sub


    Private Sub DeselectPictureBox(pictureBox As PictureBox)
        pictureBox.BackColor = Color.Transparent
        pictureBox.Image = LoadPartyImage(CurrentPartyID)
        SelectedPictureBox = Nothing
    End Sub

    Private Sub LoadAllPartyDetails()
    End Sub

    Private CurrentPartyID As Integer
    Private Sub LoadPartyDetails(partyID As Integer)
        Try
            Using cn As New OleDbConnection(connectionString)
                cn.Open()
                Dim selectPartyDetailsSql As String = "SELECT * FROM qryParties WHERE PartyStatus = 'Active' AND PartyID = @PartyID"
                Using cmd As New OleDbCommand(selectPartyDetailsSql, cn)
                    cmd.Parameters.AddWithValue("@PartyID", partyID)

                    Using reader As OleDbDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            Dim title As String = Convert.ToString(reader("Title"))
                            Dim description As String = Convert.ToString(reader("Description"))
                            Dim partyImageBytes As Byte() = DirectCast(reader("partyimage"), Byte())

                            Dim partyImage As Image = If(partyImageBytes IsNot Nothing AndAlso partyImageBytes.Length > 0, ByteArrayToImage(partyImageBytes), Nothing)
                            UpdatePartyInformation(partyID, title, description, "", "", "", "", "", "", partyImage)
                            txtpresident.Text = GetCandidateNameForPosition(cn, "PRESIDENT", Convert.ToInt32(reader("PartyID")))
                            txtvicepresident.Text = GetCandidateNameForPosition(cn, "EXECUTIVE VICE PRESIDENT", Convert.ToInt32(reader("PartyID")))
                            txtfinance.Text = GetCandidateNameForPosition(cn, "VP FINANCE", Convert.ToInt32(reader("PartyID")))
                            txtactivities.Text = GetCandidateNameForPosition(cn, "VP ACTIVITIES", Convert.ToInt32(reader("PartyID")))
                            txtcommumarketing.Text = GetCandidateNameForPosition(cn, "VP COMMUNICATION AND MARKETING ", Convert.ToInt32(reader("PartyID")))
                            txtdocu.Text = GetCandidateNameForPosition(cn, "VP DOCUMENTATION", Convert.ToInt32(reader("PartyID")))
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MsgBox("Error loading party details: " & ex.Message, vbCritical)
        End Try
    End Sub
    Private Sub UpdatePartyInformation(partyID As Integer, title As String, description As String, president As String, vicePresident As String, finance As String, activities As String, commumarketing As String, docu As String, partyImage As Image)

        texttitle.Text = title
        txtdescription.Text = description
        txtpresident.Text = president
        txtvicepresident.Text = vicePresident
        txtfinance.Text = finance
        txtactivities.Text = activities
        txtcommumarketing.Text = commumarketing
        txtdocu.Text = docu
        CurrentPartyID = partyID
    End Sub
    Private Function GetCandidateNameForPosition(connection As OleDbConnection, position As String, partyID As Integer) As String
        Try
            Dim query As String = "SELECT Firstname, Lastname FROM qryParties WHERE PartyStatus = 'Active' AND Position = @Position AND PartyID = @PartyID"

            Using cmd As New OleDbCommand(query, connection)
                cmd.Parameters.AddWithValue("@Position", position)
                cmd.Parameters.AddWithValue("@PartyID", partyID)

                Using reader As OleDbDataReader = cmd.ExecuteReader()
                    If reader.Read() Then
                        Return $"{reader("Firstname")} {reader("Lastname")}"
                    End If
                End Using
            End Using
        Catch ex As Exception
            MsgBox($"Error getting candidate name for {position}: {ex.Message}", vbCritical)
        End Try

        Return String.Empty
    End Function
End Class