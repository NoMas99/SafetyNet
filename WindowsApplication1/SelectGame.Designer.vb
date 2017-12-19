<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SelectGame
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
        Me.EasyGame = New System.Windows.Forms.TextBox()
        Me.HardGame = New System.Windows.Forms.TextBox()
        Me.MediumGame = New System.Windows.Forms.TextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'EasyGame
        '
        Me.EasyGame.BackColor = System.Drawing.Color.LimeGreen
        Me.EasyGame.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.EasyGame.Font = New System.Drawing.Font("Calibri", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EasyGame.Location = New System.Drawing.Point(47, 24)
        Me.EasyGame.Margin = New System.Windows.Forms.Padding(2)
        Me.EasyGame.Multiline = True
        Me.EasyGame.Name = "EasyGame"
        Me.EasyGame.Size = New System.Drawing.Size(202, 79)
        Me.EasyGame.TabIndex = 3
        Me.EasyGame.TabStop = False
        Me.EasyGame.Text = "Easy Level"
        Me.EasyGame.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'HardGame
        '
        Me.HardGame.BackColor = System.Drawing.Color.Crimson
        Me.HardGame.Cursor = System.Windows.Forms.Cursors.Default
        Me.HardGame.Font = New System.Drawing.Font("Calibri", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HardGame.Location = New System.Drawing.Point(47, 223)
        Me.HardGame.Margin = New System.Windows.Forms.Padding(2)
        Me.HardGame.Multiline = True
        Me.HardGame.Name = "HardGame"
        Me.HardGame.Size = New System.Drawing.Size(202, 82)
        Me.HardGame.TabIndex = 4
        Me.HardGame.TabStop = False
        Me.HardGame.Text = "Hard Level"
        Me.HardGame.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.HardGame.WordWrap = False
        '
        'MediumGame
        '
        Me.MediumGame.BackColor = System.Drawing.Color.Blue
        Me.MediumGame.Cursor = System.Windows.Forms.Cursors.Default
        Me.MediumGame.Font = New System.Drawing.Font("Calibri", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MediumGame.Location = New System.Drawing.Point(47, 123)
        Me.MediumGame.Margin = New System.Windows.Forms.Padding(2)
        Me.MediumGame.Multiline = True
        Me.MediumGame.Name = "MediumGame"
        Me.MediumGame.Size = New System.Drawing.Size(202, 82)
        Me.MediumGame.TabIndex = 5
        Me.MediumGame.TabStop = False
        Me.MediumGame.Text = "Medium Level"
        Me.MediumGame.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.MediumGame.WordWrap = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 20000
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(255, 161)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(31, 86)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'SelectGame
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Purple
        Me.ClientSize = New System.Drawing.Size(298, 341)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.MediumGame)
        Me.Controls.Add(Me.HardGame)
        Me.Controls.Add(Me.EasyGame)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "SelectGame"
        Me.Text = "Select Game Level"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents EasyGame As TextBox
    Friend WithEvents HardGame As TextBox
    Friend WithEvents MediumGame As TextBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Button1 As Button
End Class
