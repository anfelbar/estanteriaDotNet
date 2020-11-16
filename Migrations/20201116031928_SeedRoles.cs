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
                keyValue: "314d149b-c24d-4c0e-bc28-9093c436ef9a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9bbd7dbc-5351-4c16-ac23-03c9bc1682c5");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ef97190f-c89e-4f8c-b221-fc8e132bcc5c", "43910ad1-3063-4ea8-b73f-59b9c99e0ad8", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "cc8d0a41-f8cf-4518-a730-f9ebdbaaf91d", "3ef9ccf9-bf39-423f-9cd7-d111e8f6b888", "Admin", "ADMIN" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cc8d0a41-f8cf-4518-a730-f9ebdbaaf91d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ef97190f-c89e-4f8c-b221-fc8e132bcc5c");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "9bbd7dbc-5351-4c16-ac23-03c9bc1682c5", "5780864c-d059-4aa1-b4bf-9901e62d40e5", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "314d149b-c24d-4c0e-bc28-9093c436ef9a", "beaf0e41-d3e2-42fd-96e5-8a189f1b19ae", "Admin", "ADMIN" });
        }
    }
}
