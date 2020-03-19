using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CoV.DataAccess.Migrations
{
    public partial class mydaynew12 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CategoryProduct",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CategoryName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryProduct", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Classses",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ClassName = table.Column<string>(nullable: true),
                    ClassMember = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Classses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ColorProduct",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Color = table.Column<string>(type: "nvarchar(20)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ColorProduct", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Gender",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    GenderName = table.Column<string>(type: "nvarchar(30)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gender", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Role",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    RoleName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Role", x => x.Id);
                });

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

            migrationBuilder.CreateTable(
                name: "StatusProduct",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    status = table.Column<string>(type: "nvarchar(50)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StatusProduct", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Student",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    StudentMasv = table.Column<int>(nullable: false),
                    StudentName = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    StudentAvatar = table.Column<string>(nullable: true),
                    StudentAge = table.Column<int>(nullable: false),
                    StudentAddress = table.Column<string>(nullable: true),
                    ClasserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Student", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Student_Classses_ClasserId",
                        column: x => x.ClasserId,
                        principalTable: "Classses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserName = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    FirstDate = table.Column<DateTime>(nullable: true),
                    ExpiredDate = table.Column<DateTime>(nullable: true),
                    Request = table.Column<int>(nullable: true),
                    ImageAvatar = table.Column<string>(type: "nvarchar(200)", nullable: true),
                    RoleId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                    table.ForeignKey(
                        name: "FK_User_Role_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Role",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    Sku = table.Column<string>(type: "nvarchar(30)", nullable: true),
                    Price = table.Column<int>(nullable: false),
                    Evaluat = table.Column<int>(nullable: false),
                    FirstDate = table.Column<DateTime>(nullable: false),
                    Details = table.Column<string>(type: "nvarchar(500)", nullable: true),
                    AddressProduction = table.Column<string>(type: "nvarchar(200)", nullable: true),
                    AvatarDetails = table.Column<string>(nullable: true),
                    Number = table.Column<int>(nullable: false),
                    ColorProductId = table.Column<int>(nullable: false),
                    SizeProductId = table.Column<int>(nullable: false),
                    StatusProductId = table.Column<int>(nullable: false),
                    CategoryProductId = table.Column<int>(nullable: false),
                    GenderProductId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Product_CategoryProduct_CategoryProductId",
                        column: x => x.CategoryProductId,
                        principalTable: "CategoryProduct",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Product_ColorProduct_ColorProductId",
                        column: x => x.ColorProductId,
                        principalTable: "ColorProduct",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Product_Gender_GenderProductId",
                        column: x => x.GenderProductId,
                        principalTable: "Gender",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Product_SizeProduct_SizeProductId",
                        column: x => x.SizeProductId,
                        principalTable: "SizeProduct",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Product_StatusProduct_StatusProductId",
                        column: x => x.StatusProductId,
                        principalTable: "StatusProduct",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Product_CategoryProductId",
                table: "Product",
                column: "CategoryProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Product_ColorProductId",
                table: "Product",
                column: "ColorProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Product_GenderProductId",
                table: "Product",
                column: "GenderProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Product_SizeProductId",
                table: "Product",
                column: "SizeProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Product_StatusProductId",
                table: "Product",
                column: "StatusProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Student_ClasserId",
                table: "Student",
                column: "ClasserId");

            migrationBuilder.CreateIndex(
                name: "IX_User_RoleId",
                table: "User",
                column: "RoleId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropTable(
                name: "Student");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "CategoryProduct");

            migrationBuilder.DropTable(
                name: "ColorProduct");

            migrationBuilder.DropTable(
                name: "Gender");

            migrationBuilder.DropTable(
                name: "SizeProduct");

            migrationBuilder.DropTable(
                name: "StatusProduct");

            migrationBuilder.DropTable(
                name: "Classses");

            migrationBuilder.DropTable(
                name: "Role");
        }
    }
}
