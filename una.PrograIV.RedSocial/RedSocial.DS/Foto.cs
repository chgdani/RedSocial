using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace RedSocial.DS
{
    public class Foto : IFoto
    {
        int IFoto.AgregarFoto(Datos.Foto fo)
        {
            SqlConnection cnn = new SqlConnection("Data source=DANIELA-PC; Initial Catalog=RedSocialDaSay; Integrated Securited=True");
            SqlCommand cmd = new SqlCommand("AgregarFoto", cnn);

            try
            {
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdFoto", fo.IdFoto);
                cmd.Parameters.AddWithValue("@IdUsuario", fo.IdUsuario);
                cmd.Parameters.AddWithValue("@Imagen", fo.Imagen);
                cmd.Parameters.AddWithValue("@Fecha", fo.Fecha);
                cmd.Parameters.AddWithValue("@Descripcion", fo.Descripcion);

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
