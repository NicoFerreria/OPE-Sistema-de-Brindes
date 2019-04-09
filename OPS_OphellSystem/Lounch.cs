using System;
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
    public partial class Lounch : Form
    {
        public Lounch()
        {
            InitializeComponent();
        }

        void testeBancoDeDados()
        {
            DataTable dtDados = new DataTable();
            utilitarios.RealizaConexaoBd("INSERT INTO testecrud(teste)VALUES('texto de teste')");
            dtDados = utilitarios.RealizaConexaoBd("SELECT teste FROM testecrud WHERE id='2'");
            label1.Text = dtDados.Rows[0]["teste"].ToString();
        }

        private void Lounch_Load(object sender, EventArgs e)
        {
            testeBancoDeDados();
        }
    }
}
