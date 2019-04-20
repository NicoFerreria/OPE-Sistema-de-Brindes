using System;
using Syncfusion.Windows.Forms;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OPS_OphellSystem
{
    public partial class Lounch : Form
    {
        #region "Classes"

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
            if(telaMenu == null)
            {
                telaMenu = new Menu();
            }
            this.Hide();
            telaMenu.ShowDialog();
            this.Show();
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


    }
}
