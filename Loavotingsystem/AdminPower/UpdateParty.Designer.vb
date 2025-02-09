<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UpdateParty
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
        Me.CBPresident = New Guna.UI2.WinForms.Guna2TextBox()
        Me.ErrorName = New System.Windows.Forms.Label()
        Me.ButtonDiscard = New Guna.UI2.WinForms.Guna2Button()
        Me.txtdescription = New Guna.UI2.WinForms.Guna2TextBox()
        Me.texttitle = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ButtonClear = New Guna.UI2.WinForms.Guna2Button()
        Me.Picturebox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.CBViceEPresident = New Guna.UI2.WinForms.Guna2TextBox()
        Me.CBVPfinance = New Guna.UI2.WinForms.Guna2TextBox()
        Me.CBActivities = New Guna.UI2.WinForms.Guna2TextBox()
        Me.CBCOMMARKETING = New Guna.UI2.WinForms.Guna2TextBox()
        Me.CbDocumentation = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btnUpdate = New Guna.UI2.WinForms.Guna2Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Guna2GradientPanel1 = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.Label9 = New System.Windows.Forms.Label()
        CType(Me.Picturebox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2GradientPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'CBPresident
        '
        Me.CBPresident.BorderRadius = 5
        Me.CBPresident.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.CBPresident.DefaultText = ""
        Me.CBPresident.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.CBPresident.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.CBPresident.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.CBPresident.DisabledState.Parent = Me.CBPresident
        Me.CBPresident.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.CBPresident.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CBPresident.FocusedState.Parent = Me.CBPresident
        Me.CBPresident.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CBPresident.HoverState.Parent = Me.CBPresident
        Me.CBPresident.Location = New System.Drawing.Point(266, 145)
        Me.CBPresident.Margin = New System.Windows.Forms.Padding(14, 18, 14, 18)
        Me.CBPresident.Name = "CBPresident"
        Me.CBPresident.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.CBPresident.PlaceholderText = "(e.g. John)"
        Me.CBPresident.SelectedText = ""
        Me.CBPresident.ShadowDecoration.Parent = Me.CBPresident
        Me.CBPresident.Size = New System.Drawing.Size(301, 34)
        Me.CBPresident.TabIndex = 94
        '
        'ErrorName
        '
        Me.ErrorName.AutoSize = True
        Me.ErrorName.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.ErrorName.ForeColor = System.Drawing.Color.Red
        Me.ErrorName.Location = New System.Drawing.Point(19, 394)
        Me.ErrorName.Name = "ErrorName"
        Me.ErrorName.Size = New System.Drawing.Size(0, 13)
        Me.ErrorName.TabIndex = 93
        '
        'ButtonDiscard
        '
        Me.ButtonDiscard.Animated = True
        Me.ButtonDiscard.BorderRadius = 9
        Me.ButtonDiscard.CheckedState.Parent = Me.ButtonDiscard
        Me.ButtonDiscard.CustomImages.Parent = Me.ButtonDiscard
        Me.ButtonDiscard.FillColor = System.Drawing.SystemColors.Control
        Me.ButtonDiscard.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.ButtonDiscard.ForeColor = System.Drawing.Color.Gray
        Me.ButtonDiscard.HoverState.Parent = Me.ButtonDiscard
        Me.ButtonDiscard.Location = New System.Drawing.Point(323, 559)
        Me.ButtonDiscard.Name = "ButtonDiscard"
        Me.ButtonDiscard.ShadowDecoration.Parent = Me.ButtonDiscard
        Me.ButtonDiscard.Size = New System.Drawing.Size(112, 37)
        Me.ButtonDiscard.TabIndex = 91
        Me.ButtonDiscard.Text = "Discard"
        '
        'txtdescription
        '
        Me.txtdescription.BorderRadius = 9
        Me.txtdescription.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtdescription.DefaultText = ""
        Me.txtdescription.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtdescription.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtdescription.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtdescription.DisabledState.Parent = Me.txtdescription
        Me.txtdescription.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtdescription.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtdescription.FocusedState.Parent = Me.txtdescription
        Me.txtdescription.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtdescription.HoverState.Parent = Me.txtdescription
        Me.txtdescription.Location = New System.Drawing.Point(21, 414)
        Me.txtdescription.Margin = New System.Windows.Forms.Padding(6, 7, 6, 7)
        Me.txtdescription.Multiline = True
        Me.txtdescription.Name = "txtdescription"
        Me.txtdescription.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtdescription.PlaceholderText = ""
        Me.txtdescription.SelectedText = ""
        Me.txtdescription.ShadowDecoration.Parent = Me.txtdescription
        Me.txtdescription.Size = New System.Drawing.Size(220, 115)
        Me.txtdescription.TabIndex = 90
        '
        'texttitle
        '
        Me.texttitle.BorderRadius = 9
        Me.texttitle.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.texttitle.DefaultText = ""
        Me.texttitle.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.texttitle.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.texttitle.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.texttitle.DisabledState.Parent = Me.texttitle
        Me.texttitle.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.texttitle.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.texttitle.FocusedState.Parent = Me.texttitle
        Me.texttitle.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.texttitle.HoverState.Parent = Me.texttitle
        Me.texttitle.Location = New System.Drawing.Point(21, 344)
        Me.texttitle.Margin = New System.Windows.Forms.Padding(6, 7, 6, 7)
        Me.texttitle.Name = "texttitle"
        Me.texttitle.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.texttitle.PlaceholderText = ""
        Me.texttitle.SelectedText = ""
        Me.texttitle.ShadowDecoration.Parent = Me.texttitle
        Me.texttitle.Size = New System.Drawing.Size(220, 30)
        Me.texttitle.TabIndex = 89
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label5.Location = New System.Drawing.Point(262, 257)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(101, 28)
        Me.Label5.TabIndex = 81
        Me.Label5.Text = "VP FINANCE"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label7.Location = New System.Drawing.Point(262, 327)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(117, 28)
        Me.Label7.TabIndex = 82
        Me.Label7.Text = "VP ACTIVITIES"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label8.Location = New System.Drawing.Point(262, 466)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(173, 28)
        Me.Label8.TabIndex = 83
        Me.Label8.Text = "VP DOCUMENTATION"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label6.Location = New System.Drawing.Point(262, 394)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(309, 28)
        Me.Label6.TabIndex = 80
        Me.Label6.Text = "VP COMMUNICATION AND MARKETING "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label4.Location = New System.Drawing.Point(262, 187)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(219, 28)
        Me.Label4.TabIndex = 79
        Me.Label4.Text = "EXECUTIVE VICE PRESIDENT "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label3.Location = New System.Drawing.Point(262, 117)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 28)
        Me.Label3.TabIndex = 78
        Me.Label3.Text = "PRESIDENT "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(18, 386)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(105, 28)
        Me.Label2.TabIndex = 77
        Me.Label2.Text = "Description:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(18, 315)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 28)
        Me.Label1.TabIndex = 76
        Me.Label1.Text = "Name:"
        '
        'ButtonClear
        '
        Me.ButtonClear.Animated = True
        Me.ButtonClear.BorderRadius = 9
        Me.ButtonClear.CheckedState.Parent = Me.ButtonClear
        Me.ButtonClear.CustomImages.Parent = Me.ButtonClear
        Me.ButtonClear.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.ButtonClear.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ButtonClear.ForeColor = System.Drawing.Color.White
        Me.ButtonClear.HoverState.Parent = Me.ButtonClear
        Me.ButtonClear.Location = New System.Drawing.Point(22, 272)
        Me.ButtonClear.Name = "ButtonClear"
        Me.ButtonClear.ShadowDecoration.Parent = Me.ButtonClear
        Me.ButtonClear.Size = New System.Drawing.Size(220, 27)
        Me.ButtonClear.TabIndex = 75
        Me.ButtonClear.Text = "Clear Picture"
        '
        'Picturebox1
        '
        Me.Picturebox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.Picturebox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Picturebox1.BorderRadius = 9
        Me.Picturebox1.FillColor = System.Drawing.Color.White
        Me.Picturebox1.Location = New System.Drawing.Point(22, 117)
        Me.Picturebox1.Name = "Picturebox1"
        Me.Picturebox1.ShadowDecoration.Parent = Me.Picturebox1
        Me.Picturebox1.Size = New System.Drawing.Size(220, 149)
        Me.Picturebox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Picturebox1.TabIndex = 74
        Me.Picturebox1.TabStop = False
        '
        'CBViceEPresident
        '
        Me.CBViceEPresident.BorderRadius = 5
        Me.CBViceEPresident.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.CBViceEPresident.DefaultText = ""
        Me.CBViceEPresident.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.CBViceEPresident.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.CBViceEPresident.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.CBViceEPresident.DisabledState.Parent = Me.CBViceEPresident
        Me.CBViceEPresident.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.CBViceEPresident.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CBViceEPresident.FocusedState.Parent = Me.CBViceEPresident
        Me.CBViceEPresident.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CBViceEPresident.HoverState.Parent = Me.CBViceEPresident
        Me.CBViceEPresident.Location = New System.Drawing.Point(266, 215)
        Me.CBViceEPresident.Margin = New System.Windows.Forms.Padding(14, 18, 14, 18)
        Me.CBViceEPresident.Name = "CBViceEPresident"
        Me.CBViceEPresident.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.CBViceEPresident.PlaceholderText = "(e.g. John)"
        Me.CBViceEPresident.SelectedText = ""
        Me.CBViceEPresident.ShadowDecoration.Parent = Me.CBViceEPresident
        Me.CBViceEPresident.Size = New System.Drawing.Size(301, 34)
        Me.CBViceEPresident.TabIndex = 94
        '
        'CBVPfinance
        '
        Me.CBVPfinance.BorderRadius = 5
        Me.CBVPfinance.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.CBVPfinance.DefaultText = ""
        Me.CBVPfinance.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.CBVPfinance.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.CBVPfinance.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.CBVPfinance.DisabledState.Parent = Me.CBVPfinance
        Me.CBVPfinance.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.CBVPfinance.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CBVPfinance.FocusedState.Parent = Me.CBVPfinance
        Me.CBVPfinance.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CBVPfinance.HoverState.Parent = Me.CBVPfinance
        Me.CBVPfinance.Location = New System.Drawing.Point(266, 285)
        Me.CBVPfinance.Margin = New System.Windows.Forms.Padding(14, 18, 14, 18)
        Me.CBVPfinance.Name = "CBVPfinance"
        Me.CBVPfinance.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.CBVPfinance.PlaceholderText = "(e.g. John)"
        Me.CBVPfinance.SelectedText = ""
        Me.CBVPfinance.ShadowDecoration.Parent = Me.CBVPfinance
        Me.CBVPfinance.Size = New System.Drawing.Size(301, 34)
        Me.CBVPfinance.TabIndex = 94
        '
        'CBActivities
        '
        Me.CBActivities.BorderRadius = 5
        Me.CBActivities.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.CBActivities.DefaultText = ""
        Me.CBActivities.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.CBActivities.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.CBActivities.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.CBActivities.DisabledState.Parent = Me.CBActivities
        Me.CBActivities.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.CBActivities.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CBActivities.FocusedState.Parent = Me.CBActivities
        Me.CBActivities.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CBActivities.HoverState.Parent = Me.CBActivities
        Me.CBActivities.Location = New System.Drawing.Point(265, 355)
        Me.CBActivities.Margin = New System.Windows.Forms.Padding(14, 18, 14, 18)
        Me.CBActivities.Name = "CBActivities"
        Me.CBActivities.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.CBActivities.PlaceholderText = "(e.g. John)"
        Me.CBActivities.SelectedText = ""
        Me.CBActivities.ShadowDecoration.Parent = Me.CBActivities
        Me.CBActivities.Size = New System.Drawing.Size(301, 34)
        Me.CBActivities.TabIndex = 94
        '
        'CBCOMMARKETING
        '
        Me.CBCOMMARKETING.BorderRadius = 5
        Me.CBCOMMARKETING.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.CBCOMMARKETING.DefaultText = ""
        Me.CBCOMMARKETING.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.CBCOMMARKETING.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.CBCOMMARKETING.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.CBCOMMARKETING.DisabledState.Parent = Me.CBCOMMARKETING
        Me.CBCOMMARKETING.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.CBCOMMARKETING.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CBCOMMARKETING.FocusedState.Parent = Me.CBCOMMARKETING
        Me.CBCOMMARKETING.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CBCOMMARKETING.HoverState.Parent = Me.CBCOMMARKETING
        Me.CBCOMMARKETING.Location = New System.Drawing.Point(265, 425)
        Me.CBCOMMARKETING.Margin = New System.Windows.Forms.Padding(14, 18, 14, 18)
        Me.CBCOMMARKETING.Name = "CBCOMMARKETING"
        Me.CBCOMMARKETING.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.CBCOMMARKETING.PlaceholderText = "(e.g. John)"
        Me.CBCOMMARKETING.SelectedText = ""
        Me.CBCOMMARKETING.ShadowDecoration.Parent = Me.CBCOMMARKETING
        Me.CBCOMMARKETING.Size = New System.Drawing.Size(301, 34)
        Me.CBCOMMARKETING.TabIndex = 94
        '
        'CbDocumentation
        '
        Me.CbDocumentation.BorderRadius = 5
        Me.CbDocumentation.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.CbDocumentation.DefaultText = ""
        Me.CbDocumentation.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.CbDocumentation.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.CbDocumentation.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.CbDocumentation.DisabledState.Parent = Me.CbDocumentation
        Me.CbDocumentation.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.CbDocumentation.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CbDocumentation.FocusedState.Parent = Me.CbDocumentation
        Me.CbDocumentation.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CbDocumentation.HoverState.Parent = Me.CbDocumentation
        Me.CbDocumentation.Location = New System.Drawing.Point(266, 495)
        Me.CbDocumentation.Margin = New System.Windows.Forms.Padding(14, 18, 14, 18)
        Me.CbDocumentation.Name = "CbDocumentation"
        Me.CbDocumentation.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.CbDocumentation.PlaceholderText = "(e.g. John)"
        Me.CbDocumentation.SelectedText = ""
        Me.CbDocumentation.ShadowDecoration.Parent = Me.CbDocumentation
        Me.CbDocumentation.Size = New System.Drawing.Size(301, 34)
        Me.CbDocumentation.TabIndex = 94
        '
        'btnUpdate
        '
        Me.btnUpdate.BorderRadius = 9
        Me.btnUpdate.CheckedState.Parent = Me.btnUpdate
        Me.btnUpdate.CustomImages.Parent = Me.btnUpdate
        Me.btnUpdate.FillColor = System.Drawing.Color.FromArgb(CType(CType(199, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.btnUpdate.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.btnUpdate.ForeColor = System.Drawing.Color.White
        Me.btnUpdate.HoverState.Parent = Me.btnUpdate
        Me.btnUpdate.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnUpdate.ImageOffset = New System.Drawing.Point(1, 1)
        Me.btnUpdate.ImageSize = New System.Drawing.Size(15, 15)
        Me.btnUpdate.Location = New System.Drawing.Point(447, 559)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.ShadowDecoration.Parent = Me.btnUpdate
        Me.btnUpdate.Size = New System.Drawing.Size(119, 38)
        Me.btnUpdate.TabIndex = 96
        Me.btnUpdate.Text = "Update"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
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
        Me.Guna2GradientPanel1.Size = New System.Drawing.Size(590, 66)
        Me.Guna2GradientPanel1.TabIndex = 97
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Poppins", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label9.Location = New System.Drawing.Point(12, 9)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(236, 56)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "Update Party"
        '
        'UpdateParty
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(590, 635)
        Me.Controls.Add(Me.Guna2GradientPanel1)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.CbDocumentation)
        Me.Controls.Add(Me.CBCOMMARKETING)
        Me.Controls.Add(Me.CBActivities)
        Me.Controls.Add(Me.CBVPfinance)
        Me.Controls.Add(Me.CBViceEPresident)
        Me.Controls.Add(Me.CBPresident)
        Me.Controls.Add(Me.ErrorName)
        Me.Controls.Add(Me.ButtonDiscard)
        Me.Controls.Add(Me.txtdescription)
        Me.Controls.Add(Me.texttitle)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ButtonClear)
        Me.Controls.Add(Me.Picturebox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "UpdateParty"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "UpdateParty"
        Me.TopMost = True
        CType(Me.Picturebox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2GradientPanel1.ResumeLayout(False)
        Me.Guna2GradientPanel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CBPresident As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents ErrorName As Label
    Friend WithEvents ButtonDiscard As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txtdescription As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents texttitle As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ButtonClear As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Picturebox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents CBViceEPresident As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents CBVPfinance As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents CBActivities As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents CBCOMMARKETING As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents CbDocumentation As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnUpdate As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents Guna2GradientPanel1 As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents Label9 As Label
End Class
