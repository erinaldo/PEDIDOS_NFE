﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace WindowsFormsApplication3
{
    public class ConexCidade
    {
        public static DataTable CarregaCidades()
     {
         SqlConnection con = new SqlConnection();
            con.ConnectionString = Properties.Settings.Default.Ducaun;

            con.Open();
            SqlCommand Cmm = new SqlCommand();
            Cmm.CommandText = "Select * from cidades";
            Cmm.CommandType = CommandType.Text;
            Cmm.Connection = con;
            SqlDataReader DR;
            DR = Cmm.ExecuteReader();

            DataTable DT = new DataTable();
            DT.Load(DR);
            
            con.Close();
            return DT;
    }
}
}
