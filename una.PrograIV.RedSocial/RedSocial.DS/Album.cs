using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace RedSocial.DS
{
 public   class Album:IAlbum
    {
        int IAlbum.AgregarAlbum(Datos.Album al)
        {
            SqlConnection cnn = new SqlConnection("Data source=DANIELA-PC; Initial Catalog=RedSocialDaSay; Integrated Securited=True");
            SqlCommand cmd = new SqlCommand("AgregarAlbum", cnn);

            try
            {
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdAlbum", al.IdAlbum);
                cmd.Parameters.AddWithValue("@IdUsuario", al.IdUsuario);
                cmd.Parameters.AddWithValue("@IdFoto", al.IdFoto);
                cmd.Parameters.AddWithValue("@NomAlbum", al.NomAlbum);
                cnn.Open();
                return cmd.ExecuteNonQuery();
            }

            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (cnn.State == System.Data.ConnectionState.Open)

                    cnn.Close();
            }
        
        }
    }
}
