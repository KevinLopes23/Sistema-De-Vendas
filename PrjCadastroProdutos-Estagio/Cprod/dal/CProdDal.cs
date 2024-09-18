namespace Cprod.code.dal
{
    using Cprod.code.dto.dto;
    using System;
    using System.Data;
    using System.Data.SQLite;
    using System.Text;

    public class CProdDal
    {
        private const string V = "MANUAL : IMPORTADO";
        private string connSqllite = "DATA SOURCE =C:\\PrjCadastroProdutos-Estagio\\Database\\DBPRODUTOS";

        private StringBuilder sql = null;

        public bool ValidarCredenciais(string usuario, string senha)
        {
            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(connSqllite))
                {
                    conn.Open();

                    sql = new StringBuilder();
                    sql.Append("SELECT COUNT(1) FROM TBLUSUARIOS ");
                    sql.Append("WHERE USUARIO = @usuario AND SENHA = @senha");

                    using (SQLiteCommand cmd = new SQLiteCommand(conn))
                    {

                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = sql.ToString();
                        cmd.Parameters.AddWithValue("@usuario", usuario);
                        cmd.Parameters.AddWithValue("@senha", senha);

                        int count = Convert.ToInt32(cmd.ExecuteScalar());
                        return count > 0;

                    }
                }
            }
            catch (Exception erro)
            {
                throw new Exception(erro.Message);
            }
        }




        public bool VerificaSeExiste(int codproduto)
        {
            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(connSqllite))
                {
                    conn.Open();

                    sql = new StringBuilder();
                    sql.Append("SELECT COUNT(1) FROM TBLPRODUTOS ");
                    sql.Append("WHERE CODPRODUTO = @CODPRODUTO ");

                    using (SQLiteCommand cmd = new SQLiteCommand(conn))
                    {

                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = sql.ToString();
                        cmd.Parameters.AddWithValue("@CODPRODUTO", codproduto);

                        int count = Convert.ToInt32(cmd.ExecuteScalar());
                        return count > 0;

                    }
                }
            }
            catch (Exception erro)
            {
                throw new Exception(erro.Message);
            }
        }



        public bool Atualizar(ProdutosDto dto)
        {
            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(connSqllite))
                {
                    conn.Open();

                    sql = new StringBuilder();
                    sql.Append("UPDATE TBLPRODUTOS SET CODPRODUTO=@CODPRODUTO,DESCRICAO = @DESCRICAO, QTDESTOQUE = @QTDESTOQUE,PRECO = @PRECO,DATAVENCIMENTO = @DATAVENCIMENTO , CODMARCA = @CODMARCA , TIPOREGISTRO = @TIPOREGISTRO ");
                    sql.Append("WHERE CODPRODUTO = @CODPRODUTO");


                    using (SQLiteCommand cmd = new SQLiteCommand(conn))
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = sql.ToString();

                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@CODPRODUTO", dto.CodigoProduto);
                        cmd.Parameters.AddWithValue("@DESCRICAO", dto.Descricao);
                        cmd.Parameters.AddWithValue("@QTDESTOQUE", dto.QuantidadeEstoque);
                        cmd.Parameters.AddWithValue("@PRECO", dto.Preco);
                        cmd.Parameters.AddWithValue("@DATAVENCIMENTO", dto.DataVencimento.ToString("dd/MM/yyyy"));
                        cmd.Parameters.AddWithValue("@CODMARCA", dto.CodigoMarca);
                        cmd.Parameters.AddWithValue("@TIPOREGISTRO", dto.TipoRegistro);

                        cmd.ExecuteNonQuery();

                        return true;
                    }
                }

            }
            catch (Exception erro)
            {

                throw new Exception(erro.Message);
            }
        }


        public bool AtualizarMarca(MarcaDto dto)
        {
            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(connSqllite))
                {
                    conn.Open();

                    sql = new StringBuilder();
                    sql.Append("UPDATE TBLMARCA SET CODMARCA=@CODMARCA,MARCA = @MARCA ");
                    sql.Append("WHERE CODMARCA = @CODMARCA");


                    using (SQLiteCommand cmd = new SQLiteCommand(conn))
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = sql.ToString();

                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@CODMARCA", dto.CodigoMarca);
                        cmd.Parameters.AddWithValue("@MARCA", dto.Descricao);


                        cmd.ExecuteNonQuery();

                        return true;
                    }
                }

            }
            catch (Exception erro)
            {

                throw new Exception(erro.Message);
            }
        }



        public bool ValidaDescricao(string descricao)
        {
            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(connSqllite))
                {
                    conn.Open();

                    sql = new StringBuilder();
                    sql.Append("SELECT COUNT(1) FROM TBLPRODUTOS ");
                    sql.Append("WHERE DESCRICAO = @descricao");

                    using (SQLiteCommand cmd = new SQLiteCommand(conn))
                    {

                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = sql.ToString();
                        cmd.Parameters.AddWithValue("@descricao", descricao);


                        int count = Convert.ToInt32(cmd.ExecuteScalar());
                        return count > 0;

                    }
                }
            }
            catch (Exception erro)
            {
                throw new Exception(erro.Message);
            }

        }



        public bool ValidaDescricaoMarca(string marca)
        {
            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(connSqllite))
                {
                    conn.Open();

                    sql = new StringBuilder();
                    sql.Append("SELECT COUNT(1) FROM TBLMARCA ");
                    sql.Append("WHERE MARCA = @MARCA");

                    using (SQLiteCommand cmd = new SQLiteCommand(conn))
                    {

                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = sql.ToString();
                        cmd.Parameters.AddWithValue("@MARCA", marca);


                        int count = Convert.ToInt32(cmd.ExecuteScalar());
                        return count > 0;

                    }
                }
            }
            catch (Exception erro)
            {
                throw new Exception(erro.Message);
            }

        }





        public DataTable ColocaProdutoComboBox()
        {
            DataTable dt = new DataTable();

            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(connSqllite))
                {
                    conn.Open();
                    sql = new StringBuilder();
                    sql.Append("SELECT CODPRODUTO, DESCRICAO, PRECO FROM TBLPRODUTOS;");
                    using (SQLiteCommand cmd = new SQLiteCommand(conn))
                    {
                        SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = sql.ToString();
                        da.Fill(dt);
                    }
                }

            }
            catch (Exception erro)
            {

                throw new Exception(erro.Message);
            }

            return dt;
        }










        public DataTable ColocaMarcaCombo()
        {
            DataTable dt = new DataTable();

            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(connSqllite))
                {
                    conn.Open();
                    sql = new StringBuilder();
                    sql.Append("SELECT CODMARCA, MARCA FROM TBLMARCA;");
                    using (SQLiteCommand cmd = new SQLiteCommand(conn))
                    {
                        SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = sql.ToString();
                        da.Fill(dt);
                    }
                }

            }
            catch (Exception erro)
            {

                throw new Exception(erro.Message);
            }

            return dt;
        }




        public bool VerificaCodigoJaCadastrado(string codigo)
        {
            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(connSqllite))
                {
                    conn.Open();

                    sql = new StringBuilder();
                    sql.Append("SELECT COUNT(1) FROM TBLPRODUTOS WHERE CODPRODUTO = @CODPRODUTO");

                    using (SQLiteCommand cmd = new SQLiteCommand(conn))
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = sql.ToString();
                        cmd.Parameters.AddWithValue("@CODPRODUTO", codigo);
                        int count = Convert.ToInt32(cmd.ExecuteScalar());
                        return count > 0;
                    }
                }

            }
            catch (Exception erro)
            {
                throw new Exception(erro.Message);
            }


        }




        public int GeraCodigoProduto()
        {


            try
            {
                int novoId = 0;
                using (SQLiteConnection conn = new SQLiteConnection(connSqllite))
                {
                    conn.Open();

                    sql = new StringBuilder();
                    sql.Append("SELECT MAX(CODPRODUTO) + 1 FROM TBLPRODUTOS");

                    using (SQLiteCommand cmd = new SQLiteCommand(conn))
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = sql.ToString();
                        novoId = Convert.ToInt32(cmd.ExecuteScalar());
                    }
                }
                return novoId;

            }
            catch (Exception erro)
            {

                throw new Exception(erro.Message);
            }

        }



        public int GeraCodigoMarca()
        {


            try
            {
                int novoId = 0;
                using (SQLiteConnection conn = new SQLiteConnection(connSqllite))
                {
                    conn.Open();

                    sql = new StringBuilder();
                    sql.Append("SELECT MAX(CODMARCA) + 1 FROM TBLMARCA");

                    using (SQLiteCommand cmd = new SQLiteCommand(conn))
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = sql.ToString();
                        novoId = Convert.ToInt32(cmd.ExecuteScalar());
                    }
                }
                return novoId;

            }
            catch (Exception erro)
            {

                throw new Exception(erro.Message);
            }

        }


        public DataTable PesquisaProdutos(string? filtro, string valor)
        {

            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(connSqllite))
                {
                    conn.Open();
                    sql = new StringBuilder();

                    if (string.IsNullOrEmpty(filtro))
                    {
                        //sql.Append("SELECT CODPRODUTO, DESCRICAO, QTDESTOQUE, PRECO, CAST(DATAVENCIMENTO AS TEXT) AS DATAVENCIMENTO, CODMARCA, TIPOREGISTRO FROM TBLPRODUTOS ");
                        sql.Append("SELECT CODPRODUTO, TBLPRODUTOS.DESCRICAO,  QTDESTOQUE, PRECO, CAST(DATAVENCIMENTO AS TEXT) AS DATAVENCIMENTO, TBLMARCA.MARCA,  ");
                        sql.Append("CASE WHEN TIPOREGISTRO = 'M' THEN 'MANUAL' ");
                        sql.Append("WHEN TIPOREGISTRO = 'I' THEN 'IMPORTADO' ");
                        sql.Append(" END AS TIPOREGISTRO ");
                        sql.Append("FROM TBLPRODUTOS");
                        sql.Append(" INNER JOIN TBLMARCA ON TBLPRODUTOS.CODMARCA = TBLMARCA.CODMARCA ");
                        sql.Append("ORDER BY TBLPRODUTOS.DESCRICAO ASC");
                    }

                    else
                    {


                        //sql.Append("SELECT CODPRODUTO, DESCRICAO, QTDESTOQUE, PRECO, CAST(DATAVENCIMENTO AS TEXT) AS DATAVENCIMENTO, CODMARCA, TIPOREGISTRO ");
                        //sql.Append("FROM TBLPRODUTOS ");
                        //sql.Append($"WHERE {filtro} ");

                        sql.Append("SELECT CODPRODUTO, TBLPRODUTOS.DESCRICAO,  QTDESTOQUE, PRECO, CAST(DATAVENCIMENTO AS TEXT) AS DATAVENCIMENTO, TBLMARCA.MARCA,  ");
                        sql.Append("CASE WHEN TIPOREGISTRO = 'M' THEN 'MANUAL' ");
                        sql.Append("WHEN TIPOREGISTRO = 'I' THEN 'IMPORTADO' ");
                        sql.Append(" END AS TIPOREGISTRO ");
                        sql.Append("FROM TBLPRODUTOS");
                        sql.Append(" INNER JOIN TBLMARCA ON TBLPRODUTOS.CODMARCA = TBLMARCA.CODMARCA ");
                        sql.Append($"WHERE {filtro} ");



                        if (filtro == "CODPRODUTO")
                        {
                            sql.Append("= @valor");
                        }
                        else
                        {
                            sql.Append("LIKE @valor");
                        }
                    }

                    using (SQLiteCommand cmd = new SQLiteCommand(sql.ToString(), conn))
                    {
                        if (filtro == "CODPRODUTO")
                        {
                            cmd.Parameters.AddWithValue("@valor", valor);
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue("@valor", "%" + valor + "%");
                        }


                        SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        return dt;
                    }
                }

            }
            catch (Exception erro)
            {

                throw new Exception(erro.Message);
            }




        }


        public DataTable PesquisaMarca(string marca)
        {

            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(connSqllite))
                {
                    conn.Open();
                    sql = new StringBuilder();

                    sql.Append("SELECT CODMARCA, MARCA FROM TBLMARCA  ");
                    sql.Append("WHERE MARCA  LIKE @MARCA");


                    using (SQLiteCommand cmd = new SQLiteCommand(sql.ToString(), conn))
                    {

                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = sql.ToString();
                        cmd.Parameters.AddWithValue("@MARCA", "%" + marca + "%");


                        SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        return dt;
                    }
                }


            }
            catch (Exception erro)
            {

                throw new Exception(erro.Message);
            }




        }




        //public bool ImportarProdutoBanco(int codproduto, string descricao)
        //{

        //    try
        //    {
        //        using (SQLiteConnection conn = new SQLiteConnection(connSqllite))
        //        {
        //            conn.Open();
        //            sql = new StringBuilder();
        //            sql.Append("INSERT INTO TBLPRODUTOS (CODPRODUTO, DESCRICAO) VALUES (@CODPRODUTO, @DESCRICAO)");

        //            using (SQLiteCommand cmd = new SQLiteCommand(conn))
        //            {
        //                cmd.CommandType = System.Data.CommandType.Text;
        //                cmd.CommandText = sql.ToString();

        //                cmd.Parameters.Clear();
        //                cmd.Parameters.AddWithValue("@CODPRODUTO", codproduto);
        //                cmd.Parameters.AddWithValue("@DESCRICAO", descricao);

        //                cmd.ExecuteNonQuery();
        //            }
        //            return true;
        //        }
        //    }
        //    catch (Exception erro)
        //    {

        //        throw new Exception(erro.Message);
        //    }












        //}




        public bool ImportarProdutoBanco(List<ProdutosDto> lista)
        {
            Boolean transacao = false;

            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(connSqllite))
                {
                    conn.Open();
                    using (var transaction = conn.BeginTransaction())
                    {
                        transacao = true;

                        try
                        {
                            StringBuilder sql = new StringBuilder();
                            sql.Append("INSERT INTO TBLPRODUTOS (CODPRODUTO, DESCRICAO) VALUES (@CODPRODUTO, @DESCRICAO)");

                            using (SQLiteCommand cmd = new SQLiteCommand(conn))
                            {
                                cmd.Transaction = transaction;
                                cmd.CommandType = System.Data.CommandType.Text;
                                cmd.CommandText = sql.ToString();


                                foreach (var produto in lista)
                                {
                                    cmd.Parameters.Clear();
                                    cmd.Parameters.AddWithValue("@CODPRODUTO", produto.CodigoProduto);
                                    cmd.Parameters.AddWithValue("@DESCRICAO", produto.Descricao);

                                    cmd.ExecuteNonQuery();
                                }
                            }



                            transaction.Commit();
                            transacao = false;
                            return true;
                        }
                        catch (Exception erro)
                        {
                            throw new Exception(erro.Message);
                        }
                        finally
                        {
                            if (transacao == true)
                            {
                                transacao = false;
                                transaction.Rollback();
                            }
                        }
                    }
                }
            }
            catch (Exception erro)
            {
                throw new Exception(erro.Message);
            }
        }





        public bool Gravar(ProdutosDto dto)
        {

            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(connSqllite))
                {
                    conn.Open();

                    sql = new();

                    sql.Append("INSERT INTO TBLPRODUTOS (CODPRODUTO,DESCRICAO,QTDESTOQUE,PRECO, DATAVENCIMENTO ,CODMARCA,TIPOREGISTRO) ");
                    sql.Append(" VALUES ");
                    sql.Append("(@CODPRODUTO,@DESCRICAO,@QTDESTOQUE,@PRECO,@DATAVENCIMENTO,@CODMARCA,@TIPOREGISTRO)");

                    using (SQLiteCommand cmd = new SQLiteCommand(conn))
                    {
                        cmd.CommandType = System.Data.CommandType.Text;
                        cmd.CommandText = sql.ToString();

                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@CODPRODUTO", dto.CodigoProduto);
                        cmd.Parameters.AddWithValue("@DESCRICAO", dto.Descricao);
                        cmd.Parameters.AddWithValue("@QTDESTOQUE", dto.QuantidadeEstoque);
                        cmd.Parameters.AddWithValue("@PRECO", dto.Preco);
                        cmd.Parameters.AddWithValue("@DATAVENCIMENTO", dto.DataVencimento.ToString("dd/MM/yyyy"));
                        cmd.Parameters.AddWithValue("@CODMARCA", dto.CodigoMarca);
                        cmd.Parameters.AddWithValue("@TIPOREGISTRO", dto.TipoRegistro);
                        cmd.ExecuteNonQuery();

                        return true;
                    }
                }
            }
            catch (Exception erro)
            {

                throw new Exception(erro.Message);
            }


        }



        public bool GravarMarca(MarcaDto dto)
        {

            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(connSqllite))
                {
                    conn.Open();

                    sql = new();

                    sql.Append("INSERT INTO TBLMARCA (CODMARCA,MARCA) ");
                    sql.Append(" VALUES ");
                    sql.Append("(@CODMARCA,@MARCA)");

                    using (SQLiteCommand cmd = new SQLiteCommand(conn))
                    {
                        cmd.CommandType = System.Data.CommandType.Text;
                        cmd.CommandText = sql.ToString();

                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@CODMARCA", dto.CodigoMarca);
                        cmd.Parameters.AddWithValue("@MARCA", dto.Descricao);

                        cmd.ExecuteNonQuery();

                        return true;
                    }
                }
            }
            catch (Exception erro)
            {

                throw new Exception(erro.Message);
            }


        }


        public ProdutosDto DadosCliente(Int32 codigoproduto)
        {
            ProdutosDto dto = new();

            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(connSqllite))
                {
                    conn.Open();
                    StringBuilder sql = new StringBuilder();
                    sql.Append("SELECT CODPRODUTO, DESCRICAO , QTDESTOQUE , PRECO , CAST(DATAVENCIMENTO AS TEXT ) AS DATA , CODMARCA, TIPOREGISTRO ");
                    sql.Append("FROM TBLPRODUTOS ");
                    sql.Append("WHERE CODPRODUTO = @CODPRODUTO");

                    using (SQLiteCommand cmd = new SQLiteCommand(conn))
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = sql.ToString();
                        cmd.Parameters.AddWithValue("@CODPRODUTO", codigoproduto);

                        SQLiteDataReader dr = cmd.ExecuteReader();

                        if (dr.Read())
                        {
                            dto = new();
                            dto.CodigoProduto = Convert.ToInt32(dr["CODPRODUTO"].ToString());
                            dto.Descricao = dr["DESCRICAO"].ToString();
                            dto.QuantidadeEstoque = Convert.ToInt32(dr["QTDESTOQUE"].ToString());
                            dto.Preco = Convert.ToDouble(dr["PRECO"].ToString());
                            dto.DataVencimento = Convert.ToDateTime(dr["DATA"].ToString());
                            dto.CodigoMarca = Convert.ToInt32(dr["CODMARCA"].ToString());
                            dto.TipoRegistro = dr["TIPOREGISTRO"].ToString();

                        }
                        dr.Close();
                    }

                }

                return dto;

            }
            catch (Exception erro)
            {
                throw new Exception(erro.Message);
            }
        }


        public List<ProdutosDto> ExportarDados()
        {
            try
            {
                List<ProdutosDto> produtos = new List<ProdutosDto>();

                using (SQLiteConnection conn = new SQLiteConnection(connSqllite))
                {
                    conn.Open();
                    StringBuilder sql = new StringBuilder();
                    sql.Append("SELECT CODPRODUTO, DESCRICAO, QTDESTOQUE,  PRECO, CAST(DATAVENCIMENTO AS TEXT ) AS DATA , CODMARCA , TIPOREGISTRO ");
                    sql.Append("FROM TBLPRODUTOS");

                    using (SQLiteCommand cmd = new SQLiteCommand(sql.ToString(), conn))
                    {
                        using (SQLiteDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                ProdutosDto produto = new ProdutosDto
                                {
                                    // Verificação de DBNull para evitar erro de conversão
                                    CodigoProduto = reader["CODPRODUTO"] != DBNull.Value ? Convert.ToInt32(reader["CODPRODUTO"]) : 0,
                                    Descricao = reader["DESCRICAO"] != DBNull.Value ? reader["DESCRICAO"].ToString() : "",
                                    QuantidadeEstoque = reader["QTDESTOQUE"] != DBNull.Value ? Convert.ToInt32(reader["QTDESTOQUE"]) : 0,
                                    Preco = reader["PRECO"] != DBNull.Value ? Convert.ToDouble(reader["PRECO"]) : 0.0,
                                    DataVencimento = reader["DATA"] != DBNull.Value ? Convert.ToDateTime(reader["DATA"]) : DateTime.MinValue,
                                    CodigoMarca = reader["CODMARCA"] != DBNull.Value ? Convert.ToInt32(reader["CODMARCA"]) : 0,
                                    TipoRegistro = reader["TIPOREGISTRO"] != DBNull.Value ? (reader["TIPOREGISTRO"].ToString() == "M" ? "MANUAL" : "IMPORTADO") : ""
                                };



                                produtos.Add(produto);
                            }
                        }
                    }
                }

                return produtos;

            }
            catch (Exception erro)
            {

                throw new Exception(erro.Message);
            }






        }






















        public MarcaDto DadosMarca(Int32 codigomarca)
        {
            MarcaDto dto = new();

            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(connSqllite))
                {
                    conn.Open();
                    StringBuilder sql = new StringBuilder();
                    sql.Append("SELECT CODMARCA, MARCA  ");
                    sql.Append("FROM TBLMARCA ");
                    sql.Append("WHERE CODMARCA = @CODMARCA");

                    using (SQLiteCommand cmd = new SQLiteCommand(conn))
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = sql.ToString();
                        cmd.Parameters.AddWithValue("@CODMARCA", codigomarca);

                        SQLiteDataReader dr = cmd.ExecuteReader();

                        if (dr.Read())
                        {
                            dto = new();
                            dto.CodigoMarca = Convert.ToInt32(dr["CODMARCA"].ToString());
                            dto.Descricao = dr["MARCA"].ToString();

                        }
                        dr.Close();
                    }

                }

                return dto;

            }
            catch (Exception erro)
            {
                throw new Exception(erro.Message);
            }
        }



        public bool ExcluirClientePorCodigoDoProduto(int codigoDoProduto)
        {
            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(connSqllite))
                {
                    conn.Open();
                    StringBuilder sql = new StringBuilder();
                    sql.Append("DELETE FROM TBLPRODUTOS WHERE CODPRODUTO = @CODPRODUTO");

                    using (SQLiteCommand cmd = new SQLiteCommand(conn))
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = sql.ToString();
                        cmd.Parameters.AddWithValue("@CODPRODUTO", codigoDoProduto);

                        int linhasafetadas = cmd.ExecuteNonQuery();

                        // Verifica se alguma linha foi excluída
                        return linhasafetadas > 0;
                    }
                }
            }
            catch (Exception erro)
            {
                throw new Exception(erro.Message);
            }
        }

        public bool ExcluirMarca(int codigomarca)
        {
            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(connSqllite))
                {
                    conn.Open();
                    StringBuilder sql = new StringBuilder();
                    sql.Append("DELETE FROM TBLMARCA WHERE CODMARCA = @CODMARCA");

                    using (SQLiteCommand cmd = new SQLiteCommand(conn))
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = sql.ToString();
                        cmd.Parameters.AddWithValue("@CODMARCA", codigomarca);

                        int linhasafetadas = cmd.ExecuteNonQuery();

                        // Verifica se alguma linha foi excluída
                        return linhasafetadas > 0;
                    }
                }
            }
            catch (Exception erro)
            {
                throw new Exception(erro.Message);
            }
        }




        public int InserirVenda(VendaDTO dto, SQLiteTransaction transaction)
        {



            int idGerado = 0;

            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append("INSERT INTO TBLVENDA (CODVENDA, DATA) ");
                sql.Append("VALUES ((SELECT IFNULL(MAX(CODVENDA), 0) + 1 FROM TBLVENDA), @DATA);");
                sql.Append("SELECT last_insert_rowid();");

                using (SQLiteCommand cmd = new SQLiteCommand(sql.ToString(), transaction.Connection))
                {
                    cmd.Transaction = transaction;
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@DATA", DateTime.Now.ToString("dd/MM/yyyy"));


                    idGerado = Convert.ToInt32(cmd.ExecuteScalar());
                }

                return idGerado;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao inserir venda: {ex.Message}");
                throw;
            }

        }




        public Boolean InserirItens(List<ItemVendaDTO> lista, SQLiteTransaction transaction)
        {

            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append("INSERT INTO TBLITENS (CODVENDA, CODPRODUTO, QTDADE, VALOR) VALUES (@CODVENDA , @CODPRODUTO, @QTDADE,  @VALOR)");

                using (SQLiteCommand cmd = new SQLiteCommand(sql.ToString(), transaction.Connection))
                {

                    cmd.Transaction = transaction;



                    foreach (var itens in lista)
                    {
                        cmd.Parameters.AddWithValue("@CODVENDA", itens.CodVenda);
                        cmd.Parameters.AddWithValue("@CODPRODUTO", itens.CodProduto);
                        cmd.Parameters.AddWithValue("@QTDADE", itens.Quantidade);
                        cmd.Parameters.AddWithValue("@VALOR", itens.Valor);

                        cmd.ExecuteNonQuery();

                    }




                }


                return true;
            }
            catch (Exception)
            {
                return false;
            }


        }

        public Boolean AtualizaEstoque(List<ItemVendaDTO> lista, SQLiteTransaction transaction)
        {

            try
            {
                StringBuilder sql = new StringBuilder();

                //sql.Append("SELECT QTDESTOQUE FROM TBLPRODUTOS WHERE CODPRODUTO = @CODPRODUTO");
                sql.Append("UPDATE TBLPRODUTOS SET QTDESTOQUE = QTDESTOQUE - @QUANTIDADE WHERE CODPRODUTO = @CODPRODUTO");

                using (SQLiteCommand cmd = new SQLiteCommand(sql.ToString(), transaction.Connection))
                {

                    cmd.Transaction = transaction;

                    foreach (var itens in lista)
                    {
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@QUANTIDADE", itens.Quantidade);
                        cmd.Parameters.AddWithValue("@CODPRODUTO", itens.CodProduto);
                        cmd.ExecuteNonQuery();
                    }
                }



                return true;
            }
            catch (Exception)
            {
                return false;
            }



        }







        public bool VerificaEstoqueDisponivel(int codigoProduto, int quantidadeRequerida)
        {
            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(connSqllite))
                {
                    conn.Open();


                    StringBuilder sql = new StringBuilder();
                    sql.Append("SELECT QTDESTOQUE FROM TBLPRODUTOS WHERE CODPRODUTO = @CODPRODUTO");

                    using (SQLiteCommand cmd = new SQLiteCommand(sql.ToString(), conn))
                    {

                        cmd.Parameters.AddWithValue("@CODPRODUTO", codigoProduto);


                        object resultado = cmd.ExecuteScalar();


                        if (resultado != null)
                        {
                            int quantidadeDisponivel = Convert.ToInt32(resultado);



                            if (quantidadeDisponivel >= quantidadeRequerida)
                            {
                                return true;
                            }
                        }
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao verificar estoque: {ex.Message}");
                return false;
            }
        }



        public bool GravarVendaComItens(VendaDTO venda, List<ItemVendaDTO> itens)
        {
            bool transacao = false;

            using (SQLiteConnection conn = new SQLiteConnection(connSqllite))
            {
                conn.Open();

                using (SQLiteTransaction transaction = conn.BeginTransaction())
                {
                    transacao = true;
                    try
                    {

                        int idVenda = InserirVenda(venda, transaction);

                        if (idVenda == 0)
                            throw new Exception("Falha ao inserir a venda.");


                        foreach (var item in itens)
                        {
                            item.CodVenda = idVenda;
                        }


                        bool sucessoItens = InserirItens(itens, transaction);

                        if (!sucessoItens)
                            throw new Exception("Falha ao inserir os itens.");

                        bool sucessoAtualizaEstoque = AtualizaEstoque(itens, transaction);

                        if (!sucessoAtualizaEstoque)
                        {
                            throw new Exception("Falha ao atualizar estoque");

                        }



                        if (transacao)
                        {
                            transaction.Commit();
                            transacao = false;
                            return true;
                        }
                    }
                    catch (Exception ex)
                    {

                        transaction.Rollback();
                        Console.WriteLine($"Erro: {ex.Message}");
                        return false;
                    }


                    finally
                    {
                        if (transacao == true)
                        {
                            transacao = false;
                            transaction.Rollback();


                        }

                    }
                    return true;

                }
            }
        }




        public int ColocaQuantidadeLabel(int codigoProduto)
        {
            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(connSqllite))
                {
                    conn.Open();

                    StringBuilder sql = new StringBuilder();
                    sql.Append("SELECT QTDESTOQUE FROM TBLPRODUTOS WHERE CODPRODUTO = @CODPRODUTO");

                    using (SQLiteCommand cmd = new SQLiteCommand(sql.ToString(), conn))
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.Parameters.AddWithValue("@CODPRODUTO", codigoProduto);


                        object result = cmd.ExecuteScalar();

                        return result != null ? Convert.ToInt32(result) : 0;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao buscar a quantidade de estoque: {ex.Message}");
                return 0; // Retorna 0 em caso de erro
            }
        }




        public DataTable PreencheGridEstorno(string condvenda)
        {

            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(connSqllite))
                {
                    conn.Open();
                    sql = new StringBuilder();

                    sql.Append("SELECT ITENS.CODPRODUTO, PRODUTOS.DESCRICAO, ITENS.QTDADE, ITENS.VALOR  ");
                    sql.Append("FROM TBLITENS ITENS ");
                    sql.Append(" INNER JOIN TBLPRODUTOS PRODUTOS ON ITENS.CODPRODUTO = PRODUTOS.CODPRODUTO ");
                    sql.Append(" WHERE CODVENDA = @CODVENDA");


                    using (SQLiteCommand cmd = new SQLiteCommand(sql.ToString(), conn))
                    {

                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = sql.ToString();
                        cmd.Parameters.AddWithValue("@CODVENDA", condvenda);


                        SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        return dt;
                    }
                }


            }
            catch (Exception erro)
            {

                throw new Exception(erro.Message);
            }




        }





        //public bool Estornar(List<ItemVendaDTO> lista, ItemVendaDTO dto)
        //{
        //    Boolean transacao = false;

        //    try
        //    {
        //        using (SQLiteConnection conn = new SQLiteConnection(connSqllite))
        //        {
        //            conn.Open();
        //            using (var transaction = conn.BeginTransaction())
        //            {
        //                transacao = true;

        //                try
        //                {
        //                    StringBuilder sql = new StringBuilder();

        //                    foreach (var item in lista)

        //                    {

        //                        sql.Append("UPDATE TBLPRODUTOS SET QTDESTOQUE = QTDESTOQUE + @QTDVENDA WHERE CODPRODUTO = @CODPRODUTO");

        //                        using (SQLiteCommand cmd = new SQLiteCommand(conn))
        //                        {
        //                            cmd.Transaction = transaction;
        //                            cmd.CommandType = System.Data.CommandType.Text;
        //                            cmd.CommandText = sql.ToString();

        //                            cmd.Parameters.Clear();
        //                            cmd.Parameters.AddWithValue("@QTDVENDA", dto.Quantidade.ToString());
        //                            cmd.Parameters.AddWithValue("@CODPRODUTO", dto.CodProduto.ToString());

        //                            cmd.ExecuteNonQuery();
        //                            sql.Clear();
        //                        }
        //                    }



        //                    sql.Clear();


        //                    sql.Append("DELETE FROM TBLITENS WHERE CODVENDA= @CODVENDA");

        //                    using (SQLiteCommand cmd = new SQLiteCommand(conn))
        //                    {
        //                        cmd.Transaction = transaction;
        //                        cmd.CommandType = System.Data.CommandType.Text;
        //                        cmd.CommandText = sql.ToString();

        //                        cmd.Parameters.Clear();
        //                        cmd.Parameters.AddWithValue("@CODVENDA", dto.CodVenda);

        //                        cmd.ExecuteNonQuery();

        //                    }

        //                    sql.Clear();


        //                    sql.Append("DELETE FROM TBLVENDA WHERE CODVENDA= @CODVENDA");

        //                    using (SQLiteCommand cmd = new SQLiteCommand(conn))
        //                    {
        //                        cmd.Transaction = transaction;
        //                        cmd.CommandType = System.Data.CommandType.Text;
        //                        cmd.CommandText = sql.ToString();

        //                        cmd.Parameters.Clear();
        //                        cmd.Parameters.AddWithValue("@CODVENDA", dto.CodVenda);

        //                        cmd.ExecuteNonQuery();

        //                    }



        //                    transaction.Commit();
        //                    transacao = false;
        //                    return true;
        //                }
        //                catch (Exception erro)
        //                {
        //                    throw new Exception(erro.Message);
        //                }
        //                finally
        //                {
        //                    if (transacao == true)
        //                    {
        //                        transacao = false;
        //                        transaction.Rollback();
        //                    }
        //                }
        //            }
        //        }
        //    }
        //    catch (Exception erro)
        //    {
        //        throw new Exception(erro.Message);
        //    }

        //}


        public bool Estornar(List<ItemVendaDTO> lista)
        {
            Boolean transacao = false;
            int rowsAff = 0;

            try
            {

                using (SQLiteConnection conn = new SQLiteConnection(connSqllite))
                {
                    conn.Open();

                    using (var transaction = conn.BeginTransaction())
                    {
                        transacao = true;
                        try
                        {
                            using (SQLiteCommand cmd = new SQLiteCommand(conn))
                            {
                                cmd.Transaction = transaction;
                                cmd.CommandType = System.Data.CommandType.Text;

                                foreach (var item in lista)
                                {

                                    StringBuilder sqlUpdate = new StringBuilder();
                                    sqlUpdate.Append("UPDATE TBLPRODUTOS SET QTDESTOQUE = QTDESTOQUE + @QTDVENDA WHERE CODPRODUTO = @CODPRODUTO");

                                    cmd.CommandText = sqlUpdate.ToString();
                                    cmd.Parameters.Clear();
                                    cmd.Parameters.AddWithValue("@QTDVENDA", item.Quantidade);
                                    cmd.Parameters.AddWithValue("@CODPRODUTO", item.CodProduto);

                                    rowsAff = cmd.ExecuteNonQuery();

                                    if (rowsAff <= 0)
                                    {
                                        transaction.Rollback();
                                        return false;
                                    }

                                }

                                StringBuilder sqlDeleteItens = new StringBuilder();
                                sqlDeleteItens.Append("DELETE FROM TBLITENS WHERE CODVENDA = @CODVENDA");

                                cmd.CommandText = sqlDeleteItens.ToString();
                                cmd.Parameters.Clear();
                                cmd.Parameters.AddWithValue("@CODVENDA", lista[0].CodVenda);

                                rowsAff = cmd.ExecuteNonQuery();

                                if (rowsAff <= 0)
                                {
                                    transaction.Rollback();
                                    return false;
                                }

                                StringBuilder sqlDeleteVenda = new StringBuilder();
                                sqlDeleteVenda.Append("DELETE FROM TBLVENDA WHERE CODVENDA = @CODVENDA");

                                cmd.CommandText = sqlDeleteVenda.ToString();
                                cmd.Parameters.Clear();
                                cmd.Parameters.AddWithValue("@CODVENDA", lista[0].CodVenda);

                                rowsAff = cmd.ExecuteNonQuery();

                                if (rowsAff <= 0)
                                {
                                    transaction.Rollback();
                                    return false;

                                }


                            }

                            transaction.Commit();
                            transacao = false;
                            return true;
                        }
                        catch (Exception erro)
                        {
                            transaction.Rollback();
                            throw new Exception("Erro ao estornar produtos: " + erro.Message);
                        }
                        finally
                        {
                            if (transacao == true)
                            {
                                transacao = false;
                                transaction.Rollback();
                            }
                        }
                    }
                }
            }
            catch (Exception erro)
            {
                throw new Exception("Erro ao conectar ao banco: " + erro.Message);
            }
        }



    }
}














