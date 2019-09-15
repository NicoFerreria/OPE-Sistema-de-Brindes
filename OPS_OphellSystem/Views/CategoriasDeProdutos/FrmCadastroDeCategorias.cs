using System;
using OPS_OphellSystem.Cadastros.Classes.CategoriasDeProdutos;
using System.Windows.Forms;
using Cadastros.Modelos;
using Cadastros.Controles;

namespace OPS_OphellSystem.Cadastros.Views.CategoriasDeProdutos
{
    public partial class FrmCadastroDeCategorias : Form
    {
        #region "Classes"
        CadastroDeCategorias cadastroCategoria = new CadastroDeCategorias();
        FrmBuscaCategoriaProduto telaPesquisa;
        #endregion

        #region "Metodos"
        public FrmCadastroDeCategorias()
        {
            InitializeComponent();
            CriaColunasGrid();
        }
        private void NovoForm()
        {
            try
            {
                CarregarCombos();
                AtivaDesativaProduto();
                NovoProduto();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "OPH", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void CriaColunasGrid()
        {
            try
            {
                utilitarios.CriarColunasGrid(grdListagemProdutos, "id", "ID", TiposColunas.TEXTO, true, false, false);
                utilitarios.CriarColunasGrid(grdListagemProdutos, "codigo", "Código");
                utilitarios.CriarColunasGrid(grdListagemProdutos, "nome", "Nome");
                utilitarios.CriarColunasGrid(grdListagemProdutos, "descricao", "Descrição");
                utilitarios.CriarColunasGrid(grdListagemProdutos, "status", "Status",TiposColunas.CHEK);
                utilitarios.CriarColunasGrid(grdListagemProdutos, "observacao", "Observação");

                grdListagemProdutos.AutoSizeColumnsMode = Syncfusion.WinForms.DataGrid.Enums.AutoSizeColumnsMode.Fill;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "OPH", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
                MessageBox.Show(ex.Message, "OPH", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void CarregarCombos()
        {
            try
            {
                cmbCor.Items.Clear();
                cmbCor.Items.Add("Azul");
                cmbCor.Items.Add("Preto");
                cmbCor.Items.Add("Branco");
                cmbCor.Items.Add("Amarelo");
                cmbCor.Items.Add("Vermelho");
                cmbCor.Items.Add("Verde");
                cmbCor.Items.Add("Laranja");
                cmbCor.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "OPH", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void AtivaDesativaProduto()
        {
            try
            {
                if (tgBtnStatus.ToggleState == Syncfusion.Windows.Forms.Tools.ToggleButtonState.Active)
                {
                    grpDadosCategoria.Enabled = true;
                    btnGravar.Enabled = true;
                }
                else
                {
                    grpDadosCategoria.Enabled = false;
                    btnGravar.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "OPH", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void NovoProduto()
        {
            try
            {
                txtId.Text = string.Empty;
                txtCodigoCategria.Text = string.Empty;
                txtCategoria.Text = string.Empty;
                cmbCor.SelectedIndex = 0;
                txtDescricao.Text = string.Empty;
                txtObservacao.Text = string.Empty;
                btnGravar.Enabled = true;
                tgBtnStatus.ToggleState = Syncfusion.Windows.Forms.Tools.ToggleButtonState.Active;
                txtCodigoCategria.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "OPH", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void CarregaCamposCategoriaCadastrada()
        {
            try
            {
                if (txtCodigoCategria.Text == string.Empty)
                {
                    return;
                }
                else
                {
                    cadastroCategoria.CodigoCategoria = int.Parse(txtCodigoCategria.Text);
                }
                if(cadastroCategoria.ConsultaCategoriaProcudoPeloCodigo() == true)
                {
                    txtId.Text = cadastroCategoria.ID.ToString();
                    txtCategoria.Text = cadastroCategoria.Categoria;
                    txtDescricao.Text = cadastroCategoria.Descricao;
                    cmbCor.Text = cadastroCategoria.Cor;
                    txtObservacao.Text = cadastroCategoria.Observacao;
                    if(cadastroCategoria.Status == 1)
                    {
                        tgBtnStatus.ToggleState = Syncfusion.Windows.Forms.Tools.ToggleButtonState.Active;
                    }
                    else
                    {
                        tgBtnStatus.ToggleState = Syncfusion.Windows.Forms.Tools.ToggleButtonState.Inactive;
                    }

                }
                
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "OPH", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region "Eventos"
        private void FrmCadastroDeCategorias_FormClosing(object sender, FormClosingEventArgs e)
        {
            Fechar();
            e.Cancel = true;
        }
        
        private void GravarCategoria()
        {
            try
            {
                if (ValidaCampos() == false)
                {
                    return;
                }
                ProdutoModelo produto = new ProdutoModelo();
                produto.ProdutoID = txtId.Text == string.Empty ? 0 : int.Parse(txtId.Text);                
                produto.Codigo = int.Parse(txtCodigoCategria.Text);
                produto.Nome = txtCategoria.Text;
                produto.Descricao = txtDescricao.Text;
                produto.Observacao = txtObservacao.Text;
                produto.Cor = cmbCor.Text;
                produto.Status = (tgBtnStatus.ToggleState == Syncfusion.Windows.Forms.Tools.ToggleButtonState.Active);                
                ProdutoControle cadastro = new ProdutoControle(produto);
                cadastro.GravarProduto();
                MessageBox.Show("Operação realizada com sucesso!", "OPH", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "OPH", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void AbreTelaPesquisa()
        {
            if(telaPesquisa == null)
            {
                telaPesquisa = new FrmBuscaCategoriaProduto();
            }
            telaPesquisa.ShowDialog();
        }
        #endregion

        #region "Funcoes"
        private bool ValidaCampos()
        {
            try
            {
                if (txtCodigoCategria.Text == string.Empty)
                {
                    MessageBox.Show("O campo Código não pode estar vazio!", "OPH", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtCodigoCategria.Focus();
                    return false;
                }
                if(int.Parse(txtCodigoCategria.Text) <= 0)
                {
                    MessageBox.Show("O Código da categoria não pode ser menor ou igual a 0!", "OPH", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtCodigoCategria.Focus();
                    return false;
                }
                if (txtCategoria.Text == string.Empty)
                {
                    MessageBox.Show("O campo Categoria não pode estar vazio!", "OPH", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtCategoria.Focus();
                    return false;
                }
                if (txtDescricao.Text == string.Empty)
                {
                    MessageBox.Show("O campo Descrição não pode estar vazio!", "OPH", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtDescricao.Focus();
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
        private void FrmCadastroDeCategorias_Shown(object sender, EventArgs e)
        {
            NovoForm();
        }
        private void btnGravar_Click(object sender, EventArgs e)
        {
            GravarCategoria();
        }
        private void tgBtnStatus_ToggleStateChanged(object sender, Syncfusion.Windows.Forms.Tools.ToggleStateChangedEventArgs e)
        {
            AtivaDesativaProduto();
        }
        private void btnNovoProduto_Click(object sender, EventArgs e)
        {
            NovoProduto();
        }
        private void txtCodigoCategria_KeyPress(object sender, KeyPressEventArgs e)
        {
            utilitarios.PermitirApenasNumeros(sender, e);
        }
        private void txtCodigoCategria_TextChanged(object sender, EventArgs e)
        {
            CarregaCamposCategoriaCadastrada();
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            AbreTelaPesquisa();
        }
        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Fechar();
        }
        #endregion


    }
}
