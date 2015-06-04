using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedSocial.BS
{
    class Album:IAlbum
    {

        int IAlbum.AgregarAlbum(Datos.Album al)
        {
            DS.IAlbum ds = new DS.Album();
            return ds.AgregarAlbum(al);
        }
    }
}
