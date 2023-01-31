using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace parkingvip.Migrations
{
    /// <inheritdoc />
    public partial class initiala : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "VehiculoId",
                table: "tipo_Vehiculos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_tipo_Vehiculos_VehiculoId",
                table: "tipo_Vehiculos",
                column: "VehiculoId");

            migrationBuilder.AddForeignKey(
                name: "FK_tipo_Vehiculos_vehiculos_VehiculoId",
                table: "tipo_Vehiculos",
                column: "VehiculoId",
                principalTable: "vehiculos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tipo_Vehiculos_vehiculos_VehiculoId",
                table: "tipo_Vehiculos");

            migrationBuilder.DropIndex(
                name: "IX_tipo_Vehiculos_VehiculoId",
                table: "tipo_Vehiculos");

            migrationBuilder.DropColumn(
                name: "VehiculoId",
                table: "tipo_Vehiculos");
        }
    }
}
