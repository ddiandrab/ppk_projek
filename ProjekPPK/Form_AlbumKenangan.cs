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
using System.Diagnostics;

namespace ProjekPPK
{
    public partial class Form_AlbumKenangan : Form
    {
        
        public Form_AlbumKenangan()
        {
            InitializeComponent();
        }

        MySqlConnection con = new MySqlConnection("datasource=localhost; port=3306; username=root; password=; database=projek_ppk;");

        private void Form_AlbumKenangan_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            label1.Text = "";

            string query = "SELECT * FROM kenangan where gambar!='' and id!=12 order by id desc";
            List<Image> listOfImages = new List<Image>();
            List<String> listofNama = new List<String>();
            List<String> listofKet = new List<String>();
            int s = 0;

            MySqlCommand cmd, cmd2;

            cmd = new MySqlCommand(query, con);
            DataSet ds = new DataSet();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(ds);

            cmd2 = new MySqlCommand("select gambar from kenangan where id=12", con);
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
                    listofNama.Add(Convert.ToString(ds.Tables[0].Rows[s]["nama"]));
                    listofKet.Add(Convert.ToString(ds.Tables[0].Rows[s]["keterangan"]));
                    s++;
                }
                else if (ds.Tables[0].Rows.Count > 0)
                {
                    byte[] xx = (byte[])ds.Tables[0].Rows[s]["gambar"];
                    MemoryStream ms = new MemoryStream(xx);
                    listOfImages.Add(new Bitmap(ms));
                    listofNama.Add(Convert.ToString(ds.Tables[0].Rows[s]["nama"]));
                    listofKet.Add(Convert.ToString(ds.Tables[0].Rows[s]["keterangan"]));
                    s++;
                }
            }
            con.Close();

            {
                flowLayoutPanel1.Controls.Clear();

                int x = 0; //Initialize X as int of value 0
                int y = 0; //Initialize Y as int of value 0
                for (int i = 0; i < listOfImages.Count; i++)
                {
                    PictureBox I = new PictureBox(); //Initialize a new PictureBox of name I
                    Label L = new Label();
                    I.Location = new Point(x, y); //Set the PictureBox location to x,y
                    x += 50; //Sort horizontally; Increment x by 50
                    //y += 50; //Sort vertically; Increment y by 50
                    I.Image = listOfImages[i]; //Set the Image property of I to i in ImagesInFolder as index
                    I.Size = new Size(60, 60);
                    I.SizeMode = PictureBoxSizeMode.StretchImage;
                    L.Text = listofNama[i] + "\r\n\r\n" + listofKet[i];
                    L.Size = new Size(350, 65);
                    L.Padding = new Padding(15, 10, 15, 15);
                    flowLayoutPanel1.Controls.Add(I);
                    flowLayoutPanel1.Controls.Add(L);
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e, string n)
        {
            Process myProcess = new Process();
            try
            {
                // true is the default, but it is important not to set it to false
                myProcess.StartInfo.UseShellExecute = true;
                myProcess.StartInfo.FileName = n;
                myProcess.Start();
            }
            catch (Exception x)
            {
                Console.WriteLine(x.Message);
            }
        }

        private void new_Clicked(object sender, EventArgs e)
        {
            this.Visible = false;
            Form10 frm10 = new Form10();
            frm10.ShowDialog();
        }

        private void viewVideo_Click(object sender, EventArgs e)
        {
            label1.Text = "Klik untuk melihat video";

            string query = "SELECT * FROM kenangan where video!='' and id!=12 order by id desc";
            List<Image> listOfImages = new List<Image>();
            List<String> listofNama = new List<String>();
            List<String> listofVideos = new List<String>();
            List<String> listofKet = new List<String>();
            int s = 0;

            MySqlCommand cmd, cmd2;

            cmd = new MySqlCommand(query, con);
            DataSet ds = new DataSet();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(ds);

            cmd2 = new MySqlCommand("select gambar from kenangan where id=12", con);
            MySqlDataAdapter da2 = new MySqlDataAdapter(cmd2);
            DataSet ds2 = new DataSet();
            da2.Fill(ds2);

            con.Open();
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                if (ds.Tables[0].Rows.Count > 0)
                {
                    byte[] xx = (byte[])ds2.Tables[0].Rows[0]["gambar"];
                    MemoryStream ms = new MemoryStream(xx);
                    listOfImages.Add(new Bitmap(ms));
                    listofNama.Add(Convert.ToString(ds.Tables[0].Rows[s]["nama"]));
                    listofKet.Add(Convert.ToString(ds.Tables[0].Rows[s]["keterangan"]));
                    listofVideos.Add(Convert.ToString(ds.Tables[0].Rows[s]["video"]));
                    s++;
                }
            }
            con.Close();

            {
                flowLayoutPanel1.Controls.Clear();

                int x = 0; //Initialize X as int of value 0
                int y = 0; //Initialize Y as int of value 0
                for (int i = 0; i < listOfImages.Count; i++)
                {
                    PictureBox I = new PictureBox(); //Initialize a new PictureBox of name I
                    Label L = new Label();
                    Label K = new Label();
                    I.Location = new Point(x, y); //Set the PictureBox location to x,y
                    x += 50; //Sort horizontally; Increment x by 50
                    //y += 50; //Sort vertically; Increment y by 50
                    I.Image = listOfImages[i]; //Set the Image property of I to i in ImagesInFolder as index
                    I.Size = new Size(55, 55);
                    I.SizeMode = PictureBoxSizeMode.StretchImage;
                    L.Text = listofNama[i] + "\r\n" + listofKet[i] + " \r\nLink : " + listofVideos[i];;
                    L.Size = new Size(350, 70);
                    L.Padding = new Padding(15, 15, 15, 15);
                    string n = listofVideos[i];
                    I.Click += new EventHandler((snd, ev) => pictureBox1_Click(sender, e, n));

                    flowLayoutPanel1.Controls.Add(I);
                    flowLayoutPanel1.Controls.Add(L);
                }
            }
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form_Home frm3 = new Form_Home();
            frm3.ShowDialog();
        }

        

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
