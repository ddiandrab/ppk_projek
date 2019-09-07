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
    public partial class Form_Register : Form
    {
        static string connectionInfo = "datasource=localhost; port=3306; username=root; password=; database=projek_ppk;";
        MySqlConnection connect = new MySqlConnection(connectionInfo);

        Form_Login f1 = new Form_Login();

        public Form_Register()
        {
            InitializeComponent();
        }
        
        private void btnSubmit_Click(object sender, EventArgs e)
        {

            string query =
                "insert into siswa(NIS, nama, email, jurusan, kelas, password, no_hp, ttl, motto, alamat)" +
                " values ('" + tbNIS.Text + "', '" + tbNama.Text + "', '" + tbEmail.Text + "', '" +
                cbJurusan.Text + "', '" + cbKelas.Text + "','" + tbPass.Text + "', '" + tbNo.Text + "', " +
                "'" + dateTimePicker1.Value.Date.ToString("yyyyMMdd") + "', '" + tbMotto.Text + "', '" + tbAlamat.Text + "') ;";
            MySqlDataReader reader;

            Form_Login f1 = new Form_Login();

            try
            {
                connect.Open();
                MySqlCommand SQLCommand = new MySqlCommand(query, connect);
                
                if (tbNIS.TextLength > 5)
                {
                    MessageBox.Show("Panjang NIS tidak boleh lebih dari 5");
                }
                else if (tbNIS.Text.Equals("") || tbNama.Text.Equals("") || tbEmail.Equals("") || cbJurusan.Text.Equals("")
                    || cbKelas.Text.Equals("") || tbPass.Text.Equals("") || tbNo.Text.Equals("") || tbMotto.Text.Equals("")
                    || tbAlamat.Text.Equals(""))
                {
                    MessageBox.Show("Data harus terisi semua");
                }
                else
                {
                    reader = SQLCommand.ExecuteReader();
                    this.Dispose();
                    f1.ShowDialog();
                }
                //MessageBox.Show("Connected");*/
                connect.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("NIS sudah memiliki akun");
            }
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
            f1.ShowDialog();
        }

        private void Form_Register_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }
    }
}

