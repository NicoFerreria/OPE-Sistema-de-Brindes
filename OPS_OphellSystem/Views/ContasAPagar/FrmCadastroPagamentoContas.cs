using System;
using System.Linq;
using Modelos;
using Cadastros.Controles;
using System.Windows.Forms;
using OPS_OphellSystem;

namespace Views
{
    public partial class FrmCadastroPagamentoContas : Form
    {
        FrmBuscaFornecedor formBuscaFornecedor;
        FornecedorModelo Fornecedor;
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

        private void button1_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "C:\\Users\\Nicolas\\Documents\\Projetos\\OphellSB\\OPS_OphellSystem\\OPS_OphellSystem\\Resources\\Help.chm");
        }

        private void btnFornecedor_Click(object sender, EventArgs e)
        {
            if (formBuscaFornecedor == null) formBuscaFornecedor = new FrmBuscaFornecedor();
            formBuscaFornecedor.ShowDialog();
            Fornecedor = formBuscaFornecedor.Fornecedor;
            if (Fornecedor == null)
            {
                // MessageBox.Show("Erro ao obter Fornecedor, Verifique o Cadastro!", "OPH", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            txtId.Text = Fornecedor.FornecedorId.ToString();
            txtFornecedor.Text = Fornecedor.Fantasia;
        }
    }
    }

