using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace Zainal_PPL_Inventory
{
    public partial class UCPeminjaman : UserControl
    {
        public static UCPeminjaman I_Instance;
        public static UCPeminjaman Instance
        {
            get
            {
                if (I_Instance == null)
                {
                    I_Instance = new UCPeminjaman();
                }
                return I_Instance;
            }
        }
        public string namapeminjam;
       
        public UCPeminjaman()
        {
            InitializeComponent();
            namapeminjam = txtnamapeminjam.Text;
            showdata();
        }


        private void kosongkan()
        {
            txtid.Clear();
            txtidpinjam.Clear();
            txtnama.Clear();
            txtkondisi.Clear();
            txtstatus.Clear();
          
        }

        private void txtnamapeminjam_OnValueChanged(object sender, EventArgs e)
        {
           
        }

        private void UCPeminjaman_Load(object sender, EventArgs e)
        {
            showdata();
            label12.Text = DateTime.Now.ToLongTimeString();
        }
        private void showdata()
        {
            DatabaseManipulation DM = new DatabaseManipulation();
            DM.FechDatagrid("SELECT * FROM Barang", dgpinjam);
            dgpinjam.Columns[0].Width = 270;
            dgpinjam.Columns[1].Width = 270;
            dgpinjam.Columns[2].Width = 270;
            dgpinjam.Columns[3].Width = 270;
        }

        public string txt { get; set; }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int x;
                x = dgpinjam.CurrentRow.Index;
                txtid.Text = dgpinjam.Rows[x].Cells[0].Value.ToString();
                txtnama.Text = dgpinjam.Rows[x].Cells[1].Value.ToString();
                txtkondisi.Text = dgpinjam.Rows[x].Cells[2].Value.ToString();
                txtstatus.Text = dgpinjam.Rows[x].Cells[3].Value.ToString();

            }
            catch
            {

                MessageBox.Show("gagal Memilih barang", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
        }


        private void txtnamapeminjam_Click(object sender, EventArgs e)
        {
            Fmasukannama F = new Fmasukannama();
            if (!string.IsNullOrEmpty(txtnamapeminjam.Text))
            {
                F.dNama.Text = txtnamapeminjam.Text;
            }
            F.Show();
        }

        private void btnpinjam_Click(object sender, EventArgs e)
        {
            if (txtid.Text == "" || txtkondisi.Text == "" || txtnama.Text == "" || txtnamapeminjam.Text == "")
            {
                MessageBox.Show("Masih ada Kolom yang belum diisi, tolong periksa kembali", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                kosongkan();
            }
            else if (txtstatus.Text == "Tidak Tersedia") {
                MessageBox.Show("Barang yang anda pilih tidak tersedia, coba pilih barang yang lain", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                kosongkan();
            }
            else if (txtkondisi.Text == "Buruk") {
                MessageBox.Show("Barang yang anda pilih kondisinya buruk, coba pilih barang yang lain", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                kosongkan();
            }

            else
            {

                DatabaseManipulation DM = new DatabaseManipulation();
                DM.Koneksi();
                DM.querysql("INSERT INTO pinjaman VALUES('" + txtidpinjam.Text + "','" + txtid.Text + "','" + txtnama.Text + "','" + txtnamapeminjam.Text + "','" + txtkondisi.Text + "','" + txtstatus.Text + "','" + dateTimePicker1.Text + "')");
                DM.querysql("UPDATE Barang SET status_barang='Tidak Tersedia' WHERE id_barang='" + txtid.Text + "'");
                showdata();
                kosongkan();
                MessageBox.Show("Barang Berhasil Dipinjam", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            showdata();
            MessageBox.Show("Data Berhasil Disegarkan", "Konfirmasi Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

       
    }
}