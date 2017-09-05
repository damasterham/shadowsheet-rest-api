using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace ShadowAPI.Migrations
{
    public partial class RunnerSkillSpecializationManyToMany : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Alias_Runner_InfoID",
                table: "Alias");

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
                name: "FK_RunnerSkill_Runner_RunnerID",
                table: "RunnerSkill");

            migrationBuilder.DropForeignKey(
                name: "FK_SIN_Runner_RunnerID",
                table: "SIN");

            migrationBuilder.DropForeignKey(
                name: "FK_SkillSpecialization_RunnerSkill_RunnerSkillRunnerID_RunnerSkillSkillID",
                table: "SkillSpecialization");

            migrationBuilder.DropIndex(
                name: "IX_SkillSpecialization_RunnerSkillRunnerID_RunnerSkillSkillID",
                table: "SkillSpecialization");

            migrationBuilder.DropColumn(
                name: "RunnerSkillRunnerID",
                table: "SkillSpecialization");

            migrationBuilder.DropColumn(
                name: "RunnerSkillSkillID",
                table: "SkillSpecialization");

            migrationBuilder.CreateTable(
                name: "RunnerSkillSpecialization",
                columns: table => new
                {
                    RunnerID = table.Column<long>(type: "bigint", nullable: false),
                    SkillSpecializationID = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RunnerSkillSpecialization", x => new { x.RunnerID, x.SkillSpecializationID });
                    table.ForeignKey(
                        name: "FK_RunnerSkillSpecialization_Runner_RunnerID",
                        column: x => x.RunnerID,
                        principalTable: "Runner",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RunnerSkillSpecialization_SkillSpecialization_SkillSpecializationID",
                        column: x => x.SkillSpecializationID,
                        principalTable: "SkillSpecialization",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_RunnerSkillSpecialization_SkillSpecializationID",
                table: "RunnerSkillSpecialization",
                column: "SkillSpecializationID");

            migrationBuilder.AddForeignKey(
                name: "FK_Alias_Runner_InfoID",
                table: "Alias",
                column: "InfoID",
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
                name: "FK_RunnerSkill_Runner_RunnerID",
                table: "RunnerSkill",
                column: "RunnerID",
                principalTable: "Runner",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SIN_Runner_RunnerID",
                table: "SIN",
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
                name: "FK_Quality_Runner_RunnerID",
                table: "Quality");

            migrationBuilder.DropForeignKey(
                name: "FK_Runner_Awakened_ID",
                table: "Runner");

            migrationBuilder.DropForeignKey(
                name: "FK_RunnerContact_Runner_RunnerID",
                table: "RunnerContact");

            migrationBuilder.DropForeignKey(
                name: "FK_RunnerSkill_Runner_RunnerID",
                table: "RunnerSkill");

            migrationBuilder.DropForeignKey(
                name: "FK_SIN_Runner_RunnerID",
                table: "SIN");

            migrationBuilder.DropTable(
                name: "RunnerSkillSpecialization");

            migrationBuilder.AddColumn<long>(
                name: "RunnerSkillRunnerID",
                table: "SkillSpecialization",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "RunnerSkillSkillID",
                table: "SkillSpecialization",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_SkillSpecialization_RunnerSkillRunnerID_RunnerSkillSkillID",
                table: "SkillSpecialization",
                columns: new[] { "RunnerSkillRunnerID", "RunnerSkillSkillID" });

            migrationBuilder.AddForeignKey(
                name: "FK_Alias_Runner_InfoID",
                table: "Alias",
                column: "InfoID",
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
                name: "FK_RunnerSkill_Runner_RunnerID",
                table: "RunnerSkill",
                column: "RunnerID",
                principalTable: "Runner",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SIN_Runner_RunnerID",
                table: "SIN",
                column: "RunnerID",
                principalTable: "Runner",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SkillSpecialization_RunnerSkill_RunnerSkillRunnerID_RunnerSkillSkillID",
                table: "SkillSpecialization",
                columns: new[] { "RunnerSkillRunnerID", "RunnerSkillSkillID" },
                principalTable: "RunnerSkill",
                principalColumns: new[] { "RunnerID", "SkillID" },
                onDelete: ReferentialAction.Restrict);
        }
    }
}
