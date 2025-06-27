using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BusinessCardWeb.Server.Migrations
{
    /// <inheritdoc />
    public partial class ModifyTableMemberJobTitle : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FaIcon",
                table: "MemberJobTitle",
                type: "TEXT",
                maxLength: 100,
                nullable: true)
                .Annotation("Relational:ColumnOrder", 4);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FaIcon",
                table: "MemberJobTitle");
        }
    }
}
