using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class RelatorioOrcamentoModelo
    {
        public long OrcamentoId { get; set; }
        public string FantasiaCliente { get; set; }
        public string EnderecoCliente { get; set; }
        public string TelefoneCliente { get; set; }
        public string EmailCliente { get; set; }
        public string NomeOperador { get; set; }
        public DateTime DataHoraOrcamento { get; set; }
        public string ObservacaoOrcamento { get; set; }
        public string Produto { get; set; }
        public double QuantidadeVenda { get; set; }
        public decimal PrecoUnidade { get; set; }
        public decimal TotalVenda { get; set; }
        public string Status { get; set; }    
    }
}
