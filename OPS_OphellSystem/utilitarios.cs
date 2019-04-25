using System;
using System.Data.SQLite;
using System.Data;
using System.IO;

namespace OPS_OphellSystem
{
    static class utilitarios
    {
        static GeradorBD gerador = new GeradorBD();
        public static string caminhoSistema = AppDomain.CurrentDomain.BaseDirectory;
        public static string caminhoBD = caminhoSistema + "DB\\oph.sqlite";
        public static DataTable RealizaConexaoBd(string sqlString)
        {
            try
            {                
                DataTable dtDados = new DataTable();
                string strConn = @"Data Source=" + caminhoBD + "; Version=3;";
                SQLiteConnection conn = new SQLiteConnection(strConn);
                conn.Open();
                if (File.Exists(caminhoBD) == false)
                {                    
                    conn.Close();
                    throw new System.Exception("O arquivo de bando de Dados não foi encontrado!");
                }
                SQLiteDataAdapter da = new SQLiteDataAdapter(sqlString, strConn);
                SQLiteCommand cmd = new SQLiteCommand(sqlString,conn);                
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
