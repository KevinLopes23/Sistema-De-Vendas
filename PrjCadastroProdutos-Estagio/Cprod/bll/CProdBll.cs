using Cprod.code.dal;
using Cprod.code.dto.dto;
using System.Data;
using System.Data.SQLite;

namespace Cprod.code.bll
{
    public class CprodBll
    {
        private CProdDal dal = new CProdDal();

        public bool ValidarLogin(string usuario, string senha)
        {
            try
            {
                return dal.ValidarCredenciais(usuario, senha);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao validar dados: " + ex.Message);
            }
        }

        public bool VerificaCodigoJaCadastrado(string codigo)
        {
            try
            {
                return dal.VerificaCodigoJaCadastrado(codigo);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao validar dados: " + ex.Message);
            }
        }


        public bool ValidaDescricao(string descricao)
        {
            try
            {
                return dal.ValidaDescricao(descricao);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao validar dados: " + ex.Message);
            }
        }


        public bool ValidaDescricaoMarca(string marca)
        {
            try
            {
                return dal.ValidaDescricaoMarca(marca);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao validar dados: " + ex.Message);
            }
        }


        public bool ExcluirClientePorCodigoDoProduto(int codigoDoProduto)
        {

            try
            {
                return dal.ExcluirClientePorCodigoDoProduto(codigoDoProduto);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao validar dados: " + ex.Message);
            }

        }



        public bool Importar(List<ProdutosDto> lista)
        {
            try
            {

                return dal.ImportarProdutoBanco(lista);
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao validar dados: " + ex.Message);
            }

        }



        public bool VerificaSeExiste(int codmarca)
        {

            try
            {
                return dal.VerificaSeExiste(codmarca);

            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao verificar " + ex.Message);
            }

        }

        public bool ExcluirMarca(int codigomarca)
        {

            try
            {
                return dal.ExcluirMarca(codigomarca);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao validar dados: " + ex.Message);
            }

        }


        public DataTable PesquisaProdutos(string? filtro, string valor)
        {
            try
            {
                return dal.PesquisaProdutos(filtro, valor);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao pesquisar dados " + ex.Message);
            }

        }


        public DataTable PesquisaMarca(string marca)
        {
            try
            {
                return dal.PesquisaMarca(marca);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao pesquisar dados " + ex.Message);
            }
        }


        public ProdutosDto DadosCliente(Int32 codigoCliente)
        {

            try
            {
                return dal.DadosCliente(codigoCliente);
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao ao mostrar os dados do cliente " + ex.Message);
            }



        }


        public MarcaDto DadosMarca(Int32 codigomarca)
        {

            try
            {
                return dal.DadosMarca(codigomarca);
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao ao mostrar os dados do cliente " + ex.Message);
            }



        }

        public Boolean AtualizarMarca(MarcaDto dto)
        {
            try
            {
                return dal.AtualizarMarca(dto);
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao atualizar dados " + ex.Message);

            }


        }


        public Boolean Atualizar(ProdutosDto dto)
        {
            try
            {
                return dal.Atualizar(dto);
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao atualizar dados " + ex.Message);

            }


        }

        public Boolean Gravar(ProdutosDto dto)
        {

            try
            {
                return dal.Gravar(dto);
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao gravar dados " + ex.Message);

            }



        }

        public Boolean GravarMarca(MarcaDto dto)
        {

            try
            {
                return dal.GravarMarca(dto);
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao gravar dados " + ex.Message);

            }



        }


        public int InserirVenda(VendaDTO dto, SQLiteTransaction transaction)
        {
            try
            {
                return dal.InserirVenda(dto, transaction);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao validar dados: " + ex.Message);
            }
        }


        public bool InserirItens(List<ItemVendaDTO> lista, SQLiteTransaction transaction)
        {
            try
            {
                return dal.InserirItens(lista, transaction);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao validar dados: " + ex.Message);
            }
        }



        public bool AtualizaEstoque(List<ItemVendaDTO> lista, SQLiteTransaction transaction)
        {
            try
            {
                return dal.AtualizaEstoque(lista, transaction);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao validar dados: " + ex.Message);
            }
        }




        public bool GravarVendaComItens(VendaDTO venda, List<ItemVendaDTO> itens)
        {
            return dal.GravarVendaComItens(venda, itens);

        }

        public bool VerificaExtoqueDisponivel(int codigoProduto, int quantidadeRequerida)
        {
            return dal.VerificaEstoqueDisponivel(codigoProduto, quantidadeRequerida);
        }


        public int ColocaQuantidadeLabel(int codigoProduto)
        {
            return dal.ColocaQuantidadeLabel(codigoProduto);
        }


        public DataTable PreencheGridEstorno(string codvenda)
        {
            try
            {
                return dal.PreencheGridEstorno(codvenda);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao pesquisar dados " + ex.Message);
            }





        }


        public bool Estorno(List<ItemVendaDTO> lista)
        {

            return dal.Estornar(lista);

        }





    }
}
