using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//import library form
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Globalization;
using System.Data.SqlClient;


namespace Zainal_PPL_Inventory
{
    class DatabaseManipulation
    {
        SqlCommand CMD;
        SqlConnection CONN;
        SqlDataAdapter DA;
    

        public void Koneksi()
        {
            CONN = new SqlConnection("Data Source=DESKTOP-40C57RP;Initial Catalog=SMKInventoryDB;Integrated Security=True");
            try
            {
                if (CONN.State != ConnectionState.Open) {
                    CONN.Open();
                }
               
            }
            catch {
                MessageBox.Show("Gagal Koneksi Database", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(0);
            }
        } 

        //constructor
   
        public void FechDatagrid(string _query, DataGridView DGV)
        {
            Koneksi();
            DA = new SqlDataAdapter(_query, CONN);
            DataSet DS = new DataSet();
            DA.Fill(DS);
            DGV.DataSource = DS.Tables[0];
        }
        public void querysql(string _query)
        {
            CMD = new SqlCommand(_query, CONN);
            CMD.ExecuteNonQuery();
        }


    }
}
