using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace REMS
{
    internal class FUNC
    {
        DB_Connection connection = new DB_Connection();
        //insert
        public Boolean ExecQuery(MySqlCommand command)
        {


            command.Connection = connection.getConnection;

            connection.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                connection.closeConnection();
                return true;
            }
            else
            {
                connection.closeConnection();
                return false;
            }
        }


        //get data
        public  DataTable getData(MySqlCommand command)
        {
            command.Connection = connection.getConnection;


            MySqlDataAdapter adapter = new MySqlDataAdapter(command);

            DataTable table = new DataTable();

            adapter.Fill(table);

            return table;
        }

    }
}
