Public Class Berichtje
    Property afzender As String
    Property bericht As String
    Property datum As DateTime

    Public Overrides Function ToString() As String
        Console.WriteLine("Afzender: " & afzender)
        Console.WriteLine("Bericht: " & bericht)
        Console.WriteLine("Datum: " & datum)
        Return ""
    End Function
End Class
