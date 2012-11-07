Public Class Bericht
    Property afzender As String
    Property bericht As String

    Public Overrides Function ToString() As String

        Return "Afzender: " & afzender & vbCrLf & "Bericht: " & bericht
    End Function
End Class
