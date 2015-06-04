using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace RedSocial.DS
{
   public class Usuario:IUsuario
    {
        int IUsuario.AgregarUsuario(Datos.Usuario us)
        {
            {
                SqlConnection cnn = new SqlConnection("Data source=DANIELA-PC; Initial Catalog=RedSocialDaSay; Integrated Securited=True");
                SqlCommand cmd = new SqlCommand("AgregarUsuarion", cnn);

                try
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@IdUsuario", us.IdUsuario);
                    cmd.Parameters.AddWithValue("@Email", us.Email);
                    cmd.Parameters.AddWithValue("@Contraseña", us.Contraseña);
                    cmd.Parameters.AddWithValue("@FecNacimiento", us.FecNacimiento);
                    cmd.Parameters.AddWithValue("@Nombre", us.Nombre);
                    cmd.Parameters.AddWithValue("@Apellidos", us.Apellidos);
                    cmd.Parameters.AddWithValue("@Sexol", us.IdUsuario);

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
