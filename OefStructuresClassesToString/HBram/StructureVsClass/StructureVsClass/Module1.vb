﻿Structure Bericht
    Dim afzender As String
    Dim bericht As String

    Public Overrides Function ToString() As String
        Dim rtrnwrd As String

        rtrnwrd = "afzender: " & afzender & vbCrLf & "bericht: " & bericht & vbCrLf

        Return rtrnwrd
    End Function

    ' Override hier de ToString() method van object die afzender en bericht afprint
End Structure

Module Module1

    Sub Main()
        Dim b1, b2 As Bericht

        b1.afzender = "Jan"
        b2.bericht = "Heey!"
        b2.afzender = "Joseph"
        b1.bericht = "Hallo!"

        Console.WriteLine(b1)
        Console.WriteLine(b2)
        ' Maak hier 2 nieuwe berichten aan en druk ze af met Console.WriteLine (en de ToString)-method
        ' Denk eraan: structures zijn VALUE types!

    End Sub

End Module
