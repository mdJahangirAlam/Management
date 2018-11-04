namespace mass
{
    partial class login
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
            this.home_p = new System.Windows.Forms.Panel();
            this.in_login = new System.Windows.Forms.Button();
            this.home_lebel = new System.Windows.Forms.Label();
            this.create = new System.Windows.Forms.Button();
            this.in_password = new System.Windows.Forms.TextBox();
            this.in_name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.home_p.SuspendLayout();
            this.SuspendLayout();
            // 
            // home_p
            // 
            this.home_p.Controls.Add(this.in_login);
            this.home_p.Controls.Add(this.home_lebel);
            this.home_p.Controls.Add(this.create);
            this.home_p.Controls.Add(this.in_password);
            this.home_p.Controls.Add(this.in_name);
            this.home_p.Controls.Add(this.label3);
            this.home_p.Controls.Add(this.label4);
            this.home_p.Location = new System.Drawing.Point(81, 43);
            this.home_p.Name = "home_p";
            this.home_p.Size = new System.Drawing.Size(334, 255);
            this.home_p.TabIndex = 1;
            // 
            // in_login
            // 
            this.in_login.Location = new System.Drawing.Point(187, 170);
            this.in_login.Name = "in_login";
            this.in_login.Size = new System.Drawing.Size(66, 21);
            this.in_login.TabIndex = 2;
            this.in_login.Text = "Login";
            this.in_login.UseVisualStyleBackColor = true;
            this.in_login.Click += new System.EventHandler(this.in_login_Click);
            // 
            // home_lebel
            // 
            this.home_lebel.AutoSize = true;
            this.home_lebel.Location = new System.Drawing.Point(84, 11);
            this.home_lebel.Name = "home_lebel";
            this.home_lebel.Size = new System.Drawing.Size(119, 13);
            this.home_lebel.TabIndex = 1;
            this.home_lebel.Text = "Mass Managing System";
            // 
            // create
            // 
            this.create.Location = new System.Drawing.Point(205, 44);
            this.create.Name = "create";
            this.create.Size = new System.Drawing.Size(88, 21);
            this.create.TabIndex = 2;
            this.create.Text = "Create a mass";
            this.create.UseVisualStyleBackColor = true;
            this.create.Click += new System.EventHandler(this.create_Click);
            // 
            // in_password
            // 
            this.in_password.Location = new System.Drawing.Point(114, 130);
            this.in_password.Name = "in_password";
            this.in_password.Size = new System.Drawing.Size(139, 20);
            this.in_password.TabIndex = 2;
            // 
            // in_name
            // 
            this.in_name.Location = new System.Drawing.Point(114, 84);
            this.in_name.Name = "in_name";
            this.in_name.Size = new System.Drawing.Size(139, 20);
            this.in_name.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Mass name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Password:";
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 341);
            this.Controls.Add(this.home_p);
            this.Name = "login";
            this.Text = "login";
            this.home_p.ResumeLayout(false);
            this.home_p.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel home_p;
        private System.Windows.Forms.Button in_login;
        private System.Windows.Forms.Label home_lebel;
        private System.Windows.Forms.Button create;
        private System.Windows.Forms.TextBox in_password;
        private System.Windows.Forms.TextBox in_name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}