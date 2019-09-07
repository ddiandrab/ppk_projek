using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyProfile
{
    public partial class MyProfile : Form
    {
        public MyProfile()
        {
            InitializeComponent();
        }

        private void btnUplFoto_Click(object sender, EventArgs e)
        {
            // open file dialog   
            OpenFileDialog open = new OpenFileDialog();
            // image filters  
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp; *.png)|*.jpg; *.jpeg; *.gif; *.bmp; *.png";
            if (open.ShowDialog() == DialogResult.OK)
            {
                // display image in picture box  
                pbFoto.SizeMode = PictureBoxSizeMode.StretchImage;
                pbFoto.Image = new Bitmap(open.FileName);
            }


        }

        private void btnDelFoto_Click(object sender, EventArgs e)
        {
            pbFoto.Image = null;
        }
    }
}
