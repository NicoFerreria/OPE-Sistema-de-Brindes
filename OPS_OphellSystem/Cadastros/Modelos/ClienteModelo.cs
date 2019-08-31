using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class ClienteModelo
    {
        public long ClienteId { get; set; }
        public long CNPJ { get; set; }
        public int DigitoVerificadorCnpj { get; set; }
        public string Fantasia { get; set; }
        public string Razao { get; set; }
        public int Status { get; set; }
        public string Endereco { get; set; }
        public int Numero { get; set; }
        public int Telefone { get; set; }
        public string NomeContato { get; set; }
        public string Complemento { get; set; }
        public string Email { get; set; }
        public string Observacao { get; set; }
        public int Terceiro { get; set; }
        public string Cidade { get; set; }
        public string Bairro { get; set; }
        public int CEP { get; set; }

    }
}
