Imports System

Module Program

    Class Dier
        'Velden
        Private strNaam As String
        Private intLeeftijd As Integer
        Private blnAanwezig As Boolean
        Private dblGewicht As Double
        'Constructor
        Public Sub New(strNaam As String, intLeeftijd As Integer, blnAanwezig As Boolean, dblGewicht As Double)
            Me.strNaam = strNaam
            Me.intLeeftijd = intLeeftijd
            Me.blnAanwezig = blnAanwezig
            Me.dblGewicht = dblGewicht
        End Sub
        'Mutator die blnAanwezig zet op een gegeven parameter
        Public Sub ZetAanwezig(blnAanwezig As Boolean)
            Me.blnAanwezig = blnAanwezig
        End Sub
        'Accessor die blnAanwezig meegeeft
        Public Function GeefAanwezig()
            Return Me.blnAanwezig
        End Function
        'Accessor die strNaam meegeeft
        Public Function GeefNaam()
            Return Me.strNaam
        End Function

    End Class

    Sub Main(args As String())
        Dim objDier As New Dier("Joske de Leeuw", 12, False, 280.2)
        objDier.ZetAanwezig(True)
        If objDier.GeefAanwezig() Then
            Console.WriteLine("Dier met naam: " & objDier.GeefNaam() & " is aanwezig")
        Else
            Console.WriteLine("Dier met naam: " & objDier.GeefNaam() & " is aanwezig")
        End If
    End Sub
End Module
