using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OPS_OphellSystem;

namespace Modelos
{
   public class PerfilModelo
    {
        public long PerfilId { get; set; }
        public string Descricao { get; set; }

        public List<PerfilModelo> GetPerfis()
        {
            List<PerfilModelo> list = new List<PerfilModelo>();
            try
            {
                DataTable dtDados = new DataTable();
                dtDados = utilitarios.RealizaConexaoBd("SELECT * FROM Perfil WHERE excluido=0");

                if(dtDados.Rows.Count > 0)
                {
                    foreach(DataRow row in dtDados.Rows)
                    {
                        list.Add(new PerfilModelo()
                        {
                            Descricao = row["descricao"].ToString(),
                            PerfilId = long.Parse(row["id"].ToString())
                        });
                    }
                }
            }catch(Exception ex) {
                throw new System.Exception(ex.Message);
            }
            return list;
        }
    }
}
