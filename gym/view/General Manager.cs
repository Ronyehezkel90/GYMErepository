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
    public partial class General_Manager : Form
    {
        public General_Manager()
        {
            InitializeComponent();
        }

        private void Marketing_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            MarketingManager mm = new MarketingManager();
            mm.Show();
        }

        private void Purchasing_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            PurchasingManager pm = new PurchasingManager();
            pm.Show();
        }

        private void Secretery_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Secretery secretery = new Secretery();
            secretery.Show();  
        }

        private void Trainer_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Trainer t = new Trainer();
            t.Show();
        }

        private void Client_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Client client = new Client();
            client.Show();
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            this.Close();
            Main.m.Show();
        }
    }
}
