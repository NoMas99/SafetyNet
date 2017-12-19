<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuSpelling
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MenuSpelling))
        Me.cmdOK = New System.Windows.Forms.Button()
        Me.tmrStella = New System.Windows.Forms.Timer(Me.components)
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.tb1 = New System.Windows.Forms.TextBox()
        Me.tb2 = New System.Windows.Forms.TextBox()
        Me.tb3 = New System.Windows.Forms.TextBox()
        Me.tb4 = New System.Windows.Forms.TextBox()
        Me.tb5 = New System.Windows.Forms.TextBox()
        Me.tb6 = New System.Windows.Forms.TextBox()
        Me.TextBox9 = New System.Windows.Forms.TextBox()
        Me.TextBox10 = New System.Windows.Forms.TextBox()
        Me.TextBox11 = New System.Windows.Forms.TextBox()
        Me.TextBox12 = New System.Windows.Forms.TextBox()
        Me.pb1 = New System.Windows.Forms.TextBox()
        Me.pb2 = New System.Windows.Forms.TextBox()
        Me.pb3 = New System.Windows.Forms.TextBox()
        Me.pb4 = New System.Windows.Forms.TextBox()
        Me.pb5 = New System.Windows.Forms.TextBox()
        Me.pb6 = New System.Windows.Forms.TextBox()
        Me.TextBox19 = New System.Windows.Forms.TextBox()
        Me.TextBox20 = New System.Windows.Forms.TextBox()
        Me.TextBox21 = New System.Windows.Forms.TextBox()
        Me.TextBox22 = New System.Windows.Forms.TextBox()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.OvalShape1 = New Microsoft.VisualBasic.PowerPacks.OvalShape()
        Me.picBanana = New System.Windows.Forms.PictureBox()
        Me.picOldBlue = New System.Windows.Forms.PictureBox()
        Me.picStop = New System.Windows.Forms.PictureBox()
        Me.picDog = New System.Windows.Forms.PictureBox()
        Me.picCat = New System.Windows.Forms.PictureBox()
        Me.picStell = New System.Windows.Forms.PictureBox()
        CType(Me.picBanana, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picOldBlue, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picStop, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picDog, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picCat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picStell, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdOK
        '
        Me.cmdOK.BackColor = System.Drawing.Color.Purple
        Me.cmdOK.Font = New System.Drawing.Font("Calibri", 60.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdOK.Location = New System.Drawing.Point(870, 634)
        Me.cmdOK.Margin = New System.Windows.Forms.Padding(2)
        Me.cmdOK.Name = "cmdOK"
        Me.cmdOK.Size = New System.Drawing.Size(122, 112)
        Me.cmdOK.TabIndex = 0
        Me.cmdOK.Text = "X"
        Me.cmdOK.UseVisualStyleBackColor = False
        '
        'tmrStella
        '
        Me.tmrStella.Interval = 1000
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(100, 606)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(179, 20)
        Me.TextBox1.TabIndex = 4
        Me.TextBox1.Visible = False
        '
        'ProgressBar1
        '
        Me.ProgressBar1.ForeColor = System.Drawing.Color.Red
        Me.ProgressBar1.Location = New System.Drawing.Point(100, 12)
        Me.ProgressBar1.Maximum = 10
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(761, 53)
        Me.ProgressBar1.Step = 1
        Me.ProgressBar1.TabIndex = 7
        Me.ProgressBar1.Visible = False
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(632, 594)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(179, 20)
        Me.TextBox2.TabIndex = 8
        Me.TextBox2.Visible = False
        '
        'tb1
        '
        Me.tb1.BackColor = System.Drawing.Color.Violet
        Me.tb1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tb1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb1.Location = New System.Drawing.Point(1058, 707)
        Me.tb1.Name = "tb1"
        Me.tb1.Size = New System.Drawing.Size(24, 24)
        Me.tb1.TabIndex = 9
        Me.tb1.Tag = "Off"
        Me.tb1.Text = "1"
        Me.tb1.Visible = False
        '
        'tb2
        '
        Me.tb2.BackColor = System.Drawing.Color.Fuchsia
        Me.tb2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tb2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb2.Location = New System.Drawing.Point(1058, 594)
        Me.tb2.Name = "tb2"
        Me.tb2.Size = New System.Drawing.Size(24, 24)
        Me.tb2.TabIndex = 10
        Me.tb2.Tag = "Off"
        Me.tb2.Text = "2"
        Me.tb2.Visible = False
        '
        'tb3
        '
        Me.tb3.BackColor = System.Drawing.Color.DarkViolet
        Me.tb3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tb3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb3.Location = New System.Drawing.Point(1058, 490)
        Me.tb3.Name = "tb3"
        Me.tb3.Size = New System.Drawing.Size(24, 24)
        Me.tb3.TabIndex = 11
        Me.tb3.Tag = "Off"
        Me.tb3.Text = "3"
        Me.tb3.Visible = False
        '
        'tb4
        '
        Me.tb4.BackColor = System.Drawing.Color.DarkMagenta
        Me.tb4.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tb4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb4.Location = New System.Drawing.Point(1058, 385)
        Me.tb4.Name = "tb4"
        Me.tb4.Size = New System.Drawing.Size(24, 24)
        Me.tb4.TabIndex = 12
        Me.tb4.Tag = "Off"
        Me.tb4.Text = "4"
        Me.tb4.Visible = False
        '
        'tb5
        '
        Me.tb5.BackColor = System.Drawing.Color.Fuchsia
        Me.tb5.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tb5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb5.Location = New System.Drawing.Point(1058, 276)
        Me.tb5.Name = "tb5"
        Me.tb5.Size = New System.Drawing.Size(24, 24)
        Me.tb5.TabIndex = 13
        Me.tb5.Tag = "Off"
        Me.tb5.Text = "5"
        Me.tb5.Visible = False
        '
        'tb6
        '
        Me.tb6.BackColor = System.Drawing.Color.Orange
        Me.tb6.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tb6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb6.Location = New System.Drawing.Point(1058, 168)
        Me.tb6.Name = "tb6"
        Me.tb6.Size = New System.Drawing.Size(24, 24)
        Me.tb6.TabIndex = 14
        Me.tb6.Tag = "Off"
        Me.tb6.Text = "6"
        Me.tb6.Visible = False
        '
        'TextBox9
        '
        Me.TextBox9.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextBox9.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox9.Location = New System.Drawing.Point(939, 71)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New System.Drawing.Size(24, 16)
        Me.TextBox9.TabIndex = 15
        Me.TextBox9.Text = "7"
        Me.TextBox9.Visible = False
        '
        'TextBox10
        '
        Me.TextBox10.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextBox10.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox10.Location = New System.Drawing.Point(969, 72)
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Size = New System.Drawing.Size(24, 16)
        Me.TextBox10.TabIndex = 16
        Me.TextBox10.Text = "8"
        Me.TextBox10.Visible = False
        '
        'TextBox11
        '
        Me.TextBox11.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextBox11.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox11.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox11.Location = New System.Drawing.Point(989, 71)
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Size = New System.Drawing.Size(24, 16)
        Me.TextBox11.TabIndex = 17
        Me.TextBox11.Text = "9"
        Me.TextBox11.Visible = False
        '
        'TextBox12
        '
        Me.TextBox12.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextBox12.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox12.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox12.Location = New System.Drawing.Point(1003, 63)
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.Size = New System.Drawing.Size(36, 24)
        Me.TextBox12.TabIndex = 18
        Me.TextBox12.Text = "10"
        Me.TextBox12.Visible = False
        '
        'pb1
        '
        Me.pb1.BackColor = System.Drawing.Color.Violet
        Me.pb1.Location = New System.Drawing.Point(1033, 664)
        Me.pb1.Multiline = True
        Me.pb1.Name = "pb1"
        Me.pb1.Size = New System.Drawing.Size(61, 115)
        Me.pb1.TabIndex = 19
        Me.pb1.Tag = "Off"
        Me.pb1.Visible = False
        '
        'pb2
        '
        Me.pb2.BackColor = System.Drawing.Color.Fuchsia
        Me.pb2.Location = New System.Drawing.Point(1033, 552)
        Me.pb2.Multiline = True
        Me.pb2.Name = "pb2"
        Me.pb2.Size = New System.Drawing.Size(61, 115)
        Me.pb2.TabIndex = 20
        Me.pb2.Tag = "Off"
        Me.pb2.Visible = False
        '
        'pb3
        '
        Me.pb3.BackColor = System.Drawing.Color.DarkViolet
        Me.pb3.Location = New System.Drawing.Point(1033, 438)
        Me.pb3.Multiline = True
        Me.pb3.Name = "pb3"
        Me.pb3.Size = New System.Drawing.Size(61, 115)
        Me.pb3.TabIndex = 21
        Me.pb3.Tag = "Off"
        Me.pb3.Visible = False
        '
        'pb4
        '
        Me.pb4.BackColor = System.Drawing.Color.DarkMagenta
        Me.pb4.Location = New System.Drawing.Point(1033, 338)
        Me.pb4.Multiline = True
        Me.pb4.Name = "pb4"
        Me.pb4.Size = New System.Drawing.Size(61, 115)
        Me.pb4.TabIndex = 22
        Me.pb4.Tag = "Off"
        Me.pb4.Visible = False
        '
        'pb5
        '
        Me.pb5.BackColor = System.Drawing.Color.Fuchsia
        Me.pb5.Location = New System.Drawing.Point(1033, 228)
        Me.pb5.Multiline = True
        Me.pb5.Name = "pb5"
        Me.pb5.Size = New System.Drawing.Size(61, 115)
        Me.pb5.TabIndex = 23
        Me.pb5.Tag = "Off"
        Me.pb5.Visible = False
        '
        'pb6
        '
        Me.pb6.BackColor = System.Drawing.Color.Orange
        Me.pb6.Location = New System.Drawing.Point(1033, 118)
        Me.pb6.Multiline = True
        Me.pb6.Name = "pb6"
        Me.pb6.Size = New System.Drawing.Size(61, 115)
        Me.pb6.TabIndex = 24
        Me.pb6.Tag = "Off"
        Me.pb6.Visible = False
        '
        'TextBox19
        '
        Me.TextBox19.BackColor = System.Drawing.Color.Orange
        Me.TextBox19.Location = New System.Drawing.Point(841, 13)
        Me.TextBox19.Multiline = True
        Me.TextBox19.Name = "TextBox19"
        Me.TextBox19.Size = New System.Drawing.Size(79, 52)
        Me.TextBox19.TabIndex = 25
        Me.TextBox19.Tag = "Off"
        Me.TextBox19.Visible = False
        '
        'TextBox20
        '
        Me.TextBox20.BackColor = System.Drawing.Color.Orange
        Me.TextBox20.Location = New System.Drawing.Point(913, 13)
        Me.TextBox20.Multiline = True
        Me.TextBox20.Name = "TextBox20"
        Me.TextBox20.Size = New System.Drawing.Size(79, 52)
        Me.TextBox20.TabIndex = 26
        Me.TextBox20.Tag = "Off"
        Me.TextBox20.Visible = False
        '
        'TextBox21
        '
        Me.TextBox21.BackColor = System.Drawing.Color.Orange
        Me.TextBox21.Location = New System.Drawing.Point(989, 13)
        Me.TextBox21.Multiline = True
        Me.TextBox21.Name = "TextBox21"
        Me.TextBox21.Size = New System.Drawing.Size(79, 52)
        Me.TextBox21.TabIndex = 27
        Me.TextBox21.Tag = "Off"
        Me.TextBox21.Visible = False
        '
        'TextBox22
        '
        Me.TextBox22.BackColor = System.Drawing.Color.Red
        Me.TextBox22.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox22.Location = New System.Drawing.Point(884, 93)
        Me.TextBox22.Multiline = True
        Me.TextBox22.Name = "TextBox22"
        Me.TextBox22.Size = New System.Drawing.Size(79, 52)
        Me.TextBox22.TabIndex = 28
        Me.TextBox22.Tag = "Off"
        Me.TextBox22.Visible = False
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.OvalShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(1094, 779)
        Me.ShapeContainer1.TabIndex = 29
        Me.ShapeContainer1.TabStop = False
        '
        'OvalShape1
        '
        Me.OvalShape1.BackColor = System.Drawing.Color.Orange
        Me.OvalShape1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.OvalShape1.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.OvalShape1.Location = New System.Drawing.Point(1033, 72)
        Me.OvalShape1.Name = "OvalShape1"
        Me.OvalShape1.Size = New System.Drawing.Size(61, 146)
        Me.OvalShape1.Visible = False
        '
        'picBanana
        '
        Me.picBanana.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picBanana.Image = Global.WindowsApplication1.My.Resources.Resources.Banana
        Me.picBanana.Location = New System.Drawing.Point(460, 118)
        Me.picBanana.Name = "picBanana"
        Me.picBanana.Size = New System.Drawing.Size(86, 217)
        Me.picBanana.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBanana.TabIndex = 30
        Me.picBanana.TabStop = False
        '
        'picOldBlue
        '
        Me.picOldBlue.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picOldBlue.Image = CType(resources.GetObject("picOldBlue.Image"), System.Drawing.Image)
        Me.picOldBlue.Location = New System.Drawing.Point(699, 102)
        Me.picOldBlue.Name = "picOldBlue"
        Me.picOldBlue.Size = New System.Drawing.Size(179, 221)
        Me.picOldBlue.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picOldBlue.TabIndex = 6
        Me.picOldBlue.TabStop = False
        '
        'picStop
        '
        Me.picStop.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picStop.Image = Global.WindowsApplication1.My.Resources.Resources.StopSign
        Me.picStop.Location = New System.Drawing.Point(100, 338)
        Me.picStop.Name = "picStop"
        Me.picStop.Size = New System.Drawing.Size(220, 215)
        Me.picStop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picStop.TabIndex = 5
        Me.picStop.TabStop = False
        '
        'picDog
        '
        Me.picDog.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picDog.Image = Global.WindowsApplication1.My.Resources.Resources.PuppyDog
        Me.picDog.Location = New System.Drawing.Point(673, 370)
        Me.picDog.Name = "picDog"
        Me.picDog.Size = New System.Drawing.Size(220, 183)
        Me.picDog.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picDog.TabIndex = 3
        Me.picDog.TabStop = False
        '
        'picCat
        '
        Me.picCat.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picCat.Image = Global.WindowsApplication1.My.Resources.Resources.TabbyCat2
        Me.picCat.Location = New System.Drawing.Point(100, 102)
        Me.picCat.Name = "picCat"
        Me.picCat.Size = New System.Drawing.Size(221, 167)
        Me.picCat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picCat.TabIndex = 2
        Me.picCat.TabStop = False
        '
        'picStell
        '
        Me.picStell.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picStell.Image = Global.WindowsApplication1.My.Resources.Resources.Stella2
        Me.picStell.Location = New System.Drawing.Point(380, 403)
        Me.picStell.Name = "picStell"
        Me.picStell.Size = New System.Drawing.Size(221, 299)
        Me.picStell.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picStell.TabIndex = 1
        Me.picStell.TabStop = False
        '
        'MenuSpelling
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1094, 779)
        Me.Controls.Add(Me.picBanana)
        Me.Controls.Add(Me.TextBox22)
        Me.Controls.Add(Me.TextBox21)
        Me.Controls.Add(Me.TextBox20)
        Me.Controls.Add(Me.TextBox19)
        Me.Controls.Add(Me.TextBox12)
        Me.Controls.Add(Me.TextBox11)
        Me.Controls.Add(Me.TextBox10)
        Me.Controls.Add(Me.TextBox9)
        Me.Controls.Add(Me.tb6)
        Me.Controls.Add(Me.tb5)
        Me.Controls.Add(Me.tb4)
        Me.Controls.Add(Me.tb3)
        Me.Controls.Add(Me.tb2)
        Me.Controls.Add(Me.tb1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.picOldBlue)
        Me.Controls.Add(Me.picStop)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.picDog)
        Me.Controls.Add(Me.picCat)
        Me.Controls.Add(Me.picStell)
        Me.Controls.Add(Me.cmdOK)
        Me.Controls.Add(Me.pb6)
        Me.Controls.Add(Me.pb5)
        Me.Controls.Add(Me.pb4)
        Me.Controls.Add(Me.pb3)
        Me.Controls.Add(Me.pb2)
        Me.Controls.Add(Me.pb1)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "MenuSpelling"
        Me.Text = "Spelling Bee"
        CType(Me.picBanana, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picOldBlue, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picStop, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picDog, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picCat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picStell, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmdOK As Button
    Friend WithEvents picStell As PictureBox
    Friend WithEvents tmrStella As Timer
    Friend WithEvents picCat As PictureBox
    Friend WithEvents picDog As PictureBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents picStop As PictureBox
    Friend WithEvents picOldBlue As PictureBox
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents tb1 As TextBox
    Friend WithEvents tb2 As TextBox
    Friend WithEvents tb3 As TextBox
    Friend WithEvents tb4 As TextBox
    Friend WithEvents tb5 As TextBox
    Friend WithEvents tb6 As TextBox
    Friend WithEvents TextBox9 As TextBox
    Friend WithEvents TextBox10 As TextBox
    Friend WithEvents TextBox11 As TextBox
    Friend WithEvents TextBox12 As TextBox
    Friend WithEvents pb1 As TextBox
    Friend WithEvents pb2 As TextBox
    Friend WithEvents pb3 As TextBox
    Friend WithEvents pb4 As TextBox
    Friend WithEvents pb5 As TextBox
    Friend WithEvents pb6 As TextBox
    Friend WithEvents TextBox19 As TextBox
    Friend WithEvents TextBox20 As TextBox
    Friend WithEvents TextBox21 As TextBox
    Friend WithEvents TextBox22 As TextBox
    Friend WithEvents ShapeContainer1 As PowerPacks.ShapeContainer
    Friend WithEvents OvalShape1 As PowerPacks.OvalShape
    Friend WithEvents picBanana As PictureBox
End Class
