using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedSocial.BS
{
    class Publicacion:IPublicacion
    {
        int IPublicacion.AgregarPublicacion(Datos.Publicacion pu)
        {
            DS.IPublicacion ds = new DS.Publicacion();
            return ds.AgregarPublicacion(pu);
        }
    }
}
