using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class GrupoFornecedorModelo
    {
        public long Id { get; set; }
        public string Descricao { get; set; }
        public long OperadorId { get; set; }
        public string OperadorNome { get; set; }
        public DateTime Datahora { get; set; }
        public int Excluido { get; set; }
    }
}
