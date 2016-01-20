using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using gym.model;

namespace gym
{
    public partial class Clients : Form
    {
        string date = "";
        IControler controler;
        public Clients()
        {
            InitializeComponent();
            button1.Text = "שמור מתאמן";
           this.controler = new Controler(new Model());
        }



        private void button1_Click(object sender, EventArgs e)
        {

            if (type.SelectedItem == null)
                MessageBox.Show("חובה לבחור סוג מנוי");

            else
            {
                int temp = checkIsnumber(txt_id.Text);
                if (temp >= 10000000 & temp <= 999999999)
                {
                    if (txt_id.Text == "" || txt_name.Text == "" || txt_lastname.Text == "" || txt_phone.Text == "" || txt_mail.Text == "")
                        MessageBox.Show("יש למלא את כל השדות");
                    else
                    {
                        bool if_exsits= controler.check_client(txt_id.Text);
                      
                        //רשימת לקוח
                        string medical = "";
                        if (checkBox1.Checked == true)
                            medical = "yes";
                        else
                            medical = "no";
                        string t;
                        if (type.SelectedIndex == 1)
                            t = "3";
                        else
                            if (type.SelectedIndex == 1)
                                t = "6";
                            else
                                t = "12";
                        if (date == "")
                            date = DateTime.Now.ToString();

                       bool ans= controler.addClient(txt_id.Text, txt_name.Text, txt_lastname.Text, birth_date.Value, medical,t, txt_phone.Text, txt_mail.Text, date);

                       if (ans)
                       {
                        MessageBox.Show("עודכן בהצלחה");
                        button1.Text = "שמור מתאמן";
                        button3.Visible = false;
                        date = "";
                        txt_id.Text = "";
                        txt_name.Text = "";
                        txt_lastname.Text = "";

                       }
                        //    birth_date.Value = null;
                       else {
                              MessageBox.Show("השמירה לא התבצעה");
                        }


                        checkBox1.Checked = false;


                        // .Text = dt.Rows[0][4].ToString();
                        type.SelectedIndex = 0;
                        txt_phone.Text = "";
                        txt_mail.Text = "";

                       

                        }
                    }
                else
                    MessageBox.Show("תעודת זהות לא תקינה");
                }
               

            }

        


        private void button2_Click(object sender, EventArgs e)
        {
            if (txt_id.Text == "")
                MessageBox.Show("לא הוכנסה תעודת זהות");

            else if (checkIsnumber(txt_id.Text) >= 0)
            {
                DataTable dt = controler.check_client_id(txt_id.Text);
                if (dt.Rows.Count == 0)
                    MessageBox.Show("תעודת זהות לא קיימת במערכת");
                else
                {
                    txt_name.Text = dt.Rows[0][1].ToString();
                    txt_lastname.Text = dt.Rows[0][2].ToString();
                    string date = dt.Rows[0][3].ToString();
                    birth_date.Value = DateTime.Parse(date);
                    string r = dt.Rows[0][4].ToString();
                    if (r == "yes")
                    {
                        checkBox1.Checked = true;
                    }
                    else
                        checkBox1.Checked = false;


                    // .Text = dt.Rows[0][4].ToString();
                    if (dt.Rows[0][5].ToString() == "3")
                        type.SelectedIndex = 0;
                    else
                        if (dt.Rows[0][5].ToString() == "6")
                            type.SelectedIndex = 1;
                        else

                            type.SelectedIndex = 2;

                    txt_phone.Text = dt.Rows[0][6].ToString();
                    txt_mail.Text = dt.Rows[0][7].ToString();
                    button1.Text = "עדכן מתאמן";
                    button3.Visible = true;
                }
            }
            else
                MessageBox.Show("תעודת זהות לא תקינה");
        }

   
  

        private void btnPrev_Click(object sender, EventArgs e)
        {
            Main.m.Visible = true;
            this.Close();
        }

        private int checkIsnumber(string t)
        {
            int i;
            try
            {
                i = Int32.Parse(t);
                if (i >= 0)
                    return i;
                else
                    return -1;
            }
            catch (Exception re)
            {
                return -1;
            }
        }

        private void Clients_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (txt_id.Text == "")
                MessageBox.Show("לא הוכנסה תעודת זהות");

            else if (checkIsnumber(txt_id.Text) >= 0)
            {
                DataTable dt = controler.check_client11(txt_id.Text);

                    
                if (dt.Rows.Count == 0)
                    MessageBox.Show("תעודת זהות לא קיימת במערכת");
                else
                {
                    date = dt.Rows[0][8].ToString();
                    int days = (int)(DateTime.Now.Subtract(DateTime.Parse(date)).TotalDays);
                    MessageBox.Show("המנוי פעיל " +days + "ימים");
                }
            }
        }
    }
}
