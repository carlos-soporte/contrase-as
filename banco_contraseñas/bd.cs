using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace banco_contraseñas
{
    class bd
    {
        public static DataSet consultar(string query)
        {
            SqlConnection connection = new SqlConnection("server=192.168.1.181; database=banco_contraseña ; user id=duban_adm; password=3ps1-sqlbd.*");
            connection.Open();

            DataSet ds = new DataSet();
            SqlDataAdapter dp = new SqlDataAdapter(query, connection);
            dp.Fill(ds);
            connection.Close();

            return ds;
        }
    }
}
