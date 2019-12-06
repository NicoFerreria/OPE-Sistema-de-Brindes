using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;
using Financeiro.Modelos;
using Modelos;
using System.Configuration;
using System.Data.SQLite;
using System.Globalization;

namespace Dao
{
    public class ContaDao : IDao<ContaModelo>
    {

        private ContaModelo _conta;
        private List<ContaModelo> _contas = new List<ContaModelo>();
        private string connectionString = ConfigurationManager.ConnectionStrings["OPHBD"].ConnectionString;

        public void Create(ContaModelo modelo)
        {
            if(modelo != null)
            {
                if(modelo.ContaId == 0)
                {
                    _conta = modelo;
                    string sqlComand = "INSERT INTO PagamentoConta(data_lancamento,data_vencimento,valor,id_pagamento)VALUES(@dataLancamento,@dataVencimento,@valor,@pagamentoId)";
                    ExecutaComando(sqlComand);
                }                
            }
        }

        public void Delete(ContaModelo modelo)
        {
            if(modelo != null)
            {
                string sqlCommand = "DELETE FROM PagamentoConta WHERE id=@id";
                _conta = modelo;
                ExecutaComando(sqlCommand);
            }
        }

        public List<ContaModelo> SelectAll()
        {
            throw new NotImplementedException();
        }

        public void Update(ContaModelo modelo)
        {
            throw new NotImplementedException();
        }

        public List<ContaModelo> GetContasByPagamento(ContasPagarModelo pagamento)
        {
            try
            {
                _contas.Clear();
                if (pagamento != null)
                {
                    ExecutaLeitura("SELECT * FROM PagamentoConta WHERE id_pagamento=@idPagamento", new SQLiteParameter("@idPagamento", pagamento.ContaPagarId));
                    if (_contas.Count > 0)
                    {
                        return _contas;
                    }
                }
                return new List<ContaModelo>();
            }
            catch(Exception ex)
            {
                throw new System.Exception(ex.Message);
            }            
        }
        public List<ContaModelo> GetContasByRecebimento(ContasReceberModelo pagamento)
        {
            try
            {
                _contas.Clear();
                if (pagamento != null)
                {
                    ExecutaLeitura("SELECT * FROM PagamentoConta WHERE id_pagamento=@idPagamento", new SQLiteParameter("@idPagamento", pagamento.ContasAReceberID));
                    if (_contas.Count > 0)
                    {
                        return _contas;
                    }
                }
                return new List<ContaModelo>();
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
                new SQLiteParameter(){ParameterName = "@id", Value= _conta.ContaId},
                new SQLiteParameter(){ParameterName = "@dataLancamento", Value= _conta.DataLancamento.ToString("yyy-MM-dd 00:00:00",CultureInfo.InvariantCulture)},
                new SQLiteParameter(){ParameterName = "@dataVencimento", Value= _conta.DataVencimento.ToString("yyy-MM-dd 00:00:00",CultureInfo.InvariantCulture)},
                new SQLiteParameter(){ParameterName = "@valor", Value= _conta.Valor},
                new SQLiteParameter(){ParameterName = "@pagamentoId", Value= _conta.GestorId}
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
                                _contas.Add(new ContaModelo()
                                {
                                    ContaId = long.TryParse(reader["id"].ToString(), out long id) ? id : 0,
                                    DataLancamento = DateTime.ParseExact(reader["data_lancamento"].ToString(), "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture),
                                    DataVencimento = DateTime.ParseExact(reader["data_vencimento"].ToString(), "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture),
                                    Valor= double.Parse(reader["valor"].ToString()),
                                    GestorId = long.Parse(reader["id_pagamento"].ToString())
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
