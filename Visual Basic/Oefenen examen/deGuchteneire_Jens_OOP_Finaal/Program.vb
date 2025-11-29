Imports System
Imports System.ComponentModel.Design
Imports System.Transactions

Module Program

    Class Bestelling
        'Velden
        Protected strKlantNaam As String
        Protected dblTotaalBedrag As Double
        'Constructor met parameters klantnaam en totaal bedrag
        Public Sub New(strKlantNaam As String, dblTotaalBedrag As Double)
            Me.strKlantNaam = strKlantNaam
            Me.dblTotaalBedrag = dblTotaalBedrag
        End Sub
        'Accessors (klantnaam en totaal bedrag)
        Public Function GetKlantNaam()
            Return Me.strKlantNaam
        End Function
        Public Function GetTotaalBedrag()
            Return Me.dblTotaalBedrag
        End Function

        'Mutators (klantnaam en totaal bedrag)
        Public Sub SetKlantNaam(strKlantNaam As String)
            Me.strKlantNaam = strKlantNaam
        End Sub
        Public Sub SetTotaalBedrag(dblTotaalBedrag As Double)
            Me.dblTotaalBedrag = dblTotaalBedrag
        End Sub

        'Methodes
        Public Overridable Sub ToonBestelDetails() 'Schrijft klantnaam en totaal bedrag in de console
            Console.WriteLine("Klant met naam: " & strKlantNaam)
            Console.WriteLine("Totaal bedrag van de bestelling: " & dblTotaalBedrag)
        End Sub
        Public Overridable Function BerekenVerzendkosten() 'Berekent verzendkosten. Standaard 5 euro
            Return 5
        End Function
    End Class

    Class SnelleLevering
        Inherits Bestelling

        'Velden
        Private dblSpoedToeslag As Double

        'Constructor
        Public Sub New(strKlantNaam As String, dblTotaalBedrag As Double)
            MyBase.New(strKlantNaam, dblTotaalBedrag)
            Me.dblSpoedToeslag = 10
        End Sub

        'Accessors (Spoedtoeslag)
        Public Function GetSpoedToeslag()
            Return Me.dblSpoedToeslag
        End Function

        'Mutators (Spoedtoeslag)
        Public Sub SetSpoedToeslag(dblSpoedToeslag As Double)
            Me.dblSpoedToeslag = dblSpoedToeslag
        End Sub

        'Methodes
        Public Overrides Function BerekenVerzendkosten() 'Berekent verzendkosten, = 5 euro + spoed toeslag
            Return MyBase.BerekenVerzendkosten() + Me.dblSpoedToeslag
        End Function
        Public Overrides Sub ToonBestelDetails()
            MyBase.ToonBestelDetails()
            Console.WriteLine("Totale verzendkosten zijn: " & BerekenVerzendkosten())
        End Sub
    End Class

    Class InternationaleLevering
        Inherits Bestelling

        'Velden
        Private strLand As String

        'Constructor
        Public Sub New(strKlantNaam As String, dblTotaalBedrag As Double, strLand As String)
            MyBase.New(strKlantNaam, dblTotaalBedrag)
            Me.strLand = strLand
        End Sub

        'Accessors
        Public Function GetLand()
            Return Me.strLand
        End Function

        'Mutators
        Public Sub SetLand(strLand)
            Me.strLand = strLand
        End Sub

        'Methodes
        Public Function BerekenDouaneKosten() 'berekent douanekosten, = 10% van totaalbedrag
            Return Me.dblTotaalBedrag * 0.1
        End Function
        Public Overrides Function BerekenVerzendkosten() 'Berekent verzendkosten (Douanekosten + verzendkosten)
            Return MyBase.BerekenVerzendkosten() + BerekenDouaneKosten()
        End Function
        Public Overrides Sub ToonBestelDetails()
            MyBase.ToonBestelDetails()
            Console.WriteLine("douanekosten zijn: " & BerekenDouaneKosten())
            Console.WriteLine("Totalverzendkosten zijn: " & BerekenVerzendkosten())
        End Sub
    End Class

    Class Verzending
        'Velden
        Protected strVerzendType As String

        'Constructor (parameter verzendtype)
        Public Sub New(strVerzendType As String)
            Me.strVerzendType = strVerzendType
        End Sub

        'Accessors (verzendtype)
        Public Function GetVerzendType()
            Return Me.strVerzendType
        End Function

        'Mutators (verzendtype)
        Public Sub SetVerzendType(strVerzendType As String)
            Me.strVerzendType = strVerzendType
        End Sub

        'Methodes
        Public Overridable Function BerekenVerzendkosten() 'Standaard verzendkosten = 3 euro
            Return 3
        End Function
    End Class

    Class PakketVerzending
        Inherits Verzending

        'Velden
        Private strPakketGrootte As String

        'Constructor (parameter verzendtype, pakket grootte)
        Public Sub New(strVerzendType As String, strPakketGrootte As String)
            MyBase.New(strVerzendType)
            Me.strPakketGrootte = strPakketGrootte
        End Sub

        'Accessors (pakket grootte)
        Public Function GetPakketGrootte()
            Return Me.strPakketGrootte
        End Function

        'Mutatoes (pakket grootte)
        Public Sub SetPakketGrootte(strPakketGrootte As String)
            Me.strPakketGrootte = strPakketGrootte
        End Sub

        'Methodes
        Public Overrides Function BerekenVerzendKosten() 'Geeft verzendkosten mee bij verschillende grootte van pakketjes
            'klein = 3, middelgroot = 5, groot = 8
            Dim dblVerzendkosten As Double
            dblVerzendkosten = MyBase.BerekenVerzendkosten()
            If (strVerzendType = "middelgroot") Then
                dblVerzendkosten += 2
            ElseIf (strVerzendType = "groot") Then
                dblVerzendkosten += 5
            End If
            Return dblVerzendkosten
        End Function
    End Class

    Class Luchtpost
        Inherits Verzending
        'Velden
        Private dblLuchttarief As Double

        'Constructor (parameter verzendtype)
        Public Sub New(strVerzendType As String)
            MyBase.New(strVerzendType)
            Me.dblLuchttarief = 15
        End Sub

        'Accessors (luchttarief)
        Public Function GetLuchttarief()
            Return Me.dblLuchttarief
        End Function

        'Mutators (luchttarief)
        Public Sub SetLuchttarief(dblLuchttarief As Double)
            Me.dblLuchttarief = dblLuchttarief
        End Sub

        'Methodes
        Public Overrides Function BerekenVerzendkosten() 'Geeft verzendkosten, = 3 euro + luchttarief
            Return MyBase.BerekenVerzendkosten() + Me.dblLuchttarief
        End Function
    End Class
    Sub Main(args As String())
        Dim objShampoo As New SnelleLevering("Jansen", 100)
        objShampoo.ToonBestelDetails()
        Console.WriteLine("---")

        Dim objGPU As New InternationaleLevering("Martinez", 200, "Frankrijk")
        objGPU.ToonBestelDetails()
        Console.WriteLine("---")

        Dim objPS5 As New PakketVerzending("Pakket", "middelgroot")
        Console.WriteLine("Verzendkosten voor pakket met grootte: " & objPS5.GetPakketGrootte() & " is: " & objPS5.BerekenVerzendKosten())
        Console.WriteLine("---")

        Dim objHangmat As New Luchtpost("Luchtpost")
        Console.WriteLine("Verzendkosten voor luchtpakket zijn: " & objHangmat.BerekenVerzendkosten())
        Console.WriteLine("---")
    End Sub
End Module
