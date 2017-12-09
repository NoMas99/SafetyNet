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
        Me.picOldBlue = New System.Windows.Forms.PictureBox()
        Me.picStop = New System.Windows.Forms.PictureBox()
        Me.picDog = New System.Windows.Forms.PictureBox()
        Me.picCat = New System.Windows.Forms.PictureBox()
        Me.picStell = New System.Windows.Forms.PictureBox()
        CType(Me.picOldBlue, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picStop, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picDog, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picCat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picStell, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdOK
        '
        Me.cmdOK.Font = New System.Drawing.Font("Calibri", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdOK.Location = New System.Drawing.Point(50, 526)
        Me.cmdOK.Margin = New System.Windows.Forms.Padding(2)
        Me.cmdOK.Name = "cmdOK"
        Me.cmdOK.Size = New System.Drawing.Size(122, 112)
        Me.cmdOK.TabIndex = 0
        Me.cmdOK.Text = "OK"
        Me.cmdOK.UseVisualStyleBackColor = True
        Me.cmdOK.Visible = False
        '
        'tmrStella
        '
        Me.tmrStella.Interval = 1000
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(367, 585)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(179, 20)
        Me.TextBox1.TabIndex = 4
        Me.TextBox1.Visible = False
        '
        'picOldBlue
        '
        Me.picOldBlue.Image = CType(resources.GetObject("picOldBlue.Image"), System.Drawing.Image)
        Me.picOldBlue.Location = New System.Drawing.Point(660, 102)
        Me.picOldBlue.Name = "picOldBlue"
        Me.picOldBlue.Size = New System.Drawing.Size(179, 221)
        Me.picOldBlue.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picOldBlue.TabIndex = 6
        Me.picOldBlue.TabStop = False
        '
        'picStop
        '
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
        Me.picDog.Image = Global.WindowsApplication1.My.Resources.Resources.PuppyDog
        Me.picDog.Location = New System.Drawing.Point(641, 370)
        Me.picDog.Name = "picDog"
        Me.picDog.Size = New System.Drawing.Size(220, 183)
        Me.picDog.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picDog.TabIndex = 3
        Me.picDog.TabStop = False
        '
        'picCat
        '
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
        Me.picStell.Image = Global.WindowsApplication1.My.Resources.Resources.Stella2
        Me.picStell.Location = New System.Drawing.Point(372, 161)
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
        Me.ClientSize = New System.Drawing.Size(975, 658)
        Me.Controls.Add(Me.picOldBlue)
        Me.Controls.Add(Me.picStop)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.picDog)
        Me.Controls.Add(Me.picCat)
        Me.Controls.Add(Me.picStell)
        Me.Controls.Add(Me.cmdOK)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "MenuSpelling"
        Me.Text = "Spelling Bee"
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
End Class
