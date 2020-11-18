using Microsoft.EntityFrameworkCore.Migrations;

namespace Estanteria.Migrations
{
    public partial class SeedRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "61171dc2-8172-4761-a8a3-bd0601ff996b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6d6b6411-ea45-484e-8dba-ef927c81c8c1");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d772d075-2283-4662-8992-eeeede4fa063", "1c3d3fc8-923c-49e2-b230-3ca56cc359ba", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "0c3e5113-c256-44d6-9424-1f39313c4e39", "5d40c1bf-8391-4b5b-a71f-72a51fb227c3", "Admin", "ADMIN" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0c3e5113-c256-44d6-9424-1f39313c4e39");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d772d075-2283-4662-8992-eeeede4fa063");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "61171dc2-8172-4761-a8a3-bd0601ff996b", "71e68032-fc28-47e9-a69f-d46b374cdc11", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "6d6b6411-ea45-484e-8dba-ef927c81c8c1", "13708a30-f6f5-405b-a6a3-6e19285f28d9", "Admin", "ADMIN" });
        }
    }
}
