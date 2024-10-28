using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BusinessObjects.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AccountMember",
                columns: table => new
                {
                    MemberID = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    MemberPassword = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false),
                    MemberName = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false),
                    EmailAddress = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    MemberRole = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccountMember", x => x.MemberID);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryID);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductName = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    CategoryID = table.Column<int>(type: "int", nullable: false),
                    UnitsInStock = table.Column<int>(type: "int", nullable: true),
                    Price = table.Column<decimal>(type: "money", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductId);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryID",
                        column: x => x.CategoryID,
                        principalTable: "Categories",
                        principalColumn: "CategoryID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AccountMember",
                columns: new[] { "MemberID", "EmailAddress", "MemberName", "MemberPassword", "MemberRole" },
                values: new object[,]
                {
                    { "PS0001", "admin@CompanyName.com", "Administrator", "@1", 1 },
                    { "PS0002", "staff@CompanyName.com", "Staff", "@2", 2 },
                    { "PS0003", "member1@CompanyName.com", "Member 1", "@3", 3 },
                    { "PS0004", "member2@CompanyName.com", "Member 2", "@3", 3 }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryID", "CategoryName" },
                values: new object[,]
                {
                    { 1, "Beverages" },
                    { 2, "Condiments" },
                    { 3, "Confections" },
                    { 4, "Dairy Products" },
                    { 5, "Grains/Cereals" },
                    { 6, "Meat/Poultry" },
                    { 7, "Produce" },
                    { 8, "Seafood" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "CategoryID", "Price", "ProductName", "UnitsInStock" },
                values: new object[,]
                {
                    { 1, 3, 18.00m, "Chai", 12 },
                    { 2, 1, 19.00m, "Chang", 23 },
                    { 3, 2, 10.00m, "Aniseed Syrup", 23 },
                    { 4, 2, 22.00m, "Chef Anton's Cajun Seasoning", 34 },
                    { 5, 2, 21.35m, "Chef Anton's Gumbo Mix", 45 },
                    { 6, 2, 25.00m, "Grandma's Boysenberry Spread", 21 },
                    { 7, 7, 30.00m, "Uncle Bob's Organic Dried Pears", 22 },
                    { 8, 2, 40.00m, "Northwoods Cranberry Sauce", 10 },
                    { 9, 6, 97.00m, "Mishi Kobe Niku", 12 },
                    { 10, 8, 31.00m, "Ikura", 13 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryID",
                table: "Products",
                column: "CategoryID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AccountMember");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
