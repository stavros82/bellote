<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Players
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GameType = New System.Windows.Forms.GroupBox
        Me.OnePlayer = New System.Windows.Forms.RadioButton
        Me.OnePlayerAuto = New System.Windows.Forms.RadioButton
        Me.AutoPlay = New System.Windows.Forms.RadioButton
        Me.OK = New System.Windows.Forms.Button
        Me.GameType.SuspendLayout()
        Me.SuspendLayout()
        '
        'GameType
        '
        Me.GameType.Controls.Add(Me.OnePlayer)
        Me.GameType.Controls.Add(Me.OnePlayerAuto)
        Me.GameType.Controls.Add(Me.AutoPlay)
        Me.GameType.Location = New System.Drawing.Point(15, 11)
        Me.GameType.Name = "GameType"
        Me.GameType.Size = New System.Drawing.Size(251, 112)
        Me.GameType.TabIndex = 2
        Me.GameType.TabStop = False
        Me.GameType.Text = "Type of Game"
        '
        'OnePlayer
        '
        Me.OnePlayer.AutoSize = True
        Me.OnePlayer.Location = New System.Drawing.Point(14, 72)
        Me.OnePlayer.Name = "OnePlayer"
        Me.OnePlayer.Size = New System.Drawing.Size(171, 17)
        Me.OnePlayer.TabIndex = 2
        Me.OnePlayer.TabStop = True
        Me.OnePlayer.Text = "Play - Show one Player's Cards"
        Me.OnePlayer.UseVisualStyleBackColor = True
        '
        'OnePlayerAuto
        '
        Me.OnePlayerAuto.AutoSize = True
        Me.OnePlayerAuto.Checked = True
        Me.OnePlayerAuto.Location = New System.Drawing.Point(14, 49)
        Me.OnePlayerAuto.Name = "OnePlayerAuto"
        Me.OnePlayerAuto.Size = New System.Drawing.Size(196, 17)
        Me.OnePlayerAuto.TabIndex = 1
        Me.OnePlayerAuto.TabStop = True
        Me.OnePlayerAuto.Text = "Auto Play - Show one Player's Cards"
        Me.OnePlayerAuto.UseVisualStyleBackColor = True
        '
        'AutoPlay
        '
        Me.AutoPlay.AutoSize = True
        Me.AutoPlay.Location = New System.Drawing.Point(14, 26)
        Me.AutoPlay.Name = "AutoPlay"
        Me.AutoPlay.Size = New System.Drawing.Size(150, 17)
        Me.AutoPlay.TabIndex = 0
        Me.AutoPlay.Text = "Auto Play - Show All Cards"
        Me.AutoPlay.UseVisualStyleBackColor = True
        '
        'OK
        '
        Me.OK.Location = New System.Drawing.Point(15, 149)
        Me.OK.Name = "OK"
        Me.OK.Size = New System.Drawing.Size(66, 26)
        Me.OK.TabIndex = 3
        Me.OK.Text = "OK"
        Me.OK.UseVisualStyleBackColor = True
        '
        'Players
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(299, 196)
        Me.Controls.Add(Me.OK)
        Me.Controls.Add(Me.GameType)
        Me.Name = "Players"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Players"
        Me.TopMost = True
        Me.GameType.ResumeLayout(False)
        Me.GameType.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GameType As System.Windows.Forms.GroupBox
    Friend WithEvents OK As System.Windows.Forms.Button
    Friend WithEvents OnePlayerAuto As System.Windows.Forms.RadioButton
    Friend WithEvents AutoPlay As System.Windows.Forms.RadioButton
    Friend WithEvents OnePlayer As System.Windows.Forms.RadioButton
End Class
