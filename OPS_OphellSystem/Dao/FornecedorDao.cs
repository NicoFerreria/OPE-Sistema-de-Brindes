using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;
using Modelos;
using System.Globalization;
using System.Configuration;
using System.Data.SQLite;
using OPS_OphellSystem;

namespace Dao
{
    public class FornecedorDao : IDao<FornecedorModelo>
    {

        private FornecedorModelo _fornecedor;
        private string connectionString = ConfigurationManager.ConnectionStrings["OPHBD"].ConnectionString;
        public List<FornecedorModelo> Fornecedores { get; private set; } = new List<FornecedorModelo>();

        public void Create(FornecedorModelo modelo)

        {
            _fornecedor = modelo;
            string stringSql = "INSERT INTO Fornecedor(cnpj,digito_verificador,ie,plano_de_contas,fantasia,razao,status,endereco,numero,complemento,cidade,bairro,cep,telefone," +
                "contato,email,observacao,operador_cadastro_id,operador_cadastro_nome,operador_alteracao_id,operador_alteracao_nome,datahora_cadastro,datahora_alteracao" +
                ")VALUES(@cnpj,@dv,@ie,@PlanoDeContas,@fantasia,@razao,@status,@endereco,@numero,@complemento,@cidade,@bairro,@cep,@telefone,@contato,@email,@observacao," +
                "@operadorId,@OperadorNome,@OperadorId,@OperadorNome,@datahora,@datahora)";
            ExecutaComando(stringSql);
        }
        public void Delete(FornecedorModelo modelo)
        {
            _fornecedor = modelo;
            string stringSql = "UPDATE Fornecedor SET excluido=1 WHERE id=@id";
            ExecutaComando(stringSql);
        }
        public void Update(FornecedorModelo modelo)
        {
            _fornecedor = modelo;
            string stringSql = "UPDATE Fornecedor SET cnpj=@cnpj,digito_verificador=@dv,ie=@ie,plano_de_contas=@PlanoDeContas,fantasia=@fantasia,razao=@razao,status=@status" +
                ",endereco=@endereco,numero=@numero,complemento=@complemento,cidade=@cidade,bairro=@bairro,cep=@cep,telefone=@telefone," +
                "contato=@contato,email=@email,observacao=@observacao,operador_alteracao_id=@operadorId,operador_alteracao_nome=@operadorNome," +
                "datahora_alteracao=@datahora";
            ExecutaComando(stringSql);
        }
        public List<FornecedorModelo> SelectAll()
        {
            string stringSql = "SELECT * FROM Fornecedor";
            ExecutaLeitura(stringSql);
            return Fornecedores;
        }
        public FornecedorModelo GetById(long id)
        {
            _fornecedor = new FornecedorModelo() { FornecedorId = id };
            string stringSql = "SELECT * FROM Fornecedor WHERE id=@id AND excluido=0";
            ExecutaLeitura(stringSql);
            return Fornecedores.SingleOrDefault<FornecedorModelo>(f => f.FornecedorId == id);
        }

        private SQLiteParameter[] Parametros()
        {
            try
            {
                if (_fornecedor != null)
                {
                    return new SQLiteParameter[] {
                new SQLiteParameter(){ParameterName = "@bairro", Value= _fornecedor.Bairro},
                new SQLiteParameter(){ParameterName = "@cep", Value= _fornecedor.CEP},
                new SQLiteParameter(){ParameterName = "@cidade", Value= _fornecedor.Cidade},
                new SQLiteParameter(){ParameterName = "@id", Value= _fornecedor.FornecedorId},
                new SQLiteParameter(){ParameterName = "@cnpj", Value= _fornecedor.CNPJ + _fornecedor.DigitoVerificadorCnpj},
                new SQLiteParameter(){ParameterName = "@complemento", Value= _fornecedor.Complemento},
                new SQLiteParameter(){ParameterName = "@dv", Value= _fornecedor.DigitoVerificadorCnpj},
                new SQLiteParameter(){ParameterName = "@email", Value= _fornecedor.Email},
                new SQLiteParameter(){ParameterName = "@endereco", Value= _fornecedor.Endereco},
                new SQLiteParameter(){ParameterName = "@fantasia", Value= _fornecedor.Fantasia},
                new SQLiteParameter(){ParameterName = "@contato", Value= _fornecedor.NomeContato},
                new SQLiteParameter(){ParameterName = "@numero", Value= _fornecedor.Numero},
                new SQLiteParameter(){ParameterName = "@observacao", Value= _fornecedor.Observacao},
                new SQLiteParameter(){ParameterName = "@razao", Value= _fornecedor.Razao},
                new SQLiteParameter(){ParameterName = "@status", Value= _fornecedor.Status?1:0},
                new SQLiteParameter(){ParameterName = "@telefone", Value= _fornecedor.Telefone},
                new SQLiteParameter(){ParameterName = "@excluido", Value= _fornecedor.Excluido?1:0},
                new SQLiteParameter(){ParameterName = "@operadorId", Value= _fornecedor.OperadorId},
                new SQLiteParameter(){ParameterName = "@operadorNome", Value= _fornecedor.OperadorNome},
                new SQLiteParameter(){ParameterName = "@datahora", Value= _fornecedor.Datahora},
                new SQLiteParameter(){ParameterName = "@PlanoDeContas", Value= _fornecedor.PlanoDeContas.Id},
                new SQLiteParameter(){ParameterName = "@ie", Value= _fornecedor.InscricaoEstadual}};
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
                    Fornecedores.Clear();
                    var command = new SQLiteCommand(sqlQuery, connection);
                    if (Parametros().Length > 0)
                    {
                        command.Parameters.AddRange(Parametros());
                    }

                    if(parametro != null)
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
                                Fornecedores.Add(new FornecedorModelo()
                                {
                                    FornecedorId = long.TryParse(reader["id"].ToString(), out long id) ? id : 0,
                                    CNPJ = reader["cnpj"].ToString(),
                                    Fantasia = reader["fantasia"].ToString(),
                                    Razao = reader["razao"].ToString(),
                                    Status = (reader["status"].ToString() == "1"),
                                    Endereco = reader["endereco"].ToString(),
                                    Numero = int.TryParse(reader["numero"].ToString(), out int numero) ? numero : 0,
                                    Complemento = reader["complemento"].ToString(),
                                    Cidade = reader["cidade"].ToString(),
                                    Bairro = reader["bairro"].ToString(),
                                    CEP = reader["cep"].ToString(),
                                    Telefone = int.TryParse(reader["telefone"].ToString(), out int telefone) ? telefone : 0,
                                    NomeContato = reader["contato"].ToString(),
                                    Email = reader["email"].ToString(),
                                    Observacao = reader["observacao"].ToString(),
                                    DigitoVerificadorCnpj = reader["digito_verificador"].ToString(),
                                    OperadorId = long.TryParse(reader["operador_atualizacao_id"].ToString(), out long opId) ? opId : 0,
                                    OperadorNome = reader["operador_atualizacao_nome"].ToString(),
                                    Excluido = (reader["excluido"].ToString() == "1"),
                                    Datahora = DateTime.ParseExact(reader["datahora_atualizacao"].ToString(), "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture)
                                    //TipoFornecedor = (TiposFornecedores)Enum.Parse(typeof(TiposFornecedores), reader["tipo"].ToString())
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
