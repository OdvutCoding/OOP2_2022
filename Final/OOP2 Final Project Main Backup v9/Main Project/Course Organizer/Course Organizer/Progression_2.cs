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
    public partial class Progression_2 : Form
    {
        public Progression_2()
        {
            InitializeComponent();
        }

        private void label_progress_next_Click(object sender, EventArgs e)
        {

        }

        private void label_return_progress_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Progression_3().Show();
        }

        private void label18_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Progression1().Show();
        }
    }
}
