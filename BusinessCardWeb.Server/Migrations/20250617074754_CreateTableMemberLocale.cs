using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BusinessCardWeb.Server.Migrations
{
    /// <inheritdoc />
    public partial class CreateTableMemberLocale : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MemberLocale",
                columns: table => new
                {
                    MemberId = table.Column<int>(type: "INTEGER", nullable: false),
                    Locale = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Credits = table.Column<string>(type: "TEXT", nullable: false),
                    Role = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MemberLocale", x => new { x.MemberId, x.Locale });
                    table.ForeignKey(
                        name: "FK_MemberLocale_Member_MemberId",
                        column: x => x.MemberId,
                        principalTable: "Member",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MemberLocale");
        }
    }
}
