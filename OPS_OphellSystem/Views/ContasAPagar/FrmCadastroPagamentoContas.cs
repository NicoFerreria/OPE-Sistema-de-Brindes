using System;
using System.Linq;
using Cadastros.Modelos;
using Cadastros.Controles;
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
        private void NovoLoad()
        {
            try
            {
                CarregaCombos();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "OPH", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void CarregaCombos()
        {
            try
            {
                FormasPagamentoControle formaPagamento = new FormasPagamentoControle();
                cmbFormasPagamento.DataSource = null;
                cmbFormasPagamento.DataSource = formaPagamento.ListarFormasPagamento();
                cmbFormasPagamento.DisplayMember = "Descricao";
                cmbFormasPagamento.ValueMember = "FormasPafamentoId";
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"OPH",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
        #endregion

        #region "Eventos"
        private void FrmCadastroPagamentoContas_Shown(object sender, EventArgs e)
        {
            NovoLoad();
        }
        private void txtValorConta_KeyPress(object sender, KeyPressEventArgs e)
        {
            utilitarios.PermitirApenasNumeros(sender, e, true);
        }
        #endregion

        
    }
}
