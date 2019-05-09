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
    public partial class display_tourGuide : Form
    {
        public display_tourGuide()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin a = new Admin();
            a.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            x y = new x();
            string i = textBox1.Text;
            string n = textBox2.Text;
            int p = Int32.Parse(textBox3.Text);
            string ii = textBox4.Text;
            int num = Int32.Parse(textBox5.Text);
            string em = textBox6.Text;
            int s = Int32.Parse(textBox7.Text);
            y.editTourGuide(i, n, p, ii, num, em, s);
            fileManager.saveData();
            MessageBox.Show("Data was edited successfully!");
        }
    }
}
