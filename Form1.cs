using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin f2 = new Admin();
            f2.Show();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            customer f = new customer();
            f.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            fileManager.GetData();
            /*if (!File.Exists("Customer.txt"))
            {
                File.Create("Customer.txt");
            }

            if (!File.Exists("TourGuide.txt"))
            {
                File.Create("TourGuide.txt");
            }

            if (!File.Exists(" TripDetails.txt"))
            {
                File.Create("TripDetails.txt");
            }

            if (!File.Exists("Ticket.txt"))
            {
                File.Create("Ticket.txt");
            }*/
     
        }
    }
}
