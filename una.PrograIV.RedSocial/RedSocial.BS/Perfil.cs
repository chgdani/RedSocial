using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedSocial.BS
{
    class Perfil:IPerfil
    {

        int IPerfil.AgregarPerfil(Datos.Perfil pe)
        {
            DS.IPerfil ds = new DS.Perfil();
            return ds.AgregarPerfil(pe);
        }
    }
}
