using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace ShadowAPI.Migrations
{
    public partial class InitalMassModels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Awakened",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Awakened", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Economy",
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
                name: "User",
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
                name: "AdeptPower",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AwakenedID = table.Column<long>(type: "bigint", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdeptPower", x => x.ID);
                    table.ForeignKey(
                        name: "FK_AdeptPower_Awakened_AwakenedID",
                        column: x => x.AwakenedID,
                        principalTable: "Awakened",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Metamagic",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AwakenedID = table.Column<long>(type: "bigint", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Metamagic", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Metamagic_Awakened_AwakenedID",
                        column: x => x.AwakenedID,
                        principalTable: "Awakened",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Ritual",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AwakenedID = table.Column<long>(type: "bigint", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ritual", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Ritual_Awakened_AwakenedID",
                        column: x => x.AwakenedID,
                        principalTable: "Awakened",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Spell",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AwakenedID = table.Column<long>(type: "bigint", nullable: true),
                    Drain = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Spell", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Spell_Awakened_AwakenedID",
                        column: x => x.AwakenedID,
                        principalTable: "Awakened",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "FundTransaction",
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
                        principalTable: "Economy",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FundTransaction_FundTransaction_PreviousTransactionID",
                        column: x => x.PreviousTransactionID,
                        principalTable: "FundTransaction",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Runner",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false),
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
                    AwakenedID = table.Column<long>(type: "bigint", nullable: true),
                    Belongings = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EconomyID = table.Column<long>(type: "bigint", nullable: true),
                    Lifestyle = table.Column<int>(type: "int", nullable: false),
                    PlayerID = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Runner", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Runner_Awakened_AwakenedID",
                        column: x => x.AwakenedID,
                        principalTable: "Awakened",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Runner_Economy_EconomyID",
                        column: x => x.EconomyID,
                        principalTable: "Economy",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Runner_User_PlayerID",
                        column: x => x.PlayerID,
                        principalTable: "User",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Alias",
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
                        principalTable: "Runner",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Contact",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Connection = table.Column<int>(type: "int", nullable: false),
                    Favor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RunnerID = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contact", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Contact_Runner_RunnerID",
                        column: x => x.RunnerID,
                        principalTable: "Runner",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Identification",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RunnerID = table.Column<long>(type: "bigint", nullable: true)
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

            migrationBuilder.CreateTable(
                name: "Quality",
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
                        principalTable: "Quality",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Quality_Runner_RunnerID",
                        column: x => x.RunnerID,
                        principalTable: "Runner",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Skill",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ActiveType = table.Column<int>(type: "int", nullable: true),
                    Group = table.Column<byte>(type: "tinyint", nullable: false),
                    KnowledgeType = table.Column<int>(type: "int", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Rating = table.Column<int>(type: "int", nullable: false),
                    RunnerID = table.Column<long>(type: "bigint", nullable: true),
                    Type = table.Column<byte>(type: "tinyint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Skill", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Skill_Runner_RunnerID",
                        column: x => x.RunnerID,
                        principalTable: "Runner",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "License",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IdentificationID = table.Column<long>(type: "bigint", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nothing = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_License", x => x.ID);
                    table.ForeignKey(
                        name: "FK_License_Identification_IdentificationID",
                        column: x => x.IdentificationID,
                        principalTable: "Identification",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SkillSpecialization",
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
                        principalTable: "Skill",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AdeptPower_AwakenedID",
                table: "AdeptPower",
                column: "AwakenedID");

            migrationBuilder.CreateIndex(
                name: "IX_Alias_InfoID",
                table: "Alias",
                column: "InfoID");

            migrationBuilder.CreateIndex(
                name: "IX_Contact_RunnerID",
                table: "Contact",
                column: "RunnerID");

            migrationBuilder.CreateIndex(
                name: "IX_FundTransaction_EconomyID",
                table: "FundTransaction",
                column: "EconomyID");

            migrationBuilder.CreateIndex(
                name: "IX_FundTransaction_PreviousTransactionID",
                table: "FundTransaction",
                column: "PreviousTransactionID");

            migrationBuilder.CreateIndex(
                name: "IX_Identification_RunnerID",
                table: "Identification",
                column: "RunnerID");

            migrationBuilder.CreateIndex(
                name: "IX_License_IdentificationID",
                table: "License",
                column: "IdentificationID");

            migrationBuilder.CreateIndex(
                name: "IX_Metamagic_AwakenedID",
                table: "Metamagic",
                column: "AwakenedID");

            migrationBuilder.CreateIndex(
                name: "IX_Quality_ContradictorID",
                table: "Quality",
                column: "ContradictorID");

            migrationBuilder.CreateIndex(
                name: "IX_Quality_RunnerID",
                table: "Quality",
                column: "RunnerID");

            migrationBuilder.CreateIndex(
                name: "IX_Ritual_AwakenedID",
                table: "Ritual",
                column: "AwakenedID");

            migrationBuilder.CreateIndex(
                name: "IX_Runner_AwakenedID",
                table: "Runner",
                column: "AwakenedID");

            migrationBuilder.CreateIndex(
                name: "IX_Runner_EconomyID",
                table: "Runner",
                column: "EconomyID");

            migrationBuilder.CreateIndex(
                name: "IX_Runner_PlayerID",
                table: "Runner",
                column: "PlayerID");

            migrationBuilder.CreateIndex(
                name: "IX_Skill_RunnerID",
                table: "Skill",
                column: "RunnerID");

            migrationBuilder.CreateIndex(
                name: "IX_SkillSpecialization_SkillID",
                table: "SkillSpecialization",
                column: "SkillID");

            migrationBuilder.CreateIndex(
                name: "IX_Spell_AwakenedID",
                table: "Spell",
                column: "AwakenedID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AdeptPower");

            migrationBuilder.DropTable(
                name: "Alias");

            migrationBuilder.DropTable(
                name: "Contact");

            migrationBuilder.DropTable(
                name: "FundTransaction");

            migrationBuilder.DropTable(
                name: "License");

            migrationBuilder.DropTable(
                name: "Metamagic");

            migrationBuilder.DropTable(
                name: "Quality");

            migrationBuilder.DropTable(
                name: "Ritual");

            migrationBuilder.DropTable(
                name: "SkillSpecialization");

            migrationBuilder.DropTable(
                name: "Spell");

            migrationBuilder.DropTable(
                name: "Identification");

            migrationBuilder.DropTable(
                name: "Skill");

            migrationBuilder.DropTable(
                name: "Runner");

            migrationBuilder.DropTable(
                name: "Awakened");

            migrationBuilder.DropTable(
                name: "Economy");

            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
