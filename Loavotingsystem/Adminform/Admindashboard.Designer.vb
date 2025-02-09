<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Admindashboard
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
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Panelsidemenu = New System.Windows.Forms.Panel()
        Me.Guna2CirclePictureBox1 = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        Me.PanelButtonGroup = New System.Windows.Forms.FlowLayoutPanel()
        Me.ButtonHome = New Guna.UI2.WinForms.Guna2Button()
        Me.buttonvoters = New Guna.UI2.WinForms.Guna2Button()
        Me.ButtonCandidate = New Guna.UI2.WinForms.Guna2Button()
        Me.ButtonParty = New Guna.UI2.WinForms.Guna2Button()
        Me.Buttonsettings = New Guna.UI2.WinForms.Guna2Button()
        Me.btnlogout = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2ControlBox2 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Guna2ControlBox1 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Guna2ControlBox3 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnnewelection = New Guna.UI2.WinForms.Guna2Button()
        Me.ChipElectionStatus = New Guna.UI2.WinForms.Guna2Chip()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lbltimeremaining = New System.Windows.Forms.Label()
        Me.lblelectionnew = New System.Windows.Forms.Label()
        Me.lblelectionend = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lbldatetime = New System.Windows.Forms.Label()
        Me.lblname = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.mainform = New System.Windows.Forms.Panel()
        Me.Timers = New System.Windows.Forms.Timer(Me.components)
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.electionTimer = New System.Windows.Forms.Timer(Me.components)
        Me.Panelsidemenu.SuspendLayout()
        CType(Me.Guna2CirclePictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelButtonGroup.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.BorderRadius = 3
        '
        'Panelsidemenu
        '
        Me.Panelsidemenu.AutoScroll = True
        Me.Panelsidemenu.BackColor = System.Drawing.Color.Gainsboro
        Me.Panelsidemenu.Controls.Add(Me.Guna2CirclePictureBox1)
        Me.Panelsidemenu.Controls.Add(Me.PanelButtonGroup)
        Me.Panelsidemenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panelsidemenu.Location = New System.Drawing.Point(0, 0)
        Me.Panelsidemenu.Name = "Panelsidemenu"
        Me.Panelsidemenu.Size = New System.Drawing.Size(220, 779)
        Me.Panelsidemenu.TabIndex = 3
        '
        'Guna2CirclePictureBox1
        '
        Me.Guna2CirclePictureBox1.Image = Global.Loavotingsystem.My.Resources.Resources.loalogo
        Me.Guna2CirclePictureBox1.Location = New System.Drawing.Point(47, 12)
        Me.Guna2CirclePictureBox1.Name = "Guna2CirclePictureBox1"
        Me.Guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.Guna2CirclePictureBox1.ShadowDecoration.Parent = Me.Guna2CirclePictureBox1
        Me.Guna2CirclePictureBox1.Size = New System.Drawing.Size(123, 119)
        Me.Guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2CirclePictureBox1.TabIndex = 7
        Me.Guna2CirclePictureBox1.TabStop = False
        '
        'PanelButtonGroup
        '
        Me.PanelButtonGroup.Controls.Add(Me.ButtonHome)
        Me.PanelButtonGroup.Controls.Add(Me.buttonvoters)
        Me.PanelButtonGroup.Controls.Add(Me.ButtonCandidate)
        Me.PanelButtonGroup.Controls.Add(Me.ButtonParty)
        Me.PanelButtonGroup.Controls.Add(Me.Buttonsettings)
        Me.PanelButtonGroup.Controls.Add(Me.btnlogout)
        Me.PanelButtonGroup.Location = New System.Drawing.Point(1, 163)
        Me.PanelButtonGroup.Name = "PanelButtonGroup"
        Me.PanelButtonGroup.Size = New System.Drawing.Size(219, 332)
        Me.PanelButtonGroup.TabIndex = 6
        '
        'ButtonHome
        '
        Me.ButtonHome.Animated = True
        Me.ButtonHome.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton
        Me.ButtonHome.Checked = True
        Me.ButtonHome.CheckedState.ForeColor = System.Drawing.Color.White
        Me.ButtonHome.CheckedState.Parent = Me.ButtonHome
        Me.ButtonHome.CustomImages.Parent = Me.ButtonHome
        Me.ButtonHome.FillColor = System.Drawing.Color.Transparent
        Me.ButtonHome.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ButtonHome.ForeColor = System.Drawing.Color.Black
        Me.ButtonHome.HoverState.Parent = Me.ButtonHome
        Me.ButtonHome.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.ButtonHome.Location = New System.Drawing.Point(0, 0)
        Me.ButtonHome.Margin = New System.Windows.Forms.Padding(0)
        Me.ButtonHome.Name = "ButtonHome"
        Me.ButtonHome.ShadowDecoration.Parent = Me.ButtonHome
        Me.ButtonHome.Size = New System.Drawing.Size(220, 45)
        Me.ButtonHome.TabIndex = 0
        Me.ButtonHome.Text = "Home"
        '
        'buttonvoters
        '
        Me.buttonvoters.Animated = True
        Me.buttonvoters.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton
        Me.buttonvoters.CheckedState.ForeColor = System.Drawing.Color.White
        Me.buttonvoters.CheckedState.Parent = Me.buttonvoters
        Me.buttonvoters.CustomImages.Parent = Me.buttonvoters
        Me.buttonvoters.FillColor = System.Drawing.Color.Transparent
        Me.buttonvoters.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.buttonvoters.ForeColor = System.Drawing.Color.Black
        Me.buttonvoters.HoverState.Parent = Me.buttonvoters
        Me.buttonvoters.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.buttonvoters.Location = New System.Drawing.Point(0, 45)
        Me.buttonvoters.Margin = New System.Windows.Forms.Padding(0)
        Me.buttonvoters.Name = "buttonvoters"
        Me.buttonvoters.ShadowDecoration.Parent = Me.buttonvoters
        Me.buttonvoters.Size = New System.Drawing.Size(220, 45)
        Me.buttonvoters.TabIndex = 1
        Me.buttonvoters.Text = "Voters"
        '
        'ButtonCandidate
        '
        Me.ButtonCandidate.Animated = True
        Me.ButtonCandidate.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton
        Me.ButtonCandidate.CheckedState.ForeColor = System.Drawing.Color.White
        Me.ButtonCandidate.CheckedState.Parent = Me.ButtonCandidate
        Me.ButtonCandidate.CustomImages.Parent = Me.ButtonCandidate
        Me.ButtonCandidate.FillColor = System.Drawing.Color.Transparent
        Me.ButtonCandidate.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ButtonCandidate.ForeColor = System.Drawing.Color.Black
        Me.ButtonCandidate.HoverState.Parent = Me.ButtonCandidate
        Me.ButtonCandidate.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.ButtonCandidate.Location = New System.Drawing.Point(0, 90)
        Me.ButtonCandidate.Margin = New System.Windows.Forms.Padding(0)
        Me.ButtonCandidate.Name = "ButtonCandidate"
        Me.ButtonCandidate.ShadowDecoration.Parent = Me.ButtonCandidate
        Me.ButtonCandidate.Size = New System.Drawing.Size(220, 45)
        Me.ButtonCandidate.TabIndex = 2
        Me.ButtonCandidate.Text = "Candidates"
        '
        'ButtonParty
        '
        Me.ButtonParty.Animated = True
        Me.ButtonParty.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton
        Me.ButtonParty.CheckedState.ForeColor = System.Drawing.Color.White
        Me.ButtonParty.CheckedState.Parent = Me.ButtonParty
        Me.ButtonParty.CustomImages.Parent = Me.ButtonParty
        Me.ButtonParty.FillColor = System.Drawing.Color.Transparent
        Me.ButtonParty.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ButtonParty.ForeColor = System.Drawing.Color.Black
        Me.ButtonParty.HoverState.Parent = Me.ButtonParty
        Me.ButtonParty.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.ButtonParty.Location = New System.Drawing.Point(0, 135)
        Me.ButtonParty.Margin = New System.Windows.Forms.Padding(0)
        Me.ButtonParty.Name = "ButtonParty"
        Me.ButtonParty.ShadowDecoration.Parent = Me.ButtonParty
        Me.ButtonParty.Size = New System.Drawing.Size(220, 45)
        Me.ButtonParty.TabIndex = 3
        Me.ButtonParty.Text = "Party"
        '
        'Buttonsettings
        '
        Me.Buttonsettings.Animated = True
        Me.Buttonsettings.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton
        Me.Buttonsettings.CheckedState.ForeColor = System.Drawing.Color.White
        Me.Buttonsettings.CheckedState.Parent = Me.Buttonsettings
        Me.Buttonsettings.CustomImages.Parent = Me.Buttonsettings
        Me.Buttonsettings.FillColor = System.Drawing.Color.Transparent
        Me.Buttonsettings.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Buttonsettings.ForeColor = System.Drawing.Color.Black
        Me.Buttonsettings.HoverState.Parent = Me.Buttonsettings
        Me.Buttonsettings.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.Buttonsettings.Location = New System.Drawing.Point(0, 180)
        Me.Buttonsettings.Margin = New System.Windows.Forms.Padding(0)
        Me.Buttonsettings.Name = "Buttonsettings"
        Me.Buttonsettings.ShadowDecoration.Parent = Me.Buttonsettings
        Me.Buttonsettings.Size = New System.Drawing.Size(220, 45)
        Me.Buttonsettings.TabIndex = 4
        Me.Buttonsettings.Text = "Settings"
        '
        'btnlogout
        '
        Me.btnlogout.Animated = True
        Me.btnlogout.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton
        Me.btnlogout.CausesValidation = False
        Me.btnlogout.CheckedState.ForeColor = System.Drawing.Color.White
        Me.btnlogout.CheckedState.Parent = Me.btnlogout
        Me.btnlogout.CustomImages.Parent = Me.btnlogout
        Me.btnlogout.FillColor = System.Drawing.Color.Transparent
        Me.btnlogout.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnlogout.ForeColor = System.Drawing.Color.Black
        Me.btnlogout.HoverState.Parent = Me.btnlogout
        Me.btnlogout.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnlogout.Location = New System.Drawing.Point(0, 225)
        Me.btnlogout.Margin = New System.Windows.Forms.Padding(0)
        Me.btnlogout.Name = "btnlogout"
        Me.btnlogout.ShadowDecoration.Parent = Me.btnlogout
        Me.btnlogout.Size = New System.Drawing.Size(220, 45)
        Me.btnlogout.TabIndex = 7
        Me.btnlogout.Text = "Logout"
        '
        'Guna2ControlBox2
        '
        Me.Guna2ControlBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MaximizeBox
        Me.Guna2ControlBox2.FillColor = System.Drawing.Color.Transparent
        Me.Guna2ControlBox2.HoverState.Parent = Me.Guna2ControlBox2
        Me.Guna2ControlBox2.IconColor = System.Drawing.Color.White
        Me.Guna2ControlBox2.Location = New System.Drawing.Point(957, 3)
        Me.Guna2ControlBox2.Name = "Guna2ControlBox2"
        Me.Guna2ControlBox2.ShadowDecoration.Parent = Me.Guna2ControlBox2
        Me.Guna2ControlBox2.Size = New System.Drawing.Size(28, 25)
        Me.Guna2ControlBox2.TabIndex = 21
        '
        'Guna2ControlBox1
        '
        Me.Guna2ControlBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2ControlBox1.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox
        Me.Guna2ControlBox1.FillColor = System.Drawing.Color.Transparent
        Me.Guna2ControlBox1.HoverState.Parent = Me.Guna2ControlBox1
        Me.Guna2ControlBox1.IconColor = System.Drawing.Color.White
        Me.Guna2ControlBox1.Location = New System.Drawing.Point(932, 3)
        Me.Guna2ControlBox1.Name = "Guna2ControlBox1"
        Me.Guna2ControlBox1.ShadowDecoration.Parent = Me.Guna2ControlBox1
        Me.Guna2ControlBox1.Size = New System.Drawing.Size(28, 25)
        Me.Guna2ControlBox1.TabIndex = 20
        '
        'Guna2ControlBox3
        '
        Me.Guna2ControlBox3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2ControlBox3.FillColor = System.Drawing.Color.Transparent
        Me.Guna2ControlBox3.HoverState.Parent = Me.Guna2ControlBox3
        Me.Guna2ControlBox3.IconColor = System.Drawing.Color.White
        Me.Guna2ControlBox3.Location = New System.Drawing.Point(976, 3)
        Me.Guna2ControlBox3.Name = "Guna2ControlBox3"
        Me.Guna2ControlBox3.ShadowDecoration.Parent = Me.Guna2ControlBox3
        Me.Guna2ControlBox3.Size = New System.Drawing.Size(28, 25)
        Me.Guna2ControlBox3.TabIndex = 19
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btnnewelection)
        Me.Panel1.Controls.Add(Me.ChipElectionStatus)
        Me.Panel1.Controls.Add(Me.Guna2ControlBox3)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.lbltimeremaining)
        Me.Panel1.Controls.Add(Me.lblelectionnew)
        Me.Panel1.Controls.Add(Me.lblelectionend)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.lbldatetime)
        Me.Panel1.Controls.Add(Me.Guna2ControlBox1)
        Me.Panel1.Controls.Add(Me.Guna2ControlBox2)
        Me.Panel1.Controls.Add(Me.lblname)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(220, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1007, 114)
        Me.Panel1.TabIndex = 6
        '
        'btnnewelection
        '
        Me.btnnewelection.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnnewelection.BorderRadius = 10
        Me.btnnewelection.CheckedState.Parent = Me.btnnewelection
        Me.btnnewelection.CustomImages.Parent = Me.btnnewelection
        Me.btnnewelection.FillColor = System.Drawing.Color.FromArgb(CType(CType(199, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.btnnewelection.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.btnnewelection.ForeColor = System.Drawing.Color.White
        Me.btnnewelection.HoverState.Parent = Me.btnnewelection
        Me.btnnewelection.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnnewelection.ImageOffset = New System.Drawing.Point(1, 1)
        Me.btnnewelection.ImageSize = New System.Drawing.Size(15, 15)
        Me.btnnewelection.Location = New System.Drawing.Point(879, 66)
        Me.btnnewelection.Name = "btnnewelection"
        Me.btnnewelection.ShadowDecoration.Parent = Me.btnnewelection
        Me.btnnewelection.Size = New System.Drawing.Size(116, 35)
        Me.btnnewelection.TabIndex = 23
        Me.btnnewelection.Text = "New Elections:"
        '
        'ChipElectionStatus
        '
        Me.ChipElectionStatus.FillColor = System.Drawing.Color.DarkSeaGreen
        Me.ChipElectionStatus.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ChipElectionStatus.ForeColor = System.Drawing.Color.White
        Me.ChipElectionStatus.Location = New System.Drawing.Point(147, 66)
        Me.ChipElectionStatus.Name = "ChipElectionStatus"
        Me.ChipElectionStatus.ShadowDecoration.Parent = Me.ChipElectionStatus
        Me.ChipElectionStatus.Size = New System.Drawing.Size(83, 17)
        Me.ChipElectionStatus.TabIndex = 22
        Me.ChipElectionStatus.Text = "-"
        Me.ChipElectionStatus.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label9.Location = New System.Drawing.Point(15, 96)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(0, 21)
        Me.Label9.TabIndex = 15
        '
        'lbltimeremaining
        '
        Me.lbltimeremaining.AutoSize = True
        Me.lbltimeremaining.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltimeremaining.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbltimeremaining.Location = New System.Drawing.Point(159, 86)
        Me.lbltimeremaining.Name = "lbltimeremaining"
        Me.lbltimeremaining.Size = New System.Drawing.Size(45, 21)
        Me.lbltimeremaining.TabIndex = 15
        Me.lbltimeremaining.Text = "time"
        '
        'lblelectionnew
        '
        Me.lblelectionnew.AutoSize = True
        Me.lblelectionnew.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblelectionnew.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblelectionnew.Location = New System.Drawing.Point(15, 96)
        Me.lblelectionnew.Name = "lblelectionnew"
        Me.lblelectionnew.Size = New System.Drawing.Size(0, 21)
        Me.lblelectionnew.TabIndex = 15
        '
        'lblelectionend
        '
        Me.lblelectionend.AutoSize = True
        Me.lblelectionend.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblelectionend.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblelectionend.Location = New System.Drawing.Point(12, 86)
        Me.lblelectionend.Name = "lblelectionend"
        Me.lblelectionend.Size = New System.Drawing.Size(138, 21)
        Me.lblelectionend.TabIndex = 15
        Me.lblelectionend.Text = "Election will end:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label8.Location = New System.Drawing.Point(12, 62)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(129, 21)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Election Status:"
        '
        'lbldatetime
        '
        Me.lbldatetime.AutoSize = True
        Me.lbldatetime.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldatetime.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbldatetime.Location = New System.Drawing.Point(388, 19)
        Me.lbldatetime.Name = "lbldatetime"
        Me.lbldatetime.Size = New System.Drawing.Size(92, 21)
        Me.lbldatetime.TabIndex = 15
        Me.lbldatetime.Text = "Date/time"
        '
        'lblname
        '
        Me.lblname.AutoSize = True
        Me.lblname.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblname.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblname.Location = New System.Drawing.Point(133, 41)
        Me.lblname.Name = "lblname"
        Me.lblname.Size = New System.Drawing.Size(42, 21)
        Me.lblname.TabIndex = 15
        Me.lblname.Text = "User"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(12, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 21)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Logged in as:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(13, 8)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(349, 33)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Supreme Student Council"
        '
        'mainform
        '
        Me.mainform.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.mainform.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.mainform.Location = New System.Drawing.Point(220, 114)
        Me.mainform.Name = "mainform"
        Me.mainform.Size = New System.Drawing.Size(1007, 665)
        Me.mainform.TabIndex = 5
        '
        'Admindashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1227, 779)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.mainform)
        Me.Controls.Add(Me.Panelsidemenu)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Admindashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Admindashboard"
        Me.Panelsidemenu.ResumeLayout(False)
        CType(Me.Guna2CirclePictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelButtonGroup.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Panelsidemenu As Panel
    Friend WithEvents PanelButtonGroup As FlowLayoutPanel
    Friend WithEvents ButtonHome As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents buttonvoters As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents ButtonCandidate As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents ButtonParty As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Buttonsettings As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnlogout As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2CirclePictureBox1 As Guna.UI2.WinForms.Guna2CirclePictureBox
    Friend WithEvents Guna2ControlBox2 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Guna2ControlBox1 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Guna2ControlBox3 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblname As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lbldatetime As Label
    Friend WithEvents mainform As Panel
    Friend WithEvents ChipElectionStatus As Guna.UI2.WinForms.Guna2Chip
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents lbltimeremaining As Label
    Friend WithEvents lblelectionend As Label
    Friend WithEvents Timers As Timer
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents electionTimer As Timer
    Friend WithEvents lblelectionnew As Label
    Friend WithEvents btnnewelection As Guna.UI2.WinForms.Guna2Button
End Class
