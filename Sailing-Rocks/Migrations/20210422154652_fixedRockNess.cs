using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Sailing_Rocks.Migrations
{
    public partial class fixedRockNess : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                columns: new[] { "CreatedOn", "Image" },
                values: new object[] { new DateTime(2021, 4, 22, 11, 46, 51, 753, DateTimeKind.Local).AddTicks(8760), "https://lh3.googleusercontent.com/pw/ACtC-3cf5OCoKweRgXmgpS1KMLb4OCgF-rUtKZ6gLvw8YQnih2e77W0lg6nLfuRimF9Slg7cRBfmqj3VR1qiSDaiEgZJqX2Xt6u5XPMfcwAjPfgYlIbo62_Xk-vBb-Y6JXkNgVtNTdp7xsgFiOooaxV-im0=w835-h626-no?authuser=0" });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 1,
                column: "LocatedOn",
                value: new DateTime(2021, 4, 22, 11, 44, 52, 263, DateTimeKind.Local).AddTicks(6281));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 2,
                column: "LocatedOn",
                value: new DateTime(2021, 4, 22, 11, 44, 52, 268, DateTimeKind.Local).AddTicks(4001));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 3,
                column: "LocatedOn",
                value: new DateTime(2021, 4, 22, 11, 44, 52, 268, DateTimeKind.Local).AddTicks(4153));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 4,
                column: "LocatedOn",
                value: new DateTime(2021, 4, 22, 11, 44, 52, 268, DateTimeKind.Local).AddTicks(4162));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 5,
                column: "LocatedOn",
                value: new DateTime(2021, 4, 22, 11, 44, 52, 268, DateTimeKind.Local).AddTicks(4169));

            migrationBuilder.UpdateData(
                table: "Rocks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "Image" },
                values: new object[] { new DateTime(2021, 4, 22, 11, 44, 52, 262, DateTimeKind.Local).AddTicks(346), "https://lh3.googleusercontent.com/pw/ACtC-3cNYh8lnJbZ-hcw9MxMrem_I3IZvFSCjylLUGKFgLk0rkPRWb9kI0rZGTNCppqzqO07AxRTlQYMlo7DDuCc2ddOioH-nY3Duj88aVYqnfz4XJs3I6kY6_uBFAEhlsIAKMPRg5LaA2mJBJUPIZBm_xk=w470-h626-no?authuser=0" });

            migrationBuilder.UpdateData(
                table: "Rocks",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2021, 4, 22, 11, 44, 52, 262, DateTimeKind.Local).AddTicks(3869));

            migrationBuilder.UpdateData(
                table: "Rocks",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2021, 4, 22, 11, 44, 52, 262, DateTimeKind.Local).AddTicks(3952));

            migrationBuilder.UpdateData(
                table: "Rocks",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2021, 4, 22, 11, 44, 52, 262, DateTimeKind.Local).AddTicks(3964));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2021, 4, 22, 11, 44, 52, 249, DateTimeKind.Local).AddTicks(1644));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2021, 4, 22, 11, 44, 52, 255, DateTimeKind.Local).AddTicks(6827));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2021, 4, 22, 11, 44, 52, 255, DateTimeKind.Local).AddTicks(6906));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2021, 4, 22, 11, 44, 52, 255, DateTimeKind.Local).AddTicks(6963));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2021, 4, 22, 11, 44, 52, 255, DateTimeKind.Local).AddTicks(6971));
        }
    }
}
