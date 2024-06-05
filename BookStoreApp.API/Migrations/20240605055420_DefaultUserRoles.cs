using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BookStoreApp.API.Migrations
{
    /// <inheritdoc />
    public partial class DefaultUserRoles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "9902c2a7-3346-4a98-a4ed-a45f2a03811e", null, "Administrator", "ADMINISTRATOR" },
                    { "b8cce846-0fa4-4c0a-9db3-8441222ff29d", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "4a76952b-d20b-4d26-a671-aaaf7779488b", 0, "4e68e45d-01af-4369-b777-e686063fb99b", "admin@bookstore.com", false, "System", "Admin", false, null, "ADMIN@BOOKSTORE.COM", "ADMIN@BOOKSTORE.COM", "AQAAAAIAAYagAAAAEPfNOu/W5ekiBIQBA0UqumoarN0LjV51pz0ypBNNrxzVLBVhsgykQEM/Z0ZeYnIiDg==", null, false, "49ad7cfa-69cd-4c38-962a-dc9f4aa1518d", false, "admin@bookstore.com" },
                    { "c0b79b5d-7987-4214-9cc6-f7f5be3b3d42", 0, "3caf6188-eeba-474e-8118-5aee772d21b2", "user@bookstore.com", false, "System", "User", false, null, "USER@BOOKSTORE.COM", "USER@BOOKSTORE.COM", "AQAAAAIAAYagAAAAEIA0G2mNEJuEHQRtO+ebCmXf2vXW0YHYI7tGAErPxuMLVQWXU8fqg++aNYgfNGqrKA==", null, false, "a9dabe90-86e1-4e33-8c29-378c55b8f824", false, "user@bookstore.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "9902c2a7-3346-4a98-a4ed-a45f2a03811e", "4a76952b-d20b-4d26-a671-aaaf7779488b" },
                    { "b8cce846-0fa4-4c0a-9db3-8441222ff29d", "c0b79b5d-7987-4214-9cc6-f7f5be3b3d42" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "9902c2a7-3346-4a98-a4ed-a45f2a03811e", "4a76952b-d20b-4d26-a671-aaaf7779488b" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "b8cce846-0fa4-4c0a-9db3-8441222ff29d", "c0b79b5d-7987-4214-9cc6-f7f5be3b3d42" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9902c2a7-3346-4a98-a4ed-a45f2a03811e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b8cce846-0fa4-4c0a-9db3-8441222ff29d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4a76952b-d20b-4d26-a671-aaaf7779488b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c0b79b5d-7987-4214-9cc6-f7f5be3b3d42");
        }
    }
}
