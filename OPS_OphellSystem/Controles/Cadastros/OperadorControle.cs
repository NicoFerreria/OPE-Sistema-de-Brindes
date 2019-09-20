using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cadastros.Modelos;
using OPS_OphellSystem;

namespace Cadastros.Controles
{ 
    public class OperadorControle
    {
        #region "Classes"

        #endregion

        #region "Variáveis"
        private OperadorModelo _operador;
        #endregion

        #region "Propriedades"
        #endregion

        #region "Metodos"
        public OperadorControle()
        {

        }
        public OperadorControle(OperadorModelo operador)
        {            
            _operador = operador;
        }
        public void GravaOperador() {
            try
            {
                
            }catch(Exception ex)
            {
                throw new System.Exception(ex.Message);
            }
        }
        private void AtualizaOperador()
        {
            try
            {

            }catch (Exception ex)
            {
                throw new System.Exception(ex.Message);
            }
        }
        #endregion

        #region "Funções"
        private List<SqlParametro> Parametros()
        {
            List<SqlParametro> lista = new List<SqlParametro>();
            try
            {
                lista.Add(new SqlParametro { Nome = "@id", Valor = _operador.OperadroId });
                lista.Add(new SqlParametro { Nome = "@codigo", Valor = _operador.Codigo });
                lista.Add(new SqlParametro { Nome = "@nome", Valor = _operador.Nome });
                lista.Add(new SqlParametro { Nome = "@sobrenome", Valor = _operador.Sobrenome });
                lista.Add(new SqlParametro { Nome = "@cpf", Valor = _operador.CPF });
                lista.Add(new SqlParametro { Nome = "@perfil", Valor = _operador.Perfil.Descricao });
                lista.Add(new SqlParametro { Nome = "@senha", Valor = _operador.Senha });
                lista.Add(new SqlParametro { Nome = "@status", Valor = _operador.Status ? 1:0 });
            }
            catch (Exception ex)
            {
                throw new System.Exception(ex.Message);
            }
            return lista;
        }
        #endregion

    }
}
