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
    public partial class HighschoolLifeMore : Form
    {
        public HighschoolLifeMore()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Highschool H = new Highschool();
            this.Hide();
            H.Show();
        }
    }
}
