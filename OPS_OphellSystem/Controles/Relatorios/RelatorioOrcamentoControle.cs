using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelos;
using Vendas.Controles;

namespace Controles
{
    public class RelatorioOrcamentoControle
    {
        private OrcamentoControle orcamentoControle = new OrcamentoControle();
        public RelatorioOrcamentoControle()
        {

        }

        public RelatorioOrcamentoModelo GerarRelatorio(OrcamentoModelo Orcamento)
        {
            
            RelatorioOrcamentoModelo relatorio = new RelatorioOrcamentoModelo();
            relatorio.DataHoraOrcamento = Orcamento.DataEmissao;
            relatorio.EmailCliente = Orcamento.Cliente.Email;
            relatorio.EnderecoCliente = Orcamento.Cliente.Endereco + ", " + Orcamento.Cliente.Numero + " - " + Orcamento.Cliente.Bairro;
            relatorio.FantasiaCliente = Orcamento.Cliente.CNPJ.Substring(0,11) + "/" + Orcamento.Cliente.DigitoVerificadorCnpj + " " + Orcamento.Cliente.Fantasia;
            relatorio.NomeOperador = Orcamento.Operador.Nome;
            relatorio.ObservacaoOrcamento = Orcamento.Observacao;
            relatorio.OrcamentoId = Orcamento.OrcamentoID;
            relatorio.PrecoUnidade = Orcamento.ValorUnd;
            relatorio.Produto = Orcamento.Produto.Descricao;
            relatorio.QuantidadeVenda = Orcamento.Qtd;
            relatorio.Status = Orcamento.Status;
            relatorio.TelefoneCliente = Orcamento.Cliente.Telefone.ToString();
            relatorio.TotalVenda = Orcamento.TotalVenda;

            return relatorio;
        }        
    }
}
