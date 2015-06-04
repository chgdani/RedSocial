using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace RedSocial.DS
{
    public class Perfil : IPerfil
    {
        int IPerfil.AgregarPerfil(Datos.Perfil pe)
        {
            SqlConnection cnn = new SqlConnection("Data source=DANIELA-PC; Initial Catalog=RedSocialDaSay; Integrated Securited=True");
            SqlCommand cmd = new SqlCommand("AgregarPerfil", cnn);

            try
            {
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdUsuario", pe.IdUsuario);
                cmd.Parameters.AddWithValue("@IdPerfil", pe.IdPerfil);
                cmd.Parameters.AddWithValue("@Direccion", pe.Direccion);
                cmd.Parameters.AddWithValue("@EstCivil", pe.EstCivil);
                cmd.Parameters.AddWithValue("@Ocupacion", pe.Ocupacion);
                cmd.Parameters.AddWithValue("@Estudios", pe.Estudios);
                cmd.Parameters.AddWithValue("@Contraseña", pe.Contraseña);
                cmd.Parameters.AddWithValue("@Estado", pe.Estado);



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
