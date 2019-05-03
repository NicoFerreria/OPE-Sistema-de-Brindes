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

                dtDados = utilitarios.RealizaConexaoBd("SELECT id_prod FROM Produto WHERE codigo_prod='" + CodigoCategoria + "'");
                if (dtDados.Rows.Count <= 0)
                {
                    utilitarios.RealizaConexaoBd("INSERT INTO Produto(codigo_prod,categoria_prod,desc_prod,cor_prod,obs_prod,status_prod)VALUES" +
                        "('" + CodigoCategoria + "','" + Categoria + "','" + Descricao + "','" + Cor + "','" + Observacao + "','" + Status + "')");
                }
                else
                {
                    utilitarios.RealizaConexaoBd("UPDATE Produto SET categoria_prod='" + Categoria + "',desc_prod='" + Descricao + "',cor_prod='" + Cor +
                    "',obs_prod='" + Observacao + "',status_prod='" + Status + "' WHERE id_prod='" + dtDados.Rows[0]["id_prod"] + "'");
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
                dtDados = utilitarios.RealizaConexaoBd("SELECT * FROM Produto WHERE codigo_prod='" + CodigoCategoria + "'");
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
                dtDados = utilitarios.RealizaConexaoBd("SELECT * FROM Produto");
                return dtDados;
            }
            catch (Exception ex)
            {
                throw new System.Exception(ex.Message);
            }
        }
        #endregion
    }
}
