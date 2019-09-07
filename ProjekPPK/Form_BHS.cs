using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using MySql.Data.MySqlClient;

namespace ProjekPPK
{
    public partial class Form_BHS : Form
    {
        public Form_BHS()
        {
            InitializeComponent();
        }


        MySqlConnection con = new MySqlConnection("datasource=localhost; port=3306; username=root; password=; database=projek_ppk;");

        public static string BioSiswa;
        public static string dari = "form7";
        public string getbio()
        {
            return BioSiswa;
        }
        public string from()
        {
            return dari;
        }
        private void pictureBox1_Click(object sender, EventArgs e, string n)
        {
            Form8 frm8 = new Form8(dari);
            BioSiswa = n;
            frm8.ShowDialog();
        }

        private void btHome_Click(object sender, EventArgs e)
        {
            Form_Home fr3 = new Form_Home();
            this.Dispose();
            fr3.ShowDialog();
        }

        private void bt_bhs_Click(object sender, EventArgs e)
        {
            string query = "SELECT nis, gambar FROM siswa where kelas = 'BHS1' order by nama";
            List<Image> listOfImages = new List<Image>();
            List<String> listofNis = new List<String>();
            int s = 0;

            MySqlCommand cmd, cmd2;

            cmd = new MySqlCommand(query, con);
            DataSet ds = new DataSet();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(ds);

            cmd2 = new MySqlCommand("select gambar from siswa where NIS='00001'", con);
            MySqlDataAdapter da2 = new MySqlDataAdapter(cmd2);
            DataSet ds2 = new DataSet();
            da2.Fill(ds2);

            con.Open();
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                if (dr.IsNull("gambar"))
                {
                    MemoryStream ms = new MemoryStream((byte[])ds2.Tables[0].Rows[0]["gambar"]);
                    listOfImages.Add(new Bitmap(ms));
                    listofNis.Add(Convert.ToString(ds.Tables[0].Rows[s]["nis"]));
                    s++;
                }
                else if (ds.Tables[0].Rows.Count > 0)
                {
                    byte[] xx = (byte[])ds.Tables[0].Rows[s]["gambar"];
                    MemoryStream ms = new MemoryStream(xx);
                    listOfImages.Add(new Bitmap(ms));
                    listofNis.Add(Convert.ToString(ds.Tables[0].Rows[s]["nis"]));
                    s++;
                }
            }
            con.Close();

            {
                flpFoto.Controls.Clear();

                int x = 0; //Initialize X as int of value 0
                int y = 0; //Initialize Y as int of value 0
                for (int i = 0; i < listOfImages.Count; i++)
                {
                    PictureBox I = new PictureBox(); //Initialize a new PictureBox of name I
                    I.Location = new Point(x, y); //Set the PictureBox location to x,y
                    x += 50; //Sort horizontally; Increment x by 50
                    //y += 50; //Sort vertically; Increment y by 50
                    I.Image = listOfImages[i]; //Set the Image property of I to i in ImagesInFolder as index
                    I.Size = new Size(60, 60);
                    I.SizeMode = PictureBoxSizeMode.StretchImage;
                    string n = listofNis[i];
                    I.Click += new EventHandler((snd, ev) => pictureBox1_Click(sender, e, n));
                    flpFoto.Controls.Add(I);
                }
            }
        }

        private void Form_BHS_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }
    }
}

