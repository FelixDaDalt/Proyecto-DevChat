using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Proyecto_DevChat.Data.Migrations
{
    public partial class contactColumnNew : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contact_AspNetUsers_UserId",
                table: "Contact");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Contact",
                table: "Contact");

            migrationBuilder.RenameTable(
                name: "Contact",
                newName: "contacts");

            migrationBuilder.RenameIndex(
                name: "IX_Contact_UserId",
                table: "contacts",
                newName: "IX_contacts_UserId");

            migrationBuilder.AddColumn<string>(
                name: "contactUser",
                table: "contacts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_contacts",
                table: "contacts",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_contacts_AspNetUsers_UserId",
                table: "contacts",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_contacts_AspNetUsers_UserId",
                table: "contacts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_contacts",
                table: "contacts");

            migrationBuilder.DropColumn(
                name: "contactUser",
                table: "contacts");

            migrationBuilder.RenameTable(
                name: "contacts",
                newName: "Contact");

            migrationBuilder.RenameIndex(
                name: "IX_contacts_UserId",
                table: "Contact",
                newName: "IX_Contact_UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Contact",
                table: "Contact",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Contact_AspNetUsers_UserId",
                table: "Contact",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
