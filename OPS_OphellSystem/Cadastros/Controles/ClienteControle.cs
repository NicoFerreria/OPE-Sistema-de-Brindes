using System;
using System.Collections.Generic;
using System.Linq;
using Modelos;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using OPS_OphellSystem;

namespace Controles
{
    public class ClienteControle
    {
        #region "Variaveis"
        private List<SqlParametro> parametros;
        #endregion


        #region "Meodos"

        public ClienteControle()
        {

        }
        public void GravarCliente(ClienteModelo cliente)
        {
            try
            {
                DataTable dtDados = new DataTable();
                if (ValidaDados(cliente) == false)
                {
                    return;
                }

                dtDados = utilitarios.RealizaConexaoBd("SELECT id_clt FROM Cliente WHERE excluido='0' AND (cnpj_clt=@cnpj OR id_clt=@id)", RetornaParametros(cliente));
                if (dtDados.Rows.Count <= 0)
                {
                    utilitarios.RealizaConexaoBd("INSERT INTO Cliente(cnpj_clt,nome_fantasia_clt,razao_social_clt,status_clt,endereco_clt,telefone_clt,nome_contato_clt" +
                        ",email_contato_clt,numero_clt,complemento_clt,cidade,bairro,cep,digito_verificador,operador_cadastro_id," +
                        "operador_cadastro_nome,datahora_cadastro,datahora_alteracao,observacao_clt)VALUES(@cnpj,@fantasia,@razao,@status,@endereco,@telefone,@contato,@email," +
                        "@numero,@complemento,@cidade,@bairro,@cep,@digitoV,@operadorCodigo,@operadorNome,@dataHora,@datahoraAlteracao,@observacao)",
                        RetornaParametros(cliente));
                    //dtDados = utilitarios.RealizaConexaoBd("SELECT @id FROM Cliente WHERE cnpj_clt=@cnpj", RetornaParametros(cliente));
                    //cliente.ClienteId = int.Parse(dtDados.Rows[0]["id_clt"].ToString());
                }
                else
                {
                    AtualizarCliente(cliente);
                }
            }
            catch (Exception ex)
            {
                throw new System.Exception(ex.Message);
            }
        }
        public void AtualizarCliente(ClienteModelo cliente)
        {
            try
            {
                utilitarios.RealizaConexaoBd("UPDATE Cliente SET cnpj_clt=@cnpj,nome_fantasia_clt=@fantasia,razao_social_clt=@razao,status_clt=@status," +
                    "endereco_clt=@endereco,telefone_clt=@telefone,nome_contato_clt=@contato,email_contato_clt=@email,numero_clt=@numero,complemento_clt=@complemento" +
                    ",bairro=@bairro,cep=@cep,cidade=@cidade,digito_verificador=@digitoV,operador_cadastro_id=@operadorCodigo,operador_cadastro_nome=@operadorNome," +
                    "datahora_alteracao=@datahoraAlteracao,observacao_clt=@observacao WHERE id_clt=@id", RetornaParametros(cliente));
            }
            catch (Exception ex)
            {
                throw new System.Exception(ex.Message);
            }
        }
        public void DesativarAtivarCliente(ClienteModelo cliente)
        {
            try
            {
                utilitarios.RealizaConexaoBd("UPDATE Cliente SET status_clt=@status WHERE id_clt=@id", RetornaParametros(cliente));
            }
            catch (Exception ex)
            {
                throw new System.Exception(ex.Message);
            }
        }
        public void ExcluirCliente(long id)
        {
            try
            {
                if (id <= 0) throw new System.Exception("Não foi possível excluir cliente! Id do cliente inválido.");
                parametros = new List<SqlParametro>() { new SqlParametro() { Nome = "@id", Valor = id } };
                utilitarios.RealizaConexaoBd("UPDATE Cliente SET excluido=1 WHERE id_clt=@id AND excluido=0", parametros);
            }
            catch (Exception ex)
            {
                throw new System.Exception(ex.Message);
            }
        }
        #endregion

        #region "Funcoes"
        /// <summary>
        /// Retorna DataTable com os dados do Cliente com base em uma string.
        /// </summary>
        /// <param name="criterio">Compara a string passada com ID,CNPJ,Fantasia e razao social.</param>
        /// <returns></returns>
        public DataTable BuscaCliente(string criterio)
        {
            try
            {
                DataTable dtDados = new DataTable();
                if (long.TryParse(criterio, out long saida) == false & criterio != "")
                {
                    criterio = '%' + criterio + '%';
                }

                parametros = new List<SqlParametro>() { new SqlParametro() { Nome = "@criterio", Valor = criterio } };
                if (criterio == "")
                {
                    dtDados = utilitarios.RealizaConexaoBd("SELECT id_clt,cnpj_clt,nome_fantasia_clt,razao_social_clt," +
                    "CASE status_clt WHEN 1 THEN 'true' ELSE 'false' END status_clt,endereco_clt,numero_clt,complemento_clt," +
                    "cidade,bairro,cep,telefone_clt,nome_contato_clt,email_contato_clt,observacao_clt,digito_verificador,operador_cadastro_id,operador_cadastro_nome," +
                    "datahora_cadastro,datahora_alteracao FROM Cliente WHERE excluido='0'");
                }
                else
                {
                    dtDados = utilitarios.RealizaConexaoBd("SELECT id_clt,cnpj_clt,nome_fantasia_clt,razao_social_clt," +
                    "CASE status_clt WHEN 1 THEN 'true' ELSE 'false' END status_clt,endereco_clt,numero_clt,complemento_clt," +
                    "cidade,bairro,cep,telefone_clt,nome_contato_clt,email_contato_clt,observacao_clt,digito_verificador,operador_cadastro_id,operador_cadastro_nome," +
                    "datahora_cadastro,datahora_alteracao FROM Cliente WHERE excluido=0 OR id_clt=@criterio OR cnpj_clt=@criterio OR " +
                    "nome_fantasia_clt LIKE @criterio OR razao_social_clt LIKE @criterio LIMIT 100",
                    parametros);
                }
                return dtDados;
            }
            catch (Exception ex)
            {
                throw new System.Exception(ex.Message);
            }
        }
        public ClienteModelo GetCliente(long id)
        {
            try
            {
                ClienteModelo cliente = new ClienteModelo();
                DataTable dtDados = new DataTable();
                parametros = new List<SqlParametro>() { new SqlParametro { Nome = "@id", Valor = id },
                    new SqlParametro() { Nome="@excluido",Valor=0}
                };

                dtDados = utilitarios.RealizaConexaoBd("SELECT * FROM Cliente WHERE excluido='0' AND id_clt=@id", parametros);
                if (dtDados.Rows.Count > 0)
                {
                    cliente.ClienteId = long.Parse(dtDados.Rows[0]["id_clt"].ToString());
                    cliente.CNPJ = dtDados.Rows[0]["cnpj_clt"].ToString();
                    cliente.Fantasia = dtDados.Rows[0]["nome_fantasia_clt"].ToString();
                    cliente.Razao = dtDados.Rows[0]["razao_social_clt"].ToString();
                    cliente.Status = dtDados.Rows[0]["status_clt"].ToString() == "1" ? true : false;
                    cliente.Endereco = dtDados.Rows[0]["endereco_clt"].ToString();
                    cliente.Numero = int.Parse(dtDados.Rows[0]["numero_clt"].ToString());
                    cliente.Complemento = dtDados.Rows[0]["complemento_clt"].ToString();
                    cliente.Cidade = dtDados.Rows[0]["cidade"].ToString();
                    cliente.Bairro = dtDados.Rows[0]["bairro"].ToString();
                    cliente.CEP = int.Parse(dtDados.Rows[0]["cep"].ToString());
                    cliente.Telefone = int.Parse(dtDados.Rows[0]["telefone_clt"].ToString());
                    cliente.NomeContato = dtDados.Rows[0]["nome_contato_clt"].ToString();
                    cliente.Email = dtDados.Rows[0]["email_contato_clt"].ToString();
                    cliente.Observacao = dtDados.Rows[0]["observacao_clt"].ToString();
                    cliente.DigitoVerificadorCnpj = dtDados.Rows[0]["digito_verificador"].ToString();
                }

                return cliente;
            }
            catch (Exception ex)
            {
                throw new System.Exception(ex.Message);
            }
        }
        private bool ValidaDados(ClienteModelo cliente)
        {
            try
            {
                if (utilitarios.ValidaCnpj(cliente.CNPJ.ToString(), cliente.DigitoVerificadorCnpj.ToString()) == false)
                {
                    throw new System.Exception("CNPJ inválido! Confira se este é um CNPJ válido.");
                }
                if (cliente.CNPJ.ToString().Length < 12 || cliente.CNPJ.ToString().Length > 12)
                {
                    throw new System.Exception("CNPJ está com a quantidade de dígitos inferior ou superior a 14!");
                }
                if (cliente.Fantasia == "" || cliente.Fantasia == null)
                {
                    throw new System.Exception("Nome fantasia inválido!");
                }
                if (cliente.Razao == "" || cliente.Razao == null)
                {
                    throw new System.Exception("Razão Social inválida!");
                }
                return true;
            }
            catch (Exception ex)
            {
                throw new SystemException(ex.Message);
            }
        }
        private List<SqlParametro> RetornaParametros(ClienteModelo cliente)
        {

            parametros = new List<SqlParametro>();
            parametros.Add(new SqlParametro { Nome = "@id", Valor = cliente.ClienteId });
            parametros.Add(new SqlParametro { Nome = "@fantasia", Valor = cliente.Fantasia });
            parametros.Add(new SqlParametro { Nome = "@razao", Valor = cliente.Razao });
            parametros.Add(new SqlParametro { Nome = "@contato", Valor = cliente.NomeContato });
            parametros.Add(new SqlParametro { Nome = "@email", Valor = cliente.Email });
            parametros.Add(new SqlParametro { Nome = "@observacao", Valor = cliente.Observacao });
            parametros.Add(new SqlParametro { Nome = "@status", Valor = cliente.Status ? 1 : 0 });
            parametros.Add(new SqlParametro { Nome = "@cnpj", Valor = cliente.CNPJ });
            parametros.Add(new SqlParametro { Nome = "@endereco", Valor = cliente.Endereco });
            parametros.Add(new SqlParametro { Nome = "@numero", Valor = cliente.Numero });
            parametros.Add(new SqlParametro { Nome = "@cidade", Valor = cliente.Cidade });
            parametros.Add(new SqlParametro { Nome = "@cep", Valor = cliente.CEP });
            parametros.Add(new SqlParametro { Nome = "@telefone", Valor = cliente.Telefone });
            parametros.Add(new SqlParametro { Nome = "@bairro", Valor = cliente.Bairro });
            parametros.Add(new SqlParametro { Nome = "@complemento", Valor = cliente.Complemento });
            parametros.Add(new SqlParametro { Nome = "@digitoV", Valor = cliente.DigitoVerificadorCnpj });
            parametros.Add(new SqlParametro { Nome = "@operadorCodigo", Valor = SessaoUsuario.ID });
            parametros.Add(new SqlParametro { Nome = "@operadorNome", Valor = SessaoUsuario.Nome });
            parametros.Add(new SqlParametro { Nome = "@dataHora", Valor = DateTime.Now.ToString() });
            parametros.Add(new SqlParametro { Nome = "@datahoraAlteracao", Valor = DateTime.Now.ToString() });

            return parametros;
        }
        #endregion
    }
}
