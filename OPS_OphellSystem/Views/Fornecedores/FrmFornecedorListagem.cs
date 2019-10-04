using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cadastros.Modelos;
using Cadastros.Controles;

namespace OPS_OphellSystem.Cadastros.Views.Fornecedores
{
    public partial class FrmFornecedorListagem : Form
    {
        #region "Classes"
        FornecedorControle controle = new FornecedorControle();
        FrmCadastroDeFornecedores cadastroFornecedores = new FrmCadastroDeFornecedores();
        #endregion

        #region "Variaveis"
        #endregion

        #region "Metodos"
        public FrmFornecedorListagem()
        {
            InitializeComponent();

            CriarColunasGrid();
        }
        private void CriarColunasGrid()
        {
            try
            {
                utilitarios.CriarColunasGrid(grdFornecedorListagem, "id", "ID", TiposColunas.TEXTO, true, false, false, false);
                utilitarios.CriarColunasGrid(grdFornecedorListagem, "cnpj", "CNPJ");
                utilitarios.CriarColunasGrid(grdFornecedorListagem, "fantasia", "Fantasia");
                utilitarios.CriarColunasGrid(grdFornecedorListagem, "razao", "Razão");
                utilitarios.CriarColunasGrid(grdFornecedorListagem, "status", "Ativo",TiposColunas.CHEK);
                utilitarios.CriarColunasGrid(grdFornecedorListagem, "endereco", "Endereco");
                utilitarios.CriarColunasGrid(grdFornecedorListagem, "numero", "Numero");
                utilitarios.CriarColunasGrid(grdFornecedorListagem, "complemento", "Complemento");
                utilitarios.CriarColunasGrid(grdFornecedorListagem, "cidade", "Cidade");
                utilitarios.CriarColunasGrid(grdFornecedorListagem, "bairro", "Bairro");
                utilitarios.CriarColunasGrid(grdFornecedorListagem, "cep", "CEP");
                utilitarios.CriarColunasGrid(grdFornecedorListagem, "telefone", "Telefone");
                utilitarios.CriarColunasGrid(grdFornecedorListagem, "contato", "Contato");
                utilitarios.CriarColunasGrid(grdFornecedorListagem, "email", "Email");
                utilitarios.CriarColunasGrid(grdFornecedorListagem, "observacao", "Observação");
                utilitarios.CriarColunasGrid(grdFornecedorListagem, "digito_verificador", "DV",TiposColunas.TEXTO,false,false,false);

                grdFornecedorListagem.AutoSizeColumnsMode = Syncfusion.WinForms.DataGrid.Enums.AutoSizeColumnsMode.AllCells;

            }
            catch(Exception ex)
            {
                throw new System.Exception(ex.Message);
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
        private void CarregaListagem()
        {            
                grdFornecedorListagem.DataSource = null;
                grdFornecedorListagem.DataSource = controle.GetListaFornecedores(txtPesquisa.Text);            
        }
        private void NovoFornecedor()
        {
            try
            {
                if (cadastroFornecedores == null)
                {
                    cadastroFornecedores = new FrmCadastroDeFornecedores();
                }
                cadastroFornecedores.FornecedorID = 0;
                cadastroFornecedores.ShowDialog();
                CarregaListagem();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "OPH", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ExcluirFornecedor()
        {
            try
            {
                if (MessageBox.Show("Tem certeza de que deseja excluir este fornecedor?", "OPH", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2) == DialogResult.No) return;

                DataRowView drLinha = ObterDadosGrid();
                if(drLinha != null)
                {
                    if(controle.DeleteFornecedor(long.Parse(drLinha["id"].ToString())) == true)
                    {
                        MessageBox.Show("Fornecedor excluído com sucesso!", "OPH", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CarregaListagem();
                    }
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "OPH", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void EditarFornecedor()
        {
            try
            {
                if(cadastroFornecedores == null)
                {
                    cadastroFornecedores = new FrmCadastroDeFornecedores();
                }

                DataRowView drLinha = grdFornecedorListagem.SelectedItem as DataRowView;
                if(drLinha != null)
                {
                    cadastroFornecedores.FornecedorID = long.Parse(drLinha["id"].ToString());
                }
                cadastroFornecedores.ShowDialog();

                CarregaListagem();
                txtPesquisa.Focus();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"OPH",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
        #endregion

        #region "Funcoes"
        private DataRowView ObterDadosGrid()
        {
            try
            {
                DataRowView drLinha = grdFornecedorListagem.SelectedItem as DataRowView;
                
                if(drLinha != null)
                {
                    return drLinha;
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "OPH", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return null;
        }
        #endregion

        #region "Eventos"
        private void txtPesquisa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) CarregaListagem();
        }
        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            NovoFornecedor();
        }
        private void btnFechar_Click(object sender, EventArgs e)
        {
            Fechar();
        }
        private void grdFornecedorListagem_CellDoubleClick(object sender, Syncfusion.WinForms.DataGrid.Events.CellClickEventArgs e)
        {
            EditarFornecedor();
        }
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            ExcluirFornecedor();
        }
        #endregion


    }
}
