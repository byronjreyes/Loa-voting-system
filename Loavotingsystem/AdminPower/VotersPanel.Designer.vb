<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class VotersPanel
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(VotersPanel))
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.ButtonFilterAll = New Guna.UI2.WinForms.Guna2Button()
        Me.ButtonFilter1st = New Guna.UI2.WinForms.Guna2Button()
        Me.ButtonFilter2nd = New Guna.UI2.WinForms.Guna2Button()
        Me.ButtonFilter3rd = New Guna.UI2.WinForms.Guna2Button()
        Me.ButtonFilter4th = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2ShadowPanel1 = New Guna.UI2.WinForms.Guna2ShadowPanel()
        Me.DataGridView1 = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.ButtonSubmit = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2CustomGradientPanel1 = New Guna.UI2.WinForms.Guna2CustomGradientPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Me.TextSearch = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btnclose = New Guna.UI2.WinForms.Guna2Button()
        Me.btnfilterunvoted = New Guna.UI2.WinForms.Guna2Button()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.Guna2ShadowPanel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2CustomGradientPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.AutoSize = True
        Me.FlowLayoutPanel1.Controls.Add(Me.ButtonFilterAll)
        Me.FlowLayoutPanel1.Controls.Add(Me.ButtonFilter1st)
        Me.FlowLayoutPanel1.Controls.Add(Me.ButtonFilter2nd)
        Me.FlowLayoutPanel1.Controls.Add(Me.ButtonFilter3rd)
        Me.FlowLayoutPanel1.Controls.Add(Me.ButtonFilter4th)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnfilterunvoted)
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(21, 169)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(528, 35)
        Me.FlowLayoutPanel1.TabIndex = 8
        '
        'ButtonFilterAll
        '
        Me.ButtonFilterAll.BorderRadius = 15
        Me.ButtonFilterAll.CheckedState.Parent = Me.ButtonFilterAll
        Me.ButtonFilterAll.CustomImages.Parent = Me.ButtonFilterAll
        Me.ButtonFilterAll.FillColor = System.Drawing.SystemColors.Control
        Me.ButtonFilterAll.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ButtonFilterAll.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ButtonFilterAll.HoverState.Parent = Me.ButtonFilterAll
        Me.ButtonFilterAll.Location = New System.Drawing.Point(3, 3)
        Me.ButtonFilterAll.Name = "ButtonFilterAll"
        Me.ButtonFilterAll.ShadowDecoration.Parent = Me.ButtonFilterAll
        Me.ButtonFilterAll.Size = New System.Drawing.Size(76, 29)
        Me.ButtonFilterAll.TabIndex = 3
        Me.ButtonFilterAll.Text = "All"
        '
        'ButtonFilter1st
        '
        Me.ButtonFilter1st.BorderRadius = 15
        Me.ButtonFilter1st.CheckedState.Parent = Me.ButtonFilter1st
        Me.ButtonFilter1st.CustomImages.Parent = Me.ButtonFilter1st
        Me.ButtonFilter1st.FillColor = System.Drawing.SystemColors.Control
        Me.ButtonFilter1st.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ButtonFilter1st.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ButtonFilter1st.HoverState.Parent = Me.ButtonFilter1st
        Me.ButtonFilter1st.Location = New System.Drawing.Point(85, 3)
        Me.ButtonFilter1st.Name = "ButtonFilter1st"
        Me.ButtonFilter1st.ShadowDecoration.Parent = Me.ButtonFilter1st
        Me.ButtonFilter1st.Size = New System.Drawing.Size(76, 29)
        Me.ButtonFilter1st.TabIndex = 3
        Me.ButtonFilter1st.Text = "1st year"
        '
        'ButtonFilter2nd
        '
        Me.ButtonFilter2nd.BorderRadius = 15
        Me.ButtonFilter2nd.CheckedState.Parent = Me.ButtonFilter2nd
        Me.ButtonFilter2nd.CustomImages.Parent = Me.ButtonFilter2nd
        Me.ButtonFilter2nd.FillColor = System.Drawing.SystemColors.Control
        Me.ButtonFilter2nd.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ButtonFilter2nd.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ButtonFilter2nd.HoverState.Parent = Me.ButtonFilter2nd
        Me.ButtonFilter2nd.Location = New System.Drawing.Point(167, 3)
        Me.ButtonFilter2nd.Name = "ButtonFilter2nd"
        Me.ButtonFilter2nd.ShadowDecoration.Parent = Me.ButtonFilter2nd
        Me.ButtonFilter2nd.Size = New System.Drawing.Size(76, 29)
        Me.ButtonFilter2nd.TabIndex = 3
        Me.ButtonFilter2nd.Text = "2nd year"
        '
        'ButtonFilter3rd
        '
        Me.ButtonFilter3rd.BorderRadius = 15
        Me.ButtonFilter3rd.CheckedState.Parent = Me.ButtonFilter3rd
        Me.ButtonFilter3rd.CustomImages.Parent = Me.ButtonFilter3rd
        Me.ButtonFilter3rd.FillColor = System.Drawing.SystemColors.Control
        Me.ButtonFilter3rd.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ButtonFilter3rd.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ButtonFilter3rd.HoverState.Parent = Me.ButtonFilter3rd
        Me.ButtonFilter3rd.Location = New System.Drawing.Point(249, 3)
        Me.ButtonFilter3rd.Name = "ButtonFilter3rd"
        Me.ButtonFilter3rd.ShadowDecoration.Parent = Me.ButtonFilter3rd
        Me.ButtonFilter3rd.Size = New System.Drawing.Size(76, 29)
        Me.ButtonFilter3rd.TabIndex = 3
        Me.ButtonFilter3rd.Text = "3rd year"
        '
        'ButtonFilter4th
        '
        Me.ButtonFilter4th.BorderRadius = 15
        Me.ButtonFilter4th.CheckedState.Parent = Me.ButtonFilter4th
        Me.ButtonFilter4th.CustomImages.Parent = Me.ButtonFilter4th
        Me.ButtonFilter4th.FillColor = System.Drawing.SystemColors.Control
        Me.ButtonFilter4th.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ButtonFilter4th.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ButtonFilter4th.HoverState.Parent = Me.ButtonFilter4th
        Me.ButtonFilter4th.Location = New System.Drawing.Point(331, 3)
        Me.ButtonFilter4th.Name = "ButtonFilter4th"
        Me.ButtonFilter4th.ShadowDecoration.Parent = Me.ButtonFilter4th
        Me.ButtonFilter4th.Size = New System.Drawing.Size(76, 29)
        Me.ButtonFilter4th.TabIndex = 3
        Me.ButtonFilter4th.Text = "4th year"
        '
        'Guna2ShadowPanel1
        '
        Me.Guna2ShadowPanel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2ShadowPanel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2ShadowPanel1.Controls.Add(Me.DataGridView1)
        Me.Guna2ShadowPanel1.FillColor = System.Drawing.Color.White
        Me.Guna2ShadowPanel1.Location = New System.Drawing.Point(13, 222)
        Me.Guna2ShadowPanel1.Name = "Guna2ShadowPanel1"
        Me.Guna2ShadowPanel1.Radius = 10
        Me.Guna2ShadowPanel1.ShadowColor = System.Drawing.Color.Black
        Me.Guna2ShadowPanel1.Size = New System.Drawing.Size(868, 368)
        Me.Guna2ShadowPanel1.TabIndex = 9
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.ColumnHeadersHeight = 40
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(243, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.EnableHeadersVisualStyles = False
        Me.DataGridView1.GridColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.DataGridView1.Location = New System.Drawing.Point(12, 11)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.ControlLight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridView1.RowHeadersVisible = False
        DataGridViewCellStyle5.Padding = New System.Windows.Forms.Padding(4, 4, 0, 4)
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridView1.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridView1.RowTemplate.Height = 40
        Me.DataGridView1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(846, 345)
        Me.DataGridView1.TabIndex = 4
        Me.DataGridView1.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.WhiteGrid
        Me.DataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.DataGridView1.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.DataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.DataGridView1.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.DataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.DataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.White
        Me.DataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DataGridView1.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black
        Me.DataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.DataGridView1.ThemeStyle.HeaderStyle.Height = 40
        Me.DataGridView1.ThemeStyle.ReadOnly = True
        Me.DataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.DataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DataGridView1.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.DataGridView1.ThemeStyle.RowsStyle.Height = 40
        Me.DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black
        '
        'ButtonSubmit
        '
        Me.ButtonSubmit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonSubmit.CheckedState.Parent = Me.ButtonSubmit
        Me.ButtonSubmit.CustomImages.Parent = Me.ButtonSubmit
        Me.ButtonSubmit.FillColor = System.Drawing.Color.FromArgb(CType(CType(199, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.ButtonSubmit.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.ButtonSubmit.ForeColor = System.Drawing.Color.White
        Me.ButtonSubmit.HoverState.Parent = Me.ButtonSubmit
        Me.ButtonSubmit.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.ButtonSubmit.ImageOffset = New System.Drawing.Point(1, 1)
        Me.ButtonSubmit.ImageSize = New System.Drawing.Size(15, 15)
        Me.ButtonSubmit.Location = New System.Drawing.Point(743, 617)
        Me.ButtonSubmit.Name = "ButtonSubmit"
        Me.ButtonSubmit.ShadowDecoration.Parent = Me.ButtonSubmit
        Me.ButtonSubmit.Size = New System.Drawing.Size(138, 37)
        Me.ButtonSubmit.TabIndex = 10
        Me.ButtonSubmit.Text = "Add"
        '
        'Guna2CustomGradientPanel1
        '
        Me.Guna2CustomGradientPanel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2CustomGradientPanel1.BorderRadius = 21
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.Label1)
        Me.Guna2CustomGradientPanel1.FillColor = System.Drawing.Color.Gainsboro
        Me.Guna2CustomGradientPanel1.FillColor2 = System.Drawing.Color.Gainsboro
        Me.Guna2CustomGradientPanel1.FillColor3 = System.Drawing.Color.Gainsboro
        Me.Guna2CustomGradientPanel1.FillColor4 = System.Drawing.Color.Gainsboro
        Me.Guna2CustomGradientPanel1.Location = New System.Drawing.Point(-20, 50)
        Me.Guna2CustomGradientPanel1.Name = "Guna2CustomGradientPanel1"
        Me.Guna2CustomGradientPanel1.ShadowDecoration.Parent = Me.Guna2CustomGradientPanel1
        Me.Guna2CustomGradientPanel1.Size = New System.Drawing.Size(366, 47)
        Me.Guna2CustomGradientPanel1.TabIndex = 60
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Poppins", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(35, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(303, 37)
        Me.Label1.TabIndex = 58
        Me.Label1.Text = "Manage Voters Information"
        '
        'Guna2Button1
        '
        Me.Guna2Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2Button1.CheckedState.Parent = Me.Guna2Button1
        Me.Guna2Button1.CustomImages.Parent = Me.Guna2Button1
        Me.Guna2Button1.FillColor = System.Drawing.Color.FromArgb(CType(CType(199, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.Guna2Button1.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.Guna2Button1.ForeColor = System.Drawing.Color.White
        Me.Guna2Button1.HoverState.Parent = Me.Guna2Button1
        Me.Guna2Button1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.Guna2Button1.ImageOffset = New System.Drawing.Point(1, 1)
        Me.Guna2Button1.ImageSize = New System.Drawing.Size(15, 15)
        Me.Guna2Button1.Location = New System.Drawing.Point(599, 617)
        Me.Guna2Button1.Name = "Guna2Button1"
        Me.Guna2Button1.ShadowDecoration.Parent = Me.Guna2Button1
        Me.Guna2Button1.Size = New System.Drawing.Size(138, 37)
        Me.Guna2Button1.TabIndex = 10
        Me.Guna2Button1.Text = "Refresh"
        '
        'TextSearch
        '
        Me.TextSearch.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextSearch.BorderRadius = 8
        Me.TextSearch.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TextSearch.DefaultText = ""
        Me.TextSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TextSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TextSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TextSearch.DisabledState.Parent = Me.TextSearch
        Me.TextSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TextSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TextSearch.FocusedState.Parent = Me.TextSearch
        Me.TextSearch.Font = New System.Drawing.Font("Poppins", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TextSearch.HoverState.Parent = Me.TextSearch
        Me.TextSearch.IconLeft = CType(resources.GetObject("TextSearch.IconLeft"), System.Drawing.Image)
        Me.TextSearch.Location = New System.Drawing.Point(21, 119)
        Me.TextSearch.Margin = New System.Windows.Forms.Padding(2)
        Me.TextSearch.Name = "TextSearch"
        Me.TextSearch.Padding = New System.Windows.Forms.Padding(4, 0, 0, 0)
        Me.TextSearch.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TextSearch.PlaceholderText = "    Search Voters Here"
        Me.TextSearch.SelectedText = ""
        Me.TextSearch.ShadowDecoration.Parent = Me.TextSearch
        Me.TextSearch.Size = New System.Drawing.Size(860, 36)
        Me.TextSearch.TabIndex = 1
        '
        'btnclose
        '
        Me.btnclose.Animated = True
        Me.btnclose.CheckedState.Parent = Me.btnclose
        Me.btnclose.CustomImages.Parent = Me.btnclose
        Me.btnclose.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnclose.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnclose.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnclose.HoverState.Parent = Me.btnclose
        Me.btnclose.Location = New System.Drawing.Point(455, 617)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.ShadowDecoration.Parent = Me.btnclose
        Me.btnclose.Size = New System.Drawing.Size(138, 37)
        Me.btnclose.TabIndex = 61
        Me.btnclose.Text = "Close Window"
        '
        'btnfilterunvoted
        '
        Me.btnfilterunvoted.BorderRadius = 15
        Me.btnfilterunvoted.CheckedState.Parent = Me.btnfilterunvoted
        Me.btnfilterunvoted.CustomImages.Parent = Me.btnfilterunvoted
        Me.btnfilterunvoted.FillColor = System.Drawing.SystemColors.Control
        Me.btnfilterunvoted.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnfilterunvoted.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnfilterunvoted.HoverState.Parent = Me.btnfilterunvoted
        Me.btnfilterunvoted.Location = New System.Drawing.Point(413, 3)
        Me.btnfilterunvoted.Name = "btnfilterunvoted"
        Me.btnfilterunvoted.ShadowDecoration.Parent = Me.btnfilterunvoted
        Me.btnfilterunvoted.Size = New System.Drawing.Size(76, 29)
        Me.btnfilterunvoted.TabIndex = 3
        Me.btnfilterunvoted.Text = "Unvoted"
        '
        'VotersPanel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(912, 682)
        Me.Controls.Add(Me.btnclose)
        Me.Controls.Add(Me.Guna2CustomGradientPanel1)
        Me.Controls.Add(Me.Guna2Button1)
        Me.Controls.Add(Me.ButtonSubmit)
        Me.Controls.Add(Me.Guna2ShadowPanel1)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.TextSearch)
        Me.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "VotersPanel"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "VotersPanel"
        Me.TopMost = True
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.Guna2ShadowPanel1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2CustomGradientPanel1.ResumeLayout(False)
        Me.Guna2CustomGradientPanel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextSearch As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents ButtonFilterAll As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents ButtonFilter1st As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents ButtonFilter2nd As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents ButtonFilter3rd As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents ButtonFilter4th As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2ShadowPanel1 As Guna.UI2.WinForms.Guna2ShadowPanel
    Friend WithEvents DataGridView1 As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents ButtonSubmit As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2CustomGradientPanel1 As Guna.UI2.WinForms.Guna2CustomGradientPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnclose As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnfilterunvoted As Guna.UI2.WinForms.Guna2Button
End Class
