Imports System
Imports System.Security.Cryptography.X509Certificates

Module Program

    Class Dier
        Protected strKleur As String

        Public Sub New(kleur As String)
            Me.strKleur = kleur
        End Sub

        Public Sub Eet()
            Console.WriteLine("Mmmmm lekker.")
        End Sub

        Public Sub Slaap()
            Console.WriteLine("Hooooonk mimimimimi")
        End Sub

    End Class

    Class Hond
        Inherits Dier
        Private strBaasje As String

        Public Sub New(kleur As String, baasje As String)
            MyBase.New(kleur)
            Me.strBaasje = baasje
        End Sub

        Public Sub PrintInformatie()
            Console.WriteLine("Kleur: " & strKleur)
            Console.WriteLine("Baasje: " & strBaasje)
        End Sub

        Public Sub Blaf()
            Console.WriteLine("Woef Woef")
        End Sub

        Public Sub ZetEigenaar(strBaasje As String)
            Me.strBaasje = strBaasje
        End Sub

        Public Function GeefEigenaar() As String
            Return strBaasje
        End Function

    End Class

    Class Leeuw
        Inherits Dier
        Private strJungleNaam As String

        Public Sub New(kleur As String, strJungleNaam As String)
            MyBase.New(kleur)
            Me.strJungleNaam = strJungleNaam
        End Sub

        Public Sub brult()
            Console.WriteLine("ROAARRR")
        End Sub

        Public Function GeefJungle() As String
            Return strJungleNaam
        End Function

        Public Sub zetJungle(strJungleNaam As String)
            Me.strJungleNaam = strJungleNaam
        End Sub

        Public Sub PrintInformatie()
            Console.WriteLine("Kleur: " & strKleur)
            Console.WriteLine("Jungle: " & strJungleNaam)
        End Sub

    End Class
    Sub Main(args As String())

        Dim objWaffer As New Hond("Blank", "Robbe")
        objWaffer.PrintInformatie()

        Dim objSimba As New Leeuw("Goud", "Afrika")
        objSimba.PrintInformatie()

    End Sub
End Module
