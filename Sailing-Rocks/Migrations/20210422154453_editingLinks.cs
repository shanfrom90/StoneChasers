using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Sailing_Rocks.Migrations
{
    public partial class editingLinks : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "LocatedOn", "LocationImage" },
                values: new object[] { new DateTime(2021, 4, 22, 11, 44, 52, 263, DateTimeKind.Local).AddTicks(6281), "https://lh3.googleusercontent.com/pw/ACtC-3cNYh8lnJbZ-hcw9MxMrem_I3IZvFSCjylLUGKFgLk0rkPRWb9kI0rZGTNCppqzqO07AxRTlQYMlo7DDuCc2ddOioH-nY3Duj88aVYqnfz4XJs3I6kY6_uBFAEhlsIAKMPRg5LaA2mJBJUPIZBm_xk=w470-h626-no?authuser=0" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "LocatedOn", "LocationImage" },
                values: new object[] { new DateTime(2021, 4, 22, 11, 44, 52, 268, DateTimeKind.Local).AddTicks(4001), "https://lh3.googleusercontent.com/pw/ACtC-3fuuUDOXHlU4ZrfXr9wGBCA0e2goOoEd9dTcfaiAxCEAQO68FH_-JpNXUMHNHxsX-IFyL4gfpbbveiY0wRi8HdaGc7nZ-HCNIEUexgyA6owdsvudev5E8mJSCY4JuvwSdfgDQH0UThEMhQOq-OF09c=w470-h626-no?authuser=0" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "LocatedOn", "LocationImage" },
                values: new object[] { new DateTime(2021, 4, 22, 11, 44, 52, 268, DateTimeKind.Local).AddTicks(4153), "https://lh3.googleusercontent.com/pw/ACtC-3cVXz2OU6RmroM460EY_88XA7tnBzeS82uuPOnOEZalDAuX_odTJGbS60FYyIut8-lzRNL58IB6CQsm4-_CNUlUhzWdjMxssOLZciDG31f0-LUOCWMT3Bk6W8d8hWDyZkYoAZ5I267Cf4gQEHUjaWVa=w470-h626-no?authuser=0" });

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
                column: "CreatedOn",
                value: new DateTime(2021, 4, 22, 11, 44, 52, 262, DateTimeKind.Local).AddTicks(346));

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "LocatedOn", "LocationImage" },
                values: new object[] { new DateTime(2021, 4, 22, 11, 42, 20, 307, DateTimeKind.Local).AddTicks(2761), "https://photos.google.com/share/AF1QipMhD_8LIwkZJi6zkrublKRvVAfR6pP_QzzISOJYEd5qQanOsON2k9dJG1wZE7MKwQ/photo/AF1QipPR6G51JPiOSqyPFzoNebXCkKurIbJdLcrrSZGZ?key=MXJhTHFJdXgyUDM4ZXZ1YWlCcVBDaEVoTC0wLThR" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "LocatedOn", "LocationImage" },
                values: new object[] { new DateTime(2021, 4, 22, 11, 42, 20, 307, DateTimeKind.Local).AddTicks(5090), "https://photos.google.com/share/AF1QipMhD_8LIwkZJi6zkrublKRvVAfR6pP_QzzISOJYEd5qQanOsON2k9dJG1wZE7MKwQ/photo/AF1QipNokLXM5SutasZZ7cCEGVrSmikvBT57hwKrIwKO?key=MXJhTHFJdXgyUDM4ZXZ1YWlCcVBDaEVoTC0wLThR" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "LocatedOn", "LocationImage" },
                values: new object[] { new DateTime(2021, 4, 22, 11, 42, 20, 307, DateTimeKind.Local).AddTicks(5138), "https://photos.google.com/share/AF1QipMhD_8LIwkZJi6zkrublKRvVAfR6pP_QzzISOJYEd5qQanOsON2k9dJG1wZE7MKwQ/photo/AF1QipPxFGu4C5ysbdjGZHHcX-hkE225bt1IuHSrh2F8?key=MXJhTHFJdXgyUDM4ZXZ1YWlCcVBDaEVoTC0wLThR" });

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
                column: "CreatedOn",
                value: new DateTime(2021, 4, 22, 11, 42, 20, 306, DateTimeKind.Local).AddTicks(9503));

            migrationBuilder.UpdateData(
                table: "Rocks",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2021, 4, 22, 11, 42, 20, 306, DateTimeKind.Local).AddTicks(9510));

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
    }
}
