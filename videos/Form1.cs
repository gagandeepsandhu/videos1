using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace videos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           

             

            
            
            movie f = new movie();
            f.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            customer d = new customer();
            d.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            rent d = new rent();
            d.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            showall f = new showall();
            f.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            showcurrent f = new showcurrent();
            f.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            mostpopular f = new mostpopular();
            f.Show();

        }
    }
}
