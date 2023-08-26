using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TrialProjectMVC.Migrations
{
    /// <inheritdoc />
    public partial class SeedPhoneTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "PhoneId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "PhoneId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "PhoneId",
                keyValue: 7);

            migrationBuilder.InsertData(
                table: "Phone",
                columns: new[] { "PhoneId", "Address", "Phone" },
                values: new object[,]
                {
                    { 1, "Istanbul", "123123123" },
                    { 2, "Ankara", "3123123" },
                    { 3, "Izmir", "23123123" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "PhoneId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "PhoneId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "PhoneId",
                keyValue: 3);

            migrationBuilder.InsertData(
                table: "Phone",
                columns: new[] { "PhoneId", "Address", "Phone" },
                values: new object[,]
                {
                    { 5, "Istanbul", "123123123" },
                    { 6, "Ankara", "3123123" },
                    { 7, "Izmir", "23123123" }
                });
        }
    }
}
