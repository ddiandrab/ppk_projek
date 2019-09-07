namespace MyProfile
{
    partial class MyProfile
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
            this.btnUplFoto = new System.Windows.Forms.Button();
            this.btnDelFoto = new System.Windows.Forms.Button();
            this.pbFoto = new System.Windows.Forms.PictureBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbNama = new System.Windows.Forms.TextBox();
            this.tbTelp = new System.Windows.Forms.TextBox();
            this.tbAlamat = new System.Windows.Forms.TextBox();
            this.tbMotto = new System.Windows.Forms.TextBox();
            this.tbPass = new System.Windows.Forms.TextBox();
            this.lblShowNis = new System.Windows.Forms.Label();
            this.lblPass = new System.Windows.Forms.Label();
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
            this.splitContainer1.Panel1.Controls.Add(this.btnUplFoto);
            this.splitContainer1.Panel1.Controls.Add(this.btnDelFoto);
            this.splitContainer1.Panel1.Controls.Add(this.pbFoto);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.btnSave);
            this.splitContainer1.Panel2.Controls.Add(this.tbEmail);
            this.splitContainer1.Panel2.Controls.Add(this.tbNama);
            this.splitContainer1.Panel2.Controls.Add(this.tbTelp);
            this.splitContainer1.Panel2.Controls.Add(this.tbAlamat);
            this.splitContainer1.Panel2.Controls.Add(this.tbMotto);
            this.splitContainer1.Panel2.Controls.Add(this.tbPass);
            this.splitContainer1.Panel2.Controls.Add(this.lblShowNis);
            this.splitContainer1.Panel2.Controls.Add(this.lblPass);
            this.splitContainer1.Panel2.Controls.Add(this.lblMotto);
            this.splitContainer1.Panel2.Controls.Add(this.lblTelp);
            this.splitContainer1.Panel2.Controls.Add(this.lblTTL);
            this.splitContainer1.Panel2.Controls.Add(this.lblEmail);
            this.splitContainer1.Panel2.Controls.Add(this.lblNama);
            this.splitContainer1.Panel2.Controls.Add(this.lblNis);
            this.splitContainer1.Panel2.Controls.Add(this.titleProfil);
            this.splitContainer1.Size = new System.Drawing.Size(734, 411);
            this.splitContainer1.SplitterDistance = 260;
            this.splitContainer1.TabIndex = 0;
            // 
            // btnUplFoto
            // 
            this.btnUplFoto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnUplFoto.Location = new System.Drawing.Point(151, 340);
            this.btnUplFoto.Name = "btnUplFoto";
            this.btnUplFoto.Size = new System.Drawing.Size(100, 35);
            this.btnUplFoto.TabIndex = 2;
            this.btnUplFoto.Text = "Upload Foto";
            this.btnUplFoto.UseVisualStyleBackColor = true;
            this.btnUplFoto.Click += new System.EventHandler(this.btnUplFoto_Click);
            // 
            // btnDelFoto
            // 
            this.btnDelFoto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDelFoto.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnDelFoto.Location = new System.Drawing.Point(11, 340);
            this.btnDelFoto.Name = "btnDelFoto";
            this.btnDelFoto.Size = new System.Drawing.Size(100, 35);
            this.btnDelFoto.TabIndex = 1;
            this.btnDelFoto.Text = "Hapus Foto";
            this.btnDelFoto.UseVisualStyleBackColor = true;
            this.btnDelFoto.Click += new System.EventHandler(this.btnDelFoto_Click);
            // 
            // pbFoto
            // 
            this.pbFoto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbFoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbFoto.Location = new System.Drawing.Point(11, 79);
            this.pbFoto.Name = "pbFoto";
            this.pbFoto.Size = new System.Drawing.Size(240, 240);
            this.pbFoto.TabIndex = 0;
            this.pbFoto.TabStop = false;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(355, 340);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 35);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Simpan Profil";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // tbEmail
            // 
            this.tbEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbEmail.Location = new System.Drawing.Point(175, 150);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(280, 20);
            this.tbEmail.TabIndex = 14;
            // 
            // tbNama
            // 
            this.tbNama.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbNama.Location = new System.Drawing.Point(175, 115);
            this.tbNama.Name = "tbNama";
            this.tbNama.Size = new System.Drawing.Size(280, 20);
            this.tbNama.TabIndex = 13;
            // 
            // tbTelp
            // 
            this.tbTelp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbTelp.Location = new System.Drawing.Point(175, 185);
            this.tbTelp.Name = "tbTelp";
            this.tbTelp.Size = new System.Drawing.Size(280, 20);
            this.tbTelp.TabIndex = 12;
            // 
            // tbAlamat
            // 
            this.tbAlamat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbAlamat.Location = new System.Drawing.Point(175, 220);
            this.tbAlamat.Name = "tbAlamat";
            this.tbAlamat.Size = new System.Drawing.Size(280, 20);
            this.tbAlamat.TabIndex = 11;
            // 
            // tbMotto
            // 
            this.tbMotto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbMotto.Location = new System.Drawing.Point(175, 255);
            this.tbMotto.Name = "tbMotto";
            this.tbMotto.Size = new System.Drawing.Size(280, 20);
            this.tbMotto.TabIndex = 10;
            // 
            // tbPass
            // 
            this.tbPass.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPass.Location = new System.Drawing.Point(175, 290);
            this.tbPass.Name = "tbPass";
            this.tbPass.Size = new System.Drawing.Size(280, 20);
            this.tbPass.TabIndex = 9;
            // 
            // lblShowNis
            // 
            this.lblShowNis.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblShowNis.AutoSize = true;
            this.lblShowNis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShowNis.Location = new System.Drawing.Point(171, 80);
            this.lblShowNis.Name = "lblShowNis";
            this.lblShowNis.Size = new System.Drawing.Size(36, 20);
            this.lblShowNis.TabIndex = 8;
            this.lblShowNis.Text = "NIS";
            // 
            // lblPass
            // 
            this.lblPass.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPass.AutoSize = true;
            this.lblPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPass.Location = new System.Drawing.Point(13, 290);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(78, 20);
            this.lblPass.TabIndex = 7;
            this.lblPass.Text = "Password";
            // 
            // lblMotto
            // 
            this.lblMotto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMotto.AutoSize = true;
            this.lblMotto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMotto.Location = new System.Drawing.Point(13, 255);
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
            this.lblTTL.Size = new System.Drawing.Size(163, 20);
            this.lblTTL.TabIndex = 4;
            this.lblTTL.Text = "Tempat/Tanggal Lahir";
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
            this.titleProfil.Location = new System.Drawing.Point(150, 27);
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
            // MyProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 411);
            this.Controls.Add(this.splitContainer1);
            this.Name = "MyProfile";
            this.Text = "MyProfile";
            this.splitContainer1.Panel1.ResumeLayout(false);
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
        private System.Windows.Forms.PictureBox pbFoto;
        private System.Windows.Forms.Label titleProfil;
        private System.Windows.Forms.Label lblNama;
        private System.Windows.Forms.Label lblNis;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbNama;
        private System.Windows.Forms.TextBox tbTelp;
        private System.Windows.Forms.TextBox tbAlamat;
        private System.Windows.Forms.TextBox tbMotto;
        private System.Windows.Forms.TextBox tbPass;
        private System.Windows.Forms.Label lblShowNis;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.Label lblMotto;
        private System.Windows.Forms.Label lblTelp;
        private System.Windows.Forms.Label lblTTL;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelFoto;
        private System.Windows.Forms.OpenFileDialog brwFoto;
    }
}

