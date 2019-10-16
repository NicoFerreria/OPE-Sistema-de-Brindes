using System;
using Syncfusion.Windows.Forms;
using System.IO;
using System.Drawing;
using System.Windows.Forms;
using OPS_OphellSystem.Cadastros.Classes.Operadores;
using System.Collections.Generic;

namespace OPS_OphellSystem
{
    public partial class Lounch : Form
    {
        #region "Classes"
        GeradorBD gerador = new GeradorBD();
        #endregion

        #region "Variaveis"
        Menu telaMenu;
        #endregion

        #region "Metodos"
        public Lounch()
        {
            InitializeComponent();
            //TesteGit
        }
        private void Placeholders()
        {
            try
            {

                BannerTextInfo placeholderSenha = bnTxtOperador.GetBannerText(txtSenha);
                placeholderSenha.Text = "Senha";
                placeholderSenha.Visible = true;
                placeholderSenha.Color = Color.Black;
                placeholderSenha.Mode = BannerTextMode.FocusMode;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void AbrirTelaMenu()
        {
            if (telaMenu == null)
            {
                telaMenu = new Menu();
            }
            CadastroDeOperadores operador = new CadastroDeOperadores();
           
            if (mCmbOperadores.SelectedValue != null)
            {
                operador = operador.GetOperador(int.Parse(mCmbOperadores.SelectedValue.ToString()));
                if (operador.Senha == txtSenha.Text)
                {
                    SessaoUsuario.ID = long.Parse(operador.OperadorId.ToString());
                    SessaoUsuario.Nome = operador.Nome;
                    SessaoUsuario.Senha = int.Parse(operador.Senha);
                    SessaoUsuario.Perfil = operador.Perfil;
                    txtSenha.Text = "";
                    this.Hide();
                    telaMenu.ShowDialog();
                    this.Show();
                }
                else
                {
                    MessageBox.Show("Senha de Operador Incorreta!", "OPH", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtSenha.Text = "";
                    txtSenha.Focus();
                    return;
                }
            }
            else
            {
                SessaoUsuario.ID = 9999;
                SessaoUsuario.Nome = "LOGIN DE INSTALACAO";
                SessaoUsuario.Senha = 0;
                SessaoUsuario.Perfil = "SISTEMA";
                txtSenha.Text = "";
                this.Hide();
                telaMenu.ShowDialog();
                this.Show();
            }
        }
        private void VerificaBanco()
        {
            try
            {
                gerador.CriaBd(pgbLoadSistema);
            }
            catch (Exception ex)
            {
                pgbLoadSistema.Visible = false;
                MessageBox.Show(ex.Message, "OPH", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void CarregaComboOperadores()
        {
            try
            {
                CadastroDeOperadores operador = new CadastroDeOperadores();
                string[,] dadosOperador = new string[operador.GetAllOperadoresAtivos().Count, 3];
                mCmbOperadores.ListBox.Grid.ResizeColsBehavior = Syncfusion.Windows.Forms.Grid.GridResizeCellsBehavior.None;
                Syncfusion.Windows.Forms.Grid.GridColHidden OperadorId = new Syncfusion.Windows.Forms.Grid.GridColHidden(1);
                Syncfusion.Windows.Forms.Grid.GridColHidden Contas = new Syncfusion.Windows.Forms.Grid.GridColHidden(5);
                Syncfusion.Windows.Forms.Grid.GridColHidden Senha = new Syncfusion.Windows.Forms.Grid.GridColHidden(6);
                Syncfusion.Windows.Forms.Grid.GridColHidden ContraSenha = new Syncfusion.Windows.Forms.Grid.GridColHidden(7);
                Syncfusion.Windows.Forms.Grid.GridColHidden CPF = new Syncfusion.Windows.Forms.Grid.GridColHidden(8);
                Syncfusion.Windows.Forms.Grid.GridColHidden Status = new Syncfusion.Windows.Forms.Grid.GridColHidden(9);

                mCmbOperadores.DataSource = null;
                mCmbOperadores.DataSource = operador.GetAllOperadoresAtivos();

                mCmbOperadores.Columns.Clear();
                mCmbOperadores.ListBox.Grid.ColHiddenEntries.Add(OperadorId);
                mCmbOperadores.ListBox.Grid.ColHiddenEntries.Add(Contas);
                mCmbOperadores.ListBox.Grid.ColHiddenEntries.Add(Senha);
                mCmbOperadores.ListBox.Grid.ColHiddenEntries.Add(ContraSenha);
                mCmbOperadores.ListBox.Grid.ColHiddenEntries.Add(CPF);
                mCmbOperadores.ListBox.Grid.ColHiddenEntries.Add(Status);


                mCmbOperadores.ValueMember = "OperadorId";
                mCmbOperadores.DisplayMember = "Nome";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "OPH", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void AberturaSistema()
        {
            try
            {
                VerificaBanco();

                this.Enabled = false;

                CarregaComboOperadores();
                HabilitarDesabilitarCampos();

                this.Enabled = true;

            }
            catch (Exception ex)
            {
                this.Enabled = true;
                MessageBox.Show(ex.Message, "OPH", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void HabilitarDesabilitarCampos()
        {
            try
            {
                if (VerificarSeExisteUsuariosNoBanco() == false)
                {
                    mCmbOperadores.Enabled = false;
                    txtSenha.Enabled = false;
                }
                else
                {
                    mCmbOperadores.Enabled = true;
                    txtSenha.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "OPH", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region "Funcoes"
        private bool VerificarSeExisteUsuariosNoBanco()
        {
            try
            {
                CadastroDeOperadores operador = new CadastroDeOperadores();
                if (operador.GetAllOperadoresAtivos().Count <= 0)
                {
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
        private void Lounch_Load(object sender, EventArgs e)
        {
            Placeholders();
        }
        private void Lounch_Shown(object sender, EventArgs e)
        {
            AberturaSistema();
        }
        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            AbrirTelaMenu();
        }
        private void txtSenha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) AbrirTelaMenu();
        }
        #endregion    
    }
}
