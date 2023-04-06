using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmDangky : Form
    {
        public frmDangky()
        {
            InitializeComponent();
        }

        private void lbldangnhap_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmDangNhap newdangnhap = new frmDangNhap();
            newdangnhap.ShowDialog();
        }
    }
}
