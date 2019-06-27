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
    public partial class movie : Form
    {
        database d = new database();
        public movie()
        {
            InitializeComponent();
            int id = d.getmaxmovieid();
            textBox1.Text = id.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool f=d.insertnewmovie(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text, textBox7.Text);
            if (f == true)
            {
                MessageBox.Show("Inserted");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            updatemovie f = new updatemovie();
            f.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            deletemovie f = new deletemovie();
            f.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
