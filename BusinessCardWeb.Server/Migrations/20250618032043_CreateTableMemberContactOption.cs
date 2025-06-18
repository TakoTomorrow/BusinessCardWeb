using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BusinessCardWeb.Server.Migrations
{
    /// <inheritdoc />
    public partial class CreateTableMemberContactOption : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MemberContactOption",
                columns: table => new
                {
                    MemberId = table.Column<int>(type: "INTEGER", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Value = table.Column<string>(type: "TEXT", nullable: false),
                    ValueShort = table.Column<string>(type: "TEXT", nullable: false),
                    FaIcon = table.Column<string>(type: "TEXT", nullable: false),
                    Href = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MemberContactOption", x => new { x.MemberId, x.Name });
                    table.ForeignKey(
                        name: "FK_MemberContactOption_Member_MemberId",
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
                name: "MemberContactOption");
        }
    }
}
