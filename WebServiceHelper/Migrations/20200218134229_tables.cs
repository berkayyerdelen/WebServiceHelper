using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebServiceHelper.Migrations
{
    public partial class tables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Project",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedBy = table.Column<string>(nullable: true),
                    ModifiedBy = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: true),
                    ModifiedDate = table.Column<DateTime>(nullable: true),
                    ProjectName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Project", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WebApps",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedBy = table.Column<string>(nullable: true),
                    ModifiedBy = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: true),
                    ModifiedDate = table.Column<DateTime>(nullable: true),
                    WebAppUrl = table.Column<string>(nullable: true),
                    ProjectId = table.Column<int>(nullable: false),
                    WebAppType = table.Column<byte>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WebApps", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WebApps_Project_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "Project",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WebAppDetails",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedBy = table.Column<string>(nullable: true),
                    ModifiedBy = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: true),
                    ModifiedDate = table.Column<DateTime>(nullable: true),
                    WebAppAltUrl = table.Column<string>(nullable: true),
                    WebAppId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WebAppDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WebAppDetails_WebApps_WebAppId",
                        column: x => x.WebAppId,
                        principalTable: "WebApps",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Project",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "ModifiedBy", "ModifiedDate", "ProjectName" },
                values: new object[] { 1, "Berkay", new DateTime(2020, 2, 18, 16, 42, 28, 368, DateTimeKind.Local).AddTicks(2689), "Berkay", null, "Project1" });

            migrationBuilder.InsertData(
                table: "WebApps",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "ModifiedBy", "ModifiedDate", "ProjectId", "WebAppType", "WebAppUrl" },
                values: new object[] { 1, "Berkay", new DateTime(2020, 2, 18, 16, 42, 28, 370, DateTimeKind.Local).AddTicks(5037), null, null, 1, (byte)1, "www.google.com.tr/" });

            migrationBuilder.InsertData(
                table: "WebAppDetails",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "ModifiedBy", "ModifiedDate", "WebAppAltUrl", "WebAppId" },
                values: new object[] { 1, "Berkay", new DateTime(2020, 2, 18, 16, 42, 28, 370, DateTimeKind.Local).AddTicks(9167), null, null, "www.google.com.tr/altUrl1", 1 });

            migrationBuilder.InsertData(
                table: "WebAppDetails",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "ModifiedBy", "ModifiedDate", "WebAppAltUrl", "WebAppId" },
                values: new object[] { 2, "Berkay", new DateTime(2020, 2, 18, 16, 42, 28, 371, DateTimeKind.Local).AddTicks(902), null, null, "www.google.com.tr/altUrl2", 1 });

            migrationBuilder.InsertData(
                table: "WebAppDetails",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "ModifiedBy", "ModifiedDate", "WebAppAltUrl", "WebAppId" },
                values: new object[] { 3, "Berkay", new DateTime(2020, 2, 18, 16, 42, 28, 371, DateTimeKind.Local).AddTicks(958), null, null, "www.google.com.tr/altUrl3", 1 });

            migrationBuilder.CreateIndex(
                name: "IX_WebAppDetails_WebAppId",
                table: "WebAppDetails",
                column: "WebAppId");

            migrationBuilder.CreateIndex(
                name: "IX_WebApps_ProjectId",
                table: "WebApps",
                column: "ProjectId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "WebAppDetails");

            migrationBuilder.DropTable(
                name: "WebApps");

            migrationBuilder.DropTable(
                name: "Project");
        }
    }
}
