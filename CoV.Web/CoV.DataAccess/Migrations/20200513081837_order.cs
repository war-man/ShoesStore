using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CoV.DataAccess.Migrations
{
    public partial class order : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Product_ColorProduct_ColorProductId",
                table: "Product");

            migrationBuilder.DropForeignKey(
                name: "FK_Product_StatusProduct_StatusProductId",
                table: "Product");

            migrationBuilder.DropIndex(
                name: "IX_Product_ColorProductId",
                table: "Product");

            migrationBuilder.DropIndex(
                name: "IX_Product_StatusProductId",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "ColorProductId",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "StatusProductId",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "ShipCode",
                table: "Order");

            migrationBuilder.AddColumn<int>(
                name: "PriceNew",
                table: "Product",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "OrderDetals",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NameCustomer = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<int>(nullable: false),
                    NameProduct = table.Column<string>(nullable: true),
                    NumberProduct = table.Column<int>(nullable: false),
                    Address = table.Column<string>(nullable: true),
                    TotalMoney = table.Column<int>(nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    EndDate = table.Column<DateTime>(nullable: true),
                    Shipper = table.Column<string>(nullable: true),
                    StatusId = table.Column<int>(nullable: false),
                    StatusOrderId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDetals", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderDetals_StatusOrder_StatusOrderId",
                        column: x => x.StatusOrderId,
                        principalTable: "StatusOrder",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProductDetails",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    SizeProduct = table.Column<int>(nullable: false),
                    NumberProduct = table.Column<int>(nullable: false),
                    AvatarDetails = table.Column<string>(nullable: true),
                    ProductId = table.Column<int>(nullable: false),
                    StatusProductId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductDetails_Product_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Product",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductDetails_StatusProduct_StatusProductId",
                        column: x => x.StatusProductId,
                        principalTable: "StatusProduct",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetals_StatusOrderId",
                table: "OrderDetals",
                column: "StatusOrderId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductDetails_ProductId",
                table: "ProductDetails",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductDetails_StatusProductId",
                table: "ProductDetails",
                column: "StatusProductId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrderDetals");

            migrationBuilder.DropTable(
                name: "ProductDetails");

            migrationBuilder.DropColumn(
                name: "PriceNew",
                table: "Product");

            migrationBuilder.AddColumn<int>(
                name: "ColorProductId",
                table: "Product",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "StatusProductId",
                table: "Product",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ShipCode",
                table: "Order",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Product_ColorProductId",
                table: "Product",
                column: "ColorProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Product_StatusProductId",
                table: "Product",
                column: "StatusProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_Product_ColorProduct_ColorProductId",
                table: "Product",
                column: "ColorProductId",
                principalTable: "ColorProduct",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Product_StatusProduct_StatusProductId",
                table: "Product",
                column: "StatusProductId",
                principalTable: "StatusProduct",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
