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
    public partial class edit_tourGuide : Form
    {
        public edit_tourGuide()
        {
            InitializeComponent();
        }

        private void edit_tourGuide_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Name = textBox2.Text;
            x utility = new x();
            utility.displayTourGuide(Name, label1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin Prev = new Admin();
            Prev.Show();
        }
    }
}
