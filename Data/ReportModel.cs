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

        public string ReportType { get; set; }

        // True when all tests have measurements
        public bool IsComplete { get; set; }
        
        public bool IsDeleted { get; set; }

        public DateTime DateReceived { get; set; }

        // Navigation property
        public List<SampleModel> Samples { get; set; }

        public void DuplicateSample(int sampleId) {

            int first = Samples[0].LabId;

            SampleModel oldSample = Samples.Find(s => s.LabId == sampleId);
            SampleModel newSample = new SampleModel();

            newSample.SampleType = oldSample.SampleType;
            newSample.SampleCode = oldSample.SampleCode;
            newSample.Comment = oldSample.Comment;
            newSample.AssignedTestsString = oldSample.AssignedTestsString;
            newSample.AssignedTests = new List<SampleTestModel>();
            newSample.LabId = oldSample.LabId + 1;
            newSample.Report = this;

            int newIndex = Samples.IndexOf(oldSample) + 1;

            Samples.Insert(newIndex, newSample);

            for (int i = 0; i < Samples.Count; ++i)
            {
                Samples[i].LabId = first + i;
                Samples[i].LabIdFull = $"{Samples[i].SampleType.Substring(0,1)}{Samples[i].LabId}";
            }


        }

        public void RemoveSample(int sampleId) {

            int first = Samples[0].LabId;

            Samples.Remove(Samples.Find(s => s.LabId == sampleId));

            for (int i = 0; i < Samples.Count; ++i)
            {
                Samples[i].LabId = first + i;
                Samples[i].LabIdFull = $"{Samples[i].SampleType.Substring(0,1)}{Samples[i].LabId}";
            }
        }
    }
}