Imports User_LaboratoryManagement.forgot_email_pass
Public Class sercurity_code
    Dim er As New error_message
    Private Sub sercurity_code_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Guna.UI.Lib.GraphicsHelper.ShadowForm(Me)
    End Sub

    Private Sub GunaCircleButton1_Click(sender As Object, e As EventArgs) Handles GunaCircleButton1.Click
        security_cd.Text = ""
        Me.Close()
    End Sub

    Private Sub GunaGradientButton1_Click(sender As Object, e As EventArgs) Handles GunaGradientButton1.Click
        security_cd.Text = ""
        Me.Close()
    End Sub

    Private Sub saveData_Click(sender As Object, e As EventArgs) Handles saveData.Click
        If security_cd.Text = String.Empty Then
            er.messageERROR("Invalid Code!")
        ElseIf Not security_cd.Text.Equals(code_red) Then
            er.messageERROR("Incorrect Code!")
        Else
            newpass.Show()
            Me.Close()
        End If
    End Sub
End Class