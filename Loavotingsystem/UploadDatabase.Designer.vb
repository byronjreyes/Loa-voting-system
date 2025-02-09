<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UploadDatabase
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
        Me.OpenFileDialogDatabase = New System.Windows.Forms.OpenFileDialog()
        Me.BackgroundWorkerTestConnection = New System.ComponentModel.BackgroundWorker()
        Me.BackgroundWorkerUpload = New System.ComponentModel.BackgroundWorker()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Guna2Button2 = New Guna.UI2.WinForms.Guna2Button()
        Me.buttonimport = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Separator2 = New Guna.UI2.WinForms.Guna2Separator()
        Me.Guna2Separator1 = New Guna.UI2.WinForms.Guna2Separator()
        Me.CBVote = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.CBSection = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.CBYear = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.CBCourse = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.CBLastname = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.CBFirstname = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextDBPath = New Guna.UI2.WinForms.Guna2Button()
        Me.CBStudentID = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.CBTables = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PanelTestConnectionLoadng = New System.Windows.Forms.Panel()
        Me.Guna2GradientPanel1 = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Guna2GradientPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BackgroundWorkerTestConnection
        '
        Me.BackgroundWorkerTestConnection.WorkerReportsProgress = True
        '
        'BackgroundWorkerUpload
        '
        Me.BackgroundWorkerUpload.WorkerReportsProgress = True
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.AutoScrollMargin = New System.Drawing.Size(0, 20)
        Me.Panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.Guna2Button2)
        Me.Panel1.Controls.Add(Me.buttonimport)
        Me.Panel1.Controls.Add(Me.Guna2Separator2)
        Me.Panel1.Controls.Add(Me.Guna2Separator1)
        Me.Panel1.Controls.Add(Me.CBVote)
        Me.Panel1.Controls.Add(Me.CBSection)
        Me.Panel1.Controls.Add(Me.CBYear)
        Me.Panel1.Controls.Add(Me.CBCourse)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.CBLastname)
        Me.Panel1.Controls.Add(Me.CBFirstname)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.TextDBPath)
        Me.Panel1.Controls.Add(Me.CBStudentID)
        Me.Panel1.Controls.Add(Me.CBTables)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.PanelTestConnectionLoadng)
        Me.Panel1.Location = New System.Drawing.Point(22, 72)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(883, 528)
        Me.Panel1.TabIndex = 11
        '
        'Guna2Button2
        '
        Me.Guna2Button2.Animated = True
        Me.Guna2Button2.CheckedState.Parent = Me.Guna2Button2
        Me.Guna2Button2.CustomImages.Parent = Me.Guna2Button2
        Me.Guna2Button2.FillColor = System.Drawing.Color.Transparent
        Me.Guna2Button2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2Button2.ForeColor = System.Drawing.Color.DimGray
        Me.Guna2Button2.HoverState.Parent = Me.Guna2Button2
        Me.Guna2Button2.Location = New System.Drawing.Point(588, 466)
        Me.Guna2Button2.Name = "Guna2Button2"
        Me.Guna2Button2.ShadowDecoration.Parent = Me.Guna2Button2
        Me.Guna2Button2.Size = New System.Drawing.Size(99, 21)
        Me.Guna2Button2.TabIndex = 16
        Me.Guna2Button2.Text = "Cancel"
        '
        'buttonimport
        '
        Me.buttonimport.Animated = True
        Me.buttonimport.CheckedState.Parent = Me.buttonimport
        Me.buttonimport.CustomImages.Parent = Me.buttonimport
        Me.buttonimport.FillColor = System.Drawing.Color.FromArgb(CType(CType(199, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.buttonimport.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.buttonimport.ForeColor = System.Drawing.Color.Black
        Me.buttonimport.HoverState.Parent = Me.buttonimport
        Me.buttonimport.Location = New System.Drawing.Point(705, 453)
        Me.buttonimport.Name = "buttonimport"
        Me.buttonimport.ShadowDecoration.Parent = Me.buttonimport
        Me.buttonimport.Size = New System.Drawing.Size(173, 44)
        Me.buttonimport.TabIndex = 16
        Me.buttonimport.Text = "Start Import"
        '
        'Guna2Separator2
        '
        Me.Guna2Separator2.Location = New System.Drawing.Point(26, 427)
        Me.Guna2Separator2.Name = "Guna2Separator2"
        Me.Guna2Separator2.Size = New System.Drawing.Size(856, 10)
        Me.Guna2Separator2.TabIndex = 15
        '
        'Guna2Separator1
        '
        Me.Guna2Separator1.Location = New System.Drawing.Point(22, 123)
        Me.Guna2Separator1.Name = "Guna2Separator1"
        Me.Guna2Separator1.Size = New System.Drawing.Size(856, 10)
        Me.Guna2Separator1.TabIndex = 14
        '
        'CBVote
        '
        Me.CBVote.Animated = True
        Me.CBVote.BackColor = System.Drawing.Color.Transparent
        Me.CBVote.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CBVote.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBVote.FocusedColor = System.Drawing.Color.Empty
        Me.CBVote.FocusedState.Parent = Me.CBVote
        Me.CBVote.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.CBVote.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.CBVote.FormattingEnabled = True
        Me.CBVote.HoverState.Parent = Me.CBVote
        Me.CBVote.ItemHeight = 30
        Me.CBVote.ItemsAppearance.Parent = Me.CBVote
        Me.CBVote.Location = New System.Drawing.Point(614, 380)
        Me.CBVote.Name = "CBVote"
        Me.CBVote.ShadowDecoration.Parent = Me.CBVote
        Me.CBVote.Size = New System.Drawing.Size(268, 36)
        Me.CBVote.TabIndex = 13
        '
        'CBSection
        '
        Me.CBSection.Animated = True
        Me.CBSection.BackColor = System.Drawing.Color.Transparent
        Me.CBSection.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CBSection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBSection.FocusedColor = System.Drawing.Color.Empty
        Me.CBSection.FocusedState.Parent = Me.CBSection
        Me.CBSection.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.CBSection.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.CBSection.FormattingEnabled = True
        Me.CBSection.HoverState.Parent = Me.CBSection
        Me.CBSection.ItemHeight = 30
        Me.CBSection.ItemsAppearance.Parent = Me.CBSection
        Me.CBSection.Location = New System.Drawing.Point(614, 315)
        Me.CBSection.Name = "CBSection"
        Me.CBSection.ShadowDecoration.Parent = Me.CBSection
        Me.CBSection.Size = New System.Drawing.Size(268, 36)
        Me.CBSection.TabIndex = 13
        '
        'CBYear
        '
        Me.CBYear.Animated = True
        Me.CBYear.BackColor = System.Drawing.Color.Transparent
        Me.CBYear.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CBYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBYear.FocusedColor = System.Drawing.Color.Empty
        Me.CBYear.FocusedState.Parent = Me.CBYear
        Me.CBYear.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.CBYear.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.CBYear.FormattingEnabled = True
        Me.CBYear.HoverState.Parent = Me.CBYear
        Me.CBYear.ItemHeight = 30
        Me.CBYear.ItemsAppearance.Parent = Me.CBYear
        Me.CBYear.Location = New System.Drawing.Point(322, 315)
        Me.CBYear.Name = "CBYear"
        Me.CBYear.ShadowDecoration.Parent = Me.CBYear
        Me.CBYear.Size = New System.Drawing.Size(268, 36)
        Me.CBYear.TabIndex = 13
        '
        'CBCourse
        '
        Me.CBCourse.Animated = True
        Me.CBCourse.BackColor = System.Drawing.Color.Transparent
        Me.CBCourse.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CBCourse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBCourse.FocusedColor = System.Drawing.Color.Empty
        Me.CBCourse.FocusedState.Parent = Me.CBCourse
        Me.CBCourse.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.CBCourse.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.CBCourse.FormattingEnabled = True
        Me.CBCourse.HoverState.Parent = Me.CBCourse
        Me.CBCourse.ItemHeight = 30
        Me.CBCourse.ItemsAppearance.Parent = Me.CBCourse
        Me.CBCourse.Location = New System.Drawing.Point(25, 315)
        Me.CBCourse.Name = "CBCourse"
        Me.CBCourse.ShadowDecoration.Parent = Me.CBCourse
        Me.CBCourse.Size = New System.Drawing.Size(268, 36)
        Me.CBCourse.TabIndex = 13
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label13.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label13.Location = New System.Drawing.Point(610, 356)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(97, 21)
        Me.Label13.TabIndex = 12
        Me.Label13.Text = "VotingStatus"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label10.Location = New System.Drawing.Point(610, 291)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(61, 21)
        Me.Label10.TabIndex = 12
        Me.Label10.Text = "Section"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label9.Location = New System.Drawing.Point(318, 291)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(99, 21)
        Me.Label9.TabIndex = 12
        Me.Label9.Text = "Year Column"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label8.Location = New System.Drawing.Point(21, 291)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(118, 21)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "Course Column"
        '
        'CBLastname
        '
        Me.CBLastname.Animated = True
        Me.CBLastname.BackColor = System.Drawing.Color.Transparent
        Me.CBLastname.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CBLastname.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBLastname.FocusedColor = System.Drawing.Color.Empty
        Me.CBLastname.FocusedState.Parent = Me.CBLastname
        Me.CBLastname.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.CBLastname.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.CBLastname.FormattingEnabled = True
        Me.CBLastname.HoverState.Parent = Me.CBLastname
        Me.CBLastname.ItemHeight = 30
        Me.CBLastname.ItemsAppearance.Parent = Me.CBLastname
        Me.CBLastname.Location = New System.Drawing.Point(614, 236)
        Me.CBLastname.Name = "CBLastname"
        Me.CBLastname.ShadowDecoration.Parent = Me.CBLastname
        Me.CBLastname.Size = New System.Drawing.Size(268, 36)
        Me.CBLastname.TabIndex = 11
        '
        'CBFirstname
        '
        Me.CBFirstname.Animated = True
        Me.CBFirstname.BackColor = System.Drawing.Color.Transparent
        Me.CBFirstname.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CBFirstname.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBFirstname.FocusedColor = System.Drawing.Color.Empty
        Me.CBFirstname.FocusedState.Parent = Me.CBFirstname
        Me.CBFirstname.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.CBFirstname.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.CBFirstname.FormattingEnabled = True
        Me.CBFirstname.HoverState.Parent = Me.CBFirstname
        Me.CBFirstname.ItemHeight = 30
        Me.CBFirstname.ItemsAppearance.Parent = Me.CBFirstname
        Me.CBFirstname.Location = New System.Drawing.Point(322, 236)
        Me.CBFirstname.Name = "CBFirstname"
        Me.CBFirstname.ShadowDecoration.Parent = Me.CBFirstname
        Me.CBFirstname.Size = New System.Drawing.Size(268, 36)
        Me.CBFirstname.TabIndex = 11
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label7.Location = New System.Drawing.Point(610, 212)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(136, 21)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Lastname Column"
        '
        'TextDBPath
        '
        Me.TextDBPath.Animated = True
        Me.TextDBPath.BackColor = System.Drawing.Color.Transparent
        Me.TextDBPath.BorderColor = System.Drawing.Color.LightGray
        Me.TextDBPath.BorderThickness = 1
        Me.TextDBPath.CheckedState.Parent = Me.TextDBPath
        Me.TextDBPath.CustomImages.Parent = Me.TextDBPath
        Me.TextDBPath.FillColor = System.Drawing.Color.White
        Me.TextDBPath.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TextDBPath.ForeColor = System.Drawing.Color.DimGray
        Me.TextDBPath.HoverState.Parent = Me.TextDBPath
        Me.TextDBPath.Location = New System.Drawing.Point(26, 51)
        Me.TextDBPath.Name = "TextDBPath"
        Me.TextDBPath.ShadowDecoration.Parent = Me.TextDBPath
        Me.TextDBPath.Size = New System.Drawing.Size(408, 35)
        Me.TextDBPath.TabIndex = 9
        Me.TextDBPath.Text = "Click here to Upload database"
        Me.TextDBPath.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'CBStudentID
        '
        Me.CBStudentID.Animated = True
        Me.CBStudentID.BackColor = System.Drawing.Color.Transparent
        Me.CBStudentID.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CBStudentID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBStudentID.FocusedColor = System.Drawing.Color.Empty
        Me.CBStudentID.FocusedState.Parent = Me.CBStudentID
        Me.CBStudentID.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.CBStudentID.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.CBStudentID.FormattingEnabled = True
        Me.CBStudentID.HoverState.Parent = Me.CBStudentID
        Me.CBStudentID.ItemHeight = 30
        Me.CBStudentID.ItemsAppearance.Parent = Me.CBStudentID
        Me.CBStudentID.Location = New System.Drawing.Point(22, 236)
        Me.CBStudentID.Name = "CBStudentID"
        Me.CBStudentID.ShadowDecoration.Parent = Me.CBStudentID
        Me.CBStudentID.Size = New System.Drawing.Size(268, 36)
        Me.CBStudentID.TabIndex = 8
        '
        'CBTables
        '
        Me.CBTables.Animated = True
        Me.CBTables.BackColor = System.Drawing.Color.Transparent
        Me.CBTables.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CBTables.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBTables.FocusedColor = System.Drawing.Color.Empty
        Me.CBTables.FocusedState.Parent = Me.CBTables
        Me.CBTables.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.CBTables.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.CBTables.FormattingEnabled = True
        Me.CBTables.HoverState.Parent = Me.CBTables
        Me.CBTables.ItemHeight = 30
        Me.CBTables.ItemsAppearance.Parent = Me.CBTables
        Me.CBTables.Location = New System.Drawing.Point(22, 159)
        Me.CBTables.Name = "CBTables"
        Me.CBTables.ShadowDecoration.Parent = Me.CBTables
        Me.CBTables.Size = New System.Drawing.Size(856, 36)
        Me.CBTables.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(18, 212)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(137, 21)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "StudentID Column"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(18, 135)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(147, 21)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Select Student Table"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(22, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 21)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Upload File"
        '
        'PanelTestConnectionLoadng
        '
        Me.PanelTestConnectionLoadng.AutoSize = True
        Me.PanelTestConnectionLoadng.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.PanelTestConnectionLoadng.BackColor = System.Drawing.Color.Transparent
        Me.PanelTestConnectionLoadng.Location = New System.Drawing.Point(22, 87)
        Me.PanelTestConnectionLoadng.Name = "PanelTestConnectionLoadng"
        Me.PanelTestConnectionLoadng.Size = New System.Drawing.Size(0, 0)
        Me.PanelTestConnectionLoadng.TabIndex = 6
        Me.PanelTestConnectionLoadng.Visible = False
        '
        'Guna2GradientPanel1
        '
        Me.Guna2GradientPanel1.Controls.Add(Me.Label1)
        Me.Guna2GradientPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2GradientPanel1.FillColor = System.Drawing.Color.FromArgb(CType(CType(173, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.Guna2GradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Guna2GradientPanel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2GradientPanel1.Name = "Guna2GradientPanel1"
        Me.Guna2GradientPanel1.ShadowDecoration.Parent = Me.Guna2GradientPanel1
        Me.Guna2GradientPanel1.Size = New System.Drawing.Size(936, 66)
        Me.Guna2GradientPanel1.TabIndex = 33
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Poppins", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(443, 56)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Upload Student Database"
        '
        'UploadDatabase
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(936, 622)
        Me.Controls.Add(Me.Guna2GradientPanel1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "UploadDatabase"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "UploadDatabase"
        Me.TopMost = True
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Guna2GradientPanel1.ResumeLayout(False)
        Me.Guna2GradientPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents OpenFileDialogDatabase As OpenFileDialog
    Friend WithEvents BackgroundWorkerTestConnection As System.ComponentModel.BackgroundWorker
    Friend WithEvents BackgroundWorkerUpload As System.ComponentModel.BackgroundWorker
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Guna2Button2 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents buttonimport As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Separator2 As Guna.UI2.WinForms.Guna2Separator
    Friend WithEvents Guna2Separator1 As Guna.UI2.WinForms.Guna2Separator
    Friend WithEvents CBVote As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents CBSection As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents CBYear As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents CBCourse As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents CBLastname As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents CBFirstname As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TextDBPath As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents CBStudentID As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents CBTables As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PanelTestConnectionLoadng As Panel
    Friend WithEvents Guna2GradientPanel1 As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents Label1 As Label
End Class
