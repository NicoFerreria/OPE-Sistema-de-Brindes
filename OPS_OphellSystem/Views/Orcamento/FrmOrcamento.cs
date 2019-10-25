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

namespace Views
{
    public partial class FrmOrcamento : Form
    {
        FrmBuscaCliente formBuscaCliente;
        FrmBuscaFornecedor formBuscaFornecedor;
        FrmBuscaProduto formBuscaProduto;
        List<FornecedorModelo> Fornecedores = new List<FornecedorModelo>();
        OrcamentoModelo Orcamento = new OrcamentoModelo();
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
                    var forn = Fornecedores.Where(f => f.TipoFornecedor == tipoFornecedor).First();
                    if(forn != null)
                    {
                        Fornecedores.Remove(forn);
                    }

                    Fornecedores.Add(forn);
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
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message,"OPH",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
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
        #endregion


    }
}
