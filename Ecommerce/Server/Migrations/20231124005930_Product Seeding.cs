using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Ecommerce.Server.Migrations
{
    /// <inheritdoc />
    public partial class ProductSeeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageURL", "Price", "Title" },
                values: new object[,]
                {
                    { 1, "Description test", "https://upload.wikimedia.org/wikipedia/commons/thumb/0/08/Rolex_Submariner_Professional.JPG/1280px-Rolex_Submariner_Professional.JPG", 9.99m, "Title Test" },
                    { 2, "Description2", "https://upload.wikimedia.org/wikipedia/commons/6/67/RolexDaytona.jpg", 3.99m, "Watch2" },
                    { 3, "Description3", "https://upload.wikimedia.org/wikipedia/commons/thumb/f/f9/Spring-cover_pocket_clock3_open_clockface2.jpg/1200px-Spring-cover_pocket_clock3_open_clockface2.jpg", 4.99m, "Watch3" }
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

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
