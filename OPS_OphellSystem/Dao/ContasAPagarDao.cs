using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;
using Financeiro.Modelos;
using Modelos;
using System.Data.SQLite;
using System.Configuration;

namespace Dao
{
    public class ContasAPagarDao : IDao<ContasPagarModelo>
    {
        private ContasPagarModelo _conta;
        private List<ContasPagarModelo> _contas = new List<ContasPagarModelo>();
        private string connectionString = ConfigurationManager.ConnectionStrings["OPHBD"].ConnectionString;

        public void Create(ContasPagarModelo modelo)
        {
            if(modelo != null)
            {
                string sqlComando = "INSERT INTO Pagamento(data_lancamento,total,id_fornecedor,id_forma_pagamento,forma_pagamento)" +
                    "VALUES(datetime('now','localtime'),@total,@fornecedorId,@formaPagamentoId,@formaPagamento)";
                _conta = modelo;
                ExecutaComando(sqlComando);
            }            
        }

        public void Delete(ContasPagarModelo modelo)
        {
            throw new NotImplementedException();
        }

        public List<ContasPagarModelo> SelectAll()
        {
            throw new NotImplementedException();
        }

        public void Update(ContasPagarModelo modelo)
        {
            if(modelo != null)
            {
                string sqlCommand = "UPDATE Pagamento SET total=@total,id_forma_pagamento=@formaPagamento,forma_pagamento=@formaPagamento WHERE id=@id";
                _conta = modelo;
                ExecutaComando(sqlCommand);
            }
        }

        public ContasPagarModelo GetContasByFornecedor(FornecedorModelo fornecedor)
        {
            try
            {
                _contas.Clear();
                if (fornecedor != null)
                {
                    ExecutaLeitura("SELECT * FROM Pagamento WHERE id_fornecedor=@idFornecedor", new SQLiteParameter("@idFornecedor", fornecedor.FornecedorId));
                    if (_contas.Count > 0)
                    {
                        return _contas[0];
                    }
                }
                return new ContasPagarModelo();
            }catch(Exception ex)
            {
                throw new System.Exception(ex.Message);
            }
            
        }

        private SQLiteParameter[] Parametros()
        {
            try
            {
                if (_conta != null)
                {
                    return new SQLiteParameter[] {
                new SQLiteParameter(){ParameterName = "@id", Value= _conta.ContaPagarId},
                new SQLiteParameter(){ParameterName = "@duplicata", Value= _conta.Duplicata},
                new SQLiteParameter(){ParameterName = "@formaPagamentoId", Value= _conta.FormaPagamento.FormasPafamentoId},
                new SQLiteParameter(){ParameterName = "@fornecedorId", Value= _conta.Fornecedor.FornecedorId},
                new SQLiteParameter(){ParameterName = "@total", Value= _conta.Total},
                new SQLiteParameter(){ParameterName = "@formaPagamento", Value= _conta.FormaPagamento.Descricao}                
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
                    _contas.Clear();
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
                                _contas.Add(new ContasPagarModelo()
                                {
                                    ContaPagarId = long.TryParse(reader["id"].ToString(), out long id) ? id : 0,
                                    Duplicata = int.Parse(reader["duplicata"].ToString()),
                                    Fornecedor = new FornecedorModelo() { FornecedorId = long.Parse(reader["id_fornecedor"].ToString()) },
                                    FormaPagamento = new FormaPagamentoModelo() { FormasPafamentoId = long.Parse(reader["id_forma_pagamento"].ToString()),
                                        Descricao = reader["forma_pagamento"].ToString() },
                                    Total = double.Parse(reader["total"].ToString()),                                    
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
