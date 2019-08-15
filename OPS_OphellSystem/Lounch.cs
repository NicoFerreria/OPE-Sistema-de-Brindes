using System;
using Syncfusion.Windows.Forms;
using System.IO;
using System.Drawing;
using System.Windows.Forms;
using OPS_OphellSystem.Cadastros.Classes.Operadores;
using System.Collections.Generic;

namespace OPS_OphellSystem
{
    public partial class Lounch : Form
    {
        #region "Classes"
        GeradorBD gerador = new GeradorBD();
        #endregion

        #region "Variaveis"
        Menu telaMenu;
        #endregion

        #region "Metodos"
        public Lounch()
        {
            InitializeComponent();
            //TesteGit
        }
        private void Placeholders()
        {
            try
            {
                BannerTextInfo placeholderOperador = bnTxtOperador.GetBannerText(txtOperador);
                placeholderOperador.Text = "Operador";
                placeholderOperador.Visible = true;
                placeholderOperador.Color = Color.Black;
                placeholderOperador.Mode = BannerTextMode.FocusMode;

                BannerTextInfo placeholderSenha = bnTxtOperador.GetBannerText(txtSenha);
                placeholderSenha.Text = "Senha";
                placeholderSenha.Visible = true;
                placeholderSenha.Color = Color.Black;
                placeholderSenha.Mode = BannerTextMode.FocusMode;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void AbrirTelaMenu()
        {
            if (telaMenu == null)
            {
                telaMenu = new Menu();
            }
            this.Hide();
            telaMenu.ShowDialog();
            this.Show();
        }
        private void VerificaBanco()
        {
            try
            {
                string[] comando = gerador.ObterComandosSql();
                if (File.Exists(utilitarios.caminhoBD) == false)
                {
                    if(Directory.Exists(utilitarios.diretorioBD) == false)
                    {
                        Directory.CreateDirectory(utilitarios.diretorioBD);
                    }
                    pgbLoadSistema.Visible = true;
                    pgbLoadSistema.Minimum = 0;
                    pgbLoadSistema.Maximum = comando.Length;                    
                    for (int i = 0; i < comando.Length; i++)
                    {
                        utilitarios.RealizaConexaoBd(comando[i]);
                        pgbLoadSistema.Value = i + 1;
                        pgbLoadSistema.Refresh();
                    }
                    pgbLoadSistema.Visible = false;
                }
            }
            catch (Exception ex)
            {
                pgbLoadSistema.Visible = false;
                MessageBox.Show(ex.Message, "OPH", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void CarregaComboOperadores()
        {
            try
            {
                CadastroDeOperadores operador = new CadastroDeOperadores();
                string[,] dadosOperador = new string [operador.GetAllOperadoresAtivos().Count,3];
                List<string[,]> tabela = new List<string[,]>();

                mCmbOperadores.Items.Clear();
                mCmbOperadores.DataSource = null;
                mCmbOperadores.Columns.Clear();
                mCmbOperadores.Columns.Add("OperadorId");
                mCmbOperadores.Columns.Add("Nome");
                mCmbOperadores.Columns.Add("Sobrenome");                 
                mCmbOperadores.ValueMember = "OperadorId";
                mCmbOperadores.DisplayMember = "Nome";
                
                for(int inicio = 0;inicio < operador.GetAllOperadoresAtivos().Count; inicio++)
                {
                    operador = operador.GetAllOperadoresAtivos()[inicio];
                    dadosOperador[inicio, 0] = operador.OperadorId.ToString();
                    dadosOperador[inicio, 1] = operador.Nome;
                    dadosOperador[inicio, 2] = operador.Sobrenome;
                    
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "OPH", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void AberturaSistema()
        {
            try
            {
                VerificaBanco();
                CarregaComboOperadores();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "OPH", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region "Funcoes"

        #endregion

        #region "Eventos"
        private void Lounch_Load(object sender, EventArgs e)
        {
            Placeholders();            
        }
        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            AbrirTelaMenu();
        }

        #endregion

        private void Lounch_Shown(object sender, EventArgs e)
        {
            AberturaSistema();
        }
    }
}
