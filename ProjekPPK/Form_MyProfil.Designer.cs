namespace ProjekPPK
{
    partial class Form_MyProfil
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tbFoto = new System.Windows.Forms.TextBox();
            this.btnUplFoto = new System.Windows.Forms.Button();
            this.pbFoto = new System.Windows.Forms.PictureBox();
            this.btKembali = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblAlamat = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbNama = new System.Windows.Forms.TextBox();
            this.tbTelp = new System.Windows.Forms.TextBox();
            this.tbAlamat = new System.Windows.Forms.TextBox();
            this.tbMotto = new System.Windows.Forms.TextBox();
            this.lblShowNis = new System.Windows.Forms.Label();
            this.lblMotto = new System.Windows.Forms.Label();
            this.lblTelp = new System.Windows.Forms.Label();
            this.lblTTL = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblNama = new System.Windows.Forms.Label();
            this.lblNis = new System.Windows.Forms.Label();
            this.titleProfil = new System.Windows.Forms.Label();
            this.brwFoto = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tbFoto);
            this.splitContainer1.Panel1.Controls.Add(this.btnUplFoto);
            this.splitContainer1.Panel1.Controls.Add(this.pbFoto);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.btKembali);
            this.splitContainer1.Panel2.Controls.Add(this.dateTimePicker1);
            this.splitContainer1.Panel2.Controls.Add(this.lblAlamat);
            this.splitContainer1.Panel2.Controls.Add(this.btnSave);
            this.splitContainer1.Panel2.Controls.Add(this.tbEmail);
            this.splitContainer1.Panel2.Controls.Add(this.tbNama);
            this.splitContainer1.Panel2.Controls.Add(this.tbTelp);
            this.splitContainer1.Panel2.Controls.Add(this.tbAlamat);
            this.splitContainer1.Panel2.Controls.Add(this.tbMotto);
            this.splitContainer1.Panel2.Controls.Add(this.lblShowNis);
            this.splitContainer1.Panel2.Controls.Add(this.lblMotto);
            this.splitContainer1.Panel2.Controls.Add(this.lblTelp);
            this.splitContainer1.Panel2.Controls.Add(this.lblTTL);
            this.splitContainer1.Panel2.Controls.Add(this.lblEmail);
            this.splitContainer1.Panel2.Controls.Add(this.lblNama);
            this.splitContainer1.Panel2.Controls.Add(this.lblNis);
            this.splitContainer1.Panel2.Controls.Add(this.titleProfil);
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(734, 411);
            this.splitContainer1.SplitterDistance = 259;
            this.splitContainer1.TabIndex = 0;
            // 
            // tbFoto
            // 
            this.tbFoto.Location = new System.Drawing.Point(87, 348);
            this.tbFoto.Name = "tbFoto";
            this.tbFoto.Size = new System.Drawing.Size(150, 20);
            this.tbFoto.TabIndex = 3;
            // 
            // btnUplFoto
            // 
            this.btnUplFoto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnUplFoto.Location = new System.Drawing.Point(12, 340);
            this.btnUplFoto.Name = "btnUplFoto";
            this.btnUplFoto.Size = new System.Drawing.Size(69, 35);
            this.btnUplFoto.TabIndex = 2;
            this.btnUplFoto.Text = "Upload Foto";
            this.btnUplFoto.UseVisualStyleBackColor = true;
            this.btnUplFoto.Click += new System.EventHandler(this.btnUplFoto_Click);
            // 
            // pbFoto
            // 
            this.pbFoto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbFoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbFoto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbFoto.Location = new System.Drawing.Point(12, 77);
            this.pbFoto.Name = "pbFoto";
            this.pbFoto.Size = new System.Drawing.Size(239, 240);
            this.pbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFoto.TabIndex = 0;
            this.pbFoto.TabStop = false;
            // 
            // btKembali
            // 
            this.btKembali.Location = new System.Drawing.Point(302, 349);
            this.btKembali.Name = "btKembali";
            this.btKembali.Size = new System.Drawing.Size(72, 34);
            this.btKembali.TabIndex = 18;
            this.btKembali.Text = "Kembali";
            this.btKembali.UseVisualStyleBackColor = true;
            this.btKembali.Click += new System.EventHandler(this.btKembali_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(175, 220);
            this.dateTimePicker1.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker1.MinDate = new System.DateTime(1800, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(280, 20);
            this.dateTimePicker1.TabIndex = 16;
            // 
            // lblAlamat
            // 
            this.lblAlamat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAlamat.AutoSize = true;
            this.lblAlamat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlamat.Location = new System.Drawing.Point(13, 261);
            this.lblAlamat.Name = "lblAlamat";
            this.lblAlamat.Size = new System.Drawing.Size(59, 20);
            this.lblAlamat.TabIndex = 15;
            this.lblAlamat.Text = "Alamat";
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(380, 348);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(74, 35);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Simpan Profil";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tbEmail
            // 
            this.tbEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbEmail.Location = new System.Drawing.Point(175, 150);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(279, 20);
            this.tbEmail.TabIndex = 14;
            // 
            // tbNama
            // 
            this.tbNama.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbNama.Location = new System.Drawing.Point(175, 115);
            this.tbNama.Name = "tbNama";
            this.tbNama.Size = new System.Drawing.Size(279, 20);
            this.tbNama.TabIndex = 13;
            // 
            // tbTelp
            // 
            this.tbTelp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbTelp.Location = new System.Drawing.Point(175, 185);
            this.tbTelp.Name = "tbTelp";
            this.tbTelp.Size = new System.Drawing.Size(279, 20);
            this.tbTelp.TabIndex = 12;
            // 
            // tbAlamat
            // 
            this.tbAlamat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbAlamat.Location = new System.Drawing.Point(175, 261);
            this.tbAlamat.Name = "tbAlamat";
            this.tbAlamat.Size = new System.Drawing.Size(279, 20);
            this.tbAlamat.TabIndex = 11;
            this.tbAlamat.TextChanged += new System.EventHandler(this.tbAlamat_TextChanged);
            // 
            // tbMotto
            // 
            this.tbMotto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbMotto.Location = new System.Drawing.Point(175, 297);
            this.tbMotto.Name = "tbMotto";
            this.tbMotto.Size = new System.Drawing.Size(279, 20);
            this.tbMotto.TabIndex = 10;
            // 
            // lblShowNis
            // 
            this.lblShowNis.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblShowNis.AutoSize = true;
            this.lblShowNis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShowNis.Location = new System.Drawing.Point(171, 80);
            this.lblShowNis.Name = "lblShowNis";
            this.lblShowNis.Size = new System.Drawing.Size(0, 20);
            this.lblShowNis.TabIndex = 8;
            // 
            // lblMotto
            // 
            this.lblMotto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMotto.AutoSize = true;
            this.lblMotto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMotto.Location = new System.Drawing.Point(13, 297);
            this.lblMotto.Name = "lblMotto";
            this.lblMotto.Size = new System.Drawing.Size(50, 20);
            this.lblMotto.TabIndex = 6;
            this.lblMotto.Text = "Motto";
            // 
            // lblTelp
            // 
            this.lblTelp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTelp.AutoSize = true;
            this.lblTelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelp.Location = new System.Drawing.Point(13, 185);
            this.lblTelp.Name = "lblTelp";
            this.lblTelp.Size = new System.Drawing.Size(93, 20);
            this.lblTelp.TabIndex = 5;
            this.lblTelp.Text = "No. Telp/HP";
            // 
            // lblTTL
            // 
            this.lblTTL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTTL.AutoSize = true;
            this.lblTTL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTTL.Location = new System.Drawing.Point(13, 220);
            this.lblTTL.Name = "lblTTL";
            this.lblTTL.Size = new System.Drawing.Size(105, 20);
            this.lblTTL.TabIndex = 4;
            this.lblTTL.Text = "Tanggal Lahir";
            // 
            // lblEmail
            // 
            this.lblEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(13, 150);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(53, 20);
            this.lblEmail.TabIndex = 3;
            this.lblEmail.Text = "E-Mail";
            // 
            // lblNama
            // 
            this.lblNama.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNama.AutoSize = true;
            this.lblNama.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNama.Location = new System.Drawing.Point(13, 115);
            this.lblNama.Name = "lblNama";
            this.lblNama.Size = new System.Drawing.Size(51, 20);
            this.lblNama.TabIndex = 2;
            this.lblNama.Text = "Nama";
            // 
            // lblNis
            // 
            this.lblNis.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNis.AutoSize = true;
            this.lblNis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNis.Location = new System.Drawing.Point(13, 80);
            this.lblNis.Name = "lblNis";
            this.lblNis.Size = new System.Drawing.Size(36, 20);
            this.lblNis.TabIndex = 1;
            this.lblNis.Text = "NIS";
            // 
            // titleProfil
            // 
            this.titleProfil.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.titleProfil.AutoSize = true;
            this.titleProfil.Font = new System.Drawing.Font("Arial Narrow", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleProfil.Location = new System.Drawing.Point(151, 27);
            this.titleProfil.Name = "titleProfil";
            this.titleProfil.Size = new System.Drawing.Size(135, 31);
            this.titleProfil.TabIndex = 0;
            this.titleProfil.Text = "MY PROFIL";
            this.titleProfil.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // brwFoto
            // 
            this.brwFoto.FileName = "FotoProfil";
            // 
            // Form_MyProfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 411);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form_MyProfil";
            this.Text = "MyProfile";
            this.Load += new System.EventHandler(this.Form_MyProfil_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnUplFoto;
        private System.Windows.Forms.Label titleProfil;
        private System.Windows.Forms.Label lblNama;
        private System.Windows.Forms.Label lblNis;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbNama;
        private System.Windows.Forms.TextBox tbTelp;
        private System.Windows.Forms.TextBox tbMotto;
        private System.Windows.Forms.Label lblShowNis;
        private System.Windows.Forms.Label lblMotto;
        private System.Windows.Forms.Label lblTelp;
        private System.Windows.Forms.Label lblTTL;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.OpenFileDialog brwFoto;
        private System.Windows.Forms.PictureBox pbFoto;
        private System.Windows.Forms.TextBox tbFoto;
        private System.Windows.Forms.TextBox tbAlamat;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblAlamat;
        private System.Windows.Forms.Button btKembali;
    }
}