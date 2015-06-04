using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedSocial.BS
{
    class Solicitud:ISolicitud
    {

        int ISolicitud.AgregarSolicitud(Datos.Solicitud so)
        {
            DS.ISolicitud ds = new DS.Solicitud();
            return ds.AgregarSolicitud(so);

           
        }
    }
}
