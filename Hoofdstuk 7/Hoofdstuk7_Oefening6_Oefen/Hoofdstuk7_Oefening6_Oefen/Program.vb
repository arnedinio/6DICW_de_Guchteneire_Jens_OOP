Imports System

Module Program

    Class Salamander
        Protected intAantalPoten As Integer
        Protected intStaartLengteInCm As Double
        Protected dblLongCapaciteitInLiter As Double

        Public Sub New()
            Me.intAantalPoten = 4
            Me.intStaartLengteInCm = 6
            Me.dblLongCapaciteitInLiter = 0.5
        End Sub

        Public Function GeefAantalPoten()
            Return Me.intAantalPoten
        End Function

        Public Function GeefLongCapaciteit()
            Return Me.dblLongCapaciteitInLiter
        End Function

    End Class

    Class Tijger
        Inherits Salamander
        Protected strHaarkleur As String

        Public Sub New()
            MyBase.New()
            Me.strHaarkleur = "Zwart"
            Me.intStaartLengteInCm = 40
            Me.dblLongCapaciteitInLiter = 5
        End Sub

        Public Function GeefHaarKleur()
            Return Me.strHaarkleur
        End Function

    End Class

    Class Mens
        Inherits Tijger
        Private intAantalBenen As Integer
        Private intAantalArmen As Integer

        Public Sub New(strHaarkleur As String)
            MyBase.New()
            Me.intStaartLengteInCm = 0
            Me.intAantalPoten = 0
            Me.strHaarkleur = strHaarkleur
        End Sub

        Public Function GeefAantalArmenEnBenen()
            Return (Me.intAantalBenen, Me.intAantalArmen, Me.intAantalArmen + Me.intAantalBenen)
        End Function

    End Class

    Sub Main(args As String())
        Dim objMegalamania As New Salamander
        Console.WriteLine("De salamander heeft " & objMegalamania.GeefAantalPoten() & " poten")
        Console.WriteLine("De salamander heeft " & objMegalamania.GeefLongCapaciteit() & " liter longcapaciteit")
        Console.WriteLine()

        Dim objSabertooth As New Tijger
        Console.WriteLine("De tijger heeft " & objSabertooth.GeefAantalPoten() & " poten")
        Console.WriteLine("De tijger heeft " & objSabertooth.GeefLongCapaciteit() & " liter longcapaciteit")
        Console.WriteLine("De haarkleur van de tijger is " & objSabertooth.GeefHaarKleur())
        Console.WriteLine()

        Dim objBob As New Mens("Blond")
        Console.WriteLine("De persoon heeft " & objBob.GeefLongCapaciteit() & " liter longcapaciteit")
        Console.WriteLine("De haarkleur van de persoon is " & objBob.GeefHaarKleur())
        Console.WriteLine("De persoon heeft " & objBob.GeefAantalArmenEnBenen()[0) & " benen, " & objBob.GeefAantalArmenEnBenen()(1) & " armen, en dus " & objBob.GeefAantalArmenEnBenen()(2) & " aantal armen en benen")
        Console.WriteLine()
    End Sub
End Module
