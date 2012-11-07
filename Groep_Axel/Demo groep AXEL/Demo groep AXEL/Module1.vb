Module Module1

    Function BerekenBMI(ByVal lengte As Double, ByVal gewicht As Double) As Double
        Return gewicht / lengte ^ 2
    End Function

    Function BerekenBMIAsStrings(ByVal lengte As String, ByVal gewicht As String) As String
        Return BerekenBMI(Double.Parse(lengte), Double.Parse(gewicht)).ToString()
    End Function

    Sub Main()
        Console.WriteLine("Geef eerst lengte daarna gewicht in.")
        Console.WriteLine("bmi persoon 1: " & BerekenBMIAsStrings(Console.ReadLine(), Console.ReadLine()))
        Console.WriteLine("bmi persoon 2: " & BerekenBMIAsStrings(Console.ReadLine(), Console.ReadLine()))

        Console.ReadLine()
    End Sub

End Module
