namespace mass
{
    partial class create
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
            this.create_p = new System.Windows.Forms.Panel();
            this.create_m = new System.Windows.Forms.Button();
            this.create_lebel = new System.Windows.Forms.Label();
            this.month = new System.Windows.Forms.TextBox();
            this.c_password = new System.Windows.Forms.TextBox();
            this.m_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nom = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.create_p.SuspendLayout();
            this.SuspendLayout();
            // 
            // create_p
            // 
            this.create_p.Controls.Add(this.create_m);
            this.create_p.Controls.Add(this.create_lebel);
            this.create_p.Controls.Add(this.month);
            this.create_p.Controls.Add(this.c_password);
            this.create_p.Controls.Add(this.m_name);
            this.create_p.Controls.Add(this.label2);
            this.create_p.Controls.Add(this.nom);
            this.create_p.Controls.Add(this.name);
            this.create_p.Location = new System.Drawing.Point(70, 40);
            this.create_p.Name = "create_p";
            this.create_p.Size = new System.Drawing.Size(334, 255);
            this.create_p.TabIndex = 1;
            // 
            // create_m
            // 
            this.create_m.Location = new System.Drawing.Point(205, 210);
            this.create_m.Name = "create_m";
            this.create_m.Size = new System.Drawing.Size(66, 21);
            this.create_m.TabIndex = 2;
            this.create_m.Text = "create";
            this.create_m.UseVisualStyleBackColor = true;
            this.create_m.Click += new System.EventHandler(this.create_m_Click);
            // 
            // create_lebel
            // 
            this.create_lebel.AutoSize = true;
            this.create_lebel.Location = new System.Drawing.Point(109, 17);
            this.create_lebel.Name = "create_lebel";
            this.create_lebel.Size = new System.Drawing.Size(119, 13);
            this.create_lebel.TabIndex = 1;
            this.create_lebel.Text = "Mass Managing System";
            // 
            // month
            // 
            this.month.Location = new System.Drawing.Point(132, 160);
            this.month.Name = "month";
            this.month.Size = new System.Drawing.Size(139, 20);
            this.month.TabIndex = 2;
            // 
            // c_password
            // 
            this.c_password.Location = new System.Drawing.Point(132, 117);
            this.c_password.Name = "c_password";
            this.c_password.Size = new System.Drawing.Size(139, 20);
            this.c_password.TabIndex = 2;
            // 
            // m_name
            // 
            this.m_name.Location = new System.Drawing.Point(132, 71);
            this.m_name.Name = "m_name";
            this.m_name.Size = new System.Drawing.Size(139, 20);
            this.m_name.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Starting month:";
            // 
            // nom
            // 
            this.nom.AutoSize = true;
            this.nom.Location = new System.Drawing.Point(47, 120);
            this.nom.Name = "nom";
            this.nom.Size = new System.Drawing.Size(56, 13);
            this.nom.TabIndex = 1;
            this.nom.Text = "Password:";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(47, 74);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(64, 13);
            this.name.TabIndex = 1;
            this.name.Text = "Mass name:";
            // 
            // create
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 335);
            this.Controls.Add(this.create_p);
            this.Name = "create";
            this.Text = "create";
            this.create_p.ResumeLayout(false);
            this.create_p.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel create_p;
        private System.Windows.Forms.Button create_m;
        private System.Windows.Forms.Label create_lebel;
        private System.Windows.Forms.TextBox month;
        private System.Windows.Forms.TextBox c_password;
        private System.Windows.Forms.TextBox m_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label nom;
        private System.Windows.Forms.Label name;
    }
}