using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zainal_PPL_Inventory
{
    public partial class UC_Pengembalian : UserControl
    {
        public static UC_Pengembalian I_Instance;
        public static UC_Pengembalian Instance
        {
            get {
                if (I_Instance == null) {
                    I_Instance = new UC_Pengembalian();
                }
                return I_Instance;
            }
        }
        public UC_Pengembalian()
        {
            InitializeComponent();
        }

        private void UC_Pengembalian_Load(object sender, EventArgs e)
        {
            label13.Text = DateTime.Now.ToLongTimeString();
            showdata();
        }
        private void showdata()
        {
            DatabaseManipulation DM = new DatabaseManipulation();
            DM.FechDatagrid("SELECT * FROM pinjaman", dataGridView1);
            dataGridView1.Columns[0].Width = 100;
            dataGridView1.Columns[1].Width = 100;
            dataGridView1.Columns[2].Width = 100;
            dataGridView1.Columns[3].Width = 100;
        }


     

        private void clear() 
        {
            txtstatus.Clear();
            txtnamabrg.Clear();
            txtstatus.Clear();
            txtkondisi.Clear();
            txtidbarang.Clear();
            txttanggalpinjam.Clear();
            txtidpinjam.Clear();
        }

        private void btnkembalikan_Click(object sender, EventArgs e)
        {
            if (txtidbarang.Text == "" || txtkondisi.Text == "" || txtnamabrg.Text == "" || txtstatus.Text == "" || txttanggalpinjam.Text == "")
            {
                MessageBox.Show("Masih ada Kolom yang belum diisi, tolong periksa kembali", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                clear();
            }
            else if (txtstatus.Text == "Tidak Tersedia")
            {
                MessageBox.Show("Barang yang anda pilih tidak tersedia, coba pilih barang yang lain", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                clear();
            }
            else if (txtkondisi.Text == "Buruk")
            {
                MessageBox.Show("Barang yang anda pilih kondisinya buruk, coba pilih barang yang lain", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                clear();
            }
            else {
                DatabaseManipulation DM = new DatabaseManipulation();
                DM.Koneksi();
                DM.querysql("INSERT INTO Pengambalian VALUES('" + txtidpinjam.Text + "','" + txtidbarang.Text + "','" + txtnamabrg.Text + "','" + lblnama.Text + "','" +txtkondisi.Text+ "','" +txtstatus.Text+ "','" +txttanggalpinjam.Text+ "','" +dateTimePicker1.Text+ "')");
                DM.querysql("DELETE FROM pinjaman WHERE id_pinjam='" + txtidpinjam.Text + "'");
                DM.querysql("UPDATE Barang SET status_barang='Tersedia' WHERE id_barang='" +txtidbarang.Text+ "'");  
                MessageBox.Show("Barang Berhasil Dikembalikan", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                showdata();
                clear();
              
            }
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int x;
                x = dataGridView1.CurrentRow.Index;
                txtidpinjam.Text = dataGridView1.Rows[x].Cells[0].Value.ToString();
                txtidbarang.Text = dataGridView1.Rows[x].Cells[1].Value.ToString();
                txtnamabrg.Text = dataGridView1.Rows[x].Cells[2].Value.ToString();
                lblnama.Text = dataGridView1.Rows[x].Cells[3].Value.ToString();
                txtkondisi.Text = dataGridView1.Rows[x].Cells[4].Value.ToString();
                txtstatus.Text = dataGridView1.Rows[x].Cells[5].Value.ToString();
                txttanggalpinjam.Text = dataGridView1.Rows[x].Cells[6].Value.ToString();
            }
            catch
            {

                MessageBox.Show("gagal Memilih barang", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
   
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
           
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void bunifuFlatButton1_Click_1(object sender, EventArgs e)
        {
            showdata();
            MessageBox.Show("Data Berhasil Disegarkan", "Konfirmasi Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }

      

        
    }
}
