﻿Module Module1

    Sub Main()
        ' Maak hier 2 nieuwe berichten aan en druk ze af met Console.WriteLine (en de ToString)-method
        ' Denk eraan: structures zijn VALUE types!
        Dim b1 As New Bericht
        b1.afzender = "barry"
        b1.bericht = "saispas"
        Console.WriteLine(b1.ToString())

        Dim b2 As New Bericht
        b2.afzender = "Walter"
        b2.bericht = "dinges"
        Console.WriteLine(b2.ToString())




    End Sub

End Module
