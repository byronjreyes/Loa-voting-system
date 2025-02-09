<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VotingDashboard
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
        Me.components = New System.ComponentModel.Container()
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.PanelButtonGroup = New System.Windows.Forms.FlowLayoutPanel()
        Me.btncandidateinfo = New Guna.UI2.WinForms.Guna2Button()
        Me.btnpartyinfo = New Guna.UI2.WinForms.Guna2Button()
        Me.buttonvotenow = New Guna.UI2.WinForms.Guna2Button()
        Me.Buttonsettings = New Guna.UI2.WinForms.Guna2Button()
        Me.btnlogout = New Guna.UI2.WinForms.Guna2Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Guna2ControlBox3 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Guna2ControlBox1 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Panelsidemenu = New System.Windows.Forms.Panel()
        Me.Guna2CirclePictureBox1 = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        Me.lblname = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.mainform = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblfullname = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Guna2CustomGradientPanel1 = New Guna.UI2.WinForms.Guna2CustomGradientPanel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.flpMain = New System.Windows.Forms.FlowLayoutPanel()
        Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Me.ButtonPresident = New Guna.UI2.WinForms.Guna2Button()
        Me.ButtonEVPresident = New Guna.UI2.WinForms.Guna2Button()
        Me.ButtonVFinance = New Guna.UI2.WinForms.Guna2Button()
        Me.ButtonVActivities = New Guna.UI2.WinForms.Guna2Button()
        Me.ButtonVComMarketing = New Guna.UI2.WinForms.Guna2Button()
        Me.ButtonVDocumentation = New Guna.UI2.WinForms.Guna2Button()
        Me.PanelButtonGroup.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panelsidemenu.SuspendLayout()
        CType(Me.Guna2CirclePictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.mainform.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Guna2CustomGradientPanel1.SuspendLayout()
        Me.FlowLayoutPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.BorderRadius = 3
        '
        'PanelButtonGroup
        '
        Me.PanelButtonGroup.Controls.Add(Me.btncandidateinfo)
        Me.PanelButtonGroup.Controls.Add(Me.btnpartyinfo)
        Me.PanelButtonGroup.Controls.Add(Me.buttonvotenow)
        Me.PanelButtonGroup.Controls.Add(Me.Buttonsettings)
        Me.PanelButtonGroup.Controls.Add(Me.btnlogout)
        Me.PanelButtonGroup.Location = New System.Drawing.Point(1, 163)
        Me.PanelButtonGroup.Name = "PanelButtonGroup"
        Me.PanelButtonGroup.Size = New System.Drawing.Size(219, 332)
        Me.PanelButtonGroup.TabIndex = 6
        '
        'btncandidateinfo
        '
        Me.btncandidateinfo.Animated = True
        Me.btncandidateinfo.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton
        Me.btncandidateinfo.Checked = True
        Me.btncandidateinfo.CheckedState.ForeColor = System.Drawing.Color.White
        Me.btncandidateinfo.CheckedState.Parent = Me.btncandidateinfo
        Me.btncandidateinfo.CustomImages.Parent = Me.btncandidateinfo
        Me.btncandidateinfo.FillColor = System.Drawing.Color.Transparent
        Me.btncandidateinfo.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncandidateinfo.ForeColor = System.Drawing.Color.Black
        Me.btncandidateinfo.HoverState.Parent = Me.btncandidateinfo
        Me.btncandidateinfo.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btncandidateinfo.Location = New System.Drawing.Point(0, 0)
        Me.btncandidateinfo.Margin = New System.Windows.Forms.Padding(0)
        Me.btncandidateinfo.Name = "btncandidateinfo"
        Me.btncandidateinfo.ShadowDecoration.Parent = Me.btncandidateinfo
        Me.btncandidateinfo.Size = New System.Drawing.Size(220, 45)
        Me.btncandidateinfo.TabIndex = 0
        Me.btncandidateinfo.Text = "Candidate Information"
        '
        'btnpartyinfo
        '
        Me.btnpartyinfo.Animated = True
        Me.btnpartyinfo.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton
        Me.btnpartyinfo.CheckedState.ForeColor = System.Drawing.Color.White
        Me.btnpartyinfo.CheckedState.Parent = Me.btnpartyinfo
        Me.btnpartyinfo.CustomImages.Parent = Me.btnpartyinfo
        Me.btnpartyinfo.FillColor = System.Drawing.Color.Transparent
        Me.btnpartyinfo.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnpartyinfo.ForeColor = System.Drawing.Color.Black
        Me.btnpartyinfo.HoverState.Parent = Me.btnpartyinfo
        Me.btnpartyinfo.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnpartyinfo.Location = New System.Drawing.Point(0, 45)
        Me.btnpartyinfo.Margin = New System.Windows.Forms.Padding(0)
        Me.btnpartyinfo.Name = "btnpartyinfo"
        Me.btnpartyinfo.ShadowDecoration.Parent = Me.btnpartyinfo
        Me.btnpartyinfo.Size = New System.Drawing.Size(220, 45)
        Me.btnpartyinfo.TabIndex = 1
        Me.btnpartyinfo.Text = "Party Information"
        '
        'buttonvotenow
        '
        Me.buttonvotenow.Animated = True
        Me.buttonvotenow.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton
        Me.buttonvotenow.CheckedState.ForeColor = System.Drawing.Color.White
        Me.buttonvotenow.CheckedState.Parent = Me.buttonvotenow
        Me.buttonvotenow.CustomImages.Parent = Me.buttonvotenow
        Me.buttonvotenow.FillColor = System.Drawing.Color.Transparent
        Me.buttonvotenow.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buttonvotenow.ForeColor = System.Drawing.Color.Black
        Me.buttonvotenow.HoverState.Parent = Me.buttonvotenow
        Me.buttonvotenow.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.buttonvotenow.Location = New System.Drawing.Point(0, 90)
        Me.buttonvotenow.Margin = New System.Windows.Forms.Padding(0)
        Me.buttonvotenow.Name = "buttonvotenow"
        Me.buttonvotenow.ShadowDecoration.Parent = Me.buttonvotenow
        Me.buttonvotenow.Size = New System.Drawing.Size(220, 45)
        Me.buttonvotenow.TabIndex = 2
        Me.buttonvotenow.Text = "Vote Now!"
        '
        'Buttonsettings
        '
        Me.Buttonsettings.Animated = True
        Me.Buttonsettings.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton
        Me.Buttonsettings.CheckedState.ForeColor = System.Drawing.Color.White
        Me.Buttonsettings.CheckedState.Parent = Me.Buttonsettings
        Me.Buttonsettings.CustomImages.Parent = Me.Buttonsettings
        Me.Buttonsettings.FillColor = System.Drawing.Color.Transparent
        Me.Buttonsettings.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Buttonsettings.ForeColor = System.Drawing.Color.Black
        Me.Buttonsettings.HoverState.Parent = Me.Buttonsettings
        Me.Buttonsettings.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.Buttonsettings.Location = New System.Drawing.Point(0, 135)
        Me.Buttonsettings.Margin = New System.Windows.Forms.Padding(0)
        Me.Buttonsettings.Name = "Buttonsettings"
        Me.Buttonsettings.ShadowDecoration.Parent = Me.Buttonsettings
        Me.Buttonsettings.Size = New System.Drawing.Size(220, 45)
        Me.Buttonsettings.TabIndex = 4
        Me.Buttonsettings.Text = "Vote Count"
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
        Me.btnlogout.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnlogout.ForeColor = System.Drawing.Color.Black
        Me.btnlogout.HoverState.Parent = Me.btnlogout
        Me.btnlogout.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnlogout.Location = New System.Drawing.Point(0, 180)
        Me.btnlogout.Margin = New System.Windows.Forms.Padding(0)
        Me.btnlogout.Name = "btnlogout"
        Me.btnlogout.ShadowDecoration.Parent = Me.btnlogout
        Me.btnlogout.Size = New System.Drawing.Size(220, 45)
        Me.btnlogout.TabIndex = 7
        Me.btnlogout.Text = "Logout"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Guna2ControlBox3)
        Me.Panel1.Controls.Add(Me.Guna2ControlBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(220, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1016, 35)
        Me.Panel1.TabIndex = 9
        '
        'Guna2ControlBox3
        '
        Me.Guna2ControlBox3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2ControlBox3.FillColor = System.Drawing.Color.Transparent
        Me.Guna2ControlBox3.HoverState.Parent = Me.Guna2ControlBox3
        Me.Guna2ControlBox3.IconColor = System.Drawing.Color.White
        Me.Guna2ControlBox3.Location = New System.Drawing.Point(985, 3)
        Me.Guna2ControlBox3.Name = "Guna2ControlBox3"
        Me.Guna2ControlBox3.ShadowDecoration.Parent = Me.Guna2ControlBox3
        Me.Guna2ControlBox3.Size = New System.Drawing.Size(28, 25)
        Me.Guna2ControlBox3.TabIndex = 19
        '
        'Guna2ControlBox1
        '
        Me.Guna2ControlBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2ControlBox1.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox
        Me.Guna2ControlBox1.FillColor = System.Drawing.Color.Transparent
        Me.Guna2ControlBox1.HoverState.Parent = Me.Guna2ControlBox1
        Me.Guna2ControlBox1.IconColor = System.Drawing.Color.White
        Me.Guna2ControlBox1.Location = New System.Drawing.Point(962, 4)
        Me.Guna2ControlBox1.Name = "Guna2ControlBox1"
        Me.Guna2ControlBox1.ShadowDecoration.Parent = Me.Guna2ControlBox1
        Me.Guna2ControlBox1.Size = New System.Drawing.Size(28, 25)
        Me.Guna2ControlBox1.TabIndex = 20
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
        Me.Panelsidemenu.Size = New System.Drawing.Size(220, 743)
        Me.Panelsidemenu.TabIndex = 7
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
        'lblname
        '
        Me.lblname.AutoSize = True
        Me.lblname.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblname.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblname.Location = New System.Drawing.Point(332, 12)
        Me.lblname.Name = "lblname"
        Me.lblname.Size = New System.Drawing.Size(51, 21)
        Me.lblname.TabIndex = 15
        Me.lblname.Text = "122-2"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(18, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 21)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Logged in as:"
        '
        'Label3
        '
        Me.Label3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(126, 3)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(639, 39)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Supreme Student Council Voting System"
        '
        'mainform
        '
        Me.mainform.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.mainform.Controls.Add(Me.Panel2)
        Me.mainform.Controls.Add(Me.Label4)
        Me.mainform.Controls.Add(Me.Guna2CustomGradientPanel1)
        Me.mainform.Controls.Add(Me.flpMain)
        Me.mainform.Controls.Add(Me.FlowLayoutPanel2)
        Me.mainform.Controls.Add(Me.Label3)
        Me.mainform.Dock = System.Windows.Forms.DockStyle.Fill
        Me.mainform.Location = New System.Drawing.Point(220, 35)
        Me.mainform.Name = "mainform"
        Me.mainform.Size = New System.Drawing.Size(1016, 708)
        Me.mainform.TabIndex = 8
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.lblfullname)
        Me.Panel2.Controls.Add(Me.lblname)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 666)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1016, 42)
        Me.Panel2.TabIndex = 110
        '
        'lblfullname
        '
        Me.lblfullname.AutoSize = True
        Me.lblfullname.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblfullname.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblfullname.Location = New System.Drawing.Point(129, 12)
        Me.lblfullname.Name = "lblfullname"
        Me.lblfullname.Size = New System.Drawing.Size(97, 21)
        Me.lblfullname.TabIndex = 15
        Me.lblfullname.Text = "byron reyes"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label5.Location = New System.Drawing.Point(232, 12)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(99, 21)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Student-ID:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.Label4.Location = New System.Drawing.Point(11, 103)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(483, 19)
        Me.Label4.TabIndex = 109
        Me.Label4.Text = "Display a comprehensive breakdown of the candidates' information."
        '
        'Guna2CustomGradientPanel1
        '
        Me.Guna2CustomGradientPanel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2CustomGradientPanel1.BorderRadius = 21
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.Label2)
        Me.Guna2CustomGradientPanel1.FillColor = System.Drawing.Color.Gainsboro
        Me.Guna2CustomGradientPanel1.FillColor2 = System.Drawing.Color.Gainsboro
        Me.Guna2CustomGradientPanel1.FillColor3 = System.Drawing.Color.Gainsboro
        Me.Guna2CustomGradientPanel1.FillColor4 = System.Drawing.Color.Gainsboro
        Me.Guna2CustomGradientPanel1.Location = New System.Drawing.Point(-20, 50)
        Me.Guna2CustomGradientPanel1.Name = "Guna2CustomGradientPanel1"
        Me.Guna2CustomGradientPanel1.ShadowDecoration.Parent = Me.Guna2CustomGradientPanel1
        Me.Guna2CustomGradientPanel1.Size = New System.Drawing.Size(366, 47)
        Me.Guna2CustomGradientPanel1.TabIndex = 108
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Poppins", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(35, 7)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(266, 37)
        Me.Label2.TabIndex = 58
        Me.Label2.Text = "Candidate Informations"
        '
        'flpMain
        '
        Me.flpMain.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.flpMain.AutoScroll = True
        Me.flpMain.BackColor = System.Drawing.Color.Transparent
        Me.flpMain.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft
        Me.flpMain.Location = New System.Drawing.Point(112, 202)
        Me.flpMain.Name = "flpMain"
        Me.flpMain.Padding = New System.Windows.Forms.Padding(0, 10, 10, 10)
        Me.flpMain.Size = New System.Drawing.Size(760, 414)
        Me.flpMain.TabIndex = 107
        '
        'FlowLayoutPanel2
        '
        Me.FlowLayoutPanel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FlowLayoutPanel2.Controls.Add(Me.Guna2Button1)
        Me.FlowLayoutPanel2.Controls.Add(Me.ButtonPresident)
        Me.FlowLayoutPanel2.Controls.Add(Me.ButtonEVPresident)
        Me.FlowLayoutPanel2.Controls.Add(Me.ButtonVFinance)
        Me.FlowLayoutPanel2.Controls.Add(Me.ButtonVActivities)
        Me.FlowLayoutPanel2.Controls.Add(Me.ButtonVComMarketing)
        Me.FlowLayoutPanel2.Controls.Add(Me.ButtonVDocumentation)
        Me.FlowLayoutPanel2.Location = New System.Drawing.Point(22, 128)
        Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        Me.FlowLayoutPanel2.Size = New System.Drawing.Size(988, 30)
        Me.FlowLayoutPanel2.TabIndex = 16
        '
        'Guna2Button1
        '
        Me.Guna2Button1.Animated = True
        Me.Guna2Button1.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton
        Me.Guna2Button1.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.Guna2Button1.CheckedState.ForeColor = System.Drawing.Color.White
        Me.Guna2Button1.CheckedState.Parent = Me.Guna2Button1
        Me.Guna2Button1.CustomImages.Parent = Me.Guna2Button1
        Me.Guna2Button1.FillColor = System.Drawing.Color.LightGray
        Me.Guna2Button1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2Button1.ForeColor = System.Drawing.Color.Black
        Me.Guna2Button1.HoverState.Parent = Me.Guna2Button1
        Me.Guna2Button1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Button1.Margin = New System.Windows.Forms.Padding(0)
        Me.Guna2Button1.Name = "Guna2Button1"
        Me.Guna2Button1.ShadowDecoration.Parent = Me.Guna2Button1
        Me.Guna2Button1.Size = New System.Drawing.Size(102, 28)
        Me.Guna2Button1.TabIndex = 1
        Me.Guna2Button1.Tag = "1"
        Me.Guna2Button1.Text = "ALL"
        '
        'ButtonPresident
        '
        Me.ButtonPresident.Animated = True
        Me.ButtonPresident.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton
        Me.ButtonPresident.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.ButtonPresident.CheckedState.ForeColor = System.Drawing.Color.White
        Me.ButtonPresident.CheckedState.Parent = Me.ButtonPresident
        Me.ButtonPresident.CustomImages.Parent = Me.ButtonPresident
        Me.ButtonPresident.FillColor = System.Drawing.Color.LightGray
        Me.ButtonPresident.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ButtonPresident.ForeColor = System.Drawing.Color.Black
        Me.ButtonPresident.HoverState.Parent = Me.ButtonPresident
        Me.ButtonPresident.Location = New System.Drawing.Point(102, 0)
        Me.ButtonPresident.Margin = New System.Windows.Forms.Padding(0)
        Me.ButtonPresident.Name = "ButtonPresident"
        Me.ButtonPresident.ShadowDecoration.Parent = Me.ButtonPresident
        Me.ButtonPresident.Size = New System.Drawing.Size(102, 28)
        Me.ButtonPresident.TabIndex = 0
        Me.ButtonPresident.Tag = "1"
        Me.ButtonPresident.Text = "PRESIDENT "
        '
        'ButtonEVPresident
        '
        Me.ButtonEVPresident.Animated = True
        Me.ButtonEVPresident.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton
        Me.ButtonEVPresident.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.ButtonEVPresident.CheckedState.ForeColor = System.Drawing.Color.White
        Me.ButtonEVPresident.CheckedState.Parent = Me.ButtonEVPresident
        Me.ButtonEVPresident.CustomImages.Parent = Me.ButtonEVPresident
        Me.ButtonEVPresident.FillColor = System.Drawing.Color.LightGray
        Me.ButtonEVPresident.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ButtonEVPresident.ForeColor = System.Drawing.Color.Black
        Me.ButtonEVPresident.HoverState.Parent = Me.ButtonEVPresident
        Me.ButtonEVPresident.Location = New System.Drawing.Point(204, 0)
        Me.ButtonEVPresident.Margin = New System.Windows.Forms.Padding(0)
        Me.ButtonEVPresident.Name = "ButtonEVPresident"
        Me.ButtonEVPresident.ShadowDecoration.Parent = Me.ButtonEVPresident
        Me.ButtonEVPresident.Size = New System.Drawing.Size(157, 28)
        Me.ButtonEVPresident.TabIndex = 0
        Me.ButtonEVPresident.Tag = "2"
        Me.ButtonEVPresident.Text = "EXECUTIVE VICE PRESIDENT "
        '
        'ButtonVFinance
        '
        Me.ButtonVFinance.Animated = True
        Me.ButtonVFinance.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton
        Me.ButtonVFinance.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.ButtonVFinance.CheckedState.ForeColor = System.Drawing.Color.White
        Me.ButtonVFinance.CheckedState.Parent = Me.ButtonVFinance
        Me.ButtonVFinance.CustomImages.Parent = Me.ButtonVFinance
        Me.ButtonVFinance.FillColor = System.Drawing.Color.LightGray
        Me.ButtonVFinance.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ButtonVFinance.ForeColor = System.Drawing.Color.Black
        Me.ButtonVFinance.HoverState.Parent = Me.ButtonVFinance
        Me.ButtonVFinance.Location = New System.Drawing.Point(361, 0)
        Me.ButtonVFinance.Margin = New System.Windows.Forms.Padding(0)
        Me.ButtonVFinance.Name = "ButtonVFinance"
        Me.ButtonVFinance.ShadowDecoration.Parent = Me.ButtonVFinance
        Me.ButtonVFinance.Size = New System.Drawing.Size(102, 28)
        Me.ButtonVFinance.TabIndex = 0
        Me.ButtonVFinance.Tag = "3"
        Me.ButtonVFinance.Text = "VP FINANCE"
        '
        'ButtonVActivities
        '
        Me.ButtonVActivities.Animated = True
        Me.ButtonVActivities.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton
        Me.ButtonVActivities.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.ButtonVActivities.CheckedState.ForeColor = System.Drawing.Color.White
        Me.ButtonVActivities.CheckedState.Parent = Me.ButtonVActivities
        Me.ButtonVActivities.CustomImages.Parent = Me.ButtonVActivities
        Me.ButtonVActivities.FillColor = System.Drawing.Color.LightGray
        Me.ButtonVActivities.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ButtonVActivities.ForeColor = System.Drawing.Color.Black
        Me.ButtonVActivities.HoverState.Parent = Me.ButtonVActivities
        Me.ButtonVActivities.Location = New System.Drawing.Point(463, 0)
        Me.ButtonVActivities.Margin = New System.Windows.Forms.Padding(0)
        Me.ButtonVActivities.Name = "ButtonVActivities"
        Me.ButtonVActivities.ShadowDecoration.Parent = Me.ButtonVActivities
        Me.ButtonVActivities.Size = New System.Drawing.Size(102, 28)
        Me.ButtonVActivities.TabIndex = 0
        Me.ButtonVActivities.Tag = "4"
        Me.ButtonVActivities.Text = "VP ACTIVITIES"
        '
        'ButtonVComMarketing
        '
        Me.ButtonVComMarketing.Animated = True
        Me.ButtonVComMarketing.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton
        Me.ButtonVComMarketing.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.ButtonVComMarketing.CheckedState.ForeColor = System.Drawing.Color.White
        Me.ButtonVComMarketing.CheckedState.Parent = Me.ButtonVComMarketing
        Me.ButtonVComMarketing.CustomImages.Parent = Me.ButtonVComMarketing
        Me.ButtonVComMarketing.FillColor = System.Drawing.Color.LightGray
        Me.ButtonVComMarketing.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ButtonVComMarketing.ForeColor = System.Drawing.Color.Black
        Me.ButtonVComMarketing.HoverState.Parent = Me.ButtonVComMarketing
        Me.ButtonVComMarketing.Location = New System.Drawing.Point(565, 0)
        Me.ButtonVComMarketing.Margin = New System.Windows.Forms.Padding(0)
        Me.ButtonVComMarketing.Name = "ButtonVComMarketing"
        Me.ButtonVComMarketing.ShadowDecoration.Parent = Me.ButtonVComMarketing
        Me.ButtonVComMarketing.Size = New System.Drawing.Size(233, 28)
        Me.ButtonVComMarketing.TabIndex = 0
        Me.ButtonVComMarketing.Tag = "5"
        Me.ButtonVComMarketing.Text = "VP COMMUNICATION AND MARKETING "
        '
        'ButtonVDocumentation
        '
        Me.ButtonVDocumentation.Animated = True
        Me.ButtonVDocumentation.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton
        Me.ButtonVDocumentation.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.ButtonVDocumentation.CheckedState.ForeColor = System.Drawing.Color.White
        Me.ButtonVDocumentation.CheckedState.Parent = Me.ButtonVDocumentation
        Me.ButtonVDocumentation.CustomImages.Parent = Me.ButtonVDocumentation
        Me.ButtonVDocumentation.FillColor = System.Drawing.Color.Silver
        Me.ButtonVDocumentation.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ButtonVDocumentation.ForeColor = System.Drawing.Color.Black
        Me.ButtonVDocumentation.HoverState.Parent = Me.ButtonVDocumentation
        Me.ButtonVDocumentation.Location = New System.Drawing.Point(798, 0)
        Me.ButtonVDocumentation.Margin = New System.Windows.Forms.Padding(0)
        Me.ButtonVDocumentation.Name = "ButtonVDocumentation"
        Me.ButtonVDocumentation.ShadowDecoration.Parent = Me.ButtonVDocumentation
        Me.ButtonVDocumentation.Size = New System.Drawing.Size(176, 28)
        Me.ButtonVDocumentation.TabIndex = 0
        Me.ButtonVDocumentation.Tag = "6"
        Me.ButtonVDocumentation.Text = "VP DOCUMENTATION"
        '
        'VotingDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1236, 743)
        Me.Controls.Add(Me.mainform)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panelsidemenu)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "VotingDashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "VotingDashboard"
        Me.TopMost = True
        Me.PanelButtonGroup.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panelsidemenu.ResumeLayout(False)
        CType(Me.Guna2CirclePictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.mainform.ResumeLayout(False)
        Me.mainform.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Guna2CustomGradientPanel1.ResumeLayout(False)
        Me.Guna2CustomGradientPanel1.PerformLayout()
        Me.FlowLayoutPanel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2CirclePictureBox1 As Guna.UI2.WinForms.Guna2CirclePictureBox
    Friend WithEvents PanelButtonGroup As FlowLayoutPanel
    Friend WithEvents btncandidateinfo As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnpartyinfo As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents buttonvotenow As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Buttonsettings As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnlogout As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Guna2ControlBox3 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Guna2ControlBox1 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Panelsidemenu As Panel
    Friend WithEvents lblname As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents mainform As Panel
    Friend WithEvents FlowLayoutPanel2 As FlowLayoutPanel
    Friend WithEvents ButtonPresident As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents ButtonEVPresident As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents ButtonVFinance As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents ButtonVActivities As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents ButtonVComMarketing As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents ButtonVDocumentation As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents flpMain As FlowLayoutPanel
    Friend WithEvents Guna2CustomGradientPanel1 As Guna.UI2.WinForms.Guna2CustomGradientPanel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents lblfullname As Label
    Friend WithEvents Label5 As Label
End Class
