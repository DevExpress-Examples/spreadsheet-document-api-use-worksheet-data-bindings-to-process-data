Imports DevExpress.Spreadsheet

Namespace PerformanceCounterCorrelation

#Region "#WorksheetProcessor"
    Public Class WorksheetProcessor

        Private wb As Workbook

        Public Sub New(ByVal dataSource As Object)
            wb = New Workbook()
            wb.CreateNewDocument()
            Dim sheet As Worksheet = wb.Worksheets(0)
            Dim sheetDataTable As Table = sheet.Tables.Add(dataSource, sheet.Range("B2:C50"))
            sheet.Cells("E2").Formula = "IFERROR(CORREL(Table1[Column1], Table1[Column2]),0)"
        End Sub

        Public Function GetDataSource() As Object
            Return wb.Worksheets(0).Cells("E2").GetDataSource()
        End Function

        Public Sub SaveData(ByVal fileNameBase As String)
            Dim fileName As String = String.Format("{0:yyyy-MM-ddTHH-mm-ss}{1}.xlsx", Date.Now, fileNameBase)
            wb.SaveDocument(fileName, DocumentFormat.Xlsx)
        End Sub
    End Class
#End Region  ' #WorksheetProcessor
End Namespace
