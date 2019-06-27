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
    public partial class returningmovie : Form
    {
        public returningmovie()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            database d = new database();
            bool f = d.returnmovie(comboBox1.SelectedValue.ToString(), dateTimePicker1.Text);
            if (f == true)
            {
                MessageBox.Show("Returned");
            }
        }

        private void returningmovie_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet4.RentedMovies' table. You can move, or remove it, as needed.
            this.rentedMoviesTableAdapter.Fill(this.database1DataSet4.RentedMovies);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
