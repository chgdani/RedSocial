using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedSocial.BS
{
    class Amigo:IAmigo
    {

        public int AgregarAmigo(Datos.Amigo am)
        {
            DS.IAmigo ds = new DS.Amigo();
            return ds.AgregarAmigo(am);
        }
    }
}
