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
        private PlanoDeContasDao plnaoDao = new PlanoDeContasDao();
        private GrupoFornecedorDao Grupo = new GrupoFornecedorDao();

        public void Create(FornecedorModelo modelo)

        {
            _fornecedor = modelo;
            string stringSql = "INSERT INTO Fornecedor(cnpj,digito_verificador,ie,plano_id,fantasia,razao,status,endereco,numero,complemento,cidade,bairro,cep,telefone," +
                "contato,email,observacao,operador_cadastro_id,operador_cadastro_nome,operador_alteracao_id,operador_alteracao_nome,datahora_cadastro,datahora_alteracao," +
                "terceiro)VALUES(@cnpj,@dv,@ie,@PlanoDeContas,@fantasia,@razao,@status,@endereco,@numero,@complemento,@cidade,@bairro,@cep,@telefone,@contato,@email,@observacao," +
                "@operadorId,@operadorNome,@operadorId,@operadorNome,datetime('now','localtime'),datetime('now','localtime'),@Terceiro)";
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
            string stringSql = "UPDATE Fornecedor SET cnpj=@cnpj,digito_verificador=@dv,ie=@ie,fantasia=@fantasia,razao=@razao,status=@status" +
                ",endereco=@endereco,numero=@numero,complemento=@complemento,cidade=@cidade,bairro=@bairro,cep=@cep,telefone=@telefone," +
                "contato=@contato,email=@email,observacao=@observacao,operador_alteracao_id=@operadorId,operador_alteracao_nome=@operadorNome," +
                "datahora_alteracao=datetime('now','localtime'),terceiro=@Terceiro";
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
            string stringSql = "SELECT * FROM Fornecedor WHERE id=@id AND excluido='false'";
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
                new SQLiteParameter(){ParameterName = "@status", Value= _fornecedor.Status.ToString()},
                new SQLiteParameter(){ParameterName = "@telefone", Value= _fornecedor.Telefone},
                new SQLiteParameter(){ParameterName = "@excluido", Value= _fornecedor.Excluido.ToString()},
                new SQLiteParameter(){ParameterName = "@operadorId", Value= _fornecedor.OperadorId},
                new SQLiteParameter(){ParameterName = "@operadorNome", Value= _fornecedor.OperadorNome},
                new SQLiteParameter(){ParameterName = "@datahora", Value= DateTime.Now.ToShortDateString()},
                new SQLiteParameter(){ParameterName = "@PlanoDeContas", Value= _fornecedor.PlanoDeContasId},
                new SQLiteParameter(){ParameterName = "@ie", Value= _fornecedor.InscricaoEstadual},
                new SQLiteParameter(){ParameterName = "@Grupo", Value= _fornecedor.GrupoFornecedorId},
                new SQLiteParameter(){ParameterName = "@Terceiro", Value= _fornecedor.Terceiro.ToString()}};
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
                                Fornecedores.Add(new FornecedorModelo()
                                {
                                    FornecedorId = long.Parse(reader["id"].ToString()),
                                    CNPJ = reader["cnpj"].ToString(),
                                    InscricaoEstadual = reader["ie"].ToString(),
                                    Fantasia = reader["fantasia"].ToString(),
                                    Razao = reader["razao"].ToString(),
                                    Status = bool.Parse(reader["status"].ToString()),
                                    Endereco = reader["endereco"].ToString(),
                                    Numero = int.Parse(reader["numero"].ToString()),
                                    Complemento = reader["complemento"].ToString(),
                                    Cidade = reader["cidade"].ToString(),
                                    Bairro = reader["bairro"].ToString(),
                                    CEP = reader["cep"].ToString(),
                                    Telefone = int.Parse(reader["telefone"].ToString()),
                                    NomeContato = reader["contato"].ToString(),
                                    Email = reader["email"].ToString(),
                                    Terceiro = bool.Parse(reader["terceiro"].ToString()),
                                    Observacao = reader["observacao"].ToString(),
                                    OperadorId = long.Parse(reader["operador_alteracao_id"].ToString()),
                                    OperadorNome = reader["operador_alteracao_nome"].ToString(),
                                    Datahora = DateTime.ParseExact(reader["datahora_alteracao"].ToString(), "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture),
                                    Excluido = bool.Parse(reader["excluido"].ToString()),
                                    DigitoVerificadorCnpj = reader["digito_verificador"].ToString()
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
