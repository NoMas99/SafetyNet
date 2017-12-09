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
        Me.picCat = New System.Windows.Forms.PictureBox()
        Me.picStell = New System.Windows.Forms.PictureBox()
        Me.picDog = New System.Windows.Forms.PictureBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        CType(Me.picCat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picStell, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picDog, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdOK
        '
        Me.cmdOK.Font = New System.Drawing.Font("Calibri", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdOK.Location = New System.Drawing.Point(40, 76)
        Me.cmdOK.Margin = New System.Windows.Forms.Padding(2)
        Me.cmdOK.Name = "cmdOK"
        Me.cmdOK.Size = New System.Drawing.Size(122, 112)
        Me.cmdOK.TabIndex = 0
        Me.cmdOK.Text = "OK"
        Me.cmdOK.UseVisualStyleBackColor = True
        '
        'tmrStella
        '
        Me.tmrStella.Interval = 1000
        '
        'picCat
        '
        Me.picCat.Image = CType(resources.GetObject("picCat.Image"), System.Drawing.Image)
        Me.picCat.Location = New System.Drawing.Point(499, 34)
        Me.picCat.Name = "picCat"
        Me.picCat.Size = New System.Drawing.Size(221, 167)
        Me.picCat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picCat.TabIndex = 2
        Me.picCat.TabStop = False
        '
        'picStell
        '
        Me.picStell.Image = Global.WindowsApplication1.My.Resources.Resources.Stel
        Me.picStell.Location = New System.Drawing.Point(238, 34)
        Me.picStell.Name = "picStell"
        Me.picStell.Size = New System.Drawing.Size(221, 264)
        Me.picStell.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picStell.TabIndex = 1
        Me.picStell.TabStop = False
        '
        'picDog
        '
        Me.picDog.Image = CType(resources.GetObject("picDog.Image"), System.Drawing.Image)
        Me.picDog.Location = New System.Drawing.Point(499, 229)
        Me.picDog.Name = "picDog"
        Me.picDog.Size = New System.Drawing.Size(277, 183)
        Me.picDog.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picDog.TabIndex = 3
        Me.picDog.TabStop = False
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(329, 477)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(179, 20)
        Me.TextBox1.TabIndex = 4
        Me.TextBox1.Visible = False
        '
        'MenuSpelling
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1100, 578)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.picDog)
        Me.Controls.Add(Me.picCat)
        Me.Controls.Add(Me.picStell)
        Me.Controls.Add(Me.cmdOK)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "MenuSpelling"
        Me.Text = "Stella Title"
        CType(Me.picCat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picStell, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picDog, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmdOK As Button
    Friend WithEvents picStell As PictureBox
    Friend WithEvents tmrStella As Timer
    Friend WithEvents picCat As PictureBox
    Friend WithEvents picDog As PictureBox
    Friend WithEvents TextBox1 As TextBox
End Class
