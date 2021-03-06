﻿using System;
using OPS_OphellSystem.Cadastros.Classes.CategoriasDeProdutos;
using System.Windows.Forms;
using Modelos;
using Cadastros.Controles;
using System.Data;
using OPS_OphellSystem;

namespace Views
{
    public partial class FrmCadastroDeCategorias : Form
    {
        #region "Classes"
        ProdutoControle cadastro = new ProdutoControle();
        CadastroDeCategorias cadastroCategoria = new CadastroDeCategorias();        
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
                CarregarGrid();
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
                utilitarios.CriarColunasGrid(grdListagemProdutos, "cor", "Cor");
                utilitarios.CriarColunasGrid(grdListagemProdutos, "status", "Status", TiposColunas.CHEK);
                utilitarios.CriarColunasGrid(grdListagemProdutos, "observacao", "Observação");

                grdListagemProdutos.AutoSizeColumnsMode = Syncfusion.WinForms.DataGrid.Enums.AutoSizeColumnsMode.Fill;
                grdListagemProdutos.AllowFiltering = true;
            }
            catch (Exception ex)
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
                //Combo Cor
                cmbCor.Items.Clear();
                cmbCor.Items.Add("Azul");
                cmbCor.Items.Add("Preto");
                cmbCor.Items.Add("Branco");
                cmbCor.Items.Add("Amarelo");
                cmbCor.Items.Add("Vermelho");
                cmbCor.Items.Add("Verde");
                cmbCor.Items.Add("Laranja");
                cmbCor.SelectedIndex = 0;

                //Combo Pesquisa
                cmbCriterioPesquisa.Items.Clear();
                cmbCriterioPesquisa.Items.Add("Nome");
                cmbCriterioPesquisa.Items.Add("Descrição");
                cmbCriterioPesquisa.Items.Add("Cor");
                cmbCriterioPesquisa.SelectedIndex = 0;
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
        private void NovoProduto(bool limparCodigo = true)
        {
            try
            {
                if (limparCodigo == true) txtCodigoCategria.Text = string.Empty;
                txtId.Text = string.Empty;
                txtCategoria.Text = string.Empty;
                cmbCor.SelectedIndex = 0;
                cmbCriterioPesquisa.SelectedIndex = 0;
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
                ProdutoModelo produto = new ProdutoModelo();
                if (long.TryParse(txtCodigoCategria.Text, out long codigo))
                {
                    produto = cadastro.GetProduto(codigo);
                }
                if (produto.ProdutoID > 0)
                {
                    txtId.Text = produto.ProdutoID.ToString();
                    txtCategoria.Text = produto.Nome;
                    txtDescricao.Text = produto.Descricao;
                    cmbCor.Text = produto.Cor;
                    txtObservacao.Text = produto.Observacao;
                    tgBtnStatus.ToggleState = produto.Status ? Syncfusion.Windows.Forms.Tools.ToggleButtonState.Active : Syncfusion.Windows.Forms.Tools.ToggleButtonState.Inactive;
                }
                else
                {
                    NovoProduto(false);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "OPH", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void GravarCategoria()
        {
            try
            {
                if (ValidaCampos() == false) return;
                ProdutoModelo produto = ObterProdutoCarregado();
                cadastro.GravarProduto(produto);
                CarregarGrid();
                if (MessageBox.Show("Operação realizada com sucesso! Deseja gravar mais produtos?", "OPH", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                    NovoProduto();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "OPH", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }      
        private void CarregarGrid()
        {
            try
            {
                grdListagemProdutos.DataSource = null;
                grdListagemProdutos.DataSource = cadastro.RetornaDataTableTodosProdutos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "OPH", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void BuscaNaGrid()
        {
            try
            {
                if (txtFiltrar.Text == "")
                {
                    grdListagemProdutos.ClearFilters();
                    return;
                }
                string coluna = "";
                switch (cmbCriterioPesquisa.Text)
                {
                    case "Nome":
                        coluna = "nome";
                        break;
                    case "Descrição":
                        coluna = "descricao";
                        break;
                    case "Cor":
                        coluna = "cor";
                        break;
                }

                grdListagemProdutos.ClearFilters();
                grdListagemProdutos.Columns[coluna].FilterPredicates.Add(new Syncfusion.Data.FilterPredicate()
                {
                    FilterType = Syncfusion.Data.FilterType.Contains,
                    FilterValue = txtFiltrar.Text,
                    FilterBehavior = Syncfusion.Data.FilterBehavior.StronglyTyped
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "OPH", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void CapturaDadosGrid()
        {
            try
            {
                DataRowView drLinha = grdListagemProdutos.SelectedItem as DataRowView;
                if (drLinha != null)
                {
                    txtCodigoCategria.Text = drLinha["codigo"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "OPH", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ExcluirProduto()
        {
            try
            {
                DataRowView drLinha = grdListagemProdutos.SelectedItem as DataRowView;
                if (drLinha != null)
                {
                    if (MessageBox.Show("Tem certeza de que deseja excluir este produto?", "OPH", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                        MessageBoxDefaultButton.Button2) == DialogResult.No) return;
                    ProdutoModelo produto = new ProdutoModelo();
                    produto.ProdutoID = long.Parse(drLinha["id"].ToString());
                    produto.Nome = drLinha["nome"].ToString();
                    produto.Descricao = drLinha["descricao"].ToString();
                    produto.Codigo = long.Parse(drLinha["codigo"].ToString());
                    produto.Cor = drLinha["cor"].ToString();
                    produto.Observacao = drLinha["observacao"].ToString();
                    if (cadastro.ExcluirProduto(produto) == true)
                    {
                        MessageBox.Show("Produto excluído com sucesso!", "OPH", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CarregarGrid();
                        NovoProduto();
                    }
                }

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
                if (txtCodigoCategria.Text == string.Empty)
                {
                    MessageBox.Show("O campo Código não pode estar vazio!", "OPH", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtCodigoCategria.Focus();
                    return false;
                }
                if (int.Parse(txtCodigoCategria.Text) <= 0)
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
        private ProdutoModelo ObterProdutoCarregado()
        {
            ProdutoModelo produto = new ProdutoModelo();
            try
            {
                produto.ProdutoID = long.TryParse(txtId.Text, out long id) ? id : 0;
                produto.Codigo = long.TryParse(txtCodigoCategria.Text, out long codigo) ? codigo : 0;
                produto.Nome = txtCategoria.Text;
                produto.Descricao = txtDescricao.Text;
                produto.Observacao = txtObservacao.Text;
                produto.Cor = cmbCor.Text;
                produto.Status = (tgBtnStatus.ToggleState == Syncfusion.Windows.Forms.Tools.ToggleButtonState.Active);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "OPH", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return produto;
        }
        #endregion

        #region "Eventos"
        private void FrmCadastroDeCategorias_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.N && e.Modifiers == Keys.Control) NovoProduto();
            if (e.KeyCode == Keys.S && e.Modifiers == Keys.Control) GravarCategoria();
            if (e.KeyCode == Keys.Escape) Fechar();
            if (e.KeyCode == Keys.F8) cadastro.ExcluirProduto(ObterProdutoCarregado());
        }
        private void FrmCadastroDeCategorias_Shown(object sender, EventArgs e)
        {
            NovoForm();
        }
        private void FrmCadastroDeCategorias_FormClosing(object sender, FormClosingEventArgs e)
        {
            Fechar();
            e.Cancel = true;
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
            BuscaNaGrid();
        }
        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Fechar();
        }
        private void txtFiltrar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) BuscaNaGrid();
        }
        private void grdListagemProdutos_CellDoubleClick(object sender, Syncfusion.WinForms.DataGrid.Events.CellClickEventArgs e)
        {
            CapturaDadosGrid();
        }
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            cadastro.ExcluirProduto(ObterProdutoCarregado());
            CarregarGrid();
            NovoProduto();
        }
        private void grdListagemProdutos_CurrentCellKeyDown(object sender, Syncfusion.WinForms.DataGrid.Events.CurrentCellKeyEventArgs e)
        {
            var k = e.KeyEventArgs;
            if (k.KeyCode == Keys.Delete) ExcluirProduto();
        }
        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "C:\\Users\\Nicolas\\Documents\\Projetos\\OphellSB\\OPS_OphellSystem\\OPS_OphellSystem\\Resources\\Help.chm");
        }
    }
}
