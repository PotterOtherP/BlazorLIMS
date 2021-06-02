using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BlazorLIMS.Data
{
    public class SampleModel {

        [Key]
        public int SampleModelId { get; set; }

        public int LabId { get; set; }

        public string SampleType { get; set; }

        public string SampleCode { get; set; }

        public string CustomerId { get; set; }
        public string Comment { get; set; }

        public bool IsDeleted { get; set; }

        public List<LabTest> AssignedTests { get; set; }

        // Navigation properties
        [Required]
        public int ReportModelId { get; set; }
        public ReportModel Report { get; set; }
        public string LabReportIdFull { get; set; }
    }
}