Imports System

Module Program

    Class Dier
        Public naam As String
        Public leeftijd As Integer
        Public aanwezigheid As Boolean
        Public gewicht As Double

        Public Sub New(naam, leeftijd, aanwezigheid, gewicht)
            Me.naam = naam
            Me.leeftijd = leeftijd
            Me.aanwezigheid = aanwezigheid
            Me.gewicht = gewicht
        End Sub

        Public Sub ZetAanwezig(aanwezigheid)
            Me.aanwezigheid = aanwezigheid
        End Sub

        Public Function GeefAanwezig() As Boolean
            Return Me.aanwezigheid
        End Function

        Public Function GeefNaam() As String
            Return Me.naam
        End Function

    End Class

    Sub Main(args As String())
        Dim objDier As New Dier("Joske de Leeuw", 12, False, 280.2)
        objDier.ZetAanwezig(True)
        If objDier.GeefAanwezig() Then
            Console.WriteLine("Dier met naam: " & objDier.GeefNaam() & " is aanwezig")
        Else
            Console.WriteLine("Dier met naam: " & objDier.GeefNaam() & " is afwezig")
        End If
    End Sub
End Module
