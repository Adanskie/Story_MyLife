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
    public partial class LoveLifeMore : Form
    {
        public LoveLifeMore()
        {
            InitializeComponent();
        }

        private void LoveLifeMore_Load(object sender, EventArgs e)
        {

        }

        private void Back1_Click(object sender, EventArgs e)
        {
            LoveLife love = new LoveLife();
            this.Hide();
            love.Show();
        }

        private void More1_Click(object sender, EventArgs e)
        {
            LastPartLoveStory last = new LastPartLoveStory();
            this.Hide();
            last.Show();
        }
    }
}
