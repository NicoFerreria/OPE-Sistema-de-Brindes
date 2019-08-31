using System;
using System.Data.SQLite;
using System.Data;
using System.IO;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using Syncfusion.WinForms.DataGrid;

namespace OPS_OphellSystem
{
    public static class utilitarios
    {
        #region "Classes"
        static GeradorBD gerador = new GeradorBD();

        #endregion

        #region "Variaveis"
        private static string caminhoSistema = AppDomain.CurrentDomain.BaseDirectory;
        public static string caminhoBD = caminhoSistema + "DB\\oph.sqlite";
        public static string diretorioBD = caminhoSistema + "DB";
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
        public static void CriarColunasGrid(SfDataGrid grid, string campo, string caption, TiposColunas tipo = TiposColunas.TEXTO, bool limparColuna = false,
            bool editar = false,bool visivel = true)
        {
            try
            {
                GridColumn coluna = new GridColumn();

                switch (tipo)
                {
                    case TiposColunas.TEXTO:
                        coluna = new GridTextColumn();
                        break;
                    case TiposColunas.NUMERICO:
                        coluna = new GridNumericColumn();
                        break;
                    case TiposColunas.IMAGEM:
                        coluna = new GridImageColumn();
                        break;
                    case TiposColunas.HYPERLINK:
                        coluna = new GridHyperlinkColumn();
                        break;
                    case TiposColunas.DATA_HORA:
                        coluna = new GridDateTimeColumn();
                        break;
                    case TiposColunas.COMBO:
                        coluna = new GridComboBoxColumn();
                        break;
                    case TiposColunas.CHEK:
                        coluna = new GridCheckBoxColumn() { AllowThreeState = false};
                        break;
                    case TiposColunas.BOTAO:
                        coluna = new GridButtonColumn();
                        break;
                }
                grid.AutoGenerateColumns = false;
                
                if (limparColuna == true)                {
                    
                    grid.Columns.Clear();
                }

                coluna.Visible = visivel;
                coluna.AllowEditing = editar;
                coluna.MappingName = campo;
                coluna.HeaderText = caption;
                grid.Columns.Add(coluna);
                
            }
            catch (Exception ex)
            {
                throw new System.Exception(ex.Message);
            }
        }
        #endregion

        #region "Funcoes"
        public static DataTable RealizaConexaoBd(string sqlString, List<SqlParametro> parametros = null)
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

                if (parametros != null)
                {
                    foreach (SqlParametro p in parametros)
                    {
                        cmd.Parameters.AddWithValue(p.Nome, p.Valor);
                    }

                }

                cmd.ExecuteNonQuery();
                var dt = cmd.ExecuteReader();
                da.Fill(dtDados);

                //da.Fill();
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

                int[] pesosPrimeiroDigito = new int[] { 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
                int primeiroDigito = CalculaDigitoVarificadorCNPJ(CNPJ, pesosPrimeiroDigito);
                CNPJ = CNPJ + primeiroDigito.ToString();
                int[] pesosSegundoDigito = new int[] { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
                int segundoDigito = CalculaDigitoVarificadorCNPJ(CNPJ, pesosSegundoDigito);

                if (primeiroDigito == int.Parse(DV[0].ToString()))
                {
                    if (segundoDigito == int.Parse(DV[1].ToString()))
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
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
        private static int CalculaDigitoVarificadorCNPJ(string CNPJ, int[] pesos)
        {
            try
            {
                List<int[]> digitos = new List<int[]>();
                int[,] matriz = { };
                int[] resultMultiplicacao = { };
                int resultSoma = 0;
                int quociente = 0;
                int restoDivisao = 0;
                int digitoVerificador = 0;

                resultMultiplicacao = new int[pesos.Length];
                //Multiplica os valores da primeira Matriz
                for (int i = 0; i < pesos.Length; i++)
                {
                    resultMultiplicacao[i] = pesos[i] * int.Parse(CNPJ[i].ToString());
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
                    digitoVerificador = 11 - restoDivisao;
                }

                return digitoVerificador;
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
            }
            catch (Exception ex)
            {
                throw new System.Exception(ex.Message);
            }
        }
        #endregion
    }
}
