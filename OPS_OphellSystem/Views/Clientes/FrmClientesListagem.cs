using System;
using System.Data;
using System.Windows.Forms;
using Modelos;
using Cadastros.Controles;
using OPS_OphellSystem;
using System.Collections.Generic;

namespace Views
{
    public partial class FrmClientesListagem : Form
    {
        #region "Variaveis"
        FrmCadastroDeClientes cadastrarCliente = new FrmCadastroDeClientes();
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
                utilitarios.CriarColunasGrid(grdClienteListagem, "ClienteId", "ID", TiposColunas.TEXTO, true,false,false);
                utilitarios.CriarColunasGrid(grdClienteListagem, "CNPJ", "CNPJ");
                utilitarios.CriarColunasGrid(grdClienteListagem, "DigitoVerificadorCnpj", "DV");
                utilitarios.CriarColunasGrid(grdClienteListagem, "Fantasia", "Fantasia");
                utilitarios.CriarColunasGrid(grdClienteListagem, "Razao", "Razão");
                utilitarios.CriarColunasGrid(grdClienteListagem, "Status", "Ativo", TiposColunas.CHEK);
                utilitarios.CriarColunasGrid(grdClienteListagem, "Endereco", "Endereco");
                utilitarios.CriarColunasGrid(grdClienteListagem, "Numero", "Número");
                utilitarios.CriarColunasGrid(grdClienteListagem, "Complemento", "Complemento");
                utilitarios.CriarColunasGrid(grdClienteListagem, "Cidade", "Cidade");
                utilitarios.CriarColunasGrid(grdClienteListagem, "Bairro", "Bairro");
                utilitarios.CriarColunasGrid(grdClienteListagem, "CEP", "CEP");
                utilitarios.CriarColunasGrid(grdClienteListagem, "Telefone", "Telefone");
                utilitarios.CriarColunasGrid(grdClienteListagem, "NomeContato", "Contato");
                utilitarios.CriarColunasGrid(grdClienteListagem, "Email", "E-mail");
                utilitarios.CriarColunasGrid(grdClienteListagem, "Observacao", "Observação");
                utilitarios.CriarColunasGrid(grdClienteListagem, "OperadorId", "Operador ID");
                utilitarios.CriarColunasGrid(grdClienteListagem, "OperadorNome", "Operador"); 
                utilitarios.CriarColunasGrid(grdClienteListagem, "Datahora", "Ultima Alteração");

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

                //DataRowView linha = ObterDadosDaGrid();

                //ClienteModelo cliente = new ClienteModelo();
                //if (cadastrarCliente == null)
                //{
                //    cadastrarCliente = new FrmCadastroDeClientes();
                //}
                //if (linha != null)
                //{
                //    cadastrarCliente.IdCliente = long.Parse(linha["id_clt"].ToString());
                //    cliente = cadastroCliente.GetCliente(long.Parse(linha["id_clt"].ToString()));
                //}

                if (ObterDadosDaGrid() == null) return;
                cadastrarCliente.Cliente = ObterDadosDaGrid();
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
                if (ObterDadosDaGrid() == null) return;
                ClienteModelo cliente = ObterDadosDaGrid();
                cliente.Excluido = true;
                cadastroCliente.ExcluirCliente(cliente);
                CarregaListagem();
                //if(grdClienteListagem.DataSource == null)
                //{
                //    MessageBox.Show("Selecione um registro para excluir!","OPH",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                //    return;
                //}
                //if (MessageBox.Show("Deseja realmente excluir este cliente?", "OPH", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                //    MessageBoxDefaultButton.Button2) == DialogResult.No) return;

                //DataRowView drLinha = ObterDadosDaGrid();
                //if(drLinha != null)
                //{
                //    //cadastroCliente.ExcluirCliente();
                //    MessageBox.Show("Cliente excluído com sucesso!", "OPH", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //    CarregaListagem();
                //}
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"OPH",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
        #endregion

        #region "Funcoes"
        private ClienteModelo ObterDadosDaGrid()
        {  
            if(grdClienteListagem.DataSource != null)
            {
                ClienteModelo cliente = (ClienteModelo)grdClienteListagem.SelectedItem;
                return cliente;
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
