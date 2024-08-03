using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ams.data.Migrations
{
    /// <inheritdoc />
    public partial class ams_mig_v7 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "FormerAmount",
                table: "HousingSafeMovements",
                type: "money",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("db72e0e2-3201-414f-9753-190466e024f3"),
                column: "CreateTime",
                value: new DateTime(2024, 8, 4, 0, 8, 50, 514, DateTimeKind.Local).AddTicks(3992));

            migrationBuilder.UpdateData(
                table: "AdxMenus",
                keyColumn: "Id",
                keyValue: new Guid("a2b3d904-401c-431f-9845-7fa2652d87fc"),
                column: "CreateTime",
                value: new DateTime(2024, 8, 4, 0, 8, 50, 514, DateTimeKind.Local).AddTicks(4743));

            migrationBuilder.UpdateData(
                table: "Apartments",
                keyColumn: "Id",
                keyValue: new Guid("16f885ff-6897-4d08-afa6-0640c40d2a05"),
                column: "CreateTime",
                value: new DateTime(2024, 8, 4, 0, 8, 50, 514, DateTimeKind.Local).AddTicks(5247));

            migrationBuilder.UpdateData(
                table: "Apartments",
                keyColumn: "Id",
                keyValue: new Guid("d2977402-d13f-423f-bc0f-e639e4a610bb"),
                column: "CreateTime",
                value: new DateTime(2024, 8, 4, 0, 8, 50, 514, DateTimeKind.Local).AddTicks(5256));

            migrationBuilder.UpdateData(
                table: "Apartments",
                keyColumn: "Id",
                keyValue: new Guid("d4033eef-ba92-4a1f-9ecb-1eee6996214a"),
                column: "CreateTime",
                value: new DateTime(2024, 8, 4, 0, 8, 50, 514, DateTimeKind.Local).AddTicks(5241));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("051004f1-a383-4746-a722-3b051d12aaea"),
                column: "ConcurrencyStamp",
                value: "820c3fa3-60a9-446a-89f6-076d0aee583c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("4271dd20-390a-46ce-b67d-59678a720270"),
                column: "ConcurrencyStamp",
                value: "eb0ac69e-4d63-4491-a397-21523063fd57");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("4438dff4-28d6-46c1-90eb-f6b2a233d97e"),
                column: "ConcurrencyStamp",
                value: "a821c703-244e-4509-b647-6f6b04f081cd");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("6fa95f6e-2516-49e8-9ae6-7745e7743dbf"),
                columns: new[] { "ConcurrencyStamp", "CreateTime", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a5dcd54b-8d9a-47e0-82cd-5d61162478fe", new DateTime(2024, 8, 4, 0, 8, 50, 515, DateTimeKind.Local).AddTicks(4802), "AQAAAAIAAYagAAAAENQ3dkuS/u67bGlIXDv8nkCDq4gPlcPuSuuTaqgFr5x0RC4qNXhWefrLLUPYTCs95Q==", "15a48020-ba0f-4f48-b753-6d894eea0a9b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("89da7c75-8291-4baf-9060-028a07393dde"),
                columns: new[] { "ConcurrencyStamp", "CreateTime", "PasswordHash", "SecurityStamp" },
                values: new object[] { "aa1fcc60-b653-4176-9513-13f088a8563a", new DateTime(2024, 8, 4, 0, 8, 50, 551, DateTimeKind.Local).AddTicks(5391), "AQAAAAIAAYagAAAAEOxVijM+I/Nr5yr5PqcG9FCEVAIMBkiqRg3/gcneU4o0ysXE6EF1RXtSIu/SvrwfVA==", "20b0737a-6446-4741-91d5-e7f3ccebd9b7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("a35a610d-689f-4ab4-9324-cc227bfdbfba"),
                columns: new[] { "ConcurrencyStamp", "CreateTime", "PasswordHash", "SecurityStamp" },
                values: new object[] { "842cb6db-82b4-4100-89a4-8801a820abe0", new DateTime(2024, 8, 4, 0, 8, 50, 589, DateTimeKind.Local).AddTicks(4187), "AQAAAAIAAYagAAAAECZA89A57Hw45vcMB4epbFIzWehLfQVoivhLk5Mcumpw1Usjb0o896lQYQLRkggIPw==", "9d1ecfb2-d96b-425e-aa2c-e7e1bb49d804" });

            migrationBuilder.UpdateData(
                table: "HousingSafes",
                keyColumn: "Id",
                keyValue: new Guid("666776f7-518b-4805-a726-eba238e03fc4"),
                column: "CreateTime",
                value: new DateTime(2024, 8, 4, 0, 8, 50, 627, DateTimeKind.Local).AddTicks(2516));

            migrationBuilder.UpdateData(
                table: "Housings",
                keyColumn: "Id",
                keyValue: new Guid("709a770b-66c6-4adc-bd19-6438117bf646"),
                column: "CreateTime",
                value: new DateTime(2024, 8, 4, 0, 8, 50, 627, DateTimeKind.Local).AddTicks(1955));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FormerAmount",
                table: "HousingSafeMovements");

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("db72e0e2-3201-414f-9753-190466e024f3"),
                column: "CreateTime",
                value: new DateTime(2024, 8, 3, 17, 45, 22, 761, DateTimeKind.Local).AddTicks(7967));

            migrationBuilder.UpdateData(
                table: "AdxMenus",
                keyColumn: "Id",
                keyValue: new Guid("a2b3d904-401c-431f-9845-7fa2652d87fc"),
                column: "CreateTime",
                value: new DateTime(2024, 8, 3, 17, 45, 22, 761, DateTimeKind.Local).AddTicks(8701));

            migrationBuilder.UpdateData(
                table: "Apartments",
                keyColumn: "Id",
                keyValue: new Guid("16f885ff-6897-4d08-afa6-0640c40d2a05"),
                column: "CreateTime",
                value: new DateTime(2024, 8, 3, 17, 45, 22, 761, DateTimeKind.Local).AddTicks(9244));

            migrationBuilder.UpdateData(
                table: "Apartments",
                keyColumn: "Id",
                keyValue: new Guid("d2977402-d13f-423f-bc0f-e639e4a610bb"),
                column: "CreateTime",
                value: new DateTime(2024, 8, 3, 17, 45, 22, 761, DateTimeKind.Local).AddTicks(9248));

            migrationBuilder.UpdateData(
                table: "Apartments",
                keyColumn: "Id",
                keyValue: new Guid("d4033eef-ba92-4a1f-9ecb-1eee6996214a"),
                column: "CreateTime",
                value: new DateTime(2024, 8, 3, 17, 45, 22, 761, DateTimeKind.Local).AddTicks(9179));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("051004f1-a383-4746-a722-3b051d12aaea"),
                column: "ConcurrencyStamp",
                value: "ae444886-c2c8-4ece-8655-aaba8f1cd830");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("4271dd20-390a-46ce-b67d-59678a720270"),
                column: "ConcurrencyStamp",
                value: "283d9a50-36c9-4663-bf81-8f8a793ce643");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("4438dff4-28d6-46c1-90eb-f6b2a233d97e"),
                column: "ConcurrencyStamp",
                value: "de782c18-5703-4fa5-b1e1-f6ed15ee71b5");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("6fa95f6e-2516-49e8-9ae6-7745e7743dbf"),
                columns: new[] { "ConcurrencyStamp", "CreateTime", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c0e84971-0fbe-46d7-bd28-16740b66ad16", new DateTime(2024, 8, 3, 17, 45, 22, 763, DateTimeKind.Local).AddTicks(3218), "AQAAAAIAAYagAAAAENpUd44S2DGQu162ai6mEgTPeaXeBNFVfbPGRdSLoMyJ+Cx+eqY0HjOEnHT/MTBWHg==", "f3a20e9b-96c8-4836-8387-a62e1ba95979" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("89da7c75-8291-4baf-9060-028a07393dde"),
                columns: new[] { "ConcurrencyStamp", "CreateTime", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1b89e64c-52fb-4fd5-b92e-c91900a46255", new DateTime(2024, 8, 3, 17, 45, 22, 798, DateTimeKind.Local).AddTicks(8226), "AQAAAAIAAYagAAAAEM6F+ljTqwIbl93NYqRZp5DRs3teqEmmCka6OFswa0lxoBoJYUdu2h04nfvSeOu/rw==", "b2829248-7691-4137-997b-dabdf245ffca" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("a35a610d-689f-4ab4-9324-cc227bfdbfba"),
                columns: new[] { "ConcurrencyStamp", "CreateTime", "PasswordHash", "SecurityStamp" },
                values: new object[] { "54df7a16-adc7-42aa-9398-bb5e02b6fdf5", new DateTime(2024, 8, 3, 17, 45, 22, 834, DateTimeKind.Local).AddTicks(8316), "AQAAAAIAAYagAAAAED36oNOUj5qdwV71lqHsBCU0ATRSFOqfJnd0HBiN1BebEYloGdTCso7Y60nUzlUJXA==", "8f5229bc-453d-490d-b071-7424629ddf76" });

            migrationBuilder.UpdateData(
                table: "HousingSafes",
                keyColumn: "Id",
                keyValue: new Guid("666776f7-518b-4805-a726-eba238e03fc4"),
                column: "CreateTime",
                value: new DateTime(2024, 8, 3, 17, 45, 22, 870, DateTimeKind.Local).AddTicks(8760));

            migrationBuilder.UpdateData(
                table: "Housings",
                keyColumn: "Id",
                keyValue: new Guid("709a770b-66c6-4adc-bd19-6438117bf646"),
                column: "CreateTime",
                value: new DateTime(2024, 8, 3, 17, 45, 22, 870, DateTimeKind.Local).AddTicks(8082));
        }
    }
}
