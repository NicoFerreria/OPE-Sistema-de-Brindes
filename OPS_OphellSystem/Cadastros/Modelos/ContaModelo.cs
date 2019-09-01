using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class ContaModelo
    {
        public long ContaId { get; set; }
        public DateTime DataLancamento { get; set; }
        public DateTime DataVencimento { get; set; }
        public double Valor { get; set; }
        public long GestorId { get; set; }
    }
}
