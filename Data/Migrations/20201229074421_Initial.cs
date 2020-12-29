using System;
using Microsoft.EntityFrameworkCore.Migrations;
using NetTopologySuite.Geometries;

namespace VoteMap.Data.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Booths",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Location = table.Column<Point>(type: "geography", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Booths", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Candidates",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Candidates", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Elections",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PartyValidVotes = table.Column<int>(type: "int", nullable: false),
                    PartyInformalVotes = table.Column<int>(type: "int", nullable: false),
                    CandidateValidVotes = table.Column<int>(type: "int", nullable: false),
                    CandidateInformalVotes = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Elections", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Electorates",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Electorates", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Parties",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Parties", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BoothVotes",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CandidateValidVotes = table.Column<int>(type: "int", nullable: false),
                    CandidateInformalVotes = table.Column<int>(type: "int", nullable: false),
                    PartyValidVotes = table.Column<int>(type: "int", nullable: false),
                    PartyInformalVotes = table.Column<int>(type: "int", nullable: false),
                    BoothId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ElectorateId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ElectionId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BoothVotes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BoothVotes_Booths_BoothId",
                        column: x => x.BoothId,
                        principalTable: "Booths",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BoothVotes_Elections_ElectionId",
                        column: x => x.ElectionId,
                        principalTable: "Elections",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BoothVotes_Electorates_ElectorateId",
                        column: x => x.ElectorateId,
                        principalTable: "Electorates",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ElectorateVotes",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Enrolled = table.Column<int>(type: "int", nullable: false),
                    Population = table.Column<int>(type: "int", nullable: false),
                    CandidateValidOrdinaryVotes = table.Column<int>(type: "int", nullable: false),
                    CandidateInformalOrdinaryVotes = table.Column<int>(type: "int", nullable: false),
                    CandidateValidSpecialVotes = table.Column<int>(type: "int", nullable: false),
                    CandidateInformalSpecialVotes = table.Column<int>(type: "int", nullable: false),
                    CandidateSpecialVotesDisallowed = table.Column<int>(type: "int", nullable: false),
                    PartyValidOrdinaryVotes = table.Column<int>(type: "int", nullable: false),
                    PartyInformalOrdinaryVotes = table.Column<int>(type: "int", nullable: false),
                    PartyValidSpecialVotes = table.Column<int>(type: "int", nullable: false),
                    PartyInformalSpecialVotes = table.Column<int>(type: "int", nullable: false),
                    PartySpecialVotesDisallowed = table.Column<int>(type: "int", nullable: false),
                    ElectionId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ElectorateId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ElectorateVotes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ElectorateVotes_Elections_ElectionId",
                        column: x => x.ElectionId,
                        principalTable: "Elections",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ElectorateVotes_Electorates_ElectorateId",
                        column: x => x.ElectorateId,
                        principalTable: "Electorates",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CandidateCampaigns",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CandidateId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ElectionId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    PartyId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CandidateCampaigns", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CandidateCampaigns_Candidates_CandidateId",
                        column: x => x.CandidateId,
                        principalTable: "Candidates",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CandidateCampaigns_Elections_ElectionId",
                        column: x => x.ElectionId,
                        principalTable: "Elections",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CandidateCampaigns_Parties_PartyId",
                        column: x => x.PartyId,
                        principalTable: "Parties",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PartyCampaigns",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CandidateSeats = table.Column<int>(type: "int", nullable: false),
                    CandidateVotes = table.Column<int>(type: "int", nullable: false),
                    PartySeats = table.Column<int>(type: "int", nullable: false),
                    PartyVotes = table.Column<int>(type: "int", nullable: false),
                    Registered = table.Column<bool>(type: "bit", nullable: false),
                    ElectionId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    PartyId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PartyCampaigns", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PartyCampaigns_Elections_ElectionId",
                        column: x => x.ElectionId,
                        principalTable: "Elections",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PartyCampaigns_Parties_PartyId",
                        column: x => x.PartyId,
                        principalTable: "Parties",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BoothCandidateResults",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Votes = table.Column<int>(type: "int", nullable: false),
                    BoothId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CandidateCampaignId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BoothCandidateResults", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BoothCandidateResults_Booths_BoothId",
                        column: x => x.BoothId,
                        principalTable: "Booths",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BoothCandidateResults_CandidateCampaigns_CandidateCampaignId",
                        column: x => x.CandidateCampaignId,
                        principalTable: "CandidateCampaigns",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ElectorateCandidateResults",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Votes = table.Column<int>(type: "int", nullable: false),
                    CandidateCampaignId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ElectorateCandidateResults", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ElectorateCandidateResults_CandidateCampaigns_CandidateCampaignId",
                        column: x => x.CandidateCampaignId,
                        principalTable: "CandidateCampaigns",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BoothPartyResults",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Votes = table.Column<int>(type: "int", nullable: false),
                    BoothId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    PartyCampaignId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BoothPartyResults", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BoothPartyResults_Booths_BoothId",
                        column: x => x.BoothId,
                        principalTable: "Booths",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BoothPartyResults_PartyCampaigns_PartyCampaignId",
                        column: x => x.PartyCampaignId,
                        principalTable: "PartyCampaigns",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ElectoratePartyResults",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Votes = table.Column<int>(type: "int", nullable: false),
                    ElectorateId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    PartyCampaignId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ElectoratePartyResults", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ElectoratePartyResults_Electorates_ElectorateId",
                        column: x => x.ElectorateId,
                        principalTable: "Electorates",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ElectoratePartyResults_PartyCampaigns_PartyCampaignId",
                        column: x => x.PartyCampaignId,
                        principalTable: "PartyCampaigns",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BoothCandidateResults_BoothId",
                table: "BoothCandidateResults",
                column: "BoothId");

            migrationBuilder.CreateIndex(
                name: "IX_BoothCandidateResults_CandidateCampaignId",
                table: "BoothCandidateResults",
                column: "CandidateCampaignId");

            migrationBuilder.CreateIndex(
                name: "IX_BoothPartyResults_BoothId",
                table: "BoothPartyResults",
                column: "BoothId");

            migrationBuilder.CreateIndex(
                name: "IX_BoothPartyResults_PartyCampaignId",
                table: "BoothPartyResults",
                column: "PartyCampaignId");

            migrationBuilder.CreateIndex(
                name: "IX_BoothVotes_BoothId",
                table: "BoothVotes",
                column: "BoothId");

            migrationBuilder.CreateIndex(
                name: "IX_BoothVotes_ElectionId",
                table: "BoothVotes",
                column: "ElectionId");

            migrationBuilder.CreateIndex(
                name: "IX_BoothVotes_ElectorateId",
                table: "BoothVotes",
                column: "ElectorateId");

            migrationBuilder.CreateIndex(
                name: "IX_CandidateCampaigns_CandidateId",
                table: "CandidateCampaigns",
                column: "CandidateId");

            migrationBuilder.CreateIndex(
                name: "IX_CandidateCampaigns_ElectionId",
                table: "CandidateCampaigns",
                column: "ElectionId");

            migrationBuilder.CreateIndex(
                name: "IX_CandidateCampaigns_PartyId",
                table: "CandidateCampaigns",
                column: "PartyId");

            migrationBuilder.CreateIndex(
                name: "IX_ElectorateCandidateResults_CandidateCampaignId",
                table: "ElectorateCandidateResults",
                column: "CandidateCampaignId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ElectoratePartyResults_ElectorateId",
                table: "ElectoratePartyResults",
                column: "ElectorateId");

            migrationBuilder.CreateIndex(
                name: "IX_ElectoratePartyResults_PartyCampaignId",
                table: "ElectoratePartyResults",
                column: "PartyCampaignId");

            migrationBuilder.CreateIndex(
                name: "IX_ElectorateVotes_ElectionId",
                table: "ElectorateVotes",
                column: "ElectionId");

            migrationBuilder.CreateIndex(
                name: "IX_ElectorateVotes_ElectorateId",
                table: "ElectorateVotes",
                column: "ElectorateId");

            migrationBuilder.CreateIndex(
                name: "IX_PartyCampaigns_ElectionId",
                table: "PartyCampaigns",
                column: "ElectionId");

            migrationBuilder.CreateIndex(
                name: "IX_PartyCampaigns_PartyId",
                table: "PartyCampaigns",
                column: "PartyId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BoothCandidateResults");

            migrationBuilder.DropTable(
                name: "BoothPartyResults");

            migrationBuilder.DropTable(
                name: "BoothVotes");

            migrationBuilder.DropTable(
                name: "ElectorateCandidateResults");

            migrationBuilder.DropTable(
                name: "ElectoratePartyResults");

            migrationBuilder.DropTable(
                name: "ElectorateVotes");

            migrationBuilder.DropTable(
                name: "Booths");

            migrationBuilder.DropTable(
                name: "CandidateCampaigns");

            migrationBuilder.DropTable(
                name: "PartyCampaigns");

            migrationBuilder.DropTable(
                name: "Electorates");

            migrationBuilder.DropTable(
                name: "Candidates");

            migrationBuilder.DropTable(
                name: "Elections");

            migrationBuilder.DropTable(
                name: "Parties");
        }
    }
}
