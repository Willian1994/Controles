using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parte001
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void lblTítulo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bem Vindo ao C#.");
        }

        private void lblTítulo_MouseEnter(object sender, EventArgs e)
        {
            lblTítulo.ForeColor = Color.Yellow;
        }

        private void lblTítulo_MouseLeave(object sender, EventArgs e)
        {
            lblTítulo.ForeColor = Color.DarkRed;
        }
    }
}
