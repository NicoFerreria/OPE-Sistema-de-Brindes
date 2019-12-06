using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OPS_OphellSystem;
using Modelos;
using Cadastros.Controles;

namespace Views
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

            //CriarColunasGrid();
        }
        private void CriarColunasGrid()
        {
            try
            {
                utilitarios.CriarColunasGrid(grdFornecedorListagem, "FornecedorId", "ID", TiposColunas.TEXTO, true, false, false, false);                
                utilitarios.CriarColunasGrid(grdFornecedorListagem, "Fantasia", "Fantasia");
                utilitarios.CriarColunasGrid(grdFornecedorListagem, "Razao", "Razão");
                utilitarios.CriarColunasGrid(grdFornecedorListagem, "CNPJ", "CNPJ");
                utilitarios.CriarColunasGrid(grdFornecedorListagem, "InscricaoEstadual", "IE");
                utilitarios.CriarColunasGrid(grdFornecedorListagem, "Status", "Ativo",TiposColunas.CHEK);
                utilitarios.CriarColunasGrid(grdFornecedorListagem, "Terceiro", "Tipo", TiposColunas.CHEK);
                utilitarios.CriarColunasGrid(grdFornecedorListagem, "Endereco", "Endereco");
                utilitarios.CriarColunasGrid(grdFornecedorListagem, "Numero", "Numero");
                utilitarios.CriarColunasGrid(grdFornecedorListagem, "Complemento", "Complemento");
                utilitarios.CriarColunasGrid(grdFornecedorListagem, "Cidade", "Cidade");
                utilitarios.CriarColunasGrid(grdFornecedorListagem, "Bairro", "Bairro");
                utilitarios.CriarColunasGrid(grdFornecedorListagem, "CEP", "CEP");
                utilitarios.CriarColunasGrid(grdFornecedorListagem, "Telefone", "Telefone");
                utilitarios.CriarColunasGrid(grdFornecedorListagem, "NomeContato", "Contato");
                utilitarios.CriarColunasGrid(grdFornecedorListagem, "Email", "Email");
                utilitarios.CriarColunasGrid(grdFornecedorListagem, "PlanoDeContas1", "Plano de Contas 1", TiposColunas.TEXTO);
                utilitarios.CriarColunasGrid(grdFornecedorListagem, "PlanoDeContas2", "Plano de Contas 2", TiposColunas.TEXTO);
                utilitarios.CriarColunasGrid(grdFornecedorListagem, "PlanoDeContas3", "Plano de Contas 3", TiposColunas.TEXTO);
                utilitarios.CriarColunasGrid(grdFornecedorListagem, "PlanoDeContas4", "Plano de Contas 4", TiposColunas.TEXTO);
                utilitarios.CriarColunasGrid(grdFornecedorListagem, "Observacao", "Observação");
                utilitarios.CriarColunasGrid(grdFornecedorListagem, "DigitoVerificadorCnpj", "DV",TiposColunas.TEXTO,false,false,false);
                

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
            try
            {
                grdFornecedorListagem.DataSource = null;
                grdFornecedorListagem.DataSource = controle.GetListaFornecedores(txtPesquisa.Text);
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "OPH", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
                
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
                grdFornecedorListagem.DataSource = null;
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
                if (grdFornecedorListagem.DataSource == null){
                    MessageBox.Show("Selecione pelo menos um registro para exclusão!","OPH",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                    return;
                }
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

                FornecedorModelo drLinha = (FornecedorModelo)grdFornecedorListagem.SelectedItem;
                if(drLinha != null)
                {
                    cadastroFornecedores.FornecedorID = drLinha.FornecedorId;
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

        private void button1_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "C:\\Users\\Nicolas\\Documents\\Projetos\\OphellSB\\OPS_OphellSystem\\OPS_OphellSystem\\Resources\\Help.chm");
        }
    }
}
