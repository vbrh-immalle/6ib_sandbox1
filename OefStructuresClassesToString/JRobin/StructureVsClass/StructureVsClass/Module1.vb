Structure Bericht
    Dim afzender As String
    Dim datum As DateTime
    Dim bericht As String

    Public Overrides Function ToString() As String
        Return "Afzender: " & afzender & vbCrLf & "Bericht: " & bericht & vbCrLf & "Datum + tijd: " & datum
    End Function
End Structure

Module Module1

    Sub Main()

        Dim bericht1, bericht2 As Bericht
        Dim geboortedatum As New DateTime

        geboortedatum = Date.Parse("4 december")

        bericht1.bericht = "Hallo"
        bericht1.afzender = "Jan"
        bericht1.datum = geboortedatum
        bericht2.bericht = "lol"
        bericht2.afzender = "Jef"
        bericht2.datum = Date.Now

        Console.WriteLine(bericht1)
        Console.WriteLine(bericht2)

    End Sub

End Module
