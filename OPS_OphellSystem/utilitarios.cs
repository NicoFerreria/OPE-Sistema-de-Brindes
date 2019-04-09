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
        static DataTable RealizaConexaoBd(string sqlString)
        {
            try
            {
                DataTable dtDados = new DataTable();
                String strConn = @"Data Source=C:\OphellSB\DB\OpehellBase.db";
                SQLiteConnection conn = new SQLiteConnection(strConn);
                SQLiteDataAdapter da = new SQLiteDataAdapter(sqlString, strConn);
                da.Fill(dtDados);

                return dtDados;

            }
            catch (Exception ex)
            {
                throw new System.Exception(ex.Message);
            }
        }
    }
}
