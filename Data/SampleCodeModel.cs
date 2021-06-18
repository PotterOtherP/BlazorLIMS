using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;

namespace BlazorLIMS.Data {

    public class SampleCodeModel {

        [Key]
        public int Id { get; set; }

        public string Name { get; set; }
        public string Type { get; set; }
        private string DefaultTestString;

        [NotMapped]
        public string[] DefaultTests { 
            get { return DefaultTestString.Split("|"); }
            set { DefaultTestString = String.Join('|', value);  } 
        }
    }
}