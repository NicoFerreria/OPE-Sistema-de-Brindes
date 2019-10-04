using System;
using System.Data;
using System.Windows.Forms;
using Cadastros.Modelos;
using Cadastros.Controles;

namespace OPS_OphellSystem.Cadastros.Views.CondicoesDePagamento
{
    public partial class FrmCadastroDeCondicoesDePagamento : Form
    {
        #region "Classes"
        FormasPagamentoControle cadastro = new FormasPagamentoControle();
        #endregion

        #region "Metodos"
        public FrmCadastroDeCondicoesDePagamento()
        {
            InitializeComponent();
            CriaColunasGrid();
        }
        private void CriaColunasGrid()
        {
            try
            {
                utilitarios.CriarColunasGrid(grdFormasPagamento, "id", "Código", TiposColunas.TEXTO, true, false, false);
                utilitarios.CriarColunasGrid(grdFormasPagamento, "descricao", "Descrição");
                utilitarios.CriarColunasGrid(grdFormasPagamento, "tipo", "Tipo");
                utilitarios.CriarColunasGrid(grdFormasPagamento, "status", "Ativo",TiposColunas.CHEK);

                grdFormasPagamento.AutoSizeColumnsMode = Syncfusion.WinForms.DataGrid.Enums.AutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "OPH", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void NovoForm()
        {
            try
            {
                NovoCadastro();
                CarregaComboTiposPagamento();
                CarregaListagem();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "OPH", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Fechar()
        {
            try
            {
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "OPH");
            }
        }
        private void CarregaComboTiposPagamento()
        {
            try
            {
                cmbTipo.Items.Clear();
                cmbTipo.Items.Add("BOLETO");
                cmbTipo.Items.Add("CREDITO");
                cmbTipo.Items.Add("DEBITO");
                cmbTipo.Items.Add("CHEQUE");
                cmbTipo.Items.Add("ESPECIE");
                cmbTipo.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "OPH", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void NovoCadastro()
        {
            txtCodigo.Text = "";
            txtDescricao.Text = "";
            cmbTipo.SelectedIndex = 0;
            tgBtnStatus.ToggleState = Syncfusion.Windows.Forms.Tools.ToggleButtonState.Active;            
            txtDescricao.Focus();
        }
        private void GravarFormaPagamento()
        {
            try
            {
                if (VerificaCampos() == false) return;
                FormaPagamentoModelo formaPagamento = ObterModelo();
                cadastro.GravarFormaPagamento(formaPagamento);                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "OPH", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            MessageBox.Show("Gravação concluída com sucesso!", "OPH", MessageBoxButtons.OK, MessageBoxIcon.Information);
            NovoCadastro();
            CarregaListagem();
        }
        private void ExcluirFormaPagamento()
        {
            try
            {
                if (MessageBox.Show("Deseja realmente excluir esta forma de pagamento?", "OPH",MessageBoxButtons.YesNo,MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2) == DialogResult.No) return ;

                if (VerificaCampos() == false) return;
                FormaPagamentoModelo formaPagamento = ObterModelo();
                cadastro.ExcluiFormaPagamento(formaPagamento);

                MessageBox.Show("Exclusão realizada com sucesso!", "OPH", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "OPH", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void CarregaListagem()
        {
            try
            {
                grdFormasPagamento.DataSource = null;
                grdFormasPagamento.DataSource = cadastro.GetAllFormasPagamento();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "OPH", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ObterDadosGrid()
        {
            try
            {
                DataRowView drLinha = grdFormasPagamento.SelectedItem as DataRowView;
                if(drLinha != null)
                {
                    txtCodigo.Text = drLinha["id"].ToString();
                    txtDescricao.Text = drLinha["descricao"].ToString();
                    cmbTipo.Text = drLinha["tipo"].ToString();
                    tgBtnStatus.ToggleState = drLinha["status"].ToString() == "true" ? Syncfusion.Windows.Forms.Tools.ToggleButtonState.Active : Syncfusion.Windows.Forms.Tools.ToggleButtonState.Inactive;
                }
                else
                {
                    NovoCadastro();
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "OPH", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void VerificaStatusCadastro()
        {
            try
            {
                if(tgBtnStatus.ToggleState == Syncfusion.Windows.Forms.Tools.ToggleButtonState.Active)
                {
                    grpDadosFormaPagamento.Enabled = true;
                    
                }
                else
                {
                    grpDadosFormaPagamento.Enabled = false;
                    
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "OPH", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region "Funcoes"
        private bool VerificaCampos()
        {
            try
            {
                if (txtDescricao.Text == "")
                {
                    MessageBox.Show("Por favor preencha o campo descrição!", "OPH", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtDescricao.Focus();
                    return false;
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "OPH", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return true;
        }
        private FormaPagamentoModelo ObterModelo()
        {
            FormaPagamentoModelo formaPagamento = new FormaPagamentoModelo();
            try
            {
                formaPagamento.FormasPafamentoId = txtCodigo.Text != "" ? long.Parse(txtCodigo.Text) : 0;
                formaPagamento.Descricao = utilitarios.RemoveCaracteresEspeciais(txtDescricao.Text);
                formaPagamento.Tipo = cmbTipo.Text;
                formaPagamento.Tipo = cmbTipo.Text;
                formaPagamento.Status = (tgBtnStatus.ToggleState == Syncfusion.Windows.Forms.Tools.ToggleButtonState.Active);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "OPH", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return formaPagamento;
        }        
        #endregion


        #region "Eventos"
        private void FrmCadastroDeCondicoesDePagamento_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Fechar();
        }
        private void FrmCadastroDeCondicoesDePagamento_Shown(object sender, EventArgs e)
        {
            NovoForm();
        }
        private void btnGravar_Click(object sender, EventArgs e)
        {
            GravarFormaPagamento();            
        }
        private void btnNovaCondicaoDePagamento_Click(object sender, EventArgs e)
        {
            NovoCadastro();
        }
        private void grdFormasPagamento_CellDoubleClick(object sender, Syncfusion.WinForms.DataGrid.Events.CellClickEventArgs e)
        {
            ObterDadosGrid();
        }
        private void tgBtnStatus_ToggleStateChanged(object sender, Syncfusion.Windows.Forms.Tools.ToggleStateChangedEventArgs e)
        {
            VerificaStatusCadastro();
        }
        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "C:\\Users\\Nicolas\\Documents\\Projetos\\OphellSB\\OPS_OphellSystem\\OPS_OphellSystem\\Resources\\Help.chm");
        }
    }
}
