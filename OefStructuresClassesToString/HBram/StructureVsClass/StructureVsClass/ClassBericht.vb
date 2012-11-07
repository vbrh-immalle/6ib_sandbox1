Public Class Bericht
    Property afzender As String
    Property bericht As String
    Property datum As DateTime

    Public Overrides Function ToString() As String
        Dim rtrnwrd As String

        rtrnwrd = "afzender: " & afzender & vbCrLf & "bericht: " _
            & bericht & vbCrLf & "datum: " & datum & vbCrLf

        Return rtrnwrd
    End Function
End Class
