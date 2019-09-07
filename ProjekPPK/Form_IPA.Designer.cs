namespace ProjekPPK
{
    partial class Form_IPA
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
            this.lJudul = new System.Windows.Forms.Label();
            this.btn_ipa1 = new System.Windows.Forms.Button();
            this.btn_ipa2 = new System.Windows.Forms.Button();
            this.btHome = new System.Windows.Forms.Button();
            this.flpFoto = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // lJudul
            // 
            this.lJudul.AutoSize = true;
            this.lJudul.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lJudul.Location = new System.Drawing.Point(394, 18);
            this.lJudul.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lJudul.Name = "lJudul";
            this.lJudul.Size = new System.Drawing.Size(173, 33);
            this.lJudul.TabIndex = 0;
            this.lJudul.Text = "Jurusan IPA";
            // 
            // btn_ipa1
            // 
            this.btn_ipa1.Location = new System.Drawing.Point(23, 179);
            this.btn_ipa1.Name = "btn_ipa1";
            this.btn_ipa1.Size = new System.Drawing.Size(70, 39);
            this.btn_ipa1.TabIndex = 5;
            this.btn_ipa1.Text = "IPA 1";
            this.btn_ipa1.UseVisualStyleBackColor = true;
            this.btn_ipa1.Click += new System.EventHandler(this.btn_ipa1_Click);
            // 
            // btn_ipa2
            // 
            this.btn_ipa2.Location = new System.Drawing.Point(23, 224);
            this.btn_ipa2.Name = "btn_ipa2";
            this.btn_ipa2.Size = new System.Drawing.Size(70, 38);
            this.btn_ipa2.TabIndex = 6;
            this.btn_ipa2.Text = "IPA 2";
            this.btn_ipa2.UseVisualStyleBackColor = true;
            this.btn_ipa2.Click += new System.EventHandler(this.btn_ipa2_Click);
            // 
            // btHome
            // 
            this.btHome.Location = new System.Drawing.Point(23, 268);
            this.btHome.Name = "btHome";
            this.btHome.Size = new System.Drawing.Size(70, 23);
            this.btHome.TabIndex = 8;
            this.btHome.Text = "HOME";
            this.btHome.UseVisualStyleBackColor = true;
            this.btHome.Click += new System.EventHandler(this.btHome_Click);
            // 
            // flpFoto
            // 
            this.flpFoto.BackColor = System.Drawing.Color.DimGray;
            this.flpFoto.Location = new System.Drawing.Point(134, 79);
            this.flpFoto.Name = "flpFoto";
            this.flpFoto.Size = new System.Drawing.Size(398, 325);
            this.flpFoto.TabIndex = 9;
            // 
            // Form_IPA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 444);
            this.Controls.Add(this.flpFoto);
            this.Controls.Add(this.btHome);
            this.Controls.Add(this.btn_ipa2);
            this.Controls.Add(this.btn_ipa1);
            this.Controls.Add(this.lJudul);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_IPA";
            this.Text = "Jurusan IPA";
            this.Load += new System.EventHandler(this.Form_IPA_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lJudul;
        private System.Windows.Forms.Button btn_ipa1;
        private System.Windows.Forms.Button btn_ipa2;
        private System.Windows.Forms.Button btHome;
        private System.Windows.Forms.FlowLayoutPanel flpFoto;
    }
}