using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class OperadorModelo
    {
        public long OperadroId { get; set; }
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string CPF { get; set; }
        public PerfilModelo Perfil { get; set; }
        public string Senha { get; set; }
        public bool Status { get; set; }

    }
}
