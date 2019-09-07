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


namespace ProjekPPK
{
    public partial class Form_Login : Form
    {
        static string connectionInfo = "datasource=localhost; port=3306; username=root; password=; database=projek_ppk;";
        MySqlConnection connect = new MySqlConnection(connectionInfo);

        public static string UserID;

        public Form_Login()
        {
            InitializeComponent();
        }
        
        public string getuid()
        {
            return UserID;
        }
        
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string query =
                "select * from siswa where NIS = '" + tbNIS.Text + "';";
            MySqlDataReader reader;

            Form_Home f3 = new Form_Home();
            UserID = tbNIS.Text;

            try
            {
                connect.Open();
                MySqlCommand SQLCommand = new MySqlCommand(query, connect);
                reader = SQLCommand.ExecuteReader();
                int count = 0;
                while (reader.Read())
                {
                    count = count + 1;
                }
            
                if(count == 1 && tbPass.Text == reader["password"].ToString())
                {
                   this.Visible = false;
                   f3.Show();
                }
                else if (count == 1 && tbPass.Text != reader["password"].ToString())
                {
                    MessageBox.Show("Password Salah");
                }
                else if (count == 0)
                {
                    MessageBox.Show("Akun belum terdaftar");
                }
                connect.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form_Register f2 = new Form_Register();
            f2.ShowDialog();
        }

        private void Form_Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Form_Login_Load(object sender, EventArgs e)
        {
            this.AcceptButton = btnLogin;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
            {
                tbPass.PasswordChar = '\0';
            }
            else
            {
                tbPass.PasswordChar = '*';
            }
        }
    }
}
