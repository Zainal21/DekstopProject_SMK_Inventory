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
    public partial class UCInfo : UserControl
    {
        private static UCInfo I_instance;
        public static UCInfo Instance
        {
            get
            {
                if (I_instance == null)
                {
                    I_instance = new UCInfo();
                }
                return I_instance;
            }
        }
        public UCInfo()
        {
            InitializeComponent();
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            if (!(FLog.ActiveForm as FLog).panel1.Controls.Contains(UCLogin.Instance))
            {
                (FLog.ActiveForm as FLog).panel1.Controls.Add(UCLogin.Instance);
                UCLogin.Instance.BringToFront();
            }
            else UCLogin.Instance.BringToFront();

        }

        private void bunifuButton3_Click(object sender, EventArgs e)
        {
            if (!(FLog.ActiveForm as FLog).panel1.Controls.Contains(UCRegistration.Instance))
            {
                (FLog.ActiveForm as FLog).panel1.Controls.Add(UCRegistration.Instance);
                UCRegistration.Instance.BringToFront();
            }
            else UCRegistration.Instance.BringToFront();

        }
    }
}
