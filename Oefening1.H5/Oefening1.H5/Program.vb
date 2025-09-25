Imports System
Module Program

    Class Auto
        Public dblBandenSpanning As Double

        Public Sub New()
            Me.dblBandenSpanning = 5.0
        End Sub

        Public Sub pompBandenOp()
            Me.dblBandenSpanning = 5.0
        End Sub

        Sub gaOpVakantie()
            Me.dblBandenSpanning -= 1.0
        End Sub

        Public Sub GeefStaatWagenWeer()
            If Me.dblBandenSpanning < 3.0 Then
                Console.WriteLine("De banden staan plat")
            Else
                Console.WriteLine("De banden zijn perfect")
            End If
        End Sub

    End Class
    Sub Main(args As String())
        Dim objAuto As New auto()
        objAuto.gaOpVakantie()
        objAuto.GeefStaatWagenWeer()
        objAuto.gaOpVakantie()
        objAuto.GeefStaatWagenWeer()
        objAuto.gaOpVakantie()
        objAuto.GeefStaatWagenWeer()
        objAuto.pompBandenOp()
        objAuto.GeefStaatWagenWeer()
    End Sub
End Module
