<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DataForm
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
        Me.HeartsComboBox = New System.Windows.Forms.ComboBox
        Me.DiamondsComboBox = New System.Windows.Forms.ComboBox
        Me.ClubsComboBox = New System.Windows.Forms.ComboBox
        Me.SpadesComboBox = New System.Windows.Forms.ComboBox
        Me.NorthPlayerCards = New System.Windows.Forms.ComboBox
        Me.EastPlayerCards = New System.Windows.Forms.ComboBox
        Me.SouthPlayerCards = New System.Windows.Forms.ComboBox
        Me.WestPlayerCards = New System.Windows.Forms.ComboBox
        Me.SuspendLayout()
        '
        'HeartsComboBox
        '
        Me.HeartsComboBox.FormattingEnabled = True
        Me.HeartsComboBox.Location = New System.Drawing.Point(12, 39)
        Me.HeartsComboBox.Name = "HeartsComboBox"
        Me.HeartsComboBox.Size = New System.Drawing.Size(156, 21)
        Me.HeartsComboBox.TabIndex = 0
        Me.HeartsComboBox.Text = "HeartsData"
        '
        'DiamondsComboBox
        '
        Me.DiamondsComboBox.FormattingEnabled = True
        Me.DiamondsComboBox.Location = New System.Drawing.Point(198, 39)
        Me.DiamondsComboBox.Name = "DiamondsComboBox"
        Me.DiamondsComboBox.Size = New System.Drawing.Size(156, 21)
        Me.DiamondsComboBox.TabIndex = 1
        Me.DiamondsComboBox.Text = "DiamondsData"
        '
        'ClubsComboBox
        '
        Me.ClubsComboBox.FormattingEnabled = True
        Me.ClubsComboBox.Location = New System.Drawing.Point(390, 39)
        Me.ClubsComboBox.Name = "ClubsComboBox"
        Me.ClubsComboBox.Size = New System.Drawing.Size(156, 21)
        Me.ClubsComboBox.TabIndex = 2
        Me.ClubsComboBox.Text = "ClubsData"
        '
        'SpadesComboBox
        '
        Me.SpadesComboBox.FormattingEnabled = True
        Me.SpadesComboBox.Location = New System.Drawing.Point(575, 39)
        Me.SpadesComboBox.Name = "SpadesComboBox"
        Me.SpadesComboBox.Size = New System.Drawing.Size(156, 21)
        Me.SpadesComboBox.TabIndex = 3
        Me.SpadesComboBox.Text = "SpadesData"
        '
        'NorthPlayerCards
        '
        Me.NorthPlayerCards.FormattingEnabled = True
        Me.NorthPlayerCards.Location = New System.Drawing.Point(12, 160)
        Me.NorthPlayerCards.Name = "NorthPlayerCards"
        Me.NorthPlayerCards.Size = New System.Drawing.Size(156, 21)
        Me.NorthPlayerCards.TabIndex = 4
        Me.NorthPlayerCards.Text = "NorthPlayerCards"
        '
        'EastPlayerCards
        '
        Me.EastPlayerCards.FormattingEnabled = True
        Me.EastPlayerCards.Location = New System.Drawing.Point(198, 160)
        Me.EastPlayerCards.Name = "EastPlayerCards"
        Me.EastPlayerCards.Size = New System.Drawing.Size(156, 21)
        Me.EastPlayerCards.TabIndex = 5
        Me.EastPlayerCards.Text = "EastPlayerCards"
        '
        'SouthPlayerCards
        '
        Me.SouthPlayerCards.FormattingEnabled = True
        Me.SouthPlayerCards.Location = New System.Drawing.Point(390, 160)
        Me.SouthPlayerCards.Name = "SouthPlayerCards"
        Me.SouthPlayerCards.Size = New System.Drawing.Size(156, 21)
        Me.SouthPlayerCards.TabIndex = 6
        Me.SouthPlayerCards.Text = "SouthPlayerCards"
        '
        'WestPlayerCards
        '
        Me.WestPlayerCards.FormattingEnabled = True
        Me.WestPlayerCards.Location = New System.Drawing.Point(575, 160)
        Me.WestPlayerCards.Name = "WestPlayerCards"
        Me.WestPlayerCards.Size = New System.Drawing.Size(156, 21)
        Me.WestPlayerCards.TabIndex = 7
        Me.WestPlayerCards.Text = "WestPlayerCards"
        '
        'DataForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(747, 264)
        Me.Controls.Add(Me.WestPlayerCards)
        Me.Controls.Add(Me.SouthPlayerCards)
        Me.Controls.Add(Me.EastPlayerCards)
        Me.Controls.Add(Me.NorthPlayerCards)
        Me.Controls.Add(Me.SpadesComboBox)
        Me.Controls.Add(Me.ClubsComboBox)
        Me.Controls.Add(Me.DiamondsComboBox)
        Me.Controls.Add(Me.HeartsComboBox)
        Me.Name = "DataForm"
        Me.Text = "DataForm"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents HeartsComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents DiamondsComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents ClubsComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents SpadesComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents NorthPlayerCards As System.Windows.Forms.ComboBox
    Friend WithEvents EastPlayerCards As System.Windows.Forms.ComboBox
    Friend WithEvents SouthPlayerCards As System.Windows.Forms.ComboBox
    Friend WithEvents WestPlayerCards As System.Windows.Forms.ComboBox
End Class
