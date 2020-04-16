using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SE.DAL.Migrations
{
    public partial class SEDALSEContext : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    Surname = table.Column<string>(maxLength: 50, nullable: false),
                    Email = table.Column<string>(maxLength: 50, nullable: false),
                    Password = table.Column<string>(maxLength: 100, nullable: false),
                    Role = table.Column<int>(nullable: false),
                    IsConfirmed = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Materials",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    UserId = table.Column<Guid>(maxLength: 50, nullable: false),
                    Description = table.Column<string>(maxLength: 500, nullable: false),
                    Status = table.Column<string>(maxLength: 500, nullable: false),
                    PublishingDate = table.Column<DateTime>(nullable: false),
                    Auditory = table.Column<int>(nullable: false),
                    Theme = table.Column<string>(nullable: false),
                    Type = table.Column<int>(nullable: false),
                    DownloadingLink = table.Column<string>(maxLength: 500, nullable: false),
                    Picture = table.Column<byte[]>(nullable: true),
                    SourceOfInformation = table.Column<string>(maxLength: 500, nullable: false),
                    Rating = table.Column<double>(nullable: false),
                    DownloadsCount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Materials", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Materials_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    UserId = table.Column<Guid>(nullable: false),
                    MaterialId = table.Column<Guid>(nullable: false),
                    Text = table.Column<string>(maxLength: 1000, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Comments_Materials_MaterialId",
                        column: x => x.MaterialId,
                        principalTable: "Materials",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Comments_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Downloadings",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    UserId = table.Column<Guid>(nullable: false),
                    MaterialId = table.Column<Guid>(nullable: false),
                    DownloadingDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Downloadings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Downloadings_Materials_MaterialId",
                        column: x => x.MaterialId,
                        principalTable: "Materials",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Downloadings_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Ratings",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    UserId = table.Column<Guid>(nullable: false),
                    MaterialId = table.Column<Guid>(nullable: false),
                    Value = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ratings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ratings_Materials_MaterialId",
                        column: x => x.MaterialId,
                        principalTable: "Materials",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Ratings_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "IsConfirmed", "Name", "Password", "Role", "Surname" },
                values: new object[] { new Guid("903a743e-9427-4a05-a762-ff92a91fdb1d"), "admin@admin.com", true, "admin", "033f23c9312b5f9838f246c0a7f2f2a5694bbf3657a56cc13d55d7350ed19b64", 0, "admin" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "IsConfirmed", "Name", "Password", "Role", "Surname" },
                values: new object[] { new Guid("c1f3b7d8-1094-4dbe-a3bb-b33ecc0300cb"), "max.grechuha@mail.ru", true, "Max", "1c42ef9417334bfe00556b05bac80fc54d1db239c647e3a6b5d57537c94bccf4", 1, "Grechuha" });

            migrationBuilder.CreateIndex(
                name: "IX_Comments_MaterialId",
                table: "Comments",
                column: "MaterialId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_UserId",
                table: "Comments",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Downloadings_MaterialId",
                table: "Downloadings",
                column: "MaterialId");

            migrationBuilder.CreateIndex(
                name: "IX_Downloadings_UserId",
                table: "Downloadings",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Materials_UserId",
                table: "Materials",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Ratings_MaterialId",
                table: "Ratings",
                column: "MaterialId");

            migrationBuilder.CreateIndex(
                name: "IX_Ratings_UserId",
                table: "Ratings",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropTable(
                name: "Downloadings");

            migrationBuilder.DropTable(
                name: "Ratings");

            migrationBuilder.DropTable(
                name: "Materials");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
