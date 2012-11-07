Structure Bericht
    Dim afzender As String
    Dim bericht As String
    Dim verj As DateTime
    Public Overrides Function ToString() As String
        Return afzender & bericht & verj
    End Function
    ' Override hier de ToString() method van object die afzender en bericht afprint
    ' b.v. 
    ' Afzender: Jos
    ' Bericht: Waar ben je?
End Structure

Module Module1

    Sub Main()
        Dim bericht1 As Bericht
        Dim bericht2 As Bericht

        bericht1.afzender = "Jos'"
        bericht1.bericht = "Waar ben je?"
        bericht1.verj = "2012/12/12"

        bericht2.afzender = "Jan'"
        bericht2.bericht = "Hoe gaat het?"
        bericht2.verj = "1995/10/12"

        Console.WriteLine(bericht1.ToString)
        Console.WriteLine(bericht2.ToString)
        ' Maak hier 2 nieuwe berichten aan en druk ze af met Console.WriteLine (en de ToString)-method
        ' Denk eraan: structures zijn VALUE types!
    End Sub

End Module
