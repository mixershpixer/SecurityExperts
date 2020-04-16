using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SE.DAL.Migrations
{
    public partial class ChangeMaterialTheme : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40dd0b65-003a-4cef-b6f6-92566cbb6a7a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("81044850-fb16-4bdb-abd2-210f345b9426"));

            migrationBuilder.AlterColumn<int>(
                name: "Theme",
                table: "Materials",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "IsConfirmed", "Name", "Password", "Role", "Surname" },
                values: new object[] { new Guid("bf363809-78e2-4a06-97cb-e1292798e9ba"), "admin@admin.com", true, "admin", "033f23c9312b5f9838f246c0a7f2f2a5694bbf3657a56cc13d55d7350ed19b64", 0, "admin" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "IsConfirmed", "Name", "Password", "Role", "Surname" },
                values: new object[] { new Guid("57bd4c9e-0d84-45e2-a1a4-b82d6c975112"), "max.grechuha@mail.ru", true, "Max", "1c42ef9417334bfe00556b05bac80fc54d1db239c647e3a6b5d57537c94bccf4", 1, "Grechuha" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("57bd4c9e-0d84-45e2-a1a4-b82d6c975112"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bf363809-78e2-4a06-97cb-e1292798e9ba"));

            migrationBuilder.AlterColumn<string>(
                name: "Theme",
                table: "Materials",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(int),
                oldMaxLength: 100);

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "IsConfirmed", "Name", "Password", "Role", "Surname" },
                values: new object[] { new Guid("81044850-fb16-4bdb-abd2-210f345b9426"), "admin@admin.com", true, "admin", "033f23c9312b5f9838f246c0a7f2f2a5694bbf3657a56cc13d55d7350ed19b64", 0, "admin" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "IsConfirmed", "Name", "Password", "Role", "Surname" },
                values: new object[] { new Guid("40dd0b65-003a-4cef-b6f6-92566cbb6a7a"), "max.grechuha@mail.ru", true, "Max", "1c42ef9417334bfe00556b05bac80fc54d1db239c647e3a6b5d57537c94bccf4", 1, "Grechuha" });
        }
    }
}
