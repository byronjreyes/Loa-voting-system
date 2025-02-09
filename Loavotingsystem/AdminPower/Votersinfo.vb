Imports System.Data.OleDb
Imports System.Runtime.CompilerServices

Public Class Votersinfo
    Sub New()
        InitializeComponent()
        DoubleBuffered = True
    End Sub
    Public Sub New(lrnid As String, studId As String, firstName As String, lastName As String, course As String, yearLvl As String, sectionStatus As String, votingstatus As String, passwords As String)
        InitializeComponent()

        LabelLRN.Text = lrnid
        LabelStudId.Text = studId
        LabelFirstName.Text = firstName
        LabelLastName.Text = lastName
        LabelCourse.Text = course
        LabelYearLvl.Text = yearLvl
        LabelSectionStatus.Text = sectionStatus
        LabelVotingStatus.Text = votingstatus
        lblpassword.Text = passwords

    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs)
        Me.Hide()
    End Sub


    Private Sub Guna2Button1_Click_1(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Me.Close()
    End Sub


    Private Sub updateinfo_Click(sender As Object, e As EventArgs) Handles updateinfo.Click
        Dim lrnID As String = LabelLRN.Text
        Dim studId As String = LabelStudId.Text
        Dim firstName As String = LabelFirstName.Text
        Dim lastName As String = LabelLastName.Text
        Dim course As String = LabelCourse.Text
        Dim yearLvl As String = LabelYearLvl.Text
        Dim sectionStatus As String = LabelSectionStatus.Text
        Dim votingStatus As String = LabelVotingStatus.Text
        Dim passwords As String = lblpassword.Text
        Dim updateForm As New UpdateVoters()
        updateForm.setvotersinfo(lrnID, studId, firstName, lastName, course, yearLvl, sectionStatus, votingStatus, passwords)
        updateForm.ShowDialog()

        Me.Close()
    End Sub





    ''VotersInfo
    Private Sub btnregister_Click(sender As Object, e As EventArgs) Handles btnregister.Click
        Dim lrnID As String = LabelLRN.Text
        Dim studId As String = LabelStudId.Text
        Dim firstName As String = LabelFirstName.Text
        Dim lastName As String = LabelLastName.Text
        Dim course As String = LabelCourse.Text
        Dim yearLvl As String = LabelYearLvl.Text
        Dim sectionStatus As String = LabelSectionStatus.Text

        If IsCandidateRegistered(studId) Then
            MsgBox("Student is already registered as a candidate.")
            btnregister.Visible = False
            Return
        End If

        Dim updateForm As New RegisterCandidate()
        updateForm.setvotersinfo(lrnID, studId, firstName, lastName, course, yearLvl, sectionStatus)


        ' Set Enabled property of combo boxes to False
        updateForm.CBYear.Enabled = False
        updateForm.CBCourse.Enabled = False
        updateForm.CBSection.Enabled = False
        updateForm.TextStudentID.Enabled = False
        updateForm.TextFirstname.Enabled = False
        updateForm.TextLastname.Enabled = False
        updateForm.TextStudentID.Enabled = False
        updateForm.ShowDialog()

        Me.Close()
    End Sub



    Private Function IsCandidateRegistered(studentID As String) As Boolean
        Try
            Using cn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\loa_voting.accdb;Jet OLEDB:Database Password=1669-21loa")
                cn.Open()

                Dim sql As String = "SELECT COUNT(*) FROM tblCandidate WHERE [Studid] = @studid"

                Using cmd As New OleDbCommand(sql, cn)
                    cmd.Parameters.AddWithValue("@studid", studentID)
                    Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                    Return count > 0
                End Using
            End Using
        Catch ex As Exception
            MsgBox("Error checking candidate status: " & ex.Message)
            Return False
        End Try
    End Function



    Private Sub Votersinfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Admindashboard.ChipElectionStatus.Text = "Started" Then
            btnregister.Visible = False
            updateinfo.Visible = False
        End If
    End Sub

    Private Sub Guna2GradientPanel1_Paint(sender As Object, e As PaintEventArgs) Handles Guna2GradientPanel1.Paint

    End Sub
End Class