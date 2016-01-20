using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gym
{
    interface IControler
    {



        bool check_client(string p);

        System.Data.DataTable check_client_id(string p);

        bool addClient(string p1, string p2, string p3, DateTime dateTime, string medical, string p4, string p6, string p5, string date);

        System.Data.DataTable check_client11(string p);


        System.Data.DataTable check_trainer11(string p);

        System.Data.DataTable add_trainner(string p);

        void deleteTrainer(string p);

        bool add_trainner1(string p1, string p2, string p3, string p4, DateTime dateTime, string p5, string p6);

        System.Data.DataTable get_trainnig(string p);

        System.Data.DataTable get_trainer(string p);

        System.Data.DataTable get_room(string p);

        System.Data.DataTable get_training(string p);

        void delete_training(string p);

        bool add_training(string p1, string p2, string p3, string p4, string p5, string p6, string p7,string p8);

        System.Data.DataTable get_trainings();

        System.Data.DataTable get_client(string p);

        void update_train(int code, string p);

        System.Data.DataTable get_table(int code);

        System.Data.DataTable update_trainings(int code);

        System.Data.DataTable get_trainigTable();
    }
}
