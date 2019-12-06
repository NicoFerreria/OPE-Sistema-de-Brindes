using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dao;
using Modelos;
using Financeiro.Modelos;

namespace Financeiro.Controles
{
   public class ContasPagarControle
    {
        //private FornecedorModelo _fornecedor;
        //ContaModelo _conta;
        //ContasPagarModelo _pagamento;

        public ContasPagarControle()
        {

        }
        public ContasPagarModelo GetConta(FornecedorModelo fornecedor)
        {
            ContasAPagarDao daoPagamento = new ContasAPagarDao();
            ContaDao daoConta = new ContaDao();
            ContasPagarModelo pagamento;

            pagamento = daoPagamento.GetContasByFornecedor(fornecedor);
            pagamento.Contas = daoConta.GetContasByPagamento(pagamento);
            return pagamento;
        }
        public void GravarPagamento(ContasPagarModelo pagamento)
        {
            try
            {
                ContasAPagarDao daoPagamento = new ContasAPagarDao();
                ContaDao daoConta = new ContaDao();
                if(pagamento.ContaPagarId == 0)
                {
                    daoPagamento.Create(pagamento);
                }
                else
                {
                    daoPagamento.Update(pagamento);
                }
                                
                foreach (ContaModelo conta in pagamento.Contas)
                {
                    daoConta.Create(conta);
                }
            }catch(Exception ex)
            {
                throw new System.Exception(ex.Message);
            }
            
        }
        public void DeletaConta(ContaModelo conta)
        {
            ContaDao daoConta = new ContaDao();
            if(conta != null)
            {
                daoConta.Delete(conta);
            }
        }
    }
}
