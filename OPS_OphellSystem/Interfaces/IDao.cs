using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelos;

namespace Interfaces
{
   public interface IDao<t> where t : new()
    {
        void Create(t modelo);
        void Update(t modelo);
        void Delete(t modelo);        
    }
}
