﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GIT_GITHUB
{
    public class Conexion
    {
        public static SqlConnection GetConexion()
        {
            string connectionString = "Data Source=localhost,1433;Initial Catalog=GIT;Integrated Security=True;";

            try
            {
                SqlConnection cnn = new SqlConnection(connectionString);
                cnn.Open();
                return cnn;
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e.Message);
                return null;
            }
        }
    }
}
