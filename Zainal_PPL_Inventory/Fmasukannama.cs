using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace Zainal_PPL_Inventory
{
    public partial class Fmasukannama : Form
    {
        public Fmasukannama()
        {
            InitializeComponent();
        }

       

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            UCPeminjaman.Instance.namapeminjam = dNama.Text;
            UCPeminjaman.Instance.txtnamapeminjam.Text = dNama.Text;
            this.Hide();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Fmasukannama_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
