Imports System
Imports System.Runtime.CompilerServices

Module Program

    Class Deck
        'Velden
        Private intCurrentSuit As Integer
        Private intCurrentValue As Integer

        'Constructor
        Public Sub New()
            'Waarde op -1 want output moet beginnen met 2 van harten, maar toont automatisch de kaart NA 2 van harten
            Me.intCurrentValue = -1
            Me.intCurrentSuit = 0
        End Sub

        'Methodes
        Public Function ShowNextCard()
            'Toont de volgende kaart d.m.v. de waardes berekent door IncrementCard()
            Dim suits As String() = {"Harten", "Ruiten", "Schoppen", "Klaveren"}
            Dim values As String() = {"2", "3", "4", "5", "6", "7", "8", "9", "10", "Boer", "Dame", "Heer", "Aas"}
            IncrementCard()
            If intCurrentValue > 12 And intCurrentSuit = 3 Then
                Console.WriteLine("Geen kaarten meer in het deck!")
            Else
                Console.WriteLine(values(intCurrentValue) & " van " & suits(intCurrentSuit))
            End If
        End Function

        Private Sub IncrementCard()
            'Berekent welke waardes de volgende kaart heeft
            If intCurrentValue = 12 And intCurrentSuit = 3 Then
                intCurrentValue += 1
            ElseIf intCurrentValue = 12 Then
                intCurrentValue = 0
                intCurrentSuit += 1
            Else
                intCurrentValue += 1
            End If
        End Sub


    End Class
    Sub Main(args As String())
        Dim myDeck As New Deck()

        Console.WriteLine("De getrokken kaarten zijn:")
        For i As Integer = 1 To 60
            myDeck.ShowNextCard()
        Next

    End Sub
End Module
