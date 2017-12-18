using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace ShadowAPI.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "ShadowSheet");

            migrationBuilder.CreateTable(
                name: "AdeptPower",
                schema: "ShadowSheet",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdeptPower", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Contact",
                schema: "ShadowSheet",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Connection = table.Column<int>(type: "int", nullable: false),
                    Favor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contact", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Economy",
                schema: "ShadowSheet",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CurrentFunds = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Economy", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Metamagic",
                schema: "ShadowSheet",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Metamagic", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Ritual",
                schema: "ShadowSheet",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ritual", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Skill",
                schema: "ShadowSheet",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ActiveType = table.Column<int>(type: "int", nullable: true),
                    Group = table.Column<byte>(type: "tinyint", nullable: false),
                    KnowledgeType = table.Column<int>(type: "int", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Type = table.Column<byte>(type: "tinyint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Skill", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Spell",
                schema: "ShadowSheet",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Drain = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Spell", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "User",
                schema: "ShadowSheet",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsCurrentlyPlayer = table.Column<bool>(type: "bit", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "FundTransaction",
                schema: "ShadowSheet",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    EconomyID = table.Column<long>(type: "bigint", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PreviousTransactionID = table.Column<long>(type: "bigint", nullable: true),
                    Value = table.Column<long>(type: "bigint", nullable: false)
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

            migrationBuilder.CreateTable(
                name: "SkillSpecialization",
                schema: "ShadowSheet",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SkillID = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SkillSpecialization", x => x.ID);
                    table.ForeignKey(
                        name: "FK_SkillSpecialization_Skill_SkillID",
                        column: x => x.SkillID,
                        principalSchema: "ShadowSheet",
                        principalTable: "Skill",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Runner",
                schema: "ShadowSheet",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Agility = table.Column<int>(type: "int", nullable: false),
                    Body = table.Column<int>(type: "int", nullable: false),
                    Charisma = table.Column<int>(type: "int", nullable: false),
                    Edge = table.Column<int>(type: "int", nullable: false),
                    Essence = table.Column<float>(type: "real", nullable: false),
                    Intuition = table.Column<int>(type: "int", nullable: false),
                    Logic = table.Column<int>(type: "int", nullable: false),
                    Magic = table.Column<int>(type: "int", nullable: false),
                    Reaction = table.Column<int>(type: "int", nullable: false),
                    Resonance = table.Column<int>(type: "int", nullable: false),
                    Strength = table.Column<int>(type: "int", nullable: false),
                    Willpower = table.Column<int>(type: "int", nullable: false),
                    Background = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ethnicity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageURL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Metatype = table.Column<byte>(type: "tinyint", nullable: false),
                    RealName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Sex = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EconomyID = table.Column<long>(type: "bigint", nullable: true),
                    PlayerID = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Runner", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Runner_Economy_EconomyID",
                        column: x => x.EconomyID,
                        principalSchema: "ShadowSheet",
                        principalTable: "Economy",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Runner_User_PlayerID",
                        column: x => x.PlayerID,
                        principalSchema: "ShadowSheet",
                        principalTable: "User",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Alias",
                schema: "ShadowSheet",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    InfoID = table.Column<long>(type: "bigint", nullable: true),
                    IsPrimary = table.Column<bool>(type: "bit", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Alias", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Alias_Runner_InfoID",
                        column: x => x.InfoID,
                        principalSchema: "ShadowSheet",
                        principalTable: "Runner",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Quality",
                schema: "ShadowSheet",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ContradictorID = table.Column<long>(type: "bigint", nullable: true),
                    Cost = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsPositive = table.Column<bool>(type: "bit", nullable: false),
                    Modifier = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RunnerID = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Quality", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Quality_Quality_ContradictorID",
                        column: x => x.ContradictorID,
                        principalSchema: "ShadowSheet",
                        principalTable: "Quality",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Quality_Runner_RunnerID",
                        column: x => x.RunnerID,
                        principalSchema: "ShadowSheet",
                        principalTable: "Runner",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "RunnerContact",
                schema: "ShadowSheet",
                columns: table => new
                {
                    RunnerID = table.Column<long>(type: "bigint", nullable: false),
                    ContactID = table.Column<long>(type: "bigint", nullable: false),
                    Loyalty = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RunnerContact", x => new { x.RunnerID, x.ContactID });
                    table.ForeignKey(
                        name: "FK_RunnerContact_Contact_ContactID",
                        column: x => x.ContactID,
                        principalSchema: "ShadowSheet",
                        principalTable: "Contact",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RunnerContact_Runner_RunnerID",
                        column: x => x.RunnerID,
                        principalSchema: "ShadowSheet",
                        principalTable: "Runner",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RunnerSkill",
                schema: "ShadowSheet",
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
                        principalSchema: "ShadowSheet",
                        principalTable: "Runner",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RunnerSkill_Skill_RunnerID",
                        column: x => x.RunnerID,
                        principalSchema: "ShadowSheet",
                        principalTable: "Skill",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RunnerSkillSpecialization",
                schema: "ShadowSheet",
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
                        principalSchema: "ShadowSheet",
                        principalTable: "Runner",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RunnerSkillSpecialization_SkillSpecialization_SkillSpecializationID",
                        column: x => x.SkillSpecializationID,
                        principalSchema: "ShadowSheet",
                        principalTable: "SkillSpecialization",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SIN",
                schema: "ShadowSheet",
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
                        principalSchema: "ShadowSheet",
                        principalTable: "Runner",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "License",
                schema: "ShadowSheet",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nothing = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SINID = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_License", x => x.ID);
                    table.ForeignKey(
                        name: "FK_License_SIN_SINID",
                        column: x => x.SINID,
                        principalSchema: "ShadowSheet",
                        principalTable: "SIN",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Alias_InfoID",
                schema: "ShadowSheet",
                table: "Alias",
                column: "InfoID");

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

            migrationBuilder.CreateIndex(
                name: "IX_License_SINID",
                schema: "ShadowSheet",
                table: "License",
                column: "SINID");

            migrationBuilder.CreateIndex(
                name: "IX_Quality_ContradictorID",
                schema: "ShadowSheet",
                table: "Quality",
                column: "ContradictorID");

            migrationBuilder.CreateIndex(
                name: "IX_Quality_RunnerID",
                schema: "ShadowSheet",
                table: "Quality",
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
                name: "IX_RunnerContact_ContactID",
                schema: "ShadowSheet",
                table: "RunnerContact",
                column: "ContactID");

            migrationBuilder.CreateIndex(
                name: "IX_RunnerSkillSpecialization_SkillSpecializationID",
                schema: "ShadowSheet",
                table: "RunnerSkillSpecialization",
                column: "SkillSpecializationID");

            migrationBuilder.CreateIndex(
                name: "IX_SIN_RunnerID",
                schema: "ShadowSheet",
                table: "SIN",
                column: "RunnerID");

            migrationBuilder.CreateIndex(
                name: "IX_SkillSpecialization_SkillID",
                schema: "ShadowSheet",
                table: "SkillSpecialization",
                column: "SkillID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AdeptPower",
                schema: "ShadowSheet");

            migrationBuilder.DropTable(
                name: "Alias",
                schema: "ShadowSheet");

            migrationBuilder.DropTable(
                name: "FundTransaction",
                schema: "ShadowSheet");

            migrationBuilder.DropTable(
                name: "License",
                schema: "ShadowSheet");

            migrationBuilder.DropTable(
                name: "Metamagic",
                schema: "ShadowSheet");

            migrationBuilder.DropTable(
                name: "Quality",
                schema: "ShadowSheet");

            migrationBuilder.DropTable(
                name: "Ritual",
                schema: "ShadowSheet");

            migrationBuilder.DropTable(
                name: "RunnerContact",
                schema: "ShadowSheet");

            migrationBuilder.DropTable(
                name: "RunnerSkill",
                schema: "ShadowSheet");

            migrationBuilder.DropTable(
                name: "RunnerSkillSpecialization",
                schema: "ShadowSheet");

            migrationBuilder.DropTable(
                name: "Spell",
                schema: "ShadowSheet");

            migrationBuilder.DropTable(
                name: "SIN",
                schema: "ShadowSheet");

            migrationBuilder.DropTable(
                name: "Contact",
                schema: "ShadowSheet");

            migrationBuilder.DropTable(
                name: "SkillSpecialization",
                schema: "ShadowSheet");

            migrationBuilder.DropTable(
                name: "Runner",
                schema: "ShadowSheet");

            migrationBuilder.DropTable(
                name: "Skill",
                schema: "ShadowSheet");

            migrationBuilder.DropTable(
                name: "Economy",
                schema: "ShadowSheet");

            migrationBuilder.DropTable(
                name: "User",
                schema: "ShadowSheet");
        }
    }
}
