Imports System

Module Program

    Class Voetballer
        Protected random As New Random()
        Protected strNaam As String
        Protected intBetrouwbaarheid As Integer

        Public Sub New(naam As String, intBetrouwbaarheid As Integer)
            Me.strNaam = naam
            Me.intBetrouwbaarheid = intBetrouwbaarheid
        End Sub

    End Class

    Class Keeper
        Inherits Voetballer

        Public Sub New(naam As String, intBetrouwbaarheid As Integer)
            MyBase.New(naam, intBetrouwbaarheid)
            Me.intBetrouwbaarheid = random.Next(intBetrouwbaarheid - 30, intBetrouwbaarheid + 10)
            Console.WriteLine($"De betrouwbaarheid van {Me.strNaam} is {Me.intBetrouwbaarheid}.")
        End Sub

        Public Sub RedBal()
            If random.Next(1, 101) <= intBetrouwbaarheid Then
                Console.WriteLine($"{Me.strNaam} heeft de bal gered!")
            Else
                Console.WriteLine($"{Me.strNaam} heeft de bal niet gered.")
            End If
        End Sub

    End Class

    Class Trapper
        Inherits Voetballer

        Public Sub New(naam As String, intBetrouwbaarheid As Integer)
            MyBase.New(naam, intBetrouwbaarheid)
            Me.intBetrouwbaarheid = random.Next(intBetrouwbaarheid - 10, intBetrouwbaarheid + 20)
            Console.WriteLine($"De betrouwbaarheid van {Me.strNaam} is {Me.intBetrouwbaarheid}.")
        End Sub

        Public Sub TrapBal()
            If random.Next(1, 101) <= intBetrouwbaarheid Then
                Console.WriteLine($"{Me.strNaam} heeft gescoord!")
            Else
                Console.WriteLine($"{Me.strNaam} heeft de bal slecht getrapt.")
            End If
        End Sub

    End Class

    Sub Main(args As String())
        Console.WriteLine("Hello World!")
        Dim objCourtois As New Keeper("Courtois", 90)
        Dim objBenzema As New Trapper("Benzema", 85)
        objBenzema.TrapBal()
        objCourtois.RedBal()
    End Sub
End Module
