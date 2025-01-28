namespace Project_7
{
    partial class Form5
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
            this.lovelife = new System.Windows.Forms.CheckBox();
            this.LifeStory = new System.Windows.Forms.GroupBox();
            this.lblwarning = new System.Windows.Forms.Label();
            this.Criminology = new System.Windows.Forms.CheckBox();
            this.Highschool = new System.Windows.Forms.CheckBox();
            this.MyFather = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.LifeStory.SuspendLayout();
            this.SuspendLayout();
            // 
            // lovelife
            // 
            this.lovelife.AutoSize = true;
            this.lovelife.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lovelife.Location = new System.Drawing.Point(24, 31);
            this.lovelife.Name = "lovelife";
            this.lovelife.Size = new System.Drawing.Size(123, 28);
            this.lovelife.TabIndex = 0;
            this.lovelife.Text = "Love Life";
            this.lovelife.UseVisualStyleBackColor = true;
            this.lovelife.CheckedChanged += new System.EventHandler(this.lovelife_CheckedChanged);
            // 
            // LifeStory
            // 
            this.LifeStory.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.LifeStory.BackColor = System.Drawing.Color.LightSlateGray;
            this.LifeStory.Controls.Add(this.lblwarning);
            this.LifeStory.Controls.Add(this.Criminology);
            this.LifeStory.Controls.Add(this.Highschool);
            this.LifeStory.Controls.Add(this.MyFather);
            this.LifeStory.Controls.Add(this.lovelife);
            this.LifeStory.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LifeStory.Location = new System.Drawing.Point(130, 113);
            this.LifeStory.Name = "LifeStory";
            this.LifeStory.Size = new System.Drawing.Size(488, 195);
            this.LifeStory.TabIndex = 1;
            this.LifeStory.TabStop = false;
            this.LifeStory.Text = "STORY";
            // 
            // lblwarning
            // 
            this.lblwarning.AutoSize = true;
            this.lblwarning.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblwarning.Location = new System.Drawing.Point(21, 164);
            this.lblwarning.Name = "lblwarning";
            this.lblwarning.Size = new System.Drawing.Size(25, 14);
            this.lblwarning.TabIndex = 6;
            this.lblwarning.Text = "......";
            // 
            // Criminology
            // 
            this.Criminology.AutoSize = true;
            this.Criminology.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Criminology.Location = new System.Drawing.Point(24, 133);
            this.Criminology.Name = "Criminology";
            this.Criminology.Size = new System.Drawing.Size(267, 28);
            this.Criminology.TabIndex = 3;
            this.Criminology.Text = "When i was criminology";
            this.Criminology.UseVisualStyleBackColor = true;
            this.Criminology.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // Highschool
            // 
            this.Highschool.AutoSize = true;
            this.Highschool.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Highschool.Location = new System.Drawing.Point(24, 65);
            this.Highschool.Name = "Highschool";
            this.Highschool.Size = new System.Drawing.Size(185, 28);
            this.Highschool.TabIndex = 2;
            this.Highschool.Text = "Highschool Life";
            this.Highschool.UseVisualStyleBackColor = true;
            this.Highschool.CheckedChanged += new System.EventHandler(this.Highschool_CheckedChanged);
            // 
            // MyFather
            // 
            this.MyFather.AutoSize = true;
            this.MyFather.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MyFather.Location = new System.Drawing.Point(24, 99);
            this.MyFather.Name = "MyFather";
            this.MyFather.Size = new System.Drawing.Size(128, 28);
            this.MyFather.TabIndex = 1;
            this.MyFather.Text = "My Father";
            this.MyFather.UseVisualStyleBackColor = true;
            this.MyFather.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlText;
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(510, 334);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 41);
            this.button1.TabIndex = 4;
            this.button1.Text = "Click";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ControlText;
            this.button2.ForeColor = System.Drawing.Color.Transparent;
            this.button2.Location = new System.Drawing.Point(378, 334);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(108, 41);
            this.button2.TabIndex = 5;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.LifeStory);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Form5";
            this.Text = "Form5";
            this.LifeStory.ResumeLayout(false);
            this.LifeStory.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox lovelife;
        private System.Windows.Forms.GroupBox LifeStory;
        private System.Windows.Forms.CheckBox Criminology;
        private System.Windows.Forms.CheckBox Highschool;
        private System.Windows.Forms.CheckBox MyFather;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblwarning;
    }
}