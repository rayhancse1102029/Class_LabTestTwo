using Microsoft.EntityFrameworkCore.Migrations;

namespace LabTesttTwo.Migrations
{
    public partial class add_cls_student_reg_2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "cls",
                table: "StudentRegs",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "cls",
                table: "StudentRegs");
        }
    }
}
