using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;
using Modelos;
using OPS_OphellSystem;

namespace Dao
{
    class GrupoFornecedorDao : IDao<GrupoFornecedorModelo>
    {
        private GrupoFornecedorModelo _grupoFornecedor;
        private string connectionString = ConfigurationManager.ConnectionStrings["OPHBD"].ConnectionString;
        public List<GrupoFornecedorModelo> Grupos { get; private set; } = new List<GrupoFornecedorModelo>();
        private PlanoDeContasDao plnaoDao = new PlanoDeContasDao();

        public void Create(GrupoFornecedorModelo modelo)
        {
            if(modelo != null)
            {
                _grupoFornecedor = modelo;
                ExecutaComando("INSERT INTO GrupoFornecedor(descricao=@Descricao,operador_cadastro_id=@OperadorId,operador_cadastro_nome=@OperadorNome" +
                    ",datahora_cadastro=@DataHora,operador_alteracao_id=@OperadorID,operador_alteracao_nome=@OperadorNome,datahora_alteracao=@DataHora)");
            }            
        }

        public void Delete(GrupoFornecedorModelo modelo)
        {
            if(modelo != null)
            {
                _grupoFornecedor = modelo;
                ExecutaComando("DELETE FROM GrupoFornecedor WHERE id=@id");
            }            
        }

        public List<GrupoFornecedorModelo> SelectAll()
        {
            Grupos.Clear();
            ExecutaLeitura("SELECT * FROM GrupoFornecedor");
            return Grupos;
        }

        public void Update(GrupoFornecedorModelo modelo)
        {
            if(modelo != null)
            {
                _grupoFornecedor = modelo;
                ExecutaComando("UPDATE GrupoFornecedor SET descricao=@Descricao,operador_alteracao_id=@OperadorID,operador_alteracao_nome=@OperadorNome" +
                    ",datahora_alteracao=@DataHora WHERE id=@id");
            }            
        }

        public GrupoFornecedorModelo GetById(long id)
        {
            Grupos.Clear();
            ExecutaLeitura("SELECT * FROM GrupoFornecedor WHERE id=@id",new SQLiteParameter("@id",id));
            if(Grupos.Count > 0)
            {
                return Grupos[0];
            }
            return new GrupoFornecedorModelo();
        }

        private SQLiteParameter[] Parametros()
        {
            try
            {
                if (_grupoFornecedor != null)
                {
                    return new SQLiteParameter[] {
                new SQLiteParameter(){ParameterName = "@id", Value= _grupoFornecedor.Id},
                new SQLiteParameter(){ParameterName = "@Descricao", Value= _grupoFornecedor.Descricao},
                new SQLiteParameter(){ParameterName = "@OperadorId", Value= SessaoUsuario.ID},
                new SQLiteParameter(){ParameterName = "@OperadorNome", Value = SessaoUsuario.Nome},
                new SQLiteParameter(){ParameterName = "@DataHora", Value= DateTime.Now},
                new SQLiteParameter(){ParameterName = "@Excluido", Value= _grupoFornecedor.Excluido}
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
                    Grupos.Clear();
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
                                Grupos.Add(new GrupoFornecedorModelo()
                                {
                                    Id = long.TryParse(reader["id"].ToString(), out long id) ? id : 0,
                                    Descricao = reader["descricao"].ToString(),
                                    Excluido = bool.TryParse(reader["excluido"].ToString(),out bool excluido) ? excluido: false
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
