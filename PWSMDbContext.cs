using Microsoft.EntityFrameworkCore;
using BlazorLIMS.Data;

namespace BlazorLIMS {

    public class PWSMDbContext : DbContext {

        public PWSMDbContext() {
            
        }

        public PWSMDbContext (DbContextOptions<PWSMDbContext> options) : base(options) {

        }

        public DbSet<ReportModel> PlantReportModels { get; set; }
        public DbSet<ReportModel> WasteReportModels { get; set; }
        public DbSet<ReportModel> SolutionReportModels { get; set; }
        public DbSet<ReportModel> MediaReportModels { get; set; }

        public DbSet<SampleModel> PlantSampleModels { get; set; }
        public DbSet<SampleModel> WasteSampleModels { get; set; }
        public DbSet<SampleModel> SolutionSampleModels { get; set; }
        public DbSet<SampleModel> MediaSampleModels { get; set; }

        public DbSet<ReportModel> DeletedReportModels { get; set; }

        public DbSet<LabTestData> TestDataTable { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=PWSMDatabase.db");
        }
    }
}