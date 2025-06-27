using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BusinessCardWeb.Server.Migrations
{
    /// <inheritdoc />
    public partial class CreateTableMemberJobTitle : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MemberJobTitle",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    MemberId = table.Column<int>(type: "INTEGER", nullable: false),
                    Company = table.Column<string>(type: "TEXT", maxLength: 200, nullable: false),
                    JobTitle = table.Column<string>(type: "TEXT", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MemberJobTitle", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MemberJobTitle_Member_MemberId",
                        column: x => x.MemberId,
                        principalTable: "Member",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MemberJobTitle_MemberId",
                table: "MemberJobTitle",
                column: "MemberId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MemberJobTitle");
        }
    }
}
