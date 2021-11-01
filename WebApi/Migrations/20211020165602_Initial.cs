using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApi.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    ThumbnailImage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_products_categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Điện thoại" },
                    { 2, "Laptop" },
                    { 3, "Tablet" },
                    { 4, "Phụ kiện" },
                    { 5, "Đồng hồ thông minh" },
                    { 6, "Đồng hồ thời trang" },
                    { 7, "PC, Máy in" }
                });

            migrationBuilder.InsertData(
                table: "products",
                columns: new[] { "Id", "CategoryId", "DateCreated", "Description", "Name", "Price", "ThumbnailImage" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2021, 10, 20, 23, 56, 2, 351, DateTimeKind.Local).AddTicks(6528), null, "Điện thoại Samsung Galaxy Z Fold3 5G 512GB ", 43990000m, "https://cdn.tgdd.vn/Products/Images/42/248284/Slider/samsung-galaxy-z-fold-3-slider-tong-quan-1020x570.jpg" },
                    { 2, 2, new DateTime(2021, 10, 20, 23, 56, 2, 352, DateTimeKind.Local).AddTicks(3448), null, "Laptop Apple MacBook Air M1 2020 16GB/512GB/7-core GPU", 37490000m, "https://cdn.tgdd.vn/Products/Images/44/243952/apple-macbook-air-m1-2020-z12a00050-1-org.jpg" },
                    { 3, 3, new DateTime(2021, 10, 20, 23, 56, 2, 352, DateTimeKind.Local).AddTicks(3480), null, "Máy tính bảng Huawei MatePad 11", 13490000m, "https://cdn.tgdd.vn/Products/Images/522/241299/huawei-matepad-11-xam-1.jpg" },
                    { 4, 4, new DateTime(2021, 10, 20, 23, 56, 2, 352, DateTimeKind.Local).AddTicks(3495), null, "Tai nghe Bluetooth AirPods 2 Apple MV7N2 ", 2990000m, "https://cdn.tgdd.vn/Products/Images/54/236016/bluetooth-airpods-2-apple-mv7n2-imei-1-org.jpg" },
                    { 5, 5, new DateTime(2021, 10, 20, 23, 56, 2, 352, DateTimeKind.Local).AddTicks(3508), null, "Apple Watch S6 40mm viền nhôm dây cao su", 9592000m, "https://cdn.tgdd.vn/Products/Images/7077/229044/apple-watch-s6-40mm-vien-nhom-day-cao-su-hong-cont-1-org.jpg" },
                    { 6, 6, new DateTime(2021, 10, 20, 23, 56, 2, 352, DateTimeKind.Local).AddTicks(3524), null, "Đồng hồ Nữ Esprit ES1L286P0025", 4200000m, "https://cdn.tgdd.vn/Products/Images/7264/250504/esprit-es1l286p0025-nu-1-org.jpg" },
                    { 7, 7, new DateTime(2021, 10, 20, 23, 56, 2, 352, DateTimeKind.Local).AddTicks(3537), null, "Máy In laser Trắng Đen Brother HL L2321D", 3490000m, "https://cdn.tgdd.vn/Products/Images/5693/115902/may-in-laser-brother-hl-l2321d-23-600x600.jpg" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_products_CategoryId",
                table: "products",
                column: "CategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "products");

            migrationBuilder.DropTable(
                name: "categories");
        }
    }
}
