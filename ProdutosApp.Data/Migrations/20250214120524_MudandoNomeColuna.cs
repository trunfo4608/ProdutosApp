using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProdutosApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class MudandoNomeColuna : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Descricao",
                table: "PRODUTO",
                newName: "DESCRICAO");

            migrationBuilder.AlterColumn<string>(
                name: "DESCRICAO",
                table: "PRODUTO",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DESCRICAO",
                table: "PRODUTO",
                newName: "Descricao");

            migrationBuilder.AlterColumn<string>(
                name: "Descricao",
                table: "PRODUTO",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(250)",
                oldMaxLength: 250);
        }
    }
}
