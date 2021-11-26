﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace EMigrant.App.Persistencia.Migrations
{
    public partial class Entidades : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Migrantes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombres = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    Apellidos = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    TipoDocumento = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    NDocumento = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    PaisOrigen = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    FechaNacimiento = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    Telefono = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Correo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DireccionActual = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ciudad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SituacionLaboral = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Migrantes", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Migrantes");
        }
    }
}
