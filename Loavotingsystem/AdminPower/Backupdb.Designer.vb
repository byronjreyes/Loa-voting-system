<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Backupdb
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Guna2CustomGradientPanel1 = New Guna.UI2.WinForms.Guna2CustomGradientPanel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblBackupNote = New System.Windows.Forms.Label()
        Me.ButtonDiscard = New Guna.UI2.WinForms.Guna2Button()
        Me.btnbackup = New Guna.UI.WinForms.GunaButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnrestoreautonumber = New Guna.UI.WinForms.GunaButton()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Guna2WinProgressIndicator1 = New Guna.UI2.WinForms.Guna2ProgressBar()
        Me.Guna2CustomGradientPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2CustomGradientPanel1
        '
        Me.Guna2CustomGradientPanel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2CustomGradientPanel1.BorderRadius = 21
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.Label5)
        Me.Guna2CustomGradientPanel1.FillColor = System.Drawing.Color.Gainsboro
        Me.Guna2CustomGradientPanel1.FillColor2 = System.Drawing.Color.Gainsboro
        Me.Guna2CustomGradientPanel1.FillColor3 = System.Drawing.Color.Gainsboro
        Me.Guna2CustomGradientPanel1.FillColor4 = System.Drawing.Color.Gainsboro
        Me.Guna2CustomGradientPanel1.Location = New System.Drawing.Point(-20, 50)
        Me.Guna2CustomGradientPanel1.Name = "Guna2CustomGradientPanel1"
        Me.Guna2CustomGradientPanel1.ShadowDecoration.Parent = Me.Guna2CustomGradientPanel1
        Me.Guna2CustomGradientPanel1.Size = New System.Drawing.Size(366, 47)
        Me.Guna2CustomGradientPanel1.TabIndex = 104
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Poppins", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label5.Location = New System.Drawing.Point(35, 7)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(204, 37)
        Me.Label5.TabIndex = 58
        Me.Label5.Text = "Backup Database"
        '
        'lblBackupNote
        '
        Me.lblBackupNote.AutoSize = True
        Me.lblBackupNote.Font = New System.Drawing.Font("Poppins", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBackupNote.ForeColor = System.Drawing.Color.Red
        Me.lblBackupNote.Location = New System.Drawing.Point(17, 430)
        Me.lblBackupNote.Name = "lblBackupNote"
        Me.lblBackupNote.Size = New System.Drawing.Size(0, 26)
        Me.lblBackupNote.TabIndex = 103
        '
        'ButtonDiscard
        '
        Me.ButtonDiscard.Animated = True
        Me.ButtonDiscard.CheckedState.Parent = Me.ButtonDiscard
        Me.ButtonDiscard.CustomImages.Parent = Me.ButtonDiscard
        Me.ButtonDiscard.FillColor = System.Drawing.Color.Transparent
        Me.ButtonDiscard.Font = New System.Drawing.Font("Poppins", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonDiscard.ForeColor = System.Drawing.Color.Gray
        Me.ButtonDiscard.HoverState.FillColor = System.Drawing.Color.Silver
        Me.ButtonDiscard.HoverState.Font = New System.Drawing.Font("Poppins", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonDiscard.HoverState.ForeColor = System.Drawing.Color.Gray
        Me.ButtonDiscard.HoverState.Parent = Me.ButtonDiscard
        Me.ButtonDiscard.Location = New System.Drawing.Point(230, 301)
        Me.ButtonDiscard.Name = "ButtonDiscard"
        Me.ButtonDiscard.ShadowDecoration.Parent = Me.ButtonDiscard
        Me.ButtonDiscard.Size = New System.Drawing.Size(169, 38)
        Me.ButtonDiscard.TabIndex = 102
        Me.ButtonDiscard.Text = "Discard"
        '
        'btnbackup
        '
        Me.btnbackup.AnimationHoverSpeed = 0.07!
        Me.btnbackup.AnimationSpeed = 0.03!
        Me.btnbackup.BackColor = System.Drawing.Color.Transparent
        Me.btnbackup.BaseColor = System.Drawing.Color.Transparent
        Me.btnbackup.BorderColor = System.Drawing.Color.FromArgb(CType(CType(158, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.btnbackup.BorderSize = 2
        Me.btnbackup.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnbackup.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnbackup.FocusedColor = System.Drawing.Color.Transparent
        Me.btnbackup.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnbackup.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnbackup.Image = Nothing
        Me.btnbackup.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnbackup.Location = New System.Drawing.Point(201, 249)
        Me.btnbackup.Name = "btnbackup"
        Me.btnbackup.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.btnbackup.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(135, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(135, Byte), Integer))
        Me.btnbackup.OnHoverForeColor = System.Drawing.Color.White
        Me.btnbackup.OnHoverImage = Nothing
        Me.btnbackup.OnPressedColor = System.Drawing.Color.FromArgb(CType(CType(88, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.btnbackup.OnPressedDepth = 25
        Me.btnbackup.Radius = 21
        Me.btnbackup.Size = New System.Drawing.Size(226, 46)
        Me.btnbackup.TabIndex = 101
        Me.btnbackup.Text = "Backup"
        Me.btnbackup.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Poppins", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Snow
        Me.Label3.Location = New System.Drawing.Point(138, 117)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(354, 37)
        Me.Label3.TabIndex = 105
        Me.Label3.Text = "Backup your database in 1 Click!"
        '
        'btnrestoreautonumber
        '
        Me.btnrestoreautonumber.AnimationHoverSpeed = 0.07!
        Me.btnrestoreautonumber.AnimationSpeed = 0.03!
        Me.btnrestoreautonumber.BackColor = System.Drawing.Color.Transparent
        Me.btnrestoreautonumber.BaseColor = System.Drawing.Color.Transparent
        Me.btnrestoreautonumber.BorderColor = System.Drawing.Color.FromArgb(CType(CType(158, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.btnrestoreautonumber.BorderSize = 2
        Me.btnrestoreautonumber.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnrestoreautonumber.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnrestoreautonumber.FocusedColor = System.Drawing.Color.Transparent
        Me.btnrestoreautonumber.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnrestoreautonumber.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnrestoreautonumber.Image = Nothing
        Me.btnrestoreautonumber.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnrestoreautonumber.Location = New System.Drawing.Point(201, 197)
        Me.btnrestoreautonumber.Name = "btnrestoreautonumber"
        Me.btnrestoreautonumber.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.btnrestoreautonumber.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(135, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(135, Byte), Integer))
        Me.btnrestoreautonumber.OnHoverForeColor = System.Drawing.Color.White
        Me.btnrestoreautonumber.OnHoverImage = Nothing
        Me.btnrestoreautonumber.OnPressedColor = System.Drawing.Color.FromArgb(CType(CType(88, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.btnrestoreautonumber.OnPressedDepth = 25
        Me.btnrestoreautonumber.Radius = 21
        Me.btnrestoreautonumber.Size = New System.Drawing.Size(226, 46)
        Me.btnrestoreautonumber.TabIndex = 101
        Me.btnrestoreautonumber.Text = "Restore default"
        Me.btnrestoreautonumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Guna2WinProgressIndicator1
        '
        Me.Guna2WinProgressIndicator1.BorderRadius = 11
        Me.Guna2WinProgressIndicator1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.Guna2WinProgressIndicator1.Location = New System.Drawing.Point(201, 355)
        Me.Guna2WinProgressIndicator1.Name = "Guna2WinProgressIndicator1"
        Me.Guna2WinProgressIndicator1.ProgressColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Guna2WinProgressIndicator1.ProgressColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Guna2WinProgressIndicator1.ShadowDecoration.Parent = Me.Guna2WinProgressIndicator1
        Me.Guna2WinProgressIndicator1.Size = New System.Drawing.Size(230, 28)
        Me.Guna2WinProgressIndicator1.TabIndex = 106
        Me.Guna2WinProgressIndicator1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        '
        'Backupdb
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(27, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(648, 523)
        Me.Controls.Add(Me.Guna2WinProgressIndicator1)
        Me.Controls.Add(Me.Guna2CustomGradientPanel1)
        Me.Controls.Add(Me.lblBackupNote)
        Me.Controls.Add(Me.ButtonDiscard)
        Me.Controls.Add(Me.btnrestoreautonumber)
        Me.Controls.Add(Me.btnbackup)
        Me.Controls.Add(Me.Label3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Backupdb"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Backupdb"
        Me.TopMost = True
        Me.Guna2CustomGradientPanel1.ResumeLayout(False)
        Me.Guna2CustomGradientPanel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2CustomGradientPanel1 As Guna.UI2.WinForms.Guna2CustomGradientPanel
    Friend WithEvents Label5 As Label
    Friend WithEvents lblBackupNote As Label
    Friend WithEvents ButtonDiscard As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnbackup As Guna.UI.WinForms.GunaButton
    Friend WithEvents Label3 As Label
    Friend WithEvents btnrestoreautonumber As Guna.UI.WinForms.GunaButton
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Guna2WinProgressIndicator1 As Guna.UI2.WinForms.Guna2ProgressBar
End Class
