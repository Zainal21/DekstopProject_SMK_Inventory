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
    public partial class UCDaftarKembali : UserControl
    {
        private static UCDaftarKembali I_instance;
        public static UCDaftarKembali Instance
        {
            get
            {
                if (I_instance == null)
                {
                    I_instance = new UCDaftarKembali();
                }
                return I_instance;
            }

        }
        public UCDaftarKembali()
        {
            InitializeComponent();
        }

        private void UCDaftarKembali_Load(object sender, EventArgs e)
        {
            showtodatagrid();
        }
        private void showtodatagrid()
        {
            DatabaseManipulation DM = new DatabaseManipulation();
            DM.Koneksi();
            DM.FechDatagrid("SELECT * FROM pengambalian", dataGridView1);
            dataGridView1.Columns[0].Width = 240;
            dataGridView1.Columns[1].Width = 240;
            dataGridView1.Columns[2].Width = 240;
            dataGridView1.Columns[3].Width = 240;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            showtodatagrid();
            MessageBox.Show("Data Berhasil Disegarkan", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
