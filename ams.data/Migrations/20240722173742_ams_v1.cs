using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ams.data.Migrations
{
    /// <inheritdoc />
    public partial class ams_v1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AdxMenus",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ParentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Urls = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    Icons = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
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
                    table.PrimaryKey("PK_AdxMenus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AccountId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreateUser = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedUser = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeleteUser = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    Firstname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Lastname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUsers_AspNetUsers_CreateUser",
                        column: x => x.CreateUser,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AspNetUsers_AspNetUsers_DeleteUser",
                        column: x => x.DeleteUser,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AspNetUsers_AspNetUsers_ModifiedUser",
                        column: x => x.ModifiedUser,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Accounts",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AccountName = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
                    Domain = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsTrial = table.Column<bool>(type: "bit", nullable: false),
                    TrialEndDate = table.Column<DateTime>(type: "datetime2", nullable: true),
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
                    table.PrimaryKey("PK_Accounts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Accounts_AspNetUsers_CreateUser",
                        column: x => x.CreateUser,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Accounts_AspNetUsers_DeleteUser",
                        column: x => x.DeleteUser,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Accounts_AspNetUsers_ModifiedUser",
                        column: x => x.ModifiedUser,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Apartments",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AccountId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ApartmentName = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
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
                    table.PrimaryKey("PK_Apartments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Apartments_Accounts_AccountId",
                        column: x => x.AccountId,
                        principalTable: "Accounts",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Apartments_AspNetUsers_CreateUser",
                        column: x => x.CreateUser,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Apartments_AspNetUsers_DeleteUser",
                        column: x => x.DeleteUser,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Apartments_AspNetUsers_ModifiedUser",
                        column: x => x.ModifiedUser,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Expenses",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AccountId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ApartmentId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreateUser = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedUser = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeleteUser = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ExpenseName = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
                    ExpenseCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Amount = table.Column<decimal>(type: "money", nullable: true),
                    Month = table.Column<int>(type: "int", nullable: true),
                    Year = table.Column<int>(type: "int", nullable: true),
                    IsFixed = table.Column<bool>(type: "bit", nullable: false),
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
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Expenses_AspNetUsers_CreateUser",
                        column: x => x.CreateUser,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Expenses_AspNetUsers_DeleteUser",
                        column: x => x.DeleteUser,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Expenses_AspNetUsers_ModifiedUser",
                        column: x => x.ModifiedUser,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Housings",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AccountId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ApartmentId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    HousingUser = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreateUser = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedUser = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeleteUser = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    HousingName = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
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
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Housings_AspNetUsers_CreateUser",
                        column: x => x.CreateUser,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Housings_AspNetUsers_DeleteUser",
                        column: x => x.DeleteUser,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Housings_AspNetUsers_HousingUser",
                        column: x => x.HousingUser,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Housings_AspNetUsers_ModifiedUser",
                        column: x => x.ModifiedUser,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Debits",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AccountId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ApartmentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    HousingId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreateUser = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedUser = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeleteUser = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DebitUser = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Amount = table.Column<decimal>(type: "money", nullable: true),
                    ExpenseCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Paid = table.Column<bool>(type: "bit", nullable: false),
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
                    table.PrimaryKey("PK_Debits", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Debits_Accounts_AccountId",
                        column: x => x.AccountId,
                        principalTable: "Accounts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Debits_Apartments_ApartmentId",
                        column: x => x.ApartmentId,
                        principalTable: "Apartments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Debits_AspNetUsers_CreateUser",
                        column: x => x.CreateUser,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Debits_AspNetUsers_DebitUser",
                        column: x => x.DebitUser,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Debits_AspNetUsers_DeleteUser",
                        column: x => x.DeleteUser,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Debits_AspNetUsers_ModifiedUser",
                        column: x => x.ModifiedUser,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Debits_Housings_HousingId",
                        column: x => x.HousingId,
                        principalTable: "Housings",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "HousingSafes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AccountId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ApartmentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    HousingId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    HousingSafeUser = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreateUser = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedUser = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeleteUser = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Amount = table.Column<decimal>(type: "money", nullable: true),
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
                    table.ForeignKey(
                        name: "FK_HousingSafes_AspNetUsers_CreateUser",
                        column: x => x.CreateUser,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_HousingSafes_AspNetUsers_DeleteUser",
                        column: x => x.DeleteUser,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_HousingSafes_AspNetUsers_HousingSafeUser",
                        column: x => x.HousingSafeUser,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_HousingSafes_AspNetUsers_ModifiedUser",
                        column: x => x.ModifiedUser,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_HousingSafes_Housings_HousingId",
                        column: x => x.HousingId,
                        principalTable: "Housings",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "AdxMenus",
                columns: new[] { "Id", "CreateTime", "DeletedTime", "Icons", "IsActive", "IsDeleted", "IsStatus", "LanguageId", "ModifiedTime", "ParentId", "Title", "Urls" },
                values: new object[] { new Guid("a2b3d904-401c-431f-9845-7fa2652d87fc"), new DateTime(2024, 7, 22, 20, 37, 42, 511, DateTimeKind.Local).AddTicks(5788), null, null, true, false, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), "Pano", "/" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("051004f1-a383-4746-a722-3b051d12aaea"), "b90e39b6-ec70-4260-8c58-062b42cbe2f3", "user", "USER" },
                    { new Guid("4271dd20-390a-46ce-b67d-59678a720270"), "6119d03b-7930-4955-a28e-e95ec04f322b", "admin", "ADMIN" },
                    { new Guid("4438dff4-28d6-46c1-90eb-f6b2a233d97e"), "e8dc9981-052c-41a6-99c6-0dac40c332bd", "agent", "AGENT" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AccountId", "ConcurrencyStamp", "CreateTime", "CreateUser", "DeleteUser", "DeletedTime", "Email", "EmailConfirmed", "Firstname", "IsActive", "Lastname", "LockoutEnabled", "LockoutEnd", "ModifiedTime", "ModifiedUser", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("6fa95f6e-2516-49e8-9ae6-7745e7743dbf"), 0, new Guid("db72e0e2-3201-414f-9753-190466e024f3"), "03737677-1e84-46f7-bf3d-b81e814f87e3", new DateTime(2024, 7, 22, 20, 37, 42, 513, DateTimeKind.Local).AddTicks(128), null, null, null, "yayirgul@gmail.com", true, "Yunus", false, "AYIRGÜL", false, null, null, null, "YAYIRGUL@GMAIL.COM", "YAYIRGUL@GMAIL.COM", "AQAAAAIAAYagAAAAECIbEvh5gayGROfahGNm7apM2z1vs+70wIHtaraiddi/zyOVXt9AcmcnoyG2Lz45GA==", "+905558008040", true, "93193a71-fe69-433c-87be-03734265e798", false, "yayirgul@gmail.com" },
                    { new Guid("89da7c75-8291-4baf-9060-028a07393dde"), 0, new Guid("db72e0e2-3201-414f-9753-190466e024f3"), "6b9fad65-b603-4613-8677-0939b0c0beb7", new DateTime(2024, 7, 22, 20, 37, 42, 549, DateTimeKind.Local).AddTicks(1369), null, null, null, "kadirkeles@hotmail.com", true, "Kadir", false, "Keleş", false, null, null, null, "KADIRKELES@HOTMAIL.COM", "KADIRKELES@HOTMAIL.COM", "AQAAAAIAAYagAAAAEGpXI6qerECfc5VVgs4Zu//uRwnBph8u1AtiP5ZVnUMBIMFLex0LK3WY1a3MYgfacA==", "+905558008050", true, "cdcb6781-65d0-4bc4-99c0-458fd5469451", false, "kadirkeles@hotmail.com" },
                    { new Guid("a35a610d-689f-4ab4-9324-cc227bfdbfba"), 0, new Guid("db72e0e2-3201-414f-9753-190466e024f3"), "5b068333-3255-4914-9049-02e6a9fd7f5f", new DateTime(2024, 7, 22, 20, 37, 42, 585, DateTimeKind.Local).AddTicks(289), null, null, null, "lokmanyilmaz@hotmail.com", true, "Lokman", false, "Yılmaz", false, null, null, null, "LOKMANYILMAZ@HOTMAIL.COM", "LOKMANYILMAZ@HOTMAIL.COM", "AQAAAAIAAYagAAAAEIaod5oZe7y0mM8/gDsKCfs0XZCZKUkeKwmTBpDHDea7hUH1m23y4KkFKsTyPDq5Jw==", "+905558008060", true, "69a73d0f-1fb7-48ff-85b1-d1fdc44cf70e", false, "lokmanyilmaz@hotmail.com" }
                });

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "AccountName", "CreateTime", "CreateUser", "DeleteUser", "DeletedTime", "Domain", "IsActive", "IsDeleted", "IsStatus", "IsTrial", "LanguageId", "ModifiedTime", "ModifiedUser", "TrialEndDate" },
                values: new object[] { new Guid("db72e0e2-3201-414f-9753-190466e024f3"), "ABC A.Ş", new DateTime(2024, 7, 22, 20, 37, 42, 511, DateTimeKind.Local).AddTicks(5054), new Guid("6fa95f6e-2516-49e8-9ae6-7745e7743dbf"), null, null, "abc.com", true, false, null, true, null, null, null, null });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("4271dd20-390a-46ce-b67d-59678a720270"), new Guid("6fa95f6e-2516-49e8-9ae6-7745e7743dbf") },
                    { new Guid("4438dff4-28d6-46c1-90eb-f6b2a233d97e"), new Guid("89da7c75-8291-4baf-9060-028a07393dde") },
                    { new Guid("051004f1-a383-4746-a722-3b051d12aaea"), new Guid("a35a610d-689f-4ab4-9324-cc227bfdbfba") }
                });

            migrationBuilder.InsertData(
                table: "Apartments",
                columns: new[] { "Id", "AccountId", "ApartmentName", "CreateTime", "CreateUser", "DeleteUser", "DeletedTime", "IsActive", "IsDeleted", "IsStatus", "LanguageId", "ModifiedTime", "ModifiedUser" },
                values: new object[,]
                {
                    { new Guid("16f885ff-6897-4d08-afa6-0640c40d2a05"), new Guid("db72e0e2-3201-414f-9753-190466e024f3"), "Sevinç APT", new DateTime(2024, 7, 22, 20, 37, 42, 511, DateTimeKind.Local).AddTicks(6284), new Guid("6fa95f6e-2516-49e8-9ae6-7745e7743dbf"), null, null, true, false, null, null, null, null },
                    { new Guid("d2977402-d13f-423f-bc0f-e639e4a610bb"), new Guid("db72e0e2-3201-414f-9753-190466e024f3"), "Güvenç APT", new DateTime(2024, 7, 22, 20, 37, 42, 511, DateTimeKind.Local).AddTicks(6286), new Guid("6fa95f6e-2516-49e8-9ae6-7745e7743dbf"), null, null, true, false, null, null, null, null },
                    { new Guid("d4033eef-ba92-4a1f-9ecb-1eee6996214a"), new Guid("db72e0e2-3201-414f-9753-190466e024f3"), "Huzur APT", new DateTime(2024, 7, 22, 20, 37, 42, 511, DateTimeKind.Local).AddTicks(6277), new Guid("6fa95f6e-2516-49e8-9ae6-7745e7743dbf"), null, null, true, false, null, null, null, null }
                });

            migrationBuilder.InsertData(
                table: "Housings",
                columns: new[] { "Id", "AccountId", "ApartmentId", "CreateTime", "CreateUser", "DeleteUser", "DeletedTime", "HousingName", "HousingUser", "IsActive", "IsDeleted", "IsStatus", "LanguageId", "ModifiedTime", "ModifiedUser" },
                values: new object[] { new Guid("709a770b-66c6-4adc-bd19-6438117bf646"), new Guid("db72e0e2-3201-414f-9753-190466e024f3"), new Guid("d4033eef-ba92-4a1f-9ecb-1eee6996214a"), new DateTime(2024, 7, 22, 20, 37, 42, 623, DateTimeKind.Local).AddTicks(3175), null, null, null, "Daire 1", null, true, false, null, null, null, null });

            migrationBuilder.InsertData(
                table: "HousingSafes",
                columns: new[] { "Id", "AccountId", "Amount", "ApartmentId", "CreateTime", "CreateUser", "DeleteUser", "DeletedTime", "HousingId", "HousingSafeUser", "IsActive", "IsDeleted", "IsStatus", "LanguageId", "ModifiedTime", "ModifiedUser" },
                values: new object[] { new Guid("666776f7-518b-4805-a726-eba238e03fc4"), new Guid("db72e0e2-3201-414f-9753-190466e024f3"), 100m, new Guid("d4033eef-ba92-4a1f-9ecb-1eee6996214a"), new DateTime(2024, 7, 22, 20, 37, 42, 623, DateTimeKind.Local).AddTicks(4311), null, null, null, new Guid("709a770b-66c6-4adc-bd19-6438117bf646"), null, true, false, null, null, null, null });

            migrationBuilder.CreateIndex(
                name: "IX_Accounts_CreateUser",
                table: "Accounts",
                column: "CreateUser");

            migrationBuilder.CreateIndex(
                name: "IX_Accounts_DeleteUser",
                table: "Accounts",
                column: "DeleteUser");

            migrationBuilder.CreateIndex(
                name: "IX_Accounts_ModifiedUser",
                table: "Accounts",
                column: "ModifiedUser");

            migrationBuilder.CreateIndex(
                name: "IX_Apartments_AccountId",
                table: "Apartments",
                column: "AccountId");

            migrationBuilder.CreateIndex(
                name: "IX_Apartments_CreateUser",
                table: "Apartments",
                column: "CreateUser");

            migrationBuilder.CreateIndex(
                name: "IX_Apartments_DeleteUser",
                table: "Apartments",
                column: "DeleteUser");

            migrationBuilder.CreateIndex(
                name: "IX_Apartments_ModifiedUser",
                table: "Apartments",
                column: "ModifiedUser");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_CreateUser",
                table: "AspNetUsers",
                column: "CreateUser");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_DeleteUser",
                table: "AspNetUsers",
                column: "DeleteUser");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_ModifiedUser",
                table: "AspNetUsers",
                column: "ModifiedUser");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Debits_AccountId",
                table: "Debits",
                column: "AccountId");

            migrationBuilder.CreateIndex(
                name: "IX_Debits_ApartmentId",
                table: "Debits",
                column: "ApartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Debits_CreateUser",
                table: "Debits",
                column: "CreateUser");

            migrationBuilder.CreateIndex(
                name: "IX_Debits_DebitUser",
                table: "Debits",
                column: "DebitUser");

            migrationBuilder.CreateIndex(
                name: "IX_Debits_DeleteUser",
                table: "Debits",
                column: "DeleteUser");

            migrationBuilder.CreateIndex(
                name: "IX_Debits_HousingId",
                table: "Debits",
                column: "HousingId");

            migrationBuilder.CreateIndex(
                name: "IX_Debits_ModifiedUser",
                table: "Debits",
                column: "ModifiedUser");

            migrationBuilder.CreateIndex(
                name: "IX_Expenses_AccountId",
                table: "Expenses",
                column: "AccountId");

            migrationBuilder.CreateIndex(
                name: "IX_Expenses_ApartmentId",
                table: "Expenses",
                column: "ApartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Expenses_CreateUser",
                table: "Expenses",
                column: "CreateUser");

            migrationBuilder.CreateIndex(
                name: "IX_Expenses_DeleteUser",
                table: "Expenses",
                column: "DeleteUser");

            migrationBuilder.CreateIndex(
                name: "IX_Expenses_ModifiedUser",
                table: "Expenses",
                column: "ModifiedUser");

            migrationBuilder.CreateIndex(
                name: "IX_Housings_AccountId",
                table: "Housings",
                column: "AccountId");

            migrationBuilder.CreateIndex(
                name: "IX_Housings_ApartmentId",
                table: "Housings",
                column: "ApartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Housings_CreateUser",
                table: "Housings",
                column: "CreateUser");

            migrationBuilder.CreateIndex(
                name: "IX_Housings_DeleteUser",
                table: "Housings",
                column: "DeleteUser");

            migrationBuilder.CreateIndex(
                name: "IX_Housings_HousingUser",
                table: "Housings",
                column: "HousingUser");

            migrationBuilder.CreateIndex(
                name: "IX_Housings_ModifiedUser",
                table: "Housings",
                column: "ModifiedUser");

            migrationBuilder.CreateIndex(
                name: "IX_HousingSafes_AccountId",
                table: "HousingSafes",
                column: "AccountId");

            migrationBuilder.CreateIndex(
                name: "IX_HousingSafes_ApartmentId",
                table: "HousingSafes",
                column: "ApartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_HousingSafes_CreateUser",
                table: "HousingSafes",
                column: "CreateUser");

            migrationBuilder.CreateIndex(
                name: "IX_HousingSafes_DeleteUser",
                table: "HousingSafes",
                column: "DeleteUser");

            migrationBuilder.CreateIndex(
                name: "IX_HousingSafes_HousingId",
                table: "HousingSafes",
                column: "HousingId");

            migrationBuilder.CreateIndex(
                name: "IX_HousingSafes_HousingSafeUser",
                table: "HousingSafes",
                column: "HousingSafeUser");

            migrationBuilder.CreateIndex(
                name: "IX_HousingSafes_ModifiedUser",
                table: "HousingSafes",
                column: "ModifiedUser");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AdxMenus");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Debits");

            migrationBuilder.DropTable(
                name: "Expenses");

            migrationBuilder.DropTable(
                name: "HousingSafes");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Housings");

            migrationBuilder.DropTable(
                name: "Apartments");

            migrationBuilder.DropTable(
                name: "Accounts");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
