using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Zainal_PPL_Inventory
{
    public partial class FLogin : Form
    {
        public FLogin()
        {
            InitializeComponent();
            DatabaseManipulation DM = new DatabaseManipulation();
            DM.Koneksi();

        }

    
        SqlConnection CONN = new SqlConnection();
        SqlCommand CMD = new SqlCommand();
 
       
        
        public void refresLogin()
        {
            txtusername.Text = "";
            txtpassword.Text = "";
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            if (txtusername.Text == "" || txtpassword.Text == "")
            {
                MessageBox.Show("Username Atau Password Anda Belum Diisi, Mohon Cek Kembali", "informasi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                SqlDataReader DR;
                CONN.ConnectionString = "Data Source=DESKTOP-40C57RP;Initial Catalog=SMKInventoryDB;Integrated Security=True";
                CONN.Open();
                CMD = new SqlCommand("SELECT * FROM Member WHERE username='" + txtusername.Text + "'AND password='" + txtpassword.Text + "'", CONN);
                DR = CMD.ExecuteReader();
                DR.Read();
                if (DR.HasRows)
                {

                    Fmenu FM = new Fmenu();
                    FM.txtnamalvl.Text = DR["role"].ToString();     
                    FM.Show();
                    this.Hide();
                    refresLogin();
                    DR.Close();
                }
                else
                {
                    MessageBox.Show("Login Gagal, Silahkan Mencoba Kembali", "informasi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    DR.Close();
                    refresLogin();
                }
            }
        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
