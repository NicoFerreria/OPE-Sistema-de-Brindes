using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OPS_OphellSystem.Cadastros.Classes;

namespace OPS_OphellSystem.Cadastros.Views.Fornecedores
{
    public partial class FrmCadastroDeFornecedores : Form
    {
        #region "Classes"
        private Cadastros.Classes.Fornecedor.CadastroDeFornecedor cadastro = new Classes.Fornecedor.CadastroDeFornecedor();
        #endregion

        #region "Metodos"
        public FrmCadastroDeFornecedores()
        {
            InitializeComponent();
        }
        private void Fechar()
        {
            if (this.Visible == true)
            {
                this.Hide();
            }
        }
        private void Gravar()
        {
            try
            {
                if (ValidaCampos() == false) return;
                cadastro.CNPJ = long.Parse(txtCnpj.Text + txtDv.Text);
                cadastro.DigitoVerificador = int.Parse(txtDv.Text);
                cadastro.Fantasia = utilitarios.RemoveCaracteresEspeciais(txtNomeFantasia.Text);
                cadastro.Razao = utilitarios.RemoveCaracteresEspeciais(txtRazaoSocial.Text);
                cadastro.CEP = int.Parse(txtCep.Text);
                cadastro.Endereco = utilitarios.RemoveCaracteresEspeciais(txtEndereco.Text);
                cadastro.Numero = int.Parse(txtNumero.Text);
                cadastro.Complemento = utilitarios.RemoveCaracteresEspeciais(txtComplemento.Text);
                cadastro.Bairro = utilitarios.RemoveCaracteresEspeciais(txtBairro.Text);
                cadastro.Cidade = utilitarios.RemoveCaracteresEspeciais(txtCidade.Text);
                cadastro.NomeContato = utilitarios.RemoveCaracteresEspeciais(txtNomeContato.Text);
                cadastro.EmailContato = utilitarios.RemoveCaracteresEspeciais(txtEmail.Text);
                cadastro.Telefone = int.Parse(txtTelefone.Text);
                cadastro.Observacoes = utilitarios.RemoveCaracteresEspeciais(txtObservacao.Text);
                cadastro.StatusFornecedor = tgBtnStatus.ToggleState == Syncfusion.Windows.Forms.Tools.ToggleButtonState.Active ? 1 : 0;
                cadastro.Terceiro = chkTerceiro.CheckState == CheckState.Checked ? 1 : 0;
                cadastro.GravarFornecedor();
                NovoFornecedor();
                MessageBox.Show("Operação realizada com sucesso!", "OPH", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "OPH", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void NovoFornecedor()
        {
            try
            {
                txtId.Text = "";
                txtCnpj.Text = "";
                txtDv.Text = "";
                chkTerceiro.Checked = false;
                txtNomeFantasia.Text = "";
                txtRazaoSocial.Text = "";
                txtCep.Text = "";
                txtEndereco.Text = "";
                txtNumero.Text = "";
                txtComplemento.Text = "";
                txtBairro.Text = "";
                txtCidade.Text = "";
                txtNomeContato.Text = "";
                txtEmail.Text = "";
                txtTelefone.Text = "";
                txtObservacao.Text = "";
                tgBtnStatus.ToggleState = Syncfusion.Windows.Forms.Tools.ToggleButtonState.Active;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "OPH", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void VerificaStatusFornecedor()
        {
            try
            {
                if (tgBtnStatus.ToggleState == Syncfusion.Windows.Forms.Tools.ToggleButtonState.Active)
                {
                    pnlDadosGerais.Enabled = true;
                }
                else
                {
                    pnlDadosGerais.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "OPH", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void CarregaFornecedorSelecionado()
        {
            try
            {
                VerificaStatusFornecedor();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "OPH", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void AtivarDesativarFornecedor()
        {
            try
            {
                if (tgBtnStatus.ToggleState == Syncfusion.Windows.Forms.Tools.ToggleButtonState.Active)
                {
                    tgBtnStatus.ToggleState = Syncfusion.Windows.Forms.Tools.ToggleButtonState.Inactive;
                }
                else
                {
                    tgBtnStatus.ToggleState = Syncfusion.Windows.Forms.Tools.ToggleButtonState.Inactive;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "OPH", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
        #endregion

        #region "Funções"
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
                if (txtDv.Text == "")
                {
                    MessageBox.Show("Por favor preencha o campo dígito verificador do CNPJ!", "OPH", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtDv.Focus();
                    return false;
                }
                if (Int64.TryParse(txtCnpj.Text, out long cnpj) == false)
                {
                    MessageBox.Show("O CNPJ está em um formato incorreto!", "OPH", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtCnpj.Focus();
                    return false;
                }
                if (int.TryParse(txtDv.Text, out int dv) == false)
                {
                    MessageBox.Show("O dígito verificador do CNPJ está em um formato incorreto!", "OPH", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtDv.Focus();
                    return false;
                }
                if (utilitarios.ValidaCnpj(txtCnpj.Text, txtDv.Text) == false)
                {
                    MessageBox.Show("O CNPJ está inválido! Por favor verifique o mesmo.", "OPH", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtCnpj.Focus();
                    return false;
                }
                if (txtNomeFantasia.Text == "")
                {
                    MessageBox.Show("Por favor preencha o Nome Fantasia!", "OPH", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtNomeFantasia.Focus();
                    return false;
                }
                if (txtRazaoSocial.Text == "")
                {
                    MessageBox.Show("Por favor preencha a Razão Social!", "OPH", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtRazaoSocial.Focus();
                    return false;
                }

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "OPH", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        #endregion

        #region "Eventos"
        private void FrmCadastroDeFornecedores_KeyDown(object sender, KeyEventArgs e)
        {
            if (ModifierKeys == Keys.Control && e.KeyCode == Keys.N) NovoFornecedor();
            if (ModifierKeys == Keys.Control && e.KeyCode == Keys.S) Gravar();            
            if (e.KeyCode == Keys.F2) AtivarDesativarFornecedor();
            if (e.KeyCode == Keys.Escape) Fechar();
        }
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
        private void tgBtnStatus_ToggleStateChanged(object sender, Syncfusion.Windows.Forms.Tools.ToggleStateChangedEventArgs e)
        {
            VerificaStatusFornecedor();
        }
        private void txtCnpj_KeyPress(object sender, KeyPressEventArgs e)
        {
            utilitarios.PermitirApenasNumeros(sender, e);
        }
        private void txtDv_KeyPress(object sender, KeyPressEventArgs e)
        {
            utilitarios.PermitirApenasNumeros(sender, e);
        }
        private void txtCep_KeyPress(object sender, KeyPressEventArgs e)
        {
            utilitarios.PermitirApenasNumeros(sender, e);
        }
        private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            utilitarios.PermitirApenasNumeros(sender, e);
        }
        private void txtTelefone_KeyPress(object sender, KeyPressEventArgs e)
        {
            utilitarios.PermitirApenasNumeros(sender, e);
        }
        private void txtCnpj_TextChanged(object sender, EventArgs e)
        {
            if (txtCnpj.Text.Length == 12)
            {
                txtDv.Focus();
            }
        }
        private void btnNovoFornecedor_Click(object sender, EventArgs e)
        {
            NovoFornecedor();
        }
        private void btnGravar_Click(object sender, EventArgs e)
        {
            Gravar();
        }
        #endregion       

        
    }
}
