Imports System
Imports System.Resources
Imports System.Drawing
Imports System.IO
Imports System.ComponentModel

Public Class Form1
    Dim resx_cur As ResXResourceSet
    Dim resx_usa As ResXResourceSet = New ResXResourceSet("en-US.resx")
    Dim resx_mexico As ResXResourceSet = New ResXResourceSet("es-MX.resx")
    Dim resx_france As ResXResourceSet = New ResXResourceSet("es-MX.resx")
    Dim resx_china As ResXResourceSet = New ResXResourceSet("zh-CN.resx")
    Dim resx_saudi As ResXResourceSet = New ResXResourceSet("ar-SA.resx")


    Private Sub refreshLocalizableContent()
        OurMenuTitl.Text = resx_cur.GetString("OurMenuTitl")
        DuckDuckFryTitl.Text = resx_cur.GetString("DuckDuckFryTitl")
        DuckFatFriesTitl.Text = resx_cur.GetString("DuckFatFriesTitl")
        DuckFatFriesDesc.Text = resx_cur.GetString("DuckFatFriesDesc")
        DoubleDuckFriesTitl.Text = resx_cur.GetString("DoubleDuckFriesTitl")
        DoubleDuckFriesDesc.Text = resx_cur.GetString("DoubleDuckFriesDesc")
        FlockOfDuckFriesTitl.Text = resx_cur.GetString("FlockOfDuckFriesTitl")
        FlockOfFuckFriesDesc.Text = resx_cur.GetString("FlockOfFuckFriesDesc")

        StartersTitl.Text = resx_cur.GetString("StartersTitl")
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
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        resx_cur = resx_usa
        refreshLocalizableContent()
    End Sub

    Private Sub spanishLink_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles spanishLink.LinkClicked
        resx_cur = resx_mexico
        refreshLocalizableContent()
    End Sub

    Private Sub englishLink_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles englishLink.LinkClicked
        resx_cur = resx_usa
        refreshLocalizableContent()
    End Sub

    Private Sub frenchLink_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles frenchLink.LinkClicked
        resx_cur = resx_france
        refreshLocalizableContent()
    End Sub

    Private Sub saudiLink_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles saudiLink.LinkClicked
        resx_cur = resx_saudi
        refreshLocalizableContent()
    End Sub

    Private Sub chineseLink_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles chineseLink.LinkClicked
        resx_cur = resx_china
        refreshLocalizableContent()
    End Sub
End Class
