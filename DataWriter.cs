﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.Data;

namespace RSSReader
{
    class DataWriter
    {
        public static object XmlDisplay { get; private set; }

        public static void Write()
        {


            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = "Server=localhost\\SQLEXPRESS;Database=RSSReader;Trusted_Connection=true";

                string query = "INSERT INTO tabela1(kol 1, kol2, kol3) VALUES (czas, opis, url)";

                //user  iduser,id cat, feeds, category


            }


        }

        public static void ZapisTest(Post wpis)
        {

            string strCon = @"Data Source=SONY\MYSQLSERVER;" + "Initial Catalog=pubs;Integrated Security=SSPI";
            SqlConnection con = new SqlConnection(strCon);
            con.Open();
            try
            {
                string strSql = "INSERT INTO Feeds(Date, Title, Url) VALUES ("+wpis.PublishedDate+","+wpis.Title+", "+wpis.link+")";
                SqlCommand cmd = new SqlCommand(strSql, con);
                DataSet dset = new DataSet();
                cmd.ExecuteNonQuery();
                dset.ReadXml(cmd.ExecuteXmlReader(), XmlReadMode.Fragment);
                // XmlDisplay.DocumentContent = dset.GetXml();
            }
            finally
            {
                con.Close();
            }


        }

        public static void Connect()
        {
            //setup the global SqlConnection object and constr in your class
        SqlConnection con = null;
        string constr = "Integrated Security=SSPI;" +
        "Initial Catalog=RSSReader;" +
        "Data Source=localhost\\SQLEXPRESS;";

        //void fnGetConnection()
        //{
        //    try
        //    {
        //        // setup the database connection
        //        con = new SqlConnection(constr);
        //        con.Open();
        //    }
        //    catch (Exception ex)
        //    {
        //       // MessageBox.Show("Error in connection : " + ex.Message);
        //    }
        //    finally
        //    {
        //        // dispose of open objects
        //        if (con != null)
        //            con.Close();
        //    } //finally
        //}
    }


}




}
