using DevExpress.Spreadsheet;
using System;

namespace PerformanceCounterCorrelation {
    #region #WorksheetProcessor
    public class WorksheetProcessor {
        Workbook wb;

        public WorksheetProcessor(object dataSource) {
            wb = new Workbook();
            wb.CreateNewDocument();
            Worksheet sheet = wb.Worksheets[0];
            Table sheetDataTable = sheet.Tables.Add(dataSource, sheet.Range["B2:C50"]);
            sheet.Cells["E2"].Formula = "IFERROR(CORREL(Table1[Column1], Table1[Column2]),0)";
        }

        public object GetDataSource() {
            return wb.Worksheets[0].Cells["E2"].GetDataSource();
        }

        public void SaveData(string fileNameBase) {
            string fileName = String.Format("{0:yyyy-MM-ddTHH-mm-ss}{1}.xlsx", DateTime.Now, fileNameBase);
            wb.SaveDocument(fileName, DocumentFormat.Xlsx);
        }

    }
    #endregion #WorksheetProcessor
}
