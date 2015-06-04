using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedSocial.BS
{
    class Comentario:IComentario
    {

        int IComentario.AgregarComentario(Datos.Comentario co)
        {
            DS.IComentario ds = new DS.Comentario();
            return ds.AgregarComentario(co);
        }
    }
}
