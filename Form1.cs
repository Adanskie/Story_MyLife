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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static List<string> create_account = new List<string>();
        public static List<string> create_password = new List<string>();

        public static string acc;
        public static string pass;
        private void btnCreate_Click(object sender, EventArgs e)
        {
            acc = txtAcc.Text;
            pass = txtPass.Text;

            
            if(acc.Length >= 6 && pass.Length >= 6)
            {
                create_account.Add(acc);
                create_password.Add(pass);

                this.Hide();
                Form2 go = new Form2();
                go.Show();
            }
            else
            {
                lblguide.Text = "Please input 6 char";
            }
        }

        private void txtAcc_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Logins_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 f = new Form3();
            f.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
