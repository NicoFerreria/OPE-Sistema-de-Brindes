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
using Views;

namespace OPS_OphellSystem
{
    public partial class Menu : Form
    {
        #region "Classes"
        #endregion

        #region "Variaveis"
        FrmClientesListagem  cadastroClientes;
        FrmCadastroDeCategorias cadastroCategorias;
        FrmFornecedorListagem cadastroFornecedores;
        FrmCadastroDeOperadores cadastroOperadores;
        FrmCadastroDeCondicoesDePagamento cadastroDeCondicoesPagamento;
        FrmCadastroPagamentoContas cadastroDeContasAPagar;
        FrmCadastroRecebimentoContas cadastroDeContasAReceber;
        FrmOrcamento orcamento;
        FrmCadastroPerfil perfil;
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
                cadastroClientes = new FrmClientesListagem();
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
                    cadastroCategorias = new FrmCadastroDeCategorias();
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
                    cadastroFornecedores = new FrmFornecedorListagem();
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
                    cadastroOperadores = new FrmCadastroDeOperadores();
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
                cadastroDeCondicoesPagamento = new FrmCadastroDeCondicoesDePagamento();
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
                    cadastroDeContasAPagar = new FrmCadastroPagamentoContas();
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
                    orcamento = new FrmOrcamento();
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
                    cadastroDeContasAReceber = new FrmCadastroRecebimentoContas();
                }
                cadastroDeContasAReceber.ShowDialog();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "OPH", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void AbrirCadastroDePerfil()
        {
            try
            {
                if(perfil == null)
                {
                    perfil = new FrmCadastroPerfil();
                }

                perfil.ShowDialog();
            }catch(Exception ex)
            {
                throw new System.Exception(ex.Message);
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
        private void btnMenuCadPerfil_Click(object sender, EventArgs e)
        {
            AbrirCadastroDePerfil();
        }
        #endregion


    }
}
