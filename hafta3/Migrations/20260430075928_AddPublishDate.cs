using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace hafta3.Migrations
{
    /// <inheritdoc />
    public partial class AddPublishDate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "PublishedDate",
                table: "Products",
                type: "datetime2",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PublishedDate",
                table: "Products");
        }
    }
}
