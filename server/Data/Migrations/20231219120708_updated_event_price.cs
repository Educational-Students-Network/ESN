using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace server.Data.Migrations
{
    /// <inheritdoc />
    public partial class updated_event_price : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "2872b9ec-e05a-42a4-981f-c45a75e67380", null, "Member", "MEMBER" },
                    { "3f2bda94-ccb1-4a16-bea6-67e5dfc50f66", null, "Mentor", "MENTOR" },
                    { "99e704f1-eb98-452a-b367-f432a79c0681", null, "Admin", "ADMIN" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2872b9ec-e05a-42a4-981f-c45a75e67380");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3f2bda94-ccb1-4a16-bea6-67e5dfc50f66");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "99e704f1-eb98-452a-b367-f432a79c0681");

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
    }
}
