<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AddVoters
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
        Me.CBYear = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Guna2HtmlLabel5 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.TextLastname = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2HtmlLabel4 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.TextFirstname = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2HtmlLabel3 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.TextStudentID = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel7 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.CBSection = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Guna2HtmlLabel6 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.ButtonDiscard = New Guna.UI2.WinForms.Guna2Button()
        Me.ButtonSubmit = New Guna.UI2.WinForms.Guna2Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Guna2GradientPanel1 = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.lblStudentIDValidation = New System.Windows.Forms.Label()
        Me.lblFirstNameValidation = New System.Windows.Forms.Label()
        Me.lblLastNameValidation = New System.Windows.Forms.Label()
        Me.lblYearLevelValidation = New System.Windows.Forms.Label()
        Me.lblCourseValidation = New System.Windows.Forms.Label()
        Me.lblSectionValidation = New System.Windows.Forms.Label()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.textlrnnumber = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lblLRNValidation = New System.Windows.Forms.Label()
        Me.LabelInfo = New System.Windows.Forms.Label()
        Me.flpMain = New System.Windows.Forms.FlowLayoutPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.ErrorCourse = New System.Windows.Forms.Label()
        Me.CBCourse = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Guna2Separator1 = New Guna.UI2.WinForms.Guna2Separator()
        Me.Guna2GradientPanel1.SuspendLayout()
        Me.flpMain.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
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
        Me.CBYear.Location = New System.Drawing.Point(13, 347)
        Me.CBYear.Name = "CBYear"
        Me.CBYear.ShadowDecoration.Parent = Me.CBYear
        Me.CBYear.Size = New System.Drawing.Size(370, 36)
        Me.CBYear.TabIndex = 19
        '
        'Guna2HtmlLabel5
        '
        Me.Guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel5.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.Guna2HtmlLabel5.ForeColor = System.Drawing.Color.Black
        Me.Guna2HtmlLabel5.Location = New System.Drawing.Point(13, 317)
        Me.Guna2HtmlLabel5.Margin = New System.Windows.Forms.Padding(3, 3, 3, 0)
        Me.Guna2HtmlLabel5.Name = "Guna2HtmlLabel5"
        Me.Guna2HtmlLabel5.Size = New System.Drawing.Size(93, 27)
        Me.Guna2HtmlLabel5.TabIndex = 12
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
        Me.TextLastname.Location = New System.Drawing.Point(13, 44)
        Me.TextLastname.Margin = New System.Windows.Forms.Padding(7, 8, 7, 8)
        Me.TextLastname.Name = "TextLastname"
        Me.TextLastname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TextLastname.PlaceholderText = ""
        Me.TextLastname.SelectedText = ""
        Me.TextLastname.ShadowDecoration.Parent = Me.TextLastname
        Me.TextLastname.Size = New System.Drawing.Size(370, 32)
        Me.TextLastname.TabIndex = 18
        '
        'Guna2HtmlLabel4
        '
        Me.Guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel4.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.Guna2HtmlLabel4.ForeColor = System.Drawing.Color.Black
        Me.Guna2HtmlLabel4.Location = New System.Drawing.Point(13, 14)
        Me.Guna2HtmlLabel4.Margin = New System.Windows.Forms.Padding(3, 3, 3, 0)
        Me.Guna2HtmlLabel4.Name = "Guna2HtmlLabel4"
        Me.Guna2HtmlLabel4.Size = New System.Drawing.Size(87, 27)
        Me.Guna2HtmlLabel4.TabIndex = 13
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
        Me.TextFirstname.Location = New System.Drawing.Point(13, 231)
        Me.TextFirstname.Margin = New System.Windows.Forms.Padding(7, 8, 7, 8)
        Me.TextFirstname.Name = "TextFirstname"
        Me.TextFirstname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TextFirstname.PlaceholderText = ""
        Me.TextFirstname.SelectedText = ""
        Me.TextFirstname.ShadowDecoration.Parent = Me.TextFirstname
        Me.TextFirstname.Size = New System.Drawing.Size(370, 32)
        Me.TextFirstname.TabIndex = 17
        '
        'Guna2HtmlLabel3
        '
        Me.Guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel3.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.Guna2HtmlLabel3.ForeColor = System.Drawing.Color.Black
        Me.Guna2HtmlLabel3.Location = New System.Drawing.Point(13, 201)
        Me.Guna2HtmlLabel3.Margin = New System.Windows.Forms.Padding(3, 3, 3, 0)
        Me.Guna2HtmlLabel3.Name = "Guna2HtmlLabel3"
        Me.Guna2HtmlLabel3.Size = New System.Drawing.Size(89, 27)
        Me.Guna2HtmlLabel3.TabIndex = 14
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
        Me.TextStudentID.Location = New System.Drawing.Point(13, 134)
        Me.TextStudentID.Margin = New System.Windows.Forms.Padding(7, 8, 7, 8)
        Me.TextStudentID.Name = "TextStudentID"
        Me.TextStudentID.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TextStudentID.PlaceholderText = ""
        Me.TextStudentID.SelectedText = ""
        Me.TextStudentID.ShadowDecoration.Parent = Me.TextStudentID
        Me.TextStudentID.Size = New System.Drawing.Size(370, 33)
        Me.TextStudentID.TabIndex = 16
        '
        'Guna2HtmlLabel2
        '
        Me.Guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel2.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.Guna2HtmlLabel2.ForeColor = System.Drawing.Color.Black
        Me.Guna2HtmlLabel2.Location = New System.Drawing.Point(13, 104)
        Me.Guna2HtmlLabel2.Margin = New System.Windows.Forms.Padding(3, 3, 3, 0)
        Me.Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
        Me.Guna2HtmlLabel2.Size = New System.Drawing.Size(95, 27)
        Me.Guna2HtmlLabel2.TabIndex = 15
        Me.Guna2HtmlLabel2.Text = "Student ID:"
        '
        'Guna2HtmlLabel7
        '
        Me.Guna2HtmlLabel7.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel7.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.Guna2HtmlLabel7.ForeColor = System.Drawing.Color.Black
        Me.Guna2HtmlLabel7.Location = New System.Drawing.Point(13, 212)
        Me.Guna2HtmlLabel7.Name = "Guna2HtmlLabel7"
        Me.Guna2HtmlLabel7.Size = New System.Drawing.Size(69, 27)
        Me.Guna2HtmlLabel7.TabIndex = 20
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
        Me.CBSection.Location = New System.Drawing.Point(13, 242)
        Me.CBSection.Name = "CBSection"
        Me.CBSection.ShadowDecoration.Parent = Me.CBSection
        Me.CBSection.Size = New System.Drawing.Size(370, 36)
        Me.CBSection.TabIndex = 25
        '
        'Guna2HtmlLabel6
        '
        Me.Guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel6.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.Guna2HtmlLabel6.ForeColor = System.Drawing.Color.Black
        Me.Guna2HtmlLabel6.Location = New System.Drawing.Point(13, 110)
        Me.Guna2HtmlLabel6.Name = "Guna2HtmlLabel6"
        Me.Guna2HtmlLabel6.Size = New System.Drawing.Size(66, 27)
        Me.Guna2HtmlLabel6.TabIndex = 21
        Me.Guna2HtmlLabel6.Text = "Course:"
        '
        'ButtonDiscard
        '
        Me.ButtonDiscard.Animated = True
        Me.ButtonDiscard.CheckedState.Parent = Me.ButtonDiscard
        Me.ButtonDiscard.CustomImages.Parent = Me.ButtonDiscard
        Me.ButtonDiscard.FillColor = System.Drawing.Color.Transparent
        Me.ButtonDiscard.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.ButtonDiscard.ForeColor = System.Drawing.Color.Gray
        Me.ButtonDiscard.HoverState.Parent = Me.ButtonDiscard
        Me.ButtonDiscard.Location = New System.Drawing.Point(12, 545)
        Me.ButtonDiscard.Name = "ButtonDiscard"
        Me.ButtonDiscard.ShadowDecoration.Parent = Me.ButtonDiscard
        Me.ButtonDiscard.Size = New System.Drawing.Size(189, 38)
        Me.ButtonDiscard.TabIndex = 1
        Me.ButtonDiscard.Text = "Discard"
        '
        'ButtonSubmit
        '
        Me.ButtonSubmit.CheckedState.Parent = Me.ButtonSubmit
        Me.ButtonSubmit.CustomImages.Parent = Me.ButtonSubmit
        Me.ButtonSubmit.FillColor = System.Drawing.Color.FromArgb(CType(CType(199, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.ButtonSubmit.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.ButtonSubmit.ForeColor = System.Drawing.Color.White
        Me.ButtonSubmit.HoverState.Parent = Me.ButtonSubmit
        Me.ButtonSubmit.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.ButtonSubmit.ImageOffset = New System.Drawing.Point(1, 1)
        Me.ButtonSubmit.ImageSize = New System.Drawing.Size(15, 15)
        Me.ButtonSubmit.Location = New System.Drawing.Point(319, 545)
        Me.ButtonSubmit.Name = "ButtonSubmit"
        Me.ButtonSubmit.ShadowDecoration.Parent = Me.ButtonSubmit
        Me.ButtonSubmit.Size = New System.Drawing.Size(146, 38)
        Me.ButtonSubmit.TabIndex = 0
        Me.ButtonSubmit.Text = "Submit"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Poppins", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label4.Location = New System.Drawing.Point(12, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(249, 56)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Register Voter"
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
        Me.Guna2GradientPanel1.Size = New System.Drawing.Size(479, 66)
        Me.Guna2GradientPanel1.TabIndex = 32
        '
        'lblStudentIDValidation
        '
        Me.lblStudentIDValidation.AutoSize = True
        Me.lblStudentIDValidation.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStudentIDValidation.ForeColor = System.Drawing.Color.Red
        Me.lblStudentIDValidation.Location = New System.Drawing.Point(32, 175)
        Me.lblStudentIDValidation.Name = "lblStudentIDValidation"
        Me.lblStudentIDValidation.Size = New System.Drawing.Size(0, 23)
        Me.lblStudentIDValidation.TabIndex = 34
        '
        'lblFirstNameValidation
        '
        Me.lblFirstNameValidation.AutoSize = True
        Me.lblFirstNameValidation.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFirstNameValidation.ForeColor = System.Drawing.Color.Red
        Me.lblFirstNameValidation.Location = New System.Drawing.Point(32, 271)
        Me.lblFirstNameValidation.Name = "lblFirstNameValidation"
        Me.lblFirstNameValidation.Size = New System.Drawing.Size(0, 23)
        Me.lblFirstNameValidation.TabIndex = 34
        '
        'lblLastNameValidation
        '
        Me.lblLastNameValidation.AutoSize = True
        Me.lblLastNameValidation.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLastNameValidation.ForeColor = System.Drawing.Color.Red
        Me.lblLastNameValidation.Location = New System.Drawing.Point(32, 84)
        Me.lblLastNameValidation.Name = "lblLastNameValidation"
        Me.lblLastNameValidation.Size = New System.Drawing.Size(0, 23)
        Me.lblLastNameValidation.TabIndex = 34
        '
        'lblYearLevelValidation
        '
        Me.lblYearLevelValidation.AutoSize = True
        Me.lblYearLevelValidation.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblYearLevelValidation.ForeColor = System.Drawing.Color.Red
        Me.lblYearLevelValidation.Location = New System.Drawing.Point(27, 386)
        Me.lblYearLevelValidation.Name = "lblYearLevelValidation"
        Me.lblYearLevelValidation.Size = New System.Drawing.Size(0, 23)
        Me.lblYearLevelValidation.TabIndex = 34
        '
        'lblCourseValidation
        '
        Me.lblCourseValidation.AutoSize = True
        Me.lblCourseValidation.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCourseValidation.ForeColor = System.Drawing.Color.Red
        Me.lblCourseValidation.Location = New System.Drawing.Point(27, 186)
        Me.lblCourseValidation.Name = "lblCourseValidation"
        Me.lblCourseValidation.Size = New System.Drawing.Size(0, 23)
        Me.lblCourseValidation.TabIndex = 34
        '
        'lblSectionValidation
        '
        Me.lblSectionValidation.AutoSize = True
        Me.lblSectionValidation.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSectionValidation.ForeColor = System.Drawing.Color.Red
        Me.lblSectionValidation.Location = New System.Drawing.Point(27, 291)
        Me.lblSectionValidation.Name = "lblSectionValidation"
        Me.lblSectionValidation.Size = New System.Drawing.Size(0, 23)
        Me.lblSectionValidation.TabIndex = 34
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.Guna2HtmlLabel1.ForeColor = System.Drawing.Color.Black
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(13, 3)
        Me.Guna2HtmlLabel1.Margin = New System.Windows.Forms.Padding(3, 3, 3, 0)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(115, 27)
        Me.Guna2HtmlLabel1.TabIndex = 15
        Me.Guna2HtmlLabel1.Text = "LRN Number:"
        '
        'textlrnnumber
        '
        Me.textlrnnumber.BorderRadius = 5
        Me.textlrnnumber.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.textlrnnumber.DefaultText = ""
        Me.textlrnnumber.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.textlrnnumber.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.textlrnnumber.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.textlrnnumber.DisabledState.Parent = Me.textlrnnumber
        Me.textlrnnumber.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.textlrnnumber.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.textlrnnumber.FocusedState.Parent = Me.textlrnnumber
        Me.textlrnnumber.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.textlrnnumber.HoverState.Parent = Me.textlrnnumber
        Me.textlrnnumber.Location = New System.Drawing.Point(13, 38)
        Me.textlrnnumber.Margin = New System.Windows.Forms.Padding(7, 8, 7, 8)
        Me.textlrnnumber.Name = "textlrnnumber"
        Me.textlrnnumber.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.textlrnnumber.PlaceholderText = ""
        Me.textlrnnumber.SelectedText = ""
        Me.textlrnnumber.ShadowDecoration.Parent = Me.textlrnnumber
        Me.textlrnnumber.Size = New System.Drawing.Size(370, 33)
        Me.textlrnnumber.TabIndex = 16
        '
        'lblLRNValidation
        '
        Me.lblLRNValidation.AutoSize = True
        Me.lblLRNValidation.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLRNValidation.ForeColor = System.Drawing.Color.Red
        Me.lblLRNValidation.Location = New System.Drawing.Point(32, 79)
        Me.lblLRNValidation.Name = "lblLRNValidation"
        Me.lblLRNValidation.Size = New System.Drawing.Size(0, 23)
        Me.lblLRNValidation.TabIndex = 35
        '
        'LabelInfo
        '
        Me.LabelInfo.AutoSize = True
        Me.LabelInfo.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelInfo.ForeColor = System.Drawing.Color.DarkRed
        Me.LabelInfo.Location = New System.Drawing.Point(8, 421)
        Me.LabelInfo.Name = "LabelInfo"
        Me.LabelInfo.Size = New System.Drawing.Size(0, 28)
        Me.LabelInfo.TabIndex = 36
        '
        'flpMain
        '
        Me.flpMain.AutoScroll = True
        Me.flpMain.BackColor = System.Drawing.SystemColors.ControlLight
        Me.flpMain.Controls.Add(Me.Panel1)
        Me.flpMain.Controls.Add(Me.Panel3)
        Me.flpMain.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.flpMain.Location = New System.Drawing.Point(22, 87)
        Me.flpMain.Name = "flpMain"
        Me.flpMain.Padding = New System.Windows.Forms.Padding(10, 5, 0, 0)
        Me.flpMain.Size = New System.Drawing.Size(443, 418)
        Me.flpMain.TabIndex = 46
        Me.flpMain.WrapContents = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Guna2HtmlLabel1)
        Me.Panel1.Controls.Add(Me.textlrnnumber)
        Me.Panel1.Controls.Add(Me.lblLRNValidation)
        Me.Panel1.Controls.Add(Me.Guna2HtmlLabel2)
        Me.Panel1.Controls.Add(Me.TextStudentID)
        Me.Panel1.Controls.Add(Me.lblStudentIDValidation)
        Me.Panel1.Controls.Add(Me.lblFirstNameValidation)
        Me.Panel1.Controls.Add(Me.Guna2HtmlLabel3)
        Me.Panel1.Controls.Add(Me.TextFirstname)
        Me.Panel1.Location = New System.Drawing.Point(13, 8)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(403, 306)
        Me.Panel1.TabIndex = 0
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Guna2HtmlLabel4)
        Me.Panel3.Controls.Add(Me.LabelInfo)
        Me.Panel3.Controls.Add(Me.TextLastname)
        Me.Panel3.Controls.Add(Me.lblYearLevelValidation)
        Me.Panel3.Controls.Add(Me.lblSectionValidation)
        Me.Panel3.Controls.Add(Me.lblLastNameValidation)
        Me.Panel3.Controls.Add(Me.lblCourseValidation)
        Me.Panel3.Controls.Add(Me.CBYear)
        Me.Panel3.Controls.Add(Me.Guna2HtmlLabel6)
        Me.Panel3.Controls.Add(Me.Guna2HtmlLabel5)
        Me.Panel3.Controls.Add(Me.ErrorCourse)
        Me.Panel3.Controls.Add(Me.Guna2HtmlLabel7)
        Me.Panel3.Controls.Add(Me.CBSection)
        Me.Panel3.Controls.Add(Me.CBCourse)
        Me.Panel3.Location = New System.Drawing.Point(13, 320)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(403, 484)
        Me.Panel3.TabIndex = 1
        '
        'ErrorCourse
        '
        Me.ErrorCourse.AutoSize = True
        Me.ErrorCourse.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.ErrorCourse.ForeColor = System.Drawing.Color.Red
        Me.ErrorCourse.Location = New System.Drawing.Point(28, 168)
        Me.ErrorCourse.Margin = New System.Windows.Forms.Padding(3, 0, 3, 10)
        Me.ErrorCourse.Name = "ErrorCourse"
        Me.ErrorCourse.Size = New System.Drawing.Size(0, 13)
        Me.ErrorCourse.TabIndex = 22
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
        Me.CBCourse.Location = New System.Drawing.Point(13, 143)
        Me.CBCourse.Name = "CBCourse"
        Me.CBCourse.ShadowDecoration.Parent = Me.CBCourse
        Me.CBCourse.Size = New System.Drawing.Size(370, 36)
        Me.CBCourse.TabIndex = 24
        '
        'Guna2Separator1
        '
        Me.Guna2Separator1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Separator1.FillColor = System.Drawing.Color.DimGray
        Me.Guna2Separator1.Location = New System.Drawing.Point(-62, 529)
        Me.Guna2Separator1.Name = "Guna2Separator1"
        Me.Guna2Separator1.Size = New System.Drawing.Size(562, 10)
        Me.Guna2Separator1.TabIndex = 47
        '
        'AddVoters
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ClientSize = New System.Drawing.Size(479, 606)
        Me.Controls.Add(Me.Guna2Separator1)
        Me.Controls.Add(Me.ButtonSubmit)
        Me.Controls.Add(Me.ButtonDiscard)
        Me.Controls.Add(Me.flpMain)
        Me.Controls.Add(Me.Guna2GradientPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AddVoters"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AddVoters"
        Me.TopMost = True
        Me.Guna2GradientPanel1.ResumeLayout(False)
        Me.Guna2GradientPanel1.PerformLayout()
        Me.flpMain.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents CBYear As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Guna2HtmlLabel5 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents TextLastname As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel4 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents TextFirstname As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel3 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents TextStudentID As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel7 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents CBSection As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Guna2HtmlLabel6 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents ButtonDiscard As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents ButtonSubmit As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Guna2GradientPanel1 As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents lblStudentIDValidation As Label
    Friend WithEvents lblFirstNameValidation As Label
    Friend WithEvents lblLastNameValidation As Label
    Friend WithEvents lblYearLevelValidation As Label
    Friend WithEvents lblCourseValidation As Label
    Friend WithEvents lblSectionValidation As Label
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents textlrnnumber As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lblLRNValidation As Label
    Friend WithEvents LabelInfo As Label
    Friend WithEvents flpMain As FlowLayoutPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents ErrorCourse As Label
    Friend WithEvents CBCourse As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Guna2Separator1 As Guna.UI2.WinForms.Guna2Separator
End Class
