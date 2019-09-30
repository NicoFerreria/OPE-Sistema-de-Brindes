using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cadastros.Modelos;
using Cadastros.Controles;

namespace OPS_OphellSystem.Cadastros.Views.Fornecedores
{
    public partial class FrmFornecedorListagem : Form
    {
        FornecedorControle controle = new FornecedorControle();
        public FrmFornecedorListagem()
        {
            InitializeComponent();
        }

        private void CarregaListagem()
        {
            if(txtPesquisa.Text == "")
            {
                grdFornecedorListagem.DataSource = null;
                grdFornecedorListagem.DataSource = controle.GetListaFornecedores();
            }
        }

        private void txtPesquisa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) CarregaListagem();
        }
    }
}
