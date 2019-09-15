using System;
using System.Collections.Generic;
using System.Data;
using Cadastros.Modelos;
using OPS_OphellSystem;

namespace Cadastros.Controles
{
    public class FormasPagamentoControle
    {
        #region "Classes"
        #endregion

        #region "Variaveis"
        List<SqlParametro> parametros;
        #endregion

        #region "Metodos"
        public FormasPagamentoControle()
        {

        }
        public void GravarFormaPagamento(FormaPagamentoModelo formaPagamento)
        {
            try
            {
                DataTable dtDados = new DataTable();

                dtDados = utilitarios.RealizaConexaoBd("SELECT id FROM FormasPagamento WHERE id=@id AND excluido=0", RetornaParametros(formaPagamento));
                if (dtDados.Rows.Count <= 0)
                {
                    utilitarios.RealizaConexaoBd("INSERT INTO FormasPagamento(descricao,tipo,status)VALUES(@descricao,@tipo,@status)", RetornaParametros(formaPagamento));
                }
                else
                {
                    utilitarios.RealizaConexaoBd("UPDATE FormasPagamento SET descricao=@descricao,tipo=@tipo,status=@status WHERE id=@id", RetornaParametros(formaPagamento));
                }
            }
            catch (Exception ex)
            {
                throw new System.Exception(ex.Message);
            }
        }
        public void ExcluiFormaPagamento(FormaPagamentoModelo formaPagamento)
        {
            try
            {
                if (formaPagamento.FormasPafamentoId <= 0) throw new System.Exception("Id da forma de recebimento inválido!");
                utilitarios.RealizaConexaoBd("UPDATE FormasPagamento SET excluido=1 WHERE id=@id", RetornaParametros(formaPagamento));
            }
            catch (Exception ex)
            {
                throw new System.Exception(ex.Message);
            }
        }
        #endregion

        #region "Funcoes"
        private List<SqlParametro> RetornaParametros(FormaPagamentoModelo formaPagamento)
        {
            parametros = new List<SqlParametro>();
            parametros.Add(new SqlParametro() { Nome = "@id", Valor = formaPagamento.FormasPafamentoId });
            parametros.Add(new SqlParametro() { Nome = "@descricao", Valor = formaPagamento.Descricao });
            parametros.Add(new SqlParametro() { Nome = "@tipo", Valor = formaPagamento.Tipo });
            parametros.Add(new SqlParametro() { Nome = "@status", Valor = formaPagamento.Status ? 1 : 0 });

            return parametros;
        }
        public DataTable GetAllFormasPagamento()
        {
            try
            {
                return utilitarios.RealizaConexaoBd("SELECT id,tipo,descricao,CASE status WHEN 1 THEN 'true' ELSE 'false' END status FROM FormasPagamento WHERE excluido=0");

            }
            catch (Exception ex)
            {
                throw new System.Exception(ex.Message);
            }
        }
        #endregion 
    }
}
