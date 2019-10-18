using System;
using System.Windows.Forms;
using OPS_OphellSystem.Cadastros.Classes.Operadores;
using Cadastros.Controles;
using Cadastros.Modelos;

namespace OPS_OphellSystem.Cadastros.Views.Operadores
{
    public partial class FrmCadastroDeOperadores : Form
    {
        #region "Classes"

        #endregion

        #region "Metodos"
        public FrmCadastroDeOperadores()
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
        private void NovoCadastro()
        {
            txtId.Text = "";
            txtNome.Text = "";
            txtSobrenome.Text = "";
            txtCodigo.Text = "";
            txtSenha.Text = "";
            txtConfirmaSenha.Text = "";
            cmbPerfil.SelectedIndex = 0;
            tgBtnStaus.ToggleState = Syncfusion.Windows.Forms.Tools.ToggleButtonState.Active;
            txtNome.Focus();
        }
        private void NovoFormulario()
        {
            try
            {
                CarregaCombos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "OPH", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void CarregaCombos()
        {
            try
            {
                PerfilModelo perfil = new PerfilModelo();
                cmbPerfil.DataSource = null;
                cmbPerfil.DataSource = perfil.GetPerfis();
                cmbPerfil.DisplayMember = "Descricao";
                cmbPerfil.ValueMember = "PerfilId";
                //cmbPerfil.Items.Clear();
                //cmbPerfil.Items.Add("ADM");
                //cmbPerfil.SelectedIndex = 0;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "OPH", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void SalvarOperador()
        {
            try
            {
                if (ValidaCampos() == false) return;
                OperadorControle operadorControle = new OperadorControle();
                OperadorModelo operador = new OperadorModelo();

                operador.OperadroId = long.TryParse(txtId.Text, out long id) ? id : 0;
                operador.Nome = txtNome.Text;
                operador.Sobrenome = txtSobrenome.Text;
                operador.Status = (tgBtnStaus.ToggleState == Syncfusion.Windows.Forms.Tools.ToggleButtonState.Active);
                operador.Senha = utilitarios.RemoveCaracteresEspeciais(txtSenha.Text);
                operador.CPF = txtCpf.Text;
                operador.Codigo = int.TryParse(txtCodigo.Text, out int codigo) ? codigo : 0;
                operador.Perfil = new PerfilModelo() { PerfilId = long.Parse(cmbPerfil.ValueMember), Descricao = cmbPerfil.DisplayMember };

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "OPH", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void AtivarDesativarCadastro(Syncfusion.Windows.Forms.Tools.ToggleButtonState state)
        {
            try
            {
                if (state == Syncfusion.Windows.Forms.Tools.ToggleButtonState.Inactive)
                {
                    pnlDadosGerais.Enabled = false;
                }
                else
                {
                    pnlDadosGerais.Enabled = true;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "OPH", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void CarregaOperador(long id)
        {
            try
            {
                if (id <= 0)
                {
                    MessageBox.Show("Não foi possível carregar dados do operador!", "OPH", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
                CadastroDeOperadores operador = new CadastroDeOperadores();

                operador = operador.GetOperador(id);

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
                if (txtNome.Text == "")
                {
                    MessageBox.Show("Necessário preencher o campo Nome!", "OPH", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    txtNome.Focus();
                    return false;
                }

                if (txtSobrenome.Text == "")
                {
                    MessageBox.Show("Necessário preencher o campo Sobrenome!", "OPH", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    txtSobrenome.Focus();
                    return false;
                }
                if (txtCpf.Text == "")
                {
                    MessageBox.Show("Necessário preencher o campo CPF!", "OPH", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    txtCpf.Focus();
                    return false;
                }

                if (txtSenha.Text == "")
                {
                    MessageBox.Show("Necessário preencher o campo Senha!", "OPH", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    txtSenha.Focus();
                    return false;
                }
                if (txtSenha.Text != txtConfirmaSenha.Text)
                {
                    MessageBox.Show("A senha e a confirmação da senha não coincidem!", "OPH", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    txtSenha.Focus();
                    return false;
                }

                if (txtConfirmaSenha.Text == "")
                {
                    MessageBox.Show("Necessário preencher o campo Confirma Senha!", "OPH", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    txtConfirmaSenha.Focus();
                    return false;
                }

                if (long.TryParse(txtCpf.Text, out long cpf) == false)
                {
                    MessageBox.Show("CPF inválido!", "OPH", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    txtCpf.Focus();
                    return false;
                }
                if(cmbPerfil.Text == "")
                {
                    MessageBox.Show("Perfil inválido! Selecione ou cdastre um novo perfil.","OPH",MessageBoxButtons.OK,MessageBoxIcon.Stop);
                    cmbPerfil.Focus();
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
        private void FrmCadastroDeOperadores_Load(object sender, EventArgs e)
        {

        }
        private void FrmCadastroDeOperadores_Shown(object sender, EventArgs e)
        {
            CarregaCombos();
            NovoFormulario();
        }
        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Fechar();
        }
        private void btnGravar_Click(object sender, EventArgs e)
        {
            SalvarOperador();
            //MessageBox.Show("Operação realizada com sucesso!", "OPH", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //NovoCadastro();
        }
        private void txtCpf_KeyPress(object sender, KeyPressEventArgs e)
        {
            utilitarios.PermitirApenasNumeros(sender, e);
        }
        private void tgBtnStaus_ToggleStateChanged(object sender, Syncfusion.Windows.Forms.Tools.ToggleStateChangedEventArgs e)
        {
            AtivarDesativarCadastro(e.ToggleState);
        }
        private void btnNovoOperador_Click(object sender, EventArgs e)
        {
            NovoCadastro();
        }
        private void FrmCadastroDeOperadores_FormClosing(object sender, FormClosingEventArgs e)
        {
            Fechar();
        }
        #endregion


    }
}
