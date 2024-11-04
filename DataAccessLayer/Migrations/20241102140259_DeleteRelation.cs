using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class DeleteRelation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Restorants_Users_UserId",
                table: "Restorants");

            migrationBuilder.DropIndex(
                name: "IX_Restorants_UserId",
                table: "Restorants");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Restorants");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Restorants",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Restorants_UserId",
                table: "Restorants",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Restorants_Users_UserId",
                table: "Restorants",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
