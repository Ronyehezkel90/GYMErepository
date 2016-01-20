using gym.model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gym
{
    class Controler:IControler
    {
        IModel model;
        public Controler(IModel model)
        {
           this.model = model;
        }


  

   

        public bool check_client(string p)
        {
            try { 
            string query = "select * from clients where id=" + p;
            DataTable dt = model.ExecuteDataTable(query);
            if (dt.Rows.Count != 0) //תעודת זהות במערכת- מחיקת פפרטים ישנים והכנסת הלקוח מחדש
            {
               string date = dt.Rows[0][8].ToString();
                query = "Delete from clients where id=" + p;
                model.ExecuteNonQuery(query);
            }

}
            catch (Exception ee)
            {
                return false;
            }
            return true;
        }





        public DataTable check_client_id(string p)
        {
            DataTable dt;
            string query = "select * from clients where id=" + p;
           return   dt =model.ExecuteDataTable(query);
        }


        public bool addClient(string p1, string p2, string p3, DateTime dateTime, string medical, string p4,string p6, string p5, string date)
        {
            try
            {
                string query = "Insert Into Clients values (" + p1 + " ,'" + p2 + "' , '" + p3 + " ', '" + dateTime + "' , '" + medical + "','" + p4 + "','" + p6 + "','" + p5 + "','" + date + "')";
                model.ExecuteNonQuery(query);
            }
            catch (Exception ee)
            {
                return false;
            }
            return true;
        }


        public DataTable check_client11(string p)
        {
               string query = "select * from clients where id=" + p;
               return model.ExecuteDataTable(query);
        }




        public DataTable check_trainer11(string p)
        {
            string query = "select * from trainers where id=" + p;
            return model.ExecuteDataTable(query);
        }


        public DataTable add_trainner(string p)
        {
            string query = "select * from trainers where id=" + p;
              return model.ExecuteDataTable(query);
        }


        public void deleteTrainer(string p)
        {
           string query = "Delete from trainers where id=" + p;
           model.ExecuteNonQuery(query);
        }


        public bool add_trainner1(string p1, string p2, string p3, string p4, DateTime dateTime, string p5, string p6)
        {
            try
            {
            string query = "Insert Into trainers values (" + p1 + " ,'" + p2 + "' , '" + p3 + " ', '" + p4 + "','" + dateTime + "','" + p5 + "','" + p6 + "')";
            model.ExecuteNonQuery(query);

            }
            catch (Exception exx)
            {
                return false;
            }

            return true;
        }


        public DataTable get_trainnig(string p)
        {
            string query = "select * from trainings where code=" + p;
            return model.ExecuteDataTable(query);
        }


        public DataTable get_trainer(string p)
        {
            string query = "select * from trainers where id=" + p;
            return model.ExecuteDataTable(query);
        }


        public DataTable get_room(string p)
        {
           string query = "select * from room where code=" + p;
           return  model.ExecuteDataTable(query);
        }


        public DataTable get_training(string p)
        {
           string query = "select * from trainings where code=" +p;
            return model.ExecuteDataTable(query);
        }


        public void delete_training(string p)
        {
            string query = "Delete from trainings where code=" + p;
            model.ExecuteNonQuery(query);
        }


        public bool add_training(string p1, string p2, string p3, string p4, string p5, string p6, string p7,string s8)
        {
            try
            {
 string  query = "Insert Into trainings values (" + p1 + " ,'" +p2 + "' , '" + p3 + " ', '" +p4 + "' , '" + p5 + "' , '" + p6 + "' , '" + p7 + "' ,'Active','" + s8 + "')";
           model.ExecuteNonQuery(query);
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }


        public DataTable get_trainings()
        {
            string query = "select * from trainings where stat='active'";
            return model.ExecuteDataTable(query);
        }


        public DataTable get_client(string p)
        {
            string query = "select * from clients where id=" + p;
           return model.ExecuteDataTable(query);
        }


        public void update_train(int code, string p)
        {
            string query = "Insert Into trainingRegister values (" + code + " ," + p + ")";
             model.ExecuteNonQuery(query);
        }


        public DataTable get_table(int code)
        {
           string query = "select * from trainingRegister where code=" + code;
            return model.ExecuteDataTable(query);
        }


        public DataTable update_trainings(int code)
        {
          string  query = "UPDATE trainings set stat='Not Active' where code= " + code;
            return model.ExecuteDataTable(query);
        }


        public DataTable get_trainigTable()
        {
            string query = "select * from trainings where stat='active'";
           return model.ExecuteDataTable(query);
        }
    }
}
