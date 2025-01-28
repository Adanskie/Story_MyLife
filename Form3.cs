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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblAccount_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            for(int i = 0; i < Form1.create_account.Count;i++)
            {
                if(txtAccount.Text == Form1.create_account[i] && txtPassword.Text == Form1.create_password[i])
                {
                    Form4 a = new Form4();
                    this.Hide();
                    a.Show();
                    return;
                }
            }
            lblhesoyam.Text = "Please try again";
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 g = new Form1();
            g.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
