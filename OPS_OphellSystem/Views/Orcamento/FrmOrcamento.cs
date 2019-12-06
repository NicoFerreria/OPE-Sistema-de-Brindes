using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OPS_OphellSystem;
using Modelos;
using Vendas.Controles;
using Cadastros.Controles;

namespace Views
{
    public partial class FrmOrcamento : Form
    {
        FrmBuscaCliente formBuscaCliente;
        FrmBuscaFornecedor formBuscaFornecedor;
        FrmBuscaProduto formBuscaProduto;
        List<FornecedorModelo> Fornecedores = new List<FornecedorModelo>();
        OrcamentoModelo Orcamento = new OrcamentoModelo();
        OrcamentoControle controle = new OrcamentoControle();        

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
        private void AbreBuscaCliente()
        {
            try
            {
                if (formBuscaCliente == null) formBuscaCliente = new FrmBuscaCliente();

                formBuscaCliente.ShowDialog();
                ClienteModelo cliente = formBuscaCliente.Cliente;
                if(cliente != null)
                {
                    Orcamento.Cliente = cliente;
                    txtCodigoCliente.Text = cliente.ClienteId.ToString();
                    txtCliente.Text = cliente.Fantasia;
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message,"OPH",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
        private void AbreBuscaFornecedor(TiposFornecedores tipoFornecedor)
        {
            try
            {                
                if (formBuscaFornecedor == null) formBuscaFornecedor = new FrmBuscaFornecedor();

                formBuscaFornecedor.TipoFornecedor = tipoFornecedor;
                formBuscaFornecedor.ShowDialog();
                FornecedorModelo fornecedor = formBuscaFornecedor.Fornecedor;
                if(fornecedor != null)
                {
                    Fornecedores.Add(fornecedor);
                    if(tipoFornecedor == TiposFornecedores.MERCADORIA)
                    {
                        txtCodigoFornecedor.Text = fornecedor.FornecedorId.ToString();
                        txtFornecedor.Text = fornecedor.Fantasia;
                    }else if(tipoFornecedor == TiposFornecedores.TRANSPORTADOR)
                    {
                        txtCodigoTransporte.Text = fornecedor.FornecedorId.ToString();
                        txtTrasnporte.Text = fornecedor.Fantasia;
                    }else if(tipoFornecedor == TiposFornecedores.GRAFICA)
                    {
                        txtCodigoGravacao.Text = fornecedor.FornecedorId.ToString();
                        txtGravacao.Text = fornecedor.Fantasia;
                    }
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"OPH", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
        private void AbreBuscaProduto()
        {
            try
            {
                if(formBuscaProduto == null)
                {
                    formBuscaProduto = new FrmBuscaProduto();
                }

                formBuscaProduto.ShowDialog();
                ProdutoModelo produto = formBuscaProduto.Produto;
                if(produto != null)
                {
                    Orcamento.Produto = produto;
                    txtCodigoProduto.Text = produto.ProdutoID.ToString();
                    txtProduto.Text = produto.Nome;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message,"OPH",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }       
        private void CalculaGravacao()
        {
            if (txtQuantidade.Text == "" || txtValorGravacao.Text == "")
            {
                txtTotalGravacao.Text = "";
                return;
            };
            txtTotalGravacao.Text = (decimal.Parse(txtQuantidade.Text) * decimal.Parse(txtValorGravacao.Text)).ToString("C2");
        }
        private void CalculaTransporte()
        {

        }
        private void CalculaProduto()
        {
            if (txtValorProduto.Text == ""|| txtQuantidade.Text == "")
            {
                txtTotalProduto.Text = "";
                return;
            };
            txtTotalProduto.Text = (decimal.Parse(txtQuantidade.Text) * decimal.Parse(txtValorProduto.Text)).ToString("C2");
        }
        private void CalculaVenda()
        {
            if (txtValorVendaUnd.Text == "") return;
            lblTotal.Text = (decimal.Parse(txtValorProduto.Text) * decimal.Parse(txtQuantidade.Text)).ToString("C2");
            lblTotalImposto.Text = (double.Parse(lblTotal.Text.Replace("R$","")) * double.Parse(txtPorcentagemImposto.Text)).ToString("C2");
            lblTotalBv.Text = (double.Parse(lblTotal.Text.Replace("R$","")) * double.Parse(txtBv.Text)).ToString("C2");
            lblTotalLucro.Text = (decimal.Parse(lblTotal.Text.Replace("R$","")) - 
                decimal.Parse(txtTotalProduto.Text.Replace("R$", "")) - 
                decimal.Parse(txtValorGravacao.Text.Replace("R$","")) -
                decimal.Parse(txtValorTransporte.Text.Replace("R$","")) - 
                decimal.Parse(lblTotalImposto.Text.Replace("R$","")) - 
                decimal.Parse(lblTotalBv.Text.Replace("R$",""))).ToString("C2");
            txtPorcentagemLucro.Text = (decimal.Parse(lblTotalLucro.Text.Replace("R$", "")) / decimal.Parse(lblTotal.Text.Replace("R$", ""))).ToString();
        }
        private void GravarOrcamento()
        {
            Orcamento.DataEmissao = DateTime.Now;
            Orcamento.Fornecedores = Fornecedores;
            Orcamento.FornecedorGravacaoId = long.Parse(txtCodigoGravacao.Text);
            Orcamento.FornecedorId = long.Parse(txtCodigoFornecedor.Text);
            Orcamento.FornecedorTransporteId = long.Parse(txtCodigoTransporte.Text);
            Orcamento.Operador = new OperadorModelo() {OperadroId = SessaoUsuario.ID, Nome = SessaoUsuario.Nome};
            Orcamento.PorcentagemBV = double.Parse(txtBv.Text);
            Orcamento.PorcentagemImposto = double.Parse(txtPorcentagemImposto.Text);
            Orcamento.PorcentagemLucro = double.Parse(txtPorcentagemLucro.Text);
            Orcamento.Qtd = double.Parse(txtQuantidade.Text);
            Orcamento.TotalCompra = decimal.Parse(txtTotalProduto.Text.Replace("R$", ""));
            Orcamento.TotalGravacao = decimal.Parse(txtTotalGravacao.Text.Replace("R$", ""));
            Orcamento.TotalImposto = decimal.Parse(lblTotalImposto.Text.Replace("R$", ""));
            Orcamento.TotalLucro = decimal.Parse(lblTotalLucro.Text.Replace("R$", ""));
            Orcamento.TotalTransporte = decimal.Parse(txtTrasnporte.Text);
            Orcamento.TotalVenda = decimal.Parse(lblTotal.Text.Replace("R$", ""));
            Orcamento.ValorGravacao = decimal.Parse(lblTotalGravacao.Text.Replace("R$",""));
            Orcamento.ValorUnd = decimal.Parse(txtValorVendaUnd.Text);
            Orcamento.ValorUndCompra = decimal.Parse(txtValorProduto.Text);

            controle.GravaOrcamento(Orcamento);
            CarregaListagem();
        }
        private void CarregaListagem()
        {
            grdOrcamentos.DataSource = null;
            grdOrcamentos.DataSource = controle.SelectAll();
        }
        #endregion

        #region "Eventos"
        private void btnFechar_Click(object sender, EventArgs e)
        {
            Fechar();
        }
        private void btnBuscaCliente_Click(object sender, EventArgs e)
        {
            AbreBuscaCliente();
        }
        private void btnBuscaFornecedor_Click(object sender, EventArgs e)
        {
            AbreBuscaFornecedor(TiposFornecedores.MERCADORIA);
        }
        private void btnBuscaProduto_Click(object sender, EventArgs e)
        {
            AbreBuscaProduto();
        }
        private void btnBuscaGravacao_Click(object sender, EventArgs e)
        {
            AbreBuscaFornecedor(TiposFornecedores.GRAFICA);
        }
        private void btnBuscaTransporte_Click(object sender, EventArgs e)
        {
            AbreBuscaFornecedor(TiposFornecedores.TRANSPORTADOR);
        }
        private void txtValorProduto_TextChanged(object sender, EventArgs e)
        {
            CalculaProduto();
        }
        private void txtValorGravacao_TextChanged(object sender, EventArgs e)
        {
            CalculaGravacao();
        }
        private void txtQuantidade_TextChanged(object sender, EventArgs e)
        {
            CalculaProduto();
            CalculaGravacao();
        }
        private void btnRelatorio_Click(object sender, EventArgs e)
        {
            FrmRtlOrcamento relatorio = new FrmRtlOrcamento();
            relatorio.Orcamento = Orcamento;
            relatorio.ShowDialog();
        }
        #endregion


    }
}
