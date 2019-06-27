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
    public partial class deletemovie : Form
    {
        public deletemovie()
        {
            InitializeComponent();
        }

        private void deletemovie_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet1.Movies' table. You can move, or remove it, as needed.
            this.moviesTableAdapter.Fill(this.database1DataSet1.Movies);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            database d = new database();
            bool r=d.deletemovie(comboBox1.SelectedValue.ToString());
            if (r == true)
            {
                MessageBox.Show("Delete successfully");
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
