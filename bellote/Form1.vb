
Public Class Form1
    Inherits System.Windows.Forms.Form
#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents DoubleUp As System.Windows.Forms.Button
    Friend WithEvents PlayerLabel As System.Windows.Forms.Label
    Friend WithEvents SuitLabel As System.Windows.Forms.Label
    Friend WithEvents PointsLabel As System.Windows.Forms.Label
    Friend WithEvents OFFER_Button As System.Windows.Forms.Button
    Friend WithEvents DEAL_Button As System.Windows.Forms.Button
    Friend WithEvents CurrentOffer As System.Windows.Forms.Label
    Friend WithEvents ClearRound_Button As System.Windows.Forms.Button
    Friend WithEvents Txt1 As System.Windows.Forms.TextBox
    Friend WithEvents DeclarationsNorth As System.Windows.Forms.TextBox
    Friend WithEvents DeclarationsSouth As System.Windows.Forms.TextBox
    Friend WithEvents DeclarationsWest As System.Windows.Forms.TextBox
    Friend WithEvents DeclarationsEast As System.Windows.Forms.TextBox
    Friend WithEvents VerticalPoints As System.Windows.Forms.TextBox
    Friend WithEvents HorizontalPoints As System.Windows.Forms.TextBox
    Friend WithEvents CurrentOffer1 As System.Windows.Forms.Label
    Friend WithEvents MainMenu1 As System.Windows.Forms.MainMenu
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem4 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem5 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem6 As System.Windows.Forms.MenuItem
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents NorthPlay As System.Windows.Forms.Button
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents EastPlay As System.Windows.Forms.Button
    Friend WithEvents SouthPlay As System.Windows.Forms.Button
    Friend WithEvents WestPlay As System.Windows.Forms.Button
    Friend WithEvents MenuItem3 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem7 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem8 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem9 As System.Windows.Forms.MenuItem
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.OFFER_Button = New System.Windows.Forms.Button
        Me.DoubleUp = New System.Windows.Forms.Button
        Me.PlayerLabel = New System.Windows.Forms.Label
        Me.SuitLabel = New System.Windows.Forms.Label
        Me.PointsLabel = New System.Windows.Forms.Label
        Me.DEAL_Button = New System.Windows.Forms.Button
        Me.CurrentOffer = New System.Windows.Forms.Label
        Me.HorizontalPoints = New System.Windows.Forms.TextBox
        Me.ClearRound_Button = New System.Windows.Forms.Button
        Me.Txt1 = New System.Windows.Forms.TextBox
        Me.DeclarationsNorth = New System.Windows.Forms.TextBox
        Me.DeclarationsSouth = New System.Windows.Forms.TextBox
        Me.DeclarationsWest = New System.Windows.Forms.TextBox
        Me.DeclarationsEast = New System.Windows.Forms.TextBox
        Me.VerticalPoints = New System.Windows.Forms.TextBox
        Me.CurrentOffer1 = New System.Windows.Forms.Label
        Me.MainMenu1 = New System.Windows.Forms.MainMenu(Me.components)
        Me.MenuItem1 = New System.Windows.Forms.MenuItem
        Me.MenuItem2 = New System.Windows.Forms.MenuItem
        Me.MenuItem4 = New System.Windows.Forms.MenuItem
        Me.MenuItem3 = New System.Windows.Forms.MenuItem
        Me.MenuItem7 = New System.Windows.Forms.MenuItem
        Me.MenuItem8 = New System.Windows.Forms.MenuItem
        Me.MenuItem9 = New System.Windows.Forms.MenuItem
        Me.MenuItem5 = New System.Windows.Forms.MenuItem
        Me.MenuItem6 = New System.Windows.Forms.MenuItem
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.NorthPlay = New System.Windows.Forms.Button
        Me.TextBox5 = New System.Windows.Forms.TextBox
        Me.EastPlay = New System.Windows.Forms.Button
        Me.SouthPlay = New System.Windows.Forms.Button
        Me.WestPlay = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'OFFER_Button
        '
        Me.OFFER_Button.BackColor = System.Drawing.SystemColors.ControlDark
        Me.OFFER_Button.Enabled = False
        Me.OFFER_Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OFFER_Button.Location = New System.Drawing.Point(32, 656)
        Me.OFFER_Button.Name = "OFFER_Button"
        Me.OFFER_Button.Size = New System.Drawing.Size(160, 80)
        Me.OFFER_Button.TabIndex = 2
        Me.OFFER_Button.Text = "OFFER"
        Me.OFFER_Button.UseVisualStyleBackColor = False
        '
        'DoubleUp
        '
        Me.DoubleUp.BackColor = System.Drawing.SystemColors.ControlDark
        Me.DoubleUp.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DoubleUp.Location = New System.Drawing.Point(32, 744)
        Me.DoubleUp.Name = "DoubleUp"
        Me.DoubleUp.Size = New System.Drawing.Size(160, 80)
        Me.DoubleUp.TabIndex = 3
        Me.DoubleUp.Text = "DoubleUp"
        Me.DoubleUp.UseVisualStyleBackColor = False
        '
        'PlayerLabel
        '
        Me.PlayerLabel.BackColor = System.Drawing.SystemColors.ControlDark
        Me.PlayerLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PlayerLabel.Location = New System.Drawing.Point(32, 456)
        Me.PlayerLabel.Name = "PlayerLabel"
        Me.PlayerLabel.Size = New System.Drawing.Size(160, 64)
        Me.PlayerLabel.TabIndex = 4
        Me.PlayerLabel.Text = "Label1"
        '
        'SuitLabel
        '
        Me.SuitLabel.BackColor = System.Drawing.Color.Black
        Me.SuitLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SuitLabel.ForeColor = System.Drawing.Color.White
        Me.SuitLabel.Location = New System.Drawing.Point(32, 528)
        Me.SuitLabel.Name = "SuitLabel"
        Me.SuitLabel.Size = New System.Drawing.Size(160, 56)
        Me.SuitLabel.TabIndex = 5
        Me.SuitLabel.Text = "Suit:"
        '
        'PointsLabel
        '
        Me.PointsLabel.BackColor = System.Drawing.SystemColors.ControlText
        Me.PointsLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PointsLabel.ForeColor = System.Drawing.Color.White
        Me.PointsLabel.Location = New System.Drawing.Point(32, 592)
        Me.PointsLabel.Name = "PointsLabel"
        Me.PointsLabel.Size = New System.Drawing.Size(160, 56)
        Me.PointsLabel.TabIndex = 6
        Me.PointsLabel.Text = "Points:"
        '
        'DEAL_Button
        '
        Me.DEAL_Button.BackColor = System.Drawing.Color.Yellow
        Me.DEAL_Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DEAL_Button.ForeColor = System.Drawing.Color.Red
        Me.DEAL_Button.Location = New System.Drawing.Point(12, 138)
        Me.DEAL_Button.Name = "DEAL_Button"
        Me.DEAL_Button.Size = New System.Drawing.Size(160, 56)
        Me.DEAL_Button.TabIndex = 7
        Me.DEAL_Button.Text = "DEAL"
        Me.DEAL_Button.UseVisualStyleBackColor = False
        '
        'CurrentOffer
        '
        Me.CurrentOffer.BackColor = System.Drawing.Color.DimGray
        Me.CurrentOffer.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CurrentOffer.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.CurrentOffer.Location = New System.Drawing.Point(40, 16)
        Me.CurrentOffer.Name = "CurrentOffer"
        Me.CurrentOffer.Size = New System.Drawing.Size(168, 56)
        Me.CurrentOffer.TabIndex = 8
        Me.CurrentOffer.Text = "Current Offer"
        '
        'HorizontalPoints
        '
        Me.HorizontalPoints.Location = New System.Drawing.Point(307, 24)
        Me.HorizontalPoints.Name = "HorizontalPoints"
        Me.HorizontalPoints.Size = New System.Drawing.Size(71, 20)
        Me.HorizontalPoints.TabIndex = 9
        '
        'ClearRound_Button
        '
        Me.ClearRound_Button.BackColor = System.Drawing.Color.GreenYellow
        Me.ClearRound_Button.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.ClearRound_Button.ForeColor = System.Drawing.Color.Red
        Me.ClearRound_Button.Location = New System.Drawing.Point(232, 50)
        Me.ClearRound_Button.Name = "ClearRound_Button"
        Me.ClearRound_Button.Size = New System.Drawing.Size(146, 40)
        Me.ClearRound_Button.TabIndex = 10
        Me.ClearRound_Button.Text = "Clear Round"
        Me.ClearRound_Button.UseVisualStyleBackColor = False
        '
        'Txt1
        '
        Me.Txt1.Location = New System.Drawing.Point(72, 112)
        Me.Txt1.Name = "Txt1"
        Me.Txt1.Size = New System.Drawing.Size(100, 20)
        Me.Txt1.TabIndex = 11
        Me.Txt1.Text = "TextBox1"
        '
        'DeclarationsNorth
        '
        Me.DeclarationsNorth.Enabled = False
        Me.DeclarationsNorth.Location = New System.Drawing.Point(752, 24)
        Me.DeclarationsNorth.Name = "DeclarationsNorth"
        Me.DeclarationsNorth.Size = New System.Drawing.Size(100, 20)
        Me.DeclarationsNorth.TabIndex = 12
        Me.DeclarationsNorth.Text = "TextBox1"
        '
        'DeclarationsSouth
        '
        Me.DeclarationsSouth.Enabled = False
        Me.DeclarationsSouth.Location = New System.Drawing.Point(544, 520)
        Me.DeclarationsSouth.Name = "DeclarationsSouth"
        Me.DeclarationsSouth.Size = New System.Drawing.Size(100, 20)
        Me.DeclarationsSouth.TabIndex = 13
        Me.DeclarationsSouth.Text = "TextBox1"
        '
        'DeclarationsWest
        '
        Me.DeclarationsWest.Enabled = False
        Me.DeclarationsWest.Location = New System.Drawing.Point(189, 174)
        Me.DeclarationsWest.Name = "DeclarationsWest"
        Me.DeclarationsWest.Size = New System.Drawing.Size(100, 20)
        Me.DeclarationsWest.TabIndex = 14
        Me.DeclarationsWest.Text = "TextBox2"
        '
        'DeclarationsEast
        '
        Me.DeclarationsEast.Enabled = False
        Me.DeclarationsEast.Location = New System.Drawing.Point(896, 174)
        Me.DeclarationsEast.Name = "DeclarationsEast"
        Me.DeclarationsEast.Size = New System.Drawing.Size(100, 20)
        Me.DeclarationsEast.TabIndex = 15
        Me.DeclarationsEast.Text = "TextBox3"
        '
        'VerticalPoints
        '
        Me.VerticalPoints.Location = New System.Drawing.Point(232, 24)
        Me.VerticalPoints.Name = "VerticalPoints"
        Me.VerticalPoints.Size = New System.Drawing.Size(69, 20)
        Me.VerticalPoints.TabIndex = 19
        '
        'CurrentOffer1
        '
        Me.CurrentOffer1.ForeColor = System.Drawing.Color.White
        Me.CurrentOffer1.Location = New System.Drawing.Point(40, 72)
        Me.CurrentOffer1.Name = "CurrentOffer1"
        Me.CurrentOffer1.Size = New System.Drawing.Size(168, 32)
        Me.CurrentOffer1.TabIndex = 20
        Me.CurrentOffer1.Text = "Label1"
        '
        'MainMenu1
        '
        Me.MainMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem1, Me.MenuItem5})
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 0
        Me.MenuItem1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem2, Me.MenuItem4})
        Me.MenuItem1.Text = "Game"
        '
        'MenuItem2
        '
        Me.MenuItem2.Index = 0
        Me.MenuItem2.Text = "New"
        '
        'MenuItem4
        '
        Me.MenuItem4.Index = 1
        Me.MenuItem4.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem3, Me.MenuItem7, Me.MenuItem8, Me.MenuItem9})
        Me.MenuItem4.Text = "Options"
        '
        'MenuItem3
        '
        Me.MenuItem3.Index = 0
        Me.MenuItem3.Text = "Select Deck..."
        '
        'MenuItem7
        '
        Me.MenuItem7.Index = 1
        Me.MenuItem7.Text = "Change Font..."
        '
        'MenuItem8
        '
        Me.MenuItem8.Index = 2
        Me.MenuItem8.Text = "Type of Game..."
        '
        'MenuItem9
        '
        Me.MenuItem9.Index = 3
        Me.MenuItem9.Shortcut = System.Windows.Forms.Shortcut.CtrlS
        Me.MenuItem9.Text = "Current Score... "
        '
        'MenuItem5
        '
        Me.MenuItem5.Index = 1
        Me.MenuItem5.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem6})
        Me.MenuItem5.Text = "Help"
        '
        'MenuItem6
        '
        Me.MenuItem6.Index = 0
        Me.MenuItem6.Shortcut = System.Windows.Forms.Shortcut.CtrlH
        Me.MenuItem6.Text = "Open Data Form"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(229, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 13)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "Vertical Team"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Cyan
        Me.Label2.Location = New System.Drawing.Point(304, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 13)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "Horizontial Team"
        '
        'NorthPlay
        '
        Me.NorthPlay.BackColor = System.Drawing.Color.Silver
        Me.NorthPlay.Enabled = False
        Me.NorthPlay.Location = New System.Drawing.Point(253, 96)
        Me.NorthPlay.Name = "NorthPlay"
        Me.NorthPlay.Size = New System.Drawing.Size(69, 25)
        Me.NorthPlay.TabIndex = 28
        Me.NorthPlay.Text = "NorthPlay"
        Me.NorthPlay.UseVisualStyleBackColor = False
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(73, 86)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(99, 20)
        Me.TextBox5.TabIndex = 32
        '
        'EastPlay
        '
        Me.EastPlay.BackColor = System.Drawing.Color.Silver
        Me.EastPlay.Enabled = False
        Me.EastPlay.Location = New System.Drawing.Point(328, 112)
        Me.EastPlay.Name = "EastPlay"
        Me.EastPlay.Size = New System.Drawing.Size(69, 25)
        Me.EastPlay.TabIndex = 37
        Me.EastPlay.Text = "East Play"
        Me.EastPlay.UseVisualStyleBackColor = False
        '
        'SouthPlay
        '
        Me.SouthPlay.BackColor = System.Drawing.Color.Silver
        Me.SouthPlay.Enabled = False
        Me.SouthPlay.Location = New System.Drawing.Point(253, 127)
        Me.SouthPlay.Name = "SouthPlay"
        Me.SouthPlay.Size = New System.Drawing.Size(69, 25)
        Me.SouthPlay.TabIndex = 38
        Me.SouthPlay.Text = "South Play"
        Me.SouthPlay.UseVisualStyleBackColor = False
        '
        'WestPlay
        '
        Me.WestPlay.BackColor = System.Drawing.Color.Silver
        Me.WestPlay.Enabled = False
        Me.WestPlay.Location = New System.Drawing.Point(178, 112)
        Me.WestPlay.Name = "WestPlay"
        Me.WestPlay.Size = New System.Drawing.Size(69, 25)
        Me.WestPlay.TabIndex = 39
        Me.WestPlay.Text = "WestPlay"
        Me.WestPlay.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.AutoScroll = True
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange
        Me.BackColor = System.Drawing.Color.Green
        Me.ClientSize = New System.Drawing.Size(983, 540)
        Me.Controls.Add(Me.WestPlay)
        Me.Controls.Add(Me.SouthPlay)
        Me.Controls.Add(Me.EastPlay)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.NorthPlay)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CurrentOffer1)
        Me.Controls.Add(Me.VerticalPoints)
        Me.Controls.Add(Me.DeclarationsEast)
        Me.Controls.Add(Me.DeclarationsWest)
        Me.Controls.Add(Me.DeclarationsSouth)
        Me.Controls.Add(Me.DeclarationsNorth)
        Me.Controls.Add(Me.Txt1)
        Me.Controls.Add(Me.HorizontalPoints)
        Me.Controls.Add(Me.ClearRound_Button)
        Me.Controls.Add(Me.CurrentOffer)
        Me.Controls.Add(Me.DEAL_Button)
        Me.Controls.Add(Me.PointsLabel)
        Me.Controls.Add(Me.SuitLabel)
        Me.Controls.Add(Me.PlayerLabel)
        Me.Controls.Add(Me.DoubleUp)
        Me.Controls.Add(Me.OFFER_Button)
        Me.Menu = Me.MainMenu1
        Me.Name = "Form1"
        Me.Text = "Belotte Table"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region
    Dim PicBackBox(31) As PictureBox
    Dim Xartia(32) As PictureBox
    Dim CardName(32) As String
    Dim Rnd As New System.Random

    Structure Offered
        Dim Suite As String
        Dim Points As Integer
    End Structure
    Structure PlayerCards
        Dim NorthPlCards(), EastPlCards(), SouthPlCards(), WestPlCards() As Image
    End Structure

    Function RandomizeNumbers() As Integer()          'Συνάρτηση η οποία επιστρέφει αριθμούς από το 1 έως το 32 χωρίς επανάληψη
        Dim RandomCard, i, Numbers(32) As Integer     'για να γίνεται τυχαία κάθε φορά η μοιρασιά των χαρτιών καθώς τα ονομάσαμε από 
        Dim Check(32) As Boolean                      '1 ως 32 .gif.

        For i = 0 To 31
            RandomCard = Rnd.Next(1, 33)
            If Check(RandomCard) = False Then
                Numbers(i) = RandomCard
                Check(RandomCard) = True
            Else
                While Check(RandomCard) = True
                    RandomCard = Rnd.Next(1, 33)
                End While
                Numbers(i) = RandomCard
                Check(RandomCard) = True
            End If

        Next i
        RandomizeNumbers = Numbers
    End Function
    Dim NorthHas4, SouthHas4, EastHas4, WestHas4 As Boolean
    Dim OverArray(3) As Integer
    Dim CardPoints(32) As Double
    Dim Cards(32) As Integer
    Dim CardSuite(32) As String
    Dim NorthPlCards(8), EastPlCards(8), SouthPlCards(8), WestPlCards(8) As Image
    Dim northHeartscounter, northDiamondscounter, northClubscounter, northSpadescounter, eastHeartscounter, eastDiamondscounter, eastClubscounter, eastSpadescounter As Integer
    Dim southHeartscounter, southDiamondscounter, southClubscounter, southSpadescounter, westHeartscounter, westDiamondscounter, westClubscounter, westSpadescounter As Integer

    Dim northhasjHearts, northhas9Hearts, northhasAhearts, northhasjclubs, northhas9clubs, northhasAclubs As Boolean
    Dim northhasjDiamonds, northhas9Diamonds, northhasADiamonds, northhasjSpades, northhas9Spades, northhasASpades As Boolean
    Dim northhas10Diamonds, northhas10Spades, northhas10Clubs, northhas10Hearts As Boolean


    Dim easthasjHearts, easthas9Hearts, easthasAhearts, easthasjclubs, easthas9clubs, easthasAclubs As Boolean
    Dim easthasjDiamonds, easthas9Diamonds, easthasADiamonds, easthasjSpades, easthas9Spades, easthasASpades As Boolean
    Dim easthas10Diamonds, easthas10Spades, easthas10Clubs, easthas10Hearts As Boolean

    Dim westhasjHearts, westhas9Hearts, westhasAhearts, westhasjclubs, westhas9clubs, westhasAclubs As Boolean
    Dim westhasjDiamonds, westhas9Diamonds, westhasADiamonds, westhasjSpades, westhas9Spades, westhasASpades As Boolean
    Dim westhas10Diamonds, westhas10Spades, westhas10Clubs, westhas10Hearts As Boolean

    Dim southhasjHearts, southhas9Hearts, southhasAhearts, southhasjclubs, southhas9clubs, southhasAclubs As Boolean
    Dim southhasjDiamonds, southhas9Diamonds, southhasADiamonds, southhasjSpades, southhas9Spades, southhasASpades As Boolean
    Dim southhas10Diamonds, southhas10Spades, southhas10Clubs, southhas10Hearts As Boolean



    Sub Deal()
        Dim i, j, k As Integer

        VerticalOver = 0
        HorizontalOver = 0
        i = 0 'increase points
        AcePlayed = False
        HSP = -1
        DSP = -1
        CSP = -1
        SSP = -1
        TenHeartsNA = False
        TenDiamondsNA = False
        TenClubsNA = False
        TenSpadesNA = False
        CardsWithTenH = 0
        CardsWithTenD = 0
        CardsWithTenC = 0
        CardsWithTenS = 0

        northHeartscounter = 0
        northDiamondscounter = 0
        northClubscounter = 0
        northSpadescounter = 0
        eastHeartscounter = 0
        eastDiamondscounter = 0
        eastClubscounter = 0
        eastSpadescounter = 0
        southHeartscounter = 0
        southDiamondscounter = 0
        southClubscounter = 0
        southSpadescounter = 0
        westHeartscounter = 0
        westDiamondscounter = 0
        westClubscounter = 0
        westSpadescounter = 0

        VerticalTeamPoints = 0
        HorizontalTeamPoints = 0
        VerticalPoints.Text = ""
        HorizontalPoints.Text = ""

        For i = 0 To 31
            StandarLoses(31) = False
            Clicked(i) = False
        Next
        StandarLosesCounter = 0

        TenHearts = False
        AHearts = False
        KHearts = False
        QHearts = False
        JHearts = False
        NineHearts = False
        EightHearts = False
        SevenHearts = False
        TenDiamonds = False
        ADiamonds = False
        KDiamonds = False
        QDiamonds = False
        JDiamonds = False
        NineDiamonds = False
        EightDiamonds = False
        SevenDiamonds = False
        TenClubs = False
        AClubs = False
        KClubs = False
        QClubs = False
        JClubs = False
        NineClubs = False
        EightClubs = False
        SevenClubs = False
        TenSpades = False
        ASpades = False
        KSpades = False
        QSpades = False
        JSpades = False
        NineSpades = False
        EightSpades = False
        SevenSpades = False
        '----------------------------------
        HeartsCounter = 0
        DiamondsCounter = 0
        ClubsCounter = 0
        SpadesCounter = 0
        AtouCounter = 0
        '---------------------------------------
        HCS = ""
        DCS = ""
        CCS = ""
        SCS = ""
        HCSPos = -1
        DCSPos = -1
        CCSPos = -1
        SCSPos = -1
        '--------------------------------------------------
        OfferExists = False
        jand9north = False
        jand9east = False
        jand9west = False
        jand9south = False
        jor9north = False
        jor9east = False
        jor9west = False
        jor9south = False

        northhasjHearts = False
        northhas9Hearts = False
        northhasAhearts = False
        northhasjclubs = False

        northhas9clubs = False
        northhasAclubs = False
        northhasjDiamonds = False
        northhas9Diamonds = False
        northhasADiamonds = False
        northhasjSpades = False
        northhas9Spades = False
        northhasASpades = False

        northhas10Diamonds = False
        northhas10Spades = False
        northhas10Clubs = False
        northhas10Hearts = False


        easthasjHearts = False
        easthas9Hearts = False
        easthasAhearts = False
        easthasjclubs = False
        easthas9clubs = False
        easthasAclubs = False

        easthasjDiamonds = False
        easthas9Diamonds = False
        easthasADiamonds = False
        easthasjSpades = False
        easthas9Spades = False
        easthasASpades = False
        easthas10Diamonds = False
        easthas10Spades = False
        easthas10Clubs = False
        easthas10Hearts = False


        westhasjHearts = False
        westhas9Hearts = False
        westhasAhearts = False
        westhasjclubs = False
        westhas9clubs = False
        westhasAclubs = False

        westhasjDiamonds = False
        westhas9Diamonds = False
        westhasADiamonds = False
        westhasjSpades = False
        westhas9Spades = False
        westhasASpades = False

        westhas10Diamonds = False
        westhas10Spades = False
        westhas10Clubs = False
        westhas10Hearts = False


        southhasjHearts = False
        southhas9Hearts = False
        southhasAhearts = False
        southhasjclubs = False
        southhas9clubs = False
        southhasAclubs = False

        southhasjDiamonds = False
        southhas9Diamonds = False
        southhasADiamonds = False
        southhasjSpades = False
        southhas9Spades = False
        southhasASpades = False

        southhas10Diamonds = False
        southhas10Spades = False
        southhas10Clubs = False
        southhas10Hearts = False

        NorthOffered = ""
        SouthOffered = ""
        EastOffered = ""
        WestOffered = ""
        northoffer = ""
        southoffer = ""
        eastoffer = ""
        westoffer = ""

        NorthHas4 = False
        EastHas4 = False
        SouthHas4 = False
        WestHas4 = False
        NorthHasThird = False
        NorthHasForth = False
        NorthHasFifth = False
        EastHasThird = False
        SouthHasThird = False
        WestHasThird = False
        EastHasForth = False
        SouthHasForth = False
        WestHasForth = False
        EastHasFifth = False
        SouthHasFifth = False
        WestHasFifth = False
        NorthHasBelotte = False
        EastHasBelotte = False
        SouthHasBelotte = False
        WestHasBelotte = False

        ClickCounter = 0

        HorBought = False
        VerBought = False

        DeclarationsNorth.Text = ""
        DeclarationsEast.Text = ""
        DeclarationsSouth.Text = ""
        DeclarationsWest.Text = ""


        Cards = RandomizeNumbers()



        Cards.Sort(Cards, 0, 8)
        Cards.Sort(Cards, 8, 8)
        Cards.Sort(Cards, 16, 8)
        Cards.Sort(Cards, 24, 8)





        For i = 0 To 31
            If Cards(i) = 4 Or Cards(i) = 12 Or Cards(i) = 20 Or Cards(i) = 28 Then
                CardPoints(i) = 10
            ElseIf Cards(i) = 5 Or Cards(i) = 13 Or Cards(i) = 21 Or Cards(i) = 29 Then
                CardPoints(i) = 2
            ElseIf Cards(i) = 6 Or Cards(i) = 14 Or Cards(i) = 22 Or Cards(i) = 30 Then
                CardPoints(i) = 3
            ElseIf Cards(i) = 7 Or Cards(i) = 15 Or Cards(i) = 23 Or Cards(i) = 31 Then
                CardPoints(i) = 4
            ElseIf Cards(i) = 8 Or Cards(i) = 16 Or Cards(i) = 24 Or Cards(i) = 32 Then
                CardPoints(i) = 11
            ElseIf Cards(i) = 3 Or Cards(i) = 11 Or Cards(i) = 19 Or Cards(i) = 27 Then
                CardPoints(i) = 0.03
            ElseIf Cards(i) = 2 Or Cards(i) = 10 Or Cards(i) = 18 Or Cards(i) = 26 Then
                CardPoints(i) = 0.02
            ElseIf Cards(i) = 1 Or Cards(i) = 9 Or Cards(i) = 17 Or Cards(i) = 25 Then
                CardPoints(i) = 0.01

            End If
        Next i
        For i = 0 To 31
            For j = 1 To 8
                If Cards(i) = j Then
                    CardSuite(i) = "Hearts"
                End If
            Next
            For j = 9 To 16
                If Cards(i) = j Then
                    CardSuite(i) = "Diamonds"
                End If
            Next
            For j = 17 To 24
                If Cards(i) = j Then
                    CardSuite(i) = "Clubs"
                End If
            Next
            For j = 25 To 32
                If Cards(i) = j Then
                    CardSuite(i) = "Spades"
                End If
            Next
        Next

       

        For i = 0 To 31
            Select Case Cards(i)
                Case 1
                    CardName(i) = "7 Hearts"
                Case 2
                    CardName(i) = "8 Hearts"
                Case 3
                    CardName(i) = "9 Hearts"
                Case 4
                    CardName(i) = "10 Hearts"
                Case 5
                    CardName(i) = "J Hearts"
                Case 6
                    CardName(i) = "Q Hearts"
                Case 7
                    CardName(i) = "K Hearts"
                Case 8
                    CardName(i) = "A Hearts"
                Case 9
                    CardName(i) = "7 Diamonds"
                Case 10
                    CardName(i) = "8 Diamonds"
                Case 11
                    CardName(i) = "9 Diamonds"
                Case 12
                    CardName(i) = "10 Diamonds"
                Case 13
                    CardName(i) = "J Diamonds"
                Case 14
                    CardName(i) = "Q Diamonds"
                Case 15
                    CardName(i) = "K Diamonds"
                Case 16
                    CardName(i) = "A Diamonds"
                Case 17
                    CardName(i) = "7 Clubs"
                Case 18
                    CardName(i) = "8 Clubs"
                Case 19
                    CardName(i) = "9 Clubs"
                Case 20
                    CardName(i) = "10 Clubs"
                Case 21
                    CardName(i) = "J Clubs"
                Case 22
                    CardName(i) = "Q Clubs"
                Case 23
                    CardName(i) = "K Clubs"
                Case 24
                    CardName(i) = "A Clubs"
                Case 25
                    CardName(i) = "7 Spades"
                Case 26
                    CardName(i) = "8 Spades"
                Case 27
                    CardName(i) = "9 Spades"
                Case 28
                    CardName(i) = "10 Spades"
                Case 29
                    CardName(i) = "J Spades"
                Case 30
                    CardName(i) = "Q Spades"
                Case 31
                    CardName(i) = "K Spades"
                Case 32
                    CardName(i) = "A Spades"

            End Select
        Next




        For i = 7 To 0 Step -1

            DataForm.NorthPlayerCards.Items.Add(CardName(i) & " " & CardPoints(i))

            Xartia(i) = New PictureBox
            NorthPlCards(i) = Image.FromFile("C:\cards-classic\" & Cards(i) & ".GIF")

            Xartia(i).Image = NorthPlCards(i)
            Me.Controls.Add(Xartia(i))
            Xartia(i).SetBounds(30 * (i + 15), 10, 72, 96)
            Xartia(i).Tag = CardPoints(i)
            Xartia(i).Text = CardSuite(i)


            AddHandler Xartia(i).Click, AddressOf HitMeNorth

        Next i


        For i = 15 To 8 Step -1

            DataForm.EastPlayerCards.Items.Add(CardName(i))
            Xartia(i) = New PictureBox
            EastPlCards(i - 8) = Image.FromFile("C:\cards-classic\" & Cards(i) & ".GIF")
            If Players.OnePl Then
                PicBackBox(i) = New PictureBox
                PicBackBox(i).Image = Image.FromFile("C:\cards-classic\" & DeckForm.Back & ".GIF")
                PicBackBox(i).SetBounds(30 * (i + 20), 210, 72, 96)
                PicBackBox(i).Enabled = False
                Me.Controls.Add(PicBackBox(i))
            End If
            Xartia(i).Image = EastPlCards(i - 8)
            Me.Controls.Add(Xartia(i))
            Xartia(i).SetBounds(30 * (i + 20), 210, 72, 96)
            Xartia(i).Tag = CardPoints(i)
            Xartia(i).Text = CardSuite(i)

            AddHandler Xartia(i).Click, AddressOf HitMeEast
        Next i






        For i = 23 To 16 Step -1

            DataForm.SouthPlayerCards.Items.Add(CardName(i))
            Xartia(i) = New PictureBox
            SouthPlCards(i - 16) = Image.FromFile("C:\cards-classic\" & Cards(i) & ".GIF")
            If Players.OnePl Then
                PicBackBox(i) = New PictureBox
                PicBackBox(i).Image = Image.FromFile("C:\cards-classic\" & DeckForm.Back & ".GIF")
                PicBackBox(i).SetBounds(30 * (i - 1), 410, 72, 96)
                PicBackBox(i).Enabled = False
                Me.Controls.Add(PicBackBox(i))
            End If
            Xartia(i).Image = SouthPlCards(i - 16)
            Me.Controls.Add(Xartia(i))
            Xartia(i).SetBounds(30 * (i - 1), 410, 72, 96)
            Xartia(i).Tag = CardPoints(i)
            Xartia(i).Text = CardSuite(i)

            AddHandler Xartia(i).Click, AddressOf HitMeSouth
        Next i

        For i = 31 To 24 Step -1

            DataForm.WestPlayerCards.Items.Add(CardName(i))
            Xartia(i) = New PictureBox
            WestPlCards(i - 24) = Image.FromFile("C:\cards-classic\" & Cards(i) & ".GIF")
            If Players.OnePl Then
                PicBackBox(i) = New PictureBox
                PicBackBox(i).Image = Image.FromFile("C:\cards-classic\" & DeckForm.Back & ".GIF")
                PicBackBox(i).SetBounds(30 * (i - 22), 210, 72, 96)
                PicBackBox(i).Enabled = False
                Me.Controls.Add(PicBackBox(i))
            End If
            Xartia(i).Image = WestPlCards(i - 24)
            Me.Controls.Add(Xartia(i))
            Xartia(i).SetBounds(30 * (i - 22), 210, 72, 96)
            Xartia(i).Tag = CardPoints(i)
            Xartia(i).Text = CardSuite(i)

            AddHandler Xartia(i).Click, AddressOf HitMeWest
        Next i

        'If FourofAKindCheck(0) Then
        '  NorthHas4 = True
        ' DeclarationsNorth.Text = "Kare"
        ' ShowFourOfAKind(0, 15, 0)
        ' End If
        'If FourofAKindCheck(8) Then
        ' EastHas4 = True
        ' DeclarationsEast.Text = "Kare"
        'ShowFourOfAKind(8, 20, 200)
        ' End If
        '  If FourofAKindCheck(16) Then
        'SouthHas4 = True
        ' DeclarationsSouth.Text = "Kare"
        ' ShowFourOfAKind(16, -1, 400)
        ' End If

        'If FourofAKindCheck(24) Then
        'WestHas4 = True
        ' DeclarationsWest.Text = "Kare"
        ' ShowFourOfAKind(24, -22, 200)
        ' End If


        For i = 0 To 31
            If Xartia(i).Enabled Then
                Xartia(i).Cursor = System.Windows.Forms.Cursors.Hand
            End If

        Next

        OverPoints(0, 5, DeclarationsNorth, "North")
        OverPoints(8, 13, DeclarationsEast, "East")
        OverPoints(16, 21, DeclarationsSouth, "South")
        OverPoints(24, 29, DeclarationsWest, "West")



      

        For i = 0 To 7
            If Cards(i) = 3 Then
                northhas9Hearts = True
            End If
            If Cards(i) = 4 Then
                northhas10Hearts = True
            End If
            If Cards(i) = 5 Then
                northhasjHearts = True
            End If
            If Cards(i) = 8 Then
                northhasAhearts = True
            End If
            If Cards(i) = 11 Then
                northhas9Diamonds = True
            End If
            If Cards(i) = 12 Then
                northhas10Diamonds = True
            End If
            If Cards(i) = 13 Then
                northhasjDiamonds = True
            End If
            If Cards(i) = 16 Then
                northhasADiamonds = True
            End If
            If Cards(i) = 19 Then
                northhas9clubs = True
            End If
            If Cards(i) = 20 Then
                northhas10Clubs = True
            End If
            If Cards(i) = 21 Then
                northhasjclubs = True
            End If
            If Cards(i) = 24 Then
                northhasAclubs = True
            End If
            If Cards(i) = 27 Then
                northhas9Spades = True
            End If
            If Cards(i) = 28 Then
                northhas10Spades = True
            End If
            If Cards(i) = 29 Then
                northhasjSpades = True
            End If
            If Cards(i) = 32 Then
                northhasASpades = True
            End If

            If Cards(i) < 9 Then
                northHeartscounter = northHeartscounter + 1

            End If
            If Cards(i) < 17 And Cards(i) > 8 Then
                northDiamondscounter = northDiamondscounter + 1

            End If
            If Cards(i) < 25 And Cards(i) > 16 Then
                northClubscounter = northClubscounter + 1

            End If
            If Cards(i) > 24 Then
                northSpadescounter = northSpadescounter + 1
            End If
        Next
        For i = 8 To 15
            If Cards(i) = 3 Then
                easthas9Hearts = True
            End If
            If Cards(i) = 4 Then
                easthas10Hearts = True
            End If
            If Cards(i) = 5 Then
                easthasjHearts = True
            End If
            If Cards(i) = 8 Then
                easthasAhearts = True
            End If
            If Cards(i) = 11 Then
                easthas9Diamonds = True
            End If
            If Cards(i) = 12 Then
                easthas10Diamonds = True
            End If
            If Cards(i) = 13 Then
                easthasjDiamonds = True
            End If
            If Cards(i) = 16 Then
                easthasADiamonds = True
            End If
            If Cards(i) = 19 Then
                easthas9clubs = True
            End If
            If Cards(i) = 20 Then
                easthas10Clubs = True
            End If
            If Cards(i) = 21 Then
                easthasjclubs = True
            End If
            If Cards(i) = 24 Then
                easthasAclubs = True
            End If
            If Cards(i) = 27 Then
                easthas9Spades = True
            End If
            If Cards(i) = 28 Then
                easthas10Spades = True
            End If
            If Cards(i) = 29 Then
                easthasjSpades = True
            End If
            If Cards(i) = 32 Then
                easthasASpades = True
            End If
            If Cards(i) < 9 Then
                eastHeartscounter = eastHeartscounter + 1

            End If
            If Cards(i) < 17 And Cards(i) > 8 Then
                eastDiamondscounter = eastDiamondscounter + 1

            End If
            If Cards(i) < 25 And Cards(i) > 16 Then
                eastClubscounter = eastClubscounter + 1

            End If
            If Cards(i) > 24 Then
                eastSpadescounter = eastSpadescounter + 1
            End If
        Next
        For i = 16 To 23
            If Cards(i) = 3 Then
                southhas9Hearts = True
            End If
            If Cards(i) = 4 Then
                southhas10Hearts = True
            End If
            If Cards(i) = 5 Then
                southhasjHearts = True
            End If
            If Cards(i) = 8 Then
                southhasAhearts = True
            End If
            If Cards(i) = 11 Then
                southhas9Diamonds = True
            End If
            If Cards(i) = 12 Then
                southhas10Diamonds = True
            End If
            If Cards(i) = 13 Then
                southhasjDiamonds = True
            End If
            If Cards(i) = 16 Then
                southhasADiamonds = True
            End If
            If Cards(i) = 19 Then
                southhas9clubs = True
            End If
            If Cards(i) = 20 Then
                southhas10Clubs = True
            End If
            If Cards(i) = 21 Then
                southhasjclubs = True
            End If
            If Cards(i) = 24 Then
                southhasAclubs = True
            End If
            If Cards(i) = 27 Then
                southhas9Spades = True
            End If
            If Cards(i) = 28 Then
                southhas10Spades = True
            End If
            If Cards(i) = 29 Then
                southhasjSpades = True
            End If
            If Cards(i) = 32 Then
                southhasASpades = True
            End If
            If Cards(i) < 9 Then
                southHeartscounter = southHeartscounter + 1

            End If
            If Cards(i) < 17 And Cards(i) > 8 Then
                southDiamondscounter = southDiamondscounter + 1

            End If
            If Cards(i) < 25 And Cards(i) > 16 Then
                southClubscounter = southClubscounter + 1

            End If
            If Cards(i) > 24 Then
                southSpadescounter = southSpadescounter + 1
            End If
        Next
        For i = 24 To 31
            If Cards(i) = 3 Then
                westhas9Hearts = True
            End If
            If Cards(i) = 4 Then
                westhas10Hearts = True
            End If
            If Cards(i) = 5 Then
                westhasjHearts = True
            End If
            If Cards(i) = 8 Then
                westhasAhearts = True
            End If
            If Cards(i) = 11 Then
                westhas9Diamonds = True
            End If
            If Cards(i) = 12 Then
                westhas10Diamonds = True
            End If
            If Cards(i) = 13 Then
                westhasjDiamonds = True
            End If
            If Cards(i) = 16 Then
                westhasADiamonds = True
            End If
            If Cards(i) = 19 Then
                westhas9clubs = True
            End If
            If Cards(i) = 20 Then
                westhas10Clubs = True
            End If
            If Cards(i) = 21 Then
                westhasjclubs = True
            End If
            If Cards(i) = 24 Then
                westhasAclubs = True
            End If
            If Cards(i) = 27 Then
                westhas9Spades = True
            End If
            If Cards(i) = 28 Then
                westhas10Spades = True
            End If
            If Cards(i) = 29 Then
                westhasjSpades = True
            End If
            If Cards(i) = 32 Then
                westhasASpades = True
            End If
            If Cards(i) < 9 Then
                westHeartscounter = westHeartscounter + 1

            End If
            If Cards(i) < 17 And Cards(i) > 8 Then
                westDiamondscounter = westDiamondscounter + 1

            End If
            If Cards(i) < 25 And Cards(i) > 16 Then
                westClubscounter = westClubscounter + 1

            End If
            If Cards(i) > 24 Then
                westSpadescounter = westSpadescounter + 1
            End If
        Next
        PassCounter = 0
        offercounter = 0

    End Sub
    Dim counter As Integer



    Dim PointBox, SuitBox As GroupBox
    Dim PointButtons(36), SuitButtons(4) As RadioButton
    Dim SuitArray(4) As String


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Players.Visible = True Then
            Me.Enabled = False
        End If
        Players.Show()
        ClearRound_Button.Enabled = False

        Dim Cards(32), i, Points As Integer


        '------------------------------------------
        PointBox = New GroupBox
        PointBox.Text() = "Select Points"
        Me.Controls.Add(PointBox)
        PointBox.SetBounds(200, 320, 200, 568)
        '-------------------------------------------
        SuitBox = New GroupBox
        SuitBox.Text() = "Select Suit"
        Me.Controls.Add(SuitBox)
        SuitBox.SetBounds(32, 320, 155, 120)

        '-------------------------------------------
        For i = 1 To 18
            Points = 70 + i * 10
            PointButtons(i) = New RadioButton                       'Η πρώτη στήλη στο κουτί με τους  
            PointButtons(i).Text = Points                           'πόντους(για αυτό το i παίρνει τιμές από 
            PointBox.Controls.Add(PointButtons(i))                  '1 έως 18.
            PointButtons(i).SetBounds(10, 30 * i - 10, 50, 30)
        Next
        For i = 19 To 35
            Points = 70 + i * 10
            PointButtons(i) = New RadioButton                       'Η δεύτερη στήλη στο κουτί με τους  
            PointButtons(i).Text = Points                           'πόντους(για αυτό το i παίρνει τιμές από 
            PointBox.Controls.Add(PointButtons(i))                  '19 έως 35.
            PointButtons(i).SetBounds(100, 30 * (i - 18) - 10, 50, 30)
        Next
        PointButtons(36) = New RadioButton
        PointButtons(36).Text = "Pass"                              'Το τελευταίο κουμπί για πάσο 
        PointBox.Controls.Add(PointButtons(36))
        PointButtons(36).SetBounds(100, 530, 50, 30)

        '--------------------------------------------------------
        SuitArray(0) = "Hearts"             'Γράφω σε πίνακα τις τιμές των φυλών για να μπορώ να τις
        SuitArray(1) = "Diamonds"           'επεξεργάζομαι πιο εύκολα παίρνοντάς τες από θέση πίνακα
        SuitArray(2) = "Clubs"              'σειριακά και φορτώνοντάς τες στη φόρμα στην ιδιότητα 
        SuitArray(3) = "Spades"             'text των κουμπιών του κουτιού SuitBox.
        For i = 0 To 3
            SuitButtons(i) = New RadioButton
            SuitButtons(i).Text = SuitArray(i)
            SuitBox.Controls.Add(SuitButtons(i))
            SuitButtons(i).SetBounds(10, 20 * (i + 1), 100, 30)
        Next
        '--------------------------------------------------------

    End Sub
    Dim PointsCompareArray(3) As Double
    Dim SuiteCompare(3) As String
    Dim CardsPlayed(3) As PictureBox
    Dim index As Integer
    Dim HorizontalTeamPoints, VerticalTeamPoints As Integer

    Sub PointsCompare()
        Dim j, i, m As Integer
        Dim KoziPointsCompare(3), SameSuitPointsCompareArray(3) As Double
        Dim max1, max2 As Double
        Dim KoziExists As Boolean

       


        For i = 0 To 3
            If SuiteCompare(i) = Offer.Suite Then
                KoziPointsCompare(i) = PointsCompareArray(i)
                KoziExists = True
            End If
        Next

        If KoziExists Then
            max2 = KoziPointsCompare(0)
            index = 0  'Η index δεν είναι τοπική μεταβλητή, κρατά την τιμή 0-3 αναλόγως με το ποιος κέρδισε την τελευταία 
            For i = 1 To 3 'παρτίδα.Επειδή όμως κρατούσε την τιμή της από τον προηγούμενο νικητή, έπρεπε να την αρχικοποιώ με 0 
                If KoziPointsCompare(i) > max2 Then 'αφού γίνουν πρώτα οι απαραίτητοι έλεγχοι σχετικά με το ποιο θα είναι το καινούριο
                    max2 = KoziPointsCompare(i)     'χαρτί που θα παιχτεί από τον προηγούμενο νικητή.    
                    index = i                     'Η index παίρνει τιμή 0 - 3 αναλόγως με το ποιος κέρδισε
                    'Εχει default 0 , γι αυτό δεν το θέτω εκτός του IF

                End If
            Next

        End If

        If Not KoziExists Then
            For i = 0 To 3
                If SuiteCompare(index) = SuiteCompare(i) Then
                    SameSuitPointsCompareArray(i) = PointsCompareArray(i)
                End If
            Next
            max1 = SameSuitPointsCompareArray(0)
            index = 0
            For i = 1 To 3
                If SameSuitPointsCompareArray(i) > max1 Then
                    max1 = SameSuitPointsCompareArray(i)
                    index = i
                End If

            Next

        End If
        

        Select Case index
            Case 0
                For i = 0 To 7
                    Xartia(i).Enabled = True
                Next
                For i = 8 To 31
                    Xartia(i).Enabled = False
                Next
                For m = 0 To 3
                    VerticalTeamPoints = PointsCompareArray(m) + VerticalTeamPoints
                Next m
            Case 1
                For i = 8 To 15
                    Xartia(i).Enabled = True
                Next
                For i = 0 To 7
                    Xartia(i).Enabled = False
                Next
                For i = 16 To 31
                    Xartia(i).Enabled = False
                Next
                For m = 0 To 3
                    HorizontalTeamPoints = PointsCompareArray(m) + HorizontalTeamPoints
                Next m
            Case 2
                For i = 16 To 23
                    Xartia(i).Enabled = True
                Next
                For i = 0 To 15
                    Xartia(i).Enabled = False
                Next
                For i = 24 To 31
                    Xartia(i).Enabled = False
                Next
                For m = 0 To 3
                    VerticalTeamPoints = PointsCompareArray(m) + VerticalTeamPoints
                Next m
            Case 3
                For i = 24 To 31
                    Xartia(i).Enabled = True
                Next
                For i = 0 To 23
                    Xartia(i).Enabled = False
                Next
                For m = 0 To 3
                    HorizontalTeamPoints = PointsCompareArray(m) + HorizontalTeamPoints
                Next m
        End Select
        HorizontalPoints.Text = HorizontalTeamPoints
        VerticalPoints.Text = VerticalTeamPoints

        LastRoundPoints()


        Txt1.Text = SuiteCompare(0)
    End Sub
    Dim TeamWon1, TeamWon2 As Label
    Sub RoundCollector()
        Dim i As Integer

        TeamWon1 = New Label
        TeamWon1.Text = "Vertical Team Won Cards"
        TeamWon1.ForeColor = Color.White
        TeamWon1.Font.Size.Equals(12)
        TeamWon1.Font.Name.Equals("Verdana")
        TeamWon1.SetBounds(960, 10, 100, 40)
        TeamWon2 = New Label
        TeamWon2.Text = "Horizontal Team Won Cards"
        TeamWon2.ForeColor = Color.Cyan
        TeamWon2.SetBounds(950, 340, 100, 40)
        TeamWon2.Font.Size.Equals(12)
        TeamWon2.Font.Name.Equals("Verdana")

        Me.Controls.Add(TeamWon1)
        Me.Controls.Add(TeamWon2)
        Select Case index
            Case 0
                For i = 0 To 3
                    CardsPlayed(i).SetBounds(960, 40, 72, 96)
                    CardsPlayed(i).Image = Image.FromFile("C:\cards-classic\" & DeckForm.Back & ".GIF")
                Next
            Case 1
                For i = 0 To 3
                    CardsPlayed(i).SetBounds(950, 370, 72, 96)
                    CardsPlayed(i).Image = Image.FromFile("C:\cards-classic\" & DeckForm.Back & ".GIF")
                Next i
            Case 2
                For i = 0 To 3
                    CardsPlayed(i).SetBounds(960, 40, 72, 96)
                    CardsPlayed(i).Image = Image.FromFile("C:\cards-classic\" & DeckForm.Back & ".GIF")
                Next
            Case 3
                For i = 0 To 3
                    CardsPlayed(i).SetBounds(950, 370, 72, 96)
                    CardsPlayed(i).Image = Image.FromFile("C:\cards-classic\" & DeckForm.Back & ".GIF")
                Next
        End Select

    End Sub
    Dim Clicked(32) As Boolean 'Μεταβλητή που χρησιμοποέίται για να μην πατιέται ξανά κάποιο χαρτί που έχει ήδη παιχτεί
    Public ClickCounter As Integer

    Dim HeartsPlayed(7), DiamondsPlayed(7), ClubsPlayed(7), SpadesPlayed(7) As Boolean
    Dim s As PictureBox 'Σε κάθε HitMe γίνεατι το sender, η παράμετρος που έχουν για το PictureBox που παίζεται.

    'Αυτές είναι λογικές μεταβλητές για το ποιο χαρτί παίκτηκε
    Public Shared TenHearts, AHearts, KHearts, QHearts, JHearts, NineHearts, EightHearts, SevenHearts As Boolean
    Sub HeartPlayed()
        Select Case s.Tag
            Case 10
                TenHearts = True
            Case 11
                AHearts = True
            Case 4
                KHearts = True
            Case 3
                QHearts = True
            Case 2
                JHearts = True
            Case 20
                JHearts = True
            Case 14
                NineHearts = True
            Case 0.03
                NineHearts = True
            Case 0.02
                EightHearts = True
            Case 0.01
                SevenHearts = True
        End Select
    End Sub
    'Αυτές είναι λογικές μεταβλητές για το ποιο χαρτί παίκτηκε
    Public Shared ADiamonds, TenDiamonds, KDiamonds, QDiamonds, JDiamonds, NineDiamonds, EightDiamonds, SevenDiamonds As Boolean
    Sub DiamondPlayed()
        Select Case s.Tag
            Case 10
                TenDiamonds = True
            Case 11
                ADiamonds = True
            Case 4
                KDiamonds = True
            Case 3
                QDiamonds = True
            Case 2
                JDiamonds = True
            Case 20
                JDiamonds = True
            Case 14
                NineDiamonds = True
            Case 0.03
                NineDiamonds = True
            Case 0.02
                EightDiamonds = True
            Case 0.01
                SevenDiamonds = True
        End Select
    End Sub

    'Αυτές είναι λογικές μεταβλητές για το ποιο χαρτί παίκτηκε
    Public Shared AClubs, TenClubs, KClubs, QClubs, JClubs, NineClubs, EightClubs, SevenClubs As Boolean
    Sub ClubPlayed()
        Select Case s.Tag
            Case 10
                TenClubs = True
            Case 11
                AClubs = True
            Case 4
                KClubs = True
            Case 3
                QClubs = True
            Case 2
                JClubs = True
            Case 20
                JClubs = True
            Case 14
                NineClubs = True
            Case 0.03
                NineClubs = True
            Case 0.02
                EightClubs = True
            Case 0.01
                SevenClubs = True
        End Select
    End Sub

    'Αυτές είναι λογικές μεταβλητές για το ποιο χαρτί παίκτηκε
    Public Shared ASpades, TenSpades, KSpades, QSpades, JSpades, NineSpades, EightSpades, SevenSpades As Boolean
    Sub SpadePlayed()
        Select Case s.Tag
            Case 10
                TenSpades = True
            Case 11
                ASpades = True
            Case 4
                KSpades = True
            Case 3
                QSpades = True
            Case 2
                JSpades = True
            Case 20
                JSpades = True
            Case 14
                NineSpades = True
            Case 0.03
                NineSpades = True
            Case 0.02
                EightSpades = True
            Case 0.01
                SevenSpades = True
        End Select
    End Sub

    Public Shared HeartsCounter, DiamondsCounter, ClubsCounter, SpadesCounter, AtouCounter As Integer
    'Οι παραπάνω μεταβλητές χρησιμοποοιούνται στις HitMe για να μετρούνται πόσα χαρτιά από την κάθε φυλή έχουν παιχτεί.
    'Αυτό θα βοηθήσει στις ορθολογικότερες αποφάσεις που θα πάρουν οι παίκτες.

    Public Sub WhichCardPlayed()

        Select Case s.Text     'Προσθέτει στον εκάστοτε counter 1 αν έχει πατηθεί χαρτί αντίστοιχης φυλής                                  
            Case "Hearts"
                HeartsCounter = HeartsCounter + 1
                HeartPlayed()
            Case "Diamonds"
                DiamondsCounter = DiamondsCounter + 1
                DiamondPlayed()
            Case "Clubs"
                ClubsCounter = ClubsCounter + 1
                ClubPlayed()
            Case "Spades"
                SpadesCounter = SpadesCounter + 1
                SpadePlayed()
        End Select

        If Offer.Suite = s.Text Then
            AtouCounter = AtouCounter + 1
        End If
    End Sub

    Public Shared HCS, DCS, CCS, SCS As String
    Dim HCSPos, DCSPos, CCSPos, SCSPos As Integer
    Sub CurrentStronger(ByVal Tribe As String)


        'Συνάρτηση η οποία επιστρέφει σε string το τρέχον δυνατότερο χαρτί κάθε φυλής
        '----------------------------------------------------------------------------
        Dim Temp As String

        Dim i, j, f, TribeCounter, Position As Integer


        Select Case Tribe
            Case "Hearts"
                TribeCounter = HeartsCounter
            Case "Diamonds"
                TribeCounter = DiamondsCounter
            Case "Clubs"
                TribeCounter = ClubsCounter
            Case "Spades"
                TribeCounter = SpadesCounter
        End Select


        Temp = "No " & Tribe & " Left!"

        If TribeCounter = 7 Then
            For f = 0 To 31
                If Xartia(f).Text = Tribe And Not Clicked(f) Then
                    Temp = CardName(f)

                    Position = f
                End If
            Next


        End If

        If TribeCounter < 7 Then
            For j = i + 1 To 31

                If Not Clicked(i) Then
                    If Xartia(i).Text = Tribe Then

                        If Not Clicked(j) Then
                            If Xartia(j).Text = Tribe Then
                                If Xartia(j).Tag > Xartia(i).Tag Then
                                    Temp = CardName(j)
                                    Position = j
                                    i = j
                                Else
                                    Temp = CardName(i)
                                    Position = i
                                End If
                            End If
                        End If
                    ElseIf Xartia(i).Text <> Tribe Then
                        i = i + 1
                    End If


                ElseIf Clicked(i) Then
                    i = i + 1
                End If
            Next
        End If




        Select Case Tribe

            Case "Hearts"
                HCS = Temp
                HCSPos = Position
            Case "Diamonds"
                DCS = Temp
                DCSPos = Position
            Case "Clubs"
                CCS = Temp
                CCSPos = Position
            Case "Spades"
                SCS = Temp
                SCSPos = Position

        End Select

    End Sub
    Public Shared NTsakaHearts, NTsakaDiamonds, NTsakaClubs, NTsakaSpades, NAllEnabled As Boolean
    Public Shared NNoH, NNoD, NNoC, NNoS, ENoH, ENoD, ENoC, ENoS, SNoH, SNoD, SNoC, SNoS, WNoH, WNoD, WNoC, WNoS As Boolean 'Otan o ekastote paiktis den exei mia fili, energopoiountai otan den exei na riksei fili pou pezetai kai eite tsaka eite rixnei o,ti allo
    Public Shared NorthHas(10), EastHas(10), SouthHas(10), WestHas(10) As String
    Private Sub HitMeNorth(ByVal sender As System.Object, ByVal e As System.EventArgs)
        s = sender
        Dim HasBigger, HasKozi, SameSuit, Tsaka As Boolean
        Dim p As Point
        Dim i, j, EnabledCounter, First, Second, Third, Forth, Fifth As Integer
        Dim img As Image
        Dim ArrayMax(3), max As Double

        p = New Point(570, 110)
        s.Location = p
        PointsCompareArray(0) = s.Tag
        SuiteCompare(0) = s.Text
        CardsPlayed(0) = s
        img = s.Image

        If Players.One Then
            EastPlay.Enabled = True
        End If

        ClickCounter = ClickCounter + 1
        Txt1.Text = ""
        Txt1.Text = ClickCounter



        For i = 0 To 7
            If img Is NorthPlCards(i) Then
                Clicked(i) = True

            End If
        Next

        Select Case s.Text
            Case "Hearts"
                northHeartscounter = northHeartscounter - 1
            Case "Diamonds"
                northDiamondscounter = northDiamondscounter - 1
            Case "Clubs"
                northClubscounter = northClubscounter - 1
            Case "Spades"
                northSpadescounter = northSpadescounter - 1
        End Select





        For i = 0 To 7
            If img Is NorthPlCards(i) Then
                If Cards(i) < 9 Then
                    HeartsPlayed(Cards(i) - 1) = True

                End If
                If Cards(i) < 17 And Cards(i) > 8 Then
                    DiamondsPlayed(Cards(i) - 9) = True

                End If
                If Cards(i) < 25 And Cards(i) > 16 Then
                    ClubsPlayed(i) = True

                End If
                If Cards(i) > 24 Then
                    SpadesPlayed(i) = True

                End If
            End If

        Next

        ' For i = 0 To 7
        'RichTextBox4.AppendText(HeartsPlayed(i))
        '        Next

        If ClickCounter = 1 Or 2 Or 3 Or 4 Then
            OverArray(0) = OverPoints(0, 5, DeclarationsNorth, "North")
            If NorthHas4 Then
                DeclarationsNorth.Text = "Kare - 100 points!!!!"
            End If
            If NorthHas4J Then
                DeclarationsNorth.Text = "Kare - 200 points!!!!!"
            End If
            If NorthHas9 Then
                DeclarationsNorth.Text = "Kare - 150 points!!!!!"
            End If
        End If


        If ClickCounter = 5 Or ClickCounter = 6 Or ClickCounter = 7 Or ClickCounter = 8 Then
            WhichDeclarationCounts("North", DeclarationsNorth)
        End If
      



        If ClickCounter = 5 Or ClickCounter = 6 Or ClickCounter = 7 Or ClickCounter = 8 Then
            For i = 0 To 7
                NorthHas(i) = ""
            Next
            If NorthHasThird = True Then
                ShowThird(0, 5, 15, 0)
                For i = 0 To 7
                    If Xartia(i).Bounds.Y = 0 And Not Clicked(i) Then
                        NorthHas(i) = CardName(i)
                    End If
                Next

            End If
            If NorthHasForth = True Then
                ShowForth(0, 5, 15, 0)
                For i = 0 To 7
                    If Xartia(i).Bounds.Y = 0 And Not Clicked(i) Then
                        NorthHas(i) = CardName(i)
                    End If
                Next
            End If
            If NorthHasFifth = True Then
                ShowFifth(0, 5, 15, 0)
                For i = 0 To 7
                    If Xartia(i).Bounds.Y = 0 And Not Clicked(i) Then
                        NorthHas(i) = CardName(i)
                    End If
                Next
            End If
            If NorthHas4 = True Then
                ShowFourOfAKind(0, 15, 0)
                For i = 0 To 7
                    If Xartia(i).Bounds.Y = 0 And Not Clicked(i) Then
                        NorthHas(i) = CardName(i)
                    End If
                Next
            End If
            If NorthHas4J = True Then
                ShowFourOfAKindJacks(0, 15, 0)
                For i = 0 To 7
                    If Xartia(i).Bounds.Y = 0 And Not Clicked(i) Then
                        NorthHas(i) = CardName(i)
                    End If
                Next
            End If
            If NorthHas9 = True Then
                ShowFourOfAKindNines(0, 15, 0)
                For i = 0 To 7
                    If Xartia(i).Bounds.Y = 0 And Not Clicked(i) Then
                        NorthHas(i) = CardName(i)
                    End If
                Next
            End If
        End If

        If ClickCounter = 9 Or ClickCounter = 10 Or ClickCounter = 11 Or ClickCounter = 12 Then
            If NorthHasThird = True Then
                HideThird(0, 5, 15, 0)
            End If
            If NorthHasForth = True Then
                HideForth(0, 5, 15, 0)
            End If
            If NorthHasFifth = True Then
                HideFifth(0, 5, 15, 0)
            End If
            If NorthHas4 Then
                'HideFourOfAKind(7, 15, 10)
            End If
            If NorthHas4J Then
                'HideFourOfAKind(7, 15, 10)
            End If
            If NorthHas9 Then
                'HideFourOfAKind(7, 15, 10)
            End If
        End If
        'If ShowThird(0, 5, 15, 0) Then
        ' HideThird(0, 5, 15, 0)
        ' End If
        ' If ShowForth(0, 5, 15, 0) Then
        'HideForth(0, 5, 15, 0)
        'End If
        'If ShowFifth(0, 5, 15, 0) Then
        'HideFifth(0, 5, 15, 0)
        'End If

        For i = 0 To 7
            Xartia(i).Enabled = False   ''Οταν πατήσει ο παίκτης ένα χαρτί, τότε τα χαρτιά του απενεργοποιούνται 
        Next                            ' για να μη μπορεί να ξαναπαίξει και να παίξει ο επόμενος.


        If SuiteCompare(index) = Offer.Suite Then
            For i = 8 To 15
                If Xartia(i).Text = SuiteCompare(index) And Xartia(i).Tag > PointsCompareArray(0) And Xartia(i).Tag > PointsCompareArray(1) And Xartia(i).Tag > PointsCompareArray(2) And Xartia(i).Tag > PointsCompareArray(3) And Not Clicked(i) Then
                    Xartia(i).Enabled = True
                    'Παίζεται ατού και ο επόμενος έχει μεγαλύτερο
                    HasBigger = True
                End If
            Next
        End If

        If SuiteCompare(index) = Offer.Suite And Not HasBigger Then
            For i = 8 To 15
                If Xartia(i).Text = SuiteCompare(index) And Not Clicked(i) Then
                    Xartia(i).Enabled = True
                    HasKozi = True
                End If
            Next
        End If
        If SuiteCompare(index) = Offer.Suite And Not HasBigger And Not HasKozi Then
            For i = 8 To 15
                If Not Clicked(i) Then
                    Xartia(i).Enabled = True
                End If
            Next
            EAllEnabled = True
            Select Case SuiteCompare(index)
                Case "Hearts"
                    ENoH = True
                Case "Diamonds"
                    ENoD = True
                Case "Clubs"
                    ENoC = True
                Case "Spades"
                    ENoS = True
            End Select
        End If


        If SuiteCompare(index) <> Offer.Suite Then 'Den exei riksei atou o 1os kai exei idia fili o epomenos
            For i = 8 To 15
                If SuiteCompare(index) = Xartia(i).Text And Not Clicked(i) Then
                    Xartia(i).Enabled = True
                    SameSuit = True
                End If

            Next
        End If

        For j = 0 To 3
            ArrayMax(j) = 0 'Arxikopoio ton arraymax
        Next


        If SuiteCompare(index) <> Offer.Suite And Not SameSuit Then 'an o 1os den rixnei atou alla mporei na exei tsakisei kapios meta

            For i = 8 To 15
                If Offer.Suite = Xartia(i).Text And Not Clicked(i) Then
                    Tsaka = True
                End If
            Next

            For j = 0 To 3
                If SuiteCompare(j) = Offer.Suite Then
                    ArrayMax(j) = PointsCompareArray(j)
                End If
            Next
            max = ArrayMax(0)
            For j = 1 To 3
                If ArrayMax(j) > max Then
                    max = ArrayMax(j)
                End If
            Next

            For i = 8 To 15
                If Xartia(i).Tag > max And Xartia(i).Text = Offer.Suite And Not Clicked(i) Then
                    Xartia(i).Enabled = True
                    EnabledCounter = EnabledCounter + 1
                End If
            Next

            If Tsaka Then
                Select Case SuiteCompare(index)
                    Case "Hearts"
                        ETsakaHearts = True
                        ENoH = True
                    Case "Diamonds"
                        ETsakaDiamonds = True
                        ENoD = True
                    Case "Clubs"
                        ETsakaClubs = True
                        ENoC = True

                    Case "Spades"
                        ETsakaSpades = True
                        ENoS = True

                End Select

            End If
        End If

        If EnabledCounter = 0 And Tsaka Then
            For i = 8 To 15
                If Xartia(i).Text = Offer.Suite And Not Clicked(i) Then
                    Xartia(i).Enabled = True
                End If
            Next
        End If

        If SuiteCompare(index) <> Offer.Suite And Not SameSuit And Not Tsaka Then
            EAllEnabled = True
            For i = 8 To 15
                Xartia(i).Enabled = True
            Next
            Select Case SuiteCompare(index)
                Case "Hearts"
                    ETsakaHearts = False
                    ENoH = True

                Case "Diamonds"
                    ETsakaDiamonds = False
                    ENoD = True

                Case "Clubs"
                    ETsakaClubs = False
                    ENoC = True

                Case "Spades"

                    ETsakaSpades = False
                    ENoS = True
            End Select
            Select Case Offer.Suite
                Case "Hearts"
                    ENoH = True
                Case "Diamonds"
                    ENoD = True
                Case "Clubs"
                    ENoC = True
                Case "Spades"
                    ENoS = True
            End Select
        End If



        Standar_Loses("East")

        Txt1.Text = ClickCounter

        If ClickCounter Mod 4 = 0 Then
            ClearRound_Button.Enabled = True
            HSP = StrongerPlayed("Hearts")     'otan ksekina kainourios giros, kratietai stin kathe mia metavliti
            DSP = StrongerPlayed("Diamonds")   'i thesi tou dinatoterou xartiou kathe filis kai den allazei thesi     
            CSP = StrongerPlayed("Clubs")      'para mono otan ksekinaei kaoinourios giros. Afto to kanoume gia na xrisimopoiithei
            SSP = StrongerPlayed("Spades")     'stin teammateWins. 
        End If

        If index = 2 Then
            Txt1.Text = TeamMateWins("East")
            TextBox5.Text = ""
            TextBox5.Text = "East's TeamMate"
        ElseIf index = 3 Then
            Txt1.Text = TeamMateWins("East")
            TextBox5.Text = ""
            TextBox5.Text = "East's TeamMate"
        ElseIf index = 0 Then
            Txt1.Text = TeamMateWins("East")
            TextBox5.Text = ""
            TextBox5.Text = "East's TeamMate"
        Else
            TextBox5.Text = ""
        End If


        WhichCardPlayed()
        Select Case s.Text
            Case "Hearts"
                CurrentStronger(s.Text)

            Case "Diamonds"

                CurrentStronger(s.Text)
            Case "Clubs"

                CurrentStronger(s.Text)
            Case "Spades"

                CurrentStronger(s.Text)
        End Select
        WhoHasCurrentStronger()

        '  DataForm.DiamondsComboBox.Items.Add(CurrentStronger("Diamonds"))
        '  DataForm.ClubsComboBox.Items.Add(CurrentStronger("Clubs"))
        ' DataForm.SpadesComboBox.Items.Add(CurrentStronger("Spades"))



        If AtouCounter = 8 Then
            NTsakaHearts = False
            ETsakaHearts = False
            STsakaHearts = False
            WTsakaHearts = False
            NTsakaDiamonds = False
            ETsakaDiamonds = False
            STsakaDiamonds = False
            WTsakaDiamonds = False
            NTsakaClubs = False
            ETsakaClubs = False
            STsakaClubs = False
            WTsakaClubs = False
            NTsakaSpades = False
            ETsakaSpades = False
            STsakaSpades = False
            WTsakaSpades = False
        End If


    End Sub
    Public ETsakaHearts, ETsakaDiamonds, ETsakaClubs, ETsakaSpades, EAllEnabled As Boolean
    Private Sub HitMeEast(ByVal sender As System.Object, ByVal e As System.EventArgs)
        s = sender
        Dim p As Point
        Dim img As Image
        Dim i, j, EnabledCounter, First, Second, Third, Forth, Fifth As Integer
        Dim SameSuit, Tsaka, HasBigger, HasKozi, Triti, Tetarti, Pempti As Boolean
        Dim ArrayMax(3), max As Double


        p = New Point(700, 210)
        s.Location = p
        PointsCompareArray(1) = s.Tag
        SuiteCompare(1) = s.Text
        CardsPlayed(1) = s
        img = s.Image



        ClickCounter = ClickCounter + 1
        'Txt1.Text = ""




        For i = 0 To 7
            If img Is EastPlCards(i) Then
                Clicked(i + 8) = True
            End If

        Next

        Select Case s.Text
            Case "Hearts"
                eastHeartscounter = eastHeartscounter - 1
            Case "Diamonds"
                eastDiamondscounter = eastDiamondscounter - 1
            Case "Clubs"
                eastClubscounter = eastClubscounter - 1
            Case "Spades"
                eastSpadescounter = eastSpadescounter - 1
        End Select




        If ClickCounter = 1 Or 2 Or 3 Or 4 Then
            OverArray(1) = OverPoints(8, 13, DeclarationsEast, "East")
            If EastHas4 Then
                DeclarationsEast.Text = "Kare - 100 points!!!"
            End If
            If EastHas4J Then
                DeclarationsEast.Text = "Kare - 200 points!!!!!"
            End If
            If EastHas9 Then
                DeclarationsEast.Text = "Kare - 150 points!!!!"
            End If

        End If
        If ClickCounter = 5 Or ClickCounter = 6 Or ClickCounter = 7 Or ClickCounter = 8 Then
            WhichDeclarationCounts("East", DeclarationsEast)
        End If
       



        If ClickCounter = 5 Or ClickCounter = 6 Or ClickCounter = 7 Or ClickCounter = 8 Then
            For i = 0 To 10
                EastHas(i) = ""
            Next

            If EastHasThird = True Then
                ShowThird(8, 13, 20, 200)
                For i = 8 To 15
                    If Xartia(i).Bounds.Y = 200 And Not Clicked(i) Then
                        EastHas(i - 8) = CardName(i)
                    End If
                Next
            End If
            If EastHasForth = True Then
                ShowForth(8, 13, 20, 200)
                For i = 8 To 15
                    If Xartia(i).Bounds.Y = 200 And Not Clicked(i) Then
                        EastHas(i - 8) = CardName(i)
                    End If
                Next
            End If
            If EastHasFifth = True Then
                ShowFifth(8, 13, 20, 200)
                For i = 8 To 15
                    If Xartia(i).Bounds.Y = 200 And Not Clicked(i) Then
                        EastHas(i - 8) = CardName(i)
                    End If
                Next
            End If
            If EastHas4 = True Then
                ShowFourOfAKind(8, 20, 200)
                For i = 8 To 15
                    If Xartia(i).Bounds.Y = 200 And Not Clicked(i) Then
                        EastHas(i - 8) = CardName(i)
                    End If
                Next
            End If
            If EastHas4J = True Then
                ShowFourOfAKindJacks(8, 20, 200)
                For i = 8 To 15
                    If Xartia(i).Bounds.Y = 200 And Not Clicked(i) Then
                        EastHas(i - 8) = CardName(i)
                    End If
                Next
            End If
            If EastHas9 = True Then
                ShowFourOfAKindNines(8, 20, 200)
                For i = 8 To 15
                    If Xartia(i).Bounds.Y = 200 And Not Clicked(i) Then
                        EastHas(i - 8) = CardName(i)
                    End If
                Next
            End If
        End If

        If EastHasThird = True Then
            HideThird(8, 13, 20, 200)
        End If
        If EastHasForth = True Then
            HideForth(8, 13, 20, 200)
        End If
        If EastHasFifth = True Then
            HideFifth(8, 13, 20, 200)

        End If
        If EastHas4 Then
            'HideFourOfAKind(15, 20, 210)
        End If
        If EastHas4J Then
            'HideFourOfAKind(15, 20, 210)
        End If
        If EastHas9 Then
            'HideFourOfAKind(15, 20, 210)
        End If

        ' If ShowThird(8, 13, 20, 200) Then
        ' HideThird(8, 13, 20, 200)
        ' End If
        ' If ShowForth(8, 13, 20, 200) Then
        'HideForth(8, 13, 20, 200)
        ' End If
        ' If ShowFifth(8, 13, 20, 200) Then
        'HideFifth(8, 13, 20, 200)
        ' End If


        For i = 16 To 23
            Xartia(i).Enabled = False   ''Οταν πατήσει ο παίκτης ένα χαρτί, τότε τα χαρτιά του απενεργοποιούνται 
        Next                                ' για να μη μπορεί να ξαναπαίξει και να παίξει ο επόμενος.

        If SuiteCompare(index) = Offer.Suite Then
            For i = 16 To 23
                If Xartia(i).Text = SuiteCompare(index) And Xartia(i).Tag > PointsCompareArray(0) And Xartia(i).Tag > PointsCompareArray(1) And Xartia(i).Tag > PointsCompareArray(2) And Xartia(i).Tag > PointsCompareArray(3) And Not Clicked(i) Then
                    Xartia(i).Enabled = True
                    'Παίζεται ατού και ο επόμενος έχει μεγαλύτερο
                    HasBigger = True
                End If
            Next
        End If

        If SuiteCompare(index) = Offer.Suite And Not HasBigger Then
            For i = 16 To 23
                If Xartia(i).Text = SuiteCompare(index) And Not Clicked(i) Then
                    Xartia(i).Enabled = True
                    HasKozi = True
                End If
            Next
        End If
        If SuiteCompare(index) = Offer.Suite And Not HasBigger And Not HasKozi Then
            SAllEnabled = True
            For i = 16 To 23
                If Not Clicked(i) Then
                    Xartia(i).Enabled = True
                End If
                Select Case SuiteCompare(index)
                    Case "Hearts"

                        SNoH = True

                    Case "Diamonds"

                        SNoD = True
                    Case "Clubs"

                        SNoC = True
                    Case "Spades"

                        SNoS = True
                End Select
            Next
        End If


                If SuiteCompare(index) <> Offer.Suite Then
                    For i = 16 To 23
                        If SuiteCompare(index) = Xartia(i).Text And Not Clicked(i) Then
                            Xartia(i).Enabled = True
                            SameSuit = True  '
                        End If

                    Next
                End If

                For j = 0 To 3
                    ArrayMax(j) = 0 'Arxikopoio ton arraymax
                Next

                If SuiteCompare(index) <> Offer.Suite And Not SameSuit Then

                    For i = 16 To 23
                        If Offer.Suite = Xartia(i).Text And Not Clicked(i) Then
                            Tsaka = True
                        End If
                    Next

                    For j = 0 To 3
                        If SuiteCompare(j) = Offer.Suite Then
                            ArrayMax(j) = PointsCompareArray(j)
                        End If
                    Next
                    max = ArrayMax(0)
                    For j = 1 To 3
                        If ArrayMax(j) > max Then
                            max = ArrayMax(j)
                        End If
                    Next
                    For i = 16 To 23
                        If Xartia(i).Tag > max And Xartia(i).Text = Offer.Suite And Not Clicked(i) Then
                            Xartia(i).Enabled = True
                            EnabledCounter = EnabledCounter + 1
                        End If
                    Next
                    If Tsaka Then
                        Select Case SuiteCompare(index)
                            Case "Hearts"
                                STsakaHearts = True
                                SNoH = True

                            Case "Diamonds"
                                STsakaDiamonds = True
                                SNoD = True
                            Case "Clubs"
                                STsakaClubs = True
                                SNoC = True
                            Case "Spades"
                                STsakaSpades = True
                                SNoS = True

                        End Select
                    End If
                End If

                If EnabledCounter = 0 And Tsaka Then
                    For i = 16 To 23
                        If Xartia(i).Text = Offer.Suite And Not Clicked(i) Then
                            Xartia(i).Enabled = True
                        End If
                    Next
                End If

                If SuiteCompare(index) <> Offer.Suite And Not SameSuit And Not Tsaka Then
                    SAllEnabled = True
                    For i = 16 To 23
                        Xartia(i).Enabled = True
                    Next
                    Select Case SuiteCompare(index)
                        Case "Hearts"
                            STsakaHearts = False
                            SNoH = True
                        Case "Diamonds"
                            STsakaDiamonds = False
                            SNoD = True
                        Case "Clubs"
                            STsakaClubs = False
                            SNoC = True
                        Case "Spades"
                            STsakaSpades = False
                            SNoS = True
            End Select
            Select Case Offer.Suite
                Case "Hearts"
                    SNoH = True
                Case "Diamonds"
                    SNoD = True
                Case "Clubs"
                    SNoC = True
                Case "Spades"
                    SNoS = True
            End Select
                End If



                Standar_Loses("South")

                Txt1.Text = ClickCounter
                If ClickCounter Mod 4 = 0 Then
                    ClearRound_Button.Enabled = True
                    HSP = StrongerPlayed("Hearts")
                    DSP = StrongerPlayed("Diamonds")
                    CSP = StrongerPlayed("Clubs")
                    SSP = StrongerPlayed("Spades")
                End If
                If index = 3 Then
                    Txt1.Text = TeamMateWins("South")
                    TextBox5.Text = ""
                    TextBox5.Text = "South's TeamMate"
                ElseIf index = 0 Then
                    Txt1.Text = TeamMateWins("South")
                    TextBox5.Text = ""
                    TextBox5.Text = "South's TeamMate"
                ElseIf index = 1 Then
                    Txt1.Text = TeamMateWins("South")
                    TextBox5.Text = ""
                    TextBox5.Text = "South's TeamMate"
                Else
                    TextBox5.Text = ""
                End If
                WhichCardPlayed()
                Select Case s.Text
                    Case "Hearts"

                        CurrentStronger(s.Text)

                    Case "Diamonds"

                        CurrentStronger(s.Text)
                    Case "Clubs"

                        CurrentStronger(s.Text)
                    Case "Spades"

                        CurrentStronger(s.Text)
                End Select
                WhoHasCurrentStronger() 'Πρέπει να καλείται κάτω από την CurrentStronger()



                If AtouCounter = 8 Then
                    NTsakaHearts = False
                    ETsakaHearts = False
                    STsakaHearts = False
                    WTsakaHearts = False
                    NTsakaDiamonds = False
                    ETsakaDiamonds = False
                    STsakaDiamonds = False
                    WTsakaDiamonds = False
                    NTsakaClubs = False
                    ETsakaClubs = False
                    STsakaClubs = False
                    WTsakaClubs = False
                    NTsakaSpades = False
                    ETsakaSpades = False
                    STsakaSpades = False
                    WTsakaSpades = False
                End If

    End Sub
    Public STsakaHearts, STsakaDiamonds, STsakaClubs, STsakaSpades, SAllEnabled As Boolean
    Private Sub HitMeSouth(ByVal sender As System.Object, ByVal e As System.EventArgs)
        s = sender
        Dim p As Point
        Dim img As Image
        Dim i, j, EnabledCounter, SameSuitCounter, KoziCounter As Integer
        Dim HasKozi, SameSuit, Tsaka, HasBigger, Triti, Tetarti, Pempti As Boolean
        Dim ArrayMax(3), max As Double

        p = New Point(570, 310)
        s.Location = p
        PointsCompareArray(2) = s.Tag
        SuiteCompare(2) = s.Text
        CardsPlayed(2) = s
        img = s.Image

        ClickCounter = ClickCounter + 1
        Txt1.Text = ""
        Txt1.Text = ClickCounter



        Select Case s.Text
            Case "Hearts"
                southHeartscounter = southHeartscounter - 1
            Case "Diamonds"
                southDiamondscounter = southDiamondscounter - 1
            Case "Clubs"
                southClubscounter = southClubscounter - 1
            Case "Spades"
                southSpadescounter = southSpadescounter - 1
        End Select

        For i = 0 To 7
            If img Is SouthPlCards(i) Then
                Clicked(i + 16) = True
            End If

        Next

        If ClickCounter = 1 Or 2 Or 3 Or 4 Then
            OverArray(2) = OverPoints(16, 21, DeclarationsSouth, "South")
            If SouthHas4 Then
                DeclarationsSouth.Text = "Kare - 100 points!!!"
            End If
            If SouthHas4J Then
                DeclarationsSouth.Text = "Kare - 200 points!!!!!"
            End If
            If SouthHas9 Then
                DeclarationsSouth.Text = "Kare - 150 points!!!!"
            End If
        End If




        If ClickCounter = 5 Or ClickCounter = 6 Or ClickCounter = 7 Or ClickCounter = 8 Then
            WhichDeclarationCounts("South", DeclarationsSouth)
        End If
        

        If ClickCounter = 5 Or ClickCounter = 6 Or ClickCounter = 7 Or ClickCounter = 8 Then
            For i = 16 To 23

                SouthHas(i - 16) = ""

            Next

            If SouthHasThird = True Then
                ShowThird(16, 21, -1, 400)
                For i = 16 To 23
                    If Xartia(i).Bounds.Y = 400 And Not Clicked(i) Then
                        SouthHas(i - 16) = CardName(i)
                    End If
                Next
            End If
            If SouthHasForth = True Then
                ShowForth(16, 21, -1, 400)
                For i = 16 To 23
                    If Xartia(i).Bounds.Y = 400 And Not Clicked(i) Then
                        SouthHas(i - 16) = CardName(i)
                    End If
                Next
            End If
            If SouthHasFifth = True Then
                ShowFifth(16, 21, -1, 400)
                For i = 16 To 23
                    If Xartia(i).Bounds.Y = 400 And Not Clicked(i) Then
                        SouthHas(i - 16) = CardName(i)
                    End If
                Next

            End If
            If SouthHas4 = True Then
                ShowFourOfAKind(16, -1, 400)
                For i = 16 To 23
                    If Xartia(i).Bounds.Y = 400 And Not Clicked(i) Then
                        SouthHas(i - 16) = CardName(i)
                    End If
                Next
            End If
            If SouthHas4J = True Then
                ShowFourOfAKindJacks(16, -1, 400)
                For i = 16 To 23
                    If Xartia(i).Bounds.Y = 400 And Not Clicked(i) Then
                        SouthHas(i - 16) = CardName(i)
                    End If
                Next
            End If
            If SouthHas9 = True Then
                ShowFourOfAKindNines(16, -1, 400)
                For i = 16 To 23
                    If Xartia(i).Bounds.Y = 400 And Not Clicked(i) Then
                        SouthHas(i - 16) = CardName(i)
                    End If
                Next
            End If
        End If

        If SouthHasThird = True Then
            HideThird(16, 21, -1, 400)
        End If
        If SouthHasForth = True Then
            HideForth(16, 21, -1, 400)
        End If
        If SouthHasFifth = True Then
            HideFifth(16, 21, -1, 400)

        End If
        If SouthHas4 Then
            ' HideFourOfAKind(23, -1, 410)
        End If
        If SouthHas4J Then
            'HideFourOfAKind(23, -1, 410)
        End If
        If SouthHas9 Then
            'HideFourOfAKind(23, -1, 410)
        End If

        ' If ShowThird(16, 21, -1, 400) Then
        ' HideThird(16, 21, -1, 400)
        'End If
        'If ShowForth(16, 21, -1, 400) Then
        'HideForth(16, 21, -1, 400)
        'End If
        'If ShowFifth(16, 21, -1, 400) Then
        'HideFifth(16, 21, -1, 400)
        'End If


        For i = 16 To 23
            Xartia(i).Enabled = False   ''Οταν πατήσει ο παίκτης ένα χαρτί, τότε τα χαρτιά του απενεργοποιούνται 
        Next                            ' για να μη μπορεί να ξαναπαίξει και να παίξει ο επόμενος.

        If SuiteCompare(index) = Offer.Suite Then
            For i = 24 To 31
                If Xartia(i).Text = SuiteCompare(index) And Xartia(i).Tag > PointsCompareArray(0) And Xartia(i).Tag > PointsCompareArray(1) And Xartia(i).Tag > PointsCompareArray(2) And Xartia(i).Tag > PointsCompareArray(3) And Not Clicked(i) Then
                    Xartia(i).Enabled = True
                    'Παίζεται ατού και ο επόμενος έχει μεγαλύτερο
                    HasBigger = True
                End If
            Next
        End If

        If SuiteCompare(index) = Offer.Suite And Not HasBigger Then
            For i = 24 To 31
                If Xartia(i).Text = SuiteCompare(index) And Not Clicked(i) Then
                    Xartia(i).Enabled = True
                    HasKozi = True
                End If
            Next
            If SuiteCompare(index) = Offer.Suite And Not HasBigger And Not HasKozi Then
                WAllEnabled = True
                For i = 24 To 31
                    If Not Clicked(i) Then
                        Xartia(i).Enabled = True
                    End If
                Next
                Select Case SuiteCompare(index)
                    Case "Hearts"

                        WNoH = True
                    Case "Diamonds"

                        WNoD = True
                    Case "Clubs"

                        WNoC = True
                    Case "Spades"

                        WNoS = True
                End Select
            End If
        End If

        If SuiteCompare(index) <> Offer.Suite Then
            For i = 24 To 31
                If SuiteCompare(index) = Xartia(i).Text And Not Clicked(i) Then
                    Xartia(i).Enabled = True
                    SameSuit = True  '
                End If

            Next
        End If

        For j = 0 To 3
            ArrayMax(j) = 0 'Arxikopoio ton arraymax
        Next

        If SuiteCompare(index) <> Offer.Suite And Not SameSuit Then

            For i = 24 To 31
                If Offer.Suite = Xartia(i).Text And Not Clicked(i) Then
                    Tsaka = True
                End If
            Next

            For j = 0 To 3
                If SuiteCompare(j) = Offer.Suite Then
                    ArrayMax(j) = PointsCompareArray(j)
                End If
            Next
            max = ArrayMax(0)
            For j = 1 To 3
                If ArrayMax(j) > max Then
                    max = ArrayMax(j)
                End If
            Next
            For i = 24 To 31
                If Xartia(i).Tag > max And Xartia(i).Text = Offer.Suite And Not Clicked(i) Then
                    Xartia(i).Enabled = True
                    EnabledCounter = EnabledCounter + 1
                End If
            Next
            If Tsaka Then
                Select Case SuiteCompare(index)
                    Case "Hearts"
                        WTsakaHearts = True
                        WNoH = True
                    Case "Diamonds"
                        WTsakaDiamonds = True
                        WNoD = True
                    Case "Clubs"
                        WTsakaClubs = True
                        WNoC = True
                    Case "Spades"
                        WTsakaSpades = True
                        WNoS = True
                End Select
            End If
        End If

        If EnabledCounter = 0 And Tsaka Then
            For i = 24 To 31
                If Xartia(i).Text = Offer.Suite And Not Clicked(i) Then
                    Xartia(i).Enabled = True
                End If
            Next
        End If

        If SuiteCompare(index) <> Offer.Suite And Not SameSuit And Not Tsaka Then
            WAllEnabled = True
            For i = 24 To 31
                Xartia(i).Enabled = True
            Next
            Select Case SuiteCompare(index)
                Case "Hearts"
                    WTsakaHearts = False
                    WNoH = True
                Case "Diamonds"
                    WTsakaDiamonds = False
                    WNoD = True
                Case "Clubs"
                    WTsakaClubs = False
                    WNoC = True
                Case "Spades"
                    WTsakaSpades = False
                    WNoS = True

            End Select
            Select Case Offer.Suite
                Case "Hearts"
                    WNoH = True
                Case "Diamonds"
                    WNoD = True
                Case "Clubs"
                    WNoC = True
                Case "Spades"
                    WNoS = True
            End Select
        End If


        Standar_Loses("West")
        If ClickCounter Mod 4 = 0 Then
            ClearRound_Button.Enabled = True
            HSP = StrongerPlayed("Hearts")
            DSP = StrongerPlayed("Diamonds")
            CSP = StrongerPlayed("Clubs")
            SSP = StrongerPlayed("Spades")
        End If
        If index = 0 Then
            Txt1.Text = TeamMateWins("West")
            TextBox5.Text = ""
            TextBox5.Text = "West's TeamMate"
        ElseIf index = 1 Then
            Txt1.Text = TeamMateWins("West")
            TextBox5.Text = ""
            TextBox5.Text = "West's TeamMate"
        ElseIf index = 2 Then
            Txt1.Text = TeamMateWins("West")
            TextBox5.Text = ""
            TextBox5.Text = "West's TeamMate"
        Else
            TextBox5.Text = ""
        End If
        WhichCardPlayed()
        Select Case s.Text
            Case "Hearts"

                CurrentStronger(s.Text)

            Case "Diamonds"

                CurrentStronger(s.Text)
            Case "Clubs"

                CurrentStronger(s.Text)
            Case "Spades"

                CurrentStronger(s.Text)
        End Select

        WhoHasCurrentStronger()

        '   DataForm.DiamondsComboBox.Items.Add(CurrentStronger("Diamonds"))
        '  DataForm.ClubsComboBox.Items.Add(CurrentStronger("Clubs"))
        ' DataForm.SpadesComboBox.Items.Add(CurrentStronger("Spades"))

        If AtouCounter = 8 Then
            NTsakaHearts = False
            ETsakaHearts = False
            STsakaHearts = False
            WTsakaHearts = False
            NTsakaDiamonds = False
            ETsakaDiamonds = False
            STsakaDiamonds = False
            WTsakaDiamonds = False
            NTsakaClubs = False
            ETsakaClubs = False
            STsakaClubs = False
            WTsakaClubs = False
            NTsakaSpades = False
            ETsakaSpades = False
            STsakaSpades = False
            WTsakaSpades = False
        End If

    End Sub
    Public WTsakaHearts, WTsakaDiamonds, WTsakaClubs, WTsakaSpades, WAllEnabled As Boolean
    Private Sub HitMeWest(ByVal sender As System.Object, ByVal e As System.EventArgs)
        s = sender
        Dim p As Point
        Dim img As Image
        Dim i, j, EnabledCounter, First, Second, Third, Forth, Fifth As Integer
        Dim HasBigger, Tsaka, HasKozi, SameSuit, Triti, Tetarti, Pempti As Boolean
        Dim ArrayMax(3), max As Double

        p = New Point(440, 210)
        s.Location = p
        PointsCompareArray(3) = s.Tag
        SuiteCompare(3) = s.Text
        CardsPlayed(3) = s
        img = s.Image

        ClickCounter = ClickCounter + 1
        Txt1.Text = ""
        Txt1.Text = ClickCounter


        For i = 0 To 7
            If img Is WestPlCards(i) Then
                Clicked(i + 24) = True
            End If

            Select Case s.Text
                Case "Hearts"
                    westHeartscounter = westHeartscounter - 1
                Case "Diamonds"
                    westDiamondscounter = westDiamondscounter - 1
                Case "Clubs"
                    westClubscounter = westClubscounter - 1
                Case "Spades"
                    westSpadescounter = westSpadescounter - 1
            End Select

        Next

        If ClickCounter = 1 Or 2 Or 3 Or 4 Then
            OverArray(3) = OverPoints(24, 29, DeclarationsWest, "West")
            If WestHas4 Then
                DeclarationsWest.Text = "Kare - 100 points!!!"
            End If
            If WestHas4J Then
                DeclarationsWest.Text = "Kare - 200 points!!!!!"
            End If
            If WestHas9 Then
                DeclarationsWest.Text = "Kare - 150 points!!!!"
            End If


        End If

        If ClickCounter = 5 Or ClickCounter = 6 Or ClickCounter = 7 Or ClickCounter = 8 Then
            WhichDeclarationCounts("West", DeclarationsWest)
        End If
     
        If ClickCounter = 5 Or ClickCounter = 6 Or ClickCounter = 7 Or ClickCounter = 8 Then

            For i = 0 To 10

                WestHas(i) = ""
            Next
            If WestHasThird = True Then
                ShowThird(24, 29, -22, 200)
                For i = 24 To 31
                    If Xartia(i).Bounds.Y = 200 And Not Clicked(i) Then
                        WestHas(i - 24) = CardName(i)
                    End If
                Next
            End If
            If WestHasForth = True Then
                ShowForth(24, 29, -22, 200)
                For i = 24 To 31
                    If Xartia(i).Bounds.Y = 200 And Not Clicked(i) Then
                        WestHas(i - 24) = CardName(i)
                    End If
                Next
            End If
            If WestHasFifth = True Then
                ShowFifth(24, 29, -22, 200)
                For i = 16 To 23
                    If Xartia(i).Bounds.Y = 200 And Not Clicked(i) Then
                        WestHas(i - 24) = CardName(i)
                    End If
                Next

            End If
            If WestHas4 Then
                ShowFourOfAKind(24, -22, 200)
                For i = 16 To 23
                    If Xartia(i).Bounds.Y = 200 And Not Clicked(i) Then
                        WestHas(i - 24) = CardName(i)
                    End If
                Next
            End If
            If WestHas4J Then
                ShowFourOfAKindJacks(24, -22, 200)
                For i = 16 To 23
                    If Xartia(i).Bounds.Y = 200 And Not Clicked(i) Then
                        WestHas(i - 24) = CardName(i)
                    End If
                Next
            End If
            If WestHas9 Then
                ShowFourOfAKindNines(24, -22, 200)
                For i = 16 To 23
                    If Xartia(i).Bounds.Y = 200 And Not Clicked(i) Then
                        WestHas(i - 24) = CardName(i)
                    End If
                Next
            End If
        End If

        If WestHasThird = True Then
            HideThird(24, 29, -22, 200)
        End If
        If WestHasForth = True Then
            HideForth(24, 29, -22, 200)
        End If
        If WestHasFifth = True Then
            HideFifth(24, 29, -22, 200)

        End If
        If WestHas4 Then
            'HideFourOfAKind(31, -22, 210)
        End If
        If WestHas4J Then
            'HideFourOfAKind(31, -22, 210)
        End If
        If WestHas9 Then
            'HideFourOfAKind(31, -22, 210)
        End If
        'If ShowThird(24, 29, -22, 200) Then
        ' HideThird(24, 29, -22, 200)
        ' End If
        ' If ShowForth(24, 29, -22, 200) Then
        'HideForth(24, 29, -22, 200)
        'End If
        'If ShowFifth(24, 29, -22, 200) Then
        'HideFifth(24, 29, -22, 200)
        'End If


        For i = 24 To 31
            Xartia(i).Enabled = False   ''Οταν πατήσει ο παίκτης ένα χαρτί, τότε τα χαρτιά του απενεργοποιούνται 
        Next                            ' για να μη μπορεί να ξαναπαίξει και να παίξει ο επόμενος.

        If SuiteCompare(index) = Offer.Suite Then
            For i = 0 To 7
                If Xartia(i).Text = SuiteCompare(index) And Xartia(i).Tag > PointsCompareArray(0) And Xartia(i).Tag > PointsCompareArray(1) And Xartia(i).Tag > PointsCompareArray(2) And Xartia(i).Tag > PointsCompareArray(3) And Not Clicked(i) Then
                    Xartia(i).Enabled = True
                    'Παίζεται ατού και ο επόμενος έχει μεγαλύτερο
                    HasBigger = True
                End If
            Next
        End If

        If SuiteCompare(index) = Offer.Suite And Not HasBigger Then
            For i = 0 To 7
                If Xartia(i).Text = SuiteCompare(index) And Not Clicked(i) Then
                    Xartia(i).Enabled = True
                    HasKozi = True
                End If
            Next
        End If

        If SuiteCompare(index) = Offer.Suite And Not HasBigger And Not HasKozi Then
            NAllEnabled = True
            For i = 0 To 7
                If Not Clicked(i) Then
                    Xartia(i).Enabled = True
                End If
            Next
            Select Case SuiteCompare(index)
                Case "Hearts"

                    NNoH = True
                Case "Diamonds"

                    NNoD = True
                Case "Clubs"

                    NNoC = True
                Case "Spades"

                    NNoS = True
            End Select
        End If


        If SuiteCompare(index) <> Offer.Suite Then
            For i = 0 To 7
                If SuiteCompare(index) = Xartia(i).Text And Not Clicked(i) Then
                    Xartia(i).Enabled = True
                    SameSuit = True  '
                End If

            Next
        End If

        For j = 0 To 3
            ArrayMax(j) = 0 'Arxikopoio ton arraymax
        Next

        If SuiteCompare(index) <> Offer.Suite And Not SameSuit Then
            For i = 0 To 7
                If Offer.Suite = Xartia(i).Text And Not Clicked(i) Then
                    Tsaka = True
                End If
            Next
            For j = 0 To 3
                If SuiteCompare(j) = Offer.Suite Then
                    ArrayMax(j) = PointsCompareArray(j)
                End If
            Next
            max = ArrayMax(0)
            For j = 1 To 3
                If ArrayMax(j) > max Then
                    max = ArrayMax(j)
                End If
            Next
            For i = 0 To 7
                If Xartia(i).Tag > max And Xartia(i).Text = Offer.Suite And Not Clicked(i) Then
                    Xartia(i).Enabled = True
                    EnabledCounter = EnabledCounter + 1
                End If
            Next
            If Tsaka Then
                Select Case SuiteCompare(index)
                    Case "Hearts"
                        NTsakaHearts = True
                        NNoH = True

                    Case "Diamonds"
                        NTsakaDiamonds = True
                        NNoD = True

                    Case "Clubs"
                        NTsakaClubs = True
                        NNoC = True

                    Case "Spades"
                        NTsakaSpades = True
                        NNoS = True
                End Select
            End If
        End If

        If EnabledCounter = 0 And Tsaka Then
            For i = 0 To 7
                If Xartia(i).Text = Offer.Suite And Not Clicked(i) Then
                    Xartia(i).Enabled = True
                End If
            Next
        End If
        If SuiteCompare(index) <> Offer.Suite And Not SameSuit And Not Tsaka Then
            NAllEnabled = True
            For i = 0 To 7
                Xartia(i).Enabled = True
            Next

            Select Case SuiteCompare(index)
                Case "Hearts"
                    NTsakaHearts = False
                    NNoH = True
                Case "Diamonds"
                    NTsakaDiamonds = False
                    NNoD = True
                Case "Clubs"
                    NTsakaClubs = False
                    NNoC = True
                Case "Spades"
                    NTsakaSpades = False
                    NNoS = True
            End Select
            Select Case Offer.Suite
                Case "Hearts"
                    NNoH = True
                Case "Diamonds"
                    NNoD = True
                Case "Clubs"
                    NNoC = True
                Case "Spades"
                    NNoS = True
            End Select
        End If


        Standar_Loses("North")
        If ClickCounter Mod 4 = 0 Then
            ClearRound_Button.Enabled = True
            HSP = StrongerPlayed("Hearts")
            DSP = StrongerPlayed("Diamonds")
            CSP = StrongerPlayed("Clubs")
            SSP = StrongerPlayed("Spades")
        End If
        If index = 1 Then
            Txt1.Text = TeamMateWins("North")
            TextBox5.Text = ""
            TextBox5.Text = "North's TeamMate"
        ElseIf index = 2 Then
            Txt1.Text = TeamMateWins("North")
            TextBox5.Text = ""
            TextBox5.Text = "North's TeamMate"
        ElseIf index = 3 Then
            Txt1.Text = TeamMateWins("North")
            TextBox5.Text = ""
            TextBox5.Text = "North's TeamMate"
        Else
            TextBox5.Text = ""
        End If
        WhichCardPlayed()
        Select Case s.Text
            Case "Hearts"


                CurrentStronger(s.Text)

            Case "Diamonds"

                CurrentStronger(s.Text)
            Case "Clubs"

                CurrentStronger(s.Text)
            Case "Spades"

                CurrentStronger(s.Text)
        End Select

        WhoHasCurrentStronger()


        ' DataForm.DiamondsComboBox.Items.Add(CurrentStronger("Diamonds"))
        ' DataForm.ClubsComboBox.Items.Add(CurrentStronger("Clubs"))
        ' DataForm.SpadesComboBox.Items.Add(CurrentStronger("Spades"))



        If AtouCounter = 8 Then
            NTsakaHearts = False
            ETsakaHearts = False
            STsakaHearts = False
            WTsakaHearts = False
            NTsakaDiamonds = False
            ETsakaDiamonds = False
            STsakaDiamonds = False
            WTsakaDiamonds = False
            NTsakaClubs = False
            ETsakaClubs = False
            STsakaClubs = False
            WTsakaClubs = False
            NTsakaSpades = False
            ETsakaSpades = False
            STsakaSpades = False
            WTsakaSpades = False
        End If

    End Sub



    Private Sub OFFER_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OFFER_Button.Click
        offercounter = offercounter + 1
        AutoOfferProcedure()

      

    End Sub



    Dim WhoPlaysFirst As Integer
    Private Sub DEAL_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DEAL_Button.Click
        Dim j As Integer

        index = WhoPlaysFirst Mod 4
        PlayerPointer = index

        Deal()
        WhoPlaysFirst = WhoPlaysFirst + 1

        For j = 1 To 36
            If PointButtons(j).Enabled = False Then
                PointButtons(j).Enabled = True
            End If
        Next
        OFFER_Button.Enabled = True

        For i = 0 To 31
            Xartia(i).Enabled = False
        Next
        DEAL_Button.Enabled = False
        OFFER_Button.Enabled = True
        PlayerLabel.Text = PlayerPlays(PlayerPointer Mod 4)
        Offer.Suite = ""
        Offer.Points = 0
        PointsLabel.Text = 0
        SuitLabel.Text = ""
        offercounter = index
        i = 0
        PassCounter = 0  'Μηδενίζεται ο μετρητής αυτός γιατί υπάρχει η περίπτωση να έχοθμε 4 πάσα σε 2 διαδοχικές
    End Sub              'παρτίδες.Αν δεν μηδενιζόταν, στη δεύτερη γύρα ο μετρητής Passcounter θα γινόταν 4+4= 8!!
    Public Offer As Offered
    Sub playeroffers(ByVal x As Integer, ByVal y As Integer)

    End Sub
    Dim offercounter As Integer
    Dim northoffer, southoffer, westoffer, eastoffer As String

    Dim PlayerPlays(4) As String
    Dim PlayerPointer, PassCounter As Integer
    Dim OfferExists, jand9north, jand9east, jand9west, jand9south, jor9north, jor9east, jor9west, jor9south As Boolean
    Dim verticalheartscounter, verticaldiamondscounter, verticalspadescounter, verticalclubscounter As Integer

    Sub AutoOfferProcedure()
        Dim i, j, k As Integer


        PlayerPlays(0) = "North Offers:"        'Αρχικοποιήσαμε τις θέσεις των παικτών σε θέσεις πυξίδας για 
        PlayerPlays(1) = "East Offers:"         'καλύτερη κατανόηση.Τις βάλαμε σε πίνακα για να σαρώνονται 
        PlayerPlays(2) = "South Offers:"        'κάθε φορά που κάποιος παίκτης πατάει το κουμπί προσφοράς
        PlayerPlays(3) = "West Offers:"         'για να φαίνεται ποιος παίζει τη φορά αυτή.

        PlayerLabel.Text = PlayerPlays(PlayerPointer Mod 4)   'Η μεταβλήτή pointer είναι κάτι σαν δείκτης
        'πάνω στον πίνακα PlayerPlays και το MOD 4 
        'είναι γιατί η Pointer αυξάνεται πάνω από 4 και εμείς θέλουμε να παίρνει τιμές μόνο από 0 μέχρι 3.
        PlayerPointer = PlayerPointer + 1
        If PlayerLabel.Text = "North Offers:" Then
            NORTHOFFERS()
            If SuitLabel.Text <> "PASS" Then
                NorthOffered = SuitLabel.Text
            End If
        End If

        If PlayerLabel.Text = "South Offers:" Then
            SOUTHOFFERS()
            If SuitLabel.Text <> "PASS" Then
                SouthOffered = SuitLabel.Text
            End If
        End If

        If PlayerLabel.Text = "West Offers:" Then
            WESTOFFERS()
            If SuitLabel.Text <> "PASS" Then
                WestOffered = SuitLabel.Text
            End If
        End If

        If PlayerLabel.Text = "East Offers:" Then
            EASTOFFERS()
            If SuitLabel.Text <> "PASS" Then
                EastOffered = SuitLabel.Text
            End If
        End If


    End Sub
    Dim NorthOffered, EastOffered, SouthOffered, WestOffered As String
    Sub NORTHOFFERS()
        If offercounter = 1 Then

            If NorthHasForth Then
                Offer.Points = PointButtons(5).Text
                For i = 1 To 4
                    PointButtons(i).Enabled = False
                Next
                i = 4
            End If
            If NorthHasFifth Then

                Offer.Points = PointButtons(10).Text
                For i = 1 To 9
                    PointButtons(i).Enabled = False
                Next
                i = 9
            End If
            If NorthHas4 Then
                Offer.Points = PointButtons(3).Text
                For i = 1 To 3
                    PointButtons(i).Enabled = False
                Next
                i = 3


            End If
            If NorthHas4J Then
                Offer.Points = PointButtons(13).Text
                For i = 1 To 13
                    PointButtons(i).Enabled = False
                Next
                i = 13
            End If
            If NorthHas9 Then
                Offer.Points = PointButtons(8).Text
                For i = 1 To 8
                    PointButtons(i).Enabled = False
                Next
                i = 8


            End If
            ''''''''''' north mona i dipla
            If (northHeartscounter > 3 And (northhasjHearts = True And northhas9Hearts = True)) Then
                northoffer = "Hearts"
                Offer.Suite = "Hearts"
                SuitLabel.Text = Offer.Suite
                SuitLabel.ForeColor = Color.Red
                increaseofferpoints()
                increaseofferpoints()
                verticalheartscounter = verticalheartscounter + 2
                jand9north = True

            ElseIf (northSpadescounter > 3 And (northhasjSpades = True And northhas9Spades = True)) Then
                northoffer = "Spades"
                Offer.Suite = "Spades"
                SuitLabel.Text = Offer.Suite
                SuitLabel.ForeColor = Color.Red
                verticalspadescounter = verticalspadescounter + 2
                increaseofferpoints()
                increaseofferpoints()
                jand9north = True

            ElseIf (northClubscounter > 3 And (northhasjclubs = True And northhas9clubs = True)) Then
                northoffer = "Clubs"
                Offer.Suite = "Clubs"
                SuitLabel.Text = Offer.Suite
                SuitLabel.ForeColor = Color.Red
                increaseofferpoints()
                increaseofferpoints()
                verticalclubscounter = verticalclubscounter + 2
                jand9north = True

            ElseIf (northDiamondscounter > 3 And (northhasjDiamonds = True And northhas9Diamonds = True)) Then
                northoffer = "Diamonds"
                Offer.Suite = "Diamonds"
                SuitLabel.Text = Offer.Suite
                SuitLabel.ForeColor = Color.Red
                increaseofferpoints()
                increaseofferpoints()
                verticaldiamondscounter = verticaldiamondscounter + 2
                jand9north = True

            ElseIf (northHeartscounter > 3 And (northhasjHearts = True Or northhas9Hearts = True)) Then
                northoffer = "Hearts"
                Offer.Suite = "Hearts"
                SuitLabel.Text = Offer.Suite
                SuitLabel.ForeColor = Color.Red
                increaseofferpoints()
                verticalheartscounter = verticalheartscounter + 1

            ElseIf (northSpadescounter > 3 And (northhasjSpades = True Or northhas9Spades = True)) Then
                northoffer = "Spades"
                Offer.Suite = "Spades"
                SuitLabel.Text = Offer.Suite
                SuitLabel.ForeColor = Color.Red
                increaseofferpoints()
                verticalspadescounter = verticalspadescounter + 1

            ElseIf (northClubscounter > 3 And (northhasjclubs = True Or northhas9clubs)) Then
                northoffer = "Clubs"
                Offer.Suite = "Clubs"
                SuitLabel.Text = Offer.Suite
                SuitLabel.ForeColor = Color.Red
                increaseofferpoints()
                verticalclubscounter = verticalclubscounter + 1


            ElseIf (northDiamondscounter > 3 And (northhasjDiamonds = True Or northhas9Diamonds = True)) Then
                northoffer = "Diamonds"
                Offer.Suite = "Diamonds"
                SuitLabel.Text = Offer.Suite
                SuitLabel.ForeColor = Color.Red
                increaseofferpoints()
                verticaldiamondscounter = verticaldiamondscounter + 1

                ''''''''''''''''''
            ElseIf (northHeartscounter > 2 And (northhasjHearts = True And northhas9Hearts = True) And (northhasASpades = True Or northhasAclubs = True Or northhasADiamonds = True)) Then
                northoffer = "Hearts"
                Offer.Suite = "Hearts"
                SuitLabel.Text = Offer.Suite
                SuitLabel.ForeColor = Color.Red
                increaseofferpoints()
                increaseofferpoints()
                verticalheartscounter = verticalheartscounter + 2
                jand9north = True

            ElseIf (northSpadescounter > 2 And (northhasjSpades = True And northhas9Spades) = True And (northhasAhearts = True Or northhasAclubs = True Or northhasADiamonds = True)) Then
                northoffer = "Spades"
                Offer.Suite = "Spades"
                SuitLabel.Text = Offer.Suite
                SuitLabel.ForeColor = Color.Red
                verticalspadescounter = verticalspadescounter + 2
                increaseofferpoints()
                increaseofferpoints()
                jand9north = True

            ElseIf (northClubscounter > 2 And (northhasjclubs = True And northhas9clubs) = True And (northhasAhearts = True Or northhasASpades = True Or northhasADiamonds = True)) Then
                northoffer = "Clubs"
                Offer.Suite = "Clubs"
                SuitLabel.Text = Offer.Suite
                SuitLabel.ForeColor = Color.Red
                increaseofferpoints()
                increaseofferpoints()
                verticalclubscounter = verticalclubscounter + 2
                jand9north = True

            ElseIf (northDiamondscounter > 2 And (northhasjDiamonds = True And northhas9Diamonds) = True And (northhasAhearts = True Or northhasASpades = True Or northhasAclubs = True)) Then
                northoffer = "Diamonds"
                Offer.Suite = "Diamonds"
                SuitLabel.Text = Offer.Suite
                SuitLabel.ForeColor = Color.Red
                increaseofferpoints()
                increaseofferpoints()
                verticaldiamondscounter = verticaldiamondscounter + 2
                jand9north = True

            ElseIf (northHeartscounter > 2 And (northhasjHearts = True Or northhas9Hearts = True) And (northhasASpades = True Or northhasAclubs = True Or northhasADiamonds = True)) Then
                northoffer = "Hearts"
                Offer.Suite = "Hearts"
                SuitLabel.Text = Offer.Suite
                SuitLabel.ForeColor = Color.Red
                increaseofferpoints()
                verticalheartscounter = verticalheartscounter + 1

            ElseIf (northSpadescounter > 2 And (northhasjSpades = True Or northhas9Spades = True) And (northhasAhearts = True Or northhasAclubs = True Or northhasADiamonds = True)) Then
                northoffer = "Spades"
                Offer.Suite = "Spades"
                SuitLabel.Text = Offer.Suite
                SuitLabel.ForeColor = Color.Red
                increaseofferpoints()
                verticalspadescounter = verticalspadescounter + 1

            ElseIf (northClubscounter > 2 And (northhasjclubs = True Or northhas9clubs) = True And (northhasAhearts = True Or northhasASpades = True Or northhasADiamonds = True)) Then
                northoffer = "Clubs"
                Offer.Suite = "Clubs"
                SuitLabel.Text = Offer.Suite
                SuitLabel.ForeColor = Color.Red
                increaseofferpoints()
                verticalclubscounter = verticalclubscounter + 1


            ElseIf (northDiamondscounter > 2 And (northhasjDiamonds = True Or northhas9Diamonds = True) And (northhasAhearts = True Or northhasASpades = True Or northhasAclubs = True)) Then
                northoffer = "Diamonds"
                Offer.Suite = "Diamonds"
                SuitLabel.Text = Offer.Suite
                SuitLabel.ForeColor = Color.Red
                increaseofferpoints()
                verticaldiamondscounter = verticaldiamondscounter + 1

                '''''den isxyei o kanonas pou thesa me gia na ginei prosfora alla kanoume prosfora logo extra ponton
            ElseIf (NorthHas9 Or NorthHas4J Or NorthHas4) Then
                If (northClubscounter > 1 And (northhasjclubs = True And northhas9clubs)) Then
                    northoffer = "Clubs"
                    Offer.Suite = "Clubs"
                    SuitLabel.Text = Offer.Suite
                    SuitLabel.ForeColor = Color.Red
                    increaseofferpoints()
                    increaseofferpoints()
                    jand9north = True

                ElseIf (northClubscounter > 1 And (northhasjclubs = True Or northhas9clubs)) Then
                    northoffer = "Clubs"
                    Offer.Suite = "Clubs"
                    SuitLabel.Text = Offer.Suite
                    SuitLabel.ForeColor = Color.Red
                    increaseofferpoints()

                ElseIf (northDiamondscounter > 1 And (northhasjDiamonds = True And northhas9Diamonds)) Then
                    northoffer = "Diamonds"
                    Offer.Suite = "Diamonds"
                    SuitLabel.Text = Offer.Suite
                    SuitLabel.ForeColor = Color.Red
                    increaseofferpoints()
                    increaseofferpoints()
                    jand9north = True

                ElseIf (northDiamondscounter > 1 And (northhasjDiamonds = True Or northhas9Diamonds)) Then
                    northoffer = "Diamonds"
                    Offer.Suite = "Diamonds"
                    SuitLabel.Text = Offer.Suite
                    SuitLabel.ForeColor = Color.Red
                    increaseofferpoints()

                ElseIf (northHeartscounter > 1 And (northhasjHearts = True And northhas9Hearts)) Then
                    northoffer = "Hearts"
                    Offer.Suite = "Hearts"
                    SuitLabel.Text = Offer.Suite
                    SuitLabel.ForeColor = Color.Red
                    increaseofferpoints()
                    increaseofferpoints()
                    jand9north = True

                ElseIf (northHeartscounter > 1 And (northhasjHearts = True Or northhas9Hearts)) Then
                    northoffer = "Hearts"
                    Offer.Suite = "Hearts"
                    SuitLabel.Text = Offer.Suite
                    SuitLabel.ForeColor = Color.Red
                    increaseofferpoints()

                ElseIf (northSpadescounter > 1 And (northhasjSpades = True And northhas9Spades)) Then
                    northoffer = "Spades"
                    Offer.Suite = "Spades"
                    SuitLabel.Text = Offer.Suite
                    SuitLabel.ForeColor = Color.Red
                    increaseofferpoints()
                    increaseofferpoints()
                    jand9north = True

                ElseIf (northSpadescounter > 1 And (northhasjSpades = True Or northhas9Spades)) Then
                    northoffer = "Spades"
                    Offer.Suite = "Spades"
                    SuitLabel.Text = Offer.Suite
                    SuitLabel.ForeColor = Color.Red
                    increaseofferpoints()
                End If
            ElseIf NorthHasForth Or NorthHasFifth Then
                If northSpadescounter > 3 And (northhasjSpades = True And northhas9Spades) Then
                    northoffer = "Spades"
                    Offer.Suite = "Spades"
                    SuitLabel.Text = Offer.Suite
                    SuitLabel.ForeColor = Color.Red
                    increaseofferpoints()
                    increaseofferpoints()
                    jand9north = True
                ElseIf northSpadescounter > 3 And (northhasjSpades = True Or northhas9Spades) Then
                    northoffer = "Spades"
                    Offer.Suite = "Spades"
                    SuitLabel.Text = Offer.Suite
                    SuitLabel.ForeColor = Color.Red
                    increaseofferpoints()


                ElseIf northHeartscounter > 3 And (northhasjHearts = True And northhas9Hearts) Then
                    northoffer = "Hearts"
                    Offer.Suite = "Hearts"
                    SuitLabel.Text = Offer.Suite
                    SuitLabel.ForeColor = Color.Red
                    increaseofferpoints()
                    increaseofferpoints()
                    jand9north = True

                ElseIf northHeartscounter > 3 And (northhasjHearts = True Or northhas9Hearts) Then
                    northoffer = "Hearts"
                    Offer.Suite = "Hearts"
                    SuitLabel.Text = Offer.Suite
                    SuitLabel.ForeColor = Color.Red
                    increaseofferpoints()

                ElseIf northDiamondscounter > 3 And (northhasjDiamonds = True And northhas9Diamonds) Then
                    northoffer = "Diamonds"
                    Offer.Suite = "Diamonds"
                    SuitLabel.Text = Offer.Suite
                    SuitLabel.ForeColor = Color.Red
                    increaseofferpoints()
                    increaseofferpoints()
                    jand9north = True

                ElseIf northDiamondscounter > 3 And (northhasjDiamonds = True Or northhas9Diamonds) Then
                    northoffer = "Diamonds"
                    Offer.Suite = "Diamonds"
                    SuitLabel.Text = Offer.Suite
                    SuitLabel.ForeColor = Color.Red
                    increaseofferpoints()

                ElseIf northSpadescounter > 3 And (northhasjSpades = True And northhas9Spades) Then
                    northoffer = "Spades"
                    Offer.Suite = "Spades"
                    SuitLabel.Text = Offer.Suite
                    SuitLabel.ForeColor = Color.Red
                    increaseofferpoints()
                    increaseofferpoints()
                    jand9north = True

                ElseIf northSpadescounter > 3 And (northhasjSpades = True Or northhas9Spades) Then
                    northoffer = "Spades"
                    Offer.Suite = "Spades"
                    SuitLabel.Text = Offer.Suite
                    SuitLabel.ForeColor = Color.Red
                    increaseofferpoints()

                End If

            Else
                passoffer()

            End If

        End If

        If offercounter = 5 Then
            If (EastHas4 Or EastHasFifth Or EastHasForth Or EastHas4J Or EastHas9 Or WestHas4 Or WestHasFifth Or WestHasForth Or WestHas4J Or WestHas9) Then
                passoffer()
            Else
                '''''''''north vazei asous
                If northoffer = "Hearts" Then
                    If northhasASpades Then
                        northoffer = "Hearts"
                        Offer.Suite = "Hearts"
                        SuitLabel.Text = Offer.Suite
                        SuitLabel.ForeColor = Color.Red
                        increaseofferpoints()
                        verticalheartscounter = verticalheartscounter + 1


                    End If
                    If northhasAclubs Then
                        northoffer = "Hearts"
                        Offer.Suite = "Hearts"
                        SuitLabel.Text = Offer.Suite
                        SuitLabel.ForeColor = Color.Red
                        increaseofferpoints()
                        verticalheartscounter = verticalheartscounter + 1
                    End If
                    If northhasADiamonds Then
                        northoffer = "Hearts"
                        Offer.Suite = "Hearts"
                        SuitLabel.Text = Offer.Suite
                        SuitLabel.ForeColor = Color.Red
                        increaseofferpoints()
                        verticalheartscounter = verticalheartscounter + 1
                    End If

                ElseIf northoffer = "Spades" And (northhasAhearts Or northhasAclubs Or northhasADiamonds) Then
                    If northhasAhearts Then
                        northoffer = "Spades"
                        Offer.Suite = "Spades"
                        SuitLabel.Text = Offer.Suite
                        SuitLabel.ForeColor = Color.Red
                        increaseofferpoints()
                        verticalspadescounter = verticalspadescounter + 1
                    End If
                    If northhasAclubs Then
                        northoffer = "Spades"
                        Offer.Suite = "Spades"
                        SuitLabel.Text = Offer.Suite
                        SuitLabel.ForeColor = Color.Red
                        increaseofferpoints()
                        verticalspadescounter = verticalspadescounter + 1
                    End If
                    If northhasADiamonds Then
                        northoffer = "Spades"
                        Offer.Suite = "Spades"
                        SuitLabel.Text = Offer.Suite
                        SuitLabel.ForeColor = Color.Red
                        increaseofferpoints()
                        verticalspadescounter = verticalspadescounter + 1
                    End If
                ElseIf northoffer = "Clubs" And (northhasAhearts Or northhasASpades Or northhasADiamonds) Then
                    If northhasAhearts Then
                        northoffer = "Clubss"
                        Offer.Suite = "Clubs"
                        SuitLabel.Text = Offer.Suite
                        SuitLabel.ForeColor = Color.Red
                        increaseofferpoints()
                        verticalclubscounter = verticalclubscounter + 1
                    End If
                    If northhasADiamonds Then
                        northoffer = "Clubss"
                        Offer.Suite = "Clubs"
                        SuitLabel.Text = Offer.Suite
                        SuitLabel.ForeColor = Color.Red
                        increaseofferpoints()
                        verticalclubscounter = verticalclubscounter + 1
                    End If
                    If northhasASpades Then
                        northoffer = "Clubss"
                        Offer.Suite = "Clubs"
                        SuitLabel.Text = Offer.Suite
                        SuitLabel.ForeColor = Color.Red
                        increaseofferpoints()
                        verticalclubscounter = verticalclubscounter + 1
                    End If
                ElseIf northoffer = "Diamonds" And (northhasAhearts Or northhasAclubs Or northhasASpades) Then
                    If northhasASpades Then
                        northoffer = "Diamonds"
                        Offer.Suite = "Diamonds"
                        SuitLabel.Text = Offer.Suite
                        SuitLabel.ForeColor = Color.Red
                        increaseofferpoints()
                        verticaldiamondscounter = verticaldiamondscounter + 1
                    End If
                    If northhasAclubs Then
                        northoffer = "Diamonds"
                        Offer.Suite = "Diamonds"
                        SuitLabel.Text = Offer.Suite
                        SuitLabel.ForeColor = Color.Red
                        increaseofferpoints()
                        verticaldiamondscounter = verticaldiamondscounter + 1
                    End If
                    If northhasAhearts Then
                        northoffer = "Diamonds"
                        Offer.Suite = "Diamonds"
                        SuitLabel.Text = Offer.Suite
                        SuitLabel.ForeColor = Color.Red
                        increaseofferpoints()
                        verticaldiamondscounter = verticaldiamondscounter + 1
                    End If
                    ''''''north vazei pontous sto sin
                ElseIf southoffer = "Hearts" And (Not northoffer = "Clubs" Or Not northoffer = "Diamonds" Or Not northoffer = "Spades") And Not jor9south Then
                    If (northhasjHearts Or northhas9Hearts) And verticalheartscounter < 2 Then
                        northoffer = "Hearts"
                        Offer.Suite = "Hearts"
                        SuitLabel.Text = Offer.Suite
                        SuitLabel.ForeColor = Color.Red
                        increaseofferpoints()
                        verticalheartscounter = verticalheartscounter + 1
                        jor9north = True
                    ElseIf jand9south And (northhasASpades Or northhasADiamonds Or northhasAclubs) And verticalheartscounter = 2 Then
                        northoffer = "Hearts"
                        Offer.Suite = "Hearts"
                        SuitLabel.Text = Offer.Suite
                        SuitLabel.ForeColor = Color.Red
                        increaseofferpoints()
                        verticalheartscounter = verticalheartscounter + 1
                    Else

                        passoffer()

                    End If


                ElseIf southoffer = "Spades" And (Not northoffer = "Clubs" Or Not northoffer = "Diamonds" Or Not northoffer = "Hearts") Then
                    If northhasjSpades Or northhas9Spades And verticalspadescounter < 2 Then
                        northoffer = "Spades"
                        Offer.Suite = "Spades"
                        SuitLabel.Text = Offer.Suite
                        SuitLabel.ForeColor = Color.Red
                        increaseofferpoints()
                        verticalspadescounter = verticalspadescounter + 1
                        jor9north = True
                    ElseIf jand9south And (northhasAhearts Or northhasADiamonds Or northhasAclubs) And verticalspadescounter = 2 Then
                        northoffer = "Spades"
                        Offer.Suite = "Spades"
                        SuitLabel.Text = Offer.Suite
                        SuitLabel.ForeColor = Color.Red
                        increaseofferpoints()
                        verticalspadescounter = verticalspadescounter + 1
                    Else

                        passoffer()

                    End If
                ElseIf southoffer = "Diamonds" And (Not northoffer = "Clubs" Or Not northoffer = "Hearts" Or Not northoffer = "Spades") And Not jor9south Then
                    If northhasjDiamonds Or northhas9Diamonds And verticaldiamondscounter < 2 Then
                        northoffer = "Diamonds"
                        Offer.Suite = "Diamonds"
                        SuitLabel.Text = Offer.Suite
                        SuitLabel.ForeColor = Color.Red
                        increaseofferpoints()
                        verticaldiamondscounter = verticaldiamondscounter + 1
                        jor9north = True
                    ElseIf jand9south And (northhasASpades Or northhasAhearts Or northhasAclubs) And verticaldiamondscounter = 2 Then
                        northoffer = "Diamonds"
                        Offer.Suite = "Diamonds"
                        SuitLabel.Text = Offer.Suite
                        SuitLabel.ForeColor = Color.Red
                        increaseofferpoints()
                        verticaldiamondscounter = verticaldiamondscounter + 1
                    Else

                        passoffer()

                    End If

                ElseIf southoffer = "Clubs" And (Not northoffer = "Hearts" Or Not northoffer = "Diamonds" Or Not northoffer = "Spades") And Not jor9south Then
                    If northhasjclubs Or northhas9clubs And verticalclubscounter < 2 Then
                        northoffer = "Clubs"
                        Offer.Suite = "Clubs"
                        SuitLabel.Text = Offer.Suite
                        SuitLabel.ForeColor = Color.Red
                        increaseofferpoints()
                        jor9north = True
                        verticaldiamondscounter = verticaldiamondscounter + 1
                    ElseIf jand9south And (northhasASpades Or northhasAhearts Or northhasADiamonds) And verticalclubscounter = 2 Then
                        northoffer = "Clubs"
                        Offer.Suite = "Clubs"
                        SuitLabel.Text = Offer.Suite
                        SuitLabel.ForeColor = Color.Red
                        increaseofferpoints()
                        verticalclubscounter = verticalclubscounter + 1

                    Else

                        passoffer()
                    End If
                Else
                    passoffer()
                End If

            End If

        End If
        If offercounter = 9 Then
            If (EastHas4 Or EastHasFifth Or EastHasForth Or EastHas4J Or EastHas9 Or WestHas4 Or WestHasFifth Or WestHasForth Or WestHas4J Or WestHas9) Then
                passoffer()

            Else
                '''''''''north vazei 10
                If northoffer = "Hearts" And ((northhasASpades And northhas10Spades) Or (northhasAclubs And northhas10Clubs) Or (northhasADiamonds And northhas10Diamonds)) Then
                    northoffer = "Hearts"
                    Offer.Suite = "Hearts"
                    SuitLabel.Text = Offer.Suite
                    SuitLabel.ForeColor = Color.Red
                    increaseofferpoints()
                    verticalheartscounter = verticalheartscounter + 1

                ElseIf northoffer = "Spades" And ((northhasAhearts And northhas10Hearts) Or (northhasAclubs And northhas10Clubs) Or (northhasADiamonds And northhas10Diamonds)) Then
                    northoffer = "Spades"
                    Offer.Suite = "Spades"
                    SuitLabel.Text = Offer.Suite
                    SuitLabel.ForeColor = Color.Red
                    increaseofferpoints()
                    verticalspadescounter = verticalspadescounter + 1

                ElseIf northoffer = "Clubs" And ((northhasASpades And northhas10Spades) Or (northhasAhearts And northhas10Hearts) Or (northhasADiamonds And northhas10Diamonds)) Then
                    northoffer = "Clubss"
                    Offer.Suite = "Clubs"
                    SuitLabel.Text = Offer.Suite
                    SuitLabel.ForeColor = Color.Red
                    increaseofferpoints()
                    verticalclubscounter = verticalclubscounter + 1

                ElseIf northoffer = "Diamonds" And ((northhasASpades And northhas10Spades) Or (northhasAclubs And northhas10Clubs) Or (northhasAhearts And northhas10Hearts)) Then
                    northoffer = "Diamonds"
                    Offer.Suite = "Diamonds"
                    SuitLabel.Text = Offer.Suite
                    SuitLabel.ForeColor = Color.Red
                    increaseofferpoints()
                    verticaldiamondscounter = verticaldiamondscounter + 1


                    '''''''''''north vazei asous sto sin

                ElseIf southoffer = "Hearts" And (northhasASpades Or northhasAclubs Or northhasADiamonds) Then
                    northoffer = "Hearts"
                    Offer.Suite = "Hearts"
                    SuitLabel.Text = Offer.Suite
                    SuitLabel.ForeColor = Color.Red
                    increaseofferpoints()
                    verticalheartscounter = verticalheartscounter + 1

                ElseIf southoffer = "Spades" And (northhasAhearts Or northhasAclubs Or northhasADiamonds) Then
                    northoffer = "Spades"
                    Offer.Suite = "Spades"
                    SuitLabel.Text = Offer.Suite
                    SuitLabel.ForeColor = Color.Red
                    increaseofferpoints()
                    verticalspadescounter = verticalspadescounter + 1

                ElseIf southoffer = "Clubs" And (northhasAhearts Or northhasASpades Or northhasADiamonds) Then
                    northoffer = "Clubss"
                    Offer.Suite = "Clubs"
                    SuitLabel.Text = Offer.Suite
                    SuitLabel.ForeColor = Color.Red
                    increaseofferpoints()
                    verticalclubscounter = verticalclubscounter + 1

                ElseIf southoffer = "Diamonds" And (northhasAhearts Or northhasAclubs Or northhasASpades) Then
                    northoffer = "Diamonds"
                    Offer.Suite = "Diamonds"
                    SuitLabel.Text = Offer.Suite
                    SuitLabel.ForeColor = Color.Red
                    increaseofferpoints()
                    verticaldiamondscounter = verticaldiamondscounter + 1
                Else
                    passoffer()
                End If

            End If

        End If
        If offercounter > 9 Then
            passoffer()
        End If
    End Sub
    Sub SOUTHOFFERS()
        If offercounter = 3 Then
            If (EastHas4 Or EastHasFifth Or EastHasForth Or EastHas4J Or EastHas9) Then
                southoffer = "PASS"
                passoffer()
            Else

                If SouthHasForth Then
                    Offer.Points = PointButtons(5).Text
                    For i = 1 To 5
                        PointButtons(i).Enabled = False
                    Next
                    i = 5
                End If
                If SouthHasFifth Then

                    Offer.Points = PointButtons(10).Text
                    For i = 1 To 10
                        PointButtons(i).Enabled = False
                    Next
                    i = 10
                End If
                If SouthHas4 Then
                    Offer.Points = PointButtons(3).Text
                    For i = 1 To 3
                        PointButtons(i).Enabled = False
                    Next
                    i = 3


                End If
                If SouthHas4J Then
                    Offer.Points = PointButtons(13).Text
                    For i = 1 To 13
                        PointButtons(i).Enabled = False
                    Next
                    i = 13
                End If
                If SouthHas9 Then
                    Offer.Points = PointButtons(8).Text
                    For i = 1 To 8
                        PointButtons(i).Enabled = False
                    Next
                    i = 8


                End If


                ''''''''''''SOUTH vazei pontous sto sin



                '''''''''''''''''''''''''''''''''''''''''
                If northoffer = "Hearts" Then
                    If (southhasjHearts Or southhas9Hearts) And verticalheartscounter < 2 Then
                        southoffer = "Hearts"
                        Offer.Suite = "Hearts"
                        SuitLabel.Text = Offer.Suite
                        SuitLabel.ForeColor = Color.Red
                        increaseofferpoints()
                        jor9south = True
                        verticalheartscounter = verticalheartscounter + 1
                    ElseIf jand9north And (southhasASpades Or southhasADiamonds Or southhasAclubs) And verticalheartscounter = 2 Then
                        southoffer = "Hearts"
                        Offer.Suite = "Hearts"
                        SuitLabel.Text = Offer.Suite
                        SuitLabel.ForeColor = Color.Red
                        increaseofferpoints()
                        verticalheartscounter = verticalheartscounter + 1
                    Else
                        southoffer = "PASS"
                        passoffer()
                    End If

                ElseIf northoffer = "Spades" Then
                    If southhasjSpades Or southhas9Spades And verticalspadescounter < 2 Then
                        southoffer = "Spades"
                        Offer.Suite = "Spades"
                        SuitLabel.Text = Offer.Suite
                        SuitLabel.ForeColor = Color.Red
                        increaseofferpoints()
                        jor9south = True
                        verticalspadescounter = verticalspadescounter + 1
                    ElseIf jand9north And (southhasAhearts Or southhasADiamonds Or southhasAclubs) And verticalspadescounter = 2 Then
                        southoffer = "Spades"
                        Offer.Suite = "Spades"
                        SuitLabel.Text = Offer.Suite
                        SuitLabel.ForeColor = Color.Red
                        increaseofferpoints()
                        verticalspadescounter = verticalspadescounter + 1
                    Else
                        southoffer = "PASS"
                        passoffer()
                    End If

                ElseIf northoffer = "Diamonds" Then
                    If southhasjDiamonds Or southhas9Diamonds And verticaldiamondscounter < 2 Then
                        southoffer = "Diamonds"
                        Offer.Suite = "Diamonds"
                        SuitLabel.Text = Offer.Suite
                        SuitLabel.ForeColor = Color.Red
                        increaseofferpoints()
                        jor9south = True
                        verticaldiamondscounter = verticaldiamondscounter + 1
                    ElseIf jand9north And (southhasASpades Or southhasAhearts Or southhasAclubs) And verticaldiamondscounter = 2 Then
                        southoffer = "Diamonds"
                        Offer.Suite = "Diamonds"
                        SuitLabel.Text = Offer.Suite
                        SuitLabel.ForeColor = Color.Red
                        increaseofferpoints()
                        verticaldiamondscounter = verticaldiamondscounter + 1

                    Else
                        southoffer = "PASS"
                        passoffer()
                    End If


                ElseIf northoffer = "Clubs" Then
                    If southhasjclubs Or southhas9clubs And verticalclubscounter < 2 Then
                        southoffer = "Clubs"
                        Offer.Suite = "Clubs"
                        SuitLabel.Text = Offer.Suite
                        SuitLabel.ForeColor = Color.Red
                        jor9south = True
                        increaseofferpoints()
                        verticalclubscounter = verticalclubscounter + 1
                    ElseIf jand9north And (southhasASpades Or southhasAhearts Or southhasADiamonds) And verticalclubscounter = 2 Then
                        southoffer = "Clubs"
                        Offer.Suite = "Clubs"
                        SuitLabel.Text = Offer.Suite
                        SuitLabel.ForeColor = Color.Red
                        increaseofferpoints()
                        verticalclubscounter = verticalclubscounter + 1
                    Else
                        southoffer = "PASS"
                        passoffer()

                    End If
                    ''''''''''''''''''south anoima mona i dipla
                ElseIf (southHeartscounter > 3 And (southhasjHearts = True And southhas9Hearts = True)) Then
                    southoffer = "Hearts"
                    Offer.Suite = "Hearts"
                    SuitLabel.Text = Offer.Suite
                    SuitLabel.ForeColor = Color.Red
                    increaseofferpoints()
                    increaseofferpoints()
                    verticalheartscounter = verticalheartscounter + 2
                    jand9south = True

                ElseIf (southSpadescounter > 3 And southhasjSpades = True And southhas9Spades = True) Then
                    southoffer = "Spades"
                    Offer.Suite = "Spades"
                    SuitLabel.Text = Offer.Suite
                    SuitLabel.ForeColor = Color.Red
                    increaseofferpoints()
                    increaseofferpoints()
                    verticalspadescounter = verticalspadescounter + 2
                    jand9south = True

                ElseIf (southClubscounter > 3 And (southhasjclubs = True And southhas9clubs = True)) Then
                    southoffer = "Clubs"
                    Offer.Suite = "Clubs"
                    SuitLabel.Text = Offer.Suite
                    SuitLabel.ForeColor = Color.Red
                    increaseofferpoints()
                    increaseofferpoints()
                    verticalclubscounter = verticalclubscounter + 2
                    jand9south = True

                ElseIf (southDiamondscounter > 3 And (southhasjDiamonds = True And southhas9Diamonds)) Then
                    Offer.Suite = "Diamonds"
                    SuitLabel.Text = Offer.Suite
                    SuitLabel.ForeColor = Color.Red
                    increaseofferpoints()
                    increaseofferpoints()
                    verticaldiamondscounter = verticaldiamondscounter + 2
                    jand9south = True

                ElseIf (southHeartscounter > 3 And (southhasjHearts = True Or southhas9Hearts = True)) Then
                    southoffer = "Hearts"
                    Offer.Suite = "Hearts"
                    SuitLabel.Text = Offer.Suite
                    SuitLabel.ForeColor = Color.Red
                    increaseofferpoints()
                    verticalheartscounter = verticalheartscounter + 1



                ElseIf (southSpadescounter > 3 And (southhasjSpades = True Or southhas9Spades = True)) Then
                    southoffer = "Spades"
                    Offer.Suite = "Spades"
                    SuitLabel.Text = Offer.Suite
                    SuitLabel.ForeColor = Color.Red
                    increaseofferpoints()
                    verticalspadescounter = verticalspadescounter + 1



                ElseIf (southClubscounter > 3 And (southhasjclubs = True Or southhas9clubs = True)) Then
                    southoffer = "Clubs"
                    Offer.Suite = "Clubs"
                    SuitLabel.Text = Offer.Suite
                    SuitLabel.ForeColor = Color.Red
                    increaseofferpoints()
                    verticalclubscounter = verticalclubscounter + 1


                    'And (Not southoffer = "Clubs" Or Not southoffer = "Spades" Or southoffer = "Hearts")) Then
                ElseIf (southDiamondscounter > 3 And (southhasjDiamonds = True Or southhas9Diamonds = True)) Then
                    southoffer = "Diamonds"
                    Offer.Suite = "Diamonds"
                    SuitLabel.Text = Offer.Suite
                    SuitLabel.ForeColor = Color.Red
                    increaseofferpoints()
                    verticaldiamondscounter = verticaldiamondscounter + 1

                    '''''''''''''''''''''''''''''''''''''''''''
                ElseIf (southHeartscounter > 2 And (southhasjHearts = True And southhas9Hearts = True) And (southhasASpades = True Or southhasAclubs = True Or southhasADiamonds = True)) Then
                    southoffer = "Hearts"
                    Offer.Suite = "Hearts"
                    SuitLabel.Text = Offer.Suite
                    SuitLabel.ForeColor = Color.Red
                    increaseofferpoints()
                    increaseofferpoints()
                    verticalheartscounter = verticalheartscounter + 2
                    jand9south = True

                ElseIf (southSpadescounter > 2 And southhasjSpades = True And southhas9Spades = True And (southhasAhearts = True Or northhasAclubs = True Or southhasADiamonds = True)) Then
                    southoffer = "Spades"
                    Offer.Suite = "Spades"
                    SuitLabel.Text = Offer.Suite
                    SuitLabel.ForeColor = Color.Red
                    increaseofferpoints()
                    increaseofferpoints()
                    verticalspadescounter = verticalspadescounter + 2
                    jand9south = True

                ElseIf (southClubscounter > 2 And (southhasjclubs = True And southhas9clubs = True) And (southhasAhearts = True Or southhasASpades = True Or southhasADiamonds = True)) Then
                    southoffer = "Clubs"
                    Offer.Suite = "Clubs"
                    SuitLabel.Text = Offer.Suite
                    SuitLabel.ForeColor = Color.Red
                    increaseofferpoints()
                    increaseofferpoints()
                    verticalclubscounter = verticalclubscounter + 2
                    jand9south = True

                ElseIf (southDiamondscounter > 2 And (southhasjDiamonds = True And southhas9Diamonds) = True And (southhasAhearts = True Or southhasASpades = True Or southhasAclubs = True)) Then
                    Offer.Suite = "Diamonds"
                    SuitLabel.Text = Offer.Suite
                    SuitLabel.ForeColor = Color.Red
                    increaseofferpoints()
                    increaseofferpoints()
                    verticaldiamondscounter = verticaldiamondscounter + 2
                    jand9south = True

                ElseIf (southHeartscounter > 2 And (southhasjHearts = True Or southhas9Hearts = True) And (southhasASpades = True Or southhasAclubs = True Or southhasADiamonds = True)) Then
                    southoffer = "Hearts"
                    Offer.Suite = "Hearts"
                    SuitLabel.Text = Offer.Suite
                    SuitLabel.ForeColor = Color.Red
                    increaseofferpoints()
                    verticalheartscounter = verticalheartscounter + 1



                ElseIf (southSpadescounter > 2 And (southhasjSpades = True Or southhas9Spades = True) And (southhasAhearts = True Or northhasAclubs = True Or southhasADiamonds = True)) Then
                    southoffer = "Spades"
                    Offer.Suite = "Spades"
                    SuitLabel.Text = Offer.Suite
                    SuitLabel.ForeColor = Color.Red
                    increaseofferpoints()
                    verticalspadescounter = verticalspadescounter + 1



                ElseIf (southClubscounter > 2 And (southhasjclubs = True Or southhas9clubs = True) And (southhasAhearts = True Or southhasASpades = True Or southhasADiamonds = True)) Then
                    southoffer = "Clubs"
                    Offer.Suite = "Clubs"
                    SuitLabel.Text = Offer.Suite
                    SuitLabel.ForeColor = Color.Red
                    increaseofferpoints()
                    verticalclubscounter = verticalclubscounter + 1


                    'And (Not southoffer = "Clubs" Or Not southoffer = "Spades" Or southoffer = "Hearts")) Then
                ElseIf (southDiamondscounter > 2 And (southhasjDiamonds = True Or southhas9Diamonds = True) And (southhasAhearts = True Or southhasASpades = True Or southhasAclubs = True)) Then
                    southoffer = "Diamonds"
                    Offer.Suite = "Diamonds"
                    SuitLabel.Text = Offer.Suite
                    SuitLabel.ForeColor = Color.Red
                    increaseofferpoints()
                    verticaldiamondscounter = verticaldiamondscounter + 1
                    ''''den isxyei o kanonas pou thesame gia na ginei prosfora alla logo extra ponton kanoume prosfora
                ElseIf (SouthHas9 Or SouthHas4J Or SouthHas4) Then
                    If (southClubscounter > 1 And (southhasjclubs = True And southhas9clubs)) Then
                        southoffer = "Clubs"
                        Offer.Suite = "Clubs"
                        SuitLabel.Text = Offer.Suite
                        SuitLabel.ForeColor = Color.Red
                        increaseofferpoints()
                        increaseofferpoints()
                        jand9south = True

                    ElseIf (southClubscounter > 1 And (southhasjclubs = True Or southhas9clubs)) Then
                        southoffer = "Clubs"
                        Offer.Suite = "Clubs"
                        SuitLabel.Text = Offer.Suite
                        SuitLabel.ForeColor = Color.Red
                        increaseofferpoints()

                    ElseIf (southDiamondscounter > 1 And (southhasjDiamonds = True And southhas9Diamonds)) Then
                        southoffer = "Diamonds"
                        Offer.Suite = "Diamonds"
                        SuitLabel.Text = Offer.Suite
                        SuitLabel.ForeColor = Color.Red
                        increaseofferpoints()
                        increaseofferpoints()
                        jand9south = True

                    ElseIf (southDiamondscounter > 1 And (southhasjDiamonds = True Or southhas9Diamonds)) Then
                        southoffer = "Diamonds"
                        Offer.Suite = "Diamonds"
                        SuitLabel.Text = Offer.Suite
                        SuitLabel.ForeColor = Color.Red
                        increaseofferpoints()

                    ElseIf (southHeartscounter > 1 And (southhasjHearts = True And southhas9Hearts)) Then
                        southoffer = "Hearts"
                        Offer.Suite = "Hearts"
                        SuitLabel.Text = Offer.Suite
                        SuitLabel.ForeColor = Color.Red
                        increaseofferpoints()
                        increaseofferpoints()
                        jand9south = True

                    ElseIf (southHeartscounter > 1 And (southhasjHearts = True Or southhas9Hearts)) Then
                        southoffer = "Hearts"
                        Offer.Suite = "Hearts"
                        SuitLabel.Text = Offer.Suite
                        SuitLabel.ForeColor = Color.Red
                        increaseofferpoints()

                    ElseIf (southSpadescounter > 1 And (southhasjSpades = True Or southhas9Spades)) Then
                        southoffer = "Spades"
                        Offer.Suite = "Spades"
                        SuitLabel.Text = Offer.Suite
                        SuitLabel.ForeColor = Color.Red
                        increaseofferpoints()
                    End If
                ElseIf SouthHasForth Or SouthHasFifth Then
                    If southClubscounter > 3 And (southhasjclubs = True And southhas9clubs) Then
                        southoffer = "Clubs"
                        Offer.Suite = "Clubs"
                        SuitLabel.Text = Offer.Suite
                        SuitLabel.ForeColor = Color.Red
                        increaseofferpoints()
                        increaseofferpoints()
                        jand9north = True
                    ElseIf southClubscounter > 3 And (southhasjclubs = True Or southhas9clubs) Then
                        southoffer = "Clubs"
                        Offer.Suite = "Clubs"
                        SuitLabel.Text = Offer.Suite
                        SuitLabel.ForeColor = Color.Red
                        increaseofferpoints()


                    ElseIf southHeartscounter > 3 And (southhasjHearts = True And southhas9Hearts) Then
                        southoffer = "Hearts"
                        Offer.Suite = "Hearts"
                        SuitLabel.Text = Offer.Suite
                        SuitLabel.ForeColor = Color.Red
                        increaseofferpoints()
                        increaseofferpoints()
                        jand9north = True

                    ElseIf southHeartscounter > 3 And (southhasjHearts = True Or southhas9Hearts) Then
                        southoffer = "Hearts"
                        Offer.Suite = "Hearts"
                        SuitLabel.Text = Offer.Suite
                        SuitLabel.ForeColor = Color.Red
                        increaseofferpoints()

                    ElseIf southDiamondscounter > 3 And (southhasjDiamonds = True And southhas9Diamonds) Then
                        southoffer = "Diamonds"
                        Offer.Suite = "Diamonds"
                        SuitLabel.Text = Offer.Suite
                        SuitLabel.ForeColor = Color.Red
                        increaseofferpoints()
                        increaseofferpoints()
                        jand9north = True

                    ElseIf southDiamondscounter > 3 And (southhasjDiamonds = True Or southhas9Diamonds) Then
                        southoffer = "Diamonds"
                        Offer.Suite = "Diamonds"
                        SuitLabel.Text = Offer.Suite
                        SuitLabel.ForeColor = Color.Red
                        increaseofferpoints()

                    ElseIf southSpadescounter > 3 And (southhasjSpades = True And southhas9Spades) Then
                        southoffer = "Spades"
                        Offer.Suite = "Spades"
                        SuitLabel.Text = Offer.Suite
                        SuitLabel.ForeColor = Color.Red
                        increaseofferpoints()
                        increaseofferpoints()
                        jand9north = True

                    ElseIf southSpadescounter > 3 And (southhasjSpades = True Or southhas9Spades) Then
                        southoffer = "Spades"
                        Offer.Suite = "Spades"
                        SuitLabel.Text = Offer.Suite
                        SuitLabel.ForeColor = Color.Red
                        increaseofferpoints()

                    End If
                Else
                    southoffer = "PASS"
                    passoffer()
                End If


            End If
        End If


        '''''''''south offer valei asous sto epomeno gyro
        If offercounter = 7 Then
            If (EastHas4 Or EastHasFifth Or EastHasForth Or EastHas4J Or EastHas9 Or WestHas4 Or WestHasFifth Or WestHasForth Or WestHas4J Or WestHas9) Then
                passoffer()

            Else
                If Not jand9north Then
                    If southoffer = "Hearts" And (southhasASpades Or southhasAclubs Or southhasADiamonds) Then
                        southoffer = "Hearts"
                        Offer.Suite = "Hearts"
                        SuitLabel.Text = Offer.Suite
                        SuitLabel.ForeColor = Color.Red
                        increaseofferpoints()
                        verticalheartscounter = verticalheartscounter + 1

                    ElseIf southoffer = "Spades" And (southhasAhearts Or southhasAclubs Or southhasADiamonds) Then
                        southoffer = "Spades"
                        Offer.Suite = "Spades"
                        SuitLabel.Text = Offer.Suite
                        SuitLabel.ForeColor = Color.Red
                        increaseofferpoints()
                        verticalspadescounter = verticalspadescounter + 1

                    ElseIf southoffer = "Clubs" And (southhasAhearts Or southhasASpades Or southhasADiamonds) Then
                        southoffer = "Clubss"
                        Offer.Suite = "Clubs"
                        SuitLabel.Text = Offer.Suite
                        SuitLabel.ForeColor = Color.Red
                        increaseofferpoints()
                        verticalclubscounter = verticalclubscounter + 1

                    ElseIf southoffer = "Diamonds" And (southhasAhearts Or southhasAclubs Or southhasASpades) Then
                        southoffer = "Diamonds"
                        Offer.Suite = "Diamonds"
                        SuitLabel.Text = Offer.Suite
                        SuitLabel.ForeColor = Color.Red
                        increaseofferpoints()
                        verticaldiamondscounter = verticaldiamondscounter + 1



                    ElseIf northoffer = "Hearts" And (southhasASpades Or southhasAclubs Or southhasADiamonds) Then
                        southoffer = "Hearts"
                        Offer.Suite = "Hearts"
                        SuitLabel.Text = Offer.Suite
                        SuitLabel.ForeColor = Color.Red
                        increaseofferpoints()
                        verticalheartscounter = verticalheartscounter + 1

                    ElseIf northoffer = "Spades" And (southhasAhearts Or southhasAclubs Or southhasADiamonds) Then
                        southoffer = "Spades"
                        Offer.Suite = "Spades"
                        SuitLabel.Text = Offer.Suite
                        SuitLabel.ForeColor = Color.Red
                        increaseofferpoints()
                        verticalspadescounter = verticalspadescounter + 1

                    ElseIf northoffer = "Clubs" And (southhasAhearts Or southhasASpades Or southhasADiamonds) Then
                        southoffer = "Clubss"
                        Offer.Suite = "Clubs"
                        SuitLabel.Text = Offer.Suite
                        SuitLabel.ForeColor = Color.Red
                        increaseofferpoints()
                        verticalclubscounter = verticalclubscounter + 1

                    ElseIf northoffer = "Diamonds" And (southhasAhearts Or southhasAclubs Or southhasASpades) Then
                        southoffer = "Diamonds"
                        Offer.Suite = "Diamonds"
                        SuitLabel.Text = Offer.Suite
                        SuitLabel.ForeColor = Color.Red
                        increaseofferpoints()
                        verticaldiamondscounter = verticaldiamondscounter + 1
                    Else
                        southoffer = "PASS"
                        passoffer()
                    End If
                Else '''''''''''' vazei 10
                    If southoffer = "Hearts" And ((southhasASpades And southhas10Spades) Or (southhasAclubs And southhas10Clubs) Or (southhasADiamonds And southhas10Diamonds)) Then
                        southoffer = "Hearts"
                        Offer.Suite = "Hearts"
                        SuitLabel.Text = Offer.Suite
                        SuitLabel.ForeColor = Color.Red
                        increaseofferpoints()
                        verticalheartscounter = verticalheartscounter + 1

                    ElseIf southoffer = "Spades" And ((southhasAhearts And southhas10Hearts) Or (southhasAclubs And southhas10Clubs) Or (southhasADiamonds And southhas10Diamonds)) Then
                        southoffer = "Spades"
                        Offer.Suite = "Spades"
                        SuitLabel.Text = Offer.Suite
                        SuitLabel.ForeColor = Color.Red
                        increaseofferpoints()
                        verticalspadescounter = verticalspadescounter + 1

                    ElseIf southoffer = "Clubs" And ((southhasASpades And southhas10Spades) Or (southhasAhearts And southhas10Hearts) Or (southhasADiamonds And southhas10Diamonds)) Then
                        northoffer = "Clubss"
                        Offer.Suite = "Clubs"
                        SuitLabel.Text = Offer.Suite
                        SuitLabel.ForeColor = Color.Red
                        increaseofferpoints()
                        verticalclubscounter = verticalclubscounter + 1

                    ElseIf southoffer = "Diamonds" And ((southhasASpades And southhas10Spades) Or (southhasAclubs And southhas10Clubs) Or (southhasAhearts And southhas10Hearts)) Then
                        southoffer = "Diamonds"
                        Offer.Suite = "Diamonds"
                        SuitLabel.Text = Offer.Suite
                        SuitLabel.ForeColor = Color.Red
                        increaseofferpoints()
                        verticaldiamondscounter = verticaldiamondscounter + 1
                    Else
                        passoffer()
                    End If


                End If

            End If
        End If
        If offercounter = 11 Then
            If (EastHas4 Or EastHasFifth Or EastHasForth Or EastHas4J Or EastHas9 Or WestHas4 Or WestHasFifth Or WestHasForth Or WestHas4J Or WestHas9) Then
                passoffer()
            Else
                If jand9north Then
                    passoffer()
                Else
                    '''''''''south vazei 10
                    If southoffer = "Hearts" And ((southhasASpades And southhas10Spades) Or (southhasAclubs And southhas10Clubs) Or (southhasADiamonds And southhas10Diamonds)) Then
                        southoffer = "Hearts"
                        Offer.Suite = "Hearts"
                        SuitLabel.Text = Offer.Suite
                        SuitLabel.ForeColor = Color.Red
                        increaseofferpoints()
                        verticalheartscounter = verticalheartscounter + 1

                    ElseIf southoffer = "Spades" And ((southhasAhearts And southhas10Hearts) Or (southhasAclubs And southhas10Clubs) Or (southhasADiamonds And southhas10Diamonds)) Then
                        southoffer = "Spades"
                        Offer.Suite = "Spades"
                        SuitLabel.Text = Offer.Suite
                        SuitLabel.ForeColor = Color.Red
                        increaseofferpoints()
                        verticalspadescounter = verticalspadescounter + 1

                    ElseIf southoffer = "Clubs" And ((southhasASpades And southhas10Spades) Or (southhasAhearts And southhas10Hearts) Or (southhasADiamonds And southhas10Diamonds)) Then
                        northoffer = "Clubss"
                        Offer.Suite = "Clubs"
                        SuitLabel.Text = Offer.Suite
                        SuitLabel.ForeColor = Color.Red
                        increaseofferpoints()
                        verticalclubscounter = verticalclubscounter + 1

                    ElseIf southoffer = "Diamonds" And ((southhasASpades And southhas10Spades) Or (southhasAclubs And southhas10Clubs) Or (southhasAhearts And southhas10Hearts)) Then
                        southoffer = "Diamonds"
                        Offer.Suite = "Diamonds"
                        SuitLabel.Text = Offer.Suite
                        SuitLabel.ForeColor = Color.Red
                        increaseofferpoints()
                        verticaldiamondscounter = verticaldiamondscounter + 1
                    Else
                        passoffer()
                    End If
                End If
            End If

        End If
        If offercounter > 12 Then
            passoffer()
        End If
    End Sub

    Sub EASTOFFERS()
        If offercounter = 2 Then
            If (NorthHas4 Or NorthHasFifth Or NorthHasForth Or NorthHas4J Or NorthHas9) Then
                passoffer()
            Else


                If EastHasForth Then
                    Offer.Points = PointButtons(5).Text
                    For i = 1 To 5
                        PointButtons(i).Enabled = False
                    Next
                    i = 5
                End If
                If EastHasFifth Then

                    Offer.Points = PointButtons(10).Text
                    For i = 1 To 10
                        PointButtons(i).Enabled = False
                    Next
                    i = 10
                End If
                If EastHas4 Then
                    Offer.Points = PointButtons(3).Text
                    For i = 1 To 3
                        PointButtons(i).Enabled = False
                    Next
                    i = 3


                End If
                If EastHas4J Then
                    Offer.Points = PointButtons(13).Text
                    For i = 1 To 13
                        PointButtons(i).Enabled = False
                    Next
                    i = 13
                End If
                If EastHas9 Then
                    Offer.Points = PointButtons(8).Text
                    For i = 1 To 8
                        PointButtons(i).Enabled = False
                    Next
                    i = 8


                End If


                ''''''''''''''''EAST OFFER MONA I DIPLA```````````````````

                If (eastHeartscounter > 3 And easthasjHearts = True And easthas9Hearts = True) Then
                    eastoffer = "Hearts"
                    Offer.Suite = "Hearts"
                    SuitLabel.Text = Offer.Suite
                    SuitLabel.ForeColor = Color.Red
                    increaseofferpoints()
                    increaseofferpoints()
                    jand9east = True


                ElseIf (eastSpadescounter > 3 And easthasjSpades = True And easthas9Spades = True) Then
                    eastoffer = "Spades"
                    Offer.Suite = "Spades"
                    SuitLabel.Text = Offer.Suite
                    SuitLabel.ForeColor = Color.Red
                    increaseofferpoints()
                    increaseofferpoints()
                    jand9east = True


                ElseIf (eastClubscounter > 3 And easthasjclubs = True And easthas9clubs = True) Then
                    eastoffer = "Clubs"
                    Offer.Suite = "Clubs"
                    SuitLabel.Text = Offer.Suite
                    SuitLabel.ForeColor = Color.Red
                    increaseofferpoints()
                    increaseofferpoints()
                    jand9east = True

                ElseIf (eastDiamondscounter > 3 And easthasjDiamonds = True And easthas9Diamonds = True) Then
                    eastoffer = "Diamonds"
                    Offer.Suite = "Diamonds"
                    SuitLabel.Text = Offer.Suite
                    SuitLabel.ForeColor = Color.Red
                    increaseofferpoints()
                    increaseofferpoints()
                    jand9east = True

                ElseIf (eastHeartscounter > 3 And (easthasjHearts = True Or easthas9Hearts = True)) Then
                    eastoffer = "Hearts"
                    Offer.Suite = "Hearts"
                    SuitLabel.Text = Offer.Suite
                    SuitLabel.ForeColor = Color.Red
                    increaseofferpoints()


                ElseIf (eastSpadescounter > 3 And (easthasjSpades = True Or easthas9Spades = True)) Then
                    eastoffer = "Spades"
                    Offer.Suite = "Spades"
                    SuitLabel.Text = Offer.Suite
                    SuitLabel.ForeColor = Color.Red
                    increaseofferpoints()


                ElseIf (eastClubscounter > 3 And (easthasjclubs = True Or easthas9clubs = True)) Then
                    eastoffer = "Clubs"
                    Offer.Suite = "Clubs"
                    SuitLabel.Text = Offer.Suite
                    SuitLabel.ForeColor = Color.Red
                    increaseofferpoints()



                ElseIf (eastDiamondscounter > 3 And (easthasjDiamonds = True Or easthas9Diamonds = True)) Then
                    eastoffer = "Diamonds"
                    Offer.Suite = "Diamonds"
                    SuitLabel.Text = Offer.Suite
                    SuitLabel.ForeColor = Color.Red
                    increaseofferpoints()

                    '''''''''''''''''''''
                ElseIf (eastHeartscounter > 2 And easthasjHearts = True And easthas9Hearts = True And (easthasASpades = True Or easthasAclubs = True Or easthasADiamonds = True)) Then
                    eastoffer = "Hearts"
                    Offer.Suite = "Hearts"
                    SuitLabel.Text = Offer.Suite
                    SuitLabel.ForeColor = Color.Red
                    increaseofferpoints()
                    increaseofferpoints()
                    jand9east = True


                ElseIf (eastSpadescounter > 2 And easthasjSpades = True And easthas9Spades = True And (easthasAhearts = True Or easthasAclubs = True Or easthasADiamonds = True)) Then
                    eastoffer = "Spades"
                    Offer.Suite = "Spades"
                    SuitLabel.Text = Offer.Suite
                    SuitLabel.ForeColor = Color.Red
                    increaseofferpoints()
                    increaseofferpoints()
                    jand9east = True


                ElseIf (eastClubscounter > 2 And easthasjclubs = True And easthas9clubs = True And (easthasAhearts = True Or easthasASpades = True Or easthasADiamonds = True)) Then
                    eastoffer = "Clubs"
                    Offer.Suite = "Clubs"
                    SuitLabel.Text = Offer.Suite
                    SuitLabel.ForeColor = Color.Red
                    increaseofferpoints()
                    increaseofferpoints()
                    jand9east = True

                ElseIf (eastDiamondscounter > 2 And easthasjDiamonds = True And easthas9Diamonds = True And (easthasAhearts = True Or easthasASpades = True Or easthasAclubs = True)) Then
                    eastoffer = "Diamonds"
                    Offer.Suite = "Diamonds"
                    SuitLabel.Text = Offer.Suite
                    SuitLabel.ForeColor = Color.Red
                    increaseofferpoints()
                    increaseofferpoints()
                    jand9east = True

                ElseIf (eastHeartscounter > 2 And (easthasjHearts = True Or easthas9Hearts = True) And (easthasASpades = True Or easthasAclubs = True Or easthasADiamonds = True)) Then
                    eastoffer = "Hearts"
                    Offer.Suite = "Hearts"
                    SuitLabel.Text = Offer.Suite
                    SuitLabel.ForeColor = Color.Red
                    increaseofferpoints()


                ElseIf (eastSpadescounter > 2 And (easthasjSpades = True Or easthas9Spades = True) And (easthasAhearts = True Or easthasAclubs = True Or easthasADiamonds = True)) Then
                    eastoffer = "Spades"
                    Offer.Suite = "Spades"
                    SuitLabel.Text = Offer.Suite
                    SuitLabel.ForeColor = Color.Red
                    increaseofferpoints()


                ElseIf (eastClubscounter > 2 And (easthasjclubs = True Or easthas9clubs = True) And (easthasAhearts = True Or easthasASpades = True Or easthasADiamonds = True)) Then
                    eastoffer = "Clubs"
                    Offer.Suite = "Clubs"
                    SuitLabel.Text = Offer.Suite
                    SuitLabel.ForeColor = Color.Red
                    increaseofferpoints()



                ElseIf (eastDiamondscounter > 2 And (easthasjDiamonds = True Or easthas9Diamonds = True) And (easthasAhearts = True Or easthasASpades = True Or easthasAclubs = True)) Then
                    eastoffer = "Diamonds"
                    Offer.Suite = "Diamonds"
                    SuitLabel.Text = Offer.Suite
                    SuitLabel.ForeColor = Color.Red
                    increaseofferpoints()

                    ''DEN ISXUEI O "GENIKOS KANONAS" GIA NA GINEI PPROSFORA ALLA LOGO EXTRA PONTON KANOUME PROSFORA 
                ElseIf (EastHas9 Or EastHas4J Or EastHas4) Then
                    If (eastClubscounter > 1 And (easthasjclubs = True And easthas9clubs)) Then
                        eastoffer = "Clubs"
                        Offer.Suite = "Clubs"
                        SuitLabel.Text = Offer.Suite
                        SuitLabel.ForeColor = Color.Red
                        increaseofferpoints()
                        increaseofferpoints()
                        jand9east = True

                    ElseIf (eastClubscounter > 1 And (easthasjclubs = True Or easthas9clubs)) Then
                        eastoffer = "Clubs"
                        Offer.Suite = "Clubs"
                        SuitLabel.Text = Offer.Suite
                        SuitLabel.ForeColor = Color.Red
                        increaseofferpoints()

                    ElseIf (eastDiamondscounter > 1 And (easthasjDiamonds = True And easthas9Diamonds)) Then
                        eastoffer = "Diamonds"
                        Offer.Suite = "Diamonds"
                        SuitLabel.Text = Offer.Suite
                        SuitLabel.ForeColor = Color.Red
                        increaseofferpoints()
                        increaseofferpoints()
                        jand9east = True

                    ElseIf (eastDiamondscounter > 1 And (easthasjDiamonds = True Or easthas9Diamonds)) Then
                        eastoffer = "Diamonds"
                        Offer.Suite = "Diamonds"
                        SuitLabel.Text = Offer.Suite
                        SuitLabel.ForeColor = Color.Red
                        increaseofferpoints()

                    ElseIf (eastHeartscounter > 1 And (easthasjHearts = True And easthas9Hearts)) Then
                        eastoffer = "Hearts"
                        Offer.Suite = "Hearts"
                        SuitLabel.Text = Offer.Suite
                        SuitLabel.ForeColor = Color.Red
                        increaseofferpoints()
                        increaseofferpoints()
                        jand9east = True

                    ElseIf (eastHeartscounter > 1 And (easthasjHearts = True Or easthas9Hearts)) Then
                        eastoffer = "Hearts"
                        Offer.Suite = "Hearts"
                        SuitLabel.Text = Offer.Suite
                        SuitLabel.ForeColor = Color.Red
                        increaseofferpoints()

                    ElseIf (eastSpadescounter > 1 And (easthasjSpades = True And easthas9Spades)) Then
                        eastoffer = "Spades"
                        Offer.Suite = "Spades"
                        SuitLabel.Text = Offer.Suite
                        SuitLabel.ForeColor = Color.Red
                        increaseofferpoints()
                        increaseofferpoints()
                        jand9east = True


                    ElseIf (eastSpadescounter > 1 And (easthasjSpades = True Or easthas9Spades)) Then
                        eastoffer = "Spades"
                        Offer.Suite = "Spades"
                        SuitLabel.Text = Offer.Suite
                        SuitLabel.ForeColor = Color.Red
                        increaseofferpoints()

                    End If
                ElseIf EastHasForth Or EastHasFifth Then
                    If eastSpadescounter > 3 And (easthasjSpades = True And easthas9Spades) Then
                        eastoffer = "Spades"
                        Offer.Suite = "Spades"
                        SuitLabel.Text = Offer.Suite
                        SuitLabel.ForeColor = Color.Red
                        increaseofferpoints()
                        increaseofferpoints()
                        jand9north = True
                    ElseIf eastSpadescounter > 3 And (easthasjSpades = True Or easthas9Spades) Then
                        eastoffer = "Spades"
                        Offer.Suite = "Spades"
                        SuitLabel.Text = Offer.Suite
                        SuitLabel.ForeColor = Color.Red
                        increaseofferpoints()


                    ElseIf eastHeartscounter > 3 And (easthasjHearts = True And easthas9Hearts) Then
                        eastoffer = "Hearts"
                        Offer.Suite = "Hearts"
                        SuitLabel.Text = Offer.Suite
                        SuitLabel.ForeColor = Color.Red
                        increaseofferpoints()
                        increaseofferpoints()
                        jand9north = True

                    ElseIf eastHeartscounter > 3 And (easthasjHearts = True Or easthas9Hearts) Then
                        eastoffer = "Hearts"
                        Offer.Suite = "Hearts"
                        SuitLabel.Text = Offer.Suite
                        SuitLabel.ForeColor = Color.Red
                        increaseofferpoints()

                    ElseIf eastDiamondscounter > 3 And (easthasjDiamonds = True And easthas9Diamonds) Then
                        eastoffer = "Diamonds"
                        Offer.Suite = "Diamonds"
                        SuitLabel.Text = Offer.Suite
                        SuitLabel.ForeColor = Color.Red
                        increaseofferpoints()
                        increaseofferpoints()
                        jand9north = True

                    ElseIf eastDiamondscounter > 3 And (easthasjDiamonds = True Or easthas9Diamonds) Then
                        eastoffer = "Diamonds"
                        Offer.Suite = "Diamonds"
                        SuitLabel.Text = Offer.Suite
                        SuitLabel.ForeColor = Color.Red
                        increaseofferpoints()

                    ElseIf eastSpadescounter > 3 And (easthasjSpades = True And easthas9Spades) Then
                        eastoffer = "Spades"
                        Offer.Suite = "Spades"
                        SuitLabel.Text = Offer.Suite
                        SuitLabel.ForeColor = Color.Red
                        increaseofferpoints()
                        increaseofferpoints()
                        jand9north = True

                    ElseIf eastSpadescounter > 3 And (easthasjSpades = True Or easthas9Spades) Then
                        eastoffer = "Spades"
                        Offer.Suite = "Spades"
                        SuitLabel.Text = Offer.Suite
                        SuitLabel.ForeColor = Color.Red
                        increaseofferpoints()

                    End If
                Else
                    eastoffer = "PASS"
                    passoffer()
                End If

            End If
        End If
        If offercounter = 6 Then
            If (NorthHas4 Or NorthHasFifth Or NorthHasForth Or NorthHas4J Or NorthHas9 Or SouthHas4 Or SouthHasFifth Or SouthHasForth Or SouthHas4J Or SouthHas9) Then
                passoffer()
            Else
                '''''''''''''''''''EAST VAZEI PONTOUS STO SIN
                If westoffer = "Hearts" And Not jor9west Then
                    If easthasjHearts Or easthas9Hearts Then
                        eastoffer = "Hearts"
                        Offer.Suite = "Hearts"
                        SuitLabel.Text = Offer.Suite
                        SuitLabel.ForeColor = Color.Red
                        jor9east = True
                        increaseofferpoints()
                    ElseIf jand9west And (easthasASpades Or easthasADiamonds Or easthasAclubs) Then
                        eastoffer = "Hearts"
                        Offer.Suite = "Hearts"
                        SuitLabel.Text = Offer.Suite
                        SuitLabel.ForeColor = Color.Red
                        increaseofferpoints()
                    Else
                        eastoffer = "PASS"
                        passoffer()
                    End If

                ElseIf westoffer = "Spades" And Not jor9west Then
                    If easthasjSpades Or easthas9Spades Then
                        eastoffer = "Spades"
                        Offer.Suite = "Spades"
                        SuitLabel.Text = Offer.Suite
                        SuitLabel.ForeColor = Color.Red
                        increaseofferpoints()
                        jor9east = True
                    ElseIf jand9west And (easthasAhearts Or easthasADiamonds Or easthasAclubs) Then
                        eastoffer = "Spades"
                        Offer.Suite = "Spades"
                        SuitLabel.Text = Offer.Suite
                        SuitLabel.ForeColor = Color.Red
                        increaseofferpoints()
                    Else
                        eastoffer = "PASS"
                        passoffer()
                    End If

                ElseIf westoffer = "Diamonds" And Not jor9west Then
                    If easthasjDiamonds Or easthas9Diamonds Then
                        eastoffer = "Diamonds"
                        Offer.Suite = "Diamonds"
                        SuitLabel.Text = Offer.Suite
                        SuitLabel.ForeColor = Color.Red
                        increaseofferpoints()
                        jor9east = True
                    ElseIf jand9west And (easthasAhearts Or easthasASpades Or easthasAclubs) Then
                        eastoffer = "Diamonds"
                        Offer.Suite = "Diamonds"
                        SuitLabel.Text = Offer.Suite
                        SuitLabel.ForeColor = Color.Red
                        increaseofferpoints()
                    Else

                        eastoffer = "PASS"
                        passoffer()
                    End If

                ElseIf westoffer = "Clubs" And Not jor9west Then
                    If easthasjclubs Or easthas9clubs Then
                        eastoffer = "Clubs"
                        Offer.Suite = "Clubs"
                        SuitLabel.Text = Offer.Suite
                        SuitLabel.ForeColor = Color.Red
                        increaseofferpoints()
                        jor9east = True
                    ElseIf jand9west And (easthasAhearts Or easthasASpades Or easthasADiamonds) Then
                        eastoffer = "Clubs"
                        Offer.Suite = "Clubs"
                        SuitLabel.Text = Offer.Suite
                        SuitLabel.ForeColor = Color.Red
                        increaseofferpoints()
                    Else
                        eastoffer = "PASS"
                        passoffer()
                    End If



                    ''''''''''''''''''east VAZEI ASOUS


                ElseIf eastoffer = "Hearts" And (easthasASpades Or easthasAclubs Or easthasADiamonds) Then
                    eastoffer = "Hearts"
                    Offer.Suite = "Hearts"
                    SuitLabel.Text = Offer.Suite
                    SuitLabel.ForeColor = Color.Red
                    increaseofferpoints()
                    verticalheartscounter = verticalheartscounter + 1

                ElseIf eastoffer = "Spades" And (easthasAhearts Or easthasAclubs Or easthasADiamonds) Then
                    eastoffer = "Spades"
                    Offer.Suite = "Spades"
                    SuitLabel.Text = Offer.Suite
                    SuitLabel.ForeColor = Color.Red
                    increaseofferpoints()
                    verticalspadescounter = verticalspadescounter + 1

                ElseIf eastoffer = "Clubs" And (easthasAhearts Or easthasASpades Or easthasADiamonds) Then
                    eastoffer = "Clubss"
                    Offer.Suite = "Clubs"
                    SuitLabel.Text = Offer.Suite
                    SuitLabel.ForeColor = Color.Red
                    increaseofferpoints()
                    verticalclubscounter = verticalclubscounter + 1

                ElseIf eastoffer = "Diamonds" And (easthasAhearts Or easthasAclubs Or easthasASpades) Then
                    eastoffer = "Diamonds"
                    Offer.Suite = "Diamonds"
                    SuitLabel.Text = Offer.Suite
                    SuitLabel.ForeColor = Color.Red
                    increaseofferpoints()
                    verticaldiamondscounter = verticaldiamondscounter + 1
                Else
                    passoffer()
                End If

            End If
        End If

        If offercounter = 10 Then
            If (Not NorthHas4 Or Not NorthHasFifth Or Not NorthHasForth Or Not NorthHas4J Or Not NorthHas9 Or Not SouthHas4 Or Not SouthHasFifth Or Not SouthHasForth Or Not SouthHas4J Or Not SouthHas9) Then
                passoffer()
            Else
                '''''''''east vazei 10
                If eastoffer = "Hearts" And ((easthasASpades And easthas10Spades) Or (easthasAclubs And easthas10Clubs) Or (easthasADiamonds And easthas10Diamonds)) Then
                    eastoffer = "Hearts"
                    Offer.Suite = "Hearts"
                    SuitLabel.Text = Offer.Suite
                    SuitLabel.ForeColor = Color.Red
                    increaseofferpoints()
                    verticalheartscounter = verticalheartscounter + 1

                ElseIf eastoffer = "Spades" And ((easthasAhearts And easthas10Hearts) Or (easthasAclubs And easthas10Clubs) Or (easthasADiamonds And easthas10Diamonds)) Then
                    eastoffer = "Spades"
                    Offer.Suite = "Spades"
                    SuitLabel.Text = Offer.Suite
                    SuitLabel.ForeColor = Color.Red
                    increaseofferpoints()
                    verticalspadescounter = verticalspadescounter + 1

                ElseIf eastoffer = "Clubs" And ((easthasASpades And easthas10Spades) Or (easthasAhearts And easthas10Hearts) Or (easthasADiamonds And easthas10Diamonds)) Then
                    eastoffer = "Clubss"
                    Offer.Suite = "Clubs"
                    SuitLabel.Text = Offer.Suite
                    SuitLabel.ForeColor = Color.Red
                    increaseofferpoints()
                    verticalclubscounter = verticalclubscounter + 1

                ElseIf eastoffer = "Diamonds" And ((easthasASpades And easthas10Spades) Or (easthasAclubs And easthas10Clubs) Or (easthasAhearts And easthas10Hearts)) Then
                    eastoffer = "Diamonds"
                    Offer.Suite = "Diamonds"
                    SuitLabel.Text = Offer.Suite
                    SuitLabel.ForeColor = Color.Red
                    increaseofferpoints()
                    verticaldiamondscounter = verticaldiamondscounter + 1

                Else
                    passoffer()
                End If

            End If
        End If

        If offercounter > 11 Then
            passoffer()
        End If

    End Sub
    Sub WESTOFFERS()
        If offercounter = 4 Then
            If (SouthHas4 Or NorthHas4 Or SouthHasFifth Or NorthHasFifth Or SouthHasForth Or NorthHasForth Or SouthHas4J Or NorthHas4J Or NorthHas9 Or SouthHas9) Then
                passoffer()
            Else
                If WestHasForth Then
                    Offer.Points = PointButtons(5).Text
                    For i = 1 To 5
                        PointButtons(i).Enabled = False
                    Next
                    i = 5
                End If
                If WestHasFifth Then

                    Offer.Points = PointButtons(10).Text
                    For i = 1 To 10
                        PointButtons(i).Enabled = False
                    Next
                    i = 10
                End If
                If WestHas4 Then
                    Offer.Points = PointButtons(3).Text
                    For i = 1 To 3
                        PointButtons(i).Enabled = False
                    Next
                    i = 3


                End If
                If WestHas4J Then
                    Offer.Points = PointButtons(13).Text
                    For i = 1 To 13
                        PointButtons(13).Enabled = False
                    Next
                    i = 13
                End If
                If WestHas9 Then
                    Offer.Points = PointButtons(8).Text
                    For i = 1 To 8
                        PointButtons(8).Enabled = False
                    Next
                    i = 8


                End If

                '''''''''''''''''''WEST VAZEI PONTOUS STO SIN

                If eastoffer = "Hearts" Then
                    If westhasjHearts Or westhas9Hearts Then
                        westoffer = "Hearts"
                        Offer.Suite = "Hearts"
                        SuitLabel.Text = Offer.Suite
                        SuitLabel.ForeColor = Color.Red
                        increaseofferpoints()
                        jor9west = True

                    ElseIf jand9east And (westhasASpades Or westhasADiamonds Or westhasAclubs) Then
                        westoffer = "Hearts"
                        Offer.Suite = "Hearts"
                        SuitLabel.Text = Offer.Suite
                        SuitLabel.ForeColor = Color.Red
                        increaseofferpoints()
                    Else
                        westoffer = "PASS"
                        passoffer()
                    End If

                ElseIf eastoffer = "Spades" Then
                    If westhasjSpades Or westhas9Spades Then
                        westoffer = "Spades"
                        Offer.Suite = "Spades"
                        SuitLabel.Text = Offer.Suite
                        SuitLabel.ForeColor = Color.Red
                        increaseofferpoints()
                        jor9west = True
                    ElseIf jand9east And (westhasAhearts Or westhasADiamonds Or westhasAclubs) Then
                        westoffer = "Spades"
                        Offer.Suite = "Spades"
                        SuitLabel.Text = Offer.Suite
                        SuitLabel.ForeColor = Color.Red
                        increaseofferpoints()
                    Else
                        westoffer = "PASS"
                        passoffer()
                    End If

                ElseIf eastoffer = "Diamonds" Then
                    If westhasjDiamonds Or westhas9Diamonds Then
                        westoffer = "Diamonds"
                        Offer.Suite = "Diamonds"
                        SuitLabel.Text = Offer.Suite
                        SuitLabel.ForeColor = Color.Red
                        increaseofferpoints()
                        jor9west = True
                    ElseIf jand9east And (westhasAhearts Or westhasASpades Or westhasAclubs) Then
                        westoffer = "Diamonds"
                        Offer.Suite = "Diamonds"
                        SuitLabel.Text = Offer.Suite
                        SuitLabel.ForeColor = Color.Red
                        increaseofferpoints()
                    Else
                        westoffer = "PASS"
                        passoffer()
                    End If

                ElseIf eastoffer = "Clubs" Then
                    If westhasjclubs Or westhas9clubs Then
                        westoffer = "Clubs"
                        Offer.Suite = "Clubs"
                        SuitLabel.Text = Offer.Suite
                        SuitLabel.ForeColor = Color.Red
                        increaseofferpoints()
                        jor9west = True
                    ElseIf jand9east And (westhasAhearts Or westhasASpades Or westhasADiamonds) Then
                        westoffer = "Clubs"
                        Offer.Suite = "Clubs"
                        SuitLabel.Text = Offer.Suite
                        SuitLabel.ForeColor = Color.Red
                        increaseofferpoints()
                    Else
                        westoffer = "PASS"
                        passoffer()
                    End If
                    '''''''''''''''''''''''''''''''''''''''''''''''''''
                ElseIf (westHeartscounter > 3 And westhasjHearts = True And westhas9Hearts = True) Then
                    westoffer = "Hearts"
                    Offer.Suite = "Hearts"
                    SuitLabel.Text = Offer.Suite
                    SuitLabel.ForeColor = Color.Red
                    increaseofferpoints()
                    increaseofferpoints()
                    jand9west = True

                ElseIf (westSpadescounter > 3 And westhasjSpades = True And westhas9Spades = True) Then
                    westoffer = "Spades"
                    Offer.Suite = "Spades"
                    SuitLabel.Text = Offer.Suite
                    SuitLabel.ForeColor = Color.Red
                    increaseofferpoints()
                    increaseofferpoints()
                    jand9west = True


                ElseIf (westClubscounter > 3 And westhasjclubs = True And westhas9clubs = True) Then
                    westoffer = "Clubs"
                    Offer.Suite = "Clubs"
                    SuitLabel.Text = Offer.Suite
                    SuitLabel.ForeColor = Color.Red
                    increaseofferpoints()
                    increaseofferpoints()
                    jand9west = True

                ElseIf (westDiamondscounter > 3 And westhasjDiamonds = True And westhas9Diamonds = True) Then
                    westoffer = "Diamonds"
                    Offer.Suite = "Diamonds"
                    SuitLabel.Text = Offer.Suite
                    SuitLabel.ForeColor = Color.Red
                    increaseofferpoints()
                    increaseofferpoints()
                    jand9west = True

                ElseIf (westHeartscounter > 3 And (westhasjHearts = True Or westhas9Hearts = True)) Then
                    westoffer = "Hearts"
                    Offer.Suite = "Hearts"
                    SuitLabel.Text = Offer.Suite
                    SuitLabel.ForeColor = Color.Red
                    increaseofferpoints()



                ElseIf (westSpadescounter > 3 And (westhasjSpades = True Or westhas9Spades)) Then
                    westoffer = "Spades"
                    Offer.Suite = "Spades"
                    SuitLabel.Text = Offer.Suite
                    SuitLabel.ForeColor = Color.Red
                    increaseofferpoints()



                ElseIf (westClubscounter > 3 And (westhasjclubs = True Or westhas9clubs = True)) Then
                    westoffer = "Clubs"
                    Offer.Suite = "Clubs"
                    SuitLabel.Text = Offer.Suite
                    SuitLabel.ForeColor = Color.Red
                    increaseofferpoints()


                ElseIf (westDiamondscounter > 3 And (westhasjDiamonds = True Or westhas9Diamonds = True)) Then
                    westoffer = "Diamonds"
                    Offer.Suite = "Diamonds"
                    SuitLabel.Text = Offer.Suite
                    SuitLabel.ForeColor = Color.Red
                    increaseofferpoints()


                    '''''WEST OFFERS MONA I DIPLA
                ElseIf (westHeartscounter > 2 And westhasjHearts = True And westhas9Hearts = True And (westhasASpades = True Or westhasAclubs = True Or westhasADiamonds = True)) Then
                    westoffer = "Hearts"
                    Offer.Suite = "Hearts"
                    SuitLabel.Text = Offer.Suite
                    SuitLabel.ForeColor = Color.Red
                    increaseofferpoints()
                    increaseofferpoints()
                    jand9west = True

                ElseIf (westSpadescounter > 2 And westhasjSpades = True And westhas9Spades = True And (westhasAhearts = True Or westhasAclubs = True Or westhasADiamonds = True)) Then
                    westoffer = "Spades"
                    Offer.Suite = "Spades"
                    SuitLabel.Text = Offer.Suite
                    SuitLabel.ForeColor = Color.Red
                    increaseofferpoints()
                    increaseofferpoints()
                    jand9west = True


                ElseIf (westClubscounter > 2 And westhasjclubs = True And westhas9clubs = True And (westhasAhearts = True Or westhasASpades = True Or westhasADiamonds = True)) Then
                    westoffer = "Clubs"
                    Offer.Suite = "Clubs"
                    SuitLabel.Text = Offer.Suite
                    SuitLabel.ForeColor = Color.Red
                    increaseofferpoints()
                    increaseofferpoints()
                    jand9west = True

                ElseIf (westDiamondscounter > 2 And westhasjDiamonds = True And westhas9Diamonds = True And (westhasAhearts = True Or westhasASpades = True Or westhasAclubs = True)) Then
                    westoffer = "Diamonds"
                    Offer.Suite = "Diamonds"
                    SuitLabel.Text = Offer.Suite
                    SuitLabel.ForeColor = Color.Red
                    increaseofferpoints()
                    increaseofferpoints()
                    jand9west = True

                ElseIf (westHeartscounter > 2 And (westhasjHearts = True Or westhas9Hearts = True) And (westhasASpades = True Or westhasAclubs = True Or westhasADiamonds = True)) Then
                    westoffer = "Hearts"
                    Offer.Suite = "Hearts"
                    SuitLabel.Text = Offer.Suite
                    SuitLabel.ForeColor = Color.Red
                    increaseofferpoints()



                ElseIf (westSpadescounter > 2 And (westhasjSpades = True Or westhas9Spades = True) And (westhasAhearts = True Or westhasAclubs = True Or westhasADiamonds = True)) Then
                    westoffer = "Spades"
                    Offer.Suite = "Spades"
                    SuitLabel.Text = Offer.Suite
                    SuitLabel.ForeColor = Color.Red
                    increaseofferpoints()



                ElseIf (westClubscounter > 2 And (westhasjclubs = True Or westhas9clubs = True) And (westhasAhearts = True Or westhasASpades = True Or westhasADiamonds = True)) Then
                    westoffer = "Clubs"
                    Offer.Suite = "Clubs"
                    SuitLabel.Text = Offer.Suite
                    SuitLabel.ForeColor = Color.Red
                    increaseofferpoints()


                ElseIf (westDiamondscounter > 2 And (westhasjDiamonds = True Or westhas9Diamonds = True) And (westhasAhearts = True Or westhasASpades = True Or westhasAclubs = True)) Then
                    westoffer = "Diamonds"
                    Offer.Suite = "Diamonds"
                    SuitLabel.Text = Offer.Suite
                    SuitLabel.ForeColor = Color.Red
                    increaseofferpoints()

                    'DEN ISXYEI O "GENIKOS KANONAS" PROSFORVN ALLA LOGO EXTRA PONTVN KANOYME PROSFORA

                ElseIf (WestHas9 Or WestHas4J Or WestHas4) Then
                    If (westClubscounter > 1 And (westhasjclubs = True And westhas9clubs)) Then
                        westoffer = "Clubs"
                        Offer.Suite = "Clubs"
                        SuitLabel.Text = Offer.Suite
                        SuitLabel.ForeColor = Color.Red
                        increaseofferpoints()
                        increaseofferpoints()
                        jand9west = True

                    ElseIf (westClubscounter > 1 And (westhasjclubs = True Or westhas9clubs)) Then
                        westoffer = "Clubs"
                        Offer.Suite = "Clubs"
                        SuitLabel.Text = Offer.Suite
                        SuitLabel.ForeColor = Color.Red
                        increaseofferpoints()

                    ElseIf (westDiamondscounter > 1 And (westhasjDiamonds = True And westhas9Diamonds)) Then
                        westoffer = "Diamonds"
                        Offer.Suite = "Diamonds"
                        SuitLabel.Text = Offer.Suite
                        SuitLabel.ForeColor = Color.Red
                        increaseofferpoints()
                        increaseofferpoints()
                        jand9west = True

                    ElseIf (westDiamondscounter > 1 And (westhasjDiamonds = True Or westhas9Diamonds)) Then
                        westoffer = "Diamonds"
                        Offer.Suite = "Diamonds"
                        SuitLabel.Text = Offer.Suite
                        SuitLabel.ForeColor = Color.Red
                        increaseofferpoints()

                    ElseIf (westHeartscounter > 1 And (westhasjHearts = True And westhas9Hearts)) Then
                        westoffer = "Hearts"
                        Offer.Suite = "Hearts"
                        SuitLabel.Text = Offer.Suite
                        SuitLabel.ForeColor = Color.Red
                        increaseofferpoints()
                        increaseofferpoints()
                        jand9west = True

                    ElseIf (westHeartscounter > 1 And (westhasjHearts = True Or westhas9Hearts)) Then
                        westoffer = "Hearts"
                        Offer.Suite = "Hearts"
                        SuitLabel.Text = Offer.Suite
                        SuitLabel.ForeColor = Color.Red
                        increaseofferpoints()

                    ElseIf (westHeartscounter > 1 And (westhasjclubs = True And westhas9clubs)) Then
                        westoffer = "Spades"
                        Offer.Suite = "Spades"
                        SuitLabel.Text = Offer.Suite
                        SuitLabel.ForeColor = Color.Red
                        increaseofferpoints()
                        increaseofferpoints()
                        jand9west = True

                    ElseIf (westHeartscounter > 1 And (westhasjclubs = True Or westhas9clubs)) Then
                        westoffer = "Spades"
                        Offer.Suite = "Spades"
                        SuitLabel.Text = Offer.Suite
                        SuitLabel.ForeColor = Color.Red
                        increaseofferpoints()
                    End If
                ElseIf WestHasForth Or WestHasFifth Then
                    If westSpadescounter > 3 And (westhasjSpades = True And westhas9Spades) Then
                        westoffer = "Spades"
                        Offer.Suite = "Spades"
                        SuitLabel.Text = Offer.Suite
                        SuitLabel.ForeColor = Color.Red
                        increaseofferpoints()
                        increaseofferpoints()
                        jand9north = True
                    ElseIf westSpadescounter > 3 And (westhasjSpades = True Or westhas9Spades) Then
                        westoffer = "Spades"
                        Offer.Suite = "Spades"
                        SuitLabel.Text = Offer.Suite
                        SuitLabel.ForeColor = Color.Red
                        increaseofferpoints()


                    ElseIf westHeartscounter > 3 And (westhasjHearts = True And westhas9Hearts) Then
                        westoffer = "Hearts"
                        Offer.Suite = "Hearts"
                        SuitLabel.Text = Offer.Suite
                        SuitLabel.ForeColor = Color.Red
                        increaseofferpoints()
                        increaseofferpoints()
                        jand9north = True

                    ElseIf westHeartscounter > 3 And (westhasjHearts = True Or westhas9Hearts) Then
                        southoffer = "Hearts"
                        Offer.Suite = "Hearts"
                        SuitLabel.Text = Offer.Suite
                        SuitLabel.ForeColor = Color.Red
                        increaseofferpoints()

                    ElseIf westDiamondscounter > 3 And (westhasjDiamonds = True And westhas9Diamonds) Then
                        westoffer = "Diamonds"
                        Offer.Suite = "Diamonds"
                        SuitLabel.Text = Offer.Suite
                        SuitLabel.ForeColor = Color.Red
                        increaseofferpoints()
                        increaseofferpoints()
                        jand9north = True

                    ElseIf westDiamondscounter > 3 And (westhasjDiamonds = True Or westhas9Diamonds) Then
                        westoffer = "Diamonds"
                        Offer.Suite = "Diamonds"
                        SuitLabel.Text = Offer.Suite
                        SuitLabel.ForeColor = Color.Red
                        increaseofferpoints()

                    ElseIf westClubscounter > 3 And (westhasjclubs = True And westhas9clubs) Then
                        westoffer = "Clubs"
                        Offer.Suite = "Clubs"
                        SuitLabel.Text = Offer.Suite
                        SuitLabel.ForeColor = Color.Red
                        increaseofferpoints()
                        increaseofferpoints()
                        jand9north = True

                    ElseIf westClubscounter > 3 And (westhasjclubs = True Or westhas9clubs) Then
                        westoffer = "Clubs"
                        Offer.Suite = "Clubs"
                        SuitLabel.Text = Offer.Suite
                        SuitLabel.ForeColor = Color.Red
                        increaseofferpoints()

                    End If

                Else
                    passoffer()

                End If

            End If
        End If

        If offercounter = 8 Then
            If (SouthHas4 Or NorthHas4 Or SouthHasFifth Or NorthHasFifth Or SouthHasForth Or NorthHasForth Or SouthHas4J Or NorthHas4J Or NorthHas9 Or SouthHas9) Then
                passoffer()
            Else
                If jand9east Then '''''''''''''west  vazei 10

                    If westoffer = "Hearts" And ((westhasASpades And westhas10Spades) Or (westhasAclubs And westhas10Clubs) Or (westhasADiamonds And westhas10Diamonds)) Then
                        westoffer = "Hearts"
                        Offer.Suite = "Hearts"
                        SuitLabel.Text = Offer.Suite
                        SuitLabel.ForeColor = Color.Red
                        increaseofferpoints()
                        verticalheartscounter = verticalheartscounter + 1

                    ElseIf westoffer = "Spades" And ((westhasAhearts And westhas10Hearts) Or (westhasAclubs And westhas10Clubs) Or (westhasADiamonds And westhas10Diamonds)) Then
                        westoffer = "Spades"
                        Offer.Suite = "Spades"
                        SuitLabel.Text = Offer.Suite
                        SuitLabel.ForeColor = Color.Red
                        increaseofferpoints()
                        verticalspadescounter = verticalspadescounter + 1

                    ElseIf westoffer = "Clubs" And ((westhasASpades And westhas10Spades) Or (westhasAhearts And westhas10Hearts) Or (westhasADiamonds And westhas10Diamonds)) Then
                        westoffer = "Clubs"
                        Offer.Suite = "Clubs"
                        SuitLabel.Text = Offer.Suite
                        SuitLabel.ForeColor = Color.Red
                        increaseofferpoints()
                        verticalclubscounter = verticalclubscounter + 1

                    ElseIf westoffer = "Diamonds" And ((westhasASpades And westhas10Spades) Or (westhasAclubs And westhas10Clubs) Or (westhasAhearts And westhas10Hearts)) Then
                        westoffer = "Diamonds"
                        Offer.Suite = "Diamonds"
                        SuitLabel.Text = Offer.Suite
                        SuitLabel.ForeColor = Color.Red
                        increaseofferpoints()
                        verticaldiamondscounter = verticaldiamondscounter + 1

                    Else
                        passoffer()
                    End If
                Else
                    '''''''''''''''''''WEST VAZEI asous GIa EPOMENO GYRO
                    If (westoffer = "Hearts" Or eastoffer = "Hearts") And (westhasASpades Or westhasAclubs Or westhasADiamonds) Then
                        westoffer = "Hearts"
                        Offer.Suite = "Hearts"
                        SuitLabel.Text = Offer.Suite
                        SuitLabel.ForeColor = Color.Red
                        increaseofferpoints()
                        verticalheartscounter = verticalheartscounter + 1

                    ElseIf (westoffer = "Spades" Or eastoffer = "Spades") And (westhasAhearts Or westhasAclubs Or westhasADiamonds) Then
                        westoffer = "Spades"
                        Offer.Suite = "Spades"
                        SuitLabel.Text = Offer.Suite
                        SuitLabel.ForeColor = Color.Red
                        increaseofferpoints()
                        verticalspadescounter = verticalspadescounter + 1

                    ElseIf (westoffer = "Clubs" Or eastoffer = "Clubs") And (westhasAhearts Or westhasASpades Or westhasADiamonds) Then
                        westoffer = "Clubs"
                        Offer.Suite = "Clubs"
                        SuitLabel.Text = Offer.Suite
                        SuitLabel.ForeColor = Color.Red
                        increaseofferpoints()
                        verticalclubscounter = verticalclubscounter + 1

                    ElseIf (westoffer = "Diamonds" Or eastoffer = "Diamonds") And (westhasAhearts Or westhasAclubs Or westhasASpades) Then
                        westoffer = "Diamonds"
                        Offer.Suite = "Diamonds"
                        SuitLabel.Text = Offer.Suite
                        SuitLabel.ForeColor = Color.Red
                        increaseofferpoints()
                        verticaldiamondscounter = verticaldiamondscounter + 1

                    Else
                        westoffer = "PASS"
                        passoffer()
                    End If
                End If

            End If
        End If
        If offercounter = 12 Then
            If (SouthHas4 Or NorthHas4 Or SouthHasFifth Or NorthHasFifth Or SouthHasForth Or NorthHasForth Or SouthHas4J Or NorthHas4J Or NorthHas9 Or SouthHas9) Then
                passoffer()
            Else
                '''''''''east vazei 10
                If jand9east Then
                    passoffer()
                Else
                    If westoffer = "Hearts" And ((westhasASpades And westhas10Spades) Or (westhasAclubs And westhas10Clubs) Or (westhasADiamonds And westhas10Diamonds)) Then
                        westoffer = "Hearts"
                        Offer.Suite = "Hearts"
                        SuitLabel.Text = Offer.Suite
                        SuitLabel.ForeColor = Color.Red
                        increaseofferpoints()
                        verticalheartscounter = verticalheartscounter + 1

                    ElseIf westoffer = "Spades" And ((westhasAhearts And westhas10Hearts) Or (westhasAclubs And westhas10Clubs) Or (westhasADiamonds And westhas10Diamonds)) Then
                        westoffer = "Spades"
                        Offer.Suite = "Spades"
                        SuitLabel.Text = Offer.Suite
                        SuitLabel.ForeColor = Color.Red
                        increaseofferpoints()
                        verticalspadescounter = verticalspadescounter + 1

                    ElseIf westoffer = "Clubs" And ((westhasASpades And westhas10Spades) Or (westhasAhearts And westhas10Hearts) Or (westhasADiamonds And westhas10Diamonds)) Then
                        westoffer = "Clubs"
                        Offer.Suite = "Clubs"
                        SuitLabel.Text = Offer.Suite
                        SuitLabel.ForeColor = Color.Red
                        increaseofferpoints()
                        verticalclubscounter = verticalclubscounter + 1

                    ElseIf westoffer = "Diamonds" And ((westhasASpades And westhas10Spades) Or (westhasAclubs And westhas10Clubs) Or (westhasAhearts And westhas10Hearts)) Then
                        westoffer = "Diamonds"
                        Offer.Suite = "Diamonds"
                        SuitLabel.Text = Offer.Suite
                        SuitLabel.ForeColor = Color.Red
                        increaseofferpoints()
                        verticaldiamondscounter = verticaldiamondscounter + 1

                    Else
                        passoffer()
                    End If
                End If

            End If
        End If
        If offercounter > 12 Then
            passoffer()
        End If

    End Sub
    Public IsAtou(31) As Boolean
    Public VerBought, HorBought As Boolean
    Sub passoffer()
        Dim k As Integer
        SuitLabel.Text = "PASS"
        SuitLabel.ForeColor = Color.Red
        PassCounter = PassCounter + 1


        If PassCounter = 3 And OfferExists Then
            'index = 1
            CurrentOffer.Text = PlayerPlays((PlayerPointer Mod 4))
            Select Case CurrentOffer.Text
                Case "North Offers:", "South Offers:"
                    CurrentOffer.Text = "Vertical Team Bought Current Game"
                    VerBought = True
                Case "East Offers:", "West Offers:"
                    CurrentOffer.Text = "Horizontal Team Bought Current Game"
                    HorBought = True
            End Select

            For k = 0 To 31
                If Xartia(i).Text = Offer.Suite Then
                    IsAtou(i) = True
                End If
            Next

            OFFER_Button.Enabled = False

            Select Case Offer.Suite
                Case "Hearts"
                    For k = 0 To 31

                        If Cards(k) = 5 Then
                            Xartia(k).Tag = 20
                        ElseIf Cards(k) = 3 Then
                            Xartia(k).Tag = 14
                        End If
                    Next

                Case "Diamonds"
                    For k = 0 To 31
                        If Cards(k) = 13 Then
                            Xartia(k).Tag = 20
                        ElseIf Cards(k) = 11 Then
                            Xartia(k).Tag = 14
                        End If
                    Next

                Case "Clubs"
                    For k = 0 To 31
                        If Cards(k) = 21 Then
                            Xartia(k).Tag = 20
                        ElseIf Cards(k) = 19 Then
                            Xartia(k).Tag = 14
                        End If
                    Next

                Case "Spades"
                    For k = 0 To 31
                        If Cards(k) = 29 Then
                            Xartia(k).Tag = 20
                        ElseIf Cards(k) = 27 Then
                            Xartia(k).Tag = 14
                        End If
                    Next

            End Select



            CurrentStronger("Hearts")
            CurrentStronger("Diamonds")
            CurrentStronger("Clubs")
            CurrentStronger("Spades")

            WhoHasCurrentStronger()

            HSP = StrongerPlayed("Hearts")
            DSP = StrongerPlayed("Diamonds")
            CSP = StrongerPlayed("Clubs")
            SSP = StrongerPlayed("Spades")
            'DataForm.HeartsComboBox.Items.Add(HCS)
            'DataForm.DiamondsComboBox.Items.Add(DCS)
            'DataForm.ClubsComboBox.Items.Add(CCS)
            'DataForm.SpadesComboBox.Items.Add(SCS)

            AddCardPointsToDataForm()


            BelotteCheck("North", 0)
            BelotteCheck("East", 8)
            BelotteCheck("South", 16)
            BelotteCheck("West", 24)




         

           

            

            Select Case index
                Case 0
                    If Not Players.One Then
                        NorthPlay.Enabled = True
                    End If
                    For i = 0 To 7
                        Xartia(i).Enabled = True
                    Next
                    For i = 8 To 31
                        Xartia(i).Enabled = False
                    Next
                Case 1
                    EastPlay.Enabled = True
                    For i = 0 To 7
                        Xartia(i).Enabled = False
                    Next
                    For i = 8 To 15
                        Xartia(i).Enabled = True
                    Next
                    For i = 16 To 31
                        Xartia(i).Enabled = False
                    Next
                Case 2
                    SouthPlay.Enabled = True
                    For i = 0 To 15
                        Xartia(i).Enabled = False
                    Next
                    For i = 15 To 23
                        Xartia(i).Enabled = True
                    Next
                    For i = 24 To 31
                        Xartia(i).Enabled = False
                    Next
                Case 3
                    WestPlay.Enabled = True
                    For i = 0 To 23
                        Xartia(i).Enabled = False
                    Next
                    For i = 24 To 31
                        Xartia(i).Enabled = True
                    Next
            End Select

        ElseIf PassCounter = 4 And Not OfferExists Then
            For i = 0 To 31
                Xartia(i).Dispose()
                If (Players.OnePl Or Players.One) And i <> 0 And i <> 1 And i <> 2 And i <> 3 And i <> 4 And i <> 5 And i <> 6 And i <> 7 Then
                    PicBackBox(i).Dispose()
                End If
            Next
            offercounter = 0
            PassCounter = 0
            OFFER_Button.Enabled = False
            DEAL_Button.Enabled = True
        End If




        CurrentOffer.ForeColor() = Color.White
        ' CurrentOffer.Text = PlayerPlays(PlayerPointer Mod 4) & Offer.Suite & " " & Offer.Points
        CurrentOffer1.Text = Offer.Suite & " " & Offer.Points



    End Sub
    Sub Play_Buttons_Enabled()
        Select Case index
            Case 0
                NorthPlay.Enabled = True
                EastPlay.Enabled = False
                SouthPlay.Enabled = False
                WestPlay.Enabled = False
            Case 1
                EastPlay.Enabled = True
                SouthPlay.Enabled = False
                WestPlay.Enabled = False
                NorthPlay.Enabled = False
            Case 2
                SouthPlay.Enabled = True
                NorthPlay.Enabled = False
                EastPlay.Enabled = False
                WestPlay.Enabled = False
            Case 3
                NorthPlay.Enabled = False
                SouthPlay.Enabled = False
                EastPlay.Enabled = False
                WestPlay.Enabled = True
        End Select
    End Sub

    Dim i As Integer

    Sub increaseofferpoints()

        i = i + 1

        Offer.Points = PointButtons(i).Text
        PointButtons(i).Enabled = False
        PointsLabel.Text = "Points: " & Offer.Points
        PointsLabel.ForeColor = Color.Red
        OfferExists = True
        PassCounter = 0

    End Sub

    Sub OfferProcedure()

        Dim i, j, k As Integer

        PlayerPlays(0) = "North Offers:"        'Αρχικοποιήσαμε τις θέσεις των παικτών σε θέσεις πυξίδας για 
        PlayerPlays(1) = "East Offers:"         'καλύτερη κατανόηση.Τις βάλαμε σε πίνακα για να σαρώνονται 
        PlayerPlays(2) = "South Offers:"        'κάθε φορά που κάποιος παίκτης πατάει το κουμπί προσφοράς
        PlayerPlays(3) = "West Offers:"         'για να φαίνεται ποιος παίζει τη φορά αυτή.

        PlayerLabel.Text = PlayerPlays(PlayerPointer Mod 4)   'Η μεταβλήτή pointer είναι κάτι σαν δείκτης
        'πάνω στον πίνακα PlayerPlays και το MOD 4 
        'είναι γιατί η Pointer αυξάνεται πάνω από 4 και εμείς θέλουμε να παίρνει τιμές μόνο από 0 μέχρι 3.
        PlayerPointer = PlayerPointer + 1
        ''''''''
        For i = 0 To 3
            If SuitButtons(i).Checked = True Then
                Offer.Suite = SuitButtons(i).Text
                SuitLabel.Text = "Suit: " & Offer.Suite
                SuitLabel.ForeColor = Color.Red

            End If

        Next
        For i = 1 To 35
            If PointButtons(i).Checked = True Then
                Offer.Points = PointButtons(i).Text
                PointsLabel.Text = "Points: " & Offer.Points
                PointsLabel.ForeColor = Color.Red

                For j = 1 To i
                    PointButtons(j).Enabled = False
                Next
                PassCounter = 0
                OfferExists = True
            End If
        Next
        If PointButtons(36).Checked = True Then
            SuitLabel.Text = "PASS"
            SuitLabel.ForeColor = Color.Red
            PassCounter = PassCounter + 1
            If PassCounter = 3 And OfferExists Then

                CurrentOffer.Text = PlayerPlays((PlayerPointer Mod 4))
                Select Case CurrentOffer.Text
                    Case "North Offers:", "South Offers:"
                        CurrentOffer.Text = "Vertical Team Bought Current Game"
                    Case "East Offers:", "West Offers:"
                        CurrentOffer.Text = "Horizontal Team Bought Current Game"
                End Select



                OFFER_Button.Enabled = False

                Select Case Offer.Suite
                    Case "Hearts"



                        For k = 0 To 31

                            If Cards(k) = 5 Then
                                Xartia(k).Tag = 20
                            ElseIf Cards(k) = 3 Then
                                Xartia(k).Tag = 14
                            End If
                        Next

                    Case "Diamonds"
                        For k = 0 To 31
                            If Cards(k) = 13 Then
                                Xartia(k).Tag = 20
                            ElseIf Cards(k) = 11 Then
                                Xartia(k).Tag = 14
                            End If
                        Next

                    Case "Clubs"
                        For k = 0 To 31
                            If Cards(k) = 21 Then
                                Xartia(k).Tag = 20
                            ElseIf Cards(k) = 19 Then
                                Xartia(k).Tag = 14
                            End If
                        Next

                    Case "Spades"
                        For k = 0 To 31
                            If Cards(k) = 29 Then
                                Xartia(k).Tag = 20
                            ElseIf Cards(k) = 27 Then
                                Xartia(k).Tag = 14
                            End If
                        Next

                End Select
                BelotteCheck("North", 0)
                BelotteCheck("East", 8)
                BelotteCheck("South", 16)
                BelotteCheck("West", 24)


              

                For i = 0 To 7
                    Xartia(i).Enabled = True
                Next
                For i = 8 To 31
                    Xartia(i).Enabled = False
                Next
            ElseIf PassCounter = 4 And Not OfferExists Then
                For i = 0 To 31
                    Xartia(i).Dispose()
                Next
                OFFER_Button.Enabled = False
                DEAL_Button.Enabled = True
            End If
        End If



        CurrentOffer.ForeColor() = Color.Red
        ' CurrentOffer.Text = PlayerPlays(PlayerPointer Mod 4) & Offer.Suite & " " & Offer.Points
        CurrentOffer1.Text = Offer.Suite & " " & Offer.Points

    End Sub



    Private Sub ClearRound_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearRound_Button.Click
        Dim i, VerScor, HorScor, Vtotal, HTotal As Integer

        NAllEnabled = False
        EAllEnabled = False
        SAllEnabled = False
        WAllEnabled = False

        ClearRound_Button.Enabled = False

        PointsCompare()
        RoundCollector()

        For i = 0 To 3
            SuiteCompare(i) = ""
        Next

        If ClickCounter = 32 Then
            ClickCounter = 0
        End If
        Play_Buttons_Enabled()

        If ClickCounter = 0 Then
            Select Case VerBought
                Case True
                    If VerticalTeamPoints > Offer.Points Then
                        If VerticalTeamPoints Mod 10 >= 7 Then
                            VerScor = Offer.Points / 10 + VerticalTeamPoints / 10
                        End If
                        If VerticalTeamPoints Mod 10 <= 6 Then
                            VerScor = Offer.Points / 10 + VerticalTeamPoints / 10
                        End If
                        If HorizontalTeamPoints Mod 10 >= 7 Then
                            HorScor = HorizontalTeamPoints / 10
                        End If
                        If HorizontalTeamPoints Mod 10 <= 6 Then
                            HorScor = HorizontalTeamPoints / 10
                        End If
                    End If
                    If VerticalTeamPoints < Offer.Points Then
                        VerScor = 0
                        HorScor = Offer.Points / 10 + 16 + VerticalOver / 10
                    End If
                Case False
                    If HorizontalTeamPoints > Offer.Points Then
                        If HorizontalTeamPoints Mod 10 >= 7 Then
                            HorScor = Offer.Points / 10 + HorizontalTeamPoints / 10
                        End If
                        If HorizontalTeamPoints Mod 10 <= 6 Then
                            HorScor = Offer.Points / 10 + HorizontalTeamPoints / 10
                        End If
                        If VerticalTeamPoints Mod 10 >= 7 Then
                            VerScor = VerticalTeamPoints / 10
                        End If
                        If VerticalTeamPoints Mod 10 <= 6 Then
                            VerScor = VerticalTeamPoints / 10
                        End If
                    End If
                    If HorizontalTeamPoints < Offer.Points Then
                        HorScor = 0
                        VerScor = Offer.Points / 10 + 16 + HorizontalOver / 10
                    End If
            End Select
            CurrentScore.ContractBox.Items.Add(Offer.Points / 10)
            CurrentScore.VerScore.Items.Add(VerScor)
            CurrentScore.HorScore.Items.Add(HorScor)

            For i = 0 To CurrentScore.VerScore.Items.Count - 1
                Vtotal = Vtotal + Val(CurrentScore.VerScore.Items(i))
                HTotal = HTotal + Val(CurrentScore.HorScore.Items(i))
            Next

            CurrentScore.VerTotal.Text = Vtotal
            CurrentScore.HorTotal.Text = HTotal

        End If
    End Sub

    Sub LastRoundPoints()
        If ClickCounter = 32 Then
            Select Case index
                Case 0, 2
                    VerticalTeamPoints = VerticalTeamPoints + 10
                    VerticalPoints.Text = VerticalTeamPoints
                Case 1, 3
                    HorizontalTeamPoints = HorizontalTeamPoints + 10
                    HorizontalPoints.Text = HorizontalTeamPoints
            End Select
            WhoWins()
            DEAL_Button.Enabled = True
        End If
    End Sub
    Sub WhoWins()

        AddOverPoints()
        VerticalPoints.Text = VerticalTeamPoints
        HorizontalPoints.Text = HorizontalTeamPoints
        Select Case CurrentOffer.Text
            Case "Vertical Team Bought Current Game"

                If Offer.Points <= VerticalTeamPoints Then
                    MsgBox("Won")
                Else
                    MsgBox("Lost")
                End If
            Case "Horizontal Team Bought Current Game"
                If Offer.Points <= HorizontalTeamPoints Then
                    MsgBox("Won")
                Else
                    MsgBox("Lost")
                End If
        End Select
    End Sub
    Function OverPoints(ByVal x, ByVal y, ByVal TextBox, ByVal Player) As Integer
        Dim i, First, Second, Third, Forth, Fifth As Integer
        For i = x To y - 2              ' 'Ελεγχος για πέμπτες
            First = Cards(i)
            Second = Cards(i + 1)
            Third = Cards(i + 2)
            Forth = Cards(i + 3)
            Fifth = Cards(i + 4)
            If Second = First + 1 And Third = Second + 1 And Forth = Third + 1 And Fifth = Forth + 1 And Xartia(i).Text = Xartia(i + 1).Text And Xartia(i + 1).Text = Xartia(i + 2).Text And Xartia(i + 2).Text = Xartia(i + 3).Text And Xartia(i + 3).Text = Xartia(i + 4).Text Then
                'TextBox.Text = "Fifth - 100 points"
                Select Case Player
                    Case "North"
                        NorthHasFifth = True
                        If ClickCounter = 1 Or ClickCounter = 2 Or ClickCounter = 3 Or ClickCounter = 4 Then
                            TextBox.Text = "Fifth - 100 points"

                        End If
                    Case "East"
                        EastHasFifth = True
                        If ClickCounter = 1 Or ClickCounter = 2 Or ClickCounter = 3 Or ClickCounter = 4 Then
                            TextBox.Text = "Fifth - 100 points"

                        End If
                    Case "South"
                        SouthHasFifth = True
                        If ClickCounter = 1 Or ClickCounter = 2 Or ClickCounter = 3 Or ClickCounter = 4 Then
                            TextBox.Text = "Fifth - 100 points"

                        End If
                    Case "West"
                        WestHasFifth = True
                        If ClickCounter = 1 Or ClickCounter = 2 Or ClickCounter = 3 Or ClickCounter = 4 Then
                            TextBox.Text = "Fifth - 100 points"

                        End If
                End Select
                Return First

            End If
        Next
        For i = x To y - 1             ' 'Ελεγχος για τετάρτες
            First = Cards(i)
            Second = Cards(i + 1)
            Third = Cards(i + 2)
            Forth = Cards(i + 3)
            If Second = First + 1 And Third = Second + 1 And Forth = Third + 1 And Xartia(i).Text = Xartia(i + 1).Text And Xartia(i + 1).Text = Xartia(i + 2).Text And Xartia(i + 2).Text = Xartia(i + 3).Text Then
                'TextBox.Text = "Forth - 50 points"
                Select Case Player
                    Case "North"
                        'δήλωση έχει και κάνει την αντίστοιχη boolean μεταβλητή true
                        NorthHasForth = True
                        If ClickCounter = 1 Or ClickCounter = 2 Or ClickCounter = 3 Or ClickCounter = 4 Then
                            TextBox.Text = "Forth - 50 points"

                        End If
                    Case "East"
                        EastHasForth = True
                        If ClickCounter = 1 Or ClickCounter = 2 Or ClickCounter = 3 Or ClickCounter = 4 Then
                            TextBox.Text = "Forth - 50 points"

                        End If
                    Case "South"
                        SouthHasForth = True
                        If ClickCounter = 1 Or ClickCounter = 2 Or ClickCounter = 3 Or ClickCounter = 4 Then
                            TextBox.Text = "Forth - 50 points"

                        End If
                    Case "West"
                        WestHasForth = True
                        If ClickCounter = 1 Or ClickCounter = 2 Or ClickCounter = 3 Or ClickCounter = 4 Then
                            TextBox.Text = "Forth - 50 points"

                        End If
                End Select
                Return First

            End If
        Next
        For i = x To y               ' 'Ελεγχος για τρίτες
            First = Cards(i)
            Second = Cards(i + 1)
            Third = Cards(i + 2)
            If Second = First + 1 And Third = Second + 1 And Xartia(i).Text = Xartia(i + 1).Text And Xartia(i + 1).Text = Xartia(i + 2).Text Then
                'TextBox.Text = "Third - 20 points"
                Select Case Player
                    Case "North"
                        NorthHasThird = True
                        If ClickCounter = 1 Or ClickCounter = 2 Or ClickCounter = 3 Or ClickCounter = 4 Then
                            TextBox.Text = "Third - 20 points"

                        End If
                    Case "East"
                        EastHasThird = True
                        If ClickCounter = 1 Or ClickCounter = 2 Or ClickCounter = 3 Or ClickCounter = 4 Then
                            TextBox.Text = "Third - 20 points"

                        End If
                    Case "South"
                        SouthHasThird = True
                        If ClickCounter = 1 Or ClickCounter = 2 Or ClickCounter = 3 Or ClickCounter = 4 Then
                            TextBox.Text = "Third - 20 points"

                        End If
                    Case "West"
                        WestHasThird = True
                        If ClickCounter = 1 Or ClickCounter = 2 Or ClickCounter = 3 Or ClickCounter = 4 Then
                            TextBox.Text = "Third - 20 points"

                        End If
                End Select
                Return First

            End If
        Next
        If FourofAKindCheck(0) Then
            NorthHas4 = True
        End If
        If FourofAKindCheck(8) Then
            EastHas4 = True
        End If
        If FourofAKindCheck(16) Then
            SouthHas4 = True
        End If
        If FourofAKindCheck(24) Then
            WestHas4 = True
        End If
        '-------------------------------------------------------------------
        If FourofAKindCheckJacks(0) Then
            NorthHas4J = True
        End If
        If FourofAKindCheckJacks(8) Then
            EastHas4J = True
        End If
        If FourofAKindCheckJacks(16) Then
            SouthHas4J = True
        End If
        If FourofAKindCheckJacks(24) Then
            WestHas4J = True
        End If
        '---------------------------------------------------------------------------
        If FourofAKindCheckNines(0) Then
            NorthHas9 = True
        End If
        If FourofAKindCheckNines(8) Then
            EastHas9 = True
        End If
        If FourofAKindCheckNines(16) Then
            SouthHas9 = True
        End If
        If FourofAKindCheckNines(24) Then
            WestHas9 = True
        End If
    End Function
    Dim NorthHasThird, SouthHasThird, EastHasThird, WestHasThird, NorthHasForth, SouthHasForth, EastHasForth, WestHasForth, NorthHasFifth, SouthHasFifth, EastHasFifth, WestHasFifth, NorthHas4J, SouthHas4J, EastHas4J, WestHas4J, NorthHas9, SouthHas9, EastHas9, WestHas9 As Boolean

    Sub WhichDeclarationCounts(ByVal Player As String, ByVal TextBox As TextBox)
        'Ρουτίνα που δείχνει ποια δήλωση μετράει τελικά
        Select Case Player
            Case "North"
                If NorthHas4 Then
                    If EastHasThird Then
                        DeclarationsEast.Text = "Third Can't be Shown"
                        EastHasThird = False
                    ElseIf WestHasThird Then
                        DeclarationsWest.Text = "Third Can't be Shown"
                        WestHasThird = False
                    ElseIf EastHasForth Then
                        DeclarationsEast.Text = "Forth Can't be Shown"
                        EastHasForth = False
                    ElseIf WestHasForth Then
                        DeclarationsWest.Text = "Forth Can't be Shown"
                        WestHasForth = False
                    ElseIf EastHasFifth Then
                        DeclarationsEast.Text = "Fifth Can't be Shown"
                        EastHasFifth = False
                    ElseIf WestHasFifth Then
                        DeclarationsWest.Text = "Fifth Can't be Shown"
                        WestHasFifth = False
                    End If
                End If
            Case "South"
                If SouthHas4 Then
                    If EastHasThird Then
                        DeclarationsEast.Text = "Third Can't be Shown"
                        EastHasThird = False
                    ElseIf WestHasThird Then
                        DeclarationsWest.Text = "Third Can't be Shown"
                        WestHasThird = False
                    ElseIf EastHasForth Then
                        DeclarationsEast.Text = "Forth Can't be Shown"
                        EastHasForth = False
                    ElseIf WestHasForth Then
                        DeclarationsWest.Text = "Forth Can't be Shown"
                        WestHasForth = False
                    ElseIf EastHasFifth Then
                        DeclarationsEast.Text = "Fifth Can't be Shown"
                        EastHasFifth = False
                    ElseIf WestHasFifth Then
                        DeclarationsWest.Text = "Fifth Can't be Shown"
                        WestHasFifth = False
                    End If
                End If
            Case "East"
                If EastHas4 Then
                    If NorthHasThird Then
                        DeclarationsNorth.Text = "Third Can't be Shown"
                        NorthHasThird = False
                    ElseIf SouthHasThird Then
                        DeclarationsSouth.Text = "Third Can't be Shown"
                        SouthHasThird = False
                    ElseIf NorthHasForth Then
                        DeclarationsNorth.Text = "Forth Can't be Shown"
                        NorthHasForth = False
                    ElseIf SouthHasForth Then
                        DeclarationsSouth.Text = "Forth Can't be Shown"
                        SouthHasForth = False
                    ElseIf NorthHasFifth Then
                        DeclarationsNorth.Text = "Fifth Can't be Shown"
                        NorthHasFifth = False
                    ElseIf SouthHasFifth Then
                        DeclarationsSouth.Text = "Fifth Can't be Shown"
                        SouthHasFifth = False
                    End If
                End If
            Case "West"
                If WestHas4 Then
                    If NorthHasThird Then
                        DeclarationsNorth.Text = "Third Can't be Shown"
                        NorthHasThird = False
                    ElseIf SouthHasThird Then
                        DeclarationsSouth.Text = "Third Can't be Shown"
                        SouthHasThird = False
                    ElseIf NorthHasForth Then
                        DeclarationsNorth.Text = "Forth Can't be Shown"
                        NorthHasForth = False
                    ElseIf SouthHasForth Then
                        DeclarationsSouth.Text = "Forth Can't be Shown"
                        SouthHasForth = False
                    ElseIf NorthHasFifth Then
                        DeclarationsNorth.Text = "Fifth Can't be Shown"
                        NorthHasFifth = False
                    ElseIf SouthHasFifth Then
                        DeclarationsSouth.Text = "Fifth Can't be Shown"
                        SouthHasFifth = False
                    End If
                End If
        End Select

        Select Case Player
            Case "North"
                If NorthHasFifth Then
                    If WestHasForth Then
                        DeclarationsWest.Text = "Forth Can't be Shown"
                        WestHasForth = False
                    End If
                    If WestHasThird Then
                        DeclarationsWest.Text = "Third Can't be Shown"
                        WestHasThird = False
                    End If
                    If EastHasForth Then
                        DeclarationsEast.Text = "Forth Can't be Shown"
                        EastHasForth = False
                    End If
                    If EastHasThird Then
                        DeclarationsEast.Text = "Third Can't be Shown"
                        EastHasThird = False
                    End If
                    If EastHas4 Or WestHas4 Then
                        NorthHasFifth = False
                        DeclarationsNorth.Text = "Fifth Can't be Shown"
                    End If

                End If
                If NorthHasFifth And EastHasFifth Then
                    If (OverArray(0) Mod 8) <= (OverArray(1) Mod 8) Then
                        DeclarationsNorth.Text = "Fifth Can't be Shown"
                        NorthHasFifth = False
                    End If
                End If
                If NorthHasFifth And WestHasFifth Then
                    If (OverArray(0) Mod 8) <= (OverArray(3) Mod 8) Then
                        DeclarationsNorth.Text = "Fifth Can't be Shown"
                        NorthHasFifth = False
                    End If
                End If

            Case "South"
                If SouthHasFifth Then
                    If WestHasForth Then
                        DeclarationsWest.Text = "Forth Can't be Shown"
                        WestHasForth = False
                    End If
                    If WestHasThird Then
                        DeclarationsWest.Text = "Third Can't be Shown"
                        WestHasThird = False
                    End If
                    If EastHasForth Then
                        DeclarationsEast.Text = "Forth Can't be Shown"
                        EastHasForth = False
                    End If
                    If EastHasThird Then
                        DeclarationsEast.Text = "Third Can't be Shown"
                        EastHasThird = False
                    End If
                    If EastHas4 Or WestHas4 Then
                        SouthHasFifth = False
                        DeclarationsSouth.Text = "Fifth Can't be Shown"
                    End If
                End If
                If SouthHasFifth And EastHasFifth Then
                    If (OverArray(2) Mod 8) <= (OverArray(1) Mod 8) Then
                        DeclarationsSouth.Text = "Fifth Can't be Shown"
                        SouthHasFifth = False
                    End If
                End If
                If SouthHasFifth And WestHasFifth Then
                    If (OverArray(2) Mod 8) <= (OverArray(3) Mod 8) Then
                        DeclarationsSouth.Text = "Fifth Can't be Shown"
                        SouthHasFifth = False
                    End If
                End If

            Case "East"
                If EastHasFifth Then
                    If NorthHasForth Then
                        DeclarationsNorth.Text = "Forth Can't be Shown"
                        NorthHasForth = False
                    End If
                    If NorthHasThird Then
                        DeclarationsNorth.Text = "Third Can't be Shown"
                        NorthHasThird = False
                    End If
                    If SouthHasForth Then
                        DeclarationsSouth.Text = "Fourth Can't be Shown"
                        SouthHasForth = False
                    End If
                    If SouthHasThird Then
                        DeclarationsSouth.Text = "Third Can't be Shown"
                        SouthHasThird = False
                    End If
                    If NorthHas4 Or SouthHas4 Then
                        EastHasFifth = False
                        DeclarationsEast.Text = "Fifth Can't be Shown"
                    End If
                End If
                If EastHasFifth And SouthHasFifth Then
                    If (OverArray(1) Mod 8) <= (OverArray(2) Mod 8) Then
                        DeclarationsEast.Text = "Fifth Can't be Shown"
                        EastHasFifth = False
                    End If
                End If
                If EastHasFifth And NorthHasFifth Then
                    If (OverArray(1) Mod 8) <= (OverArray(0) Mod 8) Then
                        DeclarationsEast.Text = "Fifth Can't be Shown"
                        EastHasFifth = False
                    End If
                End If

            Case "West"
                If WestHasFifth Then
                    If NorthHasForth Then
                        DeclarationsNorth.Text = "Forth Can't be Shown"
                        NorthHasForth = False
                    End If
                    If NorthHasThird Then
                        DeclarationsNorth.Text = "Third Can't be Shown"
                        NorthHasThird = False
                    End If
                    If SouthHasForth Then
                        DeclarationsSouth.Text = "Fourth Can't be Shown"
                        SouthHasForth = False
                    End If
                    If SouthHasThird Then
                        DeclarationsSouth.Text = "Third Can't be Shown"
                        SouthHasThird = False
                    End If
                    If NorthHas4 Or SouthHas4 Then
                        WestHasFifth = False
                        DeclarationsWest.Text = "Fifth Can't be Shown"
                    End If
                End If
                If WestHasFifth And SouthHasFifth Then
                    If (OverArray(3) Mod 8) <= (OverArray(2) Mod 8) Then
                        DeclarationsWest.Text = "Fifth Can't be Shown"
                        WestHasFifth = False
                    End If
                End If
                If WestHasFifth And NorthHasFifth Then
                    If (OverArray(3) Mod 8) <= (OverArray(0) Mod 8) Then
                        DeclarationsWest.Text = "Fifth Can't be Shown"
                        WestHasFifth = False
                    End If
                End If
        End Select
        '-----------------------------------------------------------------------
        Select Case Player
            Case "North"
                If NorthHasForth Then
                    If WestHasThird Then
                        DeclarationsWest.Text = "Third Can't be Shown"
                        WestHasThird = False
                    End If
                    If EastHasThird Then
                        DeclarationsEast.Text = "Third Can't be Shown"
                        EastHasThird = False
                    End If
                    If WestHasFifth Or EastHasFifth Or WestHas4 Or EastHas4 Then
                        NorthHasForth = False
                        DeclarationsNorth.Text = "Forth Can't be Shown"
                    End If
                End If
                If NorthHasForth And EastHasForth Then
                    If (OverArray(0) Mod 8) <= (OverArray(1) Mod 8) Then
                        DeclarationsNorth.Text = "Forth Can't be Shown"
                        NorthHasForth = False
                    End If
                End If
                If NorthHasForth And WestHasForth Then
                    If (OverArray(0) Mod 8) <= (OverArray(3) Mod 8) Then
                        DeclarationsNorth.Text = "Forth Can't be Shown"
                        NorthHasForth = False
                    End If
                End If

            Case "East"
                If EastHasForth Then
                    If NorthHasThird Then
                        DeclarationsNorth.Text = "Third Can't be Shown"
                        NorthHasThird = False
                    End If
                    If SouthHasThird Then
                        DeclarationsSouth.Text = "Third Can't be Shown"
                        SouthHasThird = False
                    End If
                    If NorthHasFifth Or SouthHasFifth Or NorthHas4 Or SouthHas4 Then
                        DeclarationsEast.Text = "Forth Can't be Shown"
                        EastHasForth = False
                    End If
                End If
                If EastHasForth And SouthHasForth Then
                    If (OverArray(1) Mod 8) <= (OverArray(2) Mod 8) Then
                        DeclarationsEast.Text = "Forth Can't be Shown"
                        EastHasForth = False
                    End If
                End If
                If EastHasForth And NorthHasForth Then
                    If (OverArray(1) Mod 8) <= (OverArray(0) Mod 8) Then
                        DeclarationsEast.Text = "Forth Can't be Shown"
                        EastHasForth = False
                    End If
                End If

            Case "South"
                If SouthHasForth Then
                    If WestHasThird Then
                        DeclarationsWest.Text = "Third Can't be Shown"
                        WestHasThird = False
                    End If
                    If EastHasThird Then
                        DeclarationsEast.Text = "Third Can't be Shown"
                        EastHasThird = False
                    End If
                    If WestHasFifth Or EastHasFifth Or WestHas4 Or EastHas4 Then
                        SouthHasForth = False
                        DeclarationsSouth.Text = "Forth Can't be Shown"
                    End If
                End If
                If SouthHasForth And EastHasForth Then
                    If (OverArray(2) Mod 8) <= (OverArray(1) Mod 8) Then
                        DeclarationsSouth.Text = "Forth Can't be Shown"
                        SouthHasForth = False
                    End If
                End If
                If SouthHasForth And WestHasForth Then
                    If (OverArray(2) Mod 8) <= (OverArray(3) Mod 8) Then
                        DeclarationsSouth.Text = "Forth Can't be Shown"
                        SouthHasForth = False
                    End If
                End If
            Case "West"
                If WestHasForth Then
                    If NorthHasThird Then
                        DeclarationsNorth.Text = "Third Can't be Shown"
                        NorthHasThird = False
                    End If
                    If SouthHasThird Then
                        DeclarationsSouth.Text = "Third Can't be Shown"
                        SouthHasThird = False
                    End If
                    If NorthHasFifth Or SouthHasFifth Or NorthHas4 Or SouthHas4 Then
                        WestHasForth = False
                        DeclarationsWest.Text = "Forth Can't be Shown"
                    End If
                End If
                If WestHasForth And SouthHasForth Then
                    If (OverArray(3) Mod 8) <= (OverArray(2) Mod 8) Then
                        DeclarationsWest.Text = "Forth Can't be Shown"
                        WestHasForth = False
                    End If
                End If
                If WestHasForth And NorthHasForth Then
                    If (OverArray(3) Mod 8) <= (OverArray(0) Mod 8) Then
                        DeclarationsWest.Text = "Forth Can't be Shown"
                        WestHasForth = False
                    End If
                End If
        End Select

        '-------------------------------------------------------------------------------

        Select Case Player
            '1)
            Case "North"
                If NorthHasThird And WestHasThird Then
                    If (OverArray(0) Mod 8) <= (OverArray(3) Mod 8) Then  'Στον πίνακα OverArray αποθηκεύσαμε τον αριθμό από το πρώτο χαρτί 
                        DeclarationsNorth.Text = "Third Can't be Shown"   'κάθε δήλωσης του εκάστοτε παίκτη(αν έχει) και το κάνουμε mod 8
                        NorthHasThird = False                               'γιατί θέλουμε να ξέρουμε αν το χαρτί ειναί το ίδιο με το άλλο   
                    End If                                                  'δε μετράει καμία(εκτός βέβεια αν η μία εκ των δύο αποτελείται από ατού!
                End If                                                   'που συγκρίνουμε(ως προσ την τιμή και όχι τη φυλή, δηλ.δύο βαλέδες) Αυτό επιτυγχάνεται καθώς έχουμε προκαθορίσει τις ονομασίες των χαρτιών
                If NorthHasThird And EastHasThird Then                            'στο φάκελο cards-classic και επειδή είναι ανά οκτάδες(8 από κάθε φυλή)      
                    'χρησιμοποιούμε το Mod 8!!!  Έτσι, αν δυο δηλώσεις είναι ίδιες, τοτε δε μετράει καμία(εκτός βέβεια αν η μία εκ των δύο αποτελείται από ατού!!! 
                    If (OverArray(0) Mod 8) <= (OverArray(1) Mod 8) Then
                        DeclarationsNorth.Text = "Third Can't be Shown"
                        NorthHasThird = False
                    End If
                End If
                If NorthHasThird And (WestHasForth Or EastHasForth Or WestHasFifth Or EastHasFifth Or WestHas4 Or EastHas4) Then
                    NorthHasThird = False
                    DeclarationsNorth.Text = "Third Can't be Shown"
                End If
            Case "East"
                '2)         
                If EastHasThird And NorthHasThird Then
                    If (OverArray(1) Mod 8) <= (OverArray(0) Mod 8) Then
                        DeclarationsEast.Text = "Third Can't be Shown"
                        EastHasThird = False
                    End If
                End If
                If EastHasThird And SouthHasThird Then
                    If (OverArray(1) Mod 8) <= (OverArray(2) Mod 8) Then
                        DeclarationsEast.Text = "Third Can't be Shown"
                        EastHasThird = False
                    End If
                End If
                If EastHasThird And (NorthHasForth Or SouthHasForth Or NorthHasFifth Or SouthHasFifth Or NorthHas4 Or SouthHas4) Then
                    EastHasThird = False
                    DeclarationsEast.Text = "Third Can't be Shown"
                End If
            Case "South"
                '3)
                If SouthHasThird And EastHasThird Then
                    If (OverArray(2) Mod 8) <= (OverArray(1) Mod 8) Then
                        DeclarationsSouth.Text = "Third Can't be Shown"
                        SouthHasThird = False
                    End If
                End If
                If SouthHasThird And WestHasThird Then
                    If (OverArray(2) Mod 8) <= (OverArray(3) Mod 8) Then
                        DeclarationsSouth.Text = "Third Can't be Shown"
                        SouthHasThird = False
                    End If
                End If
                If SouthHasThird And (WestHasForth Or EastHasForth Or WestHasFifth Or EastHasFifth Or WestHas4 Or EastHas4) Then
                    SouthHasThird = False
                    DeclarationsSouth.Text = "Third Can't be Shown"
                End If
            Case "West"
                '4)
                If WestHasThird And SouthHasThird Then
                    If (OverArray(3) Mod 8) <= (OverArray(2) Mod 8) Then
                        DeclarationsWest.Text = "Third Can't be Shown"
                        WestHasThird = False
                    End If
                End If
                If WestHasThird And NorthHasThird Then
                    If (OverArray(3) Mod 8) <= (OverArray(0) Mod 8) Then
                        DeclarationsWest.Text = "Third Can't be Shown"
                        WestHasThird = False
                    End If
                End If
                If WestHasThird And (NorthHasForth Or SouthHasForth Or NorthHasFifth Or SouthHasFifth Or NorthHas4 Or SouthHas4) Then
                    WestHasThird = False
                    DeclarationsWest.Text = "Third Can't be Shown"
                End If
        End Select
        '---------------------------------------------------------




    End Sub


    Sub ShowFifth(ByVal x As Integer, ByVal y As Integer, ByVal z As Integer, ByVal n As Integer)

        Dim i, First, Second, Third, Forth, Fifth As Integer
        For i = x To y - 2              ' 'Ελεγχος για πέμπτες
            First = Cards(i)
            Second = Cards(i + 1)
            Third = Cards(i + 2)
            Forth = Cards(i + 3)
            Fifth = Cards(i + 4)

            If Second = First + 1 And Third = Second + 1 And Forth = Third + 1 And Fifth = Forth + 1 And Xartia(i).Text = Xartia(i + 1).Text And Xartia(i + 1).Text = Xartia(i + 2).Text And Xartia(i + 2).Text = Xartia(i + 3).Text And Xartia(i + 3).Text = Xartia(i + 4).Text Then


                If ClickCounter = 5 Or ClickCounter = 6 Or ClickCounter = 7 Or ClickCounter = 8 Then
                    If Not Clicked(i) Then
                        Xartia(i).SetBounds(30 * (i + z), n, 72, 96)
                        If Players.OnePl And i <> 1 And i <> 2 And i <> 3 And i <> 4 And i <> 5 And i <> 6 And i <> 7 Then
                            PicBackBox(i).Visible = False
                        End If
                    End If
                    If Not Clicked(i + 1) Then
                        Xartia(i + 1).SetBounds(30 * (i + z + 1), n, 72, 96)
                        If Players.OnePl And i <> 1 And i <> 2 And i <> 3 And i <> 4 And i <> 5 And i <> 6 And i <> 7 Then
                            PicBackBox(i + 1).Visible = False
                        End If
                    End If
                    If Not Clicked(i + 2) Then
                        Xartia(i + 2).SetBounds(30 * (i + z + 2), n, 72, 96)
                        If Players.OnePl And i <> 1 And i <> 2 And i <> 3 And i <> 4 And i <> 5 And i <> 6 And i <> 7 Then
                            PicBackBox(i + 2).Visible = False
                        End If
                    End If
                    If Not Clicked(i + 3) Then
                        Xartia(i + 3).SetBounds(30 * (i + z + 3), n, 72, 96)
                        If Players.OnePl And i <> 1 And i <> 2 And i <> 3 And i <> 4 And i <> 5 And i <> 6 And i <> 7 Then
                            PicBackBox(i + 3).Visible = False
                        End If
                    End If
                    If Not Clicked(i + 4) Then
                        Xartia(i + 4).SetBounds(30 * (i + z + 4), n, 72, 96)
                        If Players.OnePl And i <> 1 And i <> 2 And i <> 3 And i <> 4 And i <> 5 And i <> 6 And i <> 7 Then
                            PicBackBox(i + 4).Visible = False
                        End If
                    End If
                End If
                'Επιστρέφει true αν πραγματικά υπάρχει δήλωση, με σκοπό να τη χρησιμοποιήσουμε
            End If          'όταν θέλουμε να κρυφτούν τα χαρτιά
        Next
    End Sub
    Sub ShowForth(ByVal x As Integer, ByVal y As Integer, ByVal z As Integer, ByVal n As Integer)

        Dim i, First, Second, Third, Forth As Integer
        For i = x To y - 1              ' 'Ελεγχος για τετάρτες
            First = Cards(i)
            Second = Cards(i + 1)
            Third = Cards(i + 2)
            Forth = Cards(i + 3)

            If Second = First + 1 And Third = Second + 1 And Forth = Third + 1 And Xartia(i).Text = Xartia(i + 1).Text And Xartia(i + 1).Text = Xartia(i + 2).Text And Xartia(i + 2).Text = Xartia(i + 3).Text Then

                If ClickCounter = 5 Or ClickCounter = 6 Or ClickCounter = 7 Or ClickCounter = 8 Then
                    If Not Clicked(i) Then
                        Xartia(i).SetBounds(30 * (i + z), n, 72, 96)
                        If Players.OnePl And i <> 0 And i <> 1 And i <> 2 And i <> 3 And i <> 4 And i <> 5 And i <> 6 And i <> 7 Then
                            PicBackBox(i).Visible = False
                        End If
                    End If
                    If Not Clicked(i + 1) Then
                        Xartia(i + 1).SetBounds(30 * (i + z + 1), n, 72, 96)
                        If Players.OnePl And i <> 0 And i <> 1 And i <> 2 And i <> 3 And i <> 4 And i <> 5 And i <> 6 And i <> 7 Then
                            PicBackBox(i + 1).Visible = False
                        End If
                    End If
                    If Not Clicked(i + 2) Then
                        Xartia(i + 2).SetBounds(30 * (i + z + 2), n, 72, 96)
                        If Players.OnePl And i <> 0 And i <> 1 And i <> 2 And i <> 3 And i <> 4 And i <> 5 And i <> 6 And i <> 7 Then
                            PicBackBox(i + 2).Visible = False
                        End If
                    End If
                    If Not Clicked(i + 3) Then
                        Xartia(i + 3).SetBounds(30 * (i + z + 3), n, 72, 96)
                        If Players.OnePl And i <> 0 And i <> 1 And i <> 2 And i <> 3 And i <> 4 And i <> 5 And i <> 6 And i <> 7 Then
                            PicBackBox(i + 3).Visible = False
                        End If
                    End If
                End If
                'Επιστρέφει true αν πραγματικά υπάρχει δήλωση, με σκοπό να τη χρησιμοποιήσουμε
            End If          'όταν θέλουμε να κρυφτούν τα χαρτιά

        Next
    End Sub
    Dim DeclarationArray(7) As String
    Sub ShowThird(ByVal X As Integer, ByVal y As Integer, ByVal z As Integer, ByVal n As Integer)
        Dim i, First, Second, Third As Integer
        For i = X To y               ' 'Ελεγχος για τρίτες
            First = Cards(i)
            Second = Cards(i + 1)
            Third = Cards(i + 2)

            If Second = First + 1 And Third = Second + 1 And Xartia(i).Text = Xartia(i + 1).Text And Xartia(i + 1).Text = Xartia(i + 2).Text Then

                If ClickCounter = 5 Or ClickCounter = 6 Or ClickCounter = 7 Or ClickCounter = 8 Then
                    If Clicked(i) = False Then
                        Xartia(i).SetBounds(30 * (i + z), n, 72, 96)
                        If Players.OnePl And i <> 0 And i <> 1 And i <> 2 And i <> 3 And i <> 4 And i <> 5 And i <> 6 And i <> 7 Then
                            PicBackBox(i).Visible = False
                        End If
                        DeclarationArray(0) = CardName(i)
                    End If
                    If Clicked(i + 1) = False Then
                        Xartia(i + 1).SetBounds(30 * (i + z + 1), n, 72, 96)
                        If Players.OnePl And i <> 0 And i <> 1 And i <> 2 And i <> 3 And i <> 4 And i <> 5 And i <> 6 And i <> 7 Then
                            PicBackBox(i + 1).Visible = False
                        End If
                        DeclarationArray(1) = CardName(i + 1)
                    End If
                    If Clicked(i + 2) = False Then
                        Xartia(i + 2).SetBounds(30 * (i + z + 2), n, 72, 96)
                        If Players.OnePl And i <> 0 And i <> 1 And i <> 2 And i <> 3 And i <> 4 And i <> 5 And i <> 6 And i <> 7 Then
                            PicBackBox(i + 2).Visible = False
                        End If
                        DeclarationArray(2) = CardName(i + 2)
                    End If


                End If
                'Επιστρέφει true αν πραγματικά υπάρχει δήλωση, με σκοπό να τη χρησιμοποιήσουμε

            End If          'όταν θέλουμε να κρυφτούν τα χαρτιά
        Next
    End Sub
    Sub ShowFourOfAKind(ByVal n As Integer, ByVal m As Integer, ByVal k As Integer)

        Dim i As Integer
        If ClickCounter = 5 Or ClickCounter = 6 Or ClickCounter = 7 Or ClickCounter = 8 Then
            For i = n To n + 7
                If FourArray(i) Then
                    If Not Clicked(i) Then
                        Xartia(i).SetBounds(30 * (i + m), k, 72, 96)
                        If Players.OnePl And i <> 0 And i <> 1 And i <> 2 And i <> 3 And i <> 4 And i <> 5 And i <> 6 And i <> 7 Then
                            PicBackBox(i).Visible = False
                        End If
                    End If
                End If

            Next
        End If
    End Sub
    Sub ShowFourOfAKindJacks(ByVal n As Integer, ByVal m As Integer, ByVal k As Integer)

        Dim i As Integer
        If ClickCounter = 5 Or ClickCounter = 6 Or ClickCounter = 7 Or ClickCounter = 8 Then
            For i = n To n + 7
                If FourArrayJ(i) Then
                    If Not Clicked(i) Then
                        Xartia(i).SetBounds(30 * (i + m), k, 72, 96)
                    End If
                End If

            Next
        End If
    End Sub
    Sub ShowFourOfAKindNines(ByVal n As Integer, ByVal m As Integer, ByVal k As Integer)

        Dim i As Integer
        If ClickCounter = 5 Or ClickCounter = 6 Or ClickCounter = 7 Or ClickCounter = 8 Then
            For i = n To n + 7
                If FourArray9(i) Then
                    If Not Clicked(i) Then
                        Xartia(i).SetBounds(30 * (i + m), k, 72, 96)
                    End If
                End If

            Next
        End If
    End Sub
    Sub HideThird(ByVal x As Integer, ByVal y As Integer, ByVal z As Integer, ByVal n As Integer)
        Dim i, First, Second, Third As Integer
        For i = x To y
            First = Cards(i)
            Second = Cards(i + 1)
            Third = Cards(i + 2)

            If Second = First + 1 And Third = Second + 1 And Xartia(i).Text = Xartia(i + 1).Text And Xartia(i + 1).Text = Xartia(i + 2).Text Then

                If ClickCounter = 9 Or ClickCounter = 10 Or ClickCounter = 11 Or ClickCounter = 12 Then
                    If Clicked(i) = False Then
                        Xartia(i).SetBounds(30 * (i + z), n + 10, 72, 96)
                        If Players.OnePl And i <> 0 And i <> 1 And i <> 2 And i <> 3 And i <> 4 And i <> 5 And i <> 6 And i <> 7 Then
                            PicBackBox(i).Visible = True
                        End If
                    End If
                    If Clicked(i + 1) = False Then
                        Xartia(i + 1).SetBounds(30 * (i + z + 1), n + 10, 72, 96)
                        If Players.OnePl And i <> 0 And i <> 1 And i <> 2 And i <> 3 And i <> 4 And i <> 5 And i <> 6 And i <> 7 Then
                            PicBackBox(i + 1).Visible = True
                        End If
                    End If
                    If Clicked(i + 2) = False Then
                        Xartia(i + 2).SetBounds(30 * (i + z + 2), n + 10, 72, 96)
                        If Players.OnePl And i <> 0 And i <> 1 And i <> 2 And i <> 3 And i <> 4 And i <> 5 And i <> 6 And i <> 7 Then
                            PicBackBox(i + 2).Visible = True
                        End If
                    End If
                End If
            End If
        Next
    End Sub
    Sub HideForth(ByVal x As Integer, ByVal y As Integer, ByVal z As Integer, ByVal n As Integer)
        Dim i, First, Second, Third, Forth As Integer
        For i = x To y - 1             ' 'Ελεγχος για τετάρτες
            First = Cards(i)
            Second = Cards(i + 1)
            Third = Cards(i + 2)
            Forth = Cards(i + 3)

            If Second = First + 1 And Third = Second + 1 And Forth = Third + 1 And Xartia(i).Text = Xartia(i + 1).Text And Xartia(i + 1).Text = Xartia(i + 2).Text And Xartia(i + 2).Text = Xartia(i + 3).Text Then

                If ClickCounter = 9 Or ClickCounter = 10 Or ClickCounter = 11 Or ClickCounter = 12 Then
                    If Not Clicked(i) Then
                        Xartia(i).SetBounds(30 * (i + z), n + 10, 72, 96)
                        If Players.OnePl And i <> 0 And i <> 1 And i <> 2 And i <> 3 And i <> 4 And i <> 5 And i <> 6 And i <> 7 Then
                            PicBackBox(i).Visible = True
                        End If
                    End If
                    If Not Clicked(i + 1) Then
                        Xartia(i + 1).SetBounds(30 * (i + z + 1), n + 10, 72, 96)
                        If Players.OnePl And i <> 0 And i <> 1 And i <> 2 And i <> 3 And i <> 4 And i <> 5 And i <> 6 And i <> 7 Then
                            PicBackBox(i + 1).Visible = True
                        End If
                    End If
                    If Not Clicked(i + 2) Then
                        Xartia(i + 2).SetBounds(30 * (i + z + 2), n + 10, 72, 96)
                        If Players.OnePl And i <> 0 And i <> 1 And i <> 2 And i <> 3 And i <> 4 And i <> 5 And i <> 6 And i <> 7 Then
                            PicBackBox(i + 2).Visible = True
                        End If
                    End If
                    If Not Clicked(i + 3) Then
                        Xartia(i + 3).SetBounds(30 * (i + z + 3), n + 10, 72, 96)
                        If Players.OnePl And i <> 0 And i <> 1 And i <> 2 And i <> 3 And i <> 4 And i <> 5 And i <> 6 And i <> 7 Then
                            PicBackBox(i + 3).Visible = True
                        End If
                    End If
                End If
            End If
        Next
    End Sub
    Sub HideFifth(ByVal x As Integer, ByVal y As Integer, ByVal z As Integer, ByVal n As Integer)

        Dim i, First, Second, Third, Forth, Fifth As Integer
        For i = x To y - 2              ' 'Ελεγχος για πέμπτες
            First = Cards(i)
            Second = Cards(i + 1)
            Third = Cards(i + 2)
            Forth = Cards(i + 3)
            Fifth = Cards(i + 4)

            If Second = First + 1 And Third = Second + 1 And Forth = Third + 1 And Fifth = Forth + 1 And Xartia(i).Text = Xartia(i + 1).Text And Xartia(i + 1).Text = Xartia(i + 2).Text And Xartia(i + 2).Text = Xartia(i + 3).Text And Xartia(i + 3).Text = Xartia(i + 4).Text Then


                If ClickCounter = 9 Or ClickCounter = 10 Or ClickCounter = 11 Or ClickCounter = 12 Then
                    If Not Clicked(i) Then
                        Xartia(i).SetBounds(30 * (i + z), n + 10, 72, 96)
                        If Players.OnePl And i <> 0 And i <> 1 And i <> 2 And i <> 3 And i <> 4 And i <> 5 And i <> 6 And i <> 7 Then
                            PicBackBox(i).Visible = True
                        End If
                    End If
                    If Not Clicked(i + 1) Then
                        Xartia(i + 1).SetBounds(30 * (i + z + 1), n + 10, 72, 96)
                        If Players.OnePl And i <> 0 And i <> 1 And i <> 2 And i <> 3 And i <> 4 And i <> 5 And i <> 6 And i <> 7 Then
                            PicBackBox(i + 1).Visible = True
                        End If
                    End If
                    If Not Clicked(i + 2) Then
                        Xartia(i + 2).SetBounds(30 * (i + z + 2), n + 10, 72, 96)
                        If Players.OnePl And i <> 0 And i <> 1 And i <> 2 And i <> 3 And i <> 4 And i <> 5 And i <> 6 And i <> 7 Then
                            PicBackBox(i + 2).Visible = True
                        End If
                    End If
                    If Not Clicked(i + 3) Then
                        Xartia(i + 3).SetBounds(30 * (i + z + 3), n + 10, 72, 96)
                        If Players.OnePl And i <> 0 And i <> 1 And i <> 2 And i <> 3 And i <> 4 And i <> 5 And i <> 6 And i <> 7 Then
                            PicBackBox(i + 3).Visible = True
                        End If
                    End If
                    If Not Clicked(i + 4) Then
                        Xartia(i + 4).SetBounds(30 * (i + z + 4), n + 10, 72, 96)
                        If Players.OnePl And i <> 0 And i <> 1 And i <> 2 And i <> 3 And i <> 4 And i <> 5 And i <> 6 And i <> 7 Then
                            PicBackBox(i + 4).Visible = True
                        End If
                    End If
                End If
            End If
        Next
    End Sub
    Sub HideFourOfAKind(ByVal n As Integer, ByVal z As Integer, ByVal m As Integer)
        Dim i As Integer
        If ClickCounter = 9 Or ClickCounter = 10 Or ClickCounter = 11 Or ClickCounter = 12 Then
            For i = n To n - 7 Step -1
                If Not Clicked(i) Then
                    Xartia(i).SetBounds(30 * (i + z), m, 72, 96)
                    If Players.OnePl And i <> 0 And i <> 1 And i <> 2 And i <> 3 And i <> 4 And i <> 5 And i <> 6 And i <> 7 Then
                        PicBackBox(i).Visible = True
                    End If
                End If
            Next
        End If
    End Sub

    Public VerticalOver, HorizontalOver As Integer
    Sub AddOverPoints()



        If CurrentOffer.Text = "Vertical Team Bought Current Game" Then
            Select Case NorthHasThird
                Case True
                    VerticalOver = 20
                    If SouthHasThird Then
                        VerticalOver = VerticalOver + 20
                    End If
                    If SouthHasForth Then
                        VerticalOver = VerticalOver + 50
                    End If
                    If SouthHasFifth Then
                        VerticalOver = VerticalOver + 100
                    End If
            End Select

            Select Case NorthHasForth
                Case True
                    VerticalOver = 50
                    If SouthHasThird Then
                        VerticalOver = VerticalOver + 20
                    End If
                    If SouthHasForth Then
                        VerticalOver = VerticalOver + 50
                    End If
                    If SouthHasFifth Then
                        VerticalOver = VerticalOver + 100
                    End If
            End Select

            Select Case NorthHasFifth
                Case True
                    VerticalOver = 100
                    If SouthHasThird Then
                        VerticalOver = VerticalOver + 20
                    End If
                    If SouthHasForth Then
                        VerticalOver = VerticalOver + 50
                    End If
                    If SouthHasFifth Then
                        VerticalOver = VerticalOver + 100
                    End If
            End Select


            Select Case SouthHasThird
                Case True
                    VerticalOver = 20
                    If NorthHasThird Then
                        VerticalOver = VerticalOver + 20
                    End If
                    If NorthHasForth Then
                        VerticalOver = VerticalOver + 50
                    End If
                    If NorthHasFifth Then
                        VerticalOver = VerticalOver + 100
                    End If
            End Select

            Select Case SouthHasForth
                Case True
                    VerticalOver = 50
                    If NorthHasThird Then
                        VerticalOver = VerticalOver + 20
                    End If
                    If NorthHasForth Then
                        VerticalOver = VerticalOver + 50
                    End If
                    If NorthHasFifth Then
                        VerticalOver = VerticalOver + 100
                    End If
            End Select

            Select Case SouthHasFifth
                Case True
                    VerticalOver = 100
                    If NorthHasThird Then
                        VerticalOver = VerticalOver + 20
                    End If
                    If NorthHasForth Then
                        VerticalOver = VerticalOver + 50
                    End If
                    If NorthHasFifth Then
                        VerticalOver = VerticalOver + 100
                    End If
            End Select

            If NorthHasBelotte Or SouthHasBelotte Then
                VerticalOver = VerticalOver + 20
            End If
            If NorthHas4 Then
                VerticalOver = VerticalOver + 100
            End If
            If SouthHas4 Then
                VerticalOver = VerticalOver + 100
            End If
        End If

        If CurrentOffer.Text = "Horizontal Team Bought Current Game" Then
            Select Case EastHasThird
                Case True
                    HorizontalOver = 20
                    If WestHasThird Then
                        HorizontalOver = HorizontalOver + 20
                    End If
                    If WestHasForth Then
                        HorizontalOver = HorizontalOver + 50
                    End If
                    If WestHasFifth Then
                        HorizontalOver = HorizontalOver + 100
                    End If
            End Select

            Select Case EastHasForth
                Case True
                    HorizontalOver = 50
                    If WestHasThird Then
                        HorizontalOver = HorizontalOver + 20
                    End If
                    If WestHasForth Then
                        HorizontalOver = HorizontalOver + 50
                    End If
                    If WestHasFifth Then
                        HorizontalOver = HorizontalOver + 100
                    End If
            End Select

            Select Case EastHasFifth
                Case True
                    HorizontalOver = 100
                    If WestHasThird Then
                        HorizontalOver = HorizontalOver + 20
                    End If
                    If WestHasForth Then
                        HorizontalOver = HorizontalOver + 50
                    End If
                    If WestHasFifth Then
                        HorizontalOver = HorizontalOver + 100
                    End If
            End Select

            Select Case WestHasThird
                Case True
                    HorizontalOver = 20
                    If EastHasThird Then
                        HorizontalOver = HorizontalOver + 20
                    End If
                    If EastHasForth Then
                        HorizontalOver = HorizontalOver + 50
                    End If
                    If EastHasFifth Then
                        HorizontalOver = HorizontalOver + 100
                    End If
            End Select

            Select Case WestHasForth
                Case True
                    HorizontalOver = 50
                    If EastHasThird Then
                        HorizontalOver = HorizontalOver + 20
                    End If
                    If EastHasForth Then
                        HorizontalOver = HorizontalOver + 50
                    End If
                    If EastHasFifth Then
                        HorizontalOver = HorizontalOver + 100
                    End If
            End Select

            Select Case WestHasFifth
                Case True
                    HorizontalOver = 100
                    If EastHasThird Then
                        HorizontalOver = HorizontalOver + 20
                    End If
                    If EastHasForth Then
                        HorizontalOver = HorizontalOver + 50
                    End If
                    If EastHasFifth Then
                        HorizontalOver = HorizontalOver + 100
                    End If
            End Select

            If EastHasBelotte Or WestHasBelotte Then
                HorizontalOver = HorizontalOver + 20
            End If

            If EastHas4 Then
                HorizontalOver = HorizontalOver + 100
            End If
            If WestHas4 Then
                HorizontalOver = HorizontalOver + 100
            End If
        End If

        HorizontalTeamPoints = HorizontalTeamPoints + HorizontalOver
        VerticalTeamPoints = VerticalTeamPoints + VerticalOver
    End Sub
    Dim FourArray(31), FourArrayJ(31), FourArray9(31) As Boolean
    Function FourofAKindCheck(ByVal n As Integer) As Boolean
        'Ρουτίνα για τον έλεγχο καρέ(δηλ.να έχει 4 ίδια χαρτιά κάθε παίχτης)
        Dim i, j, m, counter As Integer

        For i = n To n + 7
            For j = i + 1 To n + 7
                FourArray(i) = True
                If (Xartia(i).Tag = Xartia(j).Tag) And Not (Xartia(i).Tag = 0.01 Or Xartia(i).Tag = 0.02 Or Xartia(i).Tag = 2 Or Xartia(i).Tag = 0.03) Then
                    FourArray(j) = True
                    counter = counter + 1
                End If
            Next
            If counter < 3 Then
                For m = n To n + 7
                    FourArray(m) = False
                Next
            End If
            If counter = 3 Then
                Return True
            End If
            counter = 0
        Next

    End Function
    Function FourofAKindCheckJacks(ByVal n As Integer) As Boolean
        'Ρουτίνα για τον έλεγχο καρέ(δηλ.να έχει 4 ίδια χαρτιά κάθε παίχτης, jacks and nines
        Dim i, j, m, counter As Integer

        For i = n To n + 7
            For j = i + 1 To n + 7
                FourArrayJ(i) = True
                If (Xartia(i).Tag = Xartia(j).Tag) And Xartia(i).Tag = 2 Then
                    FourArrayJ(j) = True
                    counter = counter + 1
                End If
            Next
            If counter < 3 Then
                For m = n To n + 7
                    FourArrayJ(m) = False
                Next
            End If
            If counter = 3 Then
                Return True
            End If
            counter = 0
        Next

    End Function
    Function FourofAKindCheckNines(ByVal n As Integer) As Boolean
        'Ρουτίνα για τον έλεγχο καρέ(δηλ.να έχει 4 ίδια χαρτιά κάθε παίχτης)
        Dim i, j, m, counter As Integer

        For i = n To n + 7
            For j = i + 1 To n + 7
                FourArray9(i) = True
                If (Xartia(i).Tag = Xartia(j).Tag) And Xartia(i).Tag = 0.03 Then
                    FourArray9(j) = True
                    counter = counter + 1
                End If
            Next
            If counter < 3 Then
                For m = n To n + 7
                    FourArray9(m) = False
                Next
            End If
            If counter = 3 Then
                Return True
            End If
            counter = 0
        Next

    End Function
    Dim NorthHasBelotte, SouthHasBelotte, EastHasBelotte, WestHasBelotte As Boolean
    Dim BelotteCard(1) As Integer
    Sub BelotteCheck(ByVal Player As String, ByVal n As Integer)
        Dim i As Integer

        Select Case Player
            Case "North"
                For i = n To n + 6
                    If (Xartia(i).Tag = 3 And Xartia(i + 1).Tag = 4) And (Xartia(i).Text = Xartia(i + 1).Text And Xartia(i).Text = Offer.Suite) Then
                        NorthHasBelotte = True
                        BelotteCard(0) = i
                        BelotteCard(1) = i + 1
                    End If
                Next
            Case "East"
                For i = n To n + 6
                    If (Xartia(i).Tag = 3 And Xartia(i + 1).Tag = 4) And (Xartia(i).Text = Xartia(i + 1).Text And Xartia(i).Text = Offer.Suite) Then
                        EastHasBelotte = True
                        BelotteCard(0) = i
                        BelotteCard(1) = i + 1
                    End If
                Next
            Case "South"
                For i = n To n + 6
                    If (Xartia(i).Tag = 3 And Xartia(i + 1).Tag = 4) And (Xartia(i).Text = Xartia(i + 1).Text And Xartia(i).Text = Offer.Suite) Then
                        SouthHasBelotte = True
                        BelotteCard(0) = i
                        BelotteCard(1) = i + 1
                    End If
                Next
            Case "West"
                For i = n To n + 6
                    If (Xartia(i).Tag = 3 And Xartia(i + 1).Tag = 4) And (Xartia(i).Text = Xartia(i + 1).Text And Xartia(i).Text = Offer.Suite) Then
                        WestHasBelotte = True
                        BelotteCard(0) = i
                        BelotteCard(1) = i + 1
                    End If
                Next
        End Select
    End Sub

    '    Sub OverSeperator(ByVal Four As Boolean, ByVal Straight As Boolean)

    '       Select Case simpiptoun
    '          Case True
    '
    '               If Four And Straight Then
    '                  Four = True
    '                 Straight = False
    ''''            End If
    '    Case False
    '       If Four And Straight Then
    '          Four = True
    '         Straight = True
    '    End If
    ' End Select
    'End Sub



    Private Sub MenuItem6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem6.Click

        Try
            DataForm.Show()
        Catch ex As Exception

            MsgBox("Only player's cards will be shown", MsgBoxStyle.Information, "INFO")
        End Try
    End Sub

    Sub AddCardPointsToDataForm()

        Dim k As Integer

        DataForm.NorthPlayerCards.Items.Clear()
        DataForm.EastPlayerCards.Items.Clear()
        DataForm.SouthPlayerCards.Items.Clear()
        DataForm.WestPlayerCards.Items.Clear()

        DataForm.NorthPlayerCards.Items.Add("North Has HCS :" & NorthHasHCS)
        DataForm.EastPlayerCards.Items.Add("East Has HCS: " & EastHasHCS)
        DataForm.SouthPlayerCards.Items.Add("South Has HCS: " & SouthHasHCS)
        DataForm.WestPlayerCards.Items.Add("West Has HCS: " & WestHasHCS)

        DataForm.NorthPlayerCards.Items.Add("North Has DCS :" & NorthHasDCS)
        DataForm.EastPlayerCards.Items.Add("East Has DCS: " & EastHasDCS)
        DataForm.SouthPlayerCards.Items.Add("South Has DCS: " & SouthHasDCS)
        DataForm.WestPlayerCards.Items.Add("West Has DCS: " & WestHasDCS)

        DataForm.NorthPlayerCards.Items.Add("North Has CCS :" & NorthHasCCS)
        DataForm.EastPlayerCards.Items.Add("East Has CCS: " & EastHasCCS)
        DataForm.SouthPlayerCards.Items.Add("South Has CCS: " & SouthHasCCS)
        DataForm.WestPlayerCards.Items.Add("West Has CCS: " & WestHasCCS)

        DataForm.NorthPlayerCards.Items.Add("North Has SCS :" & NorthHasSCS)
        DataForm.EastPlayerCards.Items.Add("East Has SCS: " & EastHasSCS)
        DataForm.SouthPlayerCards.Items.Add("South Has SCS: " & SouthHasSCS)
        DataForm.WestPlayerCards.Items.Add("West Has SCS: " & WestHasSCS)

        For k = 7 To 0 Step -1
            DataForm.NorthPlayerCards.Items.Add(CardName(k) & " " & Xartia(k).Tag)

        Next
        For k = 15 To 8 Step -1
            DataForm.EastPlayerCards.Items.Add(CardName(k) & " " & Xartia(k).Tag)

        Next
        For k = 23 To 15 Step -1
            DataForm.SouthPlayerCards.Items.Add(CardName(k) & " " & Xartia(k).Tag)

        Next
        For k = 31 To 24 Step -1
            DataForm.WestPlayerCards.Items.Add(CardName(k) & " " & Xartia(k).Tag)

        Next
    End Sub
    Public NorthHasHCS, EastHasHCS, SouthHasHCS, WestHasHCS As Boolean
    Public NorthHasDCS, EastHasDCS, SouthHasDCS, WestHasDCS As Boolean
    Public NorthHasCCS, EastHasCCS, SouthHasCCS, WestHasCCS As Boolean
    Public NorthHasSCS, EastHasSCS, SouthHasSCS, WestHasSCS As Boolean


    Sub WhoHasCurrentStronger()



        Dim i As Integer
        For i = 0 To 7
            If HCSPos = i Then
                NorthHasHCS = True
                Exit For
            Else
                NorthHasHCS = False
            End If
        Next
        For i = 8 To 15
            If HCSPos = i Then
                EastHasHCS = True
                Exit For
            Else
                EastHasHCS = False
            End If
        Next
        For i = 16 To 23
            If HCSPos = i Then
                SouthHasHCS = True
                Exit For
            Else
                SouthHasHCS = False
            End If
        Next
        For i = 24 To 31
            If HCSPos = i Then
                WestHasHCS = True
                Exit For
            Else
                WestHasHCS = False
            End If
        Next
        '-------------------------------------------------------------------------------------------------------------------
        For i = 0 To 7
            If DCSPos = i Then
                NorthHasDCS = True
                Exit For
            Else
                NorthHasDCS = False
            End If
        Next
        For i = 8 To 15
            If DCSPos = i Then
                EastHasDCS = True
                Exit For
            Else
                EastHasDCS = False
            End If
        Next
        For i = 16 To 23
            If DCSPos = i Then
                SouthHasDCS = True
                Exit For
            Else
                SouthHasDCS = False
            End If
        Next
        For i = 24 To 31
            If DCSPos = i Then
                WestHasDCS = True
                Exit For
            Else
                WestHasDCS = False
            End If
        Next
        '-----------------------------------------------------------------------------------------------------------------------------
        For i = 0 To 7
            If CCSPos = i Then
                NorthHasCCS = True
                Exit For
            Else
                NorthHasCCS = False
            End If
        Next
        For i = 8 To 15
            If CCSPos = i Then
                EastHasCCS = True
                Exit For
            Else
                EastHasCCS = False
            End If
        Next
        For i = 16 To 23
            If CCSPos = i Then
                SouthHasCCS = True
                Exit For
            Else
                SouthHasCCS = False
            End If
        Next
        For i = 24 To 31
            If CCSPos = i Then
                WestHasCCS = True
                Exit For
            Else
                WestHasCCS = False
            End If
        Next
        '-------------------------------------------------------------------------------------------------------------------
        For i = 0 To 7
            If SCSPos = i Then
                NorthHasSCS = True
                Exit For
            Else
                NorthHasSCS = False
            End If
        Next
        For i = 8 To 15
            If SCSPos = i Then
                EastHasSCS = True
                Exit For
            Else
                EastHasSCS = False
            End If
        Next
        For i = 16 To 23
            If SCSPos = i Then
                SouthHasSCS = True
                Exit For
            Else
                SouthHasSCS = False
            End If
        Next
        For i = 24 To 31
            If SCSPos = i Then
                WestHasSCS = True
                Exit For
            Else
                WestHasSCS = False
            End If
        Next
    End Sub


    Private Sub NorthPlay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NorthPlay.Click


        NorthPlay.Enabled = False
        EastPlay.Enabled = True

        Dim i, k As Integer
        Dim HowManyEnabledN As Integer

        HowManyEnabledN = HowManyEnabled(0)

        If HowManyEnabledN = 1 Then
            For i = 0 To 7
                If Xartia(i).Enabled And Not Clicked(i) Then
                    HitMeNorth(Xartia(i), e)
                    Exit Sub
                End If
            Next
        End If




        If VerBought Then
            If index <> 0 Then
                If ((Bought_NotPlaysFirst("North") = 0 And Not Clicked(0)) Or Bought_NotPlaysFirst("North") <> 0) Then
                    HitMeNorth(Xartia(Bought_NotPlaysFirst("North")), e)
                    Exit Sub
                End If
            End If
            If index = 0 Then
                If ((BoughtGame_PlaysFirst("Vertical") = 0 And Not Clicked(0)) Or BoughtGame_PlaysFirst("Vertical") <> 0) Then
                    HitMeNorth(Xartia(BoughtGame_PlaysFirst("Vertical")), e)
                    Exit Sub
                End If
            End If
        End If
        If Not VerBought Then
            If index = 0 Then
                If ((NotBought_PlaysFirst("Vertical") = 0 And Not Clicked(0)) Or NotBought_PlaysFirst("Vertical") <> 0) Then
                    If Xartia(NotBought_PlaysFirst("Vertical")).Tag = 11 And Xartia(NotBought_PlaysFirst("Vertical")).Text <> Offer.Suite Then
                        HitMeNorth(Xartia(NotBought_PlaysFirst("Vertical")), e)
                        AcePlayed = True
                    Else
                        HitMeNorth(Xartia(NotBought_PlaysFirst("Vertical")), e)
                        Exit Sub
                    End If
                End If
            End If
            If index <> 0 Then
                If ((NotBought_NotPlaysFirst("North") = 0 And Not Clicked(0)) Or NotBought_NotPlaysFirst("North") <> 0) Then
                    If Xartia(NotBought_NotPlaysFirst("North")).Tag = 11 And Xartia(NotBought_NotPlaysFirst("North")).Text <> Offer.Suite Then

                        HitMeNorth(Xartia(NotBought_NotPlaysFirst("North")), e)
                        AcePlayed = True
                    Else
                        HitMeNorth(Xartia(NotBought_NotPlaysFirst("North")), e)
                    End If
                    Exit Sub
                End If
            End If
        End If

        For i = 0 To 7
            If Xartia(i).Enabled And Not Clicked(i) Then
                HitMeNorth(Xartia(i), e)
                Exit Sub
            End If

        Next




    End Sub
    Private Sub EastPlay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EastPlay.Click


        SouthPlay.Enabled = True
        EastPlay.Enabled = False

        Dim HowManyEnabledE, i As Integer

        HowManyEnabledE = HowManyEnabled(8)

        If HowManyEnabledE = 1 Then
            For i = 8 To 15
                If Xartia(i).Enabled And Not Clicked(i) Then
                    If Players.OnePl Or Players.One Then
                        PicBackBox(i).Dispose()
                    End If
                    HitMeEast(Xartia(i), e)
                    Exit Sub
                End If
            Next
        End If
        If HorBought Then

            If index = 1 Then
                If BoughtGame_PlaysFirst("Horizontal") <> 0 Then
                    If Players.OnePl Or Players.One Then
                        PicBackBox(BoughtGame_PlaysFirst("Horizontal")).Dispose()
                    End If
                    HitMeEast(Xartia(BoughtGame_PlaysFirst("Horizontal")), e)
                    Exit Sub
                End If
            End If
            If index <> 1 Then
                If Bought_NotPlaysFirst("East") <> 0 Then
                    If Players.OnePl Or Players.One Then
                        PicBackBox(Bought_NotPlaysFirst("East")).Dispose()
                    End If
                    HitMeEast(Xartia(Bought_NotPlaysFirst("East")), e)
                    Exit Sub
                End If
            End If
        End If
        If Not HorBought Then
            If index = 1 Then
                If NotBought_PlaysFirst("Horizntal") <> 0 Then
                    If Xartia(NotBought_PlaysFirst("Horizontal")).Tag = 11 And Xartia(NotBought_PlaysFirst("Horizontal")).Text <> Offer.Suite Then
                        If Players.OnePl Or Players.One Then
                            PicBackBox(NotBought_PlaysFirst("Horizontal")).Dispose()
                        End If
                        HitMeEast(Xartia(NotBought_PlaysFirst("Horizontal")), e)
                        AcePlayed = True
                    Else
                        If Players.OnePl Or Players.One Then
                            PicBackBox(NotBought_PlaysFirst("Horizontal")).Dispose()
                        End If
                        HitMeEast(Xartia(NotBought_PlaysFirst("Horizontal")), e)
                        Exit Sub
                        End If
                End If
            End If
            If index <> 1 Then
                If NotBought_NotPlaysFirst("East") <> 0 Then
                    If Xartia(NotBought_NotPlaysFirst("East")).Tag = 11 And Xartia(NotBought_NotPlaysFirst("East")).Text <> Offer.Suite Then
                        If Players.OnePl Or Players.One Then
                            PicBackBox(NotBought_NotPlaysFirst("East")).Dispose()
                        End If
                        HitMeEast(Xartia(NotBought_NotPlaysFirst("East")), e)
                        AcePlayed = True
                    Else
                        If Players.OnePl Or Players.One Then
                            PicBackBox(NotBought_NotPlaysFirst("East")).Dispose()
                        End If
                        HitMeEast(Xartia(NotBought_NotPlaysFirst("East")), e)
                        End If
                        Exit Sub
                End If
            End If
        End If



        For i = 8 To 15
            If Xartia(i).Enabled And Not Clicked(i) Then
                If Players.OnePl Or Players.One Then
                    PicBackBox(i).Dispose()
                End If
                HitMeEast(Xartia(i), e)
                Exit Sub
            End If

        Next

    End Sub
    Private Sub SouthPlay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SouthPlay.Click

        SouthPlay.Enabled = False
        WestPlay.Enabled = True

        Dim HowManyEnabledS, i As Integer

        HowManyEnabledS = HowManyEnabled(16)

        If HowManyEnabledS = 1 Then
            For i = 16 To 23
                If Xartia(i).Enabled And Not Clicked(i) Then
                    If Players.OnePl Or Players.One Then
                        PicBackBox(i).Dispose()
                    End If
                    HitMeSouth(Xartia(i), e)
                    Exit Sub
                End If
            Next
        End If
        If VerBought Then
            If index = 2 Then
                If BoughtGame_PlaysFirst("Vertical") <> 0 Then
                    If Players.OnePl Or Players.One Then
                        PicBackBox(BoughtGame_PlaysFirst("Vertical")).Dispose()
                    End If
                    HitMeSouth(Xartia(BoughtGame_PlaysFirst("Vertical")), e)
                    Exit Sub
                End If
            End If
            If index <> 2 Then
                If Bought_NotPlaysFirst("South") <> 0 Then
                    If Players.OnePl Or Players.One Then
                        PicBackBox(Bought_NotPlaysFirst("South")).Dispose()
                    End If
                    HitMeSouth(Xartia(Bought_NotPlaysFirst("South")), e)
                    Exit Sub
                End If
            End If
        End If
        If Not VerBought Then
            If index = 2 Then
                If NotBought_PlaysFirst("Vertical") <> 0 Then
                    If Xartia(NotBought_PlaysFirst("Vertical")).Tag = 11 And Xartia(NotBought_PlaysFirst("Vertical")).Text <> Offer.Suite Then
                        If Players.OnePl Or Players.One Then
                            PicBackBox(NotBought_PlaysFirst("Vertical")).Dispose()
                        End If
                        HitMeSouth(Xartia(NotBought_PlaysFirst("Vertical")), e)
                        AcePlayed = True
                    Else
                        If Players.OnePl Or Players.One Then
                            PicBackBox(NotBought_PlaysFirst("Vertical")).Dispose()
                        End If
                        HitMeSouth(Xartia(NotBought_PlaysFirst("Vertical")), e)
                        Exit Sub
                    End If
                End If
            End If
            If index <> 2 Then
                If NotBought_NotPlaysFirst("South") <> 0 Then
                    If Xartia(NotBought_NotPlaysFirst("South")).Tag = 11 And Xartia(NotBought_NotPlaysFirst("South")).Text <> Offer.Suite Then
                        If Players.OnePl Or Players.One Then
                            PicBackBox(NotBought_NotPlaysFirst("South")).Dispose()
                        End If
                        HitMeSouth(Xartia(NotBought_NotPlaysFirst("South")), e)
                        AcePlayed = True
                    Else
                        If Players.OnePl Or Players.One Then
                            PicBackBox(NotBought_NotPlaysFirst("South")).Dispose()
                        End If
                        HitMeSouth(Xartia(NotBought_NotPlaysFirst("South")), e)
                        End If
                End If
                Exit Sub
            End If
        End If
        For i = 16 To 23
            If Xartia(i).Enabled = True And Not Clicked(i) Then
                If Players.OnePl Or Players.One Then
                    PicBackBox(i).Dispose()
                End If
                HitMeSouth(Xartia(i), e)
                Exit Sub
            End If
        Next

    End Sub
    Private Sub WestPlay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WestPlay.Click
        If Not Players.One Then
            NorthPlay.Enabled = True
        End If
        WestPlay.Enabled = False
        Dim i As Integer

        Dim HowManyEnabledW As Integer

        HowManyEnabledW = HowManyEnabled(24)

        If HowManyEnabledW = 1 Then
            For i = 24 To 31
                If Xartia(i).Enabled And Not Clicked(i) Then
                    If Players.OnePl Or Players.One Then
                        PicBackBox(i).Dispose()
                    End If
                    HitMeWest(Xartia(i), e)
                    Exit Sub
                End If
            Next
        End If

        If HorBought Then
            If index = 3 Then
                If BoughtGame_PlaysFirst("Horizontal") <> 0 Then
                    If Players.OnePl Or Players.One Then
                        PicBackBox(BoughtGame_PlaysFirst("Horizontal")).Dispose()
                    End If
                    HitMeWest(Xartia(BoughtGame_PlaysFirst("Horizontal")), e)
                    Exit Sub
                End If
            End If
            If index <> 3 Then
                If Bought_NotPlaysFirst("West") <> 0 Then
                    If Players.OnePl Or Players.One Then
                        PicBackBox(Bought_NotPlaysFirst("West")).Dispose()
                    End If
                    HitMeWest(Xartia(Bought_NotPlaysFirst("West")), e)
                    Exit Sub
                End If
            End If
        End If
        If Not HorBought Then
            If index = 3 Then
                If NotBought_PlaysFirst("Horizontal") <> 0 Then
                    If Xartia(NotBought_PlaysFirst("Horizontal")).Tag = 11 And Xartia(NotBought_PlaysFirst("Horizontal")).Text <> Offer.Suite Then
                        If Players.OnePl Or Players.One Then
                            PicBackBox(NotBought_PlaysFirst("Horizontal")).Dispose()
                        End If
                        HitMeWest(Xartia(NotBought_PlaysFirst("Horizontal")), e)
                        AcePlayed = True
                    Else
                        If Players.OnePl Or Players.One Then
                            PicBackBox(NotBought_PlaysFirst("Horizontal")).Dispose()
                        End If
                        HitMeWest(Xartia(NotBought_PlaysFirst("Horizontal")), e)
                        Exit Sub
                    End If
                End If
            End If
            If index <> 3 Then
                If NotBought_NotPlaysFirst("West") <> 0 Then
                    If Xartia(NotBought_NotPlaysFirst("West")).Tag = 11 And Xartia(NotBought_NotPlaysFirst("West")).Text <> Offer.Suite Then
                        If Players.OnePl Or Players.One Then
                            PicBackBox(NotBought_NotPlaysFirst("West")).Dispose()
                        End If
                        HitMeWest(Xartia(NotBought_NotPlaysFirst("West")), e)
                        AcePlayed = True
                    Else
                        If Players.OnePl Or Players.One Then
                            PicBackBox(NotBought_NotPlaysFirst("West")).Dispose()
                        End If
                        HitMeWest(Xartia(NotBought_NotPlaysFirst("West")), e)
                        End If

                        Exit Sub
                End If
            End If
        End If

        For i = 24 To 31
            If Xartia(i).Enabled And Not Clicked(i) Then
                If Players.OnePl Or Players.One Then
                    PicBackBox(i).Dispose()
                End If
                HitMeWest(Xartia(i), e)
                Exit Sub
            End If
        Next

    End Sub

    Dim StandarLoses(31) As Boolean
    Dim StandarLosesCounter As Integer
    Sub Standar_Loses(ByVal Player As String) 'Καλείτε σε κάθε HitMe και γεμίζει τον πίνακα StandarLoses με True/False 
        Dim i, j, k As Integer 'ανάλογα με το αν χάνει σίγουρα ένα χαρτί.
        Dim KoziPlayed As Boolean

        StandarLosesCounter = StandarLosesCounter + 1

        If StandarLosesCounter = 4 Then
            StandarLosesCounter = 0
            For i = 0 To 31
                StandarLoses(i) = False
            Next
            Exit Sub
        End If



        Select Case Player
            Case "North"
                k = 0
            Case "East"
                k = 8
            Case "South"
                k = 16
            Case "West"
                k = 24
        End Select

        For i = 0 To 3
            If SuiteCompare(i) = Offer.Suite Then
                KoziPlayed = True
                Exit For
            End If
        Next

        If KoziPlayed Then
            For j = k To k + 7
                If Xartia(j).Enabled And Not Clicked(j) And Xartia(j).Text <> Offer.Suite Then
                    StandarLoses(j) = True
                End If
                If Xartia(j).Enabled And Not Clicked(j) And Xartia(j).Text = Offer.Suite Then
                    For i = 0 To 3
                        If SuiteCompare(i) = Offer.Suite Then
                            If PointsCompareArray(i) > Xartia(j).Tag And Not StandarLoses(j) Then
                                StandarLoses(j) = True
                            End If
                        End If
                    Next
                End If
            Next
        End If

        If Not KoziPlayed Then
            For j = k To k + 7
                If Xartia(j).Text = SuiteCompare(index) And Xartia(j).Enabled And Not Clicked(j) Then
                    For i = 0 To 3
                        If SuiteCompare(i) = SuiteCompare(index) Then
                            If PointsCompareArray(i) > Xartia(j).Tag And Not Clicked(j) Then
                                StandarLoses(j) = True
                            End If
                        End If
                    Next
                End If
                If Xartia(j).Text <> SuiteCompare(index) And Xartia(j).Enabled And Not Clicked(j) Then
                    If Xartia(j).Text <> Offer.Suite Then
                        StandarLoses(j) = True
                    End If
                End If
            Next
        End If
       
    End Sub

    Function TeamMateWins(ByVal Player As String) As Boolean 'Προς το παρόν απλώς δείχνει αν καρδίζει ο εκάστοτε συμπαίκτης, αφού έχουν παιχτεί όλα τα ατού

        Dim i, PCPointer, PCP2, HowManyBeats, HowManyCheck As Integer

        Dim OppTsakaH, OppTsakaD, OppTsakaC, OppTsakaS As Boolean
        Dim TMTsakaH, TMTsakaD, TMTsakaC, TMTsakaS As Boolean

        Select Case Player
            Case "North"
                PCPointer = 2
                If index = 1 Then
                    HowManyCheck = 2
                End If
                If index = 2 Then
                    HowManyCheck = 1
                    OppTsakaH = ETsakaHearts  'Mono stin periptosi pou einai 2 xartia kato mas endiaferei ti tsaka o telefteos antipalos
                    OppTsakaD = ETsakaDiamonds ' stin prokeimeni periptosi o East
                    OppTsakaC = ETsakaClubs
                    OppTsakaS = ETsakaSpades
                End If
                If index = 3 Then

                    HowManyCheck = 0
                    TMTsakaH = STsakaHearts
                    TMTsakaD = STsakaDiamonds
                    TMTsakaC = STsakaClubs
                    TMTsakaS = STsakaSpades
                    OppTsakaH = ETsakaHearts
                    OppTsakaD = ETsakaDiamonds
                    OppTsakaC = ETsakaClubs
                    OppTsakaS = ETsakaSpades
                End If

            Case "East"
                PCPointer = 3
                If index = 2 Then
                    HowManyCheck = 2
                End If
                If index = 3 Then
                    HowManyCheck = 1
                    OppTsakaH = STsakaHearts
                    OppTsakaD = STsakaDiamonds
                    OppTsakaC = STsakaClubs
                    OppTsakaS = STsakaSpades
                End If
                If index = 0 Then
                    HowManyCheck = 0
                    TMTsakaH = WTsakaHearts
                    TMTsakaD = WTsakaDiamonds
                    TMTsakaC = WTsakaClubs
                    TMTsakaS = WTsakaSpades
                    OppTsakaH = STsakaHearts
                    OppTsakaD = STsakaDiamonds
                    OppTsakaC = STsakaClubs
                    OppTsakaS = STsakaSpades
                End If
            Case "South"
                PCPointer = 0
                If index = 3 Then
                    HowManyCheck = 2
                End If
                If index = 0 Then
                    HowManyCheck = 1
                    OppTsakaH = WTsakaHearts
                    OppTsakaD = WTsakaDiamonds
                    OppTsakaC = WTsakaClubs
                    OppTsakaS = WTsakaSpades
                End If
                If index = 1 Then
                    HowManyCheck = 0
                    TMTsakaH = NTsakaHearts
                    TMTsakaD = NTsakaDiamonds
                    TMTsakaC = NTsakaClubs
                    TMTsakaS = NTsakaSpades
                    OppTsakaH = WTsakaHearts
                    OppTsakaD = WTsakaDiamonds
                    OppTsakaC = WTsakaClubs
                    OppTsakaS = WTsakaSpades
                End If
            Case "West"
                PCPointer = 1
                If index = 0 Then
                    HowManyCheck = 2
                End If
                If index = 1 Then
                    HowManyCheck = 1
                    OppTsakaH = NTsakaHearts
                    OppTsakaD = NTsakaDiamonds
                    OppTsakaC = NTsakaClubs
                    OppTsakaS = NTsakaSpades
                End If
                If index = 2 Then
                    HowManyCheck = 0
                    TMTsakaH = ETsakaHearts
                    TMTsakaD = ETsakaDiamonds
                    TMTsakaC = ETsakaClubs
                    TMTsakaS = ETsakaSpades
                    OppTsakaH = NTsakaHearts
                    OppTsakaD = NTsakaDiamonds
                    OppTsakaC = NTsakaClubs
                    OppTsakaS = NTsakaSpades
                End If
        End Select

     

        If AtouCounter = 8 Then
            For i = 0 To 3
                If SuiteCompare(PCPointer) = Offer.Suite Then
                    Return True
                End If
            Next

            If SuiteCompare(PCPointer) <> Offer.Suite Then
                Select Case Offer.Suite
                    Case "Hearts"
                        If PointsCompareArray(PCPointer) = Xartia(HSP).Tag Then
                            Return True
                        End If
                    Case "Diamonds"
                        If PointsCompareArray(PCPointer) = Xartia(DSP).Tag Then

                            Return True
                        End If
                    Case "Clubs"
                        If PointsCompareArray(PCPointer) = Xartia(CSP).Tag Then

                            Return True
                        End If
                    Case "Spades"
                        If PointsCompareArray(PCPointer) = Xartia(SSP).Tag Then

                            Return True
                        End If
                End Select
            End If

            For i = 0 To 3
                If SuiteCompare(PCPointer) <> Offer.Suite Then
                    If SuiteCompare(PCPointer) = SuiteCompare(index) Then
                        If SuiteCompare(i) = SuiteCompare(index) Then
                            If PointsCompareArray(PCPointer) > PointsCompareArray(i) Then
                                HowManyBeats = HowManyBeats + 1
                             
                                If HowManyBeats = HowManyCheck Then

                                    Return True
                                End If
                            End If
                        ElseIf SuiteCompare(i) <> SuiteCompare(index) And Not SuiteCompare(i) = "" Then
                            HowManyBeats = HowManyBeats + 1
                           
                            If HowManyBeats = HowManyCheck Then
                                Return True
                            End If

                        End If

                    End If
                End If
            Next

        End If

        If AtouCounter <> 8 Then

            If HowManyCheck = 0 Then
                Select Case SuiteCompare(index)
                    Case "Hearts"
                        If TMTsakaH And Not OppTsakaH Then
                            Return True
                        End If
                    Case "Diamonds"
                        If TMTsakaD And Not OppTsakaD Then
                            Return True
                        End If
                    Case "Clubs"
                        If TMTsakaS And Not OppTsakaS Then
                            Return True
                        End If
                    Case "Spades"
                        If TMTsakaS And Not OppTsakaS Then
                            Return True
                        End If
                End Select
            End If

            If SuiteCompare(PCPointer) = Offer.Suite Then
                Select Case Offer.Suite
                    Case "Hearts"
                        If PointsCompareArray(PCPointer) = Xartia(HSP).Tag Then
                            Return True
                        End If
                    Case "Diamonds"
                        If PointsCompareArray(PCPointer) = Xartia(DSP).Tag Then

                            Return True
                        End If
                    Case "Clubs"
                        If PointsCompareArray(PCPointer) = Xartia(CSP).Tag Then

                            Return True
                        End If
                    Case "Spades"
                        If PointsCompareArray(PCPointer) = Xartia(SSP).Tag Then

                            Return True
                        End If
                End Select
            End If

            If SuiteCompare(PCPointer) = Offer.Suite Then
                If HowManyCheck = 2 Then
                    For i = 0 To 3
                        If PCPointer <> i Then
                            If i <> index - 1 Then
                                If SuiteCompare(i) <> Offer.Suite And SuiteCompare(i) <> "" Then
                                    HowManyBeats = HowManyBeats + 1
                                  
                                    If HowManyBeats = HowManyCheck Then
                                        Return True
                                    End If
                                ElseIf SuiteCompare(i) = Offer.Suite And PointsCompareArray(i) < PointsCompareArray(PCPointer) Then
                                    HowManyBeats = HowManyBeats + 1
                                   
                                    If HowManyBeats = HowManyCheck Then
                                        Return True
                                    End If
                                End If
                            End If
                        End If
                    Next
                End If
            End If

            If SuiteCompare(PCPointer) <> Offer.Suite Then
                If HowManyCheck = 1 Then

                    If SuiteCompare(PCPointer) = SuiteCompare(index) Then

                        Select Case SuiteCompare(PCPointer)
                            Case "Hearts"
                                For i = 0 To 3
                                    If SuiteCompare(i) = SuiteCompare(index) Then
                                        If PointsCompareArray(i) < PointsCompareArray(PCPointer) And Not OppTsakaH And SuiteCompare(i) <> Offer.Suite Then
                                            Return True
                                        End If
                                    ElseIf SuiteCompare(i) <> SuiteCompare(index) And Not SuiteCompare(i) = "" And SuiteCompare(i) <> Offer.Suite Then
                                        Return True
                                    End If
                                Next
                            Case "Diamonds"
                                For i = 0 To 3
                                    If SuiteCompare(i) = SuiteCompare(index) Then
                                        If PointsCompareArray(i) < PointsCompareArray(PCPointer) And Not OppTsakaD And SuiteCompare(i) <> Offer.Suite Then
                                            Return True
                                        End If
                                    ElseIf SuiteCompare(i) <> SuiteCompare(index) And Not SuiteCompare(i) = "" And SuiteCompare(i) <> Offer.Suite Then
                                        Return True
                                    End If
                                Next
                            Case "Clubs"
                                For i = 0 To 3
                                    If SuiteCompare(i) = SuiteCompare(index) Then
                                        If PointsCompareArray(i) < PointsCompareArray(PCPointer) And Not OppTsakaC And SuiteCompare(i) <> Offer.Suite Then
                                            Return True
                                        End If
                                    ElseIf SuiteCompare(i) <> SuiteCompare(index) And Not SuiteCompare(i) = "" And SuiteCompare(i) <> Offer.Suite Then
                                        Return True
                                    End If
                                Next
                            Case "Spades"
                                For i = 0 To 3
                                    If SuiteCompare(i) = SuiteCompare(index) Then
                                        If PointsCompareArray(i) < PointsCompareArray(PCPointer) And Not OppTsakaS And SuiteCompare(i) <> Offer.Suite Then
                                            Return True
                                        End If
                                    ElseIf SuiteCompare(i) <> SuiteCompare(index) And Not SuiteCompare(i) = "" And SuiteCompare(i) <> Offer.Suite Then
                                        Return True
                                    End If
                                Next
                        End Select

                    End If
                End If


                If HowManyCheck = 2 Then
                    If SuiteCompare(PCPointer) = SuiteCompare(index) And SuiteCompare(index) <> Offer.Suite Then
                        For i = 0 To 3
                            If SuiteCompare(i) <> Offer.Suite And SuiteCompare(i) <> "" Then
                                If PointsCompareArray(PCPointer) > PointsCompareArray(i) Then
                                    HowManyBeats = HowManyBeats + 1
                                    If HowManyBeats = HowManyCheck Then
                                        Return True
                                    End If
                                End If
                            ElseIf SuiteCompare(i) <> SuiteCompare(PCPointer) And SuiteCompare(i) <> Offer.Suite And SuiteCompare(i) <> "" Then
                                HowManyBeats = HowManyBeats + 1
                                If HowManyBeats = HowManyCheck Then
                                    Return True
                                End If
                            End If
                        Next
                    End If
                End If
            End If


        End If


        TextBox5.Text = ""
        TextBox5.Text = Player & "'s TeamMate"

    End Function

    Sub PlayerKnows(ByVal Player As String) 'Θα γεμίζει 3 πίνακες διαφορετικούς με το τι ξέρει ο κάθε παίκτης για τα χαρτιά των άλλων τριών
        'βρίσκοντάς το στην πορεία ανάλογα με το αν δείξουν κάποια δήλωση, αν έχουν πιλότα ή στην αρχή 
        'ανάλογα με τον τρόπο που κάνουν προσφορές








    End Sub

    Public TenHeartsNA, TenDiamondsNA, TenClubsNA, TenSpadesNA As Boolean
    Public CardsWithTenH, CardsWithTenD, CardsWithTenC, CardsWithTenS As Integer

    Sub TenNotALone(ByVal Player As String)  'Ελέγχει αν η τα 10άρια των παικτών είναι "ξερά".Επιστρέφει επίσης τον αριθμό των χαρτιών που 
        Dim i, j, k, CardsWithTen As Integer 'είναι της ίδιας φυλής με το εκάστοτε δεκάρι. Η αρχικοποίηση της μεταβλητής CardsWithTen που    
        'είναι -1 γίνεται για τον λόγο ότι κατά τον έλεγχο των υπολοίπων χαρτιών του παίκτη   
        TenHeartsNA = False                  'σαρώνεται και το 10άρι οπότε δε θέλουμε να μετρηθεί σαν έξτρα χαρτί................   
        TenDiamondsNA = False
        TenClubsNA = False
        TenSpadesNA = False


        CardsWithTenH = 0
        CardsWithTenD = 0
        CardsWithTenC = 0
        CardsWithTenS = 0
        CardsWithTen = -1
        'CardsWithTenD = -1
        'CardsWithTenC = -1
        'CardsWithTenS = -1

        Select Case Player
            Case "North"
                k = 0
            Case "East"
                k = 8
            Case "South"
                k = 16
            Case "West"
                k = 24
        End Select



        For i = k To k + 7
            If Xartia(i).Tag = 10 And Xartia(i).Enabled = True And Not Clicked(i) Then
                For j = k To k + 7
                    If Xartia(i).Text = Xartia(j).Text And Not Clicked(j) Then
                        CardsWithTen = CardsWithTen + 1
                    End If
                    If CardsWithTen > 0 Then
                        Select Case Xartia(i).Text
                            Case "Hearts"
                                TenHeartsNA = True
                                CardsWithTenH = CardsWithTen
                                'TextBox6.Text = CardsWithTenH
                            Case "Diamonds"
                                TenDiamondsNA = True
                                CardsWithTenD = CardsWithTen
                                'TextBox7.Text = CardsWithTenD
                            Case "Clubs"
                                TenClubsNA = True
                                CardsWithTenC = CardsWithTen


                            Case "Spades"
                                TenSpadesNA = True
                                CardsWithTenS = CardsWithTen


                        End Select
                    Else
                        Select Case Xartia(i).Text
                            Case "Hearts"
                                TenHeartsNA = False

                                'TextBox6.Text = ""
                            Case "Diamonds"
                                TenDiamondsNA = False

                                'TextBox7.Text = ""
                            Case "Clubs"
                                TenClubsNA = False



                            Case "Spades"
                                TenSpadesNA = False


                        End Select
                    End If

                Next
            End If
            CardsWithTen = -1
        Next





    End Sub

    Dim CardToPlay As Integer
    Function BoughtGame_PlaysFirst(ByVal Team As String) As Integer
        Dim i, j, k, n, m As Integer

        Dim Arraymax(7), Arraymin(7), max, min As Double
        Dim HowManyAtou As Integer
        Dim SuiteNotToPlay(3) As String
        Dim jor9, jand9, Has9, Hasj, noAtou, OppNoAtou, g As Boolean


        For i = 0 To 7
            Arraymax(i) = 0
            Arraymin(i) = 21
        Next

        n = 0
        Select Case Team
            Case "Vertical"
                If OppNoTribe("North", Offer.Suite) And OppNoTribe("South", Offer.Suite) Then

                    OppNoAtou = True
                End If
             
                If index = 0 Then
                    TenNotALone("North")
                    k = 0
                    If jand9north Or jand9south Then
                        jand9 = True
                    End If
                    If Not jand9 Then
                        If jor9north Or jor9south Then
                            jor9 = True
                        End If
                    End If

                ElseIf index = 2 Then
                    TenNotALone("South")
                    k = 16
                    If jand9north Or jand9south Then
                        jand9 = True
                    End If
                    If Not jand9 Then
                        If jor9north Or jor9south Then
                            jor9 = True
                        End If
                    End If
                    End If
            Case "Horizontal"
                If OppNoTribe("East", Offer.Suite) And OppNoTribe("West", Offer.Suite) Then

                    OppNoAtou = True
                End If
                 
                    If index = 1 Then
                        TenNotALone("East")
                    k = 8
                    If jand9east Or jand9west Then
                        jand9 = True
                    End If
                    If Not jand9 Then
                        If jor9east Or jor9west Then
                            jor9 = True
                        End If
                    End If

                ElseIf index = 3 Then
                    TenNotALone("West")
                    k = 24

                    If jand9east Or jand9west Then
                        jand9 = True
                    End If
                    If Not jand9 Then
                        If jor9east Or jor9west Then
                            jor9 = True
                        End If
                    End If
                    End If
        End Select










        For i = k To k + 7
            If Xartia(i).Tag = 14 And Xartia(i).Enabled And Not Clicked(i) Then
                Has9 = True
            End If
        Next
        For i = k To k + 7
            If Xartia(i).Tag = 20 And Xartia(i).Enabled And Not Clicked(i) Then
                Hasj = True
            End If
        Next
        For i = k To k + 7
            If Xartia(i).Text = Offer.Suite And Not Clicked(i) And Xartia(i).Enabled Then
                HowManyAtou = HowManyAtou + 1
            End If
        Next
        If HowManyAtou = 0 Then
            noAtou = True
        End If
        g = Jand9Played()

        If (HowManyAtou + AtouCounter <> 8) Then

            If g = False Then

                If Hasj And Not Has9 Then   'Exei to J kai o simpaiktis to 9, tote rixnei to megalitero atou ektos J gia na parei o simpaiktis me to 9
                    For i = k To k + 7
                        If jor9 Then
                            If Xartia(i).Text = Offer.Suite And Xartia(i).Tag <> 20 And Not Clicked(i) And Xartia(i).Enabled = True Then
                                Arraymax(n) = Xartia(i).Tag
                                n = n + 1
                            End If

                        ElseIf Not jor9 Then  'exei to j kai o simpaiktis den exei 9
                            If Xartia(i).Tag = 20 And Not Clicked(i) And Xartia(i).Enabled = True Then
                                Hasj = False
                                Return i
                            End If
                        End If
                    Next
                End If

                If Hasj And Has9 Then
                    For i = k To k + 7
                        If Xartia(i).Tag = 20 And Not Clicked(i) And Xartia(i).Enabled = True Then 'exei to j kai to 9
                            Hasj = False
                            Return i
                        End If
                    Next
                End If

                If Hasj And Not Has9 Then
                    For i = k To k + 7
                        ' rixnei to J an o simpaiktis exei to 9 alla dne exei allo atou na to girisei
                        If jor9 Then
                            If n = 0 Then
                                If Xartia(i).Tag = 20 And Xartia(i).Enabled And Not Clicked(i) Then
                                    Hasj = False
                                    Return i
                                End If
                            End If
                        End If
                    Next
                End If

                If Has9 Then
                    For i = k To k + 7
                        If jor9 Then
                            If Xartia(i).Text = Offer.Suite And Xartia(i).Tag <> 14 And Not Clicked(i) And Xartia(i).Enabled = True Then
                                Arraymax(n) = Xartia(i).Tag
                                n = n + 1
                            End If

                        ElseIf Not jor9 Then  'an exei 9 kai o simpaiktis den exei j tote i rixnei asso an exei i rixnei kati apo ti fili me ta pio polla
                            For m = k To k + 7
                                If Xartia(m).Tag = 14 And ((AtouCounter + HowManyAtou) < 8 Or OppNoAtou) Then
                                    If ((m = HCSPos) Or (m = DCSPos) Or (m = CCSPos) Or (m = SCSPos)) Then
                                        Return m
                                    End If
                                End If
                            Next
                            For m = k To k + 7
                                If Xartia(m).Text <> Offer.Suite And Xartia(m).Tag = 11 And Not Clicked(m) And Xartia(m).Enabled = True Then
                                    Return m
                                End If
                            Next
                            If Xartia(i).Text = PlayersMoreTribe(k) And Xartia(i).Tag <> 10 And Not Clicked(i) And Xartia(i).Enabled = True Then 'an den einai 10ari to rixnei 
                                Return i
                            End If
                        End If
                    Next

                    If n = 0 And jor9 Then
                        For i = k To k + 7
                            If Xartia(i).Tag = 14 And Not Clicked(i) And Xartia(i).Enabled = True Then
                                Has9 = False
                                Return i
                            End If
                        Next
                    End If
                End If


                For i = k To k + 7
                    If Not Hasj And Not Has9 And Not jand9 And Not Clicked(i) And Xartia(i).Enabled = True Then
                        If Xartia(i).Text = Offer.Suite Then
                            Arraymin(n) = Xartia(i).Tag 'an den exei oute j oute 9 kai oute o simpaiktis exei kai ta 2
                            n = n + 1
                        End If
                    End If
                Next

                For i = k To k + 7
                    If Not Hasj And Not Has9 And jand9 And Not Clicked(i) And Xartia(i).Enabled = True Then  'an exei o simpaiktis j kai 9 rixnoume to megalitero atou an exoume
                        If Xartia(i).Text = Offer.Suite Then
                            Arraymax(n) = Xartia(i).Tag
                            n = n + 1
                        End If
                    End If
                Next


                max = Arraymax(0)
                For i = 1 To 7
                    If Arraymax(i) > max Then
                        max = Arraymax(i)
                    End If
                Next

                min = Arraymin(0)
                For i = 1 To 7
                    If Arraymin(i) < min Then
                        min = Arraymin(i)
                    End If
                Next

                If Hasj And Not Has9 And jor9 Then
                    For i = k To k + 7
                        If Xartia(i).Text = Offer.Suite And Xartia(i).Tag = max And Not Clicked(i) And Enabled = True Then
                            Return i
                        End If
                    Next
                End If
                If Has9 And jor9 Then
                    For i = k To k + 7
                        If Xartia(i).Text = Offer.Suite And Xartia(i).Tag = max And Not Clicked(i) And Enabled = True Then
                            Return i
                        End If
                    Next
                End If
                If Not Has9 And Not Hasj And jand9 Then
                    For i = k To k + 7
                        If Xartia(i).Text = Offer.Suite And Xartia(i).Tag = max And Not Clicked(i) And Enabled = True Then
                            Return i
                        End If
                    Next
                End If


                If Not Hasj And Not Has9 Then
                    For i = k To k + 7
                        If Xartia(i).Text = Offer.Suite And Xartia(i).Tag = min Then
                            Return i
                        End If
                    Next
                End If

            End If

            If Not OppNoAtou Then
                For i = k To k + 7
                    If i = AtouCSPos() Then
                        Return i
                    End If
                Next
            End If

            n = 0
            For i = 0 To 3
                SuiteNotToPlay(i) = ""
            Next
            If noAtou Then
                For i = k To k + 7
                    If Xartia(i).Tag = 11 Then
                        SuiteNotToPlay(n) = Xartia(i).Text
                        n = n + 1
                    End If
                Next

                For i = k To k + 7
                    If Xartia(i).Text <> SuiteNotToPlay(0) And Xartia(i).Text <> SuiteNotToPlay(1) And Xartia(i).Text <> SuiteNotToPlay(2) And Not Clicked(i) And Xartia(i).Enabled = True Then
                        If Xartia(i).Tag <> 10 Then
                            Select Case Xartia(i).Text
                                Case "Hearts"
                                    If TenHeartsNA Then
                                        Return i
                                    End If
                                Case "Diamonds"
                                    If TenDiamondsNA Then
                                        Return i
                                    End If
                                Case "Clubs"
                                    If TenClubsNA Then
                                        Return i
                                    End If
                                Case "Spades"
                                    If TenSpadesNA Then
                                        Return i
                                    End If
                            End Select

                        End If
                    End If
                Next

            End If

        End If

        If ((HowManyAtou + AtouCounter) = 8 Or OppNoAtou) Then
            For i = k To k + 7
                If Xartia(i).Enabled And Not Clicked(i) And Xartia(i).Text <> Offer.Suite Then
                    Select Case Xartia(i).Text
                        Case "Hearts"
                            If HCSPos = i Then
                                Return i
                            End If
                        Case "Diamonds"
                            If DCSPos = i Then
                                Return i
                            End If
                        Case "Clubs"
                            If CCSPos = i Then
                                Return i
                            End If
                        Case "Spades"
                            If SCSPos = i Then
                                Return i
                            End If

                    End Select
                End If
            Next


            For i = k To k + 7
                If Xartia(i).Enabled And Not Clicked(i) And Xartia(i).Tag = 10 And Xartia(i).Text <> Offer.Suite Then
                    Select Case Xartia(i).Text
                        Case "Hearts"
                            If TenHeartsNA Then
                                For j = k To k + 7
                                    If Xartia(j).Text = "Hearts" And Xartia(i).Tag <> 10 Then
                                        Return j
                                    End If
                                Next
                            End If
                        Case "Diamonds"
                            If TenDiamondsNA Then
                                For j = k To k + 7
                                    If Xartia(j).Text = "Diamonds" And Xartia(i).Tag <> 10 Then
                                        Return j
                                    End If
                                Next
                            End If
                        Case "Clubs"
                            If TenClubsNA Then
                                For j = k To k + 7
                                    If Xartia(j).Text = "Clubs" And Xartia(i).Tag <> 10 Then
                                        Return j
                                    End If
                                Next
                            End If
                        Case "Spades"
                            If TenSpadesNA Then
                                For j = k To k + 7
                                    If Xartia(j).Text = "Spades" And Xartia(i).Tag <> 10 Then
                                        Return j
                                    End If
                                Next
                            End If
                    End Select
                End If
            Next

            For i = k To k + 7
                If Xartia(i).Enabled And Not Clicked(i) And Xartia(i).Text <> Offer.Suite Then
                    Return i
                End If
            Next
        End If


    End Function
    Public MoreNorthTribe, MoreSouthTribe, MoreEastTribe, MoreWestTribe As String
    Function PlayersMoreTribe(ByVal Player As Integer) As String
        Dim Array(2), i, max, temp As Integer

        Select Case Player
            Case 0

                Select Case Offer.Suite
                    Case "Hearts"
                        Array(0) = northDiamondscounter
                        Array(1) = northClubscounter
                        Array(2) = northSpadescounter

                        max = Array(0)
                        For i = 0 To 2
                            If Array(i) > max Then
                                max = Array(i)
                                temp = i
                            End If
                        Next
                        Select Case temp
                            Case 0
                                Return "Diamonds"
                            Case 1
                                Return "Clubs"
                            Case 2
                                Return "Spades"
                        End Select

                    Case "Diamonds"
                        Array(0) = northHeartscounter
                        Array(1) = northClubscounter
                        Array(2) = northSpadescounter

                        max = Array(0)
                        For i = 0 To 2
                            If Array(i) > max Then
                                max = Array(i)
                                temp = i
                            End If
                        Next
                        Select Case temp
                            Case 0

                                Return "Hearts"

                            Case 1
                                Return "Clubs"
                            Case 2
                                Return "Spades"
                        End Select

                    Case "Clubs"
                        Array(0) = northHeartscounter
                        Array(1) = northDiamondscounter
                        Array(2) = northSpadescounter

                        max = Array(0)
                        For i = 0 To 2
                            If Array(i) > max Then
                                max = Array(i)
                                temp = i
                            End If
                        Next
                        Select Case temp
                            Case 0

                                Return "Hearts"

                            Case 1
                                Return "Diamonds"
                            Case 2
                                Return "Spades"


                        End Select
                    Case "Spades"
                        Array(0) = northHeartscounter
                        Array(1) = northDiamondscounter
                        Array(2) = northClubscounter

                        max = Array(0)
                        For i = 0 To 2
                            If Array(i) > max Then
                                max = Array(i)
                                temp = i
                            End If
                        Next
                        Select Case temp
                            Case 0

                                Return "Hearts"

                            Case 1
                                Return "Diamonds"
                            Case 2
                                Return "Clubs"
                        End Select
                End Select


            Case 8
                Select Case Offer.Suite
                    Case "Hearts"
                        Array(0) = eastDiamondscounter
                        Array(1) = eastClubscounter
                        Array(2) = eastSpadescounter

                        max = Array(0)
                        For i = 0 To 2
                            If Array(i) > max Then
                                max = Array(i)
                                temp = i
                            End If
                        Next
                        Select Case temp
                            Case 0
                                Return "Diamonds"
                            Case 1
                                Return "Clubs"
                            Case 2
                                Return "Spades"
                        End Select

                    Case "Diamonds"
                        Array(0) = eastHeartscounter
                        Array(1) = eastClubscounter
                        Array(2) = eastSpadescounter

                        max = Array(0)
                        For i = 0 To 2
                            If Array(i) > max Then
                                max = Array(i)
                                temp = i
                            End If
                        Next
                        Select Case temp
                            Case 0
                                Return "Hearts"

                            Case 1
                                Return "Clubs"
                            Case 2
                                Return "Spades"

                        End Select

                    Case "Clubs"
                        Array(0) = eastHeartscounter
                        Array(1) = eastDiamondscounter
                        Array(2) = eastSpadescounter

                        max = Array(0)
                        For i = 0 To 2
                            If Array(i) > max Then
                                max = Array(i)
                                temp = i
                            End If
                        Next
                        Select Case temp
                            Case 0
                                Return "Hearts"
                            Case 1
                                Return "Diamonds"
                            Case 2
                                Return "Spades"

                        End Select

                    Case "Spades"
                        Array(0) = eastHeartscounter
                        Array(1) = eastDiamondscounter
                        Array(2) = eastClubscounter

                        max = Array(0)
                        For i = 0 To 2
                            If Array(i) > max Then
                                max = Array(i)
                                temp = i
                            End If
                        Next
                        Select Case temp
                            Case 0
                                Return "Hearts"
                            Case 1
                                Return "Diamonds"
                            Case 2
                                Return "Clubs"


                        End Select
                End Select



            Case 16
                Select Case Offer.Suite
                    Case "Hearts"
                        Array(0) = southDiamondscounter
                        Array(1) = southClubscounter
                        Array(2) = southSpadescounter

                        max = Array(0)
                        For i = 0 To 2
                            If Array(i) > max Then
                                max = Array(i)
                                temp = i
                            End If
                        Next
                        Select Case temp

                            Case 0
                                Return "Diamonds"
                            Case 1
                                Return "Clubs"
                            Case 2
                                Return "Spades"

                        End Select
                    Case "Diamonds"
                        Array(0) = southHeartscounter
                        Array(1) = southClubscounter
                        Array(2) = southSpadescounter

                        max = Array(0)
                        For i = 0 To 2
                            If Array(i) > max Then
                                max = Array(i)
                                temp = i
                            End If
                        Next
                        Select Case temp
                            Case 0
                                Return "Hearts"

                            Case 1
                                Return "Clubs"
                            Case 2
                                Return "Spades"

                        End Select
                    Case "Clubs"
                        Array(0) = southHeartscounter
                        Array(1) = southDiamondscounter
                        Array(2) = southSpadescounter

                        max = Array(0)
                        For i = 0 To 2
                            If Array(i) > max Then
                                max = Array(i)
                                temp = i
                            End If
                        Next
                        Select Case temp
                            Case 0
                                Return "Hearts"
                            Case 1
                                Return "Diamonds"

                            Case 2
                                Return "Spades"

                        End Select
                    Case "Spades"
                        Array(0) = southHeartscounter
                        Array(1) = southDiamondscounter
                        Array(2) = southClubscounter

                        max = Array(0)
                        For i = 0 To 2
                            If Array(i) > max Then
                                max = Array(i)
                                temp = i
                            End If
                        Next
                        Select Case temp
                            Case 0
                                Return "Hearts"
                            Case 1
                                Return "Diamonds"
                            Case 2
                                Return "Clubs"
                        End Select
                End Select

            Case 24
                Select Case Offer.Suite
                    Case "Hearts"
                        Array(0) = westDiamondscounter
                        Array(1) = westClubscounter
                        Array(2) = westSpadescounter

                        max = Array(0)
                        For i = 0 To 2
                            If Array(i) > max Then
                                max = Array(i)
                                temp = i
                            End If
                        Next
                        Select Case temp

                            Case 0
                                Return "Diamonds"
                            Case 1
                                Return "Clubs"
                            Case 2
                                Return "Spades"

                        End Select
                    Case "Diamonds"
                        Array(0) = westHeartscounter
                        Array(1) = westClubscounter
                        Array(2) = westSpadescounter

                        max = Array(0)
                        For i = 0 To 2
                            If Array(i) > max Then
                                max = Array(i)
                                temp = i
                            End If
                        Next
                        Select Case temp
                            Case 0
                                Return "Hearts"

                            Case 1
                                Return "Clubs"
                            Case 2
                                Return "Spades"

                        End Select
                    Case "Clubs"
                        Array(0) = westHeartscounter
                        Array(1) = westDiamondscounter
                        Array(2) = westSpadescounter

                        max = Array(0)
                        For i = 0 To 2
                            If Array(i) > max Then
                                max = Array(i)
                                temp = i
                            End If
                        Next
                        Select Case temp
                            Case 0
                                Return "Hearts"
                            Case 1
                                Return "Diamonds"
                            Case 2
                                Return "Spades"

                        End Select
                    Case "Spades"
                        Array(0) = westHeartscounter
                        Array(1) = westDiamondscounter
                        Array(2) = westClubscounter

                        max = Array(0)
                        For i = 0 To 2
                            If Array(i) > max Then
                                max = Array(i)
                                temp = i
                            End If
                        Next
                        Select Case temp
                            Case 0
                                Return "Hearts"
                            Case 1
                                Return "Diamonds"
                            Case 2
                                Return "Clubs"
                        End Select
                End Select

        End Select



    End Function
    Function MoreTribePlayed(ByVal Player As Integer) As String
        Dim Array(2), i, max, temp As Integer

        Select Case Player
            Case 0

                Select Case Offer.Suite
                    Case "Hearts"
                        Array(0) = northDiamondscounter + DiamondsCounter
                        Array(1) = northClubscounter + ClubsCounter
                        Array(2) = northSpadescounter + SpadesCounter

                        max = Array(0)
                        For i = 0 To 2
                            If Array(i) > max Then
                                max = Array(i)
                                temp = i
                            End If
                        Next
                        Select Case temp
                            Case 0
                                Return "Diamonds"
                            Case 1
                                Return "Clubs"
                            Case 2
                                Return "Spades"
                        End Select

                    Case "Diamonds"
                        Array(0) = northHeartscounter + HeartsCounter
                        Array(1) = northClubscounter + ClubsCounter
                        Array(2) = northSpadescounter + SpadesCounter

                        max = Array(0)
                        For i = 0 To 2
                            If Array(i) > max Then
                                max = Array(i)
                                temp = i
                            End If
                        Next
                        Select Case temp
                            Case 0

                                Return "Hearts"

                            Case 1
                                Return "Clubs"
                            Case 2
                                Return "Spades"
                        End Select

                    Case "Clubs"
                        Array(0) = northHeartscounter + HeartsCounter
                        Array(1) = northDiamondscounter + DiamondsCounter
                        Array(2) = northSpadescounter + SpadesCounter

                        max = Array(0)
                        For i = 0 To 2
                            If Array(i) > max Then
                                max = Array(i)
                                temp = i
                            End If
                        Next
                        Select Case temp
                            Case 0

                                Return "Hearts"

                            Case 1
                                Return "Diamonds"
                            Case 2
                                Return "Spades"


                        End Select
                    Case "Spades"
                        Array(0) = northHeartscounter + HeartsCounter
                        Array(1) = northDiamondscounter + DiamondsCounter
                        Array(2) = northClubscounter + ClubsCounter

                        max = Array(0)
                        For i = 0 To 2
                            If Array(i) > max Then
                                max = Array(i)
                                temp = i
                            End If
                        Next
                        Select Case temp
                            Case 0

                                Return "Hearts"

                            Case 1
                                Return "Diamonds"
                            Case 2
                                Return "Clubs"
                        End Select
                End Select


            Case 8
                Select Case Offer.Suite
                    Case "Hearts"
                        Array(0) = eastDiamondscounter + DiamondsCounter
                        Array(1) = eastClubscounter + ClubsCounter
                        Array(2) = eastSpadescounter + SpadesCounter

                        max = Array(0)
                        For i = 0 To 2
                            If Array(i) > max Then
                                max = Array(i)
                                temp = i
                            End If
                        Next
                        Select Case temp
                            Case 0
                                Return "Diamonds"
                            Case 1
                                Return "Clubs"
                            Case 2
                                Return "Spades"
                        End Select

                    Case "Diamonds"
                        Array(0) = eastHeartscounter + HeartsCounter
                        Array(1) = eastClubscounter + ClubsCounter
                        Array(2) = eastSpadescounter + SpadesCounter

                        max = Array(0)
                        For i = 0 To 2
                            If Array(i) > max Then
                                max = Array(i)
                                temp = i
                            End If
                        Next
                        Select Case temp
                            Case 0
                                Return "Hearts"

                            Case 1
                                Return "Clubs"
                            Case 2
                                Return "Spades"

                        End Select

                    Case "Clubs"
                        Array(0) = eastHeartscounter + HeartsCounter
                        Array(1) = eastDiamondscounter + DiamondsCounter
                        Array(2) = eastSpadescounter + SpadesCounter

                        max = Array(0)
                        For i = 0 To 2
                            If Array(i) > max Then
                                max = Array(i)
                                temp = i
                            End If
                        Next
                        Select Case temp
                            Case 0
                                Return "Hearts"
                            Case 1
                                Return "Diamonds"
                            Case 2
                                Return "Spades"

                        End Select

                    Case "Spades"
                        Array(0) = eastHeartscounter + HeartsCounter
                        Array(1) = eastDiamondscounter + DiamondsCounter
                        Array(2) = eastClubscounter + ClubsCounter

                        max = Array(0)
                        For i = 0 To 2
                            If Array(i) > max Then
                                max = Array(i)
                                temp = i
                            End If
                        Next
                        Select Case temp
                            Case 0
                                Return "Hearts"
                            Case 1
                                Return "Diamonds"
                            Case 2
                                Return "Clubs"


                        End Select
                End Select



            Case 16
                Select Case Offer.Suite
                    Case "Hearts"
                        Array(0) = southDiamondscounter + DiamondsCounter
                        Array(1) = southClubscounter + ClubsCounter
                        Array(2) = southSpadescounter + SpadesCounter

                        max = Array(0)
                        For i = 0 To 2
                            If Array(i) > max Then
                                max = Array(i)
                                temp = i
                            End If
                        Next
                        Select Case temp

                            Case 0
                                Return "Diamonds"
                            Case 1
                                Return "Clubs"
                            Case 2
                                Return "Spades"

                        End Select
                    Case "Diamonds"
                        Array(0) = southHeartscounter + HeartsCounter
                        Array(1) = southClubscounter + ClubsCounter
                        Array(2) = southSpadescounter + SpadesCounter

                        max = Array(0)
                        For i = 0 To 2
                            If Array(i) > max Then
                                max = Array(i)
                                temp = i
                            End If
                        Next
                        Select Case temp
                            Case 0
                                Return "Hearts"

                            Case 1
                                Return "Clubs"
                            Case 2
                                Return "Spades"

                        End Select
                    Case "Clubs"
                        Array(0) = southHeartscounter + HeartsCounter
                        Array(1) = southDiamondscounter + DiamondsCounter
                        Array(2) = southSpadescounter + SpadesCounter

                        max = Array(0)
                        For i = 0 To 2
                            If Array(i) > max Then
                                max = Array(i)
                                temp = i
                            End If
                        Next
                        Select Case temp
                            Case 0
                                Return "Hearts"
                            Case 1
                                Return "Diamonds"

                            Case 2
                                Return "Spades"

                        End Select
                    Case "Spades"
                        Array(0) = southHeartscounter + HeartsCounter
                        Array(1) = southDiamondscounter + DiamondsCounter
                        Array(2) = southClubscounter + ClubsCounter

                        max = Array(0)
                        For i = 0 To 2
                            If Array(i) > max Then
                                max = Array(i)
                                temp = i
                            End If
                        Next
                        Select Case temp
                            Case 0
                                Return "Hearts"
                            Case 1
                                Return "Diamonds"
                            Case 2
                                Return "Clubs"
                        End Select
                End Select

            Case 24
                Select Case Offer.Suite
                    Case "Hearts"
                        Array(0) = westDiamondscounter + DiamondsCounter
                        Array(1) = westClubscounter + ClubsCounter
                        Array(2) = westSpadescounter + SpadesCounter

                        max = Array(0)
                        For i = 0 To 2
                            If Array(i) > max Then
                                max = Array(i)
                                temp = i
                            End If
                        Next
                        Select Case temp

                            Case 0
                                Return "Diamonds"
                            Case 1
                                Return "Clubs"
                            Case 2
                                Return "Spades"

                        End Select
                    Case "Diamonds"
                        Array(0) = westHeartscounter + HeartsCounter
                        Array(1) = westClubscounter + ClubsCounter
                        Array(2) = westSpadescounter + SpadesCounter

                        max = Array(0)
                        For i = 0 To 2
                            If Array(i) > max Then
                                max = Array(i)
                                temp = i
                            End If
                        Next
                        Select Case temp
                            Case 0
                                Return "Hearts"

                            Case 1
                                Return "Clubs"
                            Case 2
                                Return "Spades"

                        End Select
                    Case "Clubs"
                        Array(0) = westHeartscounter + HeartsCounter
                        Array(1) = westDiamondscounter + DiamondsCounter
                        Array(2) = westSpadescounter + SpadesCounter

                        max = Array(0)
                        For i = 0 To 2
                            If Array(i) > max Then
                                max = Array(i)
                                temp = i
                            End If
                        Next
                        Select Case temp
                            Case 0
                                Return "Hearts"
                            Case 1
                                Return "Diamonds"
                            Case 2
                                Return "Spades"

                        End Select
                    Case "Spades"
                        Array(0) = westHeartscounter + HeartsCounter
                        Array(1) = westDiamondscounter + DiamondsCounter
                        Array(2) = westClubscounter + ClubsCounter

                        max = Array(0)
                        For i = 0 To 2
                            If Array(i) > max Then
                                max = Array(i)
                                temp = i
                            End If
                        Next
                        Select Case temp
                            Case 0
                                Return "Hearts"
                            Case 1
                                Return "Diamonds"
                            Case 2
                                Return "Clubs"
                        End Select
                End Select

        End Select
    End Function
    Dim AcePlayed As Boolean
    Function NotBought_PlaysFirst(ByVal Team As String) As Integer
        Dim i, k, j As Integer
        Dim offered, SuitNotToPlay As String

        SuitNotToPlay = ""

        ' ekeino pou eixame prosferei alla telika den agorastike
        Select Case Team

            Case "Vertical"

                If index = 0 Then
                    k = 0
                    j = 0
                    If NorthOffered <> "PASS" And NorthOffered <> "" Then
                        offered = NorthOffered
                    End If
                    If SouthOffered <> "PASS" And SouthOffered <> "" Then
                        offered = SouthOffered
                    End If
                End If
                If index = 2 Then
                    k = 16
                    j = 1
                    If NorthOffered <> "PASS" And NorthOffered <> "" Then
                        offered = NorthOffered
                    End If
                    If SouthOffered <> "PASS" And SouthOffered <> "" Then
                        offered = SouthOffered
                    End If
                End If

            Case "Horizontal"
                If index = 1 Then
                    k = 8
                    j = 2
                    If EastOffered <> "PASS" And EastOffered <> "" Then
                        offered = EastOffered
                    End If
                    If WestOffered <> "PASS" And WestOffered <> "" Then
                        offered = WestOffered
                    End If
                End If

                If index = 3 Then
                    j = 3
                    k = 24
                    If EastOffered <> "PASS" And EastOffered <> "" Then

                        offered = EastOffered
                    End If
                    If WestOffered <> "PASS" And WestOffered <> "" Then
                        offered = WestOffered
                    End If
                End If
        End Select

        For i = k To k + 7
            If Xartia(i).Enabled And Not Clicked(i) And Xartia(i).Text = offered And Xartia(i).Tag = 11 Then
                SuitNotToPlay = offered
                Exit For
            End If
        Next

        If (ClickCounter = 0) Or (ClickCounter = 1) Or (ClickCounter = 2) Or (ClickCounter = 3) Then ' mono ston proto giro kaleite aftos
            For i = k To k + 7  'o algorithmos giati de kseroume poia fili einai i moretribeplayed kai empeirika apofasizoume na 
                If Xartia(i).Enabled = True And Not Clicked(i) Then 'riksoume apo afto pou anoigoume. Meta de ksanakaleite kai kalountai oi 
                    If Xartia(i).Text = offered And Xartia(i).Text <> SuitNotToPlay And Xartia(i).Text <> Offer.Suite And Xartia(i).Tag <> 10 Then 'algorithmoi me to moretribe.
                        Return i
                    End If
                End If
            Next
            For i = k To k + 7
                If Xartia(i).Text <> SuitNotToPlay And Xartia(i).Text <> Offer.Suite And Xartia(i).Tag <> 10 And Xartia(i).Tag = 11 Then
                    Return i
                End If
            Next
            For i = k To k + 7
                If Xartia(i).Enabled And Not Clicked(i) And Xartia(i).Tag <> 10 And Xartia(i).Text <> offered And Xartia(i).Text <> Offer.Suite Then
                    Return i
                End If
            Next
        End If

        SuitNotToPlay = ""

        If AcePlayed Then
            For i = k To k + 7
                If Not Clicked(i) And Xartia(i).Enabled And Xartia(i).Text <> Offer.Suite And Xartia(i).Tag <> 10 Then
                    If Xartia(i).Text = MoreTribePlayed(k) Then
                        Return i
                    End If
                End If
            Next
            AcePlayed = False
        End If

        For i = k To k + 7   'rixnei ton asso me ta xartia tis ligoteris filis
            If Not Clicked(i) And Xartia(i).Enabled And Xartia(i).Text <> Offer.Suite Then
                If Xartia(i).Tag = 11 And Xartia(i).Text <> MoreTribePlayed(k) Then
                    AcePlayed = True
                    Return i
                End If
            End If
        Next



        For i = k To k + 7
            If Not Clicked(i) And Xartia(i).Enabled And Xartia(i).Text <> Offer.Suite Then
                If Xartia(i).Tag = 11 Then
                    AcePlayed = True
                    Return i
                End If
            End If
        Next




        For i = k To k + 7
            If Xartia(i).Enabled = True And Not Clicked(i) Then   'an exei apo ti fili pou paixtikan perissotera+ta dika tou rixnei tetoio
                If Xartia(i).Text <> Offer.Suite And Xartia(i).Tag <> 10 Then
                    If Xartia(i).Text = MoreTribePlayed(k) Then
                        Return i
                    End If
                End If
            End If
        Next

        For i = k To k + 7
            If Xartia(i).Enabled = True And Not Clicked(i) Then ''an den exei apo ti fili pou paixtikan perissotera , epilegei na riksei apo ta perissotera dika tou
                If Xartia(i).Text <> Offer.Suite And Xartia(i).Tag <> 10 Then
                    If Xartia(i).Text = PlayersMoreTribe(k) Then
                        Return i
                    End If
                End If
            End If
        Next







    End Function

    Function NotBought_NotPlaysFirst(ByVal Player As String) As Integer
        Dim PlaysLast, OppTsak, AllEnabled, Tsaka, OppNoAtou As Boolean
        Dim i, j, k, n, m, HowManyAtou, CS As Integer
        Dim min, max, ArrayMin(7), ArrayMax(7) As Double
        Dim SuitNotToPlay(3) As String

        Select Case SuiteCompare(index)
            Case "Hearts"
                CS = HCSPos
            Case "Diamonds"
                CS = DCSPos
            Case "Clubs"
                CS = CCSPos
            Case "Spades"
                CS = SCSPos
        End Select

        For i = 0 To 3
            SuitNotToPlay(i) = ""
        Next
       
        '------------------------------------------------
        TenNotALone(Player)
        Select Case Player
            Case "North"
                If (OppNoTribe("East", Offer.Suite) And OppNoTribe("West", Offer.Suite)) Then
                    OppNoAtou = True
                End If
                AllEnabled = NAllEnabled
                OppTsak = OppTsaka("East", SuiteCompare(index))
                k = 0
                If index = 1 Then
                    PlaysLast = True
                End If
            Case "East"
                If (OppNoTribe("South", Offer.Suite) And OppNoTribe("North", Offer.Suite)) Then
                    OppNoAtou = True
                End If
                AllEnabled = EAllEnabled
                OppTsak = OppTsaka("South", SuiteCompare(index))
                k = 8
                If index = 2 Then
                    PlaysLast = True
                End If
            Case "South"
                If (OppNoTribe("East", Offer.Suite) And OppNoTribe("West", Offer.Suite)) Then
                    OppNoAtou = True
                End If
                AllEnabled = SAllEnabled
                OppTsak = OppTsaka("West", SuiteCompare(index))
                k = 16
                If index = 3 Then
                    PlaysLast = True
                End If
            Case "West"
                If (OppNoTribe("North", Offer.Suite) And OppNoTribe("South", Offer.Suite)) Then
                    OppNoAtou = True
                End If
                AllEnabled = WAllEnabled
                OppTsak = OppTsaka("North", SuiteCompare(index))
                k = 24
                If index = 0 Then
                    PlaysLast = True
                End If
        End Select
        '--------------------------------------------------
        If SuiteCompare(index) <> Offer.Suite Then
            For i = k To k + 7
                If Xartia(i).Enabled And Not Clicked(i) Then
                    If Xartia(i).Text = Offer.Suite Then
                        Tsaka = True
                        Exit For
                    End If
                End If 'Elegxei an tsaka
            Next
        End If
        '---------------------------------------------------
        For i = k To k + 7
            If Xartia(i).Enabled And Not Clicked(i) And Xartia(i).Text = Offer.Suite Then
                HowManyAtou = HowManyAtou + 1
            End If
        Next

        If Not AllEnabled Then
            For i = 0 To 7
                ArrayMax(i) = 0
                ArrayMin(i) = 21
            Next

            For i = k To k + 7
                If Xartia(i).Enabled And Not Clicked(i) Then
                    ArrayMax(j) = Xartia(i).Tag
                    ArrayMin(j) = Xartia(i).Tag
                    j = j + 1
                End If
            Next

            max = ArrayMax(0)
            min = ArrayMin(0)

            For j = 0 To 7
                If ArrayMax(j) > max Then
                    max = ArrayMax(j)
                End If
                If ArrayMin(j) < min Then
                    min = ArrayMin(j)
                End If
            Next
        End If


        If PlaysLast Then
            If Tsaka Then
                ' an einai atou kai exei to J alla mporei na paiksei kai kati allo se atou, rixnei to allo
                For i = k To k + 7 'gia na kratisei to J 
                    If Xartia(i).Enabled And Not Clicked(i) And Xartia(i).Text = Offer.Suite And Xartia(i).Tag <> 20 Then
                        Return i
                    End If
                Next
            End If
            If Not Tsaka Then
                For i = k To k + 7
                    If Xartia(i).Enabled And Not Clicked(i) And Xartia(i).Text = Offer.Suite Then
                        If Not StandarLoses(i) And i = AtouCSPos() Then
                            For j = k To k + 7
                                If Xartia(j).Enabled And Not Clicked(j) And j <> AtouCSPos() Then
                                    ArrayMax(n) = Xartia(j).Tag
                                    n = n + 1
                                End If
                            Next
                            max = ArrayMax(0)
                            For n = 0 To 7
                                If max < ArrayMax(n) Then
                                    max = ArrayMax(n)
                                End If
                            Next
                            For j = k To k + 7
                                If Xartia(j).Enabled And Not Clicked(j) And Xartia(j).Tag = max Then
                                    Return j
                                End If
                            Next
                        End If
                    End If
                Next
                'If Not TeamMateWins(Player) Then
                'If Not AllEnabled Then
                'For i = k To k + 7
                'If Xartia(i).Enabled And Not Clicked(i) And Xartia(i).Tag = min Then
                'Return i
                'End If
                'Next

                'End If
                'End If
            End If

            If Not TeamMateWins(Player) Then
                If Not AllEnabled Then
                    For i = k To k + 7  'rixnei to mikrotero pou kerdizei an exoun pesei ta atou - Xarizei
                        If Xartia(i).Enabled And Not Clicked(i) And Not StandarLoses(i) And (AtouCounter = 8 Or (AtouCounter + HowManyAtou = 8)) Then
                            Return i
                        End If
                    Next
                    For i = k To k + 7
                        If Xartia(i).Enabled And Not Clicked(i) And StandarLoses(i) And (AtouCounter = 8 Or (AtouCounter + HowManyAtou = 8)) Then
                            If Xartia(i).Tag = min Then
                                Return i
                            End If
                        End If
                    Next
                End If
                If Not AllEnabled Then
                    For i = k To k + 7
                        If Xartia(i).Enabled And Not Clicked(i) And (AtouCounter <> 8 Or (HowManyAtou + AtouCounter <> 8)) Then
                            If Not StandarLoses(i) And i = CS Then
                                Return i
                            End If
                        End If
                    Next
                    For i = k To k + 7
                        If Xartia(i).Enabled And Not Clicked(i) And (AtouCounter <> 8 Or (HowManyAtou + AtouCounter <> 8)) Then
                            If Not StandarLoses(i) Then
                                Return i
                            End If
                        End If
                    Next
                    For i = k To k + 7
                        If Xartia(i).Enabled And Not Clicked(i) And (AtouCounter <> 8 Or (HowManyAtou + AtouCounter <> 8)) Then
                            If Xartia(i).Tag = min Then
                                Return i
                            End If
                        End If
                    Next

                End If
                '-----------------------------------------------------------------------------------------------------
                If AllEnabled Then



                    For i = k To k + 7
                        If Xartia(i).Enabled And Not Clicked(i) And Xartia(i).Tag = 11 Then
                            For j = 0 To 3
                                If SuitNotToPlay(j) = "" Then
                                    SuitNotToPlay(j) = Xartia(i).Text
                                    Exit For
                                End If
                            Next
                        End If
                    Next
                    For i = k To k + 7
                        If Xartia(i).Enabled And Not Clicked(i) And Xartia(i).Tag = 10 And Xartia(i).Text <> SuitNotToPlay(0) And Xartia(i).Text <> SuitNotToPlay(1) And Xartia(i).Text <> SuitNotToPlay(2) And Xartia(i).Text <> SuitNotToPlay(3) Then
                            For j = 0 To 3
                                If SuitNotToPlay(j) = "" Then
                                    SuitNotToPlay(j) = Xartia(i).Text
                                    Exit For
                                End If
                            Next
                        End If
                    Next
                    For i = k To k + 7
                        If Xartia(i).Enabled And Not Clicked(i) And Xartia(i).Text <> SuitNotToPlay(0) And Xartia(i).Text <> SuitNotToPlay(1) And Xartia(i).Text <> SuitNotToPlay(2) And Xartia(i).Text <> SuitNotToPlay(3) Then
                            Return i
                        End If
                    Next
                    
                   
                    
                    '----------------------------------------------------------aporriptei files me assous kai 10aria kai rixnei apo tin alli - skartarei

                    For i = 0 To 7
                        ArrayMax(i) = 0
                        ArrayMin(i) = 21
                    Next
                  
                   
                    j = 0
                    For i = k To k + 7
                        If Xartia(i).Enabled And Not Clicked(i) And Xartia(i).Text <> SuitNotToPlay(0) And Xartia(i).Text <> SuitNotToPlay(1) And Xartia(i).Text <> SuitNotToPlay(2) And Xartia(i).Text <> SuitNotToPlay(3) Then
                            ArrayMin(j) = Xartia(i).Tag
                            j = j + 1
                        End If
                    Next
                    min = ArrayMin(0)
                    For i = 1 To 7
                        If ArrayMin(i) < min Then
                            min = ArrayMin(i)
                        End If
                    Next
                    For i = k To k + 7
                        If Xartia(i).Enabled And Not Clicked(i)  And Xartia(i).Text <> SuitNotToPlay(0) And Xartia(i).Text <> SuitNotToPlay(1) And Xartia(i).Text <> SuitNotToPlay(2) And Xartia(i).Text <> SuitNotToPlay(3) Then
                            If Xartia(i).Tag = min Then
                                Return i
                            End If
                        End If
                    Next
                    '-----an exoume mono files me assous kai 10aria, rixnoume to mikrotero apo ti fili tou assou
                    For i = 0 To 7
                        ArrayMin(i) = 21
                    Next
                    For i = 0 To 3
                        SuitNotToPlay(i) = ""
                    Next
                    j = 0
                    n = 0
                    For i = k To k + 7
                        If Xartia(i).Enabled And Not Clicked(i) And Xartia(i).Tag = 10 Then
                            SuitNotToPlay(j) = Xartia(i).Text
                            j = j + 1
                        End If
                    Next        'aporiptei files me 10 kai vriskei to mikrotero apo ti fili A kai to rixnei 
                    For i = k To k + 7   'ektos tou A fisika
                        If Xartia(i).Enabled And Not Clicked(i) And Xartia(i).Text <> SuitNotToPlay(0) And Xartia(i).Text <> SuitNotToPlay(1) And Xartia(i).Text <> SuitNotToPlay(2) And Xartia(i).Text <> SuitNotToPlay(3) Then
                            ArrayMin(n) = Xartia(i).Tag
                            n = n + 1
                        End If
                    Next
                    min = ArrayMin(0)
                    For i = 1 To 7
                        If min > ArrayMin(i) Then
                            min = ArrayMin(i)
                        End If
                    Next
                    For i = k To k + 7
                        If Xartia(i).Enabled And Not Clicked(i) And Xartia(i).Tag <> 11 And Xartia(i).Tag = min And Xartia(i).Text <> SuitNotToPlay(0) And Xartia(i).Text <> SuitNotToPlay(1) And Xartia(i).Text <> SuitNotToPlay(2) And Xartia(i).Text <> SuitNotToPlay(3) Then
                            Return i
                        End If
                    Next
                    '----------------------------------------------------------------------------------------------------
                    For i = 0 To 3
                        SuitNotToPlay(i) = ""
                    Next
                    For i = k To k + 7
                        If Xartia(i).Enabled And Not Clicked(i) Then
                            If Xartia(i).Tag = 10 Then
                                Select Case Xartia(i).Text
                                    Case "Hearts"
                                        If CardsWithTenH < 2 Then
                                            SuitNotToPlay(0) = "Hearts"
                                        End If
                                    Case "Diamonds"
                                        If CardsWithTenD < 2 Then
                                            SuitNotToPlay(1) = "Diamonds"
                                        End If
                                    Case "Clubs"
                                        If CardsWithTenC < 2 Then
                                            SuitNotToPlay(2) = "Clubs"
                                        End If
                                    Case "Spades"
                                        If CardsWithTenS < 2 Then
                                            SuitNotToPlay(3) = "Spades"
                                        End If
                                End Select
                            End If
                        End If
                    Next


                    j = 0
                    For i = 0 To 7
                        ArrayMax(i) = 0
                        ArrayMin(i) = 21
                    Next
                    For i = k To k + 7
                        If Xartia(i).Enabled And Not Clicked(i) And Xartia(i).Text <> SuitNotToPlay(0) And Xartia(i).Text <> SuitNotToPlay(1) And Xartia(i).Text <> SuitNotToPlay(2) And Xartia(i).Text <> SuitNotToPlay(3) Then
                            ArrayMin(j) = Xartia(i).Tag
                            j = j + 1
                        End If
                    Next
                    min = ArrayMin(0)
                    For i = 1 To 7
                        If ArrayMin(i) < min Then
                            min = ArrayMin(i)
                        End If
                    Next
                    For i = k To k + 7
                        If Xartia(i).Enabled And Not Clicked(i) And Xartia(i).Text <> SuitNotToPlay(0) And Xartia(i).Text <> SuitNotToPlay(1) And Xartia(i).Text <> SuitNotToPlay(2) And Xartia(i).Text <> SuitNotToPlay(3) Then
                            If Xartia(i).Tag = min Then
                                Return i
                            End If
                        End If
                    Next
                    '------------an exoume mono files me 10aria, rixnei apo to dekari pou exei piopolla apo 2 xartia, to mikrotero apo afta




                    For i = k To k + 7 'An exei na epileksei poio 10ari na afisei ksero, epilegei afto pou exoun pesei perissotera xartia tis filis tou, ara me ligoteres pithanotites na paixtei 
                        If Xartia(i).Enabled And Not Clicked(i) And Xartia(i).Text = MoreTribePlayed(k) And Xartia(i).Tag <> 10 Then 'gia na kerdisei
                            Return i
                        End If
                    Next
                    For i = k To k + 7
                        If Xartia(i).Enabled And Not Clicked(i) Then
                            If Xartia(i).Tag <> 10 Then
                                Return i
                            End If
                        End If
                    Next
                End If
            End If
            '---------------playslast, teammatewins ------------------------------------------------------------------------------------------
            If TeamMateWins(Player) Then
                If Not AllEnabled Then
                    If ((AtouCounter + HowManyAtou) = 8 Or OppNoAtou) Then
                        For i = k To k + 7
                            If Xartia(i).Enabled And Not Clicked(i) And StandarLoses(i) Then
                                Return i
                            End If
                        Next
                        For i = k To k + 7
                            If Xartia(i).Enabled And Not Clicked(i) And Not StandarLoses(i) Then
                                Return i
                            End If
                        Next
                    End If
                    If ((AtouCounter + HowManyAtou) <> 8 Or Not OppNoAtou) Then
                        For i = k To k + 7
                            If Xartia(i).Enabled And Not Clicked(i) And i = AtouCSPos() Then
                                Return i
                            End If
                        Next
                        For i = k To k + 7
                            If Xartia(i).Enabled And Not Clicked(i) And Not StandarLoses(i) Then
                                Return i
                            End If
                        Next
                        For i = k To k + 7
                            If Xartia(i).Enabled And Not Clicked(i) And StandarLoses(i) Then
                                If Xartia(i).Tag = max Then
                                    Return i
                                End If
                            End If
                        Next
                    End If
                End If

                If AllEnabled Then
                    For i = 0 To 3
                        SuitNotToPlay(i) = ""
                    Next
                    For i = 0 To 7
                        ArrayMax(i) = 0
                        ArrayMin(i) = 21
                    Next
                    If ((AtouCounter + HowManyAtou) = 8 Or OppNoAtou) Then

                        For i = k To k + 7
                            If Xartia(i).Enabled And Not Clicked(i) And Xartia(i).Tag = 11 Then
                                For j = 0 To 3
                                    If SuitNotToPlay(j) = "" Then
                                        SuitNotToPlay(j) = Xartia(i).Text
                                        Exit For
                                    End If
                                Next
                            End If
                        Next
                        For i = k To k + 7
                            If Xartia(i).Enabled And Not Clicked(i) And Xartia(i).Tag = 10 Then
                                For j = 0 To 3
                                    If SuitNotToPlay(j) = "" Then
                                        SuitNotToPlay(j) = Xartia(i).Text
                                        Exit For
                                    End If
                                Next
                            End If
                        Next
                        n = 0

                        For i = k To k + 7
                            If Xartia(i).Enabled And Not Clicked(i) And Xartia(i).Text <> SuitNotToPlay(0) And Xartia(i).Text <> SuitNotToPlay(1) And Xartia(i).Text <> SuitNotToPlay(2) And Xartia(i).Text <> SuitNotToPlay(3) Then
                                ArrayMax(n) = Xartia(i).Tag
                                n = n + 1
                            End If
                        Next
                        max = ArrayMax(0)
                        For i = 0 To 7
                            If max < ArrayMax(i) Then
                                max = ArrayMax(i)
                            End If
                        Next
                        For i = k To k + 7
                            If Xartia(i).Enabled And Not Clicked(i) And Xartia(i).Text <> SuitNotToPlay(0) And Xartia(i).Text <> SuitNotToPlay(1) And Xartia(i).Text <> SuitNotToPlay(2) And Xartia(i).Text <> SuitNotToPlay(3) Then
                                If Xartia(i).Tag = max Then
                                    Return i
                                End If
                            End If
                        Next
                        '----------------------------------------------------------aporriptei files me assous kai 10aria kai rixnei apo tin alli - skartarei

                        For i = 0 To 7
                            ArrayMax(i) = 0
                            ArrayMin(i) = 21
                        Next
                        For i = 0 To 3
                            SuitNotToPlay(i) = ""
                        Next
                        For i = k To k + 7
                            If Xartia(i).Enabled And Not Clicked(i) And Xartia(i).Tag = 10 Then
                                For j = 0 To 3
                                    If SuitNotToPlay(j) = "" Then
                                        SuitNotToPlay(j) = Xartia(i).Text
                                        Exit For
                                    End If
                                Next
                            End If
                        Next
                        j = 0
                        For i = k To k + 7
                            If Xartia(i).Enabled And Not Clicked(i) And Xartia(i).Text <> SuitNotToPlay(0) And Xartia(i).Text <> SuitNotToPlay(1) And Xartia(i).Text <> SuitNotToPlay(2) And Xartia(i).Text <> SuitNotToPlay(3) Then
                                ArrayMax(j) = Xartia(i).Tag
                                j = j + 1
                            End If
                        Next
                        max = ArrayMax(0)
                        For i = 1 To 7
                            If ArrayMax(i) > max Then
                                max = ArrayMax(i)
                            End If
                        Next
                        For i = k To k + 7
                            If Xartia(i).Enabled And Not Clicked(i) And Xartia(i).Tag <> 11 And Xartia(i).Text <> SuitNotToPlay(0) And Xartia(i).Text <> SuitNotToPlay(1) And Xartia(i).Text <> SuitNotToPlay(2) And Xartia(i).Text <> SuitNotToPlay(3) Then
                                If Xartia(i).Tag = max Then
                                    Return i
                                End If
                            End If
                        Next
                        '-----an exoume mono files me assous kai 10aria, rixnoume to mikrotero apo ti fili tou assou

                        For i = 0 To 3
                            SuitNotToPlay(i) = ""
                        Next
                        For i = k To k + 7
                            If Xartia(i).Enabled And Not Clicked(i) Then
                                If Xartia(i).Tag = 10 Then
                                    Select Case Xartia(i).Text
                                        Case "Hearts"
                                            If CardsWithTenH < 2 Then
                                                SuitNotToPlay(0) = "Hearts"
                                            End If
                                        Case "Diamonds"

                                            If CardsWithTenD < 2 Then
                                                SuitNotToPlay(1) = "Diamonds"
                                            End If
                                        Case "Clubs"

                                            If CardsWithTenC < 2 Then
                                                SuitNotToPlay(2) = "Clubs"
                                            End If
                                        Case "Spades"

                                            If CardsWithTenS < 2 Then
                                                SuitNotToPlay(3) = "Spades"
                                            End If
                                    End Select
                                End If
                            End If
                        Next


                        j = 0
                        For i = 0 To 7
                            ArrayMax(i) = 0
                            ArrayMin(i) = 21
                        Next
                        For i = k To k + 7
                            If Xartia(i).Enabled And Not Clicked(i) And Xartia(i).Text <> SuitNotToPlay(0) And Xartia(i).Text <> SuitNotToPlay(1) And Xartia(i).Text <> SuitNotToPlay(2) And Xartia(i).Text <> SuitNotToPlay(3) Then
                                ArrayMax(j) = Xartia(i).Tag
                                j = j + 1
                            End If
                        Next
                        max = ArrayMax(0)
                        For i = 1 To 7
                            If ArrayMax(i) > max Then
                                max = ArrayMax(i)
                            End If
                        Next
                        For i = k To k + 7
                            If Xartia(i).Enabled And Not Clicked(i) And Xartia(i).Text <> SuitNotToPlay(0) And Xartia(i).Text <> SuitNotToPlay(1) And Xartia(i).Text <> SuitNotToPlay(2) And Xartia(i).Text <> SuitNotToPlay(3) Then
                                If Xartia(i).Tag = max Then
                                    Return i
                                End If
                            End If
                        Next
                        '------------an exoume mono files me 10aria, rixnei apo to dekari pou exei pio polla apo 2 xartia, to mikrotero apo afta




                        For i = k To k + 7 'An exei na epileksei poio 10ari na afisei ksero, epilegei afto pou exoun pesei perissotera xartia tis filis tou, ara me ligoteres pithanotites na paixtei 
                            If Xartia(i).Enabled And Not Clicked(i) And Xartia(i).Text <> MoreTribePlayed(k) And Xartia(i).Tag <> 10 Then 'gia na kerdisei
                                Return i
                            End If
                        Next
                        For i = k To k + 7
                            If Xartia(i).Enabled And Not Clicked(i) Then
                                If Xartia(i).Tag <> 10 Then
                                    Return i
                                End If
                            End If
                        Next
                    End If

                    If AtouCounter <> 8 Then
                        For i = k To k + 7
                            If Xartia(i).Enabled And Not Clicked(i) Then
                                Select Case Xartia(i).Text
                                    Case "Hearts"
                                        If i = HCSPos Then
                                            If HeartsCounter = 7 Then
                                                Return i
                                            End If
                                        End If
                                    Case "Diamonds"
                                        If i = DCSPos Then
                                            If DiamondsCounter = 7 Then
                                                Return i
                                            End If
                                        End If
                                    Case "Clubs"
                                        If i = CCSPos Then
                                            If ClubsCounter = 7 Then
                                                Return i
                                            End If
                                        End If
                                    Case "Spades"
                                        If i = SCSPos Then
                                            If SpadesCounter = 7 Then
                                                Return i
                                            End If
                                        End If
                                End Select
                            End If
                        Next
                        For i = k To k + 7
                            If Xartia(i).Enabled And Not Clicked(i) And Xartia(i).Tag = 10 Then
                                Select Case Xartia(i).Text
                                    Case "Hearts"
                                        If i = HCSPos Then
                                            If Not TenHeartsNA Then
                                                Return i
                                            End If
                                        End If
                                    Case "Diamonds"
                                        If i = DCSPos Then
                                            If Not TenDiamondsNA Then
                                                Return i
                                            End If
                                        End If
                                    Case "Clubs"
                                        If i = CCSPos Then
                                            If Not TenClubsNA Then
                                                Return i
                                            End If
                                        End If
                                    Case "Spades"
                                        If i = SCSPos Then
                                            If Not TenSpadesNA Then
                                                Return i
                                            End If
                                        End If
                                End Select

                            End If
                        Next
                        For i = k To k + 7
                            If Xartia(i).Enabled And Not Clicked(i) Then
                                Select Case Xartia(i).Text
                                    Case "Hearts"
                                        If i <> HCSPos Then
                                            Return i
                                        End If
                                    Case "Diamonds"
                                        If i <> DCSPos Then

                                            Return i

                                        End If
                                    Case "Clubs"
                                        If i <> CCSPos Then

                                            Return i

                                        End If
                                    Case "Spades"
                                        If i <> SCSPos Then

                                            Return i

                                        End If
                                End Select

                            End If
                        Next
                    End If
                End If
            End If

        End If
        '--------End if All Enabled------------------------------------------------------------------------------------------------


        j = 0
        '--------------------------------------------------------------------------------------------
        If Not PlaysLast Then
            If Not AllEnabled Then
                If Not TeamMateWins(Player) Then
                    If Not OppTsak Then
                        For i = k To k + 7
                            If Xartia(i).Enabled And Not Clicked(i) Then 'And Xartia(i).Text <> Offer.Suite Then
                                If i = CS And Not StandarLoses(i) Then
                                    Return i
                                End If
                            End If
                        Next
                        For i = k To k + 7
                            If Xartia(i).Enabled And Not Clicked(i) Then 'And Xartia(i).Text <> Offer.Suite Then
                                If StandarLoses(i) And Xartia(i).Tag = min Then
                                    Return i
                                End If
                            End If
                        Next
                        For i = k To k + 7
                            If Xartia(i).Enabled And Not Clicked(i) Then 'And Xartia(i).Text <> Offer.Suite Then
                                If Not StandarLoses(i) Then
                                    Return i
                                End If
                            End If
                        Next
                    ElseIf OppTsak Then
                        For i = k To k + 7
                            If Xartia(i).Enabled And Not Clicked(i) Then 'And Xartia(i).Text <> Offer.Suite Then
                                If Xartia(i).Tag = min Then
                                    Return i
                                End If
                            End If
                        Next
                    End If
                ElseIf TeamMateWins(Player) Then
                    If (OppNoAtou Or (AtouCounter = 8) Or (AtouCounter + HowManyAtou = 8)) Then
                        For i = k To k + 7
                            If Xartia(i).Enabled And Not Clicked(i) Then 'And Xartia(i).Text <> Offer.Suite Then
                                If Not StandarLoses(i) Then
                                    Return i
                                End If
                            End If
                        Next
                        For i = k To k + 7
                            If Xartia(i).Enabled And Not Clicked(i) Then ' And Xartia(i).Text <> Offer.Suite Then
                                If StandarLoses(i) Then
                                    If Xartia(i).Tag = max And i <> CS Then
                                        Return i
                                    End If
                                End If
                            End If
                        Next
                    ElseIf Not OppTsak Then
                        For i = k To k + 7
                            If Xartia(i).Enabled And Not Clicked(i) Then 'And Xartia(i).Text <> Offer.Suite Then
                                If i = CS Then
                                    Return i
                                End If
                            End If
                        Next
                        For i = k To k + 7
                            If Xartia(i).Enabled And Not Clicked(i) Then 'And Xartia(i).Text <> Offer.Suite Then
                                If Xartia(i).Tag = max Then
                                    Return i
                                End If
                            End If
                        Next
                    ElseIf OppTsak Then
                        For i = k To k + 7
                            If Xartia(i).Enabled And Not Clicked(i) Then 'And Xartia(i).Text <> Offer.Suite Then
                                If Xartia(i).Tag = min Then
                                    Return i
                                End If
                            End If
                        Next
                    End If
                End If
            End If
        End If

        '---------End if not playslast-not all enabled -------------------------------------------------------------
        If Not PlaysLast Then
            If AllEnabled Then
                If Not TeamMateWins(Player) Then
                    For i = 0 To 7
                        ArrayMax(i) = 0
                        ArrayMin(i) = 21
                    Next
                    For i = 0 To 3
                        SuitNotToPlay(i) = ""
                    Next
                    j = 0
                    n = 0
                    For i = k To k + 7
                        If Xartia(i).Enabled And Not Clicked(i) And Xartia(i).Tag = 11 Then
                            For j = 0 To 3
                                If SuitNotToPlay(j) = "" Then
                                    SuitNotToPlay(j) = Xartia(i).Text ' min paikseis apo asso
                                    Exit For
                                End If
                            Next
                        End If
                    Next
                    For i = k To k + 7
                        If Xartia(i).Enabled And Not Clicked(i) And Xartia(i).Text <> SuitNotToPlay(0) And Xartia(i).Text <> SuitNotToPlay(1) And Xartia(i).Text <> SuitNotToPlay(2) And Xartia(i).Text <> SuitNotToPlay(3) Then
                            If Xartia(i).Tag = 10 Then
                                For j = 0 To 3
                                    If SuitNotToPlay(j) = "" Then
                                        SuitNotToPlay(j) = Xartia(i).Text ' ,in paikseis apo 10
                                        Exit For
                                    End If
                                Next
                            End If
                        End If
                    Next
                    For i = k To k + 7
                        If Xartia(i).Enabled And Not Clicked(i) And Xartia(i).Text <> SuitNotToPlay(0) And Xartia(i).Text <> SuitNotToPlay(1) And Xartia(i).Text <> SuitNotToPlay(2) And Xartia(i).Text <> SuitNotToPlay(3) Then
                            ArrayMin(n) = Xartia(i).Tag
                            n = n + 1
                        End If
                    Next
                    min = ArrayMin(0)
                    For i = 1 To 7
                        If min < ArrayMin(i) Then
                            min = ArrayMin(i)
                        End If
                    Next
                    For i = k To k + 7
                        If Xartia(i).Enabled And Not Clicked(i) And Xartia(i).Text <> SuitNotToPlay(0) And Xartia(i).Text <> SuitNotToPlay(1) And Xartia(i).Text <> SuitNotToPlay(2) And Xartia(i).Text <> SuitNotToPlay(3) Then
                            If Xartia(i).Tag = min Then
                                Return i
                            End If
                        End If
                    Next
                    '------------rixnei to mikrotero apo files ektos assou kai 10ariou
                    For i = k To k + 7
                        If Xartia(i).Enabled And Not Clicked(i) Then
                            If Xartia(i).Tag = 10 Then
                                Select Case Xartia(i).Text
                                    Case "Hearts"
                                        If CardsWithTenH > 1 Then
                                            For j = k To k + 7
                                                If Xartia(j).Enabled And Not Clicked(j) And Xartia(j).Text = "Hearts" And Xartia(j).Tag <> 10 And Xartia(j).Tag <> 11 Then
                                                    Return j
                                                End If
                                            Next
                                        End If
                                    Case "Diamonds"
                                        If CardsWithTenD > 1 Then
                                            For j = k To k + 7
                                                If Xartia(j).Enabled And Not Clicked(j) And Xartia(j).Text = "Diamonds" And Xartia(j).Tag <> 10 And Xartia(j).Tag <> 11 Then
                                                    Return j
                                                End If
                                            Next
                                        End If
                                    Case "Clubs"
                                        If CardsWithTenC > 1 Then
                                            For j = k To k + 7
                                                If Xartia(j).Enabled And Not Clicked(j) And Xartia(j).Text = "Clubs" And Xartia(j).Tag <> 10 And Xartia(j).Tag <> 11 Then
                                                    Return j
                                                End If
                                            Next
                                        End If
                                    Case "Spades"
                                        If CardsWithTenH > 1 Then
                                            For j = k To k + 7
                                                If Xartia(j).Enabled And Not Clicked(j) And Xartia(j).Text = "Spades" And Xartia(j).Tag <> 10 And Xartia(j).Tag <> 11 Then
                                                    Return j
                                                End If
                                            Next
                                        End If
                                End Select
                            End If
                        End If
                    Next '--------an vrei 10ari me 2 xartia, na riksei apo afto , oxi omos to 10ari kai ton asso

                    For i = k To k + 7
                        If Xartia(i).Enabled And Not Clicked(i) And Xartia(i).Tag <> 10 Then
                            Return i ' an den ginei tpt apo ta parapano, na riksei to proto pou vriskei ektos 10
                        End If
                    Next
                    For i = k To k + 7
                        If Xartia(i).Enabled And Not Clicked(i) Then
                            Return i ' an den ginei tpt apo ta parapano, na riksei to proto pou vriskei 
                        End If
                    Next
                End If
                If TeamMateWins(Player) Then
                    If (AtouCounter = 8) Then

                        Select Case SuiteCompare(index)
                            Case "Hearts"
                                If Clicked(HSP) Then
                                    For i = 0 To 7
                                        ArrayMax(i) = 0
                                        ArrayMin(i) = 21
                                    Next
                                    For i = 0 To 3
                                        SuitNotToPlay(i) = ""
                                    Next
                                    j = 0
                                    n = 0
                                    For i = k To k + 7
                                        If Xartia(i).Enabled And Not Clicked(i) And Xartia(i).Tag = 11 Then
                                            For j = 0 To 3
                                                If SuitNotToPlay(j) = "" Then
                                                    SuitNotToPlay(j) = Xartia(i).Text ' min paikseis apo asso
                                                    Exit For
                                                End If
                                            Next
                                        End If
                                    Next
                                    For i = k To k + 7
                                        If Xartia(i).Enabled And Not Clicked(i) And Xartia(i).Text <> SuitNotToPlay(0) And Xartia(i).Text <> SuitNotToPlay(1) And Xartia(i).Text <> SuitNotToPlay(2) And Xartia(i).Text <> SuitNotToPlay(3) Then
                                            If Xartia(i).Tag = 10 Then
                                                For j = 0 To 3
                                                    If SuitNotToPlay(j) = "" Then
                                                        SuitNotToPlay(j) = Xartia(i).Text ' ,in paikseis apo 10
                                                        Exit For
                                                    End If
                                                Next
                                            End If
                                        End If
                                    Next
                                    For i = k To k + 7
                                        If Xartia(i).Enabled And Not Clicked(i) And Xartia(i).Text <> SuitNotToPlay(0) And Xartia(i).Text <> SuitNotToPlay(1) And Xartia(i).Text <> SuitNotToPlay(2) And Xartia(i).Text <> SuitNotToPlay(3) Then
                                            ArrayMin(n) = Xartia(i).Tag
                                            n = n + 1
                                        End If
                                    Next
                                    min = ArrayMin(0)
                                    For i = 1 To 7
                                        If min < ArrayMin(i) Then
                                            min = ArrayMin(i)
                                        End If
                                    Next
                                    For i = k To k + 7
                                        If Xartia(i).Enabled And Not Clicked(i) And Xartia(i).Text <> SuitNotToPlay(0) And Xartia(i).Text <> SuitNotToPlay(1) And Xartia(i).Text <> SuitNotToPlay(2) And Xartia(i).Text <> SuitNotToPlay(3) Then
                                            If Xartia(i).Tag = min Then
                                                Return i
                                            End If
                                        End If
                                    Next
                                End If
                            Case "Diamonds"
                                If Clicked(DSP) Then
                                    For i = 0 To 7
                                        ArrayMax(i) = 0
                                        ArrayMin(i) = 21
                                    Next
                                    For i = 0 To 3
                                        SuitNotToPlay(i) = ""
                                    Next
                                    j = 0
                                    n = 0
                                    For i = k To k + 7
                                        If Xartia(i).Enabled And Not Clicked(i) And Xartia(i).Tag = 11 Then
                                            For j = 0 To 3
                                                If SuitNotToPlay(j) = "" Then
                                                    SuitNotToPlay(j) = Xartia(i).Text ' min paikseis apo asso
                                                    Exit For
                                                End If
                                            Next
                                        End If
                                    Next
                                    For i = k To k + 7
                                        If Xartia(i).Enabled And Not Clicked(i) And Xartia(i).Text <> SuitNotToPlay(0) And Xartia(i).Text <> SuitNotToPlay(1) And Xartia(i).Text <> SuitNotToPlay(2) And Xartia(i).Text <> SuitNotToPlay(3) Then
                                            If Xartia(i).Tag = 10 Then
                                                For j = 0 To 3
                                                    If SuitNotToPlay(j) = "" Then
                                                        SuitNotToPlay(j) = Xartia(i).Text ' ,in paikseis apo 10
                                                        Exit For
                                                    End If
                                                Next
                                            End If
                                        End If
                                    Next
                                    For i = k To k + 7
                                        If Xartia(i).Enabled And Not Clicked(i) And Xartia(i).Text <> SuitNotToPlay(0) And Xartia(i).Text <> SuitNotToPlay(1) And Xartia(i).Text <> SuitNotToPlay(2) And Xartia(i).Text <> SuitNotToPlay(3) Then
                                            ArrayMin(n) = Xartia(i).Tag
                                            n = n + 1
                                        End If
                                    Next
                                    min = ArrayMin(0)
                                    For i = 1 To 7
                                        If min < ArrayMin(i) Then
                                            min = ArrayMin(i)
                                        End If
                                    Next
                                    For i = k To k + 7
                                        If Xartia(i).Enabled And Not Clicked(i) And Xartia(i).Text <> SuitNotToPlay(0) And Xartia(i).Text <> SuitNotToPlay(1) And Xartia(i).Text <> SuitNotToPlay(2) And Xartia(i).Text <> SuitNotToPlay(3) Then
                                            If Xartia(i).Tag = min Then
                                                Return i
                                            End If
                                        End If
                                    Next
                                End If
                            Case "Clubs"
                                If Clicked(CSP) Then
                                    For i = 0 To 7
                                        ArrayMax(i) = 0
                                        ArrayMin(i) = 21
                                    Next
                                    For i = 0 To 3
                                        SuitNotToPlay(i) = ""
                                    Next
                                    j = 0
                                    n = 0
                                    For i = k To k + 7
                                        If Xartia(i).Enabled And Not Clicked(i) And Xartia(i).Tag = 11 Then
                                            For j = 0 To 3
                                                If SuitNotToPlay(j) = "" Then
                                                    SuitNotToPlay(j) = Xartia(i).Text ' min paikseis apo asso
                                                    Exit For
                                                End If
                                            Next
                                        End If
                                    Next
                                    For i = k To k + 7
                                        If Xartia(i).Enabled And Not Clicked(i) And Xartia(i).Text <> SuitNotToPlay(0) And Xartia(i).Text <> SuitNotToPlay(1) And Xartia(i).Text <> SuitNotToPlay(2) And Xartia(i).Text <> SuitNotToPlay(3) Then
                                            If Xartia(i).Tag = 10 Then
                                                For j = 0 To 3
                                                    If SuitNotToPlay(j) = "" Then
                                                        SuitNotToPlay(j) = Xartia(i).Text ' ,in paikseis apo 10
                                                        Exit For
                                                    End If
                                                Next
                                            End If
                                        End If
                                    Next
                                    For i = k To k + 7
                                        If Xartia(i).Enabled And Not Clicked(i) And Xartia(i).Text <> SuitNotToPlay(0) And Xartia(i).Text <> SuitNotToPlay(1) And Xartia(i).Text <> SuitNotToPlay(2) And Xartia(i).Text <> SuitNotToPlay(3) Then
                                            ArrayMin(n) = Xartia(i).Tag
                                            n = n + 1
                                        End If
                                    Next
                                    min = ArrayMin(0)
                                    For i = 1 To 7
                                        If min < ArrayMin(i) Then
                                            min = ArrayMin(i)
                                        End If
                                    Next
                                    For i = k To k + 7
                                        If Xartia(i).Enabled And Not Clicked(i) And Xartia(i).Text <> SuitNotToPlay(0) And Xartia(i).Text <> SuitNotToPlay(1) And Xartia(i).Text <> SuitNotToPlay(2) And Xartia(i).Text <> SuitNotToPlay(3) Then
                                            If Xartia(i).Tag = min Then
                                                Return i
                                            End If
                                        End If
                                    Next
                                End If
                            Case "Spades"
                                If Clicked(SSP) Then
                                    For i = 0 To 7
                                        ArrayMax(i) = 0
                                        ArrayMin(i) = 21
                                    Next
                                    For i = 0 To 3
                                        SuitNotToPlay(i) = ""
                                    Next
                                    j = 0
                                    n = 0
                                    For i = k To k + 7
                                        If Xartia(i).Enabled And Not Clicked(i) And Xartia(i).Tag = 11 Then
                                            For j = 0 To 3
                                                If SuitNotToPlay(j) = "" Then
                                                    SuitNotToPlay(j) = Xartia(i).Text ' min paikseis apo asso
                                                    Exit For
                                                End If
                                            Next
                                        End If
                                    Next
                                    For i = k To k + 7
                                        If Xartia(i).Enabled And Not Clicked(i) And Xartia(i).Text <> SuitNotToPlay(0) And Xartia(i).Text <> SuitNotToPlay(1) And Xartia(i).Text <> SuitNotToPlay(2) And Xartia(i).Text <> SuitNotToPlay(3) Then
                                            If Xartia(i).Tag = 10 Then
                                                For j = 0 To 3
                                                    If SuitNotToPlay(j) = "" Then
                                                        SuitNotToPlay(j) = Xartia(i).Text ' ,in paikseis apo 10
                                                        Exit For
                                                    End If
                                                Next
                                            End If
                                        End If
                                    Next
                                    For i = k To k + 7
                                        If Xartia(i).Enabled And Not Clicked(i) And Xartia(i).Text <> SuitNotToPlay(0) And Xartia(i).Text <> SuitNotToPlay(1) And Xartia(i).Text <> SuitNotToPlay(2) And Xartia(i).Text <> SuitNotToPlay(3) Then
                                            ArrayMin(n) = Xartia(i).Tag
                                            n = n + 1
                                        End If
                                    Next
                                    min = ArrayMin(0)
                                    For i = 1 To 7
                                        If min < ArrayMin(i) Then
                                            min = ArrayMin(i)
                                        End If
                                    Next
                                    For i = k To k + 7
                                        If Xartia(i).Enabled And Not Clicked(i) And Xartia(i).Text <> SuitNotToPlay(0) And Xartia(i).Text <> SuitNotToPlay(1) And Xartia(i).Text <> SuitNotToPlay(2) And Xartia(i).Text <> SuitNotToPlay(3) Then
                                            If Xartia(i).Tag = min Then
                                                Return i
                                            End If
                                        End If
                                    Next
                                End If
                        End Select

                        If AtouCounter <> 8 Then
                            If Clicked(AtouCSPos()) Then
                                For i = k To k + 7
                                    If Xartia(i).Enabled And Not Clicked(i) Then
                                        Select Case Xartia(i).Text
                                            Case "Hearts"
                                                If i = HCSPos Then
                                                    If HeartsCounter = 7 Then
                                                        Return i
                                                    End If
                                                End If
                                            Case "Diamonds"
                                                If i = DCSPos Then
                                                    If DiamondsCounter = 7 Then
                                                        Return i
                                                    End If
                                                End If
                                            Case "Clubs"
                                                If i = CCSPos Then
                                                    If ClubsCounter = 7 Then
                                                        Return i
                                                    End If
                                                End If
                                            Case "Spades"
                                                If i = SCSPos Then
                                                    If SpadesCounter = 7 Then
                                                        Return i
                                                    End If
                                                End If
                                        End Select
                                    End If
                                Next
                                For i = k To k + 7
                                    If Xartia(i).Enabled And Not Clicked(i) And Xartia(i).Tag = 10 Then
                                        Select Case Xartia(i).Text
                                            Case "Hearts"
                                                If i = HCSPos Then
                                                    If Not TenHeartsNA Then
                                                        Return i
                                                    End If
                                                End If
                                            Case "Diamonds"
                                                If i = DCSPos Then
                                                    If Not TenDiamondsNA Then
                                                        Return i
                                                    End If
                                                End If
                                            Case "Clubs"
                                                If i = CCSPos Then
                                                    If Not TenClubsNA Then
                                                        Return i
                                                    End If
                                                End If
                                            Case "Spades"
                                                If i = SCSPos Then
                                                    If Not TenSpadesNA Then
                                                        Return i
                                                    End If
                                                End If
                                        End Select

                                    End If
                                Next
                            End If

                        End If

                    End If
                End If
            End If
        End If
        '---------End if not playslast-allenabled--------------------------------------------------------
        If Not PlaysLast Then
            If Tsaka Then
                max = 0
                For i = 0 To 7
                    ArrayMax(i) = 0
                Next
                For i = k To k + 7
                    If Xartia(i).Enabled And Not Clicked(i) And i <> AtouCSPos() Then
                        ArrayMax(j) = Xartia(i).Tag
                        j = j + 1
                    End If
                Next
                max = ArrayMax(0)
                For i = 0 To 7
                    If ArrayMax(i) > max Then
                        max = ArrayMax(i)
                    End If
                Next
                For i = k To k + 7
                    If Xartia(i).Enabled And Not Clicked(i) And Xartia(i).Tag = max Then
                        Return i
                    End If
                Next
            End If
        End If    'An tsaka kai exei to kalitero, den to rixnei , rixnei to amesos epomeno megalitero,an den exei to kalitero, rixnei apla to megalitero
        '-----------------------------------------------------------------------------------------------------------------------------------------------
        'mipos prepei na mpei if not allenabled edo mexri telos?? na to do
        For i = 0 To 7
            ArrayMax(i) = 0
            ArrayMin(i) = 21
        Next
        For i = 0 To 3
            SuitNotToPlay(i) = ""
        Next
        min = ArrayMax(0)
        For i = 1 To 7
            If min < ArrayMin(i) Then
                min = ArrayMin(i)
            End If
        Next
        If Not PlaysLast Then
            For i = k To k + 7
                If Xartia(i).Enabled And Not Clicked(i) Then
                    If Xartia(i).Text = Offer.Suite And Xartia(i).Tag = min Then
                        Return i 'rixnei to mikrotero apo ta atou
                    End If
                End If
            Next
        End If
        j = 0
        If Not PlaysLast Then
            For i = k To k + 7
                If Xartia(i).Enabled And Not Clicked(i) Then
                    If Xartia(i).Tag = 11 And Xartia(i).Text <> SuiteCompare(index) Then
                        SuitNotToPlay(j) = Xartia(i).Text
                        j = j + 1
                    End If
                End If
            Next
        End If
        For i = 0 To 7
            ArrayMax(i) = 0
            ArrayMin(i) = 21
        Next
        j = 0
        For i = k To k + 7
            If Xartia(i).Enabled And Not Clicked(i) And Xartia(i).Text <> SuitNotToPlay(0) And Xartia(i).Text <> SuitNotToPlay(1) And Xartia(i).Text <> SuitNotToPlay(2) And Xartia(i).Text <> SuitNotToPlay(3) Then
                ArrayMax(j) = Xartia(i).Tag
                ArrayMin(j) = Xartia(i).Tag
                j = j + 1
            End If
        Next
        min = ArrayMin(0)
        max = ArrayMax(0)
        For i = 0 To 7
            If min < ArrayMin(i) Then
                min = ArrayMin(i)
            End If
            If max > ArrayMax(i) Then
                max = ArrayMax(i)
            End If
        Next

        If Not PlaysLast Then
            For i = k To k + 7
                If Xartia(i).Enabled And Not Clicked(i) Then
                    If Not TeamMateWins(Player) Then
                        If Xartia(i).Tag <> 10 And Xartia(i).Text <> SuitNotToPlay(0) And Xartia(i).Text <> SuitNotToPlay(1) And Xartia(i).Text <> SuitNotToPlay(2) And Xartia(i).Text <> SuitNotToPlay(3) Then
                            If Xartia(i).Tag = max And Not StandarLoses(i) Then
                                Return i
                            End If
                        End If
                    End If
                End If
            Next
        End If

        If Not PlaysLast Then
            For i = k To k + 7
                If Xartia(i).Enabled And Not Clicked(i) Then
                    If Not TeamMateWins(Player) Then
                        If Xartia(i).Tag <> 10 And Xartia(i).Text <> SuitNotToPlay(0) And Xartia(i).Text <> SuitNotToPlay(1) And Xartia(i).Text <> SuitNotToPlay(2) And Xartia(i).Text <> SuitNotToPlay(3) Then
                            If Xartia(i).Tag = min And StandarLoses(i) Then
                                Return i
                            End If
                        End If
                    End If
                End If
            Next
        End If

        For i = 0 To 7
            ArrayMax(i) = 0
            ArrayMin(i) = 21
        Next


        min = ArrayMax(0)
        For i = 1 To 7
            If min < ArrayMin(i) Then
                min = ArrayMin(i)
            End If
        Next
        ' If AtouCounter = 8 Then
        If Not PlaysLast Then
            If Not TeamMateWins(Player) Then
                For i = k To k + 7
                    If Not StandarLoses(i) Then
                        If Not OppTsak Then
                            If Xartia(i).Enabled And Not Clicked(i) Then
                                Select Case Xartia(i).Text
                                    Case "Hearts"
                                        If i = HCSPos Then

                                            Return i
                                        End If
                                    Case "Diamonds"
                                        If i = DCSPos Then

                                            Return i
                                        End If
                                    Case "Clubs"
                                        If i = CCSPos Then

                                            Return i
                                        End If
                                    Case "Spades"
                                        If i = SCSPos Then

                                            Return i
                                        End If
                                End Select
                            End If

                        ElseIf OppTsak Then
                            If Xartia(i).Enabled And Not Clicked(i) Then
                                If Xartia(i).Tag = min Then
                                    Return i
                                End If
                            End If
                        End If
                    End If

                Next
            ElseIf TeamMateWins(Player) Then
                For i = k To k + 7
                    If Xartia(i).Enabled And Not Clicked(i) Then
                        If HowManyTribe(Player, SuiteCompare(index)) = 8 Then  'an exei ola ta enapomeinan xartia tis filis, rixnei to dinatotero an to exei
                            If CS = i Then
                                Return i
                            End If
                        ElseIf HowManyTribe(Player, SuiteCompare(index)) < 8 Then 'an den exei ola ta enapomeinan xartia tote
                            If OppNoTribe(Player, SuiteCompare(index)) Then       'rixnei to mikrotero an o epomenos den exei tetoia fili
                                If Xartia(i).Tag = min Then                       'etsi oste na parei o simpaiktis mas
                                    Return i
                                End If
                            ElseIf Not OppNoTribe(Player, SuiteCompare(index)) Then  'an exei to megalitero to rixnei giati exei kai o epomenos antipalos tetoia fili
                                If CS = i Then
                                    Return i
                                ElseIf Xartia(i).Tag = min Then 'allios an den exoume to dinatotero, stin periptosi pou mporei na min kerdisei o simpaiktis
                                    Return i                    'mas telika, rixnoume to mikrotero
                                End If
                            End If
                        End If
                    End If
                Next

            End If
        End If
        'End If
        'prin to 10ari , na epilegei na skartarei, na rixnei dld kati pou den kerdizei 
        'THELEI DIORTHOMAAAAA


    End Function
    Function Bought_NotPlaysFirst(ByVal Player As String) As Integer

        Dim i, k, n, j, CS, HowManyAtou As Integer
        Dim jor9, jand9, TenNA, AllEnabled, OppTsak As Boolean
        Dim max, ArrayMax(7), ArrayMin(7), min As Double
        Dim SuitNotToPlay(3) As String
        Dim PlaysLast, Tsaka As Boolean

        Select Case SuiteCompare(index)
            Case "Hearts"
                CS = HCSPos
            Case "Diamonds"
                CS = DCSPos
            Case "Clubs"
                CS = CCSPos
            Case "Spades"
                CS = SCSPos
        End Select
        
        For i = k To k + 7
            If Xartia(i).Text = Offer.Suite And Not Clicked(i) And Xartia(i).Enabled Then
                HowManyAtou = HowManyAtou + 1
            End If
        Next
        For i = 0 To 2
            SuitNotToPlay(i) = ""
        Next

        Select Case Player
            Case "North"
                If OppTsaka("East", SuiteCompare(index)) Then
                    OppTsak = True
                End If
                AllEnabled = NAllEnabled
                If index = 1 Then
                    PlaysLast = True
                End If

                k = 0
                If jand9south Or jand9north Then
                    jand9 = True
                End If
                If Not jand9 Then
                    If jor9south Or jor9north Then
                        jor9 = True
                    End If
                End If

            Case "South"
                If OppTsaka("West", SuiteCompare(index)) Then
                    OppTsak = True
                End If
                AllEnabled = SAllEnabled
                If index = 3 Then
                    PlaysLast = True
                End If

                k = 16
                If jand9south Or jand9north Then
                    jand9 = True
                End If
                If Not jand9 Then
                    If jor9south Or jor9north Then
                        jor9 = True
                    End If
                End If

            Case "East"
                If OppTsaka("South", SuiteCompare(index)) Then
                    OppTsak = True
                End If
                AllEnabled = EAllEnabled
                If index = 2 Then
                    PlaysLast = True
                End If

                k = 8
                If jand9east Or jand9west Then
                    jand9 = True
                End If
                If Not jand9 Then
                    If jor9west Or jor9east Then
                        jor9 = True
                    End If
                End If
            Case "West"
                If OppTsaka("North", SuiteCompare(index)) Then
                    OppTsak = True
                End If
                AllEnabled = WAllEnabled
                If index = 0 Then
                    PlaysLast = True
                End If

                k = 24
                If jand9east Or jand9west Then
                    jand9 = True
                End If
                If Not jand9 Then
                    If jor9west Or jor9east Then
                        jor9 = True
                    End If
                End If
        End Select

        If Not AllEnabled Then
            For i = 0 To 7
                ArrayMax(i) = 0
                ArrayMin(i) = 21
            Next

            For i = k To k + 7
                If Xartia(i).Enabled And Not Clicked(i) Then
                    ArrayMax(j) = Xartia(i).Tag
                    ArrayMin(j) = Xartia(i).Tag
                    j = j + 1
                End If
            Next

            max = ArrayMax(0)
            min = ArrayMin(0)

            For j = 0 To 7
                If ArrayMax(j) > max Then
                    max = ArrayMax(j)
                End If
                If ArrayMin(j) < min Then
                    min = ArrayMin(j)
                End If
            Next
        End If
        '------------------------------------------------------------------------------------------------
        If SuiteCompare(index) <> Offer.Suite Then
            For i = k To k + 7
                If Xartia(i).Enabled And Not Clicked(i) And Xartia(i).Text = Offer.Suite Then
                    Tsaka = True
                End If
            Next

        End If  'Elegxei an tsaka kai epistrefei true
        '--------------------------------------------------------------------------------------------------------


        If Not PlaysLast Then
            If Not AllEnabled Then
                If Not TeamMateWins(Player) Then
                    For i = k To k + 7
                        If Xartia(i).Enabled And Not Clicked(i) And Xartia(i).Text <> Offer.Suite Then
                            If Not StandarLoses(i) And (Not OppTsak Or AtouCounter = 8 Or (HowManyAtou + AtouCounter = 8)) Then
                                If i = CS Then
                                    Return i
                                End If
                            End If
                        End If
                    Next
                    For i = k To k + 7
                        If Xartia(i).Enabled And Not Clicked(i) And Xartia(i).Text <> Offer.Suite Then
                            If StandarLoses(i) And Xartia(i).Tag = min Then
                                Return i
                            End If
                        End If
                    Next
                    '----thelei elegxo!!!!! to apo kato gia na min rixnei 9 an xanei
                    If Not Tsaka Then
                        For i = k To k + 7
                            If Xartia(i).Enabled And Not Clicked(i) And Xartia(i).Text = Offer.Suite Then
                                If StandarLoses(i) Then
                                    If Xartia(i).Tag = min Then
                                        Return i
                                    End If
                                End If
                            End If
                        Next
                    End If
                ElseIf TeamMateWins(Player) Then
                    If (AtouCounter = 8) Or (HowManyAtou + AtouCounter = 8) Then
                        Select Case SuiteCompare(index)
                            Case "Hearts"
                                If Clicked(HSP) Then
                                    For i = k To k + 7
                                        If i <> CS And Xartia(i).Tag = max And Xartia(i).Enabled And Not Clicked(i) Then
                                            Return i
                                        End If
                                    Next
                                    For i = k To k + 7
                                        If i <> CS Then
                                            Return i
                                        End If
                                    Next
                                End If
                            Case "Diamonds"
                                If Clicked(DSP) Then
                                    For i = k To k + 7
                                        If i <> CS And Xartia(i).Tag = max And Xartia(i).Enabled And Not Clicked(i) Then
                                            Return i
                                        End If
                                    Next
                                    For i = k To k + 7
                                        If i <> CS Then
                                            Return i
                                        End If
                                    Next
                                End If
                            Case "Clubs"
                                If Clicked(CSP) Then
                                    For i = k To k + 7
                                        If i <> CS And Xartia(i).Tag = max And Xartia(i).Enabled And Not Clicked(i) Then
                                            Return i
                                        End If
                                    Next
                                    For i = k To k + 7
                                        If i <> CS Then
                                            Return i
                                        End If
                                    Next
                                End If
                            Case "Spades"
                                If Clicked(SSP) Then
                                    For i = k To k + 7
                                        If i <> CS And Xartia(i).Tag = max And Xartia(i).Enabled And Not Clicked(i) Then
                                            Return i
                                        End If
                                    Next
                                    For i = k To k + 7
                                        If i <> CS Then
                                            Return i
                                        End If
                                    Next
                                End If
                        End Select
                    ElseIf (HowManyAtou + AtouCounter) <> 8 Then
                        For i = k To k + 7
                            If Xartia(i).Enabled And Not Clicked(i) Then
                                Select Case Xartia(i).Text
                                    Case "Hearts"
                                        If i <> HCSPos And Xartia(i).Tag <> 10 Then
                                            Return i
                                        End If
                                    Case "Diamonds"
                                        If i <> DCSPos And Xartia(i).Tag <> 10 Then
                                            Return i
                                        End If
                                    Case "Clubs"
                                        If i <> CCSPos And Xartia(i).Tag <> 10 Then
                                            Return i
                                        End If
                                    Case "Spades"
                                        If i <> SCSPos And Xartia(i).Tag <> 10 Then
                                            Return i
                                        End If
                                End Select
                            End If
                        Next
                    End If
                End If
            End If
        End If

        If PlaysLast Then
            If Not TeamMateWins(Player) Then
                For i = k To k + 7
                    If Xartia(i).Enabled And Not Clicked(i) Then
                        If StandarLoses(i) = False Then
                            Return i
                        End If
                    End If
                Next
                For i = k To k + 7
                    If Not AllEnabled Then
                        If Xartia(i).Enabled And Not Clicked(i) And StandarLoses(i) And Xartia(i).Tag = min Then
                            Return i
                        End If
                    End If
                Next
                For i = k To k + 7

                Next
            End If 'An paizei telefteos kai de kerdizei o simpaiktis tou, pairnei me o pio mikro 
        End If
        '----------------------------------------------------------------------------
        If Tsaka Then
            For i = k To k + 7
                If Xartia(i).Enabled And Not Clicked(i) Then
                    If Xartia(i).Tag = min Then
                        Return i
                    End If
                End If
            Next       'An tsaka, rixnei to mikrotero atou pou exei epeidi einai bought
        End If
        '------------------------------------------------------------------------
        Dim SomeoneTsak As Boolean

        If SuiteCompare(index) <> Offer.Suite Then
            For i = 0 To 3
                If SuiteCompare(i) = Offer.Suite Then

                    SomeoneTsak = True
                    Exit For
                End If
            Next
        End If

        If PlaysLast Then
            If Not AllEnabled Then
                If TeamMateWins(Player) And SomeoneTsak Then
                    For i = k To k + 7
                        If Xartia(i).Enabled And Not Clicked(i) Then
                            Return i
                        End If
                    Next
                End If

            End If
        End If   'Thelei telioma 



        '--------------------------------------------------------------------------


        For i = k To k + 7
            If Xartia(i).Enabled And Not Clicked(i) And Not StandarLoses(i) And Xartia(i).Tag <> 10 Then 'Rixnei to current_stronger an to exei analoga me ti fili pou paixtike
                Select Case Xartia(i).Text               'An einai atou kai exei to J to rixnei. An den einai atou rixnei current_stronger an exei alla an exei paixtei    
                    Case "Hearts"                        ' assos kai to epomeno current stronger einai to dekari, den theloume na to rixnei.
                        If HCSPos = i Then
                            Return i
                        End If
                    Case "Diamonds"
                        If DCSPos = i Then
                            Return i
                        End If
                    Case "Clubs"
                        If CCSPos = i Then
                            Return i
                        End If
                    Case "Spades"
                        If SCSPos = i Then
                            Return i
                        End If

                End Select
            End If
        Next

        For i = k To k + 7
            If Xartia(i).Enabled And Not Clicked(i) And Not TeamMateWins(Player) And Not StandarLoses(i) Then
                Return i
            End If
        Next

        'For i = k To k + 7
        'If Xartia(i).Enabled And Not Clicked(i) Then
        'Select Case Xartia(i).Text
        'Case "Hearts"
        'If Xartia(i).Tag = 10 And i = HCSPos Then
        'If Xartia(i - 1).Enabled And Not Clicked(i - 1) And (i - 1) <> -1 Then
        'Return i - 1    'protimaei na rixnei to "aristerotero" xarti tou deka giati einai ligoteron ponton apo to deksia
        'ElseIf Xartia(i + 1).Enabled And Not Clicked(i + 1) And (i + 1) <> 32 Then
        'Return i + 1
        'End If
        'End If
        ' Case "Diamonds"
        ' If Xartia(i).Tag = 10 And i = DCSPos Then
        'If Xartia(i - 1).Enabled And Not Clicked(i - 1) And (i - 1) <> -1 Then
        'Return i - 1    'protimaei na rixnei to "aristerotero" xarti tou deka giati einai ligoteron ponton apo to deksia
        ' ElseIf Xartia(i + 1).Enabled And Not Clicked(i + 1) And (i + 1) <> 32 Then
        'Return i + 1
        'End If
        'End If
        '    Case "Clubs"
        'If Xartia(i).Tag = 10 And i = CCSPos Then
        ' If Xartia(i - 1).Enabled And Not Clicked(i - 1) And (i - 1) <> -1 Then
        ' Return i - 1    'protimaei na rixnei to "aristerotero" xarti tou deka giati einai ligoteron ponton apo to deksia
        ' ElseIf Xartia(i + 1).Enabled And Not Clicked(i + 1) And (i + 1) <> 32 Then
        ' Return i + 1
        ' End If
        ' End If
        '    Case "Spades"
        'If Xartia(i).Tag = 10 And i = SCSPos Then
        ''If Xartia(i - 1).Enabled And Not Clicked(i - 1) And (i - 1) <> -1 Then
        ' Return i - 1    'protimaei na rixnei to "aristerotero" xarti tou deka giati einai ligoteron ponton apo to deksia
        ' ElseIf Xartia(i + 1).Enabled And Not Clicked(i + 1) And (i + 1) <> 32 Then
        'Return i + 1
        'End If
        ''End If
        'End Select
        'End If
        'Next

        For i = k To k + 7
            If SuiteCompare(index) = Offer.Suite And PointsCompareArray(index) <> 20 And jor9 Then
                If Xartia(i).Enabled And Not Clicked(i) Then
                    If Xartia(i).Tag = 14 Then
                        Return i
                    End If
                End If
            End If
        Next
        '-------------------------------------------------------------------------------------------
        max = 0
        min = 0
        For i = 0 To 7
            ArrayMax(i) = 0
            ArrayMin(i) = 21  'ksanaarxikopoiountai oi max,min
        Next

        '-----------------------------------------------------------------------------------------------
        If AllEnabled Then
            If TeamMateWins(Player) Then
                For i = 0 To 3
                    SuitNotToPlay(i) = ""
                Next
                max = 0
                min = 0
                n = 0
                For i = 0 To 7
                    ArrayMax(i) = 0
                    ArrayMin(i) = 21  'ksanaarxikopoiountai oi max,min
                Next
                For i = k To k + 7
                    If Xartia(i).Enabled And Not Clicked(i) And Xartia(i).Tag = 11 Then
                        SuitNotToPlay(n) = Xartia(i).Text
                        n = n + 1
                    End If
                Next
                n = 0
                For i = k To k + 7
                    If Xartia(i).Enabled And Not Clicked(i) And Xartia(i).Tag = 10 Then
                        Select Case Xartia(i).Text
                            Case "Hearts"
                                If Not TenHeartsNA And i <> HCSPos Then
                                    Return i
                                End If
                            Case "Diamonds"
                                If Not TenDiamondsNA And i <> DCSPos Then
                                    Return i
                                End If
                            Case "Clubs"
                                If Not TenClubsNA And i <> CCSPos Then
                                    Return i
                                End If
                            Case "Spades"
                                If Not TenSpadesNA And i <> SCSPos Then
                                    Return i
                                End If
                        End Select
                    End If
                Next
                For i = k To k + 7
                    If Xartia(i).Enabled And Not Clicked(i) And Xartia(i).Tag <> 10 And Xartia(i).Text <> SuitNotToPlay(0) And Xartia(i).Text <> SuitNotToPlay(1) And Xartia(i).Text <> SuitNotToPlay(2) And Xartia(i).Text <> SuitNotToPlay(3) Then
                        Select Case Xartia(i).Text
                            Case "Hearts"
                                If i <> HCSPos Then
                                    ArrayMax(n) = Xartia(i).Tag
                                    n = n + 1
                                End If
                            Case "Diamonds"
                                If i <> DCSPos Then
                                    ArrayMax(n) = Xartia(i).Tag
                                    n = n + 1
                                End If
                            Case "Clubs"
                                If i <> CCSPos Then
                                    ArrayMax(n) = Xartia(i).Tag
                                    n = n + 1
                                End If
                            Case "Spades"
                                If i <> SCSPos Then
                                    ArrayMax(n) = Xartia(i).Tag
                                    n = n + 1
                                End If
                        End Select
                    End If
                Next
                For i = 0 To 7
                    If max < ArrayMax(i) Then
                        max = ArrayMax(i)
                    End If
                Next
                For i = k To k + 7
                    If Xartia(i).Enabled And Not Clicked(i) And Xartia(i).Tag = max Then
                        Return i
                    End If   '----aporriptei tis files pou exoun asso aki rixnei to megalitero an den einai curent stronger
                Next
                For i = k To k + 7
                    If Xartia(i).Enabled And Not Clicked(i) Then
                        Select Case Xartia(i).Text
                            Case "Hearts"
                                If i = HCSPos Then
                                    If (HowManyTribe(Player, "Hearts") + HeartsCounter) = 7 Or HeartsCounter = 7 Then
                                        Return i
                                    End If
                                End If
                            Case "Diamonds"
                                If i = DCSPos Then
                                    If (HowManyTribe(Player, "Diamonds") + DiamondsCounter) = 7 Or DiamondsCounter = 7 Then
                                        Return i
                                    End If
                                End If
                            Case "Clubs"
                                If i = CCSPos Then
                                    If (HowManyTribe(Player, "Clubs") + ClubsCounter) = 7 Or ClubsCounter = 7 Then
                                        Return i
                                    End If
                                End If
                            Case "Spades"
                                If i = SCSPos Then
                                    If (HowManyTribe(Player, "Spades") + SpadesCounter) = 7 Or SpadesCounter = 7 Then
                                        Return i
                                    End If
                                End If
                        End Select
                    End If
                Next
                For i = k To k + 7
                    If Xartia(i).Enabled And Not Clicked(i) And Xartia(i).Tag <> 10 Then
                        Return i
                    End If
                Next
            End If
        End If


        For i = k To k + 7
            If Xartia(i).Enabled And Not Clicked(i) Then   'AN kerdizei o simpaiktis tote rixnei to megalitero ektos to 10ari
                If TeamMateWins(Player) And Xartia(i).Tag <> 10 And Xartia(i).Text <> Offer.Suite Then
                    ArrayMax(n) = Xartia(i).Tag
                    n = n + 1
                End If
            End If
        Next


        max = ArrayMax(0)
        For i = 0 To 7
            If ArrayMax(i) > max Then
                max = ArrayMax(i)
            End If
        Next
        For i = k To k + 7
            If Xartia(i).Enabled And Not Clicked(i) Then
                If Xartia(i).Tag = max Then
                    Return i
                End If
            End If
        Next

        n = 0
        min = ArrayMin(0)

        If Not TeamMateWins(Player) Then 'an den kaerdizei o simpaiktis mas
            If AllEnabled Then
                For i = k To k + 7
                    If Xartia(i).Enabled And Not Clicked(i) And Xartia(i).Tag = 11 And Xartia(i).Text <> Offer.Suite Then
                        SuitNotToPlay(j) = Xartia(i).Text   'an exoume asso den paizoume apo afton
                        j = j + 1
                    End If
                    If Xartia(i).Enabled And Not Clicked(i) And Xartia(i).Tag = 10 And Xartia(i).Text <> Offer.Suite Then
                        Select Case Xartia(i).Text
                            Case "Hearts"
                                If HCSPos = i Then
                                    SuitNotToPlay(j) = "Hearts"
                                    j = j + 1
                                ElseIf CardsWithTenH < 1 Then
                                    SuitNotToPlay(j) = "Hearts"
                                End If
                            Case "Diamonds"
                                If DCSPos = i Then
                                    SuitNotToPlay(j) = "Diamonds"
                                    j = j + 1
                                ElseIf CardsWithTenD < 1 Then
                                    SuitNotToPlay(j) = "Diamonds"
                                End If
                            Case "Hearts"
                                If CCSPos = i Then
                                    SuitNotToPlay(j) = "Clubs"
                                    j = j + 1
                                ElseIf CardsWithTenC < 1 Then
                                    SuitNotToPlay(j) = "Clubs"
                                End If
                            Case "Hearts"
                                If SCSPos = i Then
                                    SuitNotToPlay(j) = "Spades"
                                    j = j + 1
                                ElseIf CardsWithTenS < 1 Then
                                    SuitNotToPlay(j) = "Spades"
                                End If
                        End Select
                    End If
                Next


                For i = k To k + 7
                    If Xartia(i).Enabled And Not Clicked(i) And Xartia(i).Text <> SuitNotToPlay(0) And Xartia(i).Text <> SuitNotToPlay(1) And Xartia(i).Text <> SuitNotToPlay(2) Then
                        ArrayMin(n) = Xartia(i).Tag
                        n = n + 1
                    End If

                Next


                For i = 0 To 7
                    If ArrayMin(i) < min Then
                        min = ArrayMin(i)
                    End If
                Next

                For i = k To k + 7
                    If Xartia(i).Enabled And Not Clicked(i) Then
                        If Xartia(i).Tag = min Then
                            Return i
                        End If
                    End If
                Next
            End If
            '-------------------------------------------------------------------------------------------
            max = 0
            min = 0
            For i = 0 To 3
                ArrayMax(i) = 0
                ArrayMin(i) = 21  'ksanaarxikopoiountai oi max,min
            Next
            j = 0
            For i = k To k + 7
                If Xartia(i).Enabled And Not Clicked(i) Then
                    ArrayMax(j) = Xartia(i).Tag
                    ArrayMin(j) = Xartia(i).Tag
                    j = j + 1
                End If
            Next
            '-----------------------------------------------------------------------------------------------
            If AllEnabled Then
                For i = k To k + 7
                    If Xartia(i).Enabled And Not Clicked(i) And Xartia(i).Tag = min Then
                        Return i
                    End If
                Next
            End If
        End If


    End Function

    Function HowManyEnabled(ByVal k As Integer) As Integer

        Dim i, HowManyEn As Integer

        For i = k To k + 7
            If Xartia(i).Enabled = True And Not Clicked(i) Then
                HowManyEn = HowManyEn + 1
            End If
        Next

        Return HowManyEn
    End Function
    Dim HSP, DSP, CSP, SSP As Integer
    Function StrongerPlayed(ByVal Tribe As String) As Integer
        Dim a, b, c, d As Integer

        a = HCSPos
        b = DCSPos
        c = CCSPos
        d = SCSPos

        Select Case Tribe
            Case "Hearts"
                Return a
            Case "Diamonds"
                Return b
            Case "Clubs"
                Return c
            Case "Spades"
                Return d
        End Select
    End Function

    Function OppTsaka(ByVal Player As String, ByVal Tribe As String) As Boolean

        Select Case Player
            Case "North"
                If Tribe = "Hearts" Then
                    If NTsakaHearts Then
                        Return True
                    End If
                End If
                If Tribe = "Diamonds" Then
                    If NTsakaDiamonds Then
                        Return True
                    End If
                End If
                If Tribe = "Clubs" Then
                    If NTsakaClubs Then
                        Return True
                    End If
                End If
                If Tribe = "Spades" Then
                    If NTsakaSpades Then
                        Return True
                    End If
                End If
            Case "East"
                If Tribe = "Hearts" Then
                    If ETsakaHearts Then
                        Return True
                    End If
                End If
                If Tribe = "Diamonds" Then
                    If ETsakaDiamonds Then
                        Return True
                    End If
                End If
                If Tribe = "Clubs" Then
                    If ETsakaClubs Then
                        Return True
                    End If
                End If
                If Tribe = "Spades" Then
                    If ETsakaSpades Then
                        Return True
                    End If
                End If
            Case "South"
                If Tribe = "Hearts" Then
                    If STsakaHearts Then
                        Return True
                    End If
                End If
                If Tribe = "Diamonds" Then
                    If STsakaDiamonds Then
                        Return True
                    End If
                End If
                If Tribe = "Clubs" Then
                    If STsakaClubs Then
                        Return True
                    End If
                End If
                If Tribe = "Spades" Then
                    If STsakaSpades Then
                        Return True
                    End If
                End If
            Case "West"
                If Tribe = "Hearts" Then
                    If WTsakaHearts Then
                        Return True
                    End If
                End If
                If Tribe = "Diamonds" Then
                    If WTsakaDiamonds Then
                        Return True
                    End If
                End If
                If Tribe = "Clubs" Then
                    If WTsakaClubs Then
                        Return True
                    End If
                End If
                If Tribe = "Spades" Then
                    If WTsakaSpades Then
                        Return True
                    End If
                End If
        End Select

    End Function
    Function OppNoTribe(ByVal Player As String, ByVal Tribe As String) As Boolean
        Select Case Player
            Case "North"
                Select Case Tribe
                    Case "Hearts"
                        If ENoH Then
                            Return True
                        End If
                    Case "Diamonds"
                        If ENoD Then
                            Return True
                        End If
                    Case "Clubs"
                        If ENoC Then
                            Return True
                        End If
                    Case "Spades"
                        If ENoS Then
                            Return True
                        End If
                End Select
            Case "South"
        Select Case Tribe

                    Case "Hearts"
                        If WNoH Then
                            Return True
                        End If
                    Case "Diamonds"
                        If WNoD Then
                            Return True
                        End If
                    Case "Clubs"
                        If WNoC Then
                            Return True
                        End If
                    Case "Spades"
                        If WNoS Then
                            Return True
                        End If
                End Select
            Case "East"
        Select Case Tribe

                    Case "Hearts"
                        If SNoH Then
                            Return True
                        End If
                    Case "Diamonds"
                        If SNoD Then
                            Return True
                        End If
                    Case "Clubs"
                        If SNoC Then
                            Return True
                        End If
                    Case "Spades"
                        If SNoS Then
                            Return True
                        End If
                End Select
            Case "West"
        Select Case Tribe

                    Case "Hearts"
                        If NNoH Then
                            Return True
                        End If
                    Case "Diamonds"
                        If NNoD Then
                            Return True
                        End If
                    Case "Clubs"
                        If NNoC Then
                            Return True
                        End If
                    Case "Spades"
                        If NNoS Then
                            Return True
                        End If
                End Select
        End Select

    End Function

    Function HowManyTribe(ByVal Player As String, ByVal Tribe As String) As Integer
        Dim i, a As Integer

        Select Case Player
            Case "North"
                Select Case Tribe
                    Case "Hearts"
                        Return (northHeartscounter + HeartsCounter)
                    Case "Diamonds"
                        Return (northDiamondscounter + DiamondsCounter)
                    Case "Clubs"
                        Return (northClubscounter + ClubsCounter)
                    Case "Spades"
                        Return (northSpadescounter + SpadesCounter)
                End Select
            Case "East"
                Select Case Tribe
                    Case "Hearts"
                        Return (eastHeartscounter + HeartsCounter)
                    Case "Diamonds"
                        Return (eastDiamondscounter + DiamondsCounter)
                    Case "Clubs"
                        Return (eastClubscounter + ClubsCounter)
                    Case "Spades"
                        Return (eastSpadescounter + SpadesCounter)
                End Select
            Case "South"
                Select Case Tribe
                    Case "Hearts"
                        Return (southHeartscounter + HeartsCounter)
                    Case "Diamonds"
                        Return (southDiamondscounter + DiamondsCounter)
                    Case "Clubs"
                        Return (southClubscounter + ClubsCounter)
                    Case "Spades"
                        Return (southSpadescounter + SpadesCounter)
                End Select

            Case "West"
                Select Case Tribe
                    Case "Hearts"
                        Return (westHeartscounter + HeartsCounter)
                    Case "Diamonds"
                        Return (westDiamondscounter + DiamondsCounter)
                    Case "Clubs"
                        Return (westClubscounter + ClubsCounter)
                    Case "Spades"
                        Return (westSpadescounter + SpadesCounter)
                End Select
        End Select

    End Function
    Function Jand9Played() As Boolean
        Select Case Offer.Suite
            Case "Hearts"
                If JHearts And NineHearts Then
                    Return True
                End If
            Case "Diamonds"
                If JDiamonds And NineDiamonds Then
                    Return True
                End If
            Case "Clubs"
                If JClubs And NineClubs Then
                    Return True
                End If
            Case "Spades"
                If JSpades And NineSpades Then
                    Return True
                End If

        End Select

    End Function
    
    Function AtouCSPos() As Integer
        Select Case Offer.Suite
            Case "Hearts"
                Return HCSPos
            Case "Diamonds"
                Return DCSPos
            Case "Clubs"
                Return CCSPos
            Case "Spades"
                Return SCSPos
        End Select
    End Function

    Private Sub MenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem3.Click
        DeckForm.Show()
    End Sub

    Private Sub MenuItem8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem8.Click
        Players.Show()
    End Sub

    Private Sub MenuItem9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem9.Click
        CurrentScore.Show()
        CurrentScore.Visible = True
    End Sub
End Class

