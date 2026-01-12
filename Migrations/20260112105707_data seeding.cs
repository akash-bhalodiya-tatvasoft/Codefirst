using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Codefirst.Migrations
{
    /// <inheritdoc />
    public partial class dataseeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Description", "IsActive", "Name" },
                values: new object[] { 1, "Electronic gadgets and devices", true, "Electronics" });

            migrationBuilder.InsertData(
                table: "UserProfiles",
                columns: new[] { "Id", "Email", "FirstName", "IsActive", "LastName" },
                values: new object[] { 1, "john.doe@example.com", "John", true, "Doe" });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "Status", "TotalAmount", "UserId" },
                values: new object[] { 1, 1, 649.99m, 1 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "DiscountEndOn", "DiscountedPrice", "Name", "Price", "ProductImage", "ProductImageUrl", "Quantity" },
                values: new object[] { 1, 1, "Latest model smartphone", null, 649.99m, "Smartphone", 699.99m, null, null, 50 });

            migrationBuilder.InsertData(
                table: "OrderItems",
                columns: new[] { "Id", "OrderId", "ProductId", "Quantity", "TotalPrice", "UnitPrice" },
                values: new object[] { 1, 1, 1, 1, 649.99m, 649.99m });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "UserProfiles",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
