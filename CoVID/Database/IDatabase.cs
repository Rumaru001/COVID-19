using MySql.Data.MySqlClient;
using System.Collections.Generic;

namespace CoVID
{
    public interface IDatabase
    {
        void OpenConnection();
        void CloseConnection();
        MySqlConnection GetConnection();
        void Insert(List<List<string>> list);
        void DeleteAll();
        void CreateTable();
        void DeleteTable();
        void Run(IDatabase database);
        MySqlDataReader GetReader(string selectQuery);
    }
}