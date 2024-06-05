﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookStoreApp.API.Migrations
{
    /// <inheritdoc />
    public partial class MyFirstMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.CreateTable(
            //    name: "Authors",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Bio = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__Authors__3214EC0701CC0B0A", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Books",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        Title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Year = table.Column<int>(type: "int", nullable: false),
            //        ISBN = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
            //        Summary = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
            //        Image = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Price = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
            //        AuthorID = table.Column<int>(type: "int", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__Books__3214EC07C5076328", x => x.Id);
            //        table.ForeignKey(
            //            name: "FK_Books_ToTable",
            //            column: x => x.AuthorID,
            //            principalTable: "Authors",
            //            principalColumn: "Id");
            //    });

            //migrationBuilder.CreateIndex(
            //    name: "IX_Books_AuthorID",
            //    table: "Books",
            //    column: "AuthorID");

            //migrationBuilder.CreateIndex(
            //    name: "UQ__Books__447D36EA90C5EE2C",
            //    table: "Books",
            //    column: "ISBN",
            //    unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropTable(
            //    name: "Books");

            //migrationBuilder.DropTable(
            //    name: "Authors");
        }
    }
}
