using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cadastros.Modelos;
using OPS_OphellSystem;
using OPS_OphellSystem.Dados;

namespace Cadastros.Controles
{
   public class FornecedorControle
    {


        #region "Classes"
        FornececedorDados _context = new FornececedorDados();
        #endregion

        #region "Variaveis"
        #endregion

        #region "Propriedades"
        #endregion

        #region "Metodos"
        public FornecedorControle()
        {
            
        }
        public void DeleteFornecedor(FornecedorModelo fornecedor)
        {
            fornecedor.Excluido = 1;
            _context.Add(fornecedor);
            _context.Save();
        }
        public void GravarFornecedor(FornecedorModelo fornecedor)
        {
            _context.Add(fornecedor);
            _context.Save();
        }        
        #endregion

        #region "Funções"
        public List<FornecedorModelo> GetListaFornecedores()
        {
            return _context.Fornecedores; 
        }
        public FornecedorModelo GetFornecedorById(long id)
        {
            try
            {
               return _context.GetFornecedorById(id);
            }catch(Exception ex) {
                throw new System.Exception(ex.Message);
            }
        }        
        
        #endregion






    }
}
