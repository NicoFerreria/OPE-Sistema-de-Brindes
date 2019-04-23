using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OPS_OphellSystem.Cadastros.Views.Clientes
{
    public partial class FrmCadastroDeClientes : Form
    {
        #region "Classes"
        Cadastros.Classes.Clientes.CadastroDeClientes cadastroCLiente = new Classes.Clientes.CadastroDeClientes();
        #endregion

        #region"Variaveis"
        #endregion

        #region "Metodos"
        public FrmCadastroDeClientes()
        {
            InitializeComponent();
        }
        private void Fechar()
        {
            try
            {
                if (this.Visible == true)
                {
                    this.Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void GravarCliente()
        {
            try
            {
                if (ValidaCampos() == false) return;

                cadastroCLiente.CNPJ = int.Parse(txtCnpj.Text);
                cadastroCLiente.Fantasia = txtNomeFantaisa.Text;
                cadastroCLiente.Razao = txtRazaoSocial.Text;
                cadastroCLiente.CEP = int.Parse(txtCep.Text);
                cadastroCLiente.Endereco = txtEndereco.Text;
                cadastroCLiente.Numero = int.Parse(txtNumero.Text);
                cadastroCLiente.Bairro = txtBairro.Text;
                cadastroCLiente.Cidade = txtCidade.Text;
                cadastroCLiente.NomeContato = txtNomeContato.Text;
                cadastroCLiente.EmailContato = txtEmail.Text;
                cadastroCLiente.Telefone = int.Parse(txtTelefone.Text);
                cadastroCLiente.GravarCliente();

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "OPH", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void NovoCliente()
        {
            try
            {
                txtIdCliente.Text = "";
                txtNomeFantaisa.Text = "";
                txtRazaoSocial.Text = "";
                txtCnpj.Text = "";
                txtCep.Text = "";
                txtEndereco.Text = "";
                txtNumero.Text = "";
                txtBairro.Text = "";
                txtCidade.Text = "";
                txtNomeContato.Text = "";
                txtEmail.Text = "";
                txtTelefone.Text = "";
                tgBtnAtivarDesativarCliente.ToggleState = Syncfusion.Windows.Forms.Tools.ToggleButtonState.Active;
                txtCnpj.Focus();

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "OPH", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void VerificaStatusCliente()
        {
            try
            {
                if(tgBtnAtivarDesativarCliente.ToggleState == Syncfusion.Windows.Forms.Tools.ToggleButtonState.Active)
                {
                    grpDadosCliente.Enabled = true;
                }
                else
                {
                    grpDadosCliente.Enabled = false;
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "OPH", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void PreencheCamposFormulario()
        {
            try
            {
                VerificaStatusCliente();

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "OPH", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region "Funcoes"
        private bool ValidaCampos()
        {
            try
            {
                if (txtCnpj.Text == "")
                {
                    MessageBox.Show("Por favor preencha o campo CNPJ!", "OPH", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtCnpj.Focus();
                    return false;
                }
                if (txtNomeFantaisa.Text == "")
                {
                    MessageBox.Show("Pro favor preencha o campo Nome Fantasia!", "OPH", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtNomeFantaisa.Focus();
                    return false;
                }
                if (txtRazaoSocial.Text == "")
                {
                    MessageBox.Show("Por favor preencha o campo Razão Social!", "OPH", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtRazaoSocial.Focus();
                    return false;
                }
                if (txtCep.Text == "")
                {
                    MessageBox.Show("Por favor preencha o campo CEP!", "OPH", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtCep.Focus();
                    return false;
                }
                if (txtEndereco.Text == "")
                {
                    MessageBox.Show("Por favor preencha o campo Endereço!", "OPH", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtEndereco.Focus();
                    return false;
                }
                if (txtBairro.Text == "")
                {
                    MessageBox.Show("Por favor preencha o campo Bairro!", "OPH", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtBairro.Focus();
                    return false;
                }
                if (txtCidade.Text == "")
                {
                    MessageBox.Show("Por favor preencha o campo Cidade!", "OPH", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtCidade.Focus();
                    return false;
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        #endregion

        #region "Eventos"
        private void FrmCadastroDeClientes_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Fechar();
        }
        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Fechar();
        }
        private void btnGravarCliente_Click(object sender, EventArgs e)
        {
            GravarCliente();
        }
        private void FrmCadastroDeClientes_KeyDown(object sender, KeyEventArgs e)
        {
            if (ModifierKeys == Keys.Control && e.KeyCode == Keys.S) GravarCliente();
        }
        private void FrmCadastroDeClientes_Shown(object sender, EventArgs e)
        {
            NovoCliente();
        }
        private void tgBtnAtivarDesativarCliente_ToggleStateChanged(object sender, Syncfusion.Windows.Forms.Tools.ToggleStateChangedEventArgs e)
        {
            VerificaStatusCliente();
        }
        private void btnAdicionarNovoCliente_Click(object sender, EventArgs e)
        {
            NovoCliente();
        }
        #endregion
    }
}
