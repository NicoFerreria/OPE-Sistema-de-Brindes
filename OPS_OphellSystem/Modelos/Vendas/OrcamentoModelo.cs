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


    }
}
