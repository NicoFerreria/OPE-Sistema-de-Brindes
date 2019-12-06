using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SQLite;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;
using Modelos;
using Cadastros.Controles;


namespace Dao
{
    public class OrcamentoDao : IDao<OrcamentoModelo>
    {
        private OrcamentoModelo _orcamento;
        private List<OrcamentoModelo> _orcamentos = new List<OrcamentoModelo>();
        private string connectionString = ConfigurationManager.ConnectionStrings["OPHBD"].ConnectionString;
        private FornecedorDao fornecedorDao = new FornecedorDao();
        private ClienteDao clienteDao = new ClienteDao();
        private OperadorControle operadorControle = new OperadorControle();
        private ProdutoControle produtoControle = new ProdutoControle();

        public OrcamentoDao()
        {

        }
        public void Create(OrcamentoModelo modelo)
        {
            if(modelo != null)
            {
                try
                {
                    _orcamento = modelo;
                    ExecutaComando("INSERT INTO Orcamento(qtd_compra,und_compra_valor,valor_total_compra,und_gravacao_valor,valor_total_gravacao,valor_total_transporte,porcentagem_imposto,porcentagem_bv," +
                        "und_venda_valor,valor_total_venda,valor_imposto,porcentagem_lucro,valor_total_lucro,operador_codigo,operador_nome,datahora_lancamento,status,Observacao,fornecedor_id," +
                        "cliente_id,produto_id,fornGravacao_id,fornTransporte_id)VALUES(@qtdCompra,@valorUndCompra,@totalCompra,@gravacaoValor,@gravacaoTotal,@totalTransporte.@porcentagemImposto," +
                        "@porcentagemBV,@valorUndVenda,@totalVenda,@totalImposto,@porcentagemLucro,@totalLucro,@operadorId,@operadorNome,@dataLancamento,@status,@observacao,@fornecedorId,@clienteId," +
                        "@produtoId,@GravacaoId,@transporteId)");
                }catch(Exception ex)
                {
                    throw new System.Exception(ex.Message);
                }
                
            }            
        }

        public void Delete(OrcamentoModelo modelo)
        {
            _orcamento = modelo;
            ExecutaComando("UPDATE Orcamento SET excluido=@excluido WHERE id=@id");            
        }

        public List<OrcamentoModelo> SelectAll()
        {
            _orcamentos.Clear();
            ExecutaLeitura("SELECT * FROM Orcamento WHERE excluido=0");
            return _orcamentos;            
        }

        public void Update(OrcamentoModelo modelo)
        {
            throw new NotImplementedException();
        }

        public OrcamentoModelo GetorcamentoById(long id)
        {
            _orcamentos.Clear();
            ExecutaLeitura("SELECT * FROM Orcamento WHERE id=@id AND excluido=0", new SQLiteParameter("@id", id));
            if(_orcamentos.Count > 0)
            {
                return _orcamentos[0];
            }
            return new OrcamentoModelo();
        }

        private SQLiteParameter[] Parametros()
        {
            try
            {
                if (_orcamento != null)
                {
                    return new SQLiteParameter[] {
                new SQLiteParameter(){ParameterName = "@id", Value= _orcamento.OrcamentoID},
                new SQLiteParameter(){ParameterName = "@dataLancamento", Value= _orcamento.DataEmissao.ToString("yyy-MM-dd 00:00:00",CultureInfo.InvariantCulture)},
                new SQLiteParameter(){ParameterName = "@operadorId", Value= _orcamento.Operador.OperadroId},
                new SQLiteParameter(){ParameterName = "@operadorNome", Value= _orcamento.Operador.Nome},
                new SQLiteParameter(){ParameterName = "@qtdCompra", Value= _orcamento.Qtd},
                new SQLiteParameter(){ParameterName = "@valorUndCompra", Value= _orcamento.ValorUndCompra},
                new SQLiteParameter(){ParameterName = "@totalCompra", Value= _orcamento.TotalCompra},
                new SQLiteParameter(){ParameterName = "@gravacaoValor", Value= _orcamento.ValorGravacao},
                new SQLiteParameter(){ParameterName = "@gravacaoTotal", Value= _orcamento.TotalGravacao},
                new SQLiteParameter(){ParameterName = "@totalTransporte", Value= _orcamento.TotalTransporte},
                new SQLiteParameter(){ParameterName = "@porcentagemImposto", Value= _orcamento.PorcentagemImposto},
                new SQLiteParameter(){ParameterName = "@porcentagemBV", Value= _orcamento.PorcentagemBV},
                new SQLiteParameter(){ParameterName = "@valorUndVenda", Value= _orcamento.ValorUnd},
                new SQLiteParameter(){ParameterName = "@id", Value= _orcamento.OrcamentoID},
                new SQLiteParameter(){ParameterName = "@totalVenda", Value= _orcamento.TotalVenda},
                new SQLiteParameter(){ParameterName = "@totalImposto", Value= _orcamento.TotalImposto},
                new SQLiteParameter(){ParameterName = "@porcentagemLucro", Value= _orcamento.PorcentagemLucro},
                new SQLiteParameter(){ParameterName = "@id", Value= _orcamento.OrcamentoID},
                new SQLiteParameter(){ParameterName = "@totalLucro", Value= _orcamento.TotalLucro},
                new SQLiteParameter(){ParameterName = "@id", Value= _orcamento.OrcamentoID},
                new SQLiteParameter(){ParameterName = "@status", Value= _orcamento.Status},
                new SQLiteParameter(){ParameterName = "@observacao", Value= _orcamento.Observacao},
                new SQLiteParameter(){ParameterName = "@excluido", Value= _orcamento.Excluido},
                new SQLiteParameter(){ParameterName = "@fornecedorId", Value= _orcamento.FornecedorId},
                new SQLiteParameter(){ParameterName = "@transporteId", Value= _orcamento.FornecedorTransporteId},
                new SQLiteParameter(){ParameterName = "@GravacaoId", Value= _orcamento.FornecedorGravacaoId},
                new SQLiteParameter(){ParameterName = "@produtoId", Value= _orcamento.Produto.ProdutoID},
                new SQLiteParameter(){ParameterName = "@clienteId", Value= _orcamento.Cliente.ClienteId}
                };
                }

                return new SQLiteParameter[] { };
            }
            catch (SQLiteException ex)
            {

                throw new SQLiteException(ex.Message);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        private void ExecutaComando(string sqlQuery)
        {
            try
            {
                using (var connection = new SQLiteConnection(connectionString))
                {
                    var command = new SQLiteCommand(sqlQuery, connection);
                    command.Parameters.AddRange(Parametros());
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
            catch (SQLiteException ex)
            {

                throw new SQLiteException(ex.Message);
            }

        }
        private void ExecutaLeitura(string sqlQuery, SQLiteParameter parametro = null)
        {

            try
            {
                using (var connection = new SQLiteConnection(connectionString))
                {
                    _orcamentos.Clear();
                    var command = new SQLiteCommand(sqlQuery, connection);
                    if (Parametros().Length > 0)
                    {
                        command.Parameters.AddRange(Parametros());
                    }

                    if (parametro != null)
                    {
                        command.Parameters.Add(parametro);
                    }
                    connection.Open();
                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.StepCount > 0)
                        {
                            while (reader.Read())
                            {
                                _orcamentos.Add(new OrcamentoModelo()
                                {
                                    OrcamentoID = long.TryParse(reader["id"].ToString(), out long id) ? id : 0,
                                    DataEmissao = DateTime.ParseExact(reader["datahora_lancamento"].ToString(), "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture),
                                    Cliente = clienteDao.SelectClietePorId(long.Parse(reader["cliente_id"].ToString())),
                                    Excluido = int.Parse(reader["excluido"].ToString()),
                                    FornecedorGravacaoId = long.Parse(reader["fornGravacao_id"].ToString()),
                                    FornecedorId = long.Parse(reader["fornecedor_id"].ToString()),
                                    FornecedorTransporteId = long.Parse(reader["fornTransporte_id"].ToString()),
                                    Observacao = reader["Observacao"].ToString(),
                                    PorcentagemBV = double.Parse(reader["porcentagem_bv"].ToString()),
                                    PorcentagemImposto = double.Parse(reader["porcentagem_imposto"].ToString()),
                                    PorcentagemLucro = double.Parse(reader["porcentagem_lucro"].ToString()),
                                    Qtd = double.Parse(reader["qtd_compra"].ToString()),
                                    Status = reader["status"].ToString(),
                                    TotalCompra = decimal.Parse(reader["valor_total_compra"].ToString()),
                                    TotalGravacao = decimal.Parse(reader["valor_total_gravacao"].ToString()),
                                    TotalImposto = decimal.Parse(reader["valor_imposto"].ToString()),
                                    TotalLucro = decimal.Parse(reader["valor_total_lucro"].ToString()),
                                    TotalTransporte = decimal.Parse(reader["valor_total_transporte"].ToString()),
                                    TotalVenda = decimal.Parse(reader["valor_total_venda"].ToString()),
                                    ValorGravacao = decimal.Parse(reader["und_gravacao_valor"].ToString()),
                                    ValorUnd = decimal.Parse(reader["und_venda_valor"].ToString()),
                                    ValorUndCompra = decimal.Parse(reader["und_compra_valor"].ToString()),
                                    Operador = operadorControle.ObterOperador(long.Parse(reader["operador_codigo"].ToString())),
                                    Produto = produtoControle.GetProdutoById(long.Parse(reader["produto_id"].ToString())),                                    
                                });
                            }
                        }
                    }
                }
            }
            catch (SQLiteException ex)
            {
                throw new SQLiteException(ex.Message);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
