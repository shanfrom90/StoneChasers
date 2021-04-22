using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Sailing_Rocks.Migrations
{
    public partial class updatedSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Lat", "Lng", "LocatedOn", "LocationImage", "LocationName" },
                values: new object[] { "41.363528", "-81.851403", new DateTime(2021, 4, 22, 11, 35, 59, 485, DateTimeKind.Local).AddTicks(2858), "https://photos.google.com/share/AF1QipMhD_8LIwkZJi6zkrublKRvVAfR6pP_QzzISOJYEd5qQanOsON2k9dJG1wZE7MKwQ/photo/AF1QipPR6G51JPiOSqyPFzoNebXCkKurIbJdLcrrSZGZ?key=MXJhTHFJdXgyUDM4ZXZ1YWlCcVBDaEVoTC0wLThR", "Coe Lake" });

            migrationBuilder.UpdateData(
                table: "Rocks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "Description", "Image", "Name", "Serial" },
                values: new object[] { new DateTime(2021, 4, 22, 11, 35, 59, 484, DateTimeKind.Local).AddTicks(7635), "Some folks don't believe in this rock, but I do.", "https://lh3.googleusercontent.com/pw/ACtC-3cNYh8lnJbZ-hcw9MxMrem_I3IZvFSCjylLUGKFgLk0rkPRWb9kI0rZGTNCppqzqO07AxRTlQYMlo7DDuCc2ddOioH-nY3Duj88aVYqnfz4XJs3I6kY6_uBFAEhlsIAKMPRg5LaA2mJBJUPIZBm_xk=w470-h626-no?authuser=0", "Rock Ness", "BCDF2346" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "Email" },
                values: new object[] { new DateTime(2021, 4, 22, 11, 35, 59, 477, DateTimeKind.Local).AddTicks(2829), "jak719@gmail.com" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Bio", "CreatedOn", "Email", "FirstName", "Hometown", "Image", "LastName", "Password", "UserName" },
                values: new object[,]
                {
                    { 2, "Software Developer", new DateTime(2021, 4, 22, 11, 35, 59, 482, DateTimeKind.Local).AddTicks(9432), "efaler@gmail.com", "Eric", "Fairview Park, OH", "https://emfaler.github.io/images/WCCI%20Headshot.jpg", "Faler", "123456", "efaler" },
                    { 3, "Avid Hiker", new DateTime(2021, 4, 22, 11, 35, 59, 482, DateTimeKind.Local).AddTicks(9550), "shanfrom90@gmail.com", "Shannon", "Cincinnati, OH", "https://avatars.githubusercontent.com/u/77690999?v=4", "Adams", "123456", "shanfrom90" },
                    { 4, "Fitness Fiend", new DateTime(2021, 4, 22, 11, 35, 59, 482, DateTimeKind.Local).AddTicks(9560), "tiahC@gmail.com", "Tiah", "Cleveland, OH", "https://media-exp1.licdn.com/dms/image/C4E03AQEIQiWhliy2Uw/profile-displayphoto-shrink_200_200/0/1614008492988?e=1624492800&v=beta&t=fravB8yvb_-EhFKcCa9e8KRIhPM870Zj2oFxVC7f_oc", "Campbell", "123456", "tiahRocks" },
                    { 5, "Artist", new DateTime(2021, 4, 22, 11, 35, 59, 482, DateTimeKind.Local).AddTicks(9566), "JE@gmail.com", "JE", "Cincinnati, OH", "https://media-exp1.licdn.com/dms/image/C4D03AQEw1N-X8JU9UA/profile-displayphoto-shrink_800_800/0/1614220067971?e=1624492800&v=beta&t=ZE3FWkoIKxRSyILQMOHsTh9omgK954adSnB9zgT2iac", "Woods", "123456", "jeXex" }
                });

            migrationBuilder.InsertData(
                table: "Rocks",
                columns: new[] { "Id", "CreatedOn", "Description", "Image", "Name", "Serial", "UserId" },
                values: new object[] { 2, new DateTime(2021, 4, 22, 11, 35, 59, 484, DateTimeKind.Local).AddTicks(9881), "Love always wins!", "https://lh3.googleusercontent.com/pw/ACtC-3ek5FZPxYzihecIhMnfaY9hviSskhDJu7bMVUSBmoD2M7wy6EWutdNzmiOBzsxYrhHEDQ_R3-ydbQOGB5WRYZU_9wNnzVIqYmqjf1KvVHKVDlZY5wWFJw7qgETjkkqEdp4a4uOdzVyLz89-abhejTc=w470-h626-no?authuser=0", "Love", "BCDH2346", 2 });

            migrationBuilder.InsertData(
                table: "Rocks",
                columns: new[] { "Id", "CreatedOn", "Description", "Image", "Name", "Serial", "UserId" },
                values: new object[] { 3, new DateTime(2021, 4, 22, 11, 35, 59, 484, DateTimeKind.Local).AddTicks(9935), "Make a Wish", "https://photos.google.com/share/AF1QipMhD_8LIwkZJi6zkrublKRvVAfR6pP_QzzISOJYEd5qQanOsON2k9dJG1wZE7MKwQ/photo/AF1QipPMjVBXxBRCw4HyfvFWsV-c-NVrAZFmpjW8mMMx?key=MXJhTHFJdXgyUDM4ZXZ1YWlCcVBDaEVoTC0wLThR", "Dandelion", "BCDG2346", 3 });

            migrationBuilder.InsertData(
                table: "Rocks",
                columns: new[] { "Id", "CreatedOn", "Description", "Image", "Name", "Serial", "UserId" },
                values: new object[] { 4, new DateTime(2021, 4, 22, 11, 35, 59, 484, DateTimeKind.Local).AddTicks(9941), "Make a Wish", "https://photos.google.com/share/AF1QipMhD_8LIwkZJi6zkrublKRvVAfR6pP_QzzISOJYEd5qQanOsON2k9dJG1wZE7MKwQ/photo/AF1QipO8TrpRxfaoVT4Z99darKiTUWsgKEG00bf_tCS_?key=MXJhTHFJdXgyUDM4ZXZ1YWlCcVBDaEVoTC0wLThR", "Heart You", "BCDP2346", 4 });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "Id", "Comment", "Lat", "Lng", "LocatedOn", "LocationImage", "LocationName", "RockId" },
                values: new object[,]
                {
                    { 2, "Love on the earth!", "41.435258", "81.845719", new DateTime(2021, 4, 22, 11, 35, 59, 485, DateTimeKind.Local).AddTicks(5049), "https://photos.google.com/share/AF1QipMhD_8LIwkZJi6zkrublKRvVAfR6pP_QzzISOJYEd5qQanOsON2k9dJG1wZE7MKwQ/photo/AF1QipNokLXM5SutasZZ7cCEGVrSmikvBT57hwKrIwKO?key=MXJhTHFJdXgyUDM4ZXZ1YWlCcVBDaEVoTC0wLThR", "Rocky River Reservation", 2 },
                    { 3, "This made my day!", "41.486700", "-81.902125", new DateTime(2021, 4, 22, 11, 35, 59, 485, DateTimeKind.Local).AddTicks(5101), "https://photos.google.com/share/AF1QipMhD_8LIwkZJi6zkrublKRvVAfR6pP_QzzISOJYEd5qQanOsON2k9dJG1wZE7MKwQ/photo/AF1QipPxFGu4C5ysbdjGZHHcX-hkE225bt1IuHSrh2F8?key=MXJhTHFJdXgyUDM4ZXZ1YWlCcVBDaEVoTC0wLThR", "Lake Erie", 3 },
                    { 4, "I love this rock so much!", "41.29424235787053", "-82.15200988091138", new DateTime(2021, 4, 22, 11, 35, 59, 485, DateTimeKind.Local).AddTicks(5107), "https://lh3.googleusercontent.com/pw/ACtC-3cSZgugu_nTsn7kUufw-G_IVKSFqePIMPbDHiA7n5XlatblZTQhLaZH0y0CVtTXtcMP69i564m_UZFcTyOH16HeUPTOR_u_cWBH3Ta-MI4c5NFmaDzRmH2w1rXNizvehZgSNgkG6-ZfkVCsNuDV3ws=w470-h626-no?authuser=0", "Carlisle Reservation", 4 },
                    { 5, "Love for everyone!", "41.3639780269892", "-81.85258535965691", new DateTime(2021, 4, 22, 11, 35, 59, 485, DateTimeKind.Local).AddTicks(5112), "https://lh3.googleusercontent.com/pw/ACtC-3dT4hvboHaq__uup5U6KvGq-vLMJXuilNM__lLUxFKh_X3uxGGj_i0oggaxRy5ahPekWJ1xYsZUf0t1laVPtjaVt1DpINz1Hy_ZN5UJBfm_jHJrWXRUHaoJFonmy9LdnLRAW8RCmTyCaSSaEFstfDg=w470-h626-no?authuser=0", "Coe Lake", 4 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Rocks",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Rocks",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Rocks",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Lat", "Lng", "LocatedOn", "LocationImage", "LocationName" },
                values: new object[] { "41.52906515532968", "-81.65136941810817", new DateTime(2021, 4, 21, 11, 13, 12, 64, DateTimeKind.Local).AddTicks(1774), "https://media-cdn.tripadvisor.com/media/photo-s/14/61/c4/4f/lighthouse-at-headlands.jpg", "Hollywood" });

            migrationBuilder.UpdateData(
                table: "Rocks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "Description", "Image", "Name", "Serial" },
                values: new object[] { new DateTime(2021, 4, 21, 11, 13, 12, 63, DateTimeKind.Local).AddTicks(5253), "Sturdy and easy to find", "https://thumbs.dreamstime.com/b/dwayne-johnson-80711565.jpg", "Dwyane", "testSerial" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "Email" },
                values: new object[] { new DateTime(2021, 4, 21, 11, 13, 12, 54, DateTimeKind.Local).AddTicks(445), "jkepic19@gmail.com" });
        }
    }
}
