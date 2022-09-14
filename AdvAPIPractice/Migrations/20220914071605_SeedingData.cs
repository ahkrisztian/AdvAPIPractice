using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AdvAPIPractice.Migrations
{
    public partial class SeedingData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Advertisements",
                columns: new[] { "Id", "AdvertiserId", "Description", "ImageURL", "Size" },
                values: new object[,]
                {
                    { 1, 1, "iron hammer big", "https://", "S" },
                    { 2, 1, "iron hammer small", "https://", "M" },
                    { 3, 1, "plastic hammer big", "https://", "L" },
                    { 4, 2, "metal umbrella cube", "https://", "M" }
                });

            migrationBuilder.InsertData(
                table: "Advertisers",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Bauhaus" },
                    { 2, "Praktiker" }
                });

            migrationBuilder.InsertData(
                table: "SizeLookUp",
                columns: new[] { "Code", "Description", "Height", "SizeType", "Width" },
                values: new object[,]
                {
                    { "L", "Large", 200, 2, 200 },
                    { "M", "Medium", 100, 1, 100 },
                    { "S", "Small", 50, 0, 50 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Advertisements",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Advertisements",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Advertisements",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Advertisements",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Advertisers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Advertisers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "SizeLookUp",
                keyColumn: "Code",
                keyValue: "L");

            migrationBuilder.DeleteData(
                table: "SizeLookUp",
                keyColumn: "Code",
                keyValue: "M");

            migrationBuilder.DeleteData(
                table: "SizeLookUp",
                keyColumn: "Code",
                keyValue: "S");
        }
    }
}
