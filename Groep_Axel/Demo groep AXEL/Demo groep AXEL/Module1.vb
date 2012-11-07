Module Module1

    Sub Main()
        Dim lengte, gewicht, bmi As Double
        Dim lengte2, gewicht2, bmi2 As Double


        Console.WriteLine("Voer eerst lengte en daarna het gewicht in van persoon 1")
        lengte = Double.Parse(Console.ReadLine())
        gewicht = Double.Parse(Console.ReadLine())
        Console.WriteLine()
        Console.WriteLine("Voer eerst lengte en daarna het gewicht in van persoon 2")
        lengte2 = Double.Parse(Console.ReadLine())
        gewicht2 = Double.Parse(Console.ReadLine())

        bmi = gewicht / lengte ^ 2
        bmi2 = gewicht2 / lengte2 ^ 2

        Console.WriteLine("bmi persoon 1: " & bmi.ToString())
        Console.WriteLine("bmi persoon 2: " & bmi2.ToString())

        Console.ReadLine()
    End Sub

End Module
