using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SE.DAL.Migrations
{
    public partial class MaterialChanges : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("903a743e-9427-4a05-a762-ff92a91fdb1d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c1f3b7d8-1094-4dbe-a3bb-b33ecc0300cb"));

            migrationBuilder.AlterColumn<string>(
                name: "Theme",
                table: "Materials",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "Status",
                table: "Materials",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500);

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "IsConfirmed", "Name", "Password", "Role", "Surname" },
                values: new object[] { new Guid("81044850-fb16-4bdb-abd2-210f345b9426"), "admin@admin.com", true, "admin", "033f23c9312b5f9838f246c0a7f2f2a5694bbf3657a56cc13d55d7350ed19b64", 0, "admin" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "IsConfirmed", "Name", "Password", "Role", "Surname" },
                values: new object[] { new Guid("40dd0b65-003a-4cef-b6f6-92566cbb6a7a"), "max.grechuha@mail.ru", true, "Max", "1c42ef9417334bfe00556b05bac80fc54d1db239c647e3a6b5d57537c94bccf4", 1, "Grechuha" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40dd0b65-003a-4cef-b6f6-92566cbb6a7a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("81044850-fb16-4bdb-abd2-210f345b9426"));

            migrationBuilder.AlterColumn<string>(
                name: "Theme",
                table: "Materials",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "Status",
                table: "Materials",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "IsConfirmed", "Name", "Password", "Role", "Surname" },
                values: new object[] { new Guid("903a743e-9427-4a05-a762-ff92a91fdb1d"), "admin@admin.com", true, "admin", "033f23c9312b5f9838f246c0a7f2f2a5694bbf3657a56cc13d55d7350ed19b64", 0, "admin" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "IsConfirmed", "Name", "Password", "Role", "Surname" },
                values: new object[] { new Guid("c1f3b7d8-1094-4dbe-a3bb-b33ecc0300cb"), "max.grechuha@mail.ru", true, "Max", "1c42ef9417334bfe00556b05bac80fc54d1db239c647e3a6b5d57537c94bccf4", 1, "Grechuha" });
        }
    }
}
