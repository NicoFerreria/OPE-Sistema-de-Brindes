using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OPS_OphellSystem.Cadastros.Views.Clientes
{
    public partial class FrmCadastroDeClientes : Form
    {
        #region "Classes"
        Cadastros.Classes.Clientes.CadastroDeClientes cadastroCLiente = new Classes.Clientes.CadastroDeClientes();
        #endregion

        #region"Variaveis"
        #endregion

        #region "Metodos"
        public FrmCadastroDeClientes()
        {
            InitializeComponent();
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
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region "Funcoes"
        private bool ValidaCampos()
        {
            try
            {
                return true;
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        #endregion

        #region "Eventos"
        private void FrmCadastroDeClientes_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Fechar();
        }
        #endregion
    }
}
