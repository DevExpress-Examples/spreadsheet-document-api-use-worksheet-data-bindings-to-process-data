Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Windows.Forms

Namespace PerformanceCounterCorrelation
    Public Class PerformanceDataProvider
        Private timerToCollectData As Timer
        Private logList As BindingList(Of TwoCounterSample)
        Private firstCounter As PerformanceCounter
        Private secondCounter As PerformanceCounter

        Public Sub New(ByVal first As PerformanceCounter, ByVal second As PerformanceCounter)
            timerToCollectData = New Timer()
            logList = New BindingList(Of TwoCounterSample)()
            timerToCollectData.Interval = 500
            firstCounter = first
            secondCounter = second
            AddHandler timerToCollectData.Tick, AddressOf TimerToCollectData_Tick
        End Sub


        Private Sub TimerToCollectData_Tick(ByVal sender As Object, ByVal e As EventArgs)
            LogPerformanceData()
        End Sub

        Private Sub LogPerformanceData()
            If logList.Count > 500 Then
                [Stop]()
                RaiseDataOver(New EventArgs())
            End If
            logList.Add(New TwoCounterSample(firstCounter.NextValue(), secondCounter.NextValue()))
            If logList.Count = 3 Then
                RaiseDataReady(New EventArgs())
            End If
        End Sub

        Public Sub Start(ByVal interval As Integer)
            timerToCollectData.Interval = interval
            timerToCollectData.Enabled = True
        End Sub

        Private Event onDataReady As EventHandler
        Public Custom Event DataReady As EventHandler
            AddHandler(ByVal value As EventHandler)
                AddHandler onDataReady, value
            End AddHandler
            RemoveHandler(ByVal value As EventHandler)
                RemoveHandler onDataReady, value
            End RemoveHandler
            RaiseEvent(ByVal sender As System.Object, ByVal e As System.EventArgs)
                RaiseEvent onDataReady(sender, e)
            End RaiseEvent
        End Event
        Private Sub RaiseDataReady(ByVal e As EventArgs)
            RaiseEvent onDataReady(Me,e)
        End Sub

        Public Function GetData() As IBindingList
            Return logList
        End Function

        Private Event onDataOver As EventHandler
        Public Custom Event DataOver As EventHandler
            AddHandler(ByVal value As EventHandler)
                AddHandler onDataOver, value
            End AddHandler
            RemoveHandler(ByVal value As EventHandler)
                RemoveHandler onDataOver, value
            End RemoveHandler
            RaiseEvent(ByVal sender As System.Object, ByVal e As System.EventArgs)
                RaiseEvent onDataOver(sender, e)
            End RaiseEvent
        End Event
        Private Sub RaiseDataOver(ByVal e As EventArgs)
            RaiseEvent onDataOver(Me, e)
        End Sub

        Public Sub [Stop]()
            timerToCollectData.Enabled = False
        End Sub
    End Class
End Namespace
