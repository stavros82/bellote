Public Class DataForm

    Private Sub DataForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

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

        'HeartsComboBox.Items.Add(Form1.CurrentStronger("Hearts"))
        'DiamondsComboBox.Items.Add(Form1.CurrentStronger("Diamonds"))
        'ClubsComboBox.Items.Add(Form1.CurrentStronger("Clubs"))
        'SpadesComboBox.Items.Add(Form1.CurrentStronger("Spades"))

        Form1.AddCardPointsToDataForm()

    End Sub


End Class