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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void admin_Load(object sender, EventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            add_customer a = new add_customer();
            a.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            edit_customer a = new edit_customer();
            a.Show();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            display_customer d = new display_customer();
            d.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            delete_customer d = new delete_customer();
            d.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            add_tourGuide a = new add_tourGuide();
            a.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            display_tourGuide a = new display_tourGuide();
            a.Show();
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            edit_tourGuide a = new edit_tourGuide();
            a.Show();
            
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            delete_tourGuide a = new delete_tourGuide();
            a.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form1 f=new Form1();
            this.Hide();
            f.Show();
            
            
        }
    }
}
