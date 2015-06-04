using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace RedSocial.DS
{
   public class Amigo:IAmigo
    {
        int IAmigo.AgregarAmigo(Datos.Amigo am)
        {
            SqlConnection cnn = new SqlConnection("Data source=SARAH-PC; Initial Catalog=RedSocialDaSay; Integrated Securited=True");
            SqlCommand cmd = new SqlCommand("AgregarAmigo", cnn);

            try
            {
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdAmigo", am.IdAmigo);
                cmd.Parameters.AddWithValue("@IdUsuario", am.IdUsuario);
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
