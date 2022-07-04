Public Class Success
    Dim trueMess As String
    Sub messageSuccess(message As String)
        trueMess = message
        Me.ShowDialog()
    End Sub
    Private Sub success_button_Click(sender As Object, e As EventArgs) Handles success_button.Click
        Me.Close()
    End Sub

    Private Sub Success_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Guna.UI.Lib.GraphicsHelper.ShadowForm(Me)
        Label1.Text = trueMess
    End Sub


End Class