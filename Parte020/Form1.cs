﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parte020
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            string url = txtUrl.Text;
            browser.Navigate("http://" + url);
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            browser.GoBack();
        }

        private void btnAvançar_Click(object sender, EventArgs e)
        {
            browser.GoForward();
        }
    }
}
