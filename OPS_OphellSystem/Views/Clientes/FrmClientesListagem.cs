using System;
using System.Data;
using System.Windows.Forms;
using Cadastros.Modelos;
using Cadastros.Controles;

namespace OPS_OphellSystem.Cadastros.Views.Clientes
{
    public partial class FrmClientesListagem : Form
    {
        #region "Variaveis"
        Cadastros.Views.Clientes.FrmCadastroDeClientes cadastrarCliente = new FrmCadastroDeClientes();
        ClienteControle cadastroCliente = new ClienteControle();
        #endregion 

        #region "Metodos"
        public FrmClientesListagem()
        {
            InitializeComponent();
            CriaColunasGrid();
        }
        public void Fechar()
        {
            if (this.Visible == true)
            {
                this.Hide();
            }
        }
        public void NovoForm()
        {
            try
            {
                txtPesquisa.Text = "";
                grdClienteListagem.DataSource = null;
                txtPesquisa.Select();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "OPH", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void AdicionarCliente()
        {
            try
            {
                cadastrarCliente.IdCliente = 0;                
                cadastrarCliente.ShowDialog();                
                txtPesquisa.Focus();
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
                utilitarios.CriarColunasGrid(grdClienteListagem, "id_clt", "ID", TiposColunas.TEXTO, true,false,false);
                utilitarios.CriarColunasGrid(grdClienteListagem, "cnpj_clt", "CNPJ");
                utilitarios.CriarColunasGrid(grdClienteListagem, "digito_verificador", "DV");
                utilitarios.CriarColunasGrid(grdClienteListagem, "nome_fantasia_clt", "Fantasia");
                utilitarios.CriarColunasGrid(grdClienteListagem, "razao_social_clt", "Razão");
                utilitarios.CriarColunasGrid(grdClienteListagem, "status_clt", "Ativo", TiposColunas.CHEK);
                utilitarios.CriarColunasGrid(grdClienteListagem, "endereco_clt", "Endereco");
                utilitarios.CriarColunasGrid(grdClienteListagem, "numero_clt", "Número");
                utilitarios.CriarColunasGrid(grdClienteListagem, "complemento_clt", "Complemento");
                utilitarios.CriarColunasGrid(grdClienteListagem, "cidade", "Cidade");
                utilitarios.CriarColunasGrid(grdClienteListagem, "bairro", "Bairro");
                utilitarios.CriarColunasGrid(grdClienteListagem, "cep", "CEP");
                utilitarios.CriarColunasGrid(grdClienteListagem, "telefone_clt", "Telefone");
                utilitarios.CriarColunasGrid(grdClienteListagem, "nome_contato_clt", "Contato");
                utilitarios.CriarColunasGrid(grdClienteListagem, "email_contato_clt", "E-mail");
                utilitarios.CriarColunasGrid(grdClienteListagem, "observacao_clt", "Observação");
                utilitarios.CriarColunasGrid(grdClienteListagem, "operador_cadastro_id", "Operador ID");
                utilitarios.CriarColunasGrid(grdClienteListagem, "operador_cadastro_nome", "Operador");
                utilitarios.CriarColunasGrid(grdClienteListagem, "datahora_cadastro", "Data Cadastro");
                utilitarios.CriarColunasGrid(grdClienteListagem, "datahora_alteracao", "Data Alteração");

                grdClienteListagem.AutoSizeColumnsMode = Syncfusion.WinForms.DataGrid.Enums.AutoSizeColumnsMode.AllCells;
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
                grdClienteListagem.DataSource = null;
                grdClienteListagem.DataSource = cadastroCliente.BuscaCliente(txtPesquisa.Text);                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "OPH", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void EditarCliente()
        {
            try
            {
                DataRowView linha = ObterDadosDaGrid();
                ClienteModelo cliente = new ClienteModelo();
                if (cadastrarCliente == null)
                {
                    cadastrarCliente = new FrmCadastroDeClientes();
                }
                if (linha != null)
                {
                    cadastrarCliente.IdCliente = long.Parse(linha["id_clt"].ToString());
                    cliente = cadastroCliente.GetCliente(long.Parse(linha["id_clt"].ToString()));
                }

                cadastrarCliente.ShowDialog();
                //grdClienteListagem.DataSource = null;
                //grdClienteListagem.DataSource = cadastroCliente.BuscaCliente(cliente.ClienteId.ToString());
                CarregaListagem();
                txtPesquisa.Focus();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "OPH", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ExcluirCliente()
        {
            try
            {
                if(grdClienteListagem.DataSource == null)
                {
                    MessageBox.Show("Selecione um registro para excluir!","OPH",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                    return;
                }
                if (MessageBox.Show("Deseja realmente excluir este cliente?", "OPH", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2) == DialogResult.No) return;

                DataRowView drLinha = ObterDadosDaGrid();
                if(drLinha != null)
                {
                    cadastroCliente.ExcluirCliente(long.Parse(drLinha["id_clt"].ToString()));
                    MessageBox.Show("Cliente excluído com sucesso!", "OPH", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CarregaListagem();
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"OPH",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
        #endregion

        #region "Funcoes"
        private DataRowView ObterDadosDaGrid()
        {
            DataRowView drLinha = grdClienteListagem.SelectedItem as DataRowView;
            if(drLinha != null)
            {
                return drLinha;
            }
            return null;
        }
        #endregion

        #region "Eventos"
        private void FrmClientesListagem_Shown(object sender, EventArgs e)
        {
            NovoForm();
        }
        private void FrmClientesListagem_VisibleChanged(object sender, EventArgs e)
        {
            NovoForm();
        }
        private void btnFechar_Click(object sender, EventArgs e)
        {
            Fechar();
        }        
        private void btnAdicionar_Click(object sender, EventArgs e)
        {

            AdicionarCliente();
        }        
        private void txtPesquisa_KeyDown(object sender, KeyEventArgs e)
        {
           if(e.KeyCode == Keys.Enter) CarregaListagem();
        }
        private void grdClienteListagem_CellDoubleClick(object sender, Syncfusion.WinForms.DataGrid.Events.CellClickEventArgs e)
        {
            EditarCliente();
        }
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            ExcluirCliente();
        }
        private void grdClienteListagem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete) ExcluirCliente();
        }
        #endregion


    }
}
