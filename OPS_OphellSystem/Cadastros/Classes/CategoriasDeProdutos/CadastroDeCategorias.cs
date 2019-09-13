using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPS_OphellSystem.Cadastros.Classes.CategoriasDeProdutos
{
    public class CadastroDeCategorias
    {
        #region "Classes"
        #endregion

        #region "Variaveis"
        private List<SqlParametro> parametros;
        #endregion

        #region "Propriedades"
        public int ID { get; set; }
        public int CodigoCategoria { get; set; }
        public string Descricao { get; set; }
        public string Categoria { get; set; }
        public string Cor { get; set; }
        public string Observacao { get; set; }
        public int Status { get; set; }
        #endregion

        #region "Metodos"
        public void GravarCategoria()
        {
            try
            {
                DataTable dtDados = new DataTable();
                if (Categoria == null)
                {
                    throw new System.Exception("Categoria inválida!");
                }
                if (Descricao == null)
                {
                    throw new System.Exception("Descrição inválida!");
                }

                dtDados = utilitarios.RealizaConexaoBd("SELECT id_prod FROM Produto WHERE codigo_prod=@codigo", RetornaParametros());
                if (dtDados.Rows.Count <= 0)
                {
                    utilitarios.RealizaConexaoBd("INSERT INTO Produto(codigo_prod,categoria_prod,desc_prod,cor_prod,obs_prod,status_prod)VALUES" +
                        "(@codigo,@categoria,@descricao,@cor,@observacao,@status)", RetornaParametros());
                }
                else
                {
                    ID = int.Parse(dtDados.Rows[0]["id_prod"].ToString());                    
                    utilitarios.RealizaConexaoBd("UPDATE Produto SET codigo_prod=@codigo,categoria_prod=@categoria,desc_prod=@descricao,cor_prod=@cor,obs_prod=@observacao,status_prod=@status WHERE id_prod=@id", RetornaParametros());
                }
            }
            catch (Exception ex)
            {
                throw new System.Exception(ex.Message);
            }
        }
        #endregion

        #region "Funcoes"
        public bool ConsultaCategoriaProcudoPeloCodigo()
        {
            try
            {
                DataTable dtDados = new DataTable();
                dtDados = utilitarios.RealizaConexaoBd("SELECT * FROM Produto WHERE codigo_prod=@codigo", RetornaParametros());
                if (dtDados.Rows.Count > 0)
                {
                    this.ID = int.Parse(dtDados.Rows[0]["id_prod"].ToString());
                    this.Categoria = dtDados.Rows[0]["categoria_prod"].ToString();
                    this.Descricao = dtDados.Rows[0]["desc_prod"].ToString();
                    this.Cor = dtDados.Rows[0]["cor_prod"].ToString();
                    this.Observacao = dtDados.Rows[0]["obs_prod"].ToString();
                    this.Status = int.Parse(dtDados.Rows[0]["status_prod"].ToString());
                    return true;
                }

                return false;
            }
            catch (Exception ex)
            {
                throw new System.Exception(ex.Message);
            }
        }
        public DataTable BuscaTodasAsCategorias()
        {
            try
            {
                DataTable dtDados = new DataTable();
                dtDados = utilitarios.RealizaConexaoBd("SELECT * FROM Produto", RetornaParametros());
                return dtDados;
            }
            catch (Exception ex)
            {
                throw new System.Exception(ex.Message);
            }
        }
        private List<SqlParametro> RetornaParametros()
        {
            try
            {
                parametros = new List<SqlParametro>();

                parametros.Add(new SqlParametro { Nome = "@id", Valor = ID });
                parametros.Add(new SqlParametro { Nome = "@codigo", Valor = CodigoCategoria });
                parametros.Add(new SqlParametro { Nome = "@descricao", Valor = Descricao });
                parametros.Add(new SqlParametro { Nome = "@categoria", Valor = Categoria });
                parametros.Add(new SqlParametro { Nome = "@cor", Valor = Cor });
                parametros.Add(new SqlParametro { Nome = "@observacao", Valor = Observacao });
                parametros.Add(new SqlParametro { Nome = "@status", Valor = Status });

                return parametros;
            }
            catch (Exception ex)
            {
                throw new System.Exception(ex.Message);
            }
        }
        #endregion
    }
}
