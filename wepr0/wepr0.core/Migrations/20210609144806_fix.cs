using Microsoft.EntityFrameworkCore.Migrations;

namespace Wepr0.core.Migrations
{
    public partial class fix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Processos_Moeda_MoedaId",
                table: "Processos");

            migrationBuilder.AlterColumn<int>(
                name: "MoedaId",
                table: "Processos",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Processos_Moeda_MoedaId",
                table: "Processos",
                column: "MoedaId",
                principalTable: "Moeda",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Processos_Moeda_MoedaId",
                table: "Processos");

            migrationBuilder.AlterColumn<int>(
                name: "MoedaId",
                table: "Processos",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Processos_Moeda_MoedaId",
                table: "Processos",
                column: "MoedaId",
                principalTable: "Moeda",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
