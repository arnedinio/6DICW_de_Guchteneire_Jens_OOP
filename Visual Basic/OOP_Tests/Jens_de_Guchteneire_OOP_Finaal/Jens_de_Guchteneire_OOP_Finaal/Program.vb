Imports System
Imports System.Runtime.CompilerServices

Module Program

    Class Bestelling
        Protected strKlantNaam As String
        Protected dblTotaalBedrag As Double

        Public Sub New(strKlantNaam As String, dblTotaalBedrag As Double)
            Me.strKlantNaam = strKlantNaam
            Me.dblTotaalBedrag = dblTotaalBedrag
        End Sub

        Public Overridable Sub ToonBestelDetails()
            Console.WriteLine("Klant met naam: " & Me.strKlantNaam)
            Console.WriteLine("Totaal bedrag van bestelling: " & Me.dblTotaalBedrag)
        End Sub

        Public Overridable Function BerekenVerzendkosten()
            Return 5.0
        End Function

    End Class

    Class SnelleLevering
        Inherits Bestelling
        Private dblSpoedToeslag As Double

        Public Sub New(strKlantNaam As String, dblTotaalBedrag As Double)
            MyBase.New(strKlantNaam, dblTotaalBedrag)
            Me.dblSpoedToeslag = 10.0
        End Sub

        Public Overrides Function BerekenVerzendkosten()
            Return MyBase.BerekenVerzendkosten() + Me.dblSpoedToeslag
        End Function

        Public Overrides Sub ToonBestelDetails()
            MyBase.ToonBestelDetails()
            Console.WriteLine("Totale verzendkosten zijn: " & Me.BerekenVerzendkosten())
        End Sub

    End Class

    Class InternationaleBestelling
        Inherits Bestelling
        Private strLand As String

        Public Sub New(strKlantNaam As String, dblTotaalBedrag As Double, strLand As String)
            MyBase.New(strKlantNaam, dblTotaalBedrag)
            Me.strLand = strLand
        End Sub

        Public Function BerekenDouaneKosten()
            Return (Me.dblTotaalBedrag * 0.1)
        End Function

        Public Overrides Function BerekenVerzendKosten()
            Return MyBase.BerekenVerzendkosten() + Me.BerekenDouaneKosten()
        End Function

        Public Overrides Sub ToonBestelDetails()
            MyBase.ToonBestelDetails()
            Console.WriteLine("douanekosten zijn: " & Me.BerekenDouaneKosten())
            Console.WriteLine("Totale verzendkosten zijn: " & Me.BerekenVerzendKosten())
        End Sub

    End Class


    Class Verzending
        Protected strVerzendType As String

        Public Sub New(strVerzendType As String)
            Me.strVerzendType = strVerzendType
        End Sub

        Public Overridable Function BerekenVerzendKosten()
            Return 3
        End Function

    End Class

    Class PakketVerzending
        Inherits Verzending
        Private strPakketGrootte As String

        Public Sub New(strVerzendtype As String, strPakketGrootte As String)
            MyBase.New(strVerzendtype)
            Me.strPakketGrootte = strPakketGrootte
        End Sub

        Public Overrides Function BerekenVerzendKosten()
            If Me.strPakketGrootte = "klein" Then
                Return 3
            ElseIf Me.strPakketGrootte = "middelgroot" Then
                Return 5
            ElseIf Me.strPakketGrootte = "groot" Then
                Return 8
            Else
                Console.WriteLine("Foute grote van pakket! Kies tussen: klein, middelgroot, groot")
                Return 0
            End If
        End Function

        Public Sub ToonVerzendingsDetails()
            Console.WriteLine("Verzendkosten voor pakket met grootte: " & Me.strPakketGrootte & " is: " & Me.BerekenVerzendKosten() & " euro")
        End Sub

    End Class

    Class Luchtpost
        Inherits Verzending
        Private dblLuchttarief As Double

        Public Sub New(strVerzendType As String)
            MyBase.New(strVerzendType)
            Me.dblLuchttarief = 15.0
        End Sub

        Public Overrides Function BerekenVerzendKosten()
            Return MyBase.BerekenVerzendKosten() + Me.dblLuchttarief
        End Function

        Public Sub ToonVerzendingsDetails()
            Console.WriteLine("Verzendkosten voor luchtpakket zijn: " & Me.BerekenVerzendKosten() & " euro")
        End Sub

    End Class

    Sub Main(args As String())
        Dim objIKEAKast As New SnelleLevering("jansen", 100)
        objIKEAKast.ToonBestelDetails()
        Console.WriteLine("---")

        Dim objBed As New InternationaleBestelling("Martinez", 200, "Frankrijk")
        objBed.ToonBestelDetails()
        Console.WriteLine("---")

        Dim objBol As New PakketVerzending("Pakket", "middelgroot")
        objBol.ToonVerzendingsDetails()
        Console.WriteLine("---")

        Dim objFedEx As New Luchtpost("Luchtpost")
        objFedEx.ToonVerzendingsDetails()
        Console.WriteLine("---")

    End Sub
End Module
