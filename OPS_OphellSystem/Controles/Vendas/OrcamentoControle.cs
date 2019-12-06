using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelos;
using OPS_OphellSystem;
using Dao;


namespace Vendas.Controles
{
    public class OrcamentoControle
    {
        public OrcamentoControle()
        {

        }
        public void CalculaVenda()
        {

        }

        public List<OrcamentoModelo> GetAllOrcamentos()
        {
            return new List<OrcamentoModelo>();
        }
        public OrcamentoModelo GetOrcamentoById(long id)
        {
            OrcamentoModelo orcamento = new OrcamentoModelo();
            try
            {
                OrcamentoDao dao = new OrcamentoDao();
                orcamento =  dao.GetorcamentoById(id);
            }
            catch(Exception ex)
            {
                throw new System.Exception(ex.Message);
            }
            
            return orcamento;
        }
        public List<OrcamentoModelo> SelectAll()
        {
            OrcamentoDao dao = new OrcamentoDao();
            return dao.SelectAll();
        }
        public void GravaOrcamento(OrcamentoModelo modelo)
        {
            if(modelo != null)
            {
                OrcamentoDao dao = new OrcamentoDao();
                dao.Create(modelo);
            }
        }
    }
}
