using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace server.Data.Migrations
{
    /// <inheritdoc />
    public partial class EventsAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3d0523a1-4e4b-416f-b2d8-d7f6cff9227e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "471ed4b6-0e29-4b25-8e1c-dbf1943392cb");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9f701682-f2f4-479e-b000-394e29ee67a0");

            migrationBuilder.CreateTable(
                name: "Events",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Speakers = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    Time = table.Column<string>(type: "TEXT", nullable: false),
                    AuthorUsername = table.Column<string>(type: "TEXT", nullable: false),
                    Place = table.Column<string>(type: "TEXT", nullable: false),
                    PictureUrl = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Events", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "61a33503-f23d-4a0c-9aea-62d8e1df73f5", null, "Member", "MEMBER" },
                    { "704dbf39-6a23-4219-9336-079f25aa8adf", null, "Admin", "ADMIN" },
                    { "b8dbfff7-4ad2-4236-aceb-16f38d6f8565", null, "Mentor", "MENTOR" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Events");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "61a33503-f23d-4a0c-9aea-62d8e1df73f5");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "704dbf39-6a23-4219-9336-079f25aa8adf");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b8dbfff7-4ad2-4236-aceb-16f38d6f8565");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "3d0523a1-4e4b-416f-b2d8-d7f6cff9227e", null, "Member", "MEMBER" },
                    { "471ed4b6-0e29-4b25-8e1c-dbf1943392cb", null, "Admin", "ADMIN" },
                    { "9f701682-f2f4-479e-b000-394e29ee67a0", null, "Mentor", "MENTOR" }
                });
        }
    }
}
