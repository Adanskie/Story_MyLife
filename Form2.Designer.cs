namespace Project_7
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.EXIT = new System.Windows.Forms.Button();
            this.lblpassword = new System.Windows.Forms.Label();
            this.lblaccount = new System.Windows.Forms.Label();
            this.lblpass = new System.Windows.Forms.Label();
            this.lblacc = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DarkTurquoise;
            this.groupBox1.Controls.Add(this.EXIT);
            this.groupBox1.Controls.Add(this.lblpassword);
            this.groupBox1.Controls.Add(this.lblaccount);
            this.groupBox1.Controls.Add(this.lblpass);
            this.groupBox1.Controls.Add(this.lblacc);
            this.groupBox1.Controls.Add(this.btnLogin);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(117, 82);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(542, 262);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Success Create Account";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // EXIT
            // 
            this.EXIT.BackColor = System.Drawing.Color.Black;
            this.EXIT.ForeColor = System.Drawing.Color.White;
            this.EXIT.Location = new System.Drawing.Point(182, 191);
            this.EXIT.Name = "EXIT";
            this.EXIT.Size = new System.Drawing.Size(97, 50);
            this.EXIT.TabIndex = 5;
            this.EXIT.Text = "Exit";
            this.EXIT.UseVisualStyleBackColor = false;
            this.EXIT.Click += new System.EventHandler(this.EXIT_Click);
            // 
            // lblpassword
            // 
            this.lblpassword.AutoSize = true;
            this.lblpassword.Location = new System.Drawing.Point(245, 132);
            this.lblpassword.Name = "lblpassword";
            this.lblpassword.Size = new System.Drawing.Size(61, 24);
            this.lblpassword.TabIndex = 4;
            this.lblpassword.Text = "None";
            this.lblpassword.Click += new System.EventHandler(this.lblpassword_Click);
            // 
            // lblaccount
            // 
            this.lblaccount.AutoSize = true;
            this.lblaccount.Location = new System.Drawing.Point(245, 77);
            this.lblaccount.Name = "lblaccount";
            this.lblaccount.Size = new System.Drawing.Size(61, 24);
            this.lblaccount.TabIndex = 3;
            this.lblaccount.Text = "None";
            // 
            // lblpass
            // 
            this.lblpass.AutoSize = true;
            this.lblpass.Location = new System.Drawing.Point(55, 132);
            this.lblpass.Name = "lblpass";
            this.lblpass.Size = new System.Drawing.Size(156, 24);
            this.lblpass.TabIndex = 2;
            this.lblpass.Text = "new Passwordt:";
            // 
            // lblacc
            // 
            this.lblacc.AutoSize = true;
            this.lblacc.Location = new System.Drawing.Point(55, 77);
            this.lblacc.Name = "lblacc";
            this.lblacc.Size = new System.Drawing.Size(138, 24);
            this.lblacc.TabIndex = 1;
            this.lblacc.Text = "new Account:";
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Black;
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(313, 191);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(160, 50);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "Go to (Log in)";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblpassword;
        private System.Windows.Forms.Label lblaccount;
        private System.Windows.Forms.Label lblpass;
        private System.Windows.Forms.Label lblacc;
        private System.Windows.Forms.Button EXIT;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}