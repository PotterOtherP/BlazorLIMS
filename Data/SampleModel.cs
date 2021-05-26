using System.Collections.Generic;

namespace BlazorLIMS.Data
{
    public class SampleModel {

        public int Id { get; set; }

        public int LabId { get; set; }
        public string SampleType { get; set; }
        public string SampleCode { get; set; }

        public string CustomerId { get; set; }
        public string Comment { get; set; }

        public List<LabTest> AssignedTests { get; set; }

    }
}