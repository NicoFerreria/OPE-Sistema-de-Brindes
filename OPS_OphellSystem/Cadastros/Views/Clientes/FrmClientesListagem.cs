using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modelos;
using Controles;

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
                if (cadastrarCliente == null)
                {
                    cadastrarCliente = new FrmCadastroDeClientes();
                }

                cadastrarCliente.ShowDialog();
                CarregaListagem();
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
                utilitarios.CriarColunasGrid(grdClienteListagem, "terceiro", "Terceiro", TiposColunas.CHEK);


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
                if (txtPesquisa.Text == "")
                {
                    grdClienteListagem.DataSource = cadastroCliente.ListarTodos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "OPH", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region "Eventos"
        private void btnFechar_Click(object sender, EventArgs e)
        {
            Fechar();
        }
        private void FrmClientesListagem_Shown(object sender, EventArgs e)
        {
            NovoForm();
        }
        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            AdicionarCliente();
        }
        private void FrmClientesListagem_VisibleChanged(object sender, EventArgs e)
        {
            txtPesquisa.Focus();
        }
        private void txtPesquisa_KeyDown(object sender, KeyEventArgs e)
        {
            CarregaListagem();
        }
        #endregion


    }
}
