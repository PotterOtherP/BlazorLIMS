using System;

namespace BlazorLIMS.Data {

    public class LabTest {

        public string Name { get; set; }

        public readonly double LowValue;
        public readonly double HighValue;

        public LabTest(string name, double low, double high) {

            if (high <= low)
            {
                throw new ArgumentException("High value must be greater than low value.");
            }

            if (high < 0 || low < 0)
            {
                throw new ArgumentException("Test threshold values cannot be negative.");
            }

            Name = name;
            LowValue = low;
            HighValue = high;

        }

        public bool IsNormal(double sampleValue) {

            return (sampleValue >= LowValue && sampleValue <= HighValue);
        }

        public double Percentile(double sampleValue) {

            if ((HighValue - LowValue) == 0)
            {
                throw new DivideByZeroException("High value and low value cannot be the same.");
            }

            return (sampleValue - LowValue) / (HighValue - LowValue);
        }

    }
}