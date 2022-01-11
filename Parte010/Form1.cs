using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parte010
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            

            ListViewItem item1 = new ListViewItem("Willian");
            item1.SubItems.Add("12 98603-4466");
            item1.SubItems.Add("willian@gmail.com");


            ListViewItem item2 = new ListViewItem("Logan");
            item2.SubItems.Add("12 98603-9988");
            item2.SubItems.Add("Logan@gmail.com");



            ListViewItem item3 = new ListViewItem("Danny");
            item3.SubItems.Add("11 98603-4466");
            item3.SubItems.Add("Danny@gmail.com");

            ListViewItem item4 = new ListViewItem(new string[] {"Arthur","13 3455-6677", "mail" });

            lista.Items.Add(item1);
            lista.Items.Add(item2);
            lista.Items.Add(item3);
            lista.Items.Add(item4);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //lista.Items.Clear();
            //lista.Items.Remove(lista.SelectedItems[0]);
            //lista.Items.RemoveAt(1);

        }

        private void lista_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show(lista.SelectedItems[0].Text);
        }
    }
}
