Public Class error_message
    Dim trueMess As String
    Sub messageERROR(message As String)
        trueMess = message
        ShowDialog()
    End Sub
    Private Sub back_error_Click(sender As Object, e As EventArgs) Handles back_error.Click
        Me.Close()
    End Sub

    Private Sub error_message_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Guna.UI.Lib.GraphicsHelper.ShadowForm(Me)
        Label1.Text = trueMess
    End Sub
End Class