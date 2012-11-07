Public Class Berichtje
    Public afzender As String
    Public bericht As String
    Public datum As DateTime

    Public Overrides Function ToString() As String
        Console.WriteLine("Afzender: " & afzender)
        Console.WriteLine("Bericht: " & bericht)
        Console.WriteLine("Datum: " & datum)
        Return ""
    End Function
End Class
