using System.ComponentModel.DataAnnotations;

namespace FarmeDms_Api.Models
{
    public class Produtos
    {   
        [Key]
        public int Id_Produto { get; set; }
        public string Nome_Produto { get; set; }
        public double Preco_Produto { get; set; }
        public int Quantidade_Produto { get; set; }        
        public int Id_Loja { get; set; }
        public string Uf { get; set; }
        public string Cidade { get; set; }
        public string Endereco { get; set; }
    }
}
