using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace bscitgroup.Migrations
{
    public partial class Files : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImagenCurso2",
                table: "Curso",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImagenCurso2",
                table: "Curso");
        }
    }
}
