Imports System
Imports System.Security.Cryptography.X509Certificates

Module Program

    Class Atleet
        Public geboorteplaats As String
        Public lengte As Integer
        Public gewicht As Double

        Public Sub New()
            Me.geboorteplaats = "Brussel"
            Me.lengte = 184
            Me.gewicht = 68.3
        End Sub
    End Class
    Sub Main(args As String())
        Dim objAtleet As New Atleet
        Console.WriteLine("---")
        Console.WriteLine("Thiam is geboren in: " & objAtleet.geboorteplaats)
        Console.WriteLine("Thiam haar lengte(in cm) is: " & objAtleet.lengte)
        Console.WriteLine("Thiam haar gewicht (in kg) is: " & objAtleet.gewicht)
        Console.WriteLine("---")
    End Sub
End Module
