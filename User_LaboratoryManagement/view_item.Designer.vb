<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class view_item
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.mainpanelsub = New Guna.UI.WinForms.GunaGradient2Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.item_data = New Guna.UI.WinForms.GunaDataGridView()
        Me.Column2 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.check_item = New Guna.UI.WinForms.GunaCheckBox()
        Me.GunaGradientButton1 = New Guna.UI.WinForms.GunaGradientButton()
        Me.request_items = New Guna.UI.WinForms.GunaGradientButton()
        Me.subheader = New Guna.UI.WinForms.GunaGradient2Panel()
        Me.GunaGradientCircleButton1 = New Guna.UI.WinForms.GunaGradientCircleButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GunaDragControl1 = New Guna.UI.WinForms.GunaDragControl(Me.components)
        Me.GunaElipse1 = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.mainpanelsub.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.item_data, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.subheader.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'mainpanelsub
        '
        Me.mainpanelsub.BackColor = System.Drawing.Color.White
        Me.mainpanelsub.Controls.Add(Me.Panel1)
        Me.mainpanelsub.Controls.Add(Me.subheader)
        Me.mainpanelsub.Dock = System.Windows.Forms.DockStyle.Fill
        Me.mainpanelsub.GradientColor1 = System.Drawing.Color.White
        Me.mainpanelsub.GradientColor2 = System.Drawing.Color.White
        Me.mainpanelsub.Location = New System.Drawing.Point(0, 0)
        Me.mainpanelsub.Margin = New System.Windows.Forms.Padding(2)
        Me.mainpanelsub.Name = "mainpanelsub"
        Me.mainpanelsub.Size = New System.Drawing.Size(661, 416)
        Me.mainpanelsub.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel1.Controls.Add(Me.item_data)
        Me.Panel1.Controls.Add(Me.check_item)
        Me.Panel1.Controls.Add(Me.GunaGradientButton1)
        Me.Panel1.Controls.Add(Me.request_items)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 88)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(661, 328)
        Me.Panel1.TabIndex = 78
        '
        'item_data
        '
        Me.item_data.AllowUserToAddRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(4, Byte), Integer), CType(CType(95, Byte), Integer))
        Me.item_data.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.item_data.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.item_data.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.item_data.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.item_data.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.item_data.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(4, Byte), Integer), CType(CType(95, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.item_data.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.item_data.ColumnHeadersHeight = 50
        Me.item_data.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column2, Me.Column5, Me.Column6, Me.Column7, Me.Column1})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(4, Byte), Integer), CType(CType(95, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(4, Byte), Integer), CType(CType(95, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.item_data.DefaultCellStyle = DataGridViewCellStyle3
        Me.item_data.EnableHeadersVisualStyles = False
        Me.item_data.GridColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.item_data.Location = New System.Drawing.Point(-1, 0)
        Me.item_data.Margin = New System.Windows.Forms.Padding(2)
        Me.item_data.Name = "item_data"
        Me.item_data.RowHeadersVisible = False
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.item_data.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.item_data.RowTemplate.Height = 40
        Me.item_data.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.item_data.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.item_data.Size = New System.Drawing.Size(662, 266)
        Me.item_data.TabIndex = 2
        Me.item_data.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Purple
        Me.item_data.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(4, Byte), Integer), CType(CType(95, Byte), Integer))
        Me.item_data.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.item_data.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.item_data.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.item_data.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.item_data.ThemeStyle.BackColor = System.Drawing.Color.WhiteSmoke
        Me.item_data.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.item_data.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(4, Byte), Integer), CType(CType(95, Byte), Integer))
        Me.item_data.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.item_data.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.item_data.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.item_data.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.item_data.ThemeStyle.HeaderStyle.Height = 50
        Me.item_data.ThemeStyle.ReadOnly = False
        Me.item_data.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(4, Byte), Integer), CType(CType(95, Byte), Integer))
        Me.item_data.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.item_data.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.item_data.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.White
        Me.item_data.ThemeStyle.RowsStyle.Height = 40
        Me.item_data.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(4, Byte), Integer), CType(CType(95, Byte), Integer))
        Me.item_data.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White
        '
        'Column2
        '
        Me.Column2.FillWeight = 80.0!
        Me.Column2.HeaderText = "Action"
        Me.Column2.Name = "Column2"
        Me.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'Column5
        '
        Me.Column5.HeaderText = "Item ID"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'Column6
        '
        Me.Column6.HeaderText = "Item Name"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        '
        'Column7
        '
        Me.Column7.HeaderText = "Borrower's ID"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        '
        'Column1
        '
        Me.Column1.HeaderText = "Quantity"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'check_item
        '
        Me.check_item.BaseColor = System.Drawing.Color.White
        Me.check_item.CheckedOffColor = System.Drawing.Color.Gray
        Me.check_item.CheckedOnColor = System.Drawing.Color.Purple
        Me.check_item.Cursor = System.Windows.Forms.Cursors.Hand
        Me.check_item.FillColor = System.Drawing.Color.White
        Me.check_item.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.check_item.Location = New System.Drawing.Point(26, 288)
        Me.check_item.Margin = New System.Windows.Forms.Padding(2)
        Me.check_item.Name = "check_item"
        Me.check_item.Size = New System.Drawing.Size(88, 20)
        Me.check_item.TabIndex = 76
        Me.check_item.Text = "Check all"
        '
        'GunaGradientButton1
        '
        Me.GunaGradientButton1.AnimationHoverSpeed = 0.07!
        Me.GunaGradientButton1.AnimationSpeed = 0.03!
        Me.GunaGradientButton1.BackColor = System.Drawing.Color.Transparent
        Me.GunaGradientButton1.BaseColor1 = System.Drawing.Color.White
        Me.GunaGradientButton1.BaseColor2 = System.Drawing.Color.White
        Me.GunaGradientButton1.BorderColor = System.Drawing.Color.Purple
        Me.GunaGradientButton1.BorderSize = 1
        Me.GunaGradientButton1.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaGradientButton1.FocusedColor = System.Drawing.Color.Empty
        Me.GunaGradientButton1.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaGradientButton1.ForeColor = System.Drawing.Color.Purple
        Me.GunaGradientButton1.Image = Nothing
        Me.GunaGradientButton1.ImageSize = New System.Drawing.Size(20, 20)
        Me.GunaGradientButton1.Location = New System.Drawing.Point(396, 278)
        Me.GunaGradientButton1.Margin = New System.Windows.Forms.Padding(2)
        Me.GunaGradientButton1.Name = "GunaGradientButton1"
        Me.GunaGradientButton1.OnHoverBaseColor1 = System.Drawing.Color.DarkMagenta
        Me.GunaGradientButton1.OnHoverBaseColor2 = System.Drawing.Color.DarkMagenta
        Me.GunaGradientButton1.OnHoverBorderColor = System.Drawing.Color.Purple
        Me.GunaGradientButton1.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaGradientButton1.OnHoverImage = Nothing
        Me.GunaGradientButton1.OnPressedColor = System.Drawing.Color.Black
        Me.GunaGradientButton1.Radius = 18
        Me.GunaGradientButton1.Size = New System.Drawing.Size(120, 39)
        Me.GunaGradientButton1.TabIndex = 75
        Me.GunaGradientButton1.Text = "Remove Selected"
        Me.GunaGradientButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'request_items
        '
        Me.request_items.AnimationHoverSpeed = 0.07!
        Me.request_items.AnimationSpeed = 0.03!
        Me.request_items.BackColor = System.Drawing.Color.Transparent
        Me.request_items.BaseColor1 = System.Drawing.Color.White
        Me.request_items.BaseColor2 = System.Drawing.Color.White
        Me.request_items.BorderColor = System.Drawing.Color.Purple
        Me.request_items.BorderSize = 1
        Me.request_items.DialogResult = System.Windows.Forms.DialogResult.None
        Me.request_items.FocusedColor = System.Drawing.Color.Empty
        Me.request_items.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.request_items.ForeColor = System.Drawing.Color.Purple
        Me.request_items.Image = Nothing
        Me.request_items.ImageSize = New System.Drawing.Size(20, 20)
        Me.request_items.Location = New System.Drawing.Point(528, 278)
        Me.request_items.Margin = New System.Windows.Forms.Padding(2)
        Me.request_items.Name = "request_items"
        Me.request_items.OnHoverBaseColor1 = System.Drawing.Color.DarkMagenta
        Me.request_items.OnHoverBaseColor2 = System.Drawing.Color.DarkMagenta
        Me.request_items.OnHoverBorderColor = System.Drawing.Color.Purple
        Me.request_items.OnHoverForeColor = System.Drawing.Color.White
        Me.request_items.OnHoverImage = Nothing
        Me.request_items.OnPressedColor = System.Drawing.Color.Black
        Me.request_items.Radius = 18
        Me.request_items.Size = New System.Drawing.Size(122, 39)
        Me.request_items.TabIndex = 74
        Me.request_items.Text = "Confirm Request"
        Me.request_items.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'subheader
        '
        Me.subheader.BackColor = System.Drawing.Color.Transparent
        Me.subheader.Controls.Add(Me.GunaGradientCircleButton1)
        Me.subheader.Controls.Add(Me.PictureBox1)
        Me.subheader.Controls.Add(Me.Label2)
        Me.subheader.Dock = System.Windows.Forms.DockStyle.Top
        Me.subheader.GradientColor1 = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(7, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.subheader.GradientColor2 = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(7, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.subheader.Location = New System.Drawing.Point(0, 0)
        Me.subheader.Margin = New System.Windows.Forms.Padding(2)
        Me.subheader.Name = "subheader"
        Me.subheader.Size = New System.Drawing.Size(661, 88)
        Me.subheader.TabIndex = 1
        '
        'GunaGradientCircleButton1
        '
        Me.GunaGradientCircleButton1.AnimationHoverSpeed = 0.07!
        Me.GunaGradientCircleButton1.AnimationSpeed = 0.03!
        Me.GunaGradientCircleButton1.BaseColor1 = System.Drawing.Color.Transparent
        Me.GunaGradientCircleButton1.BaseColor2 = System.Drawing.Color.Transparent
        Me.GunaGradientCircleButton1.BorderColor = System.Drawing.Color.Black
        Me.GunaGradientCircleButton1.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaGradientCircleButton1.Dock = System.Windows.Forms.DockStyle.Right
        Me.GunaGradientCircleButton1.FocusedColor = System.Drawing.Color.Empty
        Me.GunaGradientCircleButton1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaGradientCircleButton1.ForeColor = System.Drawing.Color.White
        Me.GunaGradientCircleButton1.Image = Global.User_LaboratoryManagement.My.Resources.Resources.icons8_cancel_80
        Me.GunaGradientCircleButton1.ImageSize = New System.Drawing.Size(45, 45)
        Me.GunaGradientCircleButton1.Location = New System.Drawing.Point(566, 0)
        Me.GunaGradientCircleButton1.Margin = New System.Windows.Forms.Padding(2)
        Me.GunaGradientCircleButton1.Name = "GunaGradientCircleButton1"
        Me.GunaGradientCircleButton1.OnHoverBaseColor1 = System.Drawing.Color.Transparent
        Me.GunaGradientCircleButton1.OnHoverBaseColor2 = System.Drawing.Color.Transparent
        Me.GunaGradientCircleButton1.OnHoverBorderColor = System.Drawing.Color.Transparent
        Me.GunaGradientCircleButton1.OnHoverForeColor = System.Drawing.Color.Transparent
        Me.GunaGradientCircleButton1.OnHoverImage = Nothing
        Me.GunaGradientCircleButton1.OnPressedColor = System.Drawing.Color.Transparent
        Me.GunaGradientCircleButton1.Size = New System.Drawing.Size(95, 88)
        Me.GunaGradientCircleButton1.TabIndex = 72
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox1.ErrorImage = Global.User_LaboratoryManagement.My.Resources.Resources.icons8_lab_items_100__1_
        Me.PictureBox1.Image = Global.User_LaboratoryManagement.My.Resources.Resources.icons8_lab_items_80
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(114, 88)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 71
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(118, 31)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(133, 26)
        Me.Label2.TabIndex = 38
        Me.Label2.Text = "Request List"
        '
        'GunaDragControl1
        '
        Me.GunaDragControl1.TargetControl = Me.subheader
        '
        'GunaElipse1
        '
        Me.GunaElipse1.TargetControl = Me
        '
        'view_item
        '
        Me.AcceptButton = Me.request_items
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(661, 416)
        Me.Controls.Add(Me.mainpanelsub)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "view_item"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "view_item"
        Me.TopMost = True
        Me.mainpanelsub.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.item_data, System.ComponentModel.ISupportInitialize).EndInit()
        Me.subheader.ResumeLayout(False)
        Me.subheader.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents mainpanelsub As Guna.UI.WinForms.GunaGradient2Panel
    Friend WithEvents subheader As Guna.UI.WinForms.GunaGradient2Panel
    Friend WithEvents GunaDragControl1 As Guna.UI.WinForms.GunaDragControl
    Friend WithEvents GunaElipse1 As Guna.UI.WinForms.GunaElipse
    Friend WithEvents item_data As Guna.UI.WinForms.GunaDataGridView
    Friend WithEvents GunaGradientButton1 As Guna.UI.WinForms.GunaGradientButton
    Friend WithEvents request_items As Guna.UI.WinForms.GunaGradientButton
    Friend WithEvents check_item As Guna.UI.WinForms.GunaCheckBox
    Friend WithEvents GunaGradientCircleButton1 As Guna.UI.WinForms.GunaGradientCircleButton
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Column2 As DataGridViewCheckBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
End Class
