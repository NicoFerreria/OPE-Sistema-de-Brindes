using System;
using System.Collections.Generic;
using System.Data;
using Cadastros.Modelos;
using OPS_OphellSystem;

namespace Cadastros.Controles
{
    public class ProdutoControle
    {
        #region "Classes"
        #endregion

        #region "Variáveis"
       private ProdutoModelo _produto;
        #endregion

        #region "Propriedades"
        #endregion

        #region "Metodos"
        public ProdutoControle(ProdutoModelo produto)
        {
            _produto = produto;
        }
        public void GravarProduto()
        {
            try
            {
                if(ValidaDadosProduto() == false)
                {
                    return;
                }

                DataTable dtDados = new DataTable();

                dtDados = utilitarios.RealizaConexaoBd("SELECT id FROM Produto WHERE codigo=@codigo AND excluido=0",parametros());

                if (dtDados.Rows.Count <= 0)
                {
                    utilitarios.RealizaConexaoBd("INSERT INTO Produto(codigo,nome,descricao,cor,observacao,status) VALUES" +
                        " (@codigo,@nome,@descricao,@cor,@observacao,@status)",parametros());
                }
                else
                {
                    AtualizaProduto();
                }

            }catch(Exception ex)
            {
                throw new System.Exception(ex.Message);
            }
        }
        private void AtualizaProduto()
        {
            try
            {
                if (_produto.Codigo <= 0) throw new System.Exception("Código de produto inválido!");
                DataTable dtDados = new DataTable();

                dtDados = utilitarios.RealizaConexaoBd("SELECT id FROM Produto WHERE codigo=@codigo AND excluido=0",parametros());
                if (dtDados.Rows.Count > 0)
                {
                    _produto.ProdutoID = long.Parse(dtDados.Rows[0]["id"].ToString());
                    utilitarios.RealizaConexaoBd("UPDATE Produto SET nome=@nome,desricao=@descricao,cor=@cor,observacao=@observacao,status=@status WHERE id=@id",
                        parametros());
                }                
            }catch(Exception ex)
            {
                throw new System.Exception(ex.Message);
            }
        }
        #endregion

        #region "Funcoes"
        private bool ValidaDadosProduto()
        {
            try
            {
                if(_produto.Codigo <= 0)
                {
                    throw new System.Exception("Código do produto informado não é válido!");
                }

                if(_produto.Nome == "")
                {
                    throw new System.Exception("Nome do produto informado é inválido!");
                }


            }catch(Exception ex)
            {
                throw new System.Exception(ex.Message);
            }

            return true;
        }
        private List<SqlParametro> parametros()
        {
            List<SqlParametro> parametros = new List<SqlParametro>();
            try
            {
                parametros.Add(new SqlParametro { Nome = "@id", Valor = _produto.ProdutoID });
                parametros.Add(new SqlParametro { Nome = "@codigo", Valor = _produto.Codigo });
                parametros.Add(new SqlParametro { Nome = "@nome", Valor = _produto.Nome });
                parametros.Add(new SqlParametro { Nome = "@descricao", Valor = _produto.Descricao });
                parametros.Add(new SqlParametro { Nome = "@cor", Valor = _produto.Cor });
                parametros.Add(new SqlParametro { Nome = "@observacao", Valor = _produto.Observacao });
                parametros.Add(new SqlParametro { Nome = "@status", Valor = _produto.Status? 1 : 0 });
            }
            catch(Exception ex)
            {
                throw new System.Exception(ex.Message);
            }

            return parametros;
        }
        #endregion
    }
}
