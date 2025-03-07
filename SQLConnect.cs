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
        static string EXPRESS = @"server=.\SQLEXPRESS; Initial Catalog=ALQUILER; integrated security=true";
        static string DEV = @"Server=localhost;Database=ALQUILER;Trusted_Connection=True;";
        public static SqlConnection ObtenerConexion()
        {
                return new SqlConnection(DEV);
        }

        

    }
}
