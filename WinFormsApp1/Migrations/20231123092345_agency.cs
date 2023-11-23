using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WinFormsApp1.Migrations
{
    /// <inheritdoc />
    public partial class agency : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_worker_workLists_WorklistId",
                table: "worker");

            migrationBuilder.RenameColumn(
                name: "WorklistId",
                table: "worker",
                newName: "workerId");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "worker",
                newName: "Names");

            migrationBuilder.RenameIndex(
                name: "IX_worker_WorklistId",
                table: "worker",
                newName: "IX_worker_workerId");

            migrationBuilder.AlterColumn<string>(
                name: "Phone",
                table: "worker",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Age",
                table: "worker",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_worker_workLists_workerId",
                table: "worker",
                column: "workerId",
                principalTable: "workLists",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_worker_workLists_workerId",
                table: "worker");

            migrationBuilder.RenameColumn(
                name: "workerId",
                table: "worker",
                newName: "WorklistId");

            migrationBuilder.RenameColumn(
                name: "Names",
                table: "worker",
                newName: "Name");

            migrationBuilder.RenameIndex(
                name: "IX_worker_workerId",
                table: "worker",
                newName: "IX_worker_WorklistId");

            migrationBuilder.AlterColumn<int>(
                name: "Phone",
                table: "worker",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "Age",
                table: "worker",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddForeignKey(
                name: "FK_worker_workLists_WorklistId",
                table: "worker",
                column: "WorklistId",
                principalTable: "workLists",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
