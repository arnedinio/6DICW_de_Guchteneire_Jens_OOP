Imports System

Module Program

    Class Speler
        Protected strNaam As String
        Protected Random As New Random()
        Public Overridable Sub TrapBal()
            Console.WriteLine("Wat ben ik?!")
        End Sub

        Public Sub New(naam As String)
            strNaam = naam
        End Sub

    End Class

    Class Verdediger
        Inherits Speler

        Public Sub New(naam As String)
            MyBase.New(naam)
        End Sub

        Public Overrides Sub TrapBal()
            If Random.Next(1, 11) <= 5 Then
                Console.WriteLine($"{strNaam} geeft de bal succesvol door!")
            Else
                Console.WriteLine($"{strNaam} verliest de bal aan de tegenstander!")
            End If
        End Sub
    End Class

    Class Aanvaller
        Inherits Speler
        Public Sub New(naam As String)
            MyBase.New(naam)
        End Sub

        Public Overrides Sub TrapBal()
            If Random.Next(1, 11) <= 3 Then
                Console.WriteLine($"{strNaam} scoort een doelpunt!")
            Else
                Console.WriteLine($"{strNaam} mist de kans!")
            End If
        End Sub
    End Class

    Sub Main(args As String())
        Console.WriteLine("Hello World!")
        Dim objVincent As New Verdediger("Vincent")
        Dim objLukaku As New Aanvaller("Lukaku")
        objVincent.TrapBal()
        objLukaku.TrapBal()
    End Sub
End Module
