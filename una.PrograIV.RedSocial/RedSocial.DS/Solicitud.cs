using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace RedSocial.DS
{
    public class Solicitud : ISolicitud
    {
        int ISolicitud.AgregarSolicitud(Datos.Solicitud so)
        {
            {
                SqlConnection cnn = new SqlConnection("Data source=DANIELA-PC; Initial Catalog=RedSocialDaSay; Integrated Securited=True");
                SqlCommand cmd = new SqlCommand("AgregarSolicitud", cnn);

                try
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@IdSolicitud", so.IdSolicitud);
                    cmd.Parameters.AddWithValue("@Fecha", so.Fecha);
                    cmd.Parameters.AddWithValue("@Email", so.Email);

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
}
