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
    public partial class updatemovie : Form
    {
        public updatemovie()
        {
            InitializeComponent();
        }

        private void updatemovie_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: This line of code loads data into the 'database1DataSet.Movies' table. You can move, or remove it, as needed.
                this.moviesTableAdapter.Fill(this.database1DataSet.Movies);

            }
            catch (Exception e1)
            {
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            database d = new database();
            bool m = d.updatemovie(comboBox1.SelectedValue.ToString(), textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox6.Text, textBox7.Text);
            if (m == true)
            {
                MessageBox.Show("Updated");
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                // MessageBox.Show(comboBox1.SelectedValue.ToString());
                database d = new database();
                DataSet d1 = d.moviedata(comboBox1.SelectedValue.ToString());
                textBox1.Text = d1.Tables[0].Rows[0][1].ToString();
                textBox2.Text = d1.Tables[0].Rows[0][2].ToString();
                textBox3.Text = d1.Tables[0].Rows[0][3].ToString();
                textBox4.Text = d1.Tables[0].Rows[0][5].ToString();
                textBox6.Text = d1.Tables[0].Rows[0][6].ToString();
                textBox7.Text = d1.Tables[0].Rows[0][7].ToString();
            }
            catch (Exception e1)
            {
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
