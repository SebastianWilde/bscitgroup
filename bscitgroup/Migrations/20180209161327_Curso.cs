using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace bscitgroup.Migrations
{
    public partial class Curso : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CursoID",
                table: "Persona",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Curso",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Certificacion = table.Column<string>(nullable: true),
                    Contenido = table.Column<string>(nullable: false),
                    Contenido2 = table.Column<string>(nullable: true),
                    EContenido1 = table.Column<string>(nullable: true),
                    EContenido2 = table.Column<string>(nullable: true),
                    Fechafin = table.Column<DateTime>(nullable: false),
                    Fechainicio = table.Column<DateTime>(nullable: false),
                    ImagenCurso = table.Column<byte[]>(nullable: true),
                    ImagenCurso2 = table.Column<string>(nullable: true),
                    Informe = table.Column<string>(nullable: true),
                    Informe2 = table.Column<string>(nullable: true),
                    Instructor = table.Column<string>(nullable: true),
                    Nombre = table.Column<string>(nullable: false),
                    Objetivo1 = table.Column<string>(nullable: true),
                    Objetivo2 = table.Column<string>(nullable: true),
                    Objetivo3 = table.Column<string>(nullable: true),
                    Objetivo4 = table.Column<string>(nullable: true),
                    Objetivo5 = table.Column<string>(nullable: true),
                    Pago = table.Column<decimal>(nullable: false),
                    Publico = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Curso", x => x.ID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Persona_CursoID",
                table: "Persona",
                column: "CursoID");

            migrationBuilder.AddForeignKey(
                name: "FK_Persona_Curso_CursoID",
                table: "Persona",
                column: "CursoID",
                principalTable: "Curso",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Persona_Curso_CursoID",
                table: "Persona");

            migrationBuilder.DropTable(
                name: "Curso");

            migrationBuilder.DropIndex(
                name: "IX_Persona_CursoID",
                table: "Persona");

            migrationBuilder.DropColumn(
                name: "CursoID",
                table: "Persona");
        }
    }
}
