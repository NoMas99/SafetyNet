Public Class Testing
    Sub MoveControls()
        'TrinaPhoto1.Location = New Point(vCood(0), vCood(1))
        btnNo.Location = New Point(0, 10)
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Yes_Click(sender As Object, e As EventArgs) Handles btnYes.Click
        'Form1.StartNewGame()
        Me.Close()
        Application.Restart()
    End Sub

    Private Sub btnNo_click(sender As Object, e As EventArgs) Handles btnNo.Click
        Form1.Close()
        DylanForm.Close()
        Me.Close()
        SelectGame.Close()
        Application.Exit()

    End Sub
End Class