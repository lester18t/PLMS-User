<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class sercurity_code
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
        Me.GunaGradient2Panel2 = New Guna.UI.WinForms.GunaGradient2Panel()
        Me.GunaGradientButton1 = New Guna.UI.WinForms.GunaGradientButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.security_cd = New Guna.UI.WinForms.GunaTextBox()
        Me.saveData = New Guna.UI.WinForms.GunaGradientButton()
        Me.gunaheader = New Guna.UI.WinForms.GunaGradient2Panel()
        Me.GunaCircleButton2 = New Guna.UI.WinForms.GunaCircleButton()
        Me.GunaCircleButton1 = New Guna.UI.WinForms.GunaCircleButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GunaGradient2Panel2.SuspendLayout()
        Me.gunaheader.SuspendLayout()
        Me.SuspendLayout()
        '
        'GunaGradient2Panel2
        '
        Me.GunaGradient2Panel2.BackColor = System.Drawing.Color.White
        Me.GunaGradient2Panel2.Controls.Add(Me.GunaGradientButton1)
        Me.GunaGradient2Panel2.Controls.Add(Me.Label3)
        Me.GunaGradient2Panel2.Controls.Add(Me.security_cd)
        Me.GunaGradient2Panel2.Controls.Add(Me.saveData)
        Me.GunaGradient2Panel2.Controls.Add(Me.gunaheader)
        Me.GunaGradient2Panel2.Controls.Add(Me.Panel1)
        Me.GunaGradient2Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GunaGradient2Panel2.Font = New System.Drawing.Font("Segoe UI Symbol", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaGradient2Panel2.GradientColor1 = System.Drawing.Color.White
        Me.GunaGradient2Panel2.GradientColor2 = System.Drawing.Color.White
        Me.GunaGradient2Panel2.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GunaGradient2Panel2.Location = New System.Drawing.Point(0, 0)
        Me.GunaGradient2Panel2.Margin = New System.Windows.Forms.Padding(2)
        Me.GunaGradient2Panel2.Name = "GunaGradient2Panel2"
        Me.GunaGradient2Panel2.Size = New System.Drawing.Size(387, 226)
        Me.GunaGradient2Panel2.TabIndex = 6
        '
        'GunaGradientButton1
        '
        Me.GunaGradientButton1.Animated = True
        Me.GunaGradientButton1.AnimationHoverSpeed = 0.07!
        Me.GunaGradientButton1.AnimationSpeed = 0.03!
        Me.GunaGradientButton1.BackColor = System.Drawing.Color.Transparent
        Me.GunaGradientButton1.BaseColor1 = System.Drawing.Color.White
        Me.GunaGradientButton1.BaseColor2 = System.Drawing.Color.White
        Me.GunaGradientButton1.BorderColor = System.Drawing.Color.Purple
        Me.GunaGradientButton1.BorderSize = 1
        Me.GunaGradientButton1.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaGradientButton1.FocusedColor = System.Drawing.Color.Empty
        Me.GunaGradientButton1.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaGradientButton1.ForeColor = System.Drawing.Color.Purple
        Me.GunaGradientButton1.Image = Nothing
        Me.GunaGradientButton1.ImageOffsetX = 2
        Me.GunaGradientButton1.ImageSize = New System.Drawing.Size(20, 20)
        Me.GunaGradientButton1.ImeMode = System.Windows.Forms.ImeMode.Hangul
        Me.GunaGradientButton1.Location = New System.Drawing.Point(293, 171)
        Me.GunaGradientButton1.Margin = New System.Windows.Forms.Padding(2)
        Me.GunaGradientButton1.Name = "GunaGradientButton1"
        Me.GunaGradientButton1.OnHoverBaseColor1 = System.Drawing.Color.Purple
        Me.GunaGradientButton1.OnHoverBaseColor2 = System.Drawing.Color.Purple
        Me.GunaGradientButton1.OnHoverBorderColor = System.Drawing.Color.Transparent
        Me.GunaGradientButton1.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaGradientButton1.OnHoverImage = Nothing
        Me.GunaGradientButton1.OnPressedColor = System.Drawing.Color.Transparent
        Me.GunaGradientButton1.OnPressedDepth = 20
        Me.GunaGradientButton1.Radius = 3
        Me.GunaGradientButton1.Size = New System.Drawing.Size(67, 37)
        Me.GunaGradientButton1.TabIndex = 20
        Me.GunaGradientButton1.Text = "Cancel"
        Me.GunaGradientButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.GunaGradientButton1.UseTransfarantBackground = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(24, 95)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(171, 17)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Enter 6 digit long code"
        '
        'security_cd
        '
        Me.security_cd.BackColor = System.Drawing.Color.Transparent
        Me.security_cd.BaseColor = System.Drawing.Color.White
        Me.security_cd.BorderColor = System.Drawing.Color.LightGray
        Me.security_cd.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.security_cd.FocusedBaseColor = System.Drawing.Color.White
        Me.security_cd.FocusedBorderColor = System.Drawing.Color.Purple
        Me.security_cd.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.security_cd.Font = New System.Drawing.Font("Segoe UI Symbol", 13.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.security_cd.Location = New System.Drawing.Point(24, 119)
        Me.security_cd.Margin = New System.Windows.Forms.Padding(2)
        Me.security_cd.Name = "security_cd"
        Me.security_cd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.security_cd.Radius = 4
        Me.security_cd.Size = New System.Drawing.Size(336, 37)
        Me.security_cd.TabIndex = 1
        Me.security_cd.TextOffsetX = 5
        '
        'saveData
        '
        Me.saveData.Animated = True
        Me.saveData.AnimationHoverSpeed = 0.07!
        Me.saveData.AnimationSpeed = 0.03!
        Me.saveData.BackColor = System.Drawing.Color.Transparent
        Me.saveData.BaseColor1 = System.Drawing.Color.White
        Me.saveData.BaseColor2 = System.Drawing.Color.White
        Me.saveData.BorderColor = System.Drawing.Color.Purple
        Me.saveData.BorderSize = 1
        Me.saveData.DialogResult = System.Windows.Forms.DialogResult.None
        Me.saveData.FocusedColor = System.Drawing.Color.Empty
        Me.saveData.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.saveData.ForeColor = System.Drawing.Color.Purple
        Me.saveData.Image = Nothing
        Me.saveData.ImageOffsetX = 2
        Me.saveData.ImageSize = New System.Drawing.Size(20, 20)
        Me.saveData.ImeMode = System.Windows.Forms.ImeMode.Hangul
        Me.saveData.Location = New System.Drawing.Point(213, 171)
        Me.saveData.Margin = New System.Windows.Forms.Padding(2)
        Me.saveData.Name = "saveData"
        Me.saveData.OnHoverBaseColor1 = System.Drawing.Color.Purple
        Me.saveData.OnHoverBaseColor2 = System.Drawing.Color.Purple
        Me.saveData.OnHoverBorderColor = System.Drawing.Color.Transparent
        Me.saveData.OnHoverForeColor = System.Drawing.Color.White
        Me.saveData.OnHoverImage = Nothing
        Me.saveData.OnPressedColor = System.Drawing.Color.Transparent
        Me.saveData.OnPressedDepth = 20
        Me.saveData.Radius = 3
        Me.saveData.Size = New System.Drawing.Size(67, 37)
        Me.saveData.TabIndex = 4
        Me.saveData.Text = "Search"
        Me.saveData.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.saveData.UseTransfarantBackground = True
        '
        'gunaheader
        '
        Me.gunaheader.BackColor = System.Drawing.Color.Transparent
        Me.gunaheader.Controls.Add(Me.GunaCircleButton2)
        Me.gunaheader.Controls.Add(Me.GunaCircleButton1)
        Me.gunaheader.Controls.Add(Me.Label1)
        Me.gunaheader.Dock = System.Windows.Forms.DockStyle.Top
        Me.gunaheader.GradientColor1 = System.Drawing.Color.Purple
        Me.gunaheader.GradientColor2 = System.Drawing.Color.Purple
        Me.gunaheader.Location = New System.Drawing.Point(0, 0)
        Me.gunaheader.Margin = New System.Windows.Forms.Padding(2)
        Me.gunaheader.Name = "gunaheader"
        Me.gunaheader.Size = New System.Drawing.Size(387, 70)
        Me.gunaheader.TabIndex = 18
        '
        'GunaCircleButton2
        '
        Me.GunaCircleButton2.Animated = True
        Me.GunaCircleButton2.AnimationHoverSpeed = 0.07!
        Me.GunaCircleButton2.AnimationSpeed = 0.03!
        Me.GunaCircleButton2.BaseColor = System.Drawing.Color.Transparent
        Me.GunaCircleButton2.BorderColor = System.Drawing.Color.Transparent
        Me.GunaCircleButton2.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaCircleButton2.Dock = System.Windows.Forms.DockStyle.Left
        Me.GunaCircleButton2.FocusedColor = System.Drawing.Color.Empty
        Me.GunaCircleButton2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaCircleButton2.ForeColor = System.Drawing.Color.White
        Me.GunaCircleButton2.Image = Global.User_LaboratoryManagement.My.Resources.Resources.icons8_key_1001
        Me.GunaCircleButton2.ImageSize = New System.Drawing.Size(45, 45)
        Me.GunaCircleButton2.Location = New System.Drawing.Point(0, 0)
        Me.GunaCircleButton2.Margin = New System.Windows.Forms.Padding(2)
        Me.GunaCircleButton2.Name = "GunaCircleButton2"
        Me.GunaCircleButton2.OnHoverBaseColor = System.Drawing.Color.Transparent
        Me.GunaCircleButton2.OnHoverBorderColor = System.Drawing.Color.Transparent
        Me.GunaCircleButton2.OnHoverForeColor = System.Drawing.Color.Transparent
        Me.GunaCircleButton2.OnHoverImage = Nothing
        Me.GunaCircleButton2.OnPressedColor = System.Drawing.Color.Transparent
        Me.GunaCircleButton2.Size = New System.Drawing.Size(76, 70)
        Me.GunaCircleButton2.TabIndex = 4
        '
        'GunaCircleButton1
        '
        Me.GunaCircleButton1.Animated = True
        Me.GunaCircleButton1.AnimationHoverSpeed = 0.07!
        Me.GunaCircleButton1.AnimationSpeed = 0.03!
        Me.GunaCircleButton1.BaseColor = System.Drawing.Color.Transparent
        Me.GunaCircleButton1.BorderColor = System.Drawing.Color.Transparent
        Me.GunaCircleButton1.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaCircleButton1.Dock = System.Windows.Forms.DockStyle.Right
        Me.GunaCircleButton1.FocusedColor = System.Drawing.Color.Empty
        Me.GunaCircleButton1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaCircleButton1.ForeColor = System.Drawing.Color.White
        Me.GunaCircleButton1.Image = Global.User_LaboratoryManagement.My.Resources.Resources.icons8_cancel_801
        Me.GunaCircleButton1.ImageSize = New System.Drawing.Size(40, 40)
        Me.GunaCircleButton1.Location = New System.Drawing.Point(315, 0)
        Me.GunaCircleButton1.Margin = New System.Windows.Forms.Padding(2)
        Me.GunaCircleButton1.Name = "GunaCircleButton1"
        Me.GunaCircleButton1.OnHoverBaseColor = System.Drawing.Color.Transparent
        Me.GunaCircleButton1.OnHoverBorderColor = System.Drawing.Color.Transparent
        Me.GunaCircleButton1.OnHoverForeColor = System.Drawing.Color.Transparent
        Me.GunaCircleButton1.OnHoverImage = Nothing
        Me.GunaCircleButton1.OnPressedColor = System.Drawing.Color.Transparent
        Me.GunaCircleButton1.Size = New System.Drawing.Size(72, 70)
        Me.GunaCircleButton1.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(80, 0)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(188, 70)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Enter Security Code"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightGray
        Me.Panel1.Location = New System.Drawing.Point(0, 59)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(496, 2)
        Me.Panel1.TabIndex = 0
        '
        'sercurity_code
        '
        Me.AcceptButton = Me.saveData
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(387, 226)
        Me.Controls.Add(Me.GunaGradient2Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "sercurity_code"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "sercurity_code"
        Me.TopMost = True
        Me.GunaGradient2Panel2.ResumeLayout(False)
        Me.GunaGradient2Panel2.PerformLayout()
        Me.gunaheader.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GunaGradient2Panel2 As Guna.UI.WinForms.GunaGradient2Panel
    Friend WithEvents GunaGradientButton1 As Guna.UI.WinForms.GunaGradientButton
    Friend WithEvents Label3 As Label
    Friend WithEvents security_cd As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents saveData As Guna.UI.WinForms.GunaGradientButton
    Friend WithEvents gunaheader As Guna.UI.WinForms.GunaGradient2Panel
    Friend WithEvents GunaCircleButton2 As Guna.UI.WinForms.GunaCircleButton
    Friend WithEvents GunaCircleButton1 As Guna.UI.WinForms.GunaCircleButton
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
End Class
