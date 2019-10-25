using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Configuration;
using Interfaces;
using Modelos;
using System.Linq;
using System.Globalization;

namespace Dao
{
    public class ClienteDao : IDao<ClienteModelo>
    {

        private ClienteModelo _cliente;
        private string connectionString = ConfigurationManager.ConnectionStrings["OPHBD"].ConnectionString;
        public List<ClienteModelo> Clientes { get; private set; } = new List<ClienteModelo>();
        public ClienteDao()
        {

        }        
        public void Create(ClienteModelo cliente)
        {
            try
            {
                _cliente = cliente;
                string sqlQuery = "INSERT INTO Cliente(cnpj,fantasia,razao,status,endereco,numero,complemento,cidade,bairro,cep,telefone,contato,email,observacao," +
                "digito_verificador,operador_cadastro_id,operador_cadastro_nome,datahora_cadastro,operador_atualizacao_id,operador_atualizacao_nome," +
                "datahora_atualizacao)VALUES(@cnpj,@fantasia,@razao,@status,@endereco,@numero,@complemento,@cidade,@bairro,@cep,@telefone,@contato,@email,@observacao," +
                "@dv,@operadorId,@operadorNome,datetime('now','localtime'),@operadorId,@operadorNome,datetime('now','localtime'))";

                ExecutaComando(sqlQuery);
            }
            catch (SQLiteException ex)
            {

                throw new SQLiteException(ex.Message);
            }
        }

        public void Delete(ClienteModelo cliente)
        {
            try
            {
                _cliente = cliente;
                string sqlQuery = "UPDATE Cliente SET excluido=1,operador_atualizacao_id=@operadorId,operador_atualizacao_nome=@operadorNome," +
                    "datahora_atualizacao=datetime('now','localtime') WHERE id=@id";
                ExecutaComando(sqlQuery);
            }
            catch (SQLiteException ex)
            {

                throw new SQLiteException(ex.Message);
            }
        }

        public void Update(ClienteModelo cliente)
        {
            try
            {
                _cliente = cliente;
                string sqlQuery = "UPDATE Cliente SET cnpj=@cnpj,fantasia=@fantasia,razao=@razao,status=@status,endereco=@endereco,numero=@numero,complemento=@complemento," +
                "cidade=@cidade,bairro=@bairro,cep=@cep,telefone=@telefone,contato=@contato,email=@email,observacao=@observacao,digito_verificador=@dv," +
                "operador_atualizacao_id=@operadorId,operador_atualizacao_nome=@operadorNome,datahora_atualizacao=datetime('now','localtime')";
                ExecutaComando(sqlQuery);
            }
            catch (SQLiteException ex)
            {

                throw new SQLiteException(ex.Message);
            }
        }

        public List<ClienteModelo> SelectAll()
        {
            try
            {
                string sqlQuery = "SELECT * FROM Cliente";
                ExecutaLeitura(sqlQuery);
                return Clientes;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

        }
        public ClienteModelo SelectClietePorId(long id)
        {
            try
            {
                _cliente = new ClienteModelo() { ClienteId = id };
                string sqlQuery = "SELECT * FROM Cliente WHERE id=@id";
                ExecutaLeitura(sqlQuery);
                var cli = Clientes.Where(c => c.ClienteId == _cliente.ClienteId).First();
                return cli;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
        public bool ContemCliente(ClienteModelo cliente)
        {
            try
            {
                _cliente = cliente;
                string sqlQuery = "SELECT * FROM Cliente WHERE id=@id AND excluido=0";
                ExecutaLeitura(sqlQuery);
                if (Clientes.Count <= 0)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

        }

        private SQLiteParameter[] Parametros()
        {
            try
            {
                if (_cliente != null)
                {
                    return new SQLiteParameter[] {
                new SQLiteParameter(){ParameterName = "@bairro", Value= _cliente.Bairro},
                new SQLiteParameter(){ParameterName = "@cep", Value= _cliente.CEP},
                new SQLiteParameter(){ParameterName = "@cidade", Value= _cliente.Cidade},
                new SQLiteParameter(){ParameterName = "@id", Value= _cliente.ClienteId},
                new SQLiteParameter(){ParameterName = "@cnpj", Value= _cliente.CNPJ + _cliente.DigitoVerificadorCnpj},
                new SQLiteParameter(){ParameterName = "@complemento", Value= _cliente.Complemento},
                new SQLiteParameter(){ParameterName = "@dv", Value= _cliente.DigitoVerificadorCnpj},
                new SQLiteParameter(){ParameterName = "@email", Value= _cliente.Email},
                new SQLiteParameter(){ParameterName = "@endereco", Value= _cliente.Endereco},
                new SQLiteParameter(){ParameterName = "@fantasia", Value= _cliente.Fantasia},
                new SQLiteParameter(){ParameterName = "@contato", Value= _cliente.NomeContato},
                new SQLiteParameter(){ParameterName = "@numero", Value= _cliente.Numero},
                new SQLiteParameter(){ParameterName = "@observacao", Value= _cliente.Observacao},
                new SQLiteParameter(){ParameterName = "@razao", Value= _cliente.Razao},
                new SQLiteParameter(){ParameterName = "@status", Value= _cliente.Status?1:0},
                new SQLiteParameter(){ParameterName = "@telefone", Value= _cliente.Telefone},
                new SQLiteParameter(){ParameterName = "@excluido", Value= _cliente.Excluido?1:0},
                new SQLiteParameter(){ParameterName = "@operadorId", Value= _cliente.OperadorId},
                new SQLiteParameter(){ParameterName = "@operadorNome", Value= _cliente.OperadorNome},
                new SQLiteParameter(){ParameterName = "@datahora", Value= _cliente.Datahora}};
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
        private void ExecutaLeitura(string sqlQuery)
        {

            try
            {
                using (var connection = new SQLiteConnection(connectionString))
                {
                    Clientes.Clear();
                    var command = new SQLiteCommand(sqlQuery, connection);
                    if(Parametros().Length > 0)
                    {
                        command.Parameters.AddRange(Parametros());
                    }                    
                    connection.Open();
                    using (var reader = command.ExecuteReader())
                    {
                        if(reader.StepCount > 0)
                        {
                            while (reader.Read())
                            {
                                Clientes.Add(new ClienteModelo()
                                {
                                    ClienteId = long.TryParse(reader["id"].ToString(), out long id) ? id : 0,
                                    CNPJ = reader["cnpj"].ToString(),
                                    Fantasia = reader["fantasia"].ToString(),
                                    Razao = reader["razao"].ToString(),
                                    Status = (reader["status"].ToString() == "1"),
                                    Endereco = reader["endereco"].ToString(),
                                    Numero = int.TryParse(reader["numero"].ToString(), out int numero) ? numero : 0,
                                    Complemento = reader["complemento"].ToString(),
                                    Cidade = reader["cidade"].ToString(),
                                    Bairro = reader["bairro"].ToString(),
                                    CEP = int.TryParse(reader["cep"].ToString(), out int cep) ? cep : 0,
                                    Telefone = int.TryParse(reader["telefone"].ToString(), out int telefone) ? telefone : 0,
                                    NomeContato = reader["contato"].ToString(),
                                    Email = reader["email"].ToString(),
                                    Observacao = reader["observacao"].ToString(),
                                    DigitoVerificadorCnpj = reader["digito_verificador"].ToString(),
                                    OperadorId = long.TryParse(reader["operador_atualizacao_id"].ToString(), out long opId) ? opId : 0,
                                    OperadorNome = reader["operador_atualizacao_nome"].ToString(),
                                    Excluido = (reader["excluido"].ToString() == "1"),
                                    Datahora = DateTime.ParseExact(reader["datahora_atualizacao"].ToString(), "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture),
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
