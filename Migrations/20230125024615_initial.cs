using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace parkingvip.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tipo_Vehiculos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tipo_Vehiculos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "vehiculos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Placa = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: false),
                    Hentrada = table.Column<DateTime>(name: "H_entrada", type: "datetime2", nullable: false),
                    Hsalida = table.Column<DateTime>(name: "H_salida", type: "datetime2", nullable: false),
                    Estado = table.Column<float>(type: "real", nullable: false),
                    Nparqueadero = table.Column<string>(name: "N_parqueadero", type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_vehiculos", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_tipo_Vehiculos_Id",
                table: "tipo_Vehiculos",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_vehiculos_Id",
                table: "vehiculos",
                column: "Id",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tipo_Vehiculos");

            migrationBuilder.DropTable(
                name: "vehiculos");
        }
    }
}
