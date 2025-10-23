Imports System

Module Program

    Class Voetballer
        Protected intNummer As Integer
        Protected strPositie As String
        Protected strNaam As String
        Protected dblMassa As Double

        Public Sub New(intNummer As Integer, strPositie As String, strNaam As String, dblMassa As Double)
            Me.intNummer = intNummer
            Me.strPositie = strPositie
            Me.strNaam = strNaam
            Me.dblMassa = dblMassa
        End Sub

        Public Sub New(intNummer As Integer, strPositie As String, strNaam As String)
            Me.intNummer = intNummer
            Me.strPositie = strPositie
            Me.strNaam = strNaam
            Me.dblMassa = 90.0
        End Sub

        Public Overridable Sub Speel()
            Console.WriteLine("Ik speel voetbal!")
        End Sub

    End Class

    Class Aanvaller
        Inherits Voetballer

        Public Sub New(strNaam As String, dblMassa As Double)
            MyBase.New(10, "CF", strNaam, dblMassa)
        End Sub

        Public Overrides Sub Speel()
            Console.WriteLine("Ik speel aanvaller!")
        End Sub

    End Class

    Sub Main(args As String())
        Console.WriteLine("Hello World!")
        Dim objMbappe As New Aanvaller("Mbappe", 75.0)
        objMbappe.Speel()
    End Sub
End Module
