Imports System
Imports System.IO

Module Program

    Class Radio
        Private huidigLiedje As String
        Private intVolume As Integer
        Private Random As New Random()
        Private Liedjes As String() = {"Destiny", "Not Like Us", "Hotline Bling"}

        Public Sub SpeelLiedje()
            Console.WriteLine("De radio speelt: " & SpeelLiedjeRadio())
        End Sub

        Private Function SpeelLiedjeRadio()
            Return Liedjes(Random.Next(0, 3))
        End Function

    End Class

    Sub Main(args As String())
        Dim objTopradio As New Radio
        objTopradio.SpeelLiedje()
    End Sub
End Module
