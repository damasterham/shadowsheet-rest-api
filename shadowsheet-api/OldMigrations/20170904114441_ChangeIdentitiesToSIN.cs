using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace ShadowAPI.Migrations
{
    public partial class ChangeIdentitiesToSIN : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Alias_Runner_InfoID",
                table: "Alias");

            migrationBuilder.DropForeignKey(
                name: "FK_License_Identification_IdentificationID",
                table: "License");

            migrationBuilder.DropForeignKey(
                name: "FK_Quality_Runner_RunnerID",
                table: "Quality");

            migrationBuilder.DropForeignKey(
                name: "FK_Runner_Awakened_AwakenedID",
                table: "Runner");

            migrationBuilder.DropForeignKey(
                name: "FK_RunnerContact_Runner_RunnerID",
                table: "RunnerContact");

            migrationBuilder.DropForeignKey(
                name: "FK_Skill_Runner_RunnerID",
                table: "Skill");

            migrationBuilder.DropTable(
                name: "Identification");

            migrationBuilder.DropIndex(
                name: "IX_Runner_AwakenedID",
                table: "Runner");

            migrationBuilder.DropIndex(
                name: "IX_License_IdentificationID",
                table: "License");

            migrationBuilder.DropColumn(
                name: "AwakenedID",
                table: "Runner");

            migrationBuilder.DropColumn(
                name: "IdentificationID",
                table: "License");

            migrationBuilder.AddColumn<long>(
                name: "SINID",
                table: "License",
                type: "bigint",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "SIN",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RunnerID = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SIN", x => x.ID);
                    table.ForeignKey(
                        name: "FK_SIN_Runner_RunnerID",
                        column: x => x.RunnerID,
                        principalTable: "Runner",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_License_SINID",
                table: "License",
                column: "SINID");

            migrationBuilder.CreateIndex(
                name: "IX_SIN_RunnerID",
                table: "SIN",
                column: "RunnerID");

            migrationBuilder.AddForeignKey(
                name: "FK_Alias_Runner_InfoID",
                table: "Alias",
                column: "InfoID",
                principalTable: "Runner",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_License_SIN_SINID",
                table: "License",
                column: "SINID",
                principalTable: "SIN",
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
                name: "FK_Runner_Awakened_ID",
                table: "Runner",
                column: "ID",
                principalTable: "Awakened",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RunnerContact_Runner_RunnerID",
                table: "RunnerContact",
                column: "RunnerID",
                principalTable: "Runner",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

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
                name: "FK_License_SIN_SINID",
                table: "License");

            migrationBuilder.DropForeignKey(
                name: "FK_Quality_Runner_RunnerID",
                table: "Quality");

            migrationBuilder.DropForeignKey(
                name: "FK_Runner_Awakened_ID",
                table: "Runner");

            migrationBuilder.DropForeignKey(
                name: "FK_RunnerContact_Runner_RunnerID",
                table: "RunnerContact");

            migrationBuilder.DropForeignKey(
                name: "FK_Skill_Runner_RunnerID",
                table: "Skill");

            migrationBuilder.DropTable(
                name: "SIN");

            migrationBuilder.DropIndex(
                name: "IX_License_SINID",
                table: "License");

            migrationBuilder.DropColumn(
                name: "SINID",
                table: "License");

            migrationBuilder.AddColumn<long>(
                name: "AwakenedID",
                table: "Runner",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "IdentificationID",
                table: "License",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Identification",
                columns: table => new
                {
                    ID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    RunnerID = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Identification", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Identification_Runner_RunnerID",
                        column: x => x.RunnerID,
                        principalTable: "Runner",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Runner_AwakenedID",
                table: "Runner",
                column: "AwakenedID",
                unique: true,
                filter: "[AwakenedID] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_License_IdentificationID",
                table: "License",
                column: "IdentificationID");

            migrationBuilder.CreateIndex(
                name: "IX_Identification_RunnerID",
                table: "Identification",
                column: "RunnerID");

            migrationBuilder.AddForeignKey(
                name: "FK_Alias_Runner_InfoID",
                table: "Alias",
                column: "InfoID",
                principalTable: "Runner",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_License_Identification_IdentificationID",
                table: "License",
                column: "IdentificationID",
                principalTable: "Identification",
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
                name: "FK_Runner_Awakened_AwakenedID",
                table: "Runner",
                column: "AwakenedID",
                principalTable: "Awakened",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_RunnerContact_Runner_RunnerID",
                table: "RunnerContact",
                column: "RunnerID",
                principalTable: "Runner",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

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
