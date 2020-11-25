using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LabTesttTwo.Migrations
{
    public partial class add_student_reg : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "StudentRegs",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(nullable: true),
                    dept = table.Column<string>(nullable: true),
                    roll = table.Column<string>(nullable: true),
                    father = table.Column<string>(nullable: true),
                    mother = table.Column<string>(nullable: true),
                    mobile = table.Column<string>(nullable: true),
                    email = table.Column<string>(nullable: true),
                    present = table.Column<string>(nullable: true),
                    parmanent = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentRegs", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StudentRegs");
        }
    }
}
