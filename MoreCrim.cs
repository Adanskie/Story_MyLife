using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_7
{
    public partial class MoreCrim : Form
    {
        public MoreCrim()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Criminology crim = new Criminology();
            this.Hide();
            crim.Show();
        }
    }
}
