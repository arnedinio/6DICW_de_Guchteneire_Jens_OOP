Imports System

Module Program

    Class Voetballer
        Private strFullName As String
        Private strNickname As String
        Private strBirthdate As String
        Private strNationality As String
        Private intLength As Integer
        Private chrPreferredFoot As Char
        Private strPosition As String

        Public Sub New(strFullname As String, strNickname As String, strBirthdate As String, strNationality As String, intLength As Integer, chrPreferredFoot As Char, strPosition As String)
            Me.strFullName = strFullname
            Me.strNickname = strNickname
            Me.strBirthdate = strBirthdate
            Me.strNationality = strNationality
            Me.intLength = intLength
            Me.chrPreferredFoot = chrPreferredFoot
            Me.strPosition = strPosition
        End Sub

        Public Sub PrintInfo()
            Console.WriteLine("Full Name: " & strFullName)
            Console.WriteLine("Nickname: " & strNickname)
            Console.WriteLine("Birthdate: " & strBirthdate)
            Console.WriteLine("Nationality: " & strNationality)
            Console.WriteLine("Length: " & intLength)
            Console.WriteLine("Preferred Foot: " & chrPreferredFoot)
            Console.WriteLine("Position: " & strPosition)
        End Sub

        Public Sub WhoAmI()
            Console.WriteLine(strFullName & ", also commonly known as " & strNickname & ", is a " & strPosition & ". He is " & intLength & "cm tall and " & strNationality & "." & " He was born " & strBirthdate & " and plays with his " & chrPreferredFoot & " foot.")
        End Sub

    End Class

    Sub Main(args As String())
        Dim objCR7 As New Voetballer("Cristiano Ronaldo dos Santos Aveiro", "CR7", "5 February 1985", "Portuguese", 187, "right", "forward")
        objCR7.PrintInfo()
        objCR7.WhoAmI()
    End Sub
End Module
