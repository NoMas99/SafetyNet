Imports System.Windows.Forms
Public Class DrawLetters
    Dim shouldPaint As Boolean = False
    Dim hovering As String = "off"

    Private Sub DrawLetters_Load(sender As Object, e As EventArgs) Handles Me.Load, TextBox1.MouseEnter

    End Sub

    Private Sub DrawLetters_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        If shouldPaint Then
            'If MousePosition.X < 300 Then
            Dim vGraphics As Graphics = CreateGraphics()
            vGraphics.FillEllipse(New SolidBrush(Color.BlueViolet), e.X, e.Y, 12, 12)
            'End If
        End If
    End Sub

    Private Sub DrawLetters_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown
        ' If MouseIsOverControl(LineShape1) = False Then
        ' If MousePosition.X < 300 Then
        shouldPaint = True

        'End If
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
    Private Sub PictureBox1_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs)
        hovering = "on"
    End Sub

    Private Sub PictureBox1_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs)
        hovering = "off"
    End Sub
    Public Function MouseIsOverControl(ByVal c As Control) As Boolean
        Return c.ClientRectangle.Contains(c.PointToClient(Control.MousePosition))
    End Function
End Class