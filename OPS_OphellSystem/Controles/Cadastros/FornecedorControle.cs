using System;
using System.Collections.Generic;
using System.Data;
using Cadastros.Modelos;
using OPS_OphellSystem;

namespace Cadastros.Controles
{
   public class FornecedorControle
    {
        #region "Classes"
        
        #endregion

        #region "Variaveis"
        #endregion

        #region "Propriedades"
        #endregion

        #region "Metodos"
        public FornecedorControle()
        {
            
        }
        public bool DeleteFornecedor(long id)
        {
            try
            {
                if (id <= 0) throw new System.Exception("Nenhum fornecedor passado como parâmetro!");
                List<SqlParametro> parametros = new List<SqlParametro>();
                parametros.Add(new SqlParametro { Nome = "@id", Valor = id });
                utilitarios.RealizaConexaoBd("UPDATE Fornecedor SET excluido=1 WHERE id=@id",parametros);
            }catch(Exception ex)
            {
                throw new System.Exception(ex.Message);
            }
            return true;
        }
        public bool GravarFornecedor(FornecedorModelo fornecedor)
        {
            DataTable dtDados = new DataTable();
            try
            {
                if (fornecedor == null) throw new System.Exception("Nenhum fornecedor passa como parâmetro!");
                dtDados = utilitarios.RealizaConexaoBd("SELECT id FROM Fornecedor WHERE id=@id", RetornaParametros(fornecedor));
                if (dtDados.Rows.Count <= 0)
                {
                    utilitarios.RealizaConexaoBd("INSERT INTO Fornecedor(cnpj,fantasia,razao,status,endereco,numero,complemento,cidade,bairro,cep,telefone,contato,email" +
                ",observacao,digito_verificador,operador_cadastro_id,operador_cadastro_nome,datahora_cadastro,datahora_alteracao)VALUES(@cnpj,@fantasia,@razao,@status" +
                ",@endereco,@numero,@complemento,@cidade,@bairro,@cep,@telefone,@contato,@email,@observacao,@digitoVerificador,@operadorId,@operadorNome,@dataAlteracao" +
                ",@dataAlteracao)",RetornaParametros(fornecedor));
                }
                else
                {
                    utilitarios.RealizaConexaoBd("UPDATE Fornecedor SET cnpj=@cnpj,fantasia=@fantasia,razao=@razao,status=@status,endereco=@endereco,numero=@numero" +
                ",complemento=@complemento,cidade=@cidade,bairro=@bairro,cep=@cep,telefone=@telefone,contato=@contato,email=@email,observacao=@observacao" +
                ",digito_verificador=@digitoVerificador,operador_alteracao_id=@operadorId,operador_alteracao_nome=@operadorNome,datahora_alteracao=@dataAlteracao WHERE id=@id", RetornaParametros(fornecedor));
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
        public DataTable GetListaFornecedores(string criterio = "")
        {
            try
            {
                List<SqlParametro> parametros = new List<SqlParametro>();                
                
                if(long.TryParse(criterio, out long result) == false && criterio != "")
                {
                    criterio = '%' + criterio + '%';
                }

                parametros.Add(new SqlParametro { Nome = "@criterio", Valor = criterio });

                if (criterio == "")
                {
                    return utilitarios.RealizaConexaoBd("SELECT id,cnpj,fantasia,razao,CASE status WHEN 1 THEN 'true' ELSE 'false' END status,endereco,numero" +
                ",complemento,cidade,bairro,cep,telefone,contato,email,observacao,digito_verificador,operador_alteracao_id,operador_alteracao_nome,datahora_alteracao" +
                " FROM Fornecedor WHERE excluido=0");
                }
                else
                {
                    return utilitarios.RealizaConexaoBd("SELECT id,cnpj,fantasia,razao,CASE status WHEN 1 THEN 'true' ELSE 'false' END status,endereco,numero" +
                ",complemento,cidade,bairro,cep,telefone,contato,email,observacao,digito_verificador,operador_alteracao_id,operador_alteracao_nome,datahora_alteracao" +
                " FROM Fornecedor WHERE excluido=0 AND cnpj=@criterio OR razao LIKE @criterio OR fantasia LIKE @criterio",parametros);
                }
                
            }catch(Exception ex)
            {
                throw new System.Exception(ex.Message);
            }
        }
        public FornecedorModelo GetFornecedorById(long id)
        {
            DataTable dtFornecedor = new DataTable();
            FornecedorModelo fornecedor = new FornecedorModelo();
            try
            {                
                fornecedor.FornecedorId  = id;
                dtFornecedor = utilitarios.RealizaConexaoBd("SELECT * FROM Fornecedor WHERE id=@id",RetornaParametros(fornecedor));
                if(dtFornecedor.Rows.Count > 0)
                {
                    fornecedor.FornecedorId = long.Parse(dtFornecedor.Rows[0]["id"].ToString());
                    fornecedor.CNPJ = dtFornecedor.Rows[0]["cnpj"].ToString();
                    fornecedor.Fantasia = dtFornecedor.Rows[0]["fantasia"].ToString();
                    fornecedor.Razao = dtFornecedor.Rows[0]["razao"].ToString();
                    fornecedor.Status = dtFornecedor.Rows[0]["status"].ToString() == "1" ? true : false;
                    fornecedor.Endereco = dtFornecedor.Rows[0]["endereco"].ToString();
                    fornecedor.Numero = int.Parse(dtFornecedor.Rows[0]["numero"].ToString());
                    fornecedor.Complemento = dtFornecedor.Rows[0]["complemento"].ToString();
                    fornecedor.Cidade = dtFornecedor.Rows[0]["cidade"].ToString();
                    fornecedor.Bairro = dtFornecedor.Rows[0]["bairro"].ToString();
                    fornecedor.CEP = dtFornecedor.Rows[0]["cep"].ToString();
                    fornecedor.Telefone = int.Parse(dtFornecedor.Rows[0]["telefone"].ToString());
                    fornecedor.NomeContato = dtFornecedor.Rows[0]["contato"].ToString();
                    fornecedor.Email = dtFornecedor.Rows[0]["email"].ToString();
                    fornecedor.Observacao = dtFornecedor.Rows[0]["observacao"].ToString();
                    fornecedor.DigitoVerificadorCnpj = dtFornecedor.Rows[0]["digito_verificador"].ToString();
                }
                else
                {
                    fornecedor.FornecedorId = 0;
                }
                
            }
            catch(Exception ex) {
                throw new System.Exception(ex.Message);
            }
            return fornecedor;
        }
        private List<SqlParametro> RetornaParametros(FornecedorModelo fornecedor)
        {
            List<SqlParametro> list = new List<SqlParametro>();
            list.Add(new SqlParametro { Nome = "@id", Valor = fornecedor.FornecedorId });
            list.Add(new SqlParametro { Nome = "@cnpj", Valor = fornecedor.CNPJ });
            list.Add(new SqlParametro { Nome = "@fantasia", Valor = fornecedor.Fantasia });
            list.Add(new SqlParametro { Nome = "@razao", Valor = fornecedor.Razao });
            list.Add(new SqlParametro { Nome = "@status", Valor = fornecedor.Status ? 1 : 0 });
            list.Add(new SqlParametro { Nome = "@endereco", Valor = fornecedor.Endereco });
            list.Add(new SqlParametro { Nome = "@numero", Valor = fornecedor.Numero });
            list.Add(new SqlParametro { Nome = "@complemento", Valor = fornecedor.Complemento });
            list.Add(new SqlParametro { Nome = "@cidade", Valor = fornecedor.Cidade });
            list.Add(new SqlParametro { Nome = "@bairro", Valor = fornecedor.Bairro });
            list.Add(new SqlParametro { Nome = "@cep", Valor = fornecedor.CEP });
            list.Add(new SqlParametro { Nome = "@telefone", Valor = fornecedor.Telefone });
            list.Add(new SqlParametro { Nome = "@contato", Valor = fornecedor.NomeContato });
            list.Add(new SqlParametro { Nome = "@email", Valor = fornecedor.Email });
            list.Add(new SqlParametro { Nome = "@observacao", Valor = fornecedor.Observacao });
            list.Add(new SqlParametro { Nome = "@digitoVerificador", Valor = fornecedor.DigitoVerificadorCnpj });
            list.Add(new SqlParametro { Nome = "@operadorId", Valor = SessaoUsuario.ID });
            list.Add(new SqlParametro { Nome = "@operadorNome", Valor = SessaoUsuario.Nome });
            list.Add(new SqlParametro { Nome = "@dataAlteracao", Valor = DateTime.Now });
            list.Add(new SqlParametro { Nome = "@excluido", Valor = fornecedor.Excluido });            

            return list;
        }
        #endregion






    }
}
