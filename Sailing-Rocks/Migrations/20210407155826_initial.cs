using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Sailing_Rocks.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    Image = table.Column<string>(nullable: true),
                    Hometown = table.Column<string>(nullable: true),
                    Bio = table.Column<string>(nullable: true),
                    UserName = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    CreatedOn = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Rocks",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Image = table.Column<string>(nullable: true),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    Serial = table.Column<string>(nullable: true),
                    UserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rocks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Rocks_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Locations",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Lat = table.Column<string>(nullable: true),
                    Lng = table.Column<string>(nullable: true),
                    RockId = table.Column<int>(nullable: false),
                    LocatedOn = table.Column<DateTime>(nullable: false),
                    IsCurrent = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Locations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Locations_Rocks_RockId",
                        column: x => x.RockId,
                        principalTable: "Rocks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserRock",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(nullable: false),
                    RockId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRock", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserRock_Rocks_RockId",
                        column: x => x.RockId,
                        principalTable: "Rocks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_UserRock_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Bio", "CreatedOn", "Email", "FirstName", "Hometown", "Image", "LastName", "Password", "UserName" },
                values: new object[] { 1, "Software Developer", new DateTime(2021, 4, 7, 11, 58, 25, 731, DateTimeKind.Local).AddTicks(165), "jkepic19@gmail.com", "Jason", "Parma, OH", "https://jak719.github.io/images/HS5.png", "Kepic", "password", "jak719" });

            migrationBuilder.InsertData(
                table: "Rocks",
                columns: new[] { "Id", "CreatedOn", "Image", "Name", "Serial", "UserId" },
                values: new object[] { 1, new DateTime(2021, 4, 7, 11, 58, 25, 739, DateTimeKind.Local).AddTicks(2660), "https://prowrestling.fandom.com/wiki/The_Rock", "Dwyane", "testSerial", 1 });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "Id", "IsCurrent", "Lat", "Lng", "LocatedOn", "RockId" },
                values: new object[] { 1, true, "41.52906515532968", "-81.65136941810817", new DateTime(2021, 4, 7, 11, 58, 25, 739, DateTimeKind.Local).AddTicks(9068), 1 });

            migrationBuilder.InsertData(
                table: "UserRock",
                columns: new[] { "Id", "RockId", "UserId" },
                values: new object[] { 1, 1, 1 });

            migrationBuilder.CreateIndex(
                name: "IX_Locations_RockId",
                table: "Locations",
                column: "RockId");

            migrationBuilder.CreateIndex(
                name: "IX_Rocks_UserId",
                table: "Rocks",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserRock_RockId",
                table: "UserRock",
                column: "RockId");

            migrationBuilder.CreateIndex(
                name: "IX_UserRock_UserId",
                table: "UserRock",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Locations");

            migrationBuilder.DropTable(
                name: "UserRock");

            migrationBuilder.DropTable(
                name: "Rocks");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
