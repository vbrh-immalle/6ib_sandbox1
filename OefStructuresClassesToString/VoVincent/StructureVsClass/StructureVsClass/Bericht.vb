Public Class Bericht
    Property afzender As String
    Property bericht As String
    Property datum As DateTime

    Public Overrides Function ToString() As String

        Return "Afzender: " & afzender & vbCrLf & "Bericht: " & bericht & vbCrLf & "Datum: " & datum
    End Function

    Sub Verzend()
        Console.WriteLine("Bericht wordt verzonden")
    End Sub


End Class
