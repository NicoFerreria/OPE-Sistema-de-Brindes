using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OPS_OphellSystem.Cadastros.Views.Orcamento
{
    public partial class FrmOrcamento : Form
    {

        #region "Metodos"
        public FrmOrcamento()
        {
            InitializeComponent();
        }
        private void Fechar()
        {
            try
            {
                if(this.Visible == true)
                {
                    this.Hide();
                }
            }catch(Exception ex)
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
        #endregion

    }
}
