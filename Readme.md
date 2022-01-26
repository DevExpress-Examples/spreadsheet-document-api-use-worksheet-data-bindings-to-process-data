<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128613015/17.1.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T520862)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/PerformanceCounterCorrelationExample/Form1.cs) (VB: [Form1.vb](./VB/PerformanceCounterCorrelationExample/Form1.vb))
* [PerformanceDataProvider.cs](./CS/PerformanceCounterCorrelationExample/PerformanceDataProvider.cs) (VB: [PerformanceDataProvider.vb](./VB/PerformanceCounterCorrelationExample/PerformanceDataProvider.vb))
* [TwoCounterSample.cs](./CS/PerformanceCounterCorrelationExample/TwoCounterSample.cs) (VB: [TwoCounterSample.vb](./VB/PerformanceCounterCorrelationExample/TwoCounterSample.vb))
* [WorksheetProcessor.cs](./CS/PerformanceCounterCorrelationExample/WorksheetProcessor.cs) (VB: [WorksheetProcessor.vb](./VB/PerformanceCounterCorrelationExample/WorksheetProcessor.vb))
<!-- default file list end -->
# Spreadsheet Document API - Use Worksheet Data Bindings to Log and Process Data


<p>This example illustrates the use of the <a href="http://help.devexpress.com/#DocumentServer/clsDevExpressSpreadsheetWorkbooktopic">DevExpress.Spreadsheet.Workbook</a> instance to perform the calculations on data bound to an external data source. The calculation result is located in the cell exposed as the data source for the <a href="http://help.devexpress.com/#WindowsForms/clsDevExpressXtraGaugesWinGaugeControltopic">DevExpress.XtraGauges.Win.GaugeControl</a> control.</p>
<p>The source data are pairs of System.Diagnostics.PerformanceCounter object values. Performance samples (TwoCounterSample objects) are collected at the time interval specified by the timer. The samples are stored in the collection. A <strong>WorksheetProcessor</strong> object instance is created to process the collection of samples. A <strong>WoksheetProcessor</strong> includes a <a href="http://help.devexpress.com/#DocumentServer/clsDevExpressSpreadsheetWorkbooktopic">DevExpress.Spreadsheet.Workbook</a>  instance with a <a href="http://help.devexpress.com/#CoreLibraries/clsDevExpressSpreadsheetWorksheettopic">DevExpress.Spreadsheet.Worksheet</a> sheet containing a table bound to the performance data collection. The <a href="http://help.devexpress.com/#CoreLibraries/DevExpressSpreadsheetTableCollection_Addtopic">DevExpress.Spreadsheet.TableCollection.Add</a> method is used to create a table bound to data.</p>
<p>The <strong>CORREL</strong> <a href="http://help.devexpress.com/#DocumentServer/CustomDocument15067">statistical function</a> calculates the correlation coefficient. The cell containing the calculation result is exposed as the data source using the <a href="http://help.devexpress.com/#CoreLibraries/DevExpressSpreadsheetRange_GetDataSourcetopic">DevExpress.Spreadsheet.Range.GetDataSource</a> method.</p>
<p>The worksheet data source providing a correlation coefficient value is bound to the <a href="http://help.devexpress.com/#WindowsForms/DevExpressXtraGaugesWinGaugesCircularArcScaleComponent_DataBindingstopic">DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent.DataBindings</a> and  <a href="http://help.devexpress.com/#WindowsForms/DevExpressXtraGaugesWinBaseLabelComponent_DataBindingstopic">LabelComponent.DataBindings</a> collections of the <a href="http://help.devexpress.com/#WindowsForms/CustomDocument18225">circular gauge</a> control. The gauge control shows the correlation dynamically.</p>
<p>The application window is shown at the following picture.<br><br><img src="https://raw.githubusercontent.com/DevExpress-Examples/document-server-using-workbook-databinding-to-log-and-analyze-performance-counters-t520862/17.1.3+/media/18d40212-460e-11e7-80c0-00155d624807.png"></p>
<br/>
