Public Class Bericht2
    Property afzender As String
    Property bericht As String
    Property verj As DateTime
    Public Overrides Function ToString() As String
        Return afzender & bericht & verj
    End Function
End Class
