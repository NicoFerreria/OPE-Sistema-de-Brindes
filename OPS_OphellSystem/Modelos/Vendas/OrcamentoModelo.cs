using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelos;

namespace Modelos
{
    public class OrcamentoModelo
    {
        public long OrcamentoID { get; set; }
        public ClienteModelo Cliente { get; set; }
        public List<FornecedorModelo> Fornecedores { get; set; }
        public ProdutoModelo Produto { get; set; }
        public DateTime DataEmissao { get; set; }
        public OperadorModelo Operador { get; set; }
        public string Observacao { get; set; }
        public decimal ValorUnd { get; set; }
        public double Qtd { get; set; }
        public string Status { get; set; }
        public decimal TotalVenda { get; set; }
        public decimal ValorUndCompra { get; set; }
        public decimal TotalCompra { get; set; }
        public decimal ValorGravacao { get; set; }
        public decimal TotalGravacao { get; set; }
        public decimal TotalTransporte { get; set; }
        public double PorcentagemImposto { get; set; }
        public double PorcentagemBV { get; set; }
        public decimal TotalImposto { get; set; }
        public double PorcentagemLucro { get; set; }
        public decimal TotalLucro { get; set; }
        public int Excluido { get; set; }
        public long FornecedorId { get; set; }
        public long FornecedorGravacaoId { get; set; }
        public long FornecedorTransporteId { get; set; }
    }
}
