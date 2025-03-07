using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ALQUILER
{
    public class SQLConnect
    {
        public static SqlConnection ObtenerConexion()
        {
            try
            {
                return new SqlConnection(@"server=.\SQLEXPRESS; Initial Catalog=ALQUILER; integrated security=true");
            }
            catch (Exception)
            {
                return new SqlConnection(@"Server=localhost;Database=ALQUILER;Trusted_Connection=True;");
            }
        }

    }
}
