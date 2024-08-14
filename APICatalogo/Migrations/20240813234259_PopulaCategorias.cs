using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace APICatalogo.Migrations
{
    /// <inheritdoc />
    public partial class PopulaCategorias : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder mb)
        {
            mb.Sql("INSERT INTO CATEGORIAS(NOME, IMAGEURL) VALUES ('bebidas','bebidas.jpg')");
            mb.Sql("INSERT INTO CATEGORIAS(NOME, IMAGEURL) VALUES ('lanches','lanches.jpg')");
            mb.Sql("INSERT INTO CATEGORIAS(NOME, IMAGEURL) VALUES ('doces','doces.jpg')");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder mb)
        {
            mb.Sql("DELETE FROM CATEGORIAS");
        }
    }
}
