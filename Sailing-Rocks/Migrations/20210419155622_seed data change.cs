using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Sailing_Rocks.Migrations
{
    public partial class seeddatachange : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 1,
                column: "LocatedOn",
                value: new DateTime(2021, 4, 19, 11, 56, 21, 854, DateTimeKind.Local).AddTicks(5931));

            migrationBuilder.UpdateData(
                table: "Rocks",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2021, 4, 19, 11, 56, 21, 854, DateTimeKind.Local).AddTicks(668));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2021, 4, 19, 11, 56, 21, 846, DateTimeKind.Local).AddTicks(9075));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 1,
                column: "LocatedOn",
                value: new DateTime(2021, 4, 15, 14, 15, 14, 916, DateTimeKind.Local).AddTicks(1675));

            migrationBuilder.UpdateData(
                table: "Rocks",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2021, 4, 15, 14, 15, 14, 915, DateTimeKind.Local).AddTicks(3232));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2021, 4, 15, 14, 15, 14, 908, DateTimeKind.Local).AddTicks(500));
        }
    }
}
