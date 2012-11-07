Module Module1

    Sub Main()
        Dim datum As New DateTime(1955, 2, 23, 10, 13, 0)
        Dim b1 As New Bericht("Bram", "Hallo", datum)
        Dim b2 As New Bericht("Jan", "Hallo!", Now())

        Console.WriteLine(b1)
        Console.WriteLine(b2)

    End Sub

End Module
