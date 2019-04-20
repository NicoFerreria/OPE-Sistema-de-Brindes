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

        private void tStrpBtnCadastroClientes_Click(object sender, EventArgs e)
        {
            AbrirCadastroClientes();
        }
    }
}
