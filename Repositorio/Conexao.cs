﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio
{
   public class Conexao
    {
        SqlConnection con = new SqlConnection();

        public static System.Configuration.ConnectionStringSettingsCollection ConnectionString { get; }

        public Conexao() 
        {
            var connectionString = ConfigurationManager.ConnectionStrings["VilaDB"].ConnectionString;
            con.ConnectionString = connectionString;
        }

        public SqlConnection conectar() 
        {
            if (con.State == System.Data.ConnectionState.Closed) 
            {
                con.Open();
            }

            return con;
        }

        public void desconectar() 
        {
            if (con.State == System.Data.ConnectionState.Open) 
            {
                con.Close();
            }
        }

    }
}
