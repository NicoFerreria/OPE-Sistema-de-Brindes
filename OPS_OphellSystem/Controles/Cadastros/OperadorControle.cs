using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelos;
using OPS_OphellSystem;

namespace Cadastros.Controles
{
    public class OperadorControle
    {
        #region "Classes"

        #endregion

        #region "Variáveis"

        #endregion

        #region "Propriedades"
        #endregion

        #region "Metodos"
        public OperadorControle()
        {

        }
        public bool GravaOperador(OperadorModelo operador)
        {
            try
            {
                if (operador == null) throw new System.Exception("Operador não pode ser nulo!");
                if (ValidaDados(operador))
                {
                    if (operador.OperadroId == 0)
                    {

                        utilitarios.RealizaConexaoBd("INSERT INTO Usuario(nome,sobrenome,codigo,senha_login,perfil_id,status,cpf,operador_cadastro_id,operador_cadastro_nome" +
                            ",datahora_cadastro,operador_alteracao_id,operador_alteracao_nome,datahora_alteracao)VALUES(@nome,@sobrenome,@codigo,@senha,@perfil,@status" +
                            ",@cpf,@operadorId,@operadorNome,@datahora,@operadorId,@operadorNome,@datahora)", Parametros(operador));

                    }
                    else
                    {
                        utilitarios.RealizaConexaoBd("UPDATE Usuario SET nome=@nome,sobrenome=@sobrenome,codigo=@codigo,senha_login=@senha,perfil_id=@perfil,status=@status" +
                                ",cpf=@cpf,operador_alteracao_id=@operadorId,operador_alteracao_nome=@operadorNome,datahora_alteracao=@datahora WHERE id=@id AND excluido=0", Parametros(operador));
                    }

                }
            }
            catch (Exception ex)
            {
                throw new System.Exception(ex.Message);
            }
            return true;
        }
        #endregion

        #region "Funções"
        public OperadorModelo ObterOperador(long id)
        {
            OperadorModelo operador = new OperadorModelo();
            PerfilModelo perfil = new PerfilModelo();
            try
            {
                if (id <= 0) throw new Exception("Erro ao obter o id de operador!");
                List<SqlParametro> list = new List<SqlParametro>() { new SqlParametro() { Nome = "@id", Valor = id } };
                DataTable dtDados = utilitarios.RealizaConexaoBd("SELECT * FROM Usuario WHERE id=@id AND excluido=0",list);
                if(dtDados.Rows.Count > 0)
                {
                    operador.OperadroId = long.Parse(dtDados.Rows[0]["id"].ToString());
                    operador.Nome = dtDados.Rows[0]["nome"].ToString();
                    operador.Sobrenome = dtDados.Rows[0]["sobrenome"].ToString();
                    operador.Codigo = int.Parse(dtDados.Rows[0]["codigo"].ToString());
                    operador.Senha = dtDados.Rows[0]["senha"].ToString();
                    operador.Status = bool.Parse(dtDados.Rows[0]["status"].ToString());
                    operador.CPF = dtDados.Rows[0]["cpf"].ToString();
                    operador.Perfil = perfil.GetPerfis().Find(p => p.PerfilId == long.Parse(dtDados.Rows[0]["perfil_id"].ToString()));                    
                }
            }catch (ArgumentException)
            {
                return operador;
            }
            catch (Exception ex)
            {
                throw new System.Exception(ex.Message);
            }
            return operador;
        }
        public DataTable ObeterDataTabelOperador()
        {
            try
            {
                return utilitarios.RealizaConexaoBd("SELECT * FROM Usuario WHERE excluido=0");
            }catch(Exception ex)
            {
                throw new System.Exception(ex.Message);
            }
        }
        public bool ExcluirOperador(long id)
        {
            try
            {
                if (id <= 0) throw new Exception("Erro ao obter o id de operador!");
                List<SqlParametro> list = new List<SqlParametro>() { new SqlParametro() { Nome = "@id", Valor = id } };
                utilitarios.RealizaConexaoBd("UPDATE Usuario SET excluido=0 WHERE id=@id", list);
            }
            catch (Exception ex)
            {
                throw new System.Exception(ex.Message);
            }
            return true;
        }
        private List<SqlParametro> Parametros(OperadorModelo operador)
        {
            List<SqlParametro> lista = new List<SqlParametro>();
            try
            {
                lista.Add(new SqlParametro { Nome = "@id", Valor = operador.OperadroId });
                lista.Add(new SqlParametro { Nome = "@codigo", Valor = operador.Codigo });
                lista.Add(new SqlParametro { Nome = "@nome", Valor = operador.Nome });
                lista.Add(new SqlParametro { Nome = "@sobrenome", Valor = operador.Sobrenome });
                lista.Add(new SqlParametro { Nome = "@cpf", Valor = operador.CPF });
                lista.Add(new SqlParametro { Nome = "@perfil_id", Valor = operador.Perfil.PerfilId });
                lista.Add(new SqlParametro { Nome = "@senha", Valor = operador.Senha });
                lista.Add(new SqlParametro { Nome = "@status", Valor = operador.Status.ToString()});
                lista.Add(new SqlParametro { Nome = "@excluido", Valor = operador.Status ? 1 : 0 });
                lista.Add(new SqlParametro { Nome = "@operadorId", Valor = SessaoUsuario.ID });
                lista.Add(new SqlParametro { Nome = "@operadorNome", Valor = SessaoUsuario.Nome });
                lista.Add(new SqlParametro { Nome = "@datahora", Valor = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") });

            }
            catch (Exception ex)
            {
                throw new System.Exception(ex.Message);
            }
            return lista;
        }
        private bool ValidaDados(OperadorModelo operador)
        {
            try
            {
                if (operador.Nome == "")
                {
                    throw new System.Exception("Nome do operador não pode estar em branco!");
                }
                if (operador.Sobrenome == "")
                {
                    throw new System.Exception("Sobrenome do opreador não pode estar em branco!");
                }
                if (long.TryParse(operador.CPF, out long cpf) == false)
                {
                    throw new System.Exception("CPF do operador está inálido ou em um formato incorreto!");
                }
            }
            catch (Exception ex)
            {

                throw new System.Exception(ex.Message);
            }
            return true;
        }
        #endregion

    }
}
