using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BlazorLIMS.Data {

    public class ReportModel {

        [Key]
        public int ReportModelId { get; set; }

        public int LabReportId { get; set; }
        public string LabReportIdFull { get; set; }

        public string SampleType { get; set; }
        public string SampleTypeLetter { get; set; }

        public string ReportType { get; set; }
        public bool IsComplete { get; set; }
        public bool IsDeleted { get; set; }

        public DateTime DateReceived { get; set; }

        // Navigation property
        public List<SampleModel> Samples { get; set; }
    }
}