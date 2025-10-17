Imports System

Module Program

    Class Veelhoek
        Protected aantalZijden As Integer
        Private Random As New Random()

        Public Sub New()
            Me.aantalZijden = Random.Next(3, 11)

        End Sub

        Public Function getAantalZijden() As Integer
            Return Me.aantalZijden
        End Function

    End Class

    Class Vierkant
        Inherits Veelhoek
        Public Sub New()
            MyBase.New()
            Me.aantalZijden = 4
        End Sub
    End Class
    Sub Main(args As String())

        Dim objVeelhoek As New Veelhoek()
        Dim objVierkant As New Vierkant()

        Console.WriteLine(objVeelhoek.getAantalZijden())
        Console.WriteLine(objVierkant.getAantalZijden())
    End Sub
End Module
