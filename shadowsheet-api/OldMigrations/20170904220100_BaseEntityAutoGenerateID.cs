using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace ShadowAPI.Migrations
{
    public partial class BaseEntityAutoGenerateID : Migration
    {
        List<string> tables = new List<string>
            {
                "AdeptPower",
                "Alias",
                "Awakened",
                "Belongings",
                "Contact",
                "Economy",
                "FundTransaction",
                "License",
                "Metamagic",
                "Quality",
                "Ritual",
                "Runner",
                "SIN",
                "Skill",
                "SkillSpecialization",
                "Spell",
                "User"
            };

        protected override void Up(MigrationBuilder migrationBuilder)
        {
            List<string> tables = new List<string>
            {
                "AdeptPower",
                "Alias",
                "Awakened",
                "Belongings",
                "Contact",
                "Economy",
                "FundTransaction",
                "License",
                "Metamagic",
                "Quality",
                "Ritual",
                "Runner",
                "SIN",
                "Skill",
                "SkillSpecialization",
                "Spell",
                "User"
            };

            // Drops all PrimaryKeys
            foreach (string item in tables)
            {
                migrationBuilder.DropPrimaryKey(
                    name: "PK_" + item,
                    table: item);
            }


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
                name: "FK_RunnerSkillSpecialization_Runner_RunnerID",
                table: "RunnerSkillSpecialization");

            migrationBuilder.DropForeignKey(
                name: "FK_SIN_Runner_RunnerID",
                table: "SIN");

            migrationBuilder.AlterColumn<long>(
                name: "ID",
                table: "Runner",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long))
                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

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
                name: "FK_RunnerSkillSpecialization_Runner_RunnerID",
                table: "RunnerSkillSpecialization",
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
                name: "FK_RunnerSkillSpecialization_Runner_RunnerID",
                table: "RunnerSkillSpecialization");

            migrationBuilder.DropForeignKey(
                name: "FK_SIN_Runner_RunnerID",
                table: "SIN");

            migrationBuilder.AlterColumn<long>(
                name: "ID",
                table: "Runner",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .OldAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

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
                name: "FK_RunnerSkillSpecialization_Runner_RunnerID",
                table: "RunnerSkillSpecialization",
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
    }
}
