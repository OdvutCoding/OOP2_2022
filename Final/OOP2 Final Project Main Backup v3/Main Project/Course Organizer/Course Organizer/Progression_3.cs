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
    public partial class Progression_3 : Form
    {
        public Progression_3()
        {
            InitializeComponent();
        }

        private void label_return_progress_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Progression_2().Show();
        }
    }
}
