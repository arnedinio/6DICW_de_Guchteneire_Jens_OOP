Imports System

Module Program

    Class Atleet
        Private strGeboorteplaats As String
        Private intLengte As Integer
        Private dblGewicht As String


        'Constructor
        Public Sub New()
            Me.strGeboorteplaats = "Brussel"
            Me.intLengte = 184
            Me.dblGewicht = 69.3
        End Sub

        'Getters/Accessors
        Public Function GetGeboorteplaats()
            Return Me.strGeboorteplaats
        End Function
        Public Function GetLengte()
            Return Me.intLengte
        End Function
        Public Function GetGewicht()
            Return Me.dblGewicht
        End Function

    End Class

    Sub Main(args As String())
        Dim objTiam As New Atleet()

        Console.WriteLine("---")
        Console.WriteLine("Tiam is geboren in            : " & objTiam.GetGeboorteplaats())
        Console.WriteLine("Tiam haar lengte (in cm) is   : " & objTiam.GetLengte())
        Console.WriteLine("Tiam haar gewicht (in kg) is  : " & objTiam.GetGewicht())
        Console.WriteLine("---")

    End Sub
End Module
