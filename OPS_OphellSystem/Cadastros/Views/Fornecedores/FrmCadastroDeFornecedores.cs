using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OPS_OphellSystem.Cadastros.Views.Fornecedores
{
    public partial class FrmCadastroDeFornecedores : Form
    {
        #region "Metodos"
        public FrmCadastroDeFornecedores()
        {
            InitializeComponent();
        }
        private void Fechar()
        {
            if(this.Visible == true)
            {
                this.Hide();
            }
        }
        #endregion

        #region "Eventos"
        private void txtNumero_TextChanged(object sender, EventArgs e)
        {

        }
        private void FrmCadastroDeFornecedores_Load(object sender, EventArgs e)
        {

        }
        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Fechar();
        }
        #endregion




    }
}
