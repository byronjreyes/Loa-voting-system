Imports System.Data.OleDb
Imports System.IO

Public Class Backupdb
    Private Sub ButtonDiscard_Click(sender As Object, e As EventArgs) Handles ButtonDiscard.Click
        Me.Close()
    End Sub



    Private Async Sub btnBackup_Click(sender As Object, e As EventArgs) Handles btnbackup.Click
        Try
            Dim sourceDatabasePath As String = "C:\Users\Admin\Desktop\Loavotingsystem\Loavotingsystem\bin\x64\Debug\loa_voting.accdb"
            Dim backupFolder As String = "C:\Users\Admin\Desktop\Loavotingsystem\Backupdb"
            Dim backupFileName As String = "loa_voting.accdb"

            If Not Directory.Exists(backupFolder) Then
                Directory.CreateDirectory(backupFolder)
            End If

            Dim backupFilePath As String = Path.Combine(backupFolder, backupFileName)

            ' Show the progress bar
            Guna2WinProgressIndicator1.Visible = True

            ' Set the progress bar value to 0%
            Guna2WinProgressIndicator1.Value = 0

            ' Perform the backup
            File.Copy(sourceDatabasePath, backupFilePath, True)

            ' Simulate a delay with the progress bar
            For i As Integer = 1 To 100
                ' Update the progress bar value
                Guna2WinProgressIndicator1.Value = i
                ' Delay for a short time
                Await Task.Delay(50) ' Adjust the delay time as needed
            Next

            ' Set the progress bar value back to 0%
            Guna2WinProgressIndicator1.Value = 0

            ' Hide the progress bar
            Guna2WinProgressIndicator1.Visible = False

            ' Display the success message
            MessageBox.Show("Backup completed successfully.", "Backup", MessageBoxButtons.OK, MessageBoxIcon.Information)
            lblBackupNote.Text = "Kindly ensure that the file is renamed as 'loa_voting.accdb' without appending " & Environment.NewLine & " 'Backup' at the conclusion."
        Catch ex As Exception
            ' Display the error message
            MessageBox.Show($"Backup failed. Error: {ex.Message}", "Backup Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            lblBackupNote.Text = $"Backup failed. Error: {ex.Message}"
        End Try
    End Sub




    Private Sub Guna2WinProgressIndicator1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ShowProgressIndicator()
        ' Show the progress indicator
        Guna2WinProgressIndicator1.Visible = True

        Timer1.Interval = 8
        AddHandler Timer1.Tick, Sub(sender As Object, e As EventArgs)

                                    Guna2WinProgressIndicator1.Visible = False
                                    Timer1.Stop()
                                End Sub
        Timer1.Start()
    End Sub


    Private Sub ShowSuccessMessage(message As String)
        MessageBox.Show(message, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        lblBackupNote.Text = "Kindly ensure that the file is renamed as 'loa_voting.accdb' without appending " & Environment.NewLine & " 'Backup' at the conclusion."
    End Sub

    Private Sub ShowErrorMessage(message As String)
        MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub

    Private Sub Backupdb_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Guna2WinProgressIndicator1.Visible = False
    End Sub

    Private Sub btnrestoreautonumber_Click(sender As Object, e As EventArgs) Handles btnrestoreautonumber.Click
        Try
            Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\loa_voting.accdb;Jet OLEDB:Database Password=1669-21loa"

            Using connection As New OleDbConnection(connectionString)
                connection.Open()

                ResetAutoIncrement(connection, "tblCandidate")

                ResetAutoIncrement(connection, "tblPrevElections")

                ResetAutoIncrement(connection, "tblResult")

                ResetAutoIncrement(connection, "tblVoters")

                ResetAutoIncrement(connection, "tblElection")

                ResetAutoIncrement(connection, "tblParty")






                ShowSuccessMessage("Auto-increment reset completed successfully.")
            End Using
        Catch ex As Exception
            ' Display the error message
            ShowErrorMessage($"Auto-increment reset failed. Error: {ex.Message}")
        End Try
    End Sub

    Private Sub ResetAutoIncrement(connection As OleDbConnection, tableName As String)
        Using command As New OleDbCommand($"ALTER TABLE {tableName} ALTER COLUMN ID COUNTER(1,1)", connection)
            command.ExecuteNonQuery()
        End Using
    End Sub

End Class