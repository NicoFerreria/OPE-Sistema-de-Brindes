using System;
using System.Linq;
using Modelos;
using Cadastros.Controles;
using System.Windows.Forms;
using OPS_OphellSystem;
using Financeiro.Modelos;
using System.Collections.Generic;
using Financeiro.Controles;

namespace Views
{
    public partial class FrmCadastroPagamentoContas : Form
    {
        FrmBuscaFornecedor formBuscaFornecedor;
        FornecedorModelo Fornecedor;
        private ContasPagarModelo _pagamento;
        private List<ContaModelo> Contas = new List<ContaModelo>();
        private ContasPagarControle controle = new ContasPagarControle();
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
                LimpaFormulario();
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
                cmbFormasPagamento.SelectedIndex = 0;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"OPH",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
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
            if(grdContas.DataSource != null) {
                ContaModelo conta = (ContaModelo)grdContas.SelectedItem;
                Contas.Remove(conta);
            }
            CarregaListagemContas();
        }
        private void CarregaListagemContas()
        {
            grdContas.DataSource = null;
            grdContas.DataSource = Contas;
        }
        private void ObtemContas()
        {
            try
            {
                if (Fornecedor != null)
                {
                    _pagamento = controle.GetConta(Fornecedor);
                    if(_pagamento.FormaPagamento != null)
                    {
                        cmbFormasPagamento.SelectedItem = _pagamento.FormaPagamento;
                    }                    
                    Contas = _pagamento.Contas;                    
                    CarregaListagemContas();
                    lblTotal.Text = Contas.Sum(c => c.Valor).ToString("C2");//conta.Total.ToString("C2");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "OPH", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
        }
        private void GravarConta()
        {
            try
            {
                //ContasPagarModelo conta = new ContasPagarModelo();
                double total = Contas.Sum(c => c.Valor);
                _pagamento.Fornecedor = Fornecedor;
                _pagamento.Contas = Contas;
                _pagamento.Total = total;
                _pagamento.FormaPagamento = (FormaPagamentoModelo)cmbFormasPagamento.SelectedItem;
                _pagamento.Duplicata = 1;

                controle.GravarPagamento(_pagamento);
                NovoLoad();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "OPH", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LimpaFormulario()
        {
            txtId.Text = "";
            Fornecedor = null;
            txtFornecedor.Text = "";
            txtValorConta.Text = "";
            grdContas.DataSource = null;
            cmbFormasPagamento.SelectedIndex = 0;
            lblTotal.Text = "";
        }
        private void DeletaConta()
        {
            if (MessageBox.Show("Esta conta será excluída permanentemente. Deseja continuar?", "OPH", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2) == DialogResult.No) return;
            ContaModelo conta = grdContas.SelectedItem as ContaModelo;
            if(conta != null)
            {
                controle.DeletaConta(conta);
                ObtemContas();
            }
        }
        #endregion

        #region "Eventos"
        private void FrmCadastroPagamentoContas_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Modifiers == Keys.Control && e.KeyCode == Keys.S) GravarConta();
            if (e.Modifiers == Keys.Control && e.KeyCode == Keys.N) LimpaFormulario();
        }
        private void FrmCadastroPagamentoContas_Shown(object sender, EventArgs e)
        {
            NovoLoad();
        }
        private void txtValorConta_KeyPress(object sender, KeyPressEventArgs e)
        {
            utilitarios.PermitirApenasNumeros(sender, e, true);
        }
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
        private void txtId_TextChanged(object sender, EventArgs e)
        {
            ObtemContas();
        }
        private void btnAdicionarConta_Click(object sender, EventArgs e)
        {
            AdicionarConta();
        }
        private void btnGravar_Click(object sender, EventArgs e)
        {
            GravarConta();
        }
        private void grdContas_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete) DeletaConta();
        }
        #endregion

        private void grdContas_CurrentCellKeyDown(object sender, Syncfusion.WinForms.DataGrid.Events.CurrentCellKeyEventArgs e)
        {
            if (e.KeyEventArgs.KeyCode == Keys.Delete) DeletaConta();
        }

        private void btnNovoPagamento_Click(object sender, EventArgs e)
        {
            LimpaFormulario();
        }
    }
    }

