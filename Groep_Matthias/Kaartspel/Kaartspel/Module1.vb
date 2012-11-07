Module Module1


    Enum KaartSoort
        Klaveren
        Ruiten
        Schoppen
        Harten
    End Enum

    Enum KaartWaarde
        Aas
        Twee
        Drie
        Vier
        Vijf
        Zes
        Zeven
        Acht
        Negen
        Tien
        Boer
        Dame
        Heer
    End Enum

    Structure Kaart
        Dim Soort As KaartSoort
        Dim Waarde As KaartWaarde

        Public Overrides Function ToString() As String
            Return Waarde.ToString + " " + Soort.ToString
        End Function
    End Structure

    Function RandomBoekInHashSet() As HashSet(Of Kaart)
        Dim h As New HashSet(Of Kaart)
        Dim rnd As New Random

        While h.Count < 52
            Dim k As Kaart
            k.Soort = rnd.Next(4)
            k.Waarde = rnd.Next(13)
            Console.WriteLine("rnd kaart: " & k.ToString)

            h.Add(k)
            Console.WriteLine(h.Count)
        End While
        Return h
    End Function

    Sub KaartSpelMain()
        For Each k In RandomBoekInHashSet()
            Console.WriteLine(k)
        Next
    End Sub


End Module
