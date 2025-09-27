using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EfCore_Maktab135.Migrations
{
    /// <inheritdoc />
    public partial class fixrelations2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CustomerId",
                table: "OrderItems");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CustomerId",
                table: "OrderItems",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
