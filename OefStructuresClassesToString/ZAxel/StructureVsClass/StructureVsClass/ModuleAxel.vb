Structure Bericht
    Dim afzender As String
    Dim bericht As String
    Dim datum As DateTime

    Public Overrides Function ToString() As String
        Console.WriteLine("Afzender: " & afzender)
        Console.WriteLine("Bericht: " & bericht)
        Console.WriteLine("Datum: " & datum)
        Return ""
    End Function
    ' Override hier de ToString() method van object die afzender en bericht afprint
    ' b.v. 
    ' Afzender: Jos
    ' Bericht: Waar ben je?
End Structure

Module ModuleAxel

    Sub Main()
        ' Maak hier 2 nieuwe berichten aan en druk ze af met Console.WriteLine (en de ToString)-method
        ' Denk eraan: structures zijn VALUE types!




        Dim b1 As Bericht

        b1.afzender = "Jos"
        b1.bericht = "Waar ben je?"
        b1.datum = Now()
        Console.WriteLine(b1)


        Dim b2 As Bericht

        b2.afzender = "Ik"
        b2.bericht = "Hello world."
        b2.datum = New DateTime(1995, 6, 22, 14, 48, 0)
        Console.WriteLine(b2)
    End Sub

End Module
