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
    public partial class Form_MyProfil : Form
    {
        public Form_MyProfil()
        {
            InitializeComponent();
        }

        
            Form_Login f1 = new Form_Login();
            
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            
            Form_Home fr3 = new Form_Home();
            
            MySqlCommand cmd;
            FileStream fs;
            BinaryReader br;
            int RowsAffected=0;

            //Kalo ubah foto
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

                  
                   string CmdString = "UPDATE siswa set gambar=@Image " +
                     "where NIS='" + lblShowNis.Text + "'";

                    cmd = new MySqlCommand(CmdString, con);
                    
                    cmd.Parameters.Add("@Image", MySqlDbType.Blob);
                    cmd.Parameters["@Image"].Value = ImageData;

                    con.Open();
                    RowsAffected = cmd.ExecuteNonQuery();
                    RowsAffected = 1;
                    con.Close();
                }
                else if (lblShowNis.Text.Length > 0)
                {

                    string CmdString = "UPDATE siswa set nama=@Nama, email=@Email, alamat=@Alamat, no_hp=@Nope, motto=@Motto, ttl=@Ttl " +
                      "where NIS='" + lblShowNis.Text + "'";

                    cmd = new MySqlCommand(CmdString, con);

                    cmd.Parameters.Add("@Nama", MySqlDbType.VarChar, 50);
                    cmd.Parameters.Add("@Email", MySqlDbType.VarChar, 100);
                    cmd.Parameters.Add("@Alamat", MySqlDbType.VarChar, 100);
                    cmd.Parameters.Add("@Nope", MySqlDbType.VarChar, 100);
                    cmd.Parameters.Add("@Motto", MySqlDbType.VarChar, 100);
                    cmd.Parameters.Add("@Ttl", MySqlDbType.Date);

                    cmd.Parameters["@Nama"].Value = tbNama.Text;
                    cmd.Parameters["@Email"].Value = tbEmail.Text;
                    cmd.Parameters["@Alamat"].Value = tbAlamat.Text;
                    cmd.Parameters["@Nope"].Value = tbTelp.Text;
                    cmd.Parameters["@Motto"].Value = tbMotto.Text;
                    cmd.Parameters["@Ttl"].Value = dateTimePicker1.Value;


                    con.Open();
                    RowsAffected = cmd.ExecuteNonQuery();
                    RowsAffected = 1;
                    con.Close();
                }
                if (RowsAffected > 0)
                {
                        MessageBox.Show("Data berhasil di update");
                }
                else
                {
                    MessageBox.Show("Data harus lengkap!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void tbAlamat_TextChanged(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btKembali_Click(object sender, EventArgs e)
        {
            Form_Home fr3 = new Form_Home();
            this.Dispose();
            fr3.ShowDialog();
        }

        private void Form_MyProfil_Load(object sender, EventArgs e)
        {
            MySqlCommand cmd, cmd2, cmdNama, cmdEmail, cmdNo, cmdTtl, cmdAlamat, cmdMotto;

            this.ControlBox = false;

            lblShowNis.Text = f1.getuid();
            //lblShowNis.Text = "55555";
            string cmd_nama = "select nama from siswa where NIS = '" + lblShowNis.Text + "'";
            string cmd_email = "select email from siswa where NIS = '" + lblShowNis.Text + "'";
            string cmd_no = "select no_hp from siswa where NIS = '" + lblShowNis.Text + "'";
            string cmd_ttl = "select ttl from siswa where NIS = '" + lblShowNis.Text + "'";
            string cmd_alamat = "select alamat from siswa where NIS = '" + lblShowNis.Text + "'";
            string cmd_motto = "select motto from siswa where NIS = '" + lblShowNis.Text + "'";

            cmdNama = new MySqlCommand(cmd_nama, con);
            cmdEmail = new MySqlCommand(cmd_email, con);
            cmdNo = new MySqlCommand(cmd_no, con);
            cmdTtl = new MySqlCommand(cmd_ttl, con);
            cmdAlamat = new MySqlCommand(cmd_alamat, con);
            cmdMotto = new MySqlCommand(cmd_motto, con);

            cmd = new MySqlCommand("select gambar from siswa where NIS='" + lblShowNis.Text + "'", con);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            cmd = new MySqlCommand("select gambar from siswa where NIS='00001'", con);
            MySqlDataAdapter da2 = new MySqlDataAdapter(cmd);
            DataSet ds2 = new DataSet();
            da2.Fill(ds2);


            con.Open();
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                if (row.IsNull("gambar"))
                {
                    MemoryStream ms = new MemoryStream((byte[])ds2.Tables[0].Rows[0]["gambar"]);
                    pbFoto.Image = new Bitmap(ms);
                    //pbFoto.Image = Image.FromFile("E:/ProfileKotak.png");
                }
                else if (ds.Tables[0].Rows.Count > 0)
                {
                    MemoryStream ms = new MemoryStream((byte[])ds.Tables[0].Rows[0]["gambar"]);
                    pbFoto.Image = new Bitmap(ms);
                }
            }
            con.Close();

            con.Open();
            MySqlDataReader DR1 = cmdNama.ExecuteReader();
            if (DR1.Read())
            {
                tbNama.Text = DR1.GetValue(0).ToString();
            }
            con.Close();

            con.Open();
            MySqlDataReader DR2 = cmdEmail.ExecuteReader();
            if (DR2.Read())
            {
                tbEmail.Text = DR2.GetValue(0).ToString();
            }
            con.Close();

            con.Open();
            MySqlDataReader DR3 = cmdNo.ExecuteReader();
            if (DR3.Read())
            {
                tbTelp.Text = DR3.GetValue(0).ToString();
            }
            con.Close();

            con.Open();
            MySqlDataReader DR4 = cmdTtl.ExecuteReader();
            if (DR4.Read())
            {
                dateTimePicker1.Text = DR4.GetValue(0).ToString();
            }
            con.Close();

            con.Open();
            MySqlDataReader DR5 = cmdAlamat.ExecuteReader();
            if (DR5.Read())
            {
                tbAlamat.Text = DR5.GetValue(0).ToString();
            }
            con.Close();

            con.Open();
            MySqlDataReader DR6 = cmdMotto.ExecuteReader();
            if (DR6.Read())
            {
                tbMotto.Text = DR6.GetValue(0).ToString();
            }
            con.Close();
        }
    }
}
