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
    public partial class bookingTicket : Form
    {
        public int p;
        public bookingTicket()
        {
            InitializeComponent();
            for (int i = 0; i < fileManager.TripDetails.Count; i++)
            {
                MessageBox.Show(fileManager.TripDetails[i].name);
                listBox1.Items.Add(fileManager.TripDetails[i].name);

            }
        }

        private void bookingTicket_Load(object sender, EventArgs e)
        {
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            customer c = new customer();
            c.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            _TourGuide m = new _TourGuide();
            //m.AssignEachTrip(listBox1.Text);
            //m.CalculateSalary();
            _Customer x = new _Customer();
            x.bookAtrip(listBox1.Text);
            _Ticket y = new _Ticket();
            int num = Int32.Parse(textBox4.Text);
            string t=" ";
            if (checkBox1.Checked)
            {
                t = "gold";
            }
            else if (checkBox2.Checked)
            {
                t = "silver";
            }
            else if (checkBox3.Checked)
            {
                t = "platinum";
            }
            y.checkingDiscount();
           p= y.bookingTicket(num,t);
            this.Hide();
            Display_price d = new Display_price();
            fileManager.saveData();
            d.Show();
            
        }
    }
}
