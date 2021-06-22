using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;

namespace BlazorLIMS.Data {

    public class SampleCodeModel {

        [Key]
        public int Id { get; set; }

        public string Name { get; set; }
        public string Type { get; set; }
        public string DefaultTestString { get; set; }

    }
}