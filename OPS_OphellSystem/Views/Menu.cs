using System;
using OPS_OphellSystem.Cadastros.Views;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OPS_OphellSystem
{
    public partial class Menu : Form
    {
        #region "Classes"
        #endregion

        #region "Variaveis"
        Cadastros.Views.Clientes.FrmClientesListagem  cadastroClientes;
        Cadastros.Views.CategoriasDeProdutos.FrmCadastroDeCategorias cadastroCategorias;
        Cadastros.Views.Fornecedores.FrmFornecedorListagem cadastroFornecedores;
        Cadastros.Views.Operadores.FrmCadastroDeOperadores cadastroOperadores;
        Cadastros.Views.CondicoesDePagamento.FrmCadastroDeCondicoesDePagamento cadastroDeCondicoesPagamento;
        Cadastros.Views.ContasAPagar.FrmCadastroPagamentoContas cadastroDeContasAPagar;
        Cadastros.Views.ContasAReceber.FrmCadastroRecebimentoContas cadastroDeContasAReceber;
        Cadastros.Views.Orcamento.FrmOrcamento orcamento;
        #endregion

        #region "Metodos"
        public Menu()
        {
            InitializeComponent();
        }
        public void AbrirCadastroClientes()
        {
            if (cadastroClientes == null)
            {
                cadastroClientes = new Cadastros.Views.Clientes.FrmClientesListagem();
            }

            cadastroClientes.MdiParent = this;
            cadastroClientes.Dock = DockStyle.Fill;
            cadastroClientes.Show();

        }
        public void AbrirCadastroDeCategoria()
        {
            try
            {
                if (cadastroCategorias == null)
                {
                    cadastroCategorias = new Cadastros.Views.CategoriasDeProdutos.FrmCadastroDeCategorias();
                }
                cadastroCategorias.MdiParent = this;
                cadastroCategorias.Dock = DockStyle.Fill;
                cadastroCategorias.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "OPH", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void AbrirCadastroDeFornecedores()
        {
            try
            {
                if (cadastroFornecedores == null)
                {
                    cadastroFornecedores = new Cadastros.Views.Fornecedores.FrmFornecedorListagem();
                }

                cadastroFornecedores.MdiParent = this;
                cadastroFornecedores.Dock = DockStyle.Fill;
                cadastroFornecedores.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "OPH", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void AbrirCadastroDeOperadores()
        {
            try
            {
                if (cadastroOperadores == null)
                {
                    cadastroOperadores = new Cadastros.Views.Operadores.FrmCadastroDeOperadores();
                }

                
                cadastroOperadores.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "OPH", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void AbrirCadastroDePagamentos()
        {
            if(cadastroDeCondicoesPagamento == null)
            {
                cadastroDeCondicoesPagamento = new Cadastros.Views.CondicoesDePagamento.FrmCadastroDeCondicoesDePagamento();
            }

            //cadastroDeCondicoesPagamento.MdiParent = this;
            //cadastroDeCondicoesPagamento.Dock = DockStyle.Fill;
            cadastroDeCondicoesPagamento.ShowDialog();
        }
        public void AbrirCadastroDeContasAPagar()
        {
            try
            {
                if(cadastroDeContasAPagar == null)
                {
                    cadastroDeContasAPagar = new Cadastros.Views.ContasAPagar.FrmCadastroPagamentoContas();
                }

                cadastroDeContasAPagar.ShowDialog();

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "OPH", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void OcultarBarraLateral()
        {
            try
            {
                Form frm = this.ActiveMdiChild;
                if(frm != null)
                {
                    tStrpCadastroClientes.Hide();
                }
                else
                {
                    tStrpCadastroClientes.Show();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "OPH", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void AbrirVendasOrcamento()
        {
            try
            {
                if (orcamento == null)
                {
                    orcamento = new Cadastros.Views.Orcamento.FrmOrcamento();
                }

                orcamento.MdiParent = this;
                orcamento.Dock = DockStyle.Fill;
                orcamento.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "OPH", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void AbrirCadastroDeContasAReceber()
        {
            try
            {
                if(cadastroDeContasAReceber == null)
                {
                    cadastroDeContasAReceber = new Cadastros.Views.ContasAReceber.FrmCadastroRecebimentoContas();
                }
                cadastroDeContasAReceber.ShowDialog();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "OPH", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region "Funções"
        #endregion

        #region "Eventos"
        private void Menu_Load(object sender, EventArgs e)
        {

        }
        private void Menu_MdiChildActivate(object sender, EventArgs e)
        {
            OcultarBarraLateral();
        }
        private void btnMenuCadFornecedores_Click(object sender, EventArgs e)
        {
            AbrirCadastroDeFornecedores();
        }
        private void btnMenuCadOperadores_Click(object sender, EventArgs e)
        {
            AbrirCadastroDeOperadores();
        }
        private void btnMenuCadClientes_Click(object sender, EventArgs e)
        {
            AbrirCadastroClientes();
        }
        private void btnMenuCadCategorias_Click(object sender, EventArgs e)
        {
            AbrirCadastroDeCategoria();
        }
        private void btnMenuCondicoesPagamento_Click(object sender, EventArgs e)
        {
            AbrirCadastroDePagamentos();
        }
        private void btnMenuCadastros_ButtonClick(object sender, EventArgs e)
        {
            btnMenuCadastros.ShowDropDown();
        }
        private void btnMenuContasPagar_Click(object sender, EventArgs e)
        {
            AbrirCadastroDeContasAPagar();
        }
        private void btnMenuVendas_ButtonClick(object sender, EventArgs e)
        {
            btnMenuVendas.ShowDropDown();
        }
        private void btnMenuOrcamento_Click(object sender, EventArgs e)
        {
            AbrirVendasOrcamento();
        }
        private void btnMenuContasReceber_Click(object sender, EventArgs e)
        {
            AbrirCadastroDeContasAReceber();
        }
        #endregion


    }
}
