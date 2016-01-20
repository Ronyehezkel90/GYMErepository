using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gym.model
{
    interface IModel
    {
         void ExecuteNonQuery(string query);
         DataTable ExecuteDataTable(string query);



    }
}
