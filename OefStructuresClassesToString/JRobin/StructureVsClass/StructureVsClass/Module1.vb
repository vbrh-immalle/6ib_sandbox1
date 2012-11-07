Structure Bericht
    Dim afzender As String
    Dim bericht As String

    Public Overrides Function ToString() As String
        Return "Afzender:"
    End Function
    ' Override hier de ToString() method van object die afzender en bericht afprint
    ' b.v. 
    ' Afzender: Jos
    ' Bericht: Waar ben je?
End Structure

Module Module1

    Sub Main()
        ' Maak hier 2 nieuwe berichten aan en druk ze af met Console.WriteLine (en de ToString)-method
        ' Denk eraan: structures zijn VALUE types!
        Dim woord As String
        woord = "Hallo"
        Console.WriteLine(woord.ToString())
    End Sub

End Module
