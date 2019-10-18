using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cadastros.Modelos;
using OPS_OphellSystem;

namespace Cadastros.Controles
{
    public class PerfilControle
    {


        #region "Metodos"
        public PerfilControle()
        {

        }
        public bool Gravar(PerfilModelo perfil)
        {
            try
            {
                if (perfil == null) throw new System.Exception("Perfil não pode ser nulo!");
                if (ValidaPerfil(perfil) == false) return false;
                if(perfil.PerfilId == 0)
                {
                    utilitarios.RealizaConexaoBd("INSERT INTO perfil(descricao)VALUES(@descricao)",parametro(perfil));
                }
                else
                {
                    utilitarios.RealizaConexaoBd("UPDATE perfil SET descricao=@descricao WHERE id=@id",parametro(perfil));
                }
            }catch(Exception ex)
            {
                throw new System.Exception(ex.Message);
            }
            return true;
        }
        public bool Excluir(long id)
        {
            try
            {
                if (id <= 0) throw new System.Exception("Id não pode ser menor ou igual a 0!");
                utilitarios.RealizaConexaoBd("UPDATE perfil SET excluido=0 WHERE id=@id");
            }catch (Exception ex)
            {
                throw new System.Exception(ex.Message);
            }
            return true;
        }
        #endregion

        #region "Funções"
        public DataTable RetornaDataTablePerfil()
        {
            try
            {
                return utilitarios.RealizaConexaoBd("SELECT * FROM perfil");
            }catch(Exception ex)
            {
                throw new System.Exception(ex.Message);
            }
        }
        private bool ValidaPerfil(PerfilModelo perfil)
        {
            try
            {
                if (perfil.Descricao == "") throw new System.Exception("A descrição do Perfil não pode estar vazia!");
            }catch(Exception ex)
            {
                throw new System.Exception(ex.Message);
            }
            return true;
        }
        private List<SqlParametro> parametro(PerfilModelo perfil)
        {
            List<SqlParametro> list = new List<SqlParametro>();
            try
            {
                list.Add(new SqlParametro() { Nome = "@id", Valor = perfil.PerfilId });
                list.Add(new SqlParametro() { Nome = "@descricao", Valor = perfil.Descricao });                
            }catch(Exception ex)
            {
                throw new System.Exception(ex.Message);
            }
            return list;
        }
        #endregion
    }
}
