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
    public partial class Math5_Examinfo : Form
    {
        public Math5_Examinfo()
        {
            InitializeComponent();
        }

        private void label18_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Math5_topics().Show();
        }

        private void label17_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Math5_Progress().Show();
        }
    }
}
