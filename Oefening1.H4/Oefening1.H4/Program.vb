Imports System

Module Program

    Public Class Draak
        Public strNaam As String
        Public strAfkomst As String
        Public chaGeslacht As Char
        Public intLeeftijd As Integer
        Public strKlassificatie As String
    End Class
    Sub Main(args As String())
        Dim objViserion As New Draak()
        objViserion.strNaam = "Viserion"
        objViserion.strAfkomst = "Game of Thrones"
        objViserion.chaGeslacht = "M"
        objViserion.intLeeftijd = 6
        objViserion.strKlassificatie = "Dragon, Wight"

        Dim objRhaegal As New Draak()
        objRhaegal.strNaam = "Rhaegal"
        objRhaegal.strAfkomst = "Game of Thrones"
        objRhaegal.chaGeslacht = "M"
        objRhaegal.intLeeftijd = 7
        objRhaegal.strKlassificatie = "Dragon"

        Dim objdrogon As New Draak()
        objdrogon.strNaam = "Drogon"
        objdrogon.strAfkomst = "Game of Thrones"
        objdrogon.chaGeslacht = "M"
        objdrogon.intLeeftijd = 7
        objdrogon.strKlassificatie = "Dragon"

        Console.WriteLine("Naam: " & objViserion.strNaam)
        Console.WriteLine("Afkomst: " & objViserion.strAfkomst)
        Console.WriteLine("Geslacht: " & objViserion.chaGeslacht)
        Console.WriteLine("Leeftijd: " & objViserion.intLeeftijd)
        Console.WriteLine("Klassificatie: " & objViserion.strKlassificatie)

        Console.WriteLine()

        Console.WriteLine("Naam: " & objRhaegal.strNaam)
        Console.WriteLine("Afkomst: " & objRhaegal.strAfkomst)
        Console.WriteLine("Geslacht: " & objRhaegal.chaGeslacht)
        Console.WriteLine("Leeftijd: " & objRhaegal.intLeeftijd)
        Console.WriteLine("Klassificatie: " & objRhaegal.strKlassificatie)

        Console.WriteLine()

        Console.WriteLine("Naam: " & objdrogon.strNaam)
        Console.WriteLine("Afkomst: " & objdrogon.strAfkomst)
        Console.WriteLine("Geslacht: " & objdrogon.chaGeslacht)
        Console.WriteLine("Leeftijd: " & objdrogon.intLeeftijd)
        Console.WriteLine("Klassificatie: " & objdrogon.strKlassificatie)

    End Sub
End Module
