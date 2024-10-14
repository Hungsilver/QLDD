using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QLDD.Migrations
{
    /// <inheritdoc />
    public partial class CreateTableUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstMidName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BirthYear = table.Column<int>(type: "int", nullable: false),
                    Gender = table.Column<int>(type: "int", nullable: false),
                    TaxCode = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    NationalityCode = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: true),
                    NationalityNameTV = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    NationalityNameQT = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    Nation = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    TypeOfIdentificationDocs = table.Column<int>(type: "int", nullable: false),
                    IssueDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IssuePlace = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    AddressID = table.Column<int>(type: "int", nullable: false),
                    IdentificationID = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
