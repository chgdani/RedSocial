using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace RedSocial.DS
{
    public class Publicacion : IPublicacion
    {
        int IPublicacion.AgregarPublicacion(Datos.Publicacion pu)
        {
            SqlConnection cnn = new SqlConnection("Data source=DANIELA-PC; Initial Catalog=RedSocialDaSay; Integrated Securited=True");
            SqlCommand cmd = new SqlCommand("AgregarPublicacion", cnn);

            try
            {
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdPublicacion", pu.IdPublicacion);
                cmd.Parameters.AddWithValue("@Imagen", pu.Imagen);
                cmd.Parameters.AddWithValue("@Texto", pu.Texto);
                cmd.Parameters.AddWithValue("@Video", pu.Video);
                cmd.Parameters.AddWithValue("@Fecha", pu.Fecha);
                cmd.Parameters.AddWithValue("@Email", pu.Email);

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
