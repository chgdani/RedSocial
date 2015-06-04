using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedSocial.BS
{
    class Foto:IFoto
    {

        int IFoto.AgregarFoto(Datos.Foto fo)
        {
            DS.IFoto ds = new DS.Foto();
            return ds.AgregarFoto(fo);
        }
    }
}
