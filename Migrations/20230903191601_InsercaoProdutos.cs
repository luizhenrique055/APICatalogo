using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace APICatalogo.Migrations
{
    /// <inheritdoc />
    public partial class InsercaoProdutos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder mb)
        {
            mb.Sql("INSERT INTO Produtos (Nome, Descricao, Preco, ImagemUrl, Estoque, DataCadastro, CategoriaId) VALUES ('Suco de Laranja', 'Suco de laranja natural', 2.99, 'suco_laranja.jpg', 100, NOW(), 1);");
            mb.Sql("INSERT INTO Produtos (Nome, Descricao, Preco, ImagemUrl, Estoque, DataCadastro, CategoriaId) VALUES ('Maçãs', 'Pacote com 6 maçãs frescas', 4.99, 'macas.jpg', 50, NOW(), 2);");
            mb.Sql("INSERT INTO Produtos (Nome, Descricao, Preco, ImagemUrl, Estoque, DataCadastro, CategoriaId) VALUES ('Sorvete de Chocolate', 'Sorvete de chocolate premium', 3.49, 'sorvete_chocolate.jpg', 75, NOW(), 3);");
            mb.Sql("INSERT INTO Produtos (Nome, Descricao, Preco, ImagemUrl, Estoque, DataCadastro, CategoriaId) VALUES ('Leite Integral', 'Leite fresco e nutritivo', 2.49, 'leite_integral.jpg', 60, NOW(), 4);");
            mb.Sql("INSERT INTO Produtos (Nome, Descricao, Preco, ImagemUrl, Estoque, DataCadastro, CategoriaId) VALUES ('Vinho Tinto', 'Vinho tinto de qualidade', 19.99, 'vinho_tinto.jpg', 30, NOW(), 5);");
            mb.Sql("INSERT INTO Produtos (Nome, Descricao, Preco, ImagemUrl, Estoque, DataCadastro, CategoriaId) VALUES ('Bife de Filé Mignon', 'Bife de filé mignon suculento', 12.99, 'bife_file.jpg', 40, NOW(), 6);");
            mb.Sql("INSERT INTO Produtos (Nome, Descricao, Preco, ImagemUrl, Estoque, DataCadastro, CategoriaId) VALUES ('Pão Integral', 'Pão integral fresco', 2.49, 'pao_integral.jpg', 80, NOW(), 7);");
            mb.Sql("INSERT INTO Produtos (Nome, Descricao, Preco, ImagemUrl, Estoque, DataCadastro, CategoriaId) VALUES ('Shampoo', 'Shampoo revitalizante', 6.99, 'shampoo.jpg', 120, NOW(), 8);");
            mb.Sql("INSERT INTO Produtos (Nome, Descricao, Preco, ImagemUrl, Estoque, DataCadastro, CategoriaId) VALUES ('Detergente', 'Detergente de limpeza', 2.99, 'detergente.jpg', 90, NOW(), 9);");
            mb.Sql("INSERT INTO Produtos (Nome, Descricao, Preco, ImagemUrl, Estoque, DataCadastro, CategoriaId) VALUES ('Smartphone', 'Smartphone de última geração', 599.99, 'smartphone.jpg', 15, NOW(), 10);");
            mb.Sql("INSERT INTO Produtos (Nome, Descricao, Preco, ImagemUrl, Estoque, DataCadastro, CategoriaId) VALUES ('Camiseta Casual', 'Camiseta casual confortável', 9.99, 'camiseta_casual.jpg', 60, NOW(), 11);");
            mb.Sql("INSERT INTO Produtos (Nome, Descricao, Preco, ImagemUrl, Estoque, DataCadastro, CategoriaId) VALUES ('Sofá de Couro', 'Sofá de couro elegante', 399.99, 'sofa_couro.jpg', 10, NOW(), 12);");
            mb.Sql("INSERT INTO Produtos (Nome, Descricao, Preco, ImagemUrl, Estoque, DataCadastro, CategoriaId) VALUES ('Furadeira Elétrica', 'Furadeira elétrica de alta potência', 49.99, 'furadeira.jpg', 25, NOW(), 13);");
            mb.Sql("INSERT INTO Produtos (Nome, Descricao, Preco, ImagemUrl, Estoque, DataCadastro, CategoriaId) VALUES ('Quebra-Cabeça', 'Quebra-cabeça desafiador', 7.99, 'quebra_cabeca.jpg', 35, NOW(), 14);");
            mb.Sql("INSERT INTO Produtos (Nome, Descricao, Preco, ImagemUrl, Estoque, DataCadastro, CategoriaId) VALUES ('Ficção Científica', 'Livro de ficção científica', 10.99, 'livro_ficcao.jpg', 45, NOW(), 15);");
            mb.Sql("INSERT INTO Produtos (Nome, Descricao, Preco, ImagemUrl, Estoque, DataCadastro, CategoriaId) VALUES ('Fones de Ouvido Bluetooth', 'Fones de ouvido sem fio', 29.99, 'fones_bluetooth.jpg', 20, NOW(), 16);");
            mb.Sql("INSERT INTO Produtos (Nome, Descricao, Preco, ImagemUrl, Estoque, DataCadastro, CategoriaId) VALUES ('Panela Antiaderente', 'Panela antiaderente de qualidade', 14.99, 'panela.jpg', 30, NOW(), 17);");
            mb.Sql("INSERT INTO Produtos (Nome, Descricao, Preco, ImagemUrl, Estoque, DataCadastro, CategoriaId) VALUES ('Batom', 'Batom de longa duração', 8.99, 'batom.jpg', 50, NOW(), 18);");
            mb.Sql("INSERT INTO Produtos (Nome, Descricao, Preco, ImagemUrl, Estoque, DataCadastro, CategoriaId) VALUES ('Bola de Futebol', 'Bola de futebol oficial', 12.99, 'bola_futebol.jpg', 25, NOW(), 19);");
            mb.Sql("INSERT INTO Produtos (Nome, Descricao, Preco, ImagemUrl, Estoque, DataCadastro, CategoriaId) VALUES ('Feijão Enlatado', 'Feijão enlatado pronto para consumo', 1.99, 'feijao_enlatado.jpg', 70, NOW(), 20);");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder mb)
        {
            mb.Sql("Delete from Categoria");
        }
    }
}
