using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace server.Data.Migrations
{
    /// <inheritdoc />
    public partial class updated_event : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bbb97649-0c25-4dd9-b5ae-ae308c432fbe");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d6019389-954b-441d-bdbf-105b26753cce");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d9cef42c-00a7-42eb-ad5e-a0f40819c605");

            migrationBuilder.AddColumn<string>(
                name: "Link",
                table: "Events",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<decimal>(
                name: "Price",
                table: "Events",
                type: "TEXT",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "Events",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1c138f53-5e65-434d-a905-469599d0d1bd", null, "Mentor", "MENTOR" },
                    { "4d8bc0a0-a66a-4d6a-b296-812c7323f0bf", null, "Member", "MEMBER" },
                    { "fc980893-adfb-41b6-8ccc-47dff282788d", null, "Admin", "ADMIN" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1c138f53-5e65-434d-a905-469599d0d1bd");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4d8bc0a0-a66a-4d6a-b296-812c7323f0bf");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fc980893-adfb-41b6-8ccc-47dff282788d");

            migrationBuilder.DropColumn(
                name: "Link",
                table: "Events");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "Events");

            migrationBuilder.DropColumn(
                name: "Title",
                table: "Events");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "bbb97649-0c25-4dd9-b5ae-ae308c432fbe", null, "Admin", "ADMIN" },
                    { "d6019389-954b-441d-bdbf-105b26753cce", null, "Member", "MEMBER" },
                    { "d9cef42c-00a7-42eb-ad5e-a0f40819c605", null, "Mentor", "MENTOR" }
                });
        }
    }
}
