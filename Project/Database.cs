using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class Database
    {
        SqlConnection strQuery = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Timetable;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

        // get the connection
        public SqlConnection getConnection
        {
            get
            {
                return strQuery;
            }
        }


        // open the connection
        public void openConnection()
        {
            if ((strQuery.State == ConnectionState.Closed))
            {
                strQuery.Open();
            }

        }


        // close the connection
        public void closeConnection()
        {
            if ((strQuery.State == ConnectionState.Open))
            {
                strQuery.Close();
            }

        }
    }
}
