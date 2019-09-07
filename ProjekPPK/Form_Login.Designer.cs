namespace ProjekPPK
{
    partial class Form_Login
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
            this.lblJudul = new System.Windows.Forms.Label();
            this.lblNIS = new System.Windows.Forms.Label();
            this.lblPass = new System.Windows.Forms.Label();
            this.tbNIS = new System.Windows.Forms.TextBox();
            this.tbPass = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lblJudul
            // 
            this.lblJudul.AutoSize = true;
            this.lblJudul.Location = new System.Drawing.Point(119, 22);
            this.lblJudul.Name = "lblJudul";
            this.lblJudul.Size = new System.Drawing.Size(64, 13);
            this.lblJudul.TabIndex = 0;
            this.lblJudul.Text = "LOGIN BKS";
            // 
            // lblNIS
            // 
            this.lblNIS.AutoSize = true;
            this.lblNIS.Location = new System.Drawing.Point(23, 72);
            this.lblNIS.Name = "lblNIS";
            this.lblNIS.Size = new System.Drawing.Size(25, 13);
            this.lblNIS.TabIndex = 1;
            this.lblNIS.Text = "NIS";
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Location = new System.Drawing.Point(23, 120);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(53, 13);
            this.lblPass.TabIndex = 2;
            this.lblPass.Text = "Password";
            // 
            // tbNIS
            // 
            this.tbNIS.Location = new System.Drawing.Point(96, 69);
            this.tbNIS.Name = "tbNIS";
            this.tbNIS.Size = new System.Drawing.Size(161, 20);
            this.tbNIS.TabIndex = 3;
            // 
            // tbPass
            // 
            this.tbPass.Location = new System.Drawing.Point(96, 117);
            this.tbPass.Name = "tbPass";
            this.tbPass.PasswordChar = '*';
            this.tbPass.Size = new System.Drawing.Size(161, 20);
            this.tbPass.TabIndex = 4;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(182, 182);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "LOGIN";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(96, 182);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(75, 23);
            this.btnRegister.TabIndex = 6;
            this.btnRegister.Text = "REGISTER";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(96, 144);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(53, 17);
            this.checkBox1.TabIndex = 7;
            this.checkBox1.Text = "Show";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Form_Login
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 265);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.tbPass);
            this.Controls.Add(this.tbNIS);
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this.lblNIS);
            this.Controls.Add(this.lblJudul);
            this.Name = "Form_Login";
            this.Text = "LOGIN";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_Login_FormClosed);
            this.Load += new System.EventHandler(this.Form_Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblJudul;
        private System.Windows.Forms.Label lblNIS;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.TextBox tbNIS;
        private System.Windows.Forms.TextBox tbPass;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

