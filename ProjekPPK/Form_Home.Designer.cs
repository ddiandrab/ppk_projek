namespace ProjekPPK
{
    partial class Form_Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Home));
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.linkProfile = new System.Windows.Forms.LinkLabel();
            this.tbDeskripsi = new System.Windows.Forms.TextBox();
            this.btnIPA = new System.Windows.Forms.Button();
            this.btnIPS = new System.Windows.Forms.Button();
            this.btnBHS = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.linkLogout = new System.Windows.Forms.LinkLabel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnAlbumKenangan = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pbLogo
            // 
            this.pbLogo.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pbLogo.ErrorImage")));
            this.pbLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbLogo.Image")));
            this.pbLogo.InitialImage = ((System.Drawing.Image)(resources.GetObject("pbLogo.InitialImage")));
            this.pbLogo.Location = new System.Drawing.Point(13, 12);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(54, 48);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogo.TabIndex = 0;
            this.pbLogo.TabStop = false;
            // 
            // linkProfile
            // 
            this.linkProfile.AutoSize = true;
            this.linkProfile.Location = new System.Drawing.Point(279, 9);
            this.linkProfile.Name = "linkProfile";
            this.linkProfile.Size = new System.Drawing.Size(30, 13);
            this.linkProfile.TabIndex = 2;
            this.linkProfile.TabStop = true;
            this.linkProfile.Text = "Profil";
            this.linkProfile.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkProfile_LinkClicked);
            // 
            // tbDeskripsi
            // 
            this.tbDeskripsi.Location = new System.Drawing.Point(13, 66);
            this.tbDeskripsi.Multiline = true;
            this.tbDeskripsi.Name = "tbDeskripsi";
            this.tbDeskripsi.ReadOnly = true;
            this.tbDeskripsi.Size = new System.Drawing.Size(342, 137);
            this.tbDeskripsi.TabIndex = 3;
            this.tbDeskripsi.Text = "SMA Negeri 94 Jakarta \r\nadalah sekolah yang didirikan pada tahun 2005 yang memili" +
    "ki tenaga pengajar sebanyak 50 orang dan jumlah murid (pada tahun 2015) berjumla" +
    "h 150 orang";
            this.tbDeskripsi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnIPA
            // 
            this.btnIPA.BackColor = System.Drawing.Color.Transparent;
            this.btnIPA.BackgroundImage = global::ProjekPPK.Properties.Resources._2000px_Science_symbol_2;
            this.btnIPA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnIPA.Location = new System.Drawing.Point(13, 219);
            this.btnIPA.Name = "btnIPA";
            this.btnIPA.Size = new System.Drawing.Size(81, 68);
            this.btnIPA.TabIndex = 4;
            this.btnIPA.UseVisualStyleBackColor = false;
            this.btnIPA.Click += new System.EventHandler(this.btnIPA_Click);
            // 
            // btnIPS
            // 
            this.btnIPS.BackColor = System.Drawing.Color.Transparent;
            this.btnIPS.BackgroundImage = global::ProjekPPK.Properties.Resources.IPS;
            this.btnIPS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnIPS.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnIPS.Location = new System.Drawing.Point(142, 219);
            this.btnIPS.Name = "btnIPS";
            this.btnIPS.Size = new System.Drawing.Size(84, 68);
            this.btnIPS.TabIndex = 5;
            this.btnIPS.UseVisualStyleBackColor = false;
            this.btnIPS.Click += new System.EventHandler(this.btnIPS_Click);
            // 
            // btnBHS
            // 
            this.btnBHS.BackColor = System.Drawing.Color.White;
            this.btnBHS.BackgroundImage = global::ProjekPPK.Properties.Resources.BAHASA;
            this.btnBHS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBHS.Location = new System.Drawing.Point(270, 219);
            this.btnBHS.Name = "btnBHS";
            this.btnBHS.Size = new System.Drawing.Size(85, 68);
            this.btnBHS.TabIndex = 6;
            this.btnBHS.UseVisualStyleBackColor = false;
            this.btnBHS.Click += new System.EventHandler(this.btnBHS_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 290);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "IPA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(170, 290);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "IPS";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(287, 290);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "BAHASA";
            // 
            // linkLogout
            // 
            this.linkLogout.AutoSize = true;
            this.linkLogout.Location = new System.Drawing.Point(315, 9);
            this.linkLogout.Name = "linkLogout";
            this.linkLogout.Size = new System.Drawing.Size(40, 13);
            this.linkLogout.TabIndex = 10;
            this.linkLogout.TabStop = true;
            this.linkLogout.Text = "Logout";
            this.linkLogout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLogout_LinkClicked);
            // 
            // btnAlbumKenangan
            // 
            this.btnAlbumKenangan.Location = new System.Drawing.Point(280, 29);
            this.btnAlbumKenangan.Name = "btnAlbumKenangan";
            this.btnAlbumKenangan.Size = new System.Drawing.Size(75, 35);
            this.btnAlbumKenangan.TabIndex = 11;
            this.btnAlbumKenangan.Text = "Album Kenangan";
            this.btnAlbumKenangan.UseVisualStyleBackColor = true;
            this.btnAlbumKenangan.Click += new System.EventHandler(this.btnAlbumKenangan_click);
            // 
            // Form_Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 323);
            this.Controls.Add(this.btnAlbumKenangan);
            this.Controls.Add(this.linkLogout);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnBHS);
            this.Controls.Add(this.btnIPS);
            this.Controls.Add(this.btnIPA);
            this.Controls.Add(this.tbDeskripsi);
            this.Controls.Add(this.linkProfile);
            this.Controls.Add(this.pbLogo);
            this.Name = "Form_Home";
            this.Text = "HOME";
            this.Load += new System.EventHandler(this.Form_Home_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.LinkLabel linkProfile;
        private System.Windows.Forms.TextBox tbDeskripsi;
        private System.Windows.Forms.Button btnIPA;
        private System.Windows.Forms.Button btnIPS;
        private System.Windows.Forms.Button btnBHS;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel linkLogout;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnAlbumKenangan;
    }
}