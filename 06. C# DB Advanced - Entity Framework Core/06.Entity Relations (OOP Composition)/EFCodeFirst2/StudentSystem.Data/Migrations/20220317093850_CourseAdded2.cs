using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace StudentSystem.Data.Migrations
{
    public partial class CourseAdded2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "CourseId", "Description", "EndDate", "Name", "Price", "StartDate" },
                values: new object[] { 1, "Testing", new DateTime(2020, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Entity Framework", 0m, new DateTime(2020, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Resources",
                columns: new[] { "ResourceId", "CourseId", "Name", "ResourceType", "Url" },
                values: new object[] { 1, 1, "Presentation", 1, "www.studensystem.my/presentation" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Resources",
                keyColumn: "ResourceId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 1);
        }
    }
}
