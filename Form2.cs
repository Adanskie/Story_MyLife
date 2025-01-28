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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            lblaccount.Text = Form1.acc;


            string get_password = "";
            for (int i = 0; i < Form1.pass.Length; i++)
            {
                get_password += "*";
            }
            lblpassword.Text = get_password;

        }

        private void lblpassword_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 get = new Form3();
            get.Show();
        }

        private void EXIT_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
