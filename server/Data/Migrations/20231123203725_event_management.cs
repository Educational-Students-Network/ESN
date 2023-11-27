using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace server.Data.Migrations
{
    /// <inheritdoc />
    public partial class event_management : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.RenameColumn(
                name: "AuthorUsername",
                table: "Events",
                newName: "UserId");

            migrationBuilder.CreateTable(
                name: "Comment",
                columns: table => new
                {
                    CommentId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Text = table.Column<string>(type: "TEXT", nullable: false),
                    Date = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UserId = table.Column<string>(type: "TEXT", nullable: false),
                    EventId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comment", x => x.CommentId);
                    table.ForeignKey(
                        name: "FK_Comment_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Comment_Events_EventId",
                        column: x => x.EventId,
                        principalTable: "Events",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Like",
                columns: table => new
                {
                    LikeId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserId = table.Column<string>(type: "TEXT", nullable: false),
                    EventId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Like", x => x.LikeId);
                    table.ForeignKey(
                        name: "FK_Like_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Like_Events_EventId",
                        column: x => x.EventId,
                        principalTable: "Events",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "8f9c3712-543f-4d4f-857e-b970b996c5db", null, "Mentor", "MENTOR" },
                    { "c022a6a9-169e-41f0-9bad-ed746550bfc9", null, "Admin", "ADMIN" },
                    { "cb659ff1-ca5f-4afa-9fa8-09e300edb74e", null, "Member", "MEMBER" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Events_UserId",
                table: "Events",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Comment_EventId",
                table: "Comment",
                column: "EventId");

            migrationBuilder.CreateIndex(
                name: "IX_Comment_UserId",
                table: "Comment",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Like_EventId",
                table: "Like",
                column: "EventId");

            migrationBuilder.CreateIndex(
                name: "IX_Like_UserId",
                table: "Like",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Events_AspNetUsers_UserId",
                table: "Events",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Events_AspNetUsers_UserId",
                table: "Events");

            migrationBuilder.DropTable(
                name: "Comment");

            migrationBuilder.DropTable(
                name: "Like");

            migrationBuilder.DropIndex(
                name: "IX_Events_UserId",
                table: "Events");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8f9c3712-543f-4d4f-857e-b970b996c5db");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c022a6a9-169e-41f0-9bad-ed746550bfc9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cb659ff1-ca5f-4afa-9fa8-09e300edb74e");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Events",
                newName: "AuthorUsername");

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
    }
}
