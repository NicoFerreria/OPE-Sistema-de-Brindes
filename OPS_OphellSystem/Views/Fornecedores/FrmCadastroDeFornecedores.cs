using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modelos;
using Cadastros.Controles;
using OPS_OphellSystem;
using OPS_OphellSystem.Modelos;

namespace Views
{
    public partial class FrmCadastroDeFornecedores : Form
    {
        #region "Classes"
        FornecedorControle controle = new FornecedorControle();        
        #endregion

        #region "Variaveis"
        public long FornecedorID { get; set; }

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
        private void NovoLoad()
        {
            try
            {
                //NovoFornecedor();
                CarregaFornecedorSelecionado();
                txtNomeFantasia.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "OPH", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Gravar()
        {
            try
            {
                FornecedorModelo fornecedor = new FornecedorModelo();
                if (ValidaCampos() == false) return;
                fornecedor.FornecedorId = long.TryParse(txtId.Text, out long fornId) ? fornId : 0;
                fornecedor.CNPJ = txtCnpj.Text;
                fornecedor.DigitoVerificadorCnpj = txtDv.Text;
                fornecedor.Fantasia = utilitarios.RemoveCaracteresEspeciais(txtNomeFantasia.Text);
                fornecedor.Razao = utilitarios.RemoveCaracteresEspeciais(txtRazaoSocial.Text);
                fornecedor.CEP = txtCep.Text;
                fornecedor.Endereco = utilitarios.RemoveCaracteresEspeciais(txtEndereco.Text);
                fornecedor.Numero = int.TryParse(txtNumero.Text, out int numero) ? numero : 0;
                fornecedor.Complemento = utilitarios.RemoveCaracteresEspeciais(txtComplemento.Text);
                fornecedor.Bairro = utilitarios.RemoveCaracteresEspeciais(txtBairro.Text);
                fornecedor.Cidade = utilitarios.RemoveCaracteresEspeciais(txtCidade.Text);
                fornecedor.NomeContato = utilitarios.RemoveCaracteresEspeciais(txtNomeContato.Text);
                fornecedor.Email = utilitarios.RemoveCaracteresEspeciais(txtEmail.Text);
                fornecedor.Telefone = int.TryParse(txtTelefone.Text, out int telefone) ? telefone : 0;
                fornecedor.Observacao = utilitarios.RemoveCaracteresEspeciais(txtObservacao.Text);
                fornecedor.Status = (tgBtnStatus.ToggleState == Syncfusion.Windows.Forms.Tools.ToggleButtonState.Active);
                fornecedor.Terceiro = (chkTerceiro.CheckState == CheckState.Checked);
                fornecedor.InscricaoEstadual = txtInscricaoEstadual.Text;
                if (controle.GravarFornecedor(fornecedor))
                {
                    NovoFornecedor();
                    MessageBox.Show("Operação realizada com sucesso!", "OPH", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
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
                txtInscricaoEstadual.Text = "";
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
                FornecedorModelo fornecedor = controle.GetFornecedorById(FornecedorID);

                if (fornecedor.FornecedorId != 0)
                {
                    txtId.Text = fornecedor.FornecedorId == 0 ? "" : fornecedor.FornecedorId.ToString();
                    txtCnpj.Text = fornecedor.CNPJ;
                    txtDv.Text = fornecedor.DigitoVerificadorCnpj;
                    txtDv.Text = fornecedor.DigitoVerificadorCnpj;
                    txtNomeFantasia.Text = fornecedor.Fantasia;
                    txtRazaoSocial.Text = fornecedor.Razao;
                    txtCep.Text = fornecedor.CEP;
                    txtEndereco.Text = fornecedor.Endereco;
                    txtNumero.Text = fornecedor.Numero == 0 ? "" : fornecedor.Numero.ToString();
                    txtComplemento.Text = fornecedor.Complemento;
                    txtBairro.Text = fornecedor.Bairro;
                    txtCidade.Text = fornecedor.Cidade;
                    txtNomeContato.Text = fornecedor.NomeContato;
                    txtEmail.Text = fornecedor.Email;
                    txtTelefone.Text = fornecedor.Telefone == 0 ? "" : fornecedor.Telefone.ToString();
                    txtObservacao.Text = fornecedor.Observacao;
                    tgBtnStatus.ToggleState = fornecedor.Status ? Syncfusion.Windows.Forms.Tools.ToggleButtonState.Active : Syncfusion.Windows.Forms.Tools.ToggleButtonState.Inactive;
                    chkTerceiro.CheckState = fornecedor.Terceiro ? CheckState.Checked : CheckState.Unchecked;
                    txtInscricaoEstadual.Text = fornecedor.InscricaoEstadual;
                    VerificaStatusFornecedor();
                }
                else
                {
                    NovoFornecedor();
                }
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "OPH", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void ObterDadosEndereco()
        {
            try
            {
                if (txtCep.Text != "")
                {
                    if (txtCep.Text.Length == 8)
                    {
                        Cep cep = utilitarios.ObterCep(txtCep.Text);
                        txtCep.Text = cep.CEP == null ? txtCep.Text : utilitarios.RemoveCaracteresEspeciais(cep.CEP);
                        txtEndereco.Text = cep.Logradouro;
                        txtBairro.Text = cep.Bairro;
                        txtComplemento.Text = cep.Complemento;
                        txtCidade.Text = cep.Localidade;
                        if(cep.CEP != null)
                        {
                            txtNumero.Focus();
                        }
                        else
                        {
                            txtEndereco.Focus();
                        }                        
                        return;
                    }
                }
                txtEndereco.Focus();
            }
            catch (Exception ex)
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
                if (txtCnpj.Text != "")
                {
                    if (long.TryParse(txtCnpj.Text, out long cnpj) == false)
                    {
                        MessageBox.Show("O CNPJ está em um formato incorreto!", "OPH", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txtCnpj.Focus();
                        return false;
                    }
                    else
                    {
                        if(txtCnpj.Text.Length < 12)
                        {
                            MessageBox.Show("O CNPJ está faltando dígitos!", "OPH", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            txtCnpj.Focus();
                            return false;
                        }
                    }

                    if (txtDv.Text == "")
                    {
                        MessageBox.Show("Por favor preencha o campo dígito verificador do CNPJ!", "OPH", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txtDv.Focus();
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
        private void FrmCadastroDeFornecedores_Shown(object sender, EventArgs e)
        {
            NovoLoad();
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
        private void txtInscricaoEstadual_KeyPress(object sender, KeyPressEventArgs e)
        {
            utilitarios.PermitirApenasNumeros(sender, e);
        }
        private void txtCep_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) ObterDadosEndereco();
        }
        #endregion


    }
}
