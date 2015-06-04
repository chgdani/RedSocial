using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedSocial.BS
{
    class Usuario:IUsuario
    {

        int IUsuario.AgregarUsuario(Datos.Usuario us)
        {
            DS.IUsuario ds = new DS.Usuario();
            return ds.AgregarUsuario(us);
        }
    }
}
