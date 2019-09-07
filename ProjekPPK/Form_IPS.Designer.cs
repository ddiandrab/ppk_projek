namespace ProjekPPK
{
    partial class Form_IPS
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
            this.flpFoto = new System.Windows.Forms.FlowLayoutPanel();
            this.btHome = new System.Windows.Forms.Button();
            this.btn_ips2 = new System.Windows.Forms.Button();
            this.btn_ips1 = new System.Windows.Forms.Button();
            this.lJudul = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // flpFoto
            // 
            this.flpFoto.BackColor = System.Drawing.Color.DimGray;
            this.flpFoto.Location = new System.Drawing.Point(129, 78);
            this.flpFoto.Name = "flpFoto";
            this.flpFoto.Size = new System.Drawing.Size(398, 325);
            this.flpFoto.TabIndex = 14;
            // 
            // btHome
            // 
            this.btHome.Location = new System.Drawing.Point(17, 277);
            this.btHome.Name = "btHome";
            this.btHome.Size = new System.Drawing.Size(70, 23);
            this.btHome.TabIndex = 13;
            this.btHome.Text = "HOME";
            this.btHome.UseVisualStyleBackColor = true;
            this.btHome.Click += new System.EventHandler(this.btHome_Click);
            // 
            // btn_ips2
            // 
            this.btn_ips2.Location = new System.Drawing.Point(17, 233);
            this.btn_ips2.Name = "btn_ips2";
            this.btn_ips2.Size = new System.Drawing.Size(70, 38);
            this.btn_ips2.TabIndex = 12;
            this.btn_ips2.Text = "IPS 2";
            this.btn_ips2.UseVisualStyleBackColor = true;
            this.btn_ips2.Click += new System.EventHandler(this.btn_ips2_Click);
            // 
            // btn_ips1
            // 
            this.btn_ips1.Location = new System.Drawing.Point(17, 188);
            this.btn_ips1.Name = "btn_ips1";
            this.btn_ips1.Size = new System.Drawing.Size(70, 39);
            this.btn_ips1.TabIndex = 11;
            this.btn_ips1.Text = "IPS 1";
            this.btn_ips1.UseVisualStyleBackColor = true;
            this.btn_ips1.Click += new System.EventHandler(this.btn_ips1_Click);
            // 
            // lJudul
            // 
            this.lJudul.AutoSize = true;
            this.lJudul.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lJudul.Location = new System.Drawing.Point(388, 27);
            this.lJudul.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lJudul.Name = "lJudul";
            this.lJudul.Size = new System.Drawing.Size(173, 33);
            this.lJudul.TabIndex = 10;
            this.lJudul.Text = "Jurusan IPS";
            // 
            // Form_IPS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 444);
            this.Controls.Add(this.flpFoto);
            this.Controls.Add(this.btHome);
            this.Controls.Add(this.btn_ips2);
            this.Controls.Add(this.btn_ips1);
            this.Controls.Add(this.lJudul);
            this.Name = "Form_IPS";
            this.Text = "Jurusan IPS";
            this.Load += new System.EventHandler(this.Form_IPS_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpFoto;
        private System.Windows.Forms.Button btHome;
        private System.Windows.Forms.Button btn_ips2;
        private System.Windows.Forms.Button btn_ips1;
        private System.Windows.Forms.Label lJudul;
    }
}