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
    public partial class showcurrent : Form
    {
        public showcurrent()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            database f = new database();
            DataSet d = f.showcurrent();
            dataGridView1.DataSource = d.Tables[0];
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
