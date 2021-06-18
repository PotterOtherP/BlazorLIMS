using System;

namespace BlazorLIMS.Data {

    public class SampleTestModel {

        public int Id { get; set; }

        public string Name { get; set; }
        public double LowValue { get; set; }
        public double HighValue { get; set; }
        public string Units { get; set; }

        public double MeasuredValue { get; set; }

        public bool IsNormal() {

            return (MeasuredValue >= LowValue && MeasuredValue <= HighValue);
        }

        public double Percentile() {

            if ((HighValue - LowValue) == 0)
            {
                throw new DivideByZeroException("High value and low value cannot be the same.");
            }

            return (MeasuredValue - LowValue) / (HighValue - LowValue);
        }

    }
}