using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SchoolAPI.Migrations
{
    public partial class InitialData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Organizations",
                columns: table => new
                {
                    OrganizationId = table.Column<Guid>(nullable: false),
                    OrgName = table.Column<string>(maxLength: 60, nullable: false),
                    City = table.Column<string>(nullable: true),
                    Country = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Organizations", x => x.OrganizationId);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<Guid>(nullable: false),
                    UserName = table.Column<string>(maxLength: 30, nullable: false),
                    OrganizationId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                    table.ForeignKey(
                        name: "FK_Users_Organizations_OrganizationId",
                        column: x => x.OrganizationId,
                        principalTable: "Organizations",
                        principalColumn: "OrganizationId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Organizations",
                columns: new[] { "OrganizationId", "City", "Country", "OrgName" },
                values: new object[,]
                {
                    { new Guid("c9d4c053-49b6-410c-bc78-2d54a9991870"), "Jersey City", "USA", "xyz com" },
                    { new Guid("3d490a70-94ce-4d15-9494-5248280c2ce3"), "Monmouth", "USA", "test com" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "OrganizationId", "UserName" },
                values: new object[,]
                {
                    { new Guid("b3369db6-5446-4b01-973a-239d92410d1a"), new Guid("744a27da-2697-4dda-808d-6b939aca820a"), "vishalt" },
                    { new Guid("b8c00ca8-8914-4494-b60d-f380f44963ae"), new Guid("9795535a-c109-4b2f-8a64-27f94c2f1399"), "vdt535" },
                    { new Guid("3bbb929a-1b10-4e3f-b837-1a2a0024f8fa"), new Guid("e9019be7-30c8-4189-a6cf-94a7ecc74a84"), "vdt534" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Users_OrganizationId",
                table: "Users",
                column: "OrganizationId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Organizations");
        }
    }
}
