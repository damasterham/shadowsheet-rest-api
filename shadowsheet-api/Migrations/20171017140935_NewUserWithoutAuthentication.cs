using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace ShadowAPI.Migrations
{
    public partial class NewUserWithoutAuthentication : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Alias_Runner_InfoID",
                schema: "ShadowSheet",
                table: "Alias");

            migrationBuilder.DropForeignKey(
                name: "FK_RunnerContact_Runner_RunnerID",
                schema: "ShadowSheet",
                table: "RunnerContact");

            migrationBuilder.DropForeignKey(
                name: "FK_RunnerQuality_Runner_RunnerID",
                schema: "ShadowSheet",
                table: "RunnerQuality");

            migrationBuilder.DropForeignKey(
                name: "FK_RunnerSkill_Runner_RunnerID",
                schema: "ShadowSheet",
                table: "RunnerSkill");

            migrationBuilder.DropForeignKey(
                name: "FK_RunnerSkillSpecialization_Runner_RunnerID",
                schema: "ShadowSheet",
                table: "RunnerSkillSpecialization");

            migrationBuilder.DropColumn(
                name: "IsCurrentlyPlayer",
                schema: "ShadowSheet",
                table: "User");

            migrationBuilder.AddColumn<bool>(
                name: "IsEmailUsername",
                schema: "ShadowSheet",
                table: "User",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddForeignKey(
                name: "FK_Alias_Runner_InfoID",
                schema: "ShadowSheet",
                table: "Alias",
                column: "InfoID",
                principalSchema: "ShadowSheet",
                principalTable: "Runner",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_RunnerContact_Runner_RunnerID",
                schema: "ShadowSheet",
                table: "RunnerContact",
                column: "RunnerID",
                principalSchema: "ShadowSheet",
                principalTable: "Runner",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RunnerQuality_Runner_RunnerID",
                schema: "ShadowSheet",
                table: "RunnerQuality",
                column: "RunnerID",
                principalSchema: "ShadowSheet",
                principalTable: "Runner",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RunnerSkill_Runner_RunnerID",
                schema: "ShadowSheet",
                table: "RunnerSkill",
                column: "RunnerID",
                principalSchema: "ShadowSheet",
                principalTable: "Runner",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RunnerSkillSpecialization_Runner_RunnerID",
                schema: "ShadowSheet",
                table: "RunnerSkillSpecialization",
                column: "RunnerID",
                principalSchema: "ShadowSheet",
                principalTable: "Runner",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Alias_Runner_InfoID",
                schema: "ShadowSheet",
                table: "Alias");

            migrationBuilder.DropForeignKey(
                name: "FK_RunnerContact_Runner_RunnerID",
                schema: "ShadowSheet",
                table: "RunnerContact");

            migrationBuilder.DropForeignKey(
                name: "FK_RunnerQuality_Runner_RunnerID",
                schema: "ShadowSheet",
                table: "RunnerQuality");

            migrationBuilder.DropForeignKey(
                name: "FK_RunnerSkill_Runner_RunnerID",
                schema: "ShadowSheet",
                table: "RunnerSkill");

            migrationBuilder.DropForeignKey(
                name: "FK_RunnerSkillSpecialization_Runner_RunnerID",
                schema: "ShadowSheet",
                table: "RunnerSkillSpecialization");

            migrationBuilder.DropColumn(
                name: "IsEmailUsername",
                schema: "ShadowSheet",
                table: "User");

            migrationBuilder.AddColumn<bool>(
                name: "IsCurrentlyPlayer",
                schema: "ShadowSheet",
                table: "User",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddForeignKey(
                name: "FK_Alias_Runner_InfoID",
                schema: "ShadowSheet",
                table: "Alias",
                column: "InfoID",
                principalSchema: "ShadowSheet",
                principalTable: "Runner",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_RunnerContact_Runner_RunnerID",
                schema: "ShadowSheet",
                table: "RunnerContact",
                column: "RunnerID",
                principalSchema: "ShadowSheet",
                principalTable: "Runner",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RunnerQuality_Runner_RunnerID",
                schema: "ShadowSheet",
                table: "RunnerQuality",
                column: "RunnerID",
                principalSchema: "ShadowSheet",
                principalTable: "Runner",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RunnerSkill_Runner_RunnerID",
                schema: "ShadowSheet",
                table: "RunnerSkill",
                column: "RunnerID",
                principalSchema: "ShadowSheet",
                principalTable: "Runner",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RunnerSkillSpecialization_Runner_RunnerID",
                schema: "ShadowSheet",
                table: "RunnerSkillSpecialization",
                column: "RunnerID",
                principalSchema: "ShadowSheet",
                principalTable: "Runner",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
