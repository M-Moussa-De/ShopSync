using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ShopSync.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BriefDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<long>(type: "bigint", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Brand = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    Createdat = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updatedat = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Brand", "BriefDescription", "Createdat", "Description", "Image", "IsActive", "Name", "Price", "Quantity", "Updatedat" },
                values: new object[,]
                {
                    { new Guid("0d5f358c-bcae-4ced-86ce-80127337ede3"), "Test Brand 2", "Brief desc for 2nd product", new DateTime(2024, 3, 9, 22, 12, 12, 438, DateTimeKind.Utc).AddTicks(4957), "This is the 2nd product's description", "test/path/to/product2/img", true, "Product two", 150000L, 90, new DateTime(2024, 3, 9, 22, 12, 12, 438, DateTimeKind.Utc).AddTicks(4957) },
                    { new Guid("4998c71b-c3cc-4e97-ba5e-6fa28e9b3be7"), "Test Brand", "Brief desc for 3rd product", new DateTime(2024, 3, 9, 22, 12, 12, 438, DateTimeKind.Utc).AddTicks(4960), "This is the 3red product's description", "test/path/to/product3/img", true, "Product three", 175000L, 177, new DateTime(2024, 3, 9, 22, 12, 12, 438, DateTimeKind.Utc).AddTicks(4960) },
                    { new Guid("57a1d6a5-1df6-4b8c-826b-267adeb0c05a"), "Test Brand 1", "Brief desc for 1st product", new DateTime(2024, 3, 9, 22, 12, 12, 438, DateTimeKind.Utc).AddTicks(4937), "This is the 1st product's description", "test/path/to/product1/img", true, "Product one", 100000L, 100, new DateTime(2024, 3, 9, 22, 12, 12, 438, DateTimeKind.Utc).AddTicks(4938) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
