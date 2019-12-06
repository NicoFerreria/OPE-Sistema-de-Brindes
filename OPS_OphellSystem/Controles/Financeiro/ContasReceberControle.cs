using Dao;
using Financeiro.Modelos;
using Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Financeiro.Controles
{
   public class ContasReceberControle
    {
        public ContasReceberModelo GetConta(ClienteModelo cliente)
        {
            ContasAReceberDao daoPagamento = new ContasAReceberDao();
            ContaDao daoConta = new ContaDao();
            ContasReceberModelo pagamento;

            pagamento = daoPagamento.GetContasByFornecedor(cliente);
            pagamento.Contas = daoConta.GetContasByRecebimento(pagamento);
            return pagamento;
        }
        public void GravarPagamento(ContasReceberModelo pagamento)
        {
            try
            {
                ContasAReceberDao daoPagamento = new ContasAReceberDao();
                ContaDao daoConta = new ContaDao();
                if (pagamento.ContasAReceberID == 0)
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
            }
            catch (Exception ex)
            {
                throw new System.Exception(ex.Message);
            }

        }
        public void DeletaConta(ContaModelo conta)
        {
            ContaDao daoConta = new ContaDao();
            if (conta != null)
            {
                daoConta.Delete(conta);
            }
        }
    }
}
