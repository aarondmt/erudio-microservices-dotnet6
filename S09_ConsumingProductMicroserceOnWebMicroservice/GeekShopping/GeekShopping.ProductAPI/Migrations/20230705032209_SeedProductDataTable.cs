using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GeekShopping.ProductAPI.Migrations
{
    public partial class SeedProductDataTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "product",
                columns: new[] { "id", "category_name", "description", "image_url", "name", "price" },
                values: new object[,]
                {
                    { 2L, "T-shirt", "DESCRIPTION RANDON", "https://github.com/aarondmt/erudio-microservices-dotnet6/blob/main/ShoppingImages/13_dragon_ball.jpg", "Camiseta Dragon Ball", 4.43497054235638m },
                    { 3L, "T-shirt", "DESCRIPTION RANDON", "https://github.com/aarondmt/erudio-microservices-dotnet6/blob/main/ShoppingImages/6_spacex.jpg", "Camiseta Elon Musck Sapcex", 76.4343530996706m },
                    { 4L, "T-shirt", "DESCRIPTION RANDON", "https://github.com/aarondmt/erudio-microservices-dotnet6/blob/main/ShoppingImages/12_gnu_linux.jpg", "Camiseta GNU Linux", 14.3897763189883m },
                    { 5L, "T-shirt", "DESCRIPTION RANDON", "https://github.com/aarondmt/erudio-microservices-dotnet6/blob/main/ShoppingImages/11_mars.jpg", "Camista Mars", 30.1453785911202m },
                    { 6L, "T-shirt", "DESCRIPTION RANDON", "https://github.com/aarondmt/erudio-microservices-dotnet6/blob/main/ShoppingImages/5_100_gamer.jpg", "Camiseta Gamer", 75.0869692488494m }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 6L);
        }
    }
}
