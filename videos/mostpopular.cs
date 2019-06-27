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
    public partial class mostpopular : Form
    {
        public mostpopular()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            database d = new database();
            DataSet d1 = d.mostpopular();
            dataGridView1.DataSource = d1.Tables[0];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
