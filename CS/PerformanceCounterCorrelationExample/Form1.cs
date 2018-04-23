using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace PerformanceCounterCorrelation {
    public partial class Form1 : Form {
        bool isRunning;
        PerformanceDataProvider dataProvider;
        WorksheetProcessor sheetProcessor;
        PerformanceCounter firstCounter = new PerformanceCounter();
        PerformanceCounter secondCounter = new PerformanceCounter();

        public Form1() {
            InitializeComponent();
            FillCounterInformation();
            this.btnStart.Select();
        }

        private void FillCounterInformation() {
            string processName = Process.GetCurrentProcess().ProcessName;
            this.textEditCategory1.Text = "Process";
            this.textEditCounter1.Text = "Private Bytes";
            this.textEditInstance1.Text = processName;
            this.textEditCategory2.Text = ".NET CLR Memory";
            this.textEditCounter2.Text = "# Bytes In All Heaps";
            this.textEditInstance2.Text = processName;
        }

        bool CreateCounters() {
            Process p = Process.GetCurrentProcess();
            try {
                firstCounter = new PerformanceCounter(textEditCategory1.Text, textEditCounter1.Text, textEditInstance1.Text);
                secondCounter = new PerformanceCounter(textEditCategory2.Text, textEditCounter2.Text, textEditInstance2.Text);
                firstCounter.NextValue();
                secondCounter.NextValue();
            }
            catch (Exception e) {
                MessageBox.Show(e.Message,"Counter Error");
                return false;
            }
            return true;
    }

        private void btnStart_Click(object sender, EventArgs e) {
            if (!isRunning) {
                if (!CreateCounters()) return;
                btnStart.Text = "Stop";
                dataProvider = new PerformanceDataProvider(firstCounter, secondCounter);
                dataProvider.DataReady += DataProvider_DataReady;
                dataProvider.DataOver += DataProvider_DataOver;
                isRunning = true;
                dataProvider.Start(500);
            }
            else {
                FullStop();
            }
        }

        private void DataProvider_DataReady(object sender, EventArgs e) {
            sheetProcessor = new WorksheetProcessor(dataProvider.GetData());
            arcScaleComponent1.DataBindings.Add("Value", sheetProcessor.GetDataSource(), "Column 0");
            labelComponent1.DataBindings.Add("Text", sheetProcessor.GetDataSource(), "Column 0");
        }

        private void DataProvider_DataOver(object sender, EventArgs e) {
            FullStop();
        }

        void FullStop() {
            dataProvider.DataReady -= DataProvider_DataReady;
            dataProvider.DataOver -= DataProvider_DataOver;
            btnStart.Text = "Start";
            dataProvider.Stop();
            sheetProcessor.SaveData("mytest");
            isRunning = false;
            arcScaleComponent1.DataBindings.Clear();
            labelComponent1.DataBindings.Clear();
        }


    }
}
