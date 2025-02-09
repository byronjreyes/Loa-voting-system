<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ManageAdmins
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
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Guna2CustomGradientPanel1 = New Guna.UI2.WinForms.Guna2CustomGradientPanel()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cbostatus = New Guna.UI.WinForms.GunaComboBox()
        Me.acclevel = New Guna.UI.WinForms.GunaComboBox()
        Me.txtrole = New Guna.UI.WinForms.GunaComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtlastname = New Guna.UI.WinForms.GunaLineTextBox()
        Me.txtpassword = New Guna.UI.WinForms.GunaLineTextBox()
        Me.txtusername = New Guna.UI.WinForms.GunaLineTextBox()
        Me.txtfirstname = New Guna.UI.WinForms.GunaLineTextBox()
        Me.ButtonDiscard = New Guna.UI2.WinForms.Guna2Button()
        Me.btnsave = New Guna.UI2.WinForms.Guna2Button()
        Me.GunaButton2 = New Guna.UI2.WinForms.Guna2Button()
        Me.btnupdate = New Guna.UI2.WinForms.Guna2Button()
        Me.btnnew = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2CustomGradientPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Poppins", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label5.Location = New System.Drawing.Point(35, 7)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(284, 37)
        Me.Label5.TabIndex = 58
        Me.Label5.Text = "Manage Admin's Account"
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
        Me.Guna2CustomGradientPanel1.TabIndex = 98
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7})
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(12, 428)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(796, 182)
        Me.ListView1.TabIndex = 93
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Username"
        Me.ColumnHeader1.Width = 92
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Password"
        Me.ColumnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader2.Width = 140
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Account Status"
        Me.ColumnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader3.Width = 151
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Access Level"
        Me.ColumnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader4.Width = 123
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Lastname"
        Me.ColumnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader5.Width = 112
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Firstname"
        Me.ColumnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader6.Width = 102
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Role"
        Me.ColumnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader7.Width = 72
        '
        'cbostatus
        '
        Me.cbostatus.BackColor = System.Drawing.Color.Transparent
        Me.cbostatus.BaseColor = System.Drawing.Color.White
        Me.cbostatus.BorderColor = System.Drawing.Color.Transparent
        Me.cbostatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbostatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbostatus.FocusedColor = System.Drawing.Color.Empty
        Me.cbostatus.Font = New System.Drawing.Font("Poppins", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbostatus.ForeColor = System.Drawing.Color.Black
        Me.cbostatus.FormattingEnabled = True
        Me.cbostatus.Items.AddRange(New Object() {"Active", "Disabled"})
        Me.cbostatus.Location = New System.Drawing.Point(477, 308)
        Me.cbostatus.Name = "cbostatus"
        Me.cbostatus.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbostatus.OnHoverItemForeColor = System.Drawing.Color.White
        Me.cbostatus.Radius = 10
        Me.cbostatus.Size = New System.Drawing.Size(287, 31)
        Me.cbostatus.TabIndex = 92
        '
        'acclevel
        '
        Me.acclevel.BackColor = System.Drawing.Color.Transparent
        Me.acclevel.BaseColor = System.Drawing.Color.White
        Me.acclevel.BorderColor = System.Drawing.Color.Transparent
        Me.acclevel.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.acclevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.acclevel.FocusedColor = System.Drawing.Color.Empty
        Me.acclevel.Font = New System.Drawing.Font("Poppins", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.acclevel.ForeColor = System.Drawing.Color.Black
        Me.acclevel.FormattingEnabled = True
        Me.acclevel.Items.AddRange(New Object() {"Admin", "Super Admin"})
        Me.acclevel.Location = New System.Drawing.Point(58, 303)
        Me.acclevel.Name = "acclevel"
        Me.acclevel.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.acclevel.OnHoverItemForeColor = System.Drawing.Color.White
        Me.acclevel.Radius = 10
        Me.acclevel.Size = New System.Drawing.Size(297, 31)
        Me.acclevel.TabIndex = 90
        '
        'txtrole
        '
        Me.txtrole.BackColor = System.Drawing.Color.Transparent
        Me.txtrole.BaseColor = System.Drawing.Color.White
        Me.txtrole.BorderColor = System.Drawing.Color.Transparent
        Me.txtrole.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.txtrole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtrole.FocusedColor = System.Drawing.Color.Empty
        Me.txtrole.Font = New System.Drawing.Font("Poppins", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtrole.ForeColor = System.Drawing.Color.Black
        Me.txtrole.FormattingEnabled = True
        Me.txtrole.Items.AddRange(New Object() {"IT Specialist", "Database Administrator", "Software Developer", "Communication Manager", "Accessibility Coordinator"})
        Me.txtrole.Location = New System.Drawing.Point(58, 363)
        Me.txtrole.Name = "txtrole"
        Me.txtrole.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtrole.OnHoverItemForeColor = System.Drawing.Color.White
        Me.txtrole.Radius = 10
        Me.txtrole.Size = New System.Drawing.Size(297, 31)
        Me.txtrole.TabIndex = 91
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Poppins", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Snow
        Me.Label7.Location = New System.Drawing.Point(503, 111)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(246, 34)
        Me.Label7.TabIndex = 88
        Me.Label7.Text = "Admin's Account Details"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Poppins", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Snow
        Me.Label6.Location = New System.Drawing.Point(98, 111)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(248, 34)
        Me.Label6.TabIndex = 89
        Me.Label6.Text = "Admin's Personal Details"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Snow
        Me.Label2.Location = New System.Drawing.Point(56, 221)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 23)
        Me.Label2.TabIndex = 87
        Me.Label2.Text = "Lastname"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Snow
        Me.Label12.Location = New System.Drawing.Point(473, 282)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(112, 23)
        Me.Label12.TabIndex = 85
        Me.Label12.Text = "Account Status:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Snow
        Me.Label11.Location = New System.Drawing.Point(56, 337)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(40, 23)
        Me.Label11.TabIndex = 84
        Me.Label11.Text = "Role:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Snow
        Me.Label10.Location = New System.Drawing.Point(473, 221)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(74, 23)
        Me.Label10.TabIndex = 83
        Me.Label10.Text = "Password"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Snow
        Me.Label9.Location = New System.Drawing.Point(473, 157)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(80, 23)
        Me.Label9.TabIndex = 82
        Me.Label9.Text = "Username:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Snow
        Me.Label4.Location = New System.Drawing.Point(56, 157)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 23)
        Me.Label4.TabIndex = 81
        Me.Label4.Text = "Firstname"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Snow
        Me.Label3.Location = New System.Drawing.Point(56, 277)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 23)
        Me.Label3.TabIndex = 86
        Me.Label3.Text = "Access Level"
        '
        'txtlastname
        '
        Me.txtlastname.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.txtlastname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtlastname.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtlastname.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtlastname.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.txtlastname.LineColor = System.Drawing.Color.Gray
        Me.txtlastname.LineSize = 2
        Me.txtlastname.Location = New System.Drawing.Point(60, 244)
        Me.txtlastname.Name = "txtlastname"
        Me.txtlastname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtlastname.SelectedText = ""
        Me.txtlastname.Size = New System.Drawing.Size(295, 30)
        Me.txtlastname.TabIndex = 79
        Me.txtlastname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtpassword
        '
        Me.txtpassword.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.txtpassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtpassword.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtpassword.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpassword.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.txtpassword.LineColor = System.Drawing.Color.Gray
        Me.txtpassword.LineSize = 2
        Me.txtpassword.Location = New System.Drawing.Point(477, 249)
        Me.txtpassword.Name = "txtpassword"
        Me.txtpassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtpassword.SelectedText = ""
        Me.txtpassword.Size = New System.Drawing.Size(287, 30)
        Me.txtpassword.TabIndex = 78
        Me.txtpassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtusername
        '
        Me.txtusername.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.txtusername.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtusername.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtusername.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtusername.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.txtusername.LineColor = System.Drawing.Color.Gray
        Me.txtusername.LineSize = 2
        Me.txtusername.Location = New System.Drawing.Point(477, 183)
        Me.txtusername.Name = "txtusername"
        Me.txtusername.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtusername.SelectedText = ""
        Me.txtusername.Size = New System.Drawing.Size(287, 30)
        Me.txtusername.TabIndex = 80
        Me.txtusername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtfirstname
        '
        Me.txtfirstname.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.txtfirstname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtfirstname.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtfirstname.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtfirstname.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.txtfirstname.LineColor = System.Drawing.Color.Gray
        Me.txtfirstname.LineSize = 2
        Me.txtfirstname.Location = New System.Drawing.Point(60, 183)
        Me.txtfirstname.Name = "txtfirstname"
        Me.txtfirstname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtfirstname.SelectedText = ""
        Me.txtfirstname.Size = New System.Drawing.Size(295, 30)
        Me.txtfirstname.TabIndex = 77
        Me.txtfirstname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ButtonDiscard
        '
        Me.ButtonDiscard.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonDiscard.Animated = True
        Me.ButtonDiscard.BorderRadius = 9
        Me.ButtonDiscard.CheckedState.Parent = Me.ButtonDiscard
        Me.ButtonDiscard.CustomImages.Parent = Me.ButtonDiscard
        Me.ButtonDiscard.FillColor = System.Drawing.SystemColors.Control
        Me.ButtonDiscard.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.ButtonDiscard.ForeColor = System.Drawing.Color.Gray
        Me.ButtonDiscard.HoverState.Parent = Me.ButtonDiscard
        Me.ButtonDiscard.Location = New System.Drawing.Point(18, 654)
        Me.ButtonDiscard.Name = "ButtonDiscard"
        Me.ButtonDiscard.ShadowDecoration.Parent = Me.ButtonDiscard
        Me.ButtonDiscard.Size = New System.Drawing.Size(113, 37)
        Me.ButtonDiscard.TabIndex = 99
        Me.ButtonDiscard.Text = "Close"
        '
        'btnsave
        '
        Me.btnsave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnsave.Animated = True
        Me.btnsave.BorderRadius = 9
        Me.btnsave.CheckedState.Parent = Me.btnsave
        Me.btnsave.CustomImages.Parent = Me.btnsave
        Me.btnsave.FillColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.btnsave.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btnsave.ForeColor = System.Drawing.Color.White
        Me.btnsave.HoverState.Parent = Me.btnsave
        Me.btnsave.Location = New System.Drawing.Point(671, 654)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.ShadowDecoration.Parent = Me.btnsave
        Me.btnsave.Size = New System.Drawing.Size(132, 37)
        Me.btnsave.TabIndex = 100
        Me.btnsave.Text = "Save"
        '
        'GunaButton2
        '
        Me.GunaButton2.Animated = True
        Me.GunaButton2.BorderRadius = 9
        Me.GunaButton2.CheckedState.Parent = Me.GunaButton2
        Me.GunaButton2.CustomImages.Parent = Me.GunaButton2
        Me.GunaButton2.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.GunaButton2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaButton2.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.GunaButton2.HoverState.Parent = Me.GunaButton2
        Me.GunaButton2.Location = New System.Drawing.Point(395, 654)
        Me.GunaButton2.Name = "GunaButton2"
        Me.GunaButton2.ShadowDecoration.Parent = Me.GunaButton2
        Me.GunaButton2.Size = New System.Drawing.Size(132, 37)
        Me.GunaButton2.TabIndex = 108
        Me.GunaButton2.Text = "Delete"
        '
        'btnupdate
        '
        Me.btnupdate.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnupdate.Animated = True
        Me.btnupdate.BorderRadius = 9
        Me.btnupdate.CheckedState.Parent = Me.btnupdate
        Me.btnupdate.CustomImages.Parent = Me.btnupdate
        Me.btnupdate.FillColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.btnupdate.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btnupdate.ForeColor = System.Drawing.Color.White
        Me.btnupdate.HoverState.Parent = Me.btnupdate
        Me.btnupdate.Location = New System.Drawing.Point(533, 654)
        Me.btnupdate.Name = "btnupdate"
        Me.btnupdate.ShadowDecoration.Parent = Me.btnupdate
        Me.btnupdate.Size = New System.Drawing.Size(132, 37)
        Me.btnupdate.TabIndex = 100
        Me.btnupdate.Text = "Update"
        '
        'btnnew
        '
        Me.btnnew.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnnew.Animated = True
        Me.btnnew.BorderRadius = 9
        Me.btnnew.CheckedState.Parent = Me.btnnew
        Me.btnnew.CustomImages.Parent = Me.btnnew
        Me.btnnew.FillColor = System.Drawing.SystemColors.Control
        Me.btnnew.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btnnew.ForeColor = System.Drawing.Color.Gray
        Me.btnnew.HoverState.Parent = Me.btnnew
        Me.btnnew.Location = New System.Drawing.Point(257, 654)
        Me.btnnew.Name = "btnnew"
        Me.btnnew.ShadowDecoration.Parent = Me.btnnew
        Me.btnnew.Size = New System.Drawing.Size(132, 37)
        Me.btnnew.TabIndex = 99
        Me.btnnew.Text = "New"
        '
        'ManageAdmins
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(815, 729)
        Me.Controls.Add(Me.GunaButton2)
        Me.Controls.Add(Me.btnnew)
        Me.Controls.Add(Me.ButtonDiscard)
        Me.Controls.Add(Me.btnupdate)
        Me.Controls.Add(Me.btnsave)
        Me.Controls.Add(Me.Guna2CustomGradientPanel1)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.cbostatus)
        Me.Controls.Add(Me.acclevel)
        Me.Controls.Add(Me.txtrole)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtlastname)
        Me.Controls.Add(Me.txtpassword)
        Me.Controls.Add(Me.txtusername)
        Me.Controls.Add(Me.txtfirstname)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ManageAdmins"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ManageAdmins"
        Me.TopMost = True
        Me.Guna2CustomGradientPanel1.ResumeLayout(False)
        Me.Guna2CustomGradientPanel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label5 As Label
    Friend WithEvents Guna2CustomGradientPanel1 As Guna.UI2.WinForms.Guna2CustomGradientPanel
    Friend WithEvents ListView1 As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents ColumnHeader7 As ColumnHeader
    Friend WithEvents cbostatus As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents acclevel As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents txtrole As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtlastname As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents txtpassword As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents txtusername As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents txtfirstname As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents ButtonDiscard As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnsave As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents GunaButton2 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnupdate As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnnew As Guna.UI2.WinForms.Guna2Button
End Class
