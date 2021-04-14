using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Sailing_Rocks.Migrations
{
    public partial class removedReview : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Review");

            migrationBuilder.AddColumn<string>(
                name: "Comment",
                table: "Locations",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LocationName",
                table: "Locations",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 1,
                column: "LocatedOn",
                value: new DateTime(2021, 4, 13, 13, 34, 58, 287, DateTimeKind.Local).AddTicks(1810));

            migrationBuilder.UpdateData(
                table: "Rocks",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2021, 4, 13, 13, 34, 58, 286, DateTimeKind.Local).AddTicks(6891));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2021, 4, 13, 13, 34, 58, 278, DateTimeKind.Local).AddTicks(7944));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Comment",
                table: "Locations");

            migrationBuilder.DropColumn(
                name: "LocationName",
                table: "Locations");

            migrationBuilder.CreateTable(
                name: "Review",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RockId = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Review", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Review_Rocks_RockId",
                        column: x => x.RockId,
                        principalTable: "Rocks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 1,
                column: "LocatedOn",
                value: new DateTime(2021, 4, 13, 11, 46, 52, 885, DateTimeKind.Local).AddTicks(4527));

            migrationBuilder.InsertData(
                table: "Review",
                columns: new[] { "Id", "Content", "RockId", "Title" },
                values: new object[] { 1, "We found a rock.", 1, "Sturdy" });

            migrationBuilder.UpdateData(
                table: "Rocks",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2021, 4, 13, 11, 46, 52, 885, DateTimeKind.Local).AddTicks(5));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2021, 4, 13, 11, 46, 52, 877, DateTimeKind.Local).AddTicks(6580));

            migrationBuilder.CreateIndex(
                name: "IX_Review_RockId",
                table: "Review",
                column: "RockId");
        }
    }
}
