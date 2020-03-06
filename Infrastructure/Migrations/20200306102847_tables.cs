using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Migrations
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
                values: new object[] { 1, "Berkay", new DateTime(2020, 3, 6, 13, 28, 46, 834, DateTimeKind.Local).AddTicks(5631), "Berkay", null, "Project1" });

            migrationBuilder.InsertData(
                table: "Project",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "ModifiedBy", "ModifiedDate", "ProjectName" },
                values: new object[] { 2, "Berkay", new DateTime(2020, 3, 6, 13, 28, 46, 838, DateTimeKind.Local).AddTicks(1150), "Berkay", null, "Project2" });

            migrationBuilder.InsertData(
                table: "WebApps",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "ModifiedBy", "ModifiedDate", "ProjectId", "WebAppType", "WebAppUrl" },
                values: new object[] { 1, "Berkay", new DateTime(2020, 3, 6, 13, 28, 46, 837, DateTimeKind.Local).AddTicks(6614), null, null, 1, (byte)1, "www.google.com.tr/" });

            migrationBuilder.InsertData(
                table: "WebApps",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "ModifiedBy", "ModifiedDate", "ProjectId", "WebAppType", "WebAppUrl" },
                values: new object[] { 2, "Berkay", new DateTime(2020, 3, 6, 13, 28, 46, 838, DateTimeKind.Local).AddTicks(1186), null, null, 2, (byte)1, "www.google.com.tr/" });

            migrationBuilder.InsertData(
                table: "WebAppDetails",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "ModifiedBy", "ModifiedDate", "WebAppAltUrl", "WebAppId" },
                values: new object[,]
                {
                    { 1, "Berkay", new DateTime(2020, 3, 6, 13, 28, 46, 837, DateTimeKind.Local).AddTicks(9710), null, null, "www.google.com.tr/altUrl1", 1 },
                    { 2, "Berkay", new DateTime(2020, 3, 6, 13, 28, 46, 838, DateTimeKind.Local).AddTicks(1043), null, null, "www.google.com.tr/altUrl2", 1 },
                    { 3, "Berkay", new DateTime(2020, 3, 6, 13, 28, 46, 838, DateTimeKind.Local).AddTicks(1088), null, null, "www.google.com.tr/altUrl3", 1 },
                    { 4, "Berkay", new DateTime(2020, 3, 6, 13, 28, 46, 838, DateTimeKind.Local).AddTicks(1233), null, null, "www.google.com.tr/altUrl1", 2 },
                    { 5, "Berkay", new DateTime(2020, 3, 6, 13, 28, 46, 838, DateTimeKind.Local).AddTicks(1255), null, null, "www.google.com.tr/altUrl2", 2 },
                    { 6, "Berkay", new DateTime(2020, 3, 6, 13, 28, 46, 838, DateTimeKind.Local).AddTicks(1279), null, null, "www.google.com.tr/altUrl3", 2 }
                });

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
