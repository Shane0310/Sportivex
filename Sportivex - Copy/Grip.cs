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
    public partial class Grip : Form
    {
        public Grip()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lb_Home_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void grips_Click(object sender, EventArgs e)
        {
            Grip grips = new Grip();
            grips.Show();
            this.Hide();
        }

        private void helmet_Click(object sender, EventArgs e)
        {
            Helmets helmet = new Helmets();
            helmet.Show();
            this.Hide();
        }

        private void locks_Click(object sender, EventArgs e)
        {
            Locks locks = new Locks();
            locks.Show();
            this.Hide();
        }

        private void eyewear_Click(object sender, EventArgs e)
        {
            Eyewear eyewear = new Eyewear();
            eyewear.Show();
            this.Hide();
        }

        private void pedals_Click(object sender, EventArgs e)
        {
            Pedals pedals = new Pedals();
            pedals.Show();
            this.Hide();
        }

        private void pumps_Click(object sender, EventArgs e)
        {
            Pumps pump = new Pumps();
            pump.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (button1.Text.ToString() == "+")
            {
                button1.Text = "−";
              
            }
            else
            {
                button1.Text = "+";
                
            }
        }
    }
}
