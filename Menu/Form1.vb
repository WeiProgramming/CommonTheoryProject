Imports System
Imports System.Resources
Imports System.Drawing
Imports System.IO
Imports System.ComponentModel
Imports System.Drawing.Text

Public Class Form1
    Const WS_EX_LAYOUTRTL = &H400000
    Const WS_EX_NOINHERITLAYOUT = &H100000
    Dim resx_cur As ResXResourceSet
    Dim resx_usa As ResXResourceSet = New ResXResourceSet("en-US.resx")
    Dim resx_mexico As ResXResourceSet = New ResXResourceSet("es-MX.resx")
    Dim resx_france As ResXResourceSet = New ResXResourceSet("es-MX.resx")
    Dim resx_china As ResXResourceSet = New ResXResourceSet("zh-CN.resx")
    Dim resx_saudi As ResXResourceSet = New ResXResourceSet("ar-SA.resx")
    Dim pfc As PrivateFontCollection = New PrivateFontCollection



    Private Sub refreshLocalizableContent()
        OurMenuTitl.Text = resx_cur.GetString("OurMenuTitl")
        OurMenuTitl.Font = New Font(pfc.Families(0), 24, FontStyle.Regular)
        DuckDuckFryTitl.Text = resx_cur.GetString("DuckDuckFryTitl")
        DuckFatFriesTitl.Text = resx_cur.GetString("DuckFatFriesTitl")
        DuckFatFriesDesc.Text = resx_cur.GetString("DuckFatFriesDesc")
        DoubleDuckFriesTitl.Text = resx_cur.GetString("DoubleDuckFriesTitl")
        DoubleDuckFriesDesc.Text = resx_cur.GetString("DoubleDuckFriesDesc")
        FlockOfDuckFriesTitl.Text = resx_cur.GetString("FlockOfDuckFriesTitl")
        FlockOfFuckFriesDesc.Text = resx_cur.GetString("FlockOfFuckFriesDesc")

        StartersTitl.Text = resx_cur.GetString("StartersTitl")
        StartersTitl.Font = New Font(pfc.Families(0), 20, FontStyle.Regular)
        BeetAndWatermelonPokeTitl.Text = resx_cur.GetString("BeetAndWatermelonPokeTitl")
        BeetAndWatermelonPokeDesc.Text = resx_cur.GetString("BeetAndWatermelonPokeDesc")
        BuffaloCauliflowerTitl.Text = resx_cur.GetString("BuffaloCauliflowerTitl")
        BuffaloCauliflowerDesc.Text = resx_cur.GetString("BuffaloCauliflowerDesc")
        CapreseTitl.Text = resx_cur.GetString("CapreseTitl")
        CapreseDesc.Text = resx_cur.GetString("CapreseDesc")
        CrispyChickenWingsTitl.Text = resx_cur.GetString("CrispyChickenWingsTitl")
        CrispyChickenWingsDesc.Text = resx_cur.GetString("CrispyChickenWingsDesc")
        OGFriedBrusselsTitl.Text = resx_cur.GetString("OGFriedBrusselsTitl")
        OGFriedBrusselsDesc.Text = resx_cur.GetString("OGFriedBrusselsDesc")
        BaconAndBlueBrusselsTitl.Text = resx_cur.GetString("BaconAndBlueBrusselsTitl")
        BaconAndBlueBrusselsDesc.Text = resx_cur.GetString("BaconAndBlueBrusselsDesc")
        SweetAndSpicyPorkBellyTitl.Text = resx_cur.GetString("SweetAndSpicyPorkBellyTitl")
        SweetAndSpicyPorkBellyDesc.Text = resx_cur.GetString("SweetAndSpicyPorkBellyDesc")
        SaltAndPepperCrispyCalamariTitl.Text = resx_cur.GetString("SaltAndPepperCrispyCalamariTitl")
        SaltAndPepperCrispyCalamariDesc.Text = resx_cur.GetString("SaltAndPepperCrispyCalamariDesc")
        BlueCrabAndCheddarPretzelsTitl.Text = resx_cur.GetString("BlueCrabAndCheddarPretzelsTitl")
        BlueCrabAndCheddarPretzelsDesc.Text = resx_cur.GetString("BlueCrabAndCheddarPretzelsDesc")
        CheeseBallsTitl.Text = resx_cur.GetString("CheeseBallsTitl")
        CheeseBallsDesc.Text = resx_cur.GetString("CheeseBallsDesc")
        PretzelBallsTitl.Text = resx_cur.GetString("PretzelBallsTitl")
        PretzelBallsDesc.Text = resx_cur.GetString("PretzelBallsDesc")

        FlatbreadsTitl.Text = resx_cur.GetString("FlatbreadsTitl")
        FlatbreadsTitl.Font = New Font(pfc.Families(0), 20, FontStyle.Regular)
        EasternShoreTitl.Text = resx_cur.GetString("EasternShoreTitl")
        EasternShoreDesc.Text = resx_cur.GetString("EasternShoreDesc")
        SausageAndPeppersTitl.Text = resx_cur.GetString("SausageAndPeppersTitl")
        SausageAndPeppersDesc.Text = resx_cur.GetString("SausageAndPeppersDesc")
        GardenTitl.Text = resx_cur.GetString("GardenTitl")
        GardenDesc.Text = resx_cur.GetString("GardenDesc")
        HellFireTitl.Text = resx_cur.GetString("HellFireTitl")
        HellFireDesc.Text = resx_cur.GetString("HellFireDesc")
        TomatoAndPestoTitl.Text = resx_cur.GetString("TomatoAndPestoTitl")
        TomatoAndPestoDesc.Text = resx_cur.GetString("TomatoAndPestoDesc")

        SeasonalSweetsTitl.Text = resx_cur.GetString("SeasonalSweetsTitl")
        SeasonalSweetsTitl.Font = New Font(pfc.Families(0), 20, FontStyle.Regular)
        SeasonalSweetsDesc.Text = resx_cur.GetString("SeasonalSweetsDesc")
        ChocolatelyGoodnessTitl.Text = resx_cur.GetString("ChocolatelyGoodnessTitl")
        FruityAndSweetTitl.Text = resx_cur.GetString("FruityAndSweetTitl")
        FeelingExtraSweetTitl.Text = resx_cur.GetString("FeelingExtraSweetTitl")
        FeelingExtraSweetDesc.Text = resx_cur.GetString("FeelingExtraSweetDesc")

        GreensTitl.Text = resx_cur.GetString("GreensTitl")
        GreensTitl.Font = New Font(pfc.Families(0), 20, FontStyle.Regular)
        GreensDesc.Text = resx_cur.GetString("GreensDesc")
        SweetCornAndShrimpTitl.Text = resx_cur.GetString("SweetCornAndShrimpTitl")
        SweetCornAndShrimpDesc.Text = resx_cur.GetString("SweetCornAndShrimpDesc")
        ClassicCaesarTitl.Text = resx_cur.GetString("ClassicCaesarTitl")
        ClassicCaesarDesc.Text = resx_cur.GetString("ClassicCaesarDesc")
        RoastedBeetTitl.Text = resx_cur.GetString("RoastedBeetTitl")
        RoastedBeetDesc.Text = resx_cur.GetString("RoastedBeetDesc")
        MixedBerryAndAlmondTitl.Text = resx_cur.GetString("MixedBerryAndAlmondTitl")
        MixedBerryAndAlmondDesc.Text = resx_cur.GetString("MixedBerryAndAlmondDesc")

        ShareableSidesTitl.Text = resx_cur.GetString("ShareableSidesTitl")
        ShareableSidesTitl.Font = New Font(pfc.Families(0), 20, FontStyle.Regular)
        ShareableSidesDesc.Text = resx_cur.GetString("ShareableSidesDesc")
        CharredCornSuccotashTitl.Text = resx_cur.GetString("CharredCornSuccotashTitl")
        CharredCornSuccotashDesc.Text = resx_cur.GetString("CharredCornSuccotashDesc")
        TabascoSlawTitl.Text = resx_cur.GetString("TabascoSlawTitl")
        TabascoSlawDesc.Text = resx_cur.GetString("TabascoSlawDesc")
        BucketofFriesTitl.Text = resx_cur.GetString("BucketofFriesTitl")

        BurgersAndSandwichesTitl.Text = resx_cur.GetString("BurgersAndSandwichesTitl")
        BurgersAndSandwichesTitl.Font = New Font(pfc.Families(0), 20, FontStyle.Regular)
        BurgersAndSandwichesDesc.Text = resx_cur.GetString("BurgersAndSandwichesDesc")
        CTBurgerTitl.Text = resx_cur.GetString("CTBurgerTitl")
        CTBurgerDesc.Text = resx_cur.GetString("CTBurgerDesc")
        BaconAndBlueTitl.Text = resx_cur.GetString("BaconAndBlueTitl")
        BaconAndBlueDesc.Text = resx_cur.GetString("BaconAndBlueDesc")
        SpicyGrilledChickenTitl.Text = resx_cur.GetString("SpicyGrilledChickenTitl")
        SpicyGrilledChickenDesc.Text = resx_cur.GetString("SpicyGrilledChickenDesc")
        SteakSandwichTitl.Text = resx_cur.GetString("SteakSandwichTitl")
        SteakSandwichDesc.Text = resx_cur.GetString("SteakSandwichDesc")
        BlackBeanAndTomatoTitl.Text = resx_cur.GetString("BlackBeanAndTomatoTitl")
        BlackBeanAndTomatoDesc.Text = resx_cur.GetString("BlackBeanAndTomatoDesc")
        DuckBLTTitl.Text = resx_cur.GetString("DuckBLTTitl")
        DuckBLTDesc.Text = resx_cur.GetString("DuckBLTDesc")
        ConvoyBurgerTitl.Text = resx_cur.GetString("ConvoyBurgerTitl")
        ConvoyBurgerDesc.Text = resx_cur.GetString("ConvoyBurgerDesc")

        MainCourseTitl.Text = resx_cur.GetString("MainCourseTitl")
        MainCourseTitl.Font = New Font(pfc.Families(0), 20, FontStyle.Regular)
        MarketSteakFritesTitl.Text = resx_cur.GetString("MarketSteakFritesTitl")
        MarketSteakFritesDesc.Text = resx_cur.GetString("MarketSteakFritesDesc")
        WhiteWineMusselsTitl.Text = resx_cur.GetString("WhiteWineMusselsTitl")
        WhiteWineMusselsDesc.Text = resx_cur.GetString("WhiteWineMusselsDesc")
        BeerBatteredFishAndChipsTitl.Text = resx_cur.GetString("BeerBatteredFishAndChipsTitl")
        BeerBatteredFishAndChipsDesc.Text = resx_cur.GetString("BeerBatteredFishAndChipsDesc")
        CrabCakeAndFriedChickenTitl.Text = resx_cur.GetString("CrabCakeAndFriedChickenTitl")
        CrabCakeAndFriedChickenDesc.Text = resx_cur.GetString("CrabCakeAndFriedChickenDesc")
        PorkDuckAndPolentaTitl.Text = resx_cur.GetString("PorkDuckAndPolentaTitl")
        PorkDuckAndPolentaDesc.Text = resx_cur.GetString("PorkDuckAndPolentaDesc")
        SearedSalmonTitl.Text = resx_cur.GetString("SearedSalmonTitl")
        SearedSalmonDesc.Text = resx_cur.GetString("SearedSalmonDesc")

    End Sub
    Private _mirrored As Boolean = False
    <Description("Change to the right-to-left layout."),
    DefaultValue(False), Localizable(True),
    Category("Appearance"), Browsable(True)>
    Public Property Mirrored() As Boolean
        Get
            Return _mirrored
        End Get
        Set(ByVal Value As Boolean)
            If _mirrored <> Value Then
                _mirrored = Value
                MyBase.OnRightToLeftChanged(EventArgs.Empty)
            End If
        End Set
    End Property

    Protected Overrides ReadOnly Property CreateParams() As System.Windows.Forms.CreateParams
        Get
            Dim CP As System.Windows.Forms.CreateParams = MyBase.CreateParams
            If Mirrored Then
                CP.ExStyle = CP.ExStyle Or WS_EX_LAYOUTRTL Or WS_EX_NOINHERITLAYOUT
            End If
            Return CP
        End Get
    End Property

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pfc.AddFontFile("chinfont.ttf")
        resx_cur = resx_usa
        refreshLocalizableContent()
    End Sub

    Private Sub spanishLink_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles spanishLink.LinkClicked
        Me.Mirrored() = False
        resx_cur = resx_mexico
        refreshLocalizableContent()
    End Sub

    Private Sub englishLink_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles englishLink.LinkClicked
        Me.Mirrored() = False
        resx_cur = resx_usa
        refreshLocalizableContent()
    End Sub

    Private Sub frenchLink_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles frenchLink.LinkClicked
        Me.Mirrored() = False
        resx_cur = resx_france
        refreshLocalizableContent()
    End Sub

    Private Sub saudiLink_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles saudiLink.LinkClicked
        Me.Mirrored() = True
        resx_cur = resx_saudi
        refreshLocalizableContent()
    End Sub

    Private Sub chineseLink_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles chineseLink.LinkClicked
        Me.Mirrored() = False
        resx_cur = resx_china
        refreshLocalizableContent()
    End Sub
End Class
