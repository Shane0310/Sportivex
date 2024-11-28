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
    public partial class Locks : Form
    {
        public Locks()
        {
            InitializeComponent();
        }

        private void lb_Home_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void label26_Click(object sender, EventArgs e)
        {
            Locks locks = new Locks();
            locks.Show();
            this.Hide();
        }

        private void label25_Click(object sender, EventArgs e)
        {
            Helmets locks = new Helmets();
            locks.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Eyewear eyewear = new Eyewear();
            eyewear.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Pedals pedals = new Pedals();
            pedals.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Pumps pump = new Pumps();
            pump.Show();
            this.Hide();
        }
    }
}
