Module Module1

    Sub Main()
        Dim b1, b2 As New Bericht

        b1.afzender = "Jan"
        b1.bericht = "Hallo!"
        b1.datum = Now()
        b2.afzender = "Bram"
        b2.bericht = "Heey!"
        b2.datum = New DateTime(1995, 2, 23, 10, 13, 0)

        Console.WriteLine(b1)
        Console.WriteLine(b2)
    End Sub

End Module
