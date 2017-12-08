<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Testing
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
        Me.btnNo = New System.Windows.Forms.Button()
        Me.btnYes = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnNo
        '
        Me.btnNo.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnNo.Font = New System.Drawing.Font("Calibri", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNo.Location = New System.Drawing.Point(229, 204)
        Me.btnNo.Name = "btnNo"
        Me.btnNo.Size = New System.Drawing.Size(139, 151)
        Me.btnNo.TabIndex = 0
        Me.btnNo.Text = "NO"
        Me.btnNo.UseVisualStyleBackColor = False
        Me.btnNo.Visible = False
        '
        'btnYes
        '
        Me.btnYes.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.btnYes.Font = New System.Drawing.Font("Calibri", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnYes.Location = New System.Drawing.Point(46, 204)
        Me.btnYes.Name = "btnYes"
        Me.btnYes.Size = New System.Drawing.Size(139, 151)
        Me.btnYes.TabIndex = 1
        Me.btnYes.Text = "YES"
        Me.btnYes.UseVisualStyleBackColor = False
        Me.btnYes.Visible = False
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.Plum
        Me.TextBox1.Font = New System.Drawing.Font("Calibri", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(75, 48)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(268, 92)
        Me.TextBox1.TabIndex = 2
        Me.TextBox1.Text = "The Winner!!   Stella"
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Testing
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(417, 427)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.btnYes)
        Me.Controls.Add(Me.btnNo)
        Me.Name = "Testing"
        Me.Text = "Please Say YES"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnNo As Button
    Friend WithEvents btnYes As Button
    Friend WithEvents TextBox1 As TextBox
End Class
