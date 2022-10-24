using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Course_Organizer
{
    public partial class Math5_topics : Form
    {
        public Math5_topics()
        {
            InitializeComponent();
        }

        private void label_progress_next_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Math5_Examinfo().Show();
        }

        private void label_return_progress_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Math5_courseinfo().Show();
        }
    }
}
