Public Class Bericht
    Property afzender As String
    Property bericht As String

    Public Overrides Function ToString() As String
        Return afzender & " " & bericht
    End Function


End Class
