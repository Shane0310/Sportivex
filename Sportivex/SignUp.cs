using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sportivex
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string dbcredentials = "server=localhost;database=sportivex;userid=root;password=''";
            MySqlConnection conn = new MySqlConnection(dbcredentials);
            conn.Open();

            MySqlCommand sql = new MySqlCommand("INSERT INTO users (username, email, password) " +
                                      " VALUES (@username, @email, @password)", conn);

            sql.Parameters.AddWithValue("@username", X_username.Text);
            sql.Parameters.AddWithValue("@email", X_email.Text);
            sql.Parameters.AddWithValue("@password", X_password.Text);
            

            if (sql.ExecuteNonQuery() > 0)
            {
                SignIn signup = new SignIn();
                signup.Show();
                this.Hide();
            }

            conn.Close();
        }

        

        private void X_password_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void Sign_in_Click(object sender, EventArgs e)
        {
            SignIn signup = new SignIn();
            signup.Show();
            this.Hide();
        }
    }
}
