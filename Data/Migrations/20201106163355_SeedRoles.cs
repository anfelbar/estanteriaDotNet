using Microsoft.EntityFrameworkCore.Migrations;

namespace Estanteria.Data.Migrations
{
    public partial class SeedRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "1c2cc76b-249f-4628-9033-64296ccef14f", "151b3a0d-fa99-4891-9591-dfa03897455b", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "8e23845e-5195-4e0d-a37f-aeb018f1f46f", "99c2eedf-89c5-4230-a137-9badf76c7a7f", "Admin", "ADMIN" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1c2cc76b-249f-4628-9033-64296ccef14f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8e23845e-5195-4e0d-a37f-aeb018f1f46f");
        }
    }
}
