using Microsoft.EntityFrameworkCore;
using BlazorLIMS.Data;
using System.Configuration;
using Microsoft.Extensions.Configuration;

namespace BlazorLIMS {

    public static class MyAppData {

        public static IConfiguration Configuration;
    }

    public class PWSMDbContext : DbContext {


        public PWSMDbContext() {

            // Console.WriteLine("Database context created.");
            
        }

        public PWSMDbContext (DbContextOptions<PWSMDbContext> options) : base(options) {

            // Console.WriteLine("Database context created.");
        }

        public DbSet<ReportModel> ReportModels { get; set; }
        public DbSet<SampleModel> SampleModels { get; set; }
        public DbSet<SampleTestModel> SampleTestModels { get; set; }

        public DbSet<TestDataModel> TestDataTable { get; set; }
        public DbSet<SampleCodeModel> SampleCodeTable { get; set; }

        public DbSet<UserModel> UserModels { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // optionsBuilder.UseSqlite("Data Source=PWSMDatabase.db");
            string str = MyAppData.Configuration.GetConnectionString("SQLCONNSTR_nstsqldb_connstr");
            optionsBuilder.UseSqlServer(str);
        }
    }
}