namespace BlazorLIMS.Data {

    public class LabTestData {

        public int Id { get; set; }

        public string SampleCode { get; set; }
        public string Name { get; set; }
        public bool DefaultAssigned { get; set; }

        public double LowValue { get; set; }
        public double HighValue { get; set; }
        public string Units { get; set; }

    }
}