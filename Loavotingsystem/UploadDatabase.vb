Imports System.Collections.Specialized.BitVector32
Imports System.Data.OleDb

Public Class UploadDatabase

    Private sourceConnString As String = String.Empty
    Dim DB_SCHEMA As Dictionary(Of String, List(Of String))

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs)

        Me.Close()
    End Sub

    Private Sub TextDBPath_Click(sender As Object, e As EventArgs)
        Dim openFileDialog1 As New OpenFileDialog()
        openFileDialog1.Filter = "Access Database File (*.accdb)|*.accdb"
        openFileDialog1.Title = "Select Access Database File"

        If openFileDialog1.ShowDialog() = DialogResult.OK Then
            TextDBPath.Text = openFileDialog1.FileName
            sourceConnString = $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={openFileDialog1.FileName};"

            PopulateTableNames()
            PopulateColumnNames()
        End If
    End Sub

    Private Sub PopulateTableNames()

        DB_SCHEMA = New Dictionary(Of String, List(Of String))


        Using conn As New OleDbConnection(sourceConnString)
            Try
                conn.Open()


                Dim schema As DataTable = conn.GetSchema("Tables")


                For Each row As DataRow In schema.Rows
                    If row("TABLE_TYPE").ToString() = "TABLE" Then
                        Dim tableName As String = row("TABLE_NAME").ToString()


                        Dim columns As List(Of String) = GetTableColumns(conn, tableName)


                        DB_SCHEMA.Add(tableName, columns)

                        CBTables.Items.Add(tableName)
                    End If
                Next

                If CBTables.Items.Count > 0 Then
                    CBTables.SelectedIndex = 0
                End If
            Catch ex As Exception
                MessageBox.Show("Error retrieving table names: " & ex.Message)
            Finally
                conn.Close()
            End Try
        End Using
    End Sub

    Private Function GetTableColumns(conn As OleDbConnection, tableName As String) As List(Of String)
        Dim columns As New List(Of String)


        Dim schema As DataTable = conn.GetSchema("Columns", New String() {Nothing, Nothing, tableName})


        For Each row As DataRow In schema.Rows

            columns.Add(row("COLUMN_NAME").ToString())
        Next

        Return columns
    End Function


    Private Sub CBTables_SelectedIndexChanged(sender As Object, e As EventArgs)

        If Not String.IsNullOrEmpty(CBTables.Text) Then

            Using conn As New OleDbConnection(sourceConnString)
                Try
                    conn.Open()


                    Dim selectCommandText As String = $"SELECT * FROM {CBTables.Text}"

                    Using cmd As New OleDbCommand(selectCommandText, conn)
                        Using reader As OleDbDataReader = cmd.ExecuteReader()

                            If reader.HasRows Then
                                reader.Read()
                                ''default coulms
                                CBStudentID.Text = (reader("Studid"))
                                CBFirstname.Text = (reader("Firstname"))
                                CBLastname.Text = (reader("Lastname"))
                                CBCourse.Text = (reader("Course"))
                                CBYear.Text = (reader("Yearlvl"))
                                CBVote.Text = (reader("VotingStatus"))
                                CBSection.Text = (reader("SectionStatus"))
                            Else

                            End If
                        End Using
                    End Using

                Catch ex As Exception
                    MessageBox.Show("Error retrieving table data: " & ex.Message)
                Finally
                    conn.Close()
                End Try
            End Using
            PopulateColumnNames()
        End If
    End Sub



    Sub PopulateColumnNames()
        If IsNothing(DB_SCHEMA) OrElse Not DB_SCHEMA.ContainsKey(CBTables.Text) Then Return

        Dim columns = New List(Of String)
        columns.Add("Select Column")
        columns.AddRange(DB_SCHEMA(CBTables.Text))

        CBStudentID.DataSource = columns.ToList()
        CBFirstname.DataSource = columns.ToList()
        CBLastname.DataSource = columns.ToList()
        CBCourse.DataSource = columns.ToList()
        CBYear.DataSource = columns.ToList()
        CBVote.DataSource = columns.ToList()
        CBSection.DataSource = columns.ToList()
    End Sub

    Private Sub ButtonImport_Click(sender As Object, e As EventArgs)

        If String.IsNullOrEmpty(CBTables.Text) Then
            MessageBox.Show("Please select a table.")
            Return
        End If


        If String.IsNullOrEmpty(CBStudentID.Text) OrElse
       String.IsNullOrEmpty(CBFirstname.Text) OrElse
       String.IsNullOrEmpty(CBLastname.Text) OrElse
       String.IsNullOrEmpty(CBCourse.Text) OrElse
       String.IsNullOrEmpty(CBYear.Text) OrElse
       String.IsNullOrEmpty(CBVote.Text) OrElse
            String.IsNullOrEmpty(CBSection.Text) Then
            MessageBox.Show("Please select columns for all fields.")
            Return
        End If


        Using sourceConn As New OleDbConnection(sourceConnString)
            Try
                sourceConn.Open()


                Dim selectCommandText As String = $"SELECT * FROM {CBTables.Text}"

                Using selectCmd As New OleDbCommand(selectCommandText, sourceConn)
                    Using reader As OleDbDataReader = selectCmd.ExecuteReader()

                        If reader.HasRows Then

                            Using mainConn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Admin\Desktop\Loavotingsystem\Loavotingsystem\bin\x64\Debug\loa_voting.accdb")
                                mainConn.Open()


                                While reader.Read()

                                    Dim checkDuplicateCommandText As String = $"SELECT COUNT(*) FROM tblVoters WHERE VoterID = @VoterID"
                                    Using checkDuplicateCmd As New OleDbCommand(checkDuplicateCommandText, mainConn)
                                        checkDuplicateCmd.Parameters.AddWithValue("@VoterID", reader("VoterID"))
                                        Dim existingRecords As Integer = Convert.ToInt32(checkDuplicateCmd.ExecuteScalar())


                                        If existingRecords = 0 Then
                                            Dim insertCommandText As String = $"INSERT INTO tblVoters (VoterID, Studid, Firstname, Lastname, Course, Yearlvl, VotingStatus, SectionStatus) VALUES (?, ?, ?, ?, ?, ?, ?, ?)"

                                            Using insertCmd As New OleDbCommand(insertCommandText, mainConn)
                                                insertCmd.Parameters.AddWithValue("@VoterID", reader("VoterID"))
                                                insertCmd.Parameters.AddWithValue("@Studid", reader(CBStudentID.Text))
                                                insertCmd.Parameters.AddWithValue("@Firstname", reader(CBFirstname.Text))
                                                insertCmd.Parameters.AddWithValue("@Lastname", reader(CBLastname.Text))
                                                insertCmd.Parameters.AddWithValue("@Course", reader(CBCourse.Text))
                                                insertCmd.Parameters.AddWithValue("@Yearlvl", reader(CBYear.Text))
                                                insertCmd.Parameters.AddWithValue("@VotingStatus", reader(CBVote.Text))
                                                insertCmd.Parameters.AddWithValue("@SectionStatus", reader(CBSection.Text))


                                                insertCmd.ExecuteNonQuery()
                                            End Using
                                        End If
                                    End Using
                                End While

                                MessageBox.Show("Data imported successfully.")
                            End Using
                        Else
                            MessageBox.Show("No data to import.")
                        End If
                    End Using
                End Using
            Catch ex As Exception
                MessageBox.Show("Error during import: " & ex.Message)
            Finally
                sourceConn.Close()
            End Try
        End Using
    End Sub

    Private Sub Guna2GroupBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Guna2Button2_Click_1(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        Me.Close()
    End Sub
End Class


