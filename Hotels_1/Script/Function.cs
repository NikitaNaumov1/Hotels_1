using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotels_1.Script
{
    class Function
    {
        public static MySqlConnection GetDBConnection(string host, int port, string database, string username, string password)
        {
            // Connection String.
            String connString = "Server=" + host + ";Database=" + database
                + ";port=" + port + ";User Id=" + username + ";password=" + password;

            MySqlConnection conn = new MySqlConnection(connString);

            return conn;
        }

        public static MySqlConnection GetDBConnection()
        {
            string host = "c9113991.beget.tech";
            int port = 3306;
            string database = "c9113991_hotel";
            string username = "c9113991_hotel";
            string password = "Naum228";

            return GetDBConnection(host, port, database, username, password);
        }


        MySqlConnection conn = GetDBConnection();

        public bool LoginUser(string login, string password)
        {
            bool flag = false;

            string sql = String.Format("SELECT * FROM clients WHERE login = @login AND pass = @pass");
            DataTable table = new DataTable();
            MySqlCommand command = new MySqlCommand(sql, conn);
            command.Parameters.Add("@login", MySqlDbType.VarChar).Value = login;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = password;
            conn.Open();
            MySqlDataReader sqldr = command.ExecuteReader();

            if (sqldr.HasRows)
                flag = true;

            conn.Close();

            return flag;
        }

        public bool RegUser(string id, string login, string password, string name, string phone)
        {
            bool flag = false;


            string sql = String.Format("INSERT INTO clients(id, login,pass,name,phone) VALUES (@id, @login,@pass,@name,@phone)");

            MySqlCommand command = new MySqlCommand(sql, conn);
            command.Parameters.Add("@id", MySqlDbType.VarChar).Value = id;
            command.Parameters.Add("@login", MySqlDbType.VarChar).Value = login;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = password;
            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = name;
            command.Parameters.Add("@phone", MySqlDbType.VarChar).Value = phone;
            conn.Open();
            if (command.ExecuteNonQuery() == 1)
            {
                flag = true;
                conn.Close();
            }
            return flag;

        }
        public bool Bronir(string name, string family, string otch, string birth, string pasp, string kolvo, string zaezd, string viezd, string typ, string phone )
        {
            bool flag = false;
            


            string sql = String.Format("INSERT INTO Bronirovanie(name,family,otch,birth,pasp,kolvo,zaezd,viezd,typ,phone) VALUES (@name,@family,@otch,@birth,@pasp,@kolvo,@zaezd,@viezd,@typ,@phone)");

            MySqlCommand command = new MySqlCommand(sql, conn);
            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = name;
            command.Parameters.Add("@family", MySqlDbType.VarChar).Value = family;
            command.Parameters.Add("@otch", MySqlDbType.VarChar).Value = otch;
            command.Parameters.Add("@birth", MySqlDbType.VarChar).Value = birth;
            command.Parameters.Add("@pasp", MySqlDbType.VarChar).Value = pasp;
            command.Parameters.Add("@kolvo", MySqlDbType.VarChar).Value = kolvo;
            command.Parameters.Add("@zaezd", MySqlDbType.VarChar).Value = zaezd;
            command.Parameters.Add("@viezd", MySqlDbType.VarChar).Value = viezd;
            command.Parameters.Add("@typ", MySqlDbType.VarChar).Value = typ;
            command.Parameters.Add("@phone", MySqlDbType.VarChar).Value = phone;
            conn.Open();
            if (command.ExecuteNonQuery() == 1)
            {
                flag = true;
                conn.Close();
            }
            return flag;

        }
    }
}
