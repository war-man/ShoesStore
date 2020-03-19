using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CoV.DataAccess.Migrations
{
    public partial class product1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Product_SizeProduct_SizeProductId",
                table: "Product");

            migrationBuilder.DropTable(
                name: "SizeProduct");

            migrationBuilder.DropColumn(
                name: "Evaluat",
                table: "Product");

            migrationBuilder.RenameColumn(
                name: "SizeProductId",
                table: "Product",
                newName: "MakerProductId");

            migrationBuilder.RenameIndex(
                name: "IX_Product_SizeProductId",
                table: "Product",
                newName: "IX_Product_MakerProductId");

            migrationBuilder.CreateTable(
                name: "MakerProduct",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    MakerName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MakerProduct", x => x.Id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Product_MakerProduct_MakerProductId",
                table: "Product",
                column: "MakerProductId",
                principalTable: "MakerProduct",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Product_MakerProduct_MakerProductId",
                table: "Product");

            migrationBuilder.DropTable(
                name: "MakerProduct");

            migrationBuilder.RenameColumn(
                name: "MakerProductId",
                table: "Product",
                newName: "SizeProductId");

            migrationBuilder.RenameIndex(
                name: "IX_Product_MakerProductId",
                table: "Product",
                newName: "IX_Product_SizeProductId");

            migrationBuilder.AddColumn<int>(
                name: "Evaluat",
                table: "Product",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "SizeProduct",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Size = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SizeProduct", x => x.Id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Product_SizeProduct_SizeProductId",
                table: "Product",
                column: "SizeProductId",
                principalTable: "SizeProduct",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
