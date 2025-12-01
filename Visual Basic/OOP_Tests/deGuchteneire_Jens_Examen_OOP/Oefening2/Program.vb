Imports System

Module Program
    Class Organisme
        'Velden
        Protected strNaam As String
        Protected intLeeftijd As Integer

        'Sinds we niet van plan zijn een object te maken, geen constructor in deze klasse. Maakt het gemakkelijker later

        Public Overridable Sub Groei()
            'Doet niks in klasse Organisme
        End Sub

        Public Function CheckTijdeenheid(intLeeftijd)
            'Dit was mijn poging van jouw "corrigeer design fout". Hieronder wat problemen met de vraagstelling:
            '1) Je geeft ons geen mogelijkheid hoe we het moeten oplossen
            '2) Je zegt niet wat van je verwacht word (aantal kommagetallen, zijn er kommagetalen? zo niet hoe rond je af?)
            '3) Je geeft ons niet de output die je verwacht
            '4) Ik betwijfel heel erg dat dit mogelijk is met wat we in de les gezien hebben.
            '   Zelf wat ik hieronder heb gemaakt (wat ik niet weet hoe ik mogelijk moet implementeren), was gemaakt met gokjes en dromen van een betere toekomst
            '5) Je zegt dat we "mogen" afwijken van de output in 4, maar als je punten aftrekt als we dat niet doen bedoel je eigenlijk "moet"
            '6) Zelf al negeer je de output moet je de invoer in Main() ook veranderen
            If intLeeftijd < 30 Then
                Return Str(intLeeftijd & "dagen")
            ElseIf intLeeftijd < 365 Then
                Return Str(intLeeftijd / 7 & "weken")
            Else
                Return Str(intLeeftijd / 365 & "jaren")
            End If
        End Function
    End Class

    Class Plant
        'Overerving
        Inherits Organisme

        'Velden
        Protected dblHoogte As Double
        '+strNaam
        '+intLeeftijd

        'Constructor {param: String naam, int Leeftijd, double Hoogte}
        Public Sub New(strNaam, intLeeftijd, dblHoogte)
            Me.strNaam = strNaam
            Me.intLeeftijd = intLeeftijd
            Me.dblHoogte = dblHoogte
        End Sub

        'Methodes
        Public Overrides Sub Groei()
            'De MyBase hier doet niks maar ik wil laten zien dat het een base functie heeft
            'Groeit (hoogte) met 1 mm
            MyBase.Groei()
            Me.dblHoogte += 0.001
            Console.WriteLine(Me.strNaam & "is gegroeid, het is nu: " & Me.dblHoogte & " meter hoog.")
            Console.WriteLine("Plant is zo oud (in jaar): " & intLeeftijd)
        End Sub

        Public Sub Fotosynthese() 'Fotosynthese is 1 woord, dus geen Pascal Casing
            'schrijft dat die aan fotosynthese doet. Niks anders
            Console.WriteLine(Me.strNaam & " is bezig met fotosynthese!")
        End Sub
    End Class

    Class Boom
        'Overerving
        Inherits Plant

        'Velden
        Private strTypeBlad As String
        '+strNaam
        '+strLeeftijd
        '+intHoogte

        'Constructor {param: String naam, int Leeftijd, double Hoogte, String type blad}
        Public Sub New(strNaam, intLeeftijd, dblHoogte, strTypeBlad)
            MyBase.New(strNaam, intLeeftijd, dblHoogte)
            Me.strTypeBlad = strTypeBlad
        End Sub
        'Methodes
        Public Overrides Sub Groei()
            'Voegt 2 duizendste aan de dblHoogte, print de naam, hoogte, leeftijd en type v.h. blad
            Me.dblHoogte += 0.002
            Console.WriteLine(strNaam & " is gegroeid met type blad: " & Me.strTypeBlad)
            Console.WriteLine("De niewe hoogte van de boom is: " & Me.dblHoogte & " meter.")
            Console.WriteLine("Boom is zo oud (in jaar): " & intLeeftijd)
        End Sub

    End Class

    Class Dier
        'Overerving
        Inherits Organisme

        'Velden
        Protected strGeluid As String
        '+strNaam
        '+strLeeftijd

        'Constructor {param: String naam, int leeftijd, String geluid}
        Public Sub New(strNaam, intLeeftijd, strGeluid)
            Me.strNaam = strNaam
            Me.intLeeftijd = intLeeftijd
            Me.strGeluid = strGeluid
        End Sub

        'Methodes
        Public Overrides Sub Groei()
            'Schrijft gewoon dat die gegroeid is en hoe oud die is. Doet niks speciaal van berekening etc
            Console.WriteLine(Me.strNaam & " is gegroeid, op een unieke dierlijke manier.")
            Console.WriteLine("Dier is zo oud (in jaar): " & Me.intLeeftijd)
        End Sub

        Public Overridable Sub MaakGeluid()
            'Doet niks in dier?
        End Sub
    End Class

    Class Vogel
        'Overerving
        Inherits Dier

        'Velden
        Private intSpanwijdte As Integer

        'Constructor {param: String naam, int leeftijd, String geluid, int spanwijdte}
        Public Sub New(strNaam, intLeeftijd, strGeluid, intSpanwijdte)
            MyBase.New(strNaam, intLeeftijd, strGeluid)
            Me.intSpanwijdte = intSpanwijdte
        End Sub

        'Methodes
        Public Overrides Sub MaakGeluid()
            'Afhankelijk van strGeluid maakt die verschillende geluiden
            Console.WriteLine(strNaam & " met vleugelspanwijdte: " & intSpanwijdte & " meter zingt: " & strGeluid)
        End Sub
    End Class
    Sub Main(args As String())
        Dim objBlauwKorenbloem As New Plant("Blauwe korenbloem", 0.1, 0.05 / 100)

        Dim objEik As New Boom("Eik", 50, 15, "Eivormig")

        Dim objAdelaar As New Vogel("Zeearend", 5, "Krijs", 2)

        objEik.Groei()
        objEik.Fotosynthese()
        Console.WriteLine("---")

        objBlauwKorenbloem.Groei()
        objBlauwKorenbloem.Fotosynthese()
        Console.WriteLine("---")

        objAdelaar.Groei()
        objAdelaar.MaakGeluid()
        Console.WriteLine("---")

    End Sub
End Module
