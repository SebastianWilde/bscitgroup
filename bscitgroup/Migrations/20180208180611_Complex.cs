using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace bscitgroup.Migrations
{
    public partial class Complex : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Servicio",
                columns: table => new
                {
                    ServicioID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CategoriaID = table.Column<int>(nullable: true),
                    Descripcion = table.Column<string>(nullable: true),
                    Nombre = table.Column<string>(nullable: false),
                    Objetivo = table.Column<string>(nullable: true),
                    Tipo = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Servicio", x => x.ServicioID);
                    table.ForeignKey(
                        name: "FK_Servicio_Categorias_CategoriaID",
                        column: x => x.CategoriaID,
                        principalTable: "Categorias",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ServicioDetalle",
                columns: table => new
                {
                    ServicioDetalleId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Costo = table.Column<decimal>(type: "money", nullable: false),
                    FechaFin = table.Column<DateTime>(nullable: false),
                    FechaInicio = table.Column<DateTime>(nullable: false),
                    HoraFin = table.Column<DateTime>(nullable: false),
                    HoraInico = table.Column<DateTime>(nullable: false),
                    Modalidad = table.Column<string>(nullable: false),
                    ServicioID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServicioDetalle", x => x.ServicioDetalleId);
                    table.ForeignKey(
                        name: "FK_ServicioDetalle_Servicio_ServicioID",
                        column: x => x.ServicioID,
                        principalTable: "Servicio",
                        principalColumn: "ServicioID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PersonaServicioDetalle",
                columns: table => new
                {
                    PersonaServicioDetalleID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Inscripcion = table.Column<DateTime>(nullable: false),
                    Participacion = table.Column<bool>(nullable: false),
                    PersonaID = table.Column<int>(nullable: false),
                    ServicioDetalleID = table.Column<int>(nullable: false),
                    ServicioID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonaServicioDetalle", x => x.PersonaServicioDetalleID);
                    table.ForeignKey(
                        name: "FK_PersonaServicioDetalle_Persona_PersonaID",
                        column: x => x.PersonaID,
                        principalTable: "Persona",
                        principalColumn: "DNI",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PersonaServicioDetalle_ServicioDetalle_ServicioDetalleID",
                        column: x => x.ServicioDetalleID,
                        principalTable: "ServicioDetalle",
                        principalColumn: "ServicioDetalleId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PersonaServicioDetalle_Servicio_ServicioID",
                        column: x => x.ServicioID,
                        principalTable: "Servicio",
                        principalColumn: "ServicioID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PersonaServicioDetalle_PersonaID",
                table: "PersonaServicioDetalle",
                column: "PersonaID");

            migrationBuilder.CreateIndex(
                name: "IX_PersonaServicioDetalle_ServicioDetalleID",
                table: "PersonaServicioDetalle",
                column: "ServicioDetalleID");

            migrationBuilder.CreateIndex(
                name: "IX_PersonaServicioDetalle_ServicioID",
                table: "PersonaServicioDetalle",
                column: "ServicioID");

            migrationBuilder.CreateIndex(
                name: "IX_Servicio_CategoriaID",
                table: "Servicio",
                column: "CategoriaID");

            migrationBuilder.CreateIndex(
                name: "IX_ServicioDetalle_ServicioID",
                table: "ServicioDetalle",
                column: "ServicioID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PersonaServicioDetalle");

            migrationBuilder.DropTable(
                name: "ServicioDetalle");

            migrationBuilder.DropTable(
                name: "Servicio");
        }
    }
}
