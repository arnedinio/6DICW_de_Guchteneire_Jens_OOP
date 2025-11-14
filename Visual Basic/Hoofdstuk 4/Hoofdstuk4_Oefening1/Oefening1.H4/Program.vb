Imports System

Module Program

    Public Class Draak
        Private strNaam As String
        Private strAfkomst As String
        Private chaGeslacht As Char
        Private intLeeftijd As Integer
        Private strKlassificatie As String

        Public Sub New(strNaam As String, strAfkomst As String, chaGeslacht As Char, intLeeftijd As Integer, strKlassificatie As String)
            Me.strNaam = strNaam
            Me.strAfkomst = strAfkomst
            Me.chaGeslacht = chaGeslacht
            Me.intLeeftijd = intLeeftijd
            Me.strKlassificatie = strKlassificatie
        End Sub

        Public Function getNaam() As String
            Return strNaam
        End Function

        Public Function getAfkomst() As String
            Return strAfkomst
        End Function

        Public Function getGeslacht() As Char
            Return chaGeslacht
        End Function

        Public Function getLeeftijd() As Integer
            Return intLeeftijd
        End Function

        Public Function getKlassificatie() As String
            Return strKlassificatie
        End Function
    End Class
    Sub Main()
        Dim objViserion As New Draak("Viserion", "Game of Thrones", "M", 6, "Dragon, Wight")
        Console.WriteLine("Naam: " & objViserion.getNaam())
        Console.WriteLine("Afkomst: " & objViserion.getAfkomst())
        Console.WriteLine("Geslacht: " & objViserion.getGeslacht())
        Console.WriteLine("Leeftijd: " & objViserion.getLeeftijd())
        Console.WriteLine("Klassificatie: " & objViserion.getKlassificatie())

        Console.WriteLine()

        Dim objRhaegal As New Draak("Rhaegal", "Game of Thrones", "M", 7, "Dragon")
        Console.WriteLine("Naam: " & objRhaegal.getNaam())
        Console.WriteLine("Afkomst: " & objRhaegal.getAfkomst())
        Console.WriteLine("Geslacht: " & objRhaegal.getGeslacht())
        Console.WriteLine("Leeftijd: " & objRhaegal.getLeeftijd())
        Console.WriteLine("Klassificatie: " & objRhaegal.getKlassificatie())

        Console.WriteLine()

        Dim objdrogon As New Draak("Drogon", "Game of Thrones", "M", 7, "Dragon")
        Console.WriteLine("Naam: " & objdrogon.getNaam())
        Console.WriteLine("Afkomst: " & objdrogon.getNaam())
        Console.WriteLine("Geslacht: " & objdrogon.getGeslacht())
        Console.WriteLine("Leeftijd: " & objdrogon.getLeeftijd())
        Console.WriteLine("Klassificatie: " & objdrogon.getKlassificatie())

    End Sub
End Module
