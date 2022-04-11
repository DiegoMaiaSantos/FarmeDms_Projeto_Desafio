using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FarmeDms_Api.Migrations
{
    public partial class AtualizandoMigrationV2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Produtos",
                table: "Produtos");

            migrationBuilder.RenameColumn(
                name: "Quantidade",
                table: "Produtos",
                newName: "Quantidade_Produto");

            migrationBuilder.RenameColumn(
                name: "Preco",
                table: "Produtos",
                newName: "Preco_Produto");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Produtos",
                newName: "Id_Loja");

            migrationBuilder.RenameColumn(
                name: "Quantidade",
                table: "Lojas",
                newName: "Quantidade_Produto");

            migrationBuilder.RenameColumn(
                name: "Nome_Produto",
                table: "Lojas",
                newName: "Uf");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Lojas",
                newName: "Id_Loja");

            migrationBuilder.AlterColumn<int>(
                name: "Id_Loja",
                table: "Produtos",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddColumn<int>(
                name: "Id_Produto",
                table: "Produtos",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Produtos",
                table: "Produtos",
                column: "Id_Produto");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Produtos",
                table: "Produtos");

            migrationBuilder.DropColumn(
                name: "Id_Produto",
                table: "Produtos");

            migrationBuilder.RenameColumn(
                name: "Quantidade_Produto",
                table: "Produtos",
                newName: "Quantidade");

            migrationBuilder.RenameColumn(
                name: "Preco_Produto",
                table: "Produtos",
                newName: "Preco");

            migrationBuilder.RenameColumn(
                name: "Id_Loja",
                table: "Produtos",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "Uf",
                table: "Lojas",
                newName: "Nome_Produto");

            migrationBuilder.RenameColumn(
                name: "Quantidade_Produto",
                table: "Lojas",
                newName: "Quantidade");

            migrationBuilder.RenameColumn(
                name: "Id_Loja",
                table: "Lojas",
                newName: "Id");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Produtos",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Produtos",
                table: "Produtos",
                column: "Id");
        }
    }
}
