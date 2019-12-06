using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Views.Modelos;
using Modelos;
using OPS_OphellSystem;
using Cadastros.Controles;

namespace Views
{
    public partial class FrmBuscaFornecedor : FrmBusca
    {
        #region "PROPRIEDADES"
        public FornecedorModelo Fornecedor { get; set; }
        private FornecedorControle _controle = new FornecedorControle();
        public TiposFornecedores TipoFornecedor { get; set; } = TiposFornecedores.MERCADORIA;
        #endregion

        public FrmBuscaFornecedor()
        {
            InitializeComponent();            
        }

        private void CarregaFornecedor()
        {
            try
            {
                if(grdResultados.DataSource != null)
                {
                    Fornecedor = (FornecedorModelo)grdResultados.SelectedItem;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "OPH", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Fechar(bool confirma = false)
        {
            try
            {
                if(this.Visible == true)
                {
                    if(confirma == true)
                    {
                        CarregaFornecedor();
                    }
                    else
                    {
                        Fornecedor = null;
                    }
                    this.Hide();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message,"OPH", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CarregaListagem()
        {
            try
            {
                grdResultados.DataSource = null;
                grdResultados.DataSource = _controle.GetListaFornecedores(txtCriterio.Text);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message,"OPH", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void FrmBuscaFornecedor_FormClosing(object sender, FormClosingEventArgs e)
        {
            Fechar();
        }

        private void btnConfirma_Click(object sender, EventArgs e)
        {
            Fechar(true);
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            CarregaListagem();
        }

        private void txtCriterio_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) CarregaListagem();
        }
    }
}
