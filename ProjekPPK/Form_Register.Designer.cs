namespace ProjekPPK
{
    partial class Form_Register
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
            this.lblNIS = new System.Windows.Forms.Label();
            this.lblNama = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblJurusan = new System.Windows.Forms.Label();
            this.lblKelas = new System.Windows.Forms.Label();
            this.lblPass = new System.Windows.Forms.Label();
            this.tbNIS = new System.Windows.Forms.TextBox();
            this.tbNama = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.cbJurusan = new System.Windows.Forms.ComboBox();
            this.cbKelas = new System.Windows.Forms.ComboBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.tbNo = new System.Windows.Forms.TextBox();
            this.tbAlamat = new System.Windows.Forms.TextBox();
            this.tbMotto = new System.Windows.Forms.TextBox();
            this.tbPass = new System.Windows.Forms.TextBox();
            this.lblNoHp = new System.Windows.Forms.Label();
            this.lblTTL = new System.Windows.Forms.Label();
            this.lblAlamat = new System.Windows.Forms.Label();
            this.lblMotto = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNIS
            // 
            this.lblNIS.AutoSize = true;
            this.lblNIS.Location = new System.Drawing.Point(26, 29);
            this.lblNIS.Name = "lblNIS";
            this.lblNIS.Size = new System.Drawing.Size(25, 13);
            this.lblNIS.TabIndex = 0;
            this.lblNIS.Text = "NIS";
            // 
            // lblNama
            // 
            this.lblNama.AutoSize = true;
            this.lblNama.Location = new System.Drawing.Point(26, 58);
            this.lblNama.Name = "lblNama";
            this.lblNama.Size = new System.Drawing.Size(35, 13);
            this.lblNama.TabIndex = 1;
            this.lblNama.Text = "Nama";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(26, 91);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEmail.TabIndex = 2;
            this.lblEmail.Text = "Email";
            // 
            // lblJurusan
            // 
            this.lblJurusan.AutoSize = true;
            this.lblJurusan.Location = new System.Drawing.Point(26, 121);
            this.lblJurusan.Name = "lblJurusan";
            this.lblJurusan.Size = new System.Drawing.Size(44, 13);
            this.lblJurusan.TabIndex = 3;
            this.lblJurusan.Text = "Jurusan";
            // 
            // lblKelas
            // 
            this.lblKelas.AutoSize = true;
            this.lblKelas.Location = new System.Drawing.Point(26, 149);
            this.lblKelas.Name = "lblKelas";
            this.lblKelas.Size = new System.Drawing.Size(33, 13);
            this.lblKelas.TabIndex = 4;
            this.lblKelas.Text = "Kelas";
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Location = new System.Drawing.Point(26, 280);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(53, 13);
            this.lblPass.TabIndex = 5;
            this.lblPass.Text = "Password";
            // 
            // tbNIS
            // 
            this.tbNIS.Location = new System.Drawing.Point(96, 26);
            this.tbNIS.Name = "tbNIS";
            this.tbNIS.Size = new System.Drawing.Size(159, 20);
            this.tbNIS.TabIndex = 7;
            // 
            // tbNama
            // 
            this.tbNama.Location = new System.Drawing.Point(96, 55);
            this.tbNama.Name = "tbNama";
            this.tbNama.Size = new System.Drawing.Size(159, 20);
            this.tbNama.TabIndex = 8;
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(96, 88);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(159, 20);
            this.tbEmail.TabIndex = 9;
            // 
            // cbJurusan
            // 
            this.cbJurusan.FormattingEnabled = true;
            this.cbJurusan.Items.AddRange(new object[] {
            "IPA",
            "IPS",
            "Bahasa"});
            this.cbJurusan.Location = new System.Drawing.Point(96, 118);
            this.cbJurusan.Name = "cbJurusan";
            this.cbJurusan.Size = new System.Drawing.Size(159, 21);
            this.cbJurusan.TabIndex = 10;
            // 
            // cbKelas
            // 
            this.cbKelas.FormattingEnabled = true;
            this.cbKelas.Items.AddRange(new object[] {
            "IPA1",
            "IPA2",
            "IPS1",
            "IPS2",
            "BHS1"});
            this.cbKelas.Location = new System.Drawing.Point(96, 146);
            this.cbKelas.Name = "cbKelas";
            this.cbKelas.Size = new System.Drawing.Size(159, 21);
            this.cbKelas.TabIndex = 11;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(177, 314);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 14;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // tbNo
            // 
            this.tbNo.Location = new System.Drawing.Point(96, 173);
            this.tbNo.Name = "tbNo";
            this.tbNo.Size = new System.Drawing.Size(159, 20);
            this.tbNo.TabIndex = 15;
            // 
            // tbAlamat
            // 
            this.tbAlamat.Location = new System.Drawing.Point(96, 225);
            this.tbAlamat.Name = "tbAlamat";
            this.tbAlamat.Size = new System.Drawing.Size(159, 20);
            this.tbAlamat.TabIndex = 16;
            // 
            // tbMotto
            // 
            this.tbMotto.Location = new System.Drawing.Point(96, 251);
            this.tbMotto.Name = "tbMotto";
            this.tbMotto.Size = new System.Drawing.Size(159, 20);
            this.tbMotto.TabIndex = 17;
            // 
            // tbPass
            // 
            this.tbPass.Location = new System.Drawing.Point(96, 277);
            this.tbPass.Name = "tbPass";
            this.tbPass.PasswordChar = '*';
            this.tbPass.Size = new System.Drawing.Size(159, 20);
            this.tbPass.TabIndex = 18;
            // 
            // lblNoHp
            // 
            this.lblNoHp.AutoSize = true;
            this.lblNoHp.Location = new System.Drawing.Point(26, 176);
            this.lblNoHp.Name = "lblNoHp";
            this.lblNoHp.Size = new System.Drawing.Size(39, 13);
            this.lblNoHp.TabIndex = 19;
            this.lblNoHp.Text = "No HP";
            // 
            // lblTTL
            // 
            this.lblTTL.AutoSize = true;
            this.lblTTL.Location = new System.Drawing.Point(26, 199);
            this.lblTTL.Name = "lblTTL";
            this.lblTTL.Size = new System.Drawing.Size(72, 13);
            this.lblTTL.TabIndex = 20;
            this.lblTTL.Text = "Tanggal Lahir";
            // 
            // lblAlamat
            // 
            this.lblAlamat.AutoSize = true;
            this.lblAlamat.Location = new System.Drawing.Point(26, 225);
            this.lblAlamat.Name = "lblAlamat";
            this.lblAlamat.Size = new System.Drawing.Size(39, 13);
            this.lblAlamat.TabIndex = 21;
            this.lblAlamat.Text = "Alamat";
            // 
            // lblMotto
            // 
            this.lblMotto.AutoSize = true;
            this.lblMotto.Location = new System.Drawing.Point(26, 254);
            this.lblMotto.Name = "lblMotto";
            this.lblMotto.Size = new System.Drawing.Size(34, 13);
            this.lblMotto.TabIndex = 22;
            this.lblMotto.Text = "Motto";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(96, 199);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(159, 20);
            this.dateTimePicker1.TabIndex = 23;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(96, 314);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 26;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // Form_Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 349);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lblMotto);
            this.Controls.Add(this.lblAlamat);
            this.Controls.Add(this.lblTTL);
            this.Controls.Add(this.lblNoHp);
            this.Controls.Add(this.tbPass);
            this.Controls.Add(this.tbMotto);
            this.Controls.Add(this.tbAlamat);
            this.Controls.Add(this.tbNo);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.cbKelas);
            this.Controls.Add(this.cbJurusan);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.tbNama);
            this.Controls.Add(this.tbNIS);
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this.lblKelas);
            this.Controls.Add(this.lblJurusan);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblNama);
            this.Controls.Add(this.lblNIS);
            this.Name = "Form_Register";
            this.Text = "REGISTER";
            this.Load += new System.EventHandler(this.Form_Register_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNIS;
        private System.Windows.Forms.Label lblNama;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblJurusan;
        private System.Windows.Forms.Label lblKelas;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.TextBox tbNIS;
        private System.Windows.Forms.TextBox tbNama;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.ComboBox cbJurusan;
        private System.Windows.Forms.ComboBox cbKelas;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox tbNo;
        private System.Windows.Forms.TextBox tbAlamat;
        private System.Windows.Forms.TextBox tbMotto;
        private System.Windows.Forms.TextBox tbPass;
        private System.Windows.Forms.Label lblNoHp;
        private System.Windows.Forms.Label lblTTL;
        private System.Windows.Forms.Label lblAlamat;
        private System.Windows.Forms.Label lblMotto;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnCancel;
    }
}