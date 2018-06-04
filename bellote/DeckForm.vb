
Public Class DeckForm
    Public Shared Back As String
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If Not (PictureBox1.BorderStyle = BorderStyle.None And PictureBox2.BorderStyle = BorderStyle.None And PictureBox3.BorderStyle = BorderStyle.None And PictureBox4.BorderStyle = BorderStyle.None) Then
            Me.Close()
            Form1.Enabled() = True
        Else
            MsgBox("Please Select a deck, choose from 2 classical decks, aris deck or Stavrakas deck ", MsgBoxStyle.Exclamation, "Select Deck")

        End If
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        Back = "Back1"
        PictureBox2.BorderStyle = BorderStyle.None
        PictureBox1.BorderStyle = BorderStyle.FixedSingle
        PictureBox3.BorderStyle = BorderStyle.None
        PictureBox4.BorderStyle = BorderStyle.None
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        Back = "Back"
        PictureBox2.BorderStyle = BorderStyle.FixedSingle
        PictureBox1.BorderStyle = BorderStyle.None
        PictureBox3.BorderStyle = BorderStyle.None
        PictureBox4.BorderStyle = BorderStyle.None
    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click
        Back = "Back2"
        PictureBox2.BorderStyle = BorderStyle.None
        PictureBox1.BorderStyle = BorderStyle.None
        PictureBox3.BorderStyle = BorderStyle.FixedSingle
        PictureBox4.BorderStyle = BorderStyle.None
    End Sub

    Private Sub PictureBox4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox4.Click
        Back = "Back4"
        PictureBox2.BorderStyle = BorderStyle.None
        PictureBox1.BorderStyle = BorderStyle.None
        PictureBox3.BorderStyle = BorderStyle.None
        PictureBox4.BorderStyle = BorderStyle.FixedSingle
    End Sub
End Class