using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ams.data.Migrations
{
    /// <inheritdoc />
    public partial class ams_mig_v4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Queue",
                table: "Debits",
                type: "int",
                nullable: false,
                defaultValue: 0);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Queue",
                table: "Debits");

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("db72e0e2-3201-414f-9753-190466e024f3"),
                column: "CreateTime",
                value: new DateTime(2024, 7, 27, 1, 11, 54, 880, DateTimeKind.Local).AddTicks(8537));

            migrationBuilder.UpdateData(
                table: "AdxMenus",
                keyColumn: "Id",
                keyValue: new Guid("a2b3d904-401c-431f-9845-7fa2652d87fc"),
                column: "CreateTime",
                value: new DateTime(2024, 7, 27, 1, 11, 54, 880, DateTimeKind.Local).AddTicks(9314));

            migrationBuilder.UpdateData(
                table: "Apartments",
                keyColumn: "Id",
                keyValue: new Guid("16f885ff-6897-4d08-afa6-0640c40d2a05"),
                column: "CreateTime",
                value: new DateTime(2024, 7, 27, 1, 11, 54, 880, DateTimeKind.Local).AddTicks(9810));

            migrationBuilder.UpdateData(
                table: "Apartments",
                keyColumn: "Id",
                keyValue: new Guid("d2977402-d13f-423f-bc0f-e639e4a610bb"),
                column: "CreateTime",
                value: new DateTime(2024, 7, 27, 1, 11, 54, 880, DateTimeKind.Local).AddTicks(9813));

            migrationBuilder.UpdateData(
                table: "Apartments",
                keyColumn: "Id",
                keyValue: new Guid("d4033eef-ba92-4a1f-9ecb-1eee6996214a"),
                column: "CreateTime",
                value: new DateTime(2024, 7, 27, 1, 11, 54, 880, DateTimeKind.Local).AddTicks(9804));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("051004f1-a383-4746-a722-3b051d12aaea"),
                column: "ConcurrencyStamp",
                value: "91d9b21f-4318-4da1-8671-bf912115f07b");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("4271dd20-390a-46ce-b67d-59678a720270"),
                column: "ConcurrencyStamp",
                value: "e9f93fdf-3e72-4bab-8a2b-33e2537da027");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("4438dff4-28d6-46c1-90eb-f6b2a233d97e"),
                column: "ConcurrencyStamp",
                value: "ffedeae0-54bd-409d-8587-1ae26fd8cc42");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("6fa95f6e-2516-49e8-9ae6-7745e7743dbf"),
                columns: new[] { "ConcurrencyStamp", "CreateTime", "PasswordHash", "SecurityStamp" },
                values: new object[] { "034f2845-3e84-4afa-8d7b-be3e83cf5796", new DateTime(2024, 7, 27, 1, 11, 54, 882, DateTimeKind.Local).AddTicks(325), "AQAAAAIAAYagAAAAEHhKljIQaTrvyQFvs0Ho6PTLAelYeO1OXscVgNG1rWFLjsxXJoh/zqe7RepTtUTJ5w==", "22d820c4-6fce-43cc-8adf-6e30a4ab4e00" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("89da7c75-8291-4baf-9060-028a07393dde"),
                columns: new[] { "ConcurrencyStamp", "CreateTime", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4af73868-2dd7-41a7-bcd2-2905156c8d35", new DateTime(2024, 7, 27, 1, 11, 54, 917, DateTimeKind.Local).AddTicks(1333), "AQAAAAIAAYagAAAAEOgqeCGy5TdUDk7iq4Bod4aZE9YlYry7meOa2E88vl00AaSOSv1vI1O5sZR6RktdQQ==", "ac8015d9-1abb-4aee-8e31-5a42e729e195" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("a35a610d-689f-4ab4-9324-cc227bfdbfba"),
                columns: new[] { "ConcurrencyStamp", "CreateTime", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a7b43c10-a788-4876-a877-fa3398b65170", new DateTime(2024, 7, 27, 1, 11, 54, 952, DateTimeKind.Local).AddTicks(7081), "AQAAAAIAAYagAAAAELMwN70xAd/SDo5mKHLI+CQVtx4kCo4mfyoTOvO82EzXkX8VWjb9GpsVEnz/rlwOCg==", "a2eddb41-1fcb-49af-a721-e3b5b30ca556" });

            migrationBuilder.UpdateData(
                table: "HousingSafes",
                keyColumn: "Id",
                keyValue: new Guid("666776f7-518b-4805-a726-eba238e03fc4"),
                column: "CreateTime",
                value: new DateTime(2024, 7, 27, 1, 11, 54, 988, DateTimeKind.Local).AddTicks(1711));

            migrationBuilder.UpdateData(
                table: "Housings",
                keyColumn: "Id",
                keyValue: new Guid("709a770b-66c6-4adc-bd19-6438117bf646"),
                column: "CreateTime",
                value: new DateTime(2024, 7, 27, 1, 11, 54, 988, DateTimeKind.Local).AddTicks(1236));
        }
    }
}
