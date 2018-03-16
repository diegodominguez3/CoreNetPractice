using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace SimpleApplication.Migrations
{
    public partial class ContactGroups : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ContactGroupId",
                table: "Contacts",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CotactGroupId",
                table: "Contacts",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "ContactGroups",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContactGroups", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Contacts_CotactGroupId",
                table: "Contacts",
                column: "CotactGroupId");

            migrationBuilder.AddForeignKey(
                name: "FK_Contacts_ContactGroups_CotactGroupId",
                table: "Contacts",
                column: "CotactGroupId",
                principalTable: "ContactGroups",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contacts_ContactGroups_CotactGroupId",
                table: "Contacts");

            migrationBuilder.DropTable(
                name: "ContactGroups");

            migrationBuilder.DropIndex(
                name: "IX_Contacts_CotactGroupId",
                table: "Contacts");

            migrationBuilder.DropColumn(
                name: "ContactGroupId",
                table: "Contacts");

            migrationBuilder.DropColumn(
                name: "CotactGroupId",
                table: "Contacts");
        }
    }
}
