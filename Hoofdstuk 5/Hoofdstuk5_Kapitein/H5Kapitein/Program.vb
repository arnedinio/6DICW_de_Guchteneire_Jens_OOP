Imports System

Module Program

    Class Voetballer

        Public strNaam As String
        Public blnIsKapitein As Boolean

        Public Sub New(strNaam As String)
            Me.strNaam = strNaam
            Me.blnIsKapitein = False
        End Sub

        Public Sub zetKapitein(blnIsKapitein As Boolean)
            Me.blnIsKapitein = blnIsKapitein
        End Sub

        Public Sub geefKapitein()
            If blnIsKapitein Then
                Console.WriteLine("Ik ben kapitein")
            Else
                Console.WriteLine("Ik ben geen kapitein")
            End If
        End Sub
    End Class

    Sub Main(args As String())
        Dim objMessi As New Voetballer("Messi")
        objMessi.geefKapitein()
        objMessi.zetKapitein(True)
        objMessi.geefKapitein()
    End Sub
End Module
