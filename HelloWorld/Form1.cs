﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HelloWorld
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHelloWorld_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello World.");

            MessageBox.Show("Hello Again.");
        }
    }
}
