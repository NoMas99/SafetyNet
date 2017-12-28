Public Class DrawLetters
    Dim shouldPaint As Boolean = False

    Private Sub DrawLetters_Load(sender As Object, e As EventArgs) Handles Me.Load, TextBox1.MouseEnter

    End Sub

    Private Sub DrawLetters_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        If shouldPaint Then
            Dim vGraphics As Graphics = CreateGraphics()
            vGraphics.FillEllipse(New SolidBrush(Color.BlueViolet), e.X, e.Y, 22, 22)
        End If
    End Sub

    Private Sub DrawLetters_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown
        shouldPaint = True
    End Sub

    Private Sub DrawLetters_MouseUp(sender As Object, e As MouseEventArgs) Handles Me.MouseUp
        shouldPaint = False
    End Sub






    Private Sub TextBox4_MouseDown(sender As Object, e As MouseEventArgs)
        ' TextBox4.BackColor = Color.Yellow
    End Sub

    Sub BoxMouseUpEvent(fBox As System.Windows.Forms.TextBox)
        fBox.BackColor = Color.BlueViolet
        'Dim vSound As String
        'Dim vPhoto As String
        '' Refresh()
        '' EnableDisableAll(False)
        'vPhoto = fCover.Tag  'gets KappB
        'fCover.BackColor = Color.Transparent
        'fCover.BackgroundImage = My.Resources.ResourceManager.GetObject(vPhoto.Substring(0, 4)) 'image is Kapp
        'fCover.BackgroundImageLayout = ImageLayout.Stretch
        'fCover.Text = ""
        'If gCount = 0 Then
        '    'WMPlayer.URL = fCover.Text 'gets file that has been stored in this path at LoadForm
        '    vSound = cSoundPath & fCover.Tag & ".m4a"
        '    WMPlayer.URL = cSoundPath & fCover.Tag & ".m4a" 'gets file that has been stored in this path at LoadForm
        '    'Threading.Thread.Sleep(2200)
        'End If
        'gCount = gCount + 1
        'If gCount = 1 Then
        '    gChoice1 = fCover.Tag  'string like "GagaA" or "KappB"
        'End If
        'If gCount > 1 Then
        '    gChoice2 = fCover.Tag
        '    'Threading.Thread.Sleep(2000)
        '    MatchCheck()
        'End If
        'EnableDisableAll(True)
    End Sub


End Class