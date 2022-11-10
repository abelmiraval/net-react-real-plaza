using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RealPlaza.DataAccess.Migrations
{
    public partial class InitMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Status = table.Column<bool>(nullable: false, defaultValue: true),
                    CreatedAt = table.Column<DateTime>(nullable: false, defaultValueSql: "GETDATE()"),
                    Name = table.Column<string>(maxLength: 100, nullable: false),
                    Description = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Status = table.Column<bool>(nullable: false, defaultValue: true),
                    CreatedAt = table.Column<DateTime>(nullable: false, defaultValueSql: "GETDATE()"),
                    Name = table.Column<string>(maxLength: 100, nullable: false),
                    Price = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    Avatar = table.Column<string>(nullable: false),
                    CategoryId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[] { 1, "Televisores", "Televisores" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[] { 2, "Laptop", "Laptop" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[] { 3, "Celulares", "Celulares" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Avatar", "CategoryId", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "https://realplaza.vtexassets.com/arquivos/ids/19952643-800-auto?v=637787185990700000&width=800&height=auto&aspect=true", 1, "Televisor SAMSUNG LED 70' Ultra HD / 4K Smart", 1000m },
                    { 4, "https://realplaza.vtexassets.com/arquivos/ids/16669049-800-auto?v=637583552723330000&width=800&height=auto&aspect=true", 1, "Televisor Sony 4K HDR Processor X1 65", 1000m },
                    { 7, "https://realplaza.vtexassets.com/arquivos/ids/30794966-800-auto?v=638019917577870000&width=800&height=auto&aspect=true", 1, "Televisor Samsung Smart TV 65' Crystal UHD 4K", 1000m },
                    { 10, "https://realplaza.vtexassets.com/arquivos/ids/29471812-800-auto?v=637934066359800000&width=800&height=auto&aspect=true", 1, "Apple MacBook Pro con M1 Max Chip", 1000m },
                    { 2, "https://realplaza.vtexassets.com/arquivos/ids/29355975-800-auto?v=637926621748600000&width=800&height=auto&aspect=true", 2, "Laptop TUF GAMING 8GB RAM 512GB SSD", 5000m },
                    { 5, "https://realplaza.vtexassets.com/arquivos/ids/18614998-300-auto?v=637769274914830000&width=300&height=auto&aspect=true", 2, "Laptop MAC M2 16GB RAM 512GB SSD", 6000m },
                    { 8, "https://realplaza.vtexassets.com/arquivos/ids/17871602-800-auto?v=637738853647470000&width=800&height=auto&aspect=true", 2, "Netbook LENOVO D330-10IGL 32GB RAM 512GB SSD", 7000m },
                    { 3, "https://realplaza.vtexassets.com/arquivos/ids/30749072-800-auto?v=638016157038870000&width=800&height=auto&aspect=true", 3, "Motorola Moto G9 Power RAM 4GB 128GB Azul", 2000m },
                    { 6, "https://realplaza.vtexassets.com/arquivos/ids/17895992-800-auto?v=637741743708070000&width=800&height=auto&aspect=true", 3, "Impresora Multifuncional Epson L3210 Ecotank", 2000m },
                    { 9, "https://realplaza.vtexassets.com/arquivos/ids/29754680-800-auto?v=637953073800630000&width=800&height=auto&aspect=true", 3, "Parlante bluetooth JBL Party Box 710 potencia 800W RMS", 2000m }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
