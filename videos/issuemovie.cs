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
    public partial class issuemovie : Form
    {
        public issuemovie()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            database d = new database();
            bool g=d.issuemovie(comboBox1.SelectedValue.ToString(), comboBox2.SelectedValue.ToString(), dateTimePicker1.Text);
            if (g == true)
            {
                MessageBox.Show("Book Issued");
            }
        }

        private void issuemovie_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet3.Customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.database1DataSet3.Customer);
            // TODO: This line of code loads data into the 'database1DataSet2.Movies' table. You can move, or remove it, as needed.
            this.moviesTableAdapter.Fill(this.database1DataSet2.Movies);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
