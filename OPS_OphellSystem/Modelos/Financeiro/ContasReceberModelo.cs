using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelos;

namespace Financeiro.Modelos
{
    public class ContasReceberModelo
    {
        public long ContasAReceberID { get; set; }
        public ClienteModelo Cliente { get; set; }
        public FormaPagamentoModelo  FormaPagamento { get; set; }
        public List<ContaModelo> Contas { get; set; }
        public double Total { get; set; }
        public int Duplicata { get; set; }
    }
}
