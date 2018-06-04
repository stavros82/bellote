Public Class DataForm


    Private Sub DataForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ContextMenuStrip.Items.Item("Refresh").Enabled = False





        NorthPlayerCards.Items.Add("North Has HCS :" & Form1.NorthHasHCS)
        EastPlayerCards.Items.Add("East Has HCS: " & Form1.EastHasHCS)
        SouthPlayerCards.Items.Add("South Has HCS: " & Form1.SouthHasHCS)
        WestPlayerCards.Items.Add("West Has HCS: " & Form1.WestHasHCS)

        NorthPlayerCards.Items.Add("North Has DCS :" & Form1.NorthHasDCS)
        EastPlayerCards.Items.Add("East Has DCS: " & Form1.EastHasDCS)
        SouthPlayerCards.Items.Add("South Has DCS: " & Form1.SouthHasDCS)
        WestPlayerCards.Items.Add("West Has DCS: " & Form1.WestHasDCS)

        NorthPlayerCards.Items.Add("North Has CCS :" & Form1.NorthHasCCS)
        EastPlayerCards.Items.Add("East Has CCS: " & Form1.EastHasCCS)
        SouthPlayerCards.Items.Add("South Has CCS: " & Form1.SouthHasCCS)
        WestPlayerCards.Items.Add("West Has CCS: " & Form1.WestHasCCS)

        NorthPlayerCards.Items.Add("North Has SCS :" & Form1.NorthHasSCS)
        EastPlayerCards.Items.Add("East Has SCS: " & Form1.EastHasSCS)
        SouthPlayerCards.Items.Add("South Has SCS: " & Form1.SouthHasSCS)
        WestPlayerCards.Items.Add("West Has SCS: " & Form1.WestHasSCS)

        HeartsComboBox.Items.Add("Hearts Current Stronger :" & Form1.HCS)
        DiamondsComboBox.Items.Add("Diamonds Current Stronger :" & Form1.DCS)
        ClubsComboBox.Items.Add("Clubs Current Stronger :" & Form1.CCS)
        SpadesComboBox.Items.Add("Spades Current Stronger :" & Form1.SCS)

        HeartsComboBox.Items.Add("Ten Hearts Not Alone: " & Form1.TenHeartsNA)
        DiamondsComboBox.Items.Add("Ten Diamonds Not Alone: " & Form1.TenDiamondsNA)
        ClubsComboBox.Items.Add("Ten Clubs Not Alone: " & Form1.TenClubsNA)
        SpadesComboBox.Items.Add("Ten Spades Not Alone: " & Form1.TenSpadesNA)


        HeartsComboBox.Items.Add("Hearts Played: " & Form1.HeartsCounter)
        HeartsComboBox.Items.Add("A Hearts Played: " & Form1.AHearts)
        HeartsComboBox.Items.Add("10 Hearts Played: " & Form1.TenHearts)
        HeartsComboBox.Items.Add("K Hearts Played: " & Form1.KHearts)
        HeartsComboBox.Items.Add("Q Hearts Played: " & Form1.QHearts)
        HeartsComboBox.Items.Add("J Hearts Played: " & Form1.JHearts)
        HeartsComboBox.Items.Add("9 Hearts Played: " & Form1.NineHearts)
        HeartsComboBox.Items.Add("8 Hearts Played: " & Form1.EightHearts)
        HeartsComboBox.Items.Add("7 Hearts Played: " & Form1.SevenHearts)

        DiamondsComboBox.Items.Add("Diamonds Played: " & Form1.DiamondsCounter)
        DiamondsComboBox.Items.Add("A Diamonds Played: " & Form1.ADiamonds)
        DiamondsComboBox.Items.Add("10 Diamonds Played: " & Form1.TenDiamonds)
        DiamondsComboBox.Items.Add("K Diamonds Played: " & Form1.KDiamonds)
        DiamondsComboBox.Items.Add("Q Diamonds Played: " & Form1.QDiamonds)
        DiamondsComboBox.Items.Add("J Diamonds Played: " & Form1.JDiamonds)
        DiamondsComboBox.Items.Add("9 Diamonds Played: " & Form1.NineDiamonds)
        DiamondsComboBox.Items.Add("8 Diamonds Played: " & Form1.EightDiamonds)
        DiamondsComboBox.Items.Add("7 Diamonds Played: " & Form1.SevenDiamonds)

        ClubsComboBox.Items.Add("Clubs Played: " & Form1.ClubsCounter)
        ClubsComboBox.Items.Add("A Clubs Played: " & Form1.AClubs)
        ClubsComboBox.Items.Add("10 Clubs Played: " & Form1.TenClubs)
        ClubsComboBox.Items.Add("K Clubs Played: " & Form1.KClubs)
        ClubsComboBox.Items.Add("Q Clubs Played: " & Form1.QClubs)
        ClubsComboBox.Items.Add("J Clubs Played: " & Form1.JClubs)
        ClubsComboBox.Items.Add("9 Clubs Played: " & Form1.NineClubs)
        ClubsComboBox.Items.Add("8 Clubs Played: " & Form1.EightClubs)
        ClubsComboBox.Items.Add("7 Clubs Played: " & Form1.SevenClubs)

        SpadesComboBox.Items.Add("Spades Played: " & Form1.SpadesCounter)
        SpadesComboBox.Items.Add("A Spades Played: " & Form1.ASpades)
        SpadesComboBox.Items.Add("10 Spades Played: " & Form1.TenSpades)
        SpadesComboBox.Items.Add("K Spades Played: " & Form1.KSpades)
        SpadesComboBox.Items.Add("Q Spades Played: " & Form1.QSpades)
        SpadesComboBox.Items.Add("J Spades Played: " & Form1.JSpades)
        SpadesComboBox.Items.Add("9 Spades Played: " & Form1.NineSpades)
        SpadesComboBox.Items.Add("8 Spades Played: " & Form1.EightSpades)
        SpadesComboBox.Items.Add("7 Spades Played: " & Form1.SevenSpades)

        NorthTsaka.Items.Add("North Tsaka Hearts: " & Form1.NTsakaHearts)
        NorthTsaka.Items.Add("North Tsaka Diamonds: " & Form1.NTsakaDiamonds)
        NorthTsaka.Items.Add("North Tsaka Clubs: " & Form1.NTsakaClubs)
        NorthTsaka.Items.Add("North Tsaka Spades: " & Form1.NTsakaSpades)


        EastTsaka.Items.Add("East Tsaka Hearts: " & Form1.ETsakaHearts)
        EastTsaka.Items.Add("East Tsaka Diamonds: " & Form1.ETsakaDiamonds)
        EastTsaka.Items.Add("East Tsaka Clubs: " & Form1.ETsakaClubs)
        EastTsaka.Items.Add("East Tsaka Spades: " & Form1.ETsakaSpades)

        SouthTsaka.Items.Add("South Tsaka Hearts: " & Form1.STsakaHearts)
        SouthTsaka.Items.Add("South Tsaka Diamonds: " & Form1.STsakaDiamonds)
        SouthTsaka.Items.Add("South Tsaka Clubs: " & Form1.STsakaClubs)
        SouthTsaka.Items.Add("South Tsaka Spades: " & Form1.STsakaSpades)

        WestTsaka.Items.Add("West Tsaka Hearts: " & Form1.WTsakaHearts)
        WestTsaka.Items.Add("West Tsaka Diamonds: " & Form1.WTsakaDiamonds)
        WestTsaka.Items.Add("West Tsaka Clubs: " & Form1.WTsakaClubs)
        WestTsaka.Items.Add("West Tsaka Spades: " & Form1.WTsakaSpades)

        Dim i As Integer
        For i = 0 To 10
            NortHas.Items.Add("North Has :" & Form1.NorthHas(i))
            EastHas.Items.Add("East Has :" & Form1.EastHas(i))
            SouthHas.Items.Add("South Has :" & Form1.SouthHas(i))
            WestHas.Items.Add("West Has :" & Form1.WestHas(i))

        Next
     
        TextBox1.Text = "Atou Played: " & Form1.AtouCounter

        Form1.AddCardPointsToDataForm()

    End Sub




    Private Sub DataForm_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseUp
        If e.Button = MouseButtons.Right Then

            ContextMenuStrip.Show(Me, New Point(e.X, e.Y))
        End If
    End Sub



   
    Private Sub Refresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Refresh.Click

    End Sub

    
    
End Class