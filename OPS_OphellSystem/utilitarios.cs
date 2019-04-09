using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;

namespace OPS_OphellSystem
{
    static class utilitarios
    {
        public static DataTable RealizaConexaoBd(string sqlString)
        {
            try
            {
                string caminhoSistema = AppDomain.CurrentDomain.BaseDirectory;
                DataTable dtDados = new DataTable();
                String strConn = @"Data Source="+ caminhoSistema  +"DB\\OpehellBase.db";
                SQLiteConnection conn = new SQLiteConnection(strConn);
                SQLiteDataAdapter da = new SQLiteDataAdapter(sqlString, strConn);
                da.Fill(dtDados);
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
                return dtDados;

            }
            catch (Exception ex)
            {
                throw new System.Exception(ex.Message);
            }            
        }
    }
}
