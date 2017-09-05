using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace ShadowAPI.Migrations
{
    public partial class RunnerSkillManyToMany : Migration
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
                name: "FK_SIN_Runner_RunnerID",
                table: "SIN");

            migrationBuilder.DropForeignKey(
                name: "FK_Skill_Runner_RunnerID",
                table: "Skill");

            migrationBuilder.DropIndex(
                name: "IX_Skill_RunnerID",
                table: "Skill");

            migrationBuilder.DropColumn(
                name: "Rating",
                table: "Skill");

            migrationBuilder.DropColumn(
                name: "RunnerID",
                table: "Skill");

            migrationBuilder.DropColumn(
                name: "Belongings",
                table: "Runner");

            migrationBuilder.DropColumn(
                name: "Lifestyle",
                table: "Runner");

            migrationBuilder.AddColumn<long>(
                name: "RunnerSkillRunnerID",
                table: "SkillSpecialization",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "RunnerSkillSkillID",
                table: "SkillSpecialization",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "BelongingsID",
                table: "Runner",
                type: "bigint",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Belongings",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Belongings", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "RunnerSkill",
                columns: table => new
                {
                    RunnerID = table.Column<long>(type: "bigint", nullable: false),
                    SkillID = table.Column<long>(type: "bigint", nullable: false),
                    Rating = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RunnerSkill", x => new { x.RunnerID, x.SkillID });
                    table.ForeignKey(
                        name: "FK_RunnerSkill_Runner_RunnerID",
                        column: x => x.RunnerID,
                        principalTable: "Runner",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RunnerSkill_Skill_RunnerID",
                        column: x => x.RunnerID,
                        principalTable: "Skill",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SkillSpecialization_RunnerSkillRunnerID_RunnerSkillSkillID",
                table: "SkillSpecialization",
                columns: new[] { "RunnerSkillRunnerID", "RunnerSkillSkillID" });

            migrationBuilder.CreateIndex(
                name: "IX_Runner_BelongingsID",
                table: "Runner",
                column: "BelongingsID");

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
                name: "FK_Runner_Belongings_BelongingsID",
                table: "Runner",
                column: "BelongingsID",
                principalTable: "Belongings",
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Alias_Runner_InfoID",
                table: "Alias");

            migrationBuilder.DropForeignKey(
                name: "FK_Quality_Runner_RunnerID",
                table: "Quality");

            migrationBuilder.DropForeignKey(
                name: "FK_Runner_Belongings_BelongingsID",
                table: "Runner");

            migrationBuilder.DropForeignKey(
                name: "FK_Runner_Awakened_ID",
                table: "Runner");

            migrationBuilder.DropForeignKey(
                name: "FK_RunnerContact_Runner_RunnerID",
                table: "RunnerContact");

            migrationBuilder.DropForeignKey(
                name: "FK_SIN_Runner_RunnerID",
                table: "SIN");

            migrationBuilder.DropForeignKey(
                name: "FK_SkillSpecialization_RunnerSkill_RunnerSkillRunnerID_RunnerSkillSkillID",
                table: "SkillSpecialization");

            migrationBuilder.DropTable(
                name: "Belongings");

            migrationBuilder.DropTable(
                name: "RunnerSkill");

            migrationBuilder.DropIndex(
                name: "IX_SkillSpecialization_RunnerSkillRunnerID_RunnerSkillSkillID",
                table: "SkillSpecialization");

            migrationBuilder.DropIndex(
                name: "IX_Runner_BelongingsID",
                table: "Runner");

            migrationBuilder.DropColumn(
                name: "RunnerSkillRunnerID",
                table: "SkillSpecialization");

            migrationBuilder.DropColumn(
                name: "RunnerSkillSkillID",
                table: "SkillSpecialization");

            migrationBuilder.DropColumn(
                name: "BelongingsID",
                table: "Runner");

            migrationBuilder.AddColumn<int>(
                name: "Rating",
                table: "Skill",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<long>(
                name: "RunnerID",
                table: "Skill",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Belongings",
                table: "Runner",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Lifestyle",
                table: "Runner",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Skill_RunnerID",
                table: "Skill",
                column: "RunnerID");

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
                name: "FK_SIN_Runner_RunnerID",
                table: "SIN",
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
