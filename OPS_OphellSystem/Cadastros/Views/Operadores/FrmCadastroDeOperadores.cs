using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OPS_OphellSystem.Cadastros.Views.Operadores
{
    public partial class FrmCadastroDeOperadores : Form
    {
        #region "Metodos"
        public FrmCadastroDeOperadores()
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
        private void NovoCadastro()
        {
            txtId.Text = "";
            txtNome.Text = "";
            txtSobrenome.Text = "";
            txtContas.Text = "";
            txtSenha.Text = "";
            txtConfirmaSenha.Text = "";
            cmbPerfil.SelectedIndex = 0;
            tgBtnStaus.ToggleState = Syncfusion.Windows.Forms.Tools.ToggleButtonState.Active;
        }
        private void NovoFormulario()
        {
            try
            {
                CarregaCombos();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "OPH", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void CarregaCombos()
        {
            try
            {
                cmbPerfil.Items.Clear();
                cmbPerfil.Items.Add("VENDEDOR");
                cmbPerfil.SelectedIndex = 0;

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "OPH", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region "Eventos"
        private void FrmCadastroDeOperadores_Load(object sender, EventArgs e)
        {

        }
        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Fechar();
        }
        #endregion

        private void btnGravar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Operação realizada com sucesso!", "OPH", MessageBoxButtons.OK, MessageBoxIcon.Information);
            NovoCadastro();
        }

        private void FrmCadastroDeOperadores_Shown(object sender, EventArgs e)
        {
            NovoFormulario();
        }
    }
}
