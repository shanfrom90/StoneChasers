using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Sailing_Rocks.Migrations
{
    public partial class edit1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 1,
                column: "LocatedOn",
                value: new DateTime(2021, 4, 22, 11, 42, 20, 307, DateTimeKind.Local).AddTicks(2761));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 2,
                column: "LocatedOn",
                value: new DateTime(2021, 4, 22, 11, 42, 20, 307, DateTimeKind.Local).AddTicks(5090));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 3,
                column: "LocatedOn",
                value: new DateTime(2021, 4, 22, 11, 42, 20, 307, DateTimeKind.Local).AddTicks(5138));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 4,
                column: "LocatedOn",
                value: new DateTime(2021, 4, 22, 11, 42, 20, 307, DateTimeKind.Local).AddTicks(5144));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 5,
                column: "LocatedOn",
                value: new DateTime(2021, 4, 22, 11, 42, 20, 307, DateTimeKind.Local).AddTicks(5150));

            migrationBuilder.UpdateData(
                table: "Rocks",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2021, 4, 22, 11, 42, 20, 306, DateTimeKind.Local).AddTicks(6782));

            migrationBuilder.UpdateData(
                table: "Rocks",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2021, 4, 22, 11, 42, 20, 306, DateTimeKind.Local).AddTicks(9442));

            migrationBuilder.UpdateData(
                table: "Rocks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "Image" },
                values: new object[] { new DateTime(2021, 4, 22, 11, 42, 20, 306, DateTimeKind.Local).AddTicks(9503), "https://lh3.googleusercontent.com/pw/ACtC-3ft7a2r_EJqEd2LvYmbRRYQmq4uFXDdGKZ9akut1XTqk7u_RWRaFD0c4CU-c1qQEI-3_eGD3ftiwIQHJqllRX8vBIZSdj8I-vr7RVOVNAHVsNeTqG7Qn1g6diCJ8MGO0cKpUvAyqkMtnwRXu_aVAG8=w470-h626-no?authuser=0" });

            migrationBuilder.UpdateData(
                table: "Rocks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedOn", "Image" },
                values: new object[] { new DateTime(2021, 4, 22, 11, 42, 20, 306, DateTimeKind.Local).AddTicks(9510), "https://lh3.googleusercontent.com/pw/ACtC-3fCsuURb-SEfSvRvxctcRMhJvuFkZj2ENeNCcNKldagp9WcOz-v9lmfzz3D7SDsR7hMNS7-cnOES8OSSZINyaIkSeBZ5NfIxWcPh0-83YnaqGCWJLNg8qRvPTIKBqRUN3k35ena3xYfd1KLcCHqtEg=w470-h626-no?authuser=0" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2021, 4, 22, 11, 42, 20, 299, DateTimeKind.Local).AddTicks(5877));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2021, 4, 22, 11, 42, 20, 304, DateTimeKind.Local).AddTicks(4978));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2021, 4, 22, 11, 42, 20, 304, DateTimeKind.Local).AddTicks(5038));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2021, 4, 22, 11, 42, 20, 304, DateTimeKind.Local).AddTicks(5046));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2021, 4, 22, 11, 42, 20, 304, DateTimeKind.Local).AddTicks(5053));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 1,
                column: "LocatedOn",
                value: new DateTime(2021, 4, 22, 11, 35, 59, 485, DateTimeKind.Local).AddTicks(2858));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 2,
                column: "LocatedOn",
                value: new DateTime(2021, 4, 22, 11, 35, 59, 485, DateTimeKind.Local).AddTicks(5049));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 3,
                column: "LocatedOn",
                value: new DateTime(2021, 4, 22, 11, 35, 59, 485, DateTimeKind.Local).AddTicks(5101));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 4,
                column: "LocatedOn",
                value: new DateTime(2021, 4, 22, 11, 35, 59, 485, DateTimeKind.Local).AddTicks(5107));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 5,
                column: "LocatedOn",
                value: new DateTime(2021, 4, 22, 11, 35, 59, 485, DateTimeKind.Local).AddTicks(5112));

            migrationBuilder.UpdateData(
                table: "Rocks",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2021, 4, 22, 11, 35, 59, 484, DateTimeKind.Local).AddTicks(7635));

            migrationBuilder.UpdateData(
                table: "Rocks",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2021, 4, 22, 11, 35, 59, 484, DateTimeKind.Local).AddTicks(9881));

            migrationBuilder.UpdateData(
                table: "Rocks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "Image" },
                values: new object[] { new DateTime(2021, 4, 22, 11, 35, 59, 484, DateTimeKind.Local).AddTicks(9935), "https://photos.google.com/share/AF1QipMhD_8LIwkZJi6zkrublKRvVAfR6pP_QzzISOJYEd5qQanOsON2k9dJG1wZE7MKwQ/photo/AF1QipPMjVBXxBRCw4HyfvFWsV-c-NVrAZFmpjW8mMMx?key=MXJhTHFJdXgyUDM4ZXZ1YWlCcVBDaEVoTC0wLThR" });

            migrationBuilder.UpdateData(
                table: "Rocks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedOn", "Image" },
                values: new object[] { new DateTime(2021, 4, 22, 11, 35, 59, 484, DateTimeKind.Local).AddTicks(9941), "https://photos.google.com/share/AF1QipMhD_8LIwkZJi6zkrublKRvVAfR6pP_QzzISOJYEd5qQanOsON2k9dJG1wZE7MKwQ/photo/AF1QipO8TrpRxfaoVT4Z99darKiTUWsgKEG00bf_tCS_?key=MXJhTHFJdXgyUDM4ZXZ1YWlCcVBDaEVoTC0wLThR" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2021, 4, 22, 11, 35, 59, 477, DateTimeKind.Local).AddTicks(2829));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2021, 4, 22, 11, 35, 59, 482, DateTimeKind.Local).AddTicks(9432));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2021, 4, 22, 11, 35, 59, 482, DateTimeKind.Local).AddTicks(9550));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2021, 4, 22, 11, 35, 59, 482, DateTimeKind.Local).AddTicks(9560));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2021, 4, 22, 11, 35, 59, 482, DateTimeKind.Local).AddTicks(9566));
        }
    }
}
