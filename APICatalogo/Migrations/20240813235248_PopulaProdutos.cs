using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace APICatalogo.Migrations
{
    /// <inheritdoc />
    public partial class PopulaProdutos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder mb)
        {
            mb.Sql("Insert into Produtos(Nome,Descricao,Preco,ImageUrl,Estoque,DataCadastro,CategoriaId) " +
                "Values ('CocaCola','refrigerante de 350 ml',10.99,'cocacola.jpg',10,now(),1)");

            mb.Sql("Insert into Produtos(Nome,Descricao,Preco,ImageUrl,Estoque,DataCadastro,CategoriaId) " +
                "Values ('Torrada','torrada de queijo',5.00,'torrada.jpg',10,now(),2)");

            mb.Sql("Insert into Produtos(Nome,Descricao,Preco,ImageUrl,Estoque,DataCadastro,CategoriaId) " +
               "Values ('Brigadeiro','brigadeiro de nescau',3.50,'brigadeiro.jpg',10,now(),3)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder mb)
        {
            mb.Sql("Delete from Produtos");
        }
    }
}
