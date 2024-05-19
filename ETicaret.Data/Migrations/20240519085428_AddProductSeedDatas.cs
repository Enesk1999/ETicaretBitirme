using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ETicaretWebUI.Migrations
{
    /// <inheritdoc />
    public partial class AddProductSeedDatas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Author", "Description", "ISBN", "ListPrice", "Price", "Price100", "Price50", "Title" },
                values: new object[,]
                {
                    { 1, "WEET8998", "Kumaş Baggy Pantolon İndigo ST00122-Siyah", "ST00122-Siyah", 550.99000000000001, 529.99000000000001, 500.0, 509.99000000000001, "Kumaş Baggy Pantolon" },
                    { 2, "STRE6655", "Studios Ltd. United Kingdom Oversize T-Shirt Beyaz", "ST00275-Beyaz", 449.99000000000001, 429.99000000000001, 400.0, 410.99000000000001, "United Kingdom Oversize" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
