using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace siswaAPI.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SISWA",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NIS = table.Column<string>(type: "nvarchar(60)", nullable: false),
                    NAME = table.Column<string>(type: "nvarchar(250)", nullable: false),
                    GENDER = table.Column<string>(type: "nvarchar(20)", nullable: false),
                    RELIGION = table.Column<string>(type: "nvarchar(250)", nullable: false),
                    ADDRESS = table.Column<string>(type: "nvarchar(4000)", nullable: false),
                    STUDY = table.Column<string>(type: "nvarchar(250)", nullable: false),
                    CLASS = table.Column<string>(type: "nvarchar(250)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SISWA", x => x.ID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SISWA");
        }
    }
}
