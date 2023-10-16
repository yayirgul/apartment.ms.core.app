using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ams.data.Migrations
{
    /// <inheritdoc />
    public partial class init_ams_v2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Accounts",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AccountName = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    IsTrial = table.Column<bool>(type: "bit", nullable: false),
                    TrialEndDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsTestAccount = table.Column<bool>(type: "bit", nullable: false),
                    CreateUserId = table.Column<Guid>(type: "uniqueidentifier", maxLength: 300, nullable: true),
                    ModifiedUserId = table.Column<Guid>(type: "uniqueidentifier", maxLength: 300, nullable: true),
                    DeletedUserId = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
                    CreateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    IsStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    LanguageId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Accounts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AdxMenus",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ParentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    MenuUrl = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    Icons = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CreateUserId = table.Column<Guid>(type: "uniqueidentifier", maxLength: 300, nullable: true),
                    ModifiedUserId = table.Column<Guid>(type: "uniqueidentifier", maxLength: 300, nullable: true),
                    DeletedUserId = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
                    CreateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    IsStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    LanguageId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdxMenus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoleType = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CreateUserId = table.Column<Guid>(type: "uniqueidentifier", maxLength: 300, nullable: true),
                    ModifiedUserId = table.Column<Guid>(type: "uniqueidentifier", maxLength: 300, nullable: true),
                    DeletedUserId = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
                    CreateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    IsStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    LanguageId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Username = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
                    Password = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    Firstname = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
                    Surname = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
                    CreateUserId = table.Column<Guid>(type: "uniqueidentifier", maxLength: 300, nullable: true),
                    ModifiedUserId = table.Column<Guid>(type: "uniqueidentifier", maxLength: 300, nullable: true),
                    DeletedUserId = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
                    CreateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    IsStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    LanguageId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Apartments",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AccountId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ApartmentName = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
                    CreateUserId = table.Column<Guid>(type: "uniqueidentifier", maxLength: 300, nullable: true),
                    ModifiedUserId = table.Column<Guid>(type: "uniqueidentifier", maxLength: 300, nullable: true),
                    DeletedUserId = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
                    CreateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    IsStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    LanguageId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Apartments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Apartments_Accounts_AccountId",
                        column: x => x.AccountId,
                        principalTable: "Accounts",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Expenses",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    OwnerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AccountId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ApartmentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ExpenseName = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    ExpenseCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Month = table.Column<int>(type: "int", nullable: true),
                    Year = table.Column<int>(type: "int", nullable: true),
                    CreateUserId = table.Column<Guid>(type: "uniqueidentifier", maxLength: 300, nullable: true),
                    ModifiedUserId = table.Column<Guid>(type: "uniqueidentifier", maxLength: 300, nullable: true),
                    DeletedUserId = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
                    CreateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    IsStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    LanguageId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Expenses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Expenses_Accounts_AccountId",
                        column: x => x.AccountId,
                        principalTable: "Accounts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Expenses_Apartments_ApartmentId",
                        column: x => x.ApartmentId,
                        principalTable: "Apartments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Housings",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    OwnerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AccountId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ApartmentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    HousingName = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    CreateUserId = table.Column<Guid>(type: "uniqueidentifier", maxLength: 300, nullable: true),
                    ModifiedUserId = table.Column<Guid>(type: "uniqueidentifier", maxLength: 300, nullable: true),
                    DeletedUserId = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
                    CreateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    IsStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    LanguageId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Housings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Housings_Accounts_AccountId",
                        column: x => x.AccountId,
                        principalTable: "Accounts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Housings_Apartments_ApartmentId",
                        column: x => x.ApartmentId,
                        principalTable: "Apartments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HousingSafes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    OwnerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AccountId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ApartmentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    HousingName = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    CreateUserId = table.Column<Guid>(type: "uniqueidentifier", maxLength: 300, nullable: true),
                    ModifiedUserId = table.Column<Guid>(type: "uniqueidentifier", maxLength: 300, nullable: true),
                    DeletedUserId = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
                    CreateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    IsStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    LanguageId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HousingSafes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HousingSafes_Accounts_AccountId",
                        column: x => x.AccountId,
                        principalTable: "Accounts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HousingSafes_Apartments_ApartmentId",
                        column: x => x.ApartmentId,
                        principalTable: "Apartments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Debits",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    OwnerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AccountId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    HousingId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ApartmentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ExpenseCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Paid = table.Column<bool>(type: "bit", nullable: false),
                    CreateUserId = table.Column<Guid>(type: "uniqueidentifier", maxLength: 300, nullable: true),
                    ModifiedUserId = table.Column<Guid>(type: "uniqueidentifier", maxLength: 300, nullable: true),
                    DeletedUserId = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
                    CreateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    IsStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    LanguageId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Debits", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Debits_Housings_HousingId",
                        column: x => x.HousingId,
                        principalTable: "Housings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Apartments_AccountId",
                table: "Apartments",
                column: "AccountId");

            migrationBuilder.CreateIndex(
                name: "IX_Debits_HousingId",
                table: "Debits",
                column: "HousingId");

            migrationBuilder.CreateIndex(
                name: "IX_Expenses_AccountId",
                table: "Expenses",
                column: "AccountId");

            migrationBuilder.CreateIndex(
                name: "IX_Expenses_ApartmentId",
                table: "Expenses",
                column: "ApartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Housings_AccountId",
                table: "Housings",
                column: "AccountId");

            migrationBuilder.CreateIndex(
                name: "IX_Housings_ApartmentId",
                table: "Housings",
                column: "ApartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_HousingSafes_AccountId",
                table: "HousingSafes",
                column: "AccountId");

            migrationBuilder.CreateIndex(
                name: "IX_HousingSafes_ApartmentId",
                table: "HousingSafes",
                column: "ApartmentId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AdxMenus");

            migrationBuilder.DropTable(
                name: "Debits");

            migrationBuilder.DropTable(
                name: "Expenses");

            migrationBuilder.DropTable(
                name: "HousingSafes");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Housings");

            migrationBuilder.DropTable(
                name: "Apartments");

            migrationBuilder.DropTable(
                name: "Accounts");
        }
    }
}
