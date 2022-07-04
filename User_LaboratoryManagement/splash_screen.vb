Public Class splash_screen
    Private Sub GunaGradientButton1_Click(sender As Object, e As EventArgs) Handles GunaGradientButton1.Click
        Application.Exit()
    End Sub

    Private Sub splash_screen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Guna.UI.Lib.GraphicsHelper.ShadowForm(Me)
        splash_progress.Value = 0

        splash_timer.Start()
    End Sub
    Private Sub splash_timer_Tick(sender As Object, e As EventArgs) Handles splash_timer.Tick
        splash_progress.Increment(5)
    End Sub
End Class