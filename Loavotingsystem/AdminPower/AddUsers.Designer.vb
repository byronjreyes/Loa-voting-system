<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AddUsers
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
        Me.lblSectionValidation = New System.Windows.Forms.Label()
        Me.lblCourseValidation = New System.Windows.Forms.Label()
        Me.lblYearLevelValidation = New System.Windows.Forms.Label()
        Me.ErrorCourse = New System.Windows.Forms.Label()
        Me.flpMain = New System.Windows.Forms.FlowLayoutPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.txtfirstname = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtusername = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel3 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.txtlastname = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.cborole = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Guna2HtmlLabel5 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.txtpassword = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2HtmlLabel6 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2GradientPanel1 = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ButtonDiscard = New Guna.UI2.WinForms.Guna2Button()
        Me.btnsave = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2HtmlLabel7 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.cboaccs = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.flpMain.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Guna2GradientPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblSectionValidation
        '
        Me.lblSectionValidation.AutoSize = True
        Me.lblSectionValidation.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSectionValidation.ForeColor = System.Drawing.Color.Red
        Me.lblSectionValidation.Location = New System.Drawing.Point(620, 245)
        Me.lblSectionValidation.Name = "lblSectionValidation"
        Me.lblSectionValidation.Size = New System.Drawing.Size(0, 23)
        Me.lblSectionValidation.TabIndex = 42
        '
        'lblCourseValidation
        '
        Me.lblCourseValidation.AutoSize = True
        Me.lblCourseValidation.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCourseValidation.ForeColor = System.Drawing.Color.Red
        Me.lblCourseValidation.Location = New System.Drawing.Point(620, 159)
        Me.lblCourseValidation.Name = "lblCourseValidation"
        Me.lblCourseValidation.Size = New System.Drawing.Size(0, 23)
        Me.lblCourseValidation.TabIndex = 43
        '
        'lblYearLevelValidation
        '
        Me.lblYearLevelValidation.AutoSize = True
        Me.lblYearLevelValidation.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblYearLevelValidation.ForeColor = System.Drawing.Color.Red
        Me.lblYearLevelValidation.Location = New System.Drawing.Point(625, 340)
        Me.lblYearLevelValidation.Name = "lblYearLevelValidation"
        Me.lblYearLevelValidation.Size = New System.Drawing.Size(0, 23)
        Me.lblYearLevelValidation.TabIndex = 44
        '
        'ErrorCourse
        '
        Me.ErrorCourse.AutoSize = True
        Me.ErrorCourse.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.ErrorCourse.ForeColor = System.Drawing.Color.Red
        Me.ErrorCourse.Location = New System.Drawing.Point(621, 141)
        Me.ErrorCourse.Margin = New System.Windows.Forms.Padding(3, 0, 3, 10)
        Me.ErrorCourse.Name = "ErrorCourse"
        Me.ErrorCourse.Size = New System.Drawing.Size(0, 13)
        Me.ErrorCourse.TabIndex = 39
        '
        'flpMain
        '
        Me.flpMain.AutoScroll = True
        Me.flpMain.BackColor = System.Drawing.SystemColors.ControlLight
        Me.flpMain.Controls.Add(Me.Panel1)
        Me.flpMain.Controls.Add(Me.Panel2)
        Me.flpMain.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.flpMain.Location = New System.Drawing.Point(12, 72)
        Me.flpMain.Name = "flpMain"
        Me.flpMain.Padding = New System.Windows.Forms.Padding(10, 5, 0, 0)
        Me.flpMain.Size = New System.Drawing.Size(370, 418)
        Me.flpMain.TabIndex = 45
        Me.flpMain.WrapContents = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Guna2HtmlLabel1)
        Me.Panel1.Controls.Add(Me.txtfirstname)
        Me.Panel1.Controls.Add(Me.txtusername)
        Me.Panel1.Controls.Add(Me.Guna2HtmlLabel2)
        Me.Panel1.Controls.Add(Me.Guna2HtmlLabel3)
        Me.Panel1.Controls.Add(Me.txtlastname)
        Me.Panel1.Location = New System.Drawing.Point(13, 8)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(342, 240)
        Me.Panel1.TabIndex = 0
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.Guna2HtmlLabel1.ForeColor = System.Drawing.Color.Black
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(13, 7)
        Me.Guna2HtmlLabel1.Margin = New System.Windows.Forms.Padding(3, 3, 3, 0)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(89, 27)
        Me.Guna2HtmlLabel1.TabIndex = 48
        Me.Guna2HtmlLabel1.Text = "Firstname:"
        '
        'txtfirstname
        '
        Me.txtfirstname.BorderRadius = 5
        Me.txtfirstname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtfirstname.DefaultText = ""
        Me.txtfirstname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtfirstname.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtfirstname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtfirstname.DisabledState.Parent = Me.txtfirstname
        Me.txtfirstname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtfirstname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtfirstname.FocusedState.Parent = Me.txtfirstname
        Me.txtfirstname.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtfirstname.HoverState.Parent = Me.txtfirstname
        Me.txtfirstname.Location = New System.Drawing.Point(13, 42)
        Me.txtfirstname.Margin = New System.Windows.Forms.Padding(7, 8, 7, 8)
        Me.txtfirstname.Name = "txtfirstname"
        Me.txtfirstname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtfirstname.PlaceholderText = ""
        Me.txtfirstname.SelectedText = ""
        Me.txtfirstname.ShadowDecoration.Parent = Me.txtfirstname
        Me.txtfirstname.Size = New System.Drawing.Size(278, 33)
        Me.txtfirstname.TabIndex = 50
        '
        'txtusername
        '
        Me.txtusername.BorderRadius = 5
        Me.txtusername.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtusername.DefaultText = ""
        Me.txtusername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtusername.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtusername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtusername.DisabledState.Parent = Me.txtusername
        Me.txtusername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtusername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtusername.FocusedState.Parent = Me.txtusername
        Me.txtusername.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtusername.HoverState.Parent = Me.txtusername
        Me.txtusername.Location = New System.Drawing.Point(13, 197)
        Me.txtusername.Margin = New System.Windows.Forms.Padding(7, 8, 7, 8)
        Me.txtusername.Name = "txtusername"
        Me.txtusername.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtusername.PlaceholderText = ""
        Me.txtusername.SelectedText = ""
        Me.txtusername.ShadowDecoration.Parent = Me.txtusername
        Me.txtusername.Size = New System.Drawing.Size(278, 32)
        Me.txtusername.TabIndex = 52
        '
        'Guna2HtmlLabel2
        '
        Me.Guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel2.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.Guna2HtmlLabel2.ForeColor = System.Drawing.Color.Black
        Me.Guna2HtmlLabel2.Location = New System.Drawing.Point(13, 86)
        Me.Guna2HtmlLabel2.Margin = New System.Windows.Forms.Padding(3, 3, 3, 0)
        Me.Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
        Me.Guna2HtmlLabel2.Size = New System.Drawing.Size(87, 27)
        Me.Guna2HtmlLabel2.TabIndex = 49
        Me.Guna2HtmlLabel2.Text = "Lastname:"
        '
        'Guna2HtmlLabel3
        '
        Me.Guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel3.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.Guna2HtmlLabel3.ForeColor = System.Drawing.Color.Black
        Me.Guna2HtmlLabel3.Location = New System.Drawing.Point(13, 165)
        Me.Guna2HtmlLabel3.Margin = New System.Windows.Forms.Padding(3, 3, 3, 0)
        Me.Guna2HtmlLabel3.Name = "Guna2HtmlLabel3"
        Me.Guna2HtmlLabel3.Size = New System.Drawing.Size(92, 27)
        Me.Guna2HtmlLabel3.TabIndex = 47
        Me.Guna2HtmlLabel3.Text = "Username:"
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
        Me.txtlastname.Location = New System.Drawing.Point(13, 121)
        Me.txtlastname.Margin = New System.Windows.Forms.Padding(7, 8, 7, 8)
        Me.txtlastname.Name = "txtlastname"
        Me.txtlastname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtlastname.PlaceholderText = ""
        Me.txtlastname.SelectedText = ""
        Me.txtlastname.ShadowDecoration.Parent = Me.txtlastname
        Me.txtlastname.Size = New System.Drawing.Size(278, 33)
        Me.txtlastname.TabIndex = 51
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.cboaccs)
        Me.Panel2.Controls.Add(Me.cborole)
        Me.Panel2.Controls.Add(Me.Guna2HtmlLabel5)
        Me.Panel2.Controls.Add(Me.txtpassword)
        Me.Panel2.Controls.Add(Me.Guna2HtmlLabel6)
        Me.Panel2.Controls.Add(Me.Guna2HtmlLabel7)
        Me.Panel2.Location = New System.Drawing.Point(13, 254)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(342, 248)
        Me.Panel2.TabIndex = 1
        '
        'cborole
        '
        Me.cborole.BackColor = System.Drawing.Color.Transparent
        Me.cborole.BorderRadius = 5
        Me.cborole.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cborole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cborole.FocusedColor = System.Drawing.Color.Empty
        Me.cborole.FocusedState.Parent = Me.cborole
        Me.cborole.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cborole.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cborole.FormattingEnabled = True
        Me.cborole.HoverState.Parent = Me.cborole
        Me.cborole.ItemHeight = 30
        Me.cborole.Items.AddRange(New Object() {"IT Specialist", "Database Administrator", "Software Developer", "Communication Manager", "Accessibility Coordinator"})
        Me.cborole.ItemsAppearance.Parent = Me.cborole
        Me.cborole.Location = New System.Drawing.Point(13, 123)
        Me.cborole.Name = "cborole"
        Me.cborole.ShadowDecoration.Parent = Me.cborole
        Me.cborole.Size = New System.Drawing.Size(278, 36)
        Me.cborole.TabIndex = 46
        Me.cborole.Tag = "3"
        '
        'Guna2HtmlLabel5
        '
        Me.Guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel5.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.Guna2HtmlLabel5.ForeColor = System.Drawing.Color.Black
        Me.Guna2HtmlLabel5.Location = New System.Drawing.Point(13, 7)
        Me.Guna2HtmlLabel5.Margin = New System.Windows.Forms.Padding(3, 3, 3, 0)
        Me.Guna2HtmlLabel5.Name = "Guna2HtmlLabel5"
        Me.Guna2HtmlLabel5.Size = New System.Drawing.Size(87, 27)
        Me.Guna2HtmlLabel5.TabIndex = 48
        Me.Guna2HtmlLabel5.Text = "Password:"
        '
        'txtpassword
        '
        Me.txtpassword.BorderRadius = 5
        Me.txtpassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtpassword.DefaultText = ""
        Me.txtpassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtpassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtpassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtpassword.DisabledState.Parent = Me.txtpassword
        Me.txtpassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtpassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtpassword.FocusedState.Parent = Me.txtpassword
        Me.txtpassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtpassword.HoverState.Parent = Me.txtpassword
        Me.txtpassword.Location = New System.Drawing.Point(13, 42)
        Me.txtpassword.Margin = New System.Windows.Forms.Padding(7, 8, 7, 8)
        Me.txtpassword.Name = "txtpassword"
        Me.txtpassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtpassword.PlaceholderText = ""
        Me.txtpassword.SelectedText = ""
        Me.txtpassword.ShadowDecoration.Parent = Me.txtpassword
        Me.txtpassword.Size = New System.Drawing.Size(278, 33)
        Me.txtpassword.TabIndex = 50
        '
        'Guna2HtmlLabel6
        '
        Me.Guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel6.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.Guna2HtmlLabel6.ForeColor = System.Drawing.Color.Black
        Me.Guna2HtmlLabel6.Location = New System.Drawing.Point(13, 86)
        Me.Guna2HtmlLabel6.Margin = New System.Windows.Forms.Padding(3, 3, 3, 0)
        Me.Guna2HtmlLabel6.Name = "Guna2HtmlLabel6"
        Me.Guna2HtmlLabel6.Size = New System.Drawing.Size(44, 27)
        Me.Guna2HtmlLabel6.TabIndex = 49
        Me.Guna2HtmlLabel6.Text = "Role:"
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
        Me.Guna2GradientPanel1.Size = New System.Drawing.Size(397, 66)
        Me.Guna2GradientPanel1.TabIndex = 46
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Poppins", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label4.Location = New System.Drawing.Point(12, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(268, 56)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Register Admin"
        '
        'ButtonDiscard
        '
        Me.ButtonDiscard.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonDiscard.Animated = True
        Me.ButtonDiscard.CheckedState.Parent = Me.ButtonDiscard
        Me.ButtonDiscard.CustomImages.Parent = Me.ButtonDiscard
        Me.ButtonDiscard.FillColor = System.Drawing.SystemColors.Control
        Me.ButtonDiscard.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.ButtonDiscard.ForeColor = System.Drawing.Color.Gray
        Me.ButtonDiscard.HoverState.Parent = Me.ButtonDiscard
        Me.ButtonDiscard.Location = New System.Drawing.Point(125, 518)
        Me.ButtonDiscard.Name = "ButtonDiscard"
        Me.ButtonDiscard.ShadowDecoration.Parent = Me.ButtonDiscard
        Me.ButtonDiscard.Size = New System.Drawing.Size(113, 37)
        Me.ButtonDiscard.TabIndex = 47
        Me.ButtonDiscard.Text = "Discard"
        '
        'btnsave
        '
        Me.btnsave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnsave.Animated = True
        Me.btnsave.CheckedState.Parent = Me.btnsave
        Me.btnsave.CustomImages.Parent = Me.btnsave
        Me.btnsave.FillColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.btnsave.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btnsave.ForeColor = System.Drawing.Color.White
        Me.btnsave.HoverState.Parent = Me.btnsave
        Me.btnsave.Location = New System.Drawing.Point(250, 518)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.ShadowDecoration.Parent = Me.btnsave
        Me.btnsave.Size = New System.Drawing.Size(132, 37)
        Me.btnsave.TabIndex = 48
        Me.btnsave.Text = "Save"
        '
        'Guna2HtmlLabel7
        '
        Me.Guna2HtmlLabel7.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel7.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.Guna2HtmlLabel7.ForeColor = System.Drawing.Color.Black
        Me.Guna2HtmlLabel7.Location = New System.Drawing.Point(13, 165)
        Me.Guna2HtmlLabel7.Margin = New System.Windows.Forms.Padding(3, 3, 3, 0)
        Me.Guna2HtmlLabel7.Name = "Guna2HtmlLabel7"
        Me.Guna2HtmlLabel7.Size = New System.Drawing.Size(111, 27)
        Me.Guna2HtmlLabel7.TabIndex = 47
        Me.Guna2HtmlLabel7.Text = "Access Level:"
        '
        'cboaccs
        '
        Me.cboaccs.BackColor = System.Drawing.Color.Transparent
        Me.cboaccs.BorderRadius = 5
        Me.cboaccs.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboaccs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboaccs.FocusedColor = System.Drawing.Color.Empty
        Me.cboaccs.FocusedState.Parent = Me.cboaccs
        Me.cboaccs.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cboaccs.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cboaccs.FormattingEnabled = True
        Me.cboaccs.HoverState.Parent = Me.cboaccs
        Me.cboaccs.ItemHeight = 30
        Me.cboaccs.Items.AddRange(New Object() {"Admin", "Super Admin"})
        Me.cboaccs.ItemsAppearance.Parent = Me.cboaccs
        Me.cboaccs.Location = New System.Drawing.Point(13, 195)
        Me.cboaccs.Name = "cboaccs"
        Me.cboaccs.ShadowDecoration.Parent = Me.cboaccs
        Me.cboaccs.Size = New System.Drawing.Size(278, 36)
        Me.cboaccs.TabIndex = 46
        Me.cboaccs.Tag = "3"
        '
        'AddUsers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ClientSize = New System.Drawing.Size(397, 582)
        Me.Controls.Add(Me.ButtonDiscard)
        Me.Controls.Add(Me.btnsave)
        Me.Controls.Add(Me.Guna2GradientPanel1)
        Me.Controls.Add(Me.flpMain)
        Me.Controls.Add(Me.lblSectionValidation)
        Me.Controls.Add(Me.lblCourseValidation)
        Me.Controls.Add(Me.lblYearLevelValidation)
        Me.Controls.Add(Me.ErrorCourse)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AddUsers"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AddUsers"
        Me.TopMost = True
        Me.flpMain.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Guna2GradientPanel1.ResumeLayout(False)
        Me.Guna2GradientPanel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblSectionValidation As Label
    Friend WithEvents lblCourseValidation As Label
    Friend WithEvents lblYearLevelValidation As Label
    Friend WithEvents ErrorCourse As Label
    Friend WithEvents flpMain As FlowLayoutPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents txtfirstname As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtusername As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel3 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents txtlastname As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Guna2HtmlLabel5 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents txtpassword As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel6 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents cborole As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Guna2GradientPanel1 As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents Label4 As Label
    Friend WithEvents ButtonDiscard As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnsave As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents cboaccs As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Guna2HtmlLabel7 As Guna.UI2.WinForms.Guna2HtmlLabel
End Class
