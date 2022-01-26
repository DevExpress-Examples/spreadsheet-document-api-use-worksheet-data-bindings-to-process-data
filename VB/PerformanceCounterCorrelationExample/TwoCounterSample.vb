Namespace PerformanceCounterCorrelation

    Friend Class TwoCounterSample

        Public Property CounterOne As Single

        Public Property CounterTwo As Single

        Public Sub New(ByVal x As Single, ByVal y As Single)
            CounterOne = x
            CounterTwo = y
        End Sub
    End Class
End Namespace
