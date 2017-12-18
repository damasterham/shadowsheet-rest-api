using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace ShadowAPI.Migrations
{
    public partial class SimplifiedRunner : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Alias_Runner_InfoID",
                schema: "ShadowSheet",
                table: "Alias");

            migrationBuilder.DropForeignKey(
                name: "FK_Quality_Runner_RunnerID",
                schema: "ShadowSheet",
                table: "Quality");

            migrationBuilder.DropForeignKey(
                name: "FK_Runner_Economy_EconomyID",
                schema: "ShadowSheet",
                table: "Runner");

            migrationBuilder.DropForeignKey(
                name: "FK_Runner_User_PlayerID",
                schema: "ShadowSheet",
                table: "Runner");

            migrationBuilder.DropForeignKey(
                name: "FK_RunnerContact_Runner_RunnerID",
                schema: "ShadowSheet",
                table: "RunnerContact");

            migrationBuilder.DropForeignKey(
                name: "FK_RunnerSkill_Runner_RunnerID",
                schema: "ShadowSheet",
                table: "RunnerSkill");

            migrationBuilder.DropForeignKey(
                name: "FK_RunnerSkillSpecialization_Runner_RunnerID",
                schema: "ShadowSheet",
                table: "RunnerSkillSpecialization");

            migrationBuilder.DropForeignKey(
                name: "FK_SIN_Runner_RunnerID",
                schema: "ShadowSheet",
                table: "SIN");

            migrationBuilder.DropTable(
                name: "FundTransaction",
                schema: "ShadowSheet");

            migrationBuilder.DropTable(
                name: "Economy",
                schema: "ShadowSheet");

            migrationBuilder.DropIndex(
                name: "IX_SIN_RunnerID",
                schema: "ShadowSheet",
                table: "SIN");

            migrationBuilder.DropIndex(
                name: "IX_Runner_EconomyID",
                schema: "ShadowSheet",
                table: "Runner");

            migrationBuilder.DropIndex(
                name: "IX_Runner_PlayerID",
                schema: "ShadowSheet",
                table: "Runner");

            migrationBuilder.DropIndex(
                name: "IX_Quality_RunnerID",
                schema: "ShadowSheet",
                table: "Quality");

            migrationBuilder.DropColumn(
                name: "RunnerID",
                schema: "ShadowSheet",
                table: "SIN");

            migrationBuilder.DropColumn(
                name: "EconomyID",
                schema: "ShadowSheet",
                table: "Runner");

            migrationBuilder.DropColumn(
                name: "PlayerID",
                schema: "ShadowSheet",
                table: "Runner");

            migrationBuilder.DropColumn(
                name: "RunnerID",
                schema: "ShadowSheet",
                table: "Quality");

            migrationBuilder.AddColumn<long>(
                name: "UserID",
                schema: "ShadowSheet",
                table: "Runner",
                type: "bigint",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "RunnerQuality",
                schema: "ShadowSheet",
                columns: table => new
                {
                    RunnerID = table.Column<long>(type: "bigint", nullable: false),
                    QualityID = table.Column<long>(type: "bigint", nullable: false),
                    Rank = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RunnerQuality", x => new { x.RunnerID, x.QualityID });
                    table.ForeignKey(
                        name: "FK_RunnerQuality_Quality_RunnerID",
                        column: x => x.RunnerID,
                        principalSchema: "ShadowSheet",
                        principalTable: "Quality",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RunnerQuality_Runner_RunnerID",
                        column: x => x.RunnerID,
                        principalSchema: "ShadowSheet",
                        principalTable: "Runner",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Runner_UserID",
                schema: "ShadowSheet",
                table: "Runner",
                column: "UserID");

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
                name: "FK_Runner_User_UserID",
                schema: "ShadowSheet",
                table: "Runner",
                column: "UserID",
                principalSchema: "ShadowSheet",
                principalTable: "User",
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
                name: "FK_Runner_User_UserID",
                schema: "ShadowSheet",
                table: "Runner");

            migrationBuilder.DropForeignKey(
                name: "FK_RunnerContact_Runner_RunnerID",
                schema: "ShadowSheet",
                table: "RunnerContact");

            migrationBuilder.DropForeignKey(
                name: "FK_RunnerSkill_Runner_RunnerID",
                schema: "ShadowSheet",
                table: "RunnerSkill");

            migrationBuilder.DropForeignKey(
                name: "FK_RunnerSkillSpecialization_Runner_RunnerID",
                schema: "ShadowSheet",
                table: "RunnerSkillSpecialization");

            migrationBuilder.DropTable(
                name: "RunnerQuality",
                schema: "ShadowSheet");

            migrationBuilder.DropIndex(
                name: "IX_Runner_UserID",
                schema: "ShadowSheet",
                table: "Runner");

            migrationBuilder.DropColumn(
                name: "UserID",
                schema: "ShadowSheet",
                table: "Runner");

            migrationBuilder.AddColumn<long>(
                name: "RunnerID",
                schema: "ShadowSheet",
                table: "SIN",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "EconomyID",
                schema: "ShadowSheet",
                table: "Runner",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "PlayerID",
                schema: "ShadowSheet",
                table: "Runner",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "RunnerID",
                schema: "ShadowSheet",
                table: "Quality",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Economy",
                schema: "ShadowSheet",
                columns: table => new
                {
                    ID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CurrentFunds = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Economy", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "FundTransaction",
                schema: "ShadowSheet",
                columns: table => new
                {
                    ID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    EconomyID = table.Column<long>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    PreviousTransactionID = table.Column<long>(nullable: true),
                    Value = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FundTransaction", x => x.ID);
                    table.ForeignKey(
                        name: "FK_FundTransaction_Economy_EconomyID",
                        column: x => x.EconomyID,
                        principalSchema: "ShadowSheet",
                        principalTable: "Economy",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FundTransaction_FundTransaction_PreviousTransactionID",
                        column: x => x.PreviousTransactionID,
                        principalSchema: "ShadowSheet",
                        principalTable: "FundTransaction",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SIN_RunnerID",
                schema: "ShadowSheet",
                table: "SIN",
                column: "RunnerID");

            migrationBuilder.CreateIndex(
                name: "IX_Runner_EconomyID",
                schema: "ShadowSheet",
                table: "Runner",
                column: "EconomyID");

            migrationBuilder.CreateIndex(
                name: "IX_Runner_PlayerID",
                schema: "ShadowSheet",
                table: "Runner",
                column: "PlayerID");

            migrationBuilder.CreateIndex(
                name: "IX_Quality_RunnerID",
                schema: "ShadowSheet",
                table: "Quality",
                column: "RunnerID");

            migrationBuilder.CreateIndex(
                name: "IX_FundTransaction_EconomyID",
                schema: "ShadowSheet",
                table: "FundTransaction",
                column: "EconomyID");

            migrationBuilder.CreateIndex(
                name: "IX_FundTransaction_PreviousTransactionID",
                schema: "ShadowSheet",
                table: "FundTransaction",
                column: "PreviousTransactionID");

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
                name: "FK_Quality_Runner_RunnerID",
                schema: "ShadowSheet",
                table: "Quality",
                column: "RunnerID",
                principalSchema: "ShadowSheet",
                principalTable: "Runner",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Runner_Economy_EconomyID",
                schema: "ShadowSheet",
                table: "Runner",
                column: "EconomyID",
                principalSchema: "ShadowSheet",
                principalTable: "Economy",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Runner_User_PlayerID",
                schema: "ShadowSheet",
                table: "Runner",
                column: "PlayerID",
                principalSchema: "ShadowSheet",
                principalTable: "User",
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

            migrationBuilder.AddForeignKey(
                name: "FK_SIN_Runner_RunnerID",
                schema: "ShadowSheet",
                table: "SIN",
                column: "RunnerID",
                principalSchema: "ShadowSheet",
                principalTable: "Runner",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
