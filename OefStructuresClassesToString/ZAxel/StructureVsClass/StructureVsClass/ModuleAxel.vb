Structure Bericht
    Dim afzender As String
    Dim bericht As String
    Dim datum As DateTime

    Public Overrides Function ToString() As String
        Console.WriteLine("Afzender: " & afzender)
        Console.WriteLine("Bericht: " & bericht)
        Console.WriteLine("Datum: " & datum)
        Return ""
    End Function

End Structure

Module ModuleAxel

    Sub Main()


        Dim b1 As Bericht

        b1.afzender = "Jos"
        b1.bericht = "Waar ben je?"
        b1.datum = Now()
        Console.WriteLine(b1)


        Dim b2 As Bericht

        b2.afzender = "Ik"
        b2.bericht = "Hello world."
        b2.datum = New DateTime(1995, 6, 22, 14, 48, 0)
        Console.WriteLine(b2)


        Dim bje1 As New Berichtje
        bje1.afzender = "Jas"
        bje1.bericht = "Woor ben je?"
        bje1.datum = Now()
        Console.WriteLine(bje1)


        Dim bje2 As New Berichtje
        bje2.afzender = "Ik"
        bje2.bericht = "Hello world."
        bje2.datum = New DateTime(1995, 6, 22, 14, 48, 0)
        Console.WriteLine(bje2)
    End Sub

End Module
