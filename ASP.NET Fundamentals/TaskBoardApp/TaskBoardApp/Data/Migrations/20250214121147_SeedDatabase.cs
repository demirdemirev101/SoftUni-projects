using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TaskBoardApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Boards",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Boards", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tasks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(70)", maxLength: 70, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BoardId = table.Column<int>(type: "int", nullable: false),
                    OwnerId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tasks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tasks_AspNetUsers_OwnerId",
                        column: x => x.OwnerId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Tasks_Boards_BoardId",
                        column: x => x.BoardId,
                        principalTable: "Boards",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "67a1eaf8-358f-4c8d-ad1e-327f0f1d4932", 0, "e0b89370-3b68-426e-8fd4-5a50c231d863", null, false, false, null, null, "TEST@SOFTUNI.BG", "AQAAAAIAAYagAAAAEAgYC+b3yMk5zyOeshgKfUKokvQb5M7Zfo/sJ2/TbQLmoGzjKZ8dV9ptyqcx917AsA==", null, false, "2602d6b8-2a5f-4858-b434-4e8a61de48f8", false, "test@softuni.bg" });

            migrationBuilder.InsertData(
                table: "Boards",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Open" },
                    { 2, "In Progess" },
                    { 3, "Done" }
                });

            migrationBuilder.InsertData(
                table: "Tasks",
                columns: new[] { "Id", "BoardId", "CreatedOn", "Description", "OwnerId", "Title" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2024, 7, 29, 14, 11, 46, 580, DateTimeKind.Local).AddTicks(1355), "Implement better styling for all public pages", "67a1eaf8-358f-4c8d-ad1e-327f0f1d4932", "Improve CSS styles" },
                    { 2, 1, new DateTime(2024, 9, 14, 14, 11, 46, 580, DateTimeKind.Local).AddTicks(1414), "Create Android client app for the TaskBoard RESTful API", "67a1eaf8-358f-4c8d-ad1e-327f0f1d4932", "Android Client App" },
                    { 3, 2, new DateTime(2025, 1, 14, 14, 11, 46, 580, DateTimeKind.Local).AddTicks(1419), "Create Windows Forms desktop app client for the TaskBoard RESTful API", "67a1eaf8-358f-4c8d-ad1e-327f0f1d4932", "Desktop Client App" },
                    { 4, 3, new DateTime(2025, 2, 13, 14, 11, 46, 580, DateTimeKind.Local).AddTicks(1421), "Implement [Create Task] page for adding new tasks", "67a1eaf8-358f-4c8d-ad1e-327f0f1d4932", "Create Tasks" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Tasks_BoardId",
                table: "Tasks",
                column: "BoardId");

            migrationBuilder.CreateIndex(
                name: "IX_Tasks_OwnerId",
                table: "Tasks",
                column: "OwnerId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tasks");

            migrationBuilder.DropTable(
                name: "Boards");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "67a1eaf8-358f-4c8d-ad1e-327f0f1d4932");
        }
    }
}
