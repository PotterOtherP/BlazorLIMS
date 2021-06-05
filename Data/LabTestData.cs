namespace BlazorLIMS.Data {

    public class LabTestData {

        public int Id { get; set; }

        public string ShortName { get; set; }
        public string LongName { get; set; }
        public string SampleCode { get; set; }
        public bool DefaultAssigned { get; set; }

        public string Units { get; set; }
        public double LowValue { get; set; }
        public double HighValue { get; set; }

    }
}