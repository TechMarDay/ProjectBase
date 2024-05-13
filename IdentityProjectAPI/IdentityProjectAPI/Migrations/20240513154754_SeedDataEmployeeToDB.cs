using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace IdentityProjectAPI.Migrations
{
    /// <inheritdoc />
    public partial class SeedDataEmployeeToDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "Age", "Name", "Position" },
                values: new object[,]
                {
                    { new Guid("398d10fe-4b8d-4606-8e9c-bd2c78d4e001"), 29, "Anna Simmons", "Software Developer" },
                    { new Guid("e310a6cb-6677-4aa6-93c7-2763956f7a97"), 26, "Mark Miens", "Software Developer" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("398d10fe-4b8d-4606-8e9c-bd2c78d4e001"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("e310a6cb-6677-4aa6-93c7-2763956f7a97"));
        }
    }
}
