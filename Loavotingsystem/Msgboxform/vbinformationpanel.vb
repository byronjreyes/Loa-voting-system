Imports System.Windows.Forms

Public Class vbinformationpanel

    Enum AlertType
        Success
        Warning
        [Error]
        Info
    End Enum

    Dim x, y As Integer
    Dim AutoHide As Boolean

    Public Sub setAlert(msg As String, type As AlertType)
        setAlert(msg, type, True)
    End Sub

    Public Sub setMessage(msg As String)
        Label1.Text = msg
    End Sub

    Enum ActionType
        Wait
        Start
        Close
    End Enum

    Dim action As ActionType = ActionType.Start

    Public Sub setAlert(msg As String, type As AlertType, AutoHide As Boolean)
        Dim fname As String
        Me.Opacity = 0
        Me.StartPosition = FormStartPosition.Manual
        Me.AutoHide = AutoHide
        'Me.TopMost = True
        For i As Integer = 1 To 10
            fname = "alert" & i.ToString()
            Dim f As vbinformationpanel = Application.OpenForms.Item(fname)
            If f Is Nothing Then
                Me.Name = fname
                x = Screen.PrimaryScreen.WorkingArea.Width - Me.Width + 15
                y = Screen.PrimaryScreen.WorkingArea.Height - Me.Height * i - 5 * i
                Me.Location = New Point(x, y)
                Exit For
            End If
        Next
        x = Screen.PrimaryScreen.WorkingArea.Width - Me.Width - 5
        Select Case type
            Case AlertType.Success
                PictureBox1.Image = My.Resources.check
                BackColor = Color.FromArgb(82, 152, 114)
            Case AlertType.Warning
                PictureBox1.Image = My.Resources.error_white
                BackColor = Color.FromArgb(255, 164, 91)
            Case AlertType.Error
                PictureBox1.Image = My.Resources.error_white
                BackColor = Color.FromArgb(255, 70, 70)
            Case AlertType.Info
                PictureBox1.Image = My.Resources.info
                BackColor = Color.FromArgb(71, 169, 248)
        End Select
        Label1.Text = msg
        Me.Show()
        Me.Timer1.Interval = 1
        Me.Timer1.Start()
    End Sub



    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Select Case action
            Case ActionType.Start
                Timer1.Interval = 1
                Me.Opacity += 0.1
                If Me.Opacity = 1 Then
                    action = ActionType.Wait
                End If
            Case ActionType.Wait
                Timer1.Interval = 3000
                action = ActionType.Close
            Case ActionType.Close
                Timer1.Interval = 1
                Me.Opacity -= 0.1
                Me.Left -= 3
                If Me.Opacity = 0 Then
                    Me.Close()
                End If
        End Select
    End Sub



    Private Sub vbinformationpanel_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


End Class







'Imports System.Windows.Forms

'Public Class vbinformationpanel

'    Enum AlertType
'        Success
'        Warning
'        [Error]
'        Info
'    End Enum

'    Dim x, y As Integer
'    Dim AutoHide As Boolean

'    Public Sub setAlert(msg As String, type As AlertType)
'        setAlert(msg, type, True)
'    End Sub

'    Public Sub setMessage(msg As String)
'        Label1.Text = msg
'    End Sub

'    Enum ActionType
'        Wait
'        Start
'        Close
'    End Enum

'    Dim action As ActionType = ActionType.Start

'    Public Sub setAlert(msg As String, type As AlertType, AutoHide As Boolean)
'        Dim fname As String
'        Me.Opacity = 0
'        Me.StartPosition = FormStartPosition.Manual
'        Me.AutoHide = AutoHide
'        Me.AutoSize = False ' Set AutoSize to False
'        Label1.AutoSize = False ' Set AutoSize to False for the label
'        Label1.MaximumSize = New Size(200, 0) ' Set a maximum width for word wrapping
'        Label1.AutoSize = True ' Let the label adjust its height based on content
'        Label1.Font = New Font("Poppins", 10)
'        Me.TopMost = True
'        For i As Integer = 1 To 10
'            fname = "alert" & i.ToString()
'            Dim f As vbinformationpanel = Application.OpenForms.Item(fname)
'            If f Is Nothing Then
'                Me.Name = fname
'                x = Screen.PrimaryScreen.WorkingArea.Width - Me.Width + 15
'                y = Screen.PrimaryScreen.WorkingArea.Height - Me.Height * i - 5 * i
'                Me.Location = New Point(x, y)
'                Exit For
'            End If
'        Next
'        x = Screen.PrimaryScreen.WorkingArea.Width - Me.Width - 5
'        Select Case type
'            Case AlertType.Success
'                PictureBox1.Image = My.Resources.check
'                BackColor = Color.FromArgb(82, 152, 114)
'            Case AlertType.Warning
'                PictureBox1.Image = My.Resources.error_white
'                BackColor = Color.FromArgb(255, 164, 91)
'            Case AlertType.Error
'                PictureBox1.Image = My.Resources.error_white
'                BackColor = Color.FromArgb(255, 70, 70)
'            Case AlertType.Info
'                PictureBox1.Image = My.Resources.info
'                BackColor = Color.FromArgb(71, 169, 248)
'        End Select
'        Label1.Text = msg
'        Me.Show()
'        Me.Timer1.Interval = 1
'        Me.Timer1.Start()
'    End Sub

'    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
'        Select Case action
'            Case ActionType.Start
'                Timer1.Interval = 1
'                Me.Opacity += 0.1
'                If Me.Opacity = 1 Then
'                    action = ActionType.Wait
'                End If
'            Case ActionType.Wait
'                Timer1.Interval = 3000
'                action = ActionType.Close
'            Case ActionType.Close
'                Timer1.Interval = 1
'                Me.Opacity -= 0.1
'                Me.Left -= 3
'                If Me.Opacity = 0 Then
'                    Me.Close()
'                End If
'        End Select
'    End Sub

'    Private Sub vbinformationpanel_Load(sender As Object, e As EventArgs) Handles MyBase.Load

'    End Sub
'End Class

