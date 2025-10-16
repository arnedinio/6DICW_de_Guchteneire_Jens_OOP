Imports System
Imports System.Reflection.Metadata.Ecma335

Module Program

    Class Koppel
        Private intLengteVrouw As Double
        Private intLengteMan As Double

        Public Function BerekenLengteKind(charGenderKind As Char) As Double
            If charGenderKind = "M" Then
                Return ((intLengteMan + intLengteVrouw) / 2) + 6.5
            Else
                Return ((intLengteMan + intLengteVrouw) / 2) - 6.5
            End If
        End Function

        Public Sub New(intLengteVrouw As Double, intLengteMan As Double)
            Me.intLengteVrouw = intLengteVrouw
            Me.intLengteMan = intLengteMan
        End Sub

    End Class
    Sub Main(args As String())
        Dim objKoppel As New Koppel(155.3, 172.8)
        Console.WriteLine(objKoppel.BerekenLengteKind("M"))
    End Sub
End Module
