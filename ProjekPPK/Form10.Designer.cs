namespace ProjekPPK
{
    partial class Form10
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
            this.tbFoto = new System.Windows.Forms.TextBox();
            this.btnUplFoto = new System.Windows.Forms.Button();
            this.pbFoto = new System.Windows.Forms.PictureBox();
            this.tbKet = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSend = new System.Windows.Forms.Button();
            this.tbVideo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Batal = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // tbFoto
            // 
            this.tbFoto.Location = new System.Drawing.Point(102, 342);
            this.tbFoto.Name = "tbFoto";
            this.tbFoto.Size = new System.Drawing.Size(150, 20);
            this.tbFoto.TabIndex = 6;
            // 
            // btnUplFoto
            // 
            this.btnUplFoto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnUplFoto.Location = new System.Drawing.Point(25, 327);
            this.btnUplFoto.Name = "btnUplFoto";
            this.btnUplFoto.Size = new System.Drawing.Size(69, 35);
            this.btnUplFoto.TabIndex = 5;
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
            this.pbFoto.Location = new System.Drawing.Point(25, 62);
            this.pbFoto.Name = "pbFoto";
            this.pbFoto.Size = new System.Drawing.Size(250, 250);
            this.pbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFoto.TabIndex = 4;
            this.pbFoto.TabStop = false;
            // 
            // tbKet
            // 
            this.tbKet.Location = new System.Drawing.Point(284, 175);
            this.tbKet.Multiline = true;
            this.tbKet.Name = "tbKet";
            this.tbKet.Size = new System.Drawing.Size(289, 137);
            this.tbKet.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(281, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 18);
            this.label1.TabIndex = 8;
            this.label1.Text = "Keterangan";
            // 
            // btnSend
            // 
            this.btnSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSend.Location = new System.Drawing.Point(499, 334);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(74, 35);
            this.btnSend.TabIndex = 9;
            this.btnSend.Text = "Kirim";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // tbVideo
            // 
            this.tbVideo.Location = new System.Drawing.Point(281, 83);
            this.tbVideo.Multiline = true;
            this.tbVideo.Name = "tbVideo";
            this.tbVideo.Size = new System.Drawing.Size(292, 42);
            this.tbVideo.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label2.Location = new System.Drawing.Point(281, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "Link Video";
            // 
            // btn_Batal
            // 
            this.btn_Batal.Location = new System.Drawing.Point(418, 334);
            this.btn_Batal.Name = "btn_Batal";
            this.btn_Batal.Size = new System.Drawing.Size(75, 35);
            this.btn_Batal.TabIndex = 12;
            this.btn_Batal.Text = "Batal";
            this.btn_Batal.UseVisualStyleBackColor = true;
            this.btn_Batal.Click += new System.EventHandler(this.btn_Batal_Click);
            // 
            // Form10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 387);
            this.Controls.Add(this.btn_Batal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbVideo);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbKet);
            this.Controls.Add(this.tbFoto);
            this.Controls.Add(this.btnUplFoto);
            this.Controls.Add(this.pbFoto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form10";
            this.Text = "Form10";
            this.Load += new System.EventHandler(this.Form10_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbFoto;
        private System.Windows.Forms.Button btnUplFoto;
        private System.Windows.Forms.PictureBox pbFoto;
        private System.Windows.Forms.TextBox tbKet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox tbVideo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Batal;
    }
}