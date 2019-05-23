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
        Cadastros.Views.Clientes.FrmCadastroDeClientes cadastroClientes;
        Cadastros.Views.CategoriasDeProdutos.FrmCadastroDeCategorias cadastroCategorias;
        Cadastros.Views.Fornecedores.FrmCadastroDeFornecedores cadastroFornecedores;
        Cadastros.Views.Operadores.FrmCadastroDeOperadores cadastroOperadores;
        Cadastros.Views.CondicoesDePagamento.FrmCadastroDeCondicoesDePagamento cadastroDeCondicoesPagamento;
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
                cadastroClientes = new Cadastros.Views.Clientes.FrmCadastroDeClientes();
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
                    cadastroFornecedores = new Cadastros.Views.Fornecedores.FrmCadastroDeFornecedores();
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

                cadastroOperadores.MdiParent = this;
                cadastroOperadores.Dock = DockStyle.Fill;
                cadastroOperadores.Show();
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

            cadastroDeCondicoesPagamento.MdiParent = this;
            cadastroDeCondicoesPagamento.Dock = DockStyle.Fill;
            cadastroDeCondicoesPagamento.Show();
        }
        #endregion

        #region "Funções"
        #endregion

        #region "Eventos"
        private void tStrpBtnCadastroClientes_Click(object sender, EventArgs e)
        {
            AbrirCadastroClientes();
        }
        private void btnCadastroCategoria_Click(object sender, EventArgs e)
        {
            AbrirCadastroDeCategoria();
        }
        private void btnCadastrarFornecedores_Click(object sender, EventArgs e)
        {
            AbrirCadastroDeFornecedores();
        }
        private void btnCadastroOperadores_Click(object sender, EventArgs e)
        {
            AbrirCadastroDeOperadores();
        }
        private void bntCadastroDeCondicaoPagamento_Click(object sender, EventArgs e)
        {
            AbrirCadastroDePagamentos();
        }
        #endregion


    }
}
