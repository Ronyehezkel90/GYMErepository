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
    public partial class RegisterActiveTraining : Form
    {
        IControler controler;
        public RegisterActiveTraining()
        {
            
            InitializeComponent();
          //  activetraining.Visible = false;

           this.controler = new Controler(new Model());

           DataTable dt = controler.get_trainings();
            activetraining.Visible = true;
            activetraining.DataSource = dt;
        }


        private void activetraining_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int code=-1;
            if (e.RowIndex > -1 && activetraining.Rows[e.RowIndex].Cells[1].Value != null)
            {
                code = Int32.Parse(activetraining.Rows[e.RowIndex].Cells[1].Value.ToString());

                int temp = checkIsnumber(txt_id.Text);
                if (txt_id.Text == "")
                    MessageBox.Show("חובה להכניס תעודת זהות ");
                else

                    if (temp >= 10000000 & temp <= 999999999)
                    {
                        DataTable dt = controler.get_client(txt_id.Text);
                       
                        if (dt.Rows.Count == 0) //לקוח לא קיים במערכת
                        {
                            MessageBox.Show("לקוח לא קיים במערכת");
                        }
                        else
                        {
                            DateTime date = DateTime.Parse(dt.Rows[0][8].ToString());
                            if (dt.Rows[0][5].ToString() == "3")
                            {
                                if (date.AddMonths(3) < DateTime.Now)
                                {
                                    MessageBox.Show("מנוי לא בתוקף");
                                    return;
                                }
                            }
                            else
                                if (dt.Rows[0][5].ToString() == "6")
                                {
                                    if (date.AddMonths(6) < DateTime.Now)
                                    {
                                        MessageBox.Show("מנוי לא בתוקף");
                                        return;
                                    }
                                }
                                else

                                    if (date.AddMonths(12) < DateTime.Now)
                                    {
                                        MessageBox.Show("מנוי לא בתוקף");
                                        return;
                                    }

                                          controler.update_train(code, txt_id.Text);
        
                                            MessageBox.Show("עודכן בהצלחה");
                                            dt = controler.get_table(code);
                                           
                                            if (dt.Rows.Count > Int32.Parse(activetraining.Rows[e.RowIndex].Cells[3].Value.ToString()))
                                            {
                                                dt = controler.update_trainings(code);
                                                dt = controler.get_trainigTable();
                                                
                                                activetraining.Visible = true;
                                                activetraining.DataSource = dt;
                                            }
                                        }

                    
                    }
                    else
                        MessageBox.Show("תעודת זהות מתאמן לא תקינה");

                txt_id.Text = "";
            }
                    
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
        private void button2_Click_1(object sender, EventArgs e)
        {
       
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            this.Close();
            Main.m.Show();
        }

    }
}