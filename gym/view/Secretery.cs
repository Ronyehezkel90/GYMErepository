using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gym.view
{
    public partial class Secretery : Form
    {
        public Secretery()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            training t = new training();
            t.Show();
        }

        private void btn_clients_Click_1(object sender, EventArgs e)
        {
            this.Close();
            Clients c = new Clients();
            c.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
            trainers t = new trainers();
            t.Show();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            this.Close();
            RegisterActiveTraining r = new RegisterActiveTraining();
            r.Show();
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            this.Close();
            Main.m.Show();
        }
    }
}