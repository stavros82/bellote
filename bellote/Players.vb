Public Class Players

    Public Shared OnePl, One As Boolean
    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        If OnePlayerAuto.Checked Then
            OnePl = True
        End If
        If OnePlayer.Checked Then
            OnePl = True
            One = True
        End If
        Me.Close()
        DeckForm.Show()
        '    Form1.Enabled = True
    End Sub

    
   
End Class