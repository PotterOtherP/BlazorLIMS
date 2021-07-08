using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BlazorLIMS.Data
{
    public class SampleModel {

        [Key]
        public int SampleModelId { get; set; }

        public int LabId { get; set; }

        public string LabIdFull { get; set; }

        public string SampleType { get; set; }

        public string SampleCode { get; set; }

        public string CustomerId { get; set; }
        public string Comment { get; set; }

        public bool IsDeleted { get; set; }

        public string AssignedTestsString { get; set; }
        public List<SampleTestModel> AssignedTests { get; set; }

        // Navigation properties
        [Required]
        public int ReportModelId { get; set; }
        public ReportModel Report { get; set; }
        public string LabReportIdFull { get; set; }

        public bool HMAssigned() {

            return AssignedTestsString.Contains("|HM|") ||
                   AssignedTestsString.StartsWith("HM|") ||
                   AssignedTestsString.EndsWith("|HM");
        }

        public bool ICPAssigned() {

            return AssignedTestsString.Contains("|ICP|") ||
                   AssignedTestsString.StartsWith("ICP|") ||
                   AssignedTestsString.EndsWith("|ICP");
        }

        public bool HMComplete() {

            foreach (var test in AssignedTests)
            {
                if (test.Name.Contains("HM") && test.MeasuredValue == null)
                    return false;

            }
            
            return true;
        }

        public bool ICPComplete() {

            foreach (var test in AssignedTests)
            {
                if (test.Name.Contains("ICP") && test.MeasuredValue == null)
                    return false;

            }

            return true;
        }

        public bool IsComplete() {

            foreach (var test in AssignedTests)
            {
                if (test.MeasuredValue == null)
                    return false;
            }

            return true;
        }
    }
}