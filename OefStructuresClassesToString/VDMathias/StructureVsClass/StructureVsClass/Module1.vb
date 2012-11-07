Structure Bericht
    Dim afzender As String
    Dim bericht As String

    Public Overrides Function ToString() As String
        Return afzender & " " & bericht
    End Function

End Structure




Module Module1

    Sub Main()
        Dim heeeej As Bericht
        Dim baas As Bericht
        Dim bigmac As New Bericht

        bigmac.afzender = "ronald"
        bigmac.bericht = "msokfjoqisfjoqisjefmoqishejz"

        heeeej.afzender = "Q"
        heeeej.bericht = "heeeeeeeeeeeeeeeeeeejjjjjjj"
        baas.afzender = "Baas"
        baas.bericht = "ARBEITEN"

        Console.WriteLine(heeeej)
        Console.WriteLine(baas)

    End Sub

End Module
