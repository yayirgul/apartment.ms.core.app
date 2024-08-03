using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ams.data.Migrations
{
    /// <inheritdoc />
    public partial class ams_mig_v6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "HousingSafeMovements",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AccountId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ApartmentId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    HousingId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    HousingSafeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    MovementAmount = table.Column<decimal>(type: "money", nullable: true),
                    DebitAmount = table.Column<decimal>(type: "money", nullable: true),
                    _Month = table.Column<int>(type: "int", nullable: false),
                    _Year = table.Column<int>(type: "int", nullable: false),
                    CreateUser = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedUser = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeleteUser = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
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
                    table.PrimaryKey("PK_HousingSafeMovements", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HousingSafeMovements_Accounts_AccountId",
                        column: x => x.AccountId,
                        principalTable: "Accounts",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_HousingSafeMovements_Apartments_ApartmentId",
                        column: x => x.ApartmentId,
                        principalTable: "Apartments",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_HousingSafeMovements_AspNetUsers_CreateUser",
                        column: x => x.CreateUser,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_HousingSafeMovements_AspNetUsers_DeleteUser",
                        column: x => x.DeleteUser,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_HousingSafeMovements_AspNetUsers_ModifiedUser",
                        column: x => x.ModifiedUser,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_HousingSafeMovements_HousingSafes_HousingSafeId",
                        column: x => x.HousingSafeId,
                        principalTable: "HousingSafes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_HousingSafeMovements_Housings_HousingId",
                        column: x => x.HousingId,
                        principalTable: "Housings",
                        principalColumn: "Id");
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_HousingSafeMovements_AccountId",
                table: "HousingSafeMovements",
                column: "AccountId");

            migrationBuilder.CreateIndex(
                name: "IX_HousingSafeMovements_ApartmentId",
                table: "HousingSafeMovements",
                column: "ApartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_HousingSafeMovements_CreateUser",
                table: "HousingSafeMovements",
                column: "CreateUser");

            migrationBuilder.CreateIndex(
                name: "IX_HousingSafeMovements_DeleteUser",
                table: "HousingSafeMovements",
                column: "DeleteUser");

            migrationBuilder.CreateIndex(
                name: "IX_HousingSafeMovements_HousingId",
                table: "HousingSafeMovements",
                column: "HousingId");

            migrationBuilder.CreateIndex(
                name: "IX_HousingSafeMovements_HousingSafeId",
                table: "HousingSafeMovements",
                column: "HousingSafeId");

            migrationBuilder.CreateIndex(
                name: "IX_HousingSafeMovements_ModifiedUser",
                table: "HousingSafeMovements",
                column: "ModifiedUser");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HousingSafeMovements");

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
                column: "CreateTime",
                value: new DateTime(2024, 7, 28, 1, 3, 26, 309, DateTimeKind.Local).AddTicks(6941));
        }
    }
}
