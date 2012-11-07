Structure Bericht
    Dim afzender As String
    Dim bericht As String
    Dim datum As DateTime

    Public Overrides Function ToString() As String
        Dim rtrnwrd As String

        rtrnwrd = "afzender: " & afzender & vbCrLf & "bericht: " & bericht & vbCrLf & "datum: " & datum & vbCrLf

        Return rtrnwrd
    End Function

End Structure

Module Module1

    Sub Main()
        Dim b1, b2 As Bericht

        b1.afzender = "Jan"
        b1.bericht = "Hallo!"
        b1.datum = Now()
        b2.afzender = "Bram"
        b2.bericht = "Heey!"
        b2.datum = New DateTime(1995, 2, 23, 10, 13, 0)

        Console.WriteLine(b1)
        Console.WriteLine(b2)
    End Sub

End Module
