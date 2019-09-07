using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;

namespace ProjekPPK
{
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        MySqlConnection con = new MySqlConnection("datasource=localhost; port=3306; username=root; password=; database=projek_ppk;");

        private void btnUplFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpeg;*.png;*.jpg)|*.jpeg;*.png;*.jpg";

            if (open.ShowDialog() == DialogResult.OK)
            {
                tbFoto.Text = open.FileName;
                pbFoto.Image = Image.FromFile(open.FileName);
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            Form_Login frm1 = new Form_Login();
            MySqlCommand cmd, cmd2;
            FileStream fs;
            BinaryReader br;

            string CmdGetNama = "Select nama from siswa where nis='" + frm1.getuid() + "'";
            //string CmdGetNama = "Select nama from siswa where nis='55555'";
            cmd2 = new MySqlCommand(CmdGetNama, con);
            
            if (tbKet.Text.Length > 0)
            {
                try
                {
                    if (tbFoto.Text.Length > 0)
                    {
                        string FileName = tbFoto.Text;
                        byte[] ImageData;
                        fs = new FileStream(FileName, FileMode.Open, FileAccess.Read);
                        br = new BinaryReader(fs);
                        ImageData = br.ReadBytes((int)fs.Length);
                        br.Close();
                        fs.Close();

                        string CmdString = "INSERT into kenangan(nis, nama, gambar, video, keterangan) values (@nis, @nama, @Image, @video, @ket)";
                        cmd = new MySqlCommand(CmdString, con);

                        cmd.Parameters.Add("@Image", MySqlDbType.Blob);
                        //cmd.Parameters.Add("@id", MySqlDbType.Int16, 5);
                        cmd.Parameters.Add("@nis", MySqlDbType.Int16, 5);
                        cmd.Parameters.Add("@nama", MySqlDbType.VarChar, 100);
                        cmd.Parameters.Add("@video", MySqlDbType.VarChar, 10000);
                        cmd.Parameters.Add("@ket", MySqlDbType.VarChar, 100000);

                        cmd.Parameters["@Image"].Value = ImageData;
                       // cmd.Parameters["@id"].Value = 0;
                        cmd.Parameters["@nis"].Value = frm1.getuid();
                        cmd.Parameters["@video"].Value = tbVideo.Text;
                        cmd.Parameters["@ket"].Value = tbKet.Text;
                        con.Open();
                        MySqlDataReader nama_read = cmd2.ExecuteReader();
                        if (nama_read.Read())
                        {
                            cmd.Parameters["@nama"].Value = nama_read.GetValue(0).ToString();
                        }
                        con.Close();

                        con.Open();
                        int RowsAffected = cmd.ExecuteNonQuery();

                        if (RowsAffected > 0)
                        {
                            MessageBox.Show("Data berhasil di upload");
                            Form_AlbumKenangan frm9 = new Form_AlbumKenangan();
                            this.Dispose();
                            frm9.ShowDialog();
                        }
                        con.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    if (con.State == ConnectionState.Open)
                    {
                        con.Close();
                    }
                }

            }
        }

        private void btn_Batal_Click(object sender, EventArgs e)
        {
            Form_AlbumKenangan falbum = new Form_AlbumKenangan();
            this.Dispose();
            falbum.ShowDialog();
        }

        private void Form10_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }
    }
}
