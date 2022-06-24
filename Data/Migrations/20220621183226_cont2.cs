using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Proyecto_DevChat.Data.Migrations
{
    public partial class cont2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_contacts_AspNetUsers_UserId",
                table: "contacts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_contacts",
                table: "contacts");

            migrationBuilder.DropIndex(
                name: "IX_contacts_UserId",
                table: "contacts");

            migrationBuilder.RenameTable(
                name: "contacts",
                newName: "Contacts");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Contacts",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<string>(
                name: "UsersId",
                table: "Contacts",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Contacts",
                table: "Contacts",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Contacts_UsersId",
                table: "Contacts",
                column: "UsersId");

            migrationBuilder.AddForeignKey(
                name: "FK_Contacts_AspNetUsers_UsersId",
                table: "Contacts",
                column: "UsersId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contacts_AspNetUsers_UsersId",
                table: "Contacts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Contacts",
                table: "Contacts");

            migrationBuilder.DropIndex(
                name: "IX_Contacts_UsersId",
                table: "Contacts");

            migrationBuilder.DropColumn(
                name: "UsersId",
                table: "Contacts");

            migrationBuilder.RenameTable(
                name: "Contacts",
                newName: "contacts");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "contacts",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_contacts",
                table: "contacts",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_contacts_UserId",
                table: "contacts",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_contacts_AspNetUsers_UserId",
                table: "contacts",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
