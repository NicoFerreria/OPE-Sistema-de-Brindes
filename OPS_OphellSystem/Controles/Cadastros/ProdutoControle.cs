using System;
using System.Collections.Generic;
using System.Data;
using Modelos;
using OPS_OphellSystem;

namespace Cadastros.Controles
{
    public class ProdutoControle
    {
        #region "Classes"
        #endregion

        #region "Variáveis"
       
        #endregion

        #region "Propriedades"
        #endregion

        #region "Metodos"
        public ProdutoControle()
        {
            
        }
        public void GravarProduto(ProdutoModelo produto)
        {
            try
            {
                if(ValidaDadosProduto(produto) == false)
                {
                    return;
                }

                DataTable dtDados = new DataTable();

                dtDados = utilitarios.RealizaConexaoBd("SELECT id FROM Produto WHERE codigo=@codigo AND excluido=0",parametros(produto));

                if (dtDados.Rows.Count <= 0)
                {
                    utilitarios.RealizaConexaoBd("INSERT INTO Produto(codigo,nome,descricao,cor,observacao,status) VALUES" +
                        " (@codigo,@nome,@descricao,@cor,@observacao,@status)",parametros(produto));
                }
                else
                {
                    AtualizaProduto(produto);
                }

            }catch(Exception ex)
            {
                throw new System.Exception(ex.Message);
            }
        }
        private void AtualizaProduto(ProdutoModelo produto)
        {
            try
            {
                if (produto.Codigo <= 0) throw new System.Exception("Código de produto inválido!");
                DataTable dtDados = new DataTable();

                dtDados = utilitarios.RealizaConexaoBd("SELECT id FROM Produto WHERE codigo=@codigo AND excluido=0",parametros(produto));
                if (dtDados.Rows.Count > 0)
                {
                    produto.ProdutoID = long.Parse(dtDados.Rows[0]["id"].ToString());
                    utilitarios.RealizaConexaoBd("UPDATE Produto SET nome=@nome,desricao=@descricao,cor=@cor,observacao=@observacao,status=@status WHERE id=@id",
                        parametros(produto));
                }                
            }catch(Exception ex)
            {
                throw new System.Exception(ex.Message);
            }
        }        
        
        #endregion

        #region "Funcoes"
        private bool ValidaDadosProduto(ProdutoModelo produto)
        {
            try
            {
                if(produto.Codigo <= 0)
                {
                    throw new System.Exception("Código do produto informado não é válido!");
                }

                if(produto.Nome == "")
                {
                    throw new System.Exception("Nome do produto informado é inválido!");
                }


            }catch(Exception ex)
            {
                throw new System.Exception(ex.Message);
            }

            return true;
        }
        private List<SqlParametro> parametros(ProdutoModelo produto)
        {
            List<SqlParametro> parametros = new List<SqlParametro>();
            try
            {
                parametros.Add(new SqlParametro { Nome = "@id", Valor = produto.ProdutoID });
                parametros.Add(new SqlParametro { Nome = "@codigo", Valor = produto.Codigo });
                parametros.Add(new SqlParametro { Nome = "@nome", Valor = produto.Nome });
                parametros.Add(new SqlParametro { Nome = "@descricao", Valor = produto.Descricao });
                parametros.Add(new SqlParametro { Nome = "@cor", Valor = produto.Cor });
                parametros.Add(new SqlParametro { Nome = "@observacao", Valor = produto.Observacao });
                parametros.Add(new SqlParametro { Nome = "@status", Valor = produto.Status? 1 : 0 });
            }
            catch(Exception ex)
            {
                throw new System.Exception(ex.Message);
            }

            return parametros;
        }
        public ProdutoModelo GetProduto(long codigo)
        {
            ProdutoModelo produto = new ProdutoModelo();
            try
            {
                DataTable dtDados = new DataTable();
                produto.Codigo = codigo;
                dtDados = utilitarios.RealizaConexaoBd("SELECT * FROM Produto WHERE codigo=@codigo AND excluido=0",parametros(produto));
                if(dtDados.Rows.Count > 0)
                {
                    produto.ProdutoID = long.Parse(dtDados.Rows[0]["id"].ToString());
                    produto.Codigo = long.Parse(dtDados.Rows[0]["codigo"].ToString());
                    produto.Nome = dtDados.Rows[0]["nome"].ToString();
                    produto.Descricao = dtDados.Rows[0]["descricao"].ToString();
                    produto.Cor = dtDados.Rows[0]["cor"].ToString();
                    produto.Observacao = dtDados.Rows[0]["observacao"].ToString();
                    produto.Status = (dtDados.Rows[0]["status"].ToString() == "1");
                }
            }catch(Exception ex)
            {
                throw new System.Exception(ex.Message);
            }

            return produto;
        }
        public ProdutoModelo GetProdutoById(long id)
        {
            ProdutoModelo produto = new ProdutoModelo();
            try
            {
                DataTable dtDados = new DataTable();
                produto.ProdutoID = id;
                dtDados = utilitarios.RealizaConexaoBd("SELECT * FROM Produto WHERE id=@id AND excluido=0", parametros(produto));
                if (dtDados.Rows.Count > 0)
                {
                    produto.ProdutoID = long.Parse(dtDados.Rows[0]["id"].ToString());
                    produto.Codigo = long.Parse(dtDados.Rows[0]["codigo"].ToString());
                    produto.Nome = dtDados.Rows[0]["nome"].ToString();
                    produto.Descricao = dtDados.Rows[0]["descricao"].ToString();
                    produto.Cor = dtDados.Rows[0]["cor"].ToString();
                    produto.Observacao = dtDados.Rows[0]["observacao"].ToString();
                    produto.Status = (dtDados.Rows[0]["status"].ToString() == "1");
                }
            }
            catch (Exception ex)
            {
                throw new System.Exception(ex.Message);
            }

            return produto;
        }
        public DataTable RetornaDataTableTodosProdutos()
        {
            try
            {
                DataTable dtDados = new DataTable();                
                dtDados =  utilitarios.RealizaConexaoBd("SELECT id,codigo,nome,descricao,cor,excluido,observacao,CASE status WHEN 1 THEN 'true' ELSE 'false' END status" +
                    " FROM Produto WHERE excluido=0");
                return dtDados;
                
            }catch(Exception ex)
            {
                throw new System.Exception(ex.Message);
            }
        }

        public bool ExcluirProduto(ProdutoModelo produto)
        {
            try
            {
                utilitarios.RealizaConexaoBd("UPDATE Produto SET excluido=1 WHERE id=@id AND excluido=0",parametros(produto));
            }catch(Exception ex)
            {
                throw new System.Exception(ex.Message);
            }
            return true;
        }
        #endregion
    }
}
