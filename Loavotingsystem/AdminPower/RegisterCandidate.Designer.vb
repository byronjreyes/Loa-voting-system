<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegisterCandidate
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.ButtonDiscard = New Guna.UI2.WinForms.Guna2Button()
        Me.ButtonRegister = New Guna.UI2.WinForms.Guna2Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblSectionValidation = New System.Windows.Forms.Label()
        Me.lblYearLevelValidation = New System.Windows.Forms.Label()
        Me.lblLastNameValidation = New System.Windows.Forms.Label()
        Me.lblFirstNameValidation = New System.Windows.Forms.Label()
        Me.lblStudentIDValidation = New System.Windows.Forms.Label()
        Me.Guna2GradientPanel1 = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.lblCourseValidation = New System.Windows.Forms.Label()
        Me.Guna2HtmlLabel7 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.CBSection = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Guna2HtmlLabel6 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.CBCourse = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.ErrorCourse = New System.Windows.Forms.Label()
        Me.CBYear = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Guna2HtmlLabel5 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.TextLastname = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2HtmlLabel4 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.TextFirstname = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2HtmlLabel3 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.TextStudentID = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.LabelLRN = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.txtrepresentative = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Guna2HtmlLabel9 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.txtposition = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Guna2HtmlLabel8 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ButtonClear = New Guna.UI2.WinForms.Guna2Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Guna2HtmlLabel10 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.txttagline = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Guna2Separator2 = New Guna.UI2.WinForms.Guna2Separator()
        Me.Guna2GradientPanel1.SuspendLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtonDiscard
        '
        Me.ButtonDiscard.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonDiscard.Animated = True
        Me.ButtonDiscard.CheckedState.Parent = Me.ButtonDiscard
        Me.ButtonDiscard.CustomImages.Parent = Me.ButtonDiscard
        Me.ButtonDiscard.FillColor = System.Drawing.Color.Transparent
        Me.ButtonDiscard.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.ButtonDiscard.ForeColor = System.Drawing.Color.Gray
        Me.ButtonDiscard.HoverState.Parent = Me.ButtonDiscard
        Me.ButtonDiscard.Location = New System.Drawing.Point(34, 607)
        Me.ButtonDiscard.Name = "ButtonDiscard"
        Me.ButtonDiscard.ShadowDecoration.Parent = Me.ButtonDiscard
        Me.ButtonDiscard.Size = New System.Drawing.Size(341, 38)
        Me.ButtonDiscard.TabIndex = 1
        Me.ButtonDiscard.Text = "Discard"
        '
        'ButtonRegister
        '
        Me.ButtonRegister.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonRegister.CheckedState.Parent = Me.ButtonRegister
        Me.ButtonRegister.CustomImages.Parent = Me.ButtonRegister
        Me.ButtonRegister.FillColor = System.Drawing.Color.FromArgb(CType(CType(199, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.ButtonRegister.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.ButtonRegister.ForeColor = System.Drawing.Color.White
        Me.ButtonRegister.HoverState.Parent = Me.ButtonRegister
        Me.ButtonRegister.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.ButtonRegister.ImageOffset = New System.Drawing.Point(1, 1)
        Me.ButtonRegister.ImageSize = New System.Drawing.Size(15, 15)
        Me.ButtonRegister.Location = New System.Drawing.Point(465, 607)
        Me.ButtonRegister.Name = "ButtonRegister"
        Me.ButtonRegister.ShadowDecoration.Parent = Me.ButtonRegister
        Me.ButtonRegister.Size = New System.Drawing.Size(315, 38)
        Me.ButtonRegister.TabIndex = 0
        Me.ButtonRegister.Text = "Register"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Poppins", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label4.Location = New System.Drawing.Point(12, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(336, 56)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Register Candidate"
        '
        'lblSectionValidation
        '
        Me.lblSectionValidation.AutoSize = True
        Me.lblSectionValidation.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSectionValidation.ForeColor = System.Drawing.Color.Red
        Me.lblSectionValidation.Location = New System.Drawing.Point(516, 187)
        Me.lblSectionValidation.Name = "lblSectionValidation"
        Me.lblSectionValidation.Size = New System.Drawing.Size(0, 23)
        Me.lblSectionValidation.TabIndex = 80
        '
        'lblYearLevelValidation
        '
        Me.lblYearLevelValidation.AutoSize = True
        Me.lblYearLevelValidation.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblYearLevelValidation.ForeColor = System.Drawing.Color.Red
        Me.lblYearLevelValidation.Location = New System.Drawing.Point(208, 460)
        Me.lblYearLevelValidation.Name = "lblYearLevelValidation"
        Me.lblYearLevelValidation.Size = New System.Drawing.Size(0, 23)
        Me.lblYearLevelValidation.TabIndex = 78
        '
        'lblLastNameValidation
        '
        Me.lblLastNameValidation.AutoSize = True
        Me.lblLastNameValidation.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLastNameValidation.ForeColor = System.Drawing.Color.Red
        Me.lblLastNameValidation.Location = New System.Drawing.Point(208, 374)
        Me.lblLastNameValidation.Name = "lblLastNameValidation"
        Me.lblLastNameValidation.Size = New System.Drawing.Size(0, 23)
        Me.lblLastNameValidation.TabIndex = 77
        '
        'lblFirstNameValidation
        '
        Me.lblFirstNameValidation.AutoSize = True
        Me.lblFirstNameValidation.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFirstNameValidation.ForeColor = System.Drawing.Color.Red
        Me.lblFirstNameValidation.Location = New System.Drawing.Point(208, 281)
        Me.lblFirstNameValidation.Name = "lblFirstNameValidation"
        Me.lblFirstNameValidation.Size = New System.Drawing.Size(0, 23)
        Me.lblFirstNameValidation.TabIndex = 76
        '
        'lblStudentIDValidation
        '
        Me.lblStudentIDValidation.AutoSize = True
        Me.lblStudentIDValidation.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStudentIDValidation.ForeColor = System.Drawing.Color.Red
        Me.lblStudentIDValidation.Location = New System.Drawing.Point(208, 189)
        Me.lblStudentIDValidation.Name = "lblStudentIDValidation"
        Me.lblStudentIDValidation.Size = New System.Drawing.Size(0, 23)
        Me.lblStudentIDValidation.TabIndex = 75
        '
        'Guna2GradientPanel1
        '
        Me.Guna2GradientPanel1.Controls.Add(Me.Label4)
        Me.Guna2GradientPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2GradientPanel1.FillColor = System.Drawing.Color.FromArgb(CType(CType(173, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.Guna2GradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Guna2GradientPanel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2GradientPanel1.Name = "Guna2GradientPanel1"
        Me.Guna2GradientPanel1.ShadowDecoration.Parent = Me.Guna2GradientPanel1
        Me.Guna2GradientPanel1.Size = New System.Drawing.Size(804, 66)
        Me.Guna2GradientPanel1.TabIndex = 73
        '
        'lblCourseValidation
        '
        Me.lblCourseValidation.AutoSize = True
        Me.lblCourseValidation.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCourseValidation.ForeColor = System.Drawing.Color.Red
        Me.lblCourseValidation.Location = New System.Drawing.Point(203, 539)
        Me.lblCourseValidation.Name = "lblCourseValidation"
        Me.lblCourseValidation.Size = New System.Drawing.Size(0, 23)
        Me.lblCourseValidation.TabIndex = 79
        '
        'Guna2HtmlLabel7
        '
        Me.Guna2HtmlLabel7.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel7.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.Guna2HtmlLabel7.ForeColor = System.Drawing.Color.Black
        Me.Guna2HtmlLabel7.Location = New System.Drawing.Point(502, 118)
        Me.Guna2HtmlLabel7.Name = "Guna2HtmlLabel7"
        Me.Guna2HtmlLabel7.Size = New System.Drawing.Size(69, 27)
        Me.Guna2HtmlLabel7.TabIndex = 67
        Me.Guna2HtmlLabel7.Text = "Section:"
        '
        'CBSection
        '
        Me.CBSection.BackColor = System.Drawing.Color.Transparent
        Me.CBSection.BorderRadius = 5
        Me.CBSection.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CBSection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBSection.FocusedColor = System.Drawing.Color.Empty
        Me.CBSection.FocusedState.Parent = Me.CBSection
        Me.CBSection.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.CBSection.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.CBSection.FormattingEnabled = True
        Me.CBSection.HoverState.Parent = Me.CBSection
        Me.CBSection.ItemHeight = 30
        Me.CBSection.Items.AddRange(New Object() {"11A1", "11A2", "11A3", "11A4", "21A1", "21A2", "21A3", "21A4", "31A1", "31A2", "31A3", "41A1", "41A2", "41A3", "41A4"})
        Me.CBSection.ItemsAppearance.Parent = Me.CBSection
        Me.CBSection.Location = New System.Drawing.Point(502, 148)
        Me.CBSection.Name = "CBSection"
        Me.CBSection.ShadowDecoration.Parent = Me.CBSection
        Me.CBSection.Size = New System.Drawing.Size(278, 36)
        Me.CBSection.TabIndex = 72
        '
        'Guna2HtmlLabel6
        '
        Me.Guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel6.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.Guna2HtmlLabel6.ForeColor = System.Drawing.Color.Black
        Me.Guna2HtmlLabel6.Location = New System.Drawing.Point(189, 473)
        Me.Guna2HtmlLabel6.Name = "Guna2HtmlLabel6"
        Me.Guna2HtmlLabel6.Size = New System.Drawing.Size(66, 27)
        Me.Guna2HtmlLabel6.TabIndex = 69
        Me.Guna2HtmlLabel6.Text = "Course:"
        '
        'CBCourse
        '
        Me.CBCourse.BackColor = System.Drawing.Color.Transparent
        Me.CBCourse.BorderRadius = 5
        Me.CBCourse.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CBCourse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBCourse.FocusedColor = System.Drawing.Color.Empty
        Me.CBCourse.FocusedState.Parent = Me.CBCourse
        Me.CBCourse.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.CBCourse.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.CBCourse.FormattingEnabled = True
        Me.CBCourse.HoverState.Parent = Me.CBCourse
        Me.CBCourse.ItemHeight = 30
        Me.CBCourse.Items.AddRange(New Object() {"BS Accountancy", "BS Business Administration", "BS Custom Administration", "BS Information Technology", "BS Computer Science", "BS Industrial Engineering", "BS Computer Engineering", "BS Tourism Management", "BS Hospitality Management", "College of Education", "College of Psychology", "College of Criminal Justice", "Real Estate Management", "Technology Department"})
        Me.CBCourse.ItemsAppearance.Parent = Me.CBCourse
        Me.CBCourse.Location = New System.Drawing.Point(189, 500)
        Me.CBCourse.Name = "CBCourse"
        Me.CBCourse.ShadowDecoration.Parent = Me.CBCourse
        Me.CBCourse.Size = New System.Drawing.Size(278, 36)
        Me.CBCourse.TabIndex = 71
        '
        'ErrorCourse
        '
        Me.ErrorCourse.AutoSize = True
        Me.ErrorCourse.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.ErrorCourse.ForeColor = System.Drawing.Color.Red
        Me.ErrorCourse.Location = New System.Drawing.Point(204, 531)
        Me.ErrorCourse.Margin = New System.Windows.Forms.Padding(3, 0, 3, 10)
        Me.ErrorCourse.Name = "ErrorCourse"
        Me.ErrorCourse.Size = New System.Drawing.Size(0, 13)
        Me.ErrorCourse.TabIndex = 70
        '
        'CBYear
        '
        Me.CBYear.BackColor = System.Drawing.Color.Transparent
        Me.CBYear.BorderRadius = 5
        Me.CBYear.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CBYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBYear.FocusedColor = System.Drawing.Color.Empty
        Me.CBYear.FocusedState.Parent = Me.CBYear
        Me.CBYear.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.CBYear.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.CBYear.FormattingEnabled = True
        Me.CBYear.HoverState.Parent = Me.CBYear
        Me.CBYear.ItemHeight = 30
        Me.CBYear.Items.AddRange(New Object() {"1st-year", "2nd-year", "3rd-year", "4th-year"})
        Me.CBYear.ItemsAppearance.Parent = Me.CBYear
        Me.CBYear.Location = New System.Drawing.Point(189, 421)
        Me.CBYear.Name = "CBYear"
        Me.CBYear.ShadowDecoration.Parent = Me.CBYear
        Me.CBYear.Size = New System.Drawing.Size(278, 36)
        Me.CBYear.TabIndex = 66
        '
        'Guna2HtmlLabel5
        '
        Me.Guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel5.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.Guna2HtmlLabel5.ForeColor = System.Drawing.Color.Black
        Me.Guna2HtmlLabel5.Location = New System.Drawing.Point(189, 391)
        Me.Guna2HtmlLabel5.Margin = New System.Windows.Forms.Padding(3, 3, 3, 0)
        Me.Guna2HtmlLabel5.Name = "Guna2HtmlLabel5"
        Me.Guna2HtmlLabel5.Size = New System.Drawing.Size(93, 27)
        Me.Guna2HtmlLabel5.TabIndex = 57
        Me.Guna2HtmlLabel5.Text = "Year Level:"
        '
        'TextLastname
        '
        Me.TextLastname.BorderRadius = 5
        Me.TextLastname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TextLastname.DefaultText = ""
        Me.TextLastname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TextLastname.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TextLastname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TextLastname.DisabledState.Parent = Me.TextLastname
        Me.TextLastname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TextLastname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TextLastname.FocusedState.Parent = Me.TextLastname
        Me.TextLastname.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TextLastname.HoverState.Parent = Me.TextLastname
        Me.TextLastname.Location = New System.Drawing.Point(189, 334)
        Me.TextLastname.Margin = New System.Windows.Forms.Padding(7, 8, 7, 8)
        Me.TextLastname.Name = "TextLastname"
        Me.TextLastname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TextLastname.PlaceholderText = ""
        Me.TextLastname.SelectedText = ""
        Me.TextLastname.ShadowDecoration.Parent = Me.TextLastname
        Me.TextLastname.Size = New System.Drawing.Size(278, 32)
        Me.TextLastname.TabIndex = 65
        '
        'Guna2HtmlLabel4
        '
        Me.Guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel4.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.Guna2HtmlLabel4.ForeColor = System.Drawing.Color.Black
        Me.Guna2HtmlLabel4.Location = New System.Drawing.Point(189, 304)
        Me.Guna2HtmlLabel4.Margin = New System.Windows.Forms.Padding(3, 3, 3, 0)
        Me.Guna2HtmlLabel4.Name = "Guna2HtmlLabel4"
        Me.Guna2HtmlLabel4.Size = New System.Drawing.Size(87, 27)
        Me.Guna2HtmlLabel4.TabIndex = 58
        Me.Guna2HtmlLabel4.Text = "Lastname:"
        '
        'TextFirstname
        '
        Me.TextFirstname.BorderRadius = 5
        Me.TextFirstname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TextFirstname.DefaultText = ""
        Me.TextFirstname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TextFirstname.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TextFirstname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TextFirstname.DisabledState.Parent = Me.TextFirstname
        Me.TextFirstname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TextFirstname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TextFirstname.FocusedState.Parent = Me.TextFirstname
        Me.TextFirstname.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TextFirstname.HoverState.Parent = Me.TextFirstname
        Me.TextFirstname.Location = New System.Drawing.Point(189, 241)
        Me.TextFirstname.Margin = New System.Windows.Forms.Padding(7, 8, 7, 8)
        Me.TextFirstname.Name = "TextFirstname"
        Me.TextFirstname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TextFirstname.PlaceholderText = ""
        Me.TextFirstname.SelectedText = ""
        Me.TextFirstname.ShadowDecoration.Parent = Me.TextFirstname
        Me.TextFirstname.Size = New System.Drawing.Size(278, 32)
        Me.TextFirstname.TabIndex = 64
        '
        'Guna2HtmlLabel3
        '
        Me.Guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel3.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.Guna2HtmlLabel3.ForeColor = System.Drawing.Color.Black
        Me.Guna2HtmlLabel3.Location = New System.Drawing.Point(189, 211)
        Me.Guna2HtmlLabel3.Margin = New System.Windows.Forms.Padding(3, 3, 3, 0)
        Me.Guna2HtmlLabel3.Name = "Guna2HtmlLabel3"
        Me.Guna2HtmlLabel3.Size = New System.Drawing.Size(89, 27)
        Me.Guna2HtmlLabel3.TabIndex = 59
        Me.Guna2HtmlLabel3.Text = "Firstname:"
        '
        'TextStudentID
        '
        Me.TextStudentID.BorderRadius = 5
        Me.TextStudentID.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TextStudentID.DefaultText = ""
        Me.TextStudentID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TextStudentID.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TextStudentID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TextStudentID.DisabledState.Parent = Me.TextStudentID
        Me.TextStudentID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TextStudentID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TextStudentID.FocusedState.Parent = Me.TextStudentID
        Me.TextStudentID.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TextStudentID.HoverState.Parent = Me.TextStudentID
        Me.TextStudentID.Location = New System.Drawing.Point(189, 148)
        Me.TextStudentID.Margin = New System.Windows.Forms.Padding(7, 8, 7, 8)
        Me.TextStudentID.Name = "TextStudentID"
        Me.TextStudentID.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TextStudentID.PlaceholderText = ""
        Me.TextStudentID.SelectedText = ""
        Me.TextStudentID.ShadowDecoration.Parent = Me.TextStudentID
        Me.TextStudentID.Size = New System.Drawing.Size(278, 33)
        Me.TextStudentID.TabIndex = 63
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.Guna2HtmlLabel1.ForeColor = System.Drawing.Color.Black
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(190, 87)
        Me.Guna2HtmlLabel1.Margin = New System.Windows.Forms.Padding(3, 3, 3, 0)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(112, 27)
        Me.Guna2HtmlLabel1.TabIndex = 62
        Me.Guna2HtmlLabel1.Text = "LRN number:"
        '
        'LabelLRN
        '
        Me.LabelLRN.BackColor = System.Drawing.Color.Transparent
        Me.LabelLRN.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.LabelLRN.ForeColor = System.Drawing.Color.Black
        Me.LabelLRN.Location = New System.Drawing.Point(308, 88)
        Me.LabelLRN.Margin = New System.Windows.Forms.Padding(3, 3, 3, 0)
        Me.LabelLRN.Name = "LabelLRN"
        Me.LabelLRN.Size = New System.Drawing.Size(67, 27)
        Me.LabelLRN.TabIndex = 60
        Me.LabelLRN.Text = "********"
        '
        'Guna2HtmlLabel2
        '
        Me.Guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel2.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.Guna2HtmlLabel2.ForeColor = System.Drawing.Color.Black
        Me.Guna2HtmlLabel2.Location = New System.Drawing.Point(189, 118)
        Me.Guna2HtmlLabel2.Margin = New System.Windows.Forms.Padding(3, 3, 3, 0)
        Me.Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
        Me.Guna2HtmlLabel2.Size = New System.Drawing.Size(91, 27)
        Me.Guna2HtmlLabel2.TabIndex = 61
        Me.Guna2HtmlLabel2.Text = "Student ID"
        '
        'txtrepresentative
        '
        Me.txtrepresentative.BackColor = System.Drawing.Color.Transparent
        Me.txtrepresentative.BorderRadius = 5
        Me.txtrepresentative.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.txtrepresentative.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtrepresentative.FocusedColor = System.Drawing.Color.Empty
        Me.txtrepresentative.FocusedState.Parent = Me.txtrepresentative
        Me.txtrepresentative.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtrepresentative.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.txtrepresentative.FormattingEnabled = True
        Me.txtrepresentative.HoverState.Parent = Me.txtrepresentative
        Me.txtrepresentative.ItemHeight = 30
        Me.txtrepresentative.Items.AddRange(New Object() {"Business Management Education", "College of Computer Studies", "College of Engineering", "College of Tourism and Hospitality Management"})
        Me.txtrepresentative.ItemsAppearance.Parent = Me.txtrepresentative
        Me.txtrepresentative.Location = New System.Drawing.Point(502, 243)
        Me.txtrepresentative.Name = "txtrepresentative"
        Me.txtrepresentative.ShadowDecoration.Parent = Me.txtrepresentative
        Me.txtrepresentative.Size = New System.Drawing.Size(278, 36)
        Me.txtrepresentative.TabIndex = 72
        '
        'Guna2HtmlLabel9
        '
        Me.Guna2HtmlLabel9.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel9.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.Guna2HtmlLabel9.ForeColor = System.Drawing.Color.Black
        Me.Guna2HtmlLabel9.Location = New System.Drawing.Point(502, 213)
        Me.Guna2HtmlLabel9.Name = "Guna2HtmlLabel9"
        Me.Guna2HtmlLabel9.Size = New System.Drawing.Size(139, 27)
        Me.Guna2HtmlLabel9.TabIndex = 67
        Me.Guna2HtmlLabel9.Text = "Representatives:"
        '
        'txtposition
        '
        Me.txtposition.BackColor = System.Drawing.Color.Transparent
        Me.txtposition.BorderRadius = 5
        Me.txtposition.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.txtposition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtposition.FocusedColor = System.Drawing.Color.Empty
        Me.txtposition.FocusedState.Parent = Me.txtposition
        Me.txtposition.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtposition.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.txtposition.FormattingEnabled = True
        Me.txtposition.HoverState.Parent = Me.txtposition
        Me.txtposition.ItemHeight = 30
        Me.txtposition.Items.AddRange(New Object() {"PRESIDENT ", "EXECUTIVE VICE PRESIDENT ", "VP FINANCE", "VP ACTIVITIES", "VP COMMUNICATION AND MARKETING ", "VP DOCUMENTATION"})
        Me.txtposition.ItemsAppearance.Parent = Me.txtposition
        Me.txtposition.Location = New System.Drawing.Point(502, 330)
        Me.txtposition.Name = "txtposition"
        Me.txtposition.ShadowDecoration.Parent = Me.txtposition
        Me.txtposition.Size = New System.Drawing.Size(278, 36)
        Me.txtposition.TabIndex = 72
        '
        'Guna2HtmlLabel8
        '
        Me.Guna2HtmlLabel8.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel8.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.Guna2HtmlLabel8.ForeColor = System.Drawing.Color.Black
        Me.Guna2HtmlLabel8.Location = New System.Drawing.Point(502, 304)
        Me.Guna2HtmlLabel8.Name = "Guna2HtmlLabel8"
        Me.Guna2HtmlLabel8.Size = New System.Drawing.Size(75, 27)
        Me.Guna2HtmlLabel8.TabIndex = 67
        Me.Guna2HtmlLabel8.Text = "Position:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(515, 281)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 23)
        Me.Label1.TabIndex = 81
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(515, 374)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 23)
        Me.Label2.TabIndex = 82
        '
        'ButtonClear
        '
        Me.ButtonClear.Animated = True
        Me.ButtonClear.CheckedState.Parent = Me.ButtonClear
        Me.ButtonClear.CustomImages.Parent = Me.ButtonClear
        Me.ButtonClear.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.ButtonClear.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ButtonClear.ForeColor = System.Drawing.Color.White
        Me.ButtonClear.HoverState.Parent = Me.ButtonClear
        Me.ButtonClear.Location = New System.Drawing.Point(22, 247)
        Me.ButtonClear.Name = "ButtonClear"
        Me.ButtonClear.ShadowDecoration.Parent = Me.ButtonClear
        Me.ButtonClear.Size = New System.Drawing.Size(137, 32)
        Me.ButtonClear.TabIndex = 84
        Me.ButtonClear.Text = "Clear Picture"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Guna2HtmlLabel10
        '
        Me.Guna2HtmlLabel10.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel10.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.Guna2HtmlLabel10.ForeColor = System.Drawing.Color.Black
        Me.Guna2HtmlLabel10.Location = New System.Drawing.Point(502, 391)
        Me.Guna2HtmlLabel10.Name = "Guna2HtmlLabel10"
        Me.Guna2HtmlLabel10.Size = New System.Drawing.Size(159, 27)
        Me.Guna2HtmlLabel10.TabIndex = 67
        Me.Guna2HtmlLabel10.Text = "Tagline: (Optional)"
        '
        'txttagline
        '
        Me.txttagline.BorderRadius = 5
        Me.txttagline.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txttagline.DefaultText = ""
        Me.txttagline.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txttagline.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txttagline.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txttagline.DisabledState.Parent = Me.txttagline
        Me.txttagline.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txttagline.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txttagline.FocusedState.Parent = Me.txttagline
        Me.txttagline.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txttagline.HoverState.Parent = Me.txttagline
        Me.txttagline.Location = New System.Drawing.Point(502, 421)
        Me.txttagline.Margin = New System.Windows.Forms.Padding(7, 8, 7, 8)
        Me.txttagline.Name = "txttagline"
        Me.txttagline.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txttagline.PlaceholderText = ""
        Me.txttagline.SelectedText = ""
        Me.txttagline.ShadowDecoration.Parent = Me.txttagline
        Me.txttagline.Size = New System.Drawing.Size(278, 33)
        Me.txttagline.TabIndex = 85
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.BackColor = System.Drawing.Color.White
        Me.Guna2PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Guna2PictureBox1.FillColor = System.Drawing.Color.White
        Me.Guna2PictureBox1.Image = Global.Loavotingsystem.My.Resources.Resources._error
        Me.Guna2PictureBox1.ImageLocation = ""
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(22, 88)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.ShadowDecoration.Parent = Me.Guna2PictureBox1
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(137, 137)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2PictureBox1.TabIndex = 83
        Me.Guna2PictureBox1.TabStop = False
        '
        'Guna2Separator2
        '
        Me.Guna2Separator2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Separator2.FillThickness = 2
        Me.Guna2Separator2.Location = New System.Drawing.Point(-37, 593)
        Me.Guna2Separator2.Name = "Guna2Separator2"
        Me.Guna2Separator2.Size = New System.Drawing.Size(863, 8)
        Me.Guna2Separator2.TabIndex = 86
        '
        'RegisterCandidate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(804, 666)
        Me.Controls.Add(Me.Guna2Separator2)
        Me.Controls.Add(Me.ButtonDiscard)
        Me.Controls.Add(Me.txttagline)
        Me.Controls.Add(Me.ButtonRegister)
        Me.Controls.Add(Me.Guna2PictureBox1)
        Me.Controls.Add(Me.ButtonClear)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblSectionValidation)
        Me.Controls.Add(Me.lblYearLevelValidation)
        Me.Controls.Add(Me.lblLastNameValidation)
        Me.Controls.Add(Me.lblFirstNameValidation)
        Me.Controls.Add(Me.lblStudentIDValidation)
        Me.Controls.Add(Me.Guna2GradientPanel1)
        Me.Controls.Add(Me.lblCourseValidation)
        Me.Controls.Add(Me.Guna2HtmlLabel10)
        Me.Controls.Add(Me.Guna2HtmlLabel8)
        Me.Controls.Add(Me.txtposition)
        Me.Controls.Add(Me.Guna2HtmlLabel9)
        Me.Controls.Add(Me.txtrepresentative)
        Me.Controls.Add(Me.Guna2HtmlLabel7)
        Me.Controls.Add(Me.CBSection)
        Me.Controls.Add(Me.Guna2HtmlLabel6)
        Me.Controls.Add(Me.CBCourse)
        Me.Controls.Add(Me.ErrorCourse)
        Me.Controls.Add(Me.CBYear)
        Me.Controls.Add(Me.Guna2HtmlLabel5)
        Me.Controls.Add(Me.TextLastname)
        Me.Controls.Add(Me.Guna2HtmlLabel4)
        Me.Controls.Add(Me.TextFirstname)
        Me.Controls.Add(Me.Guna2HtmlLabel3)
        Me.Controls.Add(Me.TextStudentID)
        Me.Controls.Add(Me.Guna2HtmlLabel1)
        Me.Controls.Add(Me.LabelLRN)
        Me.Controls.Add(Me.Guna2HtmlLabel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "RegisterCandidate"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RegisterCandidate"
        Me.TopMost = True
        Me.Guna2GradientPanel1.ResumeLayout(False)
        Me.Guna2GradientPanel1.PerformLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ButtonDiscard As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents ButtonRegister As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label4 As Label
    Friend WithEvents lblSectionValidation As Label
    Friend WithEvents lblYearLevelValidation As Label
    Friend WithEvents lblLastNameValidation As Label
    Friend WithEvents lblFirstNameValidation As Label
    Friend WithEvents lblStudentIDValidation As Label
    Friend WithEvents Guna2GradientPanel1 As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents lblCourseValidation As Label
    Friend WithEvents Guna2HtmlLabel7 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents CBSection As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Guna2HtmlLabel6 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents CBCourse As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents ErrorCourse As Label
    Friend WithEvents CBYear As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Guna2HtmlLabel5 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents TextLastname As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel4 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents TextFirstname As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel3 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents TextStudentID As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents LabelLRN As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents txtrepresentative As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Guna2HtmlLabel9 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents txtposition As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Guna2HtmlLabel8 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents ButtonClear As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents Guna2HtmlLabel10 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents txttagline As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2Separator2 As Guna.UI2.WinForms.Guna2Separator
End Class
