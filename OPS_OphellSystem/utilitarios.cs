using System;
using System.Data.SQLite;
using System.Data;
using System.IO;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Text.RegularExpressions;

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
                if (permitirVirgula == true)
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
        public static bool ValidaCnpj(string CNPJ, string DV)
        {
            try
            {



                return true;
            }
            catch (Exception Ex)
            {
                throw new System.Exception(Ex.Message);
            }
        }
        public static bool ValidaCPF()
        {
            try
            {
                return true;
            }
            catch (Exception ex)
            {
                throw new System.Exception(ex.Message);
            }
        }
        private static int CalculaDigitoVarificadorCNPJ(string CNPJ, bool calculaSegundoDigito = false)
        {
            try
            {
                List<int[]> digitos = new List<int[]>();
                int[,] matriz = { };
                int[] resultMultiplicacao = { };
                int resultSoma = 0;
                int quociente = 0;
                int restoDivisao = 0;
                int primeiroDigitoVerificador = 0;
                //Calcula primeiro digito verificador
                matriz = new int[,]
                {
                    {int.Parse(CNPJ[0].ToString()), 5 },
                    {int.Parse(CNPJ[1].ToString()), 4 },
                    {int.Parse(CNPJ[2].ToString()), 3 },
                    {int.Parse(CNPJ[3].ToString()), 2 },
                    {int.Parse(CNPJ[4].ToString()), 9 },
                    {int.Parse(CNPJ[5].ToString()), 8 },
                    {int.Parse(CNPJ[6].ToString()), 7 },
                    {int.Parse(CNPJ[7].ToString()), 6 },
                    {int.Parse(CNPJ[8].ToString()), 5 },
                    {int.Parse(CNPJ[9].ToString()), 4 },
                    {int.Parse(CNPJ[10].ToString()), 3 },
                    {int.Parse(CNPJ[11].ToString()), 2 }                    
                };

                resultMultiplicacao = new int[matriz.GetLength(0)];
                //Multiplica os valores da primeira Matriz
                for (int i = 0; i < matriz.GetLength(0); i++)
                {
                    resultMultiplicacao[i] = matriz[i, 0] * matriz[i, 1];
                }

                //Soma os resultados da multiplicação
                for (int i = 0; i < resultMultiplicacao.Length; i++)
                {
                    resultSoma += resultMultiplicacao[i];
                }

                quociente = resultSoma / 11;
                restoDivisao = resultSoma % 11;

                if (restoDivisao > 2)
                {
                    primeiroDigitoVerificador = 11 - restoDivisao;
                }

                return 0;
            }
            catch (Exception ex)
            {
                throw new System.Exception(ex.Message);
            }
        }
        public static string RemoveCaracteresEspeciais(string texto)
        {
            try
            {
                string input = texto;
                string pattern = @"(?i)[^0-9a-záéíóúàèìòùâêîôûãõç\s]";
                string replacement = "";
                Regex rgx = new Regex(pattern);
                string result = rgx.Replace(input, replacement);

                return result;
            }catch(Exception ex)
            {
                throw new System.Exception(ex.Message);
            }
        }
        #endregion
    }
}
