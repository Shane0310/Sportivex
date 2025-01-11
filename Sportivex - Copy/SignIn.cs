using MySql.Data.MySqlClient;
using Sportivex;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Sportivex
{
    public partial class SignIn : Form
    {
        public SignIn()
        {
            InitializeComponent();
        }

        private void Sign_in_Click(object sender, EventArgs e)
        {
            string dbcredentials = "server=localhost;database=sportivex;userid=root;password=''";
            MySqlConnection conn = new MySqlConnection(dbcredentials);
            conn.Open();
            MySqlCommand sql = new MySqlCommand("SELECT * FROM users " +
                              "WHERE username='" + S_username.Text + "' AND " +
                              "password='" + S_password.Text + "' LIMIT 1;", conn);
            MySqlDataReader reader = sql.ExecuteReader();


            if (reader.Read())

            {
                Home signin = new Home();
                signin.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password");
            }
            conn.Close();
        }

        private void register_Click(object sender, EventArgs e)
        {
            SignUp signUp = new SignUp();
            signUp.Show();
            this.Hide();
        }

        private void SignIn_Load(object sender, EventArgs e)
        {

        }

        private void SignIn_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}

