<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VoterealCount
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
        Dim ChartArea3 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim StripLine3 As System.Windows.Forms.DataVisualization.Charting.StripLine = New System.Windows.Forms.DataVisualization.Charting.StripLine()
        Dim Legend3 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series3 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim ChartArea4 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim StripLine4 As System.Windows.Forms.DataVisualization.Charting.StripLine = New System.Windows.Forms.DataVisualization.Charting.StripLine()
        Dim Legend4 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series4 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Me.ButtonPresident = New Guna.UI2.WinForms.Guna2Button()
        Me.ButtonEVPresident = New Guna.UI2.WinForms.Guna2Button()
        Me.ButtonVFinance = New Guna.UI2.WinForms.Guna2Button()
        Me.ButtonVActivities = New Guna.UI2.WinForms.Guna2Button()
        Me.ButtonVComMarketing = New Guna.UI2.WinForms.Guna2Button()
        Me.ButtonVDocumentation = New Guna.UI2.WinForms.Guna2Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.flpMain = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblcheckerparty = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Chart2 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.TotalVotersCircle = New Guna.UI2.WinForms.Guna2CircleProgressBar()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TotalVotersCount = New System.Windows.Forms.Label()
        Me.AlreadyVotedCircle = New Guna.UI2.WinForms.Guna2CircleProgressBar()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.AlreadyVotedCount = New System.Windows.Forms.Label()
        Me.RemainingVotersCircle = New Guna.UI2.WinForms.Guna2CircleProgressBar()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.RemainingVotersCount = New System.Windows.Forms.Label()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.btngunarefresh = New Guna.UI.WinForms.GunaCirclePictureBox()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlowLayoutPanel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.flpMain.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.Chart2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TotalVotersCircle.SuspendLayout()
        Me.AlreadyVotedCircle.SuspendLayout()
        Me.RemainingVotersCircle.SuspendLayout()
        CType(Me.btngunarefresh, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Chart1
        '
        Me.Chart1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Chart1.BackColor = System.Drawing.Color.Transparent
        Me.Chart1.BackImageWrapMode = System.Windows.Forms.DataVisualization.Charting.ChartImageWrapMode.TileFlipY
        Me.Chart1.BackSecondaryColor = System.Drawing.Color.NavajoWhite
        Me.Chart1.BorderSkin.BorderColor = System.Drawing.Color.White
        ChartArea3.Area3DStyle.Inclination = 10
        ChartArea3.Area3DStyle.IsRightAngleAxes = False
        ChartArea3.Area3DStyle.LightStyle = System.Windows.Forms.DataVisualization.Charting.LightStyle.Realistic
        ChartArea3.AxisX.LabelStyle.ForeColor = System.Drawing.Color.White
        ChartArea3.AxisX.LineColor = System.Drawing.Color.White
        ChartArea3.AxisX.TitleForeColor = System.Drawing.Color.White
        ChartArea3.AxisX2.LabelStyle.ForeColor = System.Drawing.Color.White
        ChartArea3.AxisX2.LineColor = System.Drawing.Color.White
        ChartArea3.AxisY.InterlacedColor = System.Drawing.Color.White
        ChartArea3.AxisY.LabelStyle.ForeColor = System.Drawing.Color.White
        ChartArea3.AxisY.LineColor = System.Drawing.Color.White
        StripLine3.BackColor = System.Drawing.Color.White
        StripLine3.BorderColor = System.Drawing.Color.White
        ChartArea3.AxisY.StripLines.Add(StripLine3)
        ChartArea3.AxisY2.LabelStyle.ForeColor = System.Drawing.Color.White
        ChartArea3.AxisY2.LineColor = System.Drawing.Color.White
        ChartArea3.AxisY2.TitleForeColor = System.Drawing.Color.White
        ChartArea3.BackColor = System.Drawing.Color.Transparent
        ChartArea3.BorderColor = System.Drawing.Color.White
        ChartArea3.Name = "ChartAreaBar"
        Me.Chart1.ChartAreas.Add(ChartArea3)
        Legend3.BackColor = System.Drawing.Color.Transparent
        Legend3.ForeColor = System.Drawing.Color.White
        Legend3.Name = "Legend2"
        Me.Chart1.Legends.Add(Legend3)
        Me.Chart1.Location = New System.Drawing.Point(3, 25)
        Me.Chart1.Name = "Chart1"
        Me.Chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel
        Series3.ChartArea = "ChartAreaBar"
        Series3.Legend = "Legend2"
        Series3.Name = "Series2"
        Me.Chart1.Series.Add(Series3)
        Me.Chart1.Size = New System.Drawing.Size(877, 427)
        Me.Chart1.TabIndex = 3
        Me.Chart1.Text = "Chart1"
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
        Me.FlowLayoutPanel2.Location = New System.Drawing.Point(29, 226)
        Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        Me.FlowLayoutPanel2.Size = New System.Drawing.Size(975, 28)
        Me.FlowLayoutPanel2.TabIndex = 17
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
        Me.Guna2Button1.Size = New System.Drawing.Size(82, 28)
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
        Me.ButtonPresident.Location = New System.Drawing.Point(82, 0)
        Me.ButtonPresident.Margin = New System.Windows.Forms.Padding(0)
        Me.ButtonPresident.Name = "ButtonPresident"
        Me.ButtonPresident.ShadowDecoration.Parent = Me.ButtonPresident
        Me.ButtonPresident.Size = New System.Drawing.Size(105, 28)
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
        Me.ButtonEVPresident.Location = New System.Drawing.Point(187, 0)
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
        Me.ButtonVFinance.Location = New System.Drawing.Point(344, 0)
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
        Me.ButtonVActivities.Location = New System.Drawing.Point(446, 0)
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
        Me.ButtonVComMarketing.Location = New System.Drawing.Point(548, 0)
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
        Me.ButtonVDocumentation.Location = New System.Drawing.Point(781, 0)
        Me.ButtonVDocumentation.Margin = New System.Windows.Forms.Padding(0)
        Me.ButtonVDocumentation.Name = "ButtonVDocumentation"
        Me.ButtonVDocumentation.ShadowDecoration.Parent = Me.ButtonVDocumentation
        Me.ButtonVDocumentation.Size = New System.Drawing.Size(176, 28)
        Me.ButtonVDocumentation.TabIndex = 0
        Me.ButtonVDocumentation.Tag = "6"
        Me.ButtonVDocumentation.Text = "VP DOCUMENTATION"
        '
        'Panel1
        '
        Me.Panel1.AutoSize = True
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Panel1.Controls.Add(Me.Chart1)
        Me.Panel1.Location = New System.Drawing.Point(13, 45)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(917, 455)
        Me.Panel1.TabIndex = 18
        '
        'flpMain
        '
        Me.flpMain.AutoScroll = True
        Me.flpMain.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.flpMain.Controls.Add(Me.Label1)
        Me.flpMain.Controls.Add(Me.Panel1)
        Me.flpMain.Controls.Add(Me.lblcheckerparty)
        Me.flpMain.Controls.Add(Me.Panel2)
        Me.flpMain.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.flpMain.Location = New System.Drawing.Point(29, 260)
        Me.flpMain.Name = "flpMain"
        Me.flpMain.Padding = New System.Windows.Forms.Padding(10, 5, 0, 0)
        Me.flpMain.Size = New System.Drawing.Size(960, 436)
        Me.flpMain.TabIndex = 19
        Me.flpMain.WrapContents = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Poppins", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(13, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(143, 37)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Candidates:"
        '
        'lblcheckerparty
        '
        Me.lblcheckerparty.AutoSize = True
        Me.lblcheckerparty.Font = New System.Drawing.Font("Poppins", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcheckerparty.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblcheckerparty.Location = New System.Drawing.Point(13, 503)
        Me.lblcheckerparty.Name = "lblcheckerparty"
        Me.lblcheckerparty.Size = New System.Drawing.Size(92, 37)
        Me.lblcheckerparty.TabIndex = 0
        Me.lblcheckerparty.Text = "Parties:"
        '
        'Panel2
        '
        Me.Panel2.AutoSize = True
        Me.Panel2.Controls.Add(Me.Chart2)
        Me.Panel2.Location = New System.Drawing.Point(13, 543)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(917, 345)
        Me.Panel2.TabIndex = 19
        '
        'Chart2
        '
        Me.Chart2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Chart2.BackColor = System.Drawing.Color.Transparent
        Me.Chart2.BackImageWrapMode = System.Windows.Forms.DataVisualization.Charting.ChartImageWrapMode.TileFlipY
        Me.Chart2.BackSecondaryColor = System.Drawing.Color.NavajoWhite
        Me.Chart2.BorderSkin.BorderColor = System.Drawing.Color.White
        ChartArea4.Area3DStyle.Inclination = 10
        ChartArea4.Area3DStyle.IsRightAngleAxes = False
        ChartArea4.Area3DStyle.LightStyle = System.Windows.Forms.DataVisualization.Charting.LightStyle.Realistic
        ChartArea4.AxisX.LabelStyle.ForeColor = System.Drawing.Color.White
        ChartArea4.AxisX.LineColor = System.Drawing.Color.White
        ChartArea4.AxisX.TitleForeColor = System.Drawing.Color.White
        ChartArea4.AxisX2.LabelStyle.ForeColor = System.Drawing.Color.White
        ChartArea4.AxisX2.LineColor = System.Drawing.Color.White
        ChartArea4.AxisY.InterlacedColor = System.Drawing.Color.White
        ChartArea4.AxisY.LabelStyle.ForeColor = System.Drawing.Color.White
        ChartArea4.AxisY.LineColor = System.Drawing.Color.White
        StripLine4.BackColor = System.Drawing.Color.White
        StripLine4.BorderColor = System.Drawing.Color.White
        ChartArea4.AxisY.StripLines.Add(StripLine4)
        ChartArea4.AxisY2.LabelStyle.ForeColor = System.Drawing.Color.White
        ChartArea4.AxisY2.LineColor = System.Drawing.Color.White
        ChartArea4.AxisY2.TitleForeColor = System.Drawing.Color.White
        ChartArea4.BackColor = System.Drawing.Color.Transparent
        ChartArea4.BorderColor = System.Drawing.Color.White
        ChartArea4.Name = "ChartAreaBar"
        Me.Chart2.ChartAreas.Add(ChartArea4)
        Legend4.BackColor = System.Drawing.Color.Transparent
        Legend4.ForeColor = System.Drawing.Color.White
        Legend4.Name = "Legend2"
        Me.Chart2.Legends.Add(Legend4)
        Me.Chart2.Location = New System.Drawing.Point(16, 15)
        Me.Chart2.Name = "Chart2"
        Me.Chart2.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel
        Series4.ChartArea = "ChartAreaBar"
        Series4.Legend = "Legend2"
        Series4.Name = "Series2"
        Me.Chart2.Series.Add(Series4)
        Me.Chart2.Size = New System.Drawing.Size(877, 327)
        Me.Chart2.TabIndex = 3
        Me.Chart2.Text = "Chart2"
        '
        'TotalVotersCircle
        '
        Me.TotalVotersCircle.AccessibleName = "TotalVotersCircle"
        Me.TotalVotersCircle.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TotalVotersCircle.Animated = True
        Me.TotalVotersCircle.AnimationSpeed = 2.0!
        Me.TotalVotersCircle.Controls.Add(Me.Label3)
        Me.TotalVotersCircle.Controls.Add(Me.TotalVotersCount)
        Me.TotalVotersCircle.FillThickness = 10
        Me.TotalVotersCircle.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.TotalVotersCircle.Location = New System.Drawing.Point(237, 38)
        Me.TotalVotersCircle.Name = "TotalVotersCircle"
        Me.TotalVotersCircle.ProgressColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.TotalVotersCircle.ProgressColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.TotalVotersCircle.ProgressThickness = 10
        Me.TotalVotersCircle.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.TotalVotersCircle.ShadowDecoration.Parent = Me.TotalVotersCircle
        Me.TotalVotersCircle.Size = New System.Drawing.Size(153, 153)
        Me.TotalVotersCircle.TabIndex = 31
        Me.TotalVotersCircle.Value = 100
        '
        'Label3
        '
        Me.Label3.AccessibleName = "TotalVotersDesc"
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label3.Location = New System.Drawing.Point(25, 83)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(115, 46)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Total Number of " & Global.Microsoft.VisualBasic.ChrW(10) & "Voters"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TotalVotersCount
        '
        Me.TotalVotersCount.AccessibleName = "TotalVotersCount"
        Me.TotalVotersCount.BackColor = System.Drawing.Color.Transparent
        Me.TotalVotersCount.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalVotersCount.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.TotalVotersCount.Location = New System.Drawing.Point(3, 45)
        Me.TotalVotersCount.Name = "TotalVotersCount"
        Me.TotalVotersCount.Size = New System.Drawing.Size(147, 38)
        Me.TotalVotersCount.TabIndex = 0
        Me.TotalVotersCount.Text = "0"
        Me.TotalVotersCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'AlreadyVotedCircle
        '
        Me.AlreadyVotedCircle.AccessibleName = "AlreadyVotedCircle"
        Me.AlreadyVotedCircle.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.AlreadyVotedCircle.AnimationSpeed = 2.0!
        Me.AlreadyVotedCircle.Controls.Add(Me.Label4)
        Me.AlreadyVotedCircle.Controls.Add(Me.AlreadyVotedCount)
        Me.AlreadyVotedCircle.FillColor = System.Drawing.Color.ForestGreen
        Me.AlreadyVotedCircle.FillThickness = 10
        Me.AlreadyVotedCircle.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.AlreadyVotedCircle.Location = New System.Drawing.Point(413, 38)
        Me.AlreadyVotedCircle.Name = "AlreadyVotedCircle"
        Me.AlreadyVotedCircle.ProgressColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.AlreadyVotedCircle.ProgressColor2 = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.AlreadyVotedCircle.ProgressEndCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor
        Me.AlreadyVotedCircle.ProgressThickness = 10
        Me.AlreadyVotedCircle.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.AlreadyVotedCircle.ShadowDecoration.Parent = Me.AlreadyVotedCircle
        Me.AlreadyVotedCircle.Size = New System.Drawing.Size(153, 153)
        Me.AlreadyVotedCircle.TabIndex = 32
        '
        'Label4
        '
        Me.Label4.AccessibleName = "AlreadyVotedDesc"
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label4.Location = New System.Drawing.Point(16, 83)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(124, 46)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Students Already " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Voted"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'AlreadyVotedCount
        '
        Me.AlreadyVotedCount.AccessibleName = "AlreadyVotedCount"
        Me.AlreadyVotedCount.BackColor = System.Drawing.Color.Transparent
        Me.AlreadyVotedCount.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AlreadyVotedCount.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.AlreadyVotedCount.Location = New System.Drawing.Point(3, 45)
        Me.AlreadyVotedCount.Name = "AlreadyVotedCount"
        Me.AlreadyVotedCount.Size = New System.Drawing.Size(147, 38)
        Me.AlreadyVotedCount.TabIndex = 0
        Me.AlreadyVotedCount.Text = "0"
        Me.AlreadyVotedCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RemainingVotersCircle
        '
        Me.RemainingVotersCircle.AccessibleName = "RemainingVotersCircle"
        Me.RemainingVotersCircle.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.RemainingVotersCircle.AnimationSpeed = 2.0!
        Me.RemainingVotersCircle.Controls.Add(Me.Label5)
        Me.RemainingVotersCircle.Controls.Add(Me.RemainingVotersCount)
        Me.RemainingVotersCircle.FillColor = System.Drawing.Color.Silver
        Me.RemainingVotersCircle.FillThickness = 10
        Me.RemainingVotersCircle.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.RemainingVotersCircle.Location = New System.Drawing.Point(595, 38)
        Me.RemainingVotersCircle.Name = "RemainingVotersCircle"
        Me.RemainingVotersCircle.ProgressColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.RemainingVotersCircle.ProgressColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.RemainingVotersCircle.ProgressEndCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor
        Me.RemainingVotersCircle.ProgressStartCap = System.Drawing.Drawing2D.LineCap.Square
        Me.RemainingVotersCircle.ProgressThickness = 10
        Me.RemainingVotersCircle.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.RemainingVotersCircle.ShadowDecoration.Parent = Me.RemainingVotersCircle
        Me.RemainingVotersCircle.Size = New System.Drawing.Size(153, 153)
        Me.RemainingVotersCircle.TabIndex = 33
        '
        'Label5
        '
        Me.Label5.AccessibleName = "RemainingVotersDesc"
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label5.Location = New System.Drawing.Point(36, 83)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(82, 46)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Remaining " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Voters"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RemainingVotersCount
        '
        Me.RemainingVotersCount.AccessibleName = "RemainingVotersCount"
        Me.RemainingVotersCount.BackColor = System.Drawing.Color.Transparent
        Me.RemainingVotersCount.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RemainingVotersCount.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.RemainingVotersCount.Location = New System.Drawing.Point(0, 45)
        Me.RemainingVotersCount.Name = "RemainingVotersCount"
        Me.RemainingVotersCount.Size = New System.Drawing.Size(150, 38)
        Me.RemainingVotersCount.TabIndex = 0
        Me.RemainingVotersCount.Text = "0"
        Me.RemainingVotersCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.Font = New System.Drawing.Font("Poppins", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblTime.Location = New System.Drawing.Point(37, 197)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(45, 26)
        Me.lblTime.TabIndex = 34
        Me.lblTime.Text = "time"
        '
        'btngunarefresh
        '
        Me.btngunarefresh.BaseColor = System.Drawing.Color.White
        Me.btngunarefresh.Image = Global.Loavotingsystem.My.Resources.Resources.refresh
        Me.btngunarefresh.Location = New System.Drawing.Point(939, 176)
        Me.btngunarefresh.Name = "btngunarefresh"
        Me.btngunarefresh.Size = New System.Drawing.Size(47, 44)
        Me.btngunarefresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btngunarefresh.TabIndex = 35
        Me.btngunarefresh.TabStop = False
        Me.btngunarefresh.UseTransfarantBackground = False
        '
        'VoterealCount
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1016, 708)
        Me.Controls.Add(Me.btngunarefresh)
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.RemainingVotersCircle)
        Me.Controls.Add(Me.AlreadyVotedCircle)
        Me.Controls.Add(Me.TotalVotersCircle)
        Me.Controls.Add(Me.flpMain)
        Me.Controls.Add(Me.FlowLayoutPanel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "VoterealCount"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "VoterealCount"
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlowLayoutPanel2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.flpMain.ResumeLayout(False)
        Me.flpMain.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.Chart2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TotalVotersCircle.ResumeLayout(False)
        Me.TotalVotersCircle.PerformLayout()
        Me.AlreadyVotedCircle.ResumeLayout(False)
        Me.AlreadyVotedCircle.PerformLayout()
        Me.RemainingVotersCircle.ResumeLayout(False)
        Me.RemainingVotersCircle.PerformLayout()
        CType(Me.btngunarefresh, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Chart1 As DataVisualization.Charting.Chart
    Friend WithEvents FlowLayoutPanel2 As FlowLayoutPanel
    Friend WithEvents ButtonPresident As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents ButtonEVPresident As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents ButtonVFinance As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents ButtonVActivities As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents ButtonVComMarketing As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents ButtonVDocumentation As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents flpMain As FlowLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents lblcheckerparty As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Chart2 As DataVisualization.Charting.Chart
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents TotalVotersCircle As Guna.UI2.WinForms.Guna2CircleProgressBar
    Friend WithEvents Label3 As Label
    Friend WithEvents TotalVotersCount As Label
    Friend WithEvents AlreadyVotedCircle As Guna.UI2.WinForms.Guna2CircleProgressBar
    Friend WithEvents Label4 As Label
    Friend WithEvents AlreadyVotedCount As Label
    Friend WithEvents RemainingVotersCircle As Guna.UI2.WinForms.Guna2CircleProgressBar
    Friend WithEvents Label5 As Label
    Friend WithEvents RemainingVotersCount As Label
    Friend WithEvents lblTime As Label
    Friend WithEvents btngunarefresh As Guna.UI.WinForms.GunaCirclePictureBox
End Class
