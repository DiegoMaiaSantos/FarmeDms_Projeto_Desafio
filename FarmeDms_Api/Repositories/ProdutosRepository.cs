using FarmeDms_Api.Models;
using FarmeDms_Api.Models.Entities.Produtos;

namespace FarmeDms_Api.Repositories
{
    public interface IProdutosRepository
    {
        public bool Create(PostProdutos produtos);
        public Produtos Read(int id);
        public bool Update(PutProdutos produtos);
        public bool Delete(int id);
    }
    public class ProdutosRepository: IProdutosRepository
    {
        private readonly _DbContext db;
        public ProdutosRepository(_DbContext _db)
        {
            db = _db;
        }

        // Criar ================================

        public bool Create(PostProdutos produtos)
        {
            try
            {
                var produto_db = new Produtos()
                {
                    Nome_Produto = produtos.Nome_Produto,
                    Preco_Produto = produtos.Preco_Produto,
                    Quantidade_Produto = produtos.Quantidade_Produto,
                    Id_Loja = produtos.Id_Loja,
                    Uf = produtos.Uf,
                    Cidade = produtos.Cidade,   
                    Endereco = produtos.Endereco,
                };
                db.Produtos.Add(produto_db);
                db.SaveChanges();

                return true;
            }
            catch
            {
                return false;
            }
        }

        // Pesquisar ============================

        public Produtos Read(int id)
        {
            try
            {                
                var produto_db = db.Produtos.Find(id);
                return produto_db;
            }
            catch
            {
                return new Produtos();
            }
        }

        // Atualizar/Substituir ==================

        public bool Update(PutProdutos produto)
        {
            try
            {
                var produto_db = db.Produtos.Find(produto.id);
                produto_db.Nome_Produto = produto.Nome_Produto;
                produto_db.Preco_Produto = produto.Preco_Produto;
                produto_db.Quantidade_Produto = produto.Quantidade_Produto;
                produto_db.Uf = produto.Uf;
                produto_db.Cidade = produto.Cidade;
                produto_db.Endereco = produto.Endereco;
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        // Deletar/Remover ======================

        public bool Delete(int id)
        {
            try
            {
                var produto_db = db.Produtos.Find(id);
                db.Produtos.Remove(produto_db);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
