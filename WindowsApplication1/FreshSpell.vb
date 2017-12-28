Public Class FreshSpell
    Dim vWord As String
    Dim arrWord(5) As String
    Dim vCount As Integer
    Dim vLoop As Integer = 1
    Dim vLetterCount As Integer = 1
    Dim xrayEmptySpots(5) As Point
    Dim xrayFlyBirds(1) As PictureBox
    Dim xrayStayBirds(5) As PictureBox
    Dim xrayProgress(5) As TextBox
    Dim xrayProgressNumbers(5) As TextBox
    Dim btnBig As Button
    Dim btnBigNext As Button
    Dim xrayLittleLetters(25) As Button
    Dim xrayBigLetters(5) As Button
    Dim dikLittleLetters As New Dictionary(Of String, Button)

    Public Sub freshSpell_Load(sender As Object, e As EventArgs) Handles Me.Load

        Dim i As Integer
        ' My.Forms.MenuSpelling.Close()
        Me.WindowState = FormWindowState.Maximized

        For Each cntrl As Control In Me.Controls
            If TypeOf cntrl Is Button Then
                If cntrl.ForeColor = Color.Lavender Then
                    AddHandler cntrl.MouseDown, AddressOf nodebtn_MouseDown
                    AddHandler cntrl.MouseMove, AddressOf nodebtn_MouseMove
                    AddHandler cntrl.MouseUp, AddressOf nodebtn_MouseUp
                    Tag = 0
                    xrayLittleLetters(i) = cntrl
                    i = i + 1
                End If
            End If
        Next

        xrayFlyBirds = {picBird, picBird2}
        xrayBigLetters = {Button1, Button2, Button3, Button4, Button5, Button6}
        xrayProgress = {My.Forms.MenuSpelling.pb1, My.Forms.MenuSpelling.pb2, My.Forms.MenuSpelling.pb3, My.Forms.MenuSpelling.pb4,
        My.Forms.MenuSpelling.pb5, My.Forms.MenuSpelling.pb6}
        xrayProgressNumbers = {My.Forms.MenuSpelling.tb1, My.Forms.MenuSpelling.tb2, My.Forms.MenuSpelling.tb3, My.Forms.MenuSpelling.tb4,
        My.Forms.MenuSpelling.tb5, My.Forms.MenuSpelling.tb6}
        Select Case MenuSpelling.TextBox1.Text
            Case "stella"
                vWord = "stella"
            Case "cat"
                vWord = "cat"
            Case "dog"
                vWord = "dog"
            Case "stop"
                vWord = "stop"
            Case "blue"
                vWord = "blue"
            Case "banana"
                vWord = "banana"
            Case Else
                vWord = InputBox("Enter up to 6 letter word:  ", "Let's Get This Thing Started")
        End Select

        vLetterCount = Len(vWord)
        For i = 0 To vLetterCount - 1
            arrWord(i) = UCase(Mid(vWord, i + 1, 1))
        Next
        ReDim Preserve arrWord(vLetterCount - 1)

        TextBox1.Text = "ZZ"

        If vLetterCount > 0 Then
            Button1.Text = arrWord(0)
            Button1.Tag = Button1.Text 'flag used to determine length of word, below
            Button1.BackColor = Color.LightGray
            Button1.ForeColor = Color.White
            Button1.FlatStyle = FlatStyle.Flat
            Button1.FlatAppearance.BorderColor = Color.Red
            Button1.Visible = True
        End If
        If vLetterCount > 1 Then
            Button2.Text = arrWord(1)
            Button2.Tag = Button2.Text
            Button2.BackColor = Color.LightGray
            Button2.ForeColor = Color.White
            Button2.Visible = True
        Else
            Button2.Tag = TextBox1.Text
        End If
        If vLetterCount > 2 Then
            Button3.Text = arrWord(2)
            Button3.Tag = Button3.Text
            Button3.BackColor = Color.LightGray
            Button3.ForeColor = Color.White
            Button3.Visible = True
        Else
            Button3.Tag = TextBox1.Text
        End If
        If vLetterCount > 3 Then
            Button4.Text = arrWord(3)
            Button4.Tag = Button4.Text
            Button4.BackColor = Color.LightGray
            Button4.ForeColor = Color.White
            Button4.Visible = True
        Else
            Button4.Tag = TextBox1.Text
        End If
        If vLetterCount > 4 Then
            Button5.Text = arrWord(4)
            Button5.Tag = Button5.Text
            Button5.BackColor = Color.LightGray
            Button5.ForeColor = Color.White
            Button5.Visible = True
        Else
            Button5.Tag = TextBox1.Text
        End If
        If vLetterCount > 5 Then
            Button6.Text = arrWord(5)
            Button6.Tag = Button6.Text
            Button6.BackColor = Color.LightGray
            Button6.ForeColor = Color.White
            Button6.Visible = True
        Else
            Button6.Tag = TextBox1.Text
        End If

        'this routine takes each letter in arrWord and finds the control that has the same Text and then assigns this buttons location to xrayEmptySpot
        'to know where the empty spots are once the letters have been dragged (drug) up to the word
        ReDim xrayEmptySpots(vLetterCount - 1)
        Dim x As Integer = 0
        While x < vLetterCount
            For Each element In arrWord
                For Each cntrl In xrayLittleLetters
                    If cntrl.Text = element Then
                        xrayEmptySpots(x) = cntrl.Location
                        x = x + 1
                    End If
                Next
            Next
        End While

        My.Forms.FreshSpell.Show()
        PlayWav(Button1.Text)

    End Sub

    Public btnSmall As Button ' this is a reference object
    Public ptX, ptY As Integer
    Public drag As Boolean
    Public startLoc As Point


    Public Sub nodebtn_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        If e.Button = MouseButtons.Left Then
            drag = True
            btnSmall = CType(sender, Button)
            startLoc = btnSmall.Location
            ptX = e.X : ptY = e.Y
        End If
    End Sub

    Public Sub nodebtn_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        If drag Then
            btnSmall.Location = New Point(btnSmall.Location.X + e.X - ptX, btnSmall.Location.Y + e.Y - ptY)
            Me.Refresh()
        End If
    End Sub

    Public Sub nodebtn_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        Dim xBigL As Integer
        Dim xBigR As Integer
        Dim yBigT As Integer
        Dim vExit As Boolean
        Dim vSec As Integer
        drag = False
        Select Case vLoop
            Case 1
                btnBig = Button1
                btnBigNext = Button2
                xBigL = 0
                xBigR = 220
                yBigT = 180
                vExit = True
            Case 2
                btnBig = Button2
                btnBigNext = Button3
                xBigL = 187
                xBigR = 390
                yBigT = 180
                vExit = True
            Case 3
                btnBig = Button3
                btnBigNext = Button4
                xBigL = 349
                xBigR = 555
                yBigT = 180
                vExit = True
            Case = 4
                btnBig = Button4
                btnBigNext = Button5
                xBigL = 513
                xBigR = 720
                yBigT = 180
                vExit = True
            Case 5
                btnBig = Button5
                btnBigNext = Button6
                xBigL = 675
                xBigR = 880
                yBigT = 180
                vExit = True
            Case 6
                btnBig = Button6
                btnBigNext = Button5 'actually buttonPrevious in this case
                If btnSmall.Text = btnBig.Text And btnBigNext.BackColor = Color.Yellow And btnSmall.Location.Y < 180 And btnSmall.Location.X > 840 And btnSmall.Location.X < 1050 Then
                    My.Computer.Audio.Play("C:\AJI\Tada.wav")
                    btnSmall.Visible = False
                    Button6.BackColor = Color.Yellow
                    Button6.ForeColor = Color.Purple
                    Winner()
                End If
            Case Else
                Exit Sub
        End Select
        vSec = vLoop
        ' vLoop += 1
        vCount = 0
        vExit = False

        If btnSmall.Text = btnBig.Text And btnSmall.Location.Y < yBigT And btnSmall.Location.X > xBigL And btnSmall.Location.X < xBigR Then  'if the dragged smallLetter matches the bigLetter and is dragged "close" to the bigLetter
            My.Computer.Audio.Play("C:\aaCode\Tada.wav")
            Threading.Thread.Sleep(750) 'delay to allow the Tada time to play
            If btnBigNext.Tag <> "ZZ" Then  'basically checking if there is a next bigLetter
                btnSmall.Visible = False
                btnBig.BackColor = Color.Yellow
                btnBig.ForeColor = Color.Purple
                Refresh()
                For BL = vSec To UBound(xrayBigLetters) 'this secondary loop checks if there are any of the same letter LATER in the word; vLoop being where we are in the word in the primary loop
                    If xrayBigLetters(BL).Text = btnSmall.Text Then
                        vExit = True 'sets a flag indicating that there is at least one more instance of the letter later in the word (see it used below)
                    End If
                Next
                If vExit = True Then
                    btnSmall.Visible = True  'keeps the smallLetter visible to be used again later in the word
                End If
                btnBigNext.FlatStyle = FlatStyle.Flat
                btnBigNext.FlatAppearance.BorderColor = Color.Red  'borders the next bigLetter in red to highlight

                PlayWav(btnBigNext.Text)                           'and plays "Find the letter ___"
                drag = True
                'Threading.Thread.Sleep(2100) 'delay to allow the Tada time to play
                vLoop += 1
            Else
                Winner()    'or the last letter has been matched
            End If
        Else
            My.Computer.Audio.Play("C:\AJI\Windows Critical Stop.wav")  'the dragged smallLetter did not match the bigLetter, or was not dragged to a close enough position
        End If
        btnSmall.Location = startLoc
        drag = False
    End Sub
    Sub Winner()

        'Dim i As Integer = 1


        'For i = 0 To vCount - 1
        '    While i < vCount
        '        xrayStayBirds(i).Location = xrayEmptySpots(i)
        '        xrayStayBirds(i).Visible = True
        '        i = i + 1
        '    End While
        'Next
        For Each cntrl In xrayLittleLetters
            cntrl.Visible = False
        Next
        For Each cntrl In xrayBigLetters
            cntrl.BackColor = Color.Yellow
            cntrl.ForeColor = Color.Purple
        Next
        Refresh()

        Select Case vWord
            Case "cat"
                My.Computer.Audio.Play("C:\aaCode\SpelledCat.wav")
                Threading.Thread.Sleep(3000)
            Case "dog"
                My.Computer.Audio.Play("C:\aaCode\SpelledDog.wav")
                Threading.Thread.Sleep(3000)
            Case "stella"
                My.Computer.Audio.Play("C:\aaCode\SpelledStella.wav")
                Threading.Thread.Sleep(4000)
            Case "stop"
                My.Computer.Audio.Play("C:\aaCode\SpelledStop.wav")
                Threading.Thread.Sleep(4000)
            Case "blue"
                My.Computer.Audio.Play("C:\aaCode\SpelledBlue.wav")
                Threading.Thread.Sleep(4000)
            Case "banana"
                My.Computer.Audio.Play("C:\aaCode\SpelledBanana.wav")
                Threading.Thread.Sleep(4500)
        End Select



        My.Computer.Audio.Play("C:\aaCode\ScareTheChickens.wav")
        picBird.Visible = True
        picBird2.Visible = True
        picBird3.Visible = True
        tmrEndAnimation.Enabled = True
        tmrAnimation.Start()

    End Sub
    Dim birdCount As Integer = 1

    Private Sub tmrAnimation_Tick(sender As Object, e As EventArgs) Handles tmrAnimation.Tick
        Dim xB1 As Integer = 20
        Dim xB2 As Integer = 21
        Dim yB1 As Integer = 8
        Dim yB2 As Integer = 6
        Dim xB11 As Integer = 18
        Dim xB22 As Integer = 20
        Dim yB11 As Integer = -14
        Dim yB22 As Integer = -11
        Dim vRounds As Integer = 0
        Dim tRound As String
        Dim vWav As String

        'THE ROUND WILL END IN THIS NEXT SECTION

        ProgressBar1.Value = ProgressBar1.Value + 1 'keeps a count of the timer loops
        If ProgressBar1.Value > 140 Then  'the chickens have flown far enough
            tmrAnimation.Enabled = False
            tmrAnimation.Stop()
            My.Forms.FreshSpell.Close()
            'My.Forms.MenuSpelling.ProgressBar1.Value = My.Forms.MenuSpelling.ProgressBar1.Value + 1
            For Each box In xrayProgress 'checks the custom progress bar (series of textboxes) and makes visible the next one and exits the For loop
                If box.Tag = "Off" Then
                    box.Visible = True
                    box.Tag = "On"
                    Exit For
                End If
            Next
            For Each box In xrayProgressNumbers 'and now the numbers inside the progress textboxes
                If box.Tag = "Off" Then
                    box.Visible = True
                    box.Tag = "On"
                    vRounds += 1
                    Exit For
                End If
            Next
            My.Forms.MenuSpelling.Show()  'shows menu for next round
            tRound = Trim(Str(vRounds))

            ' PlayWav(tRound & "Points")
            vWav = "C:\aaCode\" & tRound & "Points" & ".Wav"
            My.Computer.Audio.Play(vWav)

            If My.Forms.MenuSpelling.tb6.Tag = "On" Then  'if the last text box in the "progress
                My.Forms.MenuSpelling.OvalShape1.Visible = True  'the tip of the "thermometer"
                PlayWav("Surprise")
            End If
        End If

        Select Case birdCount

            Case 1
                picBird.Image = My.Resources.bird1
                picBird.Location = New Point(picBird.Location.X + 20, picBird.Location.Y + 8)
                picBird2.Image = My.Resources.bird6
                picBird2.Location = New Point(picBird2.Location.X + 15, picBird2.Location.Y + 6)
                picBird3.Image = My.Resources.bird6
                picBird3.Location = New Point(picBird3.Location.X + 12, picBird3.Location.Y + 6)
                birdCount += 1
            Case 2
                picBird.Image = My.Resources.bird2
                picBird.Location = New Point(picBird.Location.X + 20, picBird.Location.Y + -11)
                picBird2.Image = My.Resources.bird7
                picBird2.Location = New Point(picBird2.Location.X + 21, picBird2.Location.Y + -14)
                picBird3.Image = My.Resources.bird7
                picBird3.Location = New Point(picBird3.Location.X + 20, picBird3.Location.Y + -14)
                birdCount += 1
            Case 3
                picBird.Image = My.Resources.bird3
                picBird.Location = New Point(picBird.Location.X + 20, picBird.Location.Y + 8)
                picBird2.Image = My.Resources.bird8
                picBird2.Location = New Point(picBird2.Location.X + 18, picBird2.Location.Y + 7)
                picBird3.Image = My.Resources.bird8
                picBird3.Location = New Point(picBird3.Location.X + 16, picBird3.Location.Y + 7)
                birdCount += 1
            Case 4
                picBird.Image = My.Resources.bird4
                picBird.Location = New Point(picBird.Location.X + 20, picBird.Location.Y + -11)
                picBird2.Image = My.Resources.bird9
                picBird2.Location = New Point(picBird2.Location.X + 24, picBird2.Location.Y + -9)
                picBird3.Image = My.Resources.bird9
                picBird3.Location = New Point(picBird3.Location.X + 20, picBird3.Location.Y + -9)
                birdCount += 1
            Case 5
                picBird.Image = My.Resources.bird5
                picBird.Location = New Point(picBird.Location.X + 20, picBird.Location.Y + 8)
                picBird2.Image = My.Resources.bird10
                picBird2.Location = New Point(picBird2.Location.X + 17, picBird2.Location.Y + 8)
                picBird3.Image = My.Resources.bird10
                picBird3.Location = New Point(picBird3.Location.X + 20, picBird3.Location.Y + 8)
                birdCount += 1
            Case 6
                picBird.Image = My.Resources.bird6
                picBird.Location = New Point(picBird.Location.X + 20, picBird.Location.Y + -11)
                picBird2.Image = My.Resources.bird11
                picBird2.Location = New Point(picBird2.Location.X + 22, picBird2.Location.Y + -10)
                picBird3.Image = My.Resources.bird11
                picBird3.Location = New Point(picBird3.Location.X + 23, picBird3.Location.Y + -10)
                birdCount += 1
            Case 7
                picBird.Image = My.Resources.bird7
                picBird.Location = New Point(picBird.Location.X + 20, picBird.Location.Y + 8)
                picBird2.Image = My.Resources.bird12
                picBird2.Location = New Point(picBird2.Location.X + 15, picBird2.Location.Y + 6)
                picBird3.Image = My.Resources.bird12
                picBird3.Location = New Point(picBird3.Location.X + 15, picBird3.Location.Y + 6)
                birdCount += 1
            Case 8
                picBird.Image = My.Resources.bird8
                picBird.Location = New Point(picBird.Location.X + 15, picBird.Location.Y + -11)
                picBird2.Image = My.Resources.bird1
                picBird2.Location = New Point(picBird2.Location.X + 15, picBird2.Location.Y + -8)
                picBird3.Image = My.Resources.bird1
                picBird3.Location = New Point(picBird3.Location.X + 20, picBird3.Location.Y + -8)
                birdCount += 1
            Case 9
                picBird.Image = My.Resources.bird9
                picBird2.Image = My.Resources.bird2
                birdCount += 1
               ' picBird.Location = New Point(picBird.Location.X + 15, picBird.Location.Y + 3)
            Case 10
                picBird.Image = My.Resources.bird10
                picBird2.Image = My.Resources.bird3
                picBird3.Image = My.Resources.bird5
                birdCount += 1
               ' picBird.Location = New Point(picBird.Location.X + 15, picBird.Location.Y + -3)
            Case 11
                picBird.Image = My.Resources.bird11
                picBird2.Image = My.Resources.bird4
                picBird3.Image = My.Resources.bird6
                birdCount += 1
               ' picBird.Location = New Point(picBird.Location.X + 15, picBird.Location.Y + 3)
            Case 12
                picBird.Image = My.Resources.birdLast
                picBird2.Image = My.Resources.bird5
                picBird3.Image = My.Resources.bird7
                birdCount = 1
                ' picBird.Location = New Point(picBird.Location.X + 15, picBird.Location.Y + -3)

        End Select
        ' End While
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

    End Sub

    Public Sub PlayWav(fLetter As String)
        Dim vWav As String
        vWav = "C:\aaCode\F" & UCase(fLetter) & ".Wav"
        My.Computer.Audio.Play(vWav)

    End Sub

End Class