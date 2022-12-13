using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Administrador.EF.Migrations
{
    /// <inheritdoc />
    public partial class InitialStructure : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Chofer",
                columns: table => new
                {
                    choferId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    nombreCompleto = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    direccion = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    telefono = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    modelo = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    marca = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    placa = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Chofer", x => x.choferId);
                });

            migrationBuilder.CreateTable(
                name: "Cliente",
                columns: table => new
                {
                    clienteId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    nombreCompleto = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    nombreTienda = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    tipoTienda = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    direccion = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    telefono = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cliente", x => x.clienteId);
                });

            migrationBuilder.CreateTable(
                name: "Vendedor",
                columns: table => new
                {
                    vendedorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    nombreCompleto = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    direccion = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    telefono = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vendedor", x => x.vendedorId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Chofer");

            migrationBuilder.DropTable(
                name: "Cliente");

            migrationBuilder.DropTable(
                name: "Vendedor");
        }
    }
}
