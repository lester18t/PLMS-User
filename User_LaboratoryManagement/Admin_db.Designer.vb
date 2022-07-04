<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Admin_db
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
        Me.pwbox = New Guna.UI.WinForms.GunaTextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.idbox = New Guna.UI.WinForms.GunaTextBox()
        Me.Label8 = New System.Windows.Forms.Label()
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
        Me.GunaGradient2Panel2.Controls.Add(Me.pwbox)
        Me.GunaGradient2Panel2.Controls.Add(Me.Label9)
        Me.GunaGradient2Panel2.Controls.Add(Me.idbox)
        Me.GunaGradient2Panel2.Controls.Add(Me.Label8)
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
        Me.GunaGradient2Panel2.Size = New System.Drawing.Size(404, 248)
        Me.GunaGradient2Panel2.TabIndex = 4
        '
        'pwbox
        '
        Me.pwbox.BackColor = System.Drawing.Color.Transparent
        Me.pwbox.BaseColor = System.Drawing.Color.White
        Me.pwbox.BorderColor = System.Drawing.Color.LightGray
        Me.pwbox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.pwbox.FocusedBaseColor = System.Drawing.Color.White
        Me.pwbox.FocusedBorderColor = System.Drawing.Color.Purple
        Me.pwbox.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.pwbox.Font = New System.Drawing.Font("Segoe UI Symbol", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pwbox.Location = New System.Drawing.Point(98, 148)
        Me.pwbox.Margin = New System.Windows.Forms.Padding(2)
        Me.pwbox.Name = "pwbox"
        Me.pwbox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.pwbox.Radius = 4
        Me.pwbox.Size = New System.Drawing.Size(260, 37)
        Me.pwbox.TabIndex = 2
        Me.pwbox.TextOffsetX = 5
        Me.pwbox.UseSystemPasswordChar = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(14, 159)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(85, 17)
        Me.Label9.TabIndex = 21
        Me.Label9.Text = "Password:"
        '
        'idbox
        '
        Me.idbox.BackColor = System.Drawing.Color.Transparent
        Me.idbox.BaseColor = System.Drawing.Color.White
        Me.idbox.BorderColor = System.Drawing.Color.LightGray
        Me.idbox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.idbox.FocusedBaseColor = System.Drawing.Color.White
        Me.idbox.FocusedBorderColor = System.Drawing.Color.Purple
        Me.idbox.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.idbox.Font = New System.Drawing.Font("Segoe UI Symbol", 13.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.idbox.Location = New System.Drawing.Point(98, 97)
        Me.idbox.Margin = New System.Windows.Forms.Padding(2)
        Me.idbox.Name = "idbox"
        Me.idbox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.idbox.Radius = 4
        Me.idbox.Size = New System.Drawing.Size(260, 37)
        Me.idbox.TabIndex = 1
        Me.idbox.TextOffsetX = 5
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(50, 108)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(48, 17)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "User:"
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
        Me.saveData.Location = New System.Drawing.Point(150, 199)
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
        Me.saveData.Size = New System.Drawing.Size(146, 32)
        Me.saveData.TabIndex = 12
        Me.saveData.Text = "Enter"
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
        Me.gunaheader.Size = New System.Drawing.Size(404, 70)
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
        Me.GunaCircleButton2.Image = Global.User_LaboratoryManagement.My.Resources.Resources.icons8_database_administrator_100
        Me.GunaCircleButton2.ImageSize = New System.Drawing.Size(40, 40)
        Me.GunaCircleButton2.Location = New System.Drawing.Point(0, 0)
        Me.GunaCircleButton2.Margin = New System.Windows.Forms.Padding(2)
        Me.GunaCircleButton2.Name = "GunaCircleButton2"
        Me.GunaCircleButton2.OnHoverBaseColor = System.Drawing.Color.Transparent
        Me.GunaCircleButton2.OnHoverBorderColor = System.Drawing.Color.Transparent
        Me.GunaCircleButton2.OnHoverForeColor = System.Drawing.Color.Transparent
        Me.GunaCircleButton2.OnHoverImage = Nothing
        Me.GunaCircleButton2.OnPressedColor = System.Drawing.Color.Transparent
        Me.GunaCircleButton2.Size = New System.Drawing.Size(82, 70)
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
        Me.GunaCircleButton1.ImageSize = New System.Drawing.Size(45, 45)
        Me.GunaCircleButton1.Location = New System.Drawing.Point(334, 0)
        Me.GunaCircleButton1.Margin = New System.Windows.Forms.Padding(2)
        Me.GunaCircleButton1.Name = "GunaCircleButton1"
        Me.GunaCircleButton1.OnHoverBaseColor = System.Drawing.Color.Transparent
        Me.GunaCircleButton1.OnHoverBorderColor = System.Drawing.Color.Transparent
        Me.GunaCircleButton1.OnHoverForeColor = System.Drawing.Color.Transparent
        Me.GunaCircleButton1.OnHoverImage = Nothing
        Me.GunaCircleButton1.OnPressedColor = System.Drawing.Color.Transparent
        Me.GunaCircleButton1.Size = New System.Drawing.Size(70, 70)
        Me.GunaCircleButton1.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(78, 0)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(202, 70)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Administrator Only"
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
        'Admin_db
        '
        Me.AcceptButton = Me.saveData
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(404, 248)
        Me.Controls.Add(Me.GunaGradient2Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Admin_db"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Admin_db"
        Me.GunaGradient2Panel2.ResumeLayout(False)
        Me.GunaGradient2Panel2.PerformLayout()
        Me.gunaheader.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GunaGradient2Panel2 As Guna.UI.WinForms.GunaGradient2Panel
    Friend WithEvents pwbox As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents idbox As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents saveData As Guna.UI.WinForms.GunaGradientButton
    Friend WithEvents gunaheader As Guna.UI.WinForms.GunaGradient2Panel
    Friend WithEvents GunaCircleButton2 As Guna.UI.WinForms.GunaCircleButton
    Friend WithEvents GunaCircleButton1 As Guna.UI.WinForms.GunaCircleButton
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
End Class
