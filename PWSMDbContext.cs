using Microsoft.EntityFrameworkCore;
using BlazorLIMS.Data;

namespace BlazorLIMS {

    public class PWSMDbContext : DbContext {

        public PWSMDbContext (DbContextOptions<PWSMDbContext> options) : base(options) {

        }

        public DbSet<ReportModel> PlantReportModels { get; set; }
        public DbSet<ReportModel> WasteReportModels { get; set; }
        public DbSet<ReportModel> SolutionReportModels { get; set; }
        public DbSet<ReportModel> MediaReportModels { get; set; }

        public DbSet<ReportModel> DeletedReportModels { get; set; }

        public DbSet<SampleModel> SampleModels { get; set; }
    }
}