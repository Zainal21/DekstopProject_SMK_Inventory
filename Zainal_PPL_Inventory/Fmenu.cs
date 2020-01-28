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
    public partial class Fmenu : Form
    {
        public Fmenu()
        {
            InitializeComponent();
            DatabaseManipulation DM = new DatabaseManipulation();
            DM.Koneksi();
        }

      

        private void bunifuTileButton1_Click(object sender, EventArgs e)
        {
            if (!panelkonten.Controls.Contains(UCDataBarang.Instance))
            {
                panelkonten.Controls.Add(UCDataBarang.Instance);
                UCDataBarang.Instance.BringToFront();
                (Fmenu.ActiveForm as Fmenu).panelkonten.Controls.Remove(UC_Pengembalian.Instance);
                (Fmenu.ActiveForm as Fmenu).panelkonten.Controls.Remove(UCDaftarKembali.Instance);
                (Fmenu.ActiveForm as Fmenu).panelkonten.Controls.Remove(UCMasterUser.Instance);
                (Fmenu.ActiveForm as Fmenu).panelkonten.Controls.Remove(UCPeminjaman.Instance);
            }
            else UCDataBarang.Instance.BringToFront();
            (Fmenu.ActiveForm as Fmenu).panelkonten.Controls.Remove(UC_Pengembalian.Instance);
            (Fmenu.ActiveForm as Fmenu).panelkonten.Controls.Remove(UCDaftarKembali.Instance);
            (Fmenu.ActiveForm as Fmenu).panelkonten.Controls.Remove(UCMasterUser.Instance);
            (Fmenu.ActiveForm as Fmenu).panelkonten.Controls.Remove(UCPeminjaman.Instance);
       



        }

        private void bunifuTileButton2_Click(object sender, EventArgs e)
        {
            if (!panelkonten.Controls.Contains(UCMasterUser.Instance)) {
                panelkonten.Controls.Add(UCMasterUser.Instance);
                UCMasterUser.Instance.BringToFront();
            }
            else UCMasterUser.Instance.BringToFront();
            (Fmenu.ActiveForm as Fmenu).panelkonten.Controls.Remove(UC_Pengembalian.Instance);
            (Fmenu.ActiveForm as Fmenu).panelkonten.Controls.Remove(UCDaftarKembali.Instance);
            (Fmenu.ActiveForm as Fmenu).panelkonten.Controls.Remove(UCDataBarang.Instance);
            (Fmenu.ActiveForm as Fmenu).panelkonten.Controls.Remove(UCPeminjaman.Instance);
        }

        private void bunifuTileButton3_Click(object sender, EventArgs e)
        {
            if (!panelkonten.Controls.Contains(UCPeminjaman.Instance))
            {
                panelkonten.Controls.Add(UCPeminjaman.Instance);
                UCPeminjaman.Instance.BringToFront();
            }
            else UCPeminjaman.Instance.BringToFront();
            (Fmenu.ActiveForm as Fmenu).panelkonten.Controls.Remove(UC_Pengembalian.Instance);
            (Fmenu.ActiveForm as Fmenu).panelkonten.Controls.Remove(UCDaftarKembali.Instance);
            (Fmenu.ActiveForm as Fmenu).panelkonten.Controls.Remove(UCDataBarang.Instance);
            (Fmenu.ActiveForm as Fmenu).panelkonten.Controls.Remove(UCMasterUser.Instance);
        }


        private void bunifuTileButton5_Click(object sender, EventArgs e)
        {
            if (!panelkonten.Controls.Contains(UC_Pengembalian.Instance))
            {
                panelkonten.Controls.Add(UC_Pengembalian.Instance);
                UC_Pengembalian.Instance.BringToFront();
                (Fmenu.ActiveForm as Fmenu).panelkonten.Controls.Remove(UCDataBarang.Instance);
                (Fmenu.ActiveForm as Fmenu).panelkonten.Controls.Remove(UCMasterUser.Instance);
                (Fmenu.ActiveForm as Fmenu).panelkonten.Controls.Remove(UCPeminjaman.Instance);
            }
            else UC_Pengembalian.Instance.BringToFront();
            (Fmenu.ActiveForm as Fmenu).panelkonten.Controls.Remove(UCDataBarang.Instance);
            (Fmenu.ActiveForm as Fmenu).panelkonten.Controls.Remove(UCMasterUser.Instance);
            (Fmenu.ActiveForm as Fmenu).panelkonten.Controls.Remove(UCPeminjaman.Instance);

        }

        private void bunifuTileButton4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panelkonten_Paint(object sender, PaintEventArgs e)
        {
            if (!panelkonten.Controls.Contains(Main.Instance))
            {
                panelkonten.Controls.Add(Main.Instance);
                Main.Instance.BringToFront();
            }
            else Main.Instance.BringToFront();
        }

        private void Fmenu_Load(object sender, EventArgs e)
        {
            hakakses();
          
        }

        private void hakakses()
        {
            if (txtnamalvl.Text == "Operator")
            {
                txtbarang.Enabled = false;
                txtuser.Enabled = false;
                bunifuTileButton1.Enabled = false;
            }
            else if (txtnamalvl.Text == "Peminjam")
            {
                txtkembali.Enabled = false;
                txtbarang.Enabled = false;
                txtuser.Enabled = false;
                bunifuTileButton1.Enabled = false;
            }
            else if (txtnamalvl.Text == "Owner")
            {
               
                txtbarang.Enabled = false;
                txtuser.Enabled = false;
            }
        }

        private void bunifuTileButton1_Click_1(object sender, EventArgs e)
        {
            if (!panelkonten.Controls.Contains(UCDaftarKembali.Instance))
            {
                panelkonten.Controls.Add(UCDaftarKembali.Instance);
                UCDaftarKembali.Instance.BringToFront();
            }
            else UCDaftarKembali.Instance.BringToFront();
        }

        private void bunifuShadowPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        
    }
}
