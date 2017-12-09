Public Class FreshSpell
    Dim vWord As String
    Dim arrWord(5) As String
    Dim vCount As Integer
    Dim xrayEmptySpots(5) As Point
    Dim xrayFlyBirds(1) As PictureBox
    Dim xrayStayBirds(5) As PictureBox
    'Dim xrayStaySpots(5) As Point
    Dim xrayLittleLetters(25) As Button
    Dim xrayBigLetters(5) As Button
    Dim dikLittleLetters As New Dictionary(Of String, Button)


    'Public Sub SpellingGame_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    Public Sub freshspell_Load(sender As Object, e As EventArgs) Handles Me.Load


        Dim i As Integer




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
        ' xrayStayBirds = {picBird3, picBird4, picBird5, picBird6, picBird7, picBird8}

        Select Case MenuSpelling.TextBox1.Text
            Case "stella"
                vWord = "stella"
            Case "cat"
                vWord = "cat"
            Case "dog"
                vWord = "dog"
            Case "stop"
                vWord = "stop"
            Case Else
                vWord = InputBox("Enter up to 6 letter word:  ", "Let's Get This Thing Started")
        End Select

        vCount = Len(vWord)
        For i = 0 To vCount - 1
            arrWord(i) = UCase(Mid(vWord, i + 1, 1))
        Next
        ReDim Preserve arrWord(vCount - 1)

        TextBox1.Text = "ZZ"

        If vCount > 0 Then
            Button1.Text = arrWord(0)
            Button1.Tag = Button1.Text 'flag used to determine length of word, below
            Button1.BackColor = Color.LightGray
            Button1.ForeColor = Color.White
            Button1.FlatStyle = FlatStyle.Flat
            Button1.FlatAppearance.BorderColor = Color.Red
            Button1.Visible = True

        End If
        If vCount > 1 Then
            Button2.Text = arrWord(1)
            Button2.Tag = Button2.Text
            Button2.BackColor = Color.LightGray
            Button2.ForeColor = Color.White
            Button2.Visible = True
        Else
            Button2.Tag = TextBox1.Text
        End If
        If vCount > 2 Then
            Button3.Text = arrWord(2)
            Button3.Tag = Button3.Text
            Button3.BackColor = Color.LightGray
            Button3.ForeColor = Color.White
            Button3.Visible = True
        Else
            Button3.Tag = TextBox1.Text
        End If
        If vCount > 3 Then
            Button4.Text = arrWord(3)
            Button4.Tag = Button4.Text
            Button4.BackColor = Color.LightGray
            Button4.ForeColor = Color.White
            Button4.Visible = True
        Else
            Button4.Tag = TextBox1.Text
        End If
        If vCount > 4 Then
            Button5.Text = arrWord(4)
            Button5.Tag = Button5.Text
            Button5.BackColor = Color.LightGray
            Button5.ForeColor = Color.White
            Button5.Visible = True
        Else
            Button5.Tag = TextBox1.Text
        End If
        If vCount > 5 Then
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
        ReDim xrayEmptySpots(vCount - 1)
        Dim x As Integer = 0
        While x < vCount
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

    Public btn As Button ' this is a reference object
    Public ptX, ptY As Integer
    Public drag As Boolean
    Public startLoc As Point


    Public Sub nodebtn_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        If e.Button = MouseButtons.Left Then
            drag = True
            btn = CType(sender, Button)
            startLoc = btn.Location
            ptX = e.X : ptY = e.Y
        End If
    End Sub

    Public Sub nodebtn_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        If drag Then
            btn.Location = New Point(btn.Location.X + e.X - ptX, btn.Location.Y + e.Y - ptY)
            Me.Refresh()
        End If

    End Sub

    Public Sub nodebtn_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)

        If btn.Text = Button1.Text And btn.Location.Y < 180 And btn.Location.X > 26 And btn.Location.X < 220 Then
            My.Computer.Audio.Play("C:\aaCode\Tada.wav")
            Threading.Thread.Sleep(750)
            btn.Visible = False
            If Button2.Tag <> "ZZ" Then
                For Each cntrl As Control In Me.Controls
                    If TypeOf cntrl Is Button Then
                        If cntrl.Tag = Button1.Tag Then  'this should take care of the current letter and any duplicates
                            cntrl.BackColor = Color.Yellow
                            cntrl.ForeColor = Color.Purple
                        End If
                    End If
                Next
                Button2.FlatStyle = FlatStyle.Flat
                Button2.FlatAppearance.BorderColor = Color.Red
                PlayWav(Button2.Text)
            Else
                Winner()
            End If
        Else
            My.Computer.Audio.Play("C:\AJI\Windows Critical Stop.wav")
        End If
        If btn.Text = Button2.Text And Button1.BackColor = Color.Yellow And btn.Location.Y < 180 And btn.Location.X > 187 And btn.Location.X < 390 Then
            My.Computer.Audio.Play("C:\AJI\Tada.wav")
            btn.Visible = False
            Threading.Thread.Sleep(750)
            If Button3.Tag <> "ZZ" Then
                For Each cntrl As Control In Me.Controls
                    If TypeOf cntrl Is Button Then
                        If cntrl.Tag = Button2.Tag Then  'this should take care of the current letter and any duplicates
                            cntrl.BackColor = Color.Yellow
                            cntrl.ForeColor = Color.Purple
                        End If
                    End If
                Next
                Button3.FlatStyle = FlatStyle.Flat
                Button3.FlatAppearance.BorderColor = Color.Red
                PlayWav(Button3.Text)
            Else
                Winner()
            End If
        End If
        If btn.Text = Button3.Text And Button2.BackColor = Color.Yellow And btn.Location.Y < 180 And btn.Location.X > 349 And btn.Location.X < 555 Then
            My.Computer.Audio.Play("C:\AJI\Tada.wav")
            btn.Visible = False
            Threading.Thread.Sleep(750)
            If Button4.Tag <> "ZZ" Then
                For Each cntrl As Control In Me.Controls
                    If TypeOf cntrl Is Button Then
                        If cntrl.Tag = Button3.Tag Then  'this should take care of the current letter and any duplicates
                            cntrl.BackColor = Color.Yellow
                            cntrl.ForeColor = Color.Purple
                        End If
                    End If
                Next
                Button4.FlatStyle = FlatStyle.Flat
                Button4.FlatAppearance.BorderColor = Color.Red
                PlayWav(Button4.Text)
            Else
                Winner()
            End If
        End If
        If btn.Text = Button4.Text And Button3.BackColor = Color.Yellow And btn.Location.Y < 180 And btn.Location.X > 513 And btn.Location.X < 720 Then
            My.Computer.Audio.Play("C:\AJI\Tada.wav")
            btn.Visible = False
            Threading.Thread.Sleep(750)
            If Button5.Tag <> "ZZ" Then
                For Each cntrl As Control In Me.Controls
                    If TypeOf cntrl Is Button Then
                        If cntrl.Tag = Button4.Tag Then  'this should take care of the current letter and any duplicates
                            cntrl.BackColor = Color.Yellow
                            cntrl.ForeColor = Color.Purple
                        End If
                    End If
                Next
                Button5.FlatStyle = FlatStyle.Flat
                Button5.FlatAppearance.BorderColor = Color.Red
                If vWord = "stella" Then  'workaround for the double L
                    Button6.FlatStyle = FlatStyle.Flat
                    Button6.FlatAppearance.BorderColor = Color.Red
                    PlayWav(Button6.Text)
                Else
                    PlayWav(Button5.Text)
                End If
            Else
                Winner()
            End If
        End If
        If btn.Text = Button5.Text And Button4.BackColor = Color.Yellow And btn.Location.Y < 180 And btn.Location.X > 675 And btn.Location.X < 880 Then
            My.Computer.Audio.Play("C:\AJI\Tada.wav")
            btn.Visible = False
            Threading.Thread.Sleep(750)
            If Button6.Tag <> "ZZ" Then
                For Each cntrl As Control In Me.Controls
                    If TypeOf cntrl Is Button Then
                        If cntrl.Tag = Button5.Tag Then  'this should take care of the current letter and any duplicates
                            cntrl.BackColor = Color.Yellow
                            cntrl.ForeColor = Color.Purple
                        End If
                    End If
                Next
                Button6.FlatStyle = FlatStyle.Flat
                Button6.FlatAppearance.BorderColor = Color.Red
                PlayWav(Button6.Text)
            Else
                Winner()
            End If
        End If
        If btn.Text = Button6.Text And Button5.BackColor = Color.Yellow And btn.Location.Y < 180 And btn.Location.X > 840 And btn.Location.X < 1050 Then
            My.Computer.Audio.Play("C:\AJI\Tada.wav")
            btn.Visible = False
            Button6.BackColor = Color.Yellow
            Button6.ForeColor = Color.Purple
            Winner()
        End If

        btn.Location = startLoc
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
        'For Each element In xrayStayBirds
        '    element.Refresh()
        'Next

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
        End Select


        For Each cntrl As Control In Me.Controls
            If TypeOf cntrl Is Button Then
                If cntrl.Tag <> "ZZ" And cntrl.Size.Width = 145 Then
                    cntrl.BackColor = Color.Red
                Else
                    cntrl.Visible = False
                End If
            End If
        Next
        'For Each element In xrayStayBirds
        '    element.Visible = False
        'Next


        'picBird3.Visible = False
        My.Computer.Audio.Play("C:\aaCode\YouAreTheWinner.wav")
        picBird.Visible = True
        picBird2.Visible = True
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

        Select Case birdCount
            Case 1
                picBird.Image = My.Resources.bird1
                picBird.Location = New Point(picBird.Location.X + 20, picBird.Location.Y + 8)
                picBird2.Image = My.Resources.bird6
                picBird2.Location = New Point(picBird2.Location.X + 15, picBird2.Location.Y + 6)
                birdCount += 1
            Case 2
                picBird.Image = My.Resources.bird2
                picBird.Location = New Point(picBird.Location.X + 20, picBird.Location.Y + -11)
                picBird2.Image = My.Resources.bird7
                picBird2.Location = New Point(picBird2.Location.X + 21, picBird2.Location.Y + -14)
                birdCount += 1
            Case 3
                picBird.Image = My.Resources.bird3
                picBird.Location = New Point(picBird.Location.X + 20, picBird.Location.Y + 8)
                picBird2.Image = My.Resources.bird8
                picBird2.Location = New Point(picBird2.Location.X + 18, picBird2.Location.Y + 7)
                birdCount += 1
            Case 4
                picBird.Image = My.Resources.bird4
                picBird.Location = New Point(picBird.Location.X + 20, picBird.Location.Y + -11)
                picBird2.Image = My.Resources.bird9
                picBird2.Location = New Point(picBird2.Location.X + 24, picBird2.Location.Y + -9)
                birdCount += 1
            Case 5
                picBird.Image = My.Resources.bird5
                picBird.Location = New Point(picBird.Location.X + 20, picBird.Location.Y + 8)
                picBird2.Image = My.Resources.bird10
                picBird2.Location = New Point(picBird2.Location.X + 17, picBird2.Location.Y + 8)
                birdCount += 1
            Case 6
                picBird.Image = My.Resources.bird6
                picBird.Location = New Point(picBird.Location.X + 20, picBird.Location.Y + -11)
                picBird2.Image = My.Resources.bird11
                picBird2.Location = New Point(picBird2.Location.X + 22, picBird2.Location.Y + -10)
                birdCount += 1
            Case 7
                picBird.Image = My.Resources.bird7
                picBird.Location = New Point(picBird.Location.X + 20, picBird.Location.Y + 8)
                picBird2.Image = My.Resources.bird12
                picBird2.Location = New Point(picBird2.Location.X + 15, picBird2.Location.Y + 6)
                birdCount += 1
            Case 8
                picBird.Image = My.Resources.bird8
                picBird.Location = New Point(picBird.Location.X + 15, picBird.Location.Y + -11)
                picBird2.Image = My.Resources.bird1
                picBird2.Location = New Point(picBird2.Location.X + 15, picBird2.Location.Y + -8)
                birdCount += 1
            Case 9
                picBird.Image = My.Resources.bird9
                picBird2.Image = My.Resources.bird2
                birdCount += 1
               ' picBird.Location = New Point(picBird.Location.X + 15, picBird.Location.Y + 3)
            Case 10
                picBird.Image = My.Resources.bird10
                picBird2.Image = My.Resources.bird3
                birdCount += 1
               ' picBird.Location = New Point(picBird.Location.X + 15, picBird.Location.Y + -3)
            Case 11
                picBird.Image = My.Resources.bird11
                picBird2.Image = My.Resources.bird4
                birdCount += 1
               ' picBird.Location = New Point(picBird.Location.X + 15, picBird.Location.Y + 3)
            Case 12
                picBird.Image = My.Resources.birdLast
                picBird2.Image = My.Resources.bird5
                birdCount = 1
                ' picBird.Location = New Point(picBird.Location.X + 15, picBird.Location.Y + -3)



        End Select
    End Sub

    Public Sub PlayWav(fLetter As String)
        Dim vWav As String
        vWav = "C:\aaCode\FindThe" & fLetter & ".Wav"
        My.Computer.Audio.Play(vWav)

    End Sub
End Class