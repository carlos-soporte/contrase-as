﻿using System;
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
            SqlConnection connection = new SqlConnection("server=MSI; database=banco_contraseña ; integrated security = true");
            connection.Open();

            DataSet ds = new DataSet();
            SqlDataAdapter dp = new SqlDataAdapter(query, connection);
            dp.Fill(ds);
            connection.Close();

            return ds;
        }
    }
}
