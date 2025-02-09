<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CandidateUpdate
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
        Me.ButtonSubmit = New Guna.UI2.WinForms.Guna2Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Guna2GradientPanel1 = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.Guna2HtmlLabel6 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.txtCourse = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.txtYear = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Guna2HtmlLabel5 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.txtlastname = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2HtmlLabel4 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.txtFirstName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2HtmlLabel3 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.txtStudentID = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.txtPosition = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Guna2HtmlLabel9 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.txttagline = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2HtmlLabel10 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel12 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.txtrepresentative = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Guna2Separator2 = New Guna.UI2.WinForms.Guna2Separator()
        Me.flpMain = New System.Windows.Forms.FlowLayoutPanel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Guna2GradientPanel1.SuspendLayout()
        Me.flpMain.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtonDiscard
        '
        Me.ButtonDiscard.Animated = True
        Me.ButtonDiscard.BorderRadius = 12
        Me.ButtonDiscard.CheckedState.Parent = Me.ButtonDiscard
        Me.ButtonDiscard.CustomImages.Parent = Me.ButtonDiscard
        Me.ButtonDiscard.FillColor = System.Drawing.Color.Transparent
        Me.ButtonDiscard.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.ButtonDiscard.ForeColor = System.Drawing.Color.Gray
        Me.ButtonDiscard.HoverState.Parent = Me.ButtonDiscard
        Me.ButtonDiscard.Location = New System.Drawing.Point(22, 550)
        Me.ButtonDiscard.Name = "ButtonDiscard"
        Me.ButtonDiscard.ShadowDecoration.Parent = Me.ButtonDiscard
        Me.ButtonDiscard.Size = New System.Drawing.Size(240, 38)
        Me.ButtonDiscard.TabIndex = 1
        Me.ButtonDiscard.Text = "Discard"
        '
        'ButtonSubmit
        '
        Me.ButtonSubmit.BorderRadius = 12
        Me.ButtonSubmit.CheckedState.Parent = Me.ButtonSubmit
        Me.ButtonSubmit.CustomImages.Parent = Me.ButtonSubmit
        Me.ButtonSubmit.FillColor = System.Drawing.Color.FromArgb(CType(CType(199, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.ButtonSubmit.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.ButtonSubmit.ForeColor = System.Drawing.Color.White
        Me.ButtonSubmit.HoverState.Parent = Me.ButtonSubmit
        Me.ButtonSubmit.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.ButtonSubmit.ImageOffset = New System.Drawing.Point(1, 1)
        Me.ButtonSubmit.ImageSize = New System.Drawing.Size(15, 15)
        Me.ButtonSubmit.Location = New System.Drawing.Point(299, 552)
        Me.ButtonSubmit.Name = "ButtonSubmit"
        Me.ButtonSubmit.ShadowDecoration.Parent = Me.ButtonSubmit
        Me.ButtonSubmit.Size = New System.Drawing.Size(265, 38)
        Me.ButtonSubmit.TabIndex = 0
        Me.ButtonSubmit.Text = "Update"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Poppins", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label4.Location = New System.Drawing.Point(12, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(521, 56)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Update Candidate Information"
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
        Me.Guna2GradientPanel1.Size = New System.Drawing.Size(615, 66)
        Me.Guna2GradientPanel1.TabIndex = 73
        '
        'Guna2HtmlLabel6
        '
        Me.Guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel6.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.Guna2HtmlLabel6.ForeColor = System.Drawing.Color.Black
        Me.Guna2HtmlLabel6.Location = New System.Drawing.Point(12, 238)
        Me.Guna2HtmlLabel6.Name = "Guna2HtmlLabel6"
        Me.Guna2HtmlLabel6.Size = New System.Drawing.Size(66, 27)
        Me.Guna2HtmlLabel6.TabIndex = 69
        Me.Guna2HtmlLabel6.Text = "Course:"
        '
        'txtCourse
        '
        Me.txtCourse.BackColor = System.Drawing.Color.Transparent
        Me.txtCourse.BorderRadius = 5
        Me.txtCourse.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.txtCourse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtCourse.FocusedColor = System.Drawing.Color.Empty
        Me.txtCourse.FocusedState.Parent = Me.txtCourse
        Me.txtCourse.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtCourse.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.txtCourse.FormattingEnabled = True
        Me.txtCourse.HoverState.Parent = Me.txtCourse
        Me.txtCourse.ItemHeight = 30
        Me.txtCourse.Items.AddRange(New Object() {"BS Accountancy", "BS Business Administration", "BS Custom Administration", "BS Information Technology", "BS Computer Science", "BS Industrial Engineering", "BS Computer Engineering", "BS Tourism Management", "BS Hospitality Management", "College of Education", "College of Psychology", "College of Criminal Justice", "Real Estate Management", "Technology Department"})
        Me.txtCourse.ItemsAppearance.Parent = Me.txtCourse
        Me.txtCourse.Location = New System.Drawing.Point(12, 271)
        Me.txtCourse.Name = "txtCourse"
        Me.txtCourse.ShadowDecoration.Parent = Me.txtCourse
        Me.txtCourse.Size = New System.Drawing.Size(278, 36)
        Me.txtCourse.TabIndex = 71
        '
        'txtYear
        '
        Me.txtYear.BackColor = System.Drawing.Color.Transparent
        Me.txtYear.BorderRadius = 5
        Me.txtYear.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.txtYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtYear.FocusedColor = System.Drawing.Color.Empty
        Me.txtYear.FocusedState.Parent = Me.txtYear
        Me.txtYear.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtYear.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.txtYear.FormattingEnabled = True
        Me.txtYear.HoverState.Parent = Me.txtYear
        Me.txtYear.ItemHeight = 30
        Me.txtYear.Items.AddRange(New Object() {"1st-year", "2nd-year", "3rd-year", "4th-year"})
        Me.txtYear.ItemsAppearance.Parent = Me.txtYear
        Me.txtYear.Location = New System.Drawing.Point(12, 112)
        Me.txtYear.Name = "txtYear"
        Me.txtYear.ShadowDecoration.Parent = Me.txtYear
        Me.txtYear.Size = New System.Drawing.Size(278, 36)
        Me.txtYear.TabIndex = 66
        '
        'Guna2HtmlLabel5
        '
        Me.Guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel5.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.Guna2HtmlLabel5.ForeColor = System.Drawing.Color.Black
        Me.Guna2HtmlLabel5.Location = New System.Drawing.Point(12, 82)
        Me.Guna2HtmlLabel5.Margin = New System.Windows.Forms.Padding(3, 3, 3, 0)
        Me.Guna2HtmlLabel5.Name = "Guna2HtmlLabel5"
        Me.Guna2HtmlLabel5.Size = New System.Drawing.Size(93, 27)
        Me.Guna2HtmlLabel5.TabIndex = 57
        Me.Guna2HtmlLabel5.Text = "Year Level:"
        '
        'txtlastname
        '
        Me.txtlastname.BorderRadius = 5
        Me.txtlastname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtlastname.DefaultText = ""
        Me.txtlastname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtlastname.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtlastname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtlastname.DisabledState.Parent = Me.txtlastname
        Me.txtlastname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtlastname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtlastname.FocusedState.Parent = Me.txtlastname
        Me.txtlastname.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtlastname.HoverState.Parent = Me.txtlastname
        Me.txtlastname.Location = New System.Drawing.Point(12, 196)
        Me.txtlastname.Margin = New System.Windows.Forms.Padding(7, 8, 7, 8)
        Me.txtlastname.Name = "txtlastname"
        Me.txtlastname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtlastname.PlaceholderText = "(e.g. John)"
        Me.txtlastname.SelectedText = ""
        Me.txtlastname.ShadowDecoration.Parent = Me.txtlastname
        Me.txtlastname.Size = New System.Drawing.Size(278, 32)
        Me.txtlastname.TabIndex = 65
        '
        'Guna2HtmlLabel4
        '
        Me.Guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel4.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.Guna2HtmlLabel4.ForeColor = System.Drawing.Color.Black
        Me.Guna2HtmlLabel4.Location = New System.Drawing.Point(12, 159)
        Me.Guna2HtmlLabel4.Margin = New System.Windows.Forms.Padding(3, 3, 3, 0)
        Me.Guna2HtmlLabel4.Name = "Guna2HtmlLabel4"
        Me.Guna2HtmlLabel4.Size = New System.Drawing.Size(87, 27)
        Me.Guna2HtmlLabel4.TabIndex = 58
        Me.Guna2HtmlLabel4.Text = "Lastname:"
        '
        'txtFirstName
        '
        Me.txtFirstName.BorderRadius = 5
        Me.txtFirstName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtFirstName.DefaultText = ""
        Me.txtFirstName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtFirstName.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtFirstName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtFirstName.DisabledState.Parent = Me.txtFirstName
        Me.txtFirstName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtFirstName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtFirstName.FocusedState.Parent = Me.txtFirstName
        Me.txtFirstName.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtFirstName.HoverState.Parent = Me.txtFirstName
        Me.txtFirstName.Location = New System.Drawing.Point(12, 116)
        Me.txtFirstName.Margin = New System.Windows.Forms.Padding(7, 8, 7, 8)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFirstName.PlaceholderText = "(e.g. John)"
        Me.txtFirstName.SelectedText = ""
        Me.txtFirstName.ShadowDecoration.Parent = Me.txtFirstName
        Me.txtFirstName.Size = New System.Drawing.Size(278, 32)
        Me.txtFirstName.TabIndex = 64
        '
        'Guna2HtmlLabel3
        '
        Me.Guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel3.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.Guna2HtmlLabel3.ForeColor = System.Drawing.Color.Black
        Me.Guna2HtmlLabel3.Location = New System.Drawing.Point(12, 81)
        Me.Guna2HtmlLabel3.Margin = New System.Windows.Forms.Padding(3, 3, 3, 0)
        Me.Guna2HtmlLabel3.Name = "Guna2HtmlLabel3"
        Me.Guna2HtmlLabel3.Size = New System.Drawing.Size(89, 27)
        Me.Guna2HtmlLabel3.TabIndex = 59
        Me.Guna2HtmlLabel3.Text = "Firstname:"
        '
        'txtStudentID
        '
        Me.txtStudentID.BorderRadius = 5
        Me.txtStudentID.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtStudentID.DefaultText = ""
        Me.txtStudentID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtStudentID.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtStudentID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtStudentID.DisabledState.Parent = Me.txtStudentID
        Me.txtStudentID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtStudentID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtStudentID.FocusedState.Parent = Me.txtStudentID
        Me.txtStudentID.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtStudentID.HoverState.Parent = Me.txtStudentID
        Me.txtStudentID.Location = New System.Drawing.Point(12, 37)
        Me.txtStudentID.Margin = New System.Windows.Forms.Padding(7, 8, 7, 8)
        Me.txtStudentID.Name = "txtStudentID"
        Me.txtStudentID.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtStudentID.PlaceholderText = "(e.g. 20200000-C)"
        Me.txtStudentID.SelectedText = ""
        Me.txtStudentID.ShadowDecoration.Parent = Me.txtStudentID
        Me.txtStudentID.Size = New System.Drawing.Size(278, 33)
        Me.txtStudentID.TabIndex = 63
        '
        'Guna2HtmlLabel2
        '
        Me.Guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel2.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.Guna2HtmlLabel2.ForeColor = System.Drawing.Color.Black
        Me.Guna2HtmlLabel2.Location = New System.Drawing.Point(12, 3)
        Me.Guna2HtmlLabel2.Margin = New System.Windows.Forms.Padding(3, 3, 3, 0)
        Me.Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
        Me.Guna2HtmlLabel2.Size = New System.Drawing.Size(91, 27)
        Me.Guna2HtmlLabel2.TabIndex = 61
        Me.Guna2HtmlLabel2.Text = "Student ID"
        '
        'txtPosition
        '
        Me.txtPosition.BackColor = System.Drawing.Color.Transparent
        Me.txtPosition.BorderRadius = 5
        Me.txtPosition.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.txtPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtPosition.FocusedColor = System.Drawing.Color.Empty
        Me.txtPosition.FocusedState.Parent = Me.txtPosition
        Me.txtPosition.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtPosition.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.txtPosition.FormattingEnabled = True
        Me.txtPosition.HoverState.Parent = Me.txtPosition
        Me.txtPosition.ItemHeight = 30
        Me.txtPosition.Items.AddRange(New Object() {"PRESIDENT ", "EXECUTIVE VICE PRESIDENT ", "VP FINANCE", "VP ACTIVITIES", "VP COMMUNICATION AND MARKETING ", "VP DOCUMENTATION"})
        Me.txtPosition.ItemsAppearance.Parent = Me.txtPosition
        Me.txtPosition.Location = New System.Drawing.Point(12, 40)
        Me.txtPosition.Name = "txtPosition"
        Me.txtPosition.ShadowDecoration.Parent = Me.txtPosition
        Me.txtPosition.Size = New System.Drawing.Size(278, 36)
        Me.txtPosition.TabIndex = 71
        '
        'Guna2HtmlLabel9
        '
        Me.Guna2HtmlLabel9.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel9.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.Guna2HtmlLabel9.ForeColor = System.Drawing.Color.Black
        Me.Guna2HtmlLabel9.Location = New System.Drawing.Point(12, 7)
        Me.Guna2HtmlLabel9.Name = "Guna2HtmlLabel9"
        Me.Guna2HtmlLabel9.Size = New System.Drawing.Size(75, 27)
        Me.Guna2HtmlLabel9.TabIndex = 69
        Me.Guna2HtmlLabel9.Text = "Position:"
        '
        'txttagline
        '
        Me.txttagline.BorderRadius = 23
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
        Me.txttagline.Location = New System.Drawing.Point(22, 383)
        Me.txttagline.Margin = New System.Windows.Forms.Padding(7, 8, 7, 8)
        Me.txttagline.Name = "txttagline"
        Me.txttagline.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txttagline.PlaceholderText = ""
        Me.txttagline.SelectedText = ""
        Me.txttagline.ShadowDecoration.Parent = Me.txttagline
        Me.txttagline.Size = New System.Drawing.Size(200, 137)
        Me.txttagline.TabIndex = 93
        '
        'Guna2HtmlLabel10
        '
        Me.Guna2HtmlLabel10.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel10.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.Guna2HtmlLabel10.ForeColor = System.Drawing.Color.Black
        Me.Guna2HtmlLabel10.Location = New System.Drawing.Point(22, 356)
        Me.Guna2HtmlLabel10.Name = "Guna2HtmlLabel10"
        Me.Guna2HtmlLabel10.Size = New System.Drawing.Size(69, 27)
        Me.Guna2HtmlLabel10.TabIndex = 86
        Me.Guna2HtmlLabel10.Text = "Tagline:"
        '
        'Guna2HtmlLabel12
        '
        Me.Guna2HtmlLabel12.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel12.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.Guna2HtmlLabel12.ForeColor = System.Drawing.Color.Black
        Me.Guna2HtmlLabel12.Location = New System.Drawing.Point(12, 166)
        Me.Guna2HtmlLabel12.Name = "Guna2HtmlLabel12"
        Me.Guna2HtmlLabel12.Size = New System.Drawing.Size(139, 27)
        Me.Guna2HtmlLabel12.TabIndex = 88
        Me.Guna2HtmlLabel12.Text = "Representatives:"
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
        Me.txtrepresentative.Location = New System.Drawing.Point(12, 196)
        Me.txtrepresentative.Name = "txtrepresentative"
        Me.txtrepresentative.ShadowDecoration.Parent = Me.txtrepresentative
        Me.txtrepresentative.Size = New System.Drawing.Size(278, 36)
        Me.txtrepresentative.TabIndex = 90
        '
        'Guna2Separator2
        '
        Me.Guna2Separator2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Separator2.FillThickness = 2
        Me.Guna2Separator2.Location = New System.Drawing.Point(0, 531)
        Me.Guna2Separator2.Name = "Guna2Separator2"
        Me.Guna2Separator2.Size = New System.Drawing.Size(1028, 10)
        Me.Guna2Separator2.TabIndex = 95
        '
        'flpMain
        '
        Me.flpMain.AutoScroll = True
        Me.flpMain.BackColor = System.Drawing.Color.Transparent
        Me.flpMain.Controls.Add(Me.Panel2)
        Me.flpMain.Controls.Add(Me.Panel3)
        Me.flpMain.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.flpMain.Location = New System.Drawing.Point(232, 102)
        Me.flpMain.Name = "flpMain"
        Me.flpMain.Padding = New System.Windows.Forms.Padding(10, 5, 0, 0)
        Me.flpMain.Size = New System.Drawing.Size(370, 418)
        Me.flpMain.TabIndex = 97
        Me.flpMain.WrapContents = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.Control
        Me.Panel2.Controls.Add(Me.Guna2HtmlLabel2)
        Me.Panel2.Controls.Add(Me.txtStudentID)
        Me.Panel2.Controls.Add(Me.Guna2HtmlLabel3)
        Me.Panel2.Controls.Add(Me.txtFirstName)
        Me.Panel2.Controls.Add(Me.Guna2HtmlLabel4)
        Me.Panel2.Controls.Add(Me.txtlastname)
        Me.Panel2.Location = New System.Drawing.Point(13, 8)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(342, 240)
        Me.Panel2.TabIndex = 0
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.Control
        Me.Panel3.Controls.Add(Me.Guna2HtmlLabel9)
        Me.Panel3.Controls.Add(Me.Guna2HtmlLabel5)
        Me.Panel3.Controls.Add(Me.txtYear)
        Me.Panel3.Controls.Add(Me.txtPosition)
        Me.Panel3.Controls.Add(Me.Guna2HtmlLabel12)
        Me.Panel3.Controls.Add(Me.txtrepresentative)
        Me.Panel3.Controls.Add(Me.Guna2HtmlLabel6)
        Me.Panel3.Controls.Add(Me.txtCourse)
        Me.Panel3.Location = New System.Drawing.Point(13, 254)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(342, 346)
        Me.Panel3.TabIndex = 1
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.BackgroundImage = Global.Loavotingsystem.My.Resources.Resources.finalframe
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Location = New System.Drawing.Point(22, 102)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(200, 248)
        Me.Panel1.TabIndex = 96
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Location = New System.Drawing.Point(23, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(145, 242)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 94
        Me.PictureBox1.TabStop = False
        '
        'CandidateUpdate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(615, 602)
        Me.Controls.Add(Me.flpMain)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Guna2Separator2)
        Me.Controls.Add(Me.ButtonDiscard)
        Me.Controls.Add(Me.ButtonSubmit)
        Me.Controls.Add(Me.txttagline)
        Me.Controls.Add(Me.Guna2HtmlLabel10)
        Me.Controls.Add(Me.Guna2GradientPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "CandidateUpdate"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CandidateUpdate"
        Me.TopMost = True
        Me.Guna2GradientPanel1.ResumeLayout(False)
        Me.Guna2GradientPanel1.PerformLayout()
        Me.flpMain.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ButtonDiscard As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents ButtonSubmit As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Guna2GradientPanel1 As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents Guna2HtmlLabel6 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents txtCourse As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents txtYear As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Guna2HtmlLabel5 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents txtlastname As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel4 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents txtFirstName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel3 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents txtStudentID As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents txtPosition As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Guna2HtmlLabel9 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents txttagline As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel10 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel12 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents txtrepresentative As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Guna2Separator2 As Guna.UI2.WinForms.Guna2Separator
    Friend WithEvents Panel1 As Panel
    Friend WithEvents flpMain As FlowLayoutPanel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
End Class
