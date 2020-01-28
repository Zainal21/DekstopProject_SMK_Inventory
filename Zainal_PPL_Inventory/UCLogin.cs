using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Zainal_PPL_Inventory
{
    public partial class UCLogin : UserControl
    {
         private static UCLogin I_instance;
         public static UCLogin Instance
         {
             get
             {
                 if (I_instance == null)
                 {
                     I_instance = new UCLogin();
                 }
                 return I_instance;
             }
         }
        public UCLogin()
        {
            InitializeComponent();
        }


        SqlConnection CONN = new SqlConnection();
        SqlCommand CMD = new SqlCommand();
 
        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            if (txtusername.Text == "" || txtpassword.Text == "")
            {
                MessageBox.Show("Username Atau Password Anda Belum Diisi, Mohon Cek Kembali", "informasi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                SqlDataReader DR;
                DatabaseManipulation DM = new DatabaseManipulation();
                DM.Koneksi();
                CONN.ConnectionString = "Data Source=DESKTOP-40C57RP;Initial Catalog=SMKInventoryDB;Integrated Security=True";
                CONN.Open();
                CMD = new SqlCommand("SELECT * FROM Member WHERE username='" + txtusername.Text + "'AND password='" + DM.getMD5Hash(txtpassword.Text) + "'", CONN);
                DR = CMD.ExecuteReader();
                DR.Read();
                if (DR.HasRows)
                {

                    Fmenu FM = new Fmenu();
                    FM.txtnamalvl.Text = DR["role"].ToString();
                    FM.Show();
                    this.Hide();
                    this.Parent.Hide();
                    txtusername.Text = "";
                    txtpassword.Text = "";
                    refresLogin();
                   
                    DR.Close();
                }
                else
                {
                    MessageBox.Show("Login Gagal, Silahkan Mencoba Kembali", "informasi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    CONN.Close();
                    refresLogin();
                }
            
            }
        }
           
        
        public void refresLogin()
        {
            txtusername.Text = "";
            txtpassword.Text = "";
        }
        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (!(FLog.ActiveForm as FLog).panel1.Controls.Contains(UCInfo.Instance))
            {
                (FLog.ActiveForm as FLog).panel1.Controls.Add(UCInfo.Instance);
                UCInfo.Instance.BringToFront();
            }
            else UCInfo.Instance.BringToFront();
        }
    }
}
