using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace VeterinariaWeb.Migrations
{
    public partial class PrimeraMigracion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Animales",
                columns: table => new
                {
                    idAnimal = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tipoAnimal = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Animales", x => x.idAnimal);
                });

            migrationBuilder.CreateTable(
                name: "Pacientes",
                columns: table => new
                {
                    IdPaciente = table.Column<int>(type: "int", nullable: false),
                    NombrePaciente = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Apellido = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    NombreDueno = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Atendido = table.Column<bool>(type: "bit", nullable: false),
                    ClaseAnimal = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    FechaNacimiento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TipoAtencion = table.Column<int>(type: "int", nullable: false),
                    FotoRuta = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pacientes", x => x.IdPaciente);
                });

            migrationBuilder.CreateTable(
                name: "AnimalPacient",
                columns: table => new
                {
                    AnimalesidAnimal = table.Column<int>(type: "int", nullable: false),
                    PacientsIdPaciente = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnimalPacient", x => new { x.AnimalesidAnimal, x.PacientsIdPaciente });
                    table.ForeignKey(
                        name: "FK_AnimalPacient_Animales_AnimalesidAnimal",
                        column: x => x.AnimalesidAnimal,
                        principalTable: "Animales",
                        principalColumn: "idAnimal",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AnimalPacient_Pacientes_PacientsIdPaciente",
                        column: x => x.PacientsIdPaciente,
                        principalTable: "Pacientes",
                        principalColumn: "IdPaciente",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AnimalPacient_PacientsIdPaciente",
                table: "AnimalPacient",
                column: "PacientsIdPaciente");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AnimalPacient");

            migrationBuilder.DropTable(
                name: "Animales");

            migrationBuilder.DropTable(
                name: "Pacientes");
        }
    }
}
