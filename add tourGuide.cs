using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class add_tourGuide : Form
    {
        public add_tourGuide()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            x y = new x();
            string n = textBox1.Text;
            int p = Int32.Parse(textBox2.Text);
            string i = textBox3.Text;
            string em = textBox4.Text;
            int s = Int32.Parse(textBox5.Text);
            y.addTourGuide(n, p, i, em, s);
            fileManager.saveData();
            MessageBox.Show("TourGuide is Added successfully!");
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin f = new Admin();
            f.Show();
        }
    }
}
