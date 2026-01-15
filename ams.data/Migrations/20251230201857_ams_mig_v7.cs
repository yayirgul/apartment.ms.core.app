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

            migrationBuilder.AddColumn<bool>(
                name: "IsManager",
                table: "Housings",
                type: "bit",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Years",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreateUser = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedUser = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeleteUser = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    YearTX = table.Column<int>(type: "int", nullable: false),
                    CreateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsStatus = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    LanguageId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Years", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Years_AspNetUsers_CreateUser",
                        column: x => x.CreateUser,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Years_AspNetUsers_DeleteUser",
                        column: x => x.DeleteUser,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Years_AspNetUsers_ModifiedUser",
                        column: x => x.ModifiedUser,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("db72e0e2-3201-414f-9753-190466e024f3"),
                column: "CreateTime",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "AdxMenus",
                keyColumn: "Id",
                keyValue: new Guid("a2b3d904-401c-431f-9845-7fa2652d87fc"),
                column: "CreateTime",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Apartments",
                keyColumn: "Id",
                keyValue: new Guid("16f885ff-6897-4d08-afa6-0640c40d2a05"),
                column: "CreateTime",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Apartments",
                keyColumn: "Id",
                keyValue: new Guid("d2977402-d13f-423f-bc0f-e639e4a610bb"),
                column: "CreateTime",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Apartments",
                keyColumn: "Id",
                keyValue: new Guid("d4033eef-ba92-4a1f-9ecb-1eee6996214a"),
                column: "CreateTime",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("051004f1-a383-4746-a722-3b051d12aaea"),
                column: "ConcurrencyStamp",
                value: "b2dfd302-b41b-4732-b490-9bc065947992");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("4271dd20-390a-46ce-b67d-59678a720270"),
                column: "ConcurrencyStamp",
                value: "020befa1-6390-4af6-885a-9fb6e883ab71");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("4438dff4-28d6-46c1-90eb-f6b2a233d97e"),
                column: "ConcurrencyStamp",
                value: "83fd2ba2-cd51-4339-ae6e-7a9baa435c4d");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("6fa95f6e-2516-49e8-9ae6-7745e7743dbf"),
                columns: new[] { "ConcurrencyStamp", "CreateTime", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3ce276c4-a032-4e27-8070-dcc52cf40dd7", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "AQAAAAIAAYagAAAAENQ3dkuS/u67bGlIXDv8nkCDq4gPlcPuSuuTaqgFr5x0RC4qNXhWefrLLUPYTCs95Q==", "9d63def9-ca57-4d94-8fdf-2292519cec84" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("89da7c75-8291-4baf-9060-028a07393dde"),
                columns: new[] { "ConcurrencyStamp", "CreateTime", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9d2171ca-c2c0-48af-8b71-b5dcc9c613a0", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "AQAAAAIAAYagAAAAENQ3dkuS/u67bGlIXDv8nkCDq4gPlcPuSuuTaqgFr5x0RC4qNXhWefrLLUPYTCs95Q==", "be82a95e-81c8-4b07-89e6-eec384caf3ce" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("a35a610d-689f-4ab4-9324-cc227bfdbfba"),
                columns: new[] { "ConcurrencyStamp", "CreateTime", "PasswordHash", "SecurityStamp" },
                values: new object[] { "023556ad-708e-4426-b761-0f997b740d07", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "AQAAAAIAAYagAAAAENQ3dkuS/u67bGlIXDv8nkCDq4gPlcPuSuuTaqgFr5x0RC4qNXhWefrLLUPYTCs95Q==", "deff56e3-b36c-461f-b4d3-fb88a1f13afa" });

            migrationBuilder.UpdateData(
                table: "HousingSafes",
                keyColumn: "Id",
                keyValue: new Guid("666776f7-518b-4805-a726-eba238e03fc4"),
                column: "CreateTime",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Housings",
                keyColumn: "Id",
                keyValue: new Guid("709a770b-66c6-4adc-bd19-6438117bf646"),
                columns: new[] { "CreateTime", "IsManager" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.CreateIndex(
                name: "IX_Years_CreateUser",
                table: "Years",
                column: "CreateUser");

            migrationBuilder.CreateIndex(
                name: "IX_Years_DeleteUser",
                table: "Years",
                column: "DeleteUser");

            migrationBuilder.CreateIndex(
                name: "IX_Years_ModifiedUser",
                table: "Years",
                column: "ModifiedUser");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Years");

            migrationBuilder.DropColumn(
                name: "FormerAmount",
                table: "HousingSafeMovements");

            migrationBuilder.DropColumn(
                name: "IsManager",
                table: "Housings");

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
