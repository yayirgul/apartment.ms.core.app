using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ams.data.Migrations
{
    /// <inheritdoc />
    public partial class ams_mig_v5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "HousingNo",
                table: "Housings",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("db72e0e2-3201-414f-9753-190466e024f3"),
                column: "CreateTime",
                value: new DateTime(2024, 7, 28, 1, 3, 26, 205, DateTimeKind.Local).AddTicks(4236));

            migrationBuilder.UpdateData(
                table: "AdxMenus",
                keyColumn: "Id",
                keyValue: new Guid("a2b3d904-401c-431f-9845-7fa2652d87fc"),
                column: "CreateTime",
                value: new DateTime(2024, 7, 28, 1, 3, 26, 205, DateTimeKind.Local).AddTicks(5104));

            migrationBuilder.UpdateData(
                table: "Apartments",
                keyColumn: "Id",
                keyValue: new Guid("16f885ff-6897-4d08-afa6-0640c40d2a05"),
                column: "CreateTime",
                value: new DateTime(2024, 7, 28, 1, 3, 26, 205, DateTimeKind.Local).AddTicks(5703));

            migrationBuilder.UpdateData(
                table: "Apartments",
                keyColumn: "Id",
                keyValue: new Guid("d2977402-d13f-423f-bc0f-e639e4a610bb"),
                column: "CreateTime",
                value: new DateTime(2024, 7, 28, 1, 3, 26, 205, DateTimeKind.Local).AddTicks(5706));

            migrationBuilder.UpdateData(
                table: "Apartments",
                keyColumn: "Id",
                keyValue: new Guid("d4033eef-ba92-4a1f-9ecb-1eee6996214a"),
                column: "CreateTime",
                value: new DateTime(2024, 7, 28, 1, 3, 26, 205, DateTimeKind.Local).AddTicks(5697));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("051004f1-a383-4746-a722-3b051d12aaea"),
                column: "ConcurrencyStamp",
                value: "3b2d61c1-6301-41c0-ab0c-db08f960b9fa");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("4271dd20-390a-46ce-b67d-59678a720270"),
                column: "ConcurrencyStamp",
                value: "b9f22e19-8f83-4429-b6d5-919da74e9e61");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("4438dff4-28d6-46c1-90eb-f6b2a233d97e"),
                column: "ConcurrencyStamp",
                value: "9720a71f-06c8-4a3f-af8c-2fdf3da51a4c");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("6fa95f6e-2516-49e8-9ae6-7745e7743dbf"),
                columns: new[] { "ConcurrencyStamp", "CreateTime", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8aa0a804-8d6a-4b7c-b773-597a41947228", new DateTime(2024, 7, 28, 1, 3, 26, 206, DateTimeKind.Local).AddTicks(6118), "AQAAAAIAAYagAAAAEFvOpCT2Q/rPVDgQesFCoo8X+DfjUUMmtK41RAknEajw/hbOfpibpumPlEzzqKWKVA==", "50bf8aa2-7490-4e2e-afdb-7731a3890443" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("89da7c75-8291-4baf-9060-028a07393dde"),
                columns: new[] { "ConcurrencyStamp", "CreateTime", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c7c26b15-2156-466d-8670-8d9f187ae2d8", new DateTime(2024, 7, 28, 1, 3, 26, 240, DateTimeKind.Local).AddTicks(4140), "AQAAAAIAAYagAAAAEDUeDxSAffO8mr6cjeZnBuE4h2MWSJI8cKmCfhKWCWRLN3WDJf6QuntMWlYqiT2Q3w==", "959604d6-67df-4d00-bb1a-3509af9f44b9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("a35a610d-689f-4ab4-9324-cc227bfdbfba"),
                columns: new[] { "ConcurrencyStamp", "CreateTime", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6d2ee7c8-bfb2-463a-be94-c66e4451eb29", new DateTime(2024, 7, 28, 1, 3, 26, 274, DateTimeKind.Local).AddTicks(1549), "AQAAAAIAAYagAAAAEOz1EE1CbSFI3OljLhbLR+VnjCAVtxQy4JCOtWU3+ecIdeKeurN7VO9Je+cvg7nV6g==", "c9960e1f-714a-478d-86bb-975f2b56f7a7" });

            migrationBuilder.UpdateData(
                table: "HousingSafes",
                keyColumn: "Id",
                keyValue: new Guid("666776f7-518b-4805-a726-eba238e03fc4"),
                column: "CreateTime",
                value: new DateTime(2024, 7, 28, 1, 3, 26, 309, DateTimeKind.Local).AddTicks(7387));

            migrationBuilder.UpdateData(
                table: "Housings",
                keyColumn: "Id",
                keyValue: new Guid("709a770b-66c6-4adc-bd19-6438117bf646"),
                columns: new[] { "CreateTime", "HousingNo" },
                values: new object[] { new DateTime(2024, 7, 28, 1, 3, 26, 309, DateTimeKind.Local).AddTicks(6941), 0 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "HousingNo",
                table: "Housings");

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("db72e0e2-3201-414f-9753-190466e024f3"),
                column: "CreateTime",
                value: new DateTime(2024, 7, 28, 0, 56, 3, 60, DateTimeKind.Local).AddTicks(5197));

            migrationBuilder.UpdateData(
                table: "AdxMenus",
                keyColumn: "Id",
                keyValue: new Guid("a2b3d904-401c-431f-9845-7fa2652d87fc"),
                column: "CreateTime",
                value: new DateTime(2024, 7, 28, 0, 56, 3, 60, DateTimeKind.Local).AddTicks(5960));

            migrationBuilder.UpdateData(
                table: "Apartments",
                keyColumn: "Id",
                keyValue: new Guid("16f885ff-6897-4d08-afa6-0640c40d2a05"),
                column: "CreateTime",
                value: new DateTime(2024, 7, 28, 0, 56, 3, 60, DateTimeKind.Local).AddTicks(6434));

            migrationBuilder.UpdateData(
                table: "Apartments",
                keyColumn: "Id",
                keyValue: new Guid("d2977402-d13f-423f-bc0f-e639e4a610bb"),
                column: "CreateTime",
                value: new DateTime(2024, 7, 28, 0, 56, 3, 60, DateTimeKind.Local).AddTicks(6436));

            migrationBuilder.UpdateData(
                table: "Apartments",
                keyColumn: "Id",
                keyValue: new Guid("d4033eef-ba92-4a1f-9ecb-1eee6996214a"),
                column: "CreateTime",
                value: new DateTime(2024, 7, 28, 0, 56, 3, 60, DateTimeKind.Local).AddTicks(6427));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("051004f1-a383-4746-a722-3b051d12aaea"),
                column: "ConcurrencyStamp",
                value: "fc474018-034e-4245-af15-9bec62beefd3");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("4271dd20-390a-46ce-b67d-59678a720270"),
                column: "ConcurrencyStamp",
                value: "afa91f3f-0059-415e-ba72-6e10ca1e4075");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("4438dff4-28d6-46c1-90eb-f6b2a233d97e"),
                column: "ConcurrencyStamp",
                value: "96639d5f-8a76-4d78-b6fd-d63da0aff9f0");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("6fa95f6e-2516-49e8-9ae6-7745e7743dbf"),
                columns: new[] { "ConcurrencyStamp", "CreateTime", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fcbf43f0-805c-4c76-ae99-946ff9f7b9b3", new DateTime(2024, 7, 28, 0, 56, 3, 61, DateTimeKind.Local).AddTicks(6171), "AQAAAAIAAYagAAAAEMkhkj8nOs5bo/tWcTwxtK3pdaV9Oydz60NIYIs7B0mNtGhUhesV6OLumvkQMeKzQQ==", "ea24c319-f66e-41ef-ac66-4bc68179a1a4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("89da7c75-8291-4baf-9060-028a07393dde"),
                columns: new[] { "ConcurrencyStamp", "CreateTime", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c734bbb7-0a31-4664-910f-10e86074c6c9", new DateTime(2024, 7, 28, 0, 56, 3, 98, DateTimeKind.Local).AddTicks(6777), "AQAAAAIAAYagAAAAEFQGv1Ra99M5/OWctci8+DB5WvYjGJ53AABbw8b7gqHH4lUyNrD0uqY+111YG7QV7Q==", "9e2edfaa-9fa5-470e-a3d0-2d0d4c2192f0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("a35a610d-689f-4ab4-9324-cc227bfdbfba"),
                columns: new[] { "ConcurrencyStamp", "CreateTime", "PasswordHash", "SecurityStamp" },
                values: new object[] { "68b116f6-72e1-4d2d-8ec5-6b9247ab8bb5", new DateTime(2024, 7, 28, 0, 56, 3, 135, DateTimeKind.Local).AddTicks(4875), "AQAAAAIAAYagAAAAEBXVoywqUSUbW3FuM2zYs1MGeRVwXU08+lXViytAXU8I54XNwrJ4PrYrm0fBGYhGCQ==", "ef79d871-d294-4c9f-a1e8-e36f2251fcaa" });

            migrationBuilder.UpdateData(
                table: "HousingSafes",
                keyColumn: "Id",
                keyValue: new Guid("666776f7-518b-4805-a726-eba238e03fc4"),
                column: "CreateTime",
                value: new DateTime(2024, 7, 28, 0, 56, 3, 174, DateTimeKind.Local).AddTicks(3930));

            migrationBuilder.UpdateData(
                table: "Housings",
                keyColumn: "Id",
                keyValue: new Guid("709a770b-66c6-4adc-bd19-6438117bf646"),
                column: "CreateTime",
                value: new DateTime(2024, 7, 28, 0, 56, 3, 171, DateTimeKind.Local).AddTicks(6293));
        }
    }
}
