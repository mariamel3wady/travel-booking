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
    public partial class add_customer : Form
    {
        public add_customer()
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
            string n = textBox1.Text;
            string m = textBox2.Text;
            int p = Int32.Parse(textBox3.Text);
            string u = textBox4.Text;
            y.addCustomer(n, p, m, u);
            fileManager.saveData();
            MessageBox.Show("customer is added successfully");
        }
    }
}
