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
    public partial class LastPartLoveStory : Form
    {
        public LastPartLoveStory()
        {
            InitializeComponent();
        }

        private void More1_Click(object sender, EventArgs e)
        {
            LoveLifeMore a = new LoveLifeMore();
            this.Hide();
            a.Show();
        }
    }
}
