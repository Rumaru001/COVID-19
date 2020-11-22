using MySql.Data.MySqlClient;
using System.Collections.Generic;

namespace CoVID
{
    class Database : IDatabase
    {
        MySqlConnection connection = new MySqlConnection("server=localhost;port=3306;username=root;password=root;database=info");

        public void OpenConnection() 
        {
            if (connection.State == System.Data.ConnectionState.Closed)
                connection.Open();
        }
        public void CloseConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
                connection.Close();
        }
        public MySqlConnection GetConnection()
        {
            return connection;
        }
        public void Insert(List<List<string>> list)
        {
            for (int j = 0; j < list[0].Count; j++)
            {
                string query = $"INSERT INTO countriesinfo2 (country, cases, deaths, recoveries) VALUES ('{list[0][j]}', '{list[1][j]}', '{list[2][j]}', '{list[3][j]}')";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.ExecuteNonQuery();
            }   
        }
        public void DeleteAll()
        {
            string query = "DELETE FROM countriesinfo2";
            MySqlCommand command = new MySqlCommand(query, connection);
            command.ExecuteNonQuery();
        }
        public void CreateTable()
        {
            string query = "CREATE TABLE `info`.`countriesinfo2` ( `country` VARCHAR(45) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL , `cases` VARCHAR(45) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL , `deaths` VARCHAR(45) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL , `recoveries` VARCHAR(45) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL ) ENGINE = MyISAM CHARSET=utf8 COLLATE utf8_general_ci;";
            MySqlCommand command = new MySqlCommand(query, connection);
            command.ExecuteNonQuery();
        }
        public void DeleteTable()
        {
            string query = "DROP TABLE countriesinfo2;"; 
            MySqlCommand command = new MySqlCommand(query, connection);
            command.ExecuteNonQuery();
        }
        public MySqlDataReader GetReader(string selectQuery)
        {
            MySqlCommand command = new MySqlCommand(selectQuery, connection);
            MySqlDataReader reader = command.ExecuteReader();
            return reader;
        }
        public void Run(IDatabase database)
        {
            database.OpenConnection();
            database.DeleteAll();
        }
    }
}
