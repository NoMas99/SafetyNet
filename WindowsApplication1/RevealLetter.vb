Public Class RevealLetter
    Dim shouldPaint As Boolean = False
    Private Sub DrawLetters_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        If shouldPaint Then
            Dim vGraphics As Graphics = CreateGraphics()
            vGraphics.FillEllipse(New SolidBrush(Color.BlueViolet), e.X, e.Y, 72, 72)
        End If
    End Sub
    Private Sub DrawLetters_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown
        shouldPaint = True
    End Sub

    Private Sub DrawLetters_MouseUp(sender As Object, e As MouseEventArgs) Handles Me.MouseUp
        shouldPaint = False
    End Sub
End Class