using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows.Forms;

namespace PerformanceCounterCorrelation {
    public class PerformanceDataProvider {
        Timer timerToCollectData;
        BindingList<TwoCounterSample> logList;
        PerformanceCounter firstCounter;
        PerformanceCounter secondCounter;

        public PerformanceDataProvider(PerformanceCounter first, PerformanceCounter second) {
            timerToCollectData = new Timer();
            logList = new BindingList<TwoCounterSample>();
            timerToCollectData.Interval = 500;
            firstCounter = first;
            secondCounter = second;
            timerToCollectData.Tick += TimerToCollectData_Tick;
        }


        private void TimerToCollectData_Tick(object sender, EventArgs e) {
            LogPerformanceData();
        }

        private void LogPerformanceData() {
            if (logList.Count > 500) {
                Stop();
                RaiseDataOver(new EventArgs());
            }
            logList.Add(new TwoCounterSample(firstCounter.NextValue(), secondCounter.NextValue()));
            if (logList.Count == 3) RaiseDataReady(new EventArgs());
        }

        public void Start(int interval) {
            timerToCollectData.Interval = interval;
            timerToCollectData.Enabled = true;
        }

        event EventHandler onDataReady;
        public event EventHandler DataReady { add { onDataReady += value; } remove { onDataReady -= value; } }
        void RaiseDataReady(EventArgs e) {
            if (onDataReady != null) {
                onDataReady(this,e);
            }
        }

        public IBindingList GetData() {
            return logList;
        }

        event EventHandler onDataOver;
        public event EventHandler DataOver { add { onDataOver += value; } remove { onDataOver -= value; } }
        void RaiseDataOver(EventArgs e) {
            if (onDataOver != null) {
                onDataOver(this, e);
            }
        }

        public void Stop() {
            timerToCollectData.Enabled = false;
        }
    }
}
