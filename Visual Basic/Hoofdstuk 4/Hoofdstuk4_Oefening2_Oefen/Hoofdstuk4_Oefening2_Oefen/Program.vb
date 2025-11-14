Imports System

Module Program

    Class Wielrenner
        Private intLeeftijd As Integer
        Private strGeboorteplaats As String
        Private intGewicht As Integer
        Private blnOver25 As Boolean
        Private strLengte As String
        Private intPuntenTimeTrail As Integer

        Public Sub New(intLeeftijd As Integer, strGeboorteplaats As String, intGewicht As Integer, strLengte As String, intPuntenTimeTrail As Integer)
            Me.intLeeftijd = intLeeftijd
            Me.strGeboorteplaats = strGeboorteplaats
            Me.intGewicht = intGewicht
            Me.blnOver25 = (intLeeftijd > 25)
            Me.strLengte = strLengte
            Me.intPuntenTimeTrail = intPuntenTimeTrail
        End Sub

        Public Sub PrintInfo()
            Console.WriteLine("Leeftijd: " & intLeeftijd)
            Console.WriteLine("Geboorteplaats: " & strGeboorteplaats)
            Console.WriteLine("Gewicht: " & intGewicht)
            Console.WriteLine("Over 25: " & blnOver25)
            Console.WriteLine("Lengte: " & strLengte)
            Console.WriteLine("Punten Time Trial: " & intPuntenTimeTrail)
            Console.WriteLine()
        End Sub

    End Class

    Sub Main(args As String())
        Dim objWoutVanAert As New Wielrenner(28, "Belgium", 78, "1.90m", 95)
        objWoutVanAert.PrintInfo()
        Dim objTadejPogacar As New Wielrenner(27, "Slovenia", 66, "1.76m", 98)
        objTadejPogacar.PrintInfo()
    End Sub
End Module
