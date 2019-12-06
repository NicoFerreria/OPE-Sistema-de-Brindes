using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cadastros.Controles;
using Financeiro.Controles;
using Financeiro.Modelos;
using Modelos;
using OPS_OphellSystem;

namespace Views
{
    public partial class FrmCadastroRecebimentoContas : Form
    {
        FrmBuscaCliente formBuscaCliente;
        private ContasReceberModelo _pagamento;
        private List<ContaModelo> Contas = new List<ContaModelo>();
        private ClienteModelo Cliente;
        private ContasReceberControle controle = new ContasReceberControle();
        public FrmCadastroRecebimentoContas()
        {
            InitializeComponent();
            CriaColunasGrid();
        }
        private void NovoLoad()
        {
            try
            {
                LimpaFormulario();
                CarregaCombos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "OPH", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void CriaColunasGrid()
        {
            try
            {

                utilitarios.CriarColunasGrid(grdContas, "ContaId", "Id", TiposColunas.TEXTO, true, false, false);
                utilitarios.CriarColunasGrid(grdContas, "DataLancamento", "Data Lançamento");
                utilitarios.CriarColunasGrid(grdContas, "DataVencimento", "Data Vencimento");
                utilitarios.CriarColunasGrid(grdContas, "Valor", "Valor", TiposColunas.NUMERICO);
                utilitarios.CriarColunasGrid(grdContas, "GestorId", "Id Setor", TiposColunas.TEXTO, false, false, false);


                grdContas.AutoSizeColumnsMode = Syncfusion.WinForms.DataGrid.Enums.AutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "OPH", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LimpaFormulario()
        {
            txtId.Text = "";
            Cliente = null;
            txtFornecedor.Text = "";
            txtValorConta.Text = "";
            grdContas.DataSource = null;
            cmbFormasPagamento.SelectedIndex = 0;
            lblTotal.Text = "";
        }
        private void GravarConta()
        {
            try
            {
                //ContasPagarModelo conta = new ContasPagarModelo();
                double total = Contas.Sum(c => c.Valor);
                _pagamento.Cliente = Cliente;
                _pagamento.Contas = Contas;
                _pagamento.Total = total;
                _pagamento.FormaPagamento = (FormaPagamentoModelo)cmbFormasPagamento.SelectedItem;
                _pagamento.Duplicata = 1;

                controle.GravarPagamento(_pagamento);
                NovoLoad();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "OPH", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ObtemContas()
        {
            try
            {
                if (txtId.Text == "") return;
                if (Cliente != null)
                {
                    _pagamento = controle.GetConta(Cliente);
                    if (_pagamento.FormaPagamento != null)
                    {
                        cmbFormasPagamento.SelectedItem = _pagamento.FormaPagamento;
                    }
                    Contas = _pagamento.Contas;
                    CarregaListagemContas();
                    lblTotal.Text = Contas.Sum(c => c.Valor).ToString("C2");//conta.Total.ToString("C2");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "OPH", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void DeletaConta()
        {
            if (MessageBox.Show("Esta conta será excluída permanentemente. Deseja continuar?", "OPH", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2) == DialogResult.No) return;
            ContaModelo conta = grdContas.SelectedItem as ContaModelo;
            if (conta != null)
            {
                controle.DeletaConta(conta);
                ObtemContas();
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "OPH", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void CarregaListagemContas()
        {
            grdContas.DataSource = null;
            grdContas.DataSource = Contas;
        }
        private void AdicionarConta()
        {
            ContaModelo conta = new ContaModelo();
            conta.DataLancamento = DateTime.Now;
            conta.DataVencimento = dtpVencimento.Value;
            conta.Valor = double.Parse(txtValorConta.Text);
            conta.GestorId = long.Parse(txtId.Text);

            Contas.Add(conta);
            lblTotal.Text = Contas.Sum(c => c.Valor).ToString("C2");
            CarregaListagemContas();
        }
        private void RemoveConta()
        {
            if (grdContas.DataSource != null)
            {
                ContaModelo conta = (ContaModelo)grdContas.SelectedItem;
                Contas.Remove(conta);
            }
            CarregaListagemContas();
        }




        private void FrmCadastroRecebimentoContas_Load(object sender, EventArgs e)
        {
            
        }
        private void FrmCadastroRecebimentoContas_Shown(object sender, EventArgs e)
        {
            NovoLoad();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "C:\\Users\\Nicolas\\Documents\\Projetos\\OphellSB\\OPS_OphellSystem\\OPS_OphellSystem\\Resources\\Help.chm");
        }
        private void btnFornecedor_Click(object sender, EventArgs e)
        {
            if (formBuscaCliente == null) formBuscaCliente = new FrmBuscaCliente();
            formBuscaCliente.ShowDialog();
            Cliente = formBuscaCliente.Cliente;
            if (Cliente == null)
            {
               // MessageBox.Show("Erro ao obter Fornecedor, Verifique o Cadastro!", "OPH", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            txtId.Text = Cliente.ClienteId.ToString();
            txtFornecedor.Text = Cliente.Fantasia;
        }
        private void btnAdicionarConta_Click(object sender, EventArgs e)
        {
            AdicionarConta();
        }       
        private void btnGravar_Click(object sender, EventArgs e)
        {
            GravarConta();
        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {
            ObtemContas();
        }

        private void grdContas_CurrentCellKeyDown(object sender, Syncfusion.WinForms.DataGrid.Events.CurrentCellKeyEventArgs e)
        {
            if (e.KeyEventArgs.KeyCode == Keys.Delete) DeletaConta();
        }
    }
}
