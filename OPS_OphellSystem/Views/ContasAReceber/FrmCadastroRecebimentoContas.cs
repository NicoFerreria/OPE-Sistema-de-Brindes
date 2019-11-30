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
using Financeiro.Modelos;
using Modelos;
using OPS_OphellSystem;

namespace Views
{
    public partial class FrmCadastroRecebimentoContas : Form
    {
        FrmBuscaCliente formBuscaFornecedor;
        public FrmCadastroRecebimentoContas()
        {
            InitializeComponent();
        }

        private List<ContasReceberModelo> Contas = new List<ContasReceberModelo>();
        private ClienteModelo Fornecedor;
        private void GravarConta()
        {
            if(double.TryParse(txtValorConta.Text,out double valor) == false)
            {
                MessageBox.Show("Valor inválido!","OPH", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (long.TryParse(txtId.Text,out long id) == false)
            {
                MessageBox.Show("Não foi possível obter dados do fornecedor", "OPH", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Contas.Add(new ContasReceberModelo() { ContasAReceberID = Contas.Count + 1, Duplicata = 0, Cliente = Fornecedor,
                FormaPagamento = cmbFormasPagamento.ValueMember, Valor = double.Parse(txtValorConta.Text), DataVencimento= dtpVencimento.Value});          
            
        }
        private void CarregaListagem()
        {
            grdContas.DataSource = null;
            grdContas.DataSource = utilitarios.RealizaConexaoBd("SELECT * FROM Pagamento");
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

        private void FrmCadastroRecebimentoContas_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "C:\\Users\\Nicolas\\Documents\\Projetos\\OphellSB\\OPS_OphellSystem\\OPS_OphellSystem\\Resources\\Help.chm");
        }

        private void btnFornecedor_Click(object sender, EventArgs e)
        {
            if (formBuscaFornecedor == null) formBuscaFornecedor = new FrmBuscaCliente();
            formBuscaFornecedor.ShowDialog();
            Fornecedor = formBuscaFornecedor.Cliente;
            if (Fornecedor == null)
            {
               // MessageBox.Show("Erro ao obter Fornecedor, Verifique o Cadastro!", "OPH", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            txtId.Text = Fornecedor.ClienteId.ToString();
            txtFornecedor.Text = Fornecedor.Fantasia;
        }

        private void btnAdicionarConta_Click(object sender, EventArgs e)
        {
            GravarConta();
        }

        private void FrmCadastroRecebimentoContas_Shown(object sender, EventArgs e)
        {
            CarregaCombos();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            List<SqlParametro> parametros = new List<SqlParametro>()
            {
                new SqlParametro() { Nome = "@idForcenedor", Valor = Fornecedor.ClienteId },
                new SqlParametro() { Nome = "@formaPagamento", Valor = cmbFormasPagamento.ValueMember },
                new SqlParametro() { Nome = "@valor", Valor = double.Parse(txtValorConta.Text)},
                new SqlParametro() { Nome = "@vencimento", Valor = dtpVencimento.Value.ToShortDateString()},

        };
            utilitarios.RealizaConexaoBd("INSERT INTO Pagamento(total,id_fornecedor,data_lancamento,forma_pagamento)VALUE(@valor,@idFornecedor,vencimento,@formaPagamento)", parametros);
            MessageBox.Show("Cadastro realizado com sucesso!","OPH", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Fornecedor = null;
            txtId.Text = "";
            txtFornecedor.Text = "";
            txtValorConta.Text = "";
            CarregaListagem();
        }
    }
}
