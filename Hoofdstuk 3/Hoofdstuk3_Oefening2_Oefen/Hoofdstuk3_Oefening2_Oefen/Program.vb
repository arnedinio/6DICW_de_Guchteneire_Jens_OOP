Imports System

Module Program

    Class Film
        Private strTitel As String
        Private intJaar As Integer
        Private strRegisseur As String
        Private intDuur As Integer
        Private dblRating As Double

        Public Sub New(strTitel As String, intJaar As Integer, strRegisseur As String, intDuur As Integer, dblRating As Double)
            Me.strTitel = strTitel
            Me.intJaar = intJaar
            Me.strRegisseur = strRegisseur
            Me.intDuur = intDuur
            Me.dblRating = dblRating
        End Sub

        Public Sub PrintInfo()
            Console.WriteLine("Titel: " & strTitel)
            Console.WriteLine("Jaar: " & intJaar)
            Console.WriteLine("Regisseur: " & strRegisseur)
            Console.WriteLine("Duur: " & intDuur & " minuten")
            Console.WriteLine("Rating: " & dblRating & "/10")
        End Sub

    End Class

    Sub Main(args As String())
        Dim objPulpFiction As New Film("Pulp Fiction", 1994, "Quentin Tarantino", 154, 8.9)
        objPulpFiction.PrintInfo()
    End Sub
End Module
