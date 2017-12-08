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
        Me.EasyGame = New System.Windows.Forms.TextBox()
        Me.HardGame = New System.Windows.Forms.TextBox()
        Me.MediumGame = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'EasyGame
        '
        Me.EasyGame.BackColor = System.Drawing.Color.LimeGreen
        Me.EasyGame.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.EasyGame.Font = New System.Drawing.Font("Calibri", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EasyGame.Location = New System.Drawing.Point(63, 30)
        Me.EasyGame.Multiline = True
        Me.EasyGame.Name = "EasyGame"
        Me.EasyGame.Size = New System.Drawing.Size(268, 96)
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
        Me.HardGame.Location = New System.Drawing.Point(63, 275)
        Me.HardGame.Multiline = True
        Me.HardGame.Name = "HardGame"
        Me.HardGame.Size = New System.Drawing.Size(268, 100)
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
        Me.MediumGame.Location = New System.Drawing.Point(63, 151)
        Me.MediumGame.Multiline = True
        Me.MediumGame.Name = "MediumGame"
        Me.MediumGame.Size = New System.Drawing.Size(268, 100)
        Me.MediumGame.TabIndex = 5
        Me.MediumGame.TabStop = False
        Me.MediumGame.Text = "Medium Level"
        Me.MediumGame.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.MediumGame.WordWrap = False
        '
        'SelectGame
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Purple
        Me.ClientSize = New System.Drawing.Size(397, 420)
        Me.Controls.Add(Me.MediumGame)
        Me.Controls.Add(Me.HardGame)
        Me.Controls.Add(Me.EasyGame)
        Me.Name = "SelectGame"
        Me.Text = "Select Game Level"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents EasyGame As TextBox
    Friend WithEvents HardGame As TextBox
    Friend WithEvents MediumGame As TextBox
End Class
