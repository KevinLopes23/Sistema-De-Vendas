namespace Cprod.code.dto.dto
{
    public class ProdutosDto
    {
        public int CodigoProduto { get; set; }
        public string? Descricao { get; set; }
        public float QuantidadeEstoque { get; set; }
        public double Preco { get; set; }
        public DateTime DataVencimento { get; set; }
        public int CodigoMarca { get; set; }
        public string? TipoRegistro { get; set; }


    }

    public class MarcaDto
    {
        public int CodigoMarca { get; set; }
        public string? Descricao { get; set; }
    }

    public class UsuariosDto
    {
        public int CodigoUsuario { get; set; }

        public string? Nome { get; set; }

        public string? Usuario { get; set; }

        public string? Senha { get; set; }

    }



    public class VendaDTO
    {
        public int CodVenda { get; set; }
        public DateTime Data { get; set; }

    }


    public class ItemVendaDTO
    {
        public int CodVenda { get; set; }
        public int CodProduto { get; set; }
        public int Quantidade { get; set; }
        public decimal Valor { get; set; }




    }



}
