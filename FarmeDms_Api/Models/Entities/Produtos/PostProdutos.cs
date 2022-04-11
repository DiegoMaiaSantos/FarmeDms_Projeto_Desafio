namespace FarmeDms_Api.Models.Entities.Produtos
{
    public class PostProdutos
    {
        public string Nome_Produto { get; set; }
        public double Preco_Produto { get; set; }
        public int Quantidade_Produto { get; set; }
        public int Id_Loja { get; set; }
        public string Uf { get; set; }
        public string Cidade { get; set; }
        public string Endereco { get; set; }
    }
}