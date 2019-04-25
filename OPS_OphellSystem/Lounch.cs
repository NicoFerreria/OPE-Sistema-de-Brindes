using System;
using Syncfusion.Windows.Forms;
using System.IO;
using System.Drawing;
using System.Windows.Forms;

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
            VerificaBanco();
        }
    }
}
