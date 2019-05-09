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
    public partial class customer : Form
    {
        public customer()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f = new Form1();
            f.Show();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            /*for (int i = 0; i < fileManager._CustomerR.Count; i++)
            { 
               if(fileManager._CustomerR[i].name==textBox1.Text)
               {
                   this.Hide();
                   bookingTicket t = new bookingTicket();
                   t.Show(); 

               }
            }*/
            this.Hide();
            bookingTicket t = new bookingTicket();
            t.Show(); 
        }
        private void customer_Load(object sender, EventArgs e)
        {
        }
    }
}
