<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Success
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
        Me.GunaPanel1 = New Guna.UI.WinForms.GunaPanel()
        Me.success_button = New Guna.UI.WinForms.GunaGradientButton()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GunaElipse1 = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GunaPanel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GunaPanel1
        '
        Me.GunaPanel1.BackColor = System.Drawing.Color.White
        Me.GunaPanel1.Controls.Add(Me.success_button)
        Me.GunaPanel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GunaPanel1.Location = New System.Drawing.Point(0, 181)
        Me.GunaPanel1.Margin = New System.Windows.Forms.Padding(2)
        Me.GunaPanel1.Name = "GunaPanel1"
        Me.GunaPanel1.Size = New System.Drawing.Size(254, 80)
        Me.GunaPanel1.TabIndex = 5
        '
        'success_button
        '
        Me.success_button.Animated = True
        Me.success_button.AnimationHoverSpeed = 0.07!
        Me.success_button.AnimationSpeed = 0.03!
        Me.success_button.BackColor = System.Drawing.Color.Transparent
        Me.success_button.BaseColor1 = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.success_button.BaseColor2 = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.success_button.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.success_button.BorderSize = 1
        Me.success_button.DialogResult = System.Windows.Forms.DialogResult.None
        Me.success_button.FocusedColor = System.Drawing.Color.Empty
        Me.success_button.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.success_button.ForeColor = System.Drawing.Color.White
        Me.success_button.Image = Nothing
        Me.success_button.ImageOffsetX = 2
        Me.success_button.ImageSize = New System.Drawing.Size(20, 20)
        Me.success_button.ImeMode = System.Windows.Forms.ImeMode.Hangul
        Me.success_button.Location = New System.Drawing.Point(80, 24)
        Me.success_button.Margin = New System.Windows.Forms.Padding(2)
        Me.success_button.Name = "success_button"
        Me.success_button.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.success_button.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.success_button.OnHoverBorderColor = System.Drawing.Color.Transparent
        Me.success_button.OnHoverForeColor = System.Drawing.Color.White
        Me.success_button.OnHoverImage = Nothing
        Me.success_button.OnPressedColor = System.Drawing.Color.Transparent
        Me.success_button.OnPressedDepth = 20
        Me.success_button.Radius = 18
        Me.success_button.Size = New System.Drawing.Size(95, 35)
        Me.success_button.TabIndex = 2
        Me.success_button.Text = "Go Back"
        Me.success_button.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.success_button.UseTransfarantBackground = True
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.PictureBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox2.Image = Global.User_LaboratoryManagement.My.Resources.Resources.icons8_ok_1101
        Me.PictureBox2.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(254, 181)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox2.TabIndex = 7
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(254, 261)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'GunaElipse1
        '
        Me.GunaElipse1.TargetControl = Me
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 13.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 144)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(254, 37)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Oops!!"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Success
        '
        Me.AcceptButton = Me.success_button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(254, 261)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.GunaPanel1)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Success"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Success"
        Me.TopMost = True
        Me.GunaPanel1.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GunaPanel1 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents success_button As Guna.UI.WinForms.GunaGradientButton
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents GunaElipse1 As Guna.UI.WinForms.GunaElipse
    Friend WithEvents Label1 As Label
End Class
