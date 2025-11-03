Imports System

Module Program

    Class Restaurant
        Private strNaam As String
        Private strAdres As String
        Private strTelefoonnummer As String
        Private strSoortKeuken As String

        Public Sub New(strNaam As String, strAdres As String, strTelefoonnummer As String, strSoortKeuken As String)
            Me.strNaam = strNaam
            Me.strAdres = strAdres
            Me.strTelefoonnummer = strTelefoonnummer
            Me.strSoortKeuken = strSoortKeuken
        End Sub

        Public Sub PrintInfo()
            Console.WriteLine("Naam: " & strNaam)
            Console.WriteLine("Adres: " & strAdres)
            Console.WriteLine("Telefoonnummer: " & strTelefoonnummer)
            Console.WriteLine("Soort keuken: " & strSoortKeuken)
            Console.WriteLine()
        End Sub

    End Class

    Sub Main(args As String())
        Dim objRestaurant As New Restaurant("De Smulpaap", "Hoofdstraat 1, 1234 AB, Dorp", "012-3456789", "Italiaans")
        Dim objRestaurant2 As New Restaurant("Sushi World", "Kerkstraat 5, 5678 CD, Stad", "098-7654321", "Japans")
        Dim objRestaurant3 As New Restaurant("Taco Fiesta", "Marktplein 10, 9101 EF, Plaats", "034-5678901", "Mexicaans")
        objRestaurant.PrintInfo()
        objRestaurant2.PrintInfo()
        objRestaurant3.PrintInfo()
    End Sub
End Module
