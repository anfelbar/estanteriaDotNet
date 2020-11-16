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
                keyValue: "09f9fc09-acf5-4488-b473-2d953f68fff2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b0411721-5a2d-4925-a64a-0b05ff0f447e");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "1b9abbc4-6a7e-47d9-bfc0-59a02c64ea49", "f3ffbc8b-7e78-4786-83ae-c7158bdd394e", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "037c3f11-9eac-4260-9c19-422215634cd5", "77ef8b86-817c-4ccd-8cc3-c4f5ab9b6cc6", "Admin", "ADMIN" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "037c3f11-9eac-4260-9c19-422215634cd5");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1b9abbc4-6a7e-47d9-bfc0-59a02c64ea49");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "b0411721-5a2d-4925-a64a-0b05ff0f447e", "7d3bc292-86f0-494a-a023-bc02810afb35", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "09f9fc09-acf5-4488-b473-2d953f68fff2", "ea227d82-75f0-4b17-aa28-1feb9387509d", "Admin", "ADMIN" });
        }
    }
}
