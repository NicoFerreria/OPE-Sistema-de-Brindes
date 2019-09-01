using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class ContasPagarModelo
    {
        public long ContaPagarId { get; set; }
        public int Duplicata { get; set; }        
        public FornecedorModelo Fornecedor { get; set; }
        public FormaPagamentoModelo FormaPagamento { get; set; }
        public double Total { get; set; }
        public List<ContaModelo> Contas { get; set; }


    }
}
