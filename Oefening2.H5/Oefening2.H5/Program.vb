Imports System

Module Program

    Class Voetballer
        Public strNaam As String
        Public intLeeftijd As Integer
        Public intGeleKaarten As Integer

        Sub New(naam As String, leeftijd As Integer)
            Me.strNaam = naam
            Me.intLeeftijd = leeftijd
            Me.intGeleKaarten = 0
        End Sub

        Public Sub NaarKleedKamer()
            Console.Write("Moet ik naar de kleedkamer:")
            If Me.intGeleKaarten > 1 Then
                Console.WriteLine("KLEEDKAMER")
            Else
                Console.WriteLine("SPELEN")
            End If
        End Sub

        Public Sub GeefKaart()
            If Me.intGeleKaarten = 0 Then
                Me.intGeleKaarten += 1
                Console.WriteLine("Ik geef een kaart")
            ElseIf Me.intGeleKaarten = 1 Then
                Me.intGeleKaarten += 1
                Console.WriteLine("Ik geef nog een kaart")
            Else
                Console.WriteLine("Ik geef nog een kaart")
                Me.intGeleKaarten = 1
            End If
        End Sub


    End Class
    Sub Main(args As String())
        Dim objMessi As New Voetballer("Messi", 36)
        objMessi.NaarKleedKamer()
        objMessi.GeefKaart()
        objMessi.GeefKaart()
        objMessi.NaarKleedKamer()
    End Sub
End Module
