using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace RedSocial.DS
{
    public class Comentario : IComentario
    {
        int IComentario.AgregarComentario(Datos.Comentario co)
        {
            SqlConnection cnn = new SqlConnection("Data source=DANIELA-PC; Initial Catalog=RedSocialDaSay; Integrated Securited=True");
            SqlCommand cmd = new SqlCommand("AgregarComentario", cnn);

            try
            {
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdComentario", co.IdComenterio);
                cmd.Parameters.AddWithValue("@IdPublicacion", co.IdPublicacion);
                cmd.Parameters.AddWithValue("@Texto", co.Texto);
                cmd.Parameters.AddWithValue("@Fecha", co.Fecha);
                
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
