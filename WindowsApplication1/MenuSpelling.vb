Public Class MenuSpelling
    Private Sub cmdOK_Click(sender As Object, e As EventArgs) Handles cmdOK.Click
        ' Me.Hide()
        'ActiveForm
    End Sub
    Dim vCount As Integer = 1
    Private Sub tmrStella_Tick(sender As Object, e As EventArgs) Handles tmrStella.Tick
        ' Dim vCount As Integer
        'Dim vSize As Size
        'Select Case vCount
        '    Case 1
        'vSize = picStell.Size
        'picStell.Location = New Point(picStell.Location.X + 20, picStell.Location.Y + 20)

        picStell.Width = Width + 1
        picStell.Height = Height + 1
        'picStell.Size = New Size(100, 100)
        'PictureBox1.Size = New Size(300, 250)
        'picBird.Image = My.Resources.bird1
        'picBird.Location = New Point(picBird.Location.X + 20, picBird.Location.Y + 8)
        'picBird2.Image = My.Resources.bird6
        'picBird2.Location = New Point(picBird2.Location.X + 15, picBird2.Location.Y + 6)
        'birdCount += 1
        'Case 2
        'picBird.Image = My.Resources.bird2
        'picBird.Location = New Point(picBird.Location.X + 20, picBird.Location.Y + -11)
        'picBird2.Image = My.Resources.bird7
        'picBird2.Location = New Point(picBird2.Location.X + 21, picBird2.Location.Y + -14)
        'birdCount += 1
        'Case 3
        'End Select
    End Sub
End Class