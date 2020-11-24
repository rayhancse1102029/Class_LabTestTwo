using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LabTesttTwo.Migrations
{
    public partial class student_reg : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "StudentRegistrations",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(nullable: false),
                    clsName = table.Column<string>(nullable: false),
                    dept = table.Column<string>(nullable: true),
                    roll = table.Column<string>(nullable: false),
                    father = table.Column<string>(nullable: true),
                    mother = table.Column<string>(nullable: true),
                    mobile = table.Column<string>(nullable: false),
                    email = table.Column<string>(nullable: true),
                    present = table.Column<string>(nullable: false),
                    parmanent = table.Column<string>(nullable: true),
                    cretedAt = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentRegistrations", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StudentRegistrations");
        }
    }
}
