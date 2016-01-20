using gym.view;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gym
{
    public partial class Main : Form
    {
        Dictionary<string, int> dict;
        public static Main m;
        public Main()
        {
            m = this;
            InitializeComponent();
            dict = new Dictionary<string, int>();
            dict.Add("Client", 0);
            dict.Add("Secretery", 1);
            dict.Add("Purchasing Manager", 2);
            dict.Add("Trainer", 3);
            dict.Add("Marketing Manager", 4);
            dict.Add("General Manager", 5);
        }

        private void Main_Load(object sender, EventArgs e)
        {
            //CheckGit
        }
        //CheckGit2
        private void button1_Click(object sender, EventArgs e)
        {
            if (!dict.ContainsKey(comboBox1.Text))
            {
                MessageBox.Show("Please choose Role first.");
            }
            else if (comboBox1.Text=="Client")
            {
                this.Visible = false;
                    Clients clients = new Clients();
                    clients.Show();  
            }
            else if (textBox1.Text != dict[comboBox1.Text].ToString())
            {
                MessageBox.Show("Wrong Password");
            }
            else
            {
                this.Visible = false;
                if (comboBox1.Text=="Secretery")
                {
                    Secretery secretery = new Secretery();
                    secretery.Show();  
                }
                else if (comboBox1.Text=="General Manager")
                {
                    General_Manager gm = new General_Manager();
                    gm.Show();
                }
                else if (comboBox1.Text == "Trainer")
                {
                    Trainer t = new Trainer();
                    t.Show();
                }
                else if (comboBox1.Text == "Trainer")
                {
                    Client client = new Client();
                    client.Show();
                }
                else if (comboBox1.Text == "Marketing Manager")
                {
                    MarketingManager mm = new MarketingManager();
                    mm.Show();
                }
                else if (comboBox1.Text == "Purchasing Manager")
                {
                    PurchasingManager pm = new PurchasingManager();
                    pm.Show();
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text=="Client")
            {
               label3.Text = "Client can Log In without password"; 
            }

            else label3.Text = "The Password For " + comboBox1.Text + " Is: " + dict[comboBox1.Text];
        }

    }
}
