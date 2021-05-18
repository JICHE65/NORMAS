using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Normas.Api.Migrations
{
    public partial class Initialize : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Normas");

            migrationBuilder.CreateTable(
                name: "Normas",
                schema: "Normas",
                columns: table => new
                {
                    NormaID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Clave = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    FechaPublicacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Activo = table.Column<bool>(type: "bit", nullable: false),
                    TipoRequisitoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Normas", x => x.NormaID);
                });

            migrationBuilder.CreateTable(
                name: "TipoRequisitos",
                schema: "Normas",
                columns: table => new
                {
                    TipoRequisitoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoRequisitos", x => x.TipoRequisitoId);
                });

            migrationBuilder.InsertData(
                schema: "Normas",
                table: "Normas",
                columns: new[] { "NormaID", "Activo", "Clave", "Descripcion", "FechaPublicacion", "TipoRequisitoId" },
                values: new object[] { 1, true, "abc123", "descripcion", new DateTime(2021, 5, 11, 21, 58, 27, 164, DateTimeKind.Local).AddTicks(4211), 1 });

            migrationBuilder.InsertData(
                schema: "Normas",
                table: "TipoRequisitos",
                columns: new[] { "TipoRequisitoId", "Descripcion" },
                values: new object[,]
                {
                    { 1, "Norma Oficial Mexicana (NOM)" },
                    { 2, "Especificacion CFE" },
                    { 3, "Reglamento Federal" },
                    { 4, "Reglamento Estatal" },
                    { 5, "reglamento Municipal" },
                    { 6, "estandar internacional" },
                    { 7, "Norma de Referencia" },
                    { 8, "Norma mexicana" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Normas",
                schema: "Normas");

            migrationBuilder.DropTable(
                name: "TipoRequisitos",
                schema: "Normas");
        }
    }
}
