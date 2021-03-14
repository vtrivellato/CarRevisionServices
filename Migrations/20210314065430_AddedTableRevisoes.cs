using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace api.Migrations
{
    public partial class AddedTableRevisoes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedAt",
                table: "Veiculos",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AddUniqueConstraint(
                name: "AK_Veiculos_Chassi",
                table: "Veiculos",
                column: "Chassi");

            migrationBuilder.CreateTable(
                name: "Revisoes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Chassi = table.Column<string>(type: "nvarchar(17)", maxLength: 17, nullable: false),
                    Km = table.Column<double>(type: "float", nullable: false),
                    DataRevisao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Valor = table.Column<double>(type: "float", nullable: false),
                    Observacao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Revisoes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Revisoes_Veiculos_Chassi",
                        column: x => x.Chassi,
                        principalTable: "Veiculos",
                        principalColumn: "Chassi",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Revisoes_Chassi_Km",
                table: "Revisoes",
                columns: new[] { "Chassi", "Km" },
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Revisoes");

            migrationBuilder.DropUniqueConstraint(
                name: "AK_Veiculos_Chassi",
                table: "Veiculos");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedAt",
                table: "Veiculos",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);
        }
    }
}
