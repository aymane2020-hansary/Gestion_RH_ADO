using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Gestion_R_humaine
{
    public class ADO
    {
        //Déclaration des objets des modes connéctés
        public SqlConnection con = new SqlConnection();
        public SqlCommand cmd = new SqlCommand();
        public SqlDataReader dr;
        //Pour travailler avec datatable il faut importer le USING SYSTEM.DATA;
        public DataTable dt = new DataTable();

        //Décalaration de la méthode Connecter
        public void connecter()
        {
            if (con.State == ConnectionState.Closed || con.State == ConnectionState.Broken)
            {
                con.ConnectionString = @"Data Source=DESKTOP-3H6VK5U;Initial Catalog=Gestion_RH;Integrated Security=True";
                con.Open();
            }
        }
        //Décalaration de la méthode Deconnecter
        public void deconnecter()
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }
    }
}
