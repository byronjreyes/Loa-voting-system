<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddParty
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
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.ErrorName = New System.Windows.Forms.Label()
        Me.ButtonDiscard = New Guna.UI2.WinForms.Guna2Button()
        Me.btnsave = New Guna.UI2.WinForms.Guna2Button()
        Me.txtdescriptionparty = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtpartyname = New Guna.UI2.WinForms.Guna2TextBox()
        Me.CBActivities = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CBVPactivities = New System.Windows.Forms.Label()
        Me.CbDocumentation = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.CBCOMMARKETING = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.CBComnMarketing = New System.Windows.Forms.Label()
        Me.CBVPfinance = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.CBViceEPresident = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CBPresident = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ButtonClear = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2GradientPanel1 = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.pictureboxpartylist = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Guna2GradientPanel1.SuspendLayout()
        CType(Me.pictureboxpartylist, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.Filter = "JPG(*.JPG)|*.jpg"
        '
        'ErrorName
        '
        Me.ErrorName.AutoSize = True
        Me.ErrorName.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.ErrorName.ForeColor = System.Drawing.Color.Red
        Me.ErrorName.Location = New System.Drawing.Point(30, 368)
        Me.ErrorName.Name = "ErrorName"
        Me.ErrorName.Size = New System.Drawing.Size(0, 13)
        Me.ErrorName.TabIndex = 41
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
        Me.ButtonDiscard.Location = New System.Drawing.Point(570, 568)
        Me.ButtonDiscard.Name = "ButtonDiscard"
        Me.ButtonDiscard.ShadowDecoration.Parent = Me.ButtonDiscard
        Me.ButtonDiscard.Size = New System.Drawing.Size(113, 37)
        Me.ButtonDiscard.TabIndex = 39
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
        Me.btnsave.Location = New System.Drawing.Point(695, 568)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.ShadowDecoration.Parent = Me.btnsave
        Me.btnsave.Size = New System.Drawing.Size(132, 37)
        Me.btnsave.TabIndex = 40
        Me.btnsave.Text = "Save"
        '
        'txtdescriptionparty
        '
        Me.txtdescriptionparty.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtdescriptionparty.DefaultText = ""
        Me.txtdescriptionparty.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtdescriptionparty.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtdescriptionparty.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtdescriptionparty.DisabledState.Parent = Me.txtdescriptionparty
        Me.txtdescriptionparty.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtdescriptionparty.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtdescriptionparty.FocusedState.Parent = Me.txtdescriptionparty
        Me.txtdescriptionparty.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtdescriptionparty.HoverState.Parent = Me.txtdescriptionparty
        Me.txtdescriptionparty.Location = New System.Drawing.Point(33, 416)
        Me.txtdescriptionparty.Margin = New System.Windows.Forms.Padding(6, 7, 6, 7)
        Me.txtdescriptionparty.Multiline = True
        Me.txtdescriptionparty.Name = "txtdescriptionparty"
        Me.txtdescriptionparty.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtdescriptionparty.PlaceholderText = ""
        Me.txtdescriptionparty.SelectedText = ""
        Me.txtdescriptionparty.ShadowDecoration.Parent = Me.txtdescriptionparty
        Me.txtdescriptionparty.Size = New System.Drawing.Size(220, 121)
        Me.txtdescriptionparty.TabIndex = 38
        '
        'txtpartyname
        '
        Me.txtpartyname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtpartyname.DefaultText = ""
        Me.txtpartyname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtpartyname.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtpartyname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtpartyname.DisabledState.Parent = Me.txtpartyname
        Me.txtpartyname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtpartyname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtpartyname.FocusedState.Parent = Me.txtpartyname
        Me.txtpartyname.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtpartyname.HoverState.Parent = Me.txtpartyname
        Me.txtpartyname.Location = New System.Drawing.Point(33, 329)
        Me.txtpartyname.Margin = New System.Windows.Forms.Padding(6, 7, 6, 7)
        Me.txtpartyname.Name = "txtpartyname"
        Me.txtpartyname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtpartyname.PlaceholderText = ""
        Me.txtpartyname.SelectedText = ""
        Me.txtpartyname.ShadowDecoration.Parent = Me.txtpartyname
        Me.txtpartyname.Size = New System.Drawing.Size(220, 36)
        Me.txtpartyname.TabIndex = 37
        '
        'CBActivities
        '
        Me.CBActivities.BackColor = System.Drawing.Color.Transparent
        Me.CBActivities.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CBActivities.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBActivities.FocusedColor = System.Drawing.Color.Empty
        Me.CBActivities.FocusedState.Parent = Me.CBActivities
        Me.CBActivities.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.CBActivities.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.CBActivities.FormattingEnabled = True
        Me.CBActivities.HoverState.Parent = Me.CBActivities
        Me.CBActivities.ItemHeight = 30
        Me.CBActivities.ItemsAppearance.Parent = Me.CBActivities
        Me.CBActivities.Location = New System.Drawing.Point(273, 345)
        Me.CBActivities.Name = "CBActivities"
        Me.CBActivities.ShadowDecoration.Parent = Me.CBActivities
        Me.CBActivities.Size = New System.Drawing.Size(554, 36)
        Me.CBActivities.TabIndex = 35
        Me.CBActivities.Tag = "4"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(269, 249)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(165, 21)
        Me.Label5.TabIndex = 27
        Me.Label5.Text = "Vice President Finance"
        '
        'CBVPactivities
        '
        Me.CBVPactivities.AutoSize = True
        Me.CBVPactivities.BackColor = System.Drawing.Color.Transparent
        Me.CBVPactivities.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.CBVPactivities.ForeColor = System.Drawing.Color.Black
        Me.CBVPactivities.Location = New System.Drawing.Point(269, 321)
        Me.CBVPactivities.Name = "CBVPactivities"
        Me.CBVPactivities.Size = New System.Drawing.Size(95, 21)
        Me.CBVPactivities.TabIndex = 28
        Me.CBVPactivities.Text = "VP Activities"
        '
        'CbDocumentation
        '
        Me.CbDocumentation.BackColor = System.Drawing.Color.Transparent
        Me.CbDocumentation.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CbDocumentation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbDocumentation.FocusedColor = System.Drawing.Color.Empty
        Me.CbDocumentation.FocusedState.Parent = Me.CbDocumentation
        Me.CbDocumentation.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.CbDocumentation.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.CbDocumentation.FormattingEnabled = True
        Me.CbDocumentation.HoverState.Parent = Me.CbDocumentation
        Me.CbDocumentation.ItemHeight = 30
        Me.CbDocumentation.ItemsAppearance.Parent = Me.CbDocumentation
        Me.CbDocumentation.Location = New System.Drawing.Point(273, 501)
        Me.CbDocumentation.Name = "CbDocumentation"
        Me.CbDocumentation.ShadowDecoration.Parent = Me.CbDocumentation
        Me.CbDocumentation.Size = New System.Drawing.Size(554, 36)
        Me.CbDocumentation.TabIndex = 34
        Me.CbDocumentation.Tag = "6"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(269, 477)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(140, 21)
        Me.Label8.TabIndex = 29
        Me.Label8.Text = "VP Documentation"
        '
        'CBCOMMARKETING
        '
        Me.CBCOMMARKETING.BackColor = System.Drawing.Color.Transparent
        Me.CBCOMMARKETING.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CBCOMMARKETING.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBCOMMARKETING.FocusedColor = System.Drawing.Color.Empty
        Me.CBCOMMARKETING.FocusedState.Parent = Me.CBCOMMARKETING
        Me.CBCOMMARKETING.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.CBCOMMARKETING.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.CBCOMMARKETING.FormattingEnabled = True
        Me.CBCOMMARKETING.HoverState.Parent = Me.CBCOMMARKETING
        Me.CBCOMMARKETING.ItemHeight = 30
        Me.CBCOMMARKETING.ItemsAppearance.Parent = Me.CBCOMMARKETING
        Me.CBCOMMARKETING.Location = New System.Drawing.Point(273, 425)
        Me.CBCOMMARKETING.Name = "CBCOMMARKETING"
        Me.CBCOMMARKETING.ShadowDecoration.Parent = Me.CBCOMMARKETING
        Me.CBCOMMARKETING.Size = New System.Drawing.Size(554, 36)
        Me.CBCOMMARKETING.TabIndex = 33
        Me.CBCOMMARKETING.Tag = "5"
        '
        'CBComnMarketing
        '
        Me.CBComnMarketing.AutoSize = True
        Me.CBComnMarketing.BackColor = System.Drawing.Color.Transparent
        Me.CBComnMarketing.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.CBComnMarketing.ForeColor = System.Drawing.Color.Black
        Me.CBComnMarketing.Location = New System.Drawing.Point(269, 392)
        Me.CBComnMarketing.Name = "CBComnMarketing"
        Me.CBComnMarketing.Size = New System.Drawing.Size(249, 21)
        Me.CBComnMarketing.TabIndex = 30
        Me.CBComnMarketing.Text = "VP Communication and Marketing"
        '
        'CBVPfinance
        '
        Me.CBVPfinance.BackColor = System.Drawing.Color.Transparent
        Me.CBVPfinance.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CBVPfinance.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBVPfinance.FocusedColor = System.Drawing.Color.Empty
        Me.CBVPfinance.FocusedState.Parent = Me.CBVPfinance
        Me.CBVPfinance.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.CBVPfinance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.CBVPfinance.FormattingEnabled = True
        Me.CBVPfinance.HoverState.Parent = Me.CBVPfinance
        Me.CBVPfinance.ItemHeight = 30
        Me.CBVPfinance.ItemsAppearance.Parent = Me.CBVPfinance
        Me.CBVPfinance.Location = New System.Drawing.Point(273, 273)
        Me.CBVPfinance.Name = "CBVPfinance"
        Me.CBVPfinance.ShadowDecoration.Parent = Me.CBVPfinance
        Me.CBVPfinance.Size = New System.Drawing.Size(554, 36)
        Me.CBVPfinance.TabIndex = 36
        Me.CBVPfinance.Tag = "3"
        '
        'CBViceEPresident
        '
        Me.CBViceEPresident.BackColor = System.Drawing.Color.Transparent
        Me.CBViceEPresident.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CBViceEPresident.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBViceEPresident.FocusedColor = System.Drawing.Color.Empty
        Me.CBViceEPresident.FocusedState.Parent = Me.CBViceEPresident
        Me.CBViceEPresident.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.CBViceEPresident.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.CBViceEPresident.FormattingEnabled = True
        Me.CBViceEPresident.HoverState.Parent = Me.CBViceEPresident
        Me.CBViceEPresident.ItemHeight = 30
        Me.CBViceEPresident.ItemsAppearance.Parent = Me.CBViceEPresident
        Me.CBViceEPresident.Location = New System.Drawing.Point(273, 197)
        Me.CBViceEPresident.Name = "CBViceEPresident"
        Me.CBViceEPresident.ShadowDecoration.Parent = Me.CBViceEPresident
        Me.CBViceEPresident.Size = New System.Drawing.Size(554, 36)
        Me.CBViceEPresident.TabIndex = 32
        Me.CBViceEPresident.Tag = "2"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(269, 173)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(176, 21)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "Executive Vice President"
        '
        'CBPresident
        '
        Me.CBPresident.BackColor = System.Drawing.Color.Transparent
        Me.CBPresident.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CBPresident.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBPresident.FocusedColor = System.Drawing.Color.Empty
        Me.CBPresident.FocusedState.Parent = Me.CBPresident
        Me.CBPresident.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.CBPresident.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.CBPresident.FormattingEnabled = True
        Me.CBPresident.HoverState.Parent = Me.CBPresident
        Me.CBPresident.ItemHeight = 30
        Me.CBPresident.ItemsAppearance.Parent = Me.CBPresident
        Me.CBPresident.Location = New System.Drawing.Point(273, 127)
        Me.CBPresident.Name = "CBPresident"
        Me.CBPresident.ShadowDecoration.Parent = Me.CBPresident
        Me.CBPresident.Size = New System.Drawing.Size(554, 36)
        Me.CBPresident.TabIndex = 31
        Me.CBPresident.Tag = "1"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(269, 103)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 21)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "President"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(29, 388)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 21)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Description"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(29, 301)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 21)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Name"
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
        Me.ButtonClear.Location = New System.Drawing.Point(33, 258)
        Me.ButtonClear.Name = "ButtonClear"
        Me.ButtonClear.ShadowDecoration.Parent = Me.ButtonClear
        Me.ButtonClear.Size = New System.Drawing.Size(220, 27)
        Me.ButtonClear.TabIndex = 22
        Me.ButtonClear.Text = "Clear Picture"
        '
        'Guna2GradientPanel1
        '
        Me.Guna2GradientPanel1.Controls.Add(Me.Label9)
        Me.Guna2GradientPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2GradientPanel1.FillColor = System.Drawing.Color.FromArgb(CType(CType(173, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.Guna2GradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Guna2GradientPanel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2GradientPanel1.Name = "Guna2GradientPanel1"
        Me.Guna2GradientPanel1.ShadowDecoration.Parent = Me.Guna2GradientPanel1
        Me.Guna2GradientPanel1.Size = New System.Drawing.Size(909, 66)
        Me.Guna2GradientPanel1.TabIndex = 42
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Poppins", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label9.Location = New System.Drawing.Point(12, 9)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(182, 56)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "Add Party"
        '
        'pictureboxpartylist
        '
        Me.pictureboxpartylist.BackColor = System.Drawing.Color.White
        Me.pictureboxpartylist.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pictureboxpartylist.FillColor = System.Drawing.Color.White
        Me.pictureboxpartylist.Location = New System.Drawing.Point(33, 103)
        Me.pictureboxpartylist.Name = "pictureboxpartylist"
        Me.pictureboxpartylist.ShadowDecoration.Parent = Me.pictureboxpartylist
        Me.pictureboxpartylist.Size = New System.Drawing.Size(220, 149)
        Me.pictureboxpartylist.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pictureboxpartylist.TabIndex = 21
        Me.pictureboxpartylist.TabStop = False
        '
        'AddParty
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(909, 670)
        Me.Controls.Add(Me.Guna2GradientPanel1)
        Me.Controls.Add(Me.ErrorName)
        Me.Controls.Add(Me.ButtonDiscard)
        Me.Controls.Add(Me.btnsave)
        Me.Controls.Add(Me.txtdescriptionparty)
        Me.Controls.Add(Me.txtpartyname)
        Me.Controls.Add(Me.CBActivities)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.CBVPactivities)
        Me.Controls.Add(Me.CbDocumentation)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.CBCOMMARKETING)
        Me.Controls.Add(Me.CBComnMarketing)
        Me.Controls.Add(Me.CBVPfinance)
        Me.Controls.Add(Me.CBViceEPresident)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.CBPresident)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ButtonClear)
        Me.Controls.Add(Me.pictureboxpartylist)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AddParty"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AddParty"
        Me.TopMost = True
        Me.Guna2GradientPanel1.ResumeLayout(False)
        Me.Guna2GradientPanel1.PerformLayout()
        CType(Me.pictureboxpartylist, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents ErrorName As Label
    Friend WithEvents ButtonDiscard As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnsave As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txtdescriptionparty As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtpartyname As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents CBActivities As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents CBVPactivities As Label
    Friend WithEvents CbDocumentation As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents CBCOMMARKETING As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents CBComnMarketing As Label
    Friend WithEvents CBVPfinance As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents CBViceEPresident As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents CBPresident As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ButtonClear As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents pictureboxpartylist As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Guna2GradientPanel1 As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents Label9 As Label
End Class
