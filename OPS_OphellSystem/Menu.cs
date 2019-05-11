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
        public Menu()
        {
            InitializeComponent();
        }
        Cadastros.Views.Clientes.FrmCadastroDeClientes cadastroClientes;
        Cadastros.Views.CategoriasDeProdutos.FrmCadastroDeCategorias cadastroCategorias;
        public void AbrirCadastroClientes()
        {
            if(cadastroClientes == null)
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
                if(cadastroCategorias == null)
                {
                    cadastroCategorias = new Cadastros.Views.CategoriasDeProdutos.FrmCadastroDeCategorias();
                }
                cadastroCategorias.MdiParent = this;
                cadastroCategorias.Dock = DockStyle.Fill;
                cadastroCategorias.Show();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "OPH", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void tStrpBtnCadastroClientes_Click(object sender, EventArgs e)
        {
            AbrirCadastroClientes();
        }
        private void btnCadastroCategoria_Click(object sender, EventArgs e)
        {
            AbrirCadastroDeCategoria();
        }
    }
}
