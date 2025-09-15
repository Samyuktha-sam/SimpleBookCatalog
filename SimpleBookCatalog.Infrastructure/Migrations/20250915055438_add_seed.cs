using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SimpleBookCatalog.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class add_seed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Books",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Author",
                table: "Books",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Author", "Category", "PublicationDate", "Title" },
                values: new object[,]
                {
                    { 1, "Jane Appleton", 1, new DateTime(2020, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Science of Everything" },
                    { 2, "John Fit", 3, new DateTime(2022, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Modern Fitness Guide" },
                    { 3, "Sara Tech", 2, new DateTime(2021, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tech Innovations" },
                    { 4, "Marco Polo", 4, new DateTime(2019, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "World Travel Atlas" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Books",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<string>(
                name: "Author",
                table: "Books",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");
        }
    }
}
