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
                keyValue: "61312af6-afc7-4229-a524-957c39ba3753");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "73e6b8b6-3e73-464a-872f-7c61c9bbf301");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "194f8357-f9ce-468c-94da-aefbc0d440b9", "2000c684-6a1a-4ba8-9904-5e20a85535ba", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "543f5d51-8dc4-4751-8012-50dc6805c582", "a42f2838-ab55-4b1f-b728-4ef41907df6d", "Admin", "ADMIN" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "194f8357-f9ce-468c-94da-aefbc0d440b9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "543f5d51-8dc4-4751-8012-50dc6805c582");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "73e6b8b6-3e73-464a-872f-7c61c9bbf301", "8dd97a0a-3e00-4bdb-b440-28f272a76dba", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "61312af6-afc7-4229-a524-957c39ba3753", "0714b820-137d-4631-bfce-817934555cfd", "Admin", "ADMIN" });
        }
    }
}
