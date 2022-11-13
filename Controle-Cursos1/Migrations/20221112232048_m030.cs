using Microsoft.EntityFrameworkCore.Migrations;

namespace Controle_Cursos1.Migrations
{
    public partial class m030 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Modalidade",
                table: "Cursos",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Tipo",
                table: "Alunos",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Modalidade",
                table: "Cursos",
                type: "int",
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<int>(
                name: "Tipo",
                table: "Alunos",
                type: "int",
                nullable: false,
                oldClrType: typeof(string));
        }
    }
}
