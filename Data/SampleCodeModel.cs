using System.ComponentModel.DataAnnotations;

namespace BlazorLIMS.Data {

    public class SampleCodeModel {

        [Key]
        public int Id { get; set; }

        public string Name { get; set; }
        public string Type { get; set; }

        public string[] DefaultTests { get; set; }
    }
}