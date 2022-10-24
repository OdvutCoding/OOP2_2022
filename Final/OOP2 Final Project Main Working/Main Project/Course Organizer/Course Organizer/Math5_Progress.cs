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
    public partial class Math5_Progress : Form
    {
        public Math5_Progress()
        {
            InitializeComponent();
        }

        private void Backtobrowse_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form_Browse().Show();
        }

        private void label_return_progress_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Math5_Examinfo().Show();
        }
    }
}
