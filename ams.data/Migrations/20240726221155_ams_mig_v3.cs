using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ams.data.Migrations
{
    /// <inheritdoc />
    public partial class ams_mig_v3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "_Month",
                table: "Debits",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "_Year",
                table: "Debits",
                type: "int",
                nullable: false,
                defaultValue: 0);

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
                columns: new[] { "ConcurrencyStamp", "CreateTime", "IsActive", "PasswordHash", "SecurityStamp" },
                values: new object[] { "034f2845-3e84-4afa-8d7b-be3e83cf5796", new DateTime(2024, 7, 27, 1, 11, 54, 882, DateTimeKind.Local).AddTicks(325), true, "AQAAAAIAAYagAAAAEHhKljIQaTrvyQFvs0Ho6PTLAelYeO1OXscVgNG1rWFLjsxXJoh/zqe7RepTtUTJ5w==", "22d820c4-6fce-43cc-8adf-6e30a4ab4e00" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("89da7c75-8291-4baf-9060-028a07393dde"),
                columns: new[] { "ConcurrencyStamp", "CreateTime", "IsActive", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4af73868-2dd7-41a7-bcd2-2905156c8d35", new DateTime(2024, 7, 27, 1, 11, 54, 917, DateTimeKind.Local).AddTicks(1333), true, "AQAAAAIAAYagAAAAEOgqeCGy5TdUDk7iq4Bod4aZE9YlYry7meOa2E88vl00AaSOSv1vI1O5sZR6RktdQQ==", "ac8015d9-1abb-4aee-8e31-5a42e729e195" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("a35a610d-689f-4ab4-9324-cc227bfdbfba"),
                columns: new[] { "ConcurrencyStamp", "CreateTime", "IsActive", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a7b43c10-a788-4876-a877-fa3398b65170", new DateTime(2024, 7, 27, 1, 11, 54, 952, DateTimeKind.Local).AddTicks(7081), true, "AQAAAAIAAYagAAAAELMwN70xAd/SDo5mKHLI+CQVtx4kCo4mfyoTOvO82EzXkX8VWjb9GpsVEnz/rlwOCg==", "a2eddb41-1fcb-49af-a721-e3b5b30ca556" });

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
                columns: new[] { "ApartmentId", "CreateTime" },
                values: new object[] { new Guid("16f885ff-6897-4d08-afa6-0640c40d2a05"), new DateTime(2024, 7, 27, 1, 11, 54, 988, DateTimeKind.Local).AddTicks(1236) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "_Month",
                table: "Debits");

            migrationBuilder.DropColumn(
                name: "_Year",
                table: "Debits");

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("db72e0e2-3201-414f-9753-190466e024f3"),
                column: "CreateTime",
                value: new DateTime(2024, 7, 22, 22, 24, 4, 932, DateTimeKind.Local).AddTicks(5161));

            migrationBuilder.UpdateData(
                table: "AdxMenus",
                keyColumn: "Id",
                keyValue: new Guid("a2b3d904-401c-431f-9845-7fa2652d87fc"),
                column: "CreateTime",
                value: new DateTime(2024, 7, 22, 22, 24, 4, 932, DateTimeKind.Local).AddTicks(5965));

            migrationBuilder.UpdateData(
                table: "Apartments",
                keyColumn: "Id",
                keyValue: new Guid("16f885ff-6897-4d08-afa6-0640c40d2a05"),
                column: "CreateTime",
                value: new DateTime(2024, 7, 22, 22, 24, 4, 932, DateTimeKind.Local).AddTicks(6513));

            migrationBuilder.UpdateData(
                table: "Apartments",
                keyColumn: "Id",
                keyValue: new Guid("d2977402-d13f-423f-bc0f-e639e4a610bb"),
                column: "CreateTime",
                value: new DateTime(2024, 7, 22, 22, 24, 4, 932, DateTimeKind.Local).AddTicks(6516));

            migrationBuilder.UpdateData(
                table: "Apartments",
                keyColumn: "Id",
                keyValue: new Guid("d4033eef-ba92-4a1f-9ecb-1eee6996214a"),
                column: "CreateTime",
                value: new DateTime(2024, 7, 22, 22, 24, 4, 932, DateTimeKind.Local).AddTicks(6508));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("051004f1-a383-4746-a722-3b051d12aaea"),
                column: "ConcurrencyStamp",
                value: "3120fc2a-41c0-4429-ab6e-373a7adad692");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("4271dd20-390a-46ce-b67d-59678a720270"),
                column: "ConcurrencyStamp",
                value: "1ec970f4-0921-4b96-950b-07ce4800bf17");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("4438dff4-28d6-46c1-90eb-f6b2a233d97e"),
                column: "ConcurrencyStamp",
                value: "bd698e0d-e0d5-4fe3-b3f3-893aef20da07");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("6fa95f6e-2516-49e8-9ae6-7745e7743dbf"),
                columns: new[] { "ConcurrencyStamp", "CreateTime", "IsActive", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4e646029-e817-4968-a19e-d590ef10cd50", new DateTime(2024, 7, 22, 22, 24, 4, 933, DateTimeKind.Local).AddTicks(8710), false, "AQAAAAIAAYagAAAAEMzaMuGikYAJHGYw31MbIF1mOrzBl6BNZVGy2JnuPlnEh+cWBlofmYh8imABWIh8tA==", "a8a7e896-7ff2-49ff-bc6d-c9feca75755c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("89da7c75-8291-4baf-9060-028a07393dde"),
                columns: new[] { "ConcurrencyStamp", "CreateTime", "IsActive", "PasswordHash", "SecurityStamp" },
                values: new object[] { "699e94f0-e53d-41f5-87a9-f2290d04380e", new DateTime(2024, 7, 22, 22, 24, 4, 969, DateTimeKind.Local).AddTicks(850), false, "AQAAAAIAAYagAAAAEIvNyFcME1MIEqX8QSw5jmCxrrFbobawuCTj1tzCNOBpKyAJHSP5Yyu17bgAR7FEKg==", "54c5a647-a7c2-4861-8fa3-1a51c06360a2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("a35a610d-689f-4ab4-9324-cc227bfdbfba"),
                columns: new[] { "ConcurrencyStamp", "CreateTime", "IsActive", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7be15d97-b3d5-4c1a-a152-d3ef399d4fc8", new DateTime(2024, 7, 22, 22, 24, 5, 5, DateTimeKind.Local).AddTicks(5441), false, "AQAAAAIAAYagAAAAEG5dv7FtraANsNsM6TvDkGYQ8lOBE8T+kvlMf2QHey8fI69tkTLNeyt5UB7GfO586Q==", "891bded2-1430-4bb5-9637-235f796c5c87" });

            migrationBuilder.UpdateData(
                table: "HousingSafes",
                keyColumn: "Id",
                keyValue: new Guid("666776f7-518b-4805-a726-eba238e03fc4"),
                column: "CreateTime",
                value: new DateTime(2024, 7, 22, 22, 24, 5, 42, DateTimeKind.Local).AddTicks(6799));

            migrationBuilder.UpdateData(
                table: "Housings",
                keyColumn: "Id",
                keyValue: new Guid("709a770b-66c6-4adc-bd19-6438117bf646"),
                columns: new[] { "ApartmentId", "CreateTime" },
                values: new object[] { new Guid("d4033eef-ba92-4a1f-9ecb-1eee6996214a"), new DateTime(2024, 7, 22, 22, 24, 5, 42, DateTimeKind.Local).AddTicks(6216) });
        }
    }
}
