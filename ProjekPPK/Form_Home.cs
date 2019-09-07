using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjekPPK
{
    public partial class Form_Home : Form
    {
        public Form_Home()
        {
            InitializeComponent();
        }
        
        private void btnBHS_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form_BHS fr7 = new Form_BHS();
            fr7.ShowDialog();
        }
        
        private void btnIPS_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form_IPS fr6 = new Form_IPS();
            fr6.ShowDialog();
        }

        private void btnIPA_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form_IPA fr5 = new Form_IPA();
            fr5.ShowDialog();
        }

        private void linkLogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Visible = false;
            Form_Login fr1 = new Form_Login();
            fr1.ShowDialog();
        }

        private void linkProfile_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Visible = false;
            Form_MyProfil fr4 = new Form_MyProfil();
            fr4.ShowDialog();
        }
        
        private void btnAlbumKenangan_click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form_AlbumKenangan frm9 = new Form_AlbumKenangan();
            frm9.ShowDialog();
        }

        private void Form_Home_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }
    }
}
