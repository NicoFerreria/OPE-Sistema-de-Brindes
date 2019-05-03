using System;
using System.Data.SQLite;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace OPS_OphellSystem
{
    static class utilitarios
    {
        #region "Classes"
        static GeradorBD gerador = new GeradorBD();
        #endregion

        #region "Variaveis"
        private static string caminhoSistema = AppDomain.CurrentDomain.BaseDirectory;
        public static string caminhoBD = caminhoSistema + "DB\\oph.sqlite";
        #endregion

        #region "Metodos"
        public static void PermitirApenasNumeros(object sender, KeyPressEventArgs e, bool permitirVirgula = false, bool permitirPonto = false)
        {
            try
            {
                if(permitirVirgula == true)
                {
                    if (e.KeyChar != 8 && e.KeyChar != 44)
                    {
                        if (e.KeyChar < 48 || e.KeyChar > 57)
                        {

                            e.Handled = true;
                        }
                    }
                }
                else if (permitirPonto == true)
                {
                    if (e.KeyChar != 8 && e.KeyChar != 46)
                    {
                        if (e.KeyChar < 48 || e.KeyChar > 57)
                        {

                            e.Handled = true;
                        }
                    }
                }
                else
                {
                    if (e.KeyChar != 8)
                    {
                        if (e.KeyChar < 48 || e.KeyChar > 57)
                        {

                            e.Handled = true;
                        }
                    }
                }              

            }
            catch (Exception ex)
            {
                throw new System.Exception(ex.Message);
            }
        }
        #endregion

        #region "Funcoes"
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
                SQLiteCommand cmd = new SQLiteCommand(sqlString, conn);
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
        #endregion




    }
}
