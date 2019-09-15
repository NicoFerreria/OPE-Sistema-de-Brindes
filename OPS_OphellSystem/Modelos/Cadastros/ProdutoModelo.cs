using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastros.Modelos
{
    public class ProdutoModelo
    {
        public long ProdutoID { get; set; }
        public long Codigo { get; set; }
        public string Nome { get; set; }
        public string Cor { get; set; }
        public string Descricao { get; set; }
        public string Observacao { get; set; }
        public bool Status { get; set; }


    }
}
