using gym.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gym
{
    public partial class trainers : Form
    {
        IControler controler;
        public trainers()
        {
            InitializeComponent();
            controler = new Controler(new Model());

        }

        private void button2_Click(object sender, EventArgs e)
        {
if (txt_id.Text == "")
                MessageBox.Show("לא הוכנסה תעודת זהות");

            else if (checkIsnumber(txt_id.Text) >= 0)
            
            {
               DataTable dt= controler.check_trainer11(txt_id.Text);
              
                if (dt.Rows.Count == 0)
                    MessageBox.Show("תעודת זהות לא קיימת במערכת");
                else
                {
                    txt_name.Text = dt.Rows[0][1].ToString();
                    txt_lastname.Text = dt.Rows[0][2].ToString();
                    txt_seniority.Text = dt.Rows[0][3].ToString();
                    string date = dt.Rows[0][4].ToString();
                    birth_date.Value = DateTime.Parse(date);
      
                    txt_phone.Text = dt.Rows[0][5].ToString();
                    txt_mail.Text = dt.Rows[0][6].ToString();
                    button1.Text = "עדכן מאמן";
                }
            }

            else
                MessageBox.Show("תעודת זהות לא תקינה");
            
        }

      

        private void button1_Click(object sender, EventArgs e)
        {
                int temp = checkIsnumber(txt_id.Text);
                if (temp >= 10000000 & temp <= 999999999)
                {
                    if (txt_id.Text == "" || txt_name.Text == "" || txt_lastname.Text == "" || txt_phone.Text == "" || txt_mail.Text == "" || txt_seniority.Text=="")
                        MessageBox.Show("יש למלא את כל השדות");
                    else
                    {
                        DataTable dt=controler.add_trainner(txt_id.Text);
                      
                        if (dt.Rows.Count != 0) //תעודת זהות במערכת- מחיקת פפרטים ישנים והכנסת הלקוח מחדש
                        {
                            controler.deleteTrainer(txt_id.Text);
                        }
                        //רשימת לקוח

                        bool ans = controler.add_trainner1(txt_id.Text, txt_name.Text, txt_lastname.Text, txt_seniority.Text, birth_date.Value, txt_phone.Text, txt_mail.Text);
                        if (ans)
                        {
 MessageBox.Show("עודכן בהצלחה");
                        button1.Text = "שמור מאמן";

                        txt_id.Text = "";
                        txt_name.Text = "";
                        txt_lastname.Text = "";
                        // txt_age.Text = "";
                        txt_seniority.Text = "";
                        }
                        else
                        {
                            MessageBox.Show("לא נשמר");
                            txt_id.Text = "";
                            txt_name.Text = "";
                            txt_lastname.Text = "";
                            // txt_age.Text = "";
                            txt_seniority.Text = "";

                        }



                        // .Text = dt.Rows[0][4].ToString();

                        txt_phone.Text = "";
                        txt_mail.Text = "";
                    }
                }
                else
                    MessageBox.Show("תעודת זהות לא תקינה");
                }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            this.Close();
            Main.m.Show();
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
        }
    }

