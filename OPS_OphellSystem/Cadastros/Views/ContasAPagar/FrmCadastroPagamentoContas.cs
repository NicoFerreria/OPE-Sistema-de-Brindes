using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OPS_OphellSystem.Cadastros.Views.ContasAPagar
{
    public partial class FrmCadastroPagamentoContas : Form
    {
        #region "Metodos"
        public FrmCadastroPagamentoContas()
        {
            InitializeComponent();
            CriaColunasGrid();
        }
        private void CriaColunasGrid()
        {
            try
            {

                utilitarios.CriarColunasGrid(grdContas, "ContaId", "Id", TiposColunas.TEXTO, true, false, false);
                utilitarios.CriarColunasGrid(grdContas, "DataLancamento", "Data Lançamento");
                utilitarios.CriarColunasGrid(grdContas, "DataVencimento", "Data Vencimento");
                utilitarios.CriarColunasGrid(grdContas, "Valor", "Valor",TiposColunas.NUMERICO);
                utilitarios.CriarColunasGrid(grdContas, "GestorId", "Id Setor",TiposColunas.TEXTO,false,false,false);


                grdContas.AutoSizeColumnsMode = Syncfusion.WinForms.DataGrid.Enums.AutoSizeColumnsMode.Fill;
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "OPH", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region "Eventos"
        private void txtValorConta_KeyPress(object sender, KeyPressEventArgs e)
        {
            utilitarios.PermitirApenasNumeros(sender, e, true);
        }
        #endregion

    }
}
