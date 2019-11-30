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
        public List<PlanoDeContasModelo> Fornecedores { get; private set; } = new List<PlanoDeContasModelo>();

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
            throw new NotImplementedException();
        }

        public List<PlanoDeContasModelo> SelectAll()
        {
            throw new NotImplementedException();
        }

        public void Update(PlanoDeContasModelo modelo)
        {
            throw new NotImplementedException();
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
                new SQLiteParameter(){ParameterName = "@Plano4", Value= _planoDeContas.Plano1}};
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
                    Fornecedores.Clear();
                    var command = new SQLiteCommand(sqlQuery, connection);
                    if (Parametros().Length > 0)
                    {
                        command.Parameters.AddRange(Parametros());
                    }
                    connection.Open();
                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.StepCount > 0)
                        {
                            while (reader.Read())
                            {
                                Fornecedores.Add(new PlanoDeContasModelo()
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
