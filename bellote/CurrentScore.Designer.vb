<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CurrentScore
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
        Me.VerScore = New System.Windows.Forms.ListBox
        Me.ContractBox = New System.Windows.Forms.ListBox
        Me.HorScore = New System.Windows.Forms.ListBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.VerTotal = New System.Windows.Forms.Label
        Me.HorTotal = New System.Windows.Forms.Label
        Me.OK = New System.Windows.Forms.Button
        Me.Total = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'VerScore
        '
        Me.VerScore.FormattingEnabled = True
        Me.VerScore.Location = New System.Drawing.Point(50, 60)
        Me.VerScore.Name = "VerScore"
        Me.VerScore.Size = New System.Drawing.Size(36, 342)
        Me.VerScore.TabIndex = 0
        '
        'ContractBox
        '
        Me.ContractBox.FormattingEnabled = True
        Me.ContractBox.Location = New System.Drawing.Point(130, 60)
        Me.ContractBox.Name = "ContractBox"
        Me.ContractBox.Size = New System.Drawing.Size(36, 342)
        Me.ContractBox.TabIndex = 1
        '
        'HorScore
        '
        Me.HorScore.FormattingEnabled = True
        Me.HorScore.Location = New System.Drawing.Point(210, 60)
        Me.HorScore.Name = "HorScore"
        Me.HorScore.Size = New System.Drawing.Size(36, 342)
        Me.HorScore.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(47, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Vertical"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(127, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Contract"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(207, 31)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Horizontal"
        '
        'VerTotal
        '
        Me.VerTotal.AutoSize = True
        Me.VerTotal.Location = New System.Drawing.Point(47, 417)
        Me.VerTotal.Name = "VerTotal"
        Me.VerTotal.Size = New System.Drawing.Size(39, 13)
        Me.VerTotal.TabIndex = 6
        Me.VerTotal.Text = "Label4"
        '
        'HorTotal
        '
        Me.HorTotal.AutoSize = True
        Me.HorTotal.Location = New System.Drawing.Point(207, 417)
        Me.HorTotal.Name = "HorTotal"
        Me.HorTotal.Size = New System.Drawing.Size(39, 13)
        Me.HorTotal.TabIndex = 7
        Me.HorTotal.Text = "Label5"
        '
        'OK
        '
        Me.OK.Location = New System.Drawing.Point(50, 458)
        Me.OK.Name = "OK"
        Me.OK.Size = New System.Drawing.Size(196, 34)
        Me.OK.TabIndex = 9
        Me.OK.Text = "OK"
        Me.OK.UseVisualStyleBackColor = True
        '
        'Total
        '
        Me.Total.AutoSize = True
        Me.Total.Location = New System.Drawing.Point(2, 417)
        Me.Total.Name = "Total"
        Me.Total.Size = New System.Drawing.Size(48, 13)
        Me.Total.TabIndex = 10
        Me.Total.Text = "TOTAL :"
        '
        'CurrentScore
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(313, 528)
        Me.Controls.Add(Me.Total)
        Me.Controls.Add(Me.OK)
        Me.Controls.Add(Me.HorTotal)
        Me.Controls.Add(Me.VerTotal)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.HorScore)
        Me.Controls.Add(Me.ContractBox)
        Me.Controls.Add(Me.VerScore)
        Me.Name = "CurrentScore"
        Me.Text = "CurrentScore"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents OK As System.Windows.Forms.Button
    Friend WithEvents Total As System.Windows.Forms.Label
    Public WithEvents VerScore As System.Windows.Forms.ListBox
    Public WithEvents ContractBox As System.Windows.Forms.ListBox
    Public WithEvents HorScore As System.Windows.Forms.ListBox
    Public WithEvents VerTotal As System.Windows.Forms.Label
    Public WithEvents HorTotal As System.Windows.Forms.Label
End Class
