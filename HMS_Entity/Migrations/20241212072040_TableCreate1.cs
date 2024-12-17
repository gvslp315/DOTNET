using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HMS_Entity.Migrations
{
    /// <inheritdoc />
    public partial class TableCreate1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "mSpecial",
                table: "Medical",
                type: "text",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "mSpecial",
                table: "Medical");
        }
    }
}
