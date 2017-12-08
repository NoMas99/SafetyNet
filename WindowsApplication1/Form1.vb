Public Class Form1
    Dim gCount As Integer = 0
    Dim gNope As Integer = 0
    Dim gWinner As Integer = 0
    Dim gChoice1 As String
    Dim gChoice2 As String
    Dim gCover1 As System.Windows.Forms.Button
    Dim gCover2 As System.Windows.Forms.Button
    Dim arrSuspects As New List(Of String)
    Const cSoundPath As String = "C:\AJI\GamePhotos\"
    Dim vCood As New List(Of Integer)
    Public dick As New Dictionary(Of String, String)
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Hide()
        DylanForm.Show()
        ' StartNewGame()
    End Sub
    Public Sub StartNewGame()
        Dim vSec As Integer
        gCount = 0  'reset variables
        gChoice1 = Nothing
        gChoice2 = Nothing
        gCover1 = Nothing
        gCover2 = Nothing

        Dim vColor As Color      'change the Cover colors, set Tags to 0, set Text to non-Path
        vSec = Second(Now())
        Select Case vSec
            Case 1, 5, 9, 13, 17, 21, 25, 29, 33, 37, 41, 45, 49, 53, 57
                vColor = Color.Yellow
            Case 2, 6, 10, 14, 18, 22, 26, 30, 34, 38, 42, 46, 50, 54, 58
                vColor = Color.HotPink
            Case 3, 7, 11, 15, 19, 23, 27, 31, 35, 39, 43, 47, 51, 55, 59
                vColor = Color.SeaGreen
            Case 4, 8, 12, 16, 20, 24, 28, 32, 36, 40, 44, 48, 52, 56, 0
                vColor = Color.Chocolate
            Case Else
                vColor = Color.Chocolate
        End Select

        For Each cntrl As Control In Me.Controls
            If TypeOf cntrl Is Button Then
                cntrl.BackColor = vColor
                cntrl.Visible = True
                cntrl.Tag = 0
                ' cntrl.Text = "S"
            End If
        Next

        Dim vRandom As New Random
        Dim vPhotoChoice As String

        Dim vLocationLetter As String
        Dim vLocationLetter2 As String

        arrSuspects = New List(Of String) From {"Grammy", "Kappy", "Gaga", "Meghan", "Dylan",
            "Shane", "Jennings", "Henry", "Augie", "Stocking", "Santa", "AUnicorn", "BUnicorn", "Casey",
            "Anthony", "ToyBear", "Stella", "BabyStella"}

        ' ******Photo1A&B

        Dim vGetPhoto = vRandom.Next(18)
        vPhotoChoice = arrSuspects(vGetPhoto) 'puts the current choice from the list into a string variable
        arrSuspects.RemoveAt(vGetPhoto) 'removes vChoice1 from the name list
        Dim vList = New List(Of String) From {"a", "b", "c", "d", "e", "f", "g", "h"}
        Dim vLocationChoice = vRandom.Next(8)
        vLocationLetter = vList(vLocationChoice)
        vList.RemoveAt(vLocationChoice)
        Dim vLocationChoice2 = vRandom.Next(7) 'one less
        vLocationLetter2 = vList(vLocationChoice2)
        vList.RemoveAt(vLocationChoice2)
        CreateNewButton(vLocationLetter, vLocationLetter2, vPhotoChoice)


        ' ******Photo2A&B
        vGetPhoto = vRandom.Next(17)
        vPhotoChoice = arrSuspects(vGetPhoto) 'puts the current choice from the list into a string variable
        arrSuspects.RemoveAt(vGetPhoto) 'removes vChoice1 from the name list
        vLocationChoice = vRandom.Next(6)
        vLocationLetter = vList(vLocationChoice)
        vList.RemoveAt(vLocationChoice)
        vLocationChoice2 = vRandom.Next(5) 'one less
        vLocationLetter2 = vList(vLocationChoice2)
        vList.RemoveAt(vLocationChoice2)
        CreateNewButton(vLocationLetter, vLocationLetter2, vPhotoChoice)

        ' ******Photo3A&B
        vGetPhoto = vRandom.Next(16)
        vPhotoChoice = arrSuspects(vGetPhoto) 'puts the current choice from the list into a string variable
        arrSuspects.RemoveAt(vGetPhoto) 'removes vChoice1 from the name list
        vLocationChoice = vRandom.Next(4)
        vLocationLetter = vList(vLocationChoice)
        vList.RemoveAt(vLocationChoice)
        vLocationChoice2 = vRandom.Next(3) 'one less
        vLocationLetter2 = vList(vLocationChoice2)
        vList.RemoveAt(vLocationChoice2)
        CreateNewButton(vLocationLetter, vLocationLetter2, vPhotoChoice)

        ' ******Photo4A&B
        vGetPhoto = vRandom.Next(15)
        vPhotoChoice = arrSuspects(vGetPhoto) 'puts the current choice from the list into a string variable
        arrSuspects.RemoveAt(vGetPhoto) 'removes vChoice1 from the name list
        vLocationChoice = vRandom.Next(2)
        vLocationLetter = vList(vLocationChoice)
        vList.RemoveAt(vLocationChoice)
        vLocationChoice2 = vRandom.Next(1) 'one less
        vLocationLetter2 = vList(vLocationChoice2)
        vList.RemoveAt(vLocationChoice2)
        CreateNewButton(vLocationLetter, vLocationLetter2, vPhotoChoice)

    End Sub
    Public Function CreateNewButton(fNextCoor As String, fNextCoor2 As String, fPhotoName As String) As String()
        Dim newButton As Button
        Dim newButton2 As Button
        Dim vWhatCover As String
        Dim vRanNum As Integer
        Const cSoundPath As String = "C:\AJI\GamePhotos\"

        newButton = New Button
        newButton.Size = New Drawing.Size(270, 344)  'standard button size
        newButton.Name = fPhotoName & "A"  'names like "GrammyA" and next will be "GrammyB"
        newButton.BackgroundImage = My.Resources.ResourceManager.GetObject(fPhotoName) 'gets the JPG file "Grammy"
        newButton.BackgroundImageLayout = ImageLayout.Stretch  'and stretches her
        vRanNum = GetRN(fNextCoor) 'calls the function that converts the letter to an integer
        GetXY(vRanNum) 'calls the function that gets the X and Y coordinates for the random integer
        newButton.Location = New Point(vCood(0), vCood(1))
        vWhatCover = WhatCover(vCood(0), vCood(1))  'uses this function to find the name of the Cover button at the X,Y
        For Each cb As Button In Me.Controls.OfType(Of Button)()  'then assign the Photoname to the tag
            If cb.Name.Contains(vWhatCover) Then
                cb.Tag = fPhotoName.Substring(0, 4) & "A"
                Exit For
            End If
        Next
        newButton.Tag = fPhotoName.Substring(0, 4) & "A" '"Cover" & Trim(Str(vRanNum))
        'newButton.Text = cSoundPath & fPhotoName.Substring(0, 4) & "A" & ".m4a"  'uses the text of the button to hook the correct sound file
        Me.Controls.Add(newButton)
        newButton.Visible = True
        newButton.SendToBack()  'sends her to the back because the a Cover is already occupying the location

        ' *****************PhotoB
        newButton2 = New Button  'now creates another Button, "GrammyB"
        newButton2.Size = New Drawing.Size(270, 344)

        newButton2.Name = fPhotoName & "B"
        newButton2.BackgroundImage = My.Resources.ResourceManager.GetObject(fPhotoName) 'same image
        newButton2.BackgroundImageLayout = ImageLayout.Stretch  'and stretches her, again
        vRanNum = GetRN(fNextCoor2)
        GetXY(vRanNum)
        newButton2.Location = New Point(vCood(0), vCood(1))
        vWhatCover = WhatCover(vCood(0), vCood(1))  'uses this function to find the name of the Cover button at the X,Y
        For Each cb As Button In Me.Controls.OfType(Of Button)()  'then assign the Photoname to the tag
            If cb.Name.Contains(vWhatCover) Then
                cb.Tag = fPhotoName.Substring(0, 4) & "B"
                Exit For
            End If
        Next
        newButton.Tag = fPhotoName & "B" '"Cover" & Trim(Str(vRanNum))
        'newButton.Text = cSoundPath & fPhotoName & "B" & ".m4a"  'uses the text of the button to hook the correct sound file
        newButton2.SendToBack()
        Me.Controls.Add(newButton2)
        newButton2.Visible = True
        Return New String() {"Cover" & Trim(Str(vRanNum)), "cat"}
    End Function
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
            Case Else
                GetRN = 1
        End Select
    End Function
    Public Function GetXY(fNum As Integer) As List(Of Integer)
        'Dim vCood As New List(Of Integer)
        vCood.Clear()

        Select Case fNum
            Case 1
                vCood.Add(0)
                vCood.Add(0)
            Case 2
                vCood.Add(276)
                vCood.Add(0)
            Case 3
                vCood.Add(552)
                vCood.Add(0)
            Case 4
                vCood.Add(828)
                vCood.Add(0)
            Case 5
                vCood.Add(0)
                vCood.Add(350)
            Case 6
                vCood.Add(276)
                vCood.Add(350)
            Case 7
                vCood.Add(552)
                vCood.Add(350)
            Case 8
                vCood.Add(828)
                vCood.Add(350)
            Case Else
                vCood.Add(0)
                vCood.Add(0)
        End Select
        Return vCood
    End Function


    Private Sub Cover1_Click(sender As Object, e As EventArgs) Handles Cover1.Click
        If gCount = 0 Then
            gCover1 = Cover1
            CoverClickEvent(gCover1)
        Else
            gCover2 = Cover1
            CoverClickEvent(gCover2)
        End If
    End Sub

    Private Sub Cover2_Click(sender As Object, e As EventArgs) Handles Cover2.Click
        If gCount = 0 Then
            gCover1 = Cover2
            CoverClickEvent(gCover1)
        Else
            gCover2 = Cover2
            CoverClickEvent(gCover2)
        End If
    End Sub
    Private Sub Cover3_Click(sender As Object, e As EventArgs) Handles Cover3.Click
        If gCount = 0 Then
            gCover1 = Cover3
            CoverClickEvent(gCover1)
        Else
            gCover2 = Cover3
            CoverClickEvent(gCover2)
        End If
    End Sub

    Private Sub Cover4_Click(sender As Object, e As EventArgs) Handles Cover4.Click
        If gCount = 0 Then
            gCover1 = Cover4
            CoverClickEvent(gCover1)
        Else
            gCover2 = Cover4
            CoverClickEvent(gCover2)
        End If
    End Sub

    Private Sub Cover5_Click(sender As Object, e As EventArgs) Handles Cover5.Click
        If gCount = 0 Then
            gCover1 = Cover5
            CoverClickEvent(gCover1)
        Else
            gCover2 = Cover5
            CoverClickEvent(gCover2)
        End If
    End Sub

    Private Sub Cover6_Click(sender As Object, e As EventArgs) Handles Cover6.Click
        If gCount = 0 Then
            gCover1 = Cover6
            CoverClickEvent(gCover1)
        Else
            gCover2 = Cover6
            CoverClickEvent(gCover2)
        End If

    End Sub

    Private Sub Cover7_Click(sender As Object, e As EventArgs) Handles Cover7.Click
        If gCount = 0 Then
            gCover1 = Cover7
            CoverClickEvent(gCover1)
        Else
            gCover2 = Cover7
            CoverClickEvent(gCover2)
        End If

    End Sub

    Private Sub Cover8_Click(sender As Object, e As EventArgs) Handles Cover8.Click
        If gCount = 0 Then
            gCover1 = Cover8
            CoverClickEvent(gCover1)
        Else
            gCover2 = Cover8
            CoverClickEvent(gCover2)
        End If

    End Sub
    Sub CoverClickEvent(fCover As System.Windows.Forms.Button)
        Dim vSound As String
        fCover.Visible = False
        If gCount = 0 Then
            'WMPlayer.URL = fCover.Text 'gets file that has been stored in this path at LoadForm
            vSound = cSoundPath & fCover.Tag & ".m4a"
            WMPlayer.URL = cSoundPath & fCover.Tag & ".m4a" 'gets file that has been stored in this path at LoadForm
            'Threading.Thread.Sleep(2200)
        End If
        gCount = gCount + 1
        If gCount = 1 Then
            gChoice1 = fCover.Tag  'string like "GagaA" or "KappB"
            gChoice2 = "waiting"
        End If
        If gCount > 1 Then
            gChoice2 = fCover.Tag
            'Threading.Thread.Sleep(2000)
            MatchCheck()
        End If

    End Sub
    Public Sub MatchCheck()
        Dim vSec As Integer
        If gChoice1.Substring(0, 4) = gChoice2.Substring(0, 4) Then  'string like "GagaA" or "KappB" and the object gCover1 and gcover2 are available
            gCover1.Tag = 1
            gCover2.Tag = 1


            If Cover1.Tag = Str(1) And Cover2.Tag = Str(1) And Cover3.Tag = Str(1) And Cover4.Tag = Str(1) And
        Cover5.Tag = Str(1) And Cover6.Tag = Str(1) And Cover7.Tag = Str(1) And Cover8.Tag = Str(1) Then
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
            End If
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

        Else
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



            If gNope = 0 Then
                WMPlayer.URL = ("C:\AJI\GamePhotos\VanillaBean.m4a")
                gNope = 1
            Else
                WMPlayer.URL = ("C:\AJI\GamePhotos\Nope.m4a")
                gNope = 0
            End If
            While WMPlayer.playState = WMPLib.WMPPlayState.wmppsTransitioning
                My.Application.DoEvents()
            End While
            Threading.Thread.Sleep(1100)
            'MsgBox("Try Again!")


            For Each btn As Control In Controls
                If TypeOf btn Is Button And btn.Tag <> Str(1) Then
                    btn.Visible = True
                End If
            Next
        End If
        gCount = 0
    End Sub


    Function WhatCover(fX As Integer, fY As Integer) As String
        If fY = 0 Then
            Select Case fX
                Case 0
                    Return "Cover1"
                Case 276
                    Return "Cover2"
                Case 552
                    Return "Cover3"
                Case 828
                    Return "Cover4"
                Case Else
                    Return "Error"
            End Select
        Else
            Select Case fX
                Case 0
                    Return "Cover5"
                Case 276
                    Return "Cover6"
                Case 552
                    Return "Cover7"
                Case 828
                    Return "Cover8"
                Case Else
                    Return "Error"
            End Select
        End If



    End Function

    Private Sub ButtOne_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim newButton As Button
        'Dim newButton2 As Button
        'Dim vWhatCover As String
        'Dim vRanNum As Integer
        'Const cSoundPath As String = "C:\AJI\GamePhotos\"

        newButton = New Button
        newButton.Size = New Drawing.Size(270, 344)  'standard button size
        newButton.Name = "SampleA"
        newButton.BackColor = Color.AliceBlue
        newButton.Location = New Point(150, 150)
        Me.Controls.Add(newButton)

        ' newButton.BackgroundImage = My.Resources.ResourceManager.GetObject(fPhotoName) 'gets the JPG file "Grammy"
        'newButton.BackgroundImageLayout = ImageLayout.Stretch  'and stretches her
    End Sub

    Private Sub Allen1_click(sender As Object, e As EventArgs) Handles Allen1.Click
        If Allen1.BackColor = Color.Transparent Then
            Allen1.BackColor = Color.Yellow
            Allen1.Text = "S"
            Allen1.BackgroundImage = Nothing

        Else
            Allen1.BackColor = Color.Transparent
            Allen1.BackgroundImage = My.Resources.ResourceManager.GetObject("Kappy")
            Allen1.BackgroundImageLayout = ImageLayout.Stretch
            Allen1.Text = ""
        End If
    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork

    End Sub
End Class
