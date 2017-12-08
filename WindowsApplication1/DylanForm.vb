Public Class DylanForm
    Public gCount As Integer
    Public gEnable As Boolean
    Const cSoundPath As String = "C:\AJI\GamePhotos\"
    Public gChoice1 As String
    Public gChoice2 As String
    Dim gDclick As String
    Dim gTEMP As Integer = SelectGame.gLevel  '**************************************************change this to gLevel
    Dim gColor As Color
    Dim arrSuspects As New List(Of String)
    Dim gCover1 As System.Windows.Forms.Button
    Dim gCover2 As System.Windows.Forms.Button

    Private Sub frmDylanLoad(sender As Object, e As EventArgs) Handles MyBase.Load
        'gTEMP = 12
        CheckForIllegalCrossThreadCalls = False 'this is necessary for the Background worker to work
        'these were commented-out on 12/4/17 to try to run SpellingGame
        ' My.Forms.SelectGame.Close()
        'StartNewGame()
        ' SpellingGame_load()
        ' My.Forms.SpellingGame.Show()
    End Sub


    Public Sub StartNewGame()
        Dim vSec As Integer
        gCount = 0  'reset variables
        gChoice1 = Nothing
        gChoice2 = Nothing
        gCover1 = Nothing
        gCover2 = Nothing
        gDclick = "none"

        'change the Cover colors, set Tags to 0, set Text to non-Path
        vSec = Second(Now())
        Select Case vSec
            Case 1, 5, 9, 13, 17, 21, 25, 29, 33, 37, 41, 45, 49, 53, 57
                gColor = Color.Yellow
            Case 2, 6, 10, 14, 18, 22, 26, 30, 34, 38, 42, 46, 50, 54, 58
                gColor = Color.HotPink
            Case 3, 7, 11, 15, 19, 23, 27, 31, 35, 39, 43, 47, 51, 55, 59
                gColor = Color.SeaGreen
            Case 4, 8, 12, 16, 20, 24, 28, 32, 36, 40, 44, 48, 52, 56, 0
                gColor = Color.Chocolate
            Case Else
                gColor = Color.Chocolate
        End Select

        For Each cntrl As Control In Me.Controls
            If TypeOf cntrl Is Button Then
                cntrl.BackColor = gColor
                'cntrl.Visible = True
                cntrl.Tag = "blank"
                cntrl.Text = "S"
            End If
        Next

        If gTEMP = 8 Then  'Easy Game has been selected with 12 cards, otherwise the 12 or default 16 Card option
            My.Forms.DylanForm.Size = New Size(1119, 745)
            Cover9.Visible = False
            Cover10.Visible = False
            Cover11.Visible = False
            Cover12.Visible = False
            Cover13.Visible = False
            Cover14.Visible = False
            Cover15.Visible = False
            Cover16.Visible = False
            Cover17.Visible = False
            Cover18.Visible = False
            Cover9.Tag = "inactive"
            Cover10.Tag = "inactive"
            Cover11.Tag = "inactive"
            Cover12.Tag = "inactive"
            Cover13.Tag = "inactive"
            Cover14.Tag = "inactive"
            Cover15.Tag = "inactive"
            Cover16.Tag = "inactive"
            Cover17.Tag = "inactive"
            Cover18.Tag = "inactive"


        End If
        If gTEMP = 12 Then  'Medium Game has been selected with 8 cards, otherwise the default 12 Card option
            My.Forms.DylanForm.Size = New Size(1119, 1092)
            Cover13.Visible = False
            Cover14.Visible = False
            Cover15.Visible = False
            Cover16.Visible = False
            Cover17.Visible = False
            Cover18.Visible = False
            Cover13.Tag = "inactive"
            Cover14.Tag = "inactive"
            Cover15.Tag = "inactive"
            Cover16.Tag = "inactive"
            Cover17.Tag = "inactive"
            Cover18.Tag = "inactive"
        End If


        Dim vRandom As New Random
        Dim vPhotoChoice As String
        Dim vLocationLetter As String
        Dim vLocationLetter2 As String
        Dim vSus As Integer = 18  '***currently there are 18 "suspects"
        Dim vLoc As Integer
        Dim vList = New List(Of String) From {"a", "b", "c", "d", "e", "f", "g", "h"}
        Dim vRanNum As Integer

        If gTEMP = 12 Then  'Hard
            vList.Add("i")
            vList.Add("j")
            vList.Add("k")
            vList.Add("l")
        End If
        If gTEMP = 18 Then
            vList.Add("i")
            vList.Add("j")
            vList.Add("k")
            vList.Add("l")
            vList.Add("m")
            vList.Add("n")
            vList.Add("o")
            vList.Add("p")
            vList.Add("q")
            vList.Add("r")
        End If

        vLoc = gTEMP 'just an easier variable to work with
        arrSuspects = New List(Of String) From {"Grammy", "Kappy", "Gaga", "Megs", "Dylan",
            "Shane", "Jennings", "Henry", "Augie", "Stocking", "Santa", "AUnicorn", "BUnicorn", "Casy",
            "Anthony", "ToyBear", "Stella", "BabyStella"}

        ' ******Photo1A&B
        Do While vLoc > 0
            Dim vGetPhoto = vRandom.Next(vSus)
            vPhotoChoice = arrSuspects(vGetPhoto) 'puts the current choice from the list into a string variable
            arrSuspects.RemoveAt(vGetPhoto) 'removes vChoice1 from the name list
            Dim vLocationChoice = vRandom.Next(vLoc)
            vLocationLetter = vList(vLocationChoice)
            vList.RemoveAt(vLocationChoice)
            Dim vLocationChoice2 = vRandom.Next(vLoc - 1) 'one less
            vLocationLetter2 = vList(vLocationChoice2)
            vList.RemoveAt(vLocationChoice2)
            'CreateNewButton(vLocationLetter, vLocationLetter2, vPhotoChoice)
            vRanNum = GetRN(vLocationLetter) 'calls the function that converts the letter to an integer
            AssignCovers(vPhotoChoice, vRanNum, "A")

            ' *****************PhotoB
            vRanNum = GetRN(vLocationLetter2)
            AssignCovers(vPhotoChoice, vRanNum, "B")
            vLoc = vLoc - 2
            vSus = vSus - 1
        Loop

    End Sub

    Public Sub AssignCovers(fPhoto As String, fCount As Integer, fCap As String)
        Select Case fCount
            Case 1
                Cover1.Tag = fPhoto.Substring(0, 4) & fCap
                Cover1.BackColor = gColor
                Cover1.Text = "S"
                Cover1.BackgroundImage = Nothing
            Case 2
                Cover2.Tag = fPhoto.Substring(0, 4) & fCap
                Cover2.BackColor = gColor
                Cover2.Text = "S"
                Cover2.BackgroundImage = Nothing
            Case 3
                Cover3.Tag = fPhoto.Substring(0, 4) & fCap
                Cover3.BackColor = gColor
                Cover3.Text = "S"
                Cover3.BackgroundImage = Nothing
            Case 4
                Cover4.Tag = fPhoto.Substring(0, 4) & fCap
                Cover4.BackColor = gColor
                Cover4.Text = "S"
                Cover4.BackgroundImage = Nothing
            Case 5
                Cover5.Tag = fPhoto.Substring(0, 4) & fCap
                Cover5.BackColor = gColor
                Cover5.Text = "S"
                Cover5.BackgroundImage = Nothing
            Case 6
                Cover6.Tag = fPhoto.Substring(0, 4) & fCap
                Cover6.BackColor = gColor
                Cover6.Text = "S"
                Cover6.BackgroundImage = Nothing
            Case 7
                Cover7.Tag = fPhoto.Substring(0, 4) & fCap
                Cover7.BackColor = gColor
                Cover7.Text = "S"
                Cover7.BackgroundImage = Nothing
            Case 8
                Cover8.Tag = fPhoto.Substring(0, 4) & fCap
                Cover8.BackColor = gColor
                Cover8.Text = "S"
                Cover8.BackgroundImage = Nothing
            Case 9
                Cover9.Tag = fPhoto.Substring(0, 4) & fCap
                Cover9.BackColor = gColor
                Cover9.Text = "S"
                Cover9.BackgroundImage = Nothing
            Case 10
                Cover10.Tag = fPhoto.Substring(0, 4) & fCap
                Cover10.BackColor = gColor
                Cover10.Text = "S"
                Cover10.BackgroundImage = Nothing
            Case 11
                Cover11.Tag = fPhoto.Substring(0, 4) & fCap
                Cover11.BackColor = gColor
                Cover11.Text = "S"
                Cover11.BackgroundImage = Nothing
            Case 12
                Cover12.Tag = fPhoto.Substring(0, 4) & fCap
                Cover12.BackColor = gColor
                Cover12.Text = "S"
                Cover12.BackgroundImage = Nothing
            Case 13
                Cover13.Tag = fPhoto.Substring(0, 4) & fCap
                Cover13.BackColor = gColor
                Cover13.Text = "S"
                Cover13.BackgroundImage = Nothing
            Case 14
                Cover14.Tag = fPhoto.Substring(0, 4) & fCap
                Cover14.BackColor = gColor
                Cover14.Text = "S"
                Cover14.BackgroundImage = Nothing
            Case 15
                Cover15.Tag = fPhoto.Substring(0, 4) & fCap
                Cover15.BackColor = gColor
                Cover15.Text = "S"
                Cover15.BackgroundImage = Nothing
            Case 16
                Cover16.Tag = fPhoto.Substring(0, 4) & fCap
                Cover16.BackColor = gColor
                Cover16.Text = "S"
                Cover16.BackgroundImage = Nothing
            Case 17
                Cover17.Tag = fPhoto.Substring(0, 4) & fCap
                Cover17.BackColor = gColor
                Cover17.Text = "S"
                Cover17.BackgroundImage = Nothing
            Case 18
                Cover18.Tag = fPhoto.Substring(0, 4) & fCap
                Cover18.BackColor = gColor
                Cover18.Text = "S"
                Cover18.BackgroundImage = Nothing

                'Case Else
                '    Cover8.Tag = fPhoto.Substring(0, 4) & fCap
                '    Cover8.BackColor = gColor
                '    Cover8.Text = "S"
                '    Cover8.BackgroundImage = Nothing
        End Select
    End Sub
    Public Function GetRN(ByVal fRN As String) As Integer 'gets the integer equivalent of character
        Select Case fRN
            Case "a"
                GetRN = 1
            Case "b"
                GetRN = 2
            Case "c"
                GetRN = 3
            Case "d"
                GetRN = 4
            Case "e"
                GetRN = 5
            Case "f"
                GetRN = 6
            Case "g"
                GetRN = 7
            Case "h"
                GetRN = 8
            Case "i"
                GetRN = 9
            Case "j"
                GetRN = 10
            Case "k"
                GetRN = 11
            Case "l"
                GetRN = 12
            Case "m"
                GetRN = 13
            Case "n"
                GetRN = 14
            Case "o"
                GetRN = 15
            Case "p"
                GetRN = 16
            Case "q"
                GetRN = 17
            Case "r"
                GetRN = 18
            Case Else
                GetRN = 1
        End Select
    End Function
    Private Sub Cover1_click(sender As Object, e As EventArgs) Handles Cover1.Click
        EnableDisableAll(False)
        If gCount = 0 Then
            gCover1 = Cover1
            gDclick = Cover1.Name
            'If BackgroundWorker1.IsBusy Then
            '    BackgroundWorker1.CancelAsync()
            'End If
            'BackgroundWorker1.RunWorkerAsync()
            CoverClickEvent(gCover1)
        Else
            If gDclick <> Cover1.Name Then 'make sure that the same card isn't clicked again
                gCover2 = Cover1
                CoverClickEvent(gCover2)
            Else
                EnableDisableAll(True)
            End If
        End If
        'BackgroundWorker1.CancelAsync()
    End Sub '
    Private Sub Cover2_Click(sender As Object, e As EventArgs) Handles Cover2.Click
        EnableDisableAll(False)
        If gCount = 0 Then
            gCover1 = Cover2
            gDclick = Cover2.Name
            CoverClickEvent(gCover1)
        Else
            If gDclick <> Cover2.Name Then 'make sure that the same card isn't clicked again
                gCover2 = Cover2
                CoverClickEvent(gCover2)
            Else
                EnableDisableAll(True)
            End If
        End If
    End Sub
    Private Sub Cover3_Click(sender As Object, e As EventArgs) Handles Cover3.Click
        EnableDisableAll(False)
        If gCount = 0 Then
            gCover1 = Cover3
            gDclick = Cover3.Name
            CoverClickEvent(gCover1)
        Else
            If gDclick <> Cover3.Name Then 'make sure that the same card isn't clicked again
                gCover2 = Cover3
                CoverClickEvent(gCover2)
            Else
                EnableDisableAll(True)
            End If
        End If
    End Sub
    Private Sub Cover4_Click(sender As Object, e As EventArgs) Handles Cover4.Click
        EnableDisableAll(False)
        If gCount = 0 Then
            gCover1 = Cover4
            gDclick = Cover4.Name
            CoverClickEvent(gCover1)
        Else
            If gDclick <> Cover4.Name Then 'make sure that the same card isn't clicked again
                gCover2 = Cover4
                CoverClickEvent(gCover2)
            Else
                EnableDisableAll(True)
            End If
        End If
    End Sub
    Private Sub Cover5_Click(sender As Object, e As EventArgs) Handles Cover5.Click
        EnableDisableAll(False)
        If gCount = 0 Then
            gCover1 = Cover5
            gDclick = Cover5.Name
            CoverClickEvent(gCover1)
        Else
            If gDclick <> Cover5.Name Then 'make sure that the same card isn't clicked again
                gCover2 = Cover5
                CoverClickEvent(gCover2)
            Else
                EnableDisableAll(True)
            End If
        End If
    End Sub
    Private Sub Cover6_Click(sender As Object, e As EventArgs) Handles Cover6.Click
        EnableDisableAll(False)
        If gCount = 0 Then
            gCover1 = Cover6
            gDclick = Cover6.Name
            CoverClickEvent(gCover1)
        Else
            If gDclick <> Cover6.Name Then 'make sure that the same card isn't clicked again
                gCover2 = Cover6
                CoverClickEvent(gCover2)
            Else
                EnableDisableAll(True)
            End If
        End If
    End Sub
    Private Sub Cover7_Click(sender As Object, e As EventArgs) Handles Cover7.Click
        EnableDisableAll(False)
        If gCount = 0 Then
            gCover1 = Cover7
            gDclick = Cover7.Name
            CoverClickEvent(gCover1)
        Else
            If gDclick <> Cover7.Name Then 'make sure that the same card isn't clicked again
                gCover2 = Cover7
                CoverClickEvent(gCover2)
            Else
                EnableDisableAll(True)
            End If
        End If
    End Sub
    Private Sub Cover8_Click(sender As Object, e As EventArgs) Handles Cover8.Click
        EnableDisableAll(False)
        If gCount = 0 Then
            gCover1 = Cover8
            gDclick = Cover8.Name
            CoverClickEvent(gCover1)
        Else
            If gDclick <> Cover8.Name Then 'make sure that the same card isn't clicked again
                gCover2 = Cover8
                CoverClickEvent(gCover2)
            Else
                EnableDisableAll(True)
            End If
        End If
    End Sub
    Private Sub Cover9_Click(sender As Object, e As EventArgs) Handles Cover9.Click
        EnableDisableAll(False)
        If gCount = 0 Then
            gCover1 = Cover9
            gDclick = Cover9.Name
            CoverClickEvent(gCover1)
        Else
            If gDclick <> Cover9.Name Then 'make sure that the same card isn't clicked again
                gCover2 = Cover9
                CoverClickEvent(gCover2)
            Else
                EnableDisableAll(True)
            End If
        End If
    End Sub
    Private Sub Cover10_Click(sender As Object, e As EventArgs) Handles Cover10.Click
        EnableDisableAll(False)
        If gCount = 0 Then
            gCover1 = Cover10
            gDclick = Cover10.Name
            CoverClickEvent(gCover1)
        Else
            If gDclick <> Cover10.Name Then 'make sure that the same card isn't clicked again
                gCover2 = Cover10
                CoverClickEvent(gCover2)
            Else
                EnableDisableAll(True)
            End If
        End If
    End Sub
    Private Sub Cover11_Click(sender As Object, e As EventArgs) Handles Cover11.Click
        EnableDisableAll(False)
        If gCount = 0 Then
            gCover1 = Cover11
            gDclick = Cover11.Name
            CoverClickEvent(gCover1)
        Else
            If gDclick <> Cover11.Name Then 'make sure that the same card isn't clicked again
                gCover2 = Cover11
                CoverClickEvent(gCover2)
            Else
                EnableDisableAll(True)
            End If
        End If
    End Sub
    Private Sub Cover12_Click(sender As Object, e As EventArgs) Handles Cover12.Click
        EnableDisableAll(False)
        If gCount = 0 Then
            gCover1 = Cover12
            gDclick = Cover12.Name
            CoverClickEvent(gCover1)
        Else
            If gDclick <> Cover12.Name Then 'make sure that the same card isn't clicked again
                gCover2 = Cover12
                CoverClickEvent(gCover2)
            Else
                EnableDisableAll(True)
            End If
        End If
    End Sub
    Private Sub Cover13_Click(sender As Object, e As EventArgs) Handles Cover13.Click
        EnableDisableAll(False)
        If gCount = 0 Then
            gCover1 = Cover13
            gDclick = Cover13.Name
            CoverClickEvent(gCover1)
        Else
            If gDclick <> Cover13.Name Then 'make sure that the same card isn't clicked again
                gCover2 = Cover13
                CoverClickEvent(gCover2)
            Else
                EnableDisableAll(True)
            End If
        End If
    End Sub
    Private Sub Cover14_Click(sender As Object, e As EventArgs) Handles Cover14.Click
        EnableDisableAll(False)
        If gCount = 0 Then
            gCover1 = Cover14
            gDclick = Cover14.Name
            CoverClickEvent(gCover1)
        Else
            If gDclick <> Cover14.Name Then 'make sure that the same card isn't clicked again
                gCover2 = Cover14
                CoverClickEvent(gCover2)
            Else
                EnableDisableAll(True)
            End If
        End If
    End Sub

    Private Sub Cover15_Click(sender As Object, e As EventArgs) Handles Cover15.Click
        EnableDisableAll(False)
        If gCount = 0 Then
            gCover1 = Cover15
            gDclick = Cover15.Name
            CoverClickEvent(gCover1)
        Else
            If gDclick <> Cover15.Name Then 'make sure that the same card isn't clicked again
                gCover2 = Cover15
                CoverClickEvent(gCover2)
            Else
                EnableDisableAll(True)
            End If
        End If
    End Sub

    Private Sub Cover16_Click(sender As Object, e As EventArgs) Handles Cover16.Click
        EnableDisableAll(False)
        If gCount = 0 Then
            gCover1 = Cover16
            gDclick = Cover16.Name
            CoverClickEvent(gCover1)
        Else
            If gDclick <> Cover16.Name Then 'make sure that the same card isn't clicked again
                gCover2 = Cover16
                CoverClickEvent(gCover2)
            Else
                EnableDisableAll(True)
            End If
        End If
    End Sub

    Private Sub Cover17_Click(sender As Object, e As EventArgs) Handles Cover17.Click
        EnableDisableAll(False)
        If gCount = 0 Then
            gCover1 = Cover17
            gDclick = Cover17.Name
            CoverClickEvent(gCover1)
        Else
            If gDclick <> Cover17.Name Then 'make sure that the same card isn't clicked again
                gCover2 = Cover17
                CoverClickEvent(gCover2)
            Else
                EnableDisableAll(True)
            End If
        End If
    End Sub

    Private Sub Cover18_Click(sender As Object, e As EventArgs) Handles Cover18.Click

        EnableDisableAll(False)
        If gCount = 0 Then
            gCover1 = Cover18
            gDclick = Cover18.Name
            BackgroundWorker1.RunWorkerAsync()
            'CoverClickEvent(gCover1)
        Else
            If gDclick <> Cover18.Name Then 'make sure that the same card isn't clicked again
                gCover2 = Cover18
                CoverClickEvent(gCover2)
            End If
        End If
            BackgroundWorker1.CancelAsync()
    End Sub
    Sub CoverClickEvent(fCover As System.Windows.Forms.Button)
        Dim vSound As String
        Dim vPhoto As String
        ' Refresh()
        ' EnableDisableAll(False)
        vPhoto = fCover.Tag  'gets KappB
        fCover.BackColor = Color.Transparent
        fCover.BackgroundImage = My.Resources.ResourceManager.GetObject(vPhoto.Substring(0, 4)) 'image is Kapp
        fCover.BackgroundImageLayout = ImageLayout.Stretch
        fCover.Text = ""
        If gCount = 0 Then
            'WMPlayer.URL = fCover.Text 'gets file that has been stored in this path at LoadForm
            vSound = cSoundPath & fCover.Tag & ".m4a"
            WMPlayer.URL = cSoundPath & fCover.Tag & ".m4a" 'gets file that has been stored in this path at LoadForm
            'Threading.Thread.Sleep(2200)
        End If
        gCount = gCount + 1
        If gCount = 1 Then
            gChoice1 = fCover.Tag  'string like "GagaA" or "KappB"
        End If
        If gCount > 1 Then
            gChoice2 = fCover.Tag
            'Threading.Thread.Sleep(2000)
            MatchCheck()
        End If
        EnableDisableAll(True)
    End Sub
    Public Sub MatchCheck()
        Dim vSec As Integer
        Dim vWinner As String = "Yes"
        If gChoice1.Substring(0, 4) = gChoice2.Substring(0, 4) Then  'string like "GagaA" or "KappB" and the object gCover1 and gcover2 are available
            gCover1.Tag = "match"  'they match
            gCover2.Tag = "match"

            For Each cntrl As Control In Me.Controls
                If TypeOf cntrl Is Button Then
                    If cntrl.Tag <> "inactive" Then  'inactive covers have tag 9
                        If cntrl.Tag <> "match" Then
                            vWinner = "No"
                        End If
                    End If
                End If
            Next

            'If gTEMP = 8 Then
            '    If Cover1.Tag = Str(1) And Cover2.Tag = Str(1) And Cover3.Tag = Str(1) And Cover4.Tag = Str(1) And
            '      Cover5.Tag = Str(1) And Cover6.Tag = Str(1) And Cover7.Tag = Str(1) And Cover8.Tag = Str(1) Then
            '        vWinner = "Yes"
            '    Else
            '        If Cover1.Tag = Str(1) And Cover2.Tag = Str(1) And Cover3.Tag = Str(1) And Cover4.Tag = Str(1) And
            '         Cover5.Tag = Str(1) And Cover6.Tag = Str(1) And Cover7.Tag = Str(1) And Cover8.Tag = Str(1) And
            '          Cover9.Tag = Str(1) And Cover10.Tag = Str(1) And Cover11.Tag = Str(1) And Cover12.Tag = Str(1) Then
            '            vWinner = "Yes"
            '        End If
            '    End If
            'End If 'gTEMP = 8
            If vWinner = "Yes" Then
                vSec = Second(Now())
                Select Case vSec
                    Case 1, 5, 9, 13, 17, 21, 25, 29, 33, 37, 41, 45, 49, 53, 57
                        WMPlayer.URL = ("C:\AJI\GamePhotos\AndTheWinnerIs.m4a")
                    Case 2, 6, 10, 14, 18, 22, 26, 30, 34, 38, 42, 46, 50, 54, 58
                        WMPlayer.URL = ("C:\AJI\GamePhotos\LadiesWeHaveWinner.m4a")
                    Case 3, 7, 11, 15, 19, 23, 27, 31, 35, 39, 43, 47, 51, 55, 59
                        WMPlayer.URL = ("C:\AJI\GamePhotos\ShesAWinner.m4a")
                    Case 4, 8, 12, 16, 20, 24, 28, 32, 36, 40, 44, 48, 52, 56, 0
                        WMPlayer.URL = ("C:\AJI\GamePhotos\LadiesWinner.m4a")
                    Case Else
                        WMPlayer.URL = ("C:\AJI\GamePhotos\LadiesWinner.m4a")
                End Select

                Testing.TextBox1.Text = "The Winner is Stella!"
                Testing.Show()
                Threading.Thread.Sleep(100)
                Testing.TextBox1.Text = "Do You Want to Play Again?"
                Testing.btnYes.Visible = True
                Testing.btnNo.Visible = True
                'StartNewGame()
                Exit Sub
            End If 'vWinner = Yes

            vSec = Second(Now())
                Select Case vSec
                    Case 1, 5, 9, 13, 17, 21, 25, 29, 33, 37, 41, 45, 49, 53, 57
                        WMPlayer.URL = ("C:\AJI\GamePhotos\ThatsAMatch.m4a")
                    Case 2, 6, 10, 14, 18, 22, 26, 30, 34, 38, 42, 46, 50, 54, 58
                        WMPlayer.URL = ("C:\AJI\GamePhotos\YouGotItGirl.m4a")
                    Case 3, 7, 11, 15, 19, 23, 27, 31, 35, 39, 43, 47, 51, 55, 59
                        WMPlayer.URL = ("C:\AJI\GamePhotos\SmartGirl.m4a")
                    Case 4, 8, 12, 16, 20, 24, 28, 32, 36, 40, 44, 48, 52, 56, 0
                        WMPlayer.URL = ("C:\AJI\GamePhotos\YouGotIt.m4a")
                    Case Else
                        WMPlayer.URL = ("C:\AJI\GamePhotos\YouGotItGirl.m4a")
                End Select

                While WMPlayer.playState = WMPLib.WMPPlayState.wmppsTransitioning
                    My.Application.DoEvents()
                End While
                Threading.Thread.Sleep(1500)

            Else  'not a winner
                'Threading.Thread.Sleep(2000)
                vSec = Second(Now())
            Select Case vSec
                Case 1, 5, 9, 13, 17, 21, 25, 29, 33, 37, 41, 45, 49, 53, 57
                    WMPlayer.URL = ("C:\AJI\GamePhotos\VanillaBean.m4a")
                Case 2, 6, 10, 14, 18, 22, 26, 30, 34, 38, 42, 46, 50, 54, 58
                    WMPlayer.URL = ("C:\AJI\GamePhotos\Nope.m4a")
                Case 3, 7, 11, 15, 19, 23, 27, 31, 35, 39, 43, 47, 51, 55, 59
                    WMPlayer.URL = ("C:\AJI\GamePhotos\OneMoreTime.m4a")
                Case 4, 8, 12, 16, 20, 24, 28, 32, 36, 40, 44, 48, 52, 56, 0
                    WMPlayer.URL = ("C:\AJI\GamePhotos\ThatsNotIt.m4a")
                Case Else
                    WMPlayer.URL = ("C:\AJI\GamePhotos\Nope.m4a")
            End Select

            While WMPlayer.playState = WMPLib.WMPPlayState.wmppsTransitioning
                My.Application.DoEvents()
            End While
            Threading.Thread.Sleep(1100)
            'MsgBox("Try Again!")

            gCover1.BackColor = gColor  'puts the "Cover" back on
            gCover1.Text = "S"
            gCover1.BackgroundImage = Nothing

            gCover2.BackColor = gColor
            gCover2.Text = "S"
            gCover2.BackgroundImage = Nothing

        End If
        gCount = 0
        gDclick = "none"
    End Sub
    Sub EnableDisableAll(gEnable As Boolean)




        If gEnable = False Then
            Cover1.Enabled = False
            Cover2.Enabled = False
            Cover3.Enabled = False
            Cover4.Enabled = False
            Cover5.Enabled = False
            Cover6.Enabled = False
            Cover7.Enabled = False
            Cover8.Enabled = False
            Cover9.Enabled = False
            Cover10.Enabled = False
            Cover11.Enabled = False
            Cover12.Enabled = False
            Cover13.Enabled = False
            Cover14.Enabled = False
            Cover15.Enabled = False
            Cover16.Enabled = False
            Cover17.Enabled = False
            Cover18.Enabled = False
            Application.DoEvents()
        End If
        If gEnable = True Then
            Cover1.Enabled = True
            Cover2.Enabled = True
            Cover3.Enabled = True
            Cover4.Enabled = True
            Cover5.Enabled = True
            Cover6.Enabled = True
            Cover7.Enabled = True
            Cover8.Enabled = True
            Cover9.Enabled = True
            Cover10.Enabled = True
            Cover11.Enabled = True
            Cover12.Enabled = True
            Cover13.Enabled = True
            Cover14.Enabled = True
            Cover15.Enabled = True
            Cover16.Enabled = True
            Cover17.Enabled = True
            Cover18.Enabled = True
            Application.DoEvents()
        End If

    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        CoverClickEvent(gCover1)
    End Sub
End Class