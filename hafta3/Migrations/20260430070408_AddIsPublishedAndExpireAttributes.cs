using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace hafta3.Migrations
{
    /// <inheritdoc />
    public partial class AddIsPublishedAndExpireAttributes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Expire",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "isPublished",
                table: "Products",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Expire",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "isPublished",
                table: "Products");
        }
    }
}
