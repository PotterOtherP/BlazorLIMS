using System;
using System.Collections.Generic;

namespace BlazorLIMS.Data {

    public class ReportModel {

        public int Id { get; set; }

        public int LabReportId { get; set; }
        public string SampleType { get; set; }
        public string ReportType { get; set; }
        public bool IsComplete { get; set; }

        public DateTime DateReceived { get; set; }

        public List<SampleModel> Samples { get; set; }
    }
}