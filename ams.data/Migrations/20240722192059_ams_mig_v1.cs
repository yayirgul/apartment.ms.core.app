using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ams.data.Migrations
{
    /// <inheritdoc />
    public partial class ams_mig_v1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HousingSafes_Housings_HousingId",
                table: "HousingSafes");

            migrationBuilder.DropIndex(
                name: "IX_HousingSafes_HousingId",
                table: "HousingSafes");

            migrationBuilder.AddColumn<Guid>(
                name: "HousingSafe",
                table: "Housings",
                type: "uniqueidentifier",
                nullable: true);

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
                columns: new[] { "CreateTime", "CreateUser", "HousingSafe", "HousingSafeId" },
                values: new object[] { new DateTime(2024, 7, 22, 22, 20, 59, 330, DateTimeKind.Local).AddTicks(3683), new Guid("6fa95f6e-2516-49e8-9ae6-7745e7743dbf"), null, null });

            migrationBuilder.CreateIndex(
                name: "IX_Housings_HousingSafe",
                table: "Housings",
                column: "HousingSafe",
                unique: true,
                filter: "[HousingSafe] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Housings_HousingSafes_HousingSafe",
                table: "Housings",
                column: "HousingSafe",
                principalTable: "HousingSafes",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Housings_HousingSafes_HousingSafe",
                table: "Housings");

            migrationBuilder.DropIndex(
                name: "IX_Housings_HousingSafe",
                table: "Housings");

            migrationBuilder.DropColumn(
                name: "HousingSafe",
                table: "Housings");

            migrationBuilder.DropColumn(
                name: "HousingSafeId",
                table: "Housings");

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("db72e0e2-3201-414f-9753-190466e024f3"),
                column: "CreateTime",
                value: new DateTime(2024, 7, 22, 20, 37, 42, 511, DateTimeKind.Local).AddTicks(5054));

            migrationBuilder.UpdateData(
                table: "AdxMenus",
                keyColumn: "Id",
                keyValue: new Guid("a2b3d904-401c-431f-9845-7fa2652d87fc"),
                column: "CreateTime",
                value: new DateTime(2024, 7, 22, 20, 37, 42, 511, DateTimeKind.Local).AddTicks(5788));

            migrationBuilder.UpdateData(
                table: "Apartments",
                keyColumn: "Id",
                keyValue: new Guid("16f885ff-6897-4d08-afa6-0640c40d2a05"),
                column: "CreateTime",
                value: new DateTime(2024, 7, 22, 20, 37, 42, 511, DateTimeKind.Local).AddTicks(6284));

            migrationBuilder.UpdateData(
                table: "Apartments",
                keyColumn: "Id",
                keyValue: new Guid("d2977402-d13f-423f-bc0f-e639e4a610bb"),
                column: "CreateTime",
                value: new DateTime(2024, 7, 22, 20, 37, 42, 511, DateTimeKind.Local).AddTicks(6286));

            migrationBuilder.UpdateData(
                table: "Apartments",
                keyColumn: "Id",
                keyValue: new Guid("d4033eef-ba92-4a1f-9ecb-1eee6996214a"),
                column: "CreateTime",
                value: new DateTime(2024, 7, 22, 20, 37, 42, 511, DateTimeKind.Local).AddTicks(6277));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("051004f1-a383-4746-a722-3b051d12aaea"),
                column: "ConcurrencyStamp",
                value: "b90e39b6-ec70-4260-8c58-062b42cbe2f3");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("4271dd20-390a-46ce-b67d-59678a720270"),
                column: "ConcurrencyStamp",
                value: "6119d03b-7930-4955-a28e-e95ec04f322b");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("4438dff4-28d6-46c1-90eb-f6b2a233d97e"),
                column: "ConcurrencyStamp",
                value: "e8dc9981-052c-41a6-99c6-0dac40c332bd");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("6fa95f6e-2516-49e8-9ae6-7745e7743dbf"),
                columns: new[] { "ConcurrencyStamp", "CreateTime", "PasswordHash", "SecurityStamp" },
                values: new object[] { "03737677-1e84-46f7-bf3d-b81e814f87e3", new DateTime(2024, 7, 22, 20, 37, 42, 513, DateTimeKind.Local).AddTicks(128), "AQAAAAIAAYagAAAAECIbEvh5gayGROfahGNm7apM2z1vs+70wIHtaraiddi/zyOVXt9AcmcnoyG2Lz45GA==", "93193a71-fe69-433c-87be-03734265e798" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("89da7c75-8291-4baf-9060-028a07393dde"),
                columns: new[] { "ConcurrencyStamp", "CreateTime", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6b9fad65-b603-4613-8677-0939b0c0beb7", new DateTime(2024, 7, 22, 20, 37, 42, 549, DateTimeKind.Local).AddTicks(1369), "AQAAAAIAAYagAAAAEGpXI6qerECfc5VVgs4Zu//uRwnBph8u1AtiP5ZVnUMBIMFLex0LK3WY1a3MYgfacA==", "cdcb6781-65d0-4bc4-99c0-458fd5469451" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("a35a610d-689f-4ab4-9324-cc227bfdbfba"),
                columns: new[] { "ConcurrencyStamp", "CreateTime", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5b068333-3255-4914-9049-02e6a9fd7f5f", new DateTime(2024, 7, 22, 20, 37, 42, 585, DateTimeKind.Local).AddTicks(289), "AQAAAAIAAYagAAAAEIaod5oZe7y0mM8/gDsKCfs0XZCZKUkeKwmTBpDHDea7hUH1m23y4KkFKsTyPDq5Jw==", "69a73d0f-1fb7-48ff-85b1-d1fdc44cf70e" });

            migrationBuilder.UpdateData(
                table: "HousingSafes",
                keyColumn: "Id",
                keyValue: new Guid("666776f7-518b-4805-a726-eba238e03fc4"),
                column: "CreateTime",
                value: new DateTime(2024, 7, 22, 20, 37, 42, 623, DateTimeKind.Local).AddTicks(4311));

            migrationBuilder.UpdateData(
                table: "Housings",
                keyColumn: "Id",
                keyValue: new Guid("709a770b-66c6-4adc-bd19-6438117bf646"),
                columns: new[] { "CreateTime", "CreateUser" },
                values: new object[] { new DateTime(2024, 7, 22, 20, 37, 42, 623, DateTimeKind.Local).AddTicks(3175), null });

            migrationBuilder.CreateIndex(
                name: "IX_HousingSafes_HousingId",
                table: "HousingSafes",
                column: "HousingId");

            migrationBuilder.AddForeignKey(
                name: "FK_HousingSafes_Housings_HousingId",
                table: "HousingSafes",
                column: "HousingId",
                principalTable: "Housings",
                principalColumn: "Id");
        }
    }
}
