using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QLDD.Migrations
{
    /// <inheritdoc />
    public partial class tb1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Addresses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WardCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddressDetail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Street = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Hamlet = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ward = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    District = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Province = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Addresses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HouseHolds",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddressID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HouseHolds", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProcessInfos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReceptionDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DueDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DueProcessDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TypeReception = table.Column<int>(type: "int", nullable: true),
                    TypeReceiceDate = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProcessInfos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirstMidName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    BirthYear = table.Column<int>(type: "int", nullable: true),
                    Gender = table.Column<int>(type: "int", nullable: true),
                    Avatar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TaxCode = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NationalityCode = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: true),
                    NationalityNameTV = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    NationalityNameQT = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    Nation = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    Religion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Career = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NameAndAddressOrganization = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Birthplace = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CitizenID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IssueDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IssuePlace = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Role = table.Column<int>(type: "int", nullable: true),
                    PermanentAddressID = table.Column<int>(type: "int", nullable: true),
                    TemporaryAddressID = table.Column<int>(type: "int", nullable: true),
                    HouseHoldID = table.Column<int>(type: "int", nullable: true),
                    RoleInFamily = table.Column<int>(type: "int", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_Addresses_PermanentAddressID",
                        column: x => x.PermanentAddressID,
                        principalTable: "Addresses",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Users_Addresses_TemporaryAddressID",
                        column: x => x.TemporaryAddressID,
                        principalTable: "Addresses",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Users_HouseHolds_HouseHoldID",
                        column: x => x.HouseHoldID,
                        principalTable: "HouseHolds",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Documents",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    FirstMidName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Gender = table.Column<int>(type: "int", nullable: true),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Birthplace = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Avatar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CitizenID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IssueDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IssuePlace = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Nation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Religion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Career = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NameAndAddressOrganization = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserID = table.Column<int>(type: "int", nullable: true),
                    PermanentAddressID = table.Column<int>(type: "int", nullable: true),
                    TemporaryAddressID = table.Column<int>(type: "int", nullable: true),
                    NameFather = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    BirthDateFather = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NameMother = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    BirthDateMother = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NameHubOrWf = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    BirthDateHubOrWf = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SuggestedContent = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    DetailContent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReceivingAgency = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CoUserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BirthDateCoUser = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NumberGCN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NumberGCNIssue = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateIssueGCN = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PlaceIssueGCN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContentBeforeGCN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContentAfterGCN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReasonGCN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    THNVTC = table.Column<bool>(type: "bit", nullable: true),
                    IsIssueGCNNew = table.Column<bool>(type: "bit", nullable: true),
                    UrlFile1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UrlGCN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UrlFile3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UrlAttachedFile = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProcessUserID = table.Column<int>(type: "int", nullable: true),
                    ProcessInfoID = table.Column<int>(type: "int", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Documents", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Documents_Addresses_PermanentAddressID",
                        column: x => x.PermanentAddressID,
                        principalTable: "Addresses",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Documents_Addresses_TemporaryAddressID",
                        column: x => x.TemporaryAddressID,
                        principalTable: "Addresses",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Documents_ProcessInfos_ProcessInfoID",
                        column: x => x.ProcessInfoID,
                        principalTable: "ProcessInfos",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Documents_Users_ProcessUserID",
                        column: x => x.ProcessUserID,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "HistoryDocuments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Action = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TimeChange = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: true),
                    DocumentId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HistoryDocuments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HistoryDocuments_Documents_DocumentId",
                        column: x => x.DocumentId,
                        principalTable: "Documents",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_HistoryDocuments_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Documents_PermanentAddressID",
                table: "Documents",
                column: "PermanentAddressID");

            migrationBuilder.CreateIndex(
                name: "IX_Documents_ProcessInfoID",
                table: "Documents",
                column: "ProcessInfoID",
                unique: true,
                filter: "[ProcessInfoID] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Documents_ProcessUserID",
                table: "Documents",
                column: "ProcessUserID");

            migrationBuilder.CreateIndex(
                name: "IX_Documents_TemporaryAddressID",
                table: "Documents",
                column: "TemporaryAddressID");

            migrationBuilder.CreateIndex(
                name: "IX_HistoryDocuments_DocumentId",
                table: "HistoryDocuments",
                column: "DocumentId");

            migrationBuilder.CreateIndex(
                name: "IX_HistoryDocuments_UserId",
                table: "HistoryDocuments",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_HouseHoldID",
                table: "Users",
                column: "HouseHoldID");

            migrationBuilder.CreateIndex(
                name: "IX_Users_PermanentAddressID",
                table: "Users",
                column: "PermanentAddressID",
                unique: true,
                filter: "[PermanentAddressID] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Users_TemporaryAddressID",
                table: "Users",
                column: "TemporaryAddressID",
                unique: true,
                filter: "[TemporaryAddressID] IS NOT NULL");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HistoryDocuments");

            migrationBuilder.DropTable(
                name: "Documents");

            migrationBuilder.DropTable(
                name: "ProcessInfos");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Addresses");

            migrationBuilder.DropTable(
                name: "HouseHolds");
        }
    }
}
