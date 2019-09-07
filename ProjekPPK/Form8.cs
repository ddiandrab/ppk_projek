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
    public partial class Form8 : Form
    {
        Form_IPA frm5 = new Form_IPA();
        Form_IPS frm6 = new Form_IPS();
        Form_BHS frm7 = new Form_BHS();
        public static string dari;
        public static string ShowNis;
        public Form8(string d)
        {
            InitializeComponent();
            dari = d;
        }

        MySqlConnection con = new MySqlConnection("datasource=localhost; port=3306; username=root; password=; database=projek_ppk;");

        private void Form8_Load(object sender, EventArgs e)
        {            
            MySqlCommand cmd, cmdNama, cmdEmail, cmdNo, cmdTtl, cmdAlamat, cmdMotto;

            this.ControlBox = false;

            if (dari == "form7") {
                ShowNis = frm7.getbio();
                lblShowNis.Text = frm7.getbio();
            }
            else if (dari == "form6")
            {
                ShowNis = frm6.getbio();
                lblShowNis.Text = frm6.getbio();
            }
            else if (dari == "form5")
            {
                ShowNis = frm5.getbio();
                lblShowNis.Text = frm5.getbio();
            }
            //lblShowNis.Text = "55555";
            string cmd_nama = "select nama from siswa where NIS = '" + ShowNis + "'";
            string cmd_email = "select email from siswa where NIS = '" + ShowNis + "'";
            string cmd_no = "select no_hp from siswa where NIS = '" + ShowNis+ "'";
            string cmd_ttl = "select ttl from siswa where NIS = '" + ShowNis+ "'";
            string cmd_alamat = "select alamat from siswa where NIS = '" + ShowNis + "'";
            string cmd_motto = "select motto from siswa where NIS = '" + ShowNis+ "'";

            cmdNama = new MySqlCommand(cmd_nama, con);
            cmdEmail = new MySqlCommand(cmd_email, con);
            cmdNo = new MySqlCommand(cmd_no, con);
            cmdTtl = new MySqlCommand(cmd_ttl, con);
            cmdAlamat = new MySqlCommand(cmd_alamat, con);
            cmdMotto = new MySqlCommand(cmd_motto, con);

            cmd = new MySqlCommand("select gambar from siswa where NIS='" + ShowNis + "'", con);
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
                tbTtl.Text = Convert.ToDateTime(DR4["ttl"]).ToString("dd/MM/yyyy");
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

        private void tbAlamat_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

    }
}
