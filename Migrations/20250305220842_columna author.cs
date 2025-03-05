using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Albums.Migrations
{
    /// <inheritdoc />
    public partial class columnaauthor : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "GenreName",
                table: "Albums");

            migrationBuilder.AddColumn<string>(
                name: "Author",
                table: "Albums",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Author",
                table: "Albums");

            migrationBuilder.AddColumn<string>(
                name: "GenreName",
                table: "Albums",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
