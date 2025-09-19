Imports System

Module Program

    Class Cirkel
        Public strKleur As String
        Public intStraal As Integer

        Public Sub New()
            Me.strKleur = "geel"
            Me.intStraal = 2
        End Sub

    End Class
    Sub Main(args As String())
        Dim objGeleCirkel As New Cirkel()
        Console.WriteLine("De cirkel heeft als kleur: " & objGeleCirkel.strKleur)
        Console.WriteLine("De cirkel heeft als straal: " & objGeleCirkel.intStraal)
    End Sub
End Module
