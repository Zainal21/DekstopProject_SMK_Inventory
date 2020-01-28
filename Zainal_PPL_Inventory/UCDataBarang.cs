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
    public partial class UCDataBarang : UserControl
    {
        private static UCDataBarang I_instance;
        public static UCDataBarang Instance
        { 
            get
            {
                if(I_instance == null){
                    I_instance = new UCDataBarang();
                }
                return I_instance;
            }
        
        }
        public UCDataBarang()
        {
            InitializeComponent();
            DatabaseManipulation DM = new DatabaseManipulation();
            DM.Koneksi();
        }

        private void UCDataBarang_Load(object sender, EventArgs e)
        {
            showdata();
           
        }

        private void showdata()
        {
            DatabaseManipulation DM = new DatabaseManipulation();
            DM.FechDatagrid("SELECT * FROM Barang", dgbarang);
            dgbarang.Columns[0].Width = 270;
            dgbarang.Columns[1].Width = 270;
            dgbarang.Columns[2].Width = 270;
            dgbarang.Columns[3].Width = 270;
        }


       

        private void refreshform()
        {
            txtid.Clear();
            txtnama.Clear();
            cbkondisi.Text = "";
            cbstatus.Text = "";
        }

        private void dgbarang_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int x;
                x = dgbarang.CurrentRow.Index;
                txtid.Text = dgbarang.Rows[x].Cells[0].Value.ToString();
                txtnama.Text = dgbarang.Rows[x].Cells[1].Value.ToString();
                cbkondisi.Text = dgbarang.Rows[x].Cells[2].Value.ToString();
                cbstatus.Text = dgbarang.Rows[x].Cells[3].Value.ToString();

                if (txtid.Text == "" || txtnama.Text == "")
                {
                    bunifuFlatButton1.Enabled = true;
                    refreshform();
                }
                else {
                    txtid.ReadOnly = true;
                    bunifuFlatButton1.Enabled = false;
                   

                }
                
            }
            catch
            {

                MessageBox.Show("gagal Memilih barang");
            }
        }

       

        private void bunifuFlatButton1_Click_1(object sender, EventArgs e)
        {
            if (txtid.Text == "" || txtnama.Text == "" || cbkondisi.SelectedItem == null || cbstatus.SelectedItem == null)
            {
                MessageBox.Show("Masih  ada kolom yang belum diisi, tolong perikasa kembali", "informasi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else {
                DatabaseManipulation DM = new DatabaseManipulation();
                DM.Koneksi();
                DM.querysql("INSERT INTO Barang VALUES('" + txtid.Text + "','" + txtnama.Text + "','" + cbkondisi.Text + "','" + cbstatus.Text + "')");
                MessageBox.Show("Data Barang Berhasil Ditambahkan", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                refreshform();
                showdata();
            }
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            if (txtid.Text == "" || txtnama.Text == "" || cbkondisi.SelectedItem == null || cbstatus.SelectedItem == null)
            {
                MessageBox.Show("Masih  ada kolom yang belum diisi, tolong perikasa kembali", "informasi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }else{
                DatabaseManipulation DM = new DatabaseManipulation();
                DM.Koneksi();
                DM.querysql("UPDATE Barang SET nama_barang='" + txtnama.Text + "',kondisi='" + cbkondisi.Text + "',status_barang='" + cbstatus.Text + "'WHERE id_barang='" + txtid.Text + "'");
                MessageBox.Show("Data Barang Berhasil Diubah", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                showdata();
                refreshform();
            }
           

        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            if (txtid.Text == "" || txtnama.Text == "" || cbkondisi.SelectedItem == null || cbstatus.SelectedItem == null)
            {
                MessageBox.Show("Masih  ada kolom yang belum diisi, tolong perikasa kembali", "informasi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DatabaseManipulation DM = new DatabaseManipulation();
                DM.Koneksi();
                DM.querysql("DELETE FROM Barang WHERE id_barang='" + txtid.Text + "'");
                MessageBox.Show("Data Barang Berhasil Dihapus", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                refreshform();
                showdata();
            }

        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            

        }

        private void bunifuFlatButton3_Click_1(object sender, EventArgs e)
        {
            showdata();
            refreshform();
            txtid.ReadOnly = false;
            bunifuFlatButton1.Enabled = true;
            MessageBox.Show("Data Berhasil Disegarkan", "Konfirmasi Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        

    
    }
}
