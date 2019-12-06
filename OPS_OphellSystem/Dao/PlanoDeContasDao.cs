using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;
using Modelos;
using System.Configuration;
using System.Data.SQLite;

namespace Dao
{
   public class PlanoDeContasDao:IDao<PlanoDeContasModelo>
    {
        private PlanoDeContasModelo _planoDeContas;
        private string connectionString = ConfigurationManager.ConnectionStrings["OPHBD"].ConnectionString;
        public List<PlanoDeContasModelo> Planos { get; private set; } = new List<PlanoDeContasModelo>();

        public PlanoDeContasDao()
        {

        }

        public void Create(PlanoDeContasModelo modelo)
        {
            _planoDeContas = modelo;
            string sql = "INSERT INTO Plano_de_Contas(plano1,plano2,plano2,plano4)VALUES(@plano1,@plano2,@plano3,@plano4)";
            ExecutaComando(sql);
        }

        public void Delete(PlanoDeContasModelo modelo)
        {
            if (modelo.Id == 0) throw new System.Exception("Plano de contas inválido para atualização");
            _planoDeContas = modelo;
            ExecutaComando("DELETE FROM PlanoContas WHERE id=@id");
        }

        public List<PlanoDeContasModelo> SelectAll()
        {
            Planos.Clear();
            ExecutaComando("SELECT * FROM PlanoContas");
            return Planos;
        }

        public void Update(PlanoDeContasModelo modelo)
        {
            if (modelo.Id == 0) throw new System.Exception("Plano de contas inválido para atualização");
            _planoDeContas = modelo;
            ExecutaComando("UPDATE SET plano1=@Plano1,Plano2=@Plano2,Plano3=@Plano3,Plano4=@Plano2 WHERE id=@id");
        }

        public PlanoDeContasModelo GetPlanoById(long id)
        {
            Planos.Clear();
            ExecutaLeitura("SELECT * FROM PlanoContas WHERE id=@id", new SQLiteParameter("@id",id));
            if(Planos.Count > 0)
            {
                return Planos[0];
            }
            return new PlanoDeContasModelo();
        }

        private SQLiteParameter[] Parametros()
        {
            try
            {
                if (_planoDeContas != null)
                {
                    return new SQLiteParameter[] {
                new SQLiteParameter(){ParameterName = "@id", Value= _planoDeContas.Id},
                new SQLiteParameter(){ParameterName = "@Plano1", Value= _planoDeContas.Plano1},
                new SQLiteParameter(){ParameterName = "@Plano2", Value= _planoDeContas.Plano1},
                new SQLiteParameter(){ParameterName = "@Plano2", Value= _planoDeContas.Plano1},
                new SQLiteParameter(){ParameterName = "@Plano4", Value= _planoDeContas.Plano1},
                new SQLiteParameter(){ParameterName = "@excluido", Value= _planoDeContas.Excluido}};
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
        private void ExecutaLeitura(string sqlQuery,SQLiteParameter parametro = null)
        {

            try
            {
                using (var connection = new SQLiteConnection(connectionString))
                {
                    Planos.Clear();
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
                                Planos.Add(new PlanoDeContasModelo()
                                {
                                    Id = long.TryParse(reader["id"].ToString(), out long id) ? id : 0,
                                    Plano1 = reader["plano1"].ToString(),
                                    Plano2 = reader["plano2"].ToString(),
                                    Plano3 = reader["plano3"].ToString(),
                                    Plano4 = reader["plano4"].ToString()
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
