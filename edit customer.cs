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
    public partial class edit_customer : Form
    {
        public edit_customer()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
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
            int num = Int32.Parse(textBox5.Text);
            y.editCustomer(textBox6.Text, n, p, m, num, u);
            fileManager.saveData();
            MessageBox.Show("data is edited successfully");
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void edit_customer_Load(object sender, EventArgs e)
        {

        }
    }
}
