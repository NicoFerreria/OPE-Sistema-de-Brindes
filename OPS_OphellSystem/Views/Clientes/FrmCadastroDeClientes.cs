using System;
using Cadastros.Modelos;
using Cadastros.Controles;
using System.Windows.Forms;

namespace OPS_OphellSystem.Cadastros.Views.Clientes
{
    public partial class FrmCadastroDeClientes : Form
    {
        #region "Classes"
        ClienteControle cadastroCLiente = new ClienteControle();
        #endregion

        #region"Variaveis"
        public long IdCliente { get; set; } = 0;
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
                //utilitarios.ValidaCnpj("114447770001","00"); 
                if (ValidaCampos() == false) return;
                ClienteModelo cliente = new ClienteModelo();

                cliente.ClienteId = long.Parse(txtIdCliente.Text);
                cliente.CNPJ = txtCnpj.Text;
                cliente.DigitoVerificadorCnpj = txtDigitoVerificador.Text;
                cliente.Fantasia = utilitarios.RemoveCaracteresEspeciais(txtNomeFantaisa.Text);
                cliente.Razao = utilitarios.RemoveCaracteresEspeciais(txtRazaoSocial.Text);
                cliente.CEP = int.Parse(txtCep.Text);
                cliente.Endereco = utilitarios.RemoveCaracteresEspeciais(txtEndereco.Text);
                cliente.Numero = int.Parse(txtNumero.Text);
                cliente.Bairro = utilitarios.RemoveCaracteresEspeciais(txtBairro.Text);
                cliente.Cidade = utilitarios.RemoveCaracteresEspeciais(txtCidade.Text);
                cliente.NomeContato = utilitarios.RemoveCaracteresEspeciais(txtNomeContato.Text);
                cliente.Email  = txtEmail.Text;
                cliente.Telefone = int.Parse(txtTelefone.Text);
                cliente.Complemento = utilitarios.RemoveCaracteresEspeciais(txtComplemento.Text);
                cliente.Status = (tgBtnAtivarDesativarCliente.ToggleState == Syncfusion.Windows.Forms.Tools.ToggleButtonState.Active);
                cliente.Observacao = utilitarios.RemoveCaracteresEspeciais(txtObservacao.Text);

                cadastroCLiente.GravarCliente(cliente);

                MessageBox.Show("Operação realizada com sucesso!", "OPH", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
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
                txtObservacao.Text = "";
                txtDigitoVerificador.Text = "";
                tgBtnAtivarDesativarCliente.ToggleState = Syncfusion.Windows.Forms.Tools.ToggleButtonState.Active;
                txtCnpj.Focus();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "OPH", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void VerificaStatusCliente()
        {
            try
            {
                if (tgBtnAtivarDesativarCliente.ToggleState == Syncfusion.Windows.Forms.Tools.ToggleButtonState.Active)
                {
                    grpDadosCliente.Enabled = true;
                    btnAdicionarNovoCliente.Enabled = true;
                    btnGravarCliente.Enabled = true;
                    txtCnpj.Focus();
                }
                else
                {
                    grpDadosCliente.Enabled = false;
                    btnAdicionarNovoCliente.Enabled = false;
                    //btnGravarCliente.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "OPH", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void PreencheCamposFormulario()
        {
            try
            {
                ClienteModelo cliente = cadastroCLiente.GetCliente(IdCliente);

                if(cliente != null)
                {
                    txtIdCliente.Text = cliente.ClienteId.ToString();
                    txtCnpj.Text = cliente.CNPJ;
                    txtDigitoVerificador.Text = cliente.DigitoVerificadorCnpj;
                    txtNomeFantaisa.Text = cliente.Fantasia;
                    txtRazaoSocial.Text = cliente.Razao;
                    txtCep.Text = cliente.CEP.ToString();
                    txtEndereco.Text = cliente.Endereco;
                    txtNumero.Text = cliente.Numero.ToString();
                    txtComplemento.Text = cliente.Complemento;
                    txtBairro.Text = cliente.Bairro;
                    txtCidade.Text = cliente.Cidade;
                    txtNomeContato.Text = cliente.NomeContato;
                    txtEmail.Text = cliente.Email;
                    txtTelefone.Text = cliente.Telefone.ToString();
                    txtObservacao.Text = cliente.Observacao;
                    tgBtnAtivarDesativarCliente.ToggleState = cliente.Status ? Syncfusion.Windows.Forms.Tools.ToggleButtonState.Active : Syncfusion.Windows.Forms.Tools.ToggleButtonState.Inactive;
                }
                else
                {
                    NovoCliente();
                }
                if(cliente.ClienteId == 0)
                {
                    tgBtnAtivarDesativarCliente.ToggleState = Syncfusion.Windows.Forms.Tools.ToggleButtonState.Active;
                }
                //VerificaStatusCliente();

            }
            catch (Exception ex)
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
                if (double.TryParse(txtCnpj.Text, out double rsult) == false)
                {
                    MessageBox.Show("CNPJ informado está em um formato incorreto!", "OPH", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtCnpj.Focus();
                    return false;
                }
                if(txtCnpj.Text.Length < 12)
                {
                    MessageBox.Show("CNPJ inválido! Verifique a quantidade de dítos.", "OPH", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtCnpj.Focus();
                    return false;
                }
                if(txtDigitoVerificador.Text == "")
                {
                    MessageBox.Show("Dígito verificador do CNPJ está em branco","OPH",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                    txtDigitoVerificador.Focus();
                    return false;
                }
                if(int.TryParse(txtDigitoVerificador.Text, out int result) == false)
                {
                    MessageBox.Show("Dígito verificador do CNPJ é inválido!", "OPH", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtDigitoVerificador.Focus();
                    return false;
                }
                if(txtDigitoVerificador.Text.Length < 2)
                {
                    MessageBox.Show("Dígito verificador do CNPJ inválido! Verifique a quantidade de dígitos.", "OPH", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtDigitoVerificador.Focus();
                    return false;
                }
                if(utilitarios.ValidaCnpj(txtCnpj.Text,txtDigitoVerificador.Text) == false)
                {
                    MessageBox.Show("CNPJ inválido!", "OPH", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
                if (int.TryParse(txtCep.Text, out int retono) == false)
                {
                    MessageBox.Show("CEP informado está no formato incorreto!", "OPH", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
                if(txtNumero.Text == "")
                {
                    if(MessageBox.Show("O campo número está vazio! Deseja Continuar?","OPH",MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                        MessageBoxDefaultButton.Button2) == DialogResult.No)
                    {
                        txtNumero.Focus();
                        return false;
                    }
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
        private void FrmCadastroDeClientes_KeyDown(object sender, KeyEventArgs e)
        {
            if (ModifierKeys == Keys.Control && e.KeyCode == Keys.S) GravarCliente();
            if (ModifierKeys == Keys.Control && e.KeyCode == Keys.N) NovoCliente();
            if (e.KeyCode == Keys.Escape) Fechar();
        }
        private void FrmCadastroDeClientes_Shown(object sender, EventArgs e)
        {
            //NovoCliente();
            PreencheCamposFormulario();
        }        
        private void btnGravarCliente_Click(object sender, EventArgs e)
        {
            GravarCliente();
        }        
        private void tgBtnAtivarDesativarCliente_ToggleStateChanged(object sender, Syncfusion.Windows.Forms.Tools.ToggleStateChangedEventArgs e)
        {
            VerificaStatusCliente();
        }
        private void btnAdicionarNovoCliente_Click(object sender, EventArgs e)
        {
            NovoCliente();
        }
        private void txtCnpj_KeyPress(object sender, KeyPressEventArgs e)
        {
            utilitarios.PermitirApenasNumeros(sender, e);
        }
        private void txtCep_KeyPress(object sender, KeyPressEventArgs e)
        {
            utilitarios.PermitirApenasNumeros(sender, e);
        }
        private void txtTelefone_KeyPress(object sender, KeyPressEventArgs e)
        {
            utilitarios.PermitirApenasNumeros(sender, e);
        }
        private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            utilitarios.PermitirApenasNumeros(sender, e);
        }
        private void txtCnpj_TextChanged(object sender, EventArgs e)
        {
            if (txtCnpj.Text.Length == 12)
            {
                txtDigitoVerificador.Focus();
            }
        }
        private void FrmCadastroDeClientes_VisibleChanged(object sender, EventArgs e)
        {
            PreencheCamposFormulario();
        }

        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "C:\\Users\\Nicolas\\Documents\\Projetos\\OphellSB\\OPS_OphellSystem\\OPS_OphellSystem\\Resources\\Help.chm");
        }
    }
}
