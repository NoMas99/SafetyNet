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
    Private Sub timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick, Button1.Click
        Dim tCount As Integer = 1
        Dim tLoop As Integer = 1

        While tLoop < 10
            Select Case tCount
                Case 1
                    My.Forms.SelectGame.BackColor = Color.Yellow
                    tCount += 1
                Case 2
                    My.Forms.SelectGame.BackColor = Color.Red
                    tCount = 1
                    tLoop += 1
            End Select
            Refresh()
            Threading.Thread.Sleep(300)
        End While

    End Sub
End Class