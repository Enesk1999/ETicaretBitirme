using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ETicaretWebUI.Migrations
{
    /// <inheritdoc />
    public partial class Initt : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categoriler",
                columns: new[] { "Id", "DisplayOrder", "Name" },
                values: new object[,]
                {
                    { 1, 1, "Aksiyon" },
                    { 2, 2, "Bilim-Kurgu" },
                    { 3, 3, "Tarih" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categoriler",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categoriler",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categoriler",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
