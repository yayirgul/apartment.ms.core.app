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
                    DeletedUser = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
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
                    Urls = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    Icons = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CreateUser = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedUser = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletedUser = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
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
                    DeletedUser = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
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
                    DeletedUser = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
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
                name: "Expenses",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AccountId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ApartmentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ExpenseName = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
                    ExpenseCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Month = table.Column<int>(type: "int", nullable: true),
                    Year = table.Column<int>(type: "int", nullable: true),
                    IsFixed = table.Column<bool>(type: "bit", nullable: false),
                    CreateUser = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedUser = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletedUser = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
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
                    AccountId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ApartmentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    HousingName = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
                    CreateUser = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedUser = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletedUser = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
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
                    table.ForeignKey(
                        name: "FK_Housings_AspNetUsers_UserId",
                        column: x => x.UserId,
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
                    HousingId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    OwnerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    ExpenseCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Paid = table.Column<bool>(type: "bit", nullable: false),
                    CreateUser = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedUser = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletedUser = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
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
                        name: "FK_Debits_Housings_HousingId",
                        column: x => x.HousingId,
                        principalTable: "Housings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "HousingSafes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AccountId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ApartmentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    HousingId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    CreateUser = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedUser = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletedUser = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
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
                    table.ForeignKey(
                        name: "FK_HousingSafes_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_HousingSafes_Housings_HousingId",
                        column: x => x.HousingId,
                        principalTable: "Housings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "AccountName", "CreateTime", "CreateUser", "DeletedTime", "DeletedUser", "Domain", "IsActive", "IsDeleted", "IsStatus", "IsTrial", "LanguageId", "ModifiedTime", "ModifiedUser", "TrialEndDate" },
                values: new object[] { new Guid("db72e0e2-3201-414f-9753-190466e024f3"), "ABC A.Ş", new DateTime(2024, 7, 8, 0, 32, 36, 823, DateTimeKind.Local).AddTicks(5598), null, null, null, "abc.com", true, false, null, true, null, null, null, null });

            migrationBuilder.InsertData(
                table: "AdxMenus",
                columns: new[] { "Id", "CreateTime", "CreateUser", "DeletedTime", "DeletedUser", "Icons", "IsActive", "IsDeleted", "IsStatus", "LanguageId", "ModifiedTime", "ModifiedUser", "ParentId", "Title", "Urls" },
                values: new object[] { new Guid("a2b3d904-401c-431f-9845-7fa2652d87fc"), new DateTime(2024, 7, 8, 0, 32, 36, 823, DateTimeKind.Local).AddTicks(6651), null, null, null, null, true, false, null, null, null, null, new Guid("00000000-0000-0000-0000-000000000000"), "Pano", "/" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("051004f1-a383-4746-a722-3b051d12aaea"), "98e452e5-86b6-45c7-bc25-f17e148bf42d", "user", "USER" },
                    { new Guid("4271dd20-390a-46ce-b67d-59678a720270"), "fa99ef65-6edb-42e0-b6d2-c2ce9d95fedd", "admin", "ADMIN" },
                    { new Guid("4438dff4-28d6-46c1-90eb-f6b2a233d97e"), "3ede9a0f-26f3-43fe-87f6-7e15e9a9ca6d", "agent", "AGENT" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AccountId", "ConcurrencyStamp", "CreateTime", "CreateUser", "DeletedTime", "DeletedUser", "Email", "EmailConfirmed", "Firstname", "IsActive", "Lastname", "LockoutEnabled", "LockoutEnd", "ModifiedTime", "ModifiedUser", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("6fa95f6e-2516-49e8-9ae6-7745e7743dbf"), 0, null, "045ea4d2-7772-4801-af87-806bbb592b37", new DateTime(2024, 7, 8, 0, 32, 36, 824, DateTimeKind.Local).AddTicks(8638), null, null, null, "yayirgul@gmail.com", true, "Yunus", false, "AYIRGÜL", false, null, null, null, "YAYIRGUL@GMAIL.COM", "YAYIRGUL@GMAIL.COM", "AQAAAAIAAYagAAAAEB3cM9raBiYDolpPP7wPpz0avlkKGhLOErKByloGqFcx4vGOGpbPwIC8SIcNi2ugcQ==", "+905558008040", true, "2e2a8b70-9f3d-40fe-bcf0-80a2451038d9", false, "yayirgul@gmail.com" },
                    { new Guid("89da7c75-8291-4baf-9060-028a07393dde"), 0, null, "a2e4bac1-8f97-41bd-ac7e-6cefa4ca8920", new DateTime(2024, 7, 8, 0, 32, 36, 860, DateTimeKind.Local).AddTicks(7795), null, null, null, "erdem@makronet.com", true, "Erdem", false, "Tekin", false, null, null, null, "ERDEM@MAKRONET.COM", "ERDEM@MAKRONET.COM", "AQAAAAIAAYagAAAAEA9GX165YpgvRxBDRhEZpdlz4TJKFpXNGHiMvhvIQ+26K3Z0RGm+8PKd8a9L9zaHcA==", "+905558008050", true, "a1a84793-b072-49be-88b4-5c1c3cbf6881", false, "erdem@makronet.com" },
                    { new Guid("a35a610d-689f-4ab4-9324-cc227bfdbfba"), 0, null, "b94c447b-dd8b-4d8f-84a1-66a1e79051c5", new DateTime(2024, 7, 8, 0, 32, 36, 898, DateTimeKind.Local).AddTicks(8510), null, null, null, "umut@makronet.com", true, "Umut", false, "Arslan", false, null, null, null, "UMUT@MAKRONET.COM", "UMUT@MAKRONET.COM", "AQAAAAIAAYagAAAAEDez6OPAgB7WEEGM46NKXnFxU3LEGrWucmwqBuDIwcryQxNhjIQoW5W8sGObpGEYxg==", "+905558008060", true, "d694df45-4f0c-4451-b6b1-c3610d0d6d05", false, "umut@makronet.com" }
                });

            migrationBuilder.InsertData(
                table: "Apartments",
                columns: new[] { "Id", "AccountId", "ApartmentName", "CreateTime", "CreateUser", "DeletedTime", "DeletedUser", "IsActive", "IsDeleted", "IsStatus", "LanguageId", "ModifiedTime", "ModifiedUser" },
                values: new object[] { new Guid("d4033eef-ba92-4a1f-9ecb-1eee6996214a"), new Guid("db72e0e2-3201-414f-9753-190466e024f3"), "Huzur APT", new DateTime(2024, 7, 8, 0, 32, 36, 823, DateTimeKind.Local).AddTicks(7420), null, null, null, true, false, null, null, null, null });

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
                table: "Housings",
                columns: new[] { "Id", "AccountId", "ApartmentId", "CreateTime", "CreateUser", "DeletedTime", "DeletedUser", "HousingName", "IsActive", "IsDeleted", "IsStatus", "LanguageId", "ModifiedTime", "ModifiedUser", "UserId" },
                values: new object[] { new Guid("709a770b-66c6-4adc-bd19-6438117bf646"), new Guid("db72e0e2-3201-414f-9753-190466e024f3"), new Guid("d4033eef-ba92-4a1f-9ecb-1eee6996214a"), new DateTime(2024, 7, 8, 0, 32, 36, 935, DateTimeKind.Local).AddTicks(4399), null, null, null, "Daire 1", true, false, null, null, null, null, null });

            migrationBuilder.InsertData(
                table: "HousingSafes",
                columns: new[] { "Id", "AccountId", "Amount", "ApartmentId", "CreateTime", "CreateUser", "DeletedTime", "DeletedUser", "HousingId", "IsActive", "IsDeleted", "IsStatus", "LanguageId", "ModifiedTime", "ModifiedUser", "UserId" },
                values: new object[] { new Guid("666776f7-518b-4805-a726-eba238e03fc4"), new Guid("db72e0e2-3201-414f-9753-190466e024f3"), 100m, new Guid("d4033eef-ba92-4a1f-9ecb-1eee6996214a"), new DateTime(2024, 7, 8, 0, 32, 36, 935, DateTimeKind.Local).AddTicks(5018), null, null, null, new Guid("709a770b-66c6-4adc-bd19-6438117bf646"), true, false, null, null, null, null, null });

            migrationBuilder.CreateIndex(
                name: "IX_Apartments_AccountId",
                table: "Apartments",
                column: "AccountId");

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
                name: "IX_Housings_UserId",
                table: "Housings",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_HousingSafes_AccountId",
                table: "HousingSafes",
                column: "AccountId");

            migrationBuilder.CreateIndex(
                name: "IX_HousingSafes_ApartmentId",
                table: "HousingSafes",
                column: "ApartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_HousingSafes_HousingId",
                table: "HousingSafes",
                column: "HousingId");

            migrationBuilder.CreateIndex(
                name: "IX_HousingSafes_UserId",
                table: "HousingSafes",
                column: "UserId");
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
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Accounts");
        }
    }
}
