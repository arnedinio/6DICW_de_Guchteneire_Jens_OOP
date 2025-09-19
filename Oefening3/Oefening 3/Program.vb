Imports System

Module Program

    Class Film
        Public strtitel As String
        Public intjaar As Integer
        Public intlengte As Integer
        Public booleanisActieFilm As Boolean
    End Class


    Sub Main(args As String())
        Dim objFilm As New Film()
        objFilm.strtitel = "Inception"
        objFilm.intjaar = 2010
        objFilm.intlengte = 148
        objFilm.booleanisActieFilm = True
        Console.WriteLine("Hello World!")
    End Sub
End Module
