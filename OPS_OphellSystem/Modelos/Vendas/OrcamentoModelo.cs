using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cadastros.Modelos;

namespace Vendas.Modelos
{
    public class OrcamentoModelo
    {
        public long OrcamentoID { get; set; }
        public ClienteModelo Cliente { get; set; }
        public FornecedorModelo Fornecedor { get; set; }
        
    }
}
