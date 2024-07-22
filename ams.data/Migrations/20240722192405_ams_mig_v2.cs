using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ams.data.Migrations
{
    /// <inheritdoc />
    public partial class ams_mig_v2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "HousingSafeId",
                table: "Housings");

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
                columns: new[] { "ConcurrencyStamp", "CreateTime", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4e646029-e817-4968-a19e-d590ef10cd50", new DateTime(2024, 7, 22, 22, 24, 4, 933, DateTimeKind.Local).AddTicks(8710), "AQAAAAIAAYagAAAAEMzaMuGikYAJHGYw31MbIF1mOrzBl6BNZVGy2JnuPlnEh+cWBlofmYh8imABWIh8tA==", "a8a7e896-7ff2-49ff-bc6d-c9feca75755c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("89da7c75-8291-4baf-9060-028a07393dde"),
                columns: new[] { "ConcurrencyStamp", "CreateTime", "PasswordHash", "SecurityStamp" },
                values: new object[] { "699e94f0-e53d-41f5-87a9-f2290d04380e", new DateTime(2024, 7, 22, 22, 24, 4, 969, DateTimeKind.Local).AddTicks(850), "AQAAAAIAAYagAAAAEIvNyFcME1MIEqX8QSw5jmCxrrFbobawuCTj1tzCNOBpKyAJHSP5Yyu17bgAR7FEKg==", "54c5a647-a7c2-4861-8fa3-1a51c06360a2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("a35a610d-689f-4ab4-9324-cc227bfdbfba"),
                columns: new[] { "ConcurrencyStamp", "CreateTime", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7be15d97-b3d5-4c1a-a152-d3ef399d4fc8", new DateTime(2024, 7, 22, 22, 24, 5, 5, DateTimeKind.Local).AddTicks(5441), "AQAAAAIAAYagAAAAEG5dv7FtraANsNsM6TvDkGYQ8lOBE8T+kvlMf2QHey8fI69tkTLNeyt5UB7GfO586Q==", "891bded2-1430-4bb5-9637-235f796c5c87" });

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
                column: "CreateTime",
                value: new DateTime(2024, 7, 22, 22, 24, 5, 42, DateTimeKind.Local).AddTicks(6216));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "HousingSafeId",
                table: "Housings",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("db72e0e2-3201-414f-9753-190466e024f3"),
                column: "CreateTime",
                value: new DateTime(2024, 7, 22, 22, 20, 59, 221, DateTimeKind.Local).AddTicks(7013));

            migrationBuilder.UpdateData(
                table: "AdxMenus",
                keyColumn: "Id",
                keyValue: new Guid("a2b3d904-401c-431f-9845-7fa2652d87fc"),
                column: "CreateTime",
                value: new DateTime(2024, 7, 22, 22, 20, 59, 221, DateTimeKind.Local).AddTicks(7818));

            migrationBuilder.UpdateData(
                table: "Apartments",
                keyColumn: "Id",
                keyValue: new Guid("16f885ff-6897-4d08-afa6-0640c40d2a05"),
                column: "CreateTime",
                value: new DateTime(2024, 7, 22, 22, 20, 59, 221, DateTimeKind.Local).AddTicks(8320));

            migrationBuilder.UpdateData(
                table: "Apartments",
                keyColumn: "Id",
                keyValue: new Guid("d2977402-d13f-423f-bc0f-e639e4a610bb"),
                column: "CreateTime",
                value: new DateTime(2024, 7, 22, 22, 20, 59, 221, DateTimeKind.Local).AddTicks(8323));

            migrationBuilder.UpdateData(
                table: "Apartments",
                keyColumn: "Id",
                keyValue: new Guid("d4033eef-ba92-4a1f-9ecb-1eee6996214a"),
                column: "CreateTime",
                value: new DateTime(2024, 7, 22, 22, 20, 59, 221, DateTimeKind.Local).AddTicks(8315));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("051004f1-a383-4746-a722-3b051d12aaea"),
                column: "ConcurrencyStamp",
                value: "df3bfb58-a8e2-43c2-bb78-8e8bc87fe229");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("4271dd20-390a-46ce-b67d-59678a720270"),
                column: "ConcurrencyStamp",
                value: "8253b17a-4020-4316-bdf4-3b8c1586a037");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("4438dff4-28d6-46c1-90eb-f6b2a233d97e"),
                column: "ConcurrencyStamp",
                value: "65c3f4f1-74b7-4ace-85fe-824be00c82ad");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("6fa95f6e-2516-49e8-9ae6-7745e7743dbf"),
                columns: new[] { "ConcurrencyStamp", "CreateTime", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a9af99c8-9d06-480d-aa88-9edef90683ac", new DateTime(2024, 7, 22, 22, 20, 59, 223, DateTimeKind.Local).AddTicks(94), "AQAAAAIAAYagAAAAEMcnPMRfJywi4fXj+mUSHQNeWA+DVbaUGQA6LBnJqn0+b/7JKK1AbaNVvQRoZ9y0GQ==", "23e4277c-68d3-4600-b09d-9a3c0178ae56" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("89da7c75-8291-4baf-9060-028a07393dde"),
                columns: new[] { "ConcurrencyStamp", "CreateTime", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a057661c-8fcb-489c-94bf-8bc6bb3ae365", new DateTime(2024, 7, 22, 22, 20, 59, 259, DateTimeKind.Local).AddTicks(1991), "AQAAAAIAAYagAAAAEKke09yFgTvMub0FNzKM/eHpa9yFVeRWzskR7a+Issv5Zz5KxswNyEPOL1SK9N28JA==", "3f3ae7f3-9d40-4442-9efc-484dc59def02" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("a35a610d-689f-4ab4-9324-cc227bfdbfba"),
                columns: new[] { "ConcurrencyStamp", "CreateTime", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5ee725f0-37cf-45b2-9aa1-8a2e37eb5218", new DateTime(2024, 7, 22, 22, 20, 59, 294, DateTimeKind.Local).AddTicks(7622), "AQAAAAIAAYagAAAAEEsah1e+sEnWOFfoKsqPZlkSkkACUHA1Da44AZCTTY1yT68jPdtDIkTrNme22Kxsag==", "a0f1c979-a300-40d6-90eb-e18d09db45d7" });

            migrationBuilder.UpdateData(
                table: "HousingSafes",
                keyColumn: "Id",
                keyValue: new Guid("666776f7-518b-4805-a726-eba238e03fc4"),
                column: "CreateTime",
                value: new DateTime(2024, 7, 22, 22, 20, 59, 330, DateTimeKind.Local).AddTicks(4167));

            migrationBuilder.UpdateData(
                table: "Housings",
                keyColumn: "Id",
                keyValue: new Guid("709a770b-66c6-4adc-bd19-6438117bf646"),
                columns: new[] { "CreateTime", "HousingSafeId" },
                values: new object[] { new DateTime(2024, 7, 22, 22, 20, 59, 330, DateTimeKind.Local).AddTicks(3683), null });
        }
    }
}
