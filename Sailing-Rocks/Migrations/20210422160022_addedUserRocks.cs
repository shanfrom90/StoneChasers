using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Sailing_Rocks.Migrations
{
    public partial class addedUserRocks : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 1,
                column: "LocatedOn",
                value: new DateTime(2021, 4, 22, 12, 0, 21, 23, DateTimeKind.Local).AddTicks(7120));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 2,
                column: "LocatedOn",
                value: new DateTime(2021, 4, 22, 12, 0, 21, 23, DateTimeKind.Local).AddTicks(9860));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 3,
                column: "LocatedOn",
                value: new DateTime(2021, 4, 22, 12, 0, 21, 23, DateTimeKind.Local).AddTicks(9920));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 4,
                column: "LocatedOn",
                value: new DateTime(2021, 4, 22, 12, 0, 21, 23, DateTimeKind.Local).AddTicks(9926));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 5,
                column: "LocatedOn",
                value: new DateTime(2021, 4, 22, 12, 0, 21, 23, DateTimeKind.Local).AddTicks(9931));

            migrationBuilder.UpdateData(
                table: "Rocks",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2021, 4, 22, 12, 0, 21, 22, DateTimeKind.Local).AddTicks(9449));

            migrationBuilder.UpdateData(
                table: "Rocks",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2021, 4, 22, 12, 0, 21, 23, DateTimeKind.Local).AddTicks(2757));

            migrationBuilder.UpdateData(
                table: "Rocks",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2021, 4, 22, 12, 0, 21, 23, DateTimeKind.Local).AddTicks(2824));

            migrationBuilder.UpdateData(
                table: "Rocks",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2021, 4, 22, 12, 0, 21, 23, DateTimeKind.Local).AddTicks(2832));

            migrationBuilder.UpdateData(
                table: "UserRock",
                keyColumn: "Id",
                keyValue: 1,
                column: "UserId",
                value: 2);

            migrationBuilder.InsertData(
                table: "UserRock",
                columns: new[] { "Id", "RockId", "UserId" },
                values: new object[,]
                {
                    { 5, 4, 1 },
                    { 4, 4, 5 },
                    { 3, 3, 4 },
                    { 2, 2, 1 }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2021, 4, 22, 12, 0, 21, 16, DateTimeKind.Local).AddTicks(1394));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2021, 4, 22, 12, 0, 21, 20, DateTimeKind.Local).AddTicks(7278));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2021, 4, 22, 12, 0, 21, 20, DateTimeKind.Local).AddTicks(7346));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2021, 4, 22, 12, 0, 21, 20, DateTimeKind.Local).AddTicks(7353));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2021, 4, 22, 12, 0, 21, 20, DateTimeKind.Local).AddTicks(7363));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserRock",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "UserRock",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "UserRock",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "UserRock",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 1,
                column: "LocatedOn",
                value: new DateTime(2021, 4, 22, 11, 46, 51, 754, DateTimeKind.Local).AddTicks(4340));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 2,
                column: "LocatedOn",
                value: new DateTime(2021, 4, 22, 11, 46, 51, 754, DateTimeKind.Local).AddTicks(6913));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 3,
                column: "LocatedOn",
                value: new DateTime(2021, 4, 22, 11, 46, 51, 754, DateTimeKind.Local).AddTicks(6973));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 4,
                column: "LocatedOn",
                value: new DateTime(2021, 4, 22, 11, 46, 51, 754, DateTimeKind.Local).AddTicks(6980));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 5,
                column: "LocatedOn",
                value: new DateTime(2021, 4, 22, 11, 46, 51, 754, DateTimeKind.Local).AddTicks(6986));

            migrationBuilder.UpdateData(
                table: "Rocks",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2021, 4, 22, 11, 46, 51, 753, DateTimeKind.Local).AddTicks(8760));

            migrationBuilder.UpdateData(
                table: "Rocks",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2021, 4, 22, 11, 46, 51, 754, DateTimeKind.Local).AddTicks(1080));

            migrationBuilder.UpdateData(
                table: "Rocks",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2021, 4, 22, 11, 46, 51, 754, DateTimeKind.Local).AddTicks(1150));

            migrationBuilder.UpdateData(
                table: "Rocks",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2021, 4, 22, 11, 46, 51, 754, DateTimeKind.Local).AddTicks(1159));

            migrationBuilder.UpdateData(
                table: "UserRock",
                keyColumn: "Id",
                keyValue: 1,
                column: "UserId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2021, 4, 22, 11, 46, 51, 746, DateTimeKind.Local).AddTicks(5543));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2021, 4, 22, 11, 46, 51, 751, DateTimeKind.Local).AddTicks(1436));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2021, 4, 22, 11, 46, 51, 751, DateTimeKind.Local).AddTicks(1491));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2021, 4, 22, 11, 46, 51, 751, DateTimeKind.Local).AddTicks(1498));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2021, 4, 22, 11, 46, 51, 751, DateTimeKind.Local).AddTicks(1506));
        }
    }
}
