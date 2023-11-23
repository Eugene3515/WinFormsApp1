using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WinFormsApp1.Migrations
{
    /// <inheritdoc />
    public partial class agency3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_worker_workLists_workerId",
                table: "worker");

            migrationBuilder.DropIndex(
                name: "IX_worker_workerId",
                table: "worker");

            migrationBuilder.DropColumn(
                name: "workerId",
                table: "worker");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "workerId",
                table: "worker",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_worker_workerId",
                table: "worker",
                column: "workerId");

            migrationBuilder.AddForeignKey(
                name: "FK_worker_workLists_workerId",
                table: "worker",
                column: "workerId",
                principalTable: "workLists",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
