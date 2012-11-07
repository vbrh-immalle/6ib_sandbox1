Public Class Bericht
    Dim _afzender As String
    Dim _bericht As String
    Dim _datum As DateTime

    Sub New(ByVal afzender As String, ByVal bericht As String, ByVal datum As DateTime)
        _afzender = afzender
        _bericht = bericht
        _datum = datum
    End Sub

    Public Overrides Function ToString() As String
        Dim rtrnwrd As String

        rtrnwrd = "afzender: " & _afzender & vbCrLf & "bericht: " _
            & _bericht & vbCrLf & "datum: " & _datum & vbCrLf

        Return rtrnwrd
    End Function
End Class
