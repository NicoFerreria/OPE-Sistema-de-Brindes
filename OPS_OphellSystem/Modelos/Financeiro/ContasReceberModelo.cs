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
        public FornecedorModelo Fornecedor { get; set; }
        public string  FormaPagamento { get; set; }
        public double Valor { get; set; }        
        public int Duplicata { get; set; }
        public DateTime DataVencimento { get; set; }
    }
}
