namespace Sportivex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //SignIn form1 = new SignIn();
            //form1.Show();
            //this.Hide();
            SignIn signin = new SignIn();
            signin.Show();
            this.Hide();

        }
    }
}
