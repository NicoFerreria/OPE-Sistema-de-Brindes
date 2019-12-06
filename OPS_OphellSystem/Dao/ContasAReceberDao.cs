using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;
using Modelos;
using Financeiro.Modelos;
using System.Data.SQLite;
using System.Configuration;

namespace Dao
{
    public class ContasAReceberDao : IDao<ContasReceberModelo>
    {
        private ContasReceberModelo _conta;
        private List<ContasReceberModelo> _contas = new List<ContasReceberModelo>();
        private string connectionString = ConfigurationManager.ConnectionStrings["OPHBD"].ConnectionString;

        public void Create(ContasReceberModelo modelo)
        {
            if (modelo != null)
            {
                string sqlComando = "INSERT INTO Pagamento(data_lancamento,total,id_cliente,id_forma_pagamento,forma_pagamento)" +
                    "VALUES(datetime('now','localtime'),@total,@clienteId,@formaPagamentoId,@formaPagamento)";
                _conta = modelo;
                ExecutaComando(sqlComando);
            }
        }

        public void Delete(ContasReceberModelo modelo)
        {
            throw new NotImplementedException();
        }

        public List<ContasReceberModelo> SelectAll()
        {
            throw new NotImplementedException();
        }

        public void Update(ContasReceberModelo modelo)
        {
            if (modelo != null)
            {
                string sqlCommand = "UPDATE Pagamento SET total=@total,id_forma_pagamento=@formaPagamento,forma_pagamento=@formaPagamento WHERE id=@id";
                _conta = modelo;
                ExecutaComando(sqlCommand);
            }
        }

        public ContasReceberModelo GetContasByFornecedor(ClienteModelo cliente)
        {
            try
            {
                _contas.Clear();
                if (cliente != null)
                {
                    ExecutaLeitura("SELECT * FROM Pagamento WHERE id_cliente=@idCliente", new SQLiteParameter("@idCliente", cliente.ClienteId));
                    if (_contas.Count > 0)
                    {
                        return _contas[0];
                    }
                }
                return new ContasReceberModelo();
            }
            catch (Exception ex)
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
                new SQLiteParameter(){ParameterName = "@id", Value= _conta.ContasAReceberID},
                new SQLiteParameter(){ParameterName = "@duplicata", Value= _conta.Duplicata},
                new SQLiteParameter(){ParameterName = "@formaPagamentoId", Value= _conta.FormaPagamento.FormasPafamentoId},
                new SQLiteParameter(){ParameterName = "@clienteId", Value= _conta.Cliente.ClienteId},
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
                                _contas.Add(new ContasReceberModelo()
                                {
                                    ContasAReceberID = long.TryParse(reader["id"].ToString(), out long id) ? id : 0,
                                    Duplicata = int.Parse(reader["duplicata"].ToString()),
                                    Cliente = new ClienteModelo() { ClienteId = long.Parse(reader["id_cliente"].ToString()) },
                                    FormaPagamento = new FormaPagamentoModelo()
                                    {
                                        FormasPafamentoId = long.Parse(reader["id_forma_pagamento"].ToString()),
                                        Descricao = reader["forma_pagamento"].ToString()
                                    },
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
