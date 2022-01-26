Imports System
Imports System.Diagnostics
Imports System.Windows.Forms

Namespace PerformanceCounterCorrelation

    Public Partial Class Form1
        Inherits Form

        Private isRunning As Boolean

        Private dataProvider As PerformanceDataProvider

        Private sheetProcessor As WorksheetProcessor

        Private firstCounter As PerformanceCounter = New PerformanceCounter()

        Private secondCounter As PerformanceCounter = New PerformanceCounter()

        Public Sub New()
            InitializeComponent()
            FillCounterInformation()
            btnStart.Select()
        End Sub

        Private Sub FillCounterInformation()
            Dim processName As String = Process.GetCurrentProcess().ProcessName
            textEditCategory1.Text = "Process"
            textEditCounter1.Text = "Private Bytes"
            textEditInstance1.Text = processName
            textEditCategory2.Text = ".NET CLR Memory"
            textEditCounter2.Text = "# Bytes In All Heaps"
            textEditInstance2.Text = processName
        End Sub

        Private Function CreateCounters() As Boolean
            Dim p As Process = Process.GetCurrentProcess()
            Try
                firstCounter = New PerformanceCounter(textEditCategory1.Text, textEditCounter1.Text, textEditInstance1.Text)
                secondCounter = New PerformanceCounter(textEditCategory2.Text, textEditCounter2.Text, textEditInstance2.Text)
                firstCounter.NextValue()
                secondCounter.NextValue()
            Catch e As Exception
                MessageBox.Show(e.Message, "Counter Error")
                Return False
            End Try

            Return True
        End Function

        Private Sub btnStart_Click(ByVal sender As Object, ByVal e As EventArgs)
            If Not isRunning Then
                If Not CreateCounters() Then Return
                btnStart.Text = "Stop"
                dataProvider = New PerformanceDataProvider(firstCounter, secondCounter)
                AddHandler dataProvider.DataReady, AddressOf DataProvider_DataReady
                AddHandler dataProvider.DataOver, AddressOf DataProvider_DataOver
                isRunning = True
                dataProvider.Start(500)
            Else
                FullStop()
            End If
        End Sub

        Private Sub DataProvider_DataReady(ByVal sender As Object, ByVal e As EventArgs)
            sheetProcessor = New WorksheetProcessor(dataProvider.GetData())
            arcScaleComponent1.DataBindings.Add("Value", sheetProcessor.GetDataSource(), "Column 0")
            labelComponent1.DataBindings.Add("Text", sheetProcessor.GetDataSource(), "Column 0")
        End Sub

        Private Sub DataProvider_DataOver(ByVal sender As Object, ByVal e As EventArgs)
            FullStop()
        End Sub

        Private Sub FullStop()
            RemoveHandler dataProvider.DataReady, AddressOf DataProvider_DataReady
            RemoveHandler dataProvider.DataOver, AddressOf DataProvider_DataOver
            btnStart.Text = "Start"
            dataProvider.Stop()
            sheetProcessor.SaveData("mytest")
            isRunning = False
            arcScaleComponent1.DataBindings.Clear()
            labelComponent1.DataBindings.Clear()
        End Sub
    End Class
End Namespace
