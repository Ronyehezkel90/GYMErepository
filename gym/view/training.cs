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
    public partial class training : Form
    {
        IControler controler;
        public training()
        {
            InitializeComponent();
            this.controler = new Controler(new Model());
        }



        private void button2_Click(object sender, EventArgs e)
        {
            if (txt_code.Text == "")
                MessageBox.Show("לא הוכנס קוד אימון");
            else
                if(checkIsnumber(txt_code.Text)==-1)
                    MessageBox.Show("קוד אימון לא תקין");

            else
            {
               DataTable dt = controler.get_trainnig(txt_code.Text);
                if (dt.Rows.Count == 0)
                    MessageBox.Show("קוד אימון לא קיים במערכת");
                else
                {
                    txt_name.Text = dt.Rows[0][1].ToString();

                    txt_participent.Text = dt.Rows[0][2].ToString();
                    txt_type.Text = dt.Rows[0][3].ToString();
                    txt_id.Text = dt.Rows[0][4].ToString();
                    textBox1.Text = dt.Rows[0][5].ToString();
                    txt_hours.Text = dt.Rows[0][6].ToString();
                    txt_room.Text = dt.Rows[0][8].ToString();

                    button1.Text = "עדכן חוג ";
                }
            }
        }

 
    

        private void button1_Click_1(object sender, EventArgs e)
        {
          
                     if (txt_id.Text == "")
                MessageBox.Show("חובה להכניס מאמן ");
            else
                if (txt_code.Text == "")
                    MessageBox.Show("חובה להכניס קוד חוג ");
                else
                    if (txt_room.Text == "")
                        MessageBox.Show("חובה להכניס קוד אולם ");
                else
                        if (checkIsnumber(txt_code.Text) >= 0 & checkIsnumber(txt_participent.Text) >= 0 & checkIsnumber(txt_id.Text) >= 0 & checkIsnumber(txt_room.Text)>=0)
                        {

                            DataTable dt = controler.get_trainer(txt_id.Text);
                               
                                if (dt.Rows.Count == 0) //מאמן לא קיים במערכת
                                {
                                    MessageBox.Show("מאמן לא קיים במערכת");
                                }
                                else
                                {
                                    dt = controler.get_room(txt_room.Text);
                                 
                                    if (dt.Rows.Count == 0) //מאמן לא קיים במערכת
                                    {
                                        MessageBox.Show("אולם לא קיים במערכת");
                                    }
                                    else
                                    {
                                        dt=controler.get_training(txt_code.Text);
                                      
                                        if (dt.Rows.Count != 0) //קוד במערכת- מחיקת פפרטים ישנים והכנסת אימון מחדש
                                        {
                                           
                                            controler.delete_training(txt_code.Text);
                                        }
                                        string ac="' ,'Active','";
                                        bool ans = controler.add_training(txt_code.Text, txt_name.Text, txt_participent.Text, txt_type.Text, txt_id.Text,textBox1.Text, txt_hours.Text,txt_room.Text);
                                        if (ans)
                                        {
     MessageBox.Show("עודכן בהצלחה");
                                        txt_id.Text = "";
                                        textBox1.Text = "";
                                       txt_hours.Text ="";
                                       txt_room.Text = "";
                                        txt_code.Text = "";
                                        txt_name.Text = "";
                                        txt_participent.Text = "";
                                        txt_type.Text = "";
                                        button1.Text = "שמור חוג";
                                        }
                                        else
                                        {
                                            MessageBox.Show("לא עודכן ");

                                        }
                                   
                                    }
                                }
                            
                        }
                        else
                        {
                            MessageBox.Show("שגיאה, יש להזין רק מספרים בשדות: קוד חוג, תעודת זהות מאמן, מספר משתתפים ואולם");
                        }
           
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
            catch(Exception re)
            {
            return -1;
        }
        }
    }
}
