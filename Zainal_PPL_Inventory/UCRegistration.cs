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
    public partial class UCRegistration : UserControl
    {
        private static UCRegistration I_instance;
        public static UCRegistration Instance
        {
            get
            {
                if (I_instance == null)
                {
                    I_instance = new UCRegistration();
                }
                return I_instance;
            }
        }
        public UCRegistration()
        {
            InitializeComponent();
        }

        private void txtid_TextChange(object sender, EventArgs e)
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

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            if (txtid.Text == "" || txtusername.Text == "" || txtpass.Text == "" || txtpass.Text == "" || cbrole.Text == "")
            {
                MessageBox.Show("masih ada kolom yang kosong tolong perikas kembali", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    DatabaseManipulation DM = new DatabaseManipulation();
                    DM.Koneksi();
                    DM.querysql("INSERT INTO Member VALUES('" + txtid.Text + "','" + txtpass.Text + "','" + DM.getMD5Hash(txtpass.Text) + "','" + txtusername.Text + "','" + cbrole.Text + "')");
                    MessageBox.Show("Selamat Akun Anda Berhasil Terdaftar", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtid.Clear();
                    txtnama.Clear();
                    txtpass.Clear();
                    txtusername.Clear();
                    cbrole.Text = null;
                }
                catch
                {
                    MessageBox.Show("Data User Gagal untuk ditambahkan", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
        }
    }
}
