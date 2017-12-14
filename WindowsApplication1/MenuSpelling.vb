Public Class MenuSpelling
    Private Sub CmdOK_Click(sender As Object, e As EventArgs) Handles cmdOK.Click
        Me.Close()
        'Me.TextBox1.Text = "Stella"
        'SpellingGame.Activate()
    End Sub
    Private Sub CmdStella_Click(sender As Object, e As EventArgs) Handles picStell.Click
        Me.Hide()
        Me.TextBox1.Text = "stella"
        FreshSpell.Show()
    End Sub
    Private Sub CmdCat_Click(sender As Object, e As EventArgs) Handles picCat.Click
        Me.Hide()
        Me.TextBox1.Text = "cat"
        FreshSpell.Show()
    End Sub
    Private Sub CmdDog_Click(sender As Object, e As EventArgs) Handles picDog.Click, picDog.Click
        Me.Hide()
        Me.TextBox1.Text = "dog"
        FreshSpell.Show()
    End Sub
    Private Sub CmdStop_Click(sender As Object, e As EventArgs) Handles picDog.Click, picStop.Click
        Me.Hide()
        Me.TextBox1.Text = "stop"
        FreshSpell.Show()
    End Sub
    Private Sub CmdBlue_Click(sender As Object, e As EventArgs) Handles picDog.Click, picOldBlue.Click
        Me.Hide()
        Me.TextBox1.Text = "blue"
        FreshSpell.Show()
    End Sub
    Private Sub CmdBanana_Click(sender As Object, e As EventArgs) Handles picBanana.Click
        Me.Hide()
        Me.TextBox1.Text = "banana"
        FreshSpell.Show()
    End Sub
    Dim vCount As Integer = 1
    Private Sub TmrStella_Tick(sender As Object, e As EventArgs) Handles tmrStella.Tick
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
    Public Sub menuSpelling_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Me.ProgressBar1.Value = 0 Then
            MsgBox("Hello, Merle!")
        End If
    End Sub
End Class