namespace ProjekPPK
{
    partial class Form_BHS
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
            this.bt_bhs = new System.Windows.Forms.Button();
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
            this.btHome.Location = new System.Drawing.Point(17, 233);
            this.btHome.Name = "btHome";
            this.btHome.Size = new System.Drawing.Size(70, 23);
            this.btHome.TabIndex = 13;
            this.btHome.Text = "HOME";
            this.btHome.UseVisualStyleBackColor = true;
            this.btHome.Click += new System.EventHandler(this.btHome_Click);
            // 
            // bt_bhs
            // 
            this.bt_bhs.Location = new System.Drawing.Point(17, 188);
            this.bt_bhs.Name = "bt_bhs";
            this.bt_bhs.Size = new System.Drawing.Size(70, 39);
            this.bt_bhs.TabIndex = 11;
            this.bt_bhs.Text = "BHS 1";
            this.bt_bhs.UseVisualStyleBackColor = true;
            this.bt_bhs.Click += new System.EventHandler(this.bt_bhs_Click);
            // 
            // lJudul
            // 
            this.lJudul.AutoSize = true;
            this.lJudul.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lJudul.Location = new System.Drawing.Point(343, 28);
            this.lJudul.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lJudul.Name = "lJudul";
            this.lJudul.Size = new System.Drawing.Size(225, 33);
            this.lJudul.TabIndex = 10;
            this.lJudul.Text = "Jurusan Bahasa";
            // 
            // Form_BHS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 444);
            this.Controls.Add(this.flpFoto);
            this.Controls.Add(this.btHome);
            this.Controls.Add(this.bt_bhs);
            this.Controls.Add(this.lJudul);
            this.Name = "Form_BHS";
            this.Text = "Jurusan Bahasa";
            this.Load += new System.EventHandler(this.Form_BHS_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpFoto;
        private System.Windows.Forms.Button btHome;
        private System.Windows.Forms.Button bt_bhs;
        private System.Windows.Forms.Label lJudul;
    }
}