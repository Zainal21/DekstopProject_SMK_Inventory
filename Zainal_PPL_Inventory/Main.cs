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
    public partial class Main : UserControl
    {
        public static Main I_Instance;
        public static Main Instance
        {
            get
            {
                if (I_Instance == null)
                {
                    I_Instance = new Main();
                }
                return I_Instance;
            }
        }
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }
    }
}
