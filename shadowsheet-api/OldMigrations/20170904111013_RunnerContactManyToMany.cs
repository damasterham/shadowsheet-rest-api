using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace ShadowAPI.Migrations
{
    public partial class RunnerContactManyToMany : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Alias_Runner_InfoID",
                table: "Alias");

            migrationBuilder.DropForeignKey(
                name: "FK_Contact_Runner_RunnerID",
                table: "Contact");

            migrationBuilder.DropForeignKey(
                name: "FK_Identification_Runner_RunnerID",
                table: "Identification");

            migrationBuilder.DropForeignKey(
                name: "FK_Quality_Runner_RunnerID",
                table: "Quality");

            migrationBuilder.DropForeignKey(
                name: "FK_Skill_Runner_RunnerID",
                table: "Skill");

            migrationBuilder.DropIndex(
                name: "IX_Runner_AwakenedID",
                table: "Runner");

            migrationBuilder.DropIndex(
                name: "IX_Contact_RunnerID",
                table: "Contact");

            migrationBuilder.DropColumn(
                name: "RunnerID",
                table: "Contact");

            migrationBuilder.CreateTable(
                name: "RunnerContact",
                columns: table => new
                {
                    RunnerID = table.Column<long>(type: "bigint", nullable: false),
                    ContactID = table.Column<long>(type: "bigint", nullable: false),
                    ID = table.Column<long>(type: "bigint", nullable: false),
                    Loyalty = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RunnerContact", x => new { x.RunnerID, x.ContactID });
                    table.ForeignKey(
                        name: "FK_RunnerContact_Contact_ContactID",
                        column: x => x.ContactID,
                        principalTable: "Contact",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RunnerContact_Runner_RunnerID",
                        column: x => x.RunnerID,
                        principalTable: "Runner",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Runner_AwakenedID",
                table: "Runner",
                column: "AwakenedID",
                unique: true,
                filter: "[AwakenedID] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_RunnerContact_ContactID",
                table: "RunnerContact",
                column: "ContactID");

            migrationBuilder.AddForeignKey(
                name: "FK_Alias_Runner_InfoID",
                table: "Alias",
                column: "InfoID",
                principalTable: "Runner",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Identification_Runner_RunnerID",
                table: "Identification",
                column: "RunnerID",
                principalTable: "Runner",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Quality_Runner_RunnerID",
                table: "Quality",
                column: "RunnerID",
                principalTable: "Runner",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Skill_Runner_RunnerID",
                table: "Skill",
                column: "RunnerID",
                principalTable: "Runner",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Alias_Runner_InfoID",
                table: "Alias");

            migrationBuilder.DropForeignKey(
                name: "FK_Identification_Runner_RunnerID",
                table: "Identification");

            migrationBuilder.DropForeignKey(
                name: "FK_Quality_Runner_RunnerID",
                table: "Quality");

            migrationBuilder.DropForeignKey(
                name: "FK_Skill_Runner_RunnerID",
                table: "Skill");

            migrationBuilder.DropTable(
                name: "RunnerContact");

            migrationBuilder.DropIndex(
                name: "IX_Runner_AwakenedID",
                table: "Runner");

            migrationBuilder.AddColumn<long>(
                name: "RunnerID",
                table: "Contact",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Runner_AwakenedID",
                table: "Runner",
                column: "AwakenedID");

            migrationBuilder.CreateIndex(
                name: "IX_Contact_RunnerID",
                table: "Contact",
                column: "RunnerID");

            migrationBuilder.AddForeignKey(
                name: "FK_Alias_Runner_InfoID",
                table: "Alias",
                column: "InfoID",
                principalTable: "Runner",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Contact_Runner_RunnerID",
                table: "Contact",
                column: "RunnerID",
                principalTable: "Runner",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Identification_Runner_RunnerID",
                table: "Identification",
                column: "RunnerID",
                principalTable: "Runner",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Quality_Runner_RunnerID",
                table: "Quality",
                column: "RunnerID",
                principalTable: "Runner",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Skill_Runner_RunnerID",
                table: "Skill",
                column: "RunnerID",
                principalTable: "Runner",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
