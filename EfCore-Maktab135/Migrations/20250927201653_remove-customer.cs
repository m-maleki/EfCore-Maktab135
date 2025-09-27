using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EfCore_Maktab135.Migrations
{
    /// <inheritdoc />
    public partial class removecustomer : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderItems_Customers_CustomerId",
                table: "OrderItems");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropIndex(
                name: "IX_OrderItems_CustomerId",
                table: "OrderItems");

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "OrderItems",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_UserId",
                table: "OrderItems",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderItems_Users_UserId",
                table: "OrderItems",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderItems_Users_UserId",
                table: "OrderItems");

            migrationBuilder.DropIndex(
                name: "IX_OrderItems_UserId",
                table: "OrderItems");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "OrderItems");

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_CustomerId",
                table: "OrderItems",
                column: "CustomerId");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderItems_Customers_CustomerId",
                table: "OrderItems",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
