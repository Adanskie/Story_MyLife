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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 g = new Form4();
            g.Show();
        }

        private void lovelife_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void Highschool_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(lovelife.Checked && !Highschool.Checked && !MyFather.Checked && !Criminology.Checked)
            {
                LoveLife love = new LoveLife();
                this.Hide();
                love.Show();
            }
            else if(!lovelife.Checked && Highschool.Checked && !MyFather.Checked && !Criminology.Checked)
            {
                Highschool school = new Highschool();
                this.Hide();
                school.Show();
            }
            else if(!lovelife.Checked && !Highschool.Checked && MyFather.Checked && !Criminology.Checked)
            {
                Father father = new Father();
                this.Hide();
                father.Show();
            }
            else if(!lovelife.Checked && !Highschool.Checked && !MyFather.Checked && Criminology.Checked)
            {
                Criminology crim = new Criminology();
                this.Hide();
                crim.Show();
            }
            else
            {
                lblwarning.Text = "Please Choice 1";
            }
        }
    }
}
