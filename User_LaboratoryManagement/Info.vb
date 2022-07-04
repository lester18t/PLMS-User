Public Class Info
    Dim trueMess As String
    Sub messageInfo(message As String)
        trueMess = message
        Me.Show()
    End Sub
    Private Sub success_button_Click(sender As Object, e As EventArgs) Handles success_button.Click
        Me.Close()
    End Sub

    Private Sub Info_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Guna.UI.Lib.GraphicsHelper.ShadowForm(Me)
        Label1.Text = trueMess
    End Sub
End Class