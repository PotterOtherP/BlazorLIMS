using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BlazorLIMS.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ReportModel",
                columns: table => new
                {
                    ReportModelId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    LabReportId = table.Column<int>(type: "INTEGER", nullable: false),
                    SampleType = table.Column<string>(type: "TEXT", nullable: true),
                    ReportType = table.Column<string>(type: "TEXT", nullable: true),
                    IsComplete = table.Column<bool>(type: "INTEGER", nullable: false),
                    IsDeleted = table.Column<bool>(type: "INTEGER", nullable: false),
                    DateReceived = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReportModel", x => x.ReportModelId);
                });

            migrationBuilder.CreateTable(
                name: "SampleModel",
                columns: table => new
                {
                    SampleModelId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    LabId = table.Column<int>(type: "INTEGER", nullable: false),
                    LabIdFull = table.Column<string>(type: "TEXT", nullable: true),
                    SampleType = table.Column<string>(type: "TEXT", nullable: true),
                    SampleTypeLetter = table.Column<string>(type: "TEXT", nullable: true),
                    SampleCode = table.Column<string>(type: "TEXT", nullable: true),
                    CustomerId = table.Column<string>(type: "TEXT", nullable: true),
                    Comment = table.Column<string>(type: "TEXT", nullable: true),
                    IsDeleted = table.Column<bool>(type: "INTEGER", nullable: false),
                    ReportModelId = table.Column<int>(type: "INTEGER", nullable: false),
                    LabReportIdFull = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SampleModel", x => x.SampleModelId);
                    table.ForeignKey(
                        name: "FK_SampleModel_ReportModel_ReportModelId",
                        column: x => x.ReportModelId,
                        principalTable: "ReportModel",
                        principalColumn: "ReportModelId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LabTest",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    LowValue = table.Column<double>(type: "REAL", nullable: false),
                    HighValue = table.Column<double>(type: "REAL", nullable: false),
                    MeasuredValue = table.Column<double>(type: "REAL", nullable: false),
                    SampleModelId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LabTest", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LabTest_SampleModel_SampleModelId",
                        column: x => x.SampleModelId,
                        principalTable: "SampleModel",
                        principalColumn: "SampleModelId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_LabTest_SampleModelId",
                table: "LabTest",
                column: "SampleModelId");

            migrationBuilder.CreateIndex(
                name: "IX_SampleModel_ReportModelId",
                table: "SampleModel",
                column: "ReportModelId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LabTest");

            migrationBuilder.DropTable(
                name: "SampleModel");

            migrationBuilder.DropTable(
                name: "ReportModel");
        }
    }
}
