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
    public partial class FrmBuscaCliente : FrmBusca
    {
        #region "PROPRIEDADES"
        public ClienteModelo Cliente { get; set; }
        private ClienteControle _controle = new ClienteControle();
        #endregion

        public FrmBuscaCliente()
        {
            InitializeComponent();
        }        

        private void CarregaCliente()
        {
            try
            {
                if (grdResultados.DataSource != null)
                {
                    Cliente = (ClienteModelo)grdResultados.SelectedItem;
                }                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "OPH", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Fechar(bool confirma = false)
        {
            if(this.Visible == true)
            {
                if(confirma == true)
                {
                    CarregaCliente();
                }
                else
                {
                    Cliente = new ClienteModelo();
                }
                this.Hide();
            }
        }
        private void CarregaListagem()
        {
            try
            {
                grdResultados.DataSource = null;
                grdResultados.DataSource = _controle.BuscaCliente("");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "OPH", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }        
        private void NovoForm()
        {
            grdResultados.DataSource = null;
            txtCriterio.Text = "";
            txtCriterio.Focus();
        }
        private void BuscarCliente()
        {
            try
            {
                if (txtCriterio.Text == "")
                {
                    CarregaListagem();
                }
                else
                {
                    grdResultados.DataSource = null;
                    grdResultados.DataSource = _controle.BuscaCliente(txtCriterio.Text);
                }                
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "OPH", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmBuscaCliente_Shown(object sender, EventArgs e)
        {
            NovoForm();
        }

        private void FrmBuscaCliente_FormClosing(object sender, FormClosingEventArgs e)
        {
            Fechar();
        }

        private void btnConfirma_Click(object sender, EventArgs e)
        {
            Fechar(true);
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            BuscarCliente();
        }
    }
}
