using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Sailing_Rocks.Migrations
{
    public partial class Added_LocationImage_Updated_RockImage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsCurrent",
                table: "Locations");

            migrationBuilder.AddColumn<string>(
                name: "LocationImage",
                table: "Locations",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "LocatedOn", "LocationImage" },
                values: new object[] { new DateTime(2021, 4, 9, 10, 40, 47, 587, DateTimeKind.Local).AddTicks(6074), "https://media-cdn.tripadvisor.com/media/photo-s/14/61/c4/4f/lighthouse-at-headlands.jpg" });

            migrationBuilder.UpdateData(
                table: "Rocks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "Image" },
                values: new object[] { new DateTime(2021, 4, 9, 10, 40, 47, 587, DateTimeKind.Local).AddTicks(1341), "https://thumbs.dreamstime.com/b/dwayne-johnson-80711565.jpg" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2021, 4, 9, 10, 40, 47, 580, DateTimeKind.Local).AddTicks(2788));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LocationImage",
                table: "Locations");

            migrationBuilder.AddColumn<bool>(
                name: "IsCurrent",
                table: "Locations",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "IsCurrent", "LocatedOn" },
                values: new object[] { true, new DateTime(2021, 4, 7, 11, 58, 25, 739, DateTimeKind.Local).AddTicks(9068) });

            migrationBuilder.UpdateData(
                table: "Rocks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "Image" },
                values: new object[] { new DateTime(2021, 4, 7, 11, 58, 25, 739, DateTimeKind.Local).AddTicks(2660), "https://prowrestling.fandom.com/wiki/The_Rock" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2021, 4, 7, 11, 58, 25, 731, DateTimeKind.Local).AddTicks(165));
        }
    }
}
