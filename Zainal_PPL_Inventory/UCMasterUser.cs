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
    public partial class UCMasterUser : UserControl
    {
        public static UCMasterUser I_Instance;
        public static UCMasterUser Instance
        {
            get {
                if (I_Instance == null) {
                   I_Instance = new UCMasterUser();
                }
                return I_Instance;
            }
        }
        public UCMasterUser()
        {
            InitializeComponent();
            DatabaseManipulation DM = new DatabaseManipulation();
            DM.Koneksi();
        }

        private void UCMasterUser_Load(object sender, EventArgs e)
        {
            showdata();

        }
        private void clear() {

            txtid.Clear();
            txtnama.Clear();
            txtusername.Clear();
            txtpass.Clear();
            cbrole.SelectedItem = null;
        }

        private void showdata()
        {
            DatabaseManipulation DM = new DatabaseManipulation();
            DM.FechDatagrid("SELECT * FROM Member", gduser);
            gduser.Columns[0].Width = 240;
            gduser.Columns[1].Width = 240;
            gduser.Columns[2].Width = 240;
            gduser.Columns[3].Width = 240;
        
        }
        private void gduser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int x;
                x = gduser.CurrentRow.Index;
                txtid.Text = gduser.Rows[x].Cells[0].Value.ToString();
                txtusername.Text = gduser.Rows[x].Cells[1].Value.ToString();
                txtpass.Text = gduser.Rows[x].Cells[2].Value.ToString();
                txtnama.Text = gduser.Rows[x].Cells[3].Value.ToString();
                cbrole.SelectedItem = gduser.Rows[x].Cells[4].Value.ToString();
                bunifuFlatButton4.Enabled = false;

            }
            catch {

                MessageBox.Show("gagal Memilih barang", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
   
        }


        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            if (txtid.Text == "" || txtnama.Text == "" || txtusername.Text == "" || txtpass.Text == "" || cbrole.Text == "")
            {
                MessageBox.Show("masih ada kolom yang kosong tolong perikas kembali", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    DatabaseManipulation DM = new DatabaseManipulation();
                    DM.Koneksi();
                    DM.querysql("INSERT INTO Member VALUES('" + txtid.Text + "','" + txtusername.Text + "','" + DM.getMD5Hash(txtpass.Text) + "','" + txtnama.Text + "','" + cbrole.Text + "')");
                    MessageBox.Show("Data User Berhasil Ditambahkan", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    showdata();
                    clear();

                }
                catch
                {
                    MessageBox.Show("Data User Gagal untuk ditambahkan", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
        }

        private void bunifuFlatButton1_Click_1(object sender, EventArgs e)
        {
            if (txtid.Text == "" || txtnama.Text == "" || txtusername.Text == "" || txtpass.Text == "" || cbrole.Text == "")
            {
                MessageBox.Show("masih ada kolom yang kosong tolong perikas kembali", "informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try
                {
                    DatabaseManipulation DM = new DatabaseManipulation();
                    DM.Koneksi();
                    DM.querysql("UPDATE Member SET username='" + txtusername.Text + "',password='" + txtpass.Text + "',nama='" + txtnama.Text + "',role='" + cbrole.Text + "WHERE id_user='" + txtid.Text + "'");
                    MessageBox.Show("Data User Berhasil Diubah", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    showdata();
                    clear();
                }
                catch
                {
                    MessageBox.Show("Data User Gagal untuk di Ubah", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information );
                }
            }
        }

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {
            if (txtid.Text == "" || txtnama.Text == "" || txtusername.Text == "" || txtpass.Text == "" || cbrole.Text == "")
            {
                MessageBox.Show("masih ada kolom yang kosong tolong perikas kembali", "informasi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    DatabaseManipulation DM = new DatabaseManipulation();
                    DM.Koneksi();
                    DM.querysql("DELETE FROM Member WHERE id_user='" + txtid.Text + "'");
                    MessageBox.Show("Data User Berhasil Dihapus", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    showdata();
                    clear();
                }
                catch
                {
                    MessageBox.Show("Data User Gagal Ditambahkan", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void bunifuFlatButton2_Click_1(object sender, EventArgs e)
        {
            clear();
            showdata();
            bunifuFlatButton4.Enabled = true;
            MessageBox.Show("Data Berhasil di segarkan", "Konfirmasi data", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
