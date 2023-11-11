using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AkarSoftware.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class InitalCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Advertiesments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Description = table.Column<string>(type: "ntext", nullable: false),
                    ApplicationStatus = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 11, 11, 16, 37, 16, 168, DateTimeKind.Local).AddTicks(9744)),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Advertiesments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AdvertiesmentUserApplyStatuses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Status = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    StatuDescription = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdvertiesmentUserApplyStatuses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppRoles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Genders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genders", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MilitaryStatuses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Status = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    StatusDescription = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MilitaryStatuses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProviderServices",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "ntext", nullable: false),
                    ListOrder = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 11, 11, 16, 37, 16, 170, DateTimeKind.Local).AddTicks(6483)),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProviderServices", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppUsers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    OptionalName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorAuthenticaton = table.Column<bool>(type: "bit", nullable: false),
                    AlwaysLockAccount = table.Column<bool>(type: "bit", nullable: false),
                    LockOutEndDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 11, 11, 16, 37, 16, 170, DateTimeKind.Local).AddTicks(574)),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    GendersId = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AppUsers_Genders_GendersId",
                        column: x => x.GendersId,
                        principalTable: "Genders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AdvertiesmentStatuses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CoverLetter = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    WorkExperiance = table.Column<int>(type: "int", precision: 0, scale: 100, nullable: false),
                    CvPath = table.Column<string>(type: "nvarchar(MAX)", nullable: false),
                    AppUserId = table.Column<int>(type: "int", nullable: false),
                    AdvertiesmentId = table.Column<int>(type: "int", nullable: false),
                    AdvertiesmentUserApplyStatusId = table.Column<int>(type: "int", nullable: false),
                    MilitaryStatusId = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdvertiesmentStatuses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AdvertiesmentStatuses_AdvertiesmentUserApplyStatuses_AdvertiesmentUserApplyStatusId",
                        column: x => x.AdvertiesmentUserApplyStatusId,
                        principalTable: "AdvertiesmentUserApplyStatuses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AdvertiesmentStatuses_Advertiesments_AdvertiesmentId",
                        column: x => x.AdvertiesmentId,
                        principalTable: "Advertiesments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AdvertiesmentStatuses_AppUsers_AppUserId",
                        column: x => x.AppUserId,
                        principalTable: "AppUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AdvertiesmentStatuses_MilitaryStatuses_MilitaryStatusId",
                        column: x => x.MilitaryStatusId,
                        principalTable: "MilitaryStatuses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AppUserRoles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AppUserId = table.Column<int>(type: "int", nullable: false),
                    BaseRoleId = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUserRoles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AppUserRoles_AppRoles_BaseRoleId",
                        column: x => x.BaseRoleId,
                        principalTable: "AppRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AppUserRoles_AppUsers_AppUserId",
                        column: x => x.AppUserId,
                        principalTable: "AppUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AppRoles",
                columns: new[] { "Id", "Description", "IsActive", "RoleName" },
                values: new object[,]
                {
                    { 1, "Sadece İş başvurularında bulunabilecek olan adaylar için roldür.", true, "Aday" },
                    { 2, "İlgili rol sistem yöneticilerine ve insan kaynakları için ayrılmıştır.", true, "Admin" }
                });

            migrationBuilder.InsertData(
                table: "Genders",
                columns: new[] { "Id", "IsActive", "Name" },
                values: new object[,]
                {
                    { 1, true, "Erkek" },
                    { 2, true, "Kadın" },
                    { 3, true, "Belirtmek İstemiyor" }
                });

            migrationBuilder.InsertData(
                table: "MilitaryStatuses",
                columns: new[] { "Id", "IsActive", "Status", "StatusDescription" },
                values: new object[,]
                {
                    { 1, true, "Yapıldı", "Askerliğini yapan kişiler için teşkil etmektedir." },
                    { 2, true, "Tecilli", "Askerliğini şuan için yapmamış ve yapma zorunluluğu olan kişiler için elverişlidir" },
                    { 3, true, "Muaf", "Askerlik durumunun muaf olması durumu temsil edilmektedir." },
                    { 4, true, "Yapılacak - Bedelli", "İlgili başvuruda başvuran adayın askerlik zorunluluğunun olduğu fakat bedelli kategorisinde ilgili sürecin gerçekleştirileceği planlanmıştır" }
                });

            migrationBuilder.InsertData(
                table: "AppUsers",
                columns: new[] { "Id", "AlwaysLockAccount", "CreateDate", "Email", "EmailConfirmed", "FirstName", "GendersId", "IsActive", "LastName", "LockOutEndDate", "OptionalName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Status", "TwoFactorAuthenticaton", "UpdatedDate", "UserName" },
                values: new object[,]
                {
                    { 1, false, new DateTime(2023, 11, 11, 16, 37, 16, 170, DateTimeKind.Local).AddTicks(7158), "m.berkay.akar@gmail.com", true, "Berkay", 1, true, "Akar", null, "", "EE8F61B03B6B1D0FC1171EAE7D20BC689F2502D8679574007CB6939D1F8AFF94", "+905345413410", true, true, false, new DateTime(2023, 11, 11, 16, 37, 16, 170, DateTimeKind.Local).AddTicks(7159), "BERKAY" },
                    { 2, false, new DateTime(2023, 11, 11, 16, 37, 16, 170, DateTimeKind.Local).AddTicks(7374), "ahmet.akar@gmail.com", true, "Ahmet", 1, true, "Akar", null, "", "EE8F61B03B6B1D0FC1171EAE7D20BC689F2502D8679574007CB6939D1F8AFF94", "+90111111111", true, true, false, new DateTime(2023, 11, 11, 16, 37, 16, 170, DateTimeKind.Local).AddTicks(7375), "AHMET" }
                });

            migrationBuilder.InsertData(
                table: "AppUserRoles",
                columns: new[] { "Id", "AppUserId", "BaseRoleId", "IsActive" },
                values: new object[,]
                {
                    { 1, 1, 2, true },
                    { 2, 2, 1, true }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AdvertiesmentStatuses_AdvertiesmentId_AppUserId",
                table: "AdvertiesmentStatuses",
                columns: new[] { "AdvertiesmentId", "AppUserId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AdvertiesmentStatuses_AdvertiesmentUserApplyStatusId",
                table: "AdvertiesmentStatuses",
                column: "AdvertiesmentUserApplyStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_AdvertiesmentStatuses_AppUserId",
                table: "AdvertiesmentStatuses",
                column: "AppUserId");

            migrationBuilder.CreateIndex(
                name: "IX_AdvertiesmentStatuses_MilitaryStatusId",
                table: "AdvertiesmentStatuses",
                column: "MilitaryStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_AppUserRoles_AppUserId_BaseRoleId",
                table: "AppUserRoles",
                columns: new[] { "AppUserId", "BaseRoleId" });

            migrationBuilder.CreateIndex(
                name: "IX_AppUserRoles_BaseRoleId",
                table: "AppUserRoles",
                column: "BaseRoleId");

            migrationBuilder.CreateIndex(
                name: "IX_AppUsers_Email",
                table: "AppUsers",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AppUsers_GendersId",
                table: "AppUsers",
                column: "GendersId");

            migrationBuilder.CreateIndex(
                name: "IX_AppUsers_PhoneNumber",
                table: "AppUsers",
                column: "PhoneNumber",
                unique: true,
                filter: "[PhoneNumber] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AppUsers_UserName",
                table: "AppUsers",
                column: "UserName",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AdvertiesmentStatuses");

            migrationBuilder.DropTable(
                name: "AppUserRoles");

            migrationBuilder.DropTable(
                name: "ProviderServices");

            migrationBuilder.DropTable(
                name: "AdvertiesmentUserApplyStatuses");

            migrationBuilder.DropTable(
                name: "Advertiesments");

            migrationBuilder.DropTable(
                name: "MilitaryStatuses");

            migrationBuilder.DropTable(
                name: "AppRoles");

            migrationBuilder.DropTable(
                name: "AppUsers");

            migrationBuilder.DropTable(
                name: "Genders");
        }
    }
}
