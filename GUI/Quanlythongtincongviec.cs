﻿using System;
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
    public partial class frmQlttcv : Form
    {
        public frmQlttcv()
        {
            InitializeComponent();
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            frmTimKiem timKiem = new frmTimKiem(); 
            timKiem.ShowDialog();
        }
    }
}
