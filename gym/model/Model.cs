using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gym.model
{
    class Model: IModel
    {

        public  void ExecuteNonQuery(string query)
        {
            string connectionString = gym.Properties.Settings.Default.DBconnection;
            OleDbConnection con = new OleDbConnection(connectionString);
            try
            {
                con.Open();
                OleDbCommand command = new OleDbCommand(query, con);

                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
        }


        public  DataTable ExecuteDataTable(string query)
        {
            string connectionString = gym.Properties.Settings.Default.DBconnection;
            OleDbConnection con = new OleDbConnection(connectionString);
            try
            {

                con.Open();
                OleDbCommand command = new OleDbCommand(query, con);
                OleDbDataAdapter tableAdapter = new OleDbDataAdapter(command);
                DataTable dt = new DataTable();
                tableAdapter.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
        }
    }
}
