namespace PerformanceCounterCorrelation {
    internal class TwoCounterSample {
        public float CounterOne { get; set; }
        public float CounterTwo { get; set; }

        public TwoCounterSample(float x, float y) {
            CounterOne = x;
            CounterTwo = y;
        }
    }
}