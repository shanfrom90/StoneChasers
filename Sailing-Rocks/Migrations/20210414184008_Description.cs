using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Sailing_Rocks.Migrations
{
    public partial class Description : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Rocks",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Comment", "LocatedOn", "LocationName" },
                values: new object[] { "10/10 Would pick up again.", new DateTime(2021, 4, 14, 14, 40, 7, 248, DateTimeKind.Local).AddTicks(2009), "Hollywood" });

            migrationBuilder.UpdateData(
                table: "Rocks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "Description" },
                values: new object[] { new DateTime(2021, 4, 14, 14, 40, 7, 247, DateTimeKind.Local).AddTicks(3966), "Sturdy and easy to find" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2021, 4, 14, 14, 40, 7, 238, DateTimeKind.Local).AddTicks(5993));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Rocks");

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Comment", "LocatedOn", "LocationName" },
                values: new object[] { null, new DateTime(2021, 4, 13, 13, 34, 58, 287, DateTimeKind.Local).AddTicks(1810), null });

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
    }
}
