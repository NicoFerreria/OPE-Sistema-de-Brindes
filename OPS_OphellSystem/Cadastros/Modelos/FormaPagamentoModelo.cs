using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class FormaPagamentoModelo
    {
        public long FormasPafamentoId { get; set; }
        public string Descricao { get; set; }
        public string Tipo { get; set; }
        public bool Status { get; set; }

    }
}
