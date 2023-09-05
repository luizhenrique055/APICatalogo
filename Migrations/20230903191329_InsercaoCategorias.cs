using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace APICatalogo.Migrations
{
    /// <inheritdoc />
    public partial class InsercaoCategorias : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder mb)
        {
            mb.Sql("INSERT INTO Categorias (Nome, ImagemUrl) VALUES ('Suco', 'imagem1.jpg');");
            mb.Sql("INSERT INTO Categorias (Nome, ImagemUrl) VALUES ('Frutas', 'imagem2.jpg');");
            mb.Sql("INSERT INTO Categorias (Nome, ImagemUrl) VALUES ('Gelados', 'imagem3.jpg');");
            mb.Sql("INSERT INTO Categorias (Nome, ImagemUrl) VALUES ('Laticínios', 'imagem4.jpg');");
            mb.Sql("INSERT INTO Categorias (Nome, ImagemUrl) VALUES ('Bebidas Alcoólicas', 'imagem5.jpg');");
            mb.Sql("INSERT INTO Categorias (Nome, ImagemUrl) VALUES ('Carnes', 'imagem6.jpg');");
            mb.Sql("INSERT INTO Categorias (Nome, ImagemUrl) VALUES ('Produtos de Panificação', 'imagem7.jpg');");
            mb.Sql("INSERT INTO Categorias (Nome, ImagemUrl) VALUES ('Higiene Pessoal', 'imagem8.jpg');");
            mb.Sql("INSERT INTO Categorias (Nome, ImagemUrl) VALUES ('Limpeza Doméstica', 'imagem9.jpg');");
            mb.Sql("INSERT INTO Categorias (Nome, ImagemUrl) VALUES ('Eletrônicos', 'imagem10.jpg');");
            mb.Sql("INSERT INTO Categorias (Nome, ImagemUrl) VALUES ('Vestuário', 'imagem11.jpg');");
            mb.Sql("INSERT INTO Categorias (Nome, ImagemUrl) VALUES ('Móveis', 'imagem12.jpg');");
            mb.Sql("INSERT INTO Categorias (Nome, ImagemUrl) VALUES ('Ferramentas', 'imagem13.jpg');");
            mb.Sql("INSERT INTO Categorias (Nome, ImagemUrl) VALUES ('Jogos e Brinquedos', 'imagem14.jpg');");
            mb.Sql("INSERT INTO Categorias (Nome, ImagemUrl) VALUES ('Livros', 'imagem15.jpg');");
            mb.Sql("INSERT INTO Categorias (Nome, ImagemUrl) VALUES ('Tecnologia', 'imagem16.jpg');");
            mb.Sql("INSERT INTO Categorias (Nome, ImagemUrl) VALUES ('Artigos de Cozinha', 'imagem17.jpg');");
            mb.Sql("INSERT INTO Categorias (Nome, ImagemUrl) VALUES ('Produtos de Beleza', 'imagem18.jpg');");
            mb.Sql("INSERT INTO Categorias (Nome, ImagemUrl) VALUES ('Esportes e Fitness', 'imagem19.jpg');");
            mb.Sql("INSERT INTO Categorias (Nome, ImagemUrl) VALUES ('Alimentos Enlatados', 'imagem20.jpg');");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder mb)
        {
            mb.Sql("Delete from Categoria");
        }
    }
}
