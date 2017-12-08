Public Class SelectGame
    Public gLevel As Integer
    Private Sub Click_Easy(sender As Object, e As EventArgs) Handles EasyGame.Click
        My.Forms.SelectGame.Hide()
        gLevel = 8
        ' My.Forms.SelectGame.Close()
        DylanForm.Show()
    End Sub

    Private Sub Click_Hard(sender As Object, e As EventArgs) Handles HardGame.Click
        My.Forms.SelectGame.Hide()
        gLevel = 18
        'My.Forms.SelectGame.Close()
        DylanForm.Show()
    End Sub

    Private Sub Click_Medium(sender As Object, e As EventArgs) Handles MediumGame.Click
        My.Forms.SelectGame.Hide()
        gLevel = 12
        DylanForm.Show()
    End Sub
End Class