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
    public partial class rent : Form
    {
        public rent()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            issuemovie f = new issuemovie();
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            returningmovie f = new returningmovie();
            f.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
