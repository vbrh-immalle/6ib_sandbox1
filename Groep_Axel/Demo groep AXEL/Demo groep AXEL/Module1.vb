Module Module1

    Public Class BMICalculator

        Private _lengte As Double
        Private _gewicht As Double

        Public Sub New(ByVal strLengte As String, ByVal strGewicht As String)
            _lengte = Double.Parse(strLengte)
            _gewicht = Double.Parse(strGewicht)
        End Sub

        Public Sub New(ByVal dblLengte As Double, ByVal dblGewicht As Double)
            _lengte = dblLengte
            _gewicht = dblGewicht
        End Sub

        ReadOnly Property BMI()
            Get
                Return BerekenBMI(_lengte, _gewicht).ToString()
            End Get
        End Property

        Private Function BerekenBMI(ByVal lengte As Double, ByVal gewicht As Double) As Double
            Return gewicht / lengte ^ 2
        End Function

    End Class

    Sub Main()
        Dim a As New BMICalculator(1.7, 80)
        Dim b As New BMICalculator(1.8, 80)

        Console.WriteLine(a.BMI)
        Console.WriteLine(b.BMI)
    End Sub

End Module


