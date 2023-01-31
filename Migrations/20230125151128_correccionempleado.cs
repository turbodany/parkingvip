using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace parkingvip.Migrations
{
    /// <inheritdoc />
    public partial class correccionempleado : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<string>(
                name: "Placa",
                table: "vehiculos",
                type: "nvarchar(7)",
                maxLength: 7,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(8)",
                oldMaxLength: 8);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Placa",
                table: "vehiculos",
                type: "nvarchar(8)",
                maxLength: 8,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(7)",
                oldMaxLength: 7);

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
    }
}
