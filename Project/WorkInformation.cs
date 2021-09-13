using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class WorkInformation
    {
        Database mydb = new Database();

        public int ms { get; set; }
        public int autoIDWork()
        {
            SqlCommand command = new SqlCommand("select max(id) from WorkInfo ", mydb.getConnection);
            DataTable table = getWork(command);
            string strMax = table.Rows[0][0].ToString().Trim();
            if (strMax != "")
                return Convert.ToInt32(strMax) + 1;
            else return 1;
        }

        public bool insertInfoWork(string name, string desr, DateTime alarm, DateTime deadline, int per, int level)
        {
            SqlCommand comand = new SqlCommand("INSERT INTO WorkInfo (id, name, description, alarm_time, deadline, percentage, level_important)" +
                " VALUES (@id, @name, @desr, @alarm, @dead, @per, @level)", mydb.getConnection);
            comand.Parameters.Add("@id", SqlDbType.Int).Value = autoIDWork();
            comand.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;
            comand.Parameters.Add("@desr", SqlDbType.NVarChar).Value = desr ;
            comand.Parameters.Add("@alarm", SqlDbType.DateTime).Value = alarm;
            comand.Parameters.Add("@dead", SqlDbType.DateTime).Value = deadline;
            comand.Parameters.Add("@per", SqlDbType.Int).Value = per;
            comand.Parameters.Add("@level", SqlDbType.Int).Value = level;
            mydb.openConnection();
            if ((comand.ExecuteNonQuery() == 1))
            {
                mydb.closeConnection();
                return true;
            }
            else
            {
                mydb.closeConnection();
                return false;
            }
        }

        public bool insertInfoWorkById()
        {
            SqlCommand comand = new SqlCommand("INSERT INTO WorkInfo (id) VALUES (@id)", mydb.getConnection);

            this.ms = this.autoIDWork();
            comand.Parameters.Add("@id", SqlDbType.Int).Value = ms;
            mydb.openConnection();
            if ((comand.ExecuteNonQuery() == 1))
            {
                mydb.closeConnection();
                return true;
            }
            else
            {

                return false;
            }
        }

        public int returnID()
        {
            return this.ms;
        }

        public bool UpdateInfoWork(int id, string name, string desr, DateTime alarm, DateTime deadline, int per, int level)
        {
            SqlCommand comand = new SqlCommand("UPDATE WorkInfo SET name = @name, description =  @desr, alarm_time = @alarm, deadline = @dead, percentage =  @per, level_important = @level WHERE id= @id", mydb.getConnection);

            comand.Parameters.Add("@id", SqlDbType.Int).Value = id;
            comand.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;
            comand.Parameters.Add("@desr", SqlDbType.NVarChar).Value = desr;
            comand.Parameters.Add("@alarm", SqlDbType.DateTime).Value = alarm;
            comand.Parameters.Add("@dead", SqlDbType.DateTime).Value = deadline;
            comand.Parameters.Add("@per", SqlDbType.Int).Value = per;
            comand.Parameters.Add("@level", SqlDbType.Int).Value = level;
            mydb.openConnection();
            if ((comand.ExecuteNonQuery() == 1))
            {
                mydb.closeConnection();
                return true;
            }
            else
            {
                mydb.closeConnection();
                return false;
            }
        }


        public bool UpdateInfoWorkNullClock(int id, string name, string desr, DateTime deadline, int per, int level)
        {
            SqlCommand comand = new SqlCommand("UPDATE WorkInfo SET name = @name, description =  @desr, alarm_time = NULL, deadline = @dead, percentage =  @per, level_important = @level WHERE id= @id", mydb.getConnection);

            comand.Parameters.Add("@id", SqlDbType.Int).Value = id;
            comand.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;
            comand.Parameters.Add("@desr", SqlDbType.NVarChar).Value = desr;
            comand.Parameters.Add("@dead", SqlDbType.DateTime).Value = deadline;
            comand.Parameters.Add("@per", SqlDbType.Int).Value = per;
            comand.Parameters.Add("@level", SqlDbType.Int).Value = level;
            mydb.openConnection();
            if ((comand.ExecuteNonQuery() == 1))
            {
                mydb.closeConnection();
                return true;
            }
            else
            {
                mydb.closeConnection();
                return false;
            }
        }

        public bool UpdateInfoWorkNullLine(int id, string name, string desr, DateTime alarm, int per, int level)
        {
            SqlCommand comand = new SqlCommand("UPDATE WorkInfo SET name = @name, description =  @desr, alarm_time = @alarm, deadline = NULL, percentage =  @per, level_important = @level WHERE id= @id", mydb.getConnection);

            comand.Parameters.Add("@id", SqlDbType.Int).Value = id;
            comand.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;
            comand.Parameters.Add("@desr", SqlDbType.NVarChar).Value = desr;
            comand.Parameters.Add("@alarm", SqlDbType.DateTime).Value = alarm;
            comand.Parameters.Add("@per", SqlDbType.Int).Value = per;
            comand.Parameters.Add("@level", SqlDbType.Int).Value = level;
            mydb.openConnection();
            if ((comand.ExecuteNonQuery() == 1))
            {
                mydb.closeConnection();
                return true;
            }
            else
            {
                mydb.closeConnection();
                return false;
            }
        }

        public bool deleteWork(int id)
        {
            SqlCommand command = new SqlCommand("DELETE FROM WorkInfo WHERE id= @id", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            mydb.openConnection();
            if ((command.ExecuteNonQuery() == 1))
            {
                mydb.closeConnection();
                return true;
            }
            else
            {
                mydb.closeConnection();
                return false;
            }
        }

        public DataTable getWork(SqlCommand command)
        {
            command.Connection = mydb.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public DataTable getAllWork()
        {
            SqlCommand command = new SqlCommand("SELECT * FROM WorkInfo", mydb.getConnection);
            return this.getWork(command);
        }

        public DataTable getWorkID(int id)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM WorkInfo WHERE id= @id", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            return this.getWork(command);
        }
    }
}
